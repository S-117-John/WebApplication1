using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web;
using System.Xml;

namespace WebApplication1.Service
{
   
    public class HardWareService
    {
        [DllImport(@"GGXmlTcp.dll")]
        public static extern int XmlTcp(StringBuilder xmlbuf, int timeout);

        public static bool AllowCardIn()
        {
            StringBuilder xmlBuff = new StringBuilder(1000);
            xmlBuff.Append("<invoke name=\"READCARDALLOWCARDIN\"><arguments><string id =\"ONLY_MAG\">TRUE</string></arguments></invoke>");
            int ret = XmlTcp(xmlBuff, 1000);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlBuff.ToString());
            XmlNode xmlNode = xmlDocument.SelectSingleNode("/return/arguments/string[@id='ERROR']");
            if (xmlNode!=null && xmlNode.InnerText.IndexOf("SUCCESS")>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}