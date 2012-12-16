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
using IP.Core.IPWordReport;

using C1.Win.C1FlexGrid;
using System.Data.SqlClient;
using IP.Core.IPSystemAdmin;

namespace BondApp
{
    public partial class f700_giao_dich_phong_toa_giai_toa : Form
    {
        public f700_giao_dich_phong_toa_giai_toa()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interface
        public void display_phong_toa()
        {
            m_e_form_mode = eFormMode.LAP_PHONG_TOA;
            this.Text = "F700 - Lập Giao dịch phong tỏa";
            m_lbl_title.Text = "F700 - Lập Giao dịch phong tỏa";
            this.ShowDialog();
        }
        public void display_giai_toa()
        {
            m_e_form_mode = eFormMode.LAP_GIAI_TOA;

            this.Text = "F700 - Lập Giao dịch giải tỏa";
            m_lbl_title.Text = "F700 - Lập Giao dịch giải tỏa";
            m_lbl_so_luong_tp_cam_co.Text = "Số lượng TP giải tỏa";
            m_lbl_khoan_dau_tu.Text = "Lý do giải tỏa";
            m_lbl_so_luong_kha_dung.Text = "Số lượng phong tỏa";
            m_cbo_ngan_hang_cam_co.Enabled = true;
            m_cbo_ngan_hang_cam_co.Visible = true;
            this.ShowDialog();
        }
        public void display_sua_phong_toa(US_GD_PHONG_GIAI_TOA ip_us_phong_giai_toa)
        {
            m_e_form_mode = eFormMode.SUA_PHONG_TOA;
            //m_cmd_lap.Enabled = false;
            //m_cmd_duyet.Enabled = false;
            //m_cmd_chon_trai_chu.Enabled = false;
            //m_cmd_save.Enabled = true;
            //m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            this.Text = "F700 - Sửa Giao dịch phong tỏa";
            m_lbl_title.Text = "F700 - Sửa Giao dịch phong tỏa";
            m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            US_DM_TRAI_CHU ip_us_trai_chu = new US_DM_TRAI_CHU(ip_us_phong_giai_toa.dcID_TRAI_CHU);
            us_trai_chu_2_form(ip_us_trai_chu);
            m_txt_nguoi_dai_dien.Focus();
            this.ShowDialog();
        }
        public void display_sua_giai_toa(US_GD_PHONG_GIAI_TOA ip_us_phong_giai_toa)
        {
            m_e_form_mode = eFormMode.SUA_GIAI_TOA;
            //m_cmd_lap.Enabled = false;
            //m_cmd_duyet.Enabled = false;
            //m_cmd_chon_trai_chu.Enabled = false;
            //m_cmd_save.Enabled = true;
            //m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            this.Text = "F700 - Sửa Giao dịch giải tỏa";
            m_lbl_title.Text = "F700 - Sửa Giao dịch giải tỏa";
            m_lbl_so_luong_tp_cam_co.Text = "Số lượng TP giải tỏa";
            m_lbl_khoan_dau_tu.Text = "Lý do giải tỏa";
            m_lbl_so_luong_kha_dung.Text = "Số lượng phong tỏa";
            m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            US_DM_TRAI_CHU ip_us_trai_chu = new US_DM_TRAI_CHU(ip_us_phong_giai_toa.dcID_TRAI_CHU);
            us_trai_chu_2_form(ip_us_trai_chu);
            m_txt_nguoi_dai_dien.Focus();
            m_cbo_ngan_hang_cam_co.Enabled = true;
            m_cbo_ngan_hang_cam_co.Visible = true;
            this.ShowDialog();
        }
        public void display_duyet_phong_toa(US_GD_PHONG_GIAI_TOA ip_us_phong_giai_toa)
        {
            m_e_form_mode = eFormMode.DUYET_PHONG_TOA;
            m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            this.Text = "F700 - Duyệt Giao dịch phong tỏa";
            m_lbl_title.Text = "F700 - Duyệt Giao dịch phong tỏa";             
            US_DM_TRAI_CHU ip_us_trai_chu = new US_DM_TRAI_CHU(ip_us_phong_giai_toa.dcID_TRAI_CHU);
            us_trai_chu_2_form(ip_us_trai_chu);
            m_txt_nguoi_dai_dien.Focus();
            this.ShowDialog();
        }
        public void display_duyet_giai_toa(US_GD_PHONG_GIAI_TOA ip_us_phong_giai_toa)
        {
            m_e_form_mode = eFormMode.DUYET_GIAI_TOA;
            m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;           
            US_DM_TRAI_CHU ip_us_trai_chu = new US_DM_TRAI_CHU(ip_us_phong_giai_toa.dcID_TRAI_CHU);
            us_trai_chu_2_form(ip_us_trai_chu);
            this.Text = "F700 - Duyệt Giao dịch giải tỏa";
            m_lbl_title.Text = "F700 - Duyệt Giao dịch giải tỏa";
            m_lbl_so_luong_tp_cam_co.Text = "Số lượng TP giải tỏa";
            m_lbl_khoan_dau_tu.Text = "Lý do giải tỏa";
            m_lbl_so_luong_kha_dung.Text = "Số lượng phong tỏa";
            m_cbo_ngan_hang_cam_co.Enabled = true;
            m_cbo_ngan_hang_cam_co.Visible = true;
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        private enum e_col_Number
        {
            ID = 1
                ,
            ID_TRAI_CHU = 2
                ,
            NGAY = 3
                ,
            TONG_SO_DU = 4
                ,
            SO_DU_KHA_DUNG = 5
        }
        public enum eFormMode
        {
            LAP_PHONG_TOA
                ,
            LAP_GIAI_TOA
            ,
            DUYET_PHONG_TOA
                ,
            DUYET_GIAI_TOA
                ,
            SUA_PHONG_TOA
                , SUA_GIAI_TOA
        }
        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_V_DM_TRAI_PHIEU m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        US_CM_DM_LOAI_TD m_us_cm_dm_loai_tu_dien = new US_CM_DM_LOAI_TD();
        US_GD_PHONG_GIAI_TOA m_us_gd_phong_toa_giai_toa = new US_GD_PHONG_GIAI_TOA();
        DS_GD_PHONG_GIAI_TOA m_ds_gd_phong_toa_giai_toa = new DS_GD_PHONG_GIAI_TOA();
        eFormMode m_e_form_mode = eFormMode.LAP_PHONG_TOA;
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        #endregion

        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);

