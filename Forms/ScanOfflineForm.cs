using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using HZH_Controls;
using HZH_Controls.Forms;
using Microsoft.Extensions.Configuration;
using QualityCheckDemo;

namespace ManualCheck.Forms
{
    public partial class ScanOfflineForm : FrmWithOKCancel1
    {
        public ScanOfflineForm(string productBornCode, long? staffId, string staffCode, string staffName)
        {
            _productBornCode = productBornCode;
            _staffId = staffId;
            _staffCode = staffCode;
            _staffName = staffName;
            InitializeComponent();
        }

        private static string _workshopId;
        private static string _workshopCode;
        private static string _workshopName;
        private static string _equipmentId;
        private static string _equipmentCode;
        private static string _equipmentName;
        private static long? _staffId;
        private static string _staffCode;
        private static string _staffName;
        private static string _productBornCode;
        private static C_CheckProcessing _cCheckProcessing;
        public Action ChangeBgColor;
        public Action ClearMainPanelTxt;
        public Action RegetProcedureTasksDetails;

        private void ScanOfflineForm_Load(object sender, EventArgs e)
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

            DataFill();
        }
        private void DataFill()
        {
            var tuple = new Tuple<string, string>("扫码下线", "A_fa_cube");
            FontIcons icon1 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple.Item2);
            var pictureBox1 = new PictureBox
            {
                AutoSize = false,
                Size = new Size(40, 40),
                ForeColor = Color.FromArgb(255, 77, 59),
                Image = FontImages.GetImage(icon1, 40, Color.FromArgb(255, 77, 59)),
                Location = new Point(this.Size.Width / 2 - 20, 15)
            };
            panel3.Controls.Add(pictureBox1);

