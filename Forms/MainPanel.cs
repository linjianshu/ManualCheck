using AutoMapper;
using HZH_Controls;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using MachineryProcessingDemo;
using Microsoft.Extensions.Configuration;
using QualityCheckDemo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ManualCheck.Forms
{
    public partial class MainPanel : FrmBase
    {
        public MainPanel(long? staffId, string staffCode, string staffName)
        {
            InitializeComponent();
            _staffId = staffId;
            _staffCode = staffCode;
            _staffName = staffName;
            EmployeeIDTxt.Text = staffCode;
            EmployeeNameTxt.Text = staffName;
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

        //图标间宽度
        private static int _widthX = 1300;
        //tuple计数器
        private static int _tupleI = 0;
        //全局静态只读tuple
        private static readonly List<Tuple<string, string>> MuneList = new List<Tuple<string, string>>()
        {
            new Tuple<string, string>("切换账号", "E_arrow_left_right_alt"),
            new Tuple<string, string>("退出", "A_fa_power_off"),
        };
        private static C_CheckProcessing _cCheckProcessing;
        private void MainPanel_Load(object sender, EventArgs e)
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

            //使用hzh控件自带的图标库 tuple
            //解析tuple 加载顶部菜单栏 绑定事件
            var switchAccountLabel = GenerateLabel();
            switchAccountLabel.Click += OpenLoginForm;

            var exitLabel = GenerateLabel();
            exitLabel.Click += CloseForms;

            // 加载人员信息图标
            var tuple1 = new Tuple<string, string>("人员信息", "A_fa_address_card_o");
            var icon1 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple1.Item2);
            var pictureBox1 = new PictureBox
            {
                AutoSize = false,
                Size = new Size(240, 160),
                ForeColor = Color.FromArgb(255, 77, 59),
                Image = FontImages.GetImage(icon1, 64, Color.FromArgb(255, 77, 59)),
                Location = new Point(110, 20)
            };
            PersonnelInfoPanel.Controls.Add(pictureBox1);

            // 加载箭头图标
            var tuple2 = new Tuple<string, string>("Arrow", "A_fa_arrow_down");
            var icon2 = (FontIcons)Enum.Parse(typeof(FontIcons), tuple2.Item2);
            int localY = 72;
            for (var i = 0; i < 2; i++)
            {
                ProductionStatusInfoPanel.Controls.Add(new PictureBox()
                {
                    AutoSize = false,
                    Size = new Size(40, 40),
                    ForeColor = Color.FromArgb(255, 77, 59),
                    Image = FontImages.GetImage(icon2, 40, Color.FromArgb(255, 77, 59)),
                    Location = new Point(270, localY)
                });
                localY += 98;
            }

            //修改自定义控件label.text文本
            CompletedTask1.label1.Text = " 已完成任务";
            ProductionTaskQueue1.label1.Text = "手检任务队列";

            InitialDidTasks();

            ucSignalLamp1.LampColor = new Color[] { Color.Green };
            ucSignalLamp2.LampColor = new Color[] { Color.Red };

            InialToDoTasks();

            //初始化生产状态信息面板
            using (var context = new Model())
            {
                //这里需要配置修改xml
                var cBBdbRCntlPntBases = context.C_BBdbR_CntlPntBase.Where(s =>
                        s.CntlPntTyp == 2.ToString() && s.Enabled == 1.ToString())
                    .OrderBy(s => s.CntlPntSort).ToList();

                int localLblY = 25;
                foreach (var cBBdbRCntlPntBase in cBBdbRCntlPntBases)
                {
                    var label = new Label()
                    {
                        Location = new Point(239, localLblY),
                        Size = new Size(112, 39),
                        Name = cBBdbRCntlPntBase.CntlPntCd,
                        BackColor = Color.LightSlateGray,
                        Font = new Font("微软雅黑", 10.8F, FontStyle.Bold,
                            GraphicsUnit.Point, ((byte)(134))),
                        Text = cBBdbRCntlPntBase.CntlPntNm,
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    if (label.Name.Equals("control001"))
                    {
                        label.Click += BeginQcEvent;
                    }
                    else if (label.Name.Equals("control002"))
                    {
                        label.Click += UpLoadReportEvent;
                    }
                    else if (label.Name.Equals("control003"))
                    {
                        label.Click += EndQcEvent;
                    }
                    ProductionStatusInfoPanel.Controls.Add(label);
                    localLblY += 96;
                }
            }

            //获取当前质检中心的质检任务(已上线)
            using (var context = new Model())
            {
                var cCheckProcessing = context.C_CheckProcessing.FirstOrDefault(s => s.EquipmentID == _equipmentId && s.OnlineTime != null);
                if (cCheckProcessing != null)
                {
                    ProductIDTxt.Text = cCheckProcessing.ProductBornCode;
                    ProductIDTxt.ReadOnly = true;
                    ProductNameTxt.Text = cCheckProcessing.ProductName;
                    ProductNameTxt.ReadOnly = true;
                    CurrentProcessTxt.Text = "手动检验";
                    CurrentProcessTxt.ReadOnly = true;
                    QCTimeTxt.Text = cCheckProcessing.OnlineTime.ToString();
                    QCTimeTxt.ReadOnly = true;
                    ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                        Color.MediumSeaGreen;
                }
                if (!string.IsNullOrEmpty(ProductIDTxt.Text))
                {
                    //在质检过程表中根据产品出生证  获取元数据
                    _cCheckProcessing = context.C_CheckProcessing.FirstOrDefault(s => s.ProductBornCode == ProductIDTxt.Text.Trim());
                }
            }

            //初始化判断质检文件上传完成与否
            ReportUploadJudge();

            timer1.Enabled = true;
        }
        private void EndQcEvent(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            var label = (Label)sender;
            if (label.BackColor == Color.MediumSeaGreen) return;
            if (string.IsNullOrEmpty(ProductIDTxt.Text))
            {
                FrmDialog.ShowDialog(this, "未检测到上线质检产品", "警告");
                return;
            }
            var backColor = ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor;
            if (backColor != Color.MediumSeaGreen)
            {
                FrmDialog.ShowDialog(this, "请先上传质检报告", "提示");
                return;
            }
            else
            {
                UploadCntLogicTurn();
            }
            OpenScanOfflineForm(out var isOk);
            if (isOk)
            {
                AddCntLogicProOffline("手检");
            }
        }
        private void InialToDoTasks()
        {
            //  自定义表格 装载图片等资源
            List<DataGridViewColumnEntity> lstColumns1 = new List<DataGridViewColumnEntity>
            {
                new DataGridViewColumnEntity()
                {
                    DataField = "ProductBornCode", HeadText = "产品出生证", Width = 35, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "ProductName", HeadText = "产品名称", Width = 15, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "CreateTime", HeadText = "预计开始时间", Width = 35, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "Reserve1", HeadText = "检验类型", Width = 15, WidthType = SizeType.Percent
                }
            };
            ucDataGridView2.Columns = lstColumns1;
            ucDataGridView2.ItemClick += UcDataGridView2_ItemClick;

            //拿到待加工产品排序集合
            var toDoProcedureTask = GetToDoProcedureTask();
            ucDataGridView2.DataSource = toDoProcedureTask;
        }

        private void InitialDidTasks()
        {
            // 自定义表格 装载图片等资源
            List<DataGridViewColumnEntity> lstColumns = new List<DataGridViewColumnEntity>
            {
                new DataGridViewColumnEntity()
                {
                    DataField = "ProductBornCode", HeadText = "产品出生证", Width = 40, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "ProductName", HeadText = "产品名称", Width = 20, WidthType = SizeType.Percent
                },
                new DataGridViewColumnEntity()
                {
                    DataField = "Reserve1", HeadText = "下机类型", Width = 35, WidthType = SizeType.Percent
                }
            };

            var didProcedureTask = GetDidProcedureTask();
            ucDataGridView1.Columns = lstColumns;
            ucDataGridView1.DataSource = didProcedureTask;
        }
        private void UcDataGridView2_ItemClick(object sender, DataGridViewEventArgs e)
        {
            ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                Color.LightSlateGray;
            ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor =
                Color.LightSlateGray;
            ProductionStatusInfoPanel.Controls.Find("control003", false).First().BackColor =
                Color.LightSlateGray;

            var controls = panel10.Controls.Find("scanOnlineForm", false);
            if (controls.Any())
            {
                controls[0].Dispose();
            }

            if (!HasExitProductTask())
            {
                ProductNameTxt.Clear();
                ProductIDTxt.Clear();
                CurrentProcessTxt.Clear();
                QCTimeTxt.Clear();

                var dataGridViewRow = ucDataGridView2.SelectRow;
                var dataSource = dataGridViewRow.DataSource;
                if (dataSource is C_CheckTask checktask)
                {
                    var dialogResult = FrmDialog.ShowDialog(this, $"确定上线选中产品[{checktask.ProductBornCode}]吗", "手检上线", true);
                    if (dialogResult == DialogResult.OK)
                    {
                        if (!DoneAllThreeCoordinate(checktask.ProductBornCode))
                        {
                            FrmDialog.ShowDialog(this, "该产品尚有三坐标质检任务未完成,请先完成!");
                            return;
                        }
                        var scanOnlineForm = new ScanOnlineForm(_staffId, _staffCode, _staffName,
                            checktask.ProductBornCode, _workshopId, _workshopCode, _workshopName, _equipmentId,
                            _equipmentCode, _equipmentName)
                        {
                            DisplayInfoToMainPanel = (s1, s2, s3, s4) =>
                            {
                                ProductIDTxt.Text = s1;
                                ProductNameTxt.Text = s2;
                                CurrentProcessTxt.Text = s3;
                                QCTimeTxt.Text = s4;
                            },
                            ChangeBgColor = () =>
                            {
                                ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                                    Color.MediumSeaGreen;
                                ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor =
                                    Color.LightSlateGray;
                                ProductionStatusInfoPanel.Controls.Find("control003", false).First().BackColor =
                                    Color.LightSlateGray;
                            }
                        };
                        if (scanOnlineForm.CheckTaskValidity(checktask.ProcedureCode))
                        {
                            scanOnlineForm.AddCntLogicPro(checktask.ProcedureCode);
                            {
                                //操作人员确认
                                if (scanOnlineForm.WorkerConfirm())
                                {
                                    //转档  检验任务表=>检验过程表
                                    scanOnlineForm.CheckProcessTurnArchives();
                                    //完善检验任务表 诸如任务状态 ; 修改人修改时间
                                    scanOnlineForm.PerfectCheckTask();
                                    //控制点转档  
                                    scanOnlineForm.CntLogicTurn();
                                    InialToDoTasks();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                    Color.MediumSeaGreen;
                ReportUploadJudge();
            }
        }
        private List<C_CheckTask> GetDidProcedureTask()
        {
            var cCheckTasks = new List<C_CheckTask>();
            using (var context = new Model())
            {
                //在检验任务表中根据设备编号/有效性/任务状态/质检类型(手检) 修改时间排序
                var checkTasks = context.C_CheckTask
                    .Where(s => s.IsAvailable == true && s.TaskState == (decimal?)CheckTaskState.Completed &&
                                s.CheckType == (decimal?)CheckType.Manual).OrderBy(s => s.LastModifiedTime).ToList();

                foreach (var cCheckTask in checkTasks)
                {
                    var cCheckProcessingDocument = context.C_CheckProcessingDocument.FirstOrDefault(s =>
                        s.ProductBornCode == cCheckTask.ProductBornCode && s.CheckType == (decimal?)CheckType.Manual &&
                        s.ProcedureCode == "");
                    cCheckTask.Reserve1 = cCheckProcessingDocument.Offline_type == (decimal?)OfflineType.Normal ? "正常下机" : "NG下机";
                }
                cCheckTasks.AddRange(checkTasks);
                return cCheckTasks;
            }
        }
        private List<C_CheckTask> GetToDoProcedureTask()
        {
            var cCheckTasks = new List<C_CheckTask>();
            using (var context = new Model())
            {
                //在质检任务表中根据设备编号/任务状态(没完成)/有效性/质检类型(手检) 按创建时间排个序(先创建的先排序)
                var checkTasks = context.C_CheckTask
                    .Where(s => s.TaskState != (decimal?)CheckTaskState.Completed && s.IsAvailable == true
                    && s.CheckType == (decimal?)CheckType.Manual)
                    .OrderBy(s => s.CreateTime).ToList();

                foreach (var cCheckTask in checkTasks)
                {
                    cCheckTask.Reserve1 = "手动检验";
                }
                cCheckTasks.AddRange(checkTasks);
                return cCheckTasks;
            }
        }
        private void ReportUploadJudge()
        {
            using (var context = new Model())
            {
                //在质检过程表中根据产品出生证  获取元数据
                _cCheckProcessing = context.C_CheckProcessing.FirstOrDefault(s => s.ProductBornCode == ProductIDTxt.Text.Trim());

                if (_cCheckProcessing != null)
                {
                    var any = context.C_CheckProcessing.Any(s =>
                        s.ProductBornCode == ProductIDTxt.Text.Trim() &&
                        s.ProcedureName == "" && s.CheckType == (decimal?)CheckType.Manual && s.CheckReportPath != null);
                    if (any)
                    {
                        ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor
                            = Color.MediumSeaGreen;
                    }
                }
            }
        }
        public bool HasExitProductTask()
        {
            using (var context = new Model())
            {
                //在质检过程表中根据设备编号/上线时间判断是否存在正在质检的任务
                var cCheckProcessing =
                    context.C_CheckProcessing.FirstOrDefault(s => s.OnlineTime != null && s.CheckType == (decimal?)CheckType.Manual);
                if (cCheckProcessing != null)
                {
                    FrmDialog.ShowDialog(this, "当前已有正在处理的质检任务,请完成", "已有质检任务");
                    return true;
                }
                return false;
            }
        }
        private void BeginQcEvent(object sender, EventArgs e)
        {
            var find = panel10.Controls.Find("scanOnlineForm", false);
            if (find.Any())
            {
                return;
            }
            ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                Color.LightSlateGray;
            ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor =
                Color.LightSlateGray;
            ProductionStatusInfoPanel.Controls.Find("control003", false).First().BackColor =
                Color.LightSlateGray;
            var exitProductTask = HasExitProductTask();
            if (!exitProductTask)
            {
                ProductNameTxt.Clear();
                ProductIDTxt.Clear();
                CurrentProcessTxt.Clear();
                QCTimeTxt.Clear();
                var scanOnlineForm = new ScanOnlineForm(_staffId, _staffCode, _staffName)
                {
                    DisplayInfoToMainPanel = (s1, s2, s3, s4) =>
                    {
                        ProductIDTxt.Text = s1;
                        ProductNameTxt.Text = s2;
                        CurrentProcessTxt.Text = s3;
                        QCTimeTxt.Text = s4;
                    },
                    ChangeBgColor = () =>
                    {
                        ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                                Color.MediumSeaGreen;
                        ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor =
                            Color.LightSlateGray;
                        ProductionStatusInfoPanel.Controls.Find("control003", false).First().BackColor =
                            Color.LightSlateGray;
                    },
                    RegetProcedureTasksDetails = () =>
                    {
                        InialToDoTasks();
                    }
                };
                var controls = scanOnlineForm.Controls.Find("lblTitle", false).First();
                controls.Visible = false;
                scanOnlineForm.Location = new Point(panel10.Width / 2 - scanOnlineForm.Width / 2, 0);
                scanOnlineForm.FormBorderStyle = FormBorderStyle.None;
                scanOnlineForm.AutoSize = false;
                scanOnlineForm.AutoScaleMode = AutoScaleMode.None;
                scanOnlineForm.Size = new Size(553, panel10.Height);
                scanOnlineForm.AutoScaleMode = AutoScaleMode.Font;
                scanOnlineForm.TopLevel = false;
                scanOnlineForm.BackColor = Color.FromArgb(247, 247, 247);
                scanOnlineForm.ForeColor = Color.FromArgb(66, 66, 66);
                panel10.Controls.Add(scanOnlineForm);
                scanOnlineForm.Show();
            }
            else
            {
                ProductionStatusInfoPanel.Controls.Find("control001", false).First().BackColor =
                    Color.MediumSeaGreen;
                ReportUploadJudge();
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
        private void UpLoadReportEvent(object sender, EventArgs e)
        {
            panel10.Controls.Clear();
            if (string.IsNullOrEmpty(ProductIDTxt.Text))
            {
                FrmDialog.ShowDialog(this, "未检测到上线质检产品", "警告");
                return;
            }
            using (var context = new Model())
            {
                //在质检加工过程表中根据产品出生证  获取元数据
                _cCheckProcessing = context.C_CheckProcessing.FirstOrDefault(s => s.ProductBornCode == ProductIDTxt.Text.Trim());
            }

            if (_cCheckProcessing != null)
            {
                AddUploadCntLogic("手检");
                var selectUploadFile = SelectUploadFile(out string filePath);
                if (selectUploadFile == DialogResult.OK)
                {
                    UploadFilePath(filePath);

                    //由于服务器炸裂 所以上传不了呜呜呜
                    // connectState("\\192.168.1.22", "administrator", "hfutIE100310#");
                    // var upLoadFile2 = UpLoadFile2(filePath, "ftp://zlr@192.168.1.22/ljsdemo/", "ZLR", "SA123", 1);
                    // if (!upLoadFile2)
                    // {
                    //     return;
                    // }
                    
                    ProductionStatusInfoPanel.Controls.Find("control002", false).First().BackColor =
                        Color.MediumSeaGreen;
                    FrmDialog.ShowDialog(this, "质检报告上传成功");
                }
            }
            else
            {
                FrmDialog.ShowDialog(this, "未检测到上线质检产品", "警告");
            }
        }
        private void AddUploadCntLogic(string remark)
        {
            using (var context = new Model())
            {
                var cBWuECntlLogicPro = new C_BWuE_CntlLogicPro
                {
                    ProcedureCode = "",
                    ProductBornCode = _cCheckProcessing.ProductBornCode,
                    ControlPointID = 5,
                    Sort = "2",
                    EquipmentCode = _equipmentCode,
                    State = "1",
                    StartTime = context.GetServerDate(),
                    Remarks = remark
                };
                context.C_BWuE_CntlLogicPro.Add(cBWuECntlLogicPro);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// 上传文件到共享文件夹
        /// </summary>
        /// <param name="sourceFile">本地文件</param>
        /// <param name="remoteFile">远程文件</param>
        public bool UpLoadFile(string sourceFile, string remoteFile, int islog)
        {
            //判断文件夹是否存在 ->不存在则创建
            var targetFolder = Path.GetDirectoryName(remoteFile);
            DirectoryInfo theFolder = new DirectoryInfo(targetFolder);
            if (theFolder.Exists == false)
            {
                theFolder.Create();
            }

            var flag = true;

            try
            {
                WebClient myWebClient = new WebClient();
                NetworkCredential cread = new NetworkCredential();
                myWebClient.Credentials = cread;

                using (FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        byte[] postArray = r.ReadBytes((int)fs.Length);
                        using (Stream postStream = myWebClient.OpenWrite(remoteFile))
                        {
                            if (postStream.CanWrite == false)
                            {
                                //LogUtil.Error($"{remoteFile} 文件不允许写入~");
                                if (islog > 0)
                                    // com.log("UpLoadFile", remoteFile + " 文件不允许写入~");
                                    flag = false;
                            }

                            postStream.Write(postArray, 0, postArray.Length);
                        }
                    }
                }

                return flag;
            }
            catch (Exception ex)
            {
                // string errMsg = $"{remoteFile}  ex:{ex.ToString()}";
                //LogUtil.Error(errMsg);
                //Console.WriteLine(ex.Message);
                if (islog > 0)
                    // com.log("UpLoadFile", "上传文件到共享文件夹：" + ex.Message);
                    return false;
            }
            return flag;
        }

        /// <summary>
        /// 连接远程共享文件夹
        /// </summary>
        /// <param name="path">远程共享文件夹的路径</param>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public static bool connectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();

                // string dosLine = "mstsc /v: 192.168.1.22 /console"; 
                string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                // string dosLine = "net use \\192.168.1.22 hfutIE100310# /user:administrator"; 

                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }
        /// <summary>
        /// 上传文件：要设置共享文件夹是否有创建的权限，否则无法上传文件
        /// </summary>
        /// <param name="fileNamePath">本地文件路径</param>
        /// <param name="urlPath">共享文件夹地址</param>
        /// <param name="User"></param>
        /// <param name="Pwd"></param>
        /// <param name="islog"></param>
        /// <returns></returns>
        public bool UpLoadFile2(string fileNamePath, string urlPath, string User, string Pwd, int islog)
        {
            var flag = false;
            string newFileName = fileNamePath.Substring(fileNamePath.LastIndexOf(@"\") + 1);//取文件名称
            // MessageBox.Show(newFileName);
            // if (urlPath.EndsWith(@"\") == false) urlPath = urlPath + @"\";


            var urlPath1 = urlPath + newFileName;


            WebClient myWebClient = new WebClient();
            NetworkCredential cread = new NetworkCredential(User, Pwd);
            myWebClient.Credentials = cread;

            // var webRequest = (FtpWebRequest)FtpWebRequest.Create(urlPath);
            // webRequest.UseBinary = true; 
            // webRequest.Credentials = cread;
            // webRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            // var webResponse = webRequest.GetResponse();


            FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);

            Stream postStream = null;
            try
            {
                byte[] postArray = r.ReadBytes((int)fs.Length);
                postStream = myWebClient.OpenWrite(urlPath1);

                if (!Directory.Exists(urlPath))
                {
                    // Directory.CreateDirectory(urlPath1);
                    // var directories = Directory.GetDirectories("ftp://zlr@192.168.1.22");
                    // var directoryInfo = new DirectoryInfo(@"ftp:/192.168.1.22\\ljsdemo1\");
                    // if (!directoryInfo.Exists)
                    // {
                    // directoryInfo.Create();
                    // }
                    // Directory.CreateDirectory("ljsdemo1");
                    // Directory.CreateDirectory(@"ftp:/zlr@192.168.1.22/ljsdemo1");
                }

                // postStream.m
                if (postStream.CanWrite)
                {
                    postStream.Write(postArray, 0, postArray.Length);
                    MessageBox.Show("文件上传成功！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flag = true;
                }
                else
                {
                    MessageBox.Show("文件上传错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = false;
                }

                postStream.Close();
                return flag;
            }
            catch (Exception ex)
            {
                // Close();
                return false;
                //MessageBox.Show(ex.Message, "错误");
                if (islog > 0)
                    // com.log("UpLoadFile", "上传文件到共享文件夹：" + ex.Message);
                    if (postStream != null)
                        postStream.Close();
                return false;
            }

        }
        private void UploadFilePath(string filePath)
        {
            using (var context = new Model())
            {
                //在质量数据表中根据计划号/产品出生证/工序编号/检验类型(手检)
                var cProductQualityData = context.C_ProductQualityData.FirstOrDefault(s =>
                    s.PlanID == _cCheckProcessing.PlanID && s.ProductBornCode == _cCheckProcessing.ProductBornCode &&
                    s.ProcedureCode == _cCheckProcessing.ProcedureCode && s.CheckType == (decimal?)CheckType.Manual);

                //如果找到了就更新操作 , 如果没找到就插入
                if (cProductQualityData != null)
                {
                    //这里有疑问
                    cProductQualityData.CheckReportPath = filePath;
                    cProductQualityData.CheckStaffName = _staffName;
                    cProductQualityData.CheckStaffCode = _staffCode;
                    context.SaveChanges();
                }
                else
                {
                    var mapperConfiguration = new MapperConfiguration(cfg =>
                          cfg.CreateMap<C_CheckProcessing, C_ProductQualityData>());
                    var mapper = mapperConfiguration.CreateMapper();
                    var productQualityData = mapper.Map<C_ProductQualityData>(_cCheckProcessing);

                    productQualityData.CreateTime = context.GetServerDate();
                    productQualityData.OnlineStaffCode = _staffCode;
                    productQualityData.OnlineStaffID = _staffId;
                    productQualityData.OnlineStaffName = _staffName;

                    //这里有疑问 如果需要修改的话, 机加工那边也需要修改
                    productQualityData.CheckStaffCode = _staffCode;
                    productQualityData.CheckStaffName = _staffName;

                    productQualityData.CheckReportPath = filePath;

                    context.C_ProductQualityData.Add(productQualityData);
                    context.SaveChanges();
                }

                context.Entry(_cCheckProcessing).State = EntityState.Modified;
                _cCheckProcessing.CheckReportPath = filePath;

                context.SaveChanges();
            }
        }
        private DialogResult SelectUploadFile(out string filePath)
        {
            filePath = "";
            var dialogResult = DialogResult.None;
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "请选择上传报告";
            openFileDialog.Filter = "所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                dialogResult = MessageBox.Show("已选择文件:" + filePath + ",确定上传该文件吗", "文件上传提示", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);
            }
            return dialogResult;
        }
        private void AddCntLogicProOffline(string remark = "")
        {
            using (var context = new Model())
            {
                var cBWuECntlLogicPro = new C_BWuE_CntlLogicPro
                {
                    ProductBornCode = ProductIDTxt.Text.Trim(),
                    ProcedureCode = "",
                    ControlPointID = 6,
                    Sort = "3",
                    EquipmentCode = _equipmentCode,
                    State = "1",
                    StartTime = context.GetServerDate(),
                    Remarks = remark
                };

                context.Entry(cBWuECntlLogicPro).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        private void OpenScanOfflineForm(out bool isOk)
        {
            var scanOfflineForm = new ScanOfflineForm(ProductIDTxt.Text.Trim(), _staffId, _staffCode, _staffName)
            {
                ChangeBgColor = () =>
                    ProductionStatusInfoPanel.Controls.
                        Find("control003", false).First().BackColor = Color.MediumSeaGreen,
                ClearMainPanelTxt = () =>
                {
                    ProductIDTxt.Clear();
                    CurrentProcessTxt.Clear();
                    ProductNameTxt.Clear();
                    QCTimeTxt.Clear();
                },
                RegetProcedureTasksDetails = () =>
                {
                    InitialDidTasks();
                    InialToDoTasks();
                }
            };
            var controls = scanOfflineForm.Controls.Find("lblTitle", false).First();
            controls.Visible = false;
            scanOfflineForm.Location = new Point(panel10.Width / 2 - scanOfflineForm.Width / 2, 0);
            scanOfflineForm.FormBorderStyle = FormBorderStyle.None;
            scanOfflineForm.AutoSize = false;
            scanOfflineForm.AutoScaleMode = AutoScaleMode.None;
            scanOfflineForm.Size = new Size(553, panel10.Height);
            scanOfflineForm.AutoScaleMode = AutoScaleMode.Font;
            scanOfflineForm.TopLevel = false;
            scanOfflineForm.BackColor = Color.FromArgb(247, 247, 247);
            scanOfflineForm.ForeColor = Color.FromArgb(66, 66, 66);
            panel10.Controls.Add(scanOfflineForm);
            scanOfflineForm.Show();
            isOk = true;
        }
        private void UploadCntLogicTurn(string remark = "")
        {
            using (var context = new Model())
            {
                //在控制点过程表中根据产品出生证/工序编号/控制点id/设备编号 按开始时间排序 获得list
                var bWuECntlLogicPros = context.C_BWuE_CntlLogicPro
                    .Where(s => s.ProductBornCode == _cCheckProcessing.ProductBornCode &&
                                s.ProcedureCode == "" && s.ControlPointID == 5 &&
                                s.EquipmentCode == _equipmentCode).OrderByDescending(s => s.StartTime).ToList();

                if (bWuECntlLogicPros.Any())
                {
                    bWuECntlLogicPros[0].State = "2";
                    bWuECntlLogicPros[0].FinishTime = context.GetServerDate();
                    bWuECntlLogicPros[0].Remarks = remark;
                }

                var mapperConfiguration = new MapperConfiguration(cfg =>
                                       cfg.CreateMap<C_BWuE_CntlLogicPro, C_BWuE_CntlLogicDoc>());
                var mapper = mapperConfiguration.CreateMapper();
                foreach (var cBWuECntlLogicPro in bWuECntlLogicPros)
                {
                    var cBWuECntlLogicDoc = mapper.Map<C_BWuE_CntlLogicDoc>(cBWuECntlLogicPro);
                    context.C_BWuE_CntlLogicDoc.Add(cBWuECntlLogicDoc);
                    context.C_BWuE_CntlLogicPro.Remove(cBWuECntlLogicPro);
                }

                context.SaveChanges();
            }
        }
        private void OpenLoginForm(object sender, EventArgs e)
        {
            // new UserLoginForm().Show();
            //
            // C_LoginInProcessing cLoginInProcessing;
            // using (var context = new Model())
            // {
            //     //在登陆过程表中根据员工id/设备id/下线时间非空 获得登陆过程信息
            //     cLoginInProcessing = context.C_LoginInProcessing.First(s =>
            //         s.StaffCode == EmployeeIDTxt.Text && s.EquipmentID.ToString() == _equipmentId && s.OfflineTime == null);
            //
            //     cLoginInProcessing.OfflineTime = context.GetServerDate();
            //     context.SaveChanges();
            // }
            // LoginUserTurnArchives(cLoginInProcessing);

            _tupleI = 0;
            _widthX = 1300;
            this.Close();
        }
        private void CloseForms(object sender, EventArgs e)
        {
            // C_LoginInProcessing cLoginInProcessing;
            // using (var context = new Model())
            // {
            //     cLoginInProcessing = context.C_LoginInProcessing.First(s =>
            //         s.StaffCode == EmployeeIDTxt.Text && s.EquipmentID.ToString() == _equipmentId && s.OfflineTime == null);
            //     cLoginInProcessing.OfflineTime = context.GetServerDate();
            //     context.SaveChanges();
            // }
            // LoginUserTurnArchives(cLoginInProcessing);
            Application.Exit();
        }
        private Label GenerateLabel()
        {
            var icon = (FontIcons)Enum.Parse(typeof(FontIcons), MuneList[_tupleI].Item2);
            var label = new Label
            {
                AutoSize = false,
                Size = new Size(90, 60),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.BottomCenter,
                ImageAlign = ContentAlignment.TopCenter,
                Margin = new Padding(5),
                Text = MuneList[_tupleI].Item1,
                Image = FontImages.GetImage(icon, 32, Color.White),
                Location = new Point(_widthX, 0),
                Font = new Font("微软雅黑", 12, FontStyle.Bold)
            };
            FirstTitlePanel.Controls.Add(label);
            _widthX += 90;
            _tupleI++;
            return label;
        }
        public void LoginUserTurnArchives(C_LoginInProcessing cLoginInProcessing)
        {
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.CreateMap<C_LoginInProcessing, C_LoginInDocument>());
            var mapper = mapperConfiguration.CreateMapper();
            var cLoginInDocument = mapper.Map<C_LoginInDocument>(cLoginInProcessing);
            using (var context = new Model())
            {
                //此处应该优化成事务操作 保证acid原则
                context.C_LoginInDocument.Add(cLoginInDocument);
                context.SaveChanges();
                context.Entry(cLoginInProcessing).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var toDoProcedureTask = GetToDoProcedureTask();
            ucDataGridView2.DataSource = toDoProcedureTask;
        }
    }

    public class TestGridModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public List<TestGridModel> Childrens { get; set; }
    }
}
