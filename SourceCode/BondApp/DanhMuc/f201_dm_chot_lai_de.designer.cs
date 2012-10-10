namespace BondApp
{
    partial class f201_dm_chot_lai_de
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
            this.m_txt_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_luu = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_lbl_trai_phieu = new System.Windows.Forms.Label();
            this.m_lbl_trang_thai = new System.Windows.Forms.Label();
            this.m_lbl_ki_tinh_lai = new System.Windows.Forms.Label();
            this.m_txt_ki_tinh_lai = new System.Windows.Forms.TextBox();
            this.m_lbl_muc_dich = new System.Windows.Forms.Label();
            this.m_txt_muc_dich = new System.Windows.Forms.TextBox();
            this.m_lbl_ghi_chu = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_lbl_nguoi_duyet = new System.Windows.Forms.Label();
            this.m_txt_nguoi_duyet = new System.Windows.Forms.TextBox();
            this.m_lbl_nguoi_lap = new System.Windows.Forms.Label();
            this.m_txt_nguoi_lap = new System.Windows.Forms.TextBox();
            this.m_lbl_ngay_chot_lai = new System.Windows.Forms.Label();
            this.m_lbl_ngay_thanh_toan = new System.Windows.Forms.Label();
            this.m_dat_ngay_chot_lai = new System.Windows.Forms.DateTimePicker();
            this.m_dat_ngay_thanh_toan = new System.Windows.Forms.DateTimePicker();
            this.m_txt_trang_thai = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_txt_trai_phieu
            // 
            this.m_txt_trai_phieu.Location = new System.Drawing.Point(104, 74);
            this.m_txt_trai_phieu.Name = "m_txt_trai_phieu";
            this.m_txt_trai_phieu.Size = new System.Drawing.Size(121, 20);
            this.m_txt_trai_phieu.TabIndex = 2;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_luu);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 326);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(584, 36);
            this.m_pnl_out_place_dm.TabIndex = 20;
            // 
            // m_cmd_luu
            // 
            this.m_cmd_luu.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_luu.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_luu.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_luu.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_luu.ImageIndex = 4;
            this.m_cmd_luu.Location = new System.Drawing.Point(404, 4);
            this.m_cmd_luu.Name = "m_cmd_luu";
            this.m_cmd_luu.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_luu.TabIndex = 11;
            this.m_cmd_luu.Text = "&Lưu";
            this.m_cmd_luu.Click += new System.EventHandler(this.m_cmd_luu_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.Location = new System.Drawing.Point(492, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 12;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(584, 37);
            this.m_lbl_title.TabIndex = 25;
            this.m_lbl_title.Text = "F201 - Danh mục đợt chốt lãi";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_trai_phieu
            // 
            this.m_lbl_trai_phieu.AutoSize = true;
            this.m_lbl_trai_phieu.Location = new System.Drawing.Point(12, 81);
            this.m_lbl_trai_phieu.Name = "m_lbl_trai_phieu";
            this.m_lbl_trai_phieu.Size = new System.Drawing.Size(54, 13);
            this.m_lbl_trai_phieu.TabIndex = 28;
            this.m_lbl_trai_phieu.Text = "Trái phiếu";
            // 
            // m_lbl_trang_thai
            // 
            this.m_lbl_trang_thai.AutoSize = true;
            this.m_lbl_trang_thai.Location = new System.Drawing.Point(12, 125);
            this.m_lbl_trang_thai.Name = "m_lbl_trang_thai";
            this.m_lbl_trang_thai.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_trang_thai.TabIndex = 29;
            this.m_lbl_trang_thai.Text = "Trạng thái";
            // 
            // m_lbl_ki_tinh_lai
            // 
            this.m_lbl_ki_tinh_lai.AutoSize = true;
            this.m_lbl_ki_tinh_lai.Location = new System.Drawing.Point(12, 171);
            this.m_lbl_ki_tinh_lai.Name = "m_lbl_ki_tinh_lai";
            this.m_lbl_ki_tinh_lai.Size = new System.Drawing.Size(51, 13);
            this.m_lbl_ki_tinh_lai.TabIndex = 31;
            this.m_lbl_ki_tinh_lai.Text = "Kì tính lãi";
            // 
            // m_txt_ki_tinh_lai
            // 
            this.m_txt_ki_tinh_lai.Location = new System.Drawing.Point(104, 164);
            this.m_txt_ki_tinh_lai.Name = "m_txt_ki_tinh_lai";
            this.m_txt_ki_tinh_lai.Size = new System.Drawing.Size(121, 20);
            this.m_txt_ki_tinh_lai.TabIndex = 4;
            // 
            // m_lbl_muc_dich
            // 
            this.m_lbl_muc_dich.AutoSize = true;
            this.m_lbl_muc_dich.Location = new System.Drawing.Point(12, 214);
            this.m_lbl_muc_dich.Name = "m_lbl_muc_dich";
            this.m_lbl_muc_dich.Size = new System.Drawing.Size(54, 13);
            this.m_lbl_muc_dich.TabIndex = 33;
            this.m_lbl_muc_dich.Text = "Mục đích";
            // 
            // m_txt_muc_dich
            // 
            this.m_txt_muc_dich.Location = new System.Drawing.Point(104, 207);
            this.m_txt_muc_dich.Name = "m_txt_muc_dich";
            this.m_txt_muc_dich.Size = new System.Drawing.Size(121, 20);
            this.m_txt_muc_dich.TabIndex = 5;
            // 
            // m_lbl_ghi_chu
            // 
            this.m_lbl_ghi_chu.AutoSize = true;
            this.m_lbl_ghi_chu.Location = new System.Drawing.Point(12, 254);
            this.m_lbl_ghi_chu.Name = "m_lbl_ghi_chu";
            this.m_lbl_ghi_chu.Size = new System.Drawing.Size(44, 13);
            this.m_lbl_ghi_chu.TabIndex = 35;
            this.m_lbl_ghi_chu.Text = "Ghi chú";
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(104, 251);
            this.m_txt_ghi_chu.Multiline = true;
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(459, 59);
            this.m_txt_ghi_chu.TabIndex = 10;
            // 
            // m_lbl_nguoi_duyet
            // 
            this.m_lbl_nguoi_duyet.AutoSize = true;
            this.m_lbl_nguoi_duyet.Location = new System.Drawing.Point(261, 214);
            this.m_lbl_nguoi_duyet.Name = "m_lbl_nguoi_duyet";
            this.m_lbl_nguoi_duyet.Size = new System.Drawing.Size(64, 13);
            this.m_lbl_nguoi_duyet.TabIndex = 37;
            this.m_lbl_nguoi_duyet.Text = "Người duyệt";
            // 
            // m_txt_nguoi_duyet
            // 
            this.m_txt_nguoi_duyet.Location = new System.Drawing.Point(363, 207);
            this.m_txt_nguoi_duyet.Name = "m_txt_nguoi_duyet";
            this.m_txt_nguoi_duyet.Size = new System.Drawing.Size(121, 20);
            this.m_txt_nguoi_duyet.TabIndex = 9;
            // 
            // m_lbl_nguoi_lap
            // 
            this.m_lbl_nguoi_lap.AutoSize = true;
            this.m_lbl_nguoi_lap.Location = new System.Drawing.Point(261, 171);
            this.m_lbl_nguoi_lap.Name = "m_lbl_nguoi_lap";
            this.m_lbl_nguoi_lap.Size = new System.Drawing.Size(52, 13);
            this.m_lbl_nguoi_lap.TabIndex = 39;
            this.m_lbl_nguoi_lap.Text = "Người lập";
            // 
            // m_txt_nguoi_lap
            // 
            this.m_txt_nguoi_lap.Location = new System.Drawing.Point(363, 164);
            this.m_txt_nguoi_lap.Name = "m_txt_nguoi_lap";
            this.m_txt_nguoi_lap.Size = new System.Drawing.Size(121, 20);
            this.m_txt_nguoi_lap.TabIndex = 8;
            // 
            // m_lbl_ngay_chot_lai
            // 
            this.m_lbl_ngay_chot_lai.AutoSize = true;
            this.m_lbl_ngay_chot_lai.Location = new System.Drawing.Point(261, 81);
            this.m_lbl_ngay_chot_lai.Name = "m_lbl_ngay_chot_lai";
            this.m_lbl_ngay_chot_lai.Size = new System.Drawing.Size(69, 13);
            this.m_lbl_ngay_chot_lai.TabIndex = 43;
            this.m_lbl_ngay_chot_lai.Text = "Ngày chốt lãi";
            // 
            // m_lbl_ngay_thanh_toan
            // 
            this.m_lbl_ngay_thanh_toan.AutoSize = true;
            this.m_lbl_ngay_thanh_toan.Location = new System.Drawing.Point(261, 124);
            this.m_lbl_ngay_thanh_toan.Name = "m_lbl_ngay_thanh_toan";
            this.m_lbl_ngay_thanh_toan.Size = new System.Drawing.Size(86, 13);
            this.m_lbl_ngay_thanh_toan.TabIndex = 44;
            this.m_lbl_ngay_thanh_toan.Text = "Ngày thanh toán";
            // 
            // m_dat_ngay_chot_lai
            // 
            this.m_dat_ngay_chot_lai.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_chot_lai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_chot_lai.Location = new System.Drawing.Point(363, 74);
            this.m_dat_ngay_chot_lai.Name = "m_dat_ngay_chot_lai";
            this.m_dat_ngay_chot_lai.Size = new System.Drawing.Size(120, 20);
            this.m_dat_ngay_chot_lai.TabIndex = 6;
            // 
            // m_dat_ngay_thanh_toan
            // 
            this.m_dat_ngay_thanh_toan.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_thanh_toan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_thanh_toan.Location = new System.Drawing.Point(363, 117);
            this.m_dat_ngay_thanh_toan.Name = "m_dat_ngay_thanh_toan";
            this.m_dat_ngay_thanh_toan.Size = new System.Drawing.Size(120, 20);
            this.m_dat_ngay_thanh_toan.TabIndex = 7;
            // 
            // m_txt_trang_thai
            // 
            this.m_txt_trang_thai.Location = new System.Drawing.Point(104, 118);
            this.m_txt_trang_thai.Name = "m_txt_trang_thai";
            this.m_txt_trang_thai.Size = new System.Drawing.Size(121, 20);
            this.m_txt_trang_thai.TabIndex = 3;
            // 
            // f201_dm_chot_lai_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.m_dat_ngay_thanh_toan);
            this.Controls.Add(this.m_dat_ngay_chot_lai);
            this.Controls.Add(this.m_lbl_ngay_thanh_toan);
            this.Controls.Add(this.m_lbl_ngay_chot_lai);
            this.Controls.Add(this.m_txt_trang_thai);
            this.Controls.Add(this.m_lbl_nguoi_lap);
            this.Controls.Add(this.m_txt_nguoi_lap);
            this.Controls.Add(this.m_lbl_nguoi_duyet);
            this.Controls.Add(this.m_txt_nguoi_duyet);
            this.Controls.Add(this.m_lbl_ghi_chu);
            this.Controls.Add(this.m_txt_ghi_chu);
            this.Controls.Add(this.m_lbl_muc_dich);
            this.Controls.Add(this.m_txt_muc_dich);
            this.Controls.Add(this.m_lbl_ki_tinh_lai);
            this.Controls.Add(this.m_txt_ki_tinh_lai);
            this.Controls.Add(this.m_lbl_trang_thai);
            this.Controls.Add(this.m_lbl_trai_phieu);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.m_txt_trai_phieu);
            this.Name = "f201_dm_chot_lai_de";
            this.Text = "f201_dm_chot_lai_de";
            this.Load += new System.EventHandler(this.f201_dm_chot_lai_de_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_trai_phieu;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_luu;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Label m_lbl_title;
        private System.Windows.Forms.Label m_lbl_trai_phieu;
        private System.Windows.Forms.Label m_lbl_trang_thai;
        private System.Windows.Forms.Label m_lbl_ki_tinh_lai;
        private System.Windows.Forms.TextBox m_txt_ki_tinh_lai;
        private System.Windows.Forms.Label m_lbl_muc_dich;
        private System.Windows.Forms.TextBox m_txt_muc_dich;
        private System.Windows.Forms.Label m_lbl_ghi_chu;
        private System.Windows.Forms.TextBox m_txt_ghi_chu;
        private System.Windows.Forms.Label m_lbl_nguoi_duyet;
        private System.Windows.Forms.TextBox m_txt_nguoi_duyet;
        private System.Windows.Forms.Label m_lbl_nguoi_lap;
        private System.Windows.Forms.TextBox m_txt_nguoi_lap;
        private System.Windows.Forms.Label m_lbl_ngay_chot_lai;
        private System.Windows.Forms.Label m_lbl_ngay_thanh_toan;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_chot_lai;
        private System.Windows.Forms.DateTimePicker m_dat_ngay_thanh_toan;
        private System.Windows.Forms.TextBox m_txt_trang_thai;
    }
}