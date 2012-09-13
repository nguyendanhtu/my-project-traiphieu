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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // m_fg
            // 
            this.m_fg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 115);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(541, 190);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 21;
            // 
            // m_lbl_lich_nhac_viec_tu
            // 
            this.m_lbl_lich_nhac_viec_tu.AutoSize = true;
            this.m_lbl_lich_nhac_viec_tu.Location = new System.Drawing.Point(11, 42);
            this.m_lbl_lich_nhac_viec_tu.Name = "m_lbl_lich_nhac_viec_tu";
            this.m_lbl_lich_nhac_viec_tu.Size = new System.Drawing.Size(20, 13);
            this.m_lbl_lich_nhac_viec_tu.TabIndex = 22;
            this.m_lbl_lich_nhac_viec_tu.Text = "Từ";
            // 
            // m_lbl_lich_nhac_viec_den
            // 
            this.m_lbl_lich_nhac_viec_den.AutoSize = true;
            this.m_lbl_lich_nhac_viec_den.Location = new System.Drawing.Point(11, 75);
            this.m_lbl_lich_nhac_viec_den.Name = "m_lbl_lich_nhac_viec_den";
            this.m_lbl_lich_nhac_viec_den.Size = new System.Drawing.Size(27, 13);
            this.m_lbl_lich_nhac_viec_den.TabIndex = 23;
            this.m_lbl_lich_nhac_viec_den.Text = "Đến";
            
            // 
            // m_dat_from_date
            // 
            this.m_dat_from_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_from_date.Location = new System.Drawing.Point(54, 35);
            this.m_dat_from_date.Name = "m_dat_from_date";
            this.m_dat_from_date.Size = new System.Drawing.Size(200, 20);
            this.m_dat_from_date.TabIndex = 24;
            
            // 
            // m_dat_to_date
            // 
            this.m_dat_to_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_to_date.Location = new System.Drawing.Point(54, 68);
            this.m_dat_to_date.Name = "m_dat_to_date";
            this.m_dat_to_date.Size = new System.Drawing.Size(200, 20);
            this.m_dat_to_date.TabIndex = 25;
            this.m_dat_to_date.Value = new System.DateTime(2012, 9, 23, 19, 12, 0, 0);
            // 
            // m_cbo_loai_nhac_viec
            // 
            this.m_cbo_loai_nhac_viec.DisplayMember = "Tất cả";
            this.m_cbo_loai_nhac_viec.FormattingEnabled = true;
            this.m_cbo_loai_nhac_viec.Location = new System.Drawing.Point(371, 34);
            this.m_cbo_loai_nhac_viec.Name = "m_cbo_loai_nhac_viec";
            this.m_cbo_loai_nhac_viec.Size = new System.Drawing.Size(148, 21);
            this.m_cbo_loai_nhac_viec.TabIndex = 26;
            this.m_cbo_loai_nhac_viec.ValueMember = "Tất cả";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại công việc";
            
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_filter.Image")));
            this.m_cmd_filter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_filter.Location = new System.Drawing.Point(455, 65);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(64, 23);
            this.m_cmd_filter.TabIndex = 28;
            this.m_cmd_filter.Text = "     Xem";
            this.m_cmd_filter.UseVisualStyleBackColor = true;
            
            // 
            // m_chk_da_thuc_hien
            // 
            this.m_chk_da_thuc_hien.AutoSize = true;
            this.m_chk_da_thuc_hien.Location = new System.Drawing.Point(291, 71);
            this.m_chk_da_thuc_hien.Name = "m_chk_da_thuc_hien";
            this.m_chk_da_thuc_hien.Size = new System.Drawing.Size(87, 17);
            this.m_chk_da_thuc_hien.TabIndex = 30;
            this.m_chk_da_thuc_hien.Text = "Đã thực hiện";
            this.m_chk_da_thuc_hien.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(201, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lịch nhắc việc";
            // 
            // f800_lich_nhac_viec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_chk_da_thuc_hien);
            this.Controls.Add(this.m_cmd_filter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_cbo_loai_nhac_viec);
            this.Controls.Add(this.m_dat_to_date);
            this.Controls.Add(this.m_dat_from_date);
            this.Controls.Add(this.m_lbl_lich_nhac_viec_den);
            this.Controls.Add(this.m_lbl_lich_nhac_viec_tu);
            this.Controls.Add(this.m_fg);
            this.Name = "f800_lich_nhac_viec";
            this.Text = "F800 - Lịch nhắc việc";
            
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}