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
using IP.Core.IPData.DBNames;

namespace BondApp.DanhMuc
{
    public partial class f151_dm_dot_phat_hanh_de : Form
    {
        public f151_dm_dot_phat_hanh_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display_for_insert()
        {
            m_e_form_mode = e_form_mode.THEM_TO_CHUC_PHAT_HANH;
            this.ShowDialog();
        }

        public void display_for_update(US_V_DM_DOT_PHAT_HANH ip_us_v_dot_phat_hanh)
        {
            m_e_form_mode = e_form_mode.SUA_TO_CHUC_PHAT_HANH;
            m_us_v_dot_phat_hanh = ip_us_v_dot_phat_hanh;
            this.ShowDialog();
        }

        public void display_for_duyet(US_V_DM_DOT_PHAT_HANH ip_us_v_dot_phat_hanh)
        {
            m_e_form_mode = e_form_mode.DUYET_DU_LIEU;
            m_us_v_dot_phat_hanh = ip_us_v_dot_phat_hanh;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            
        }
        public enum e_form_mode
        {
            THEM_TO_CHUC_PHAT_HANH = 0
            ,
            SUA_TO_CHUC_PHAT_HANH = 1
                , DUYET_DU_LIEU = 2
        }
        #endregion

        #region Members
        US_V_DM_DOT_PHAT_HANH m_us_v_dot_phat_hanh = new US_V_DM_DOT_PHAT_HANH();
        DS_V_DM_DOT_PHAT_HANH m_ds_v_dot_phat_hanh = new DS_V_DM_DOT_PHAT_HANH();
        e_form_mode m_e_form_mode = e_form_mode.THEM_TO_CHUC_PHAT_HANH;
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
        
