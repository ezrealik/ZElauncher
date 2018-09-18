namespace ZElauncher
{
    partial class Form_Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Video));
            this.Web_Refresh = new System.Windows.Forms.PictureBox();
            this.Web_Go = new System.Windows.Forms.PictureBox();
            this.Web_Back = new System.Windows.Forms.PictureBox();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Go)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Back)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Web_Refresh
            // 
            this.Web_Refresh.Image = global::ZElauncher.Properties.Resources.Refresh;
            this.Web_Refresh.Location = new System.Drawing.Point(126, 4);
            this.Web_Refresh.Name = "Web_Refresh";
            this.Web_Refresh.Size = new System.Drawing.Size(52, 46);
            this.Web_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Web_Refresh.TabIndex = 4;
            this.Web_Refresh.TabStop = false;
            this.Web_Refresh.Click += new System.EventHandler(this.Web_Refresh_Click);
            this.Web_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Web_Refresh_MouseDown);
            this.Web_Refresh.MouseEnter += new System.EventHandler(this.Web_Refresh_MouseEnter);
            this.Web_Refresh.MouseLeave += new System.EventHandler(this.Web_Refresh_MouseLeave);
            this.Web_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Web_Refresh_MouseUp);
            // 
            // Web_Go
            // 
            this.Web_Go.BackColor = System.Drawing.Color.Transparent;
            this.Web_Go.Image = global::ZElauncher.Properties.Resources.Go;
            this.Web_Go.Location = new System.Drawing.Point(68, 4);
            this.Web_Go.Name = "Web_Go";
            this.Web_Go.Size = new System.Drawing.Size(52, 46);
            this.Web_Go.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Web_Go.TabIndex = 2;
            this.Web_Go.TabStop = false;
            this.Web_Go.Click += new System.EventHandler(this.Web_Go_Click);
            this.Web_Go.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Web_Go_MouseDown);
            this.Web_Go.MouseEnter += new System.EventHandler(this.Web_Go_MouseEnter);
            this.Web_Go.MouseLeave += new System.EventHandler(this.Web_Go_MouseLeave);
            this.Web_Go.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Web_Go_MouseUp);
            // 
            // Web_Back
            // 
            this.Web_Back.BackColor = System.Drawing.Color.Transparent;
            this.Web_Back.Image = global::ZElauncher.Properties.Resources.Back;
            this.Web_Back.Location = new System.Drawing.Point(10, 4);
            this.Web_Back.Name = "Web_Back";
            this.Web_Back.Size = new System.Drawing.Size(52, 46);
            this.Web_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Web_Back.TabIndex = 1;
            this.Web_Back.TabStop = false;
            this.Web_Back.Click += new System.EventHandler(this.Web_Back_Click);
            this.Web_Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Web_Back_MouseDown);
            this.Web_Back.MouseEnter += new System.EventHandler(this.Web_Back_MouseEnter);
            this.Web_Back.MouseLeave += new System.EventHandler(this.Web_Back_MouseLeave);
            this.Web_Back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Web_Back_MouseUp);
            // 
            // textBox_Url
            // 
            this.textBox_Url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Url.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Url.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox_Url.Location = new System.Drawing.Point(184, 13);
            this.textBox_Url.Name = "textBox_Url";
            this.textBox_Url.Size = new System.Drawing.Size(747, 26);
            this.textBox_Url.TabIndex = 5;
            this.textBox_Url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Url_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(937, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(5, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 580);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(3, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(993, 560);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://live.bilibili.com/p/eden/area-tags?parentAreaId=2&areaId=89&visit_id=63tm" +
        "bjl3heg0#/2/89", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // Form_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1012, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Url);
            this.Controls.Add(this.Web_Refresh);
            this.Controls.Add(this.Web_Go);
            this.Controls.Add(this.Web_Back);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Video";
            this.Load += new System.EventHandler(this.Form_Video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Web_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Go)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Web_Back)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Web_Back;
        private System.Windows.Forms.PictureBox Web_Go;
        private System.Windows.Forms.PictureBox Web_Refresh;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}