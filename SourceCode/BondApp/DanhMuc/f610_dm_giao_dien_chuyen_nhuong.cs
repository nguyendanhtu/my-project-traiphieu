///************************************************
/// Generated by: ninhvh
/// Date: 10/10/2012 10:23:46
/// Goal: Create Form for V_GD_CHUYEN_NHUONG
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



    public class f610_dm_giao_dien_chuyen_nhuong : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private GroupBox m_grb_thong_tin_ban_hang;
        private ComboBox m_cbo_trai_phieu;
        private Label m_lbl_nhom_hang;
        private DateTimePicker m_dat_to_date;
        private Label label2;
        private Label label1;
        private DateTimePicker m_dat_from_date;
        private Label m_lbl_title;
        private C1FlexGrid m_fg;
        private System.ComponentModel.IContainer components;

        public f610_dm_giao_dien_chuyen_nhuong()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f610_dm_giao_dien_chuyen_nhuong));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grb_thong_tin_ban_hang = new System.Windows.Forms.GroupBox();
            this.m_cbo_trai_phieu = new System.Windows.Forms.ComboBox();
            this.m_lbl_nhom_hang = new System.Windows.Forms.Label();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_title = new System.Windows.Forms.Label();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.m_grb_thong_tin_ban_hang.SuspendLayout();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 526);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(884, 36);
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
            // m_grb_thong_tin_ban_hang
            // 
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cbo_trai_phieu);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_lbl_nhom_hang);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_to_date);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label2);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label1);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_from_date);
            this.m_grb_thong_tin_ban_hang.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grb_thong_tin_ban_hang.Location = new System.Drawing.Point(0, 31);
            this.m_grb_thong_tin_ban_hang.Name = "m_grb_thong_tin_ban_hang";
            this.m_grb_thong_tin_ban_hang.Size = new System.Drawing.Size(884, 92);
            this.m_grb_thong_tin_ban_hang.TabIndex = 34;
            this.m_grb_thong_tin_ban_hang.TabStop = false;
            this.m_grb_thong_tin_ban_hang.Text = "Thông tin giao dịch phong tỏa";
            // 
            // m_cbo_trai_phieu
            // 
            this.m_cbo_trai_phieu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_trai_phieu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_trai_phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trai_phieu.FormattingEnabled = true;
            this.m_cbo_trai_phieu.Location = new System.Drawing.Point(243, 65);
            this.m_cbo_trai_phieu.MaxDropDownItems = 5;
            this.m_cbo_trai_phieu.Name = "m_cbo_trai_phieu";
            this.m_cbo_trai_phieu.Size = new System.Drawing.Size(483, 21);
            this.m_cbo_trai_phieu.TabIndex = 31;
            // 
            // m_lbl_nhom_hang
            // 
            this.m_lbl_nhom_hang.AutoSize = true;
            this.m_lbl_nhom_hang.Location = new System.Drawing.Point(165, 68);
            this.m_lbl_nhom_hang.Name = "m_lbl_nhom_hang";
            this.m_lbl_nhom_hang.Size = new System.Drawing.Size(72, 13);
            this.m_lbl_nhom_hang.TabIndex = 30;
            this.m_lbl_nhom_hang.Text = "Tên trái phiếu";
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
            // m_lbl_title
            // 
            this.m_lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_title.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_title.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_title.Name = "m_lbl_title";
            this.m_lbl_title.Size = new System.Drawing.Size(884, 31);
            this.m_lbl_title.TabIndex = 33;
            this.m_lbl_title.Text = "F610 -Danh sách giao dịch chuyển nhượng";
            this.m_lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_fg.Location = new System.Drawing.Point(0, 123);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(884, 397);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 35;
            // 
            // f610_dm_giao_dien_chuyen_nhuong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_grb_thong_tin_ban_hang);
            this.Controls.Add(this.m_lbl_title);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f610_dm_giao_dien_chuyen_nhuong";
            this.Text = "F610-Danh sach giao dich chuyen nhuong";
            this.Load += new System.EventHandler(this.f610_dm_giao_dien_chuyen_nhuong_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_grb_thong_tin_ban_hang.ResumeLayout(false);
            this.m_grb_thong_tin_ban_hang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display_theo_trai_phieu(decimal ip_id_trai_phieu)
        {
            m_cbo_trai_phieu.SelectedValue = ip_id_trai_phieu;
            this.ShowDialog();            
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            GIA_TRI_CN_THEO_MENH_GIA = 8,
            tcb_TEN_TRAI_CHU = 4
                ,
            ID = 0
                ,
            tcm_MA_TRAI_CHU = 3
                ,
            GIA_TRI_THUE = 11
                ,
            tcb_MA_TRAI_CHU = 5
                ,
            tcm_TEN_TRAI_CHU = 2
                ,
            MA_GIAO_DICH = 1
                ,
            GIA_TRI_CHUYEN_NHUONG_THUC_TE = 9
                ,
            NGAY_XAC_NHAN = 14
                ,
            PHI_GD = 10
                ,
            NGAY_KY_CHUYEN_NHUONG = 12
                ,
            ID_TRANG_THAI_CHUYEN_NHUONG = 15
                ,
            SO_LUONG_CHUYEN_NHUONG = 7
                ,
            TEN_TRAI_PHIEU = 6
                , NGAY_VAO_SO = 13            

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_GD_CHUYEN_NHUONG m_ds = new DS_V_GD_CHUYEN_NHUONG();
        US_V_GD_CHUYEN_NHUONG m_us = new US_V_GD_CHUYEN_NHUONG();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            set_define_events();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cmb_trai_phieu();
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_CHUYEN_NHUONG.GIA_TRI_CN_THEO_MENH_GIA, e_col_Number.GIA_TRI_CN_THEO_MENH_GIA);
            v_htb.Add(V_GD_CHUYEN_NHUONG.tcb_TEN_TRAI_CHU, e_col_Number.tcb_TEN_TRAI_CHU);
            v_htb.Add(V_GD_CHUYEN_NHUONG.ID, e_col_Number.ID);
            v_htb.Add(V_GD_CHUYEN_NHUONG.tcm_MA_TRAI_CHU, e_col_Number.tcm_MA_TRAI_CHU);
            v_htb.Add(V_GD_CHUYEN_NHUONG.GIA_TRI_THUE, e_col_Number.GIA_TRI_THUE);
            v_htb.Add(V_GD_CHUYEN_NHUONG.tcb_MA_TRAI_CHU, e_col_Number.tcb_MA_TRAI_CHU);
            v_htb.Add(V_GD_CHUYEN_NHUONG.tcm_TEN_TRAI_CHU, e_col_Number.tcm_TEN_TRAI_CHU);
            v_htb.Add(V_GD_CHUYEN_NHUONG.MA_GIAO_DICH, e_col_Number.MA_GIAO_DICH);
            v_htb.Add(V_GD_CHUYEN_NHUONG.GIA_TRI_CHUYEN_NHUONG_THUC_TE, e_col_Number.GIA_TRI_CHUYEN_NHUONG_THUC_TE);
            v_htb.Add(V_GD_CHUYEN_NHUONG.NGAY_XAC_NHAN, e_col_Number.NGAY_XAC_NHAN);
            v_htb.Add(V_GD_CHUYEN_NHUONG.PHI_GD, e_col_Number.PHI_GD);
            v_htb.Add(V_GD_CHUYEN_NHUONG.NGAY_KY_CHUYEN_NHUONG, e_col_Number.NGAY_KY_CHUYEN_NHUONG);
            v_htb.Add(V_GD_CHUYEN_NHUONG.ID_TRANG_THAI_CHUYEN_NHUONG, e_col_Number.ID_TRANG_THAI_CHUYEN_NHUONG);
            v_htb.Add(V_GD_CHUYEN_NHUONG.SO_LUONG_CHUYEN_NHUONG, e_col_Number.SO_LUONG_CHUYEN_NHUONG);
            v_htb.Add(V_GD_CHUYEN_NHUONG.TEN_TRAI_PHIEU, e_col_Number.TEN_TRAI_PHIEU);
            v_htb.Add(V_GD_CHUYEN_NHUONG.NGAY_VAO_SO, e_col_Number.NGAY_VAO_SO);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_CHUYEN_NHUONG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_GD_CHUYEN_NHUONG();      
            US_CM_DM_TU_DIEN v_tu_dien;
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            for (int v_i_grid_row = m_fg.Rows.Fixed; v_i_grid_row < m_fg.Rows.Count; v_i_grid_row++)
            {              
                v_tu_dien = new US_CM_DM_TU_DIEN(CIPConvert.ToDecimal( m_fg[v_i_grid_row, (int)e_col_Number.ID_TRANG_THAI_CHUYEN_NHUONG]));
                m_fg[v_i_grid_row, (int)e_col_Number.ID_TRANG_THAI_CHUYEN_NHUONG] = v_tu_dien.strTEN;
            }
            m_fg.Redraw = true;
        }
        private void load_data_2_cmb_trai_phieu()
        {
            DS_DM_TRAI_PHIEU v_ds_dm_trai_phieu = new DS_DM_TRAI_PHIEU();
            US_DM_TRAI_PHIEU v_us_dm_trai_phieu = new US_DM_TRAI_PHIEU();
            v_us_dm_trai_phieu.FillDataset(v_ds_dm_trai_phieu);            
            DataRow v_dr = v_ds_dm_trai_phieu.DM_TRAI_PHIEU.NewDM_TRAI_PHIEURow();
            v_ds_dm_trai_phieu.EnforceConstraints = false;
            v_dr[DM_TRAI_PHIEU.ID] = 0;
            v_dr[DM_TRAI_PHIEU.TEN_TRAI_PHIEU] = "ALL";
            v_ds_dm_trai_phieu.DM_TRAI_PHIEU.Rows.InsertAt(v_dr, 0);


            m_cbo_trai_phieu.ValueMember = DM_TRAI_PHIEU.ID;
            m_cbo_trai_phieu.DisplayMember = DM_TRAI_PHIEU.TEN_TRAI_PHIEU;
            m_cbo_trai_phieu.DataSource = v_ds_dm_trai_phieu.DM_TRAI_PHIEU;
        }
        private void grid2us_object(US_V_GD_CHUYEN_NHUONG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_GD_CHUYEN_NHUONG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_gd_chuyen_nhuong()
        {
            f600_giao_dich_chuyen_nhuong v_fm600 = new f600_giao_dich_chuyen_nhuong();
            v_fm600.display_lap_chuyen_nhuong();           
            load_data_2_grid();
        }

        private void update_v_gd_chuyen_nhuong()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            f600_giao_dich_chuyen_nhuong v_fm600 = new f600_giao_dich_chuyen_nhuong();
            v_fm600.display_sua_chuyen_nhuong(m_us.dcID);            
            load_data_2_grid();
        }

        private void delete_v_gd_chuyen_nhuong()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_GD_CHUYEN_NHUONG v_us = new US_V_GD_CHUYEN_NHUONG();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_gd_chuyen_nhuong()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            f600_giao_dich_chuyen_nhuong v_fm600 = new f600_giao_dich_chuyen_nhuong();
            v_fm600.display_xem_gd_chuyen_nhuong(m_us.dcID);            
        }
        
        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }
        private void f610_dm_giao_dien_chuyen_nhuong_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_gd_chuyen_nhuong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_gd_chuyen_nhuong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_gd_chuyen_nhuong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_gd_chuyen_nhuong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}

