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
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += new EventHandler(f801_them_ghi_chu_lich_nhac_viec_Load);
        }
        private void us_obj_2_form(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_gd_lich_thanh_toan_lai_goc)
        {
            m_txt_ngay_dien_ra.Text = CIPConvert.ToStr(ip_us_gd_lich_thanh_toan_lai_goc.datNGAY,"dd/MM/yyyy");
            //m_txt_noi_dung_cong_viec.Text = ip_us_gd_lich_thanh_toan_lai_goc
        }
        private string get_noi_dung_cong_viec(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_gd_lich_thanh_toan_lai_goc)
        {
            string v_str_content = "Ngày";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strCHOT_LAI_YN == "Y") v_str_content += " chốt danh sách nhận lãi,";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strTHANH_TOAN_GOC_YN == "Y") v_str_content += " thanh toán gốc,";
           // if (ip_us_gd_lich_thanh_toan_lai_goc == "Y") v_str_content += " thanh toán lãi,";
            if (ip_us_gd_lich_thanh_toan_lai_goc.strTHANH_TOAN_GOC_YN == "Y") v_str_content += " cập nhật lãi suất,";
            v_str_content = v_str_content.Substring(0, v_str_content.Length - 1);
            return v_str_content;
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
