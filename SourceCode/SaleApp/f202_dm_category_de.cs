using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

using BondUS;
using BondDS;
using Sale.CDBNames;

namespace BondApp
{
    public partial class f202_dm_category_de : Form
    {
        public f202_dm_category_de()
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
        public void display_for_update(US_DM_CATEGORY ip_us_category)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_category = ip_us_category;
            this.ShowDialog();

        }
        #endregion

        #region Members
        US_DM_CATEGORY m_us_category = new US_DM_CATEGORY();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
        }

        private void load_data_2_cbo()
        {
            US_DM_CATEGORY v_us_category = new US_DM_CATEGORY();
            DS_DM_CATEGORY v_ds_category = new DS_DM_CATEGORY();
            v_us_category.FillDataset(v_ds_category, " ORDER BY " + DM_CATEGORY.DISPLAY_ORDER);
            v_ds_category.EnforceConstraints = false;
            DataRow v_dr_default = v_ds_category.DM_CATEGORY.NewDM_CATEGORYRow();
            v_dr_default[DM_CATEGORY.ID] = -1;
            v_dr_default[DM_CATEGORY.CATEGORY_NAME] = "Không có cấp trên";
            v_ds_category.DM_CATEGORY.Rows.InsertAt(v_dr_default, 0);

            m_cbo_parent_name.DisplayMember = DM_CATEGORY.CATEGORY_NAME;
            m_cbo_parent_name.ValueMember = DM_CATEGORY.ID;
            m_cbo_parent_name.DataSource = v_ds_category.DM_CATEGORY;


        }


        private void us_object_2_form(US_DM_CATEGORY ip_us_category)
        {
            m_txt_category_code.Text = ip_us_category.strCATEGORY_CODE;
            m_txt_category_name.Text = ip_us_category.strCATEGORY_NAME;
            m_txt_category_display_level.Text = CIPConvert.ToStr(ip_us_category.dcDISPLAY_LEVEL);
            m_txt_category_display_order.Text = CIPConvert.ToStr(ip_us_category.dcDISPLAY_ORDER);
            m_txt_description.Text = ip_us_category.strCATEGORY_DESCRIPTION;
            m_cbo_parent_name.SelectedValue = ip_us_category.dcCATEGORY_PARENT_ID;

        }


        private void form_2_us_object(US_DM_CATEGORY op_us_category)
        {
            op_us_category.strCATEGORY_CODE = m_txt_category_code.Text;
            op_us_category.strCATEGORY_NAME = m_txt_category_name.Text;

            if (m_txt_category_display_level.Text.Trim().Length == 0)
            {
                op_us_category.SetDISPLAY_LEVELNull();
            }
            else
            {

                op_us_category.dcDISPLAY_LEVEL = CIPConvert.ToDecimal(m_txt_category_display_level.Text);
            }
            if (m_txt_category_display_order.Text.Trim().Length == 0)
            {
                op_us_category.SetDISPLAY_ORDERNull();
            }
            else
            {

                op_us_category.dcDISPLAY_ORDER = CIPConvert.ToDecimal(m_txt_category_display_order.Text);
            }
            op_us_category.strCATEGORY_DESCRIPTION = m_txt_description.Text;
            if ((decimal)m_cbo_parent_name.SelectedValue == -1)
            {
                op_us_category.SetCATEGORY_PARENT_IDNull();
            }
            else
            {
                op_us_category.dcCATEGORY_PARENT_ID = CIPConvert.ToDecimal(m_cbo_parent_name.SelectedValue);
            }
        }

        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_category_code, DataType.StringType, allowNull.NO, true)){
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_category_name, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_category_display_level, DataType.NumberType, allowNull.YES, true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_category_display_order, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            return true;
        }


        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us_category);
            switch (m_e_form_mode)  
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_category.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_category.Update();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }

            BaseMessages.MsgBox_Infor(10); //Dữ liệu cập nhật thành cộng
            this.Close();

        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.Load += new EventHandler(f202_dm_category_Load);


        }

        void f202_dm_category_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        us_object_2_form(m_us_category);
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

        

        #region Events
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