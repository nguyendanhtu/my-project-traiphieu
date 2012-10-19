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

        }
        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
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