            using (var context = new Model())
            {
                //在检验过程表中根据产品出生证获取元数据
                _cCheckProcessing = context.C_CheckProcessing.First(s => s.ProductBornCode == _productBornCode);
                BeginInvoke(new Action(() =>
                {
                    ProductIDTxt.Text = _productBornCode;
                    ProductIDTxt.ReadOnly = true;
                    ProductNameTxt.Text = _cCheckProcessing.ProductName;
                    ProductNameTxt.ReadOnly = true;
                }));
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NG下机")
            {
                BadReasonLbl.Visible = true;
                richTextBox1.Visible = true;
            }
            else
            {
                BadReasonLbl.Visible = false;
                richTextBox1.Visible = false;
            }
        }
        protected override void DoEnter()
        {
            if (IsFirstRecord())
            {
                //如果是NG下机 判断是否是首件 如果是首件记得修改首件档案表里的首件状态
                if (comboBox1.Text.Trim().Equals("NG下机"))
                {
                    {
                        //要在首件记录档案表里查到并且更新状态信息
                        PerfectFirstDocumentInfo(ProcedureFirstStatus.NG);
                    }
                }
                else
                {
                    PerfectFirstDocumentInfo(ProcedureFirstStatus.Qualified);
                }
            }
             
            //检验任务表里状态修改以及完善最后修改时间呀什么的
            PerfectCheckTask();
            //控制点转档
            OfflineCntLogicTurn();
            //完善产品质量数据表 补充下线人员姓名编号id
            PerfectProductQD();
            //检验过程表转档
            CheckProcessingDocTurn();
            FrmDialog.ShowDialog(this, "质检下线成功", "提示");
            ChangeBgColor();
            RegetProcedureTasksDetails();
            Close();
        }
        private void PerfectFirstDocumentInfo(ProcedureFirstStatus procedureFirstStatus)
        {
            using (var context = new Model())
            {
                //在首件档案表里根据计划号/产品出生证/工序编号/初始状态
                var cProcedureFirstDocument = context.C_ProcedureFirstDocument.FirstOrDefault(s =>
                    s.PlanID == _cCheckProcessing.PlanID && s.ProductBornCode == _cCheckProcessing.ProductBornCode &&
                    s.ProcedureCode == _cCheckProcessing.ProcedureCode && s.ProcedureFirstStatus == 0);
                if (cProcedureFirstDocument != null)
                {
                    //修改首件状态为合格/NG 
                    cProcedureFirstDocument.ProcedureFirstStatus = (int?)procedureFirstStatus;
                    context.SaveChanges();
                }
            }
        }
        private void PerfectCheckTask()
        {
            using (var context = new Model())
            {
                var cCheckTasks = context.C_CheckTask.First(s =>  s.PlanID == _cCheckProcessing.PlanID &&
                                                                 s.ProductBornCode == _cCheckProcessing.ProductBornCode &&
                                                                 s.TaskState == (int?)CheckTaskState.InExecution &&
                                                                 s.CheckType == (decimal?)CheckType.Manual
                                                                 && s.ProcedureCode == _cCheckProcessing.ProcedureCode && s.IsAvailable == true);
                cCheckTasks.TaskState = (int?)CheckTaskState.Completed;
                cCheckTasks.ModifierID = _staffId;
                cCheckTasks.LastModifiedTime = context.GetServerDate();
                context.Entry(cCheckTasks).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        private bool IsFirstRecord()
        {
            using (var context = new Model())
            {
                //在首件档案表里根据产品出生证/工序编号/计划号查找元数据
                var cProcedureFirstDocument = context.C_ProcedureFirstDocument.FirstOrDefault(s =>
                    s.ProductBornCode == _productBornCode && s.ProcedureCode == _cCheckProcessing.ProcedureCode && s.PlanID == _cCheckProcessing.PlanID);
                if (cProcedureFirstDocument != null)
                {
                    return true;
                }
                return false;
            }
        }
        private void PerfectProductQD()
        {
            using (var context = new Model())
            {
                //在产品质量数据表里根据产品出生证/计划号/下机人员为空/工序编号/检验类型(三坐标)
                var productQualityData = context.C_ProductQualityData.First(s => s.ProductBornCode == _cCheckProcessing.ProductBornCode &&
                                                                                 s.PlanID == _cCheckProcessing.PlanID && s.OfflineStaffID == null&&
                                                                                 s.ProcedureCode == _cCheckProcessing.ProcedureCode && s.CheckType ==(decimal?) CheckType.Manual);
                    // 
                productQualityData.OfflineStaffCode = _staffCode;
                productQualityData.OfflineStaffName = _staffName;
                productQualityData.OfflineStaffID = _staffId;
                context.SaveChanges();
            }
        }
        private void OfflineCntLogicTurn()
        {
            using (var context = new Model())
            {
                //在控制点过程表中根据设备编号/控制点id/产品出生证/工序编号 获取list
                var bWuECntlLogicPros = context.C_BWuE_CntlLogicPro
                    .Where(s => s.ProductBornCode == _cCheckProcessing.ProductBornCode  && s.ControlPointID == 6 &&
                                s.ProcedureCode==""&&
                                s.EquipmentCode == _equipmentCode).OrderByDescending(s => s.StartTime).ToList();
                if (bWuECntlLogicPros.Any())
                {
                    bWuECntlLogicPros[0].State = "2";
                    bWuECntlLogicPros[0].FinishTime = context.GetServerDate();

                    foreach (var cBWuECntlLogicPro in bWuECntlLogicPros)
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
        }
        private void CheckProcessingDocTurn()
        {
            using (var context = new Model())
            {
                _cCheckProcessing.OfflineTime = context.GetServerDate();
                _cCheckProcessing.OfflineStaffCode = _staffCode;
                _cCheckProcessing.OfflineStaffName = _staffName;
                _cCheckProcessing.OfflineStaffID = _staffId;

                if (comboBox1.Text.Trim().Contains("正常"))
                {
                    _cCheckProcessing.Offline_type = (int?)OfflineType.Normal;
                }
                else
                {
                    _cCheckProcessing.Offline_type = (int?)OfflineType.NG;
                    _cCheckProcessing.CauseDescription = richTextBox1.Text.Trim();
                }

                context.Entry(_cCheckProcessing).State = EntityState.Deleted;

                var mapperConfiguration = new MapperConfiguration(cfg =>
                    cfg.CreateMap<C_CheckProcessing, C_CheckProcessingDocument>());
                var mapper = mapperConfiguration.CreateMapper();
                var cCheckProcessingDocument = mapper.Map<C_CheckProcessingDocument>(_cCheckProcessing);
                context.C_CheckProcessingDocument.Add(cCheckProcessingDocument);
                context.SaveChanges();
            }
        }
    }
}
