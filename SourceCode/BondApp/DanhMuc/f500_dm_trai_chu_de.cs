    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BondUS;
using IP.Core.IPCommon;
using BondDS;
using IP.Core.IPUserService;
using IP.Core.IPData;
using BondDS.CDBNames;
using IP.Core.IPSystemAdmin;
using BondUS;

namespace BondApp.DanhMuc
{
    public partial class f500_dm_trai_chu_de : Form
    {
        public f500_dm_trai_chu_de()
        {
            InitializeComponent();
            format_control();
        }

        #region Public interface
        public void display_for_insert()
        {
            m_e_form_mode = e_formmode.HIEN_THI_DE_THEM;
            this.ShowDialog();
        }

        public void display_for_update(US_V_DM_TRAI_CHU ip_us_v_trai_chu)
        {
            m_e_form_mode = e_formmode.HIEN_THI_DE_SUA;
            m_us_v_trai_chu = ip_us_v_trai_chu;
            this.ShowDialog();
        }

        public void display_for_duyet(US_V_DM_TRAI_CHU ip_us_v_trai_chu)
        {
            m_e_form_mode = e_formmode.HIEN_THI_DE_DUYET;
            m_us_v_trai_chu = ip_us_v_trai_chu;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_formmode
        {
            HIEN_THI_DE_THEM = 0
           , HIEN_THI_DE_SUA = 1
           , HIEN_THI_DE_DUYET = 2
        }
        #endregion

        #region Members
        US_V_DM_TRAI_CHU m_us_v_trai_chu = new US_V_DM_TRAI_CHU();
        DS_V_DM_TRAI_CHU m_ds_v_trai_chu = new DS_V_DM_TRAI_CHU();
        //US_DM_TRAI_PHIEU m_us_trai_phieu;
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu;
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        DS_DM_TRAI_CHU m_ds_trai_chu = new DS_DM_TRAI_CHU();
        US_GD_SO_DU_TRAI_PHIEU m_us_gd_so_du_trai_phieu;
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        e_formmode m_e_form_mode = e_formmode.HIEN_THI_DE_THEM;
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            set_define_event();
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU;
            
            /* Thông tin riêng*/
            switch (m_e_form_mode)
            {
                case e_formmode.HIEN_THI_DE_THEM:
                    DS_V_DM_TRAI_CHU v_ds_dm_trai_chu = new DS_V_DM_TRAI_CHU();
                    m_us_v_trai_chu.FillDataset(v_ds_dm_trai_chu, " WHERE ID = (SELECT MAX(ID) FROM DM_TRAI_CHU)");
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.THEM;
                    if (v_ds_dm_trai_chu.V_DM_TRAI_CHU.Rows.Count > 0)
                        m_us_v_ht_log_truy_cap.strMO_TA = "Thêm " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU + ": " + CIPConvert.ToStr(v_ds_dm_trai_chu.V_DM_TRAI_CHU.Rows[0][V_DM_TRAI_CHU.TEN_TRAI_CHU]) + " sở hữu trái phiếu: " + CIPConvert.ToStr(v_ds_dm_trai_chu.V_DM_TRAI_CHU.Rows[0][V_DM_TRAI_CHU.TEN_TRAI_PHIEU]);
                    break;
                case e_formmode.HIEN_THI_DE_SUA:
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Cập nhật thông tin " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU + ": " + m_us_v_trai_chu.strTEN_TRAI_CHU + " sở hữu trái phiếu: " + m_us_v_trai_chu.strTEN_TRAI_PHIEU;
                    break;
                case e_formmode.HIEN_THI_DE_DUYET:
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.DUYET;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Duyệt thông tin " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_CHU + ": " + m_us_v_trai_chu.strTEN_TRAI_CHU + " sở hữu trái phiếu: " + m_us_v_trai_chu.strTEN_TRAI_PHIEU;
                    break;
                default:
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
        private void set_inital_form_load()
        {
            load_data_2_cbo();

            switch (m_e_form_mode)
            {
                case e_formmode.HIEN_THI_DE_THEM:
                    m_lbl_so_kha_dung.Visible = false;
                    m_lbl_so_luong_phong_toa.Visible = false;
                    m_txt_so_du_kha_dung.Visible = false;
                    m_txt_sl_da_phong_toa.Visible = false;
                    break;
                case e_formmode.HIEN_THI_DE_SUA:
                    us_object_2_form(m_us_v_trai_chu);                    
                    break;
                case e_formmode.HIEN_THI_DE_DUYET:                    
                    m_cmd_save.Visible = false;
                    m_cmd_duyet.Visible = true;
                    m_lbl_ngay_duyet_lbl.Visible = true;
                    m_dat_ngay_duyet.Visible = true;
                    //m_lbl_duyet_ghi_chu.Visible = true;
                    us_object_2_form(m_us_v_trai_chu);
                    break;
            }
        }

        private void load_data_2_cbo()
        {
            m_ds_cm_dm_tu_dien = m_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.TRANG_THAI_DANH_MUC);
            m_cbo_trang_thai.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;

            m_ds_cm_dm_tu_dien = m_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.LOAI_TRAI_CHU);
            m_cbo_loai_trai_chu.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_trai_chu.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_trai_chu.ValueMember = CM_DM_TU_DIEN.ID;
        }

