
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
using System.Data.SqlClient;

namespace BondApp
{
    public partial class f800_lich_nhac_viec : Form
    {
        public f800_lich_nhac_viec()
        {
            InitializeComponent();
        }

        #region Public Interface
        public void display_in_container(System.Windows.Forms.Control i_objContainer)
        {
            m_ctlGroup = i_objContainer;
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Top = 0;
            this.Left = 0;
            this.Height = i_objContainer.Height;
            this.Width = i_objContainer.Width;
            this.Dock = DockStyle.Fill;            
            i_objContainer.Controls.Add(this);            
            set_start_form();
            this.Show();
        }
        
        #endregion

        #region Data Structures

        #endregion

        #region Members
        System.Windows.Forms.Control m_ctlGroup;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);

            set_define_events();
            this.KeyPreview = true;
        }

        private void set_start_form()
        {
            //this.m_lbl_intro.ForeColor = System.Drawing.Color.Black;
            //this.m_lbl_intro.BackColor = System.Drawing.Color.Transparent;
            //this.m_lbl_intro.Font = new System.Drawing.Font("BVDTArial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            //US_T2C_DM_ORGANIZATION v_us_org = new US_T2C_DM_ORGANIZATION();
            //US_T2C_DM_PORTFOLIO v_us_portfolio = new US_T2C_DM_PORTFOLIO();
            //try
            //{
            //    v_us_org.open_connection();
            //    v_us_org.findByID(m_dc_org_id);
            //    v_us_portfolio.continue_connection_of(v_us_org);
            //    if (!v_us_org.IsIDNull())
            //    {
            //        v_us_portfolio.findByID(v_us_org.dcT2C_DM_PORTFOLIO_ID);
            //    }
            //    v_us_org.commit_close_connection();
            //}
            //catch (Exception v_e)
            //{
            //    v_us_org.rollback_close_connection();
            //    throw v_e;
            //}
            //if (!v_us_org.IsIDNull())
            //{
            //    this.m_txt_lbl_organization_name.Text = v_us_org.strNAME;
            //}
            //if (!v_us_portfolio.IsIDNull())
            //{
            //    this.m_txt_lbl_portfolio_name.Text = v_us_portfolio.strNAME;
            //}

        }
        #endregion
        private void set_define_events(){
        }
        
    }
}
