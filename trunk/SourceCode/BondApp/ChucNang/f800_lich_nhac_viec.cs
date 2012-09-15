
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
            format_controls();
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
        private enum e_col_Number
        {

            NGAY = 1 ,
            NOI_DUNG_LICH = 2,
            MA_TRAI_PHIEU = 3,            
            CAP_NHAT_LS_YN = 4,
            CHOT_DANH_SACH_LAI = 5,
            THANH_TOAN_LAI_YN = 6,
            THANH_TOAN_GOC_YN = 7,
            DA_THUC_HIEN_YN = 8
        }
        #endregion

        #region Members
        System.Windows.Forms.Control m_ctlGroup;
        ITransferDataRow m_obj_trans;
        DS_GD_LICH_THANH_TOAN_LAI_GOC m_ds_gd_lich_tt_lai_goc = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
        US_GD_LICH_THANH_TOAN_LAI_GOC m_us_gd_lich_tt_lai_goc = new US_GD_LICH_THANH_TOAN_LAI_GOC();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);

            set_define_events();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void load_data_2_cbo_loai_nhac_viec(){
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("LOAI_NHAC_NHAC_VIEC", v_ds_tu_dien);
            v_ds_tu_dien.EnforceConstraints = false;
            DataRow v_dr = v_ds_tu_dien.CM_DM_TU_DIEN.NewCM_DM_TU_DIENRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.TEN] = "Tất cả";
            v_ds_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);

            m_cbo_loai_nhac_viec.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_nhac_viec.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_loai_nhac_viec.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.CHOT_LAI_YN, e_col_Number.CHOT_DANH_SACH_LAI);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.NGAY, e_col_Number.NGAY);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.CAP_NHAT_LS_YN, e_col_Number.CAP_NHAT_LS_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.THANH_TOAN_LAI_YN, e_col_Number.THANH_TOAN_LAI_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.THANH_TOAN_GOC_YN, e_col_Number.THANH_TOAN_GOC_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.DA_THUC_HIEN_YN, e_col_Number.DA_THUC_HIEN_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.ID_TRAI_PHIEU, e_col_Number.MA_TRAI_PHIEU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_gd_lich_tt_lai_goc.GD_LICH_THANH_TOAN_LAI_GOC.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_cbo_grid()
        {
            US_DM_TRAI_PHIEU v_us_trai_phieu = new US_DM_TRAI_PHIEU();
            DS_DM_TRAI_PHIEU v_ds_trai_phieu = new DS_DM_TRAI_PHIEU();
            v_us_trai_phieu.FillDataset(v_ds_trai_phieu);

            Hashtable v_hst_ma_trai_phieu = new Hashtable();
            foreach (DataRow v_dr in v_ds_trai_phieu.DM_TRAI_PHIEU.Rows)
            {
                v_hst_ma_trai_phieu.Add(v_dr[DM_TRAI_CHU.ID], v_dr[DM_TRAI_PHIEU.TEN_TRAI_PHIEU]);
            }
            m_fg.Cols[(int)e_col_Number.MA_TRAI_PHIEU].DataMap = v_hst_ma_trai_phieu;



        }

        private void load_data_2_grid()
        {
            m_ds_gd_lich_tt_lai_goc = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
            m_us_gd_lich_tt_lai_goc.FillDataset(
                m_ds_gd_lich_tt_lai_goc
                , m_dat_from_date.Value.Date
                , m_dat_to_date.Value.Date
                , CIPConvert.ToDecimal( m_cbo_loai_nhac_viec.SelectedValue));
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_gd_lich_tt_lai_goc, m_fg, m_obj_trans);
            for (int v_i_grid_row = m_fg.Rows.Fixed; v_i_grid_row < m_fg.Rows.Count; v_i_grid_row++)
            {
                m_fg[v_i_grid_row, (int)e_col_Number.NOI_DUNG_LICH] = get_content_of_calendar(v_i_grid_row);
            }
            load_data_2_cbo_grid();
            m_fg.Redraw = true;
        }

        private string get_content_of_calendar(int ip_grid_row)
        {
            string v_str_content = "Ngày";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.CHOT_DANH_SACH_LAI] == true) v_str_content += " chốt danh sách nhận lãi,";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.THANH_TOAN_GOC_YN] == true) v_str_content += " thanh toán gốc,";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.THANH_TOAN_LAI_YN] == true) v_str_content += " thanh toán lãi,";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.CAP_NHAT_LS_YN] == true) v_str_content += " cập nhật lãi suất,";
            v_str_content = v_str_content.Substring(0, v_str_content.Length - 1);
            return v_str_content;
        }
        
        private void set_start_form()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_cbo_loai_nhac_viec();
            m_dat_to_date.Value = m_dat_from_date.Value.AddDays(90);
            load_data_2_grid();
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
            m_cmd_filter.Click += new EventHandler(m_cmd_filter_Click);
        }

        void m_cmd_filter_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        
    }
}