            set_define_events();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;

            /* Thông tin riêng*/
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:
                    m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_GIAI_TOA;
                    DS_GD_PHONG_GIAI_TOA v_ds_gd_phong_giai_toa = new DS_GD_PHONG_GIAI_TOA();
                    US_DM_TRAI_CHU v_us_trai_chu = new US_DM_TRAI_CHU(m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    m_us_gd_phong_toa_giai_toa.FillDataset(v_ds_gd_phong_giai_toa, " WHERE ID = (SELECT MAX(ID) FROM GD_PHONG_GIAI_TOA)");
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.THEM;
                    if (v_ds_gd_phong_giai_toa.GD_PHONG_GIAI_TOA.Rows.Count > 0)
                        m_us_v_ht_log_truy_cap.strMO_TA = "Thêm " + LOG_DOI_TUONG_TAC_DONG.GD_GIAI_TOA + " ngày " + CIPConvert.ToStr(v_ds_gd_phong_giai_toa.GD_PHONG_GIAI_TOA.Rows[0][GD_PHONG_GIAI_TOA.NGAY_GIAO_DICH]) + ", trái chủ: " + v_us_trai_chu.strTEN_TRAI_CHU;
                    break;
                case eFormMode.LAP_PHONG_TOA:
                    m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_PHONG_TOA;
                    DS_GD_PHONG_GIAI_TOA v_ds_gd_phong_giai_toa1 = new DS_GD_PHONG_GIAI_TOA();
                    US_DM_TRAI_CHU v_us_trai_chu1 = new US_DM_TRAI_CHU(m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    m_us_gd_phong_toa_giai_toa.FillDataset(v_ds_gd_phong_giai_toa1, " WHERE ID = (SELECT MAX(ID) FROM GD_PHONG_GIAI_TOA)");
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.THEM;
                    if (v_ds_gd_phong_giai_toa1.GD_PHONG_GIAI_TOA.Rows.Count > 0)
                        m_us_v_ht_log_truy_cap.strMO_TA = "Thêm " + LOG_DOI_TUONG_TAC_DONG.GD_PHONG_TOA + " ngày " + CIPConvert.ToStr(v_ds_gd_phong_giai_toa1.GD_PHONG_GIAI_TOA.Rows[0][GD_PHONG_GIAI_TOA.NGAY_GIAO_DICH]) + ", trái chủ: " + v_us_trai_chu1.strTEN_TRAI_CHU;
                    break;
                case eFormMode.SUA_GIAI_TOA:
                    US_DM_TRAI_CHU v_us_trai_chu2 = new US_DM_TRAI_CHU(m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_GIAI_TOA;
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Cập nhật thông tin " + LOG_DOI_TUONG_TAC_DONG.GD_GIAI_TOA + " ngày " + m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH + ", trái chủ " + v_us_trai_chu2.strTEN_TRAI_CHU;
                    break;
                case eFormMode.SUA_PHONG_TOA:
                    US_DM_TRAI_CHU v_us_trai_chu3 = new US_DM_TRAI_CHU(m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_PHONG_TOA;
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Cập nhật thông tin " + LOG_DOI_TUONG_TAC_DONG.GD_PHONG_TOA + " ngày " + m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH + ", trái chủ " + v_us_trai_chu3.strTEN_TRAI_CHU;
                    break;
                case eFormMode.DUYET_GIAI_TOA:
                    US_DM_TRAI_CHU v_us_trai_chu4 = new US_DM_TRAI_CHU(m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_GIAI_TOA;
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Duyệt thông tin " + LOG_DOI_TUONG_TAC_DONG.GD_GIAI_TOA + " ngày " + m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH + ", trái chủ " + v_us_trai_chu4.strTEN_TRAI_CHU;
                    break;
                case eFormMode.DUYET_PHONG_TOA:
                    US_DM_TRAI_CHU v_us_trai_chu5 = new US_DM_TRAI_CHU(m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_PHONG_TOA;
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Duyệt thông tin " + LOG_DOI_TUONG_TAC_DONG.GD_PHONG_TOA + " ngày " + m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH + ", trái chủ " + v_us_trai_chu5.strTEN_TRAI_CHU;
                    break;
            }
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
        private bool check_thong_tin_chuyen_nhuong_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_nguoi_dai_dien, DataType.StringType, allowNull.NO))
            {
                m_txt_nguoi_dai_dien.Focus();

                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tru_so_chinh, DataType.StringType, allowNull.NO))
            {
                m_txt_tru_so_chinh.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_chuc_danh, DataType.StringType, allowNull.NO))
            {
                m_txt_chuc_danh.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_dien_thoai, DataType.StringType, allowNull.NO))
            {
                m_txt_dien_thoai.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_luong_tp_cam_co, DataType.NumberType, allowNull.NO))
            {
                m_txt_so_luong_tp_cam_co.Focus();
                return false;
            }
            if (m_e_form_mode != eFormMode.LAP_GIAI_TOA && m_e_form_mode != eFormMode.SUA_GIAI_TOA && m_e_form_mode != eFormMode.DUYET_GIAI_TOA)
            {
                if (!CValidateTextBox.IsValid(m_txt_ngan_hang_cam_co, DataType.StringType, allowNull.NO))
                {

                    m_txt_ngan_hang_cam_co.Focus();
                    return false;
                }
            }
            //if (!CValidateTextBox.IsValid(m_txt_nguoi_xac_nhan, DataType.StringType, allowNull.NO))
            //{
            //    m_txt_nguoi_xac_nhan.Focus();
            //    return false;
            //}
            //if (!CValidateTextBox.IsValid(m_txt_chuc_vu, DataType.StringType, allowNull.NO))
            //{
            //    m_txt_chuc_vu.Focus();
            //    return false;
            //}
            //if (!CValidateTextBox.IsValid(m_txt_theo_giay_uy_quyen_so, DataType.StringType, allowNull.NO))
            //{
            //    m_txt_theo_giay_uy_quyen_so.Focus();
            //    return false;
            //}

