using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

using System.Data;
using BondApp.ChucNang;
using BondApp.HeThong;

namespace BondApp
{
	/// <summary>
	/// Summary description for f001_main_form.
	/// </summary>
	public class f001_main_form : System.Windows.Forms.Form
    {
        private IContainer components;

		public f001_main_form()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f001_main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanTriHêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_user_management = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thamSốNhắcViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thamSốHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTưĐiênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_directory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_type_of_directory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_category = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcTráiPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcTráiChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcĐợtChốtLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchChyểnNhượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucChuyểnNhượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchChuyệnNhượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duyệtGiaoDịchPhongTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiTỏaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giảiTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTráiChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.lịchThanhToánLãiGốcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtLãiSuấtThảNổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtGiaoDịchChốtLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảVốnTráiChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoLãiSuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngBáoNgàyChốtTiềnLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchTrảLãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.báoCáoLãiSuấtTráiPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoInSổSởHữuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoChuyểnNhượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_license = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnp = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýDanhMụcToolStripMenuItem,
            this.nhậpLiệuToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.mnu_license});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đToolStripMenuItem,
            this.quanTriHêThôngToolStripMenuItem,
            this.quanLyTưĐiênToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnu_exit});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // đToolStripMenuItem
            // 
            this.đToolStripMenuItem.Name = "đToolStripMenuItem";
            this.đToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.đToolStripMenuItem.Text = "Đăng nhập";
            // 
            // quanTriHêThôngToolStripMenuItem
            // 
            this.quanTriHêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_user_management,
            this.lịchLàmViệcToolStripMenuItem,
            this.thamSốNhắcViệcToolStripMenuItem,
            this.thamSốHệThốngToolStripMenuItem});
            this.quanTriHêThôngToolStripMenuItem.Name = "quanTriHêThôngToolStripMenuItem";
            this.quanTriHêThôngToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.quanTriHêThôngToolStripMenuItem.Text = "Quản trị hệ thống";
            // 
            // mnu_user_management
            // 
            this.mnu_user_management.Name = "mnu_user_management";
            this.mnu_user_management.Size = new System.Drawing.Size(206, 24);
            this.mnu_user_management.Text = "Người sử dụng";
            this.mnu_user_management.Click += new System.EventHandler(this.mnu_user_management_Click);
            // 
            // lịchLàmViệcToolStripMenuItem
            // 
            this.lịchLàmViệcToolStripMenuItem.Name = "lịchLàmViệcToolStripMenuItem";
            this.lịchLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.lịchLàmViệcToolStripMenuItem.Text = "Lịch làm việc";
            this.lịchLàmViệcToolStripMenuItem.Click += new System.EventHandler(this.lịchLàmViệcToolStripMenuItem_Click);
            // 
            // thamSốNhắcViệcToolStripMenuItem
            // 
            this.thamSốNhắcViệcToolStripMenuItem.Name = "thamSốNhắcViệcToolStripMenuItem";
            this.thamSốNhắcViệcToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.thamSốNhắcViệcToolStripMenuItem.Text = "Tham số nhắc việc";
            this.thamSốNhắcViệcToolStripMenuItem.Click += new System.EventHandler(this.thamSốNhắcViệcToolStripMenuItem_Click);
            // 
            // thamSốHệThốngToolStripMenuItem
            // 
            this.thamSốHệThốngToolStripMenuItem.Name = "thamSốHệThốngToolStripMenuItem";
            this.thamSốHệThốngToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.thamSốHệThốngToolStripMenuItem.Text = "Tham số hệ thống";
            this.thamSốHệThốngToolStripMenuItem.Click += new System.EventHandler(this.thamSốHệThốngToolStripMenuItem_Click);
            // 
            // quanLyTưĐiênToolStripMenuItem
            // 
            this.quanLyTưĐiênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_directory,
            this.mnu_type_of_directory});
            this.quanLyTưĐiênToolStripMenuItem.Name = "quanLyTưĐiênToolStripMenuItem";
            this.quanLyTưĐiênToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.quanLyTưĐiênToolStripMenuItem.Text = "Quản lý từ điển";
            // 
            // mnu_directory
            // 
            this.mnu_directory.Name = "mnu_directory";
            this.mnu_directory.Size = new System.Drawing.Size(161, 24);
            this.mnu_directory.Text = "Từ điển";
            this.mnu_directory.Click += new System.EventHandler(this.mnu_directory_Click);
            // 
            // mnu_type_of_directory
            // 
            this.mnu_type_of_directory.Name = "mnu_type_of_directory";
            this.mnu_type_of_directory.Size = new System.Drawing.Size(161, 24);
            this.mnu_type_of_directory.Text = "Loại từ điển";
            this.mnu_type_of_directory.Click += new System.EventHandler(this.mnu_type_of_directory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(202, 24);
            this.mnu_exit.Text = "Thoát";
            this.mnu_exit.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýDanhMụcToolStripMenuItem
            // 
            this.quảnLýDanhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_category,
            this.danhMụcTráiPhiếuToolStripMenuItem,
            this.danhMụcTráiChủToolStripMenuItem,
            this.danhMụcĐợtChốtLãiToolStripMenuItem});
            this.quảnLýDanhMụcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.quảnLýDanhMụcToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnLýDanhMụcToolStripMenuItem.Name = "quảnLýDanhMụcToolStripMenuItem";
            this.quảnLýDanhMụcToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.quảnLýDanhMụcToolStripMenuItem.Text = "Quản lý danh mục";
            // 
            // mnu_category
            // 
            this.mnu_category.Name = "mnu_category";
            this.mnu_category.Size = new System.Drawing.Size(280, 24);
            this.mnu_category.Text = "Danh mục tổ chức phát hành";
            this.mnu_category.Click += new System.EventHandler(this.mnu_category_Click);
            // 
            // danhMụcTráiPhiếuToolStripMenuItem
            // 
            this.danhMụcTráiPhiếuToolStripMenuItem.Name = "danhMụcTráiPhiếuToolStripMenuItem";
            this.danhMụcTráiPhiếuToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.danhMụcTráiPhiếuToolStripMenuItem.Text = "Danh mục trái phiếu";
            this.danhMụcTráiPhiếuToolStripMenuItem.Click += new System.EventHandler(this.danhMụcTráiPhiếuToolStripMenuItem_Click);
            // 
            // danhMụcTráiChủToolStripMenuItem
            // 
            this.danhMụcTráiChủToolStripMenuItem.Name = "danhMụcTráiChủToolStripMenuItem";
            this.danhMụcTráiChủToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.danhMụcTráiChủToolStripMenuItem.Text = "Danh mục trái chủ";
            this.danhMụcTráiChủToolStripMenuItem.Click += new System.EventHandler(this.danhMụcTráiChủToolStripMenuItem_Click);
            // 
            // danhMụcĐợtChốtLãiToolStripMenuItem
            // 
            this.danhMụcĐợtChốtLãiToolStripMenuItem.Name = "danhMụcĐợtChốtLãiToolStripMenuItem";
            this.danhMụcĐợtChốtLãiToolStripMenuItem.Size = new System.Drawing.Size(280, 24);
            this.danhMụcĐợtChốtLãiToolStripMenuItem.Text = "Danh mục đợt chốt lãi";
            this.danhMụcĐợtChốtLãiToolStripMenuItem.Click += new System.EventHandler(this.danhMụcĐợtChốtLãiToolStripMenuItem_Click);
            // 
            // nhậpLiệuToolStripMenuItem
            // 
            this.nhậpLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDịchChyểnNhượngToolStripMenuItem,
            this.giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem,
            this.giảiTỏaToolStripMenuItem1,
            this.importTráiChủToolStripMenuItem,
            this.toolStripMenuItem4,
            this.lịchThanhToánLãiGốcToolStripMenuItem1,
            this.cậpNhậtLãiSuấtThảNổiToolStripMenuItem,
            this.chiTiếtGiaoDịchChốtLãiToolStripMenuItem,
            this.trảVốnTráiChủToolStripMenuItem,
            this.trảLãiToolStripMenuItem});
            this.nhậpLiệuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.nhậpLiệuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nhậpLiệuToolStripMenuItem.Name = "nhậpLiệuToolStripMenuItem";
            this.nhậpLiệuToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.nhậpLiệuToolStripMenuItem.Text = "Chức năng";
            // 
            // giaoDịchChyểnNhượngToolStripMenuItem
            // 
            this.giaoDịchChyểnNhượngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucChuyểnNhượngToolStripMenuItem,
            this.giaoDịchChuyệnNhượngToolStripMenuItem});
            this.giaoDịchChyểnNhượngToolStripMenuItem.Name = "giaoDịchChyểnNhượngToolStripMenuItem";
            this.giaoDịchChyểnNhượngToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.giaoDịchChyểnNhượngToolStripMenuItem.Text = "Chyển nhượng";
            // 
            // danhMucChuyểnNhượngToolStripMenuItem
            // 
            this.danhMucChuyểnNhượngToolStripMenuItem.Name = "danhMucChuyểnNhượngToolStripMenuItem";
            this.danhMucChuyểnNhượngToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.danhMucChuyểnNhượngToolStripMenuItem.Text = "Danh mục chuyển nhượng";
            this.danhMucChuyểnNhượngToolStripMenuItem.Click += new System.EventHandler(this.danhMucChuyểnNhượngToolStripMenuItem_Click);
            // 
            // giaoDịchChuyệnNhượngToolStripMenuItem
            // 
            this.giaoDịchChuyệnNhượngToolStripMenuItem.Name = "giaoDịchChuyệnNhượngToolStripMenuItem";
            this.giaoDịchChuyệnNhượngToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.giaoDịchChuyệnNhượngToolStripMenuItem.Text = "Giao dịch chuyện nhượng";
            this.giaoDịchChuyệnNhượngToolStripMenuItem.Click += new System.EventHandler(this.giaoDịchChuyệnNhượngToolStripMenuItem_Click);
            // 
            // giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem
            // 
            this.giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongTỏaToolStripMenuItem,
            this.duyệtGiaoDịchPhongTỏaToolStripMenuItem,
            this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem});
            this.giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem.Name = "giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem";
            this.giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem.Text = "Phong tỏa";
            // 
            // phongTỏaToolStripMenuItem
            // 
            this.phongTỏaToolStripMenuItem.Name = "phongTỏaToolStripMenuItem";
            this.phongTỏaToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.phongTỏaToolStripMenuItem.Text = "Lập giao dịch phong tỏa";
            this.phongTỏaToolStripMenuItem.Click += new System.EventHandler(this.phongTỏaToolStripMenuItem_Click);
            // 
            // duyệtGiaoDịchPhongTỏaToolStripMenuItem
            // 
            this.duyệtGiaoDịchPhongTỏaToolStripMenuItem.Name = "duyệtGiaoDịchPhongTỏaToolStripMenuItem";
            this.duyệtGiaoDịchPhongTỏaToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.duyệtGiaoDịchPhongTỏaToolStripMenuItem.Text = "Duyệt giao dịch Phong Tỏa";
            this.duyệtGiaoDịchPhongTỏaToolStripMenuItem.Click += new System.EventHandler(this.duyệtGiaoDịchPhongTỏaToolStripMenuItem_Click);
            // 
            // danhSáchGiaoDịchPhongTỏaToolStripMenuItem
            // 
            this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem.Name = "danhSáchGiaoDịchPhongTỏaToolStripMenuItem";
            this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem.Text = "Danh sách giao dịch Phong Tỏa";
            this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem.Click += new System.EventHandler(this.danhSáchGiaoDịchPhongTỏaToolStripMenuItem_Click);
            // 
            // giảiTỏaToolStripMenuItem1
            // 
            this.giảiTỏaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giảiTỏaToolStripMenuItem,
            this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem,
            this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem});
            this.giảiTỏaToolStripMenuItem1.Name = "giảiTỏaToolStripMenuItem1";
            this.giảiTỏaToolStripMenuItem1.Size = new System.Drawing.Size(261, 24);
            this.giảiTỏaToolStripMenuItem1.Text = "Giải tỏa";
            // 
            // giảiTỏaToolStripMenuItem
            // 
            this.giảiTỏaToolStripMenuItem.Name = "giảiTỏaToolStripMenuItem";
            this.giảiTỏaToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.giảiTỏaToolStripMenuItem.Text = "Lập giao dịch Giải tỏa";
            this.giảiTỏaToolStripMenuItem.Click += new System.EventHandler(this.giảiTỏaToolStripMenuItem_Click);
            // 
            // duyệtGiaoDịchGiảiTỏaToolStripMenuItem
            // 
            this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem.Name = "duyệtGiaoDịchGiảiTỏaToolStripMenuItem";
            this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem.Text = "Duyệt giao dịch giải tỏa";
            this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem.Click += new System.EventHandler(this.duyệtGiaoDịchGiảiTỏaToolStripMenuItem_Click);
            // 
            // danhSáchGiaoDịchGiảiTỏaToolStripMenuItem
            // 
            this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem.Name = "danhSáchGiaoDịchGiảiTỏaToolStripMenuItem";
            this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem.Text = "Danh sách giao dịch giải tỏa";
            this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem.Click += new System.EventHandler(this.danhSáchGiaoDịchGiảiTỏaToolStripMenuItem_Click);
            // 
            // importTráiChủToolStripMenuItem
            // 
            this.importTráiChủToolStripMenuItem.Name = "importTráiChủToolStripMenuItem";
            this.importTráiChủToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.importTráiChủToolStripMenuItem.Text = "Import trái chủ";
            this.importTráiChủToolStripMenuItem.Click += new System.EventHandler(this.importTráiChủToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(258, 6);
            // 
            // lịchThanhToánLãiGốcToolStripMenuItem1
            // 
            this.lịchThanhToánLãiGốcToolStripMenuItem1.Name = "lịchThanhToánLãiGốcToolStripMenuItem1";
            this.lịchThanhToánLãiGốcToolStripMenuItem1.Size = new System.Drawing.Size(261, 24);
            this.lịchThanhToánLãiGốcToolStripMenuItem1.Text = "Lập lịch thanh toán lãi gốc";
            // 
            // cậpNhậtLãiSuấtThảNổiToolStripMenuItem
            // 
            this.cậpNhậtLãiSuấtThảNổiToolStripMenuItem.Name = "cậpNhậtLãiSuấtThảNổiToolStripMenuItem";
            this.cậpNhậtLãiSuấtThảNổiToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.cậpNhậtLãiSuấtThảNổiToolStripMenuItem.Text = "Cập nhật lãi suất thả nổi";
            // 
            // chiTiếtGiaoDịchChốtLãiToolStripMenuItem
            // 
            this.chiTiếtGiaoDịchChốtLãiToolStripMenuItem.Name = "chiTiếtGiaoDịchChốtLãiToolStripMenuItem";
            this.chiTiếtGiaoDịchChốtLãiToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.chiTiếtGiaoDịchChốtLãiToolStripMenuItem.Text = "Lập danh sách chốt lãi";
            // 
            // trảVốnTráiChủToolStripMenuItem
            // 
            this.trảVốnTráiChủToolStripMenuItem.Name = "trảVốnTráiChủToolStripMenuItem";
            this.trảVốnTráiChủToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.trảVốnTráiChủToolStripMenuItem.Text = "Trả vốn trái chủ";
            // 
            // trảLãiToolStripMenuItem
            // 
            this.trảLãiToolStripMenuItem.Name = "trảLãiToolStripMenuItem";
            this.trảLãiToolStripMenuItem.Size = new System.Drawing.Size(261, 24);
            this.trảLãiToolStripMenuItem.Text = "Trả lãi";
            this.trảLãiToolStripMenuItem.Click += new System.EventHandler(this.trảLãiToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngBáoLãiSuấtToolStripMenuItem,
            this.thôngBáoNgàyChốtTiềnLãiToolStripMenuItem,
            this.toolStripMenuItem3,
            this.thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem,
            this.phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem,
            this.danhSáchTrảLãiToolStripMenuItem,
            this.yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem,
            this.toolStripMenuItem2,
            this.báoCáoLãiSuấtTráiPhiếuToolStripMenuItem,
            this.báoCáoInSổSởHữuToolStripMenuItem,
            this.báoCáoChuyểnNhượngToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.báoCáoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // thôngBáoLãiSuấtToolStripMenuItem
            // 
            this.thôngBáoLãiSuấtToolStripMenuItem.Name = "thôngBáoLãiSuấtToolStripMenuItem";
            this.thôngBáoLãiSuấtToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.thôngBáoLãiSuấtToolStripMenuItem.Text = "Thông báo lãi suất";
            // 
            // thôngBáoNgàyChốtTiềnLãiToolStripMenuItem
            // 
            this.thôngBáoNgàyChốtTiềnLãiToolStripMenuItem.Name = "thôngBáoNgàyChốtTiềnLãiToolStripMenuItem";
            this.thôngBáoNgàyChốtTiềnLãiToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.thôngBáoNgàyChốtTiềnLãiToolStripMenuItem.Text = "Thông báo ngày chốt tiền lãi";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(338, 6);
            // 
            // thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem
            // 
            this.thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem.Name = "thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem";
            this.thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem.Text = "Thông báo thanh toán lãi trái phiếu";
            // 
            // phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem
            // 
            this.phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem.Name = "phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem";
            this.phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem.Text = "Phiếu đề xuất kỳ trả lãi tiếp theo";
            // 
            // danhSáchTrảLãiToolStripMenuItem
            // 
            this.danhSáchTrảLãiToolStripMenuItem.Name = "danhSáchTrảLãiToolStripMenuItem";
            this.danhSáchTrảLãiToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.danhSáchTrảLãiToolStripMenuItem.Text = "Danh sách trả lãi";
            // 
            // yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem
            // 
            this.yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem.Name = "yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem";
            this.yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem.Text = "Yêu cầu tổ chức phát hành trả lãi suất";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(338, 6);
            // 
            // báoCáoLãiSuấtTráiPhiếuToolStripMenuItem
            // 
            this.báoCáoLãiSuấtTráiPhiếuToolStripMenuItem.Name = "báoCáoLãiSuấtTráiPhiếuToolStripMenuItem";
            this.báoCáoLãiSuấtTráiPhiếuToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.báoCáoLãiSuấtTráiPhiếuToolStripMenuItem.Text = "Báo cáo lãi suất trái phiếu";
            // 
            // báoCáoInSổSởHữuToolStripMenuItem
            // 
            this.báoCáoInSổSởHữuToolStripMenuItem.Name = "báoCáoInSổSởHữuToolStripMenuItem";
            this.báoCáoInSổSởHữuToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.báoCáoInSổSởHữuToolStripMenuItem.Text = "Báo cáo in sổ sở hữu";
            // 
            // báoCáoChuyểnNhượngToolStripMenuItem
            // 
            this.báoCáoChuyểnNhượngToolStripMenuItem.Name = "báoCáoChuyểnNhượngToolStripMenuItem";
            this.báoCáoChuyểnNhượngToolStripMenuItem.Size = new System.Drawing.Size(341, 24);
            this.báoCáoChuyểnNhượngToolStripMenuItem.Text = "Báo cáo chuyển nhượng";
            this.báoCáoChuyểnNhượngToolStripMenuItem.Click += new System.EventHandler(this.báoCáoChuyểnNhượngToolStripMenuItem_Click);
            // 
            // mnu_license
            // 
            this.mnu_license.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.mnu_license.ForeColor = System.Drawing.Color.White;
            this.mnu_license.Name = "mnu_license";
            this.mnu_license.Size = new System.Drawing.Size(95, 24);
            this.mnu_license.Text = "Bản quyền";
            this.mnu_license.Click += new System.EventHandler(this.mnu_license_Click);
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
            // m_pnp
            // 
            this.m_pnp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnp.Location = new System.Drawing.Point(0, 349);
            this.m_pnp.Name = "m_pnp";
            this.m_pnp.Size = new System.Drawing.Size(1008, 393);
            this.m_pnp.TabIndex = 1;
            // 
            // f001_main_form
            // 
            this.ClientSize = new System.Drawing.Size(1008, 742);
            this.Controls.Add(this.m_pnp);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "f001_main_form";
            this.Text = "F001 - Chuong trinh quan ly trai phieu - version 2012.09.07";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem quảnLýDanhMụcToolStripMenuItem;
        internal ImageList ImageList;
        private ToolStripMenuItem đToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnu_exit;
        private ToolStripMenuItem quanTriHêThôngToolStripMenuItem;
        private ToolStripMenuItem mnu_user_management;
        private ToolStripMenuItem mnu_license;
        private ToolStripMenuItem quanLyTưĐiênToolStripMenuItem;
        private ToolStripMenuItem mnu_directory;
        private ToolStripMenuItem mnu_type_of_directory;
        private ToolStripMenuItem mnu_category;
        private ToolStripMenuItem danhMụcTráiPhiếuToolStripMenuItem;
        private ToolStripMenuItem danhMụcTráiChủToolStripMenuItem;
        private ToolStripMenuItem danhMụcĐợtChốtLãiToolStripMenuItem;
        private ToolStripMenuItem giaoDịchChyểnNhượngToolStripMenuItem;
        private ToolStripMenuItem giaoDịchPhongTỏaGiảiTỏaToolStripMenuItem;
        private ToolStripMenuItem chiTiếtGiaoDịchChốtLãiToolStripMenuItem;
        private Panel m_pnp;
        private ToolStripMenuItem cậpNhậtLãiSuấtThảNổiToolStripMenuItem;
        private ToolStripMenuItem thôngBáoLãiSuấtToolStripMenuItem;
        private ToolStripMenuItem thôngBáoNgàyChốtTiềnLãiToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem thôngBáoThanhToánLãiTráiPhiếuToolStripMenuItem;
        private ToolStripMenuItem phiếuĐềXuấtKỳTrảLãiTiếpTheoToolStripMenuItem;
        private ToolStripMenuItem danhSáchTrảLãiToolStripMenuItem;
        private ToolStripMenuItem yêuCầuTổChứcPhátHànhTrảLãiSuấtToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem báoCáoLãiSuấtTráiPhiếuToolStripMenuItem;
        private ToolStripMenuItem báoCáoInSổSởHữuToolStripMenuItem;
        private ToolStripMenuItem báoCáoChuyểnNhượngToolStripMenuItem;
        private ToolStripMenuItem lịchThanhToánLãiGốcToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem trảVốnTráiChủToolStripMenuItem;
        private ToolStripMenuItem lịchLàmViệcToolStripMenuItem;
        private ToolStripMenuItem phongTỏaToolStripMenuItem;
        private ToolStripMenuItem giảiTỏaToolStripMenuItem;
        private ToolStripMenuItem trảLãiToolStripMenuItem;
        private ToolStripMenuItem duyệtGiaoDịchPhongTỏaToolStripMenuItem;
        private ToolStripMenuItem giảiTỏaToolStripMenuItem1;
        private ToolStripMenuItem duyệtGiaoDịchGiảiTỏaToolStripMenuItem;
        private ToolStripMenuItem danhSáchGiaoDịchPhongTỏaToolStripMenuItem;
        private ToolStripMenuItem danhSáchGiaoDịchGiảiTỏaToolStripMenuItem;
        private ToolStripMenuItem thamSốNhắcViệcToolStripMenuItem;
        private ToolStripMenuItem thamSốHệThốngToolStripMenuItem;
        private ToolStripMenuItem importTráiChủToolStripMenuItem;
        private ToolStripMenuItem danhMucChuyểnNhượngToolStripMenuItem;
        private ToolStripMenuItem giaoDịchChuyệnNhượngToolStripMenuItem;
        private ToolStripMenuItem nhậpLiệuToolStripMenuItem;


        #region public Interface
        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm o_exitMode)
        {
            this.ShowDialog();
            o_exitMode = m_exitMode;
        }

        #endregion
        #region Data Structures
      
        #endregion

        #region Members
        
        IPConstants.HowUserWantTo_Exit_MainForm m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
        #endregion
        
        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.ShowInTaskbar = true;
            set_define_events();
        }
      
        private void show_manager_user()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.BACK_UP_AND_RESTORE))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được quyền truy nhập phần này !!! ");
                return;
            }
            f999_ht_nguoi_su_dung v_frm_999 = new f999_ht_nguoi_su_dung();
            v_frm_999.display();
        }
        private void show_introduction()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f996_license_form v_frm996 = new f996_license_form();
            v_frm996.display();
            //			IP.Core.IPSystemAdmin.f996_license v_frm = new f996_license () ;
            //			v_frm.display () ;
        }

        private void show_tu_dien_phan_quyen()
        {
            //if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            //{
            //    BaseMessages.MsgBox_Infor(" Người sử dụng không có quyền truy nhập phần này ! ");
            //    return;
            //}
            f100_TuDien v_frm = new f100_TuDien();
            v_frm.ShowDialog();
        }

        private void set_inital_form_load()
        {

            f800_lich_nhac_viec v_frm800 = new f800_lich_nhac_viec();

            v_frm800.display_in_container(m_pnp);
        }
        private void show_to_chuc_phat_hanh()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f100_dm_to_chuc_phat_hanh v_frm100 = new f100_dm_to_chuc_phat_hanh();
            v_frm100.display();                  
        }

        private void show_trai_phieu()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            v_frm300.display();
        }

        private void show_trai_chu()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            v_frm500.display();
        }

        private void show_dot_chot_lai()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f200_dm_dot_chot_lai v_frm200 = new f200_dm_dot_chot_lai();
            v_frm200.display();
        }
        
        private void show_phong_toa_lap()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f700_giao_dich_phong_toa_giai_toa v_frm700 = new f700_giao_dich_phong_toa_giai_toa();           
            v_frm700.display_phong_toa();
        }
        private void show_phong_toa_duyet()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f701_danh_sach_giao_dich_phong_giai_toa v_frm701 = new f701_danh_sach_giao_dich_phong_giai_toa();
            v_frm701.display_duyet_phong_toa();
        }
        private void show_giai_toa_lap()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f700_giao_dich_phong_toa_giai_toa v_frm700 = new f700_giao_dich_phong_toa_giai_toa();          
            v_frm700.display_giai_toa();
        }
        private void show_giai_toa_duyet()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f701_danh_sach_giao_dich_phong_giai_toa v_frm701 = new f701_danh_sach_giao_dich_phong_giai_toa();
            v_frm701.display_duyet_giai_toa();
        }
        private void show_danh_sach_giai_toa()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f660_bao_cao_tinh_hinh_giai_toa v_frm660 = new f660_bao_cao_tinh_hinh_giai_toa();
            v_frm660.display_danh_sach_giai_toa();
        }
        private void show_danh_sach_phong_toa()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            //f701_danh_sach_giao_dich_phong_giai_toa v_frm701 = new f701_danh_sach_giao_dich_phong_giai_toa();
            //v_frm701.display_danh_sach_phong_toa();
            f659_bao_cao_tinh_hinh_phong_toa v_frm659 = new f659_bao_cao_tinh_hinh_phong_toa();
            v_frm659.display_danh_sach_phong_toa();
        }
        private void show_bao_cao_giao_dich_chuyen_nhuong()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.IN_BAO_CAO))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }

            f601_bao_cao_giao_dich_chuyen_nhuong v_frm601 = new f601_bao_cao_giao_dich_chuyen_nhuong();
            v_frm601.display();
        }
        private void show_danh_muc_chuyen_nhuong()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f610_dm_giao_dien_chuyen_nhuong v_frm610 = new f610_dm_giao_dien_chuyen_nhuong();
            v_frm610.display();
        }

        private void show_giao_dich_chuyen_nhuong()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f600_giao_dich_chuyen_nhuong v_frm600 = new f600_giao_dich_chuyen_nhuong();
            v_frm600.display_lap_chuyen_nhuong();
        }
         private void show_lich_lam_viec()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f850_dm_ngay_lam_viec v_frm850 = new f850_dm_ngay_lam_viec();
            v_frm850.display();
        }

        private void show_tra_lai()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f900_quan_ly_coupon v_frm900 = new f900_quan_ly_coupon();
            v_frm900.display();
        }

        private void show_tuy_chinh_tham_so_nhac_viec()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f106_tuy_chinh_tham_so_nhac_viec v_frm106 = new f106_tuy_chinh_tham_so_nhac_viec();
            v_frm106.display();
        }
        private void show_tham_so_he_thong()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f107_ht_tham_so_he_thong v_frm107 = new f107_ht_tham_so_he_thong();
            v_frm107.display();
        }
        private void show_form_import()
        {
            if (!CAppContext_201.IsHavingQuyen(IP.Core.IPSystemAdmin.PHAN_QUYEN.CHUC_NANG))
            {
                BaseMessages.MsgBox_Infor(" Người sử dụng không được phép truy nhập phần này !!! ");
                return;
            }
            f260_import_trai_chu_tu_excel v_frm260 = new f260_import_trai_chu_tu_excel();
            v_frm260.display();
        }
        
        #endregion
        //
        //
        //   event handlers
        //
        //
        private void set_define_events()
        {

            this.Load += new EventHandler(f001_main_form_Load);
            
            
            
        }

        void f001_main_form_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.MsgBox_Confirm("Bạn có thật sự muốn kết thúc chương trình không ? "))
                {
                    m_exitMode = IPConstants.HowUserWantTo_Exit_MainForm.ExitFromSystem;
                    this.Close();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_user_management_Click(object sender, EventArgs e)
        {
            try
            {
                show_manager_user();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void mnu_license_Click(object sender, EventArgs e)
        {
            try
            {

                show_introduction();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_directory_Click(object sender, EventArgs e)
        {
            try
            {

                show_tu_dien_phan_quyen();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_type_of_directory_Click(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void mnu_category_Click(object sender, EventArgs e)
        {
            try
            {
                show_to_chuc_phat_hanh();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhMụcTráiPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_trai_phieu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhMụcTráiChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_trai_chu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhMụcĐợtChốtLãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_dot_chot_lai();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }      

        private void lịchLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_lich_lam_viec();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void phongTỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_phong_toa_lap();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void giảiTỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_giai_toa_lap();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void trảLãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_tra_lai();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void duyệtGiaoDịchPhongTỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_phong_toa_duyet();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void duyệtGiaoDịchGiảiTỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_giai_toa_duyet();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhSáchGiaoDịchPhongTỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_danh_sach_phong_toa();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhSáchGiaoDịchGiảiTỏaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_danh_sach_giai_toa();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thamSốNhắcViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_tuy_chinh_tham_so_nhac_viec();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void thamSốHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_tham_so_he_thong();

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void importTráiChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_form_import();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
       

        private void giaoDịchChuyệnNhượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_danh_muc_chuyen_nhuong();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void danhMucChuyểnNhượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_giao_dich_chuyen_nhuong();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void báoCáoChuyểnNhượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                show_bao_cao_giao_dich_chuyen_nhuong();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    

        
    }
}
