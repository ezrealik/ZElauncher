using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            textBox_CSGOPath.Text = _form1.GetCSGOPath();
            try
            {
                System.IO.StreamReader st;
                st = new System.IO.StreamReader(textBox_CSGOPath.Text + @"\csgo\cfg\bind.cfg", System.Text.Encoding.UTF8);
                //UTF-8通用编码
                textBox_KeyCmd.Text = st.ReadToEnd();
                st.Close();
            }
            catch
            {
            	
            }
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

        private void textBox_bindKey_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                #region 键盘数字
                case "D1":
                    textBox_bindKey.Text = "slot1";
                    break;
                case "D2":
                    textBox_bindKey.Text = "slot2";
                    break;
                case "D3":
                    textBox_bindKey.Text = "slot3";
                    break;
                case "D4":
                    textBox_bindKey.Text = "slot4";
                    break;
                case "D5":
                    textBox_bindKey.Text = "slot5";
                    break;
                case "D6":
                    textBox_bindKey.Text = "slot6";
                    break;
                case "D7":
                    textBox_bindKey.Text = "slot7";
                    break;
                case "D8":
                    textBox_bindKey.Text = "slot8";
                    break;
                case "D9":
                    textBox_bindKey.Text = "slot9";
                    break;
                case "D0":
                    textBox_bindKey.Text = "slot10";
                    break; 
                #endregion
                #region 操作按键
                case "Oemtilde":
                    textBox_bindKey.Text = "~";
                    break;
                case "OemMinus":
                    textBox_bindKey.Text = "-";
                    break;
                case "Oemplus":
                    textBox_bindKey.Text = "=";
                    break;
                case "Return":
                    textBox_bindKey.Text = "enter";
                    break;
                case "OemPeriod":
                    textBox_bindKey.Text = ".";
                    break;
                case "Oemcomma":
                    textBox_bindKey.Text = ",";
                    break;
                case "ControlKey":
                    textBox_bindKey.Text = "Ctrl";
                    break;
                case "ShiftKey":
                    textBox_bindKey.Text = "Shift";
                    break;
                case "Oem5":
                    textBox_bindKey.Text = @"\";
                    break;
                #endregion
                default:
                    textBox_bindKey.Text=e.KeyCode.ToString().ToLower();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string BindCmd, KeyCmd = "", key = "";

            #region 指令选择
            if (cmd_he.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!he";
            }
            else if (cmd_lol.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "lol";
            }
            else if (cmd_mov.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!mov";
            }
            else if (cmd_decoy.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!decoy";
            }
            else if (cmd_hide.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!hide";
            }
            else if (cmd_rtv.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "rtv";
            }
            else if (cmd_smoke.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!smoke";
            }
            else if (cmd_gun.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!guns";
            }
            else if (cmd_flash.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!flash";
            }
            else if (cmd_ammo.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!zammo";
            }
            else if (cmd_buyawp.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!zbuy awp";
            }
            else if (cmd_vip.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!v";
            }
            else if (cmd_Mainbuy.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!ammo";
            }
            else if (cmd_fullbuy.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!buyammo2";
            }
            else if (cmd_tp.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!tp";
            }
            else if (cmd_ta.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!ta";
            }
            else if (cmd_stopmap.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!dj";
            }
            else if (cmd_stopsound.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!stopsound";
            }
            else if (cmd_revote.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!revote";
            }
            else if (cmd_timeleft.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "timeleft";
            }
            else if (cmd_ness.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!ness";
            }
            else if (cmd_credits.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!credits";
            }
            else if (cmd_pb.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!pb";
            }
            else if (cmd_unpb.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!unpb";
            }
            else if (cmd_nextmap.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "nextmap";
            }
            else if (cmd_armor.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!armor";
            }
            else if (cmd_nvg.Checked)
            {
                key = textBox_bindKey.Text.ToString();
                KeyCmd = "!nvg";
            }
            #endregion
            if (key.Length > 0)
            {
                BindCmd = string.Format("\r\nbind \"{0}\" \"say {1} {2}\"", key, KeyCmd, textBox_Out.Text.ToString());
                textBox_KeyCmd.AppendText(BindCmd);
            }
            else
            {
                MessageBox.Show("请输入正确的按键代码!");
            }
            //写入
            StreamWriter sw = new StreamWriter(textBox_CSGOPath.Text + @"\csgo\cfg\bind.cfg");
            sw.WriteLine(textBox_KeyCmd.Text.ToString());
            sw.Flush();//文件流
            sw.Close();//最后要关闭写入状态
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CSGO目录浏览
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择CSGO文件";
            dialog.Filter = "可执行文件(*.exe)|*.exe|所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StringBuilder sr = new StringBuilder(1024);
                sr.Append(dialog.FileName);
                WIN32API._DeleteSuffix(sr,'\\');
                if (File.Exists(sr.ToString() + "\\csgo.exe"))
                {
                    textBox_CSGOPath.Text = sr.ToString();
                    _form1.SetCSGOPath(textBox_CSGOPath.Text);
                    WIN32API.WritePrivateProfileString("Steam", "CSGOPath", textBox_CSGOPath.Text, Application.StartupPath + "\\Config.ini");
                }
            }
        }
    }
}
