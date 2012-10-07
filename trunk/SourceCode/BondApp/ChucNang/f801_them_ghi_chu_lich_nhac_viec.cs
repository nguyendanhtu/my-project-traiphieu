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
using IP.Core.IPSystemAdmin;

using BondUS;
using BondDS;
using BondDS.CDBNames;

namespace BondApp.ChucNang
{
    public partial class f801_them_ghi_chu_lich_nhac_viec : Form
    {
        public f801_them_ghi_chu_lich_nhac_viec()
        {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure

        #endregion

        #region Members
        US_GD_LICH_THANH_TOAN_LAI_GOC m_us_gd_lich_thanh_toan_lai_goc;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_initial_form_load()
        {
            m_chb_cap_nhat_lai_suat_yn.Enabled = false;
            m_chb_chot_lai_yn.Enabled = false;
            m_chb_thanh_toan_goc.Enabled = false;
            m_chb_thanh_toan_lai.Enabled = false;
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert_note.Click += new EventHandler(m_cmd_insert_note_Click);
            this.Load += new EventHandler(f801_them_ghi_chu_lich_nhac_viec_Load);
        }
        private void them_ghi_chu()
        {
            form_2_us_object();
            m_us_gd_lich_thanh_toan_lai_goc.them_ghi_chu();
        }
        private void us_obj_2_form(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_gd_lich_thanh_toan_lai_goc)
        {
            m_txt_ngay_dien_ra.Text = CIPConvert.ToStr(ip_us_gd_lich_thanh_toan_lai_goc.datNGAY,"dd/MM/yyyy");
            m_txt_noi_dung_cong_viec.Text = get_noi_dung_cong_viec(ip_us_gd_lich_thanh_toan_lai_goc);
            US_DM_TRAI_PHIEU v_us_dm_trai_phieu = new US_DM_TRAI_PHIEU(ip_us_gd_lich_thanh_toan_lai_goc.dcID_TRAI_PHIEU);
            if (!v_us_dm_trai_phieu.IsIDNull())
                m_txt_ma_trai_phieu.Text = v_us_dm_trai_phieu.strMA_TRAI_PHIEU;
            m_chb_chot_lai_yn.Checked = chuyen_str_2_bool(ip_us_gd_lich_thanh_toan_lai_goc.strCHOT_LAI_YN);
            m_chb_cap_nhat_lai_suat_yn.Checked = chuyen_str_2_bool(ip_us_gd_lich_thanh_toan_lai_goc.strCAP_NHAT_LS_YN);
            m_chb_thanh_toan_lai.Checked = chuyen_str_2_bool(ip_us_gd_lich_thanh_toan_lai_goc.strTHANH_TOAN_LAI_YN);
            m_chb_thanh_toan_goc.Checked = chuyen_str_2_bool(ip_us_gd_lich_thanh_toan_lai_goc.strTHANH_TOAN_GOC_YN);
            m_txt_ghi_chu.Text = ip_us_gd_lich_thanh_toan_lai_goc.strGHI_CHU;
        }
        private void form_2_us_object()
        {
            m_us_gd_lich_thanh_toan_lai_goc.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
        }
        private string get_noi_dung_cong_viec(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_gd_lich_thanh_toan_lai_goc)
        {
            string v_str_content = "Ngày";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strCHOT_LAI_YN == "Y") v_str_content += " chốt danh sách nhận lãi,";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strTHANH_TOAN_GOC_YN == "Y") v_str_content += " thanh toán gốc,";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strTHANH_TOAN_LAI_YN == "Y") v_str_content += " thanh toán lãi,";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strCAP_NHAT_LS_YN == "Y") v_str_content += " cập nhật lãi suất,";
            v_str_content = v_str_content.Substring(0, v_str_content.Length - 1);
            return v_str_content;
        }
        private bool chuyen_str_2_bool(string ip_str_yn)
        {
            if (ip_str_yn.Equals("Y")) return true;
            return false;
        }
        #endregion

        #region Public Interfaces
        public void display_2_them_ghi_chu(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_gd_lich_thanh_toan_lai_goc)
        {
            m_us_gd_lich_thanh_toan_lai_goc = ip_us_gd_lich_thanh_toan_lai_goc;
            this.ShowDialog();
        }
        #endregion

        #region Events
        void f801_them_ghi_chu_lich_nhac_viec_Load(object sender, EventArgs e)
        {
            try
            {
                us_obj_2_form(m_us_gd_lich_thanh_toan_lai_goc);
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_insert_note_Click(object sender, EventArgs e)
        {
            try
            {
                them_ghi_chu();
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
        #endregion
    }
}
