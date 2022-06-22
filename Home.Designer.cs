namespace PhoneStat
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ContentPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.control = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.PhoneCompareLink = new System.Windows.Forms.LinkLabel();
            this.LogOutLink = new System.Windows.Forms.LinkLabel();
            this.PhoneListLink = new System.Windows.Forms.LinkLabel();
            this.PhoneEditLink = new System.Windows.Forms.LinkLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.ContentPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.control.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::PhoneStat.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(288, 113);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ForeColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = global::PhoneStat.Properties.Resources.icons8_subtract_26px;
            this.Minimize.Location = new System.Drawing.Point(1165, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(41, 38);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::PhoneStat.Properties.Resources.icons8_Close_26px;
            this.Exit.Location = new System.Drawing.Point(1206, 0);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 38);
            this.Exit.TabIndex = 0;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ContentPnl
            // 
            this.ContentPnl.BackColor = System.Drawing.Color.White;
            this.ContentPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPnl.Controls.Add(this.pictureBox1);
            this.ContentPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPnl.Location = new System.Drawing.Point(0, 113);
            this.ContentPnl.Name = "ContentPnl";
            this.ContentPnl.Size = new System.Drawing.Size(1247, 696);
            this.ContentPnl.TabIndex = 2;
            this.ContentPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPnl_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PhoneStat.Properties.Resources._2174912;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1247, 696);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.Color.Transparent;
            this.control.Controls.Add(this.UserNameLabel);
            this.control.Controls.Add(this.LoginLink);
            this.control.Controls.Add(this.tbSearch);
            this.control.Controls.Add(this.Minimize);
            this.control.Controls.Add(this.Exit);
            this.control.Dock = System.Windows.Forms.DockStyle.Top;
            this.control.Location = new System.Drawing.Point(0, 0);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(1247, 113);
            this.control.TabIndex = 1;
            this.control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.control_MouseDown);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.ForeColor = System.Drawing.Color.White;
            this.UserNameLabel.Location = new System.Drawing.Point(971, 58);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserNameLabel.Size = new System.Drawing.Size(174, 24);
            this.UserNameLabel.TabIndex = 7;
            this.UserNameLabel.Text = "Xin chào, Admin";
            this.UserNameLabel.Visible = false;
            // 
            // LoginLink
            // 
            this.LoginLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.LoginLink.AutoSize = true;
            this.LoginLink.BackColor = System.Drawing.Color.Transparent;
            this.LoginLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.LoginLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginLink.ForeColor = System.Drawing.Color.Aqua;
            this.LoginLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LoginLink.LinkColor = System.Drawing.Color.White;
            this.LoginLink.Location = new System.Drawing.Point(1090, 55);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(131, 27);
            this.LoginLink.TabIndex = 6;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Đăng nhập";
            this.LoginLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.Location = new System.Drawing.Point(48, 55);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Tìm kiếm";
            this.tbSearch.Size = new System.Drawing.Size(263, 23);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.PhoneCompareLink);
            this.Dashboard.Controls.Add(this.LogOutLink);
            this.Dashboard.Controls.Add(this.PhoneListLink);
            this.Dashboard.Controls.Add(this.PhoneEditLink);
            this.Dashboard.Controls.Add(this.Logo);
            this.Dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.Dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(206)))), ((int)(((byte)(246)))));
            this.Dashboard.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(240)))));
            this.Dashboard.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(288, 809);
            this.Dashboard.TabIndex = 0;
            // 
            // PhoneCompareLink
            // 
            this.PhoneCompareLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.PhoneCompareLink.AutoSize = true;
            this.PhoneCompareLink.BackColor = System.Drawing.Color.Transparent;
            this.PhoneCompareLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.PhoneCompareLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneCompareLink.ForeColor = System.Drawing.Color.Aqua;
            this.PhoneCompareLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PhoneCompareLink.LinkColor = System.Drawing.Color.White;
            this.PhoneCompareLink.Location = new System.Drawing.Point(52, 244);
            this.PhoneCompareLink.Name = "PhoneCompareLink";
            this.PhoneCompareLink.Size = new System.Drawing.Size(98, 27);
            this.PhoneCompareLink.TabIndex = 7;
            this.PhoneCompareLink.TabStop = true;
            this.PhoneCompareLink.Text = "So sánh";
            this.PhoneCompareLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.PhoneCompareLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PhoneCompareLink_LinkClicked);
            // 
            // LogOutLink
            // 
            this.LogOutLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.LogOutLink.AutoSize = true;
            this.LogOutLink.BackColor = System.Drawing.Color.Transparent;
            this.LogOutLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.LogOutLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogOutLink.ForeColor = System.Drawing.Color.Aqua;
            this.LogOutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogOutLink.LinkColor = System.Drawing.Color.White;
            this.LogOutLink.Location = new System.Drawing.Point(52, 734);
            this.LogOutLink.Name = "LogOutLink";
            this.LogOutLink.Size = new System.Drawing.Size(125, 27);
            this.LogOutLink.TabIndex = 6;
            this.LogOutLink.TabStop = true;
            this.LogOutLink.Text = "Đăng xuất";
            this.LogOutLink.Visible = false;
            this.LogOutLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.LogOutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOutBtn_LinkClicked);
            // 
            // PhoneListLink
            // 
            this.PhoneListLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.PhoneListLink.AutoSize = true;
            this.PhoneListLink.BackColor = System.Drawing.Color.Transparent;
            this.PhoneListLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.PhoneListLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneListLink.ForeColor = System.Drawing.Color.Aqua;
            this.PhoneListLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PhoneListLink.LinkColor = System.Drawing.Color.White;
            this.PhoneListLink.Location = new System.Drawing.Point(52, 174);
            this.PhoneListLink.Name = "PhoneListLink";
            this.PhoneListLink.Size = new System.Drawing.Size(126, 27);
            this.PhoneListLink.TabIndex = 5;
            this.PhoneListLink.TabStop = true;
            this.PhoneListLink.Text = "Danh sách";
            this.PhoneListLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.PhoneListLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PhoneListLink_LinkClicked);
            // 
            // PhoneEditLink
            // 
            this.PhoneEditLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.PhoneEditLink.AutoSize = true;
            this.PhoneEditLink.BackColor = System.Drawing.Color.Transparent;
            this.PhoneEditLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.PhoneEditLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneEditLink.ForeColor = System.Drawing.Color.Aqua;
            this.PhoneEditLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PhoneEditLink.LinkColor = System.Drawing.Color.White;
            this.PhoneEditLink.Location = new System.Drawing.Point(52, 319);
            this.PhoneEditLink.Name = "PhoneEditLink";
            this.PhoneEditLink.Size = new System.Drawing.Size(122, 27);
            this.PhoneEditLink.TabIndex = 4;
            this.PhoneEditLink.TabStop = true;
            this.PhoneEditLink.Text = "Chỉnh sửa";
            this.PhoneEditLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.PhoneEditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PhoneEditLink_LinkClicked);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.ContentPnl);
            this.guna2GradientPanel1.Controls.Add(this.control);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(206)))), ((int)(((byte)(246)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(240)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(288, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1247, 809);
            this.guna2GradientPanel1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1535, 809);
            this.ControlBox = false;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.Dashboard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ContentPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel control;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel ContentPnl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GradientPanel Dashboard;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.LinkLabel PhoneListLink;
        private System.Windows.Forms.LinkLabel PhoneEditLink;
        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.LinkLabel LogOutLink;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel PhoneCompareLink;
    }
}
