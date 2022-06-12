namespace PhoneStat
{
    partial class PhoneItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PhoneName = new System.Windows.Forms.LinkLabel();
            this.PhoneImg = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.PhoneName);
            this.guna2Panel1.Controls.Add(this.PhoneImg);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.guna2Panel1.Size = new System.Drawing.Size(273, 487);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseEnter += new System.EventHandler(this.guna2Panel1_MouseEnter);
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.guna2Panel1_MouseLeave);
            // 
            // PhoneName
            // 
            this.PhoneName.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.PhoneName.AutoSize = true;
            this.PhoneName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.PhoneName.LinkColor = System.Drawing.Color.Black;
            this.PhoneName.Location = new System.Drawing.Point(20, 303);
            this.PhoneName.Name = "PhoneName";
            this.PhoneName.Size = new System.Drawing.Size(140, 24);
            this.PhoneName.TabIndex = 1;
            this.PhoneName.TabStop = true;
            this.PhoneName.Text = "Oppo Reno 7";
            this.PhoneName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PhoneImg
            // 
            this.PhoneImg.Image = global::PhoneStat.Properties.Resources._65756;
            this.PhoneImg.Location = new System.Drawing.Point(0, 22);
            this.PhoneImg.Name = "PhoneImg";
            this.PhoneImg.Size = new System.Drawing.Size(273, 267);
            this.PhoneImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhoneImg.TabIndex = 3;
            this.PhoneImg.TabStop = false;
            this.PhoneImg.MouseEnter += new System.EventHandler(this.PhoneImg_MouseEnter);
            // 
            // PhoneItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "PhoneItem";
            this.Size = new System.Drawing.Size(297, 500);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.LinkLabel PhoneName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.PictureBox PhoneImg;
    }
}
