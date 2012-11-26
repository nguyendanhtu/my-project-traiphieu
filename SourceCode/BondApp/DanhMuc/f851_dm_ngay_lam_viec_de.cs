using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using IP.Core.IPSystemAdmin;
using System.Windows.Forms;
using BondUS;
using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using BondDS.CDBNames;

namespace BondApp.DanhMuc
{
    public partial class f851_dm_ngay_lam_viec_de : Form
    {
        public f851_dm_ngay_lam_viec_de()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display_for_update(US_DM_NGAY_LAM_VIEC ip_us_ngay_lam_viec)
        {
            m_us_ngay_lam_viec = ip_us_ngay_lam_viec;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        #endregion

        #region Members
        US_DM_NGAY_LAM_VIEC m_us_ngay_lam_viec = new US_DM_NGAY_LAM_VIEC();
        DS_DM_NGAY_LAM_VIEC m_ds_ngay_lam_viec = new DS_DM_NGAY_LAM_VIEC();
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_initial_form_load()
        {
            us_object_2_form(m_us_ngay_lam_viec);
        }
        private void us_object_2_form(US_DM_NGAY_LAM_VIEC ip_us_dm_ngay_lam_viec)
        {
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_dm_ngay_lam_viec.datNGAY,"dd/MM/yyyy");
            if (ip_us_dm_ngay_lam_viec.strNGAY_LAM_VIEC_YN.Equals("Y"))
                m_chb_lam_viec_hai_sau.Checked = true;
            if (ip_us_dm_ngay_lam_viec.strNGAY_LAM_VIEC_HAI_BAY_YN.Equals("Y"))
                m_chb_lam_viec_hai_bay.Checked = true;
        }
        private void form_2_us_object(US_DM_NGAY_LAM_VIEC op_us_dm_ngay_lam_viec)
        {
            if(m_chb_lam_viec_hai_sau.Checked)
                op_us_dm_ngay_lam_viec.strNGAY_LAM_VIEC_YN = "Y";
            else op_us_dm_ngay_lam_viec.strNGAY_LAM_VIEC_YN = "N";
            if(m_chb_lam_viec_hai_bay.Checked)
                op_us_dm_ngay_lam_viec.strNGAY_LAM_VIEC_HAI_BAY_YN = "Y";
            else op_us_dm_ngay_lam_viec.strNGAY_LAM_VIEC_HAI_BAY_YN = "N";
        }
        private void save_data()
        {
            form_2_us_object(m_us_ngay_lam_viec);
            m_us_ngay_lam_viec.Update();
            BaseMessages.MsgBox_Infor("Dữ liệu được cập nhật thành công");
            ghi_log_he_thong();
            this.Close();
        }
        #endregion

        #region Event
        private void set_define_events()
        {
            this.Load += new EventHandler(f851_dm_ngay_lam_viec_de_Load);
            m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.KeyDown += new KeyEventHandler(f851_dm_ngay_lam_viec_de_KeyDown);
        }
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.DM_NGAY_LAM_VIEC;

            m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
            m_us_v_ht_log_truy_cap.strMO_TA = "Sửa ngày làm việc " + m_us_ngay_lam_viec.datNGAY;
            // ghi log hệ thống
            try
            {
                m_us_v_ht_log_truy_cap.Insert();
            }
            catch
            {
                BaseMessages.MsgBox_Infor("Đã xảy ra lỗi trong quá trình ghi log hệ thống");
            }
        }
        void f851_dm_ngay_lam_viec_de_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f851_dm_ngay_lam_viec_de_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Escape)
                    this.Close();
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