        private void us_object_2_form(US_V_DM_TRAI_CHU ip_us_trai_chu)
        {
            m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);

            m_txt_ma_trai_chu.Text = ip_us_trai_chu.strMA_TRAI_CHU;
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_cbo_loai_trai_chu.SelectedValue = CIPConvert.ToStr(ip_us_trai_chu.dcID_LOAI_TRAI_CHU);
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_dat_ngay_cap.Value = ip_us_trai_chu.datNGAY_CAP_CMT;
            m_txt_dia_chi.Text = ip_us_trai_chu.strDIA_CHI;
            m_txt_dien_thoai.Text = ip_us_trai_chu.strMOBILE;
            m_txt_fax.Text = ip_us_trai_chu.strFAX;
            m_txt_tai_khoan.Text = ip_us_trai_chu.strSO_TAI_KHOAN;
            m_txt_mo_tai_ngan_hang.Text = ip_us_trai_chu.strMO_TAI_NGAN_HANG;

            m_txt_nguoi_dai_dien.Text = ip_us_trai_chu.strTEN_NGUOI_DAI_DIEN;
            m_txt_chuc_vu.Text = ip_us_trai_chu.strCHUC_VU;
            m_txt_cmt_nguoi_dai_dien.Text = ip_us_trai_chu.strCMT_NGUOI_DAI_DIEN;
            m_dat_ngay_cap_cmt_nguoi_dai_dien.Value = ip_us_trai_chu.datNGAY_CAP_CMT_NGUOI_DAI_DIEN;
            m_txt_noi_cap_cmt_nguoi_dai_dien.Text = ip_us_trai_chu.strNOI_CAP_CMT_NGUOI_DAI_DIEN;

            m_txt_id_trai_phieu_so_huu.Text = ip_us_trai_chu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_chu.strTEN_TRAI_PHIEU;
            m_txt_so_du_kha_dung.Text = CIPConvert.ToStr(ip_us_trai_chu.dcSO_DU_KHA_DUNG, "#,###");
            m_txt_sl_da_phong_toa.Text = CIPConvert.ToStr(ip_us_trai_chu.dcTONG_SO_DU - ip_us_trai_chu.dcSO_DU_KHA_DUNG, "#,###");
            m_txt_so_trai_phieu_so_huu.Text = CIPConvert.ToStr(ip_us_trai_chu.dcTONG_SO_DU, "#,###");

