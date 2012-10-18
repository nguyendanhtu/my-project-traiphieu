///************************************************
/// Generated by: UyVQ
/// Date: 12/10/2012 12:39:36
/// Goal: Create Form for GD_PHONG_GIAI_TOA
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
using IP.Core.IPExcelReport;

namespace BondApp
{



    public class f701_danh_sach_giao_dich_phong_giai_toa : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        private GroupBox m_grb_thong_tin_ban_hang;
        private ComboBox m_cbo_trang_thai;
        private Label m_lbl_nhom_hang;
        private DateTimePicker m_dat_to_date;
        private Label label2;
        private Label label1;
        private DateTimePicker m_dat_from_date;
        private Label m_lbl_header;
        internal Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_duyet;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        private System.ComponentModel.IContainer components;

        public f701_danh_sach_giao_dich_phong_giai_toa()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f701_danh_sach_giao_dich_phong_giai_toa));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_grb_thong_tin_ban_hang = new System.Windows.Forms.GroupBox();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.m_lbl_nhom_hang = new System.Windows.Forms.Label();
            this.m_dat_to_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_dat_from_date = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_header = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_duyet = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.m_grb_thong_tin_ban_hang.SuspendLayout();
            this.m_pnl_out_place_dm.SuspendLayout();
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
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 137);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(871, 241);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_grb_thong_tin_ban_hang
            // 
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_cbo_trang_thai);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_lbl_nhom_hang);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_to_date);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label2);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.label1);
            this.m_grb_thong_tin_ban_hang.Controls.Add(this.m_dat_from_date);
            this.m_grb_thong_tin_ban_hang.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_grb_thong_tin_ban_hang.Location = new System.Drawing.Point(0, 31);
            this.m_grb_thong_tin_ban_hang.Name = "m_grb_thong_tin_ban_hang";
            this.m_grb_thong_tin_ban_hang.Size = new System.Drawing.Size(871, 106);
            this.m_grb_thong_tin_ban_hang.TabIndex = 35;
            this.m_grb_thong_tin_ban_hang.TabStop = false;
            this.m_grb_thong_tin_ban_hang.Text = "Thông tin giao dịch phong tỏa";
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_cbo_trang_thai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_trang_thai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_trang_thai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(243, 65);
            this.m_cbo_trang_thai.MaxDropDownItems = 5;
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(200, 21);
            this.m_cbo_trang_thai.TabIndex = 33;
            this.m_cbo_trang_thai.SelectedIndexChanged += new System.EventHandler(this.m_cbo_trang_thai_SelectedIndexChanged);
            // 
            // m_lbl_nhom_hang
            // 
            this.m_lbl_nhom_hang.AutoSize = true;
            this.m_lbl_nhom_hang.Location = new System.Drawing.Point(167, 68);
            this.m_lbl_nhom_hang.Name = "m_lbl_nhom_hang";
            this.m_lbl_nhom_hang.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_nhom_hang.TabIndex = 32;
            this.m_lbl_nhom_hang.Text = "Trạng thái";
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
            this.label2.Location = new System.Drawing.Point(468, 32);
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
            // m_lbl_header
            // 
            this.m_lbl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_header.ForeColor = System.Drawing.Color.DarkRed;
            this.m_lbl_header.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_header.Name = "m_lbl_header";
            this.m_lbl_header.Size = new System.Drawing.Size(871, 31);
            this.m_lbl_header.TabIndex = 34;
            this.m_lbl_header.Text = "F701 - DANH SÁCH TÌNH HÌNH PHONG TỎA";
            this.m_lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_duyet);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 378);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(871, 36);
            this.m_pnl_out_place_dm.TabIndex = 33;
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
            this.m_cmd_insert.Location = new System.Drawing.Point(427, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 15;
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
            this.m_cmd_update.Location = new System.Drawing.Point(515, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 16;
            this.m_cmd_update.Text = "&Sửa";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(603, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 17;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_duyet
            // 
            this.m_cmd_duyet.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_duyet.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_duyet.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_duyet.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_duyet.Enabled = false;
            this.m_cmd_duyet.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_duyet.Image")));
            this.m_cmd_duyet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_duyet.Location = new System.Drawing.Point(691, 4);
            this.m_cmd_duyet.Name = "m_cmd_duyet";
            this.m_cmd_duyet.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_duyet.TabIndex = 12;
            this.m_cmd_duyet.Text = "&Duyệt";
            this.m_cmd_duyet.Click += new System.EventHandler(this.m_cmd_duyet_Click);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(779, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // f701_danh_sach_giao_dich_phong_giai_toa
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(871, 414);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_grb_thong_tin_ban_hang);
            this.Controls.Add(this.m_lbl_header);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f701_danh_sach_giao_dich_phong_giai_toa";
            this.Text = "f701_danh_sach_giao_dich_phong_giai_toa";
            this.Load += new System.EventHandler(this.f701_danh_sach_giao_dich_phong_giai_toa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.m_grb_thong_tin_ban_hang.ResumeLayout(false);
            this.m_grb_thong_tin_ban_hang.PerformLayout();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void display_phong_toa_duyet()
        {
            this.Text = "F701 - Danh sách giao dịch phong tỏa";
            m_lbl_header.Text = "F701 - DANH SÁCH GIAO DỊCH PHONG TỎA";
            m_e_form_mode = e_form_mode.DANH_SACH_PHONG_TOA;
            this.ShowDialog();
        }
        public void display_giai_toa_duyet()
        {
            this.Text = "F702 - DANH SÁCH GIAO DỊCH giải tỏa";
            m_lbl_header.Text = "F702 - DANH SÁCH GIAO DỊCH GIẢI TỎA";
            m_e_form_mode = e_form_mode.DANH_SACH_GIAI_TOA;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            PHONG_TOA_YN = 19
,
            ID_NGUOI_LAP = 16
                ,
            NGUOI_XAC_NHAN = 11
                ,
            SO_LUONG = 2
                ,
            CHUC_DANH = 5
                ,
            GIAY_UQ = 13
                ,
            NGAY_CAP_GIAY_UQ = 15
                ,
            CUA = 14
                ,
            NGAN_HANG_CAM_CO = 9
                ,
            ID_TRAI_CHU = 1
                ,
            ID_TRANG_THAI = 18
                ,
            ID_NGUOI_DUYET = 17
                ,
            NGAY_GIAO_DICH = 3
                ,
            CHUC_VU = 12
                ,
            KHOAN_DAU_TU = 10
                ,
            NDD_DIEN_THOAI = 7
                ,
            NGUOI_DAI_DIEN = 4
                ,
            NDD_TRU_SO = 6
                , NDD_FAX = 8

        }
        private enum e_form_mode
        {
            DANH_SACH_PHONG_TOA = 1
            , DANH_SACH_GIAI_TOA = 2
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_GD_PHONG_GIAI_TOA m_ds = new DS_GD_PHONG_GIAI_TOA();
        US_GD_PHONG_GIAI_TOA m_us = new US_GD_PHONG_GIAI_TOA();
        DS_DM_TRAI_CHU m_ds_trai_chu = new DS_DM_TRAI_CHU();
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        e_form_mode m_e_form_mode = e_form_mode.DANH_SACH_PHONG_TOA;

        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();

            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_to_cbo_trang_thai();
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_PHONG_GIAI_TOA.PHONG_TOA_YN, e_col_Number.PHONG_TOA_YN);
            v_htb.Add(GD_PHONG_GIAI_TOA.ID_NGUOI_LAP, e_col_Number.ID_NGUOI_LAP);
            v_htb.Add(GD_PHONG_GIAI_TOA.NGUOI_XAC_NHAN, e_col_Number.NGUOI_XAC_NHAN);
            v_htb.Add(GD_PHONG_GIAI_TOA.SO_LUONG, e_col_Number.SO_LUONG);
            v_htb.Add(GD_PHONG_GIAI_TOA.CHUC_DANH, e_col_Number.CHUC_DANH);
            v_htb.Add(GD_PHONG_GIAI_TOA.GIAY_UQ, e_col_Number.GIAY_UQ);
            v_htb.Add(GD_PHONG_GIAI_TOA.NGAY_CAP_GIAY_UQ, e_col_Number.NGAY_CAP_GIAY_UQ);
            v_htb.Add(GD_PHONG_GIAI_TOA.CUA, e_col_Number.CUA);
            v_htb.Add(GD_PHONG_GIAI_TOA.NGAN_HANG_CAM_CO, e_col_Number.NGAN_HANG_CAM_CO);
            v_htb.Add(GD_PHONG_GIAI_TOA.ID_TRAI_CHU, e_col_Number.ID_TRAI_CHU);
            v_htb.Add(GD_PHONG_GIAI_TOA.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
            v_htb.Add(GD_PHONG_GIAI_TOA.ID_NGUOI_DUYET, e_col_Number.ID_NGUOI_DUYET);
            v_htb.Add(GD_PHONG_GIAI_TOA.NGAY_GIAO_DICH, e_col_Number.NGAY_GIAO_DICH);
            v_htb.Add(GD_PHONG_GIAI_TOA.CHUC_VU, e_col_Number.CHUC_VU);
            v_htb.Add(GD_PHONG_GIAI_TOA.KHOAN_DAU_TU, e_col_Number.KHOAN_DAU_TU);
            v_htb.Add(GD_PHONG_GIAI_TOA.NDD_DIEN_THOAI, e_col_Number.NDD_DIEN_THOAI);
            v_htb.Add(GD_PHONG_GIAI_TOA.NGUOI_DAI_DIEN, e_col_Number.NGUOI_DAI_DIEN);
            v_htb.Add(GD_PHONG_GIAI_TOA.NDD_TRU_SO, e_col_Number.NDD_TRU_SO);
            v_htb.Add(GD_PHONG_GIAI_TOA.NDD_FAX, e_col_Number.NDD_FAX);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.GD_PHONG_GIAI_TOA.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_GD_PHONG_GIAI_TOA();
            int v_i_phong_toa_yn = (int)m_e_form_mode;
            string v_str_phong_toa_yn = "";
            if (v_i_phong_toa_yn == 1) v_str_phong_toa_yn = "Y";
            else v_str_phong_toa_yn = "N";
            m_us.fill_dataset_by_date_trang_thai(m_ds
                                    , v_str_phong_toa_yn
                                    , CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue)
                                    , m_dat_from_date.Value
                                    , m_dat_to_date.Value);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
            //Map ten trai chu
            DS_DM_TRAI_CHU m_ds_trai_chu = new DS_DM_TRAI_CHU();
            US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
            m_us_trai_chu.FillDataset(m_ds_trai_chu);
            Hashtable v_hst_ten_trai_chu = new Hashtable();
            foreach (DataRow v_dr in m_ds_trai_chu.DM_TRAI_CHU.Rows)
            {
                v_hst_ten_trai_chu.Add(v_dr[DM_TRAI_CHU.ID], v_dr[DM_TRAI_CHU.TEN_TRAI_CHU]);
            }
            m_fg.Cols[(int)e_col_Number.ID_TRAI_CHU].DataMap = v_hst_ten_trai_chu;
            //Map ten nguoi lap
            DS_HT_NGUOI_SU_DUNG m_ds_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
            US_HT_NGUOI_SU_DUNG m_us_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG();
            m_us_nguoi_su_dung.FillDataset(m_ds_nguoi_su_dung);
            Hashtable v_hst_ten_nguoi_lap = new Hashtable();
            foreach (DataRow v_dr in m_ds_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows)
            {
                v_hst_ten_nguoi_lap.Add(v_dr[HT_NGUOI_SU_DUNG.ID], v_dr[HT_NGUOI_SU_DUNG.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_NGUOI_LAP].DataMap = v_hst_ten_nguoi_lap;
            m_fg.Cols[(int)e_col_Number.ID_NGUOI_DUYET].DataMap = v_hst_ten_nguoi_lap;
            // Map trang thai

            US_CM_DM_TU_DIEN m_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN m_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            m_us_tu_dien.FillDataset(m_ds_tu_dien);
            Hashtable v_hst_ten_trang_thai = new Hashtable();
            foreach (DataRow v_dr in m_ds_tu_dien.CM_DM_TU_DIEN.Rows)
            {
                v_hst_ten_trang_thai.Add(v_dr[CM_DM_TU_DIEN.ID], v_dr[CM_DM_TU_DIEN.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI].DataMap = v_hst_ten_trang_thai;
        }
        private void grid2us_object(US_GD_PHONG_GIAI_TOA i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_GD_PHONG_GIAI_TOA i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void load_data_to_cbo_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.fill_tu_dien_cung_loai_ds(CM_DM_DS_LOAI_TU_DIEN.TRANG_THAI_GD, v_ds_cm_dm_tu_dien);
            v_ds_cm_dm_tu_dien.EnforceConstraints = false;
            DataRow v_dr = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = 0;
            v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
        }
        private void insert_gd_phong_giai_toa()
        {
            f700_giao_dich_phong_toa_giai_toa v_fDE = new f700_giao_dich_phong_toa_giai_toa();			
			switch(m_e_form_mode)
            {
            	case e_form_mode.DANH_SACH_GIAI_TOA: v_fDE.display_giai_toa();
                    break;
                case e_form_mode.DANH_SACH_PHONG_TOA: v_fDE.display_phong_toa();
                    break;
                default: break;
            }
        }

        private void update_gd_phong_giai_toa()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            f700_giao_dich_phong_toa_giai_toa vf700 = new f700_giao_dich_phong_toa_giai_toa();
            switch (m_e_form_mode)
            {
                case e_form_mode.DANH_SACH_GIAI_TOA:
                    vf700.display_sua_giai_toa(m_us);
                    break;
                case e_form_mode.DANH_SACH_PHONG_TOA:
                    vf700.display_sua_phong_toa(m_us);
                    break;
            }
            
        }

        private void delete_gd_phong_giai_toa()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_GD_PHONG_GIAI_TOA v_us = new US_GD_PHONG_GIAI_TOA();
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
        private void chon_trai_chu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            f700_giao_dich_phong_toa_giai_toa vf700 = new f700_giao_dich_phong_toa_giai_toa();
            switch (m_e_form_mode)
            {
                case e_form_mode.DANH_SACH_GIAI_TOA:
                    vf700.display_duyet_giai_toa(m_us);
                    break;
                case e_form_mode.DANH_SACH_PHONG_TOA:
                    vf700.display_duyet_phong_toa(m_us);
                    break;
            }
            this.Close();

        }
        private void view_gd_phong_giai_toa()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f701_danh_sach_giao_dich_phong_giai_toa_DE v_fDE = new f701_danh_sach_giao_dich_phong_giai_toa_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
               m_dat_from_date.ValueChanged += new EventHandler(m_dat_from_date_ValueChanged);
            m_dat_to_date.ValueChanged += new EventHandler(m_dat_to_date_ValueChanged);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f701_danh_sach_giao_dich_phong_giai_toa_Load(object sender, System.EventArgs e)
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
                insert_gd_phong_giai_toa();
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
                update_gd_phong_giai_toa();                
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
                delete_gd_phong_giai_toa();
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
                view_gd_phong_giai_toa();
            }
            catch (Exception v_e)
            {
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

        private void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
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

        private void m_cmd_duyet_Click(object sender, EventArgs e)
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
    }
}

