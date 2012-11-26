///************************************************
/// Generated by: LinhDH
/// Date: 07/11/2012 11:38:38
/// Goal: Create Form for V_HT_LOG_TRUY_CAP
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

namespace BondApp
{



	public class f661_bao_cao_log_he_thong : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private GroupBox groupBox1;
        private Label m_lbl_title;
        private Label m_lbl_lich_nhac_viec_tu;
        private Label m_lbl_lich_nhac_viec_den;
        private Button m_cmd_filter;
        private DateTimePicker m_dat_from_date;
        private Label label3;
        private DateTimePicker m_dat_to_date;
        private ComboBox m_cbo_loai_hanh_dong;
        private Label label1;
        private TextBox m_txt_username;
		private System.ComponentModel.IContainer components;

		public f661_bao_cao_log_he_thong()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f661_bao_cao_log_he_thong));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_txt_username = new System.Windows.Forms.TextBox();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_lich_nhac_viec_tu = new System.Windows.Forms.Label();
            this.m_lbl_lich_nhac_viec_den = new System.Windows.Forms.Label();
            this.m_cmd_filter = new System.Windows.Forms.Button();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.m_cbo_loai_hanh_dong = new System.Windows.Forms.ComboBox();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(884, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 88);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(884, 438);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_txt_username);
            this.groupBox1.Controls.Add(this.m_lbl_title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_lbl_lich_nhac_viec_tu);
            this.groupBox1.Controls.Add(this.m_lbl_lich_nhac_viec_den);
            this.groupBox1.Controls.Add(this.m_cmd_filter);
            this.groupBox1.Controls.Add(this.m_dat_from_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_dat_to_date);
            this.groupBox1.Controls.Add(this.m_cbo_loai_hanh_dong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 88);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lọc";
            // 
            // m_txt_username
            // 
            this.m_txt_username.Location = new System.Drawing.Point(84, 47);
            this.m_txt_username.Name = "m_txt_username";
            this.m_txt_username.Size = new System.Drawing.Size(99, 20);
            this.m_txt_username.TabIndex = 32;
            // 
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_title.Location = new System.Drawing.Point(3, 16);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(878, 20);
            this.m_lbl_title.TabIndex = 31;
            this.m_lbl_title.Text = "LỊCH SỬ TRUY CẬP HỆ THỐNG";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên truy cập";
            // 
            // m_lbl_lich_nhac_viec_tu
            // 
            this.m_lbl_lich_nhac_viec_tu.AutoSize = true;
            this.m_lbl_lich_nhac_viec_tu.Location = new System.Drawing.Point(192, 51);
            this.m_lbl_lich_nhac_viec_tu.Name = "m_lbl_lich_nhac_viec_tu";
            this.m_lbl_lich_nhac_viec_tu.Size = new System.Drawing.Size(46, 13);
            this.m_lbl_lich_nhac_viec_tu.TabIndex = 22;
            this.m_lbl_lich_nhac_viec_tu.Text = "Từ ngày";
            // 
            // m_lbl_lich_nhac_viec_den
            // 
            this.m_lbl_lich_nhac_viec_den.AutoSize = true;
            this.m_lbl_lich_nhac_viec_den.Location = new System.Drawing.Point(360, 51);
            this.m_lbl_lich_nhac_viec_den.Name = "m_lbl_lich_nhac_viec_den";
            this.m_lbl_lich_nhac_viec_den.Size = new System.Drawing.Size(53, 13);
            this.m_lbl_lich_nhac_viec_den.TabIndex = 23;
            this.m_lbl_lich_nhac_viec_den.Text = "Đến ngày";
            this.m_lbl_lich_nhac_viec_den.Visible = false;
            // 
            // m_cmd_filter
            // 
            this.m_cmd_filter.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_filter.Image")));
            this.m_cmd_filter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_cmd_filter.Location = new System.Drawing.Point(778, 44);
            this.m_cmd_filter.Name = "m_cmd_filter";
            this.m_cmd_filter.Size = new System.Drawing.Size(64, 23);
            this.m_cmd_filter.TabIndex = 28;
            this.m_cmd_filter.Text = "     Xem";
            this.m_cmd_filter.UseVisualStyleBackColor = true;
            // 
            // m_dat_from_date
            // 
            this.m_dat_from_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_from_date.Location = new System.Drawing.Point(245, 47);
            this.m_dat_from_date.Name = "m_dat_from_date";
            this.m_dat_from_date.Size = new System.Drawing.Size(111, 20);
            this.m_dat_from_date.TabIndex = 24;
            this.m_dat_from_date.Value = new System.DateTime(2012, 10, 10, 0, 12, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hành động";
            // 
            // m_dat_to_date
            // 
            this.m_dat_to_date.CustomFormat = "dd/MM/yyyy";
            this.m_dat_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_to_date.Location = new System.Drawing.Point(419, 47);
            this.m_dat_to_date.Name = "m_dat_to_date";
            this.m_dat_to_date.Size = new System.Drawing.Size(106, 20);
            this.m_dat_to_date.TabIndex = 25;
            this.m_dat_to_date.Value = new System.DateTime(2012, 11, 14, 0, 0, 0, 0);
            // 
            // m_cbo_loai_hanh_dong
            // 
            this.m_cbo_loai_hanh_dong.DisplayMember = "Tất cả";
            this.m_cbo_loai_hanh_dong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_loai_hanh_dong.FormattingEnabled = true;
            this.m_cbo_loai_hanh_dong.Location = new System.Drawing.Point(606, 46);
            this.m_cbo_loai_hanh_dong.Name = "m_cbo_loai_hanh_dong";
            this.m_cbo_loai_hanh_dong.Size = new System.Drawing.Size(148, 21);
            this.m_cbo_loai_hanh_dong.TabIndex = 26;
            this.m_cbo_loai_hanh_dong.ValueMember = "Tất cả";
            // 
            // f661_bao_cao_log_he_thong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f661_bao_cao_log_he_thong";
            this.Text = "F661 - Lịch sử truy cập hệ thống";
            this.Load += new System.EventHandler(this.f661_bao_cao_log_he_thong_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
			TEN_TRUY_CAP = 1
,MO_TA = 6
,LOAI_HANH_DONG = 4
,DOI_TUONG_THAO_TAC = 5
,THOI_GIAN = 3
,TEN = 2

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_HT_LOG_TRUY_CAP m_ds = new DS_V_HT_LOG_TRUY_CAP();
		US_V_HT_LOG_TRUY_CAP m_us = new US_V_HT_LOG_TRUY_CAP();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_loai_hanh_dong();
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_HT_LOG_TRUY_CAP.TEN_TRUY_CAP, e_col_Number.TEN_TRUY_CAP);
			v_htb.Add(V_HT_LOG_TRUY_CAP.MO_TA, e_col_Number.MO_TA);
			v_htb.Add(V_HT_LOG_TRUY_CAP.LOAI_HANH_DONG, e_col_Number.LOAI_HANH_DONG);
			v_htb.Add(V_HT_LOG_TRUY_CAP.DOI_TUONG_THAO_TAC, e_col_Number.DOI_TUONG_THAO_TAC);
			v_htb.Add(V_HT_LOG_TRUY_CAP.THOI_GIAN, e_col_Number.THOI_GIAN);
			v_htb.Add(V_HT_LOG_TRUY_CAP.TEN, e_col_Number.TEN);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_HT_LOG_TRUY_CAP.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_HT_LOG_TRUY_CAP();
            m_us.fill_data_bo_loc(m_ds
                                , m_txt_username.Text.Trim()
                                , m_dat_from_date.Value
                                , m_dat_to_date.Value
                                , CIPConvert.ToDecimal(m_cbo_loai_hanh_dong.SelectedValue));
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
        private void load_data_2_cbo_loai_hanh_dong()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            DataRow v_dr = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = 0;
            v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            v_ds_cm_dm_tu_dien.EnforceConstraints = false;
            v_us_cm_dm_tu_dien.fill_tu_dien_cung_loai_ds(CM_DM_DS_LOAI_TU_DIEN.LOG_LOAI_HANH_DONG, v_ds_cm_dm_tu_dien);
            v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_loai_hanh_dong.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_loai_hanh_dong.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_hanh_dong.ValueMember = CM_DM_TU_DIEN.ID;
        }
		private void grid2us_object(US_V_HT_LOG_TRUY_CAP i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
        
		private void us_object2grid(US_V_HT_LOG_TRUY_CAP i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

		private void view_v_ht_log_truy_cap(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f661_bao_cao_log_he_thong_DE v_fDE = new f661_bao_cao_log_he_thong_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_filter.Click += new EventHandler(m_cmd_filter_Click);
		}

        void m_cmd_filter_Click(object sender, EventArgs e)
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
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f661_bao_cao_log_he_thong_Load(object sender, System.EventArgs e) {
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

	}
}

