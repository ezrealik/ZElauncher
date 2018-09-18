namespace ZElauncher
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_Web = new System.Windows.Forms.GroupBox();
            this.button_QQlogin = new System.Windows.Forms.Button();
            this.button_Steam = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_SaveCookies = new System.Windows.Forms.CheckBox();
            this.button_Sign = new System.Windows.Forms.Button();
            this.textBox_PassWorld = new System.Windows.Forms.TextBox();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Web.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(649, 662);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 140);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 104);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox_Web
            // 
            this.groupBox_Web.Controls.Add(this.button_QQlogin);
            this.groupBox_Web.Controls.Add(this.button_Steam);
            this.groupBox_Web.Controls.Add(this.groupBox1);
            this.groupBox_Web.Controls.Add(this.webBrowser1);
            this.groupBox_Web.Location = new System.Drawing.Point(-650, -510);
            this.groupBox_Web.Name = "groupBox_Web";
            this.groupBox_Web.Size = new System.Drawing.Size(1800, 1800);
            this.groupBox_Web.TabIndex = 26;
            this.groupBox_Web.TabStop = false;
            this.groupBox_Web.Text = "groupBox2";
            // 
            // button_QQlogin
            // 
            this.button_QQlogin.BackColor = System.Drawing.Color.Transparent;
            this.button_QQlogin.BackgroundImage = global::ZElauncher.Properties.Resources.qq_login;
            this.button_QQlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QQlogin.Location = new System.Drawing.Point(653, 661);
            this.button_QQlogin.Name = "button_QQlogin";
            this.button_QQlogin.Size = new System.Drawing.Size(126, 26);
            this.button_QQlogin.TabIndex = 23;
            this.button_QQlogin.UseVisualStyleBackColor = false;
            this.button_QQlogin.Click += new System.EventHandler(this.button_QQlogin_Click);
            // 
            // button_Steam
            // 
            this.button_Steam.BackColor = System.Drawing.Color.Transparent;
            this.button_Steam.BackgroundImage = global::ZElauncher.Properties.Resources.steam_login;
            this.button_Steam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Steam.Location = new System.Drawing.Point(784, 662);
            this.button_Steam.Name = "button_Steam";
            this.button_Steam.Size = new System.Drawing.Size(132, 26);
            this.button_Steam.TabIndex = 24;
            this.button_Steam.UseVisualStyleBackColor = false;
            this.button_Steam.Click += new System.EventHandler(this.button_Steam_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1794, 1780);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://bbs.93x.net/member.php?mod=logging&action=login&referer=https%3A%2F%2Fbbs" +
        ".93x.net%2F", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_SaveCookies);
            this.panel2.Controls.Add(this.button_Sign);
            this.panel2.Controls.Add(this.textBox_PassWorld);
            this.panel2.Controls.Add(this.textBox_UserName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 64);
            this.panel2.TabIndex = 27;
            // 
            // checkBox_SaveCookies
            // 
            this.checkBox_SaveCookies.AutoSize = true;
            this.checkBox_SaveCookies.Checked = true;
            this.checkBox_SaveCookies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SaveCookies.Location = new System.Drawing.Point(282, 40);
            this.checkBox_SaveCookies.Name = "checkBox_SaveCookies";
            this.checkBox_SaveCookies.Size = new System.Drawing.Size(96, 16);
            this.checkBox_SaveCookies.TabIndex = 28;
            this.checkBox_SaveCookies.Text = "记住登录状态";
            this.checkBox_SaveCookies.UseVisualStyleBackColor = true;
            // 
            // button_Sign
            // 
            this.button_Sign.BackColor = System.Drawing.Color.Transparent;
            this.button_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sign.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Sign.ForeColor = System.Drawing.Color.Red;
            this.button_Sign.Location = new System.Drawing.Point(290, 9);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Size = new System.Drawing.Size(77, 23);
            this.button_Sign.TabIndex = 27;
            this.button_Sign.Text = "登 录";
            this.button_Sign.UseVisualStyleBackColor = false;
            this.button_Sign.Click += new System.EventHandler(this.button_Sign_Click);
            // 
            // textBox_PassWorld
            // 
            this.textBox_PassWorld.Location = new System.Drawing.Point(61, 36);
            this.textBox_PassWorld.Name = "textBox_PassWorld";
            this.textBox_PassWorld.PasswordChar = '*';
            this.textBox_PassWorld.Size = new System.Drawing.Size(218, 21);
            this.textBox_PassWorld.TabIndex = 26;
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(61, 9);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(218, 21);
            this.textBox_UserName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "密码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "帐号:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pictureBox_Logo);
            this.panel3.Controls.Add(this.button_Close);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 50);
            this.panel3.TabIndex = 28;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-5, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 5);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImage = global::ZElauncher.Properties.Resources.logo;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(206, 42);
            this.pictureBox_Logo.TabIndex = 15;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Logo_MouseDown);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::ZElauncher.Properties.Resources.X;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.Color.LightCoral;
            this.button_Close.Location = new System.Drawing.Point(346, -1);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 46);
            this.button_Close.TabIndex = 16;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(309, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 72);
            this.panel4.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ZElauncher.Properties.Resources.weixin_bind;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(271, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(387, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox_Web);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_login_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Web.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_Web;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_SaveCookies;
        private System.Windows.Forms.Button button_Sign;
        private System.Windows.Forms.TextBox textBox_PassWorld;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_QQlogin;
        private System.Windows.Forms.Button button_Steam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
    }
}