///************************************************
/// Generated by: SyHT
/// Date: 08/09/2012 11:29:27
/// Goal: Create Form for GD_CHOT_LAI
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BondApp
{



	public class f200_dm_dot_chot_lai : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_gen;
        private Label m_lbl_title;
        private GroupBox groupBox1;
        private Label m_lbl_muc_dich;
        private TextBox m_txt_nguoi_lap;
        private Label m_lbl_ma_trai_phieu;
        private Label m_lbl_ten_trai_phieu;
        private TextBox m_txt_trang_thai;
        private Label m_lbl_ngay_chot_lai;
        private TextBox m_txt_muc_dich;
        private TextBox m_txt_ky_tinh_lai;
        private Label m_lbl_ghi_chu;
        private Label m_lbl_trang_thai;
        private Label m_lbl_nguoi_lap;
        private TextBox m_txt_ma_trai_phieu;
        private C1FlexGrid m_fg;
        private DateTimePicker m_dat_ngay_thanh_toan;
        private Label m_lbl_ngay_thanh_toan;
        private DateTimePicker m_dat_ngay_chot_lai;
        private TextBox m_txt_nguoi_duyet;
        private Label m_lbl_nguoi_duyet;
        private Label m_lbl_ky_tinh_lai;
        private TextBox m_txt_tong_so_luong_trai_phieu;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
		private System.ComponentModel.IContainer components;

		public f200_dm_dot_chot_lai()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f200_dm_dot_chot_lai));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_gen = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_lbl_ky_tinh_lai = new System.Windows.Forms.Label();
            this.m_txt_nguoi_duyet = new System.Windows.Forms.TextBox();
            this.m_lbl_nguoi_duyet = new System.Windows.Forms.Label();
            this.m_dat_ngay_thanh_toan = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_ngay_thanh_toan = new System.Windows.Forms.Label();
            this.m_dat_ngay_chot_lai = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_muc_dich = new System.Windows.Forms.Label();
            this.m_txt_nguoi_lap = new System.Windows.Forms.TextBox();
            this.m_lbl_ma_trai_phieu = new System.Windows.Forms.Label();
            this.m_lbl_ten_trai_phieu = new System.Windows.Forms.Label();
            this.m_txt_trang_thai = new System.Windows.Forms.TextBox();
            this.m_txt_tong_so_luong_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_lbl_ngay_chot_lai = new System.Windows.Forms.Label();
            this.m_txt_muc_dich = new System.Windows.Forms.TextBox();
            this.m_txt_ky_tinh_lai = new System.Windows.Forms.TextBox();
            this.m_lbl_ghi_chu = new System.Windows.Forms.Label();
            this.m_lbl_trang_thai = new System.Windows.Forms.Label();
            this.m_lbl_nguoi_lap = new System.Windows.Forms.Label();
            this.m_txt_ma_trai_phieu = new System.Windows.Forms.TextBox();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_gen);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 445);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(755, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(399, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 22;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(487, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_gen
            // 
            this.m_cmd_gen.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_gen.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_gen.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_gen.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_gen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_gen.ImageIndex = 18;
            this.m_cmd_gen.ImageList = this.ImageList;
            this.m_cmd_gen.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_gen.Name = "m_cmd_gen";
            this.m_cmd_gen.Size = new System.Drawing.Size(146, 28);
            this.m_cmd_gen.TabIndex = 21;
            this.m_cmd_gen.Text = "Sinh danh sách trả lãi";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(575, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(663, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(755, 37);
            this.m_lbl_title.TabIndex = 24;
            this.m_lbl_title.Text = "F200 - Danh mục chốt lãi";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_lbl_ky_tinh_lai);
            this.groupBox1.Controls.Add(this.m_txt_nguoi_duyet);
            this.groupBox1.Controls.Add(this.m_lbl_nguoi_duyet);
            this.groupBox1.Controls.Add(this.m_dat_ngay_thanh_toan);
            this.groupBox1.Controls.Add(this.m_lbl_ngay_thanh_toan);
            this.groupBox1.Controls.Add(this.m_dat_ngay_chot_lai);
            this.groupBox1.Controls.Add(this.m_lbl_muc_dich);
            this.groupBox1.Controls.Add(this.m_txt_nguoi_lap);
            this.groupBox1.Controls.Add(this.m_lbl_ma_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_ten_trai_phieu);
            this.groupBox1.Controls.Add(this.m_txt_trang_thai);
            this.groupBox1.Controls.Add(this.m_txt_tong_so_luong_trai_phieu);
            this.groupBox1.Controls.Add(this.m_lbl_ngay_chot_lai);
            this.groupBox1.Controls.Add(this.m_txt_muc_dich);
            this.groupBox1.Controls.Add(this.m_txt_ky_tinh_lai);
            this.groupBox1.Controls.Add(this.m_lbl_ghi_chu);
            this.groupBox1.Controls.Add(this.m_lbl_trang_thai);
            this.groupBox1.Controls.Add(this.m_lbl_nguoi_lap);
            this.groupBox1.Controls.Add(this.m_txt_ma_trai_phieu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 200);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trái phiếu";
            // 
            // m_lbl_ky_tinh_lai
            // 
            this.m_lbl_ky_tinh_lai.AutoSize = true;
            this.m_lbl_ky_tinh_lai.Location = new System.Drawing.Point(552, 53);
            this.m_lbl_ky_tinh_lai.Name = "m_lbl_ky_tinh_lai";
            this.m_lbl_ky_tinh_lai.Size = new System.Drawing.Size(54, 13);
            this.m_lbl_ky_tinh_lai.TabIndex = 63;
            this.m_lbl_ky_tinh_lai.Text = "Kỳ tính lãi";
            // 
            // m_txt_nguoi_duyet
            // 
            this.m_txt_nguoi_duyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_nguoi_duyet.Location = new System.Drawing.Point(358, 102);
            this.m_txt_nguoi_duyet.Name = "m_txt_nguoi_duyet";
            this.m_txt_nguoi_duyet.ReadOnly = true;
            this.m_txt_nguoi_duyet.Size = new System.Drawing.Size(120, 20);
            this.m_txt_nguoi_duyet.TabIndex = 62;
            this.m_txt_nguoi_duyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_nguoi_duyet
            // 
            this.m_lbl_nguoi_duyet.AutoSize = true;
            this.m_lbl_nguoi_duyet.Location = new System.Drawing.Point(288, 105);
            this.m_lbl_nguoi_duyet.Name = "m_lbl_nguoi_duyet";
            this.m_lbl_nguoi_duyet.Size = new System.Drawing.Size(64, 13);
            this.m_lbl_nguoi_duyet.TabIndex = 61;
            this.m_lbl_nguoi_duyet.Text = "Người duyệt";
            // 
            // m_dat_ngay_thanh_toan
            // 
            this.m_dat_ngay_thanh_toan.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_dat_ngay_thanh_toan.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_thanh_toan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_thanh_toan.Location = new System.Drawing.Point(358, 50);
            this.m_dat_ngay_thanh_toan.Name = "m_dat_ngay_thanh_toan";
            this.m_dat_ngay_thanh_toan.Size = new System.Drawing.Size(120, 20);
            this.m_dat_ngay_thanh_toan.TabIndex = 60;
            // 
            // m_lbl_ngay_thanh_toan
            // 
            this.m_lbl_ngay_thanh_toan.AutoSize = true;
            this.m_lbl_ngay_thanh_toan.Location = new System.Drawing.Point(266, 55);
            this.m_lbl_ngay_thanh_toan.Name = "m_lbl_ngay_thanh_toan";
            this.m_lbl_ngay_thanh_toan.Size = new System.Drawing.Size(86, 13);
            this.m_lbl_ngay_thanh_toan.TabIndex = 59;
            this.m_lbl_ngay_thanh_toan.Text = "Ngày thanh toán";
            this.m_lbl_ngay_thanh_toan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_dat_ngay_chot_lai
            // 
            this.m_dat_ngay_chot_lai.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_dat_ngay_chot_lai.CustomFormat = "dd/MM/yyyy";
            this.m_dat_ngay_chot_lai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_ngay_chot_lai.Location = new System.Drawing.Point(106, 50);
            this.m_dat_ngay_chot_lai.Name = "m_dat_ngay_chot_lai";
            this.m_dat_ngay_chot_lai.Size = new System.Drawing.Size(120, 20);
            this.m_dat_ngay_chot_lai.TabIndex = 58;
            // 
            // m_lbl_muc_dich
            // 
            this.m_lbl_muc_dich.AutoSize = true;
            this.m_lbl_muc_dich.Location = new System.Drawing.Point(21, 79);
            this.m_lbl_muc_dich.Name = "m_lbl_muc_dich";
            this.m_lbl_muc_dich.Size = new System.Drawing.Size(54, 13);
            this.m_lbl_muc_dich.TabIndex = 38;
            this.m_lbl_muc_dich.Text = "Mục đích";
            // 
            // m_txt_nguoi_lap
            // 
            this.m_txt_nguoi_lap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_nguoi_lap.Location = new System.Drawing.Point(106, 102);
            this.m_txt_nguoi_lap.Name = "m_txt_nguoi_lap";
            this.m_txt_nguoi_lap.ReadOnly = true;
            this.m_txt_nguoi_lap.Size = new System.Drawing.Size(120, 20);
            this.m_txt_nguoi_lap.TabIndex = 53;
            this.m_txt_nguoi_lap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_ma_trai_phieu
            // 
            this.m_lbl_ma_trai_phieu.AutoSize = true;
            this.m_lbl_ma_trai_phieu.Location = new System.Drawing.Point(21, 27);
            this.m_lbl_ma_trai_phieu.Name = "m_lbl_ma_trai_phieu";
            this.m_lbl_ma_trai_phieu.Size = new System.Drawing.Size(68, 13);
            this.m_lbl_ma_trai_phieu.TabIndex = 33;
            this.m_lbl_ma_trai_phieu.Text = "Mã trái phiếu";
            this.m_lbl_ma_trai_phieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_ten_trai_phieu
            // 
            this.m_lbl_ten_trai_phieu.AutoSize = true;
            this.m_lbl_ten_trai_phieu.Location = new System.Drawing.Point(232, 27);
            this.m_lbl_ten_trai_phieu.Name = "m_lbl_ten_trai_phieu";
            this.m_lbl_ten_trai_phieu.Size = new System.Drawing.Size(72, 13);
            this.m_lbl_ten_trai_phieu.TabIndex = 34;
            this.m_lbl_ten_trai_phieu.Text = "Tên trái phiếu";
            this.m_lbl_ten_trai_phieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_trang_thai
            // 
            this.m_txt_trang_thai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_trang_thai.Location = new System.Drawing.Point(358, 76);
            this.m_txt_trang_thai.Name = "m_txt_trang_thai";
            this.m_txt_trang_thai.ReadOnly = true;
            this.m_txt_trang_thai.Size = new System.Drawing.Size(120, 20);
            this.m_txt_trang_thai.TabIndex = 51;
            this.m_txt_trang_thai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_txt_tong_so_luong_trai_phieu
            // 
            this.m_txt_tong_so_luong_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_tong_so_luong_trai_phieu.Location = new System.Drawing.Point(106, 128);
            this.m_txt_tong_so_luong_trai_phieu.Multiline = true;
            this.m_txt_tong_so_luong_trai_phieu.Name = "m_txt_tong_so_luong_trai_phieu";
            this.m_txt_tong_so_luong_trai_phieu.ReadOnly = true;
            this.m_txt_tong_so_luong_trai_phieu.Size = new System.Drawing.Size(626, 57);
            this.m_txt_tong_so_luong_trai_phieu.TabIndex = 50;
            this.m_txt_tong_so_luong_trai_phieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_lbl_ngay_chot_lai
            // 
            this.m_lbl_ngay_chot_lai.AutoSize = true;
            this.m_lbl_ngay_chot_lai.Location = new System.Drawing.Point(21, 55);
            this.m_lbl_ngay_chot_lai.Name = "m_lbl_ngay_chot_lai";
            this.m_lbl_ngay_chot_lai.Size = new System.Drawing.Size(69, 13);
            this.m_lbl_ngay_chot_lai.TabIndex = 36;
            this.m_lbl_ngay_chot_lai.Text = "Ngày chốt lãi";
            this.m_lbl_ngay_chot_lai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_txt_muc_dich
            // 
            this.m_txt_muc_dich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_muc_dich.Location = new System.Drawing.Point(106, 76);
            this.m_txt_muc_dich.Name = "m_txt_muc_dich";
            this.m_txt_muc_dich.ReadOnly = true;
            this.m_txt_muc_dich.Size = new System.Drawing.Size(120, 20);
            this.m_txt_muc_dich.TabIndex = 49;
            // 
            // m_txt_ky_tinh_lai
            // 
            this.m_txt_ky_tinh_lai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ky_tinh_lai.Location = new System.Drawing.Point(612, 48);
            this.m_txt_ky_tinh_lai.Name = "m_txt_ky_tinh_lai";
            this.m_txt_ky_tinh_lai.ReadOnly = true;
            this.m_txt_ky_tinh_lai.Size = new System.Drawing.Size(120, 20);
            this.m_txt_ky_tinh_lai.TabIndex = 48;
            // 
            // m_lbl_ghi_chu
            // 
            this.m_lbl_ghi_chu.AutoSize = true;
            this.m_lbl_ghi_chu.Location = new System.Drawing.Point(21, 128);
            this.m_lbl_ghi_chu.Name = "m_lbl_ghi_chu";
            this.m_lbl_ghi_chu.Size = new System.Drawing.Size(44, 13);
            this.m_lbl_ghi_chu.TabIndex = 39;
            this.m_lbl_ghi_chu.Text = "Ghi chú";
            // 
            // m_lbl_trang_thai
            // 
            this.m_lbl_trang_thai.AutoSize = true;
            this.m_lbl_trang_thai.Location = new System.Drawing.Point(297, 79);
            this.m_lbl_trang_thai.Name = "m_lbl_trang_thai";
            this.m_lbl_trang_thai.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_trang_thai.TabIndex = 40;
            this.m_lbl_trang_thai.Text = "Trạng thái";
            // 
            // m_lbl_nguoi_lap
            // 
            this.m_lbl_nguoi_lap.AutoSize = true;
            this.m_lbl_nguoi_lap.Location = new System.Drawing.Point(21, 105);
            this.m_lbl_nguoi_lap.Name = "m_lbl_nguoi_lap";
            this.m_lbl_nguoi_lap.Size = new System.Drawing.Size(52, 13);
            this.m_lbl_nguoi_lap.TabIndex = 42;
            this.m_lbl_nguoi_lap.Text = "Người lập";
            // 
            // m_txt_ma_trai_phieu
            // 
            this.m_txt_ma_trai_phieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.m_txt_ma_trai_phieu.Location = new System.Drawing.Point(106, 24);
            this.m_txt_ma_trai_phieu.Name = "m_txt_ma_trai_phieu";
            this.m_txt_ma_trai_phieu.ReadOnly = true;
            this.m_txt_ma_trai_phieu.Size = new System.Drawing.Size(120, 20);
            this.m_txt_ma_trai_phieu.TabIndex = 44;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 237);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(755, 208);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 56;
            // 
            // f200_dm_dot_chot_lai
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(755, 481);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f200_dm_dot_chot_lai";
            this.Text = "F200-Danh muc chot lai";
            this.Load += new System.EventHandler(this.f200_dm_dot_chot_lai_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
			ID_NGUOI_LAP = 3
,NGAY_CHOT_LAI = 1
,ID_TRAI_PHIEU = 6
,GHI_CHU1 = 9
,KY_TINH_LAI = 7
,NGAY_THANH_TOAN = 2
,ID_NGUOI_DUYET = 4
,MUC_DICH = 8
,TRANG_THAI = 5

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_GD_CHOT_LAI m_ds = new DS_GD_CHOT_LAI();
		US_GD_CHOT_LAI m_us_gd_dot_chot_lai = new US_GD_CHOT_LAI();
        //US_GD_CHOT_LAI_DETAIL m_us_gd_dot_chot_lai_detail = new US_GD_CHOT_LAI_DETAIL();
        US_DM_TRAI_PHIEU m_us_dm_trai_phieu = new US_DM_TRAI_PHIEU();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
			set_define_events();
			this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
		}
		private void set_initial_form_load(){
            us_trai_phieu_2_form();
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}
        private void us_trai_phieu_2_form()
        {
            m_txt_ma_trai_phieu.Text = m_us_dm_trai_phieu.strMA_TRAI_PHIEU;
            m_lbl_ten_trai_phieu.Text = m_us_dm_trai_phieu.strTEN_TRAI_PHIEU;
        }

		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(GD_CHOT_LAI.ID_NGUOI_LAP, e_col_Number.ID_NGUOI_LAP);
			v_htb.Add(GD_CHOT_LAI.NGAY_CHOT_LAI, e_col_Number.NGAY_CHOT_LAI);
			v_htb.Add(GD_CHOT_LAI.ID_TRAI_PHIEU, e_col_Number.ID_TRAI_PHIEU);
			v_htb.Add(GD_CHOT_LAI.GHI_CHU1, e_col_Number.GHI_CHU1);
			v_htb.Add(GD_CHOT_LAI.KY_TINH_LAI, e_col_Number.KY_TINH_LAI);
			v_htb.Add(GD_CHOT_LAI.NGAY_THANH_TOAN, e_col_Number.NGAY_THANH_TOAN);
			v_htb.Add(GD_CHOT_LAI.ID_NGUOI_DUYET, e_col_Number.ID_NGUOI_DUYET);
			v_htb.Add(GD_CHOT_LAI.MUC_DICH, e_col_Number.MUC_DICH);
			v_htb.Add(GD_CHOT_LAI.TRANG_THAI, e_col_Number.TRANG_THAI);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.GD_CHOT_LAI.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_GD_CHOT_LAI();
            m_us_gd_dot_chot_lai.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_GD_CHOT_LAI i_us, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
		private void us_object2grid(US_GD_CHOT_LAI i_us, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_gd_chot_lai(){
            //f201_dm_chot_lai_de v_fDE = new f201_dm_chot_lai_de();
            //v_fDE.display_for_insert();
			load_data_2_grid();
		}

		private void update_gd_chot_lai(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_gd_dot_chot_lai, m_fg.Row);
            //f201_dm_chot_lai_de v_fDE = new f201_dm_chot_lai_de();
            //v_fDE.display_for_update(m_us);
			load_data_2_grid();
		}
				
		private void delete_gd_chot_lai(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_GD_CHOT_LAI v_us = new US_GD_CHOT_LAI();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}
        private void gen_gd_chot_lai()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_gd_dot_chot_lai, m_fg.Row);
            f201_dm_gd_chot_lai_detail v_f201 = new f201_dm_gd_chot_lai_detail(m_us_gd_dot_chot_lai);
            v_f201.display();
        }
		private void set_define_events(){
            this.Load += new EventHandler(f200_dm_dot_chot_lai_Load);
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_gen.Click += new EventHandler(m_cmd_gen_Click);
		}
		#endregion
		private void f200_dm_dot_chot_lai_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
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

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_gd_chot_lai();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_gd_chot_lai();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_gen_Click(object sender, EventArgs e) {
			try{
                gen_gd_chot_lai();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
	}
}

