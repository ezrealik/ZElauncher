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

namespace ZElauncher
{
    public partial class Form_MapInfo : Form
    {
        public Form_MapInfo()
        {
            InitializeComponent();
        }

        private void Form_MapInfo_Load(object sender, EventArgs e)
        {
            //初始化地图列表
            listView_Map.Columns.Add("地图名");
            listView_Map.Columns[0].Width = 300;
            listView_Map.Columns.Add("类型");
            listView_Map.Columns[1].Width = 150;
            listView_Map.Columns.Add("时间");
            listView_Map.Columns[2].Width = 150;
            listView_Map.Columns.Add("大小");
            listView_Map.Columns[3].Width = 130;
        }
        private void InitMapList(string Type)
        {
            switch (Type)
            {
                

            }
        }
        private void ZEMap()
        {
            string input = WIN32API.GetContentFromUrl("http://gomaps.93x.net/fastdlze/maps/");
            string pattern = "<a href=\"(.+.bsp.bz2)\">";

            foreach (Match match in Regex.Matches(input, pattern))
            {

            }
        }
    }
}
