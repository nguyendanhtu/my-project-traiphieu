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
        #region Members
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        US_DM_TO_CHUC_PHAT_HANH m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH();
        US_CM_DM_TU_DIEN m_us_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion
        #region Data Structures
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
            m_lbl_ten_to_chuc_phat_hanh.Text = ip_us_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH;
        }
        private void us_object_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
            m_us_tu_dien = new US_CM_DM_TU_DIEN(ip_us_trai_phieu.dcID_LOAI_TRAI_PHIEU);

            m_txt_ten_trai_phieu.Text = m_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_ma_trai_phieu.Text = m_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ky_han.Text = m_us_trai_phieu.dcKY_HAN.ToString();
            m_txt_ky_dieu_chinh_ls.Text = m_us_trai_phieu.dcKY_DIEU_CHINH_LS.ToString();
            m_txt_ky_tra_lai.Text = m_us_trai_phieu.dcKY_TRA_LAI.ToString();
            /*m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_tong_sl.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_SL_PHAT_HANH, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_trai_phieu.dcLAI_SUAT_DEFAULT);
            m_dat_ngay_phat_hanh.Value = m_us_trai_phieu.datNGAY_PHAT_HANH;
            m_dat_ngay_dao_han.Value = m_us_trai_phieu.datNGAY_DAO_HAN;*/

            m_cbo_co_so_tinh_lai.SelectedText = m_us_trai_phieu.strCO_SO_TINH_LAI;
            m_cbo_loai_trai_phieu.SelectedText = m_us_tu_dien.strTEN;
            m_cbo_loai_trai_phieu.SelectedValue = m_us_tu_dien.dcID;

            m_us_tu_dien = new US_CM_DM_TU_DIEN(m_us_trai_phieu.dcID_DV_KY_HAN);
            m_cbo_don_vi_ky_han.SelectedText = m_us_tu_dien.strTEN;
            m_cbo_don_vi_ky_han.SelectedValue = m_us_tu_dien.dcID;

            m_us_tu_dien = new US_CM_DM_TU_DIEN(m_us_trai_phieu.dcID_DV_DIEU_CHINH_LS);
            m_cbo_dv_dieu_chinh_ls.SelectedText = m_us_tu_dien.strTEN;
            m_cbo_dv_dieu_chinh_ls.SelectedValue = m_us_tu_dien.dcID;

            m_us_tu_dien = new US_CM_DM_TU_DIEN(m_us_trai_phieu.dcID_DV_KY_TRA_LAI);
            m_cbo_dv_tra_lai.SelectedText = m_us_tu_dien.strTEN;
            m_cbo_dv_tra_lai.SelectedValue = m_us_tu_dien.dcID;
            if (m_us_trai_phieu.strTRA_LAI_SAU_YN.ToUpper() == "Y")
                m_cbo_tra_lai_sau.SelectedText = "Có";
            else
                m_cbo_tra_lai_sau.SelectedText = "Không";
            if (m_us_trai_phieu.strTHA_NOI_YN.ToUpper() == "Y")
                m_cbo_tha_noi.SelectedText = "Có";
            else
                m_cbo_tha_noi.SelectedText = "Không";
            m_cbo_tra_lai_sau.SelectedValue = m_us_trai_phieu.strTRA_LAI_SAU_YN.ToUpper();

            us_to_chuc_phat_hanh_2_form(m_us_to_chuc_phat_hanh);
        }
        private void form_2_us_object(US_DM_TRAI_PHIEU op_us_trai_phieu)
        {
            op_us_trai_phieu.strTEN_TRAI_PHIEU = m_txt_ten_trai_phieu.Text;
           /* op_us_trai_phieu.dcID_TO_CHUC_PHAT_HANH = m_us_to_chuc_phat_hanh.dcID;
            op_us_trai_phieu.strMA_TRAI_PHIEU = m_txt_ma_trai_phieu.Text;
            op_us_trai_phieu.dcID_LOAI_TRAI_PHIEU = (decimal)m_cbo_loai_trai_phieu.SelectedValue;
            op_us_trai_phieu.dcMENH_GIA = CIPConvert.ToDecimal(m_txt_menh_gia.Text);*/
            op_us_trai_phieu.dcKY_HAN = CIPConvert.ToDecimal(m_txt_ky_han.Text);
            op_us_trai_phieu.dcID_DV_KY_HAN = (decimal)m_cbo_don_vi_ky_han.SelectedValue;
            op_us_trai_phieu.dcLAI_SUAT_DEFAULT = CIPConvert.ToDecimal(m_txt_lai_suat.Text);
            op_us_trai_phieu.dcKY_DIEU_CHINH_LS = CIPConvert.ToDecimal(m_txt_ky_dieu_chinh_ls.Text);
            op_us_trai_phieu.dcID_DV_DIEU_CHINH_LS = (decimal)m_cbo_dv_dieu_chinh_ls.SelectedValue;
            op_us_trai_phieu.strTHA_NOI_YN = (string)m_cbo_tha_noi.SelectedValue;
            op_us_trai_phieu.dcKY_TRA_LAI = CIPConvert.ToDecimal(m_txt_ky_tra_lai.Text);
            op_us_trai_phieu.dcID_DV_KY_TRA_LAI = (decimal)m_cbo_dv_tra_lai.SelectedValue;
            op_us_trai_phieu.strTRA_LAI_SAU_YN = (string)m_cbo_tra_lai_sau.SelectedValue;
            /*op_us_trai_phieu.datNGAY_PHAT_HANH = m_dat_ngay_phat_hanh.Value.Date;
            op_us_trai_phieu.datNGAY_DAO_HAN = m_dat_ngay_dao_han.Value.Date;
            op_us_trai_phieu.dcTONG_SL_PHAT_HANH = decimal.Parse(m_txt_tong_sl.Text);
            op_us_trai_phieu.dcTONG_GIA_TRI = op_us_trai_phieu.dcTONG_SL_PHAT_HANH * op_us_trai_phieu.dcMENH_GIA;*/
        }
        private void load_data_2_cbo()
        {
            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.LOAI_TRAI_PHIEU);
            m_cbo_loai_trai_phieu.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_trai_phieu.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_trai_phieu.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_trai_phieu.Text = "";

            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_don_vi_ky_han.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_don_vi_ky_han.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_ky_han.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_don_vi_ky_han.Text = "";

            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_dv_dieu_chinh_ls.DataSource = (DataTable)m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_dv_dieu_chinh_ls.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_dieu_chinh_ls.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_dieu_chinh_ls.Text = "";

            m_ds_cm_dm_tu_dien = m_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_dv_tra_lai.DataSource = (DataTable)m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_dv_tra_lai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_tra_lai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_tra_lai.Text = "";

            ArrayList v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("360/360", "360/360"));
            v_arr.Add(new CO_SO_TINH_LAI("365/365", "360/365"));
            m_cbo_co_so_tinh_lai.DataSource = v_arr;
            m_cbo_co_so_tinh_lai.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_co_so_tinh_lai.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_co_so_tinh_lai.Text = "";

            v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("Có", "Y"));
            v_arr.Add(new CO_SO_TINH_LAI("Không", "N"));
            m_cbo_tha_noi.DataSource = v_arr;
            m_cbo_tha_noi.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_tha_noi.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_tha_noi.Text = "";

            v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("Có", "Y"));
            v_arr.Add(new CO_SO_TINH_LAI("Không", "N"));
            m_cbo_tra_lai_sau.DataSource = v_arr;
            m_cbo_tra_lai_sau.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_tra_lai_sau.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_tra_lai_sau.Text = "";
        }

        
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ten_trai_phieu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ma_to_chuc_phat_hanh, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_han, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_menh_gia, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_tong_sl, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_lai_suat, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_tra_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ky_dieu_chinh_ls, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (m_us_to_chuc_phat_hanh.IsIDNull()) {
                MessageBox.Show("Bạn chưa chọn tổ chức phát hành!");
                return false; }
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
      
        #endregion
        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f300_dm_trai_phieu_DE_Load);
            m_cmd_id_to_chuc_phat_hanh.Click += new EventHandler(m_cmd_ma_to_chuc_phat_hanh_Click);
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
                        load_data_2_cbo();
                        break;
                    case DataEntryFormMode.SelectDataState:
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        load_data_2_cbo();
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
    }
    public class CO_SO_TINH_LAI
    { 
        private string m_Display;
        private string m_Value;
        public const string DISPLAY = "DISPLAY";
        public const string VALUE = "VALUE";
        public CO_SO_TINH_LAI(string Display, string Value)
        {
            m_Display = Display;
            m_Value = Value;
        }
        public string Display
        {
            get{return m_Display;}
        }
        public string Value
        {
            get{return m_Value;}
        }

    }
}
