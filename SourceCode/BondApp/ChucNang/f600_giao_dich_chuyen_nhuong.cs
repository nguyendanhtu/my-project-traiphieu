using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BondUS;
using BondDS;
using BondDS.CDBNames;
using IP.Core.IPData.DBNames;
using C1.Win.C1FlexGrid;
using System.Data.SqlClient;

using IP.Core.IPSystemAdmin;

namespace BondApp
{
    public partial class f600_giao_dich_chuyen_nhuong : Form
    {
        public f600_giao_dich_chuyen_nhuong()
        {
            InitializeComponent();
            format_controls();
            load_cbb_trang_thai_chuyen_nhuong();
        }

        #region Public Intrface
        public void display_lap_chuyen_nhuong()
        {
            m_e_form_mode = eFormMode.LAP_CHUYEN_NHUONG;
            this.ShowDialog();
        }
        public void display_sua_chuyen_nhuong(decimal ip_dc_id_gd_cn)
        {
            m_us_gd_chuyen_nhuong = new US_GD_CHUYEN_NHUONG(ip_dc_id_gd_cn);
            us_dg_chuyen_nhuong_2_from();
            m_e_form_mode = eFormMode.SUA_CHUYEN_NHUONG_CHUA_DUYET;
            this.ShowDialog();
        }
        public void display_duyet_chuyen_nhuong(decimal ip_dc_id_gd_cn)
        {
            m_us_gd_chuyen_nhuong = new US_GD_CHUYEN_NHUONG(ip_dc_id_gd_cn);
            us_dg_chuyen_nhuong_2_from();
            m_e_form_mode = eFormMode.DUYET_CHUYEN_NHUONG;
            this.ShowDialog();
        }
        public void display_xem_gd_chuyen_nhuong(decimal ip_dc_id_gd_cn)
        {
            m_us_gd_chuyen_nhuong = new US_GD_CHUYEN_NHUONG(ip_dc_id_gd_cn);
            us_dg_chuyen_nhuong_2_from();
            m_e_form_mode = eFormMode.XEM_GIAO_DICH;
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        public enum eFormMode
        {
            LAP_CHUYEN_NHUONG
            , SUA_CHUYEN_NHUONG_CHUA_DUYET
            , DUYET_CHUYEN_NHUONG
            , XEM_GIAO_DICH
        }
        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU();
        US_GD_CHUYEN_NHUONG m_us_gd_chuyen_nhuong = new US_GD_CHUYEN_NHUONG();
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        decimal m_dc_phi_gd_chuyen_nhuong_max, m_dc_phi_gd_chuyen_nhuong_min;
        eFormMode m_e_form_mode = eFormMode.LAP_CHUYEN_NHUONG;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);                       
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            set_define_events();
        }
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_CHUYEN_NHUONG;

            /* Thông tin riêng*/
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_CHUYEN_NHUONG:
                    DS_GD_CHUYEN_NHUONG v_ds_dm_to_chuc_ph = new DS_GD_CHUYEN_NHUONG();
                    m_us_gd_chuyen_nhuong.FillDataset(v_ds_dm_to_chuc_ph, " WHERE ID = (SELECT MAX(ID) FROM GD_CHUYEN_NHUONG)");
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.THEM;
                    if (v_ds_dm_to_chuc_ph.GD_CHUYEN_NHUONG.Rows.Count > 0)
                        m_us_v_ht_log_truy_cap.strMO_TA = "Thêm " + LOG_DOI_TUONG_TAC_DONG.GD_CHUYEN_NHUONG + " mã: " + CIPConvert.ToStr(v_ds_dm_to_chuc_ph.GD_CHUYEN_NHUONG.Rows[0][GD_CHUYEN_NHUONG.MA_GIAO_DICH]);
                    break;
                case eFormMode.SUA_CHUYEN_NHUONG_CHUA_DUYET:
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Cập nhật thông tin " + LOG_DOI_TUONG_TAC_DONG.GD_CHUYEN_NHUONG + " mã: " + m_us_gd_chuyen_nhuong.strMA_GIAO_DICH;
                    break;
                case eFormMode.DUYET_CHUYEN_NHUONG:
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.DUYET;
                    m_us_v_ht_log_truy_cap.strMO_TA = "Duyệt thông tin " + LOG_DOI_TUONG_TAC_DONG.GD_CHUYEN_NHUONG + " mã: " + m_us_gd_chuyen_nhuong.strMA_GIAO_DICH;
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
        private void load_cbb_trang_thai_chuyen_nhuong()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.fill_tu_dien_cung_loai_ds(CM_DM_DS_LOAI_TU_DIEN.TRANG_THAI_GD, v_ds_cm_dm_tu_dien);
            v_ds_cm_dm_tu_dien.EnforceConstraints = false;
            

