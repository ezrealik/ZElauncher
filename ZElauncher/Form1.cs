using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace ZElauncher
{

    public partial class Form1 : Form
    {
        //全局变量
        Form_Setting set;
        Form_login login;
        System.Windows.Forms.Timer time_csgo = new System.Windows.Forms.Timer();

        static string GSteamPath;
        static string GCSGOPath;
        public Form1()
        {
            InitializeComponent();
            this.Text = "93x.net-X社区逃跑服启动器-V" + Application.ProductVersion.ToString() + "--By:ezrealik";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //检测重复执行
            bool isRuned;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "ZELauncher-93X", out isRuned);
            if (isRuned)
            {
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("小X是单核的[Master]重复执行小X会死机的(>^ω^<)\r\n如果[Master]找不到小X了可以打开任务管理把那个淘气的小X关掉!");
                Application.Exit();              //关闭系统
            }
            //设置导航栏首页
            SetTileIndex(0);
            label_DebugOutPut.Text = "导航页初始化完成!";
            //初始化Steam目录
            InitSteamPath();
            if (File.Exists(GSteamPath))
            {
                label_DebugOutPut.Text = "Steam信息初始化完成!";
            }
            else
            {
                label_DebugOutPut.Text = "Steam目录获取失败!";
            }
            //初始化CSGO目录;
            InitCSGOPath();
            if (!File.Exists(GCSGOPath + @"\csgo.exe"))
            {
                label_DebugOutPut.Text = "CSGO目录获取失败,执行检测线程自动获取CSGO目录!";
                time_csgo.Interval = 1000;
                time_csgo.Enabled = true;
                time_csgo.Tick += new EventHandler(time_csgo_event);
                time_csgo.Start();
            }
            else
            {
                label_DebugOutPut.Text = "CSGO信息初始化完成!";
            }
            OpenLoginForm();
        }
        private void OpenLoginForm()
        {
            if (login == null || login.IsDisposed)
            {
                login = new Form_login(this);
                login.Show();//如果之前未打开，则打开。
            }
            else
            {
                set.Activate();//之前已打开，则给予焦点，置顶。
            }
        }
        private void time_csgo_event(object sender,EventArgs e)
        {
            label_DebugOutPut.Text = "CSGO线程检测运行中,正在等待CSGO进程运行....";
            try
            {
                StringBuilder Csgo = new StringBuilder(1024);
                if (WIN32API._GetProcessCSGOPath(Csgo, 1024))
                {
                    if (File.Exists(Csgo.ToString() + @"\csgo.exe"))
                    {
                        GCSGOPath = Csgo.ToString();
                        time_csgo.Stop();
                        WIN32API.WritePrivateProfileString("Steam", "CSGOPath", GCSGOPath, Application.StartupPath + "\\Config.ini");
                        label_DebugOutPut.Text = "成功获取到CSGO目录路径!";
                    }
                }
            }
            catch (System.Exception ex)
            {
                label_DebugOutPut.Text = ex.Message.ToString();
            }
        }
        public void SetDebugString(string tp)
        {
            label_DebugOutPut.Text = tp.ToString();
        }

        //获取Steam目录
        private void InitSteamPath()
        {
            try
            {
                StringBuilder SteamPath = new StringBuilder(1024);
                WIN32API.GetPrivateProfileString("Steam", "Path", null, SteamPath, 1024, Application.StartupPath + "\\Config.ini");
                if (SteamPath.Length > 5)
                {
                    GSteamPath = SteamPath.ToString();
                    return;
                }
                string registData;
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", false);
                RegistryKey aimdir = software.OpenSubKey("Classes\\steam\\Shell\\Open\\Command", false);
                registData = aimdir.GetValue(null).ToString();
                string[] sArray = Regex.Split(registData, "\"", RegexOptions.IgnoreCase);
                GSteamPath = sArray[1].ToString();
                WIN32API.WritePrivateProfileString("Steam", "Path", GSteamPath, Application.StartupPath + "\\Config.ini");
            }
            catch (Exception e)
            {
                label_DebugOutPut.Text = e.Message.ToString();
            }
        }
        public void SetSteamPath(string path)
        {
            GSteamPath = path;
        }
        public string GetSteamPath()
        {
            return GSteamPath;
        }
        //获取CSGO目录
        private void InitCSGOPath()
        {
            try
            {
                StringBuilder Stream = new StringBuilder(1024);
                WIN32API.GetPrivateProfileString("Steam", "CSGOPath", null, Stream, 1024, Application.StartupPath + "\\Config.ini");
                if (File.Exists(Stream.ToString() + @"\csgo.exe"))
                {
                    GCSGOPath = Stream.ToString();
                    return;
                }
                WIN32API._GetCSGOPath(Stream, 1024);
                GCSGOPath = Stream.ToString();
                if (File.Exists(GCSGOPath.ToString() + @"\csgo.exe"))
                {
                    label_DebugOutPut.Text = "获取CSGO目录失败!!";
                    return;
                }
                WIN32API.WritePrivateProfileString("Steam", "CSGOPath", GCSGOPath, Application.StartupPath + "\\Config.ini");
            }
            catch (Exception e)
            {
                label_DebugOutPut.Text = e.Message.ToString();
            }
        }
        public string GetCSGOPath()
        {
            return GCSGOPath;
        }
        public void SetCSGOPath(string path)
        {
            GCSGOPath = path;
        }
        //标题栏点击 移动窗口
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //判断是否标题栏区域
            if (e.Y < 60&&e.X>270&&e.X<750)
            {
                //为当前应用程序释放鼠标捕获
                WIN32API.ReleaseCapture();
                //发送消息 让系统误以为在标题栏上按下鼠标
                WIN32API.SendMessage((IntPtr)this.Handle, WIN32API.VM_NCLBUTTONDOWN, WIN32API.HTCAPTION, 0);
            }
        }
        //论坛官网首页访问
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("http://bbs.93x.net");
        }
        //标题按钮 关闭操作
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //标题按钮 我的信息操作
        private void button_MyInfo_Click(object sender, EventArgs e)
        {
            
        }
        #region 导航栏选择
        //关闭Tab窗口
        private void ClosePreForm()
        {
            foreach (Control item in this.panel_WindowTab.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }

            }
        }
        //新建Tab窗口
        private void SetTileForm(Form objFrm)
        {
            //嵌入子窗体到父窗体中，把添加学员信息嵌入到主窗体右侧
            objFrm.TopLevel = false; //将子窗体设置成非最高层，非顶级控件
            objFrm.WindowState = FormWindowState.Maximized;//将当前窗口设置成最大化
            objFrm.FormBorderStyle = FormBorderStyle.None;//去掉窗体边框
            objFrm.Parent = this.panel_WindowTab;//指定子窗体显示的容器
            objFrm.Show();
        }
        //设置导航栏索引
        private void SetTileIndex(int Index)
        {
            switch (Index)
            {
                case 0:
                    DefaultTitleColor();
                    button_Title_MainPage.BackColor = Color.DeepSkyBlue;
                    ClosePreForm();
                    SetTileForm(new Form_MainPage(this));
                    break;
                case 1:
                    DefaultTitleColor();
                    button_Title_Page2.BackColor = Color.DeepSkyBlue;
                    ClosePreForm();
                    break;
                case 2:
                    DefaultTitleColor();
                    button_Title_Page3.BackColor = Color.DeepSkyBlue;
                    ClosePreForm();
                    break;
                case 3:
                    DefaultTitleColor();
                    button_Title_Page4.BackColor = Color.DeepSkyBlue;
                    ClosePreForm();
                    break;
                case 4:
                    DefaultTitleColor();
                    button_Title_Page5.BackColor = Color.DeepSkyBlue;
                    ClosePreForm();
                    break;
                default:
                    break;
            }
        }
        //重置所有导航栏颜色属性
        private void DefaultTitleColor()
        {
            button_Title_MainPage.BackColor = Color.Transparent;
            button_Title_Page2.BackColor = Color.Transparent;
            button_Title_Page3.BackColor = Color.Transparent;
            button_Title_Page4.BackColor = Color.Transparent;
            button_Title_Page5.BackColor = Color.Transparent;
        }
        private void button_Title_Page2_Click(object sender, EventArgs e)
        {
            SetTileIndex(1);
        }
        private void button_Title_MainPage_Click(object sender, EventArgs e)
        {
            SetTileIndex(0);
        }
        private void button_Title_Page3_Click(object sender, EventArgs e)
        {
            SetTileIndex(2);
        }
        private void button_Title_Page4_Click(object sender, EventArgs e)
        {
            SetTileIndex(3);
        }
        private void button_Title_Page5_Click(object sender, EventArgs e)
        {
            SetTileIndex(4);
        }
        #endregion
        #region 标题按钮操作
        private void Login_MyInfo_MouseMove(object sender, MouseEventArgs e)
        {
            Login_MyInfo.BackColor = Color.Silver;
            this.Cursor = Cursors.Hand;
        }
        private void Login_MyInfo_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }
        private void Login_MyInfo_MouseLeave(object sender, EventArgs e)
        {
            Login_MyInfo.BackColor = Color.Transparent;
            this.Cursor = Cursors.Default;
        }
        private void pictureBox_Logo_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        private void pictureBox_Logo_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void button_MinWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = true;
        }
        private void button_Setting_Click(object sender, EventArgs e)
        {
            if (set == null || set.IsDisposed)
            {
                set = new Form_Setting(this);
                set.Show();//如果之前未打开，则打开。
            }
            else
            {
                set.Activate();//之前已打开，则给予焦点，置顶。
            }
        }
        private void button_Menu_Click(object sender, EventArgs e)
        {
            Point ms = new Point();
            ms.X = this.Left + button_Menu.Left;
            ms.Y = this.Top + button_Menu.Bottom;
            Menu1.Show(ms);
        }
        private void 访问官方论坛ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://bbs.93x.net/");
        }
        #endregion
    }
}
