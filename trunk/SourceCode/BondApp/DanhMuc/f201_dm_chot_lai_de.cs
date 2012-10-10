using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BondUS;
using IP.Core.IPCommon;

namespace BondApp
{
    public partial class f201_dm_chot_lai_de : Form
    {
        public f201_dm_chot_lai_de()
        {
            InitializeComponent();
            format_control();
            set_define_events();
        }

        #region Public Interface

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_GD_CHOT_LAI ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_gd_chot_lai = ip_us;
            this.ShowDialog();
        }

        #endregion

        #region Members
        US_GD_CHOT_LAI m_us_gd_chot_lai = new US_GD_CHOT_LAI();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
        
        #region Data Structure
        #endregion
        
        #region Private Method

        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
        }

        private void us_object_2_form(US_GD_CHOT_LAI ip_us_gd_chot_lai)
        {
            //m_dat_to_date.Value = m_dat_from_date.Value;
            m_dat_ngay_chot_lai.Value = m_us_gd_chot_lai.datNGAY_CHOT_LAI;
            m_dat_ngay_thanh_toan.Value = m_us_gd_chot_lai.datNGAY_THANH_TOAN;
            m_txt_trai_phieu.Text = m_us_gd_chot_lai.dcID_TRAI_PHIEU.ToString();
            m_txt_ki_tinh_lai.Text = m_us_gd_chot_lai.dcKY_TINH_LAI.ToString();
            m_txt_trang_thai.Text = m_us_gd_chot_lai.dcTRANG_THAI.ToString();
            m_txt_nguoi_lap.Text = m_us_gd_chot_lai.dcID_NGUOI_LAP.ToString();
            m_txt_nguoi_duyet.Text = m_us_gd_chot_lai.dcID_NGUOI_DUYET.ToString();
            m_txt_ghi_chu.Text = m_us_gd_chot_lai.strGHI_CHU1;
            m_txt_muc_dich.Text = m_us_gd_chot_lai.strMUC_DICH;   
        }

        private void form_2_us_object(US_GD_CHOT_LAI op_us_gd_chot_lai)
        {
            //op_us_trai_phieu.datNGAY_PHAT_HANH = m_dat_ngay_phat_hanh.Value.Date;
            op_us_gd_chot_lai.datNGAY_CHOT_LAI = m_dat_ngay_chot_lai.Value;
            op_us_gd_chot_lai.datNGAY_THANH_TOAN = m_dat_ngay_thanh_toan.Value;
            op_us_gd_chot_lai.dcID_TRAI_PHIEU = CIPConvert.ToDecimal(m_txt_trai_phieu.Text);
            op_us_gd_chot_lai.dcKY_TINH_LAI = CIPConvert.ToDecimal(m_txt_ki_tinh_lai.Text);
            op_us_gd_chot_lai.dcTRANG_THAI = CIPConvert.ToDecimal(m_txt_trang_thai.Text);
            op_us_gd_chot_lai.dcID_NGUOI_LAP = CIPConvert.ToDecimal(m_txt_nguoi_lap.Text);
            op_us_gd_chot_lai.dcID_NGUOI_DUYET = CIPConvert.ToDecimal(m_txt_nguoi_duyet.Text);
            op_us_gd_chot_lai.strGHI_CHU1 = m_txt_ghi_chu.Text;
            op_us_gd_chot_lai.strMUC_DICH = m_txt_muc_dich.Text;
         }

        private bool check_validate_data_is_ok()
        {
            return true;
        }

        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_gd_chot_lai);
            switch (m_e_form_mode)
            { 
                case DataEntryFormMode.InsertDataState:
                    m_us_gd_chot_lai.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_chot_lai.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void set_define_events()
        { 
            this.Load +=new EventHandler(f201_dm_chot_lai_de_Load);
            m_cmd_luu.Click +=new EventHandler(m_cmd_luu_Click);
            m_cmd_exit.Click +=new EventHandler(m_cmd_exit_Click);
        }

        #endregion        
        
        #region Event

        private void m_cmd_luu_Click(object sender, EventArgs e)
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
        
        private void f201_dm_chot_lai_de_Load(object sender, EventArgs e)
        {
            try
            {
                switch (m_e_form_mode)
                { 
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_gd_chot_lai);
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