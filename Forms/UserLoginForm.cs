using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using HZH_Controls.Forms;
using Microsoft.Extensions.Configuration;
using QualityCheckDemo;

namespace ManualCheck.Forms
{
    public partial class UserLoginForm : FrmBase
    {
        private static string _workshopId;
        private static string _workshopCode;
        private static string _workshopName;
        private static string _equipmentId;
        private static string _equipmentCode;
        private static string _equipmentName;

        public UserLoginForm()
        {
            InitializeComponent();
            this.IsFullSize = false;
            PwdTxt.PasswordChar = '*'; 
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwd = ""; 
            var md5 = MD5.Create();
            var computeHash = md5.ComputeHash(Encoding.UTF8.GetBytes(PwdTxt.ToString()));
            foreach (var b in computeHash)
            {
                pwd += b.ToString(); 
            }

            using (var context = new Model())
            {
                var cStaffBaseInformation = context.C_StaffBaseInformation.FirstOrDefault(s => s.Account==AccountTxt.Text);
                if (cStaffBaseInformation!=null)
                {
                    if (cStaffBaseInformation.Password==pwd)
                    {
                        FrmDialog.ShowDialog(this, "登陆成功,欢迎使用!", "登陆成功");
                        this.Hide();

                        string strIp = ""; 
                        foreach (var ipAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                        {
                                strIp = ipAddress.ToString(); 
                        }

                        // int.TryParse(_equipmentId, out var result); 
                        // //在登陆过程表中插入数据
                        // var cLoginInProcessing = new C_LoginInProcessing()
                        // {
                        //     StaffCode = cStaffBaseInformation.StaffCode,
                        //     StaffID = cStaffBaseInformation.StaffID,
                        //     StaffName = cStaffBaseInformation.StaffName,
                        //     OnlineTime = context.GetServerDate(),
                        //     //设备id???
                        //     EquipmentID = result,
                        //     EquipmentName = _equipmentName,
                        //     IP = strIp,
                        //     Remarks = "测试数据"
                        // };
                        //
                        // context.C_LoginInProcessing.Add(cLoginInProcessing);
                        // context.SaveChanges(); 

                        new MainPanel(cStaffBaseInformation.StaffID, cStaffBaseInformation.StaffCode, cStaffBaseInformation.StaffName).Show();
                    }
                    else
                    {
                        FrmDialog.ShowDialog(this, "密码错误,请重试!", "登陆失败");
                    }
                }
                else
                {
                    FrmDialog.ShowDialog(this, "该用户不存在!", "登陆失败");
                }
            }
        }
    }
}
