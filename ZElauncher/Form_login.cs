using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZElauncher
{
    public partial class Form_login : Form
    {
        private Form1 _form1;
        public Form_login()
        {
            InitializeComponent();
        }
        public Form_login(Form1 form): this()
        {
            _form1 = form;
        }
        private void Form_login_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
        }

        private void Form_login_MouseDown(object sender, MouseEventArgs e)
        {
            //判断是否标题栏区域
            if (e.Y < 45 && e.X < 335)
            {
                //为当前应用程序释放鼠标捕获
                WIN32API.ReleaseCapture();
                //发送消息 让系统误以为在标题栏上按下鼠标
                WIN32API.SendMessage((IntPtr)this.Handle, WIN32API.VM_NCLBUTTONDOWN, WIN32API.HTCAPTION, 0);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_QQlogin_Click(object sender, EventArgs e)
        {
            Form_loginQQ loginqq = new Form_loginQQ();
            loginqq.Show();
            this.Close();
        }
        private void button_Steam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未实现此功能!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂未实现此功能!");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.LocalPath == "/member.php")
            {

            }
        }

        private void button_Sign_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂时仅支持QQ登陆");
            //HtmlElement btnSubmit = webBrowser1.Document.All["loginsubmit"];
            //HtmlElement tbUserid = webBrowser1.Document.All["username"];
            //HtmlElement tbPasswd = webBrowser1.Document.All["password"];
            //if (tbUserid == null || tbPasswd == null || btnSubmit == null) return;
            //tbUserid.SetAttribute("value", textBox_UserName.Text);
            //tbPasswd.SetAttribute("value", textBox_PassWorld.Text);
            //btnSubmit.InvokeMember("click");
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            //判断是否标题栏区域
            if (e.Y < 45 && e.X < 335)
            {
                //为当前应用程序释放鼠标捕获
                WIN32API.ReleaseCapture();
                //发送消息 让系统误以为在标题栏上按下鼠标
                WIN32API.SendMessage((IntPtr)this.Handle, WIN32API.VM_NCLBUTTONDOWN, WIN32API.HTCAPTION, 0);
            }
        }

        private void pictureBox_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            //为当前应用程序释放鼠标捕获
            WIN32API.ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            WIN32API.SendMessage((IntPtr)this.Handle, WIN32API.VM_NCLBUTTONDOWN, WIN32API.HTCAPTION, 0);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }
    }
}
