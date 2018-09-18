using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft;
using System.IO;

namespace ZElauncher
{
    public partial class Form_MapInfo : Form
    {
        Form1 _form1;
        static int OldRun = 0;
        static string OldKey;
        public Form_MapInfo()
        {
            InitializeComponent();
        }
        public Form_MapInfo(Form1 forme):this()
        {
            _form1 = forme;
        }
        private void Form_MapInfo_Load(object sender, EventArgs e)
        {
            //初始化地图列表
            listView_Map.Columns.Add("地图名");
            listView_Map.Columns[0].Width = 300;
            listView_Map.Columns.Add("类型");
            listView_Map.Columns[1].Width = 60;
            listView_Map.Columns.Add("时间");
            listView_Map.Columns[2].Width = 120;
            listView_Map.Columns.Add("大小");
            listView_Map.Columns[3].Width = 60;
            listView_Map.Columns.Add("地图状态");
            listView_Map.Columns[4].Width = 100;
            listView_Map.Columns.Add("下载地址");
            listView_Map.Columns[5].Width = 300;
        }
        private void InitMapList(string Type)
        {
            try
            {
                //变量
                string Result;
                byte[] bjson;
                JArray jar;
                listView_Map.Items.Clear();
                _form1.SetDebugString("正在搜索地图中,请耐心等待......");
                switch (Type)
                {

                    case "ze/zm":
                        #region 僵尸逃跑/感染
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/ze.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                            int index = listView_Map.Items.Count;//获取数组值
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if(File.Exists(_form1.GetCSGOPath()+@"\csgo\maps\"+ tempo["mapname"].ToString()+".bsp")){
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/zm.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                            int index = listView_Map.Items.Count;//获取数组值
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        #endregion 
                        break;
                    case "mg/hg/de":
                        #region 对抗/混战/死斗
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/mgdk.html");
                        //字符转换;
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析;
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点;
                            //获取数组值;
                            int index = listView_Map.Items.Count;
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/hg.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                                                                             //获取数组值
                            int index = listView_Map.Items.Count;
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/csde.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                                                                             //获取数组值
                            int index = listView_Map.Items.Count;
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        #endregion
                        break;
                    case "awp":
                        #region AWP
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/awp.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                            int index = listView_Map.Items.Count;//获取数组值
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        #endregion
                        break;
                    case "ttt/jb":
                        #region 越狱/叛徒
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/ttt.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                            int index = listView_Map.Items.Count;//获取数组值
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/jb.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                            int index = listView_Map.Items.Count;//获取数组值
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        #endregion
                        break;
                    case "kz/bhop/surf":
                        #region kz/bhop/surf
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/kz.html");
                        //字符转换;
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析;
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点;
                            //获取数组值;
                            int index = listView_Map.Items.Count;
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/bhop.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                                                                             //获取数组值
                            int index = listView_Map.Items.Count;
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        Result = WIN32API.GetContentFromUrl("http://xnetsoft2.93x.net:9295/mapdata/surf.html");
                        //字符转换
                        bjson = Encoding.GetEncoding("GBK").GetBytes(Result);
                        Result = Encoding.GetEncoding("GBK").GetString(bjson);
                        jar = JArray.Parse(Result);//数组解析
                        for (int i = 0; i < jar.Count; i++)
                        {
                            JObject tempo = JObject.Parse(jar[i].ToString());//获取数组节点
                                                                             //获取数组值
                            int index = listView_Map.Items.Count;
                            listView_Map.Items.Add(tempo["mapname"].ToString());
                            listView_Map.Items[index].SubItems.Add(tempo["type"].ToString());
                            long DateTime;
                            long.TryParse(tempo["timestamp"].ToString(), out DateTime);
                            listView_Map.Items[index].SubItems.Add(WIN32API.UnixToDateTime(tempo["timestamp"].ToString()));
                            listView_Map.Items[index].SubItems.Add(WIN32API.GetSizeKB(tempo["size"].ToString()));
                            if (File.Exists(_form1.GetCSGOPath() + @"\csgo\maps\" + tempo["mapname"].ToString() + ".bsp"))
                            {
                                listView_Map.Items[index].SubItems.Add("已存在");
                            }
                            else
                            {
                                listView_Map.Items[index].SubItems.Add("需要下载");
                            }
                            listView_Map.Items[index].SubItems.Add(tempo["download"].ToString());
                        }
                        #endregion
                        break;
                    default:
                        break;
                }
                _form1.SetDebugString(string.Format("当前地图数量[{0}],已完成地图搜索", listView_Map.Items.Count));
            }
            catch (Exception ex)
            {
                _form1.SetDebugString(ex.Message.ToString());
            }
        }
        private void ZEZMMap()
        {
                /*string input = WIN32API.GetContentFromUrl("http://gomaps.93x.net/fastdlze/maps/");
                string pattern = "<a href=\"(.+.bsp.bz2)\">";
                foreach (Match match in Regex.Matches(input, pattern))
                {
                }*/
            }
        #region 地图类型选择
        private void button_Server_ZE_Click(object sender, EventArgs e)
        {
            InitMapList("ze/zm");
        }
        private void button_Server_MG_Click(object sender, EventArgs e)
        {
            InitMapList("mg/hg/de");
        }
        private void button_Server_TTT_Click(object sender, EventArgs e)
        {
            InitMapList("ttt/jb");
        }
        private void button_Server_AWP_Click(object sender, EventArgs e)
        {
            InitMapList("awp");
        }
        private void button_Server_KZ_Click(object sender, EventArgs e)
        {
            InitMapList("kz/bhop/surf"); 
        }
        private void listView_Map_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (listView_Map.Items.Count > 0)
                {
                    int Runti = Environment.TickCount;
                    if (Runti - OldRun < 1800)
                    {
                        if (e.KeyChar == '\b')
                        {
                            if (OldKey.Length > 0)
                            {
                                OldKey = OldKey.Remove(OldKey.Length - 1, 1);
                            }
                        }
                        else
                        {
                            OldKey = OldKey + e.KeyChar.ToString();
                        }
                    }
                    else
                    {
                        if (e.KeyChar == '\b')
                        {
                            OldKey = "";
                        }
                        else
                        {
                            OldKey = e.KeyChar.ToString();
                        }
                    }
                    OldRun = Environment.TickCount;
                    ListViewItem foundItem = listView_Map.FindItemWithText(OldKey, false, 0, true);
                    if (foundItem != null)
                    {
                        foundItem.Selected = true;

                    }
                    _form1.SetDebugString(string.Format("正在搜索:[{0}]", OldKey));
                }
            }
            catch (Exception ex)
            {
                _form1.SetDebugString(ex.Message.ToString());
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void 复制下载地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = listView_Map.FocusedItem.SubItems[5].Text;
            Clipboard.SetText(data);

        }
        private void listView_Map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point ms = new Point();
                ms.X = Control.MousePosition.X;
                ms.Y = Control.MousePosition.Y;
                ListMap.Show(ms);
            }
        }

        private void 下载地图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("等待完成...");
        }

        private void 复制地图名字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = listView_Map.FocusedItem.SubItems[0].Text;
            Clipboard.SetText(data);
        }
    }
}
