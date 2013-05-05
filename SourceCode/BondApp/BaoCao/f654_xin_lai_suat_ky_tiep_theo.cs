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
    public partial class f654_xin_lai_suat_ky_tiep_theo : System.Windows.Forms.Form
    {
        public f654_xin_lai_suat_ky_tiep_theo()
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

        #region Data Structure

        #endregion

        #region Members
        //ITransferDataRow m_obj_trans;
        //DS_V_DM_TRAI_CHU_CHOT_LAI m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
        //US_V_DM_TRAI_CHU_CHOT_LAI m_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_PHIEU m_us_trai_phieu = new US_V_DM_TRAI_PHIEU();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            //CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            this.KeyPreview = true;
            m_lbl_header.Font = new Font("Arial", 16);
            m_lbl_header.ForeColor = Color.DarkRed;
            m_lbl_header.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_initial_form_load()
        {
            		
        }

        /*private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TONG_SO_DU, e_col_Number.TONG_SO_DU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_TRAI_PHIEU, e_col_Number.ID_TRAI_PHIEU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_TRAI_CHU_CHOT_LAI.NewRow());
            return v_obj_trans;
        }*/

        /*private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
            //load_data_2_cbo();
            m_us.FillDatasetByIDTraiPhieuAndNgayChotLai(m_ds, m_us_trai_phieu.dcID, CIPConvert.ToDatetime(m_txt_ngay_chot.Text));
            foreach (DataRow v_dr in m_ds.V_DM_TRAI_CHU_CHOT_LAI.Rows)
            {
                v_dr["ID_TRAI_PHIEU"] = m_us_trai_phieu.dcMENH_GIA * CIPConvert.ToDecimal(v_dr["TONG_SO_DU"]);
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }*/

        private void load_data_2_cbo()
        {
            if (m_us_trai_phieu != null)
            {
                decimal v_dc_so_ky_tra_lai;
                int v_i_current = 0;
                double v_d_ngay = 0;
                US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_trai_phieu.dcID_DOT_PHAT_HANH);
                m_cbo_ky_tinh_lai.Items.Clear();
                if (m_us_trai_phieu.dcID_DV_KY_TRA_LAI == 18)
                {
                    v_dc_so_ky_tra_lai = m_us_trai_phieu.dcKY_HAN / m_us_trai_phieu.dcKY_TRA_LAI * 12;
                    v_d_ngay = (DateTime.Now - v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH).TotalDays;
                }
                else
                {
                    v_dc_so_ky_tra_lai = m_us_trai_phieu.dcKY_HAN / m_us_trai_phieu.dcKY_TRA_LAI;
                }
                for (int i = 1; i <= v_dc_so_ky_tra_lai; i++)
                {
                    m_cbo_ky_tinh_lai.Items.Add(i);
                    DateTime v_dat = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH;
                    v_dat = v_dat.AddMonths(i * (int)m_us_trai_phieu.dcKY_TRA_LAI);
                    if (v_d_ngay >= (v_dat - v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH).TotalDays)
                    {
                        v_i_current = i;
                    }
                }

                if (v_i_current != 0)
                {
                    m_cbo_ky_tinh_lai.SelectedIndex = v_i_current - 1;
                    load_ngay_chot_theo_ky(v_i_current);
                }
            }
        }

        private void load_ngay_chot_theo_ky(int i_ky_chot_lai)
        {
            //US_HT_THAM_SO_HE_THONG v_us_ht = new US_HT_THAM_SO_HE_THONG(ID_THAM_SO_HE_THONG.CHOT_LAI_TRUOC);
            US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_trai_phieu.dcID_DOT_PHAT_HANH);
            DateTime v_dat_ngay_chot_tuong_ung = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH;
            DateTime v_dat_ngay_chot_lai;
            v_dat_ngay_chot_tuong_ung = v_dat_ngay_chot_tuong_ung.AddMonths(i_ky_chot_lai * (int)m_us_trai_phieu.dcID_DV_DIEU_CHINH_LS);
            m_txt_ngay_bat_dau.Text = CIPConvert.ToStr(v_dat_ngay_chot_tuong_ung, "dd/MM/yyyy");
            v_dat_ngay_chot_lai = v_dat_ngay_chot_tuong_ung.AddDays(-(int)CIPConvert.ToDecimal(m_us_trai_phieu.dcSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN));
            v_dat_ngay_chot_tuong_ung = v_dat_ngay_chot_tuong_ung.AddMonths((int)m_us_trai_phieu.dcID_DV_DIEU_CHINH_LS);
            m_txt_ngay_ket_thuc.Text = CIPConvert.ToStr(v_dat_ngay_chot_tuong_ung, "dd/MM/yyyy");
            m_txt_ngay_chot.Text = CIPConvert.ToStr(v_dat_ngay_chot_lai, "dd/MM/yyyy");
        }

        /*private void grid2us_object(US_V_DM_TRAI_CHU_CHOT_LAI i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }*/


        /*private void us_object2grid(US_V_DM_TRAI_CHU_CHOT_LAI i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }*/


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
            m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_trai_phieu.dcLAI_SUAT_DEFAULT * 100, "#,##0.00");
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
                load_data_2_cbo();
                //load_data_2_grid();
            }
        }

        private void load_data_theo_ky()
        {
            load_ngay_chot_theo_ky(m_cbo_ky_tinh_lai.SelectedIndex);
            //load_data_2_grid();
        }

        private void export_xin_lai_suat()
        {
            if (m_us_trai_phieu == null || m_us_trai_phieu.strMA_TRAI_PHIEU == "") return;
            IP.Core.IPWordReport.CWordReport v_obj_word_rpt = new CWordReport("f800_Xin LS.doc");
            v_obj_word_rpt.AddFindAndReplace("<TEN_TRAI_PHIEU>", m_us_trai_phieu.strTEN_TRAI_PHIEU);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_PHAT_HANH>", m_txt_ngay_phat_hanh.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_TINH_LAI_DAU>", m_txt_ngay_bat_dau.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_TINH_LAI_CUOI>", m_txt_ngay_ket_thuc.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_KHONG_TINH_LAI>", m_txt_ngay_ket_thuc.Text);
            v_obj_word_rpt.AddFindAndReplace("<NGAY_XAC_DINH_LS>", m_txt_ngay_chot.Text);
            v_obj_word_rpt.AddFindAndReplace("<GHI_CHU_VE_PHUONG_THUC_XD_LS>", m_us_trai_phieu.strGHI_CHU_PHUONG_THUC_XD_LAI_SUAT);
            v_obj_word_rpt.Export2Word(true);

        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_cmd_export_excel.Click += new EventHandler(m_cmd_export_excel_Click);
            m_cbo_ky_tinh_lai.SelectedIndexChanged += new EventHandler(m_cbo_ky_tinh_lai_SelectedIndexChanged);
            this.KeyDown += new KeyEventHandler(f654_xin_lai_suat_ky_tiep_theo_KeyDown);
        }

        void f654_xin_lai_suat_ky_tiep_theo_KeyDown(object sender, KeyEventArgs e)
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
        #endregion

        #region Event

        private void f654_xin_lai_suat_ky_tiep_theo_Load(object sender, EventArgs e)
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

        void m_cbo_ky_tinh_lai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_theo_ky();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_export_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_xin_lai_suat();
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

        private void m_cmd_exit_Click(object sender, EventArgs e)
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
