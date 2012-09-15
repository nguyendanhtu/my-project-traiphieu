using System;
using System.Collections.Generic;
using System.Collections;
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

using C1.Win.C1FlexGrid;

namespace BondApp
{
    public partial class f650_lich_thanh_toan_lai_goc_xem : Form
    {
        public f650_lich_thanh_toan_lai_goc_xem()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public interface
        public void display_lich_thanh_toan_lai_goc(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_trai_phieu = ip_us_trai_phieu;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            CHOT_LAI_YN = 3
,
            NGAY = 1
                ,
            CAP_NHAT_LS_YN = 4
                ,
            LAI_SUAT = 7
                ,
            THANH_TOAN_LAI_YN = 6
                ,
            THANH_TOAN_GOC_YN = 5
                , DA_THUC_HIEN_YN = 8
            , NOI_DUNG_LICH = 2
        }
        #endregion

        #region Members
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        ITransferDataRow m_obj_trans;
        DS_GD_LICH_THANH_TOAN_LAI_GOC m_ds_gd_lich_tt_lai_goc = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
        US_GD_LICH_THANH_TOAN_LAI_GOC m_us_gd_lich_tt_lai_goc = new US_GD_LICH_THANH_TOAN_LAI_GOC();
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void set_initial_form_load()
        {
            us_trai_phieu_2_form();
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }


        private void us_trai_phieu_2_form()
        {
            m_txt_ma_trai_phieu.Text = m_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = m_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(m_us_trai_phieu.dcKY_DIEU_CHINH_LS, "#,###");
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(m_us_trai_phieu.datNGAY_PHAT_HANH);
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(m_us_trai_phieu.datNGAY_DAO_HAN);
            m_txt_tong_so_luong_trai_phieu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_SL_PHAT_HANH, "#,###");
            m_txt_tong_gia_tri_trai_phieu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_GIA_TRI, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_trai_phieu.dcLAI_SUAT_DEFAULT, "p");
            m_txt_ky_tinh_lai.Text = CIPConvert.ToStr(m_us_trai_phieu.dcKY_TRA_LAI, "#,###");
        }


        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.CHOT_LAI_YN, e_col_Number.CHOT_LAI_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.NGAY, e_col_Number.NGAY);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.CAP_NHAT_LS_YN, e_col_Number.CAP_NHAT_LS_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.LAI_SUAT, e_col_Number.LAI_SUAT);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.THANH_TOAN_LAI_YN, e_col_Number.THANH_TOAN_LAI_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.THANH_TOAN_GOC_YN, e_col_Number.THANH_TOAN_GOC_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.DA_THUC_HIEN_YN, e_col_Number.DA_THUC_HIEN_YN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_gd_lich_tt_lai_goc.GD_LICH_THANH_TOAN_LAI_GOC.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds_gd_lich_tt_lai_goc = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
            m_us_gd_lich_tt_lai_goc.FillDatasetByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_trai_phieu.dcID);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_gd_lich_tt_lai_goc, m_fg, m_obj_trans);
            for (int v_i_grid_row = m_fg.Rows.Fixed; v_i_grid_row < m_fg.Rows.Count; v_i_grid_row++)
            {
                m_fg[v_i_grid_row, (int)e_col_Number.NOI_DUNG_LICH] = get_content_of_calendar(v_i_grid_row);
            }
            m_fg.Redraw = true;
        }
        private string get_content_of_calendar(int ip_grid_row)
        {
            string v_str_content = "Ngày";

            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.CHOT_LAI_YN] == true) v_str_content += " chốt lãi,";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.THANH_TOAN_GOC_YN] == true) v_str_content += " thanh toán gốc,";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.THANH_TOAN_LAI_YN] == true) v_str_content += " thanh toán lãi,";
            if ((Boolean)m_fg[ip_grid_row, (int)e_col_Number.CAP_NHAT_LS_YN] == true) v_str_content += " cập nhật lãi suất,";
            v_str_content = v_str_content.Substring(0, v_str_content.Length - 1);
            return v_str_content;
        }

        private void grid2us_object(US_GD_LICH_THANH_TOAN_LAI_GOC i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_GD_LICH_THANH_TOAN_LAI_GOC i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void delete_lich_trai_phieu()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_GD_LICH_THANH_TOAN_LAI_GOC v_us = new US_GD_LICH_THANH_TOAN_LAI_GOC();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void thong_bao_lai_suat(){
            grid2us_object(m_us_gd_lich_tt_lai_goc, m_fg.Row);
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f750_ TB Lai Suat.doc");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_CAP_NHAT_LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY));
            v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text +"VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            v_obj_word_rpt.AddFindAndReplace("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            v_obj_word_rpt.AddFindAndReplace("<LAI_SUAT>", m_txt_lai_suat.Text);
            v_obj_word_rpt.Export2Word(true);
        }


         #endregion

        private void set_define_events()
        {
            this.Load += new EventHandler(f650_lich_thanh_toan_lai_goc_xem_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.m_cmd_generate.Click += new System.EventHandler(this.m_cmd_generate_Click);
            m_cmd_thong_bao_ls.Click += new EventHandler(m_cmd_thong_bao_ls_Click);
        }

        void m_cmd_thong_bao_ls_Click(object sender, EventArgs e)
        {
            try
            {
                thong_bao_lai_suat();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_lich_trai_phieu();
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

        void f650_lich_thanh_toan_lai_goc_xem_Load(object sender, EventArgs e)
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

        private void m_cmd_generate_Click(object sender, EventArgs e)
        {
            try
            {
                m_us_gd_lich_tt_lai_goc.GenLichThanhToanLaiGoc(m_us_trai_phieu.dcID);
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
       
    }
}
