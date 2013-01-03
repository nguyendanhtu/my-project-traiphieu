namespace BondApp.ChucNang
{
    partial class f801_them_ghi_chu_lich_nhac_viec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f801_them_ghi_chu_lich_nhac_viec));
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_insert_note = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ma_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_lbl_ma_trai_phieu = new System.Windows.Forms.Label();
            this.m_lbl_to_chuc_phat_hanh = new System.Windows.Forms.Label();
            this.m_txt_noi_dung_cong_viec = new System.Windows.Forms.TextBox();
            this.m_txt_ngay_dien_ra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.m_lbl_title.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(759, 45);
            this.m_lbl_title.TabIndex = 32;
            this.m_lbl_title.Text = "F801 - Thêm ghi chú cho công việc";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_insert_note);
            this.panel1.Controls.Add(this.m_cmd_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 321);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(759, 36);
            this.panel1.TabIndex = 56;
            // 
            // m_cmd_insert_note
            // 
            this.m_cmd_insert_note.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert_note.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert_note.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert_note.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_insert_note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert_note.ImageIndex = 2;
            this.m_cmd_insert_note.ImageList = this.ImageList;
            this.m_cmd_insert_note.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_insert_note.Name = "m_cmd_insert_note";
            this.m_cmd_insert_note.Size = new System.Drawing.Size(111, 28);
            this.m_cmd_insert_note.TabIndex = 12;
            this.m_cmd_insert_note.Text = "&Thêm ghi chú";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(667, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_txt_ghi_chu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_txt_ma_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_ma_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_to_chuc_phat_hanh);
            this.groupBox1.Controls.Add(this.m_txt_noi_dung_cong_viec);
            this.groupBox1.Controls.Add(this.m_txt_ngay_dien_ra);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 276);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nội dung công việc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ghi chú công việc";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.BackColor = System.Drawing.Color.White;
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(131, 137);
            this.m_txt_ghi_chu.Multiline = true;
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(590, 117);
            this.m_txt_ghi_chu.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên trái phiếu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ma_trai_phieu
            // 
            this.m_txt_ma_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ma_trai_phieu.Location = new System.Drawing.Point(360, 28);
            this.m_txt_ma_trai_phieu.Name = "m_txt_ma_trai_phieu";
            this.m_txt_ma_trai_phieu.ReadOnly = true;
            this.m_txt_ma_trai_phieu.Size = new System.Drawing.Size(361, 20);
            this.m_txt_ma_trai_phieu.TabIndex = 58;
            // 
            // m_lbl_ma_trai_phieu
            // 
            this.m_lbl_ma_trai_phieu.AutoSize = true;
            this.m_lbl_ma_trai_phieu.Location = new System.Drawing.Point(47, 31);
            this.m_lbl_ma_trai_phieu.Name = "m_lbl_ma_trai_phieu";
            this.m_lbl_ma_trai_phieu.Size = new System.Drawing.Size(67, 13);
            this.m_lbl_ma_trai_phieu.TabIndex = 33;
            this.m_lbl_ma_trai_phieu.Text = "Ngày diễn ra";
            this.m_lbl_ma_trai_phieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_to_chuc_phat_hanh
            // 
            this.m_lbl_to_chuc_phat_hanh.AutoSize = true;
            this.m_lbl_to_chuc_phat_hanh.Location = new System.Drawing.Point(14, 76);
            this.m_lbl_to_chuc_phat_hanh.Name = "m_lbl_to_chuc_phat_hanh";
            this.m_lbl_to_chuc_phat_hanh.Size = new System.Drawing.Size(100, 13);
            this.m_lbl_to_chuc_phat_hanh.TabIndex = 34;
            this.m_lbl_to_chuc_phat_hanh.Text = "Nội dung công việc";
            this.m_lbl_to_chuc_phat_hanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_noi_dung_cong_viec
            // 
            this.m_txt_noi_dung_cong_viec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_noi_dung_cong_viec.Location = new System.Drawing.Point(131, 71);
            this.m_txt_noi_dung_cong_viec.Name = "m_txt_noi_dung_cong_viec";
            this.m_txt_noi_dung_cong_viec.ReadOnly = true;
            this.m_txt_noi_dung_cong_viec.Size = new System.Drawing.Size(590, 20);
            this.m_txt_noi_dung_cong_viec.TabIndex = 45;
            // 
            // m_txt_ngay_dien_ra
            // 
            this.m_txt_ngay_dien_ra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ngay_dien_ra.Location = new System.Drawing.Point(131, 28);
            this.m_txt_ngay_dien_ra.Name = "m_txt_ngay_dien_ra";
            this.m_txt_ngay_dien_ra.ReadOnly = true;
            this.m_txt_ngay_dien_ra.Size = new System.Drawing.Size(120, 20);
            this.m_txt_ngay_dien_ra.TabIndex = 44;
            // 
            // f801_them_ghi_chu_lich_nhac_viec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_title);
            this.Name = "f801_them_ghi_chu_lich_nhac_viec";
            this.Text = "F801 - Thêm ghi chú cho lịch nhắc việc";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_title;
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel panel1;
        internal SIS.Controls.Button.SiSButton m_cmd_insert_note;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label m_lbl_ma_trai_phieu;
        private System.Windows.Forms.Label m_lbl_to_chuc_phat_hanh;
        private System.Windows.Forms.TextBox m_txt_noi_dung_cong_viec;
        private System.Windows.Forms.TextBox m_txt_ngay_dien_ra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_txt_ma_trai_phieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txt_ghi_chu;
    }
}