            m_cbb_trang_thai_cn.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbb_trang_thai_cn.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbb_trang_thai_cn.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
        }

        private void set_inital_form_load(){            
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_CHUYEN_NHUONG:                    
                    m_cmd_lap_chuyen_nhuong.Visible = true;
                    m_cmd_sua_chuyen_nhuong.Visible = false;
                    m_cmd_duyet_chuyen_nhuong.Visible = false;
                    m_txt_nguoi_lap.Text = CAppContext_201.getCurrentUser();
                    break;
                case eFormMode.SUA_CHUYEN_NHUONG_CHUA_DUYET:
                    m_cmd_lap_chuyen_nhuong.Visible = false;
                    m_cmd_sua_chuyen_nhuong.Visible = true;
                    m_cmd_duyet_chuyen_nhuong.Visible = false;
                    m_gru_thong_tin_khach_hang.Enabled = false;
                    m_gru_thong_tin_trai_phieu.Enabled = false;
                    break;
                case eFormMode.DUYET_CHUYEN_NHUONG:
                    m_cmd_lap_chuyen_nhuong.Visible = false;
                    m_cmd_sua_chuyen_nhuong.Visible = false;
                    m_cmd_duyet_chuyen_nhuong.Visible = true;
                    m_cmd_duyet_chuyen_nhuong.Enabled = true;
                    m_gru_thong_tin_khach_hang.Enabled = false;
                    m_gru_thong_tin_trai_phieu.Enabled = false;
                    m_date_ngay_xac_nhan.Checked = true;
                    m_txt_nguoi_duyet.Text = CAppContext_201.getCurrentUser();
                    break;
                case eFormMode.XEM_GIAO_DICH:
                    m_cmd_lap_chuyen_nhuong.Visible = false;
                    m_cmd_sua_chuyen_nhuong.Visible = false;
                    m_cmd_duyet_chuyen_nhuong.Visible = false;                    
                    m_gru_thong_tin_trai_phieu.Enabled = false;
                    m_gru_thong_tin_khach_hang.Enabled = false;
                    m_gru_thong_tin_chuyen_nhuong.Enabled = false;
                    break;
                default:                    
                    break;
            }
            US_HT_THAM_SO_HE_THONG v_us_ht_tham_so_ht = new US_HT_THAM_SO_HE_THONG();
            IP.Core.IPData.DS_HT_THAM_SO_HE_THONG v_ds_ht_tham_so_ht = new IP.Core.IPData.DS_HT_THAM_SO_HE_THONG();
            v_us_ht_tham_so_ht.FillDataset(v_ds_ht_tham_so_ht, " WHERE LOAI_THAM_SO = 'PHI_PGT'");
            string v_str_ty_le_phi_gd_max_min = "";
            v_str_ty_le_phi_gd_max_min = "Phí chuyển nhượng từ ";
            v_str_ty_le_phi_gd_max_min += CIPConvert.ToStr(CIPConvert.ToDecimal(v_ds_ht_tham_so_ht.HT_THAM_SO_HE_THONG.Rows[1][HT_THAM_SO_HE_THONG.GIA_TRI]),"#,###");
            m_dc_phi_gd_chuyen_nhuong_max = CIPConvert.ToDecimal(v_ds_ht_tham_so_ht.HT_THAM_SO_HE_THONG.Rows[0][HT_THAM_SO_HE_THONG.GIA_TRI]);
            v_str_ty_le_phi_gd_max_min += " VNĐ đến ";
            v_str_ty_le_phi_gd_max_min += CIPConvert.ToStr(CIPConvert.ToDecimal(v_ds_ht_tham_so_ht.HT_THAM_SO_HE_THONG.Rows[0][HT_THAM_SO_HE_THONG.GIA_TRI]), "#,###");
            m_dc_phi_gd_chuyen_nhuong_min = CIPConvert.ToDecimal(v_ds_ht_tham_so_ht.HT_THAM_SO_HE_THONG.Rows[1][HT_THAM_SO_HE_THONG.GIA_TRI]);
            v_str_ty_le_phi_gd_max_min += " VNĐ";
            m_lbl_phi_gd_max_min.Text = v_str_ty_le_phi_gd_max_min;
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (m_us_v_trai_phieu.dcID != -1)
                us_trai_phieu_2_form(m_us_v_trai_phieu);
        }
        private void select_trai_chu_mua()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
           
            m_us_trai_chu = v_frm500.select_trai_chu_of_trai_phieu(m_us_v_trai_phieu);
            if (m_us_trai_chu.dcID != -1)
            {
                if (!m_us_trai_chu.dcID.ToString().Equals(m_lbl_ID_nguoi_ban.Text))
                    us_trai_chu_mua_2_form(m_us_trai_chu);
                else
                    MessageBox.Show("Phải chọn bên mua không trùng với bên bán");
            }
        }
        private void select_trai_chu_ban()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            
            m_us_trai_chu = v_frm500.select_trai_chu_of_trai_phieu(m_us_v_trai_phieu);
            if (m_us_trai_chu.dcID != -1)
            {
                if (!m_us_trai_chu.dcID.ToString().Equals(m_lbl_ID_nguoi_mua.Text))
                    us_trai_chu_ban_2_form(m_us_trai_chu);
                else
                    MessageBox.Show("Phải chọn bên bán không trùng với bên mua");
            }
        }
        private void us_trai_phieu_2_form(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            US_GD_CHUYEN_NHUONG v_us_gd_chuyen_nhuong = new US_GD_CHUYEN_NHUONG();
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_DIEU_CHINH_LS, "#,###");
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH,"dd/MM/yyyy");
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN, "dd/MM/yyyy");
            try
            {
                v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN(ip_us_trai_phieu.dcID_DV_KY_HAN);
            }
            catch (Exception v_e)
            {
                MessageBox.Show("Trái phiếu " + m_us_v_trai_phieu.strTEN_TRAI_PHIEU + " không có đơn vị kỳ hạn");
                    throw v_e;
            }

            m_txt_ty_le_phi_gd.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.dcTY_LE_PHI_CHUYEN_NHUONG * 100, "#,##0.00");
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_HAN) + " " + CIPConvert.ToStr(v_us_cm_dm_tu_dien.strTEN);
            m_txt_lai_suat.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcLAI_SUAT_DEFAULT, "#,##0.00");
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_CHUYEN_NHUONG:
                    m_date_ngay_chuyen_nhuong.Value = DateTime.Today;// dòng này KHÔNG đúng trong trường hợp hiển thị Giao dịch chuyển nhượng đã xảy ra
                    m_date_ngay_vao_so.Value = DateTime.Today;
                    m_txt_ma_giao_dich.Text = sinh_ma_giao_dich();
                    break;
                case eFormMode.SUA_CHUYEN_NHUONG_CHUA_DUYET:                    
                    m_date_ngay_chuyen_nhuong.Value = m_us_gd_chuyen_nhuong.datNGAY_KY_CHUYEN_NHUONG;
                    m_date_ngay_vao_so.Value = m_us_gd_chuyen_nhuong.datNGAY_VAO_SO;
                    if (!m_us_gd_chuyen_nhuong.IsNGAY_XAC_NHANNull())
                    {
                        m_date_ngay_xac_nhan.Value = m_us_gd_chuyen_nhuong.datNGAY_XAC_NHAN;
                    }
                    break;
                case eFormMode.DUYET_CHUYEN_NHUONG:
                    m_date_ngay_chuyen_nhuong.Value = m_us_gd_chuyen_nhuong.datNGAY_KY_CHUYEN_NHUONG;
                    m_date_ngay_xac_nhan.Value = DateTime.Today;                    
                    break;
                default:
                    break;
            }
        }
        private void us_trai_chu_ban_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            m_lbl_ID_nguoi_ban.Text = CIPConvert.ToStr(ip_us_trai_chu.dcID);
            if (ip_us_trai_chu.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds_so_du_trai_phieu = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
            v_us_so_du_trai_phieu.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu.dcID, v_ds_so_du_trai_phieu);

            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_txt_ngay_cap.Text = ip_us_trai_chu.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            if (v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU != null && v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Count > 0)
            {
                m_txt_so_luong_trai_phieu.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.TONG_SO_DU].ToString();
                m_txt_so_luong_kha_dung.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.SO_DU_KHA_DUNG].ToString();
            }
            m_txt_so_dt.Text = ip_us_trai_chu.strMOBILE;
            m_txt_so_fax.Text = ip_us_trai_chu.strFAX;
            m_txt_dia_chi.Text = ip_us_trai_chu.strDIA_CHI;
            m_txt_chuc_vu_ng_dai_dien.Text = ip_us_trai_chu.strCHUC_VU;
            if (m_e_form_mode == eFormMode.LAP_CHUYEN_NHUONG)
            {
                m_txt_nguoi_dai_dien.Text = ip_us_trai_chu.strTEN_NGUOI_DAI_DIEN;
                m_txt_cmt_ng_dai_dien.Text = ip_us_trai_chu.strCMT_NGUOI_DAI_DIEN;
                m_txt_noi_cap_cmt_ng_dai_dien.Text = ip_us_trai_chu.strNOI_CAP_CMT;
                m_date_ngay_cap_cmnd_ng_dai_dien.Value = ip_us_trai_chu.datNGAY_CAP_CMT_NGUOI_DAI_DIEN;
            }
        }
        private void us_trai_chu_mua_2_form(US_DM_TRAI_CHU ip_us_trai_chu_mua)
        {
            m_lbl_ID_nguoi_mua.Text = CIPConvert.ToStr(ip_us_trai_chu_mua.dcID);
            if (ip_us_trai_chu_mua.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds_so_du_trai_phieu = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
            v_us_so_du_trai_phieu.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu_mua.dcID, v_ds_so_du_trai_phieu);

            m_txt_ben_mua_ten.Text = ip_us_trai_chu_mua.strTEN_TRAI_CHU;
            m_txt_ben_mua_cmnd.Text = ip_us_trai_chu_mua.strCMT_GIAY_DKKD;
            m_txt_ben_mua_noi_cap_cmnd.Text = ip_us_trai_chu_mua.strNOI_CAP_CMT;
            m_txt_ben_mua_ngay_cap_cmnd.Text = ip_us_trai_chu_mua.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            if (v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU != null && v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Count > 0)
            {
                m_txt_ben_mua_so_luong_trai_phieu.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.TONG_SO_DU].ToString();
                m_txt_ben_mua_so_kha_dung.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.SO_DU_KHA_DUNG].ToString();
            }            
            m_txt_ben_mua_sdt.Text = ip_us_trai_chu_mua.strMOBILE;
            m_txt_ben_mua_so_fax.Text = ip_us_trai_chu_mua.strFAX;
            m_txt_ben_mua_dia_chi.Text = ip_us_trai_chu_mua.strDIA_CHI;
            m_txt_chuc_vu_ng_dai_dien.Text = ip_us_trai_chu_mua.strCHUC_VU;
            if (m_e_form_mode == eFormMode.LAP_CHUYEN_NHUONG)
            {
                m_txt_ben_mua_ten_nguoi_dai_dien.Text = ip_us_trai_chu_mua.strTEN_NGUOI_DAI_DIEN;
                m_txt_ben_mua_cmnd_ng_dai_dien.Text = ip_us_trai_chu_mua.strCMT_NGUOI_DAI_DIEN;
                m_txt_ben_mua_noi_cap_cmnd_ng_dai_dien.Text = ip_us_trai_chu_mua.strNOI_CAP_CMT;
                m_date_ben_mua_ngay_cap_cmnd_ng_dai_dien.Value = ip_us_trai_chu_mua.datNGAY_CAP_CMT_NGUOI_DAI_DIEN;
            }
        }
        private void form_2_us_gd_chuyen_nhuong()
        {
            Debug.Assert(m_cbb_trang_thai_cn.SelectedValue != null, "Chưa thiết lập trạng thái chuyển nhượng ở Từ điển!");                                   

            if(!m_lbl_ID_gd_chuyen_nhuong.Text.Equals(""))
            m_us_gd_chuyen_nhuong.dcID = CIPConvert.ToDecimal(m_lbl_ID_gd_chuyen_nhuong.Text);
            m_us_gd_chuyen_nhuong.strMA_GIAO_DICH = m_txt_ma_giao_dich.Text;            
            m_us_gd_chuyen_nhuong.datNGAY_KY_CHUYEN_NHUONG = m_date_ngay_chuyen_nhuong.Value;
            m_us_gd_chuyen_nhuong.datNGAY_VAO_SO = m_date_ngay_vao_so.Value;
            m_us_gd_chuyen_nhuong.dcID_TRAI_CHU_MUA = CIPConvert.ToDecimal(m_lbl_ID_nguoi_mua.Text);
            m_us_gd_chuyen_nhuong.dcID_TRAI_CHU_BAN = CIPConvert.ToDecimal(m_lbl_ID_nguoi_ban.Text);
            m_us_gd_chuyen_nhuong.strTEN_NGUOI_UY_QUYEN_MUA = m_txt_ben_mua_ten_nguoi_dai_dien.Text;
            m_us_gd_chuyen_nhuong.strTEN_NGUOI_UY_QUYEN_BAN = m_txt_nguoi_dai_dien.Text;           
            m_us_gd_chuyen_nhuong.strSO_CMT_NGUOI_MUA = m_txt_ben_mua_cmnd_ng_dai_dien.Text;
            m_us_gd_chuyen_nhuong.strSO_CMT_NGUOI_BAN = m_txt_cmt_ng_dai_dien.Text;
            m_us_gd_chuyen_nhuong.datNGAY_CAP_CMT_NGUOI_MUA = m_date_ben_mua_ngay_cap_cmnd_ng_dai_dien.Value;
            m_us_gd_chuyen_nhuong.datNGAY_CAP_CMT_NGUOI_BAN = m_date_ngay_cap_cmnd_ng_dai_dien.Value;
            m_us_gd_chuyen_nhuong.strNOI_CAP_CMT_NGUOI_MUA = m_txt_ben_mua_noi_cap_cmnd_ng_dai_dien.Text;
            m_us_gd_chuyen_nhuong.strNOI_CAP_CMT_NGUOI_BAN = m_txt_noi_cap_cmt_ng_dai_dien.Text;
            m_us_gd_chuyen_nhuong.dcSO_LUONG_CHUYEN_NHUONG = CIPConvert.ToDecimal(m_txt_so_luong_chuyen_nhuong.Text);
            if (m_us_gd_chuyen_nhuong.dcSO_LUONG_CHUYEN_NHUONG > CIPConvert.ToDecimal(m_txt_so_luong_kha_dung.Text))
            {
                MessageBox.Show("Số lượng trái phiếu chuyển nhượng phải nhỏ hợn số trái phiếu khả dụng của trai chủ bán!");
                return;
            }
            m_us_gd_chuyen_nhuong.dcGIA_TRI_CHUYEN_NHUONG_THUC_TE = CIPConvert.ToDecimal(m_txt_gia_tri_chuyen_nhuong_thuc_te.Text);
            m_us_gd_chuyen_nhuong.dcTY_LE_PHI_GD = CIPConvert.ToDecimal(m_txt_ty_le_phi_gd.Text)/100;
            m_us_gd_chuyen_nhuong.dcPHI_GD = CIPConvert.ToDecimal(m_txt_phi_gd.Text);            
            m_us_gd_chuyen_nhuong.strNOI_DUNG_GIAO_DICH = m_txt_noi_dung_chuyen_nhuong.Text;
            m_us_gd_chuyen_nhuong.dcPHAN_TRAM_THUE = CIPConvert.ToDecimal(m_txt_phan_tram_thue.Text)/100;
            m_us_gd_chuyen_nhuong.dcGIA_TRI_THUE = CIPConvert.ToDecimal(m_txt_thue.Text);

            if (!m_date_ngay_xac_nhan.Checked)
            {
                m_us_gd_chuyen_nhuong.SetNGAY_XAC_NHANNull();
            }
            else
            {
                m_us_gd_chuyen_nhuong.datNGAY_XAC_NHAN = m_date_ngay_xac_nhan.Value;
            }
           
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_CHUYEN_NHUONG:
                    m_us_gd_chuyen_nhuong.dcID_NGUOI_LAP = CAppContext_201.getCurrentUserID();
                    m_us_gd_chuyen_nhuong.SetID_NGUOI_DUYETNull();
                    m_us_gd_chuyen_nhuong.dcID_TRANG_THAI_CHUYEN_NHUONG = List_trang_thai.Da_Nhap;
                    break;
                case eFormMode.DUYET_CHUYEN_NHUONG:
                    m_us_gd_chuyen_nhuong.dcID_NGUOI_DUYET = CAppContext_201.getCurrentUserID();
                    m_us_gd_chuyen_nhuong.dcID_TRANG_THAI_CHUYEN_NHUONG = List_trang_thai.Da_Duyet;
                    break;
                default:
                    break;
            }           
        }

        private void us_dg_chuyen_nhuong_2_from()
        {
            US_DM_TRAI_CHU v_trai_chu_ban = new US_DM_TRAI_CHU(m_us_gd_chuyen_nhuong.dcID_TRAI_CHU_BAN);
            US_DM_TRAI_CHU v_trai_chu_mua = new US_DM_TRAI_CHU(m_us_gd_chuyen_nhuong.dcID_TRAI_CHU_MUA);
            US_V_DM_TRAI_PHIEU v_trai_phieu = new US_V_DM_TRAI_PHIEU(v_trai_chu_ban.dcID_TRAI_PHIEU_SO_HUU);
            if (v_trai_chu_ban.IsIDNull()) return;
            if (v_trai_chu_mua.IsIDNull()) return;
            if (v_trai_phieu.IsIDNull()) return;
            us_trai_chu_ban_2_form(v_trai_chu_ban);
            us_trai_chu_mua_2_form(v_trai_chu_mua);
            us_trai_phieu_2_form(v_trai_phieu);
            m_txt_nguoi_dai_dien.Text = m_us_gd_chuyen_nhuong.strTEN_NGUOI_UY_QUYEN_BAN;
            m_txt_cmt_ng_dai_dien.Text = m_us_gd_chuyen_nhuong.strSO_CMT_NGUOI_BAN;
            m_txt_noi_cap_cmt_ng_dai_dien.Text = m_us_gd_chuyen_nhuong.strNOI_CAP_CMT_NGUOI_BAN;
            m_date_ngay_cap_cmnd_ng_dai_dien.Value = m_us_gd_chuyen_nhuong.datNGAY_CAP_CMT_NGUOI_BAN;
            m_txt_ben_mua_ten_nguoi_dai_dien.Text = m_us_gd_chuyen_nhuong.strTEN_NGUOI_UY_QUYEN_MUA;
            m_txt_ben_mua_cmnd_ng_dai_dien.Text = m_us_gd_chuyen_nhuong.strSO_CMT_NGUOI_MUA;
            m_txt_ben_mua_noi_cap_cmnd_ng_dai_dien.Text = m_us_gd_chuyen_nhuong.strNOI_CAP_CMT_NGUOI_MUA;
            m_date_ben_mua_ngay_cap_cmnd_ng_dai_dien.Value = m_us_gd_chuyen_nhuong.datNGAY_CAP_CMT_NGUOI_MUA;
            m_txt_ma_giao_dich.Text = m_us_gd_chuyen_nhuong.strMA_GIAO_DICH;
            m_txt_noi_dung_chuyen_nhuong.Text = m_us_gd_chuyen_nhuong.strNOI_DUNG_GIAO_DICH;            
            m_txt_so_luong_chuyen_nhuong.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcSO_LUONG_CHUYEN_NHUONG, "#,###");
            m_txt_gia_tri_chuyen_nhuong.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcSO_LUONG_CHUYEN_NHUONG * v_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_gia_tri_chuyen_nhuong_thuc_te.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcGIA_TRI_CHUYEN_NHUONG_THUC_TE, "#,###");
            m_txt_ty_le_phi_gd.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcTY_LE_PHI_GD*100, "#,##0.00");
            m_txt_phi_gd.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcPHI_GD, "#,###");
            m_txt_phan_tram_thue.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcPHAN_TRAM_THUE * 100, "#,##0.00");
            m_txt_thue.Text = CIPConvert.ToStr(m_us_gd_chuyen_nhuong.dcGIA_TRI_THUE, "#,###");
            m_date_ngay_chuyen_nhuong.Value = m_us_gd_chuyen_nhuong.datNGAY_KY_CHUYEN_NHUONG;
            m_date_ngay_vao_so.Value = m_us_gd_chuyen_nhuong.datNGAY_VAO_SO;
            if (!m_us_gd_chuyen_nhuong.IsNGAY_XAC_NHANNull())
            {                
                m_date_ngay_xac_nhan.Checked = true;
                m_date_ngay_xac_nhan.Value = m_us_gd_chuyen_nhuong.datNGAY_XAC_NHAN;
            }
            US_HT_NGUOI_SU_DUNG v_nguoi_dung = new US_HT_NGUOI_SU_DUNG(m_us_gd_chuyen_nhuong.dcID_NGUOI_LAP);            
            switch (m_e_form_mode)
            {
                case eFormMode.LAP_CHUYEN_NHUONG:
                    m_txt_nguoi_lap.Text = CAppContext_201.getCurrentUser();
                    m_txt_nguoi_duyet.Text = "";                    
                    break;
                case eFormMode.SUA_CHUYEN_NHUONG_CHUA_DUYET:
                    
                    m_txt_nguoi_lap.Text =  v_nguoi_dung.strTEN;
                    m_txt_nguoi_duyet.Text = "";
                    break;
                case eFormMode.DUYET_CHUYEN_NHUONG:                    
                    m_txt_nguoi_lap.Text =  v_nguoi_dung.strTEN;
                    m_txt_nguoi_duyet.Text = CAppContext_201.getCurrentUser();
                    m_date_ngay_xac_nhan.Checked = true;
                    m_date_ngay_xac_nhan.Value = DateTime.Today;
                    break;
                default:
                    break;
            }           
            //m_txt_nguoi_lap.Text = (m_us_gd_chuyen_nhuong.dcID_NGUOI_LAP)
            m_cbb_trang_thai_cn.SelectedValue = m_us_gd_chuyen_nhuong.dcID_TRANG_THAI_CHUYEN_NHUONG;
        }

        private bool check_thong_tin_chuyen_nhuong_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ben_mua_ten, DataType.StringType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ten_khach_hang, DataType.StringType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ma_giao_dich, DataType.StringType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_so_luong_chuyen_nhuong, DataType.NumberType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ty_le_phi_gd, DataType.NumberType, allowNull.NO)) return false;
            if (!CValidateTextBox.IsValid(m_txt_so_cmnd_dkkd, DataType.StringType, allowNull.NO)) return false;
            return true;
        }

        private void lap_chuyen_nhuong()
        {
            if (!check_thong_tin_chuyen_nhuong_is_ok()) return;
            //if (!kiem_tra_phi_gd()) return;
            form_2_us_gd_chuyen_nhuong();
            
            try
            {
                m_us_gd_chuyen_nhuong.BeginTransaction();
                m_us_gd_chuyen_nhuong.Insert();
                m_us_gd_chuyen_nhuong.CommitTransaction();
                ghi_log_he_thong();
            }
            catch (Exception v_e)
            {
                if (m_us_gd_chuyen_nhuong.is_having_transaction())
                {
                    m_us_gd_chuyen_nhuong.Rollback();
                }
                throw v_e;
            }

            MessageBox.Show("Cập nhập thành công!");
            this.Close();
            f610_dm_giao_dien_chuyen_nhuong v_fm610 = new f610_dm_giao_dien_chuyen_nhuong();
            v_fm610.display();

        }

        private void sua_thong_tin_chuyen_nhuong()
        {
            if (!check_thong_tin_chuyen_nhuong_is_ok()) return;
            form_2_us_gd_chuyen_nhuong();
            
            try
            {
                m_us_gd_chuyen_nhuong.BeginTransaction();
                m_us_gd_chuyen_nhuong.Update();
                m_us_gd_chuyen_nhuong.CommitTransaction();
                ghi_log_he_thong();
            }
            catch (Exception v_e)
            {
                if (m_us_gd_chuyen_nhuong.is_having_transaction())
                {
                    m_us_gd_chuyen_nhuong.Rollback();
                }

                throw v_e;
            }
            MessageBox.Show("Cập nhập thành công!");
            this.Close();
            
        }

        private void duyet_chuyen_nhuong()
        {
            /*Cần thực hiện 02 việc ở dưới procedure (trong cùng 01 transaction)
             * 1. Update trạng thái chuyển nhượng
             * 2. Cập nhật số dư
             * */
            if (!check_thong_tin_chuyen_nhuong_is_ok()) return;
            form_2_us_gd_chuyen_nhuong();
            
            try
            {
                m_us_gd_chuyen_nhuong.BeginTransaction();
                m_us_gd_chuyen_nhuong.duyet_chuyen_nhuong();
                m_us_gd_chuyen_nhuong.CommitTransaction();
                ghi_log_he_thong();
            }
            catch (Exception v_e)
            {
                if (m_us_gd_chuyen_nhuong.is_having_transaction())
                {
                    m_us_gd_chuyen_nhuong.Rollback();
                }

                throw v_e;
            }

            MessageBox.Show("Cập nhập thành công!");
            this.Close();
            
        }

        private void Show_danh_muc_chuyen_nhuong()
        {
            this.Close();
            f610_dm_giao_dien_chuyen_nhuong v_frm610 = new f610_dm_giao_dien_chuyen_nhuong();
            if (!m_us_v_trai_phieu.IsIDNull())
                v_frm610.display_theo_trai_phieu(m_us_v_trai_phieu.dcID);
            else
                v_frm610.display();
        }
        private bool kiem_tra_phi_gd()
        {
            US_HT_THAM_SO_HE_THONG v_us_phi_gd_max = new US_HT_THAM_SO_HE_THONG();
            string v_str_phi_gd_max, v_str_phi_gd_min; 
            IP.Core.IPData.DS_HT_THAM_SO_HE_THONG v_ds_phi_gd = new IP.Core.IPData.DS_HT_THAM_SO_HE_THONG();
            v_us_phi_gd_max.FillDataset(v_ds_phi_gd, " WHERE LOAI_THAM_SO = 'PHI_PGT'");
            // TH > max
            if (CIPConvert.ToDecimal(m_txt_phi_gd.Text) > CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[0][HT_THAM_SO_HE_THONG.GIA_TRI]))
            {
                v_str_phi_gd_max = CIPConvert.ToStr(CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[0][HT_THAM_SO_HE_THONG.GIA_TRI]), "#,###");
                BaseMessages.MsgBox_Infor("Phí GD lớn hơn phí chuyển nhượng max ("
                    + v_str_phi_gd_max + " VNĐ). Phí GD tự động chuyển thành " + v_str_phi_gd_max + " VNĐ");
                m_txt_phi_gd.Text = v_str_phi_gd_max;
                return false;
            }
            // TH < min
            if (CIPConvert.ToDecimal(m_txt_phi_gd.Text) < CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[1][HT_THAM_SO_HE_THONG.GIA_TRI]))
            {
                v_str_phi_gd_min = CIPConvert.ToStr(CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[1][HT_THAM_SO_HE_THONG.GIA_TRI]), "#,###");
                BaseMessages.MsgBox_Infor("Phí GD nhỏ hơn phí chuyển nhượng min ("
                    + v_str_phi_gd_min + " VNĐ). Phí GD tự động chuyển thành " + v_str_phi_gd_min+" VNĐ");
                m_txt_phi_gd.Text = v_str_phi_gd_min;
                return false;
            }
            return true;
        }
        private string sinh_ma_giao_dich()
        {
            string v_str_ma_tu_sinh ="CN_" + m_us_v_trai_phieu.strMA_TRAI_PHIEU+"_";
            US_V_GD_CHUYEN_NHUONG v_us_gd_chuyen_nhuong = new US_V_GD_CHUYEN_NHUONG();
            DS_V_GD_CHUYEN_NHUONG v_ds_gd_chuyen_nhuong = new DS_V_GD_CHUYEN_NHUONG();
            v_us_gd_chuyen_nhuong.FillDataset(v_ds_gd_chuyen_nhuong, " WHERE ID = (SELECT MAX(ID) FROM GD_CHUYEN_NHUONG)");
            if (v_ds_gd_chuyen_nhuong.V_GD_CHUYEN_NHUONG.Rows.Count == 0)
                v_str_ma_tu_sinh += "00001";
            else
            {
                decimal v_dc_stt = CIPConvert.ToDecimal(CIPConvert.ToStr(v_ds_gd_chuyen_nhuong.V_GD_CHUYEN_NHUONG.Rows[0][GD_CHUYEN_NHUONG.ID])) + 1;
                v_str_ma_tu_sinh += v_dc_stt.ToString("00000");
            }
            return v_str_ma_tu_sinh;
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            //m_txt_phan_tram_thue.LostFocus += new EventHandler(m_txt_phan_tram_thue_LostFocus);
            m_txt_ty_le_phi_gd.LostFocus += new EventHandler(m_txt_ty_le_phi_gd_LostFocus);
            //m_txt_ty_le_phi_gd.TextChanged += new EventHandler(m_txt_ty_le_phi_gd_TextChanged);
            m_txt_phan_tram_thue.TextChanged += new EventHandler(m_txt_phan_tram_thue_TextChanged);
            m_cmd_chon_ben_mua.Click += new EventHandler(m_cmd_chon_ben_mua_Click);
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_lap_chuyen_nhuong.Click += new EventHandler(m_cmd_insert_Click);
            m_txt_so_luong_chuyen_nhuong.TextChanged += new EventHandler(m_txt_so_luong_chuyen_nhuong_TextChanged);
            m_cmd_sua_chuyen_nhuong.Click += new EventHandler(m_cmd_update_Click);
            this.Load += new EventHandler(f600_giao_dich_chuyen_nhuong_Load);
            m_cmd_duyet_chuyen_nhuong.Click += new EventHandler(m_cmd_duyet_chuyen_nhuong_Click);
            m_cmd_danh_sach_chuyen_nhuong.Click += new EventHandler(m_cmd_danh_sach_chuyen_nhuong_Click);
            this.KeyDown += new KeyEventHandler(f600_giao_dich_chuyen_nhuong_KeyDown);
        }
        void m_txt_ty_le_phi_gd_LostFocus(object sender, EventArgs e)
        {
            try
            {
                US_HT_THAM_SO_HE_THONG v_us_phi_gd_max = new US_HT_THAM_SO_HE_THONG();                
                IP.Core.IPData.DS_HT_THAM_SO_HE_THONG v_ds_phi_gd = new IP.Core.IPData.DS_HT_THAM_SO_HE_THONG();
                v_us_phi_gd_max.FillDataset(v_ds_phi_gd, " WHERE LOAI_THAM_SO = 'PHI_PGT'");

                if (m_txt_so_luong_chuyen_nhuong.Text.Trim() == "") return;
                if (m_txt_ty_le_phi_gd.Text.Trim() == "") return;
                decimal v_ty_le_phi = CIPConvert.ToDecimal(m_txt_ty_le_phi_gd.Text) / 100;
                decimal v_so_luong_CN = CIPConvert.ToDecimal(m_txt_so_luong_chuyen_nhuong.Text);
                decimal v_phi_giao_dich = v_so_luong_CN * v_ty_le_phi * CIPConvert.ToDecimal(m_txt_menh_gia.Text);
                if (v_phi_giao_dich > CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[0][HT_THAM_SO_HE_THONG.GIA_TRI]))
                    v_phi_giao_dich = CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[0][HT_THAM_SO_HE_THONG.GIA_TRI]);
                if (v_phi_giao_dich < CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[1][HT_THAM_SO_HE_THONG.GIA_TRI]))
                    v_phi_giao_dich = CIPConvert.ToDecimal(v_ds_phi_gd.HT_THAM_SO_HE_THONG.Rows[1][HT_THAM_SO_HE_THONG.GIA_TRI]);

                m_txt_phi_gd.Text = CIPConvert.ToStr(v_phi_giao_dich, "#,###");
                //kiem_tra_phi_gd();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_phan_tram_thue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_phan_tram_thue.Text.Trim() == "") return;
                decimal v_dc_phan_tram_thue = CIPConvert.ToDecimal(m_txt_phan_tram_thue.Text)/100;
                decimal v_dc_so_luong_chuyen_nhuong = CIPConvert.ToDecimal(m_txt_so_luong_chuyen_nhuong.Text);
                m_txt_thue.Text = CIPConvert.ToStr(
                    v_dc_so_luong_chuyen_nhuong * v_dc_phan_tram_thue * CIPConvert.ToDecimal(m_txt_menh_gia.Text)
                    , "#,###");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_so_luong_chuyen_nhuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_so_luong_chuyen_nhuong.Text.Trim() == "") return;
                decimal v_so_luong_chuyen_nhuong = CIPConvert.ToDecimal(m_txt_so_luong_chuyen_nhuong.Text);
                decimal v_menh_gia_trai_phieu = CIPConvert.ToDecimal(m_txt_menh_gia.Text);
                decimal v_so_luong_kha_dung = CIPConvert.ToDecimal(m_txt_so_luong_kha_dung.Text);
                if (v_so_luong_chuyen_nhuong > v_so_luong_kha_dung)
                {
                    MessageBox.Show("Số lượng chuyển nhượng vượt quá số lượng khả dụng của bên bán");
                    v_so_luong_chuyen_nhuong = v_so_luong_kha_dung;
                    m_txt_so_luong_chuyen_nhuong.Text = CIPConvert.ToStr(v_so_luong_chuyen_nhuong);
                }
                m_txt_gia_tri_chuyen_nhuong.Text = CIPConvert.ToStr(v_so_luong_chuyen_nhuong * v_menh_gia_trai_phieu, "#,###");
                m_txt_gia_tri_chuyen_nhuong_thuc_te.Text = CIPConvert.ToStr(v_so_luong_chuyen_nhuong * v_menh_gia_trai_phieu, "#,###");
                m_txt_phi_gd.Text = CIPConvert.ToStr(v_so_luong_chuyen_nhuong * v_menh_gia_trai_phieu * CIPConvert.ToDecimal(m_txt_ty_le_phi_gd.Text) / 100, "#,###");
                //kiem_tra_phi_gd();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_phi_gd_LostFocus(object sender, EventArgs e)
        {
            try
            {
                //if (m_txt_phi_gd.Text.Trim() != "")
                //{
                //    if (CIPConvert.ToDecimal(m_txt_phi_gd.Text) > m_dc_phi_gd_chuyen_nhuong_max)
                //    {
                //        BaseMessages.MsgBox_Infor("Phí GD của chuyển nhượng này lớn hơn phí chuyển  nhượng max. Hệ thống tự động sử dụng tỷ lệ phí GD max!");
                //        m_txt_phi_gd.Text = CIPConvert.ToStr(m_dc_phi_gd_chuyen_nhuong_max, "#,###");
                //    }
                //    if (CIPConvert.ToDecimal(m_txt_phi_gd.Text) < m_dc_phi_gd_chuyen_nhuong_min)
                //    {
                //        BaseMessages.MsgBox_Infor("Phí GD của chuyển nhượng này nhỏ hơn phí chuyển  nhượng min. Hệ thống tự động sử dụng tỷ lệ phí GD min!");
                //        m_txt_phi_gd.Text = CIPConvert.ToStr(m_dc_phi_gd_chuyen_nhuong_min, "#,###");
                //    }
                //}
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f600_giao_dich_chuyen_nhuong_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_danh_sach_chuyen_nhuong_Click(object sender, EventArgs e)
        {
            try
            {
                Show_danh_muc_chuyen_nhuong();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_duyet_chuyen_nhuong_Click(object sender, EventArgs e)
        {
            try
            {                      
                duyet_chuyen_nhuong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f600_giao_dich_chuyen_nhuong_Load(object sender, EventArgs e)
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

        void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {                         
                sua_thong_tin_chuyen_nhuong();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {                
                lap_chuyen_nhuong();
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

        void m_cmd_chon_trai_phieu_Click(object sender, EventArgs e)
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

        void m_txt_phan_tram_thue_LostFocus(object sender, EventArgs e)
        {
            try
            {
                //if (!CValidateTextBox.IsValid(m_txt_phan_tram_thue, DataType.NumberType, allowNull.NO, false)) return;
                //if (!CValidateTextBox.IsValid(m_txt_so_luong_chuyen_nhuong, DataType.NumberType, allowNull.NO, false)) return;
                //if (!CIPConvert.is_valid_number(m_txt_phan_tram_thue.Text)) return;
                //if (!CIPConvert.is_valid_number(m_txt_so_luong_chuyen_nhuong.Text)) return;
                if (m_txt_phan_tram_thue.Text.Trim() == "") return;
                decimal v_dc_phan_tram_thue = CIPConvert.ToDecimal(m_txt_phan_tram_thue.Text);                
                decimal v_dc_so_luong_chuyen_nhuong = CIPConvert.ToDecimal(m_txt_so_luong_chuyen_nhuong.Text);
                m_txt_thue.Text = CIPConvert.ToStr(
                    v_dc_so_luong_chuyen_nhuong * v_dc_phan_tram_thue * CIPConvert.ToDecimal( m_txt_menh_gia.Text)
                    , "#,###");
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu, đây phải là số!");
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
                return;
            }
        }

        void m_cmd_chon_ben_mua_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_us_v_trai_phieu.IsIDNull()) {
                    MessageBox.Show("Cần chọn trái phiếu trước");
                    return;
                }
                 select_trai_chu_mua();
                
                    
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
                 if (m_us_v_trai_phieu.IsIDNull()) {
                    MessageBox.Show("Cần chọn trái phiếu trước");
                    return;
                }
                    select_trai_chu_ban();
                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion                                            
    }
}
 