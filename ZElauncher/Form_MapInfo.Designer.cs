namespace ZElauncher
{
    partial class Form_MapInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Server_KZ = new System.Windows.Forms.Button();
            this.button_Server_AWP = new System.Windows.Forms.Button();
            this.button_Server_TTT = new System.Windows.Forms.Button();
            this.button_Server_MG = new System.Windows.Forms.Button();
            this.button_Server_ZE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Map = new System.Windows.Forms.ListView();
            this.ListMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.下载地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制下载地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制地图名字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ListMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Server_KZ);
            this.groupBox1.Controls.Add(this.button_Server_AWP);
            this.groupBox1.Controls.Add(this.button_Server_TTT);
            this.groupBox1.Controls.Add(this.button_Server_MG);
            this.groupBox1.Controls.Add(this.button_Server_ZE);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "地图列表";
            // 
            // button_Server_KZ
            // 
            this.button_Server_KZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_KZ.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_KZ.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_Server_KZ.Location = new System.Drawing.Point(379, 20);
            this.button_Server_KZ.Name = "button_Server_KZ";
            this.button_Server_KZ.Size = new System.Drawing.Size(114, 25);
            this.button_Server_KZ.TabIndex = 8;
            this.button_Server_KZ.Text = "KZ/Surf/BHOP";
            this.button_Server_KZ.UseVisualStyleBackColor = true;
            this.button_Server_KZ.Click += new System.EventHandler(this.button_Server_KZ_Click);
            // 
            // button_Server_AWP
            // 
            this.button_Server_AWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_AWP.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_AWP.ForeColor = System.Drawing.Color.Yellow;
            this.button_Server_AWP.Location = new System.Drawing.Point(499, 20);
            this.button_Server_AWP.Name = "button_Server_AWP";
            this.button_Server_AWP.Size = new System.Drawing.Size(114, 25);
            this.button_Server_AWP.TabIndex = 6;
            this.button_Server_AWP.Text = "狙击战争";
            this.button_Server_AWP.UseVisualStyleBackColor = true;
            this.button_Server_AWP.Click += new System.EventHandler(this.button_Server_AWP_Click);
            // 
            // button_Server_TTT
            // 
            this.button_Server_TTT.BackColor = System.Drawing.Color.Transparent;
            this.button_Server_TTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_TTT.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_TTT.ForeColor = System.Drawing.Color.LightCoral;
            this.button_Server_TTT.Location = new System.Drawing.Point(259, 20);
            this.button_Server_TTT.Name = "button_Server_TTT";
            this.button_Server_TTT.Size = new System.Drawing.Size(114, 25);
            this.button_Server_TTT.TabIndex = 4;
            this.button_Server_TTT.Text = "越狱/叛徒";
            this.button_Server_TTT.UseVisualStyleBackColor = false;
            this.button_Server_TTT.Click += new System.EventHandler(this.button_Server_TTT_Click);
            // 
            // button_Server_MG
            // 
            this.button_Server_MG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_MG.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_MG.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_Server_MG.Location = new System.Drawing.Point(134, 20);
            this.button_Server_MG.Name = "button_Server_MG";
            this.button_Server_MG.Size = new System.Drawing.Size(119, 25);
            this.button_Server_MG.TabIndex = 2;
            this.button_Server_MG.Text = "对抗/混战/死斗";
            this.button_Server_MG.UseVisualStyleBackColor = true;
            this.button_Server_MG.Click += new System.EventHandler(this.button_Server_MG_Click);
            // 
            // button_Server_ZE
            // 
            this.button_Server_ZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Server_ZE.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Server_ZE.ForeColor = System.Drawing.Color.Red;
            this.button_Server_ZE.Location = new System.Drawing.Point(14, 20);
            this.button_Server_ZE.Name = "button_Server_ZE";
            this.button_Server_ZE.Size = new System.Drawing.Size(114, 25);
            this.button_Server_ZE.TabIndex = 1;
            this.button_Server_ZE.Text = "僵尸逃跑/感染";
            this.button_Server_ZE.UseVisualStyleBackColor = true;
            this.button_Server_ZE.Click += new System.EventHandler(this.button_Server_ZE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox_search);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(638, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 95);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索地图";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(298, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(57, 15);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(239, 21);
            this.textBox_search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地图名:";
            // 
            // listView_Map
            // 
            this.listView_Map.BackColor = System.Drawing.Color.White;
            this.listView_Map.BackgroundImage = global::ZElauncher.Properties.Resources.BG;
            this.listView_Map.BackgroundImageTiled = true;
            this.listView_Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Map.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.listView_Map.FullRowSelect = true;
            this.listView_Map.Location = new System.Drawing.Point(12, 114);
            this.listView_Map.MultiSelect = false;
            this.listView_Map.Name = "listView_Map";
            this.listView_Map.Size = new System.Drawing.Size(988, 499);
            this.listView_Map.TabIndex = 11;
            this.listView_Map.UseCompatibleStateImageBehavior = false;
            this.listView_Map.View = System.Windows.Forms.View.Details;
            this.listView_Map.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView_Map_KeyPress);
            this.listView_Map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Map_MouseClick);
            // 
            // ListMap
            // 
            this.ListMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载地图ToolStripMenuItem,
            this.复制下载地址ToolStripMenuItem,
            this.复制地图名字ToolStripMenuItem});
            this.ListMap.Name = "contextMenuStrip1";
            this.ListMap.Size = new System.Drawing.Size(153, 92);
            // 
            // 下载地图ToolStripMenuItem
            // 
            this.下载地图ToolStripMenuItem.Name = "下载地图ToolStripMenuItem";
            this.下载地图ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.下载地图ToolStripMenuItem.Text = "下载地图";
            this.下载地图ToolStripMenuItem.Click += new System.EventHandler(this.下载地图ToolStripMenuItem_Click);
            // 
            // 复制下载地址ToolStripMenuItem
            // 
            this.复制下载地址ToolStripMenuItem.Name = "复制下载地址ToolStripMenuItem";
            this.复制下载地址ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.复制下载地址ToolStripMenuItem.Text = "复制下载地址";
            this.复制下载地址ToolStripMenuItem.Click += new System.EventHandler(this.复制下载地址ToolStripMenuItem_Click);
            // 
            // 复制地图名字ToolStripMenuItem
            // 
            this.复制地图名字ToolStripMenuItem.Name = "复制地图名字ToolStripMenuItem";
            this.复制地图名字ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.复制地图名字ToolStripMenuItem.Text = "复制地图名字";
            this.复制地图名字ToolStripMenuItem.Click += new System.EventHandler(this.复制地图名字ToolStripMenuItem_Click);
            // 
            // Form_MapInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1012, 619);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView_Map);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MapInfo";
            this.Text = "Form_MapInfo";
            this.Load += new System.EventHandler(this.Form_MapInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ListMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Server_KZ;
        private System.Windows.Forms.Button button_Server_AWP;
        private System.Windows.Forms.Button button_Server_TTT;
        private System.Windows.Forms.Button button_Server_MG;
        private System.Windows.Forms.Button button_Server_ZE;
        private System.Windows.Forms.ListView listView_Map;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ListMap;
        private System.Windows.Forms.ToolStripMenuItem 下载地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制下载地址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制地图名字ToolStripMenuItem;
    }
}