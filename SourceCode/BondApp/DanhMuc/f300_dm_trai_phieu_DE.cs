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


using BondUS;
using BondDS;
using BondDS.CDBNames;

namespace BondApp.DanhMuc
{
    public partial class f300_dm_trai_phieu_DE : Form
    {
        public f300_dm_trai_phieu_DE()
        {
            InitializeComponent();
            format_controls();
            set_define_events();
        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_TRAI_PHIEU ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_trai_phieu = ip_us;
            this.ShowDialog();
        }
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
        }
        private void select_to_chuc_phat_hanh()
        {
            f100_dm_to_chuc_phat_hanh v_frm100 = new f100_dm_to_chuc_phat_hanh();
            m_us_to_chuc_phat_hanh = v_frm100.select_to_chuc_phat_hanh();
            us_to_chuc_phat_hanh_2_form(m_us_to_chuc_phat_hanh);
        }
        private void us_to_chuc_phat_hanh_2_form(US_DM_TO_CHUC_PHAT_HANH ip_us_to_chuc_phat_hanh)
        {
            if (ip_us_to_chuc_phat_hanh.IsIDNull()) return;
            m_txt_ma_to_chuc_phat_hanh.Text = ip_us_to_chuc_phat_hanh.strMA_TO_CHUC_PHAT_HANH;
        }
        private void us_object_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(ip_us_trai_phieu.dcID_TO_CHUC_PHAT_HANH);
            m_us_tu_dien = new US_CM_DM_TU_DIEN(ip_us_trai_phieu.dcID_LOAI_TRAI_PHIEU);
            m_txt_ten_trai_phieu.Text = m_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_ma_to_chuc_phat_hanh.Text = m_us_to_chuc_phat_hanh.strMA_TO_CHUC_PHAT_HANH;
            m_txt_ma_trai_phieu.Text = m_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ma_loai_trai_phieu.Text = m_us_tu_dien.strMA_TU_DIEN;
            m_txt_ky_han.Text = m_us_trai_phieu.dcKY_HAN.ToString();
            m_txt_ky_dieu_chinh_ls.Text = m_us_trai_phieu.dcKY_DIEU_CHINH_LS.ToString();
            m_txt_ky_tra_lai.Text = m_us_trai_phieu.dcKY_TRA_LAI.ToString();
            m_txt_menh_gia.Text = m_us_trai_phieu.dcMENH_GIA.ToString();
            m_txt_tong_sl.Text = m_us_trai_phieu.dcTONG_SL_PHAT_HANH.ToString();
            m_txt_lai_suat.Text = m_us_trai_phieu.dcLAI_SUAT_DEFAULT.ToString();
        }
        private void form_2_us_object(US_DM_TRAI_PHIEU op_us_trai_phieu)
        {
            op_us_trai_phieu.strTEN_TRAI_PHIEU = m_txt_ten_trai_phieu.Text;
            op_us_trai_phieu.dcID_TO_CHUC_PHAT_HANH = m_us_to_chuc_phat_hanh.dcID;
            op_us_trai_phieu.strMA_TRAI_PHIEU = m_txt_ma_trai_phieu.Text;
            op_us_trai_phieu.dcID_LOAI_TRAI_PHIEU = m_us_tu_dien.dcID_LOAI_TU_DIEN;
            op_us_trai_phieu.dcKY_HAN = decimal.Parse(m_txt_ky_han.Text.ToString());
            op_us_trai_phieu.dcKY_DIEU_CHINH_LS = decimal.Parse(m_txt_ky_dieu_chinh_ls.Text);
            op_us_trai_phieu.dcKY_TRA_LAI = decimal.Parse(m_txt_ky_tra_lai.Text);
            op_us_trai_phieu.dcMENH_GIA = decimal.Parse(m_txt_menh_gia.Text);
            op_us_trai_phieu.dcTONG_SL_PHAT_HANH = decimal.Parse(m_txt_tong_sl.Text);
            op_us_trai_phieu.dcLAI_SUAT_DEFAULT = decimal.Parse(m_txt_lai_suat.Text);
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ma_to_chuc_phat_hanh, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ma_loai_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_han, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_dieu_chinh_ls, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_tra_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_menh_gia, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_tong_sl, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_lai_suat, DataType.NumberType, allowNull.NO, true))
            { return false; }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_trai_phieu);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_trai_phieu.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_trai_phieu.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }
        private void set_define_events()
        {
            this.Load += new EventHandler(f300_dm_trai_phieu_DE_Load);
            m_cmd_ma_to_chuc_phat_hanh.Click += new EventHandler(m_cmd_ma_to_chuc_phat_hanh_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }
        void f300_dm_trai_phieu_DE_Load(object sender, EventArgs e)
        {
            try
            {
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_trai_phieu);
                        break;
                    case DataEntryFormMode.ViewDataState:
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
        void m_cmd_ma_to_chuc_phat_hanh_Click(object sender, EventArgs e)
        {
            try
            {
                select_to_chuc_phat_hanh();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
        #region Members
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        US_DM_TO_CHUC_PHAT_HANH m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
        US_CM_DM_TU_DIEN m_us_tu_dien = new US_CM_DM_TU_DIEN();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
        #region Data Structures
        #endregion
        #region Events
        #endregion
    }
}
