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

        public void display_tra_goc_trai_phieu(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_trai_phieu = ip_us_trai_phieu;
            this.ShowDialog();
        }
		#endregion

		#region Data Structure
        private enum e_col_Number
        {
            CMT_GIAY_DKKD = 10
,
            TEN_TRAI_CHU = 2
                ,
            ID_LOAI_TRAI_CHU = 13
                ,
            FAX = 9
                ,
            ID_TRANG_THAI = 16
                ,
            MA_TRAI_PHIEU = 3
                ,
            NGAY_CAP_CMT = 11
                ,
            MA_TRAI_CHU = 1
                ,
            SO_TAI_KHOAN = 14
                ,
            TEN_TRAI_PHIEU = 4
                ,
            DIA_CHI = 7
                ,
            MO_TAI_NGAN_HANG = 15
                ,
            MENH_GIA = 5
                ,
            MOBILE = 8
                ,
            TONG_SO_DU = 6
                , NOI_CAP_CMT = 12

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
		DS_V_GD_TRA_GOC m_ds = new DS_V_GD_TRA_GOC();
		US_V_GD_TRA_GOC m_us = new US_V_GD_TRA_GOC();
        US_DM_TRAI_PHIEU m_us_trai_phieu;
        e_Mod m_mod = e_Mod.CHUA_TRA;
        US_GD_SO_DU_TRAI_PHIEU m_us_gd_so_du_trai_phieu;
        US_DM_TRAI_CHU m_us_dm_trai_chu;
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
            set_define_events();	
		}
		private void set_initial_form_load(){
            if (m_us_trai_phieu != null)
                us_trai_phieu_2_form(m_us_trai_phieu);
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(m_us_trai_phieu);
            load_data_2_cbo();
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_TRA_GOC.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
            v_htb.Add(V_GD_TRA_GOC.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
            v_htb.Add(V_GD_TRA_GOC.ID_LOAI_TRAI_CHU, e_col_Number.ID_LOAI_TRAI_CHU);
            v_htb.Add(V_GD_TRA_GOC.FAX, e_col_Number.FAX);
            v_htb.Add(V_GD_TRA_GOC.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
            v_htb.Add(V_GD_TRA_GOC.MA_TRAI_PHIEU, e_col_Number.MA_TRAI_PHIEU);
            v_htb.Add(V_GD_TRA_GOC.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
            v_htb.Add(V_GD_TRA_GOC.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);
            v_htb.Add(V_GD_TRA_GOC.SO_TAI_KHOAN, e_col_Number.SO_TAI_KHOAN);
            v_htb.Add(V_GD_TRA_GOC.TEN_TRAI_PHIEU, e_col_Number.TEN_TRAI_PHIEU);
            v_htb.Add(V_GD_TRA_GOC.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_GD_TRA_GOC.MO_TAI_NGAN_HANG, e_col_Number.MO_TAI_NGAN_HANG);
            v_htb.Add(V_GD_TRA_GOC.MENH_GIA, e_col_Number.MENH_GIA);
            v_htb.Add(V_GD_TRA_GOC.MOBILE, e_col_Number.MOBILE);
            v_htb.Add(V_GD_TRA_GOC.TONG_SO_DU, e_col_Number.TONG_SO_DU);
            v_htb.Add(V_GD_TRA_GOC.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_TRA_GOC.NewRow());
			return v_obj_trans;			
		}

        private void load_data_2_grid(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_ds = new DS_V_GD_TRA_GOC();
            if (m_us_trai_phieu != null)
            {
                switch (m_mod)
                {
                    case e_Mod.TAT_CA:
                        m_us.FillDatasetByIDTraiPhieu(m_ds, m_us_trai_phieu.dcID);
                        break;
                    case e_Mod.DA_TRA:
                        m_us.FillDatasetByIDTraiPhieuYes(m_ds, m_us_trai_phieu.dcID);
                        break;
                    case e_Mod.CHUA_TRA:
                        m_us.FillDatasetByIDTraiPhieuNo(m_ds, ip_us_trai_phieu.dcID);
                        break;
                }
            }
            else
            {
                return;
            }
            
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
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
            m_cbo_trang_thai.Items.Add("Tất cả");
            m_cbo_trang_thai.Items.Add("Đã thanh toán");
            m_cbo_trang_thai.Items.Add("Chưa thanh toán");

            m_cbo_trang_thai.SelectedIndex = 2;
        }

		private void grid2us_object(US_V_GD_TRA_GOC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_TRA_GOC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void us_trai_phieu_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH);
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
            
            load_data_2_grid(m_us_trai_phieu);
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_trai_phieu = v_frm300.select_trai_phieu();
            if (m_us_trai_phieu.strMA_TRAI_PHIEU != "")
            {
                us_trai_phieu_2_form(m_us_trai_phieu);
                load_data_2_grid(m_us_trai_phieu);
            }
        }

        private void thanh_toan_tra_goc()
        {
            //Kiểm tra xem có dữ liệu hay chưa
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_us_trai_phieu == null) return;
            grid2us_object(m_us, m_fg.Row);

            //Kiểm tra xem trái chủ này đã thanh toán chưa
            if (m_us.dcID_TRANG_THAI == List_trang_thai.Da_Thuc_Hien){
                BaseMessages.MsgBox_Infor("Trái chủ này đã thanh toán!");
                return;
            }

            if (BaseMessages.MsgBox_Confirm(" Khách hàng: " + m_us.strTEN_TRAI_CHU + "                Số tiền thanh toán: " + CIPConvert.ToStr(m_us.dcMENH_GIA * m_us.dcTONG_SO_DU, "#,###") + " VNĐ"))
            {
                //Thay đổi trạng thái trái chủ
                m_us_dm_trai_chu = new US_DM_TRAI_CHU(m_us.dcID);
                m_us_dm_trai_chu.dcID_TRANG_THAI = List_trang_thai.Da_Thuc_Hien;

                //Đưa tổng số dư và số dư khả dụng về 0
                m_us_gd_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
                m_us_gd_so_du_trai_phieu.dcID_TRAI_CHU = m_us.dcID;
                m_us_gd_so_du_trai_phieu.datNGAY = DateTime.Now;
                m_us_gd_so_du_trai_phieu.dcSO_DU_KHA_DUNG = 0;
                m_us_gd_so_du_trai_phieu.dcTONG_SO_DU = 0;

                m_us_dm_trai_chu.Update();
                m_us_gd_so_du_trai_phieu.Insert();
                load_data_2_grid(m_us_trai_phieu);
            }
        }

		private void set_define_events(){
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_cbo_trang_thai.SelectedIndexChanged += new EventHandler(m_cbo_trang_thai_SelectedIndexChanged);
            m_cmd_thanh_toan.Click += new EventHandler(m_cmd_thanh_toan_Click);
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