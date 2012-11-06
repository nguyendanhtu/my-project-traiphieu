using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BondDS;
using BondUS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using System.Collections;
using System.Data.SqlTypes;

namespace BondApp.ChucNang
{
    public partial class f950_quan_ly_tra_goc : Form
    {
        public f950_quan_ly_tra_goc()
        {
            InitializeComponent();
            format_controls();
        }
        
		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}

        public void display_tra_goc_trai_phieu(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_v_trai_phieu = ip_us_trai_phieu;
            this.ShowDialog();
        }
		#endregion

		#region Data Structure
        private enum e_col_Number
        {
            STT = 1,
            CMT_GIAY_DKKD = 7
,
            TEN_TRAI_CHU = 3
                ,
            ID_LOAI_TRAI_CHU = 12
                ,
            NGAY_CAP_CMT = 8
                ,
            ID_TRANG_THAI = 15
                ,
            SO_DU_KHA_DUNG = 5
                ,
            MA_TRAI_CHU = 2
                ,
            SO_TAI_KHOAN = 13
                ,
            DIA_CHI = 10
                ,
            MO_TAI_NGAN_HANG = 14
                ,
            ID_TRAI_PHIEU = 4
                ,
            MOBILE = 11
                ,
            SO_TIEN_LAI = 6
                , NOI_CAP_CMT = 9

        }	
        private enum e_Mod
        {
            DA_TRA = 1,
            CHUA_TRA = 0,
            TAT_CA = 2
        }
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;
        DS_V_DM_TRAI_CHU_CHOT_LAI m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_CHU_CHOT_LAI m_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
        //US_V_DM_TRAI_PHIEU m_us_trai_phieu;
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu;
        e_Mod m_mod = e_Mod.CHUA_TRA;
        US_GD_SO_DU_TRAI_PHIEU m_us_gd_so_du_trai_phieu;
        US_DM_TRAI_CHU m_us_dm_trai_chu;
        decimal m_d_ky_tinh_lai = 0;
        DateTime m_dat_ngay_chot_lai_cuoi;
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            m_lbl_trang_thai.Font = new Font("Arial", 14);
            m_lbl_trang_thai.ForeColor = Color.DarkRed;
            set_define_events();	
		}
		private void set_initial_form_load(){
            if (m_us_v_trai_phieu != null)
            {
                us_trai_phieu_2_form(m_us_v_trai_phieu);
                load_data_2_cbo();
            }
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(m_us_v_trai_phieu);
            m_cbo_trang_thai.Items.Add("Tất cả");
            m_cbo_trang_thai.Items.Add("Đã thanh toán");
            m_cbo_trang_thai.Items.Add("Chưa thanh toán");

            m_cbo_trang_thai.SelectedIndex = 0;
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_LOAI_TRAI_CHU, e_col_Number.ID_LOAI_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_DU_KHA_DUNG, e_col_Number.SO_DU_KHA_DUNG);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TAI_KHOAN, e_col_Number.SO_TAI_KHOAN);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MO_TAI_NGAN_HANG, e_col_Number.MO_TAI_NGAN_HANG);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_TRAI_PHIEU, e_col_Number.ID_TRAI_PHIEU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MOBILE, e_col_Number.MOBILE);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TIEN_LAI, e_col_Number.SO_TIEN_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_TRAI_CHU_CHOT_LAI.NewRow());
            return v_obj_trans;		
		}

        private void load_data_2_grid(US_V_DM_TRAI_PHIEU ip_us_v_trai_phieu)
        {
            m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
            if (m_us_v_trai_phieu != null)
            {
                switch (m_mod)
                {
                    case e_Mod.TAT_CA:
                        m_us.FillDatasetByIDTraiPhieuAndNgayChotLai(m_ds, m_us_v_trai_phieu.dcID, m_dat_ngay_chot_lai_cuoi,"A");
                        break;
                    case e_Mod.DA_TRA:
                        m_us.FillDatasetByIDTraiPhieuAndNgayChotLaiAndTrangThaiYes(m_ds, m_us_v_trai_phieu.dcID, m_dat_ngay_chot_lai_cuoi);
                        break;
                    case e_Mod.CHUA_TRA:
                        m_us.FillDatasetByIDTraiPhieuAndNgayChotLaiAndTrangThaiNo(m_ds, ip_us_v_trai_phieu.dcID, m_dat_ngay_chot_lai_cuoi);
                        break;
                }
            }
            else
            {
                return;
            }
            foreach (DataRow v_dr in m_ds.V_DM_TRAI_CHU_CHOT_LAI.Rows)
            {
                v_dr["SO_TIEN_LAI"] = m_us_v_trai_phieu.dcMENH_GIA * CIPConvert.ToDecimal(v_dr["SO_DU_KHA_DUNG"]);
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;

            //Load loai trai chu
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("LOAI_TRAI_CHU", v_ds_tu_dien);
            Hashtable v_hst_loai_tu_dien = new Hashtable();
            foreach (DataRow v_dr in v_ds_tu_dien.CM_DM_TU_DIEN.Rows)
            {
                v_hst_loai_tu_dien.Add(v_dr[CM_DM_TU_DIEN.ID], v_dr[CM_DM_TU_DIEN.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_LOAI_TRAI_CHU].DataMap = v_hst_loai_tu_dien;

            //load trang thai
            v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.fill_tu_dien_cung_loai_ds("TRANG_THAI_GD", v_ds_tu_dien);

            Hashtable v_hst_trang_thai = new Hashtable();
            foreach (DataRow v_dr in v_ds_tu_dien.CM_DM_TU_DIEN.Rows)
            {
                v_hst_trang_thai.Add(v_dr[CM_DM_TU_DIEN.ID], v_dr[CM_DM_TU_DIEN.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_TRANG_THAI].DataMap = v_hst_trang_thai;
        }

        private void load_data_2_cbo()
        {
            if (m_us_v_trai_phieu != null)
            {
                //int v_i_current = 0;
                double v_d_ngay = 0;
                US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_v_trai_phieu.dcID_DOT_PHAT_HANH);
                if (m_us_v_trai_phieu.dcID_DV_KY_TRA_LAI == 18)
                {
                    m_d_ky_tinh_lai = m_us_v_trai_phieu.dcKY_HAN / m_us_v_trai_phieu.dcKY_TRA_LAI * 12;
                    v_d_ngay = (DateTime.Now - v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH).TotalDays;
                }
                else
                {
                    m_d_ky_tinh_lai = m_us_v_trai_phieu.dcKY_HAN / m_us_v_trai_phieu.dcKY_TRA_LAI;
                }

                /*for (int i = 1; i <= m_d_ky_tinh_lai; i++)
                {
                    DateTime v_dat = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH;
                    v_dat = v_dat.AddMonths(i * (int)m_us_v_trai_phieu.dcKY_TRA_LAI);
                    if (v_d_ngay >= (v_dat - v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH).TotalDays)
                    {
                        v_i_current = i;
                    }
                }*/

                US_HT_THAM_SO_HE_THONG v_us_ht = new US_HT_THAM_SO_HE_THONG(ID_THAM_SO_HE_THONG.CHOT_LAI_TRUOC);
                m_dat_ngay_chot_lai_cuoi = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH;
                m_dat_ngay_chot_lai_cuoi = m_dat_ngay_chot_lai_cuoi.AddMonths((int)(m_d_ky_tinh_lai * m_us_v_trai_phieu.dcKY_TRA_LAI));
                m_dat_ngay_chot_lai_cuoi = m_dat_ngay_chot_lai_cuoi.AddDays(-(int)CIPConvert.ToDecimal(v_us_ht.strGIA_TRI));

                if (DateTime.Now < m_dat_ngay_chot_lai_cuoi) m_lbl_trang_thai.Text = "Trái phiếu này chưa đến kỳ trả gốc!";
            }
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

        private void us_trai_phieu_2_form(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            //US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH);
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN);
            m_txt_menh_gia.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_HAN);
        }

        private void view_theo_trang_thai()
        {
            switch(m_cbo_trang_thai.SelectedIndex)
            {
                case 0:
                    m_mod = e_Mod.TAT_CA;
                    break;
                case 1:
                    m_mod = e_Mod.DA_TRA;
                    break;
                case 2:
                    m_mod = e_Mod.CHUA_TRA;
                    break;
            }
            
            load_data_2_grid(m_us_v_trai_phieu);
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (m_us_v_trai_phieu.strMA_TRAI_PHIEU != "")
            {
                us_trai_phieu_2_form(m_us_v_trai_phieu);
                load_data_2_cbo();
                load_data_2_grid(m_us_v_trai_phieu);
            }
        }

        private void thanh_toan_tra_goc()
        {
            //Kiểm tra xem có dữ liệu hay chưa
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_us_v_trai_phieu == null || m_us_v_trai_phieu.strMA_TRAI_PHIEU == "") return;
            grid2us_object(m_us, m_fg.Row);

            //Kiểm tra xem trái chủ này đã thanh toán chưa
            if (m_us.dcID_TRANG_THAI == List_trang_thai.Da_Thuc_Hien){
                BaseMessages.MsgBox_Infor("Trái chủ này đã thanh toán!");
                return;
            }

            if (BaseMessages.MsgBox_Confirm(" Khách hàng: " + m_us.strTEN_TRAI_CHU + "          Số tiền gốc: " + CIPConvert.ToStr(m_us_v_trai_phieu.dcMENH_GIA * m_us.dcSO_DU_KHA_DUNG, "#,###") + " VNĐ"))
            {
                //Thay đổi trạng thái trái chủ
                m_us_dm_trai_chu = new US_DM_TRAI_CHU(m_us.dcID_TRAI_CHU);
                m_us_dm_trai_chu.dcID_TRANG_THAI = List_trang_thai.Da_Thuc_Hien;
                m_us_dm_trai_chu.strGHI_CHU3 = "Ngày thanh toán gốc: " + DateTime.Now.ToString("dd/MM/yyyy");

                //Đưa tổng số dư và số dư khả dụng về 0
                m_us_gd_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
                m_us_gd_so_du_trai_phieu.dcID_TRAI_CHU = m_us.dcID_TRAI_CHU;
                m_us_gd_so_du_trai_phieu.datNGAY = DateTime.Now;
                m_us_gd_so_du_trai_phieu.dcSO_DU_KHA_DUNG = 0;
                m_us_gd_so_du_trai_phieu.dcTONG_SO_DU = m_us.dcTONG_SO_DU - m_us.dcSO_DU_KHA_DUNG;

                m_us_dm_trai_chu.Update();
                m_us_gd_so_du_trai_phieu.Insert();
                load_data_2_grid(m_us_v_trai_phieu);
            }
        }

		private void set_define_events(){
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_cbo_trang_thai.SelectedIndexChanged += new EventHandler(m_cbo_trang_thai_SelectedIndexChanged);
            m_cmd_thanh_toan.Click += new EventHandler(m_cmd_thanh_toan_Click);
            this.KeyDown += new KeyEventHandler(f950_quan_ly_tra_goc_KeyDown);
		}

        void f950_quan_ly_tra_goc_KeyDown(object sender, KeyEventArgs e)
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

		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//

        private void f950_quan_ly_tra_goc_Load(object sender, EventArgs e)
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

        void m_cbo_trang_thai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                view_theo_trang_thai();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_thanh_toan_Click(object sender, EventArgs e)
        {
            try
            {
                thanh_toan_tra_goc();
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
	}
}