        private void us_object_2_form(US_V_DM_DOT_PHAT_HANH ip_us_v_dot_phat_hanh)
        {
            US_DM_TO_CHUC_PHAT_HANH v_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(ip_us_v_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);
            m_cbo_ten_to_chuc_phat_hanh.SelectedText = v_us_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH;
            m_cbo_ten_to_chuc_phat_hanh.SelectedValue = CIPConvert.ToStr(ip_us_v_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);
            m_dat_ngay_phat_hanh.Value = m_us_v_dot_phat_hanh.datNGAY_PHAT_HANH;
            m_txt_ghi_chu.Text = m_us_v_dot_phat_hanh.strGHI_CHU;
            m_txt_tong_so_luong_tp.Text = CIPConvert.ToStr(ip_us_v_dot_phat_hanh.dcTONG_SO_LUONG_TRAI_PHIEU,"#,###");
            m_txt_menh_gia.Text = CIPConvert.ToStr(ip_us_v_dot_phat_hanh.dcMENH_GIA, "#,###");
            m_txt_ty_le_phi_chuyen_nhuong.Text = CIPConvert.ToStr(ip_us_v_dot_phat_hanh.dcTY_LE_PHI_CHUYEN_NHUONG * 100, "#,###");
            m_txt_ty_le_phi_phong_giai_toa.Text = CIPConvert.ToStr(ip_us_v_dot_phat_hanh.dcTY_LE_PHI_PHONG_GIAI_TOA * 100, "#,###");
            if (ip_us_v_dot_phat_hanh.dcID_NGAN_HANG_DAI_LY_QUAN_LY_TK > 0)
            {
                m_cbo_ngan_hang_quan_ly_tai_khoan.SelectedValue = ip_us_v_dot_phat_hanh.dcID_NGAN_HANG_DAI_LY_QUAN_LY_TK;
            }

            if (ip_us_v_dot_phat_hanh.strNGAY_LAM_VIEC_HAI_SAU_YN.Equals("Y"))
                m_cbo_loai_ngay_lam_viec.SelectedIndex = 0;
            else m_cbo_loai_ngay_lam_viec.SelectedIndex = 1;
        }
        private void form_2_us_object(US_V_DM_DOT_PHAT_HANH op_v_us_dot_phat_hanh)
        {
            op_v_us_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH = CIPConvert.ToDecimal(m_cbo_ten_to_chuc_phat_hanh.SelectedValue);
            op_v_us_dot_phat_hanh.datNGAY_PHAT_HANH = CIPConvert.ToDatetime(CIPConvert.ToStr(m_dat_ngay_phat_hanh.Value));
            op_v_us_dot_phat_hanh.dcMENH_GIA = CIPConvert.ToDecimal(m_txt_menh_gia.Text);
            op_v_us_dot_phat_hanh.dcTONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH = CIPConvert.ToDecimal(m_txt_tong_gia_tri.Text);
            op_v_us_dot_phat_hanh.dcTONG_SO_LUONG_TRAI_PHIEU = CIPConvert.ToDecimal(m_txt_tong_so_luong_tp.Text);
            op_v_us_dot_phat_hanh.strGHI_CHU = m_txt_ghi_chu.Text;
            op_v_us_dot_phat_hanh.dcTY_LE_PHI_CHUYEN_NHUONG = CIPConvert.ToDecimal(m_txt_ty_le_phi_chuyen_nhuong.Text)/100;
            op_v_us_dot_phat_hanh.dcTY_LE_PHI_PHONG_GIAI_TOA = CIPConvert.ToDecimal(m_txt_ty_le_phi_phong_giai_toa.Text)/100;
            if (m_cbo_ngan_hang_quan_ly_tai_khoan.SelectedValue != null)
                op_v_us_dot_phat_hanh.dcID_NGAN_HANG_DAI_LY_QUAN_LY_TK = CIPConvert.ToDecimal(m_cbo_ngan_hang_quan_ly_tai_khoan.SelectedValue);
            if (m_cbo_loai_ngay_lam_viec.SelectedIndex == 0)
                op_v_us_dot_phat_hanh.strNGAY_LAM_VIEC_HAI_SAU_YN = "Y";
            else op_v_us_dot_phat_hanh.strNGAY_LAM_VIEC_HAI_SAU_YN = "N";
        }
        
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_menh_gia, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tong_so_luong_tp, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tong_gia_tri, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ty_le_phi_chuyen_nhuong, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ty_le_phi_phong_giai_toa, DataType.NumberType, allowNull.NO, true))
            {
                return false;
            }
            return true;
        }
        private void load_data_2_cbo_to_chuc_phat_hanh()
        {
            US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
            DS_DM_TO_CHUC_PHAT_HANH v_ds_dm_to_chuc_phat_hanh = new DS_DM_TO_CHUC_PHAT_HANH();

            v_us_dm_to_chuc_phat_hanh.FillDataset(v_ds_dm_to_chuc_phat_hanh, " WHERE ID_TRANG_THAI = " + TRANG_THAI_DANH_MUC.DA_DUYET);

            m_cbo_ten_to_chuc_phat_hanh.ValueMember = DM_TO_CHUC_PHAT_HANH.ID;
            m_cbo_ten_to_chuc_phat_hanh.DisplayMember = DM_TO_CHUC_PHAT_HANH.TEN_TO_CHUC_PHAT_HANH;
            m_cbo_ten_to_chuc_phat_hanh.DataSource = v_ds_dm_to_chuc_phat_hanh.DM_TO_CHUC_PHAT_HANH;
        }
        private void load_data_2_cbo_ngan_hang_quan_ly_tk()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_diem = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = v_us_cm_dm_tu_diem.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.NGAN_HANG_DL_QUAN_LY_TK);
            m_cbo_ngan_hang_quan_ly_tai_khoan.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_ngan_hang_quan_ly_tai_khoan.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_ngan_hang_quan_ly_tai_khoan.DataSource = v_ds_cm_dm_tu_dien.Tables[0];
        }
        private void load_data_2_cbo_loai_ngay_lam_viec()
        {
            US_CM_DM_TU_DIEN v_us_cm_dm_tu_diem = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = v_us_cm_dm_tu_diem.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.LOAI_NGAY_LAM_VIEC);
            m_cbo_loai_ngay_lam_viec.DataSource = v_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_ngay_lam_viec.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_ngay_lam_viec.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_ngay_lam_viec.Text = "";
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_v_dot_phat_hanh);
            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_TO_CHUC_PHAT_HANH:
                    m_us_v_dot_phat_hanh.Insert();
                    break;
                case e_form_mode.SUA_TO_CHUC_PHAT_HANH:
                    m_us_v_dot_phat_hanh.Update();
                    break;
                case e_form_mode.DUYET_DU_LIEU:
                    m_us_v_dot_phat_hanh.dcID_NGUOI_DUYET = CAppContext_201.getCurrentUserID();
                    m_us_v_dot_phat_hanh.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_DUYET;
                    m_us_v_dot_phat_hanh.Update();
                    break;
                default:
                    break;
            }

            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }
        private void computeTotalValue()
        {
            try
            {
                decimal v_d_menhgia = CIPConvert.ToDecimal(m_txt_menh_gia.Text);
                decimal v_d_tongsl = CIPConvert.ToDecimal(m_txt_tong_so_luong_tp.Text);
                m_txt_tong_gia_tri.Text = CIPConvert.ToStr(v_d_menhgia * v_d_tongsl);
            }
            catch
            { 

            }
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f151_dm_dot_phat_hanh_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_txt_menh_gia.TextChanged +=new EventHandler(m_txt_menh_gia_TextChanged);
            m_txt_tong_so_luong_tp.TextChanged += new EventHandler(m_txt_tong_so_luong_tp_TextChanged);
        }
        private void m_txt_tong_so_luong_tp_TextChanged(object sender, EventArgs e)
        {
            computeTotalValue();
        }
        private void m_txt_menh_gia_TextChanged(object sender, EventArgs e)
        {
            computeTotalValue();
        }
        void f151_dm_dot_phat_hanh_Load(object sender, EventArgs e)
        {
            try
            {
                switch (m_e_form_mode)
                {
                    case e_form_mode.THEM_TO_CHUC_PHAT_HANH:
                        load_data_2_cbo_to_chuc_phat_hanh();
                        load_data_2_cbo_ngan_hang_quan_ly_tk();
                        m_cmd_save.Text = "Lưu";
                        break;
                    case e_form_mode.SUA_TO_CHUC_PHAT_HANH:
                        load_data_2_cbo_to_chuc_phat_hanh();
                        load_data_2_cbo_ngan_hang_quan_ly_tk();
                        us_object_2_form(m_us_v_dot_phat_hanh);
                        m_cmd_save.Text = "Lưu";
                        break;
                    case e_form_mode.DUYET_DU_LIEU:
                        m_cmd_save.Text = "Duyệt";
                        load_data_2_cbo_to_chuc_phat_hanh();
                        load_data_2_cbo_ngan_hang_quan_ly_tk();
                        us_object_2_form(m_us_v_dot_phat_hanh);
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
        #endregion
    }
}
