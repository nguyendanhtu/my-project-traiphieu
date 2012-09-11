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
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_select = new SIS.Controls.Button.SiSButton();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_select);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(330, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(506, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(594, 4);
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
            this.m_fg.Size = new System.Drawing.Size(686, 373);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
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
            this.m_cmd_select.Location = new System.Drawing.Point(242, 4);
            this.m_cmd_select.Name = "m_cmd_select";
            this.m_cmd_select.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_select.TabIndex = 22;
            this.m_cmd_select.Text = "Chọn trái chủ";
            // 
            // f500_dm_trai_chu
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f500_dm_trai_chu";
            this.Text = "F500-Danh muc trai chu";
            this.Load += new System.EventHandler(this.f500_dm_trai_chu_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
        public US_DM_TRAI_CHU select_trai_chu()
        {
            m_e_form_mode = DataEntryFormMode.SelectDataState;
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
			load_data_2_grid();		
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
		private void load_data_2_grid(){						
			m_ds = new DS_DM_TRAI_CHU();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
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
		//	f500_dm_trai_chu_DE v_fDE = new  f500_dm_trai_chu_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_dm_trai_chu(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f500_dm_trai_chu_DE v_fDE = new f500_dm_trai_chu_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
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

