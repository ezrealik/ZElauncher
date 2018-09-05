namespace ZElauncher
{
    partial class Form_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_MaxWindows = new System.Windows.Forms.Button();
            this.button_MinWindows = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SteamPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_DownloadMap = new System.Windows.Forms.CheckBox();
            this.checkBox_BindKey = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_KeyCmd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 8);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Logo.Image = global::ZElauncher.Properties.Resources.Set;
            this.pictureBox_Logo.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(251, 62);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 7;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::ZElauncher.Properties.Resources.X;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.Color.Wheat;
            this.button_Close.Location = new System.Drawing.Point(558, -3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 54);
            this.button_Close.TabIndex = 10;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_MaxWindows
            // 
            this.button_MaxWindows.BackColor = System.Drawing.Color.Transparent;
            this.button_MaxWindows.BackgroundImage = global::ZElauncher.Properties.Resources.口;
            this.button_MaxWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_MaxWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MaxWindows.ForeColor = System.Drawing.Color.Wheat;
            this.button_MaxWindows.Location = new System.Drawing.Point(517, -3);
            this.button_MaxWindows.Name = "button_MaxWindows";
            this.button_MaxWindows.Size = new System.Drawing.Size(40, 54);
            this.button_MaxWindows.TabIndex = 9;
            this.button_MaxWindows.UseVisualStyleBackColor = false;
            // 
            // button_MinWindows
            // 
            this.button_MinWindows.BackColor = System.Drawing.Color.Transparent;
            this.button_MinWindows.BackgroundImage = global::ZElauncher.Properties.Resources.一;
            this.button_MinWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_MinWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MinWindows.ForeColor = System.Drawing.Color.Wheat;
            this.button_MinWindows.Location = new System.Drawing.Point(476, -3);
            this.button_MinWindows.Name = "button_MinWindows";
            this.button_MinWindows.Size = new System.Drawing.Size(40, 54);
            this.button_MinWindows.TabIndex = 8;
            this.button_MinWindows.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_SteamPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(5, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 99);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目录设置";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 23);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "CSGO目录:";
            // 
            // textBox_SteamPath
            // 
            this.textBox_SteamPath.Location = new System.Drawing.Point(98, 22);
            this.textBox_SteamPath.Name = "textBox_SteamPath";
            this.textBox_SteamPath.Size = new System.Drawing.Size(424, 23);
            this.textBox_SteamPath.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Steam目录:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(527, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(527, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_KeyCmd);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBox_BindKey);
            this.groupBox2.Controls.Add(this.checkBox_DownloadMap);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(5, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 365);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其他设置";
            // 
            // checkBox_DownloadMap
            // 
            this.checkBox_DownloadMap.AutoSize = true;
            this.checkBox_DownloadMap.Checked = true;
            this.checkBox_DownloadMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DownloadMap.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBox_DownloadMap.Location = new System.Drawing.Point(13, 24);
            this.checkBox_DownloadMap.Name = "checkBox_DownloadMap";
            this.checkBox_DownloadMap.Size = new System.Drawing.Size(123, 20);
            this.checkBox_DownloadMap.TabIndex = 0;
            this.checkBox_DownloadMap.Text = "自动下载地图";
            this.checkBox_DownloadMap.UseVisualStyleBackColor = true;
            // 
            // checkBox_BindKey
            // 
            this.checkBox_BindKey.AutoSize = true;
            this.checkBox_BindKey.Location = new System.Drawing.Point(149, 24);
            this.checkBox_BindKey.Name = "checkBox_BindKey";
            this.checkBox_BindKey.Size = new System.Drawing.Size(123, 20);
            this.checkBox_BindKey.TabIndex = 3;
            this.checkBox_BindKey.Text = "绑定按键指令";
            this.checkBox_BindKey.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(290, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "按键:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(346, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 26);
            this.textBox2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(526, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "加入";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox_KeyCmd
            // 
            this.textBox_KeyCmd.Location = new System.Drawing.Point(10, 52);
            this.textBox_KeyCmd.Multiline = true;
            this.textBox_KeyCmd.Name = "textBox_KeyCmd";
            this.textBox_KeyCmd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_KeyCmd.Size = new System.Drawing.Size(571, 302);
            this.textBox_KeyCmd.TabIndex = 7;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(600, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_MaxWindows);
            this.Controls.Add(this.button_MinWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Setting";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Setting_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_MaxWindows;
        private System.Windows.Forms.Button button_MinWindows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SteamPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_BindKey;
        private System.Windows.Forms.CheckBox checkBox_DownloadMap;
        private System.Windows.Forms.TextBox textBox_KeyCmd;
        private System.Windows.Forms.Button button3;
    }
}