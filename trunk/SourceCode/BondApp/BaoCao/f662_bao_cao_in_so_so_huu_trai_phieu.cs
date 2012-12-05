
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
using IP.Core.IPSystemAdmin;
using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using BondApp.ChucNang;
using BondApp;
using IP.Core.IPExcelReport;
using IP.Core.IPWordReport;

namespace BondApp.BaoCao
{
    public partial class f662_bao_cao_in_so_so_huu_trai_phieu : Form
    {
        public f662_bao_cao_in_so_so_huu_trai_phieu()
        {
            InitializeComponent();
        }

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }      

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            STT = 1,
            CMT_GIAY_DKKD = 4
,
            TEN_TRAI_CHU = 3
                ,
            TONG_SO_DU = 9
                ,
            NGAY_CAP_CMT = 5
                ,
            MA_TRAI_CHU = 2
                ,
            DIA_CHI = 7
                ,
            DIEN_THOAI = 8
                ,
            ID_TRAI_PHIEU = 10
                , NOI_CAP_CMT = 6
            ,TAI_KHOAN_NH = 11

        }
       
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_TRAI_CHU_CHOT_LAI m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_CHU_CHOT_LAI m_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_PHIEU m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();        
        #endregion



        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_initial_form_load()
        {                      
            m_obj_trans = get_trans_object(m_fg);
            //load_data_2_grid();		
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TONG_SO_DU, e_col_Number.TONG_SO_DU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MOBILE, e_col_Number.DIEN_THOAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TAI_KHOAN, e_col_Number.TAI_KHOAN_NH);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_TRAI_PHIEU, e_col_Number.ID_TRAI_PHIEU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_TRAI_CHU_CHOT_LAI.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
            //load_data_2_cbo();
            m_us.FillDatasetByIDTraiPhieuAndNgayChotLai1(m_ds, m_us_trai_phieu.dcID, DateTime.Today);
            foreach (DataRow v_dr in m_ds.V_DM_TRAI_CHU_CHOT_LAI.Rows)
            {
                v_dr["ID_TRAI_PHIEU"] = m_us_trai_phieu.dcMENH_GIA * CIPConvert.ToDecimal(v_dr["TONG_SO_DU"]);
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;
        }



        private void grid2us_object(US_V_DM_TRAI_CHU_CHOT_LAI i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_TRAI_CHU_CHOT_LAI i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void us_trai_phieu_2_form()
        {
            m_txt_ma_trai_phieu.Text = m_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = m_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(m_us_trai_phieu.dcKY_HAN, "#,###");
            if (m_us_trai_phieu.dcID_DV_KY_HAN == ID_DON_VI_KY_HAN.THANG)
                m_lbl_dv_ky_han.Text = "tháng";
            else
                m_lbl_dv_ky_han.Text = "năm";
            try
            {
                US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_trai_phieu.dcID_DOT_PHAT_HANH);
                US_DM_TO_CHUC_PHAT_HANH v_us_dm_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(v_us_dm_dot_phat_hanh.dcID_TO_CHUC_PHAT_HANH);
                m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH, "dd/MM/yyyy");               
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(m_us_trai_phieu.datNGAY_DAO_HAN);
            m_txt_tong_so_luong_trai_phieu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_SL_PHAT_HANH, "#,###");
            m_txt_tong_gia_tri_trai_phieu.Text = CIPConvert.ToStr(m_us_trai_phieu.dcTONG_GIA_TRI, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_trai_phieu.dcLAI_SUAT_DEFAULT * 100, "#,##0.0000");
            m_txt_ky_tinh_lai.Text = CIPConvert.ToStr(m_us_trai_phieu.dcKY_TRA_LAI, "#,###");
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();
            m_us_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_trai_phieu.IsIDNull() && m_us_trai_phieu.dcID != -1)
            {
                us_trai_phieu_2_form();
                load_data_2_grid();
            }
        }

        private void export_excel()
        {
            US_DM_TO_CHUC_PHAT_HANH v_us_to_chuc_phat_hanh = new US_DM_TO_CHUC_PHAT_HANH(m_us_trai_phieu.dcID_TO_CHUC_PHAT_HANH);
            US_V_DM_DOT_PHAT_HANH_LAN_THU v_us_dot_phat_hanh = new US_V_DM_DOT_PHAT_HANH_LAN_THU(m_us_trai_phieu.dcID_DOT_PHAT_HANH);
            CExcelReport v_obj_export_excel1 = new CExcelReport("f500_DLDKLK_So_DKNSHTP_bia.xls", 15, 2);
            v_obj_export_excel1.AddFindAndReplaceItem("<TO_CHUC_PHAT_HANH>", m_us_trai_phieu.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_export_excel1.AddFindAndReplaceItem("<DOT_PHAT_HANH>", CIPConvert.ToStr(v_us_dot_phat_hanh.dcLAN_THU, "#,###"));  
            v_obj_export_excel1.AddFindAndReplaceItem("<NGAY>", m_us_trai_phieu.datNGAY_PHAT_HANH.Day);
            v_obj_export_excel1.AddFindAndReplaceItem("<THANG>", m_us_trai_phieu.datNGAY_PHAT_HANH.Month);
            v_obj_export_excel1.AddFindAndReplaceItem("<NAM>", m_us_trai_phieu.datNGAY_PHAT_HANH.Year); 
            v_obj_export_excel1.FindAndReplace(false);
            
            CExcelReport v_obj_export_excel2 = new CExcelReport("f500_DLDKLK_So_DKNSHTP_sdknsh.xls", 15, 2);
            v_obj_export_excel2.AddFindAndReplaceItem("<TO_CHUC_PHAT_HANH>", m_us_trai_phieu.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_export_excel2.AddFindAndReplaceItem("<SO_CHUNG_NHAN_DKKD>", v_us_to_chuc_phat_hanh.strCHUNG_NHAN_DKDN);
            v_obj_export_excel2.AddFindAndReplaceItem("<TRU_SO_CHINH>", v_us_to_chuc_phat_hanh.strDIA_CHI_TRU_SO_CHINH);
            v_obj_export_excel2.AddFindAndReplaceItem("<SO_DIEN_THOAI>", v_us_to_chuc_phat_hanh.strDIEN_THOAI);
            v_obj_export_excel2.AddFindAndReplaceItem("<SO_FAX>", v_us_to_chuc_phat_hanh.strFAX);
            v_obj_export_excel2.AddFindAndReplaceItem("<SO_TAI_KHOAN>", v_us_to_chuc_phat_hanh.strSO_TAI_KHOAN);
            v_obj_export_excel2.AddFindAndReplaceItem("<DIA_CHI>", v_us_to_chuc_phat_hanh.strMO_TAI_NGAN_HANG);
            v_obj_export_excel2.AddFindAndReplaceItem("<TEN_TRAI_PHIEU>", m_us_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_export_excel2.AddFindAndReplaceItem("<LOAI_TRAI_PHIEU>", m_us_trai_phieu.strLOAI_TRAI_PHIEU);
            v_obj_export_excel2.AddFindAndReplaceItem("<MENH_GIA>", m_us_trai_phieu.dcMENH_GIA);
            v_obj_export_excel2.AddFindAndReplaceItem("<KY_HAN_TRAI_PHIEU>", m_us_trai_phieu.dcKY_HAN.ToString() + " " + m_us_trai_phieu.strDON_VI_KY_HAN);
            v_obj_export_excel2.AddFindAndReplaceItem("<LAI_SUAT>", m_us_trai_phieu.dcLAI_SUAT_DEFAULT* 100);
            v_obj_export_excel2.AddFindAndReplaceItem("<PHUONG_THUC_TRA_LAI>", m_us_trai_phieu.strGHI_CHU_PHUONG_THUC_XD_LAI_SUAT);
            v_obj_export_excel2.AddFindAndReplaceItem("<NGAY_PHAT_HANH>", m_us_trai_phieu.dcTONG_SL_PHAT_HANH);
            v_obj_export_excel2.AddFindAndReplaceItem("<NGAY_DAO_HAN>", m_us_trai_phieu.dcTONG_GIA_TRI);
            v_obj_export_excel2.AddFindAndReplaceItem("<SO_LUONG_TRAI_PHIEU>", m_us_trai_phieu.dcTONG_SL_PHAT_HANH);
            v_obj_export_excel2.AddFindAndReplaceItem("<GIA_TRI_TRAI_PHIEU>", m_us_trai_phieu.dcTONG_GIA_TRI);
            v_obj_export_excel2.FindAndReplace(false);


            CExcelReport v_obj_export_excel3 = new CExcelReport("f500_DLDKLK_So_DKNSHTP_dsnshtp.xls", 10, 4);
            v_obj_export_excel3.AddFindAndReplaceItem("<TEN_TO_CHUC_PHAT_HANH>", m_us_trai_phieu.strTEN_TO_CHUC_PHAT_HANH);
            v_obj_export_excel3.AddFindAndReplaceItem("<MENH_GIA_TRAI_PHIEU>", m_us_trai_phieu.dcMENH_GIA);          
            v_obj_export_excel3.FindAndReplace(false);
            v_obj_export_excel3.Export2ExcelWithoutFixedRows(m_fg, (int)e_col_Number.MA_TRAI_CHU, m_fg.Cols.Count - 1, false);

        }        
        #endregion

        #region Events
        private void set_define_events()
        {                                                                
        }      

        void f662_bao_cao_in_so_so_huu_trai_phieu_KeyDown(object sender, KeyEventArgs e)
        {
           
        }                
       

        private void m_cmd_chon_trai_phieu_Click_1(object sender, EventArgs e)
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

        private void m_cmd_exit_Click_1(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_export_excel_Click_1(object sender, EventArgs e)
        {
            try
            {
                export_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f662_bao_cao_in_so_so_huu_trai_phieu_Load_1(object sender, EventArgs e)
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
        #endregion

        private void f662_bao_cao_in_so_so_huu_trai_phieu_KeyDown_1(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                    this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
