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
using IP.Core.IPSystemAdmin;

using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using BondApp.ChucNang;
using BondApp.HeThong;
using IP.Core.IPData.DBNames;

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
        // Dùng cho F300 - Trái phiếu
        public void display_lich_thanh_toan_lai_goc(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_v_trai_phieu = ip_us_trai_phieu;
            m_e_form_mode = e_form_mode.HIEN_THI_CO_TRAI_PHIEU;
            this.ShowDialog();
        }
        public void display()
        {
            m_e_form_mode = e_form_mode.HIEN_THI_KHONG_TRAI_PHIEU;
            this.ShowDialog();
        }

        public void display_khong_trai_phieu_sinh_lich()
        {
            m_e_form_mode = e_form_mode.KHONG_TRAI_PHIEU_SINH_LICH;
            this.ShowDialog();
        }

        public void display_khong_trai_phieu_thong_bao_lai_suat()
        {
            m_e_form_mode = e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_LAI_SUAT;
            this.ShowDialog();
        }
        public void display_khong_trai_phieu_thong_bao_ngay_chot_ds()
        {
            m_e_form_mode = e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_NGAY_CHOT_DS_LAI;
            this.ShowDialog();
        }
        public void display_khong_trai_phieu_thong_bao_thanh_toan_lai()
        {
            m_e_form_mode = e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_TT_LAI;
            this.ShowDialog();
        }
        public void display_khong_trai_phieu_thong_bao_dot_thanh_toan_lai_trai_phieu()
        {
            m_e_form_mode = e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_DOT_THANH_TOAN_LAI_TRAI_PHIEU;
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            STT =1,
            CHOT_LAI_YN = 4
,
            NGAY = 2
                ,
            CAP_NHAT_LS_YN = 5
                ,
            LAI_SUAT = 8
                ,
            THANH_TOAN_LAI_YN = 7
                ,
            THANH_TOAN_GOC_YN = 6
                , DA_THUC_HIEN_YN = 9
            , NOI_DUNG_LICH = 3
        }
        private enum e_form_mode
        {
            HIEN_THI_CO_TRAI_PHIEU = 1
          ,
            HIEN_THI_KHONG_TRAI_PHIEU = 2
                ,
            KHONG_TRAI_PHIEU_SINH_LICH = 3
                ,
            KHONG_TRAI_PHIEU_THONG_BAO_LAI_SUAT = 4
                ,
            KHONG_TRAI_PHIEU_THONG_BAO_NGAY_CHOT_DS_LAI = 5
                , 
            KHONG_TRAI_PHIEU_THONG_BAO_TT_LAI = 6
                ,
            KHONG_TRAI_PHIEU_THONG_BAO_DOT_THANH_TOAN_LAI_TRAI_PHIEU = 7
        }
        #endregion

        #region Members
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU();
        //US_V_DM_TRAI_PHIEU m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU();
        US_GD_CHOT_LAI m_us_gd_chot_lai = new US_GD_CHOT_LAI();
        ITransferDataRow m_obj_trans;
        e_form_mode m_e_form_mode = e_form_mode.HIEN_THI_KHONG_TRAI_PHIEU;
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
            load_data_2_cbo_dv_ky_tinh_lai();
            switch (m_e_form_mode)
            {
                case e_form_mode.HIEN_THI_CO_TRAI_PHIEU:
                    us_trai_phieu_2_form();
                    m_obj_trans = get_trans_object(m_fg);
                    load_data_2_grid();
                    m_cmd_generate.Visible = true;
                    m_cmd_thong_bao_tien_lai.Visible = false;
                    m_cmd_thong_bao_ls.Visible = true;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
                    m_cmd_insert.Visible = true;
                    m_cmd_update.Visible = true;
                    m_cmd_delete.Visible = true;
                    m_cmd_cap_nhat_lai_suat.Visible = true;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = false;
                    break;
                case e_form_mode.HIEN_THI_KHONG_TRAI_PHIEU:
                    m_obj_trans = get_trans_object(m_fg);
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_SINH_LICH:
                    m_obj_trans = get_trans_object(m_fg);
                    m_lbl_header.Text = "F650 - SINH LỊCH THANH TOÁN LÃI GỐC";
                    this.Text = "F650 - Sinh lịch thanh toán lãi gốc";
                    m_cmd_generate.Visible = true;
                    m_cmd_thong_bao_ls.Visible = false;
                    m_cmd_thong_bao_tien_lai.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = false;
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_LAI_SUAT:
                    m_obj_trans = get_trans_object(m_fg);
                    m_lbl_header.Text = "F650 - THÔNG BÁO LÃI SUẤT";
                    this.Text = "F650 - Thông báo lãi suất";
                    m_cmd_generate.Visible = false;
                    m_cmd_thong_bao_tien_lai.Visible = false;
                    m_cmd_thong_bao_ls.Visible = true;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
                    m_cmd_insert.Visible = false;
                    m_cmd_update.Visible = false;
                    m_cmd_delete.Visible = false;
                    m_cmd_cap_nhat_lai_suat.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = false;
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_NGAY_CHOT_DS_LAI:
                    m_obj_trans = get_trans_object(m_fg);
                    m_lbl_header.Text = "F650 - THÔNG BÁO NGÀY CHỐT DANH SÁCH NHẬN LÃI";
                    this.Text = "F650 - Thông báo ngày chốt danh sách nhận lãi";
                    m_cmd_generate.Visible = false;
                    m_cmd_thong_bao_ls.Visible = false;
                    m_cmd_thong_bao_tien_lai.Visible = true;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
                    m_cmd_insert.Visible = false;
                    m_cmd_update.Visible = false;
                    m_cmd_delete.Visible = false;
                    m_cmd_cap_nhat_lai_suat.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = false;
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_TT_LAI:
                    m_obj_trans = get_trans_object(m_fg);
                    m_lbl_header.Text = "F650 - THÔNG BÁO THANH TOÁN LÃI TRÁI PHIẾU";
                    this.Text = "F650 - Thông báo thanh toán lãi trái phiếu";
                    m_cmd_generate.Visible = false;
                    m_cmd_thong_bao_ls.Visible = false;
                    m_cmd_thong_bao_tien_lai.Visible = false;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
                    m_cmd_insert.Visible = false;
                    m_cmd_update.Visible = false;
                    m_cmd_delete.Visible = false;
                    m_cmd_cap_nhat_lai_suat.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = false;
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_DOT_THANH_TOAN_LAI_TRAI_PHIEU:
                    m_obj_trans = get_trans_object(m_fg);
                    m_lbl_header.Text = "F650 - THÔNG BÁO ĐỢT THANH TOÁN LÃI TRÁI PHIẾU";
                    this.Text = "F650 - Thông báo đợt thanh toán lãi trái phiếu";
                    m_cmd_generate.Visible = false;
                    m_cmd_thong_bao_ls.Visible = false;
                    m_cmd_thong_bao_tien_lai.Visible = false;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
                    m_cmd_insert.Visible = false;
                    m_cmd_update.Visible = false;
                    m_cmd_delete.Visible = false;
                    m_cmd_cap_nhat_lai_suat.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void us_trai_phieu_2_form()
        {
            m_txt_ma_trai_phieu.Text = m_us_v_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = m_us_v_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_HAN, "#,###");
            try
            {
                US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_v_trai_phieu.dcID_DOT_PHAT_HANH);
                US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(v_us_dm_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);
                m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH, "dd/MM/yyyy");
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(m_us_v_trai_phieu.datNGAY_DAO_HAN);
            m_txt_tong_so_luong_trai_phieu.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcTONG_SL_PHAT_HANH, "#,###");
            m_txt_tong_gia_tri_trai_phieu.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcTONG_GIA_TRI, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcLAI_SUAT_DEFAULT, "p");
            m_txt_ky_tinh_lai.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_TRA_LAI, "#,###");
            m_cbo_don_vi_ky_tinh_lai.SelectedValue = m_us_v_trai_phieu.dcID_DV_KY_TRA_LAI;
        }

        private void load_data_2_cbo_dv_ky_tinh_lai()
        {
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            v_ds_cm_dm_tu_dien = v_us_tu_dien.getLoaiTuDienDS(CM_DM_LOAI_TD_LIST.DON_VI_KY_HAN);
            m_cbo_don_vi_ky_tinh_lai.DataSource = v_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_don_vi_ky_tinh_lai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_ky_tinh_lai.ValueMember = CM_DM_TU_DIEN.ID;
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
            switch (m_e_form_mode)
            {
                case e_form_mode.HIEN_THI_CO_TRAI_PHIEU:
                    m_us_gd_lich_tt_lai_goc.FillDatasetByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
                    break;
                case e_form_mode.HIEN_THI_KHONG_TRAI_PHIEU:
                    m_us_gd_lich_tt_lai_goc.FillDatasetAll(m_ds_gd_lich_tt_lai_goc);
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_SINH_LICH:
                    m_us_gd_lich_tt_lai_goc.FillDatasetByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_LAI_SUAT:
                    m_us_gd_lich_tt_lai_goc.FillDatasetLaiSuatByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_NGAY_CHOT_DS_LAI:
                    m_us_gd_lich_tt_lai_goc.FillDatasetChotLaiByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_TT_LAI:
                    m_us_gd_lich_tt_lai_goc.FillDatasetNgayThanhToanLaiByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_DOT_THANH_TOAN_LAI_TRAI_PHIEU:
                    m_us_gd_lich_tt_lai_goc.FillDatasetNgayThanhToanLaiByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
                    break;
                default:
                    break;
            }            
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_gd_lich_tt_lai_goc, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
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
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
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
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            grid2us_object(m_us_gd_lich_tt_lai_goc, m_fg.Row);
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f750_ TB Lai Suat.doc");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_CAP_NHAT_LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY));
            v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_v_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text +"VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + " VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            v_obj_word_rpt.AddFindAndReplace("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            v_obj_word_rpt.AddFindAndReplace("<LAI_SUAT>", m_txt_lai_suat.Text);
            v_obj_word_rpt.AddFindAndReplace("<BIEN_DO_LAI>", CIPConvert.ToStr(m_us_v_trai_phieu.dcBIEN_DO_LAI, "#,###0.0000"));
            v_obj_word_rpt.Export2Word(true);
        }

        private void thong_bao_ngay_chot_tien_lai()
        {
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            grid2us_object(m_us_gd_lich_tt_lai_goc, m_fg.Row);                        
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f750_TB Trai Chu Ngay Chot.doc");
            //v_obj_word_rpt.AddFindAndReplace("<NGAY_CAP_NHAT_LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY));
            //v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text +"VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            v_obj_word_rpt.AddFindAndReplace("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            v_obj_word_rpt.AddFindAndReplace("<LAI_SUAT>", m_txt_lai_suat.Text);                   
            v_obj_word_rpt.AddFindAndReplace("<NGAY_THANH_TOAN>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY.AddDays((int)m_us_v_trai_phieu.dcSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN), "dd/MM/yyyy"));
            v_obj_word_rpt.AddFindAndReplace("<MUC_DICH>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.strGHI_CHU));
            v_obj_word_rpt.AddFindAndReplace("<NGAY_CHOT_DANH_SACH>",CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY, "dd/MM/yyyy" ));
            v_obj_word_rpt.Export2Word(true);
        }

        private void thong_bao_dot_thanh_toan_lai_trai_phieu()
        {
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            grid2us_object(m_us_gd_lich_tt_lai_goc, m_fg.Row);
            DS_GD_CHOT_LAI v_ds_gd_chot_lai = new DS_GD_CHOT_LAI();
            m_us_gd_chot_lai.FillDSChotLaiByIDTraiPhieuAndNgayChotLai(v_ds_gd_chot_lai, m_us_gd_lich_tt_lai_goc.dcID_TRAI_PHIEU, m_us_gd_lich_tt_lai_goc.datNGAY);

            if (v_ds_gd_chot_lai.GD_CHOT_LAI.Rows.Count == 0) return;
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f700_TB TCPH Dot Thanh Toan.doc");
            US_V_DM_TO_CHUC_PHAT_HANH v_dm_to_chuc_phat_hanh = new US_V_DM_TO_CHUC_PHAT_HANH(m_us_v_trai_phieu.dcID_TO_CHUC_PHAT_HANH);
            //v_obj_word_rpt.AddFindAndReplace("<NGAY_CAP_NHAT_LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY));
            //v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<TO_CHUC_PHAT_HANH>", v_dm_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_v_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            v_obj_word_rpt.AddFindAndReplace("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            v_obj_word_rpt.AddFindAndReplace("<LAI_SUAT>", m_txt_lai_suat.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_THANH_TOAN_LAI>", CIPConvert.ToStr(v_ds_gd_chot_lai.Tables["GD_CHOT_LAI"].Rows[0]["NGAY_THANH_TOAN"]));
            v_obj_word_rpt.AddFindAndReplace("<MUC_DICH>", CIPConvert.ToStr(v_ds_gd_chot_lai.Tables["GD_CHOT_LAI"].Rows[0]["MUC_DICH"].ToString()));

            US_V_DM_TRAI_CHU_CHOT_LAI v_us_gd_trai_chu_chot_lai = new US_V_DM_TRAI_CHU_CHOT_LAI();
            DS_V_DM_TRAI_CHU_CHOT_LAI v_ds_gd_trai_chu_chot_lai = new DS_V_DM_TRAI_CHU_CHOT_LAI();
            v_us_gd_trai_chu_chot_lai.FillDatasetByIdChotLai(v_ds_gd_trai_chu_chot_lai, v_ds_gd_chot_lai.Tables["GD_CHOT_LAI"].Rows[0]["ID"].ToString());
            decimal v_d_sum = 0;
            foreach (DataRow v_dr in v_ds_gd_trai_chu_chot_lai.V_DM_TRAI_CHU_CHOT_LAI.Rows)
            {
                v_d_sum += CIPConvert.ToDecimal(v_dr["SO_TIEN_LAI"]);
            }
            v_obj_word_rpt.AddFindAndReplace("<TONG_SO_TIEN_PHAI_THANH_TOAN>", CIPConvert.ToStr(v_d_sum, "#,###") + " VNĐ");

            v_obj_word_rpt.AddFindAndReplace("<NGAY_CHOT_DANH_SACH>", CIPConvert.ToStr(v_ds_gd_chot_lai.Tables["GD_CHOT_LAI"].Rows[0]["NGAY_CHOT_LAI"]));
            v_obj_word_rpt.AddFindAndReplace("<SO_TAI_KHOAN>", v_dm_to_chuc_phat_hanh.strSO_TAI_KHOAN);
            v_obj_word_rpt.AddFindAndReplace("<TEN_NGAN_HANG>", v_dm_to_chuc_phat_hanh.strMO_TAI_NGAN_HANG);
            v_obj_word_rpt.AddFindAndReplace("<SO_NGAY_TRA_LAI>", CIPConvert.ToStr(m_us_v_trai_phieu.dcSO_NGAY_TCPH_CHUYEN_TIEN_TRUOC, "#,###"));
            v_obj_word_rpt.Export2Word(true);
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_v_trai_phieu.IsIDNull() && m_us_v_trai_phieu.dcID != -1)
            {
                // Load thông tin trái phiếu lên form
                us_trai_phieu_2_form();
                // Hiển thị lịch lên lưới
                load_data_2_grid();
            }
        }

        private void cell_changed()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            US_GD_LICH_THANH_TOAN_LAI_GOC v_us = new US_GD_LICH_THANH_TOAN_LAI_GOC();
            grid2us_object(v_us, m_fg.Row);
            if (v_us.strTHANH_TOAN_GOC_YN == "Y")
            {
                m_cmd_tra_goc.Enabled = true;
            }
            else
                m_cmd_tra_goc.Enabled = false;
            if (v_us.strTHANH_TOAN_LAI_YN == "Y")
            {
                m_cmd_tra_lai.Enabled = true;
            }
            else
                m_cmd_tra_lai.Enabled = false;
            if (v_us.strCAP_NHAT_LS_YN.Equals("Y"))
                m_cmd_cap_nhat_lai_suat.Enabled = true;
            else
                m_cmd_cap_nhat_lai_suat.Enabled = false;

        }

        private void display_tra_goc()
        {
            f950_quan_ly_tra_goc v_frm950 = new f950_quan_ly_tra_goc();
            v_frm950.display_tra_goc_trai_phieu(m_us_v_trai_phieu);
        }

        private void display_tra_lai()
        {
            f900_quan_ly_coupon v_frm900 = new f900_quan_ly_coupon();
            v_frm900.display_tra_lai_trai_phieu(m_us_v_trai_phieu);
        }

        private void show_cap_nhat_lai_suat()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            US_GD_LICH_THANH_TOAN_LAI_GOC v_us = new US_GD_LICH_THANH_TOAN_LAI_GOC();
            grid2us_object(v_us, m_fg.Row);
            if (v_us.strCAP_NHAT_LS_YN.Equals("Y"))
            {                
                f310_cap_nhat_lai_suat v_frm310 = new f310_cap_nhat_lai_suat();
                if (v_us.strDA_THUC_HIEN_YN.Equals("Y"))
                    v_frm310.display_xem_gd_cap_nhat_ls(v_us);
                else
                    v_frm310.display_sua_gd_cap_nhat_ls(v_us);
            }
        }
         #endregion

        private void set_define_events()
        {
            this.Load += new EventHandler(f650_lich_thanh_toan_lai_goc_xem_Load);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.m_cmd_generate.Click += new System.EventHandler(this.m_cmd_generate_Click);
            m_cmd_thong_bao_ls.Click += new EventHandler(m_cmd_thong_bao_ls_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_fg.Click += new EventHandler(m_fg_Click);
            m_cmd_tra_goc.Click += new EventHandler(m_cmd_tra_goc_Click);
            m_cmd_tra_lai.Click += new EventHandler(m_cmd_tra_lai_Click);
            m_cmd_thong_bao_tien_lai.Click += new EventHandler(m_cmd_thong_bao_tien_lai_Click);
            m_cmd_cap_nhat_lai_suat.Click += new EventHandler(m_cmd_cap_nhat_lai_suat_Click);
            m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Click += new EventHandler(m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu_Click);
            this.KeyDown += new KeyEventHandler(f650_lich_thanh_toan_lai_goc_xem_KeyDown);
        }

        void f650_lich_thanh_toan_lai_goc_xem_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_cap_nhat_lai_suat_Click(object sender, EventArgs e)
        {
            try
            {
                show_cap_nhat_lai_suat();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_fg_Click(object sender, EventArgs e)
        {
            try
            {
                cell_changed();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tra_lai_Click(object sender, EventArgs e)
        {
            try
            {
                display_tra_lai();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_tra_goc_Click(object sender, EventArgs e)
        {
            try
            {
                display_tra_goc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_trai_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_phieu();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
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

        void m_cmd_thong_bao_tien_lai_Click(object sender, EventArgs e)
        {
            try
            {
                thong_bao_ngay_chot_tien_lai();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                thong_bao_dot_thanh_toan_lai_trai_phieu();
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
                // nếu chưa chọn trái phiếu để gen --> ko thực hiện
                if (m_us_v_trai_phieu.dcID == -1) return;
                // Kiểm tra xem đã gen lịch thanh toán lãi gốc cho Trái phiếu này chưa? Nếu đã có thì phải xác nhận
                US_GD_LICH_THANH_TOAN_LAI_GOC v_us_lich = new US_GD_LICH_THANH_TOAN_LAI_GOC();
                DS_GD_LICH_THANH_TOAN_LAI_GOC v_ds_lich = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
                v_us_lich.FillDatasetByIDTraiPhieu(v_ds_lich, m_us_v_trai_phieu.dcID);
                bool v_bool_xac_nhan = false;
                if (v_ds_lich.GD_LICH_THANH_TOAN_LAI_GOC.Rows.Count > 0)
                {
                    f000_confirm v_confirm = new f000_confirm();
                    v_bool_xac_nhan = v_confirm.display_to_confirm();
                }
                // nếu đồng ý or chưa có thì cho gen
                if (v_bool_xac_nhan || v_ds_lich.GD_LICH_THANH_TOAN_LAI_GOC.Rows.Count == 0)
                {
                    m_us_gd_lich_tt_lai_goc.BeginTransaction();
                    m_us_gd_lich_tt_lai_goc.GenLichThanhToanLaiGoc(m_us_v_trai_phieu.dcID, CAppContext_201.getCurrentUserID());
                    load_data_2_grid();
                    m_us_gd_lich_tt_lai_goc.CommitTransaction();
                }
            }
            catch (Exception v_e)
            {
                m_us_gd_lich_tt_lai_goc.Rollback();
                CDBExceptionHandler v_exceptionHander = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_exceptionHander.showErrorMessage();
            }
        }
       
    }
}
