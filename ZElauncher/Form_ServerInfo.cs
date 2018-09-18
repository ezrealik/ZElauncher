using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZElauncher
{
    public partial class Form_ServerInfo : Form
    {
        public Form_ServerInfo()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        static string IPOR = null;
        private static IPEndPoint epServer;
        private static UdpClient local;
        static Stopwatch sw = new Stopwatch();
        public void SetIPO(string IPO)
        {
            IPOR = IPO;
        }
        private void Form_ServerInfo_Load(object sender, EventArgs e)
        {
            //初始化服务器列表
            listView_PlayerInfo.Columns.Add("玩家名字");
            listView_PlayerInfo.Columns[0].Width = 170;
            listView_PlayerInfo.Columns.Add("比分");
            listView_PlayerInfo.Columns[1].Width = 60;
            listView_PlayerInfo.Columns.Add("时间");
            listView_PlayerInfo.Columns[2].Width = 80;

            UDPGetSvInfo();
        }
        //发送获取服务器信息数据
        private void UDPGetSvInfo()
        {
            try
            {
                sw.Restart();
                //设置服务器端IP和端口
                string itemtext = IPOR;
                string[] sArray = Regex.Split(itemtext, ":", RegexOptions.IgnoreCase);
                int pri = 0;
                int.TryParse(sArray[1].ToString(), out pri);
                epServer = new IPEndPoint(IPAddress.Parse(sArray[0].ToString()), pri);
                local = new UdpClient(911);    //绑定本机IP和端口，9001
                byte[] strSend = new byte[] { 0xff, 0xff, 0xff, 0xff };
                byte[] data = new byte[1024];
                strSend.CopyTo(data, 0);
                string str = "TSource Engine Query";
                Array.Copy(Encoding.Default.GetBytes(str), 0, data, 4, str.Length);
                //发送UDP数据到服务器
                local.Send(data, data.Length, epServer);
                //开始异步接收启动一个线程，该线程启动函数是：ReceiveCallback，该函数中结束挂起的异步接收
                local.BeginReceive(new AsyncCallback(ReceiveCallback), null);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        //发送获取玩家列表Key数据
        private void UDPGetServerInfo()
        {
            try
            {
                //设置服务器端IP和端口
                string itemtext = IPOR;
                string[] sArray = Regex.Split(itemtext, ":", RegexOptions.IgnoreCase);
                int pri = 0;
                int.TryParse(sArray[1].ToString(), out pri);
                epServer = new IPEndPoint(IPAddress.Parse(sArray[0].ToString()), pri);
                local = new UdpClient(911);    //绑定本机IP和端口，911
                //ff:ff:ff:ff:55:00:00:00:00 //获取服务器Key值
                byte[] strSend = new byte[] { 0xff, 0xff, 0xff, 0xff ,0x55,0x00, 0x00, 0x00, 0x00 };
                //发送UDP数据到服务器
                local.Send(strSend, strSend.Length, epServer);
                //开始异步接收启动一个线程，该线程启动函数是：ReceiveCallback，该函数中结束挂起的异步接收
                local.BeginReceive(new AsyncCallback(ReceiveCallback2), null);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        //发送获取玩家列表数据
        private void UDPGetPlayerInfo(byte[] data)
        {
            try
            {
                //设置服务器端IP和端口
                listView_PlayerInfo.Items.Clear();
                string itemtext = IPOR;
                string[] sArray = Regex.Split(itemtext, ":", RegexOptions.IgnoreCase);
                int pri = 0;
                int.TryParse(sArray[1].ToString(), out pri);
                epServer = new IPEndPoint(IPAddress.Parse(sArray[0].ToString()), pri);
                local = new UdpClient(110);    //绑定本机IP和端口，911
                //ff:ff:ff:ff:55:40:5b:6c:1a //获取服务器玩家信息
                byte[] strSend = new byte[] { 0xff, 0xff, 0xff, 0xff, 0x55, 0x00, 0x00, 0x00, 0x00 };
                Array.Copy(data, 0, strSend, 5, 4);
                //发送UDP数据到服务器
                local.Send(strSend, strSend.Length, epServer);
                //开始异步接收启动一个线程，该线程启动函数是：ReceiveCallback，该函数中结束挂起的异步接收
                local.BeginReceive(new AsyncCallback(ReceiveCallback2), null);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        //接收数据返回信息0x49 服务器信息
        private void ReceiveCallback(IAsyncResult iar)
        {
            try
            {
                byte[] receiveData = local.EndReceive(iar, ref epServer);
                int infnum = 0;
                int[] ServerInfo = new int[20];
                byte[] RevData = null;
                //判断是否正确返回 
                #region 分段 0x49协议数据段
                if (receiveData[4] == 0x49)
                {
                    sw.Stop();
                    TimeSpan ts2 = sw.Elapsed;
                    Console.WriteLine(ts2.TotalMilliseconds.ToString());
                    label_ServerTick.Text = Math.Floor(ts2.TotalMilliseconds).ToString() + "ms";
                    //跳过头协议
                    RevData = receiveData.Skip(9).ToArray();
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
                    string ServerName = null, MapName = null, GameName = null, VAC = null;
                    int MaxPlayer = 0, NowPlayer = 0;
                    #region //从协议数据分段中提取服务器信息
                    for (int i = 0; i < infnum; i++)
                    {
                        switch (i)
                        {
                            case 0: //服务器名称
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                ServerName = gb2312.GetString(gb2312Bytes);
                                break;
                            case 1://当前地图
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                MapName = gb2312.GetString(gb2312Bytes);
                                break;
                            case 3://游戏名
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                GameName = gb2312.GetString(gb2312Bytes);
                                break;
                            case 4://玩家数量
                                gb2312Bytes = RevData.Skip(ServerInfo[i]).ToArray();
                                if (gb2312Bytes[0] == 0xDA && gb2312Bytes[1] == 0x02)
                                {
                                    NowPlayer = gb2312Bytes[2];
                                    MaxPlayer = gb2312Bytes[3];
                                }
                                break;
                            case 5:
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(ServerInfo[i]).ToArray());
                                VAC = gb2312.GetString(gb2312Bytes);
                                break;
                        }
                    }
                    label_ServerName.Text = ServerName;
                    label_GameType.Text = GameName;
                    label_NowMap.Text = MapName;
                    label_PlayerNum.Text = NowPlayer.ToString() + "/" + MaxPlayer.ToString();
                    label_VAC.Text = "VAC:" + VAC;
                    #endregion
                }
                #endregion
                local.Close();
                UDPGetServerInfo();
            }
            catch (System.Exception ex)
            {
                local.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //接收数据返回信息0x44 0x41 玩家信息
        private void ReceiveCallback2(IAsyncResult iar)
        {
            try
            {
                byte[] receiveData = local.EndReceive(iar, ref epServer);
                byte[] RevData = null;
                //处理key数据包
                if (receiveData[4] == 0x41&&receiveData[5]!=0x0 && receiveData[6] != 0x0)
                {
                    //跳过头协议
                    RevData = receiveData.Skip(5).ToArray();
                    local.Close();
                    UDPGetPlayerInfo(RevData);
                    return;
                }
                //处理玩家信息数据
                else if (receiveData[4] == 0x44)
                {
                    //跳过头协议
                    RevData = receiveData.Skip(7).ToArray();
                    int i = 0, OldLocal = 0;
                    bool IsFor = true;
                    while(IsFor)
                    {
                        if (i + 1 < RevData.Length)
                        {
                            if (RevData[i] == 0x00)
                            {
                                //移动数据指针位置
                                i++;
                                //UTF8转GB2312;
                                Encoding utf8 = Encoding.UTF8;
                                Encoding gb2312 = Encoding.GetEncoding("gb2312");
                                byte[] gb2312Bytes = null;
                                int PlayerCore = 0, Index = 0, Time = 0;
                                //获取玩家分数
                                gb2312Bytes = RevData.Skip(i).ToArray();
                                PlayerCore = BitConverter.ToInt32(gb2312Bytes, 0);
                                //移动数据指针位置
                                i+=4;
                                //转换UTF8玩家名字
                                gb2312Bytes = Encoding.Convert(utf8, gb2312, RevData.Skip(OldLocal).ToArray());
                                string tmpstr = gb2312.GetString(gb2312Bytes);
                                //添加到服务器列表框中
                                Index = listView_PlayerInfo.Items.Count;
                                listView_PlayerInfo.Items.Add(tmpstr);
                                listView_PlayerInfo.Items[Index].SubItems.Add(PlayerCore.ToString());
                                //获取玩家时间
                                gb2312Bytes = RevData.Skip(i).ToArray();
                                Time = BitConverter.ToInt32(gb2312Bytes, 0);
                                Time -= 1058216820;
                                Time /= 36000;
                                Time /= 60;
                                listView_PlayerInfo.Items[Index].SubItems.Add(Time.ToString());
                                //记录玩家名字出现的位置
                                i += 5;
                                OldLocal = i;
                            }else
                            {
                                i++;
                            }
                            if (i + 1 >= RevData.Length)
                            {
                                IsFor = false;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    local.Close();
                    return;
                }
                local.Close();
            }
            catch (System.Exception ex)
            {
                local.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_MinWindows_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Visible = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //判断是否标题栏区域
            if (e.Y < 50 && e.X < 265)
            {
                //为当前应用程序释放鼠标捕获
                WIN32API.ReleaseCapture();
                //发送消息 让系统误以为在标题栏上按下鼠标
                WIN32API.SendMessage((IntPtr)this.Handle, WIN32API.VM_NCLBUTTONDOWN, WIN32API.HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UDPGetSvInfo();
        }
    }
}
