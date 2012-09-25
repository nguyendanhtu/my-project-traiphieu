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

using C1.Win.C1FlexGrid;

namespace BondApp.DanhMuc
{
    public partial class f100_dm_to_chuc_phat_hanh_de : Form
    {
        public f100_dm_to_chuc_phat_hanh_de()
        {
            InitializeComponent();
            format_controls();
            set_define_events();
            m_lbl_to_chuc_phat_hanh.Font = new Font("Arial", 16);
            m_lbl_to_chuc_phat_hanh.ForeColor = Color.DarkRed;
            m_lbl_to_chuc_phat_hanh.TextAlign = ContentAlignment.MiddleCenter;
        }

        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_TO_CHUC_PHAT_HANH ip_us_to_chuc_phat_hanh)
        {
             m_e_form_mode = DataEntryFormMode.UpdateDataState;
             m_us_to_chuc_phat_hanh = ip_us_to_chuc_phat_hanh;
             this.ShowDialog();
        }
        private void us_object_2_form(US_DM_TO_CHUC_PHAT_HANH ip_to_chuc_phat_hanh)
        {
            m_txt_ma_to_chuc.Text = ip_to_chuc_phat_hanh.strMA_TO_CHUC_PHAT_HANH;
            m_txt_ten_to_chuc.Text = ip_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HÀNH;
            m_txt_ma_so_thue.Text = ip_to_chuc_phat_hanh.strMA_SO_THUE;
            m_txt_dia_chi.Text = ip_to_chuc_phat_hanh.strDIA_CHI_TRU_SO_CHINH;
            m_txt_dien_thoai.Text = ip_to_chuc_phat_hanh.strDIEN_THOAI;
            m_txt_fax.Text = ip_to_chuc_phat_hanh.strFAX;
            m_txt_chung_nhan_dkdn.Text = ip_to_chuc_phat_hanh.strCHUNG_NHAN_DKDN;
        }
        private void form_2_usobject(US_DM_TO_CHUC_PHAT_HANH op_to_chuc_phat_hanh)
        {
            op_to_chuc_phat_hanh.strMA_TO_CHUC_PHAT_HANH = m_txt_ma_to_chuc.Text;
            op_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HÀNH = m_txt_ten_to_chuc.Text;
            op_to_chuc_phat_hanh.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            op_to_chuc_phat_hanh.strDIA_CHI_TRU_SO_CHINH = m_txt_dia_chi.Text;
            op_to_chuc_phat_hanh.strDIEN_THOAI = m_txt_dien_thoai.Text;
            op_to_chuc_phat_hanh.strFAX = m_txt_fax.Text;
            op_to_chuc_phat_hanh.strCHUNG_NHAN_DKDN = m_txt_chung_nhan_dkdn.Text;
        }
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_to_chuc,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ten_to_chuc,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }
            
            if (!CValidateTextBox.IsValid(m_txt_ma_so_thue,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_dia_chi,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_dien_thoai,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_fax,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_chung_nhan_dkdn,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            return true;
        }
        private void save_data()
        {
            if(check_validate_data_is_ok() == false) return;
            form_2_usobject(m_us_to_chuc_phat_hanh);
            switch(m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_to_chuc_phat_hanh.Insert();
                    break;

                case DataEntryFormMode.SelectDataState:
                    break;
                
                case DataEntryFormMode.UpdateDataState:
                    m_us_to_chuc_phat_hanh.Update();
                    break;

                case DataEntryFormMode.ViewDataState:
                    break;

                default:
                    break;
            }

            BaseMessages.MsgBox_Infor(10); //Dữ liệu đã cập nhật thành công
            this.Close();
        }
        private void set_define_events()
        {
            this.Load += new EventHandler(f100_dm_to_chuc_phat_hanh_de_Load);
            m_cmd_luu.Click += new EventHandler(m_cmd_luu_Click);
            m_cmd_thoat.Click += new EventHandler(m_cmd_thoat_Click);
        }

        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
        }

        #endregion

        #region Members
        US_DM_TO_CHUC_PHAT_HANH m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
               
        #region Data Structure
        #endregion

        #region Event
        void m_cmd_thoat_Click(object sender, EventArgs e)
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
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_to_chuc_phat_hanh);
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
        #endregion
    }
}
