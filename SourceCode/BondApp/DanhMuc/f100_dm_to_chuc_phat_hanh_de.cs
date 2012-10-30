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

using C1.Win.C1FlexGrid;

namespace BondApp.DanhMuc
{
    public partial class f100_dm_to_chuc_phat_hanh_de : Form
    {
        public f100_dm_to_chuc_phat_hanh_de()
        {
            InitializeComponent();
            format_controls();
            
           
        }

        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = e_form_mode.THEM_TO_CHUC_PHAT_HANH;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_TO_CHUC_PHAT_HANH ip_us_to_chuc_phat_hanh)
        {
            m_e_form_mode = e_form_mode.SUA_TO_CHUC_PHAT_HANH;
             m_us_to_chuc_phat_hanh = ip_us_to_chuc_phat_hanh;
             this.ShowDialog();
        }
        public void display_for_duyet(US_V_DM_TO_CHUC_PHAT_HANH ip_us_to_chuc_phat_hanh)
        {
            m_e_form_mode = e_form_mode.DUYET_DU_LIEU;
            m_us_to_chuc_phat_hanh = ip_us_to_chuc_phat_hanh;
            this.ShowDialog();
        }
        #endregion

    
        #region Members
        US_V_DM_TO_CHUC_PHAT_HANH m_us_to_chuc_phat_hanh = new US_V_DM_TO_CHUC_PHAT_HANH();
        e_form_mode m_e_form_mode = e_form_mode.THEM_TO_CHUC_PHAT_HANH;
        #endregion
               
        #region Data Structure
        public enum e_form_mode
        {
           THEM_TO_CHUC_PHAT_HANH = 0
           , SUA_TO_CHUC_PHAT_HANH = 1
            , DUYET_DU_LIEU = 2
        }
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            m_lbl_to_chuc_phat_hanh.Font = new Font("Arial", 16);
            m_lbl_to_chuc_phat_hanh.ForeColor = Color.DarkRed;
            m_lbl_to_chuc_phat_hanh.TextAlign = ContentAlignment.MiddleCenter;
            set_define_events();
        }

        private void set_inital_form_load()
        {
            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_TO_CHUC_PHAT_HANH:
                    m_cmd_luu.Text = "Lưu";
                    break;
                case e_form_mode.SUA_TO_CHUC_PHAT_HANH:
                    m_cmd_luu.Text = "Lưu";
                    us_object_2_form(m_us_to_chuc_phat_hanh);
                    break;
                case e_form_mode.DUYET_DU_LIEU:
                    m_cmd_luu.Text = "Duyệt";
                    us_object_2_form(m_us_to_chuc_phat_hanh);
                    break;
                default:
                    break;
            }
        }
        private void us_object_2_form(US_V_DM_TO_CHUC_PHAT_HANH ip_to_chuc_phat_hanh)
        {
            m_txt_ma_to_chuc.Text = ip_to_chuc_phat_hanh.strMA_TO_CHUC_PHAT_HANH;
            m_txt_ten_to_chuc.Text = ip_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH;
            m_txt_chung_nhan_dkdn.Text = ip_to_chuc_phat_hanh.strCHUNG_NHAN_DKDN;
            m_txt_ma_so_thue.Text = ip_to_chuc_phat_hanh.strMA_SO_THUE;
            m_txt_so_tai_khoan.Text = ip_to_chuc_phat_hanh.strSO_TAI_KHOAN;
            m_txt_mo_tai_ngan_hang.Text = ip_to_chuc_phat_hanh.strMO_TAI_NGAN_HANG;
            m_txt_dien_thoai.Text = ip_to_chuc_phat_hanh.strDIEN_THOAI;
            m_txt_fax.Text = ip_to_chuc_phat_hanh.strFAX;
            m_txt_dia_chi.Text = ip_to_chuc_phat_hanh.strDIA_CHI_TRU_SO_CHINH;
        }
        private void form_2_usobject(US_V_DM_TO_CHUC_PHAT_HANH op_to_chuc_phat_hanh)
        {
            op_to_chuc_phat_hanh.strMA_TO_CHUC_PHAT_HANH = m_txt_ma_to_chuc.Text.Trim();
            op_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH = m_txt_ten_to_chuc.Text.Trim();
            op_to_chuc_phat_hanh.strCHUNG_NHAN_DKDN = m_txt_chung_nhan_dkdn.Text.Trim();
            op_to_chuc_phat_hanh.strMA_SO_THUE = m_txt_ma_so_thue.Text.Trim();
            op_to_chuc_phat_hanh.strSO_TAI_KHOAN = m_txt_so_tai_khoan.Text.Trim();
            op_to_chuc_phat_hanh.strMO_TAI_NGAN_HANG = m_txt_mo_tai_ngan_hang.Text.Trim();
            op_to_chuc_phat_hanh.strDIEN_THOAI = m_txt_dien_thoai.Text.Trim();
            op_to_chuc_phat_hanh.strFAX = m_txt_fax.Text.Trim();
            op_to_chuc_phat_hanh.strDIA_CHI_TRU_SO_CHINH = m_txt_dia_chi.Text.Trim();
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_to_chuc, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ten_to_chuc, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_chung_nhan_dkdn, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ma_so_thue, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_so_tai_khoan, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_mo_tai_ngan_hang, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_dien_thoai, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_usobject(m_us_to_chuc_phat_hanh);
            switch (m_e_form_mode)
            {
                case e_form_mode.THEM_TO_CHUC_PHAT_HANH:
                    m_us_to_chuc_phat_hanh.dcID_NGUOI_LAP = CAppContext_201.getCurrentUserID();
                    m_us_to_chuc_phat_hanh.SetID_NGUOI_DUYETNull();
                    m_us_to_chuc_phat_hanh.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_LAP;
                    m_us_to_chuc_phat_hanh.Insert();
                    break;

                case e_form_mode.SUA_TO_CHUC_PHAT_HANH:
                    m_us_to_chuc_phat_hanh.Update();
                    break;

                case e_form_mode.DUYET_DU_LIEU:
                    m_us_to_chuc_phat_hanh.dcID_NGUOI_DUYET = CAppContext_201.getCurrentUserID();
                    m_us_to_chuc_phat_hanh.dcID_TRANG_THAI = TRANG_THAI_DANH_MUC.DA_DUYET;
                    m_us_to_chuc_phat_hanh.Update();
                    break;

                default:
                    break;
            }

            BaseMessages.MsgBox_Infor(10); //Dữ liệu đã cập nhật thành công
            this.Close();
        }

        #endregion


        #region Event
        private void set_define_events()
        {
            this.Load += new EventHandler(f100_dm_to_chuc_phat_hanh_de_Load);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(f100_dm_to_chuc_phat_hanh_de_KeyDown);
        }

        void f100_dm_to_chuc_phat_hanh_de_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_luu_Click(object sender, EventArgs e)
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

        void f100_dm_to_chuc_phat_hanh_de_Load(object sender, EventArgs e)
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
        #endregion
    }
}
