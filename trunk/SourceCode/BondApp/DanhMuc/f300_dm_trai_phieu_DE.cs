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
            
        }
        private void us_object_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            
        }
        private void form_2_us_object(US_DM_TRAI_PHIEU op_us_trai_phieu)
        {

        }
        private bool check_validate_data_is_ok()
        {
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
            m_cmd_ma_to_chuc_phat_hanh.Click += new EventHandler(m_cmd_ma_to_chuc_phat_hanh_Click);
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
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
        #region Data Structures
        #endregion
        #region Events
        #endregion
    }
}
