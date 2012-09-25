///************************************************
/// Generated by: SyHT
/// Date: 08/09/2012 11:03:42
/// Goal: Create Form for DM_TRAI_CHU
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

namespace BondApp
{



	public class f500_dm_trai_chu : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        internal SIS.Controls.Button.SiSButton m_cmd_select;
        private Label m_lbl_title;
        private GroupBox m_gru_tim_kiem;
        private TextBox m_txt_search;
        private Label label1;
        private Button m_cmd_filter;
		private System.ComponentModel.IContainer components;

		public f500_dm_trai_chu()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f500_dm_trai_chu));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_select = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_gru_tim_kiem = new System.Windows.Forms.GroupBox();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_filter = new System.Windows.Forms.Button();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_gru_tim_kiem.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_select);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(884, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_select
            // 
            this.m_cmd_select.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_select.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_select.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_select.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_select.ImageIndex = 18;
            this.m_cmd_select.ImageList = this.ImageList;
            this.m_cmd_select.Location = new System.Drawing.Point(431, 4);
            this.m_cmd_select.Name = "m_cmd_select";
            this.m_cmd_select.Size = new System.Drawing.Size(97, 28);
            this.m_cmd_select.TabIndex = 22;
            this.m_cmd_select.Text = "Chọn trái chủ";
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
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 92);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(884, 434);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(884, 37);
            this.m_lbl_title.TabIndex = 22;
            this.m_lbl_title.Text = "F500 - Danh sách trái chủ";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_gru_tim_kiem
            // 
            this.m_gru_tim_kiem.Controls.Add(this.m_txt_search);
            this.m_gru_tim_kiem.Controls.Add(this.label1);
            this.m_gru_tim_kiem.Controls.Add(this.m_cmd_filter);
            this.m_gru_tim_kiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_gru_tim_kiem.Location = new System.Drawing.Point(0, 37);
            this.m_gru_tim_kiem.Name = "m_gru_tim_kiem";
            this.m_gru_tim_kiem.Size = new System.Drawing.Size(884, 49);
            this.m_gru_tim_kiem.TabIndex = 23;
            this.m_gru_tim_kiem.TabStop = false;
            // 
            // m_txt_search
            // 
            this.m_txt_search.Location = new System.Drawing.Point(78, 16);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(508, 20);
            this.m_txt_search.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tìm kiếm";
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_filter.Image")));
            this.m_cmd_filter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_filter.Location = new System.Drawing.Point(601, 14);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(64, 23);
            this.m_cmd_filter.TabIndex = 29;
            this.m_cmd_filter.Text = "     Xem";
            this.m_cmd_filter.UseVisualStyleBackColor = true;
            // 
            // f500_dm_trai_chu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.m_gru_tim_kiem);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f500_dm_trai_chu";
            this.Text = "F500-Danh muc trai chu";
            this.Load += new System.EventHandler(this.f500_dm_trai_chu_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_gru_tim_kiem.ResumeLayout(false);
            this.m_gru_tim_kiem.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
        public US_DM_TRAI_CHU select_trai_chu_of_trai_phieu(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_e_form_mode = DataEntryFormMode.SelectDataState;
            m_us_trai_phieu = ip_us_trai_phieu;
            this.ShowDialog();            
            return m_us;
        }

		#endregion

		#region Data Structure
		private enum e_col_Number{
			GHI_CHU3 = 17
,DIA_CHI = 3
,ID_NGUOI_LAP = 12
,MO_TAI_NGAN_HANG = 10
,NGAY_CAP_CMT = 6
,MOBILE = 4
,ID_TRAI_PHIEU_SO_HUU = 11
,GHI_CHU1 = 15
,ID_LOAI_TRAI_CHU = 8
,ID_TRANG_THAI = 14
,MA_TRAI_CHU = 1
,ID_NGUOI_DUYET = 13
,NOI_CAP_CMT = 7
,TEN_TRAI_CHU = 2
,GHI_CHU2 = 16
,SO_TAI_KHOAN = 9
,CMT_GIAY_DKKD = 5

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
		DS_DM_TRAI_CHU m_ds = new DS_DM_TRAI_CHU();
		US_DM_TRAI_CHU m_us = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu;
        DS_DM_TRAI_PHIEU m_ds_trai_phieu;
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
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    m_cmd_delete.Visible = false;
                    m_cmd_update.Visible = false;
                    m_cmd_insert.Visible = false;
                    m_cmd_select.Visible = true;
                    break;
                case DataEntryFormMode.UpdateDataState:
                    break;
                case DataEntryFormMode.ViewDataState:
                    m_cmd_delete.Visible = true;
                    m_cmd_update.Visible = true;
                    m_cmd_insert.Visible = true;
                    
                    m_cmd_select.Visible = false;
                    break;
                default:
                    break;
            }

			m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(m_us_trai_phieu);
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(DM_TRAI_CHU.GHI_CHU3, e_col_Number.GHI_CHU3);
			v_htb.Add(DM_TRAI_CHU.DIA_CHI, e_col_Number.DIA_CHI);
			v_htb.Add(DM_TRAI_CHU.ID_NGUOI_LAP, e_col_Number.ID_NGUOI_LAP);
			v_htb.Add(DM_TRAI_CHU.MO_TAI_NGAN_HANG, e_col_Number.MO_TAI_NGAN_HANG);
			v_htb.Add(DM_TRAI_CHU.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
			v_htb.Add(DM_TRAI_CHU.MOBILE, e_col_Number.MOBILE);
			v_htb.Add(DM_TRAI_CHU.ID_TRAI_PHIEU_SO_HUU, e_col_Number.ID_TRAI_PHIEU_SO_HUU);
			v_htb.Add(DM_TRAI_CHU.GHI_CHU1, e_col_Number.GHI_CHU1);
			v_htb.Add(DM_TRAI_CHU.ID_LOAI_TRAI_CHU, e_col_Number.ID_LOAI_TRAI_CHU);
			v_htb.Add(DM_TRAI_CHU.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
			v_htb.Add(DM_TRAI_CHU.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
			v_htb.Add(DM_TRAI_CHU.ID_NGUOI_DUYET, e_col_Number.ID_NGUOI_DUYET);
			v_htb.Add(DM_TRAI_CHU.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);
			v_htb.Add(DM_TRAI_CHU.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
			v_htb.Add(DM_TRAI_CHU.GHI_CHU2, e_col_Number.GHI_CHU2);
			v_htb.Add(DM_TRAI_CHU.SO_TAI_KHOAN, e_col_Number.SO_TAI_KHOAN);
			v_htb.Add(DM_TRAI_CHU.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.DM_TRAI_CHU.NewRow());
			return v_obj_trans;			
		}

		private void load_data_2_grid(US_DM_TRAI_PHIEU ip_us_trai_phieu){						
			m_ds = new DS_DM_TRAI_CHU();
            if (ip_us_trai_phieu == null)
            {

                m_us.FillDataset(m_ds);
            }
            else
            {
                m_us.FillDatasetByIDTraiPhieu(m_ds, ip_us_trai_phieu.dcID);     
            }
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            load_data_2_cbo_grid();
			m_fg.Redraw = true;
		}

        private void load_data_2_cbo_grid()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            //load loai trai chu
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("LOAI_TRAI_CHU", v_ds_tu_dien);
            Hashtable v_hst_loai_tu_dien = new Hashtable();
            foreach (DataRow v_dr in v_ds_tu_dien.CM_DM_TU_DIEN.Rows)
            {
                v_hst_loai_tu_dien.Add(v_dr[CM_DM_TU_DIEN.ID], v_dr[CM_DM_TU_DIEN.TEN_NGAN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_LOAI_TRAI_CHU].DataMap = v_hst_loai_tu_dien;

            //load trang thai
            v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("TRANG_THAI_GD", v_ds_tu_dien);

            Hashtable v_hst_dv_ky_han = new Hashtable();
            foreach (DataRow v_dr in v_ds_tu_dien.CM_DM_TU_DIEN.Rows)
            {
                v_hst_dv_ky_han.Add(v_dr[CM_DM_TU_DIEN.ID], v_dr[CM_DM_TU_DIEN.TEN_NGAN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI].DataMap = v_hst_dv_ky_han;

            //load trai phieu so huu
            m_us_trai_phieu = new US_DM_TRAI_PHIEU();
            m_ds_trai_phieu = new DS_DM_TRAI_PHIEU();
            m_us_trai_phieu.FillDataset(m_ds_trai_phieu);
            Hashtable v_hst_trai_phieu_so_huu = new Hashtable();
            foreach (DataRow v_dr in m_ds_trai_phieu.DM_TRAI_PHIEU.Rows)
            {
                v_hst_trai_phieu_so_huu.Add(v_dr[DM_TRAI_PHIEU.ID], v_dr[DM_TRAI_PHIEU.MA_TRAI_PHIEU]);
            }
            m_fg.Cols[(int)e_col_Number.ID_TRAI_PHIEU_SO_HUU].DataMap = v_hst_trai_phieu_so_huu;
        }

		private void grid2us_object(US_DM_TRAI_CHU i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_DM_TRAI_CHU i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_dm_trai_chu(){
            f500_dm_trai_chu_de v_frm500 = new f500_dm_trai_chu_de();
            v_frm500.display_for_insert();
			load_data_2_grid(null);
		}

		private void update_dm_trai_chu(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
            f500_dm_trai_chu_de v_frm500 = new f500_dm_trai_chu_de();
            v_frm500.display_for_update(m_us);
			load_data_2_grid(null);
		}
				
		private void delete_dm_trai_chu(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_DM_TRAI_CHU v_us = new US_DM_TRAI_CHU();
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

		private void view_dm_trai_chu(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f500_dm_trai_chu_DE v_fDE = new f500_dm_trai_chu_DE();			
		//	v_fDE.display(m_us);
		}

        private void chon_trai_chu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_e_form_mode != DataEntryFormMode.SelectDataState) return;

            grid2us_object(m_us, m_fg.Row);
            this.Close();

        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_cmd_select.Click += new EventHandler(m_cmd_select_Click);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
		}

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                chon_trai_chu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_select_Click(object sender, EventArgs e)
        {
            try
            {
                chon_trai_chu();
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
		private void f500_dm_trai_chu_Load(object sender, System.EventArgs e) {
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
				insert_dm_trai_chu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_dm_trai_chu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_dm_trai_chu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_dm_trai_chu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

