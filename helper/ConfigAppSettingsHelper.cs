using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace WorkPlatForm.Public_Classes
{
    static class ConfigAppSettingsHelper
    {
        /// <summary>
        /// 读取节点的值
        /// </summary>
        /// <param name="key"></param>
        public static string ReadSetting(string key)
        {
            try
            {
                string value = "";
                XmlDocument xDoc = new XmlDocument();
                //获得配置文件的全路径  
                //string fileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;//调试时读取到的是vshost.Config, 运行时读取的是exe.config, 会导致不同步
                string fileName = System.Windows.Forms.Application.ExecutablePath + ".config";//读取的是exe.config,不存在同步问题
                xDoc.Load(fileName);
                //找出名称为"add"的所有元素  
                var xNode = xDoc.SelectSingleNode("//appSettings");
                var xElem = (XmlElement)xNode.SelectSingleNode("//add[@key='" + key + "']");
                if (xElem != null)
                {
                    value = xElem.Attributes["value"].Value;
                }
                return (value);
            }
            catch (ConfigurationErrorsException E)
            {
                throw new Exception(E.Message);
            }
        }

        /// <summary>
        /// 插入或者更新节点
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                XmlElement root = null;
                //获得配置文件的全路径  
                //string fileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;//调试时读取到的是vshost.Config, 运行时读取的是exe.config, 会导致不同步
                string fileName = System.Windows.Forms.Application.ExecutablePath + ".config";//读取的是exe.config,不存在同步问题
                xDoc.Load(fileName);
                root = xDoc.DocumentElement;
                var xNode = (XmlElement)root.SelectSingleNode("//appSettings");
                var xElem = (XmlElement)xNode.SelectSingleNode("//add[@key='" + key + "']");
                if (xElem != null) xElem.SetAttribute("value", value);
                else
                {
                    var xNewElem = xDoc.CreateElement("add");
                    xNewElem.SetAttribute("key", key);
                    xNewElem.SetAttribute("value", value);
                    xNode.AppendChild(xNewElem);
                }
                xDoc.Save(fileName);
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException E)
            {
                throw new Exception(E.Message);
            }
        }
    }
}
