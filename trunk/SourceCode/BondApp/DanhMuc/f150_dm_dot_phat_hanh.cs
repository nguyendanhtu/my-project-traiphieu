///************************************************
/// Generated by: LinhDH
/// Date: 11/10/2012 11:22:45
/// Goal: Create Form for DM_DOT_PHAT_HANH
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
using BondApp.DanhMuc;
using BondApp.HeThong;
using IP.Core.IPSystemAdmin;

namespace BondApp
{



	public class f150_dm_dot_phat_hanh : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private Label m_lbl_title;
        private GroupBox m_gru_tim_kiem;
        private TextBox m_txt_search;
        private Label label1;
        private Button m_cmd_filter;
        internal SIS.Controls.Button.SiSButton m_cmd_duyet;
        private C1FlexGrid m_fg;
		private System.ComponentModel.IContainer components;

		public f150_dm_dot_phat_hanh()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f150_dm_dot_phat_hanh));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_duyet = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_gru_tim_kiem = new System.Windows.Forms.GroupBox();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_filter = new System.Windows.Forms.Button();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.m_gru_tim_kiem.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_duyet);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 426);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(884, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_duyet
            // 
            this.m_cmd_duyet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_duyet.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_duyet.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_duyet.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_duyet.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_duyet.Image")));
            this.m_cmd_duyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_duyet.Location = new System.Drawing.Point(440, 4);
            this.m_cmd_duyet.Name = "m_cmd_duyet";
            this.m_cmd_duyet.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_duyet.TabIndex = 29;
            this.m_cmd_duyet.Text = "&Duyệt";
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
            this.m_cmd_insert.Location = new System.Drawing.Point(528, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
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
            this.m_cmd_update.Location = new System.Drawing.Point(616, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            this.m_cmd_view.Enabled = false;
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
            this.m_cmd_delete.Location = new System.Drawing.Point(704, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(792, 4);
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
            this.m_lbl_title.Size = new System.Drawing.Size(884, 40);
            this.m_lbl_title.TabIndex = 64;
            this.m_lbl_title.Text = "F150 - Danh sách đợt phát hành";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_gru_tim_kiem
            // 
            this.m_gru_tim_kiem.Controls.Add(this.m_txt_search);
            this.m_gru_tim_kiem.Controls.Add(this.label1);
            this.m_gru_tim_kiem.Controls.Add(this.m_cmd_filter);
            this.m_gru_tim_kiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_gru_tim_kiem.Location = new System.Drawing.Point(0, 40);
            this.m_gru_tim_kiem.Name = "m_gru_tim_kiem";
            this.m_gru_tim_kiem.Size = new System.Drawing.Size(884, 49);
            this.m_gru_tim_kiem.TabIndex = 65;
            this.m_gru_tim_kiem.TabStop = false;
            // 
            // m_txt_search
            // 
            this.m_txt_search.Location = new System.Drawing.Point(94, 16);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(508, 20);
            this.m_txt_search.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm kiếm";
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_filter.Image")));
            this.m_cmd_filter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_filter.Location = new System.Drawing.Point(617, 14);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(64, 23);
            this.m_cmd_filter.TabIndex = 29;
            this.m_cmd_filter.Text = "     Xem";
            this.m_cmd_filter.UseVisualStyleBackColor = true;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 89);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(884, 337);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 66;
            // 
            // f150_dm_dot_phat_hanh
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_gru_tim_kiem);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f150_dm_dot_phat_hanh";
            this.Text = "F150 - Danh mục đợt phát hành";
            this.Load += new System.EventHandler(this.f150_dm_dot_phat_hanh_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_gru_tim_kiem.ResumeLayout(false);
            this.m_gru_tim_kiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){
            m_e_form_mode = DataEntryFormMode.ViewDataState;
			this.ShowDialog();
		}

        public US_V_DM_DOT_PHAT_HANH display_2_select()
        {
            m_e_form_mode = DataEntryFormMode.SelectDataState;
            this.ShowDialog();
            return m_us;
        }
		#endregion

		#region Data Structure
		private enum e_col_Number{
            STT = 1
                ,
            NGAY_LAM_VIEC_HAI_SAU_YN = 10
 ,
            PHI_PHONG_GIAI_TOA_MAX = 13
                ,
            MENH_GIA = 5
                ,
            TY_LE_PHI_CHUYEN_NHUONG = 7
                ,
            TY_LE_PHI_PHONG_GIAI_TOA = 8
                ,
            TONG_SO_LUONG_TRAI_PHIEU = 4
                ,
            PHI_CHUYEN_NHUONG_MAX = 11
                ,
            NGUOI_LAP = 15
                ,
            PHI_PHONG_GIAI_TOA_MIN = 14
                ,
            PHI_CHUYEN_NHUONG_MIN = 12
                ,
            NGAY_PHAT_HANH = 3
                ,
            NGUOI_DUYET = 16
                ,
            TEN_TO_CHUC_PHAT_HANH = 2
                ,
            GHI_CHU = 17
                ,
            NGAN_HANG_DAI_LY_QUAN_LY_TK = 9
                ,
            TRANG_THAI = 18
                , TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH = 6

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_DM_DOT_PHAT_HANH m_ds = new DS_V_DM_DOT_PHAT_HANH();
		US_V_DM_DOT_PHAT_HANH m_us = new US_V_DM_DOT_PHAT_HANH();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.SelectDataState;
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
			CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
			set_define_events();
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
			this.KeyPreview = true;		
		}
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DM_DOT_PHAT_HANH;
            m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.XOA;
            m_us_v_ht_log_truy_cap.strMO_TA = "Xóa " + LOG_DOI_TUONG_TAC_DONG.DM_DOT_PHAT_HANH + " ngày " + m_us.datNGAY_PHAT_HANH+ " của TCPH "+ m_us.strTEN_TO_CHUC_PHAT_HANH;
            // ghi log hệ thống
            try
            {
                m_us_v_ht_log_truy_cap.Insert();
            }
            catch
            {
                BaseMessages.MsgBox_Infor("Đã xảy ra lỗi trong quá trình ghi log hệ thống");
            }
        }
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_DOT_PHAT_HANH.NGAY_LAM_VIEC_HAI_SAU_YN, e_col_Number.NGAY_LAM_VIEC_HAI_SAU_YN);
            v_htb.Add(V_DM_DOT_PHAT_HANH.PHI_PHONG_GIAI_TOA_MAX, e_col_Number.PHI_PHONG_GIAI_TOA_MAX);
            v_htb.Add(V_DM_DOT_PHAT_HANH.MENH_GIA, e_col_Number.MENH_GIA);
            v_htb.Add(V_DM_DOT_PHAT_HANH.TY_LE_PHI_CHUYEN_NHUONG, e_col_Number.TY_LE_PHI_CHUYEN_NHUONG);
            v_htb.Add(V_DM_DOT_PHAT_HANH.TY_LE_PHI_PHONG_GIAI_TOA, e_col_Number.TY_LE_PHI_PHONG_GIAI_TOA);
            v_htb.Add(V_DM_DOT_PHAT_HANH.TONG_SO_LUONG_TRAI_PHIEU, e_col_Number.TONG_SO_LUONG_TRAI_PHIEU);
            v_htb.Add(V_DM_DOT_PHAT_HANH.PHI_CHUYEN_NHUONG_MAX, e_col_Number.PHI_CHUYEN_NHUONG_MAX);
            v_htb.Add(V_DM_DOT_PHAT_HANH.NGUOI_LAP, e_col_Number.NGUOI_LAP);
            v_htb.Add(V_DM_DOT_PHAT_HANH.PHI_PHONG_GIAI_TOA_MIN, e_col_Number.PHI_PHONG_GIAI_TOA_MIN);
            v_htb.Add(V_DM_DOT_PHAT_HANH.PHI_CHUYEN_NHUONG_MIN, e_col_Number.PHI_CHUYEN_NHUONG_MIN);
            v_htb.Add(V_DM_DOT_PHAT_HANH.NGAY_PHAT_HANH, e_col_Number.NGAY_PHAT_HANH);
            v_htb.Add(V_DM_DOT_PHAT_HANH.NGUOI_DUYET, e_col_Number.NGUOI_DUYET);
            v_htb.Add(V_DM_DOT_PHAT_HANH.TEN_TO_CHUC_PHAT_HANH, e_col_Number.TEN_TO_CHUC_PHAT_HANH);
            v_htb.Add(V_DM_DOT_PHAT_HANH.GHI_CHU, e_col_Number.GHI_CHU);
            v_htb.Add(V_DM_DOT_PHAT_HANH.NGAN_HANG_DAI_LY_QUAN_LY_TK, e_col_Number.NGAN_HANG_DAI_LY_QUAN_LY_TK);
            v_htb.Add(V_DM_DOT_PHAT_HANH.TRANG_THAI, e_col_Number.TRANG_THAI);
            v_htb.Add(V_DM_DOT_PHAT_HANH.TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH, e_col_Number.TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_DOT_PHAT_HANH.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_DM_DOT_PHAT_HANH();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.SelectDataState:
                    m_us.FillDataset(m_ds, " WHERE ID_TRANG_THAI = " + TRANG_THAI_DANH_MUC.DA_DUYET);
                    break;
                case DataEntryFormMode.ViewDataState:
                    m_us.FillDataset(m_ds);
                    break;
            }
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_V_DM_DOT_PHAT_HANH i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_DOT_PHAT_HANH i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


        private void load_data_2_grid(string ip_str_search_key)
        {
            m_ds = new DS_V_DM_DOT_PHAT_HANH();
            m_us.load_data_by_search(m_ds, ip_str_search_key);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;
        }

        private void select_dot_phat_hanh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if(!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            this.Close();
        }
		private void insert_dm_dot_phat_hanh(){
            f151_dm_dot_phat_hanh_de v_fDE = new f151_dm_dot_phat_hanh_de();
            v_fDE.display_for_insert();
			load_data_2_grid();
		}

		private void update_dm_dot_phat_hanh(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
            f151_dm_dot_phat_hanh_de v_fDE = new f151_dm_dot_phat_hanh_de();
            v_fDE.display_for_update(m_us);
			load_data_2_grid();
		}
				
		private void delete_dm_dot_phat_hanh(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (!BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?")) return;
			US_V_DM_DOT_PHAT_HANH v_us = new US_V_DM_DOT_PHAT_HANH();
            grid2us_object(v_us, m_fg.Row);
            US_V_DM_TRAI_PHIEU v_us_dm_trai_phieu = new US_V_DM_TRAI_PHIEU();
            DS_V_DM_TRAI_PHIEU v_ds_dm_trai_phieu = new DS_V_DM_TRAI_PHIEU();
            v_us_dm_trai_phieu.FillDataset(v_ds_dm_trai_phieu, " WHERE ID_DOT_PHAT_HANH = " + v_us.dcID);
            if (v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows.Count > 0)
            {
                BaseMessages.MsgBox_Infor("Không xóa đợt phát hành này được do đã khai báo trái phiếu trong đợt này!");
                return;
            }
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
                ghi_log_he_thong();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_dm_dot_phat_hanh(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f150_dm_dot_phat_hanh_DE v_fDE = new f150_dm_dot_phat_hanh_DE();			
		//	v_fDE.display(m_us);
		}
        private void duyet_dm_dot_phat_hanh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            if (m_us.dcID_TRANG_THAI == TRANG_THAI_DANH_MUC.DA_DUYET)
            {
                BaseMessages.MsgBox_Infor("Thông tin tổ chức phát hành này đã được duyệt");
                return;
            }
            f151_dm_dot_phat_hanh_de frm151 = new f151_dm_dot_phat_hanh_de();
            frm151.display_for_duyet(m_us);
            load_data_2_grid();
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_filter.Click += new EventHandler(m_cmd_filter_Click);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
            m_cmd_duyet.Click += new EventHandler(m_cmd_duyet_Click);
            this.KeyDown += new KeyEventHandler(f150_dm_dot_phat_hanh_KeyDown);        
		}

        void f150_dm_dot_phat_hanh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_duyet_Click(object sender, EventArgs e)
        {
            try
            {
                duyet_dm_dot_phat_hanh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid(m_txt_search.Text.Trim());
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f150_dm_dot_phat_hanh_Load(object sender, System.EventArgs e) {
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
				insert_dm_dot_phat_hanh();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_dm_dot_phat_hanh();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_dm_dot_phat_hanh();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_dm_dot_phat_hanh();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(m_e_form_mode == DataEntryFormMode.SelectDataState)
                    select_dot_phat_hanh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_Click(object sender, EventArgs e)
        {

        }
	}
}

