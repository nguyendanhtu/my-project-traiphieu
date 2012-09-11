///************************************************
/// Generated by: SyHT
/// Date: 08/09/2012 10:46:42
/// Goal: Create Form for DM_TRAI_PHIEU
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



	public class f300_dm_trai_phieu : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
		private System.ComponentModel.IContainer components;

		public f300_dm_trai_phieu()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f300_dm_trai_phieu));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 465);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(922, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(566, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(654, 4);
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
            this.m_cmd_view.Size = new System.Drawing.Size(173, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem lịch thanh toán lãi gốc";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(742, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(830, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 0);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(922, 465);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // f300_dm_trai_phieu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(922, 501);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f300_dm_trai_phieu";
            this.Text = "F300-Danh muc trai phieu";
            this.Load += new System.EventHandler(this.f300_dm_trai_phieu_Load);
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
			TONG_SL_PHAT_HANH = 17
,ID_DV_DIEU_CHINH_LS = 10
,MENH_GIA = 5
,NGAY_DAO_HAN = 16
,MA_TRAI_PHIEU = 2
,ID_DV_KY_HAN = 7
,KY_HAN = 6
,ID_TO_CHUC_PHAT_HANH = 1
,KY_DIEU_CHINH_LS = 9
,TRA_LAI_SAU_YN = 14
,TONG_GIA_TRI = 18
,NGAY_PHAT_HANH = 15
,ID_LOAI_TRAI_PHIEU = 4
,TEN_TRAI_PHIEU = 3
,ID_DV_KY_TRA_LAI = 13
,LAI_SUAT_DEFAULT = 8
,THA_NOI_YN = 11
,KY_TRA_LAI = 12

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_DM_TRAI_PHIEU m_ds = new DS_DM_TRAI_PHIEU();
		US_DM_TRAI_PHIEU m_us = new US_DM_TRAI_PHIEU();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(DM_TRAI_PHIEU.TONG_SL_PHAT_HANH, e_col_Number.TONG_SL_PHAT_HANH);
			v_htb.Add(DM_TRAI_PHIEU.ID_DV_DIEU_CHINH_LS, e_col_Number.ID_DV_DIEU_CHINH_LS);
			v_htb.Add(DM_TRAI_PHIEU.MENH_GIA, e_col_Number.MENH_GIA);
			v_htb.Add(DM_TRAI_PHIEU.NGAY_DAO_HAN, e_col_Number.NGAY_DAO_HAN);
			v_htb.Add(DM_TRAI_PHIEU.MA_TRAI_PHIEU, e_col_Number.MA_TRAI_PHIEU);
			v_htb.Add(DM_TRAI_PHIEU.ID_DV_KY_HAN, e_col_Number.ID_DV_KY_HAN);
			v_htb.Add(DM_TRAI_PHIEU.KY_HAN, e_col_Number.KY_HAN);
			v_htb.Add(DM_TRAI_PHIEU.ID_TO_CHUC_PHAT_HANH, e_col_Number.ID_TO_CHUC_PHAT_HANH);
			v_htb.Add(DM_TRAI_PHIEU.KY_DIEU_CHINH_LS, e_col_Number.KY_DIEU_CHINH_LS);
			v_htb.Add(DM_TRAI_PHIEU.TRA_LAI_SAU_YN, e_col_Number.TRA_LAI_SAU_YN);
			v_htb.Add(DM_TRAI_PHIEU.TONG_GIA_TRI, e_col_Number.TONG_GIA_TRI);
			v_htb.Add(DM_TRAI_PHIEU.NGAY_PHAT_HANH, e_col_Number.NGAY_PHAT_HANH);
			v_htb.Add(DM_TRAI_PHIEU.ID_LOAI_TRAI_PHIEU, e_col_Number.ID_LOAI_TRAI_PHIEU);
			v_htb.Add(DM_TRAI_PHIEU.TEN_TRAI_PHIEU, e_col_Number.TEN_TRAI_PHIEU);
			v_htb.Add(DM_TRAI_PHIEU.ID_DV_KY_TRA_LAI, e_col_Number.ID_DV_KY_TRA_LAI);
			v_htb.Add(DM_TRAI_PHIEU.LAI_SUAT_DEFAULT, e_col_Number.LAI_SUAT_DEFAULT);
			v_htb.Add(DM_TRAI_PHIEU.THA_NOI_YN, e_col_Number.THA_NOI_YN);
			v_htb.Add(DM_TRAI_PHIEU.KY_TRA_LAI, e_col_Number.KY_TRA_LAI);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.DM_TRAI_PHIEU.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_DM_TRAI_PHIEU();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            load_data_2_cbo_grid();
			m_fg.Redraw = true;

		}

        private void load_data_2_cbo_grid()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            //load loai tu dien
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("LOAI_TRAI_PHIEU", v_ds_tu_dien);
            Hashtable v_hst_loai_tu_dien = new Hashtable();
            foreach (DataRow v_dr in v_ds_tu_dien.CM_DM_TU_DIEN.Rows){
                v_hst_loai_tu_dien.Add(v_dr[CM_DM_TU_DIEN.ID],v_dr[CM_DM_TU_DIEN.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_LOAI_TRAI_PHIEU].DataMap = v_hst_loai_tu_dien;

            //load don vi ky han
            v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("DON_VI_KY_HAN", v_ds_tu_dien);
            
            Hashtable v_hst_dv_ky_han = new Hashtable();
            foreach (DataRow v_dr in v_ds_tu_dien.CM_DM_TU_DIEN.Rows)
            {
                v_hst_dv_ky_han.Add(v_dr[CM_DM_TU_DIEN.ID], v_dr[CM_DM_TU_DIEN.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_DV_DIEU_CHINH_LS].DataMap = v_hst_dv_ky_han;
            m_fg.Cols[(int)e_col_Number.ID_DV_KY_HAN].DataMap = v_hst_dv_ky_han;
            m_fg.Cols[(int)e_col_Number.ID_DV_KY_TRA_LAI].DataMap = v_hst_dv_ky_han;

        }

		private void grid2us_object(US_DM_TRAI_PHIEU i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_DM_TRAI_PHIEU i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_dm_trai_phieu(){			
		//	f300_dm_trai_phieu_DE v_fDE = new  f300_dm_trai_phieu_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_dm_trai_phieu(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f300_dm_trai_phieu_DE v_fDE = new f300_dm_trai_phieu_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_dm_trai_phieu(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_DM_TRAI_PHIEU v_us = new US_DM_TRAI_PHIEU();
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

		private void view_thanh_toan_lai_goc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
            f650_lich_thanh_toan_lai_goc_xem v_frm_650 = new f650_lich_thanh_toan_lai_goc_xem();
            v_frm_650.display_lich_thanh_toan_lai_goc(m_us);		
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f300_dm_trai_phieu_Load(object sender, System.EventArgs e) {
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
				insert_dm_trai_phieu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_dm_trai_phieu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_dm_trai_phieu();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_thanh_toan_lai_goc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

