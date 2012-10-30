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
using IP.Core.IPData.DBNames;
using System.Collections;
using C1.Win.C1FlexGrid;
using BondApp.DanhMuc;
using BondUS;
namespace BondApp.ChucNang
{
    public partial class f250_chi_tiet_giao_dich_chot_lai : Form
    {
        public f250_chi_tiet_giao_dich_chot_lai()
        {
            InitializeComponent(); 
            format_controls();
        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_GD_CHOT_LAI_DETAIL ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_gd_chot_lai_detail = ip_us;
            this.ShowDialog();
        }
        #endregion
        #region Members
        US_GD_CHOT_LAI_DETAIL m_us_gd_chot_lai_detail = new US_GD_CHOT_LAI_DETAIL();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
        #region Data Structures
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
        private void us_object_2_form(US_GD_CHOT_LAI_DETAIL ip_us_trai_phieu)
        {
            m_txt_so_tien_lai.Text = CIPConvert.ToStr(m_us_gd_chot_lai_detail.dcSO_TIEN_LAI);
        }
        private void form_2_us_object(US_GD_CHOT_LAI_DETAIL op_us_gd_chot_lai_de)
        {
            op_us_gd_chot_lai_de.dcSO_TIEN_LAI = CIPConvert.ToDecimal(m_txt_so_tien_lai.Text);
        }  
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_so_tien_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_gd_chot_lai_detail);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_chot_lai_detail.Update();
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
            this.Load += new EventHandler(f300_dm_trai_phieu_DE_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(f250_chi_tiet_giao_dich_chot_lai_KeyDown);
        }

        void f250_chi_tiet_giao_dich_chot_lai_KeyDown(object sender, KeyEventArgs e)
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
                        us_object_2_form(m_us_gd_chot_lai_detail);
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