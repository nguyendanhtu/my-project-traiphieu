using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

using IP.FMS.FMSBondData;
using IP.FMS.FMSBondData.CDBNames;
using IP.FMS.FMSBondUserService;

using IP.Core.IPData;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData.IPDBName;
using IP.Core.IPSystemAdmin;

using IP.FMS.FMSBondWin;
using IP.FMS.FMSCommonData;
using IP.FMS.FMSCommonUserService;
using IP.FMS.FMSCommonData.CDBNames;

using C1.Win.C1FlexGrid;


namespace IP.FMS.FMSBondWin
{
	/// <summary>
	/// Summary description for f312_nhac_viec.
	/// </summary>
	internal class f312_nhac_viec : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox m_group_thu_coupon;
		private System.Windows.Forms.GroupBox m_group_thu_goc;
		private System.Windows.Forms.GroupBox m_group_lenh;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg_thu_coupon;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg_thu_goc;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg_lenh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private SIS.Controls.Button.SiSButton m_cmd_xoa_1_lenh;
		private SIS.Controls.Button.SiSButton m_cmd_xoa_het_lenh;
		private System.Windows.Forms.TextBox m_txt_so_ngay_nhac_viec_coupon;
		private System.Windows.Forms.TextBox m_txt_so_ngay_nhac_viec_thu_goc;
		private System.Windows.Forms.DateTimePicker m_dat_ngay_dat_nhac_thu_coupon;
		private System.Windows.Forms.DateTimePicker m_dat_ngay_dat_nhac_thu_goc;
		private System.Windows.Forms.ImageList m_img_list;
		
		private System.ComponentModel.IContainer components;

