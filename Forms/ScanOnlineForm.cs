using AutoMapper;
using HZH_Controls;
using HZH_Controls.Forms;
using Microsoft.Extensions.Configuration;
using QualityCheckDemo;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WorkPlatForm.Public_Classes;

namespace ManualCheck.Forms
{
    public partial class ScanOnlineForm : FrmWithOKCancel1
    {
        private static string _workshopId;
        private static string _workshopCode;
        private static string _workshopName;
        private static string _equipmentId;
        private static string _equipmentCode;
        private static string _equipmentName;
        public ScanOnlineForm(long? staffId, string staffCode, string staffName)
        {
            _staffId = staffId;
            _staffCode = staffCode;
            _staffName = staffName;
            InitializeComponent();
        }
        public ScanOnlineForm(long? staffId, string staffCode, string staffName, string productBornCode)
        {
            _staffId = staffId;
            _staffCode = staffCode;
            _staffName = staffName;
            _productBornCode = productBornCode;
            InitializeComponent();
            ProductIDTxt.Text = _productBornCode;
        }
        public ScanOnlineForm(long? staffId, string staffCode, string staffName, string productBornCode, string workshopId, string workshopCode, string workshopName,
            string equipmentId, string equipmentCode, string equipmentName)
        {
            _staffId = staffId;
            _staffCode = staffCode;
            _staffName = staffName;
            _productBornCode = productBornCode;
            _workshopId = workshopId;
            _workshopCode = workshopCode;
            _workshopName = workshopName;
            _equipmentId = equipmentId;
            _equipmentCode = equipmentCode;
            _equipmentName = equipmentName;
            InitializeComponent();
            ProductIDTxt.Text = _productBornCode;
        }

        private static long? _staffId;
        private static string _staffCode;
        private static string _staffName;
        private static string _productBornCode;
        private static string _strProductType = "产品";
        private static C_CheckTask _currenChecktTask;
        public Action RegetProcedureTasksDetails;
        public Action<string, string, string, string> DisplayInfoToMainPanel;
        public Action ChangeBgColor;
        private void ScanOnline_Load(object sender, EventArgs e)
        {
            var addXmlFile = new ConfigurationBuilder().SetBasePath("E:\\project\\visual Studio Project\\ManualCheck")
                .AddXmlFile("config.xml");
            var configuration = addXmlFile.Build();
            _workshopId = configuration["WorkshopID"];
            _workshopCode = configuration["WorkshopCode"];
            _workshopName = configuration["WorkshopName"];
            _equipmentId = configuration["EquipmentID"];
            _equipmentCode = configuration["EquipmentCode"];
            _equipmentName = configuration["EquipmentName"];

            var tuple = new Tuple<string, string>("扫码上线", "A_fa_cube");
            var icon1 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple.Item2);
            var pictureBox1 = new PictureBox
            {
                AutoSize = false,
                Size = new Size(40, 40),
                ForeColor = Color.FromArgb(255, 77, 59),
                Image = FontImages.GetImage(icon1, 40, Color.FromArgb(255, 77, 59)),
                Location = new Point(this.Size.Width / 2 - 20, 30)
            };
            panel3.Controls.Add(pictureBox1);

