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
    public partial class Form_Setting : Form
    {
        private Form1 _form1;
        public Form_Setting()
        {
            InitializeComponent();
        }
        public Form_Setting(Form1 form): this()
        {
            _form1 = form;
        }
        private void Form_Setting_MouseDown(object sender, MouseEventArgs e)
        {
            //判断是否标题栏区域
            if (e.Y < 60 && e.X < 470)
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

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            textBox_SteamPath.Text = _form1.GetSteamPath();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Steam目录浏览
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择Steam文件";
            dialog.Filter = "可执行文件(*.exe)|*.exe|所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_SteamPath.Text = dialog.FileName;
            }

        }
    }
}
