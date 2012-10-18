///************************************************
/// Generated by: Syht
/// Date: 12/10/2012 12:25:18
/// Goal: Create Form for V_DM_TRAI_CHU_CHOT_LAI
///************************************************


using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPWordReport;

using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using BondApp.ChucNang;
using BondApp;
using IP.Core.IPExcelReport;

namespace SaleManagement
{



	public class f655_danh_sach_chot_lai : System.Windows.Forms.Form
	{
        internal System.Windows.Forms.ImageList ImageList;
        private Label m_lbl_header;
        private GroupBox groupBox1;
        private Button m_cmd_chon_trai_phieu;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox m_txt_ky_han;
        private Label label1;
        private Label m_lbl_ngay_dao_han;
        private TextBox m_txt_lai_suat;
        private Label m_lbl_ma_trai_phieu;
        private TextBox m_txt_ky_tinh_lai;
        private Label m_lbl_to_chuc_phat_hanh;
        private TextBox m_txt_tong_gia_tri_trai_phieu;
        private Label m_lbl_menh_gia;
        private TextBox m_txt_tong_so_luong_trai_phieu;
        private Label m_lbl_ky_han;
        private TextBox m_txt_ngay_dao_han;
        private Label m_lbl_ngay_phat_hanh;
        private TextBox m_txt_ngay_phat_hanh;
        private Label m_lbl_tong_so_luong_trai_phieu;
        private Label m_lbl_tong_gia_tri_trai_phieu;
        private TextBox m_txt_menh_gia;
        private Label m_lbl_ky_tinh_lai;
        private TextBox m_txt_ten_trai_phieu;
        private Label m_lbl_lai_suat;
        private TextBox m_txt_ma_trai_phieu;
        internal Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_export_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		private System.ComponentModel.IContainer components;