            //if (!CValidateTextBox.IsValid(m_txt_cua, DataType.StringType, allowNull.NO))
            //{
            //    m_txt_cua.Focus();
            //    return false;
            //}
            if (CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text) > CIPConvert.ToDecimal(m_txt_so_luong_kha_dung.Text))
            {
                m_txt_so_luong_tp_cam_co.Focus();
                MessageBox.Show("Số lượng trái phiếu cầm cố vượt quá số lượng trái phiểu khả dụng! Xin hãy nhập lại.", "Cảnh báo");
                return false;
            }

            return true;
        }
        private bool kiem_tra_phi_gd(decimal v_phi_gd)
        {
            US_DM_DOT_PHAT_HANH v_dm_dot_phat_hanh = new BondUS.US_DM_DOT_PHAT_HANH(m_us_trai_phieu.dcID_DOT_PHAT_HANH);

            if (v_phi_gd < CIPConvert.ToDecimal(v_dm_dot_phat_hanh.dcPHI_PHONG_GIAI_TOA_MIN))
            {

                m_txt_phi_gd.Text = CIPConvert.ToStr(CIPConvert.ToDecimal(v_dm_dot_phat_hanh.dcPHI_PHONG_GIAI_TOA_MIN), "#,###");

                return false;
            }
            if (v_phi_gd > CIPConvert.ToDecimal(v_dm_dot_phat_hanh.dcPHI_PHONG_GIAI_TOA_MAX))
            {

                m_txt_phi_gd.Text = CIPConvert.ToStr(CIPConvert.ToDecimal(v_dm_dot_phat_hanh.dcPHI_PHONG_GIAI_TOA_MAX), "#,##");
                // m_txt_ty_le_phi_gd.Text = CIPConvert.ToStr(Math.Round((CIPConvert.ToDecimal(v_us_phi_gd_max.strGIA_TRI) / CIPConvert.ToDecimal(m_txt_tong_gia_tri.Text)*100),2));
                return false;
            }
            return true;
        }
        private void set_inital_form_load()
        {                        
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:                    
                    m_cmd_lap.Enabled = true;
                    m_cmd_duyet.Enabled = false;
                    m_cmd_save.Enabled = false;
                    m_dat_ngay.Value = DateTime.Today;
                    break;
                case eFormMode.LAP_PHONG_TOA:
                    m_cmd_lap.Enabled = true;
                    m_cmd_duyet.Enabled = false;
                    m_cmd_save.Enabled = false;
                    m_dat_ngay.Value = DateTime.Today;
                    break;
                case eFormMode.DUYET_GIAI_TOA:
                case eFormMode.DUYET_PHONG_TOA:
                    m_cmd_lap.Enabled = false;
                    m_cmd_duyet.Enabled = true;
                    m_cmd_save.Enabled = false;
                    break;
                case eFormMode.SUA_GIAI_TOA:
                case eFormMode.SUA_PHONG_TOA:
                    m_cmd_save.Enabled = true;
                    m_cmd_lap.Enabled = false;
                    m_cmd_duyet.Enabled = false;
                    break;
                default:
                    break;
            }       
        }

        private void load_data_2_cmb_ngan_hang_cam_co()
        {
            US_GD_PHONG_GIAI_TOA v_us_gd_phong_toa = new BondUS.US_GD_PHONG_GIAI_TOA();
            DS_GD_PHONG_GIAI_TOA v_ds_gd_phong_toa = new DS_GD_PHONG_GIAI_TOA();

            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:
                  v_us_gd_phong_toa.fill_dataset_byIdtraichu(v_ds_gd_phong_toa, m_us_trai_chu.dcID);
                    break;
                case eFormMode.DUYET_GIAI_TOA:
                case eFormMode.SUA_GIAI_TOA:
                    v_us_gd_phong_toa.fill_dataset_byIdtraichu(v_ds_gd_phong_toa, m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU);
                    break;
            }
            v_ds_gd_phong_toa.EnforceConstraints = false;

            m_cbo_ngan_hang_cam_co.DataSource = v_ds_gd_phong_toa.GD_PHONG_GIAI_TOA;
            m_cbo_ngan_hang_cam_co.ValueMember = GD_PHONG_GIAI_TOA.NGAN_HANG_CAM_CO;
            m_cbo_ngan_hang_cam_co.DisplayMember = GD_PHONG_GIAI_TOA.NGAN_HANG_CAM_CO;
        }
        //private void load_data_2_cmb_ngan_hang_cam_co()
        //{
        //    US_GD_PHONG_GIAI_TOA v_us_gd_phong_toa = new BondUS.US_GD_PHONG_GIAI_TOA();
        //    DS_GD_PHONG_GIAI_TOA v_ds_gd_phong_toa = new DS_GD_PHONG_GIAI_TOA();

        //    v_us_gd_phong_toa.fill_dataset_byIdtraichu(v_ds_gd_phong_toa, m_us_trai_chu.dcID);
        //    v_ds_gd_phong_toa.EnforceConstraints = false;


        //    m_cbo_ngan_hang_cam_co.ValueMember = GD_PHONG_GIAI_TOA.NGAN_HANG_CAM_CO;
        //    m_cbo_ngan_hang_cam_co.DisplayMember = GD_PHONG_GIAI_TOA.NGAN_HANG_CAM_CO;
        //    m_cbo_ngan_hang_cam_co.DataSource = v_ds_gd_phong_toa.GD_PHONG_GIAI_TOA;
        //}
        private void select_trai_chu()
        {
            f701_danh_sach_giao_dich_phong_giai_toa vfrm701 = new f701_danh_sach_giao_dich_phong_giai_toa();
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:
                    f500_dm_trai_chu v_f500 = new f500_dm_trai_chu();
                    m_us_trai_chu = v_f500.select_trai_chu_giai_toa_of_trai_phieu(null);
                    if (m_us_trai_chu.dcID == -1) return;
                    us_trai_chu_2_form(m_us_trai_chu);
                    m_txt_nguoi_dai_dien.Focus();
                    break;
                case eFormMode.LAP_PHONG_TOA:
                    f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
                    m_us_trai_chu = v_frm500.select_trai_chu_phong_toa_of_trai_phieu(null);
                    if (m_us_trai_chu.dcID == -1) return;
                    us_trai_chu_2_form(m_us_trai_chu);
                    m_txt_nguoi_dai_dien.Focus();
                    break;
                case eFormMode.DUYET_GIAI_TOA:
                    this.Close();
                    vfrm701.display_giai_toa_duyet();
                    break;
                case eFormMode.DUYET_PHONG_TOA:
                    this.Close();
                    vfrm701.display_phong_toa_duyet();
                    break;
            }
        }
        private void us_trai_chu_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            if (ip_us_trai_chu.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us = new US_GD_SO_DU_TRAI_PHIEU();
            v_us.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu.dcID, v_ds);
            m_us_trai_phieu = new US_V_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);
            m_txt_ma_trai_chu.Text = ip_us_trai_chu.strMA_TRAI_CHU;
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_txt_ngay_cap.Text = ip_us_trai_chu.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            m_txt_so_luong_trai_phieu.Text = CIPConvert.ToStr(v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["TONG_SO_DU"], "#,###");
            if (m_e_form_mode == eFormMode.DUYET_GIAI_TOA || m_e_form_mode == eFormMode.LAP_GIAI_TOA || m_e_form_mode == eFormMode.SUA_GIAI_TOA)
                m_txt_so_luong_kha_dung.Text = CIPConvert.ToStr(CIPConvert.ToDecimal(v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["TONG_SO_DU"]) - CIPConvert.ToDecimal(v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["SO_DU_KHA_DUNG"]),"#,###");
            else
                m_txt_so_luong_kha_dung.Text = CIPConvert.ToStr(v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["SO_DU_KHA_DUNG"],"#,###");
            us_trai_phieu_2_form(m_us_trai_phieu);
            if (m_e_form_mode == eFormMode.DUYET_GIAI_TOA || m_e_form_mode == eFormMode.DUYET_PHONG_TOA
                 || m_e_form_mode == eFormMode.SUA_GIAI_TOA || m_e_form_mode == eFormMode.SUA_PHONG_TOA)
            {
                m_txt_nguoi_dai_dien.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.strNGUOI_DAI_DIEN);
                m_txt_chuc_danh.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.strCHUC_DANH);
                m_txt_tru_so_chinh.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.strNDD_TRU_SO);
                m_txt_dien_thoai.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.strNDD_DIEN_THOAI);
                m_txt_fax.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.strNDD_FAX);
                m_txt_so_luong_tp_cam_co.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.dcSO_LUONG,"#,###");
                m_txt_tong_gia_tri.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.dcSO_LUONG * m_us_trai_phieu.dcMENH_GIA,"#,###");
                //m_txt_ngan_hang_cam_co.Text = m_us_gd_phong_toa_giai_toa.strNGAN_HANG_CAM_CO;
                m_txt_khoan_dau_tu.Text = m_us_gd_phong_toa_giai_toa.strKHOAN_DAU_TU;
                m_txt_nguoi_xac_nhan.Text = m_us_gd_phong_toa_giai_toa.strNGUOI_XAC_NHAN;
                m_txt_chuc_vu.Text = m_us_gd_phong_toa_giai_toa.strCHUC_VU;
                m_txt_theo_giay_uy_quyen_so.Text = m_us_gd_phong_toa_giai_toa.strGIAY_UQ;
                m_dat_ngay_cap_giay_uq.Value = m_us_gd_phong_toa_giai_toa.datNGAY_CAP_GIAY_UQ;
                m_dat_ngay.Value = m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH;
                m_txt_cua.Text = m_us_gd_phong_toa_giai_toa.strCUA;
                if (m_us_gd_phong_toa_giai_toa.dcTY_LE_PHI_GD == 0) m_txt_ty_le_phi_gd.Text = "0";
                else m_txt_ty_le_phi_gd.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.dcTY_LE_PHI_GD * 100, "#,###0.00000");
                if (m_us_gd_phong_toa_giai_toa.dcPHI_GIAO_DICH == 0) m_txt_phi_gd.Text = "0";
                else m_txt_phi_gd.Text = CIPConvert.ToStr(m_us_gd_phong_toa_giai_toa.dcPHI_GIAO_DICH,"#,###");
            }
             if (m_e_form_mode == eFormMode.LAP_GIAI_TOA || m_e_form_mode == eFormMode.LAP_PHONG_TOA)
            {
                m_txt_nguoi_dai_dien.Text = ip_us_trai_chu.strTEN_NGUOI_DAI_DIEN;
                m_txt_chuc_danh.Text = ip_us_trai_chu.strCHUC_VU;
                m_txt_tru_so_chinh.Text = ip_us_trai_chu.strDIA_CHI;
                m_txt_dien_thoai.Text = ip_us_trai_chu.strMOBILE;
                m_txt_fax.Text = ip_us_trai_chu.strFAX;
            }
             if (m_e_form_mode == eFormMode.LAP_GIAI_TOA || m_e_form_mode == eFormMode.SUA_GIAI_TOA || m_e_form_mode == eFormMode.DUYET_GIAI_TOA)
                load_data_2_cmb_ngan_hang_cam_co();
             else m_txt_ngan_hang_cam_co.Text = m_us_gd_phong_toa_giai_toa.strNGAN_HANG_CAM_CO;
             m_cbo_ngan_hang_cam_co.SelectedValue = m_us_gd_phong_toa_giai_toa.strNGAN_HANG_CAM_CO;
        }
        private void us_trai_phieu_2_form(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);

            m_txt_ma_so_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_to_chuc_phat_hanh.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_ty_le_phi_gd.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.dcTY_LE_PHI_PHONG_GIAI_TOA*100, "#,##0.0000");
            if (v_us_dm_dot_phat_hanh.dcMENH_GIA == 0) m_txt_menh_gia.Text = "0";
            else
                m_txt_menh_gia.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.dcMENH_GIA, "#,###");

            m_txt_ngay_phat_hanh.Text = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH.ToString("dd/MM/yyyy");
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN, "dd/MM/yyyy");
            m_txt_lai_suat.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcLAI_SUAT_DEFAULT, "#,##0.00");
            if (ip_us_trai_phieu.strTRA_LAI_SAU_YN != null)
                switch (ip_us_trai_phieu.strTRA_LAI_SAU_YN)
                {
                    case "Y":
                        m_txt_hinh_thuc_tra_lai.Text = "Trả lãi sau";
                        break;
                    case "N":
                        m_txt_hinh_thuc_tra_lai.Text = "Trả theo kỳ";
                        break;
                }
            m_lbl_pgd_max_min.Text = "Phí giao dịch trong khoảng " + CIPConvert.ToStr(v_us_dm_dot_phat_hanh.dcPHI_PHONG_GIAI_TOA_MIN, "#,###") + " đến " + CIPConvert.ToStr(v_us_dm_dot_phat_hanh.dcPHI_PHONG_GIAI_TOA_MAX, "#,###") + ".";
        }
        private void form_2_us_gd_phong_toa_giai_toa()
        {
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:
                    m_us_gd_phong_toa_giai_toa.strPHONG_TOA_YN = "N";
                    m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU = m_us_trai_chu.dcID;
                    form_2_us_gd_lap_pgt();
                    m_us_gd_phong_toa_giai_toa.dcID_TRANG_THAI = List_trang_thai.Da_Nhap;
                    break;
                case eFormMode.LAP_PHONG_TOA:
                    m_us_gd_phong_toa_giai_toa.strPHONG_TOA_YN = "Y";
                    m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU = m_us_trai_chu.dcID;
                    form_2_us_gd_lap_pgt();
                    m_us_gd_phong_toa_giai_toa.dcID_TRANG_THAI = List_trang_thai.Da_Nhap;
                    break;
                case eFormMode.DUYET_PHONG_TOA:
                    m_us_gd_phong_toa_giai_toa.dcID_NGUOI_DUYET = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();

                    break;
                case eFormMode.DUYET_GIAI_TOA:
                    m_us_gd_phong_toa_giai_toa.dcID_NGUOI_DUYET = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();

                    break;

                default: form_2_us_gd_lap_pgt(); break;

            }
        }
        private void form_2_us_gd_lap_pgt()
        {

            m_us_gd_phong_toa_giai_toa.SetID_NGUOI_DUYETNull();
            m_us_gd_phong_toa_giai_toa.dcID_NGUOI_LAP = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
            m_us_gd_phong_toa_giai_toa.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text);
            m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH = m_dat_ngay.Value.Date;
            m_us_gd_phong_toa_giai_toa.strNGUOI_DAI_DIEN = m_txt_nguoi_dai_dien.Text;
            m_us_gd_phong_toa_giai_toa.strCHUC_DANH = m_txt_chuc_danh.Text;
            m_us_gd_phong_toa_giai_toa.dcID_TRANG_THAI = 0;
            m_us_gd_phong_toa_giai_toa.strCUA = m_txt_cua.Text;
            m_us_gd_phong_toa_giai_toa.datNGAY_CAP_GIAY_UQ = m_dat_ngay_cap_giay_uq.Value.Date;
            m_us_gd_phong_toa_giai_toa.strGIAY_UQ = m_txt_theo_giay_uy_quyen_so.Text;
            m_us_gd_phong_toa_giai_toa.strNGUOI_XAC_NHAN = m_txt_nguoi_xac_nhan.Text;
            m_us_gd_phong_toa_giai_toa.strCHUC_VU = m_txt_chuc_vu.Text;
            m_us_gd_phong_toa_giai_toa.dcTY_LE_PHI_GD = CIPConvert.ToDecimal(m_txt_ty_le_phi_gd.Text)/100;
            m_us_gd_phong_toa_giai_toa.dcPHI_GIAO_DICH = CIPConvert.ToDecimal(m_txt_phi_gd.Text);
            m_us_gd_phong_toa_giai_toa.strNDD_FAX = m_txt_fax.Text;
            m_us_gd_phong_toa_giai_toa.strNDD_DIEN_THOAI = m_txt_dien_thoai.Text;
            m_us_gd_phong_toa_giai_toa.strNDD_TRU_SO = m_txt_tru_so_chinh.Text;
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_PHONG_TOA:
                case eFormMode.DUYET_PHONG_TOA:
                case eFormMode.SUA_PHONG_TOA:
                    m_us_gd_phong_toa_giai_toa.strNGAN_HANG_CAM_CO = m_txt_ngan_hang_cam_co.Text;
                    break;
                case eFormMode.LAP_GIAI_TOA:
                case eFormMode.DUYET_GIAI_TOA:
                case eFormMode.SUA_GIAI_TOA:
                    m_us_gd_phong_toa_giai_toa.strNGAN_HANG_CAM_CO = CIPConvert.ToStr(m_cbo_ngan_hang_cam_co.SelectedValue);
                    break;
            }
            m_us_gd_phong_toa_giai_toa.strKHOAN_DAU_TU = m_txt_khoan_dau_tu.Text;
        }
        private void lap_giao_dich_phong_toa_giai_toa()
        {
            form_2_us_gd_phong_toa_giai_toa();
            // m_us_gd_phong_toa_giai_toa.CapNhatSoDuTraiPhieuPhongGiaiToan(m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH, m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU, 0, m_us_gd_phong_toa_giai_toa.dcSO_LUONG);
            m_us_gd_phong_toa_giai_toa.Insert();
            ghi_log_he_thong();
        }
        private void export_word()
        {
            CWordReport v_obj_export_word = new CWordReport("f700_ĐLĐKLK_Giay De Nghi Phong Toa TP.doc");
            v_obj_export_word.AddFindAndReplace("<TEN_NGAN_HANG>", m_txt_ngan_hang_cam_co.Text);
            v_obj_export_word.AddFindAndReplace("<TEN_KHACH_HANG>", m_txt_ten_khach_hang.Text);
            v_obj_export_word.AddFindAndReplace("<SO_CMND>", m_txt_so_cmnd_dkkd.Text);
            v_obj_export_word.AddFindAndReplace("<TC_CAP_CMND>", m_txt_noi_cap.Text);
            v_obj_export_word.AddFindAndReplace("<NGAY_CAP>", m_txt_ngay_cap.Text);
            v_obj_export_word.AddFindAndReplace("<NGUOI_DAI_DIEN>", m_txt_nguoi_dai_dien.Text);
            v_obj_export_word.AddFindAndReplace("<CHUC_DANH_DAI_DIEN>", m_txt_chuc_danh.Text);
            v_obj_export_word.AddFindAndReplace("<TRU_SO_CHINH_DAI_DIEN>", m_txt_tru_so_chinh.Text);
            v_obj_export_word.AddFindAndReplace("<DIEN_THOAI_DAI_DIEN>", m_txt_dien_thoai.Text);
            v_obj_export_word.AddFindAndReplace("<SO_FAX>", m_txt_fax.Text);
            v_obj_export_word.AddFindAndReplace("<MA_SO_DAU_TU>", m_txt_ma_so_trai_phieu.Text);
            v_obj_export_word.AddFindAndReplace("<MA_SO_TP>", m_txt_ma_so_trai_phieu.Text);
            v_obj_export_word.AddFindAndReplace("<TO_CHUC_PHAT_HANH>", m_txt_to_chuc_phat_hanh.Text);
            v_obj_export_word.AddFindAndReplace("<TONG_SO_LUONG_TRAI_PHIEU>", m_txt_menh_gia.Text);
            v_obj_export_word.AddFindAndReplace("<TONG_GIA_TRI_THEO_MENH_GIA>", m_txt_tong_gia_tri.Text);
            v_obj_export_word.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_export_word.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_export_word.AddFindAndReplace("<LAI_SUAT>", m_txt_lai_suat.Text);
            v_obj_export_word.AddFindAndReplace("<HINH_THUC_TRA_LAI>", m_txt_hinh_thuc_tra_lai.Text);
            v_obj_export_word.AddFindAndReplace("<MA_TRAI_PHIEU>", m_txt_ma_so_trai_phieu.Text);
            v_obj_export_word.AddFindAndReplace("<NGUOI_XAC_NHAN>", m_txt_nguoi_xac_nhan.Text);
            v_obj_export_word.AddFindAndReplace("<CHUC_VU>", m_txt_chuc_vu.Text);
            v_obj_export_word.AddFindAndReplace("<SO_UY_QUYEN>", m_txt_theo_giay_uy_quyen_so.Text);
            v_obj_export_word.AddFindAndReplace("<NGAY_UY_QUYEN>", m_dat_ngay.Value.Date.ToString());
            v_obj_export_word.AddFindAndReplace("<DON_VI_UY_QUYEN>", m_txt_cua.Text);
            v_obj_export_word.AddFindAndReplace("<MENH_GIA_TRAI_PHIEU>", m_txt_menh_gia.Text);
            v_obj_export_word.AddFindAndReplace("<LOAI_PHONG_TOA>", "");
            v_obj_export_word.Export2Word(true);

        }
        private void save_data()
        {
            if (check_thong_tin_chuyen_nhuong_is_ok() == false) return;
            form_2_us_gd_phong_toa_giai_toa();
            m_us_gd_phong_toa_giai_toa.Update();
            ghi_log_he_thong();
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }
        //private string sinh_ma_giao_dich()
        //{
        //    string v_str_ma_tu_sinh = "CN_" + m_us_v_trai_phieu.strMA_TRAI_PHIEU + "_";
        //    US_V_GD_CHUYEN_NHUONG v_us_gd_chuyen_nhuong = new US_V_GD_CHUYEN_NHUONG();
        //    DS_V_GD_CHUYEN_NHUONG v_ds_gd_chuyen_nhuong = new DS_V_GD_CHUYEN_NHUONG();
        //    v_us_gd_chuyen_nhuong.FillDataset(v_ds_gd_chuyen_nhuong, " WHERE ID = (SELECT MAX(ID) FROM GD_CHUYEN_NHUONG)");
        //    if (v_ds_gd_chuyen_nhuong.V_GD_CHUYEN_NHUONG.Rows.Count == 0)
        //        v_str_ma_tu_sinh += "00001";
        //    else
        //    {
        //        decimal v_dc_stt = CIPConvert.ToDecimal(CIPConvert.ToStr(v_ds_gd_chuyen_nhuong.V_GD_CHUYEN_NHUONG.Rows[0][GD_CHUYEN_NHUONG.ID])) + 1;
        //        v_str_ma_tu_sinh += v_dc_stt.ToString("00000");
        //    }
        //    return v_str_ma_tu_sinh;
        //}
        #endregion

        #region Events

        private void set_define_events()
        {
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
            m_cmd_lap.Click += new EventHandler(m_cmd_lap_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_print.Click += new EventHandler(m_cmd_print_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            //  m_txt_ty_le_phi_gd.TextChanged += new EventHandler(m_txt_ty_le_phi_gd_TextChanged);
            m_txt_so_luong_tp_cam_co.TextChanged += new EventHandler(m_txt_so_luong_tp_cam_co_TextChanged);
            m_txt_ty_le_phi_gd.LostFocus += new EventHandler(m_txt_ty_le_phi_gd_LostFocus);
            m_txt_so_luong_tp_cam_co.LostFocus += new EventHandler(m_txt_so_luong_tp_cam_co_LostFocus);
            this.KeyDown += new KeyEventHandler(f700_giao_dich_phong_toa_giai_toa_KeyDown);
            m_txt_phi_gd.Leave += new EventHandler(m_txt_phi_gd_Leave);           
        }


        void m_txt_phi_gd_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_phi_gd.Text.Trim().Equals("")) return;
                if (!CValidateTextBox.IsValid(m_txt_phi_gd, DataType.NumberType, allowNull.NO, true))
                {
                    BaseMessages.MsgBox_Infor(12); // dữ liệu phải là số
                    return;
                }
                decimal temp = CIPConvert.ToDecimal(m_txt_phi_gd.Text);
                if (temp == 0) m_txt_phi_gd.Text = "0";
                else m_txt_phi_gd.Text = CIPConvert.ToStr(temp, "#,###");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        void f700_giao_dich_phong_toa_giai_toa_KeyDown(object sender, KeyEventArgs e)
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
        private void m_cmd_chon_trai_chu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_chu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f700_giao_dich_phong_toa_giai_toa_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_print_Click(object sender, EventArgs e)
        {
            try
            {
                switch (m_e_form_mode)
                {
                    case eFormMode.LAP_GIAI_TOA:

                        break;
                    case eFormMode.LAP_PHONG_TOA:
                        export_word();
                        break;

                    default:
                        break;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_lap_Click(object sender, EventArgs e)
        {
            if (!check_thong_tin_chuyen_nhuong_is_ok())
            {
                return;
            }
            try
            {
                lap_giao_dich_phong_toa_giai_toa();
                BaseMessages.MsgBox_Infor(10);
                this.Close();
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
                form_2_us_gd_phong_toa_giai_toa();
                if (m_us_gd_phong_toa_giai_toa.dcID_TRANG_THAI == ID_TRANG_THAI_PGT.DA_DUYET)
                {
                    BaseMessages.MsgBox_Infor("Cập nhật không thành công do giao dịch này đã được duyệt rồi, hãy chọn giao dịch khác");
                    return;
                }
                try
                {
                    m_us_gd_phong_toa_giai_toa.BeginTransaction();
                    if (m_e_form_mode == eFormMode.DUYET_PHONG_TOA)
                        m_us_gd_phong_toa_giai_toa.CapNhatSoDuTraiPhieuPhongGiaiToan(m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH, m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU, 0, -m_us_gd_phong_toa_giai_toa.dcSO_LUONG);
                    else
                        m_us_gd_phong_toa_giai_toa.CapNhatSoDuTraiPhieuPhongGiaiToan(m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH, m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU, 0, m_us_gd_phong_toa_giai_toa.dcSO_LUONG);
                    m_us_gd_phong_toa_giai_toa.duyet_giao_dich_pgt(m_us_gd_phong_toa_giai_toa.dcID_NGUOI_DUYET);
                    m_us_gd_phong_toa_giai_toa.CommitTransaction();
                    ghi_log_he_thong();
                    BaseMessages.MsgBox_Infor(10);
                    this.Close();
                }
                catch (Exception v_e)
                {
                    m_us_gd_phong_toa_giai_toa.Rollback();
                    throw v_e;
                }


            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_so_luong_tp_cam_co_TextChanged(object sender, EventArgs e)
        {
            if (m_txt_ma_trai_chu.Text == "") return;
            if (!CValidateTextBox.IsValid(m_txt_so_luong_tp_cam_co, DataType.NumberType, allowNull.YES))
            {
                //MessageBox.Show("Số lượng trái phiếu cầm cố nhập không đúng.\n Mời nhập lại!", "Cảnh báo");
                m_txt_so_luong_tp_cam_co.Text = "";
                m_txt_so_luong_tp_cam_co.Focus();
                return;
            }
            if (m_txt_so_luong_tp_cam_co.Text != "")
            {
                m_txt_tong_gia_tri.Text = CIPConvert.ToStr((CIPConvert.ToDecimal(m_txt_menh_gia.Text) * CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text)), "#,###");
                return;
                //if(m_txt_ty_le_phi_gd.Text != "") phi_giao_dich_pgt_change();
            }
        }
        private void phi_giao_dich_pgt_change()
        {
            decimal v_phi_gd = CIPConvert.ToDecimal((Convert.ToDouble(m_txt_ty_le_phi_gd.Text)) * (Convert.ToDouble(m_txt_tong_gia_tri.Text))) / 100;
            if (kiem_tra_phi_gd(v_phi_gd))
            {
                m_txt_phi_gd.Text = CIPConvert.ToStr(v_phi_gd, "#,###");
            }
            return;
        }
        private void m_txt_so_luong_tp_cam_co_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_so_luong_tp_cam_co.Text != "")
                {

                    if (m_txt_ty_le_phi_gd.Text != "") phi_giao_dich_pgt_change();
                    if (m_e_form_mode == eFormMode.LAP_GIAI_TOA)
                    {
                        if (CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text) > CIPConvert.ToDecimal(m_txt_so_luong_kha_dung.Text))
                        {
                            MessageBox.Show("Số lượng trái phiếu giải tỏa cần bé hơn số lượng trái phiếu đã phong tỏa.");
                            m_txt_so_luong_kha_dung.Text = "";
                            return;
                        }
                    }
                    if (m_e_form_mode == eFormMode.LAP_PHONG_TOA)
                    {
                        if (CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text) > CIPConvert.ToDecimal(m_txt_so_luong_kha_dung.Text))
                        {
                            MessageBox.Show("Số lượng trái phiếu phong tỏa cần bé hơn số lượng trái phiếu khả dụng.");
                            m_txt_so_luong_kha_dung.Text = "";
                            //m_txt_so_luong_tp_cam_co.Focus();
                            return;

                        }
                    }
                }

            }
            //catch (FormatException)
            //{
            //    MessageBox.Show("Nhập sai kiểu dữ liệu. Tỷ lệ phí giao dịch phải là số!");
            //}
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return;
            }
        }
        private void m_txt_ty_le_phi_gd_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tong_gia_tri.Text == "")
                {
                    m_txt_phi_gd.Text = "0";
                    return;
                }
                if (!CValidateTextBox.IsValid(m_txt_ty_le_phi_gd, DataType.NumberType, allowNull.YES))
                {
                    MessageBox.Show("Cảnh báo", "Nhập sai định dạng tỷ lệ phí giao dịch.\n Mời nhập lại!");
                    m_txt_ty_le_phi_gd.Focus();
                }
                else phi_giao_dich_pgt_change();

            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu. Tỷ lệ phí giao dịch phải là số!");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
                return;
            }
        }

        #endregion
    }
}

