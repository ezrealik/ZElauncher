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
            this.TopMost = true;
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
    }
}
