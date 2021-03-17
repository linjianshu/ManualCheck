using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;

namespace MachineryProcessingDemo
{
    public partial class ThridTitle : UserControl
    {
        public ThridTitle()
        {
            InitializeComponent();
        }

        private void ThridTitle_Load(object sender, EventArgs e)
        {
            string strIcon = "E_icon_star"; 
            pictureBox1.ForeColor = Color.FromArgb(255, 77, 59);
            FontIcons icon1 = (FontIcons)Enum.Parse(typeof(FontIcons), strIcon);
            pictureBox1.Image = FontImages.GetImage(icon1, 32, Color.FromArgb(255, 77, 59));
            pictureBox2.Image = FontImages.GetImage(icon1, 32, Color.FromArgb(255, 77, 59));
            pictureBox3.Image = FontImages.GetImage(icon1, 32, Color.FromArgb(255, 77, 59));
            pictureBox4.Image = FontImages.GetImage(icon1, 32, Color.FromArgb(255, 77, 59));
            
        }
    }
}
