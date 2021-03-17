
namespace ManualCheck.Forms
{
    partial class ScanOfflineForm
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
            this.ProductIDTxt = new System.Windows.Forms.TextBox();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.ProductNameTxt = new System.Windows.Forms.TextBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductType = new System.Windows.Forms.Label();
            this.BadReasonLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.BadReasonLbl);
            this.panel3.Controls.Add(this.ProductType);
            this.panel3.Controls.Add(this.ProductIDTxt);
            this.panel3.Controls.Add(this.ProductIDLbl);
            this.panel3.Controls.Add(this.ProductNameTxt);
            this.panel3.Controls.Add(this.ProductNameLbl);
            this.panel3.Size = new System.Drawing.Size(553, 278);
            // 
            // ProductIDTxt
            // 
            this.ProductIDTxt.BackColor = System.Drawing.Color.White;
            this.ProductIDTxt.Location = new System.Drawing.Point(244, 125);
            this.ProductIDTxt.Name = "ProductIDTxt";
            this.ProductIDTxt.Size = new System.Drawing.Size(143, 32);
            this.ProductIDTxt.TabIndex = 6;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductIDLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductIDLbl.Location = new System.Drawing.Point(135, 129);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(112, 26);
            this.ProductIDLbl.TabIndex = 4;
            this.ProductIDLbl.Text = "产品出生证:";
            // 
            // ProductNameTxt
            // 
            this.ProductNameTxt.BackColor = System.Drawing.Color.White;
            this.ProductNameTxt.Location = new System.Drawing.Point(244, 71);
            this.ProductNameTxt.Name = "ProductNameTxt";
            this.ProductNameTxt.Size = new System.Drawing.Size(143, 32);
            this.ProductNameTxt.TabIndex = 7;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductNameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductNameLbl.Location = new System.Drawing.Point(135, 75);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(93, 26);
            this.ProductNameLbl.TabIndex = 5;
            this.ProductNameLbl.Text = "产品名称:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "正常下机",
            "NG下机"});
            this.comboBox1.Location = new System.Drawing.Point(244, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 33);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "正常下机";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // ProductType
            // 
            this.ProductType.AutoSize = true;
            this.ProductType.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProductType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ProductType.Location = new System.Drawing.Point(135, 178);
            this.ProductType.Name = "ProductType";
            this.ProductType.Size = new System.Drawing.Size(93, 26);
            this.ProductType.TabIndex = 8;
            this.ProductType.Text = "下机类型:";
            // 
            // BadReasonLbl
            // 
            this.BadReasonLbl.AutoSize = true;
            this.BadReasonLbl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BadReasonLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BadReasonLbl.Location = new System.Drawing.Point(135, 219);
            this.BadReasonLbl.Name = "BadReasonLbl";
            this.BadReasonLbl.Size = new System.Drawing.Size(86, 26);
            this.BadReasonLbl.TabIndex = 8;
            this.BadReasonLbl.Text = "NG原因:";
            this.BadReasonLbl.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(244, 213);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(252, 53);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // ScanOfflineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(553, 402);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ScanOfflineForm";
            this.Text = "ScanOfflineForm";
            this.Title = "扫码下线";
            this.Load += new System.EventHandler(this.ScanOfflineForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ProductIDTxt;
        private System.Windows.Forms.Label ProductIDLbl;
        private System.Windows.Forms.TextBox ProductNameTxt;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ProductType;
        private System.Windows.Forms.Label BadReasonLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}