		public f312_nhac_viec()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			initial_format();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(f312_nhac_viec));
			this.m_group_thu_coupon = new System.Windows.Forms.GroupBox();
			this.m_fg_thu_coupon = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.m_dat_ngay_dat_nhac_thu_coupon = new System.Windows.Forms.DateTimePicker();
			this.m_txt_so_ngay_nhac_viec_coupon = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_group_thu_goc = new System.Windows.Forms.GroupBox();
			this.m_fg_thu_goc = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.m_dat_ngay_dat_nhac_thu_goc = new System.Windows.Forms.DateTimePicker();
			this.m_txt_so_ngay_nhac_viec_thu_goc = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.m_group_lenh = new System.Windows.Forms.GroupBox();
			this.m_fg_lenh = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.m_cmd_xoa_het_lenh = new SIS.Controls.Button.SiSButton();
			this.m_img_list = new System.Windows.Forms.ImageList(this.components);
			this.m_cmd_xoa_1_lenh = new SIS.Controls.Button.SiSButton();
			this.m_group_thu_coupon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_fg_thu_coupon)).BeginInit();
			this.panel4.SuspendLayout();
			this.m_group_thu_goc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_fg_thu_goc)).BeginInit();
			this.panel5.SuspendLayout();
			this.m_group_lenh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_fg_lenh)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_group_thu_coupon
			// 
			this.m_group_thu_coupon.Controls.Add(this.m_fg_thu_coupon);
			this.m_group_thu_coupon.Controls.Add(this.panel4);
			this.m_group_thu_coupon.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_group_thu_coupon.Location = new System.Drawing.Point(0, 0);
			this.m_group_thu_coupon.Name = "m_group_thu_coupon";
			this.m_group_thu_coupon.Size = new System.Drawing.Size(792, 136);
			this.m_group_thu_coupon.TabIndex = 0;
			this.m_group_thu_coupon.TabStop = false;
			this.m_group_thu_coupon.Text = "Thu coupon";
			// 
			// m_fg_thu_coupon
			// 
			this.m_fg_thu_coupon.ColumnInfo = "3,1,0,0,0,85,Columns:0{Width:16;}\t1{Width:145;Caption:\"Mã trái phiếu\";DataType:Sy" +
				"stem.String;TextAlign:LeftCenter;}\t2{Width:140;Caption:\"Ngày trả lãi coupon\";Dat" +
				"aType:System.DateTime;Format:\"d\";TextAlign:LeftCenter;}\t";
			this.m_fg_thu_coupon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_fg_thu_coupon.Location = new System.Drawing.Point(3, 16);
			this.m_fg_thu_coupon.Name = "m_fg_thu_coupon";
			this.m_fg_thu_coupon.Size = new System.Drawing.Size(642, 117);
			this.m_fg_thu_coupon.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.m_fg_thu_coupon.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.m_dat_ngay_dat_nhac_thu_coupon);
			this.panel4.Controls.Add(this.m_txt_so_ngay_nhac_viec_coupon);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(645, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(144, 117);
			this.panel4.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 144;
			this.label2.Text = "Xem đến ngày";
			// 
			// m_dat_ngay_dat_nhac_thu_coupon
			// 
			this.m_dat_ngay_dat_nhac_thu_coupon.CustomFormat = "dd/MM/yyyy";
			this.m_dat_ngay_dat_nhac_thu_coupon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.m_dat_ngay_dat_nhac_thu_coupon.Location = new System.Drawing.Point(32, 88);
			this.m_dat_ngay_dat_nhac_thu_coupon.Name = "m_dat_ngay_dat_nhac_thu_coupon";
			this.m_dat_ngay_dat_nhac_thu_coupon.Size = new System.Drawing.Size(88, 20);
			this.m_dat_ngay_dat_nhac_thu_coupon.TabIndex = 143;
			this.m_dat_ngay_dat_nhac_thu_coupon.Value = new System.DateTime(2006, 1, 9, 0, 0, 0, 0);
			// 
			// m_txt_so_ngay_nhac_viec_coupon
			// 
			this.m_txt_so_ngay_nhac_viec_coupon.Location = new System.Drawing.Point(32, 32);
			this.m_txt_so_ngay_nhac_viec_coupon.Name = "m_txt_so_ngay_nhac_viec_coupon";
			this.m_txt_so_ngay_nhac_viec_coupon.Size = new System.Drawing.Size(40, 20);
			this.m_txt_so_ngay_nhac_viec_coupon.TabIndex = 1;
			this.m_txt_so_ngay_nhac_viec_coupon.Text = "0";
			this.m_txt_so_ngay_nhac_viec_coupon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số ngày xem trước";
			// 
			// m_group_thu_goc
			// 
			this.m_group_thu_goc.Controls.Add(this.m_fg_thu_goc);
			this.m_group_thu_goc.Controls.Add(this.panel5);
			this.m_group_thu_goc.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_group_thu_goc.Location = new System.Drawing.Point(0, 136);
			this.m_group_thu_goc.Name = "m_group_thu_goc";
			this.m_group_thu_goc.Size = new System.Drawing.Size(792, 128);
			this.m_group_thu_goc.TabIndex = 1;
			this.m_group_thu_goc.TabStop = false;
			this.m_group_thu_goc.Text = "Thu gốc";
			// 
			// m_fg_thu_goc
			// 
			this.m_fg_thu_goc.ColumnInfo = "3,1,0,0,0,85,Columns:0{Width:16;}\t1{Width:145;Caption:\"Mã trái phiếu\";DataType:Sy" +
				"stem.String;TextAlign:LeftCenter;}\t2{Width:140;Caption:\"Ngày thanh toán gốc\";Dat" +
				"aType:System.DateTime;Format:\"d\";TextAlign:LeftCenter;}\t";
			this.m_fg_thu_goc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_fg_thu_goc.Location = new System.Drawing.Point(3, 16);
			this.m_fg_thu_goc.Name = "m_fg_thu_goc";
			this.m_fg_thu_goc.Size = new System.Drawing.Size(642, 109);
			this.m_fg_thu_goc.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.m_fg_thu_goc.TabIndex = 4;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.m_dat_ngay_dat_nhac_thu_goc);
			this.panel5.Controls.Add(this.m_txt_so_ngay_nhac_viec_thu_goc);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel5.Location = new System.Drawing.Point(645, 16);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(144, 109);
			this.panel5.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 18);
			this.label3.TabIndex = 148;
			this.label3.Text = "Xem đến ngày";
			// 
			// m_dat_ngay_dat_nhac_thu_goc
			// 
			this.m_dat_ngay_dat_nhac_thu_goc.CustomFormat = "dd/MM/yyyy";
			this.m_dat_ngay_dat_nhac_thu_goc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.m_dat_ngay_dat_nhac_thu_goc.Location = new System.Drawing.Point(36, 78);
			this.m_dat_ngay_dat_nhac_thu_goc.Name = "m_dat_ngay_dat_nhac_thu_goc";
			this.m_dat_ngay_dat_nhac_thu_goc.Size = new System.Drawing.Size(88, 20);
			this.m_dat_ngay_dat_nhac_thu_goc.TabIndex = 147;
			this.m_dat_ngay_dat_nhac_thu_goc.Value = new System.DateTime(2006, 1, 9, 0, 0, 0, 0);
			// 
			// m_txt_so_ngay_nhac_viec_thu_goc
			// 
			this.m_txt_so_ngay_nhac_viec_thu_goc.Location = new System.Drawing.Point(36, 22);
			this.m_txt_so_ngay_nhac_viec_thu_goc.Name = "m_txt_so_ngay_nhac_viec_thu_goc";
			this.m_txt_so_ngay_nhac_viec_thu_goc.Size = new System.Drawing.Size(40, 20);
			this.m_txt_so_ngay_nhac_viec_thu_goc.TabIndex = 146;
			this.m_txt_so_ngay_nhac_viec_thu_goc.Text = "0";
			this.m_txt_so_ngay_nhac_viec_thu_goc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(36, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 16);
			this.label4.TabIndex = 145;
			this.label4.Text = "Số ngày xem trước";
			// 
			// m_group_lenh
			// 
			this.m_group_lenh.Controls.Add(this.m_fg_lenh);
			this.m_group_lenh.Controls.Add(this.panel3);
			this.m_group_lenh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_group_lenh.Location = new System.Drawing.Point(0, 264);
			this.m_group_lenh.Name = "m_group_lenh";
			this.m_group_lenh.Size = new System.Drawing.Size(792, 302);
			this.m_group_lenh.TabIndex = 2;
			this.m_group_lenh.TabStop = false;
			this.m_group_lenh.Text = "Lệnh mua bán chưa khớp";
			// 
			// m_fg_lenh
			// 
			this.m_fg_lenh.ColumnInfo = @"6,1,0,0,0,85,Columns:0{Width:16;}	1{Width:150;Caption:""Mã loại lệnh"";DataType:System.String;TextAlign:LeftCenter;}	2{Width:153;Caption:""Mã lệnh"";DataType:System.String;TextAlign:LeftCenter;}	3{Width:127;Caption:""Mã trái phiếu"";DataType:System.String;TextAlign:LeftCenter;}	4{Width:101;Caption:""Ngày đặt lệnh"";DataType:System.DateTime;Format:""d"";TextAlign:LeftCenter;}	5{Caption:""Trạng thái"";DataType:System.String;TextAlign:LeftCenter;}	";
			this.m_fg_lenh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_fg_lenh.Location = new System.Drawing.Point(3, 16);
			this.m_fg_lenh.Name = "m_fg_lenh";
			this.m_fg_lenh.Size = new System.Drawing.Size(690, 283);
			this.m_fg_lenh.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.m_fg_lenh.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.m_cmd_xoa_het_lenh);
			this.panel3.Controls.Add(this.m_cmd_xoa_1_lenh);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(693, 16);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(96, 283);
			this.panel3.TabIndex = 1;
			// 
			// m_cmd_xoa_het_lenh
			// 
			this.m_cmd_xoa_het_lenh.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_xoa_het_lenh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_xoa_het_lenh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_xoa_het_lenh.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_cmd_xoa_het_lenh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_xoa_het_lenh.ImageIndex = 15;
			this.m_cmd_xoa_het_lenh.ImageList = this.m_img_list;
			this.m_cmd_xoa_het_lenh.Location = new System.Drawing.Point(0, 32);
			this.m_cmd_xoa_het_lenh.Name = "m_cmd_xoa_het_lenh";
			this.m_cmd_xoa_het_lenh.Size = new System.Drawing.Size(96, 32);
			this.m_cmd_xoa_het_lenh.TabIndex = 1;
			this.m_cmd_xoa_het_lenh.Text = "Xóa hết";
			// 
			// m_img_list
			// 
			this.m_img_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
			this.m_img_list.ImageSize = new System.Drawing.Size(24, 24);
			this.m_img_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_img_list.ImageStream")));
			this.m_img_list.TransparentColor = System.Drawing.Color.White;
			// 
			// m_cmd_xoa_1_lenh
			// 
			this.m_cmd_xoa_1_lenh.AdjustImageLocation = new System.Drawing.Point(0, 0);
			this.m_cmd_xoa_1_lenh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
			this.m_cmd_xoa_1_lenh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
			this.m_cmd_xoa_1_lenh.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_cmd_xoa_1_lenh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.m_cmd_xoa_1_lenh.ImageIndex = 15;
			this.m_cmd_xoa_1_lenh.ImageList = this.m_img_list;
			this.m_cmd_xoa_1_lenh.Location = new System.Drawing.Point(0, 0);
			this.m_cmd_xoa_1_lenh.Name = "m_cmd_xoa_1_lenh";
			this.m_cmd_xoa_1_lenh.Size = new System.Drawing.Size(96, 32);
			this.m_cmd_xoa_1_lenh.TabIndex = 0;
			this.m_cmd_xoa_1_lenh.Text = "Xóa";
			// 
			// f312_nhac_viec
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.m_group_lenh);
			this.Controls.Add(this.m_group_thu_goc);
			this.Controls.Add(this.m_group_thu_coupon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "f312_nhac_viec";
			this.Text = "F312-Nhac viec trai phieu";
			this.m_group_thu_coupon.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_fg_thu_coupon)).EndInit();
			this.panel4.ResumeLayout(false);
			this.m_group_thu_goc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_fg_thu_goc)).EndInit();
			this.panel5.ResumeLayout(false);
			this.m_group_lenh.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_fg_lenh)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region  public functions
		public void display(){
			this.ShowDialog();
		}
		#endregion
		#region data structures
		private enum e_coupon_date_cols {
			ma_trai_phieu	= 1
			,ngay_coupon	= 2
		}		
		private enum e_face_date_cols {
			ma_trai_phieu	= 1
			,ngay_thu_goc	= 2
		}		
		private enum e_lenh_cols {
			ma_loai_lenh	= 1
			,ma_lenh	    = 2
			,ma_trai_phieu	= 3
			,ngay_dat		= 4
			,trang_thai		= 5
		}		

		#endregion
		#region members
		ITransferDataRow		m_obj_coupon_date;
		ITransferDataRow		m_obj_face_date;
		ITransferDataRow		m_obj_lenh;
		#endregion
		#region private methods
		private void initial_events(){
			this.Load += new EventHandler(f312_nhac_viec_Load);
			m_cmd_xoa_1_lenh.Click += new EventHandler(m_cmd_xoa_1_lenh_Click);
			m_cmd_xoa_het_lenh.Click += new EventHandler(m_cmd_xoa_het_lenh_Click);

			m_txt_so_ngay_nhac_viec_coupon.TextChanged += new EventHandler(m_txt_so_ngay_nhac_viec_coupon_TextChanged);
			m_txt_so_ngay_nhac_viec_thu_goc.TextChanged += new EventHandler(m_txt_so_ngay_nhac_viec_thu_goc_TextChanged);
			m_dat_ngay_dat_nhac_thu_coupon.ValueChanged += new EventHandler(m_dat_ngay_dat_nhac_thu_coupon_ValueChanged);
			m_dat_ngay_dat_nhac_thu_goc.ValueChanged += new EventHandler(m_dat_ngay_dat_nhac_thu_goc_ValueChanged);
		}
		private void initial_format(){
			initial_events();
			CControlFormat.setFormStyle(this,IPFormStyle.DialogForm);
			CControlFormat.setC1FlexFormat(m_fg_lenh, C1GridStyle.GridViewAndSearch);
			CGridUtils.AddSearch_Handlers(m_fg_lenh);
			CControlFormat.setC1FlexFormat(m_fg_thu_coupon, C1GridStyle.GridViewAndSearch);
			CGridUtils.AddSearch_Handlers(m_fg_thu_coupon);
			CControlFormat.setC1FlexFormat(m_fg_thu_goc, C1GridStyle.GridViewAndSearch);
			CGridUtils.AddSearch_Handlers(m_fg_thu_goc);
		}
		private ITransferDataRow get_obj_coupon_date_trans() {
			Hashtable v_hast = new Hashtable();
			DS_BOND_COUPON_DATE	v_ds_bond_coupon_date = new DS_BOND_COUPON_DATE();
			v_hast.Add(BOND_COUPON_DATE.BOND_CODE, e_coupon_date_cols.ma_trai_phieu);
			v_hast.Add(BOND_COUPON_DATE.COUPON_DATE, e_coupon_date_cols.ngay_coupon);
			return new CC1TransferDataRow(m_fg_thu_coupon
				, v_hast
				, v_ds_bond_coupon_date.BOND_COUPON_DATE.NewBOND_COUPON_DATERow());
		}
		private ITransferDataRow get_obj_face_date_trans() {
			Hashtable v_hast = new Hashtable();
			DS_CM_DM_TRAI_PHIEU	v_ds_cm_dm_trai_phieu = new DS_CM_DM_TRAI_PHIEU();
			v_hast.Add(CM_DM_TRAI_PHIEU.MA_TRAI_PHIEU, e_face_date_cols.ma_trai_phieu);
			v_hast.Add(CM_DM_TRAI_PHIEU.NGAY_THANH_TOAN_GOC, e_face_date_cols.ngay_thu_goc);
			return new CC1TransferDataRow(m_fg_thu_goc
				, v_hast
				, v_ds_cm_dm_trai_phieu.CM_DM_TRAI_PHIEU.NewCM_DM_TRAI_PHIEURow());
		}
		private ITransferDataRow get_obj_lenh_trans() {
			Hashtable v_hast = new Hashtable();
			DS_BOND_GD_DEAL_BOND	v_ds_bond_gd_deal_bond = new DS_BOND_GD_DEAL_BOND();
			v_hast.Add(BOND_GD_DEAL_BOND.DEAL_TYPE_CODE, e_lenh_cols.ma_loai_lenh);
			v_hast.Add(BOND_GD_DEAL_BOND.DEAL_CODE, e_lenh_cols.ma_lenh);
			v_hast.Add(BOND_GD_DEAL_BOND.MA_TRAI_PHIEU, e_lenh_cols.ma_trai_phieu);
			v_hast.Add(BOND_GD_DEAL_BOND.NGAY_DAT_LENH, e_lenh_cols.ngay_dat);
			v_hast.Add(BOND_GD_DEAL_BOND.TRANG_THAI_LENH, e_lenh_cols.trang_thai);
			return new CC1TransferDataRow(m_fg_lenh
				, v_hast
				, v_ds_bond_gd_deal_bond.BOND_GD_DEAL_BOND.NewBOND_GD_DEAL_BONDRow());
		}
		private void m_fg_lenh_2_us(US_BOND_GD_DEAL_BOND o_us, int i_int_indx){
			if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg_lenh,i_int_indx)) return;
			DataRow v_dr = (DataRow)m_fg_lenh.Rows[i_int_indx].UserData;
			o_us.DataRow2Me(v_dr);
		}
		private void xoa_du_lieu_khong_hop_le_tren_m_fg_ngay_coupon(){
			if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_thu_coupon)) return;
			decimal tong_so_luong_tp = 0;
			decimal tong_gia_tri_tp = 0;
			try{
				US_CM_DM_TRAI_PHIEU v_us = new US_CM_DM_TRAI_PHIEU();
				v_us.open_connection();
				for(int v_int_indx = m_fg_thu_coupon.Rows.Fixed
						;v_int_indx < m_fg_thu_coupon.Rows.Count
					;v_int_indx++){
					if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg_thu_coupon,v_int_indx)) continue;
					v_us.lay_sl_gtr_tp_gd_duoc_theo_ma(
						CIPConvert.ToStr(m_fg_thu_coupon[v_int_indx,(int)e_coupon_date_cols.ma_trai_phieu])
						,Convert.ToDateTime(m_fg_thu_coupon[v_int_indx,(int)e_coupon_date_cols.ngay_coupon].ToString())
						,ref tong_so_luong_tp
						,ref tong_gia_tri_tp);
					if (tong_so_luong_tp <=0 ){
						m_fg_thu_coupon.RemoveItem(v_int_indx);
						v_int_indx -=1;
					}
				}
			}catch(Exception v_e){
				throw v_e;
			}

		}
		private void xoa_du_lieu_khong_hop_le_tren_m_fg_ngay_thu_goc(){
			if(!CGridUtils.IsThere_Any_NonFixed_Row(m_fg_thu_goc)) return;
			decimal tong_so_luong_tp = 0;
			decimal tong_gia_tri_tp = 0;
			try{
				US_CM_DM_TRAI_PHIEU v_us = new US_CM_DM_TRAI_PHIEU();
				v_us.open_connection();
				for(int v_int_indx = m_fg_thu_goc.Rows.Fixed
						;v_int_indx < m_fg_thu_goc.Rows.Count
					;v_int_indx++){
					if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg_thu_goc,v_int_indx)) continue;
					v_us.lay_sl_gtr_tp_gd_duoc_theo_ma(
						CIPConvert.ToStr(m_fg_thu_goc[v_int_indx,(int)e_face_date_cols.ma_trai_phieu])
						,Convert.ToDateTime(m_fg_thu_goc[v_int_indx,(int)e_face_date_cols.ngay_thu_goc].ToString())
						,ref tong_so_luong_tp
						,ref tong_gia_tri_tp);
					if (tong_so_luong_tp <=0 ){
						m_fg_thu_goc.RemoveItem(v_int_indx);
						v_int_indx -=1;
					}
				}
			}catch(Exception v_e){
				throw v_e;
			}

		}
		private void load_data_2_m_fg_coupon_date(){
			DS_BOND_COUPON_DATE v_ds = new DS_BOND_COUPON_DATE();
			US_BOND_COUPON_DATE v_us = new US_BOND_COUPON_DATE();
			try{
				v_us.open_connection();
				v_us.fill_DS_4_nhac_thu_coupon(v_ds,m_dat_ngay_dat_nhac_thu_coupon.Value);
				v_us.commit_close_connection();
			}
			catch(Exception v_e){
				v_us.rollback_close_connection();
				throw v_e;
			}
			CGridUtils.Dataset2C1Grid(v_ds,m_fg_thu_coupon,m_obj_coupon_date);
			//xoa_du_lieu_khong_hop_le_tren_m_fg_ngay_coupon();
			//cai nay can xem lai tai sao gia tri ra luon =0?
		}
		private void load_data_2_m_fg_face_date(){
			DS_CM_DM_TRAI_PHIEU v_ds = new DS_CM_DM_TRAI_PHIEU();
			US_CM_DM_TRAI_PHIEU v_us = new US_CM_DM_TRAI_PHIEU();
			try{
				v_us.open_connection();
				v_us.fill_DS_4_nhac_thu_goc(v_ds,m_dat_ngay_dat_nhac_thu_goc.Value);
				v_us.commit_close_connection();
			}
			catch(Exception v_e){
				v_us.rollback_close_connection();
				throw v_e;
			}
			CGridUtils.Dataset2C1Grid(v_ds,m_fg_thu_goc,m_obj_face_date);
			//xoa_du_lieu_khong_hop_le_tren_m_fg_ngay_thu_goc();
		}
		private void load_data_2_m_fg_lenh(){
			DS_BOND_GD_DEAL_BOND v_ds = new DS_BOND_GD_DEAL_BOND();
			US_BOND_GD_DEAL_BOND v_us = new US_BOND_GD_DEAL_BOND();
			try{
				v_us.open_connection();
				v_us.Fill_DataSet_4_nhac_viec( v_ds,CApplicationContext.get_curent_datetime());
				v_us.commit_close_connection();
			}
			catch(Exception v_e){
				v_us.rollback_close_connection();
				throw v_e;
			}
			CGridUtils.Dataset2C1Grid(v_ds,m_fg_lenh,m_obj_lenh);
		}
		private void load_data_ngay_nhac_viec_2_form(){
			US_CM_DM_TU_DIEN v_us_1 = new US_CM_DM_TU_DIEN();
			US_CM_DM_TU_DIEN v_us_2 = new US_CM_DM_TU_DIEN();
			try{
				v_us_1.open_connection();	
				v_us_2.continue_connection_of(v_us_1);	
				v_us_1.findByID(BOND_NGAY_NHAC_VIEC.C_DEC_ID_NHAC_SO_NGAY_THU_GOC);
				v_us_2.findByID(BOND_NGAY_NHAC_VIEC.C_DEC_ID_NHAC_SO_NGAY_THU_COUPON);	
				v_us_1.commit_close_connection();
			}
			catch(Exception v_e){
				v_us_1.rollback_close_connection();
				throw v_e;
			}
			if(v_us_2.IsIDNull()) return;
			m_txt_so_ngay_nhac_viec_coupon.Text = CIPConvert.ToStr(v_us_2.dcID_LOAI_TU_DIEN,CIPConvert.get_default_dec_format());
			if(v_us_1.IsIDNull()) return;
			m_txt_so_ngay_nhac_viec_thu_goc.Text = CIPConvert.ToStr(v_us_1.dcID_LOAI_TU_DIEN,CIPConvert.get_default_dec_format());
		}
		private void delete_us_lenh(US_BOND_GD_DEAL_BOND v_us){
			if(v_us.IsIDNull()) return;
			US_BOND_GD_INV_DEAL v_us_inv_deal = new US_BOND_GD_INV_DEAL();
			US_BOND_GD_INVESTMENT v_us_inv = new US_BOND_GD_INVESTMENT();
			try{
				v_us.open_connection();			
				v_us_inv_deal.continue_connection_of(v_us);
				v_us_inv.continue_connection_of(v_us);

				v_us_inv_deal.find_by_bond_gd_deal_bond_id(v_us.dcID);				
				v_us_inv.findByID(v_us_inv_deal.dcINV_ID);
				switch(v_us_inv.strTRANG_THAI_INV){
					case BOND_DM_TRANG_THAI_INVESTMENT.C_STR_DANG_DAT_MUA_TP:
						v_us_inv.strTRANG_THAI_INV = BOND_DM_TRANG_THAI_INVESTMENT.C_STR_STATE_DA_DUYET_MUA.ToString();
						break;
				}
				v_us_inv.Update();
				v_us_inv_deal.Delete();
				v_us.Delete();
				v_us.commit_close_connection();
			}
			catch(Exception v_e){
				v_us.rollback_close_connection();
				throw v_e;
			}
		}

		private void update_ngay_nhac_viec(decimal id_ngay_nhac_viec_trai_phieu,decimal i_int_so_ngay ){			
			US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
			try{
				v_us.open_connection();	
				v_us.findByID(id_ngay_nhac_viec_trai_phieu);
				v_us.dcID_LOAI_TU_DIEN = i_int_so_ngay;
				v_us.Update();
				v_us.commit_close_connection();
			}
			catch(Exception v_e){
				v_us.rollback_close_connection();
				throw v_e;
			}
		}
		#endregion
		#region events handler
		#endregion

		private void f312_nhac_viec_Load(object sender, EventArgs e) {
			try{				
				m_obj_coupon_date = get_obj_coupon_date_trans();
				m_obj_face_date   = get_obj_face_date_trans();
				m_obj_lenh		  = get_obj_lenh_trans();
				
				load_data_ngay_nhac_viec_2_form();
				load_data_2_m_fg_coupon_date();
				load_data_2_m_fg_face_date();
				load_data_2_m_fg_lenh();
				
			}
			catch(Exception v_e){
				throw v_e;
			}
		}

		private void m_cmd_xoa_1_lenh_Click(object sender, EventArgs e) {
			try{
				try{
					US_BOND_GD_DEAL_BOND v_us = new US_BOND_GD_DEAL_BOND();
					m_fg_lenh_2_us(v_us,m_fg_lenh.Row);
					delete_us_lenh(v_us);
					m_fg_lenh.RemoveItem(m_fg_lenh.Row);
				}
				catch(Exception v_e){
					throw v_e;
				}
			}
			catch(Exception v_e){
				throw v_e;
			}
		}

		private void m_cmd_xoa_het_lenh_Click(object sender, EventArgs e) {
			try{
				for(int v_int_indx = m_fg_lenh.Rows.Fixed
					;v_int_indx < m_fg_lenh.Rows.Count
					;v_int_indx++){
					US_BOND_GD_DEAL_BOND v_us = new US_BOND_GD_DEAL_BOND();
					m_fg_lenh_2_us(v_us,v_int_indx);
					delete_us_lenh(v_us);
					m_fg_lenh.RemoveItem(v_int_indx);
				}
			}
			catch(Exception v_e){
				throw v_e;
			}
		}

		private void m_txt_so_ngay_nhac_viec_coupon_TextChanged(object sender, EventArgs e) {
			try{
				if(!CValidateTextBox.IsValidPosValue(m_txt_so_ngay_nhac_viec_coupon,true)) return;
				m_dat_ngay_dat_nhac_thu_coupon.Value = CApplicationContext.get_curent_datetime().AddDays(Convert.ToDouble(m_txt_so_ngay_nhac_viec_coupon.Text));
				update_ngay_nhac_viec(BOND_NGAY_NHAC_VIEC.C_DEC_ID_NHAC_SO_NGAY_THU_COUPON,CIPConvert.ToDecimal(m_txt_so_ngay_nhac_viec_coupon.Text));
			}
			catch(Exception v_e){
				throw v_e;
			}
		}

		private void m_txt_so_ngay_nhac_viec_thu_goc_TextChanged(object sender, EventArgs e) {
			try{
				if(!CValidateTextBox.IsValidPosValue(m_txt_so_ngay_nhac_viec_thu_goc,true)) return;
				m_dat_ngay_dat_nhac_thu_goc.Value = CApplicationContext.get_curent_datetime().AddDays(Convert.ToDouble(m_txt_so_ngay_nhac_viec_thu_goc.Text));
				update_ngay_nhac_viec(BOND_NGAY_NHAC_VIEC.C_DEC_ID_NHAC_SO_NGAY_THU_GOC,CIPConvert.ToDecimal(m_txt_so_ngay_nhac_viec_thu_goc.Text));
			}
			catch(Exception v_e){
				throw v_e;
			}
		}

		private void m_dat_ngay_dat_nhac_thu_coupon_ValueChanged(object sender, EventArgs e) {
			try{
				load_data_2_m_fg_coupon_date();
			}
			catch(Exception v_e){
				throw v_e;
			}
		}

		private void m_dat_ngay_dat_nhac_thu_goc_ValueChanged(object sender, EventArgs e) {
			try{
				load_data_2_m_fg_face_date();
			}
			catch(Exception v_e){
				throw v_e;
			}
		}
	}
}
