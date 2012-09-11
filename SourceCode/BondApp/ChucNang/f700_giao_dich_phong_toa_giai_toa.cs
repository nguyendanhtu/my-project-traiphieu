
using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BondApp
{
    public partial class f700_giao_dich_phong_toa_giai_toa : Form
    {
        public f700_giao_dich_phong_toa_giai_toa()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structures

        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        #endregion

        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
         
            set_define_events();
            this.KeyPreview = true;
        }

        private void select_trai_chu()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            m_us_trai_chu =  v_frm500.select_trai_chu();
            us_trai_chu_2_form(m_us_trai_chu);
        }

        private void us_trai_chu_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            if (ip_us_trai_chu.IsIDNull()) return;  
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;


            m_us_trai_phieu = new US_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);

            us_trai_phieu_2_form(m_us_trai_phieu);
            
        }

        private void us_trai_phieu_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_so_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
        }


        #endregion

        private void set_define_events()
        {
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
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
    }
}