            m_txt_ghi_chu_1.Text = ip_us_trai_chu.strGHI_CHU1;
            m_txt_ghi_chu_2.Text = ip_us_trai_chu.strGHI_CHU2;
            m_txt_ghi_chu_3.Text = ip_us_trai_chu.strGHI_CHU3;
            m_cbo_trang_thai.SelectedValue = CIPConvert.ToStr(ip_us_trai_chu.dcID_TRANG_THAI);
            if (ip_us_trai_chu.dcID_TRANG_THAI == TRANG_THAI_DANH_MUC.DA_LAP)
            {
                m_txt_so_trai_phieu_so_huu.Text = CIPConvert.ToStr(ip_us_trai_chu.dcSO_LUONG_TP_SO_HUU_BAN_DAU, "#,###");
                m_txt_so_du_kha_dung.Text = CIPConvert.ToStr(ip_us_trai_chu.dcSO_LUONG_TP_SO_HUU_BAN_DAU, "#,###");
                m_txt_sl_da_phong_toa.Text = CIPConvert.ToStr(0);
            }
            if (ip_us_trai_chu.dcID_TRANG_THAI == TRANG_THAI_DANH_MUC.DA_DUYET)
            {
                m_txt_id_trai_phieu_so_huu.ReadOnly = true;
                m_cmd_select_trai_phieu.Enabled = false;
                m_txt_so_trai_phieu_so_huu.ReadOnly = true;
            }
        }

        private void form_2_us_object(US_V_DM_TRAI_CHU ip_us_trai_chu)
        {
            ip_us_trai_chu.strMA_TRAI_CHU = m_txt_ma_trai_chu.Text;
            ip_us_trai_chu.strTEN_TRAI_CHU = m_txt_ten_khach_hang.Text;
            ip_us_trai_chu.dcID_LOAI_TRAI_CHU = CIPConvert.ToDecimal(m_cbo_loai_trai_chu.SelectedValue);
            ip_us_trai_chu.strCMT_GIAY_DKKD = m_txt_so_cmnd_dkkd.Text;
            ip_us_trai_chu.strNOI_CAP_CMT = m_txt_noi_cap.Text;
            ip_us_trai_chu.datNGAY_CAP_CMT = m_dat_ngay_cap.Value;
            ip_us_trai_chu.strDIA_CHI = m_txt_dia_chi.Text;
            ip_us_trai_chu.strMOBILE = m_txt_dien_thoai.Text;
            ip_us_trai_chu.strFAX = m_txt_fax.Text;
            
            ip_us_trai_chu.strSO_TAI_KHOAN = m_txt_tai_khoan.Text;
            ip_us_trai_chu.strMO_TAI_NGAN_HANG = m_txt_mo_tai_ngan_hang.Text;

            ip_us_trai_chu.strTEN_NGUOI_DAI_DIEN = m_txt_nguoi_dai_dien.Text;
            ip_us_trai_chu.strCHUC_VU = m_txt_chuc_vu.Text;
            ip_us_trai_chu.strCMT_NGUOI_DAI_DIEN = m_txt_cmt_nguoi_dai_dien.Text;
            ip_us_trai_chu.datNGAY_CAP_CMT_NGUOI_DAI_DIEN = m_dat_ngay_cap_cmt_nguoi_dai_dien.Value;
            ip_us_trai_chu.strNOI_CAP_CMT_NGUOI_DAI_DIEN = m_txt_noi_cap_cmt_nguoi_dai_dien.Text;

            ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU = m_us_v_trai_phieu.dcID;
            ip_us_trai_chu.dcSO_LUONG_TP_SO_HUU_BAN_DAU = CIPConvert.ToDecimal(m_txt_so_trai_phieu_so_huu.Text);

            ip_us_trai_chu.strGHI_CHU1 = m_txt_ghi_chu_1.Text;
            ip_us_trai_chu.strGHI_CHU2 = m_txt_ghi_chu_2.Text;
            ip_us_trai_chu.SetGHI_CHU3Null();
        }

