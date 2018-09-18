using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZElauncher
{
    public partial class Form_Video : Form
    {
        Form1 _form1;
        public Form_Video()
        {
            InitializeComponent();
        }
        public Form_Video(Form1 For2) : this()
        {
            _form1 = For2;
        }
        private void Form_Video_Load(object sender, EventArgs e)
        {
            
        }
        private void ClearCachedSWFFiles()
        {
            try
            {
                var cachefolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                       "\\Microsoft\\Windows\\INetCache\\IE";
                var dirinfo = new DirectoryInfo(cachefolder);
                foreach (var directoryInfo in dirinfo.GetDirectories())
                {
                    foreach (var fileInfo in directoryInfo.GetFiles("*.swf"))
                    {
                        fileInfo.Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            ClearCachedSWFFiles();
            string url = webBrowser1.Document.ActiveElement.GetAttribute("href");
            if (url != string.Empty)
            {
                webBrowser1.Navigate(url);
            }
            e.Cancel = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBox_Url.Text = webBrowser1.Document.Url.ToString();
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

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void Web_Back_MouseLeave(object sender, EventArgs e)
        {
            Web_Back.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
        }
        private void Web_Back_MouseEnter(object sender, EventArgs e)
        {
            Web_Back.BackColor = Color.Tan;
            this.Cursor = Cursors.Hand;
        }
        private void Web_Go_MouseEnter(object sender, EventArgs e)
        {
            Web_Go.BackColor = Color.Tan;
            this.Cursor = Cursors.Hand;
        }
        private void Web_Go_MouseLeave(object sender, EventArgs e)
        {
            Web_Go.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
        }
        private void Web_Refresh_MouseLeave(object sender, EventArgs e)
        {
            Web_Refresh.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
        }
        private void Web_Refresh_MouseEnter(object sender, EventArgs e)
        {
            Web_Refresh.BackColor = Color.Tan;
            this.Cursor = Cursors.Hand;
        }
        private void Web_Back_MouseDown(object sender, MouseEventArgs e)
        {
            Web_Back.BackColor = Color.Pink;
        }
        private void Web_Go_MouseUp(object sender, MouseEventArgs e)
        {
            Web_Go.BackColor = Color.Tan;
        }
        private void Web_Back_MouseUp(object sender, MouseEventArgs e)
        {
            Web_Back.BackColor = Color.Tan;
        }
        private void Web_Go_MouseDown(object sender, MouseEventArgs e)
        {
            Web_Go.BackColor = Color.Pink;
        }
        private void Web_Refresh_MouseDown(object sender, MouseEventArgs e)
        {
            Web_Refresh.BackColor = Color.Pink;
        }
        private void Web_Refresh_MouseUp(object sender, MouseEventArgs e)
        {
            Web_Refresh.BackColor = Color.Tan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(textBox_Url.Text);
        }
        private void Web_Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void Web_Go_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void Web_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void textBox_Url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                webBrowser1.Navigate(textBox_Url.Text);
            }
        }
    }
}
