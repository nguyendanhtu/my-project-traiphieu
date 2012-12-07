﻿using System;
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
        US_V_HT_LOG_TRUY_CAP m_us_v_ht_log_truy_cap = new US_V_HT_LOG_TRUY_CAP();
        #endregion

        #region Private Method
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void ghi_log_he_thong()
        {
            /* Thông tin chung*/
            m_us_v_ht_log_truy_cap.dcID_DANG_NHAP = CAppContext_201.getCurrentUserID();
            m_us_v_ht_log_truy_cap.datTHOI_GIAN = DateTime.Now;
            m_us_v_ht_log_truy_cap.strDOI_TUONG_THAO_TAC = LOG_DOI_TUONG_TAC_DONG.GD_LICH_THANH_TOAN_LAI_GOC;
            m_us_v_ht_log_truy_cap.strMO_TA = "Sinh " + LOG_DOI_TUONG_TAC_DONG.GD_LICH_THANH_TOAN_LAI_GOC;
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
                    m_cmd_generate.Enabled = true;
                    m_cmd_thong_bao_tien_lai.Visible = false;
                    m_cmd_thong_bao_ls.Enabled = true;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;                    
                    m_cmd_cap_nhat_lai_suat.Enabled = true;
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
                    m_cmd_thong_bao_ls.Enabled = true;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
                    m_cmd_cap_nhat_lai_suat.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Visible = false;
                    break;
                case e_form_mode.KHONG_TRAI_PHIEU_THONG_BAO_NGAY_CHOT_DS_LAI:
                    m_obj_trans = get_trans_object(m_fg);
                    m_lbl_header.Text = "F650 - THÔNG BÁO NGÀY CHỐT DANH SÁCH NHẬN LÃI";
                    this.Text = "F650 - Thông báo ngày chốt danh sách nhận lãi";
                    m_cmd_generate.Visible = false;
                    m_cmd_thong_bao_ls.Visible = false;
                    m_cmd_thong_bao_tien_lai.Enabled = true;
                    m_cmd_tra_goc.Visible = false;
                    m_cmd_tra_lai.Visible = false;
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
                    m_cmd_cap_nhat_lai_suat.Visible = false;
                    m_cmd_thong_bao_dot_thanh_toan_lai_trai_phieu.Enabled = true;
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
            if (m_us_v_trai_phieu.dcID_DV_KY_HAN == ID_DON_VI_KY_HAN.THANG)
                m_lbl_don_vi_kh.Text = "tháng";
            else
                m_lbl_don_vi_kh.Text = "năm";
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
            m_txt_ky_dieu_chinh_ls.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_DIEU_CHINH_LS);
            if (m_us_v_trai_phieu.dcID_DV_DIEU_CHINH_LS == ID_DON_VI_KY_HAN.THANG)
                m_lbl_dv_ky_dieu_chinh_ls.Text = "tháng";
            else
                m_lbl_dv_ky_dieu_chinh_ls.Text = "năm";
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
            DateTime v_dat_den_ngay;
            if (m_us_v_trai_phieu.dcID_DV_DIEU_CHINH_LS == ID_DON_VI_KY_HAN.THANG)
                v_dat_den_ngay = m_us_gd_lich_tt_lai_goc.datNGAY_BAT_DAU_AD_LS.AddMonths(int.Parse(CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_DIEU_CHINH_LS)));
            else v_dat_den_ngay = m_us_gd_lich_tt_lai_goc.datNGAY_BAT_DAU_AD_LS.AddYears(int.Parse(CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_DIEU_CHINH_LS)));
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f750_ TB Lai Suat.doc");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_CAP_NHAT_LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY));
            v_obj_word_rpt.AddFindAndReplace("<NGAY_XAC_DINH_LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY));
            v_obj_word_rpt.AddFindAndReplace("<TO_CHUC_PHAT_HANH>", m_us_v_trai_phieu.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_word_rpt.AddFindAndReplace("<NGAN_HANG_THAM_CHIEU_LAI_SUAT>", m_us_v_trai_phieu.strNGAN_HANG_THAM_CHIEU_LS);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text +"VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + " VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_BAT_DAU>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY_BAT_DAU_AD_LS));
            v_obj_word_rpt.AddFindAndReplace("<NGAY_KET_THUC>", CIPConvert.ToStr(v_dat_den_ngay));
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            //
            v_obj_word_rpt.AddFindAndReplace("<LAI_SUAT>", CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.dcLAI_SUAT, "p"));
            v_obj_word_rpt.AddFindAndReplace("<GHI_CHU_VE_PHUONG_THUC_XAC_DINH_LAI_SUAT>", m_us_v_trai_phieu.strGHI_CHU_PHUONG_THUC_XD_LAI_SUAT);
            v_obj_word_rpt.AddFindAndReplace("<SO_HOP_DONG>", m_us_v_trai_phieu.strSO_HOP_DONG_DL_DK_LUU_KY);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_KY_HOP_DONG>", CIPConvert.ToStr(m_us_v_trai_phieu.datNGAY_KY_HD, "dd/MM/yyyy"));
            v_obj_word_rpt.Export2Word(true);
        }
        private DateTime get_ngay_thanh_toan(DateTime ip_ngay_chot_lai)
        {
            US_V_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_V_DM_DOT_PHAT_HANH(m_us_v_trai_phieu.dcID_DOT_PHAT_HANH);
            DS_DM_NGAY_LAM_VIEC v_ds_dm_ng_lam_viec = new DS_DM_NGAY_LAM_VIEC();
            US_DM_NGAY_LAM_VIEC v_us_dm_ng_lam_viec = new US_DM_NGAY_LAM_VIEC();
            decimal v_so_ngay_truoc_tt = m_us_v_trai_phieu.dcSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN;
            v_us_dm_ng_lam_viec.FillDatasetGetNgayThanhToan(
                v_ds_dm_ng_lam_viec,
                ip_ngay_chot_lai,
                v_so_ngay_truoc_tt,
                v_us_dm_dot_phat_hanh.strNGAY_LAM_VIEC_HAI_SAU_YN);
            if (v_ds_dm_ng_lam_viec.DM_NGAY_LAM_VIEC == null || v_ds_dm_ng_lam_viec.DM_NGAY_LAM_VIEC.Count < v_so_ngay_truoc_tt) return ip_ngay_chot_lai;
            return CIPConvert.ToDatetime(CIPConvert.ToStr(v_ds_dm_ng_lam_viec.DM_NGAY_LAM_VIEC.Rows[(int)v_so_ngay_truoc_tt - 1][DM_NGAY_LAM_VIEC.NGAY]));
        }
        private void thong_bao_ngay_chot_tien_lai()
        {
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            grid2us_object(m_us_gd_lich_tt_lai_goc, m_fg.Row);
            DateTime v_dat_ngay_bdau_thanh_toan, v_dat_ngay_thanh_toan;
            //Ham duoi nay tinh sai ngay thanh toan anh nhe --- Anh xem cho nao cua anh con tinh sai kieu nay thi sua di nhe
            v_dat_ngay_thanh_toan = get_ngay_thanh_toan( m_us_gd_lich_tt_lai_goc.datNGAY);//.AddDays((int)m_us_v_trai_phieu.dcSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN);
            if (m_us_v_trai_phieu.dcID_DV_KY_TRA_LAI == ID_DON_VI_KY_HAN.THANG)
                v_dat_ngay_bdau_thanh_toan = v_dat_ngay_thanh_toan.AddMonths(-(int)m_us_v_trai_phieu.dcKY_TRA_LAI);
            else v_dat_ngay_bdau_thanh_toan = v_dat_ngay_thanh_toan.AddYears(-(int)m_us_v_trai_phieu.dcKY_TRA_LAI);
            string v_str_ngung_chuyen_nhuong = "";
            if (m_us_v_trai_phieu.strNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN.Equals("Y"))
            {
                if (m_us_v_trai_phieu.strNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN.Equals("Y"))
                    v_str_ngung_chuyen_nhuong = "từ ngày " + CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY, "dd/MM/yyyy") + "(ngày chốt) đến hết ngày " + CIPConvert.ToStr(v_dat_ngay_thanh_toan, "dd/MM/yyyy") + "(ngày thanh toán)";
                else v_str_ngung_chuyen_nhuong = "trong ngày " + CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY, "dd/MM/yyyy") + "(ngày chốt)";
            }

            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f750_TB Trai Chu Ngay Chot.doc");
            v_obj_word_rpt.AddFindAndReplace("<TO_CHUC_PHAT_HANH>", m_us_v_trai_phieu.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text +"VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            v_obj_word_rpt.AddFindAndReplace("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_CHOT_DANH_SACH>",CIPConvert.ToStr(m_us_gd_lich_tt_lai_goc.datNGAY, "dd/MM/yyyy" ));
            v_obj_word_rpt.AddFindAndReplace("<NGAY_BAT_DAU>", CIPConvert.ToStr(v_dat_ngay_bdau_thanh_toan));
            v_obj_word_rpt.AddFindAndReplace("<NGAY_KET_THUC>", CIPConvert.ToStr(v_dat_ngay_thanh_toan));
            US_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU v_us_so_tien_lai_tren_tp = new US_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU();
            DS_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU v_ds_so_tien_lai_tren_tp = new DS_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU();
            v_us_so_tien_lai_tren_tp.fill_dataset_by_trai_phieu_in_times(v_ds_so_tien_lai_tren_tp, v_dat_ngay_bdau_thanh_toan, v_dat_ngay_thanh_toan, m_us_v_trai_phieu.dcID);
            decimal v_so_tien_lai_tren_tp;
            if (v_ds_so_tien_lai_tren_tp.GD_SO_TIEN_LAI_TREN_TRAI_PHIEU != null && v_ds_so_tien_lai_tren_tp.GD_SO_TIEN_LAI_TREN_TRAI_PHIEU.Rows.Count > 0)
                v_so_tien_lai_tren_tp = CIPConvert.ToDecimal(v_ds_so_tien_lai_tren_tp.GD_SO_TIEN_LAI_TREN_TRAI_PHIEU.Rows[0][GD_SO_TIEN_LAI_TREN_TRAI_PHIEU.SO_TIEN_LAI_TREN_TRAI_PHIEU]);
            else v_so_tien_lai_tren_tp = 0;
            v_obj_word_rpt.AddFindAndReplace("<SO_TIEN>", CIPConvert.ToStr(v_so_tien_lai_tren_tp, "#,###")); // cái này Ninh làm nốt nhé
            v_obj_word_rpt.AddFindAndReplace("<NGAY_THANH_TOAN>", CIPConvert.ToStr(v_dat_ngay_thanh_toan, "dd/MM/yyyy"));
            v_obj_word_rpt.AddFindAndReplace("<NGUNG_CHUYEN_NHUONG>", v_str_ngung_chuyen_nhuong);
            v_obj_word_rpt.Export2Word(true);
        }

        private void thong_bao_dot_thanh_toan_lai_trai_phieu()
        {
            if (m_fg.Rows[m_fg.Row].UserData == null) return;
            grid2us_object(m_us_gd_lich_tt_lai_goc, m_fg.Row);
            DS_GD_CHOT_LAI v_ds_gd_chot_lai = new DS_GD_CHOT_LAI();
            m_us_gd_chot_lai.FillDSChotLaiByIDTraiPhieuAndNgayThanhToan(v_ds_gd_chot_lai, m_us_gd_lich_tt_lai_goc.dcID_TRAI_PHIEU, m_us_gd_lich_tt_lai_goc.datNGAY);

            if (v_ds_gd_chot_lai.GD_CHOT_LAI.Rows.Count == 0)
            {
                MessageBox.Show("Giao dịch chốt lãi chưa được thực hiện.");
                return;
            }
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f700_TB TCPH Dot Thanh Toan.doc");
            US_V_DM_TO_CHUC_PHAT_HANH v_dm_to_chuc_phat_hanh = new US_V_DM_TO_CHUC_PHAT_HANH(m_us_v_trai_phieu.dcID_TO_CHUC_PHAT_HANH);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_KY_KET>", CIPConvert.ToStr(m_us_v_trai_phieu.datNGAY_KY_HD,"dd/MM/yyyy"));
            v_obj_word_rpt.AddFindAndReplace("<MA_SO>", m_us_v_trai_phieu.strSO_HOP_DONG_DL_DK_LUU_KY);
            v_obj_word_rpt.AddFindAndReplace("<TO_CHUC_PHAT_HANH>", v_dm_to_chuc_phat_hanh.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_v_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<MENH_GIA>", m_txt_menh_gia.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_DAO_HAN>", m_txt_ngay_dao_han.Text);
            v_obj_word_rpt.AddFindAndReplace("<SO_LUONG_TRAI_PHIEU>", m_txt_tong_so_luong_trai_phieu.Text);
            v_obj_word_rpt.AddFindAndReplace("<TONG_GIA_TRI_TRAI_PHIEU>", m_txt_tong_gia_tri_trai_phieu.Text + "VNĐ");
            v_obj_word_rpt.AddFindAndReplace("<KY_HAN>", m_txt_ky_han.Text + " năm"); // Can phai sua
            v_obj_word_rpt.AddFindAndReplace("<KY_TINH_LAI>", m_txt_ky_tinh_lai.Text + " tháng");
            //Chua biet dung hay sai
            v_obj_word_rpt.AddFindAndReplace("<LAI_SUAT>", m_txt_lai_suat.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_THANH_TOAN_LAI>", CIPConvert.ToStr(v_ds_gd_chot_lai.GD_CHOT_LAI.Rows[0][GD_CHOT_LAI.NGAY_THANH_TOAN]));
            if (v_ds_gd_chot_lai.GD_CHOT_LAI.Rows[0][GD_CHOT_LAI.MUC_DICH].GetType() != typeof(DBNull))
                v_obj_word_rpt.AddFindAndReplace("<MUC_DICH>", CIPConvert.ToStr(v_ds_gd_chot_lai.GD_CHOT_LAI.Rows[0][GD_CHOT_LAI.MUC_DICH]));
            else v_obj_word_rpt.AddFindAndReplace("<MUC_DICH>", "");
            v_obj_word_rpt.AddFindAndReplace("<NGAY_BAT_DAU>", CIPConvert.ToStr(v_ds_gd_chot_lai.GD_CHOT_LAI.Rows[0][GD_CHOT_LAI.NGAY_DAU_KY]));
            v_obj_word_rpt.AddFindAndReplace("<NGAY_KET_THUC>", CIPConvert.ToStr(v_ds_gd_chot_lai.GD_CHOT_LAI.Rows[0][GD_CHOT_LAI.NGAY_CUOI_KY]));

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
            
            US_V_DM_DOT_PHAT_HANH v_dm_dot_ph = new US_V_DM_DOT_PHAT_HANH(m_us_v_trai_phieu.dcID_DOT_PHAT_HANH);
            v_obj_word_rpt.AddFindAndReplace("<NGAN_HANG_NHAN_THANH_TOAN>", v_dm_dot_ph.strNGAN_HANG_DAI_LY_QUAN_LY_TK);
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
                    m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.SUA;
                }
                else m_us_v_ht_log_truy_cap.dcID_LOAI_HANH_DONG = LOG_TRUY_CAP.THEM;
                // nếu đồng ý or chưa có thì cho gen
                if (v_bool_xac_nhan || v_ds_lich.GD_LICH_THANH_TOAN_LAI_GOC.Rows.Count == 0)
                {
                    m_us_gd_lich_tt_lai_goc.BeginTransaction();
                    m_us_gd_lich_tt_lai_goc.GenLichThanhToanLaiGoc(m_us_v_trai_phieu.dcID, CAppContext_201.getCurrentUserID());
                    ghi_log_he_thong();
                    // ghi log hệ thống
                    try
                    {
                        m_us_v_ht_log_truy_cap.Insert();
                    }
                    catch
                    {
                        BaseMessages.MsgBox_Infor("Đã xảy ra lỗi trong quá trình ghi log hệ thống");
                    }
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
