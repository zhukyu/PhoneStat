namespace PhoneStat
{
    partial class PhoneEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PhoneDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddLink = new System.Windows.Forms.LinkLabel();
            this.EditLink = new System.Windows.Forms.LinkLabel();
            this.DeleteLink = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chipset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasSDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Battery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplaySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CameraResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrontCameraResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneImage = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDGV)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhoneDGV
            // 
            this.PhoneDGV.AllowUserToAddRows = false;
            this.PhoneDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PhoneDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PhoneDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PhoneDGV.BackgroundColor = System.Drawing.Color.White;
            this.PhoneDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhoneDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PhoneDGV.ColumnHeadersHeight = 27;
            this.PhoneDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PhoneName,
            this.Brand,
            this.Chipset,
            this.RAM,
            this.ROM,
            this.HasSDCard,
            this.Battery,
            this.Resolution,
            this.DisplaySize,
            this.RefreshRate,
            this.CameraResolution,
            this.FrontCameraResolution,
            this.phoneImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhoneDGV.EnableHeadersVisualStyles = false;
            this.PhoneDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhoneDGV.Location = new System.Drawing.Point(0, 0);
            this.PhoneDGV.MultiSelect = false;
            this.PhoneDGV.Name = "PhoneDGV";
            this.PhoneDGV.ReadOnly = true;
            this.PhoneDGV.RowHeadersVisible = false;
            this.PhoneDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PhoneDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PhoneDGV.RowTemplate.Height = 29;
            this.PhoneDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PhoneDGV.Size = new System.Drawing.Size(2502, 610);
            this.PhoneDGV.TabIndex = 0;
            this.PhoneDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PhoneDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PhoneDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PhoneDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PhoneDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PhoneDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PhoneDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhoneDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PhoneDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PhoneDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PhoneDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PhoneDGV.ThemeStyle.HeaderStyle.Height = 27;
            this.PhoneDGV.ThemeStyle.ReadOnly = true;
            this.PhoneDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PhoneDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PhoneDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhoneDGV.ThemeStyle.RowsStyle.Height = 29;
            this.PhoneDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PhoneDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PhoneDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PhoneDGV_CellContentClick);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.Controls.Add(this.panel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1225, 65);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.AddLink);
            this.panel1.Controls.Add(this.EditLink);
            this.panel1.Controls.Add(this.DeleteLink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(919, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 65);
            this.panel1.TabIndex = 7;
            // 
            // AddLink
            // 
            this.AddLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.AddLink.AutoSize = true;
            this.AddLink.BackColor = System.Drawing.Color.Transparent;
            this.AddLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.AddLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.AddLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(240)))));
            this.AddLink.Location = new System.Drawing.Point(31, 19);
            this.AddLink.Name = "AddLink";
            this.AddLink.Size = new System.Drawing.Size(73, 27);
            this.AddLink.TabIndex = 6;
            this.AddLink.TabStop = true;
            this.AddLink.Text = "Thêm";
            this.AddLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.AddLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddLink_LinkClicked);
            // 
            // EditLink
            // 
            this.EditLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.EditLink.AutoSize = true;
            this.EditLink.BackColor = System.Drawing.Color.Transparent;
            this.EditLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.EditLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.EditLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(240)))));
            this.EditLink.Location = new System.Drawing.Point(132, 19);
            this.EditLink.Name = "EditLink";
            this.EditLink.Size = new System.Drawing.Size(55, 27);
            this.EditLink.TabIndex = 7;
            this.EditLink.TabStop = true;
            this.EditLink.Text = "Sửa";
            this.EditLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.EditLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditLink_LinkClicked);
            // 
            // DeleteLink
            // 
            this.DeleteLink.ActiveLinkColor = System.Drawing.Color.Aqua;
            this.DeleteLink.AutoSize = true;
            this.DeleteLink.BackColor = System.Drawing.Color.Transparent;
            this.DeleteLink.DisabledLinkColor = System.Drawing.Color.Aqua;
            this.DeleteLink.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.DeleteLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(240)))));
            this.DeleteLink.Location = new System.Drawing.Point(211, 19);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(54, 27);
            this.DeleteLink.TabIndex = 4;
            this.DeleteLink.TabStop = true;
            this.DeleteLink.Text = "Xóa";
            this.DeleteLink.VisitedLinkColor = System.Drawing.Color.Aqua;
            this.DeleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLink_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PhoneDGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 605);
            this.panel2.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã ĐT";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 179;
            // 
            // PhoneName
            // 
            this.PhoneName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhoneName.HeaderText = "Tên ĐT";
            this.PhoneName.MinimumWidth = 6;
            this.PhoneName.Name = "PhoneName";
            this.PhoneName.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Hãng SX";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 179;
            // 
            // Chipset
            // 
            this.Chipset.HeaderText = "Chipset";
            this.Chipset.MinimumWidth = 6;
            this.Chipset.Name = "Chipset";
            this.Chipset.ReadOnly = true;
            this.Chipset.Width = 179;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.MinimumWidth = 6;
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 179;
            // 
            // ROM
            // 
            this.ROM.HeaderText = "ROM";
            this.ROM.MinimumWidth = 6;
            this.ROM.Name = "ROM";
            this.ROM.ReadOnly = true;
            this.ROM.Width = 178;
            // 
            // HasSDCard
            // 
            this.HasSDCard.HeaderText = "Thẻ SD";
            this.HasSDCard.MinimumWidth = 6;
            this.HasSDCard.Name = "HasSDCard";
            this.HasSDCard.ReadOnly = true;
            this.HasSDCard.Width = 179;
            // 
            // Battery
            // 
            this.Battery.HeaderText = "Pin";
            this.Battery.MinimumWidth = 6;
            this.Battery.Name = "Battery";
            this.Battery.ReadOnly = true;
            this.Battery.Width = 179;
            // 
            // Resolution
            // 
            this.Resolution.HeaderText = "Độ phân giải";
            this.Resolution.MinimumWidth = 6;
            this.Resolution.Name = "Resolution";
            this.Resolution.ReadOnly = true;
            this.Resolution.Width = 178;
            // 
            // DisplaySize
            // 
            this.DisplaySize.HeaderText = "Kích thước";
            this.DisplaySize.MinimumWidth = 6;
            this.DisplaySize.Name = "DisplaySize";
            this.DisplaySize.ReadOnly = true;
            this.DisplaySize.Width = 179;
            // 
            // RefreshRate
            // 
            this.RefreshRate.HeaderText = "Tần số quét";
            this.RefreshRate.MinimumWidth = 6;
            this.RefreshRate.Name = "RefreshRate";
            this.RefreshRate.ReadOnly = true;
            this.RefreshRate.Width = 179;
            // 
            // CameraResolution
            // 
            this.CameraResolution.HeaderText = "Camera";
            this.CameraResolution.MinimumWidth = 6;
            this.CameraResolution.Name = "CameraResolution";
            this.CameraResolution.ReadOnly = true;
            this.CameraResolution.Width = 179;
            // 
            // FrontCameraResolution
            // 
            this.FrontCameraResolution.HeaderText = "Camera trước";
            this.FrontCameraResolution.MinimumWidth = 6;
            this.FrontCameraResolution.Name = "FrontCameraResolution";
            this.FrontCameraResolution.ReadOnly = true;
            this.FrontCameraResolution.Width = 178;
            // 
            // phoneImage
            // 
            this.phoneImage.HeaderText = "Ảnh";
            this.phoneImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.phoneImage.MinimumWidth = 6;
            this.phoneImage.Name = "phoneImage";
            this.phoneImage.ReadOnly = true;
            this.phoneImage.Width = 130;
            // 
            // PhoneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "PhoneEdit";
            this.Size = new System.Drawing.Size(1225, 670);
            this.Load += new System.EventHandler(this.PhoneEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDGV)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView PhoneDGV;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.LinkLabel AddLink;
        private System.Windows.Forms.LinkLabel DeleteLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel EditLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chipset;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasSDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Battery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplaySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefreshRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CameraResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrontCameraResolution;
        private System.Windows.Forms.DataGridViewImageColumn phoneImage;
    }
}
