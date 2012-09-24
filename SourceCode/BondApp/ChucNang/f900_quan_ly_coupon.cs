using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BondApp.ChucNang
{
    public partial class f900_quan_ly_coupon : Form
    {
        public f900_quan_ly_coupon()
        {
            InitializeComponent();
        }

        #region Public interface

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            CHOT_LAI_YN = 3
,
            NGAY = 1
                ,
            CAP_NHAT_LS_YN = 4
                ,
            LAI_SUAT = 7
                ,
            THANH_TOAN_LAI_YN = 6
                ,
            THANH_TOAN_GOC_YN = 5
                ,
            DA_THUC_HIEN_YN = 8
                , NOI_DUNG_LICH = 2
        }
        #endregion

        #region Members
        /*US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu;
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;*/
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            set_define_event();
        }

        private void set_inital_form_load()
        {
            /*switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    us_object_2_form(m_us_trai_chu);
                    break;
            }*/
        }

        /*private void us_object_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            
        }

        private void form_2_us_object(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            
        }*/

        private bool check_data_is_ok()
        {
            /*if (!CValidateTextBox.IsValid(m_txt_ma_trai_chu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }*/
            return true;
        }

        private void set_define_event()
        {
               
        }

        private void save_data()
        {
            /*if (check_data_is_ok() == false)
            {
                return;
            }
            form_2_us_object(m_us_trai_chu);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_trai_chu.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_trai_chu.Update();
                    break;
            }

            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();*/
        }

        private void select_trai_phieu()
        {
            /*f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_trai_phieu.IsIDNull())
                m_txt_id_trai_phieu_so_huu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcID);*/
        }

        #endregion

        #region Events

        #endregion
    }
}