            if (serialPortTest.IsOpen) { serialPortTest.Close(); }
            string portName = ConfigAppSettingsHelper.ReadSetting("PortName");
            string baudRate = ConfigAppSettingsHelper.ReadSetting("BaudRate");
            serialPortTest.Dispose();//释放扫描枪所有资源
            serialPortTest.PortName = portName;
            serialPortTest.BaudRate = int.Parse(baudRate);
            try
            {
                if (!serialPortTest.IsOpen)
                {
                    serialPortTest.Open();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        /// <summary>
        /// 扫描枪扫描调用方法
        /// </summary>
        /// <param name="serialPort"></param>
        /// <returns></returns>
        private static string GetDataFromSerialPort(SerialPort serialPort)
        {
            Thread.Sleep(300);
            byte[] buffer = new byte[serialPort.BytesToRead];
            string receiveString = "";
            try
            {
                serialPort.Read(buffer, 0, buffer.Length);
                foreach (var t in buffer)
                {
                    receiveString += (char)t;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            if (receiveString.Length > 2)
            {
                receiveString = receiveString.Substring(0, receiveString.Length - 1);
            }
            return receiveString;
        }
        //清空窗体textbox 解开只读限制
        private void ClearTxt()
        {
            BeginInvoke(new Action(() =>
            {
                ProductIDTxt.Clear();
                ProductIDTxt.ReadOnly = false;
                ProductNameTxt.Clear();
                ProductNameTxt.ReadOnly = false;
                _productBornCode = "";
            }));
        }
        private void serialPortTest_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            var receivedData = GetDataFromSerialPort(serialPortTest);

            if (CheckProductBornCode(receivedData))
            {
                CheckTaskValidity();
            }
        }
        private bool CheckProductBornCode(string receivedData)
        {
            using (var context = new Model())
            {
                BeginInvoke(new Action(() =>
                {
                    ProductIDTxt.Text = receivedData;
                    ProductIDTxt.ReadOnly = true;
                }));

                //在计划产品出生证表中根据产品出生证来获取产品名称(要添加一个状态)
                var aPlanProductInflammations = context.A_PlanProductInfomation.FirstOrDefault(s =>
                    s.ProductBornCode == receivedData && s.IsAvailable == true);

                if (aPlanProductInflammations != null)
                {
                    _productBornCode = receivedData;

                    //在检验任务表中根据有效性/产品出生证/检验类型(手检)/完成状态
                    var cCheckTasksDictionary = context.C_CheckTask.Where(s =>
                        s.IsAvailable == true && s.ProductBornCode == _productBornCode && s.CheckType == (decimal?)CheckType.Manual &&
                        s.TaskState == (decimal?)CheckTaskState.NotOnline).Select(s => s.ProcedureCode).ToList();

                    BeginInvoke(new Action(() =>
                    {
                        // comboBox1.Items.AddRange(cCheckTasksDictionary.ToArray());
                        ProductNameTxt.Text = aPlanProductInflammations.ProductName;
                        ProductNameTxt.ReadOnly = true;
                        ProductIDTxt.Text = receivedData;
                        ProductIDTxt.ReadOnly = true;
                        // comboBox1.Text = comboBox1.Items[0].ToString();
                    }));

                    return true;
                }
                BeginInvoke(new Action((() =>
                    FrmDialog.ShowDialog(this, "产品出生证不正确", "出生证不正确"))));
                ClearTxt();
                _productBornCode = "";
                return false;
            }
        }

        private bool CheckTaskValidity()
        {
            using (var context = new Model())
            {
                {
                    //在检验任务表里根据产品出生证以及设备编号/有效性/手检类型/以及任务完成状态 判断有无质检任务
                    var cCheckTask = context.C_CheckTask.First(s =>
                        s.ProductBornCode == _productBornCode &&
                        s.TaskState == (decimal?)CheckTaskState.NotOnline && s.IsAvailable == true &&
                        s.CheckType == (decimal?)CheckType.Manual);

                    if (cCheckTask == null)
                    {
                        BeginInvoke(new Action((() =>
                            FrmDialog.ShowDialog(this, "该加工中心暂无当前产品手检任务", "暂无手检任务"))));
                        ClearTxt();
                        return false;
                    }
                    return true;
                }
            }
        }
        public bool CheckTaskValidity(string procedureCode)
        {
            using (var context = new Model())
            {
                {
                    //在检验任务表里根据产品出生证以及设备编号/有效性/手检类型/以及任务完成状态 判断有无质检任务
                    var cCheckTask = context.C_CheckTask.First(s =>
                        s.ProductBornCode == _productBornCode && s.TaskState == (decimal?)CheckTaskState.NotOnline &&
                        s.IsAvailable == true && s.CheckType == (decimal?)CheckType.Manual);
                    if (cCheckTask == null)
                    {
                        BeginInvoke(new Action((() =>
                            FrmDialog.ShowDialog(this, "该加工中心暂无当前产品质检任务", "暂无质检任务"))));
                        ClearTxt();
                        return false;
                    }
                    return true;
                }
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            // _strProductType = comboBox1.Text;
        }
        protected override void DoEnter()
        {
            if (CheckProductBornCode(ProductIDTxt.Text.Trim()))
            {
                if (CheckTaskValidity())
                {
                    if (!DoneAllThreeCoordinate(ProductIDTxt.Text.Trim()))
                    {
                        FrmDialog.ShowDialog(this, "该产品尚有三坐标质检任务未完成,请先完成!");
                        return;
                    }
                    AddCntLogicPro();
                    {
                        //操作人员确认
                        if (WorkerConfirm())
                        {
                            //转档  检验任务表=>检验过程表
                            CheckProcessTurnArchives();
                            //完善检验任务表中的数据 诸如任务状态 ; 修改人修改时间
                            PerfectCheckTask();
                            //转档  
                            CntLogicTurn();
                            //刷新界面数据
                            RegetProcedureTasksDetails();
                        }
                    }
                }
            }
        }

        private bool DoneAllThreeCoordinate(string bornCode)
        {
            using (var context = new Model())
            {
                //在检验任务表里根据产品出生证/有效性/检验类型(三坐标)/完成情况 查询是否有未完成的
                var any = context.C_CheckTask.Any(s =>
                    s.ProductBornCode == bornCode && s.IsAvailable == true &&
                    s.CheckType == (decimal?)CheckType.ThreeCoordinate && s.TaskState != (decimal?)CheckTaskState.Completed);
                if (any)
                {
                    return false;
                }
                return true;
            }
        }

        public void PerfectCheckTask()
        {
            using (var context = new Model())
            {
                //在检验过程表中根据产品出生证拿到元数据(如果不是同时开始做一个产品出生证的三道工序的三坐标检验一般是没问题的)
                var cCheckProcessing = context.C_CheckProcessing.First(s => s.ProductBornCode == _productBornCode);
                var cCheckTask = context.C_CheckTask.First(s =>
                    s.ProductBornCode == _productBornCode && s.IsAvailable == true &&
                    s.PlanID == cCheckProcessing.PlanID &&
                    s.TaskState == (decimal?)CheckTaskState.NotOnline && s.CheckType == (decimal?)CheckType.Manual);

                cCheckTask.TaskState = (int?)CheckTaskState.InExecution;
                cCheckTask.ModifierID = _staffId;
                cCheckTask.LastModifiedTime = context.GetServerDate();

                context.SaveChanges();
            }
        }
        public void CntLogicTurn()
        {
            using (var context = new Model())
            {
                //在控制点过程表中 根据产品出生证 工序编号 控制点id 设备编号(需要修改) 查到相关集合
                var cBWuECntlLogicPros = context.C_BWuE_CntlLogicPro.Where(s =>
                        s.ProductBornCode == _productBornCode
                                                              && s.ControlPointID == 4 && s.EquipmentCode == _equipmentCode)
                    .OrderByDescending(s => s.StartTime).ToList();
                cBWuECntlLogicPros[0].State = "2";
                cBWuECntlLogicPros[0].FinishTime = context.GetServerDate();

                //遍历  添加后删除过程表中所有选中数据
                foreach (var cBWuECntlLogicPro in cBWuECntlLogicPros)
                {
                    var mapperConfiguration = new MapperConfiguration(cfg =>
                        cfg.CreateMap<C_BWuE_CntlLogicPro, C_BWuE_CntlLogicDoc>());
                    var mapper = mapperConfiguration.CreateMapper();
                    var cBWuECntlLogicDoc = mapper.Map<C_BWuE_CntlLogicDoc>(cBWuECntlLogicPro);

                    context.C_BWuE_CntlLogicDoc.Add(cBWuECntlLogicDoc);
                    context.C_BWuE_CntlLogicPro.Remove(cBWuECntlLogicPro);
                }
                context.SaveChanges();
            }
        }
        public void AddCntLogicPro(string procedureCode = "")
        {
            //录入进控制点过程表  哪个产品在哪个工序哪个控制点正在进行
            using (var context = new Model())
            {
                //在检验任务表里根据产品出生证以及设备编号/有效性/手检类型/以及任务完成状态 按照时间排序获得优先加工任务
                _currenChecktTask = context.C_CheckTask.FirstOrDefault(s =>
                     s.TaskState == (decimal?)CheckTaskState.NotOnline && s.IsAvailable == true &&
                    s.CheckType == (decimal?)CheckType.Manual && s.ProductBornCode == _productBornCode);

                var cBWuECntlLogicPro = new C_BWuE_CntlLogicPro
                {
                    ProductBornCode = _productBornCode,
                    ProcedureCode = "",
                    ControlPointID = 4,
                    Sort = "1",
                    EquipmentCode = _equipmentCode,
                    State = "1",
                    StartTime = context.GetServerDate(),
                    Remarks = "手检"
                };

                context.C_BWuE_CntlLogicPro.Add(cBWuECntlLogicPro);
                context.SaveChanges();
            }
        }
        //操作成员确认
        public bool WorkerConfirm()
        {
            using (var context = new Model())
            {
                var strings = _currenChecktTask.WorkerCode.Split(',');
                var contains = strings.Contains(_staffCode);
                if (!contains)
                {
                    var dialogResult = FrmDialog.ShowDialog(this, "手检人员与规定人员不一致,是否继续手检", "人员不匹配", true);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (!IsHighLevel())
                        {
                            var cInformationPushProcessing = new C_InfomationPushProcessing
                            {
                                //这里需要改动
                                // PushID = "push001",
                                PushCategory = "等级异常",
                                InitPushRankPushRank = "1",
                                PushContent = "手检质检环节人员操作等级未达要求",
                                CreateType = "现场发起",
                                PushState = 1,
                                CreateTime = context.GetServerDate(),
                                CreatorID = _staffId
                            };

                            context.C_InfomationPushProcessing.Add(cInformationPushProcessing);
                            context.SaveChanges();

                            BeginInvoke(new Action((() =>
                                FrmDialog.ShowDialog(this, "很抱歉,您的操作等级未能达到要求,已将消息推送至主管", "等级异常"))));
                            ClearTxt();
                            return false;
                        }
                        return true;
                    }
                    ClearTxt();
                    return false;
                }
                return true;
            }
        }
        private bool IsHighLevel()
        {
            bool b = false;
            using (var context = new Model())
            {
                var cStaffBaseInformation = context.C_StaffBaseInformation.FirstOrDefault(s =>
                    s.StaffCode == _staffCode && s.StaffName == _staffName && s.IsAvailable == true);
                int.TryParse(cStaffBaseInformation.SkillGrade, out var result);
                var strings = _currenChecktTask.WorkerCode.Split(',');
                foreach (var s1 in strings)
                {
                    var staffBaseInformation = context.C_StaffBaseInformation.FirstOrDefault(s => s.StaffCode == s1 && s.IsAvailable == true);

                    if (staffBaseInformation != null)
                    {
                        int.TryParse(staffBaseInformation.SkillGrade, out var result1);
                        if (result < result1)
                        {
                            return false;
                        }
                        if (result >= result1)
                        {
                            b = true;
                        }
                    }
                }
            }
            //这里需要改动
            return b;
        }
        public void CheckProcessTurnArchives()
        {
            using (var context = new Model())
            {
                var mapperConfiguration = new MapperConfiguration(cfg =>
                   cfg.CreateMap<C_CheckTask, C_CheckProcessing>());
                var mapper = mapperConfiguration.CreateMapper();
                var cCheckProcessing = mapper.Map<C_CheckProcessing>(_currenChecktTask);

                cCheckProcessing.OnlineStaffID = _staffId;
                cCheckProcessing.OnlineStaffCode = _staffCode;
                cCheckProcessing.OnlineStaffName = _staffName;
                cCheckProcessing.OnlineTime = context.GetServerDate();

                cCheckProcessing.ProcedureCode = "";
                cCheckProcessing.ProcedureID = "";
                cCheckProcessing.ProcedureName = "";
                cCheckProcessing.Reserve1 = "手检";

                cCheckProcessing.EquipmentCode = _equipmentCode;
                cCheckProcessing.EquipmentName = _equipmentName;
                cCheckProcessing.EquipmentID = _equipmentId;

                context.C_CheckProcessing.Add(cCheckProcessing);
                context.SaveChanges();

                FrmDialog.ShowDialog(this, $"产品{ProductIDTxt.Text}手检上线成功!", "手检上线成功");

                DisplayInfoToMainPanel(cCheckProcessing.ProductBornCode, cCheckProcessing.ProductName,
                    "手动检验", cCheckProcessing.OnlineTime.ToString());
                ChangeBgColor();

                Close();
                Dispose();
            }
        }
        private void ProductIDTxt_DoubleClick(object sender, EventArgs e)
        {
            if (CheckProductBornCode(ProductIDTxt.Text.Trim()))
            {
                CheckTaskValidity();
            }
        }
    }
}