        private void form_2_us_gd_so_du_trai_phieu()
        {
            m_us_gd_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
            US_DM_TRAI_CHU v_us = new US_DM_TRAI_CHU();
            v_us.FillDatasetByMaTraiChu(m_ds_trai_chu, m_us_v_trai_chu.strMA_TRAI_CHU);
            m_us_gd_so_du_trai_phieu.dcID_TRAI_CHU = CIPConvert.ToDecimal(m_ds_trai_chu.DM_TRAI_CHU.Rows[0]["ID"]);
            m_us_gd_so_du_trai_phieu.dcTONG_SO_DU = CIPConvert.ToDecimal(m_txt_so_trai_phieu_so_huu.Text);
            m_us_gd_so_du_trai_phieu.dcSO_DU_KHA_DUNG = CIPConvert.ToDecimal(m_txt_so_trai_phieu_so_huu.Text);
            m_us_gd_so_du_trai_phieu.datNGAY = DateTime.Now;
        }

        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_chu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten_khach_hang, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_cmnd_dkkd, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_cap, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.YES, true))
            {
                return false;
            } if (!CValidateTextBox.IsValid(m_txt_dien_thoai, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_fax, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tai_khoan, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_mo_tai_ngan_hang, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu_1, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu_2, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu_3, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_id_trai_phieu_so_huu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_nguoi_dai_dien, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_chuc_vu, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_cmt_nguoi_dai_dien, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_cap_cmt_nguoi_dai_dien, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_trai_phieu_so_huu, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }

            if (CIPConvert.ToDecimal(m_txt_so_trai_phieu_so_huu.Text) > m_us_v_trai_phieu.dcTONG_SL_PHAT_HANH )
            {
                BaseMessages.MsgBox_Infor("Số trái phiếu sở hữu không được vượt quá số lượng trái phiếu phát hành!");
                m_txt_so_trai_phieu_so_huu.Focus();
                return false;
            }
            return true;
        }

        private void save_data()
        {
            if (check_data_is_ok() == false)
            {
                return;
            }
            
            form_2_us_object(m_us_v_trai_chu);
            switch (m_e_form_mode)
            {
                case e_formmode.HIEN_THI_DE_THEM:
                    m_us_v_trai_chu.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_LAP;
                    m_us_v_trai_chu.dcID_NGUOI_LAP_TC = CAppContext_201.getCurrentUserID();
                    m_us_v_trai_chu.SetID_NGUOI_DUYET_TCNull();
                    m_us_v_trai_chu.Insert();
                    break;
                case e_formmode.HIEN_THI_DE_SUA:
                    //m_us_trai_chu.dcID = m_us_v_trai_chu.dcID;
                    m_us_v_trai_chu.SetID_NGUOI_DUYET_TCNull();
                    //form_2_us_gd_so_du_trai_phieu();
                    m_us_v_trai_chu.Update();
                    break;
                case e_formmode.HIEN_THI_DE_DUYET:
                    m_us_v_trai_chu.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_DUYET;
                    m_us_v_trai_chu.dcID_NGUOI_DUYET_TC = CAppContext_201.getCurrentUserID();
                    m_us_v_trai_chu.datNGAY_DUYET = m_dat_ngay_duyet.Value;
                    m_us_v_trai_chu.Update();
                    break;
            }
            ghi_log_he_thong();
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_v_trai_phieu.IsIDNull())
            {
                m_txt_id_trai_phieu_so_huu.Text = m_us_v_trai_phieu.strMA_TRAI_PHIEU;
                m_txt_ten_trai_phieu.Text = m_us_v_trai_phieu.strTEN_TRAI_PHIEU;
            }
        }

        private void set_define_event()
        {
            this.Load += new EventHandler(f500_dm_trai_chu_de_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_select_trai_phieu.Click += new EventHandler(m_cmd_select_trai_phieu_Click);
            m_cmd_duyet.Click += new EventHandler(m_cmd_duyet_Click);
            this.KeyDown += new KeyEventHandler(f500_dm_trai_chu_de_KeyDown);
        }

        void f500_dm_trai_chu_de_KeyDown(object sender, KeyEventArgs e)
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

        #endregion

        #region Events
        void f500_dm_trai_chu_de_Load(object sender, EventArgs e)
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


        void m_cmd_duyet_Click(object sender, EventArgs e)
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

        void m_cmd_select_trai_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_phieu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_save_Click(object sender, EventArgs e)
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
        #endregion

    }
}
