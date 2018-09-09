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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_PassWorld = new System.Windows.Forms.TextBox();
            this.button_Sign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_SaveCookies = new System.Windows.Forms.CheckBox();
            this.button_Steam = new System.Windows.Forms.Button();
            this.button_QQlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 5);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "帐号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "密码:";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(62, 53);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(218, 21);
            this.textBox_UserName.TabIndex = 17;
            // 
            // textBox_PassWorld
            // 
            this.textBox_PassWorld.Location = new System.Drawing.Point(62, 80);
            this.textBox_PassWorld.Name = "textBox_PassWorld";
            this.textBox_PassWorld.PasswordChar = '*';
            this.textBox_PassWorld.Size = new System.Drawing.Size(218, 21);
            this.textBox_PassWorld.TabIndex = 18;
            // 
            // button_Sign
            // 
            this.button_Sign.BackColor = System.Drawing.Color.Transparent;
            this.button_Sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sign.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Sign.ForeColor = System.Drawing.Color.Red;
            this.button_Sign.Location = new System.Drawing.Point(291, 53);
            this.button_Sign.Name = "button_Sign";
            this.button_Sign.Size = new System.Drawing.Size(77, 23);
            this.button_Sign.TabIndex = 19;
            this.button_Sign.Text = "登 录";
            this.button_Sign.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 96);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 71);
            this.label3.TabIndex = 0;
            this.label3.Text = "TIP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox_SaveCookies
            // 
            this.checkBox_SaveCookies.AutoSize = true;
            this.checkBox_SaveCookies.Checked = true;
            this.checkBox_SaveCookies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SaveCookies.Location = new System.Drawing.Point(283, 84);
            this.checkBox_SaveCookies.Name = "checkBox_SaveCookies";
            this.checkBox_SaveCookies.Size = new System.Drawing.Size(96, 16);
            this.checkBox_SaveCookies.TabIndex = 22;
            this.checkBox_SaveCookies.Text = "记住登录状态";
            this.checkBox_SaveCookies.UseVisualStyleBackColor = true;
            // 
            // button_Steam
            // 
            this.button_Steam.BackColor = System.Drawing.Color.Transparent;
            this.button_Steam.BackgroundImage = global::ZElauncher.Properties.Resources.steam_login;
            this.button_Steam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Steam.Location = new System.Drawing.Point(131, 110);
            this.button_Steam.Name = "button_Steam";
            this.button_Steam.Size = new System.Drawing.Size(132, 26);
            this.button_Steam.TabIndex = 24;
            this.button_Steam.UseVisualStyleBackColor = false;
            // 
            // button_QQlogin
            // 
            this.button_QQlogin.BackColor = System.Drawing.Color.Transparent;
            this.button_QQlogin.BackgroundImage = global::ZElauncher.Properties.Resources.qq_login;
            this.button_QQlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QQlogin.Location = new System.Drawing.Point(3, 110);
            this.button_QQlogin.Name = "button_QQlogin";
            this.button_QQlogin.Size = new System.Drawing.Size(126, 26);
            this.button_QQlogin.TabIndex = 23;
            this.button_QQlogin.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ZElauncher.Properties.Resources.weixin_bind;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(265, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.Transparent;
            this.button_Close.BackgroundImage = global::ZElauncher.Properties.Resources.X;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.Color.LightCoral;
            this.button_Close.Location = new System.Drawing.Point(340, -4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(40, 46);
            this.button_Close.TabIndex = 10;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackgroundImage = global::ZElauncher.Properties.Resources.logo;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_Logo.Location = new System.Drawing.Point(-22, 0);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(206, 42);
            this.pictureBox_Logo.TabIndex = 7;
            this.pictureBox_Logo.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(380, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Steam);
            this.Controls.Add(this.button_QQlogin);
            this.Controls.Add(this.checkBox_SaveCookies);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Sign);
            this.Controls.Add(this.textBox_PassWorld);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.button_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_login";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_login_MouseDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_PassWorld;
        private System.Windows.Forms.Button button_Sign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_SaveCookies;
        private System.Windows.Forms.Button button_QQlogin;
        private System.Windows.Forms.Button button_Steam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
    }
}