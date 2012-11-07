using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;


using BondUS;
using BondDS;
using BondDS.CDBNames;
using IP.Core.IPData.DBNames;
using System.Collections;
namespace BondApp.DanhMuc
{
    public partial class f300_dm_trai_phieu_DE : Form
    {
        public f300_dm_trai_phieu_DE()
        {
            InitializeComponent();
            format_controls();
        }
        
        #region Public Interface
        public void display_for_insert()
        {
            m_e_formmode = e_form_mode.THEM_TRAI_PHIEU;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_TRAI_PHIEU ip_us)
        {
            m_e_formmode = e_form_mode.CAP_NHAT_TRAI_PHIEU;
            m_us_trai_phieu = ip_us;
            this.ShowDialog();
        }
        public void display_for_duyet(US_V_DM_TRAI_PHIEU ip_us)
        {
            m_e_formmode = e_form_mode.DUYET_DU_LIEU;
            m_us_trai_phieu = ip_us;
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_V_DM_TRAI_PHIEU m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();
        US_DM_TO_CHUC_PHAT_HANH m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
        US_CM_DM_TU_DIEN m_us_tu_dien = new US_CM_DM_TU_DIEN();
        US_V_DM_DOT_PHAT_HANH m_us_v_dm_dot_phat_hanh = new US_V_DM_DOT_PHAT_HANH();
        DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        e_form_mode m_e_formmode = e_form_mode.VIEW_DU_LIEU;
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        #endregion
        
        #region Data Structures
        public enum e_form_mode { 
            THEM_TRAI_PHIEU = 0
            , CAP_NHAT_TRAI_PHIEU = 1
            , DUYET_DU_LIEU = 2
            , VIEW_DU_LIEU = 3
        }
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
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DM_TRAI_PHIEU;

            /* Thông tin riêng*/
            switch (m_e_formmode)
            {
                case e_form_mode.THEM_TRAI_PHIEU:
                    DS_V_DM_TRAI_PHIEU v_ds_dm_trai_phieu = new DS_V_DM_TRAI_PHIEU();
                    m_us_trai_phieu.FillDataset(v_ds_dm_trai_phieu, " WHERE ID = (SELECT MAX(ID) FROM DM_TRAI_PHIEU)");
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.THEM;
                    if (v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows.Count > 0)
                        m_us_v_ht_log_truy_cap.strMO_TA = "Thêm " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_PHIEU + " mã " + CIPConvert.ToStr(v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows[0][V_DM_TRAI_PHIEU.MA_TRAI_PHIEU]) + " phát hành ngày: " + CIPConvert.ToStr(v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows[0][V_DM_TRAI_PHIEU.NGAY_PHAT_HANH]);
                    break;
                case e_form_mode.CAP_NHAT_TRAI_PHIEU:
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Cập nhật thông tin " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_PHIEU + " mã " + m_us_trai_phieu.strMA_TRAI_PHIEU + " phát hành ngày " + m_us_trai_phieu.datNGAY_PHAT_HANH;
                    break;
                case e_form_mode.DUYET_DU_LIEU:
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.DUYET;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Duyệt thông tin " + LOG_DOI_TUONG_TAC_DONG.DM_TRAI_PHIEU + " mã " + m_us_trai_phieu.strMA_TRAI_PHIEU + " phát hành ngày " + m_us_trai_phieu.datNGAY_PHAT_HANH;
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
        private void us_object_2_form(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            // Thông tin phát hành
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH, "dd/MM/yyyy");
            m_txt_ten_dv_phat_hanh.Text = ip_us_trai_phieu.strTEN_TO_CHUC_PHAT_HANH;
            US_DM_DOT_PHAT_HANH v_dm_dot_ph = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
            if (!v_dm_dot_ph.IsIDNull())
            {
                m_txt_menh_gia.Text = CIPConvert.ToStr(v_dm_dot_ph.dcMENH_GIA, "#,###");
                m_txt_so_luong_phat_hanh.Text = CIPConvert.ToStr(v_dm_dot_ph.dcTONG_SO_LUONG_TRAI_PHIEU, "#,###");
            }
            // Thông tin về HĐ
            m_txt_so_hd.Text = ip_us_trai_phieu.strSO_HOP_DONG_DL_DK_LUU_KY;
            m_dat_ngay_ky_hd.Value = ip_us_trai_phieu.datNGAY_KY_HD;

            // Thông tin cơ bản khác về trái phiếu
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_cbo_loai_trai_phieu.SelectedValue = ip_us_trai_phieu.dcID_LOAI_TRAI_PHIEU;
            m_dat_ngay_dao_han.Value = ip_us_trai_phieu.datNGAY_DAO_HAN;
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_HAN);
            m_cbo_don_vi_ky_han.SelectedValue = ip_us_trai_phieu.dcID_DV_KY_HAN;
            m_txt_tong_sl.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcTONG_SL_PHAT_HANH, "#,###");
            m_txt_tong_gia_tri.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcTONG_GIA_TRI, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcLAI_SUAT_DEFAULT * 100, "#,####0.0000");
            m_txt_ky_tra_lai.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_TRA_LAI);
            m_cbo_dv_tra_lai.SelectedValue = ip_us_trai_phieu.dcID_DV_KY_TRA_LAI;
            m_txt_ky_dieu_chinh_ls.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_DIEU_CHINH_LS);
            m_cbo_dv_dieu_chinh_ls.SelectedValue = ip_us_trai_phieu.dcID_DV_DIEU_CHINH_LS;
            m_cbo_co_so_tinh_lai.SelectedValue = ip_us_trai_phieu.strCO_SO_TINH_LAI;
            if (ip_us_trai_phieu.strTHA_NOI_YN == "Y")
                m_cbo_tha_noi.SelectedIndex = 0;
            else
                m_cbo_tha_noi.SelectedIndex = 1;
            if (ip_us_trai_phieu.strTRA_LAI_SAU_YN == "Y")
                m_cbo_tra_lai_sau.SelectedIndex = 0;
            else
                m_cbo_tra_lai_sau.SelectedIndex = 1;
            m_txt_bien_do_lai.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcBIEN_DO_LAI * 100, "#,##0.0000");
            m_txt_tcph_chuyen_tien_trc.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcSO_NGAY_TCPH_CHUYEN_TIEN_TRUOC);
            if (ip_us_trai_phieu.strNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN.Equals("Y") && ip_us_trai_phieu.strNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN.Equals("Y"))
                m_cbo_ngung_chuyen_nhuong_tu_ngay.SelectedIndex = 1;
            else m_cbo_ngung_chuyen_nhuong_tu_ngay.SelectedIndex = 0;
            if (ip_us_trai_phieu.strCN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN.Equals("Y"))
                m_cbo_chuyen_nhuong_huong_theo.SelectedIndex = 0;
            else m_cbo_chuyen_nhuong_huong_theo.SelectedIndex = 1;
            m_txt_ghi_chu_phuong_thuc_xd_lai_suat.Text = ip_us_trai_phieu.strGHI_CHU_PHUONG_THUC_XD_LAI_SUAT;
        }
        private void form_2_us_object(US_V_DM_TRAI_PHIEU op_us_trai_phieu)
        {
            // Thông tin phát hành
            op_us_trai_phieu.dcMENH_GIA = m_us_v_dm_dot_phat_hanh.dcMENH_GIA;
            
            // Thông tin về HĐ
            op_us_trai_phieu.strSO_HOP_DONG_DL_DK_LUU_KY = m_txt_so_hd.Text;
            op_us_trai_phieu.datNGAY_KY_HD = m_dat_ngay_ky_hd.Value.Date;

            // Thông tin cơ bản khác về trái phiếu
            op_us_trai_phieu.strMA_TRAI_PHIEU = m_txt_ma_trai_phieu.Text.Trim();
            op_us_trai_phieu.strTEN_TRAI_PHIEU = m_txt_ten_trai_phieu.Text.Trim();
            op_us_trai_phieu.dcID_LOAI_TRAI_PHIEU = CIPConvert.ToDecimal(m_cbo_loai_trai_phieu.SelectedValue);
            op_us_trai_phieu.datNGAY_DAO_HAN = m_dat_ngay_dao_han.Value.Date;
            op_us_trai_phieu.dcKY_HAN = CIPConvert.ToDecimal(m_txt_ky_han.Text);
            op_us_trai_phieu.dcID_DV_KY_HAN = CIPConvert.ToDecimal(m_cbo_don_vi_ky_han.SelectedValue);
            op_us_trai_phieu.dcTONG_SL_PHAT_HANH = CIPConvert.ToDecimal(m_txt_tong_sl.Text);
            op_us_trai_phieu.dcLAI_SUAT_DEFAULT = CIPConvert.ToDecimal(m_txt_lai_suat.Text) / 100;
            op_us_trai_phieu.dcKY_TRA_LAI = CIPConvert.ToDecimal(m_txt_ky_tra_lai.Text);
            op_us_trai_phieu.dcID_DV_KY_TRA_LAI = CIPConvert.ToDecimal(m_cbo_dv_tra_lai.SelectedValue);
            op_us_trai_phieu.dcKY_DIEU_CHINH_LS = CIPConvert.ToDecimal(m_txt_ky_dieu_chinh_ls.Text);
            op_us_trai_phieu.dcID_DV_DIEU_CHINH_LS = CIPConvert.ToDecimal(m_cbo_dv_dieu_chinh_ls.SelectedValue);
            op_us_trai_phieu.strCO_SO_TINH_LAI = CIPConvert.ToStr(m_cbo_co_so_tinh_lai.SelectedValue);
            op_us_trai_phieu.dcTONG_GIA_TRI = CIPConvert.ToDecimal(m_txt_tong_gia_tri.Text);
            if (m_cbo_tha_noi.SelectedIndex == 0)
                op_us_trai_phieu.strTHA_NOI_YN = "Y";
            else op_us_trai_phieu.strTHA_NOI_YN = "N";

            if (m_cbo_tra_lai_sau.SelectedIndex == 0)
                op_us_trai_phieu.strTRA_LAI_SAU_YN = "Y";
            else op_us_trai_phieu.strTRA_LAI_SAU_YN = "N";
            if (m_txt_bien_do_lai.Text != "")
                op_us_trai_phieu.dcBIEN_DO_LAI = CIPConvert.ToDecimal(m_txt_bien_do_lai.Text) / 100;
            op_us_trai_phieu.dcSO_NGAY_TCPH_CHUYEN_TIEN_TRUOC = CIPConvert.ToDecimal(m_txt_tcph_chuyen_tien_trc.Text);
            if (m_cbo_ngung_chuyen_nhuong_tu_ngay.SelectedIndex == 1)
            {
                op_us_trai_phieu.strNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN = "Y";
                op_us_trai_phieu.strNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN = "Y";
            }
            else
            {
                op_us_trai_phieu.strNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN = "Y";
                op_us_trai_phieu.strNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN = "N";
            }
            if (m_cbo_chuyen_nhuong_huong_theo.SelectedIndex == 0) op_us_trai_phieu.strCN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN = "Y";
            else op_us_trai_phieu.strCN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN = "N";
            op_us_trai_phieu.strGHI_CHU_PHUONG_THUC_XD_LAI_SUAT = m_txt_ghi_chu_phuong_thuc_xd_lai_suat.Text.Trim();
        }
        //private void form_2_us_object(US_V_DM_TRAI_PHIEU op_us_trai_phieu)
        //{
        //    op_us_trai_phieu.strTEN_TRAI_PHIEU = m_txt_ten_trai_phieu.Text;
        //    op_us_trai_phieu.strMA_TRAI_PHIEU = m_txt_ma_trai_phieu.Text;
        //    op_us_trai_phieu.dcID_LOAI_TRAI_PHIEU = CIPConvert.ToDecimal(m_cbo_loai_trai_phieu.SelectedValue);
        //    op_us_trai_phieu.dcMENH_GIA = CIPConvert.ToDecimal(m_txt_menh_gia.Text);
        //    op_us_trai_phieu.dcKY_HAN = CIPConvert.ToDecimal(m_txt_ky_han.Text);
        //    op_us_trai_phieu.dcID_DV_KY_HAN = CIPConvert.ToDecimal(m_cbo_don_vi_ky_han.SelectedValue);
        //    op_us_trai_phieu.dcLAI_SUAT_DEFAULT = CIPConvert.ToDecimal(m_txt_lai_suat.Text) / 100;
        //    op_us_trai_phieu.dcKY_DIEU_CHINH_LS = CIPConvert.ToDecimal(m_txt_ky_dieu_chinh_ls.Text);
        //    op_us_trai_phieu.dcID_DV_DIEU_CHINH_LS = CIPConvert.ToDecimal(m_cbo_dv_dieu_chinh_ls.SelectedValue);
        //    op_us_trai_phieu.strTHA_NOI_YN = (string)m_cbo_tha_noi.SelectedValue;
        //    op_us_trai_phieu.dcKY_TRA_LAI = CIPConvert.ToDecimal(m_txt_ky_tra_lai.Text);
        //    op_us_trai_phieu.dcID_DV_KY_TRA_LAI = CIPConvert.ToDecimal(m_cbo_dv_tra_lai.SelectedValue);
        //    op_us_trai_phieu.strTRA_LAI_SAU_YN = (string)m_cbo_tra_lai_sau.SelectedValue;
        //    op_us_trai_phieu.datNGAY_DAO_HAN = m_dat_ngay_dao_han.Value.Date;
        //    op_us_trai_phieu.dcTONG_SL_PHAT_HANH = CIPConvert.ToDecimal(m_txt_tong_sl.Text);
        //    op_us_trai_phieu.dcTONG_GIA_TRI = op_us_trai_phieu.dcTONG_SL_PHAT_HANH * op_us_trai_phieu.dcMENH_GIA;
        //}
        private void load_data_2_cbo()
        {
            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.LOAI_TRAI_PHIEU);
            m_cbo_loai_trai_phieu.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_trai_phieu.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_trai_phieu.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_trai_phieu.Text = "";

            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_don_vi_ky_han.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_don_vi_ky_han.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_ky_han.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_don_vi_ky_han.SelectedIndex = 1;
            //m_cbo_don_vi_ky_han.Text = "";

            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_dv_dieu_chinh_ls.DataSource = (DataTable)m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_dv_dieu_chinh_ls.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_dieu_chinh_ls.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_dieu_chinh_ls.Text = "";

            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_dv_tra_lai.DataSource = (DataTable)m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_dv_tra_lai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_tra_lai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_tra_lai.Text = "";

            ArrayList v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("360/360", "360/360"));
            v_arr.Add(new CO_SO_TINH_LAI("360/365", "360/365"));
            v_arr.Add(new CO_SO_TINH_LAI("365/365", "365/365"));
            v_arr.Add(new CO_SO_TINH_LAI("365/360", "365/360"));
            m_cbo_co_so_tinh_lai.DataSource = v_arr;
            m_cbo_co_so_tinh_lai.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_co_so_tinh_lai.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_co_so_tinh_lai.SelectedIndex = 0;

            v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("Có", "Y"));
            v_arr.Add(new CO_SO_TINH_LAI("Không", "N"));
            m_cbo_tha_noi.DataSource = v_arr;
            m_cbo_tha_noi.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_tha_noi.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_tha_noi.Text = "";

            v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("Có", "Y"));
            v_arr.Add(new CO_SO_TINH_LAI("Không", "N"));
            m_cbo_tra_lai_sau.DataSource = v_arr;
            m_cbo_tra_lai_sau.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_tra_lai_sau.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_tra_lai_sau.Text = "";
        }
        private void chon_dot_phat_hanh()
        {
            f150_dm_dot_phat_hanh v_frm150 = new f150_dm_dot_phat_hanh();
            m_us_v_dm_dot_phat_hanh = v_frm150.display_2_select();
            m_txt_ten_dv_phat_hanh.Text = m_us_v_dm_dot_phat_hanh.strTEN_TO_CHUC_PHAT_HANH;
            m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_v_dm_dot_phat_hanh.dcMENH_GIA,"#,###");
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(m_us_v_dm_dot_phat_hanh.datNGAY_PHAT_HANH, "dd/MM/yyyy");
            m_txt_so_luong_phat_hanh.Text = CIPConvert.ToStr(m_us_v_dm_dot_phat_hanh.dcTONG_SO_LUONG_TRAI_PHIEU,"#,###");
        }
        private void tinh_ngay_dao_han(int ip_i_ky_han, int id_dv_ky_han)
        {
            DateTime v_dat_ngay_phat_hanh = CIPConvert.ToDatetime(m_txt_ngay_phat_hanh.Text);
            if(id_dv_ky_han == ID_DON_VI_KY_HAN.THANG)
                m_dat_ngay_dao_han.Value = CIPConvert.ToDatetime(CIPConvert.ToStr(v_dat_ngay_phat_hanh.AddMonths(ip_i_ky_han)));
            else m_dat_ngay_dao_han.Value = CIPConvert.ToDatetime(CIPConvert.ToStr(v_dat_ngay_phat_hanh.AddYears(ip_i_ky_han)));
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ten_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_han, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_tong_sl, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_lai_suat, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_tra_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_dieu_chinh_ls, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_bien_do_lai, DataType.NumberType, allowNull.YES, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_tcph_chuyen_tien_trc, DataType.NumberType, allowNull.YES, true))
            { return false; }
            if (m_us_to_chuc_phat_hanh.IsIDNull()) {
                MessageBox.Show("Bạn chưa chọn tổ chức phát hành!");
                return false; }
            return true;
        }
        private bool check_so_luong_is_ok()
        {
            int v_i_so_luong = int.Parse(m_txt_tong_sl.Text.Trim());
            US_V_DM_TRAI_PHIEU v_us_dm_trai_phieu = new US_V_DM_TRAI_PHIEU();
            DS_V_DM_TRAI_PHIEU v_ds_dm_trai_phieu = new DS_V_DM_TRAI_PHIEU();
            v_us_dm_trai_phieu.FillDatasetByIDDotPhatHanh(v_ds_dm_trai_phieu, m_us_v_dm_dot_phat_hanh.dcID);
            int v_i_so_luong_hien_tai = 0;
            if (v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows.Count > 0)
            {
                for (int v_i = 0; v_i < v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows.Count; v_i++)
                {
                    v_i_so_luong_hien_tai += int.Parse(CIPConvert.ToStr(v_ds_dm_trai_phieu.V_DM_TRAI_PHIEU.Rows[v_i][V_DM_TRAI_PHIEU.TONG_SL_PHAT_HANH]));
                }
            }
            v_i_so_luong_hien_tai += v_i_so_luong;
            switch (m_e_formmode)
            {
                case e_form_mode.THEM_TRAI_PHIEU:
                    if (v_i_so_luong_hien_tai > m_us_v_dm_dot_phat_hanh.dcTONG_SO_LUONG_TRAI_PHIEU) return false;
                    break;
                case e_form_mode.CAP_NHAT_TRAI_PHIEU:
                    if (v_i_so_luong_hien_tai > CIPConvert.ToDecimal(m_txt_so_luong_phat_hanh.Text)) return false;
                    break;
                case e_form_mode.DUYET_DU_LIEU:
                    if (v_i_so_luong_hien_tai > CIPConvert.ToDecimal(m_txt_so_luong_phat_hanh.Text)) return false;
                    break;
            }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            // Kiểm tra sô lượng
            if (!check_so_luong_is_ok())
            {
                BaseMessages.MsgBox_Infor("Số lượng trái phiếu đã vượt quá số lượng trái phiếu phát hành trong đợt");
                return;
            }
            form_2_us_object(m_us_trai_phieu);

            switch (m_e_formmode)
            {
                case e_form_mode.THEM_TRAI_PHIEU:
                    m_us_trai_phieu.dcID_NGUOI_LAP = CAppContext_201.getCurrentUserID();
                    m_us_trai_phieu.SetID_NGUOI_DUYETNull();
                    m_us_trai_phieu.dcID_DOT_PHAT_HANH = m_us_v_dm_dot_phat_hanh.dcID;
                    m_us_trai_phieu.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_LAP;
                    m_us_trai_phieu.Insert();
                    break;
                case e_form_mode.CAP_NHAT_TRAI_PHIEU:
                    m_us_trai_phieu.Update();
                    break;
                case e_form_mode.DUYET_DU_LIEU:
                    m_us_trai_phieu.dcID_NGUOI_DUYET = CAppContext_201.getCurrentUserID();
                    m_us_trai_phieu.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_DUYET;
                    m_us_trai_phieu.Update();
                    break;
                case e_form_mode.VIEW_DU_LIEU:
                    break;
                default:
                    break;
            }
            ghi_log_he_thong();
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }
        private void set_ini_form_load()
        {
            load_data_2_cbo();
            m_cbo_chuyen_nhuong_huong_theo.SelectedIndex = 1;
            m_cbo_ngung_chuyen_nhuong_tu_ngay.SelectedIndex = 1;
            m_lbl_lai_suat_tha_noi.Visible = false;
            m_cbo_tha_noi.Visible = false;
            switch (m_e_formmode)
            {
                case e_form_mode.THEM_TRAI_PHIEU:
                    m_cmd_save.Text = "Lưu";
                    break;
                case e_form_mode.CAP_NHAT_TRAI_PHIEU:
                    us_object_2_form(m_us_trai_phieu);
                    m_cmd_save.Text = "Lưu";
                    break;
                case e_form_mode.DUYET_DU_LIEU:
                    m_cmd_save.Text = "Duyệt";
                    us_object_2_form(m_us_trai_phieu);
                    break;
                case e_form_mode.VIEW_DU_LIEU:
                    break;
            }
        }
        #endregion
        
        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f300_dm_trai_phieu_DE_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_dot_phat_hanh.Click += new EventHandler(m_cmd_chon_dot_phat_hanh_Click);
            m_txt_ky_han.LostFocus += new EventHandler(m_txt_ky_han_LostFocus);
            m_cbo_don_vi_ky_han.LostFocus += new EventHandler(m_cbo_don_vi_ky_han_LostFocus);
            m_cbo_loai_trai_phieu.LostFocus += new EventHandler(m_cbo_loai_trai_phieu_LostFocus);
            m_txt_tong_sl.LostFocus += new EventHandler(m_txt_tong_sl_LostFocus);
            this.KeyDown += new KeyEventHandler(f300_dm_trai_phieu_DE_KeyDown);
        }

        void f300_dm_trai_phieu_DE_KeyDown(object sender, KeyEventArgs e)
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

        void m_txt_tong_sl_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tong_sl.Text.Trim() == "") return;
                m_txt_tong_gia_tri.Text = CIPConvert.ToStr(CIPConvert.ToDecimal(m_txt_tong_sl.Text) * CIPConvert.ToDecimal(m_txt_menh_gia.Text),"#,###");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f300_dm_trai_phieu_DE_Load(object sender, EventArgs e)
        {
            try
            {
                set_ini_form_load();
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
        private void m_cmd_chon_dot_phat_hanh_Click(object sender, EventArgs e)
        {
            try
            {
                chon_dot_phat_hanh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_txt_ky_han_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_ky_han.Text.Trim() == "") return;
                if (m_txt_so_luong_phat_hanh.Text == "") return;
                tinh_ngay_dao_han(int.Parse(m_txt_ky_han.Text), int.Parse(CIPConvert.ToStr(m_cbo_don_vi_ky_han.SelectedValue)));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cbo_don_vi_ky_han_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_ky_han.Text.Trim() == "") return;
                tinh_ngay_dao_han(int.Parse(m_txt_ky_han.Text), int.Parse(CIPConvert.ToStr(m_cbo_don_vi_ky_han.SelectedValue)));
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cbo_loai_trai_phieu_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (CIPConvert.ToDecimal(m_cbo_loai_trai_phieu.SelectedValue) == ID_LOAI_TRAI_PHIEU.LS_THA_NOI)
                {
                    m_cbo_tha_noi.SelectedIndex = 0;
                    m_cbo_tha_noi.Enabled = false;
                }
                else
                {
                    m_cbo_tha_noi.SelectedIndex = 1;
                    m_cbo_tha_noi.Enabled = false;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
    public class CO_SO_TINH_LAI
    { 
        private string m_Display;
        private string m_Value;
        public const string DISPLAY = "DISPLAY";
        public const string VALUE = "VALUE";
        public CO_SO_TINH_LAI(string Display, string Value)
        {
            m_Display = Display;
            m_Value = Value;
        }
        public string Display
        {
            get{return m_Display;}
        }
        public string Value
        {
            get{return m_Value;}
        }

    }
}
