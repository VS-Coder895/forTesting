namespace UI
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.formTitle = new System.Windows.Forms.Label();
            this.toolTipUserName = new System.Windows.Forms.ToolTip(this.components);
            this.txtBoxUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.txtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnfrmAbout = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.picBoxLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.White;
            this.formTitle.Location = new System.Drawing.Point(533, 133);
            this.formTitle.Margin = new System.Windows.Forms.Padding(0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(296, 41);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Happy Hacking";
            // 
            // toolTipUserName
            // 
            this.toolTipUserName.AutoPopDelay = 5500;
            this.toolTipUserName.InitialDelay = 50;
            this.toolTipUserName.IsBalloon = true;
            this.toolTipUserName.ReshowDelay = 110;
            this.toolTipUserName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUserName.ToolTipTitle = "Email Policies";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxUserName.BorderRadius = 8;
            this.txtBoxUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUserName.DefaultText = "";
            this.txtBoxUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBoxUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUserName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxUserName.IconLeft")));
            this.txtBoxUserName.Location = new System.Drawing.Point(75, 43);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.PlaceholderText = "Enter UserName";
            this.txtBoxUserName.SelectedText = "";
            this.txtBoxUserName.Size = new System.Drawing.Size(460, 50);
            this.txtBoxUserName.TabIndex = 1;
            this.toolTipUserName.SetToolTip(this.txtBoxUserName, "Enter here your user name, please!.");
            // 
            // toolTipPassword
            // 
            this.toolTipPassword.AutoPopDelay = 5500;
            this.toolTipPassword.InitialDelay = 50;
            this.toolTipPassword.IsBalloon = true;
            this.toolTipPassword.ReshowDelay = 110;
            this.toolTipPassword.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPassword.ToolTipTitle = "Password Policies";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPassword.BorderRadius = 8;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPassword.DefaultText = "";
            this.txtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPassword.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtBoxPassword.IconLeft")));
            this.txtBoxPassword.Location = new System.Drawing.Point(75, 111);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PlaceholderText = "Enter Password";
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.Size = new System.Drawing.Size(460, 50);
            this.txtBoxPassword.TabIndex = 2;
            this.toolTipPassword.SetToolTip(this.txtBoxPassword, "Enter here your password!.");
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.btnfrmAbout);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.txtBoxPassword);
            this.guna2Panel1.Controls.Add(this.txtBoxUserName);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.guna2Panel1.Location = new System.Drawing.Point(379, 197);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(599, 337);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnfrmAbout
            // 
            this.btnfrmAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnfrmAbout.BorderRadius = 12;
            this.btnfrmAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfrmAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfrmAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfrmAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfrmAbout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnfrmAbout.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmAbout.ForeColor = System.Drawing.SystemColors.Info;
            this.btnfrmAbout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnfrmAbout.Location = new System.Drawing.Point(417, 212);
            this.btnfrmAbout.Name = "btnfrmAbout";
            this.btnfrmAbout.Size = new System.Drawing.Size(118, 35);
            this.btnfrmAbout.TabIndex = 4;
            this.btnfrmAbout.Text = "About us";
            this.btnfrmAbout.Click += new System.EventHandler(this.btnfrmAbout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(71)))), ((int)(((byte)(195)))));
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(75, 212);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picBoxLogin
            // 
            this.picBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogin.Image")));
            this.picBoxLogin.ImageRotate = 0F;
            this.picBoxLogin.Location = new System.Drawing.Point(379, 133);
            this.picBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxLogin.Name = "picBoxLogin";
            this.picBoxLogin.Size = new System.Drawing.Size(59, 41);
            this.picBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogin.TabIndex = 6;
            this.picBoxLogin.TabStop = false;
            this.picBoxLogin.UseTransparentBackground = true;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox3);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox2);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(27)))), ((int)(((byte)(190)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(32)))), ((int)(((byte)(178)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(49)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(3)))), ((int)(((byte)(85)))));
            this.guna2CustomGradientPanel1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1253, 66);
            this.guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderRadius = 7;
            this.guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Green;
            this.guna2ControlBox3.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Chartreuse;
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1162, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(15, 15);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 7;
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ControlBox2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1194, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(15, 15);
            this.guna2ControlBox2.TabIndex = 3;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 7;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Tomato;
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1226, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(15, 15);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bookman Old Style", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 31);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Login";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(919, 134);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(59, 41);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // loginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1253, 536);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.picBoxLogin);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.formTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogin)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.ToolTip toolTipUserName;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUserName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPassword;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxLogin;
        private Guna.UI2.WinForms.Guna2Button btnfrmAbout;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}