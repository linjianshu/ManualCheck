
namespace ManualCheck.Forms
{
    partial class ScanOnlineForm
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
            serialPortTest.Close();
            serialPortTest.Dispose(); 
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
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.serialPortTest = new System.IO.Ports.SerialPort(this.components);
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductIDTxt);
            this.panel3.Controls.Add(this.ProductIDLbl);
            this.panel3.Controls.Add(this.ProductNameTxt);
            this.panel3.Controls.Add(this.ProductNameLbl);
            this.panel3.Size = new System.Drawing.Size(553, 290);
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.Location = new System.Drawing.Point(241, 154);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(143, 32);
            this.ProductNameTxt.TabIndex = 3;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductNameLbl.Location = new System.Drawing.Point(132, 158);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(93, 26);
            this.ProductNameLbl.TabIndex = 2;
            this.ProductNameLbl.Text = "产品名称:";
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductIDLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductIDLbl.Location = new System.Drawing.Point(132, 212);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(112, 26);
            this.ProductIDLbl.TabIndex = 2;
            this.ProductIDLbl.Text = "产品出生证:";
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.Location = new System.Drawing.Point(241, 208);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(143, 32);
            this.ProductIDTxt.TabIndex = 3;
            this.ProductIDTxt.DoubleClick += new System.EventHandler(this.ProductIDTxt_DoubleClick);
            // 
            // serialPortTest
            // 
            this.serialPortTest.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortTest_DataReceived_1);
            // 
            // ScanOnlineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(553, 414);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ScanOnlineForm";
            this.Text = "ScanOnline";
            this.Title = "扫码上线";
            this.Load += new System.EventHandler(this.ScanOnline_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.IO.Ports.SerialPort serialPortTest;

        #endregion
        // private System.Windows.Forms.Label TrademarkLbl;
    }
}