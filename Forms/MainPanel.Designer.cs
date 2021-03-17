
using MachineryProcessingDemo;

namespace ManualCheck.Forms
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.TrademarkLbl = new System.Windows.Forms.Label();
            this.MachiningCenterLbl = new System.Windows.Forms.Label();
            this.graphicalOverlayComponent1 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.FirstTitlePanel = new System.Windows.Forms.Panel();
            this.graphicalOverlayComponent2 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.ProductInfo = new System.Windows.Forms.Label();
            this.SecondTitlePanel1 = new System.Windows.Forms.Panel();
            this.QCStatusInfoLbl = new System.Windows.Forms.Label();
            this.QCProductInfoLbl = new System.Windows.Forms.Label();
            this.PersonnelInfoLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProductionStatusInfoPanel = new System.Windows.Forms.Panel();
            this.QCTimeTxt = new System.Windows.Forms.TextBox();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.CurrentProcessTxt = new System.Windows.Forms.TextBox();
            this.QCTimeLbl = new System.Windows.Forms.Label();
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.CurrentProcessLbl = new System.Windows.Forms.Label();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.EmployeeNameTxt = new System.Windows.Forms.TextBox();
            this.EmployeeIDTxt = new System.Windows.Forms.TextBox();
            this.EmployeeNameLbl = new System.Windows.Forms.Label();
            this.EmployeeIDLbl = new System.Windows.Forms.Label();
            this.OnlineProductInfoPanel = new System.Windows.Forms.Panel();
            this.PersonnelInfoPanel = new System.Windows.Forms.Panel();
            this.SecondTitlePanel2 = new System.Windows.Forms.Panel();
            this.PlanInfoLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MachiningCenterStateLbl = new System.Windows.Forms.Label();
            this.ucSignalLamp2 = new HZH_Controls.Controls.UCSignalLamp();
            this.ServerStateLbl = new System.Windows.Forms.Label();
            this.ucSignalLamp1 = new HZH_Controls.Controls.UCSignalLamp();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ucDataGridView2 = new HZH_Controls.Controls.UCDataGridView();
            this.ucDataGridView1 = new HZH_Controls.Controls.UCDataGridView();
            this.ShiftPlanTxt = new System.Windows.Forms.TextBox();
            this.CompletedPlanTxt = new System.Windows.Forms.TextBox();
            this.ShiftPlanLbl = new System.Windows.Forms.Label();
            this.CompletedPlanLbl = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProductionTaskQueue1 = new MachineryProcessingDemo.ThridTitle();
            this.CompletedTask1 = new MachineryProcessingDemo.ThridTitle();
            this.ProductionTaskQueue = new MachineryProcessingDemo.ThridTitle();
            this.CompletedTask = new MachineryProcessingDemo.ThridTitle();
            this.GeneralTaskStatistics = new MachineryProcessingDemo.ThridTitle();
            this.FirstTitlePanel.SuspendLayout();
            this.SecondTitlePanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SecondTitlePanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrademarkLbl
            // 
            this.TrademarkLbl.AutoSize = true;
            this.TrademarkLbl.BackColor = System.Drawing.Color.Transparent;
            this.TrademarkLbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.TrademarkLbl.ForeColor = System.Drawing.Color.White;
            this.TrademarkLbl.Location = new System.Drawing.Point(34, 6);
            this.TrademarkLbl.Name = "TrademarkLbl";
            this.TrademarkLbl.Size = new System.Drawing.Size(161, 40);
            this.TrademarkLbl.TabIndex = 1;
            this.TrademarkLbl.Text = "SHINDEN";
            // 
            // MachiningCenterLbl
            // 
            this.MachiningCenterLbl.AutoSize = true;
            this.MachiningCenterLbl.BackColor = System.Drawing.Color.Transparent;
            this.MachiningCenterLbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.MachiningCenterLbl.ForeColor = System.Drawing.Color.White;
            this.MachiningCenterLbl.Location = new System.Drawing.Point(189, 20);
            this.MachiningCenterLbl.Name = "MachiningCenterLbl";
            this.MachiningCenterLbl.Size = new System.Drawing.Size(137, 40);
            this.MachiningCenterLbl.TabIndex = 1;
            this.MachiningCenterLbl.Text = "手动检验";
            // 
            // graphicalOverlayComponent1
            // 
            this.graphicalOverlayComponent1.Owner = null;
            // 
            // FirstTitlePanel
            // 
            this.FirstTitlePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.FirstTitlePanel.Controls.Add(this.TrademarkLbl);
            this.FirstTitlePanel.Controls.Add(this.MachiningCenterLbl);
            this.FirstTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.FirstTitlePanel.Name = "FirstTitlePanel";
            this.FirstTitlePanel.Size = new System.Drawing.Size(1358, 63);
            this.FirstTitlePanel.TabIndex = 3;
            // 
            // graphicalOverlayComponent2
            // 
            this.graphicalOverlayComponent2.Owner = null;
            // 
            // ProductInfo
            // 
            this.ProductInfo.Image = ((System.Drawing.Image)(resources.GetObject("ProductInfo.Image")));
            this.ProductInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProductInfo.Location = new System.Drawing.Point(627, 26);
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(65, 49);
            this.ProductInfo.TabIndex = 4;
            this.ProductInfo.Text = "汪汪";
            this.ProductInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SecondTitlePanel1
            // 
            this.SecondTitlePanel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SecondTitlePanel1.Controls.Add(this.QCStatusInfoLbl);
            this.SecondTitlePanel1.Controls.Add(this.QCProductInfoLbl);
            this.SecondTitlePanel1.Controls.Add(this.PersonnelInfoLbl);
            this.SecondTitlePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondTitlePanel1.Location = new System.Drawing.Point(0, 63);
            this.SecondTitlePanel1.Name = "SecondTitlePanel1";
            this.SecondTitlePanel1.Size = new System.Drawing.Size(1358, 44);
            this.SecondTitlePanel1.TabIndex = 5;
            // 
            // QCStatusInfoLbl
            // 
            this.QCStatusInfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QCStatusInfoLbl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.QCStatusInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QCStatusInfoLbl.ForeColor = System.Drawing.Color.White;
            this.QCStatusInfoLbl.Location = new System.Drawing.Point(1188, 11);
            this.QCStatusInfoLbl.Name = "QCStatusInfoLbl";
            this.QCStatusInfoLbl.Size = new System.Drawing.Size(362, 29);
            this.QCStatusInfoLbl.TabIndex = 1;
            this.QCStatusInfoLbl.Text = "质检状态信息";
            // 
            // QCProductInfoLbl
            // 
            this.QCProductInfoLbl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.QCProductInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QCProductInfoLbl.ForeColor = System.Drawing.Color.White;
            this.QCProductInfoLbl.Location = new System.Drawing.Point(588, 11);
            this.QCProductInfoLbl.Name = "QCProductInfoLbl";
            this.QCProductInfoLbl.Size = new System.Drawing.Size(163, 29);
            this.QCProductInfoLbl.TabIndex = 1;
            this.QCProductInfoLbl.Text = "质检产品信息";
            // 
            // PersonnelInfoLbl
            // 
            this.PersonnelInfoLbl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PersonnelInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonnelInfoLbl.ForeColor = System.Drawing.Color.White;
            this.PersonnelInfoLbl.Location = new System.Drawing.Point(136, 13);
            this.PersonnelInfoLbl.Name = "PersonnelInfoLbl";
            this.PersonnelInfoLbl.Size = new System.Drawing.Size(113, 29);
            this.PersonnelInfoLbl.TabIndex = 1;
            this.PersonnelInfoLbl.Text = "人员信息";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ProductionStatusInfoPanel);
            this.panel4.Controls.Add(this.ProductInfo);
            this.panel4.Controls.Add(this.QCTimeTxt);
            this.panel4.Controls.Add(this.ProductNameTxt);
            this.panel4.Controls.Add(this.CurrentProcessTxt);
            this.panel4.Controls.Add(this.QCTimeLbl);
            this.panel4.Controls.Add(this.ProductIDTxt);
            this.panel4.Controls.Add(this.ProductNameLbl);
            this.panel4.Controls.Add(this.CurrentProcessLbl);
            this.panel4.Controls.Add(this.ProductIDLbl);
            this.panel4.Controls.Add(this.EmployeeNameTxt);
            this.panel4.Controls.Add(this.EmployeeIDTxt);
            this.panel4.Controls.Add(this.EmployeeNameLbl);
            this.panel4.Controls.Add(this.EmployeeIDLbl);
            this.panel4.Controls.Add(this.OnlineProductInfoPanel);
            this.panel4.Controls.Add(this.PersonnelInfoPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1358, 291);
            this.panel4.TabIndex = 7;
            // 
            // ProductionStatusInfoPanel
            // 
            this.ProductionStatusInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductionStatusInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductionStatusInfoPanel.Location = new System.Drawing.Point(962, 0);
            this.ProductionStatusInfoPanel.Name = "ProductionStatusInfoPanel";
            this.ProductionStatusInfoPanel.Size = new System.Drawing.Size(396, 291);
            this.ProductionStatusInfoPanel.TabIndex = 7;
            // 
            // QCTimeTxt
            // 
            this.QCTimeTxt.BackColor = System.Drawing.Color.White;
            this.QCTimeTxt.Location = new System.Drawing.Point(592, 240);
            this.QCTimeTxt.Name = "QCTimeTxt";
            this.QCTimeTxt.Size = new System.Drawing.Size(168, 27);
            this.QCTimeTxt.TabIndex = 1;
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.BackColor = System.Drawing.Color.White;
            this.ProductNameTxt.Location = new System.Drawing.Point(592, 141);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(168, 27);
            this.ProductNameTxt.TabIndex = 1;
            // 
            // CurrentProcessTxt
            // 
            this.CurrentProcessTxt.BackColor = System.Drawing.Color.White;
            this.CurrentProcessTxt.Location = new System.Drawing.Point(592, 190);
            this.CurrentProcessTxt.Name = "CurrentProcessTxt";
            this.CurrentProcessTxt.Size = new System.Drawing.Size(168, 27);
            this.CurrentProcessTxt.TabIndex = 1;
            // 
            // QCTimeLbl
            // 
            this.QCTimeLbl.AutoSize = true;
            this.QCTimeLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QCTimeLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.QCTimeLbl.Location = new System.Drawing.Point(502, 242);
            this.QCTimeLbl.Name = "QCTimeLbl";
            this.QCTimeLbl.Size = new System.Drawing.Size(93, 26);
            this.QCTimeLbl.TabIndex = 0;
            this.QCTimeLbl.Text = "质检时间:";
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.BackColor = System.Drawing.Color.White;
            this.ProductIDTxt.Location = new System.Drawing.Point(592, 91);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(168, 27);
            this.ProductIDTxt.TabIndex = 1;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductNameLbl.Location = new System.Drawing.Point(502, 143);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(93, 26);
            this.ProductNameLbl.TabIndex = 0;
            this.ProductNameLbl.Text = "产品名称:";
            // 
            // CurrentProcessLbl
            // 
            this.CurrentProcessLbl.AutoSize = true;
            this.CurrentProcessLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentProcessLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CurrentProcessLbl.Location = new System.Drawing.Point(502, 192);
            this.CurrentProcessLbl.Name = "CurrentProcessLbl";
            this.CurrentProcessLbl.Size = new System.Drawing.Size(93, 26);
            this.CurrentProcessLbl.TabIndex = 0;
            this.CurrentProcessLbl.Text = "当前工序:";
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductIDLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductIDLbl.Location = new System.Drawing.Point(483, 92);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(112, 26);
            this.ProductIDLbl.TabIndex = 0;
            this.ProductIDLbl.Text = "产品出生证:";
            // 
            // EmployeeNameTxt
            // 
            this.EmployeeNameTxt.BackColor = System.Drawing.Color.White;
            this.EmployeeNameTxt.Location = new System.Drawing.Point(127, 180);
            this.EmployeeNameTxt.Name = "EmployeeNameTxt";
            this.EmployeeNameTxt.ReadOnly = true;
            this.EmployeeNameTxt.Size = new System.Drawing.Size(126, 27);
            this.EmployeeNameTxt.TabIndex = 1;
            // 
            // EmployeeIDTxt
            // 
            this.EmployeeIDTxt.BackColor = System.Drawing.Color.White;
            this.EmployeeIDTxt.Location = new System.Drawing.Point(127, 130);
            this.EmployeeIDTxt.Name = "EmployeeIDTxt";
            this.EmployeeIDTxt.ReadOnly = true;
            this.EmployeeIDTxt.Size = new System.Drawing.Size(126, 27);
            this.EmployeeIDTxt.TabIndex = 1;
            // 
            // EmployeeNameLbl
            // 
            this.EmployeeNameLbl.AutoSize = true;
            this.EmployeeNameLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EmployeeNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeNameLbl.Location = new System.Drawing.Point(37, 182);
            this.EmployeeNameLbl.Name = "EmployeeNameLbl";
            this.EmployeeNameLbl.Size = new System.Drawing.Size(93, 26);
            this.EmployeeNameLbl.TabIndex = 0;
            this.EmployeeNameLbl.Text = "员工姓名:";
            // 
            // EmployeeIDLbl
            // 
            this.EmployeeIDLbl.AutoSize = true;
            this.EmployeeIDLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EmployeeIDLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeIDLbl.Location = new System.Drawing.Point(37, 132);
            this.EmployeeIDLbl.Name = "EmployeeIDLbl";
            this.EmployeeIDLbl.Size = new System.Drawing.Size(93, 26);
            this.EmployeeIDLbl.TabIndex = 0;
            this.EmployeeIDLbl.Text = "员工编号:";
            // 
            // OnlineProductInfoPanel
            // 
            this.OnlineProductInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OnlineProductInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OnlineProductInfoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.OnlineProductInfoPanel.Location = new System.Drawing.Point(367, 0);
            this.OnlineProductInfoPanel.Name = "OnlineProductInfoPanel";
            this.OnlineProductInfoPanel.Size = new System.Drawing.Size(595, 291);
            this.OnlineProductInfoPanel.TabIndex = 5;
            // 
            // PersonnelInfoPanel
            // 
            this.PersonnelInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonnelInfoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonnelInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.PersonnelInfoPanel.Name = "PersonnelInfoPanel";
            this.PersonnelInfoPanel.Size = new System.Drawing.Size(367, 291);
            this.PersonnelInfoPanel.TabIndex = 6;
            // 
            // SecondTitlePanel2
            // 
            this.SecondTitlePanel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.SecondTitlePanel2.Controls.Add(this.PlanInfoLbl);
            this.SecondTitlePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondTitlePanel2.Location = new System.Drawing.Point(0, 398);
            this.SecondTitlePanel2.Name = "SecondTitlePanel2";
            this.SecondTitlePanel2.Size = new System.Drawing.Size(1358, 44);
            this.SecondTitlePanel2.TabIndex = 8;
            // 
            // PlanInfoLbl
            // 
            this.PlanInfoLbl.BackColor = System.Drawing.Color.MediumAquamarine;
            this.PlanInfoLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanInfoLbl.ForeColor = System.Drawing.Color.White;
            this.PlanInfoLbl.Location = new System.Drawing.Point(734, 9);
            this.PlanInfoLbl.Name = "PlanInfoLbl";
            this.PlanInfoLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlanInfoLbl.Size = new System.Drawing.Size(163, 29);
            this.PlanInfoLbl.TabIndex = 1;
            this.PlanInfoLbl.Text = "计划信息";
            this.PlanInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.MachiningCenterStateLbl);
            this.panel3.Controls.Add(this.ucSignalLamp2);
            this.panel3.Controls.Add(this.ServerStateLbl);
            this.panel3.Controls.Add(this.ucSignalLamp1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 788);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1358, 20);
            this.panel3.TabIndex = 9;
            // 
            // MachiningCenterStateLbl
            // 
            this.MachiningCenterStateLbl.AutoSize = true;
            this.MachiningCenterStateLbl.ForeColor = System.Drawing.Color.White;
            this.MachiningCenterStateLbl.Location = new System.Drawing.Point(206, 3);
            this.MachiningCenterStateLbl.Name = "MachiningCenterStateLbl";
            this.MachiningCenterStateLbl.Size = new System.Drawing.Size(69, 20);
            this.MachiningCenterStateLbl.TabIndex = 11;
            this.MachiningCenterStateLbl.Text = "加工中心";
            // 
            // ucSignalLamp2
            // 
            this.ucSignalLamp2.IsHighlight = true;
            this.ucSignalLamp2.IsShowBorder = false;
            this.ucSignalLamp2.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.ucSignalLamp2.Location = new System.Drawing.Point(177, 2);
            this.ucSignalLamp2.Name = "ucSignalLamp2";
            this.ucSignalLamp2.Size = new System.Drawing.Size(18, 18);
            this.ucSignalLamp2.TabIndex = 10;
            this.ucSignalLamp2.TwinkleSpeed = 0;
            // 
            // ServerStateLbl
            // 
            this.ServerStateLbl.AutoSize = true;
            this.ServerStateLbl.ForeColor = System.Drawing.Color.White;
            this.ServerStateLbl.Location = new System.Drawing.Point(69, 3);
            this.ServerStateLbl.Name = "ServerStateLbl";
            this.ServerStateLbl.Size = new System.Drawing.Size(54, 20);
            this.ServerStateLbl.TabIndex = 11;
            this.ServerStateLbl.Text = "服务器";
            // 
            // ucSignalLamp1
            // 
            this.ucSignalLamp1.IsHighlight = true;
            this.ucSignalLamp1.IsShowBorder = false;
            this.ucSignalLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.ucSignalLamp1.Location = new System.Drawing.Point(40, 2);
            this.ucSignalLamp1.Name = "ucSignalLamp1";
            this.ucSignalLamp1.Size = new System.Drawing.Size(18, 18);
            this.ucSignalLamp1.TabIndex = 10;
            this.ucSignalLamp1.TwinkleSpeed = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.ProductionTaskQueue1);
            this.panel9.Controls.Add(this.CompletedTask1);
            this.panel9.Controls.Add(this.ucDataGridView2);
            this.panel9.Controls.Add(this.ucDataGridView1);
            this.panel9.Controls.Add(this.ShiftPlanTxt);
            this.panel9.Controls.Add(this.CompletedPlanTxt);
            this.panel9.Controls.Add(this.ShiftPlanLbl);
            this.panel9.Controls.Add(this.CompletedPlanLbl);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 442);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(613, 346);
            this.panel9.TabIndex = 10;
            // 
            // ucDataGridView2
            // 
            this.ucDataGridView2.BackColor = System.Drawing.Color.White;
            this.ucDataGridView2.Columns = null;
            this.ucDataGridView2.DataSource = null;
            this.ucDataGridView2.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucDataGridView2.HeadHeight = 40;
            this.ucDataGridView2.HeadPadingLeft = 0;
            this.ucDataGridView2.HeadTextColor = System.Drawing.Color.Black;
            this.ucDataGridView2.IsShowCheckBox = false;
            this.ucDataGridView2.IsShowHead = true;
            this.ucDataGridView2.Location = new System.Drawing.Point(11, 209);
            this.ucDataGridView2.Name = "ucDataGridView2";
            this.ucDataGridView2.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ucDataGridView2.RowHeight = 40;
            this.ucDataGridView2.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.ucDataGridView2.Size = new System.Drawing.Size(583, 220);
            this.ucDataGridView2.TabIndex = 2;
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1.BackColor = System.Drawing.Color.White;
            this.ucDataGridView1.Columns = null;
            this.ucDataGridView1.DataSource = null;
            this.ucDataGridView1.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucDataGridView1.HeadHeight = 40;
            this.ucDataGridView1.HeadPadingLeft = 0;
            this.ucDataGridView1.HeadTextColor = System.Drawing.Color.Black;
            this.ucDataGridView1.IsShowCheckBox = false;
            this.ucDataGridView1.IsShowHead = true;
            this.ucDataGridView1.Location = new System.Drawing.Point(11, 43);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ucDataGridView1.RowHeight = 40;
            this.ucDataGridView1.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.ucDataGridView1.Size = new System.Drawing.Size(583, 130);
            this.ucDataGridView1.TabIndex = 2;
            // 
            // ShiftPlanTxt
            // 
            this.ShiftPlanTxt.Location = new System.Drawing.Point(254, 77);
            this.ShiftPlanTxt.Name = "ShiftPlanTxt";
            this.ShiftPlanTxt.Size = new System.Drawing.Size(112, 27);
            this.ShiftPlanTxt.TabIndex = 1;
            // 
            // CompletedPlanTxt
            // 
            this.CompletedPlanTxt.Location = new System.Drawing.Point(254, 127);
            this.CompletedPlanTxt.Name = "CompletedPlanTxt";
            this.CompletedPlanTxt.Size = new System.Drawing.Size(112, 27);
            this.CompletedPlanTxt.TabIndex = 1;
            // 
            // ShiftPlanLbl
            // 
            this.ShiftPlanLbl.AutoSize = true;
            this.ShiftPlanLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShiftPlanLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ShiftPlanLbl.Location = new System.Drawing.Point(161, 79);
            this.ShiftPlanLbl.Name = "ShiftPlanLbl";
            this.ShiftPlanLbl.Size = new System.Drawing.Size(112, 26);
            this.ShiftPlanLbl.TabIndex = 0;
            this.ShiftPlanLbl.Text = "本班制计划:";
            // 
            // CompletedPlanLbl
            // 
            this.CompletedPlanLbl.AutoSize = true;
            this.CompletedPlanLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompletedPlanLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CompletedPlanLbl.Location = new System.Drawing.Point(161, 129);
            this.CompletedPlanLbl.Name = "CompletedPlanLbl";
            this.CompletedPlanLbl.Size = new System.Drawing.Size(112, 26);
            this.CompletedPlanLbl.TabIndex = 0;
            this.CompletedPlanLbl.Text = "已完成计划:";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(613, 442);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(745, 346);
            this.panel10.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProductionTaskQueue1
            // 
            this.ProductionTaskQueue1.Location = new System.Drawing.Point(140, 163);
            this.ProductionTaskQueue1.Name = "ProductionTaskQueue1";
            this.ProductionTaskQueue1.Size = new System.Drawing.Size(255, 40);
            this.ProductionTaskQueue1.TabIndex = 4;
            // 
            // CompletedTask1
            // 
            this.CompletedTask1.Location = new System.Drawing.Point(140, 5);
            this.CompletedTask1.Name = "CompletedTask1";
            this.CompletedTask1.Size = new System.Drawing.Size(255, 40);
            this.CompletedTask1.TabIndex = 3;
            // 
            // ProductionTaskQueue
            // 
            this.ProductionTaskQueue.Location = new System.Drawing.Point(140, 183);
            this.ProductionTaskQueue.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.ProductionTaskQueue.Name = "ProductionTaskQueue";
            this.ProductionTaskQueue.Size = new System.Drawing.Size(353, 37);
            this.ProductionTaskQueue.TabIndex = 0;
            // 
            // CompletedTask
            // 
            this.CompletedTask.Location = new System.Drawing.Point(153, 7);
            this.CompletedTask.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CompletedTask.Name = "CompletedTask";
            this.CompletedTask.Size = new System.Drawing.Size(279, 44);
            this.CompletedTask.TabIndex = 0;
            // 
            // GeneralTaskStatistics
            // 
            this.GeneralTaskStatistics.Location = new System.Drawing.Point(153, 4);
            this.GeneralTaskStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GeneralTaskStatistics.Name = "GeneralTaskStatistics";
            this.GeneralTaskStatistics.Size = new System.Drawing.Size(279, 40);
            this.GeneralTaskStatistics.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1358, 808);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SecondTitlePanel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SecondTitlePanel1);
            this.Controls.Add(this.FirstTitlePanel);
            this.Name = "MainPanel";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.FirstTitlePanel.ResumeLayout(false);
            this.FirstTitlePanel.PerformLayout();
            this.SecondTitlePanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.SecondTitlePanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TrademarkLbl;
        private System.Windows.Forms.Label MachiningCenterLbl;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent1;
        private System.Windows.Forms.Panel FirstTitlePanel;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent2;
        private System.Windows.Forms.Label ProductInfo;
        private System.Windows.Forms.Panel SecondTitlePanel1;
        private System.Windows.Forms.Label PersonnelInfoLbl;
        private System.Windows.Forms.Label QCStatusInfoLbl;
        private System.Windows.Forms.Label QCProductInfoLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel SecondTitlePanel2;
        private System.Windows.Forms.Panel panel3;
        public HZH_Controls.Controls.UCSignalLamp ucSignalLamp1;
        private System.Windows.Forms.Label ServerStateLbl;
        private System.Windows.Forms.Label MachiningCenterStateLbl;
        public HZH_Controls.Controls.UCSignalLamp ucSignalLamp2;
        private System.Windows.Forms.Label EmployeeNameLbl;
        private System.Windows.Forms.Label EmployeeIDLbl;
        private System.Windows.Forms.TextBox EmployeeNameTxt;
        private System.Windows.Forms.TextBox EmployeeIDTxt;
        private System.Windows.Forms.TextBox QCTimeTxt;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.TextBox CurrentProcessTxt;
        private System.Windows.Forms.Label QCTimeLbl;
        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label CurrentProcessLbl;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.Panel OnlineProductInfoPanel;
        private System.Windows.Forms.Panel PersonnelInfoPanel;
        private System.Windows.Forms.Panel ProductionStatusInfoPanel;
        private System.Windows.Forms.Label PlanInfoLbl;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private ThridTitle CompletedTask;
        private ThridTitle GeneralTaskStatistics;
        private ThridTitle ProductionTaskQueue;
        private System.Windows.Forms.TextBox CompletedPlanTxt;
        private System.Windows.Forms.Label ShiftPlanLbl;
        private System.Windows.Forms.Label CompletedPlanLbl;
        private System.Windows.Forms.TextBox ShiftPlanTxt;
        private HZH_Controls.Controls.UCDataGridView ucDataGridView1;
        private HZH_Controls.Controls.UCDataGridView ucDataGridView2;
        private ThridTitle ProductionTaskQueue1;
        private ThridTitle CompletedTask1;
        private System.Windows.Forms.Timer timer1;
    }
}