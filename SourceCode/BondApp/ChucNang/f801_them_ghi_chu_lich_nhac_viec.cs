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
        US_V_GD_NHAC_VIEC m_us_v_gd_nhac_viec;
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
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert_note.Click += new EventHandler(m_cmd_insert_note_Click);
            this.Load += new EventHandler(f801_them_ghi_chu_lich_nhac_viec_Load);
            this.KeyDown += new KeyEventHandler(f801_them_ghi_chu_lich_nhac_viec_KeyDown);
        }

        void f801_them_ghi_chu_lich_nhac_viec_KeyDown(object sender, KeyEventArgs e)
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
        private void them_ghi_chu()
        {
            form_2_us_object();
            m_us_v_gd_nhac_viec.Update();
        }
        private void us_obj_2_form(US_V_GD_NHAC_VIEC ip_us_v_gd_nhac_viec)
        {
            m_txt_ngay_dien_ra.Text = CIPConvert.ToStr(ip_us_v_gd_nhac_viec.datNGAY,"dd/MM/yyyy");
            m_txt_noi_dung_cong_viec.Text = ip_us_v_gd_nhac_viec.strNOI_DUNG_NHAC;
            m_txt_ma_trai_phieu.Text = ip_us_v_gd_nhac_viec.strTEN_TRAI_PHIEU;
            m_txt_ghi_chu.Text = ip_us_v_gd_nhac_viec.strGHI_CHU;
        }
        private void form_2_us_object()
        {
            m_us_v_gd_nhac_viec.strGHI_CHU = m_txt_ghi_chu.Text.Trim();
        }
        #endregion

        #region Public Interfaces
        public void display_2_them_ghi_chu(US_V_GD_NHAC_VIEC ip_us_v_gd_nhac_viec)
        {
            m_us_v_gd_nhac_viec = ip_us_v_gd_nhac_viec;
            this.ShowDialog();
        }
        #endregion

        #region Events
        void f801_them_ghi_chu_lich_nhac_viec_Load(object sender, EventArgs e)
        {
            try
            {
                us_obj_2_form(m_us_v_gd_nhac_viec);
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
