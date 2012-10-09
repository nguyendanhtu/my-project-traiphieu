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
using IP.Core.IPWordReport;

using BondUS;
using BondDS;
using BondDS.CDBNames;

namespace BondApp.HeThong
{
    public partial class f106_tuy_chinh_tham_so_nhac_viec : Form
    {
        public f106_tuy_chinh_tham_so_nhac_viec()
        {
            InitializeComponent();
            format_controls();
        }

        #region Members

        #endregion

        #region Data Structure
        private enum e_loai_nhac_viec
        {
            TRA_LAI = 27
            , TRA_VON = 28
            , CAP_NHAT_LAI_SUAT = 29
            , GIAO_DICH_DA_THUC_HIEN = 30
            , CHOT_DANH_SACH_LAI = 33
        }
        private enum e_row_loai_nhac_viec
        {
            TRA_LAI = 0
            , TRA_VON = 1
            , CAP_NHAT_LAI_SUAT = 2
            , GIAO_DICH_DA_THUC_HIEN = 3
            , CHOT_DANH_SACH_LAI = 4
        }
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 14);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void set_initial_form_load()
        {
            ds_obj_2_form();
        }
        private void cap_nhat_tham_so_nhac_viec()
        {

        }
        private bool check_du_lieu_ngay_nhap_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ngay_cap_nhat_ls, DataType.NumberType, allowNull.NO, true))
            {
                m_txt_ngay_cap_nhat_ls.Focus();
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ngay_chot_ds_ls, DataType.NumberType, allowNull.NO, true))
            {
                m_txt_ngay_chot_ds_ls.Focus();
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ngay_thanh_toan_goc, DataType.NumberType, allowNull.NO, true))
            {
                m_txt_ngay_thanh_toan_goc.Focus();
                return false;
            }

            if (!CValidateTextBox.IsValid(m_txt_ngay_thanh_toan_lai, DataType.NumberType, allowNull.NO, true))
            {
                m_txt_ngay_thanh_toan_lai.Focus();
                return false;
            }
            return true;
        }

        private void ds_obj_2_form()
        {
            US_DM_THAM_SO_NHAC_VIEC v_us_tham_so_nhac_viec = new US_DM_THAM_SO_NHAC_VIEC();
            DS_DM_THAM_SO_NHAC_VIEC v_ds_tham_so_nhac_viec = new DS_DM_THAM_SO_NHAC_VIEC();
            v_us_tham_so_nhac_viec.FillDataset(v_ds_tham_so_nhac_viec);
            /*
             * 0: trả lãi
             * 1: trả vốn
             * 2: Cập nhật lãi suất
             * 3: Giao dịch đã thực hiện
             * 4: Chốt danh sách lấy lãi
             */
            m_txt_ngay_thanh_toan_lai.Text = CIPConvert.ToStr(v_ds_tham_so_nhac_viec.DM_THAM_SO_NHAC_VIEC.Rows[(int)e_row_loai_nhac_viec.TRA_LAI][DM_THAM_SO_NHAC_VIEC.SO_NGAY_NHAC_TRUOC]);
            m_txt_ngay_cap_nhat_ls.Text = CIPConvert.ToStr(v_ds_tham_so_nhac_viec.DM_THAM_SO_NHAC_VIEC.Rows[(int)e_row_loai_nhac_viec.CAP_NHAT_LAI_SUAT][DM_THAM_SO_NHAC_VIEC.SO_NGAY_NHAC_TRUOC]);
            m_txt_ngay_chot_ds_ls.Text = CIPConvert.ToStr(v_ds_tham_so_nhac_viec.DM_THAM_SO_NHAC_VIEC.Rows[(int)e_row_loai_nhac_viec.CHOT_DANH_SACH_LAI][DM_THAM_SO_NHAC_VIEC.SO_NGAY_NHAC_TRUOC]);
            m_txt_ngay_thanh_toan_goc.Text = CIPConvert.ToStr(v_ds_tham_so_nhac_viec.DM_THAM_SO_NHAC_VIEC.Rows[(int)e_row_loai_nhac_viec.TRA_VON][DM_THAM_SO_NHAC_VIEC.SO_NGAY_NHAC_TRUOC]);
        }
        #endregion

        #region Public Interfaces

        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_cap_nhat.Click += new EventHandler(m_cmd_cap_nhat_Click);
            m_cmd_default.Click += new EventHandler(m_cmd_default_Click);
            this.Load += new EventHandler(f106_tuy_chinh_tham_so_nhac_viec_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }

        void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_du_lieu_ngay_nhap_is_ok()) return;
                
                cap_nhat_tham_so_nhac_viec();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f106_tuy_chinh_tham_so_nhac_viec_Load(object sender, EventArgs e)
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

        void m_cmd_default_Click(object sender, EventArgs e)
        {
            try
            {
                m_txt_ngay_cap_nhat_ls.Text = "7";
                m_txt_ngay_chot_ds_ls.Text = "7";
                m_txt_ngay_thanh_toan_goc.Text = "7";
                m_txt_ngay_thanh_toan_lai.Text = "7";
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