		public f655_danh_sach_chot_lai()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f655_danh_sach_chot_lai));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_cmd_chon_trai_phieu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ky_han = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_ngay_dao_han = new System.Windows.Forms.Label();
            this.m_txt_lai_suat = new System.Windows.Forms.TextBox();
            this.m_lbl_ma_trai_phieu = new System.Windows.Forms.Label();
            this.m_txt_ky_tinh_lai = new System.Windows.Forms.TextBox();
            this.m_lbl_to_chuc_phat_hanh = new System.Windows.Forms.Label();
            this.m_txt_tong_gia_tri_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_lbl_menh_gia = new System.Windows.Forms.Label();
            this.m_txt_tong_so_luong_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_lbl_ky_han = new System.Windows.Forms.Label();
            this.m_txt_ngay_dao_han = new System.Windows.Forms.TextBox();
            this.m_lbl_ngay_phat_hanh = new System.Windows.Forms.Label();
            this.m_txt_ngay_phat_hanh = new System.Windows.Forms.TextBox();
            this.m_lbl_tong_so_luong_trai_phieu = new System.Windows.Forms.Label();
            this.m_lbl_tong_gia_tri_trai_phieu = new System.Windows.Forms.Label();
            this.m_txt_menh_gia = new System.Windows.Forms.TextBox();
            this.m_lbl_ky_tinh_lai = new System.Windows.Forms.Label();
            this.m_txt_ten_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_lbl_lai_suat = new System.Windows.Forms.Label();
            this.m_txt_ma_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_export_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
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
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(968, 24);
            this.m_lbl_header.TabIndex = 24;
            this.m_lbl_header.Text = "F655- DANH SÁCH TRẢ LÃI";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_cmd_chon_trai_phieu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_txt_ky_han);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_lbl_ngay_dao_han);
            this.groupBox1.Controls.Add(this.m_txt_lai_suat);
            this.groupBox1.Controls.Add(this.m_lbl_ma_trai_phieu);
            this.groupBox1.Controls.Add(this.m_txt_ky_tinh_lai);
            this.groupBox1.Controls.Add(this.m_lbl_to_chuc_phat_hanh);
            this.groupBox1.Controls.Add(this.m_txt_tong_gia_tri_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_menh_gia);
            this.groupBox1.Controls.Add(this.m_txt_tong_so_luong_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_ky_han);
            this.groupBox1.Controls.Add(this.m_txt_ngay_dao_han);
            this.groupBox1.Controls.Add(this.m_lbl_ngay_phat_hanh);
            this.groupBox1.Controls.Add(this.m_txt_ngay_phat_hanh);
            this.groupBox1.Controls.Add(this.m_lbl_tong_so_luong_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_tong_gia_tri_trai_phieu);
            this.groupBox1.Controls.Add(this.m_txt_menh_gia);
            this.groupBox1.Controls.Add(this.m_lbl_ky_tinh_lai);
            this.groupBox1.Controls.Add(this.m_txt_ten_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_lai_suat);
            this.groupBox1.Controls.Add(this.m_txt_ma_trai_phieu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 135);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trái phiếu";
            // 
            // m_cmd_chon_trai_phieu
            // 
            this.m_cmd_chon_trai_phieu.Location = new System.Drawing.Point(260, 23);
            this.m_cmd_chon_trai_phieu.Name = "m_cmd_chon_trai_phieu";
            this.m_cmd_chon_trai_phieu.Size = new System.Drawing.Size(27, 23);
            this.m_cmd_chon_trai_phieu.TabIndex = 58;
            this.m_cmd_chon_trai_phieu.Text = "...";
            this.m_cmd_chon_trai_phieu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "VNĐ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(834, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "VNĐ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "tháng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ky_han
            // 
            this.m_txt_ky_han.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ky_han.Location = new System.Drawing.Point(134, 50);
            this.m_txt_ky_han.Name = "m_txt_ky_han";
            this.m_txt_ky_han.ReadOnly = true;
            this.m_txt_ky_han.Size = new System.Drawing.Size(120, 20);
            this.m_txt_ky_han.TabIndex = 47;
            this.m_txt_ky_han.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "năm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_ngay_dao_han
            // 
            this.m_lbl_ngay_dao_han.AutoSize = true;
            this.m_lbl_ngay_dao_han.Location = new System.Drawing.Point(582, 53);
            this.m_lbl_ngay_dao_han.Name = "m_lbl_ngay_dao_han";
            this.m_lbl_ngay_dao_han.Size = new System.Drawing.Size(75, 13);
            this.m_lbl_ngay_dao_han.TabIndex = 38;
            this.m_lbl_ngay_dao_han.Text = "Ngày đáo hạn";
            // 
            // m_txt_lai_suat
            // 
            this.m_txt_lai_suat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_lai_suat.Location = new System.Drawing.Point(134, 102);
            this.m_txt_lai_suat.Name = "m_txt_lai_suat";
            this.m_txt_lai_suat.ReadOnly = true;
            this.m_txt_lai_suat.Size = new System.Drawing.Size(120, 20);
            this.m_txt_lai_suat.TabIndex = 53;
            this.m_txt_lai_suat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_ma_trai_phieu
            // 
            this.m_lbl_ma_trai_phieu.AutoSize = true;
            this.m_lbl_ma_trai_phieu.Location = new System.Drawing.Point(49, 31);
            this.m_lbl_ma_trai_phieu.Name = "m_lbl_ma_trai_phieu";
            this.m_lbl_ma_trai_phieu.Size = new System.Drawing.Size(68, 13);
            this.m_lbl_ma_trai_phieu.TabIndex = 33;
            this.m_lbl_ma_trai_phieu.Text = "Mã trái phiếu";
            this.m_lbl_ma_trai_phieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ky_tinh_lai
            // 
            this.m_txt_ky_tinh_lai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ky_tinh_lai.Location = new System.Drawing.Point(431, 106);
            this.m_txt_ky_tinh_lai.Name = "m_txt_ky_tinh_lai";
            this.m_txt_ky_tinh_lai.ReadOnly = true;
            this.m_txt_ky_tinh_lai.Size = new System.Drawing.Size(69, 20);
            this.m_txt_ky_tinh_lai.TabIndex = 52;
            this.m_txt_ky_tinh_lai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_to_chuc_phat_hanh
            // 
            this.m_lbl_to_chuc_phat_hanh.AutoSize = true;
            this.m_lbl_to_chuc_phat_hanh.Location = new System.Drawing.Point(353, 24);
            this.m_lbl_to_chuc_phat_hanh.Name = "m_lbl_to_chuc_phat_hanh";
            this.m_lbl_to_chuc_phat_hanh.Size = new System.Drawing.Size(72, 13);
            this.m_lbl_to_chuc_phat_hanh.TabIndex = 34;
            this.m_lbl_to_chuc_phat_hanh.Text = "Tên trái phiếu";
            this.m_lbl_to_chuc_phat_hanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_tong_gia_tri_trai_phieu
            // 
            this.m_txt_tong_gia_tri_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_tong_gia_tri_trai_phieu.Location = new System.Drawing.Point(680, 76);
            this.m_txt_tong_gia_tri_trai_phieu.Name = "m_txt_tong_gia_tri_trai_phieu";
            this.m_txt_tong_gia_tri_trai_phieu.ReadOnly = true;
            this.m_txt_tong_gia_tri_trai_phieu.Size = new System.Drawing.Size(148, 20);
            this.m_txt_tong_gia_tri_trai_phieu.TabIndex = 51;
            this.m_txt_tong_gia_tri_trai_phieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_menh_gia
            // 
            this.m_lbl_menh_gia.AutoSize = true;
            this.m_lbl_menh_gia.Location = new System.Drawing.Point(49, 83);
            this.m_lbl_menh_gia.Name = "m_lbl_menh_gia";
            this.m_lbl_menh_gia.Size = new System.Drawing.Size(51, 13);
            this.m_lbl_menh_gia.TabIndex = 35;
            this.m_lbl_menh_gia.Text = "Mệnh giá";
            this.m_lbl_menh_gia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_tong_so_luong_trai_phieu
            // 
            this.m_txt_tong_so_luong_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_tong_so_luong_trai_phieu.Location = new System.Drawing.Point(431, 76);
            this.m_txt_tong_so_luong_trai_phieu.Name = "m_txt_tong_so_luong_trai_phieu";
            this.m_txt_tong_so_luong_trai_phieu.ReadOnly = true;
            this.m_txt_tong_so_luong_trai_phieu.Size = new System.Drawing.Size(130, 20);
            this.m_txt_tong_so_luong_trai_phieu.TabIndex = 50;
            this.m_txt_tong_so_luong_trai_phieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_ky_han
            // 
            this.m_lbl_ky_han.AutoSize = true;
            this.m_lbl_ky_han.Location = new System.Drawing.Point(49, 55);
            this.m_lbl_ky_han.Name = "m_lbl_ky_han";
            this.m_lbl_ky_han.Size = new System.Drawing.Size(40, 13);
            this.m_lbl_ky_han.TabIndex = 36;
            this.m_lbl_ky_han.Text = "Kỳ hạn";
            this.m_lbl_ky_han.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ngay_dao_han
            // 
            this.m_txt_ngay_dao_han.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ngay_dao_han.Location = new System.Drawing.Point(680, 46);
            this.m_txt_ngay_dao_han.Name = "m_txt_ngay_dao_han";
            this.m_txt_ngay_dao_han.ReadOnly = true;
            this.m_txt_ngay_dao_han.Size = new System.Drawing.Size(148, 20);
            this.m_txt_ngay_dao_han.TabIndex = 49;
            // 
            // m_lbl_ngay_phat_hanh
            // 
            this.m_lbl_ngay_phat_hanh.AutoSize = true;
            this.m_lbl_ngay_phat_hanh.Location = new System.Drawing.Point(342, 50);
            this.m_lbl_ngay_phat_hanh.Name = "m_lbl_ngay_phat_hanh";
            this.m_lbl_ngay_phat_hanh.Size = new System.Drawing.Size(83, 13);
            this.m_lbl_ngay_phat_hanh.TabIndex = 37;
            this.m_lbl_ngay_phat_hanh.Text = "Ngày phát hành";
            this.m_lbl_ngay_phat_hanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_ngay_phat_hanh
            // 
            this.m_txt_ngay_phat_hanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ngay_phat_hanh.Location = new System.Drawing.Point(431, 50);
            this.m_txt_ngay_phat_hanh.Name = "m_txt_ngay_phat_hanh";
            this.m_txt_ngay_phat_hanh.ReadOnly = true;
            this.m_txt_ngay_phat_hanh.Size = new System.Drawing.Size(130, 20);
            this.m_txt_ngay_phat_hanh.TabIndex = 48;
            // 
            // m_lbl_tong_so_luong_trai_phieu
            // 
            this.m_lbl_tong_so_luong_trai_phieu.AutoSize = true;
            this.m_lbl_tong_so_luong_trai_phieu.Location = new System.Drawing.Point(307, 79);
            this.m_lbl_tong_so_luong_trai_phieu.Name = "m_lbl_tong_so_luong_trai_phieu";
            this.m_lbl_tong_so_luong_trai_phieu.Size = new System.Drawing.Size(121, 13);
            this.m_lbl_tong_so_luong_trai_phieu.TabIndex = 39;
            this.m_lbl_tong_so_luong_trai_phieu.Text = "Tổng số lượng trái phiếu";
            // 
            // m_lbl_tong_gia_tri_trai_phieu
            // 
            this.m_lbl_tong_gia_tri_trai_phieu.AutoSize = true;
            this.m_lbl_tong_gia_tri_trai_phieu.Location = new System.Drawing.Point(563, 79);
            this.m_lbl_tong_gia_tri_trai_phieu.Name = "m_lbl_tong_gia_tri_trai_phieu";
            this.m_lbl_tong_gia_tri_trai_phieu.Size = new System.Drawing.Size(106, 13);
            this.m_lbl_tong_gia_tri_trai_phieu.TabIndex = 40;
            this.m_lbl_tong_gia_tri_trai_phieu.Text = "Tổng giá trị trái phiếu";
            // 
            // m_txt_menh_gia
            // 
            this.m_txt_menh_gia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_menh_gia.Location = new System.Drawing.Point(134, 76);
            this.m_txt_menh_gia.Name = "m_txt_menh_gia";
            this.m_txt_menh_gia.ReadOnly = true;
            this.m_txt_menh_gia.Size = new System.Drawing.Size(120, 20);
            this.m_txt_menh_gia.TabIndex = 46;
            this.m_txt_menh_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_ky_tinh_lai
            // 
            this.m_lbl_ky_tinh_lai.AutoSize = true;
            this.m_lbl_ky_tinh_lai.Location = new System.Drawing.Point(371, 109);
            this.m_lbl_ky_tinh_lai.Name = "m_lbl_ky_tinh_lai";
            this.m_lbl_ky_tinh_lai.Size = new System.Drawing.Size(54, 13);
            this.m_lbl_ky_tinh_lai.TabIndex = 41;
            this.m_lbl_ky_tinh_lai.Text = "Kỳ tính lãi";
            // 
            // m_txt_ten_trai_phieu
            // 
            this.m_txt_ten_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ten_trai_phieu.Location = new System.Drawing.Point(431, 24);
            this.m_txt_ten_trai_phieu.Name = "m_txt_ten_trai_phieu";
            this.m_txt_ten_trai_phieu.ReadOnly = true;
            this.m_txt_ten_trai_phieu.Size = new System.Drawing.Size(397, 20);
            this.m_txt_ten_trai_phieu.TabIndex = 45;
            // 
            // m_lbl_lai_suat
            // 
            this.m_lbl_lai_suat.AutoSize = true;
            this.m_lbl_lai_suat.Location = new System.Drawing.Point(49, 105);
            this.m_lbl_lai_suat.Name = "m_lbl_lai_suat";
            this.m_lbl_lai_suat.Size = new System.Drawing.Size(44, 13);
            this.m_lbl_lai_suat.TabIndex = 42;
            this.m_lbl_lai_suat.Text = "Lãi suất";
            // 
            // m_txt_ma_trai_phieu
            // 
            this.m_txt_ma_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ma_trai_phieu.Location = new System.Drawing.Point(134, 24);
            this.m_txt_ma_trai_phieu.Name = "m_txt_ma_trai_phieu";
            this.m_txt_ma_trai_phieu.ReadOnly = true;
            this.m_txt_ma_trai_phieu.Size = new System.Drawing.Size(120, 20);
            this.m_txt_ma_trai_phieu.TabIndex = 44;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_export_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 447);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(968, 36);
            this.m_pnl_out_place_dm.TabIndex = 57;
            // 
            // m_cmd_export_excel
            // 
            this.m_cmd_export_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_export_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_export_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_export_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_export_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_export_excel.ImageIndex = 19;
            this.m_cmd_export_excel.ImageList = this.ImageList;
            this.m_cmd_export_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_export_excel.Name = "m_cmd_export_excel";
            this.m_cmd_export_excel.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_export_excel.TabIndex = 22;
            this.m_cmd_export_excel.Text = "Xuất excel";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(876, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 159);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(968, 288);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 58;
            // 
            // f655_danh_sach_chot_lai
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(968, 483);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_lbl_header);
            this.Name = "f655_danh_sach_chot_lai";
            this.Text = "F655 - Danh sách chốt lãi";
            this.Load += new System.EventHandler(this.f655_danh_sach_chot_lai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TEN_TRAI_CHU = 1
,SO_LUONG_TINH_LAI = 7
,NGAY_CAP_CMT = 3
,SO_TIEN_LAI = 8
,CMT_GIAY_DKKD = 2
,SO_TAI_KHOAN = 9
,DIA_CHI = 5
,MOBILE = 6
,NOI_CAP_CMT = 4

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_TRAI_CHU_CHOT_LAI m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
		US_V_DM_TRAI_CHU_CHOT_LAI m_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_PHIEU m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();
		#endregion

		#region Private Methods
		private void format_controls(){
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;	
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);	
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_LUONG_TINH_LAI, e_col_Number.SO_LUONG_TINH_LAI);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TIEN_LAI, e_col_Number.SO_TIEN_LAI);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TAI_KHOAN, e_col_Number.SO_TAI_KHOAN);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.DIA_CHI, e_col_Number.DIA_CHI);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MOBILE, e_col_Number.MOBILE);
			v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_TRAI_CHU_CHOT_LAI.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
			if (m_us_trai_phieu != null)
            m_us.FillDatasetByIDTraiPhieu(m_ds, m_us_trai_phieu.dcID);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}

		private void grid2us_object(US_V_DM_TRAI_CHU_CHOT_LAI i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_TRAI_CHU_CHOT_LAI i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void us_trai_phieu_2_form()
        {
            m_txt_ma_trai_phieu.Text = m_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = m_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(m_us_trai_phieu.dcKY_HAN, "#,###");
            try
            {
                US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_trai_phieu.dcID_DOT_PHAT_HANH);
                US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(v_us_dm_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);
                m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH, "dd/MM/yyyy");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(m_us_trai_phieu.datNGAY_DAO_HAN);
            m_txt_tong_so_luong_trai_phieu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_SL_PHAT_HANH, "#,###");
            m_txt_tong_gia_tri_trai_phieu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_GIA_TRI, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_trai_phieu.dcLAI_SUAT_DEFAULT, "p");
            m_txt_ky_tinh_lai.Text = CIPConvert.ToStr(m_us_trai_phieu.dcKY_TRA_LAI, "#,###");
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();
            m_us_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_trai_phieu.IsIDNull() && m_us_trai_phieu.dcID != -1)
            {
                us_trai_phieu_2_form();
                load_data_2_grid();
            }
        }

        private void export_excel()
        {
            US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_trai_phieu.dcID_DOT_PHAT_HANH);
            US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(v_us_dm_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);

            CExcelReport v_obj_export_excel = new CExcelReport("f300 _Danh Sach Chot.xls", 17, 2);
            v_obj_export_excel.AddFindAndReplaceItem("<TEN_CONG_TY>", v_us_dm_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_export_excel.AddFindAndReplaceItem("<TEN_TRAI_PHIEU>", m_txt_ten_trai_phieu.Text);
            v_obj_export_excel.AddFindAndReplaceItem("<MENH_GIA_TRAI_PHIEU>", m_txt_menh_gia.Text + " VND");
            v_obj_export_excel.AddFindAndReplaceItem("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_export_excel.AddFindAndReplaceItem("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_export_excel.AddFindAndReplaceItem("<NGAY_CHOT_DANH_SACH>", CIPConvert.ToStr(m_us.datNGAY_CHOT_LAI, "dd/MM/yyyy"));
            v_obj_export_excel.AddFindAndReplaceItem("<MUC_DICH>", m_us.strMUC_DICH);
            v_obj_export_excel.AddFindAndReplaceItem("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            v_obj_export_excel.AddFindAndReplaceItem("<LAI_SUAT>", m_txt_lai_suat.Text);
            v_obj_export_excel.AddFindAndReplaceItem("<NGAY_THANH_TOAN>", CIPConvert.ToStr(m_us.datNGAY_THANH_TOAN, "dd/MM/yyyy"));
            v_obj_export_excel.FindAndReplace(false);
            v_obj_export_excel.Export2ExcelWithoutFixedRows(m_fg, (int)e_col_Number.TEN_TRAI_CHU, m_fg.Cols.Count - 1, false);
            
        }

		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_export_excel.Click += new EventHandler(m_cmd_export_excel_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
		}

		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f655_danh_sach_chot_lai_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

        void m_cmd_chon_trai_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_phieu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

