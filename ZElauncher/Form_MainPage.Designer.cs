namespace ZElauncher
{
    partial class Form_MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_CN = new System.Windows.Forms.CheckBox();
            this.button_Server_Cat = new System.Windows.Forms.Button();
            this.button_Server_KZ = new System.Windows.Forms.Button();
            this.button_Server_FFA = new System.Windows.Forms.Button();
            this.button_Server_AWP = new System.Windows.Forms.Button();
            this.button_Server_idle = new System.Windows.Forms.Button();
            this.button_Server_TTT = new System.Windows.Forms.Button();
            this.button_Server_Solo = new System.Windows.Forms.Button();
            this.button_Server_MG = new System.Windows.Forms.Button();
            this.button_Server_ZE = new System.Windows.Forms.Button();
            this.button_Server_ALL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_SystemTip = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_MyDisk = new System.Windows.Forms.Button();
            this.button_Ban = new System.Windows.Forms.Button();
            this.button_flsh = new System.Windows.Forms.Button();
            this.button_VIP = new System.Windows.Forms.Button();
            this.button_Shop = new System.Windows.Forms.Button();
            this.button_HappyGay = new System.Windows.Forms.Button();
            this.button_MineGame = new System.Windows.Forms.Button();
            this.button_SignToDay = new System.Windows.Forms.Button();
            this.button_YaoYaole = new System.Windows.Forms.Button();
            this.label_OnlineTime = new System.Windows.Forms.Label();
            this.label_integral = new System.Windows.Forms.Label();
            this.label_Yezi = new System.Windows.Forms.Label();
            this.label_ServerTick = new System.Windows.Forms.Label();
            this.label_ServerNumber = new System.Windows.Forms.Label();
            this.label_SignDay = new System.Windows.Forms.Label();
            this.label_MapState = new System.Windows.Forms.Label();
            this.label_NextMap = new System.Windows.Forms.Label();
            this.label_NowMap = new System.Windows.Forms.Label();
            this.label_NowServer = new System.Windows.Forms.Label();
            this.label_SteamID = new System.Windows.Forms.Label();
            this.label_NickName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加入服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Server = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox_CN);
            this.groupBox1.Controls.Add(this.button_Server_Cat);
            this.groupBox1.Controls.Add(this.button_Server_KZ);
            this.groupBox1.Controls.Add(this.button_Server_FFA);
            this.groupBox1.Controls.Add(this.button_Server_AWP);
            this.groupBox1.Controls.Add(this.button_Server_idle);
            this.groupBox1.Controls.Add(this.button_Server_TTT);
            this.groupBox1.Controls.Add(this.button_Server_Solo);
            this.groupBox1.Controls.Add(this.button_Server_MG);
            this.groupBox1.Controls.Add(this.button_Server_ZE);
            this.groupBox1.Controls.Add(this.button_Server_ALL);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 96);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器列表";
            // 
            // checkBox_CN
            // 
            this.checkBox_CN.AutoSize = true;
            this.checkBox_CN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBox_CN.Checked = true;
            this.checkBox_CN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CN.ForeColor = System.Drawing.Color.Red;
            this.checkBox_CN.Location = new System.Drawing.Point(113, -2);
            this.checkBox_CN.Name = "checkBox_CN";
            this.checkBox_CN.Size = new System.Drawing.Size(95, 20);
            this.checkBox_CN.TabIndex = 10;
            this.checkBox_CN.Text = "国服启动";
            this.checkBox_CN.UseVisualStyleBackColor = false;
            this.checkBox_CN.CheckedChanged += new System.EventHandler(this.checkBox_CN_CheckedChanged);
            // 
            // button_Server_Cat
            // 
            this.button_Server_Cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_Cat.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_Cat.ForeColor = System.Drawing.Color.Fuchsia;
            this.button_Server_Cat.Location = new System.Drawing.Point(376, 62);
            this.button_Server_Cat.Name = "button_Server_Cat";
            this.button_Server_Cat.Size = new System.Drawing.Size(114, 25);
            this.button_Server_Cat.TabIndex = 9;
            this.button_Server_Cat.Text = "躲猫猫";
            this.button_Server_Cat.UseVisualStyleBackColor = true;
            this.button_Server_Cat.Click += new System.EventHandler(this.button_Server_Cat_Click);
            // 
            // button_Server_KZ
            // 
            this.button_Server_KZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_KZ.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_KZ.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_Server_KZ.Location = new System.Drawing.Point(256, 62);
            this.button_Server_KZ.Name = "button_Server_KZ";
            this.button_Server_KZ.Size = new System.Drawing.Size(114, 25);
            this.button_Server_KZ.TabIndex = 8;
            this.button_Server_KZ.Text = "KZ/Surf/BHOP";
            this.button_Server_KZ.UseVisualStyleBackColor = true;
            this.button_Server_KZ.Click += new System.EventHandler(this.button_Server_KZ_Click);
            // 
            // button_Server_FFA
            // 
            this.button_Server_FFA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_FFA.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_FFA.ForeColor = System.Drawing.Color.Red;
            this.button_Server_FFA.Location = new System.Drawing.Point(134, 62);
            this.button_Server_FFA.Name = "button_Server_FFA";
            this.button_Server_FFA.Size = new System.Drawing.Size(114, 25);
            this.button_Server_FFA.TabIndex = 7;
            this.button_Server_FFA.Text = "死斗/FFA";
            this.button_Server_FFA.UseVisualStyleBackColor = true;
            this.button_Server_FFA.Click += new System.EventHandler(this.button_Server_FFA_Click);
            // 
            // button_Server_AWP
            // 
            this.button_Server_AWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_AWP.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_AWP.ForeColor = System.Drawing.Color.Yellow;
            this.button_Server_AWP.Location = new System.Drawing.Point(14, 62);
            this.button_Server_AWP.Name = "button_Server_AWP";
            this.button_Server_AWP.Size = new System.Drawing.Size(114, 25);
            this.button_Server_AWP.TabIndex = 6;
            this.button_Server_AWP.Text = "狙击战争";
            this.button_Server_AWP.UseVisualStyleBackColor = true;
            this.button_Server_AWP.Click += new System.EventHandler(this.button_Server_AWP_Click);
            // 
            // button_Server_idle
            // 
            this.button_Server_idle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_idle.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_idle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Server_idle.Location = new System.Drawing.Point(496, 62);
            this.button_Server_idle.Name = "button_Server_idle";
            this.button_Server_idle.Size = new System.Drawing.Size(114, 25);
            this.button_Server_idle.TabIndex = 5;
            this.button_Server_idle.Text = "挂机/合成";
            this.button_Server_idle.UseVisualStyleBackColor = true;
            this.button_Server_idle.Click += new System.EventHandler(this.button_Server_idle_Click);
            // 
            // button_Server_TTT
            // 
            this.button_Server_TTT.BackColor = System.Drawing.Color.Transparent;
            this.button_Server_TTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_TTT.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_TTT.ForeColor = System.Drawing.Color.LightCoral;
            this.button_Server_TTT.Location = new System.Drawing.Point(496, 22);
            this.button_Server_TTT.Name = "button_Server_TTT";
            this.button_Server_TTT.Size = new System.Drawing.Size(114, 25);
            this.button_Server_TTT.TabIndex = 4;
            this.button_Server_TTT.Text = "越狱/叛徒";
            this.button_Server_TTT.UseVisualStyleBackColor = false;
            this.button_Server_TTT.Click += new System.EventHandler(this.button_Server_TTT_Click);
            // 
            // button_Server_Solo
            // 
            this.button_Server_Solo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_Solo.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_Solo.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_Server_Solo.Location = new System.Drawing.Point(376, 22);
            this.button_Server_Solo.Name = "button_Server_Solo";
            this.button_Server_Solo.Size = new System.Drawing.Size(114, 25);
            this.button_Server_Solo.TabIndex = 3;
            this.button_Server_Solo.Text = "单挑/Solo";
            this.button_Server_Solo.UseVisualStyleBackColor = true;
            this.button_Server_Solo.Click += new System.EventHandler(this.button_Server_Solo_Click);
            // 
            // button_Server_MG
            // 
            this.button_Server_MG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_MG.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_MG.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_Server_MG.Location = new System.Drawing.Point(256, 22);
            this.button_Server_MG.Name = "button_Server_MG";
            this.button_Server_MG.Size = new System.Drawing.Size(114, 25);
            this.button_Server_MG.TabIndex = 2;
            this.button_Server_MG.Text = "娱乐对战/混战";
            this.button_Server_MG.UseVisualStyleBackColor = true;
            this.button_Server_MG.Click += new System.EventHandler(this.button_Server_MG_Click);
            // 
            // button_Server_ZE
            // 
            this.button_Server_ZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_ZE.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_ZE.ForeColor = System.Drawing.Color.Red;
            this.button_Server_ZE.Location = new System.Drawing.Point(134, 22);
            this.button_Server_ZE.Name = "button_Server_ZE";
            this.button_Server_ZE.Size = new System.Drawing.Size(114, 25);
            this.button_Server_ZE.TabIndex = 1;
            this.button_Server_ZE.Text = "僵尸逃跑/感染";
            this.button_Server_ZE.UseVisualStyleBackColor = true;
            this.button_Server_ZE.Click += new System.EventHandler(this.button_Server_ZE_Click);
            // 
            // button_Server_ALL
            // 
            this.button_Server_ALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_ALL.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_ALL.ForeColor = System.Drawing.Color.Gold;
            this.button_Server_ALL.Location = new System.Drawing.Point(14, 22);
            this.button_Server_ALL.Name = "button_Server_ALL";
            this.button_Server_ALL.Size = new System.Drawing.Size(114, 25);
            this.button_Server_ALL.TabIndex = 0;
            this.button_Server_ALL.Text = "显示所有";
            this.button_Server_ALL.UseVisualStyleBackColor = true;
            this.button_Server_ALL.Click += new System.EventHandler(this.button_Server_ALL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label_OnlineTime);
            this.groupBox2.Controls.Add(this.label_integral);
            this.groupBox2.Controls.Add(this.label_Yezi);
            this.groupBox2.Controls.Add(this.label_ServerTick);
            this.groupBox2.Controls.Add(this.label_ServerNumber);
            this.groupBox2.Controls.Add(this.label_SignDay);
            this.groupBox2.Controls.Add(this.label_MapState);
            this.groupBox2.Controls.Add(this.label_NextMap);
            this.groupBox2.Controls.Add(this.label_NowMap);
            this.groupBox2.Controls.Add(this.label_NowServer);
            this.groupBox2.Controls.Add(this.label_SteamID);
            this.groupBox2.Controls.Add(this.label_NickName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(637, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 601);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "我的信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_SystemTip);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.Brown;
            this.groupBox4.Location = new System.Drawing.Point(6, 453);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 142);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "系统公告";
            // 
            // label_SystemTip
            // 
            this.label_SystemTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_SystemTip.ForeColor = System.Drawing.Color.Red;
            this.label_SystemTip.Location = new System.Drawing.Point(6, 37);
            this.label_SystemTip.Name = "label_SystemTip";
            this.label_SystemTip.Size = new System.Drawing.Size(337, 97);
            this.label_SystemTip.TabIndex = 1;
            this.label_SystemTip.Text = "Normal";
            this.label_SystemTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(128, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "公告:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_MyDisk);
            this.groupBox3.Controls.Add(this.button_Ban);
            this.groupBox3.Controls.Add(this.button_flsh);
            this.groupBox3.Controls.Add(this.button_VIP);
            this.groupBox3.Controls.Add(this.button_Shop);
            this.groupBox3.Controls.Add(this.button_HappyGay);
            this.groupBox3.Controls.Add(this.button_MineGame);
            this.groupBox3.Controls.Add(this.button_SignToDay);
            this.groupBox3.Controls.Add(this.button_YaoYaole);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("楷体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox3.Location = new System.Drawing.Point(6, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 121);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "娱乐/自助";
            // 
            // button_MyDisk
            // 
            this.button_MyDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyDisk.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MyDisk.ForeColor = System.Drawing.Color.HotPink;
            this.button_MyDisk.Location = new System.Drawing.Point(238, 86);
            this.button_MyDisk.Name = "button_MyDisk";
            this.button_MyDisk.Size = new System.Drawing.Size(105, 25);
            this.button_MyDisk.TabIndex = 9;
            this.button_MyDisk.Text = "我的云盘";
            this.button_MyDisk.UseVisualStyleBackColor = true;
            this.button_MyDisk.Click += new System.EventHandler(this.button_MyDisk_Click);
            // 
            // button_Ban
            // 
            this.button_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ban.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Ban.ForeColor = System.Drawing.Color.Fuchsia;
            this.button_Ban.Location = new System.Drawing.Point(238, 55);
            this.button_Ban.Name = "button_Ban";
            this.button_Ban.Size = new System.Drawing.Size(105, 25);
            this.button_Ban.TabIndex = 8;
            this.button_Ban.Text = "封禁查询";
            this.button_Ban.UseVisualStyleBackColor = true;
            this.button_Ban.Click += new System.EventHandler(this.button_Ban_Click);
            // 
            // button_flsh
            // 
            this.button_flsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_flsh.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_flsh.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button_flsh.Location = new System.Drawing.Point(238, 24);
            this.button_flsh.Name = "button_flsh";
            this.button_flsh.Size = new System.Drawing.Size(105, 25);
            this.button_flsh.TabIndex = 7;
            this.button_flsh.Text = "捕鱼兑换";
            this.button_flsh.UseVisualStyleBackColor = true;
            this.button_flsh.Click += new System.EventHandler(this.button_flsh_Click);
            // 
            // button_VIP
            // 
            this.button_VIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VIP.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_VIP.ForeColor = System.Drawing.Color.Maroon;
            this.button_VIP.Location = new System.Drawing.Point(124, 86);
            this.button_VIP.Name = "button_VIP";
            this.button_VIP.Size = new System.Drawing.Size(105, 25);
            this.button_VIP.TabIndex = 6;
            this.button_VIP.Text = "充值VIP/叶子";
            this.button_VIP.UseVisualStyleBackColor = true;
            this.button_VIP.Click += new System.EventHandler(this.button_VIP_Click);
            // 
            // button_Shop
            // 
            this.button_Shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Shop.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Shop.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_Shop.Location = new System.Drawing.Point(10, 86);
            this.button_Shop.Name = "button_Shop";
            this.button_Shop.Size = new System.Drawing.Size(105, 25);
            this.button_Shop.TabIndex = 5;
            this.button_Shop.Text = "游戏商城";
            this.button_Shop.UseVisualStyleBackColor = true;
            this.button_Shop.Click += new System.EventHandler(this.button_Shop_Click);
            // 
            // button_HappyGay
            // 
            this.button_HappyGay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HappyGay.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_HappyGay.ForeColor = System.Drawing.Color.Fuchsia;
            this.button_HappyGay.Location = new System.Drawing.Point(124, 55);
            this.button_HappyGay.Name = "button_HappyGay";
            this.button_HappyGay.Size = new System.Drawing.Size(105, 25);
            this.button_HappyGay.TabIndex = 4;
            this.button_HappyGay.Text = "欢乐大乐斗";
            this.button_HappyGay.UseVisualStyleBackColor = true;
            this.button_HappyGay.Click += new System.EventHandler(this.button_HappyGay_Click);
            // 
            // button_MineGame
            // 
            this.button_MineGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MineGame.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_MineGame.ForeColor = System.Drawing.Color.Gold;
            this.button_MineGame.Location = new System.Drawing.Point(10, 55);
            this.button_MineGame.Name = "button_MineGame";
            this.button_MineGame.Size = new System.Drawing.Size(105, 25);
            this.button_MineGame.TabIndex = 3;
            this.button_MineGame.Text = "矿场游戏";
            this.button_MineGame.UseVisualStyleBackColor = true;
            this.button_MineGame.Click += new System.EventHandler(this.button_MineGame_Click);
            // 
            // button_SignToDay
            // 
            this.button_SignToDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignToDay.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SignToDay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_SignToDay.Location = new System.Drawing.Point(124, 24);
            this.button_SignToDay.Name = "button_SignToDay";
            this.button_SignToDay.Size = new System.Drawing.Size(105, 25);
            this.button_SignToDay.TabIndex = 2;
            this.button_SignToDay.Text = "每日签到";
            this.button_SignToDay.UseVisualStyleBackColor = true;
            this.button_SignToDay.Click += new System.EventHandler(this.button_SignToDay_Click);
            // 
            // button_YaoYaole
            // 
            this.button_YaoYaole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_YaoYaole.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_YaoYaole.ForeColor = System.Drawing.Color.Red;
            this.button_YaoYaole.Location = new System.Drawing.Point(10, 24);
            this.button_YaoYaole.Name = "button_YaoYaole";
            this.button_YaoYaole.Size = new System.Drawing.Size(105, 25);
            this.button_YaoYaole.TabIndex = 1;
            this.button_YaoYaole.Text = "摇摇乐";
            this.button_YaoYaole.UseVisualStyleBackColor = true;
            this.button_YaoYaole.Click += new System.EventHandler(this.button_YaoYaole_Click);
            // 
            // label_OnlineTime
            // 
            this.label_OnlineTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OnlineTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_OnlineTime.Location = new System.Drawing.Point(91, 279);
            this.label_OnlineTime.Name = "label_OnlineTime";
            this.label_OnlineTime.Size = new System.Drawing.Size(266, 20);
            this.label_OnlineTime.TabIndex = 25;
            this.label_OnlineTime.Text = "Error....";
            this.label_OnlineTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_integral
            // 
            this.label_integral.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_integral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_integral.Location = new System.Drawing.Point(91, 252);
            this.label_integral.Name = "label_integral";
            this.label_integral.Size = new System.Drawing.Size(266, 20);
            this.label_integral.TabIndex = 24;
            this.label_integral.Text = "Error....";
            this.label_integral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Yezi
            // 
            this.label_Yezi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Yezi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Yezi.Location = new System.Drawing.Point(91, 228);
            this.label_Yezi.Name = "label_Yezi";
            this.label_Yezi.Size = new System.Drawing.Size(266, 20);
            this.label_Yezi.TabIndex = 23;
            this.label_Yezi.Text = "Error....";
            this.label_Yezi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ServerTick
            // 
            this.label_ServerTick.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ServerTick.ForeColor = System.Drawing.Color.Olive;
            this.label_ServerTick.Location = new System.Drawing.Point(91, 199);
            this.label_ServerTick.Name = "label_ServerTick";
            this.label_ServerTick.Size = new System.Drawing.Size(266, 20);
            this.label_ServerTick.TabIndex = 21;
            this.label_ServerTick.Text = "Error....";
            this.label_ServerTick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ServerNumber
            // 
            this.label_ServerNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ServerNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ServerNumber.Location = new System.Drawing.Point(91, 174);
            this.label_ServerNumber.Name = "label_ServerNumber";
            this.label_ServerNumber.Size = new System.Drawing.Size(266, 20);
            this.label_ServerNumber.TabIndex = 20;
            this.label_ServerNumber.Text = "Error....";
            this.label_ServerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SignDay
            // 
            this.label_SignDay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SignDay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_SignDay.Location = new System.Drawing.Point(91, 305);
            this.label_SignDay.Name = "label_SignDay";
            this.label_SignDay.Size = new System.Drawing.Size(266, 20);
            this.label_SignDay.TabIndex = 19;
            this.label_SignDay.Text = "Error....";
            this.label_SignDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_MapState
            // 
            this.label_MapState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_MapState.ForeColor = System.Drawing.Color.Red;
            this.label_MapState.Location = new System.Drawing.Point(91, 148);
            this.label_MapState.Name = "label_MapState";
            this.label_MapState.Size = new System.Drawing.Size(266, 20);
            this.label_MapState.TabIndex = 18;
            this.label_MapState.Text = "Error....";
            this.label_MapState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_NextMap
            // 
            this.label_NextMap.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NextMap.ForeColor = System.Drawing.Color.Red;
            this.label_NextMap.Location = new System.Drawing.Point(91, 125);
            this.label_NextMap.Name = "label_NextMap";
            this.label_NextMap.Size = new System.Drawing.Size(266, 20);
            this.label_NextMap.TabIndex = 17;
            this.label_NextMap.Text = "Error....";
            this.label_NextMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_NowMap
            // 
            this.label_NowMap.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NowMap.ForeColor = System.Drawing.Color.Red;
            this.label_NowMap.Location = new System.Drawing.Point(91, 100);
            this.label_NowMap.Name = "label_NowMap";
            this.label_NowMap.Size = new System.Drawing.Size(266, 20);
            this.label_NowMap.TabIndex = 16;
            this.label_NowMap.Text = "Error....";
            this.label_NowMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_NowServer
            // 
            this.label_NowServer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NowServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NowServer.Location = new System.Drawing.Point(91, 76);
            this.label_NowServer.Name = "label_NowServer";
            this.label_NowServer.Size = new System.Drawing.Size(266, 20);
            this.label_NowServer.TabIndex = 15;
            this.label_NowServer.Text = "Error....";
            this.label_NowServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SteamID
            // 
            this.label_SteamID.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SteamID.ForeColor = System.Drawing.Color.Fuchsia;
            this.label_SteamID.Location = new System.Drawing.Point(91, 52);
            this.label_SteamID.Name = "label_SteamID";
            this.label_SteamID.Size = new System.Drawing.Size(266, 20);
            this.label_SteamID.TabIndex = 14;
            this.label_SteamID.Text = "Error....";
            this.label_SteamID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_NickName
            // 
            this.label_NickName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_NickName.ForeColor = System.Drawing.Color.Violet;
            this.label_NickName.Location = new System.Drawing.Point(91, 29);
            this.label_NickName.Name = "label_NickName";
            this.label_NickName.Size = new System.Drawing.Size(266, 20);
            this.label_NickName.TabIndex = 13;
            this.label_NickName.Text = "Error....";
            this.label_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label9.Location = new System.Drawing.Point(5, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "在线时长:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label10.Location = new System.Drawing.Point(4, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "拥有积分:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label11.Location = new System.Drawing.Point(4, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "拥有叶子:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(4, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "服务器队列:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label14.Location = new System.Drawing.Point(4, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "服务器人数:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(4, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "签到天数:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.SpringGreen;
            this.label6.Location = new System.Drawing.Point(4, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "地图状态:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.SpringGreen;
            this.label7.Location = new System.Drawing.Point(4, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "下一张地图:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(5, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "当前地图:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "当前服务器:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SteamID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "昵称:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListMenu
            // 
            this.ListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入服务器ToolStripMenuItem,
            this.刷新列表ToolStripMenuItem,
            this.显示详情ToolStripMenuItem});
            this.ListMenu.Name = "contextMenuStrip1";
            this.ListMenu.Size = new System.Drawing.Size(137, 70);
            // 
            // 加入服务器ToolStripMenuItem
            // 
            this.加入服务器ToolStripMenuItem.Name = "加入服务器ToolStripMenuItem";
            this.加入服务器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.加入服务器ToolStripMenuItem.Text = "加入服务器";
            this.加入服务器ToolStripMenuItem.Click += new System.EventHandler(this.加入服务器ToolStripMenuItem_Click);
            // 
            // 刷新列表ToolStripMenuItem
            // 
            this.刷新列表ToolStripMenuItem.Name = "刷新列表ToolStripMenuItem";
            this.刷新列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新列表ToolStripMenuItem.Text = "刷新列表";
            this.刷新列表ToolStripMenuItem.Click += new System.EventHandler(this.刷新列表ToolStripMenuItem_Click);
            // 
            // 显示详情ToolStripMenuItem
            // 
            this.显示详情ToolStripMenuItem.Name = "显示详情ToolStripMenuItem";
            this.显示详情ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示详情ToolStripMenuItem.Text = "显示详情";
            this.显示详情ToolStripMenuItem.Click += new System.EventHandler(this.显示详情ToolStripMenuItem_Click);
            // 
            // listView_Server
            // 
            this.listView_Server.BackColor = System.Drawing.Color.White;
            this.listView_Server.BackgroundImage = global::ZElauncher.Properties.Resources.profilephoto2;
            this.listView_Server.BackgroundImageTiled = true;
            this.listView_Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Server.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listView_Server.FullRowSelect = true;
            this.listView_Server.Location = new System.Drawing.Point(12, 113);
            this.listView_Server.MultiSelect = false;
            this.listView_Server.Name = "listView_Server";
            this.listView_Server.Size = new System.Drawing.Size(618, 499);
            this.listView_Server.TabIndex = 8;
            this.listView_Server.UseCompatibleStateImageBehavior = false;
            this.listView_Server.View = System.Windows.Forms.View.Details;
            this.listView_Server.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Server_MouseClick);
            this.listView_Server.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Server_MouseDoubleClick);
            // 
            // Form_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1012, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView_Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MainPage";
            this.Text = "Form_MainPage";
            this.TransparencyKey = System.Drawing.SystemColors.Highlight;
            this.Load += new System.EventHandler(this.Form_MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ListMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_Server;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Server_Cat;
        private System.Windows.Forms.Button button_Server_KZ;
        private System.Windows.Forms.Button button_Server_FFA;
        private System.Windows.Forms.Button button_Server_AWP;
        private System.Windows.Forms.Button button_Server_idle;
        private System.Windows.Forms.Button button_Server_TTT;
        private System.Windows.Forms.Button button_Server_Solo;
        private System.Windows.Forms.Button button_Server_MG;
        private System.Windows.Forms.Button button_Server_ZE;
        private System.Windows.Forms.Button button_Server_ALL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_NowMap;
        private System.Windows.Forms.Label label_NowServer;
        private System.Windows.Forms.Label label_SteamID;
        private System.Windows.Forms.Label label_NickName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_OnlineTime;
        private System.Windows.Forms.Label label_integral;
        private System.Windows.Forms.Label label_Yezi;
        private System.Windows.Forms.Label label_ServerTick;
        private System.Windows.Forms.Label label_ServerNumber;
        private System.Windows.Forms.Label label_SignDay;
        private System.Windows.Forms.Label label_MapState;
        private System.Windows.Forms.Label label_NextMap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_MyDisk;
        private System.Windows.Forms.Button button_Ban;
        private System.Windows.Forms.Button button_flsh;
        private System.Windows.Forms.Button button_VIP;
        private System.Windows.Forms.Button button_Shop;
        private System.Windows.Forms.Button button_HappyGay;
        private System.Windows.Forms.Button button_MineGame;
        private System.Windows.Forms.Button button_SignToDay;
        private System.Windows.Forms.Button button_YaoYaole;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_SystemTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_CN;
        private System.Windows.Forms.ContextMenuStrip ListMenu;
        private System.Windows.Forms.ToolStripMenuItem 加入服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示详情ToolStripMenuItem;
    }
}