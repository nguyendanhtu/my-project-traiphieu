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
//using IP.Core.IPData;
//using BondDS.CDBNames;
using IP.Core.IPSystemAdmin;

namespace BondApp.HeThong
{
    public partial class f108_tham_so_he_thong_de : Form
    {
        public f108_tham_so_he_thong_de()
        {
            InitializeComponent();
            format_control();
        }

        #region Public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_HT_THAM_SO_HE_THONG ip_us_ht_tham_so_he_thong)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_ht_tham_so_he_thong = ip_us_ht_tham_so_he_thong;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        //private enum e_col_Number
        //{
        //}
        #endregion

        #region Members
        US_HT_THAM_SO_HE_THONG m_us_ht_tham_so_he_thong = new US_HT_THAM_SO_HE_THONG();
        DS_HT_THAM_SO_HE_THONG m_ds_ht_tham_so_he_thong = new DS_HT_THAM_SO_HE_THONG();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Mehod
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            this.KeyPreview = true;
            set_define_event();
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void set_define_event()
        {
            this.Load += new EventHandler(f108_tham_so_he_thong_de_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
        }
        

        private void set_inital_form_load()
        {
            //if (check_data_is_ok() == false) return;
            //form_2_us_object(m_us_ht_tham_so_he_thong);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    us_object_2_form(m_us_ht_tham_so_he_thong);
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void us_object_2_form(US_HT_THAM_SO_HE_THONG ip_us_ht_tham_so_he_thong)
        {
            m_us_ht_tham_so_he_thong = new US_HT_THAM_SO_HE_THONG(ip_us_ht_tham_so_he_thong.dcID);
            m_txt_loai_tham_so.Text = ip_us_ht_tham_so_he_thong.strLOAI_THAM_SO;
            m_txt_ma_tham_so.Text = ip_us_ht_tham_so_he_thong.strMA_THAM_SO;
            m_txt_gia_tri.Text = ip_us_ht_tham_so_he_thong.strGIA_TRI;
            m_txt_ghi_chu.Text = ip_us_ht_tham_so_he_thong.strGHI_CHU;
        }

        private void form_2_us_object(US_HT_THAM_SO_HE_THONG ip_us_ht_tham_so_he_thong)
        {
            ip_us_ht_tham_so_he_thong.strLOAI_THAM_SO = m_txt_loai_tham_so.Text;
            ip_us_ht_tham_so_he_thong.strMA_THAM_SO = m_txt_ma_tham_so.Text;
            ip_us_ht_tham_so_he_thong.strGIA_TRI = m_txt_gia_tri.Text;
            ip_us_ht_tham_so_he_thong.strGHI_CHU = m_txt_ghi_chu.Text;
            ip_us_ht_tham_so_he_thong.strPHAN_HE = "SD";
            ip_us_ht_tham_so_he_thong.strKIEU_DU_LIEU = "Numeric";
            ip_us_ht_tham_so_he_thong.strCO_THE_NULL_YN = "N";
        }

        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_loai_tham_so,DataType.StringType,allowNull.NO,true))
            {
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ma_tham_so, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_gia_tri, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            return true;
        }

        private void save_data()
        {
            if (check_data_is_ok() == false)
            {
                return;
            }
            form_2_us_object(m_us_ht_tham_so_he_thong);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_ht_tham_so_he_thong.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_ht_tham_so_he_thong.Update();
                    break;
            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();
        }

        //private void update_dm_to_chuc_phat_hanh()
        //{
        //    if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
        //    if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
        //    grid2us_object(m_us, m_fg.Row);
        //    f100_dm_to_chuc_phat_hanh_de frm100 = new f100_dm_to_chuc_phat_hanh_de();
        //    frm100.display_for_update(m_us);
        //    load_data_2_grid();
        //}

        //private void update_ht_tham_so_he_thong()
        //{
        //    if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
        //    if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
        //    grid2us_object(m_us, m_fg.Row);
        //    f108_tham_so_he_thong_de frm108 = new f108_tham_so_he_thong_de();
        //    frm108.display_for_update(m_us);
        //    load_data_2_grid();
            
        //}

        #endregion

        #region Events

        void f108_tham_so_he_thong_de_Load(object sender, EventArgs e)
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

        //private void m_cmd_update_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        update_ht_tham_so_he_thong();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}



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
        #endregion

    }
}
