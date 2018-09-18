namespace ZElauncher
{
    partial class Form_ServerInfo
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
            this.button_Close = new System.Windows.Forms.Button();
            this.button_MinWindows = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_ServerTick = new System.Windows.Forms.Label();
            this.label_VAC = new System.Windows.Forms.Label();
            this.label_PlayerNum = new System.Windows.Forms.Label();
            this.label_NowMap = new System.Windows.Forms.Label();
            this.label_GameType = new System.Windows.Forms.Label();
            this.label_ServerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_PlayerInfo = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::ZElauncher.Properties.Resources.X;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button_Close.Location = new System.Drawing.Point(304, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 44);
            this.button_Close.TabIndex = 8;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_MinWindows
            // 
            this.button_MinWindows.BackColor = System.Drawing.Color.Transparent;
            this.button_MinWindows.BackgroundImage = global::ZElauncher.Properties.Resources.一;
            this.button_MinWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_MinWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MinWindows.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.button_MinWindows.Location = new System.Drawing.Point(263, 0);
            this.button_MinWindows.Name = "button_MinWindows";
            this.button_MinWindows.Size = new System.Drawing.Size(40, 44);
            this.button_MinWindows.TabIndex = 7;
            this.button_MinWindows.UseVisualStyleBackColor = false;
            this.button_MinWindows.Click += new System.EventHandler(this.button_MinWindows_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "服务器信息";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label_ServerTick);
            this.groupBox1.Controls.Add(this.label_VAC);
            this.groupBox1.Controls.Add(this.label_PlayerNum);
            this.groupBox1.Controls.Add(this.label_NowMap);
            this.groupBox1.Controls.Add(this.label_GameType);
            this.groupBox1.Controls.Add(this.label_ServerName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 205);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label_ServerTick
            // 
            this.label_ServerTick.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_ServerTick.Location = new System.Drawing.Point(66, 179);
            this.label_ServerTick.Name = "label_ServerTick";
            this.label_ServerTick.Size = new System.Drawing.Size(257, 22);
            this.label_ServerTick.TabIndex = 11;
            this.label_ServerTick.Text = "6ms";
            this.label_ServerTick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_VAC
            // 
            this.label_VAC.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_VAC.Location = new System.Drawing.Point(66, 148);
            this.label_VAC.Name = "label_VAC";
            this.label_VAC.Size = new System.Drawing.Size(257, 22);
            this.label_VAC.TabIndex = 10;
            this.label_VAC.Text = "None";
            this.label_VAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PlayerNum
            // 
            this.label_PlayerNum.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_PlayerNum.Location = new System.Drawing.Point(66, 113);
            this.label_PlayerNum.Name = "label_PlayerNum";
            this.label_PlayerNum.Size = new System.Drawing.Size(257, 22);
            this.label_PlayerNum.TabIndex = 9;
            this.label_PlayerNum.Text = "12/16";
            this.label_PlayerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NowMap
            // 
            this.label_NowMap.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_NowMap.Location = new System.Drawing.Point(66, 79);
            this.label_NowMap.Name = "label_NowMap";
            this.label_NowMap.Size = new System.Drawing.Size(257, 22);
            this.label_NowMap.TabIndex = 8;
            this.label_NowMap.Text = "None";
            this.label_NowMap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_GameType
            // 
            this.label_GameType.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_GameType.Location = new System.Drawing.Point(66, 46);
            this.label_GameType.Name = "label_GameType";
            this.label_GameType.Size = new System.Drawing.Size(257, 22);
            this.label_GameType.TabIndex = 7;
            this.label_GameType.Text = "CSGO";
            this.label_GameType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ServerName
            // 
            this.label_ServerName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label_ServerName.Location = new System.Drawing.Point(66, 17);
            this.label_ServerName.Name = "label_ServerName";
            this.label_ServerName.Size = new System.Drawing.Size(257, 22);
            this.label_ServerName.TabIndex = 6;
            this.label_ServerName.Text = "None";
            this.label_ServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "响应延迟";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(7, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "VAC保护";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "玩家人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "游戏名字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "当前地图";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务器名";
            // 
            // listView_PlayerInfo
            // 
            this.listView_PlayerInfo.BackColor = System.Drawing.Color.White;
            this.listView_PlayerInfo.BackgroundImageTiled = true;
            this.listView_PlayerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_PlayerInfo.ForeColor = System.Drawing.Color.DeepPink;
            this.listView_PlayerInfo.FullRowSelect = true;
            this.listView_PlayerInfo.Location = new System.Drawing.Point(6, 304);
            this.listView_PlayerInfo.MultiSelect = false;
            this.listView_PlayerInfo.Name = "listView_PlayerInfo";
            this.listView_PlayerInfo.Size = new System.Drawing.Size(331, 299);
            this.listView_PlayerInfo.TabIndex = 11;
            this.listView_PlayerInfo.UseCompatibleStateImageBehavior = false;
            this.listView_PlayerInfo.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-6, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 8);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ZElauncher.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-22, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(235, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "刷新信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_ServerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(344, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView_PlayerInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_MinWindows);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ServerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ServerInfo";
            this.Load += new System.EventHandler(this.Form_ServerInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_MinWindows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ServerTick;
        private System.Windows.Forms.Label label_VAC;
        private System.Windows.Forms.Label label_PlayerNum;
        private System.Windows.Forms.Label label_NowMap;
        private System.Windows.Forms.Label label_GameType;
        private System.Windows.Forms.Label label_ServerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_PlayerInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}