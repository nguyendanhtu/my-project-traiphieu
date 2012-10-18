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
    public partial class f500_dm_trai_chu_de : Form
    {
        public f500_dm_trai_chu_de()
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

        public void display_for_update(US_V_DM_TRAI_CHU ip_us_v_trai_chu)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_trai_chu = ip_us_v_trai_chu;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            
        }
        #endregion

        #region Members
        US_V_DM_TRAI_CHU m_us_v_trai_chu = new US_V_DM_TRAI_CHU();
        //US_DM_TRAI_PHIEU m_us_trai_phieu;
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu;
        US_DM_TRAI_CHU m_us_trai_chu;
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            set_define_event();
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void set_inital_form_load()
        {
            load_data_2_cbo();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    us_object_2_form(m_us_v_trai_chu);
                    break;
            }
        }

        private void load_data_2_cbo()
        {
            m_ds_cm_dm_tu_dien = m_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.TRANG_THAI_DANH_MUC);
            m_cbo_trang_thai.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;

            m_ds_cm_dm_tu_dien = m_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.LOAI_TRAI_CHU);
            m_cbo_loai_trai_chu.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_trai_chu.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_trai_chu.ValueMember = CM_DM_TU_DIEN.ID;
        }

        private void us_object_2_form(US_V_DM_TRAI_CHU ip_us_trai_chu)
        {
            m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);

            m_txt_ma_trai_chu.Text = ip_us_trai_chu.strMA_TRAI_CHU;
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_cbo_loai_trai_chu.SelectedValue = CIPConvert.ToStr(ip_us_trai_chu.dcID_LOAI_TRAI_CHU);
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_dat_ngay_cap.Value = ip_us_trai_chu.datNGAY_CAP_CMT;
            m_txt_dia_chi.Text = ip_us_trai_chu.strDIA_CHI;
            m_txt_dien_thoai.Text = ip_us_trai_chu.strMOBILE;
            m_txt_fax.Text = ip_us_trai_chu.strFAX;
            m_txt_tai_khoan.Text = ip_us_trai_chu.strSO_TAI_KHOAN;
            m_txt_mo_tai_ngan_hang.Text = ip_us_trai_chu.strMO_TAI_NGAN_HANG;
            m_txt_ghi_chu_1.Text = ip_us_trai_chu.strGHI_CHU1;
            m_txt_ghi_chu_2.Text = ip_us_trai_chu.strGHI_CHU2;
            m_txt_ghi_chu_3.Text = ip_us_trai_chu.strGHI_CHU3;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_txt_id_trai_phieu_so_huu.Text = m_us_v_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = m_us_v_trai_phieu.strTEN_TRAI_PHIEU;
            m_cbo_trang_thai.SelectedValue = CIPConvert.ToStr(ip_us_trai_chu.dcID_TRANG_THAI);
            m_txt_so_du_kha_dung.Text = CIPConvert.ToStr(ip_us_trai_chu.dcSO_DU_KHA_DUNG);
        }

        private void form_2_us_object(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            ip_us_trai_chu.strMA_TRAI_CHU = m_txt_ma_trai_chu.Text;
            ip_us_trai_chu.strTEN_TRAI_CHU = m_txt_ten_khach_hang.Text;
            ip_us_trai_chu.dcID_LOAI_TRAI_CHU = CIPConvert.ToDecimal(m_cbo_loai_trai_chu.SelectedValue);
            ip_us_trai_chu.strCMT_GIAY_DKKD = m_txt_so_cmnd_dkkd.Text;
            ip_us_trai_chu.strNOI_CAP_CMT = m_txt_noi_cap.Text;
            ip_us_trai_chu.datNGAY_CAP_CMT = m_dat_ngay_cap.Value;
            ip_us_trai_chu.strDIA_CHI = m_txt_dia_chi.Text;
            ip_us_trai_chu.strMOBILE = m_txt_dien_thoai.Text;
            ip_us_trai_chu.strFAX = m_txt_fax.Text;
            ip_us_trai_chu.strSO_TAI_KHOAN = m_txt_tai_khoan.Text;
            ip_us_trai_chu.strMO_TAI_NGAN_HANG = m_txt_mo_tai_ngan_hang.Text;
            ip_us_trai_chu.strGHI_CHU1 = m_txt_ghi_chu_1.Text;
            ip_us_trai_chu.strGHI_CHU2 = m_txt_ghi_chu_2.Text;
            ip_us_trai_chu.strGHI_CHU3 = m_txt_ghi_chu_3.Text;
            ip_us_trai_chu.strNOI_CAP_CMT = m_txt_noi_cap.Text;
            ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU = m_us_v_trai_phieu.dcID;
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
                ip_us_trai_chu.dcID_NGUOI_LAP = CAppContext_201.getCurrentUserID();
            else
                ip_us_trai_chu.dcID_NGUOI_DUYET = CAppContext_201.getCurrentUserID();
            ip_us_trai_chu.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
        }

        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_chu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ten_khach_hang, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_so_cmnd_dkkd, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_noi_cap, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.YES, true))
            {
                return false;
            } if (!CValidateTextBox.IsValid(m_txt_dien_thoai, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_fax, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_tai_khoan, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_mo_tai_ngan_hang, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu_1, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu_2, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_ghi_chu_3, DataType.StringType, allowNull.YES, true))
            {
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_id_trai_phieu_so_huu, DataType.StringType, allowNull.NO, true))
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
            
            m_us_trai_chu = new US_DM_TRAI_CHU(m_us_v_trai_chu.dcID);
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
            this.Close();
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_v_trai_phieu.IsIDNull())
            {
                m_txt_id_trai_phieu_so_huu.Text = m_us_v_trai_phieu.strMA_TRAI_PHIEU;
                m_txt_ten_trai_phieu.Text = m_us_v_trai_phieu.strTEN_TRAI_PHIEU;
            }
        }

        private void set_define_event()
        {
            this.Load += new EventHandler(f500_dm_trai_chu_de_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_select_trai_phieu.Click += new EventHandler(m_cmd_select_trai_phieu_Click);
        }

        #endregion

        #region Events
        void f500_dm_trai_chu_de_Load(object sender, EventArgs e)
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

        void m_cmd_select_trai_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_phieu();
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
