
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
using BondUS;

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
            m_lbl_title.Text = "LẬP GIAO DỊCH PHONG TỎA";
            this.ShowDialog();
        }
        public void display_giai_toa()
        {
            m_e_form_mode = eFormMode.LAP_GIAI_TOA;
           
            this.Text = "F700 - Lập Giao dịch giải tỏa";
            m_lbl_title.Text = "LẬP GIAO DỊCH GIẢI TỎA";
            this.ShowDialog();
        }
        public void display_duyet_phong_toa(US_GD_PHONG_GIAI_TOA ip_us_phong_giai_toa)
        {
            m_e_form_mode = eFormMode.DUYET_PHONG_TOA;
            m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            this.Text = "F700 - Duyệt Giao dịch phong tỏa";
            m_lbl_title.Text = "DUYỆT GIAO DỊCH PHONG TỎA";
            this.ShowDialog();        
        }
        public void display_duyet_giai_toa(US_GD_PHONG_GIAI_TOA ip_us_phong_giai_toa)
        {
            m_e_form_mode = eFormMode.DUYET_GIAI_TOA;
            m_us_gd_phong_toa_giai_toa = ip_us_phong_giai_toa;
            this.Text = "F700 - Duyệt Giao dịch giải tỏa";
            m_lbl_title.Text = "DUYỆT GIAO DỊCH GIẢI TỎA";
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
            , DUYET_PHONG_TOA
            , DUYET_GIAI_TOA
        }
        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        US_CM_DM_LOAI_TD m_us_cm_dm_loai_tu_dien = new US_CM_DM_LOAI_TD();
        US_GD_PHONG_GIAI_TOA m_us_gd_phong_toa_giai_toa = new US_GD_PHONG_GIAI_TOA();
        DS_GD_PHONG_GIAI_TOA m_ds_gd_phong_toa_giai_toa = new DS_GD_PHONG_GIAI_TOA();
        eFormMode m_e_form_mode = eFormMode.LAP_PHONG_TOA;
        #endregion

        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);

            set_define_events();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
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
          
            if (!CValidateTextBox.IsValid(m_txt_ngan_hang_cam_co, DataType.StringType, allowNull.NO))
            {
                m_txt_ngan_hang_cam_co.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_nguoi_xac_nhan, DataType.StringType, allowNull.NO))
            {
                m_txt_nguoi_xac_nhan.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_chuc_vu, DataType.StringType, allowNull.NO))
            {
                m_txt_chuc_vu.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_theo_giay_uy_quyen_so, DataType.StringType, allowNull.NO))
            {
                m_txt_theo_giay_uy_quyen_so.Focus();
                return false;
            }
       
            if (!CValidateTextBox.IsValid(m_txt_cua, DataType.StringType, allowNull.NO))
            {
                m_txt_cua.Focus();
                return false;
            }

            return true;
        }
       
        
        private void set_inital_form_load()
        {

            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:
                case eFormMode.LAP_PHONG_TOA:
                    m_cmd_lap.Enabled = true;
                    m_cmd_duyet.Enabled = false;
                    break;
                case eFormMode.DUYET_GIAI_TOA:
                case eFormMode.DUYET_PHONG_TOA:
                    m_cmd_lap.Enabled = false;
                    m_cmd_duyet.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void select_trai_chu()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            m_us_trai_chu = v_frm500.select_trai_chu_of_trai_phieu(null);
            if (m_us_trai_chu.IsIDNull()) return;
            us_trai_chu_2_form(m_us_trai_chu);
            m_txt_nguoi_dai_dien.Focus();
        }
        private void us_trai_chu_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            if (ip_us_trai_chu.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us = new US_GD_SO_DU_TRAI_PHIEU();
            v_us.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu.dcID, v_ds);
            m_us_trai_phieu = new US_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);
            m_txt_ma_trai_chu.Text = ip_us_trai_chu.strMA_TRAI_CHU;
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_txt_ngay_cap.Text = ip_us_trai_chu.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            m_txt_so_luong_trai_phieu.Text = v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["TONG_SO_DU"].ToString();
            m_txt_so_luong_kha_dung.Text = v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["SO_DU_KHA_DUNG"].ToString();
            us_trai_phieu_2_form(m_us_trai_phieu);
            
        }
        private void us_trai_phieu_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
          
            m_txt_ma_so_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_to_chuc_phat_hanh.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr( ip_us_trai_phieu.dcMENH_GIA, "#,###");
           
            m_txt_ngay_phat_hanh.Text = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH.ToString("dd/MM/yyyy");
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN,"dd/MM/yyyy");
            m_txt_lai_suat.Text = CIPConvert.ToStr( ip_us_trai_phieu.dcLAI_SUAT_DEFAULT, "p");
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
        }
        private void from_2_us_gd_phong_toa_giai_toa()
        {
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_GIAI_TOA:
                    m_us_gd_phong_toa_giai_toa.strPHONG_TOA_YN = "N";
                    m_us_gd_phong_toa_giai_toa.dcSO_LUONG = CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text);
                    m_us_gd_phong_toa_giai_toa.SetID_NGUOI_DUYETNull();
                    m_us_gd_phong_toa_giai_toa.dcID_NGUOI_LAP = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
                    break;
                case eFormMode.LAP_PHONG_TOA:
                    m_us_gd_phong_toa_giai_toa.strPHONG_TOA_YN = "Y";
                    m_us_gd_phong_toa_giai_toa.dcSO_LUONG = -CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text);
                    m_us_gd_phong_toa_giai_toa.SetID_NGUOI_DUYETNull();
                    m_us_gd_phong_toa_giai_toa.dcID_NGUOI_LAP = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
                    break;
                case eFormMode.DUYET_PHONG_TOA:
                    m_us_gd_phong_toa_giai_toa.dcID_NGUOI_DUYET = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
                    m_us_gd_phong_toa_giai_toa.SetID_NGUOI_LAPNull();
                    break;
                case eFormMode.DUYET_GIAI_TOA:
                    m_us_gd_phong_toa_giai_toa.dcID_NGUOI_DUYET = IP.Core.IPSystemAdmin.CAppContext_201.getCurrentUserID();
                    m_us_gd_phong_toa_giai_toa.SetID_NGUOI_LAPNull();
                    break;
                default: break;

            }
            m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU = m_us_trai_chu.dcID;
            m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH = m_dat_ngay.Value.Date;
            m_us_gd_phong_toa_giai_toa.strNGUOI_DAI_DIEN = m_txt_nguoi_dai_dien.Text;
            m_us_gd_phong_toa_giai_toa.strCHUC_DANH = m_txt_chuc_danh.Text;   
            m_us_gd_phong_toa_giai_toa.dcID_TRANG_THAI = 0;
            m_us_gd_phong_toa_giai_toa.strCUA = m_txt_cua.Text;
            m_us_gd_phong_toa_giai_toa.datNGAY_CAP_GIAY_UQ = m_dat_ngay_cap_giay_uq.Value.Date;
            m_us_gd_phong_toa_giai_toa.strGIAY_UQ = m_txt_theo_giay_uy_quyen_so.Text;
            m_us_gd_phong_toa_giai_toa.strNGUOI_XAC_NHAN = m_txt_nguoi_xac_nhan.Text;
            m_us_gd_phong_toa_giai_toa.strCHUC_VU = m_txt_chuc_vu.Text;


        }
        private void lap_giao_dich_phong_toa_giai_toa()
        {
            from_2_us_gd_phong_toa_giai_toa();
           // m_us_gd_phong_toa_giai_toa.CapNhatSoDuTraiPhieuPhongGiaiToan(m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH, m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU, 0, m_us_gd_phong_toa_giai_toa.dcSO_LUONG);
            m_us_gd_phong_toa_giai_toa.Insert();
           
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
            v_obj_export_word.AddFindAndReplace("<LOAI_PHONG_TOA>","");            
            v_obj_export_word.Export2Word(true);
         
        }
        #endregion

        private void set_define_events()
        {
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
            m_cmd_lap.Click += new EventHandler(m_cmd_lap_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_print.Click += new EventHandler(m_cmd_print_Click);
        }
        void m_cmd_exit_Click(object sender, EventArgs e)
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
        void m_cmd_chon_trai_chu_Click(object sender, EventArgs e)
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
        void m_cmd_lap_Click(object sender, EventArgs e)
        {
            if (!check_thong_tin_chuyen_nhuong_is_ok())
            {
                return;
            }
            try
            {
                lap_giao_dich_phong_toa_giai_toa();
                BaseMessages.MsgBox_Infor(10); 
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
                from_2_us_gd_phong_toa_giai_toa();
                m_us_gd_phong_toa_giai_toa.CapNhatSoDuTraiPhieuPhongGiaiToan(m_us_gd_phong_toa_giai_toa.datNGAY_GIAO_DICH, m_us_gd_phong_toa_giai_toa.dcID_TRAI_CHU, 0, m_us_gd_phong_toa_giai_toa.dcSO_LUONG);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_so_luong_tp_cam_co_TextChanged(object sender, EventArgs e)
        {
            m_txt_tong_gia_tri.Text = CIPConvert.ToStr((CIPConvert.ToDecimal(m_txt_menh_gia.Text) * CIPConvert.ToDecimal(m_txt_so_luong_tp_cam_co.Text)),"#,###");
        }
    }
}

