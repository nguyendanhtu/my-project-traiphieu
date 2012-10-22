using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

namespace BondApp.HeThong
{
    public partial class f000_confirm : Form
    {
        public f000_confirm()
        {
            InitializeComponent();
            format_controls();
        }

        #region Members
        bool m_bool_is_confirm;
        #endregion

        #region Public Interfaces
        public bool display_to_confirm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowDialog();
            return m_bool_is_confirm;
        }
        #endregion

        #region Private Method
        private void format_controls()
        {
            set_define_events();
        }

        private void set_ini_form_load()
        {
            m_bool_is_confirm = false;
        }
        private void xac_nhan_cua_nguoi_dung()
        {
            if (!check_dieu_kien_is_ok()) return;
            string v_str_xac_nhan_nguoi_dung = m_txt_xac_nhan.Text.Trim();
            if (v_str_xac_nhan_nguoi_dung.Equals("Co")) m_bool_is_confirm = true;
            else m_bool_is_confirm = false;
            this.Close();
        }
        private bool check_dieu_kien_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_xac_nhan, DataType.StringType, allowNull.NO, true))
            {
                m_txt_xac_nhan.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_xac_nhan.Click += new EventHandler(m_cmd_xac_nhan_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += new EventHandler(f000_confirm_Load);
        }

        void f000_confirm_Load(object sender, EventArgs e)
        {
            try
            {
                set_ini_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_xac_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                xac_nhan_cua_nguoi_dung();
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
