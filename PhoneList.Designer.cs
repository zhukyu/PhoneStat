namespace PhoneStat
{
    partial class PhoneList
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
            this.PhoneListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FilterPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.BrandCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ResolutionCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RefreshRateCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RAMCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ROMCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneListPanel
            // 
            this.PhoneListPanel.AutoScroll = true;
            this.PhoneListPanel.BackColor = System.Drawing.Color.White;
            this.PhoneListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneListPanel.Location = new System.Drawing.Point(0, 108);
            this.PhoneListPanel.Name = "PhoneListPanel";
            this.PhoneListPanel.Size = new System.Drawing.Size(1215, 504);
            this.PhoneListPanel.TabIndex = 0;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.ResetBtn);
            this.FilterPanel.Controls.Add(this.FilterBtn);
            this.FilterPanel.Controls.Add(this.BrandCB);
            this.FilterPanel.Controls.Add(this.ResolutionCB);
            this.FilterPanel.Controls.Add(this.RefreshRateCB);
            this.FilterPanel.Controls.Add(this.RAMCB);
            this.FilterPanel.Controls.Add(this.ROMCB);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(206)))), ((int)(((byte)(246)))));
            this.FilterPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(147)))), ((int)(((byte)(241)))));
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(1215, 108);
            this.FilterPanel.TabIndex = 1;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ResetBtn.Image = global::PhoneStat.Properties.Resources.erase_26px;
            this.ResetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetBtn.Location = new System.Drawing.Point(24, 32);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.ResetBtn.Size = new System.Drawing.Size(109, 36);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.Text = "Đặt lại";
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilterBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FilterBtn.Image = global::PhoneStat.Properties.Resources.filter_26px2;
            this.FilterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FilterBtn.Location = new System.Drawing.Point(1119, 32);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.FilterBtn.Size = new System.Drawing.Size(94, 36);
            this.FilterBtn.TabIndex = 8;
            this.FilterBtn.Text = "Lọc";
            this.FilterBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.FilterBtn.UseVisualStyleBackColor = true;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // BrandCB
            // 
            this.BrandCB.BackColor = System.Drawing.Color.Transparent;
            this.BrandCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BrandCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BrandCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BrandCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrandCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.BrandCB.ItemHeight = 30;
            this.BrandCB.Location = new System.Drawing.Point(152, 32);
            this.BrandCB.Name = "BrandCB";
            this.BrandCB.Size = new System.Drawing.Size(175, 36);
            this.BrandCB.TabIndex = 0;
            // 
            // ResolutionCB
            // 
            this.ResolutionCB.BackColor = System.Drawing.Color.Transparent;
            this.ResolutionCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ResolutionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResolutionCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResolutionCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ResolutionCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResolutionCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ResolutionCB.ItemHeight = 30;
            this.ResolutionCB.Location = new System.Drawing.Point(344, 32);
            this.ResolutionCB.Name = "ResolutionCB";
            this.ResolutionCB.Size = new System.Drawing.Size(175, 36);
            this.ResolutionCB.TabIndex = 1;
            // 
            // RefreshRateCB
            // 
            this.RefreshRateCB.BackColor = System.Drawing.Color.Transparent;
            this.RefreshRateCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RefreshRateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RefreshRateCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RefreshRateCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RefreshRateCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshRateCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RefreshRateCB.ItemHeight = 30;
            this.RefreshRateCB.Location = new System.Drawing.Point(540, 32);
            this.RefreshRateCB.Name = "RefreshRateCB";
            this.RefreshRateCB.Size = new System.Drawing.Size(168, 36);
            this.RefreshRateCB.TabIndex = 4;
            // 
            // RAMCB
            // 
            this.RAMCB.BackColor = System.Drawing.Color.Transparent;
            this.RAMCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RAMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RAMCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAMCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RAMCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RAMCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RAMCB.ItemHeight = 30;
            this.RAMCB.Location = new System.Drawing.Point(727, 32);
            this.RAMCB.Name = "RAMCB";
            this.RAMCB.Size = new System.Drawing.Size(192, 36);
            this.RAMCB.TabIndex = 2;
            // 
            // ROMCB
            // 
            this.ROMCB.BackColor = System.Drawing.Color.Transparent;
            this.ROMCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ROMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ROMCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ROMCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ROMCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ROMCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ROMCB.ItemHeight = 30;
            this.ROMCB.Location = new System.Drawing.Point(943, 32);
            this.ROMCB.Name = "ROMCB";
            this.ROMCB.Size = new System.Drawing.Size(156, 36);
            this.ROMCB.TabIndex = 3;
            // 
            // PhoneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PhoneListPanel);
            this.Controls.Add(this.FilterPanel);
            this.DoubleBuffered = true;
            this.Name = "PhoneList";
            this.Size = new System.Drawing.Size(1215, 612);
            this.Load += new System.EventHandler(this.PhoneList_Load);
            this.FilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PhoneListPanel;
        private Guna.UI2.WinForms.Guna2ComboBox BrandCB;
        private Guna.UI2.WinForms.Guna2GradientPanel FilterPanel;
        private Guna.UI2.WinForms.Guna2ComboBox ResolutionCB;
        private Guna.UI2.WinForms.Guna2ComboBox RefreshRateCB;
        private Guna.UI2.WinForms.Guna2ComboBox RAMCB;
        private Guna.UI2.WinForms.Guna2ComboBox ROMCB;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetBtn;
    }
}
