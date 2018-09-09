using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Diagnostics;

using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace ZElauncher
{
    public partial class Form_MainPage : Form
    {

        public Form_MainPage()
        {
            InitializeComponent();
        }
        //全局变量
        //创建定时器对象
        System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer time_RefreshServer = new System.Windows.Forms.Timer();
        string ServerMode = new string(new char[256]);
        static string QueueIPO = new string(new char[256]);
        static bool IsQueue = false;
        private Form1 _form1;
        private static IPEndPoint epServer;
        private static UdpClient local;
        static string SVNowMap = null, SVNowName = null;
        int SVMaxPlayer = 0,  SVNowPlayer= 0;
        private void UDPGetServerInfo()
        {
           try
           {
                //设置服务器端IP和端口
                string itemtext = QueueIPO;
                string[] sArray = Regex.Split(itemtext, ":", RegexOptions.IgnoreCase);
                int pri = 0;
                int.TryParse(sArray[1].ToString(), out pri);
                epServer = new IPEndPoint(IPAddress.Parse(sArray[0].ToString()), pri);
                local = new UdpClient(911);    //绑定本机IP和端口，9001
                byte[] strSend = new byte[] { 0xff, 0xff, 0xff, 0xff };
                byte[] data = new byte[1024];
                strSend.CopyTo(data, 0);
                string str = "TSource Engine Query";
                Buffer.BlockCopy(data, strSend.Length, Encoding.Default.GetBytes(str), 0, str.Length);
                Array.Copy(Encoding.Default.GetBytes(str), 0, data, 4, str.Length);
                //发送UDP数据到服务器
                local.Send(data, data.Length, epServer);
                //开始异步接收启动一个线程，该线程启动函数是：ReceiveCallback，该函数中结束挂起的异步接收
                local.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
           catch (System.Exception ex)
           {
                _form1.SetDebugString(ex.Message.ToString());
           }

        }
        //接收数据返回信息
        private void ReceiveCallback(IAsyncResult iar)
        {
            try
            {
                byte[] receiveData = local.EndReceive(iar, ref epServer);
                int infnum = 0;
                int[] ServerInfo = new int[20];
                //判断是否正确返回
                if (receiveData[4] == 0x49)
                {
                    //跳过头协议
                    byte[] RevData = receiveData.Skip(9).ToArray();
                    //记录分割数据段
                    for (int i = 0; i < RevData.Length; i++)
                    {
                        if (i + 1 <= RevData.Length - 1)
                        {
                            if (RevData[i] == 0x0 && RevData[i + 1] != 0x0)
                            {
                                infnum++;
                                ServerInfo[infnum] = i + 1;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    //UTF8转GB2312;
                    Encoding utf8 = Encoding.UTF8;
                    Encoding gb2312 = Encoding.GetEncoding("gb2312");
                    byte[] gb2312Bytes = new byte[1];
                    string ServerName = null, MapName = null, GameName = null;
                    int MaxPlayer = 0, NowPlayer = 0;
                    //从协议数据分段中提取服务器信息
                    for (int i = 0; i < infnum; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                ServerName = gb2312.GetString(gb2312Bytes);
                                break;
                            case 1:
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                MapName = gb2312.GetString(gb2312Bytes);
                                break;
                            case 3:
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                GameName = gb2312.GetString(gb2312Bytes);
                                break;
                            case 4:
                                gb2312Bytes = RevData.Skip(ServerInfo[i]).ToArray();
                                if (gb2312Bytes[0] == 0xDA && gb2312Bytes[1] == 0x02)
                                {
                                    NowPlayer = gb2312Bytes[2];
                                    MaxPlayer = gb2312Bytes[3];
                                }
                                break;
                        }
                    }
                    SVMaxPlayer = MaxPlayer;
                    SVNowPlayer = NowPlayer;
                    SVNowMap = MapName;
                    SVNowName = ServerName;
                }
                local.Close();
            }
            catch (System.Exception ex)
            {
                _form1.SetDebugString(ex.Message.ToString());
            }
        }
        private void Form_MainPage_Load(object sender, EventArgs e)
        {
            StringBuilder CnCheck = new StringBuilder(70);
            WIN32API.GetPrivateProfileString("Steam", "IsChina", null, CnCheck, 70, Application.StartupPath + "\\Config.ini");
            if (string.Compare(CnCheck.ToString(), "False") == 0)
            {
                checkBox_CN.Checked = false;
            }
            else
            {
                checkBox_CN.Checked = true;
            }
            //初始化服务器列表
            listView_Server.Columns.Add("服务器名");
            listView_Server.Columns[0].Width = 300;
            listView_Server.Columns.Add("地图名");
            listView_Server.Columns[1].Width = 150;
            listView_Server.Columns.Add("人数");
            listView_Server.Columns.Add("IP:端口");
            listView_Server.Columns[3].Width = 100;
            listView_Server.Columns.Add("地区");
            listView_Server.Columns[4].Width = 80;
            WIN32API.GetPrivateProfileString("Config", "ServerMode", null, CnCheck, 70, Application.StartupPath + "\\Config.ini");
            if (string.Compare(CnCheck.ToString(), "") == 1)
            {
                ServerMode = CnCheck.ToString();
            }
            else
            {
                ServerMode = "all";
            }
            InitServerListInfo(ServerMode);
            //服务器列表刷新定时器;
            time_RefreshServer.Enabled = true;
            time_RefreshServer.Interval = 8 * 1000;//3Secound;
            time_RefreshServer.Tick += new EventHandler(ServerRefreshEvent);
            time_RefreshServer.Start();
            InitSteamPath();
            RefreshMyInfo();
        }
        //初始化我的信息
        private void RefreshMyInfo()
        {
            if (_form1.GetSignState() == false)
            {
                label_NickName.Text = "未登录";
                label_NowMap.Text = "未登录";
                label_ServerNumber.Text = "未登录";
                label_SteamID.Text = "未登录";
                label_MapState.Text = "未登录";
                label_NowServer.Text = "未登录";
                label_ServerTick.Text = "未登录";
                label_Yezi.Text = "未登录";
                label_integral.Text = "未登录";
                label_OnlineTime.Text = "未登录";
                label_NextMap.Text = "未登录";
                label_SignDay.Text = "未登录";
            }
        }
        //重构传参构造函数
        public Form_MainPage(Form1 form): this()
        {
            _form1 = form;
        }
        #region 服务器操作
        //获取Steam目录
        private void InitSteamPath()
        {
            try
            {
                StringBuilder SteamPath = new StringBuilder(1024);
                WIN32API.GetPrivateProfileString("Steam", "Path", null, SteamPath, 1024, Application.StartupPath + "\\Config.ini");
                if (SteamPath.Length > 6)
                {
                    return;
                }
                string registData;
                RegistryKey hkml = Registry.LocalMachine;
                RegistryKey software = hkml.OpenSubKey("SOFTWARE", false);
                RegistryKey aimdir = software.OpenSubKey("Classes\\steam\\Shell\\Open\\Command", false);
                registData = aimdir.GetValue(null).ToString();
                string[] sArray = Regex.Split(registData, "\"", RegexOptions.IgnoreCase);
                WIN32API.WritePrivateProfileString("Steam", "Path", sArray[1].ToString(), Application.StartupPath + "\\Config.ini");
            }
            catch (Exception e)
            {
                WIN32API.WritePrivateProfileString("Steam", "Path", "Error", Application.StartupPath + "\\Config.ini");
                _form1.SetDebugString(e.Message.ToString());
            }
        }
        //地图是否存在
        private bool IsMapExist(string mapName)
        {
            StringBuilder Path = new StringBuilder(1024);
            Path.Append("F:\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\maps\\");
            Path.Append(mapName);
            Path.Append(".bsp");
            return File.Exists(Path.ToString());
        }
        //获取网页数据(无Cookies)
        private string GetContentFromUrl(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Credentials = CredentialCache.DefaultCredentials;//获取或设置请求凭据
                Byte[] pageData = client.DownloadData(url); //下载数据
                string pageHtml = System.Text.Encoding.UTF8.GetString(pageData);
                return pageHtml;
            }
            catch (WebException ex)
            {
                return ex.Message;
            }
        }
        //刷新服务器列表
        protected void InitServerListInfo(string mode)
        {
            string json = GetContentFromUrl("http://servers.93x.net/api/servers?region=global");
            try
            {
                listView_Server.Items.Clear();
                //字符转换
                byte[] bjson = Encoding.GetEncoding("GBK").GetBytes(json);
                json = Encoding.GetEncoding("GBK").GetString(bjson);
                JArray jlist = JArray.Parse(json);//数组解析
                for (int i = 0; i < jlist.Count; i++)
                {
                    JObject tempo = JObject.Parse(jlist[i].ToString());//获取数组节点
                    //获取数组值
                    int index = 0;
                    switch (mode)
                    {
                        case "ze":
                            #region 僵尸逃跑/感染
                            if (string.Compare(tempo["mode"].ToString(), "ze") == 0
                                || string.Compare(tempo["mode"].ToString(), "zm") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "all":
                            #region 显示所有服务器
                            index = listView_Server.Items.Count;
                            listView_Server.Items.Add(tempo["name"].ToString());
                            listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                            listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                            listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                            listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            #endregion
                            break;
                        case "kz":
                            #region KZ/Surf/Bhop
                            if (string.Compare(tempo["mode"].ToString(), "kz") == 0
                                || string.Compare(tempo["mode"].ToString(), "bhop") == 0
                                || string.Compare(tempo["mode"].ToString(), "surf") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "mg":
                            #region 娱乐对战/混战
                            if (string.Compare(tempo["mode"].ToString(), "mg") == 0
                                || string.Compare(tempo["mode"].ToString(), "tdm") == 0
                                || string.Compare(tempo["mode"].ToString(), "hg") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "awp":
                            #region 狙击模式
                            if (string.Compare(tempo["mode"].ToString(), "awp") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "ttt":
                            #region TT叛徒
                            if (string.Compare(tempo["mode"].ToString(), "ttt") == 0
                                || string.Compare(tempo["mode"].ToString(), "jb") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "ffa":
                            #region 死斗/死亡
                            if (string.Compare(tempo["mode"].ToString(), "dr") == 0
                                || string.Compare(tempo["mode"].ToString(), "dm") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "cat":
                            #region 躲猫猫
                            if (string.Compare(tempo["mode"].ToString(), "hns") == 0
                                || string.Compare(tempo["mode"].ToString(), "db") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "idle":
                            #region 挂机/合成
                            if (string.Compare(tempo["mode"].ToString(), "idle") == 0
                                || string.Compare(tempo["mode"].ToString(), "other") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                        case "solo":
                            #region 单挑/SOLO
                            if (string.Compare(tempo["mode"].ToString(), "1v1") == 0
                                || string.Compare(tempo["mode"].ToString(), "solo") == 0
                                )
                            {
                                index = listView_Server.Items.Count;
                                listView_Server.Items.Add(tempo["name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["map_name"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["players"].ToString() + "/" + tempo["max_players"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["ip"].ToString() + ":" + tempo["port"].ToString());
                                listView_Server.Items[index].SubItems.Add(tempo["comments"].ToString());
                            }
                            #endregion
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                _form1.SetDebugString(e.Message.ToString());
            }

        }
        //服务器刷新定时器事件
        private void ServerRefreshEvent(object sender, EventArgs e)
        {
            InitServerListInfo(ServerMode);
        }
        #endregion
        //国服/国际服模式
        private void checkBox_CN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_CN.Checked == false)
            {
                WIN32API.WritePrivateProfileString("Steam", "IsChina", "False", Application.StartupPath + "\\Config.ini");
            }
            else
            {
                WIN32API.WritePrivateProfileString("Steam", "IsChina", "True", Application.StartupPath + "\\Config.ini");
            }
        }
        #region 服务器模式转换
        private void SaveServerMode()
        {
            WIN32API.WritePrivateProfileString("Config", "ServerMode", ServerMode, Application.StartupPath + "\\Config.ini");
        }
        private void button_Server_ALL_Click(object sender, EventArgs e)
        {
            ServerMode = "all";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_ZE_Click(object sender, EventArgs e)
        {
            ServerMode = "ze";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_MG_Click(object sender, EventArgs e)
        {
            ServerMode = "mg";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_Solo_Click(object sender, EventArgs e)
        {
            ServerMode = "solo";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_TTT_Click(object sender, EventArgs e)
        {
            ServerMode = "ttt";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_AWP_Click(object sender, EventArgs e)
        {
            ServerMode = "awp";
            InitServerListInfo(ServerMode);
        }
        private void button_Server_FFA_Click(object sender, EventArgs e)
        {
            ServerMode = "ffa";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_KZ_Click(object sender, EventArgs e)
        {
            ServerMode = "kz";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_Cat_Click(object sender, EventArgs e)
        {
            ServerMode = "cat";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        private void button_Server_idle_Click(object sender, EventArgs e)
        {
            ServerMode = "idle";
            InitServerListInfo(ServerMode);
            SaveServerMode();
        }
        #endregion
        //服务器列表 鼠标键
        private void listView_Server_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ms=new Point();
                ms.X = Control.MousePosition.X;
                ms.Y = Control.MousePosition.Y;
                ListMenu.Show(ms);
            }
        }
        //睡眠延迟;
        private void Sleep(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                Application.DoEvents();
            }
        }
        //启动游戏
        private void LauncherGame(string IPO)
        {
            if (WIN32API.IsProcessExist("csgo"))
            {
                Process.Start("steam://connect/" + IPO, null);
                _form1.SetDebugString(string.Format("小X加入[{0}]服务器队列啦,[Master]游戏愉快(～o￣▽￣)～o", IPO));
            }
            else
            {
                string r;
                if (checkBox_CN.Checked)
                {
                    r = string.Format("-applaunch 730 -perfectworld -novid +connect {0}", IPO);
                }
                else
                {
                    r = string.Format("-applaunch 730 -worldwide -novid +connect {0}", IPO);
                }
                Process.Start(_form1.GetSteamPath(), r);
                Sleep(3000);
                _form1.SetDebugString(string.Format("小X终于挤进[{0}]服务器队列啦,[Master]游戏愉快(～o￣▽￣)～o", IPO));
            }
            label_ServerTick.Text = "服务器队列中";
        }
        //队列时钟事件
        private void TimerEvent(object sender, EventArgs e)
        {
            if (IsQueue)
            {
                try
                {
                    label_ServerTick.Text = "正在排队中....";
                    //使用UDP获取服务器人数排队
                    UDPGetServerInfo();
                    label_NowMap.Text = SVNowMap;
                    label_ServerNumber.Text=SVNowPlayer.ToString()+"/"+ SVMaxPlayer.ToString();
                    label_NowServer.Text = SVNowName;
                    if (SVNowPlayer < SVMaxPlayer)
                    {
                        label_ServerTick.Text = "正在进入服务器....";
                        listView_Server.Text = string.Format("小X提示:迷路的小X终于找到座位啦,正在进入[{0}]服务器队列!", QueueIPO);
                        IsQueue = false;
                        LauncherGame(QueueIPO);
                        time.Stop();
                    }
                    else
                    {
                        _form1.SetDebugString(string.Format("小X提示:[{0}]服务器人数< {1} >,小X正在努力为您排队中,请耐心等待!", QueueIPO, SVNowPlayer));
                    }
                }
                catch (System.Exception ex)
                {
                    _form1.SetDebugString(string.Format("小X提示:{0}", ex.Message.ToString()));
                }
            }
        }
        private void StartQueue()
        {
            UDPGetServerInfo();
            time.Enabled = true;
            time.Interval = 3 * 1000; //4Secound
            time.Tick += new EventHandler(TimerEvent);
            time.Start();
        }
        //加入游戏
        private void JoinGame()
        {
            try
            {
                string itemtext = listView_Server.FocusedItem.SubItems[2].Text.ToString();
                label_ServerNumber.Text = itemtext;
                label_NowServer.Text= listView_Server.FocusedItem.Text.ToString(); 
                label_NowMap.Text= listView_Server.FocusedItem.SubItems[1].Text.ToString();
                QueueIPO = listView_Server.FocusedItem.SubItems[3].Text.ToString();
                if (IsMapExist(label_NowMap.Text))
                {
                    label_MapState.Text = "地图已安装";
                }
                else
                {
                    label_MapState.Text = "无法找到地图";
                }
                string[] sArray = Regex.Split(itemtext, "/", RegexOptions.IgnoreCase);
                int hint, mint;
                if (int.TryParse(sArray[0].ToString(), out hint))
                {
                    if (int.TryParse(sArray[1].ToString(), out mint))
                    {
                        if (hint >= mint)
                        {
                            hint = listView_Server.FocusedItem.Index;
                            if (MessageBox.Show("服务器已满,是否开启排队?", "小X提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (IsQueue)
                                {
                                    if (MessageBox.Show("[Master]小X正在拼命的排队,需要小X换个服务器队列吗?_?", "小X提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    {
                                        return;
                                    }
                                }
                                IsQueue = true;
                                StartQueue();
                                label_ServerTick.Text = "开始请求队列信息...";
                                _form1.SetDebugString(string.Format("小X正在努力的帮助[Master]挤[{0}]服务器队列,请耐心等待排队结果ヾ|≧_≦|〃",
                                    listView_Server.Items[hint].SubItems[3].Text));
                            }
                        }
                        else
                        {
                            IsQueue = false;
                            time.Stop();
                            _form1.SetDebugString(string.Format("[Master]进入其他服务器队列,小X正在退出战斗前线ヾ|≧_≦|〃",
                                listView_Server.FocusedItem.SubItems[3].Text));
                            LauncherGame(listView_Server.FocusedItem.SubItems[3].Text);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                _form1.SetDebugString(ex.Message.ToString());
            }
        }
        private void 加入服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JoinGame();
        }
        private void 刷新列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitServerListInfo(ServerMode);
        }

        private void listView_Server_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            JoinGame();
        }

        private void button_YaoYaole_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_flsh_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_MineGame_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_HappyGay_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_Ban_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_Shop_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_VIP_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void button_MyDisk_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }

        private void 显示详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form_ServerInfo Serinfo = new Form_ServerInfo();
                Serinfo.SetIPO(listView_Server.FocusedItem.SubItems[3].Text.ToString());
                Serinfo.Show();
            }
            catch (System.Exception ex)
            {
                _form1.SetDebugString(ex.Message.ToString());
            }
        }

        private void button_SignToDay_Click(object sender, EventArgs e)
        {
            if (_form1.GetSignState())
            {

            }
            else
            {
                MessageBox.Show("你没有登录请登录后在操作!");
            }
        }
    }
}
