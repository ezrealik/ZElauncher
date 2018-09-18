using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZElauncher
{
    public partial class Form_loginQQ : Form
    {
        public Form_loginQQ()
        {
            InitializeComponent();
        }
        bool Con = false;
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            if (e.Url.LocalPath == "/connect.php")
            {
                if (Con)
                {
                    if (webBrowser1.Document.Cookie != null)
                    {
                        try
                        {
                            string cookieStr = webBrowser1.Document.Cookie;
                            File.WriteAllText(Application.StartupPath + @"\Cookies.dat", cookieStr, Encoding.Default);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    this.Close();
                }
                Con = true;
            }
            
            //将所有的链接的目标，指向本窗体
            foreach (HtmlElement archor in this.webBrowser1.Document.Links)
            {
                archor.SetAttribute("target", "_blank");
                archor.SetAttribute("target", "_self");
            }

            //将所有的FORM的提交目标，指向本窗体
            foreach (HtmlElement form in this.webBrowser1.Document.Forms)
            {
                form.SetAttribute("target", "_blank");
                form.SetAttribute("target", "_self");
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            string url = webBrowser1.Document.ActiveElement.GetAttribute("href");
            if (url != string.Empty)
            {
                webBrowser1.Navigate(url);
            }
            e.Cancel = true;
        }
    }
}
