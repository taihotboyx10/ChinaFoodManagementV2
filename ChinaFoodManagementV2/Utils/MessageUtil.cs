using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ChinaFoodManagementV2.Utils
{
    public class MessageUtil
    {
        public static DialogResult ShowMessage(string msgId, MessageBoxButtons btn, string cap = "",
            MessageBoxDefaultButton defaultBtn = 0, string optMsg = "")
        {
            XmlDocument xmlDoc = new XmlDocument();

            string msgText = msgId;
            string iconStr = "";
            string path = System.IO.Path.Combine(@"C:\Users\Nguyen Du Tai\source\repos\CoffeeStore\CofffeeStoreManagement\Message\Message.xml");
            //string path = System.IO.Path.Combine(@"C:\Users\HP\source\repos\CofffeeStoreManagement\CofffeeStoreManagement\Message\Message.xml");

            MessageBoxIcon msgIcon;

            xmlDoc.Load(path);

            XmlNode node = xmlDoc.SelectSingleNode(string.Format("/message/contents[@id='{0}']/{1}", msgId, "text"));
            if (node != null && node.InnerText != null)
            {
                msgText = node.InnerText;
            }

            node = xmlDoc.SelectSingleNode(string.Format("/message/contents[@id='{0}']/{1}", msgId, "icon"));

            if (node != null && node.InnerText != null)
            {
                iconStr = node.InnerText;
            }
            msgIcon = MessageBoxIcon.None;
            if (iconStr == "Warning")
            {
                msgIcon = MessageBoxIcon.Warning;
            }
            else if (iconStr == "Error")
            {
                msgIcon = MessageBoxIcon.Error;
            }
            else if (iconStr == "Info")
            {
                msgIcon = MessageBoxIcon.Information;
            }
            else if (iconStr == "Question")
            {
                msgIcon = MessageBoxIcon.Question;
            }

            if (!string.IsNullOrEmpty(optMsg))
            {
                msgText = msgText + "\r\n" + optMsg;
            }

            return MessageBox.Show(msgText, cap, btn, msgIcon, defaultBtn);
        }

        public static DialogResult ShowMessage(string MsgId, MessageBoxButtons Btn, string Caption = "", string OptMsg = "")
        {
            return ShowMessage(MsgId, Btn, Caption, 0, OptMsg);
        }

        public static DialogResult ShowMessage(string MsgId, MessageBoxButtons Btn, string Caption = "")
        {
            return ShowMessage(MsgId, Btn, Caption, 0);
        }
    }
}
