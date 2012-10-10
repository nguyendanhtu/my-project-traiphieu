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
            set_define_events();
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
            m_us = ip_us;
            this.ShowDialog();
        }
        #endregion
        #region Members
        US_GD_CHOT_LAI_DETAIL m_us = new US_GD_CHOT_LAI_DETAIL();
        US_V_DM_TRAI_CHU m_us_trai_chu = new US_V_DM_TRAI_CHU();
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
        private void select_trai_chu()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            m_us_trai_chu = v_frm500.select_trai_chu_of_trai_phieu(null);
            if (m_us_trai_chu.IsIDNull()) return;
            us_trai_chu_2_form(m_us_trai_chu);
            m_txt_so_luong_tinh_lai.Focus();
        }
        private void us_trai_chu_2_form(US_V_DM_TRAI_CHU ip_us_trai_chu)
        {
            if (ip_us_trai_chu.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us = new US_GD_SO_DU_TRAI_PHIEU();
            v_us.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu.dcID, v_ds);
            //m_us_trai_phieu = new US_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);

            m_txt_ma_trai_chu.Text = ip_us_trai_chu.dcID.ToString();
            //m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            //m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            //m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            //m_txt_ngay_cap.Text = ip_us_trai_chu.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            //m_txt_so_luong_trai_phieu.Text = v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["TONG_SO_DU"].ToString();
            //m_txt_so_luong_kha_dung.Text = v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["SO_DU_KHA_DUNG"].ToString();

            //us_trai_phieu_2_form(m_us_trai_phieu);
        }
        private void us_object_2_form(US_GD_CHOT_LAI_DETAIL ip_us_trai_phieu)
        {
            //m_us_tu_dien = new US_CM_DM_TU_DIEN(ip_us_trai_phieu.dcID_LOAI_TRAI_PHIEU);
            m_us_trai_chu = new US_V_DM_TRAI_CHU(m_us.dcID_TRAI_CHU);
            m_txt_id_chot_lai.Text = CIPConvert.ToStr(m_us.dcID_CHOT_LAI);
            m_txt_ma_trai_chu.Text = CIPConvert.ToStr(m_us.dcID_TRAI_CHU);
            m_txt_so_luong_tinh_lai.Text = CIPConvert.ToStr(m_us.dcSO_LUONG_TINH_LAI);
            m_txt_so_tien_lai.Text = CIPConvert.ToStr(m_us.dcSO_TIEN_LAI);
            if (m_us.strDA_NHAN_TIEN_YN.ToUpper() == "Y")
                m_cbo_da_nhan_tien_yn.SelectedText = "Có";
            else
                m_cbo_da_nhan_tien_yn.SelectedText = "Không";
            m_cbo_da_nhan_tien_yn.SelectedValue = m_us.strDA_NHAN_TIEN_YN.ToUpper();
            m_dat_ngay_nhan_tien.Value = m_us.datNGAY_NHAN_TIEN;
            us_trai_chu_2_form(m_us_trai_chu);
        }
        private void form_2_us_object(US_GD_CHOT_LAI_DETAIL op_us_gd_chot_lai_de)
        {
            op_us_gd_chot_lai_de.dcID_CHOT_LAI = CIPConvert.ToDecimal(m_txt_id_chot_lai.Text);
            op_us_gd_chot_lai_de.dcID_TRAI_CHU = CIPConvert.ToDecimal(m_us_trai_chu.dcID);
            op_us_gd_chot_lai_de.dcSO_LUONG_TINH_LAI = CIPConvert.ToDecimal(m_txt_so_luong_tinh_lai.Text);
            op_us_gd_chot_lai_de.dcSO_TIEN_LAI = CIPConvert.ToDecimal(m_txt_so_tien_lai.Text);
            op_us_gd_chot_lai_de.strDA_NHAN_TIEN_YN = m_cbo_da_nhan_tien_yn.SelectedValue.ToString();
            op_us_gd_chot_lai_de.datNGAY_NHAN_TIEN = m_dat_ngay_nhan_tien.Value.Date;
        }
        private void load_data_2_cbo()
        {
            ArrayList v_arr = new ArrayList();
            v_arr.Add(new CO_SO_TINH_LAI("Có", "Y"));
            v_arr.Add(new CO_SO_TINH_LAI("Không", "N"));
            m_cbo_da_nhan_tien_yn.DataSource = v_arr;
            m_cbo_da_nhan_tien_yn.DisplayMember = CO_SO_TINH_LAI.DISPLAY;
            m_cbo_da_nhan_tien_yn.ValueMember = CO_SO_TINH_LAI.VALUE;
            m_cbo_da_nhan_tien_yn.Text = "";
        }       
        private bool check_validate_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_id_chot_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_chu, DataType.StringType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_so_luong_tinh_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (!CValidateTextBox.IsValid(m_txt_so_tien_lai, DataType.NumberType, allowNull.NO, true))
            { return false; }
            if (m_us_trai_chu.IsIDNull()) {
                MessageBox.Show("Bạn chưa chọn trái chủ!");
                return false; }
            return true;
        }
        private void save_data()
        {
            if (check_validate_data_is_ok() == false) return;
            form_2_us_object(m_us);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us.Insert();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us.Update();
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
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
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
                        us_object_2_form(m_us);
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
        void m_cmd_chon_trai_chu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_chu();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
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
        get { return m_Display; }
    }
    public string Value
    {
        get { return m_Value; }
    }

}
