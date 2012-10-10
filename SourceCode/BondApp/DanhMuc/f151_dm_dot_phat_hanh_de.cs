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
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_V_DM_DOT_PHAT_HANH ip_us_v_dot_phat_hanh)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dot_phat_hanh = ip_us_v_dot_phat_hanh;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            
        }
        #endregion

        #region Members
        US_V_DM_DOT_PHAT_HANH m_us_dot_phat_hanh = new US_V_DM_DOT_PHAT_HANH();
        DS_V_DM_DOT_PHAT_HANH m_ds_dot_phat_hanh = new DS_V_DM_DOT_PHAT_HANH();

        US_DM_TO_CHUC_PHAT_HANH m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
        DS_DM_TO_CHUC_PHAT_HANH m_ds_to_chuc_phat_hanh = new DS_DM_TO_CHUC_PHAT_HANH();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
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
            m_txt_ten_to_chuc_phat_hanh.Text = m_us_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH;
            m_dat_ngay_phat_hanh.Value = m_us_dot_phat_hanh.datNGAY_PHAT_HANH;
            m_txt_ghi_chu.Text = m_us_dot_phat_hanh.strGHI_CHU;
        }
        private void form_2_us_object(US_V_DM_DOT_PHAT_HANH op_v_us_dot_phat_hanh)
        {
            op_v_us_dot_phat_hanh.strTEN_TO_CHUC_PHAT_HANH = m_txt_ten_to_chuc_phat_hanh.Text;
            op_v_us_dot_phat_hanh.datNGAY_PHAT_HANH = m_dat_ngay_phat_hanh.Value;
            op_v_us_dot_phat_hanh.strGHI_CHU = m_txt_ghi_chu.Text;
        }
        
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_to_chuc_phat_hanh, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu, DataType.StringType, allowNull.NO, true))
            { return false; }
            return true;
        }

        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_dot_phat_hanh);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dot_phat_hanh.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dot_phat_hanh.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }

            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }
      
        #endregion
        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f151_dm_dot_phat_hanh_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }
        void f151_dm_dot_phat_hanh_Load(object sender, EventArgs e)
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
                        us_object_2_form(m_us_dot_phat_hanh);
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
        #endregion


    }
}
