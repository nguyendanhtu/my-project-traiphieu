namespace BondApp
{
    partial class f800_lich_nhac_viec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f800_lich_nhac_viec));
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_lich_nhac_viec_tu = new System.Windows.Forms.Label();
            this.m_lbl_lich_nhac_viec_den = new System.Windows.Forms.Label();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.m_cbo_loai_nhac_viec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cmd_filter = new System.Windows.Forms.Button();
            this.m_chk_da_thuc_hien = new System.Windows.Forms.CheckBox();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cmd_them_ghi_chu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 88);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(962, 325);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            // 
            // m_lbl_lich_nhac_viec_tu
            // 
            this.m_lbl_lich_nhac_viec_tu.AutoSize = true;
            this.m_lbl_lich_nhac_viec_tu.Location = new System.Drawing.Point(18, 50);
            this.m_lbl_lich_nhac_viec_tu.Name = "m_lbl_lich_nhac_viec_tu";
            this.m_lbl_lich_nhac_viec_tu.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_lich_nhac_viec_tu.TabIndex = 22;
            this.m_lbl_lich_nhac_viec_tu.Text = "Hôm nay";
            // 
            // m_lbl_lich_nhac_viec_den
            // 
            this.m_lbl_lich_nhac_viec_den.AutoSize = true;
            this.m_lbl_lich_nhac_viec_den.Location = new System.Drawing.Point(186, 55);
            this.m_lbl_lich_nhac_viec_den.Name = "m_lbl_lich_nhac_viec_den";
            this.m_lbl_lich_nhac_viec_den.Size = new System.Drawing.Size(27, 13);
            this.m_lbl_lich_nhac_viec_den.TabIndex = 23;
            this.m_lbl_lich_nhac_viec_den.Text = "Đến";
            this.m_lbl_lich_nhac_viec_den.Visible = false;
            // 
            // m_dat_from_date
            // 
            this.m_dat_from_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_from_date.Location = new System.Drawing.Point(71, 48);
            this.m_dat_from_date.Name = "m_dat_from_date";
            this.m_dat_from_date.Size = new System.Drawing.Size(111, 20);
            this.m_dat_from_date.TabIndex = 24;
            // 
            // m_dat_to_date
            // 
            this.m_dat_to_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_to_date.Location = new System.Drawing.Point(229, 48);
            this.m_dat_to_date.Name = "m_dat_to_date";
            this.m_dat_to_date.Size = new System.Drawing.Size(91, 20);
            this.m_dat_to_date.TabIndex = 25;
            this.m_dat_to_date.Value = new System.DateTime(2012, 9, 23, 19, 12, 0, 0);
            // 
            // m_cbo_loai_nhac_viec
            // 
            this.m_cbo_loai_nhac_viec.DisplayMember = "Tất cả";
            this.m_cbo_loai_nhac_viec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_loai_nhac_viec.FormattingEnabled = true;
            this.m_cbo_loai_nhac_viec.Location = new System.Drawing.Point(416, 47);
            this.m_cbo_loai_nhac_viec.Name = "m_cbo_loai_nhac_viec";
            this.m_cbo_loai_nhac_viec.Size = new System.Drawing.Size(148, 21);
            this.m_cbo_loai_nhac_viec.TabIndex = 26;
            this.m_cbo_loai_nhac_viec.ValueMember = "Tất cả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại công việc";
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_filter.Image")));
            this.m_cmd_filter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_filter.Location = new System.Drawing.Point(735, 43);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(64, 23);
            this.m_cmd_filter.TabIndex = 28;
            this.m_cmd_filter.Text = "     Xem";
            this.m_cmd_filter.UseVisualStyleBackColor = true;
            // 
            // m_chk_da_thuc_hien
            // 
            this.m_chk_da_thuc_hien.AutoSize = true;
            this.m_chk_da_thuc_hien.Location = new System.Drawing.Point(580, 49);
            this.m_chk_da_thuc_hien.Name = "m_chk_da_thuc_hien";
            this.m_chk_da_thuc_hien.Size = new System.Drawing.Size(87, 17);
            this.m_chk_da_thuc_hien.TabIndex = 30;
            this.m_chk_da_thuc_hien.Text = "Đã thực hiện";
            this.m_chk_da_thuc_hien.UseVisualStyleBackColor = true;
            this.m_chk_da_thuc_hien.Visible = false;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_title.Location = new System.Drawing.Point(3, 16);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(956, 20);
            this.m_lbl_title.TabIndex = 31;
            this.m_lbl_title.Text = "LỊCH NHẮC VIỆC";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cmd_them_ghi_chu);
            this.groupBox1.Controls.Add(this.m_lbl_title);
            this.groupBox1.Controls.Add(this.m_lbl_lich_nhac_viec_tu);
            this.groupBox1.Controls.Add(this.m_chk_da_thuc_hien);
            this.groupBox1.Controls.Add(this.m_lbl_lich_nhac_viec_den);
            this.groupBox1.Controls.Add(this.m_cmd_filter);
            this.groupBox1.Controls.Add(this.m_dat_from_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_dat_to_date);
            this.groupBox1.Controls.Add(this.m_cbo_loai_nhac_viec);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(962, 88);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lọc";
            // 
            // m_cmd_them_ghi_chu
            // 
            this.m_cmd_them_ghi_chu.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_them_ghi_chu.Image")));
            this.m_cmd_them_ghi_chu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_them_ghi_chu.Location = new System.Drawing.Point(825, 43);
            this.m_cmd_them_ghi_chu.Name = "m_cmd_them_ghi_chu";
            this.m_cmd_them_ghi_chu.Size = new System.Drawing.Size(104, 23);
            this.m_cmd_them_ghi_chu.TabIndex = 32;
            this.m_cmd_them_ghi_chu.Text = "     Thêm ghi chú";
            this.m_cmd_them_ghi_chu.UseVisualStyleBackColor = true;
            // 
            // f800_lich_nhac_viec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 413);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox1);
            this.Name = "f800_lich_nhac_viec";
            this.Text = "F800 - Lịch nhắc việc";
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private System.Windows.Forms.Label m_lbl_lich_nhac_viec_tu;
        private System.Windows.Forms.Label m_lbl_lich_nhac_viec_den;
        private System.Windows.Forms.DateTimePicker m_dat_from_date;
        private System.Windows.Forms.DateTimePicker m_dat_to_date;
        private System.Windows.Forms.ComboBox m_cbo_loai_nhac_viec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button m_cmd_filter;
        private System.Windows.Forms.CheckBox m_chk_da_thuc_hien;
        private System.Windows.Forms.Label m_lbl_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button m_cmd_them_ghi_chu;
    }
}