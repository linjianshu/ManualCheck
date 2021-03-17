
namespace ManualCheck.Forms
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.FirstTitlePanel = new System.Windows.Forms.Panel();
            this.TrademarkLbl = new System.Windows.Forms.Label();
            this.MachiningCenterLbl = new System.Windows.Forms.Label();
            this.comfirmBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountTxt = new System.Windows.Forms.TextBox();
            this.PwdTxt = new System.Windows.Forms.TextBox();
            this.FirstTitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstTitlePanel
            // 
            this.FirstTitlePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.FirstTitlePanel.Controls.Add(this.TrademarkLbl);
            this.FirstTitlePanel.Controls.Add(this.MachiningCenterLbl);
            this.FirstTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.FirstTitlePanel.Name = "FirstTitlePanel";
            this.FirstTitlePanel.Size = new System.Drawing.Size(645, 63);
            this.FirstTitlePanel.TabIndex = 4;
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
            this.MachiningCenterLbl.Location = new System.Drawing.Point(254, 23);
            this.MachiningCenterLbl.Name = "MachiningCenterLbl";
            this.MachiningCenterLbl.Size = new System.Drawing.Size(194, 40);
            this.MachiningCenterLbl.TabIndex = 1;
            this.MachiningCenterLbl.Text = "手检中心001";
            // 
            // comfirmBtn
            // 
            this.comfirmBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comfirmBtn.ForeColor = System.Drawing.Color.Black;
            this.comfirmBtn.Location = new System.Drawing.Point(261, 345);
            this.comfirmBtn.Name = "comfirmBtn";
            this.comfirmBtn.Size = new System.Drawing.Size(107, 37);
            this.comfirmBtn.TabIndex = 6;
            this.comfirmBtn.Text = "登录";
            this.comfirmBtn.UseVisualStyleBackColor = true;
            this.comfirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 118);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "账号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(188, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码:";
            // 
            // AccountTxt
            // 
            this.AccountTxt.Location = new System.Drawing.Point(261, 219);
            this.AccountTxt.Name = "AccountTxt";
            this.AccountTxt.Size = new System.Drawing.Size(134, 27);
            this.AccountTxt.TabIndex = 10;
            this.AccountTxt.Text = "987126632";
            // 
            // PwdTxt
            // 
            this.PwdTxt.Location = new System.Drawing.Point(261, 272);
            this.PwdTxt.Name = "PwdTxt";
            this.PwdTxt.Size = new System.Drawing.Size(134, 27);
            this.PwdTxt.TabIndex = 10;
            this.PwdTxt.Text = "lalala123";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 432);
            this.Controls.Add(this.PwdTxt);
            this.Controls.Add(this.AccountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comfirmBtn);
            this.Controls.Add(this.FirstTitlePanel);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.FirstTitlePanel.ResumeLayout(false);
            this.FirstTitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FirstTitlePanel;
        private System.Windows.Forms.Label TrademarkLbl;
        private System.Windows.Forms.Label MachiningCenterLbl;
        private System.Windows.Forms.Button comfirmBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountTxt;
        private System.Windows.Forms.TextBox PwdTxt;
    }
}