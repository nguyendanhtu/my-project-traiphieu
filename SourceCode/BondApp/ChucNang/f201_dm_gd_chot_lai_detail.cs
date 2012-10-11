///************************************************
/// Generated by: haind
/// Date: 10/10/2012 10:05:18
/// Goal: Create Form for GD_CHOT_LAI_DETAIL
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
using BondApp.ChucNang;

using C1.Win.C1FlexGrid;

namespace BondApp
{
	public class f201_dm_gd_chot_lai_detail : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_view;
        private GroupBox m_gru_tim_kiem;
        private TextBox m_txt_search;
        private Label label1;
        private Button m_cmd_filter;
        private Label m_lbl_title;
        private C1FlexGrid m_fg;
		private System.ComponentModel.IContainer components;

		public f201_dm_gd_chot_lai_detail(decimal ip_dc_id_chot_lai)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
            m_us = new US_GD_CHOT_LAI_DETAIL(ip_dc_id_chot_lai);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f201_dm_gd_chot_lai_detail));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_gru_tim_kiem = new System.Windows.Forms.GroupBox();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_filter = new System.Windows.Forms.Button();
            this.m_lbl_title = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 376);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(459, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(103, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(191, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(279, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(367, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_gru_tim_kiem
            // 
            this.m_gru_tim_kiem.Controls.Add(this.m_txt_search);
            this.m_gru_tim_kiem.Controls.Add(this.label1);
            this.m_gru_tim_kiem.Controls.Add(this.m_cmd_filter);
            this.m_gru_tim_kiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_gru_tim_kiem.Location = new System.Drawing.Point(0, 37);
            this.m_gru_tim_kiem.Name = "m_gru_tim_kiem";
            this.m_gru_tim_kiem.Size = new System.Drawing.Size(459, 49);
            this.m_gru_tim_kiem.TabIndex = 28;
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
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(459, 37);
            this.m_lbl_title.TabIndex = 27;
            this.m_lbl_title.Text = "F200 - Danh mục chốt lãi";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 86);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(459, 290);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 29;
            // 
            // f201_dm_gd_chot_lai_detail
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(459, 412);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_gru_tim_kiem);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f201_dm_gd_chot_lai_detail";
            this.Text = "f201_dm_gd_chot_lai_detail";
            this.Load += new System.EventHandler(this.f201_dm_gd_chot_lai_detail_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_gru_tim_kiem.ResumeLayout(false);
            this.m_gru_tim_kiem.PerformLayout();
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
			ID_CHOT_LAI = 1,ID_TRAI_CHU = 2,NGAY_NHAN_TIEN = 6,SO_TIEN_LAI = 4,DA_NHAN_TIEN_YN = 5,SO_LUONG_TINH_LAI = 3
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_GD_CHOT_LAI_DETAIL m_ds = new DS_GD_CHOT_LAI_DETAIL();
		US_GD_CHOT_LAI_DETAIL m_us = new US_GD_CHOT_LAI_DETAIL();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();			v_htb.Add(GD_CHOT_LAI_DETAIL.ID_TRAI_CHU, e_col_Number.ID_TRAI_CHU);			v_htb.Add(GD_CHOT_LAI_DETAIL.NGAY_NHAN_TIEN, e_col_Number.NGAY_NHAN_TIEN);			v_htb.Add(GD_CHOT_LAI_DETAIL.SO_TIEN_LAI, e_col_Number.SO_TIEN_LAI);			v_htb.Add(GD_CHOT_LAI_DETAIL.DA_NHAN_TIEN_YN, e_col_Number.DA_NHAN_TIEN_YN);			v_htb.Add(GD_CHOT_LAI_DETAIL.SO_LUONG_TINH_LAI, e_col_Number.SO_LUONG_TINH_LAI);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.GD_CHOT_LAI_DETAIL.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_GD_CHOT_LAI_DETAIL();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_GD_CHOT_LAI_DETAIL i_us, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
		private void us_object2grid(US_GD_CHOT_LAI_DETAIL i_us, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}
    	private void insert_gd_chot_lai_detail(){
            f250_chi_tiet_giao_dich_chot_lai v_fDE = new f250_chi_tiet_giao_dich_chot_lai();
			v_fDE.display_for_insert();
			load_data_2_grid();
		}
		private void update_gd_chot_lai_detail(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
            f250_chi_tiet_giao_dich_chot_lai v_fDE = new f250_chi_tiet_giao_dich_chot_lai();
			v_fDE.display_for_update(m_us);
			load_data_2_grid();
		}
				
		private void delete_gd_chot_lai_detail(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_GD_CHOT_LAI_DETAIL v_us = new US_GD_CHOT_LAI_DETAIL();
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

		private void view_gd_chot_lai_detail(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f201_dm_gd_chot_lai_detail_DE v_fDE = new f201_dm_gd_chot_lai_detail_DE();			
		//	v_fDE.display(m_us);
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
		private void f201_dm_gd_chot_lai_detail_Load(object sender, System.EventArgs e) {
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
				insert_gd_chot_lai_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_gd_chot_lai_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_gd_chot_lai_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_gd_chot_lai_detail();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

	}
}

