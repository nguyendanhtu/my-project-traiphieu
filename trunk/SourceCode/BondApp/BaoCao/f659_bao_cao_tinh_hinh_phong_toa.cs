///************************************************
/// Generated by: LinhDH
/// Date: 08/10/2012 05:15:54
/// Goal: Create Form for V_GD_PHONG_GIAI_TOA
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
using IP.Core.IPSystemAdmin;
using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPExcelReport;

namespace BondApp
{
	public class f659_bao_cao_tinh_hinh_phong_toa : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_header;
        internal SIS.Controls.Button.SiSButton m_cmd_export_excel;
        private GroupBox m_grb_thong_tin_ban_hang;
        private ComboBox m_cbo_to_chuc_phat_hanh;
        private Label m_lbl_nhom_hang;
        private DateTimePicker m_dat_to_date;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label label2;
        private Label label1;
        private DateTimePicker m_dat_from_date;
		private System.ComponentModel.IContainer components;

		public f659_bao_cao_tinh_hinh_phong_toa()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f659_bao_cao_tinh_hinh_phong_toa));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_export_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_grb_thong_tin_ban_hang = new System.Windows.Forms.GroupBox();
            this.m_cbo_to_chuc_phat_hanh = new System.Windows.Forms.ComboBox();
            this.m_lbl_nhom_hang = new System.Windows.Forms.Label();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_grb_thong_tin_ban_hang.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_export_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 460);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1080, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(988, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 123);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1080, 337);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(1080, 31);
            this.m_lbl_header.TabIndex = 24;
            this.m_lbl_header.Text = "F659 - Báo cáo tình hình phong tỏa";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_grb_thong_tin_ban_hang
            // 
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cbo_to_chuc_phat_hanh);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_lbl_nhom_hang);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_to_date);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cmd_view);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label2);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label1);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_from_date);
            this.m_grb_thong_tin_ban_hang.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grb_thong_tin_ban_hang.Location = new System.Drawing.Point(0, 31);
            this.m_grb_thong_tin_ban_hang.Name = "m_grb_thong_tin_ban_hang";
            this.m_grb_thong_tin_ban_hang.Size = new System.Drawing.Size(1080, 92);
            this.m_grb_thong_tin_ban_hang.TabIndex = 29;
            this.m_grb_thong_tin_ban_hang.TabStop = false;
            this.m_grb_thong_tin_ban_hang.Text = "Thông tin giao dịch phong tỏa";
            // 
            // m_cbo_to_chuc_phat_hanh
            // 
            this.m_cbo_to_chuc_phat_hanh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_to_chuc_phat_hanh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_to_chuc_phat_hanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_to_chuc_phat_hanh.FormattingEnabled = true;
            this.m_cbo_to_chuc_phat_hanh.Location = new System.Drawing.Point(243, 65);
            this.m_cbo_to_chuc_phat_hanh.MaxDropDownItems = 5;
            this.m_cbo_to_chuc_phat_hanh.Name = "m_cbo_to_chuc_phat_hanh";
            this.m_cbo_to_chuc_phat_hanh.Size = new System.Drawing.Size(483, 21);
            this.m_cbo_to_chuc_phat_hanh.TabIndex = 31;
            // 
            // m_lbl_nhom_hang
            // 
            this.m_lbl_nhom_hang.AutoSize = true;
            this.m_lbl_nhom_hang.Location = new System.Drawing.Point(139, 68);
            this.m_lbl_nhom_hang.Name = "m_lbl_nhom_hang";
            this.m_lbl_nhom_hang.Size = new System.Drawing.Size(98, 13);
            this.m_lbl_nhom_hang.TabIndex = 30;
            this.m_lbl_nhom_hang.Text = "Tổ chức phát hành";
            // 
            // m_dat_to_date
            // 
            this.m_dat_to_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_to_date.Location = new System.Drawing.Point(526, 26);
            this.m_dat_to_date.Name = "m_dat_to_date";
            this.m_dat_to_date.Size = new System.Drawing.Size(200, 20);
            this.m_dat_to_date.TabIndex = 26;
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 5;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(989, 16);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 73);
            this.m_cmd_view.TabIndex = 29;
            this.m_cmd_view.Text = "In báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Từ ngày";
            // 
            // m_dat_from_date
            // 
            this.m_dat_from_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_from_date.Location = new System.Drawing.Point(243, 26);
            this.m_dat_from_date.Name = "m_dat_from_date";
            this.m_dat_from_date.Size = new System.Drawing.Size(200, 20);
            this.m_dat_from_date.TabIndex = 24;
            // 
            // f659_bao_cao_tinh_hinh_phong_toa
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1080, 496);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_grb_thong_tin_ban_hang);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f659_bao_cao_tinh_hinh_phong_toa";
            this.Text = "F659 - Báo cáo tình hình phong tỏa";
            this.Load += new System.EventHandler(this.f659_bao_cao_tinh_hinh_phong_toa_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_grb_thong_tin_ban_hang.ResumeLayout(false);
            this.m_grb_thong_tin_ban_hang.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
        public void display_danh_sach_phong_toa()
        {
            this.Text = "F659 - Báo cáo tình hình phong tỏa";
            m_lbl_header.Text = "F659 - BÁO CÁO TÌNH HÌNH PHONG TỎA";
            m_e_form_mode = e_form_mode.PHONG_TOA;
            this.ShowDialog();
        }
        public void display_danh_sach_giai_toa()
        {
            this.Text = "F660 - Báo cáo tình hình giải tỏa";
            m_lbl_header.Text = "F660 - BÁO CÁO TÌNH HÌNH GIẢI TỎA";
            m_e_form_mode = e_form_mode.GIAI_TOA;
            this.ShowDialog();
        }
		#endregion

		#region Data Structure
        private enum e_form_mode
        {
            PHONG_TOA = 1
            , GIAI_TOA = 2
        }
		private enum e_col_Number{
            STT = 1,
			CMT_GIAY_DKKD = 6
,TEN_TRAI_CHU = 5
,NGAY_CAP_CMT = 7
,MA_GIAO_DICH = 2
,NGUOI_THUC_HIEN = 12
,MA_TRAI_CHU = 4
,SO_LUONG = 9
,PHI_GIAO_DICH = 11
,NGAY_GIAO_DICH = 3
,GIA_TRI_GD_THEO_MENH_GIA = 10
,NOI_CAP_CMT = 8

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_PHONG_GIAI_TOA m_ds = new DS_V_GD_PHONG_GIAI_TOA();
		US_V_GD_PHONG_GIAI_TOA m_us = new US_V_GD_PHONG_GIAI_TOA();
        e_form_mode m_e_form_mode = e_form_mode.PHONG_TOA;
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_to_chuc_phat_hanh();
            m_dat_from_date.Value = CIPConvert.ToDatetime("01/01/2010");
			load_data_2_grid();
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_PHONG_GIAI_TOA.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.MA_GIAO_DICH, e_col_Number.MA_GIAO_DICH);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.NGUOI_THUC_HIEN, e_col_Number.NGUOI_THUC_HIEN);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.SO_LUONG, e_col_Number.SO_LUONG);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.PHI_GIAO_DICH, e_col_Number.PHI_GIAO_DICH);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.NGAY_GIAO_DICH, e_col_Number.NGAY_GIAO_DICH);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.GIA_TRI_GD_THEO_MENH_GIA, e_col_Number.GIA_TRI_GD_THEO_MENH_GIA);
			v_htb.Add(V_GD_PHONG_GIAI_TOA.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_PHONG_GIAI_TOA.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_PHONG_GIAI_TOA();
		    int v_i_phong_toa_yn = (int) m_e_form_mode;
            string v_str_phong_toa_yn = ""; 
            if (v_i_phong_toa_yn == 1) v_str_phong_toa_yn = "Y";
            else v_str_phong_toa_yn = "N";
            m_us.fill_dataset_by_date_and_to_chuc_phat_hanh(m_ds
                                                            , CIPConvert.ToDecimal(m_cbo_to_chuc_phat_hanh.SelectedValue)
                                                            , v_str_phong_toa_yn
                                                            , m_dat_from_date.Value
                                                            , m_dat_to_date.Value);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_GD_PHONG_GIAI_TOA i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

		private void us_object2grid(US_V_GD_PHONG_GIAI_TOA i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void export_excel()
        {
            CExcelReport v_obj_export_excel = new CExcelReport("f700_Bao cao tong hop tinh hinh phong toa.xls", 11, 2);
            v_obj_export_excel.AddFindAndReplaceItem("<NGAY_BAT_DAU>", CIPConvert.ToStr(m_dat_from_date.Value,"dd/MM/yyyy"));
            v_obj_export_excel.AddFindAndReplaceItem("<TEN_CONG_TY>", m_cbo_to_chuc_phat_hanh.Text);
            v_obj_export_excel.AddFindAndReplaceItem("<NGAY_KET_THUC>", CIPConvert.ToStr(m_dat_to_date.Value,"dd/MM/yyyy"));
            v_obj_export_excel.FindAndReplace(false);
            v_obj_export_excel.Export2ExcelWithoutFixedRows(m_fg, (int)e_col_Number.MA_GIAO_DICH, m_fg.Cols.Count - 1, false);
        }
		private void insert_v_gd_phong_giai_toa(){			
		//	f659_bao_cao_tinh_hinh_phong_toa_DE v_fDE = new  f659_bao_cao_tinh_hinh_phong_toa_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_phong_giai_toa(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f659_bao_cao_tinh_hinh_phong_toa_DE v_fDE = new f659_bao_cao_tinh_hinh_phong_toa_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_phong_giai_toa(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_PHONG_GIAI_TOA v_us = new US_V_GD_PHONG_GIAI_TOA();
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

		private void view_v_gd_phong_giai_toa(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f659_bao_cao_tinh_hinh_phong_toa_DE v_fDE = new f659_bao_cao_tinh_hinh_phong_toa_DE();			
		//	v_fDE.display(m_us);
		}
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_export_excel.Click += new EventHandler(m_cmd_export_excel_Click);
            m_dat_from_date.ValueChanged += new EventHandler(m_dat_from_date_ValueChanged);
            m_dat_to_date.ValueChanged += new EventHandler(m_dat_to_date_ValueChanged);
            m_cbo_to_chuc_phat_hanh.SelectedIndexChanged += new EventHandler(m_cbo_to_chuc_phat_hanh_SelectedIndexChanged);
            this.KeyDown += new KeyEventHandler(f659_bao_cao_tinh_hinh_phong_toa_KeyDown);
        }

        void f659_bao_cao_tinh_hinh_phong_toa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void load_data_2_cbo_to_chuc_phat_hanh()
        {
            US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
            DS_DM_TO_CHUC_PHAT_HANH v_ds_dm_to_chuc_phat_hanh = new DS_DM_TO_CHUC_PHAT_HANH();

            v_us_dm_to_chuc_phat_hanh.FillDataset(v_ds_dm_to_chuc_phat_hanh);
            v_ds_dm_to_chuc_phat_hanh.EnforceConstraints = false;
            DataRow v_dr = v_ds_dm_to_chuc_phat_hanh.DM_TO_CHUC_PHAT_HANH.NewDM_TO_CHUC_PHAT_HANHRow();
            v_dr[DM_TO_CHUC_PHAT_HANH.ID] = 0;
            v_dr[DM_TO_CHUC_PHAT_HANH.TEN_TO_CHUC_PHAT_HANH] = "Tất cả";
            v_ds_dm_to_chuc_phat_hanh.DM_TO_CHUC_PHAT_HANH.Rows.InsertAt(v_dr, 0);

            m_cbo_to_chuc_phat_hanh.ValueMember = DM_TO_CHUC_PHAT_HANH.ID;
            m_cbo_to_chuc_phat_hanh.DisplayMember = DM_TO_CHUC_PHAT_HANH.TEN_TO_CHUC_PHAT_HANH;
            m_cbo_to_chuc_phat_hanh.DataSource = v_ds_dm_to_chuc_phat_hanh.DM_TO_CHUC_PHAT_HANH;
        }
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f659_bao_cao_tinh_hinh_phong_toa_Load(object sender, System.EventArgs e) {
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

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_gd_phong_giai_toa();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_gd_phong_giai_toa();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_gd_phong_giai_toa();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
                load_data_2_grid();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        void m_dat_to_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_dat_from_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
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
        void m_cbo_to_chuc_phat_hanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
	}
}

