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
    public partial class f900_quan_ly_coupon : Form
    {
        public f900_quan_ly_coupon()
        {
            InitializeComponent();
            format_control();
        }

        #region Public interface
        public void display()
        {
            this.ShowDialog();
        }

        public void display_tra_lai_trai_phieu(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_v_trai_phieu = ip_us_trai_phieu;
            this.ShowDialog();
        }

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            GHI_CHU3 = 22
,
            SO_LUONG_TINH_LAI = 6
                ,
            FAX = 16
                ,
            NGAY_CHOT_LAI = 10
                ,
            DIA_CHI = 14
                ,
            KY_TINH_LAI = 5
                ,
            SO_TAI_KHOAN = 12
                ,
            ID_CHOT_LAI = 26
                ,
            NOI_CAP_CMT = 18
                ,
            SO_TIEN_LAI = 7
                ,
            NGAY_NHAN_TIEN = 9
                ,
            DA_NHAN_TIEN_YN = 8
                ,
            GHI_CHU2 = 21
                ,
            ID_TRAI_PHIEU_SO_HUU = 4
                ,
            GHI_CHU1 = 20
                ,
            GHI_CHU_CHOT_LAI = 23
                ,
            NGAY_THANH_TOAN = 11
                ,
            ID_LOAI_TRAI_CHU = 19
                ,
            TEN_TRAI_CHU = 2
                ,
            ID_NGUOI_DUYET_CHOT_LAI = 25
                ,
            ID_TRAI_CHU = 27
                ,
            ID_NGUOI_LAP_CHOT_LAI = 24
                ,
            MO_TAI_NGAN_HANG = 13
                ,
            NGAY_CAP_CMT = 17
                ,
            MOBILE = 15
                ,
            CMT_GIAY_DKKD = 3
                , MA_TRAI_CHU = 1

        }

        private enum e_Mod
        {
            DA_TRA = 1,
            CHUA_TRA = 0,
            TAT_CA = 2
        }
        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu;
        US_GD_CHOT_LAI_DETAIL m_us_gd_chot_lai_detail;
        ITransferDataRow m_obj_trans;
        DS_V_DM_TRAI_CHU_CHOT_LAI m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_CHU_CHOT_LAI m_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
        e_Mod m_mod;
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            set_define_event();
        }

        private void set_inital_form_load()
        {
            m_mod = e_Mod.CHUA_TRA;
            if (m_us_v_trai_phieu != null)
                us_trai_phieu_2_form(m_us_v_trai_phieu);
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(m_us_v_trai_phieu);
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.GHI_CHU3, e_col_Number.GHI_CHU3);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_LUONG_TINH_LAI, e_col_Number.SO_LUONG_TINH_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.FAX, e_col_Number.FAX);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_CHOT_LAI, e_col_Number.NGAY_CHOT_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.KY_TINH_LAI, e_col_Number.KY_TINH_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TAI_KHOAN, e_col_Number.SO_TAI_KHOAN);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_CHOT_LAI, e_col_Number.ID_CHOT_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NOI_CAP_CMT, e_col_Number.NOI_CAP_CMT);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.SO_TIEN_LAI, e_col_Number.SO_TIEN_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_NHAN_TIEN, e_col_Number.NGAY_NHAN_TIEN);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.DA_NHAN_TIEN_YN, e_col_Number.DA_NHAN_TIEN_YN);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.GHI_CHU2, e_col_Number.GHI_CHU2);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_TRAI_PHIEU_SO_HUU, e_col_Number.ID_TRAI_PHIEU_SO_HUU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.GHI_CHU1, e_col_Number.GHI_CHU1);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.GHI_CHU_CHOT_LAI, e_col_Number.GHI_CHU_CHOT_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_THANH_TOAN, e_col_Number.NGAY_THANH_TOAN);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_LOAI_TRAI_CHU, e_col_Number.ID_LOAI_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.TEN_TRAI_CHU, e_col_Number.TEN_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_NGUOI_DUYET_CHOT_LAI, e_col_Number.ID_NGUOI_DUYET_CHOT_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_TRAI_CHU, e_col_Number.ID_TRAI_CHU);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.ID_NGUOI_LAP_CHOT_LAI, e_col_Number.ID_NGUOI_LAP_CHOT_LAI);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MO_TAI_NGAN_HANG, e_col_Number.MO_TAI_NGAN_HANG);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.NGAY_CAP_CMT, e_col_Number.NGAY_CAP_CMT);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MOBILE, e_col_Number.MOBILE);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.CMT_GIAY_DKKD, e_col_Number.CMT_GIAY_DKKD);
            v_htb.Add(V_DM_TRAI_CHU_CHOT_LAI.MA_TRAI_CHU, e_col_Number.MA_TRAI_CHU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_TRAI_CHU_CHOT_LAI.NewRow());
            return v_obj_trans;
        }

        private void load_data_2_grid(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
            if (m_us_v_trai_phieu != null)
            {
                switch (m_mod)
                {
                    case e_Mod.TAT_CA:
                        m_us.FillDatasetByIDTraiPhieu(m_ds, m_us_v_trai_phieu.dcID);
                        break;
                    case e_Mod.DA_TRA:
                        m_us.FillDatasetByIDTraiPhieuYes(m_ds, m_us_v_trai_phieu.dcID);
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
            load_data_2_cbo();
            m_fg.Redraw = true;

            //Load ma trai phieu so huu
            DS_DM_TRAI_PHIEU v_ds_trai_phieu = new DS_DM_TRAI_PHIEU();
            US_DM_TRAI_PHIEU v_us_trai_phieu = new US_DM_TRAI_PHIEU();
            v_us_trai_phieu.FillDataset(v_ds_trai_phieu);
            Hashtable v_hst_trai_phieu = new Hashtable();
            foreach (DataRow v_dr in v_ds_trai_phieu.DM_TRAI_PHIEU.Rows)
            {
                v_hst_trai_phieu.Add(v_dr[DM_TRAI_PHIEU.ID], v_dr[DM_TRAI_PHIEU.MA_TRAI_PHIEU]);
            }
            m_fg.Cols[(int)e_col_Number.ID_TRAI_PHIEU_SO_HUU].DataMap = v_hst_trai_phieu;

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

            //Load nguoi su dung
            US_HT_NGUOI_SU_DUNG v_us_nguoi_dung = new US_HT_NGUOI_SU_DUNG();
            DS_HT_NGUOI_SU_DUNG v_ds_nguoi_dung = new DS_HT_NGUOI_SU_DUNG();
            v_us_nguoi_dung.FillDataset(v_ds_nguoi_dung);
            Hashtable v_hst_nguoi_dung = new Hashtable();
            foreach (DataRow v_dr in v_ds_nguoi_dung.HT_NGUOI_SU_DUNG.Rows)
            {
                v_hst_nguoi_dung.Add(v_dr[HT_NGUOI_SU_DUNG.ID], v_dr[HT_NGUOI_SU_DUNG.TEN]);
            }
            m_fg.Cols[(int)e_col_Number.ID_NGUOI_LAP_CHOT_LAI].DataMap = v_hst_nguoi_dung;
            m_fg.Cols[(int)e_col_Number.ID_NGUOI_DUYET_CHOT_LAI].DataMap = v_hst_nguoi_dung;
        }

        private void grid2us_object(US_V_DM_TRAI_CHU_CHOT_LAI i_us, int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }

        private void us_object2grid(US_V_DM_TRAI_CHU_CHOT_LAI i_us, int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void tra_lai_v_dm_trai_chu_chot_lai()
        {
            //Kiểm tra xem có dữ liệu hay chưa
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_us_v_trai_phieu == null) return;
            grid2us_object(m_us, m_fg.Row);

            //Kiểm tra xem trái chủ này đã thanh toán chưa
            if (m_us.strDA_NHAN_TIEN_YN == "Y")
            {
                BaseMessages.MsgBox_Infor("Trái chủ này đã thanh toán!");
                return;
            }

            //Thực hiện thanh toán
            if (BaseMessages.MsgBox_Confirm(" Khách hàng: " + m_us.strTEN_TRAI_CHU + "                Số tiền thanh toán: " + CIPConvert.ToStr(m_us.dcSO_TIEN_LAI, "#,###").ToString() + " VNĐ"))
            {
                m_us.strDA_NHAN_TIEN_YN = "Y";
                m_us.datNGAY_NHAN_TIEN = DateTime.Now;

                m_us_gd_chot_lai_detail = new US_GD_CHOT_LAI_DETAIL();
                m_us_gd_chot_lai_detail.dcID = m_us.dcID;
                m_us_gd_chot_lai_detail.dcID_CHOT_LAI = m_us.dcID_CHOT_LAI;
                m_us_gd_chot_lai_detail.dcID_TRAI_CHU = m_us.dcID_TRAI_CHU;
                m_us_gd_chot_lai_detail.dcSO_LUONG_TINH_LAI = m_us.dcSO_LUONG_TINH_LAI;
                m_us_gd_chot_lai_detail.dcSO_TIEN_LAI = m_us.dcSO_TIEN_LAI;
                m_us_gd_chot_lai_detail.datNGAY_NHAN_TIEN = m_us.datNGAY_NHAN_TIEN;
                m_us_gd_chot_lai_detail.strDA_NHAN_TIEN_YN = m_us.strDA_NHAN_TIEN_YN;

                m_us_gd_chot_lai_detail.Update();
                load_data_2_grid(m_us_v_trai_phieu);
            }
        }

        private void hoan_tac_v_dm_trai_chu_chot_lai()
        {
            //Kiểm tra xem có dữ liệu hay chưa
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_us_v_trai_phieu == null) return;
            grid2us_object(m_us, m_fg.Row);

            if (m_us.strDA_NHAN_TIEN_YN == "N")
            {
                BaseMessages.MsgBox_Infor("Trái chủ này chưa thanh toán!");
                return;
            }
            
            if (BaseMessages.MsgBox_Confirm(" Khách hàng: " + m_us.strTEN_TRAI_CHU + "\n Xác nhận hủy bỏ thanh toán!"))
            {
                m_us.strDA_NHAN_TIEN_YN = "N";
                m_us.datNGAY_NHAN_TIEN = (DateTime)SqlDateTime.Null;

                m_us_gd_chot_lai_detail = new US_GD_CHOT_LAI_DETAIL();
                m_us_gd_chot_lai_detail.dcID = m_us.dcID;
                m_us_gd_chot_lai_detail.dcID_CHOT_LAI = m_us.dcID_CHOT_LAI;
                m_us_gd_chot_lai_detail.dcID_TRAI_CHU = m_us.dcID_TRAI_CHU;
                m_us_gd_chot_lai_detail.dcSO_LUONG_TINH_LAI = m_us.dcSO_LUONG_TINH_LAI;
                m_us_gd_chot_lai_detail.dcSO_TIEN_LAI = m_us.dcSO_TIEN_LAI;
                m_us_gd_chot_lai_detail.datNGAY_NHAN_TIEN = m_us.datNGAY_NHAN_TIEN;
                m_us_gd_chot_lai_detail.strDA_NHAN_TIEN_YN = m_us.strDA_NHAN_TIEN_YN;

                m_us_gd_chot_lai_detail.Update();
                load_data_2_grid(m_us_v_trai_phieu);
            }
        }

        private void view_v_dm_trai_chu_chot_lai()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
        }

        private void view_theo_trang_thai()
        {
            switch (m_cbo_trang_thai.SelectedIndex)
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

        private void load_data_2_cbo()
        {
            if (m_cbo_trang_thai.Items.Count == 0)
            {
                m_cbo_trang_thai.Items.Add("Tất cả");
                m_cbo_trang_thai.Items.Add("Đã thanh toán");
                m_cbo_trang_thai.Items.Add("Chưa thanh toán");

                m_cbo_trang_thai.SelectedIndex = 2;
            }
            if (m_us_v_trai_phieu != null)
            {
                decimal v_dc_so_ky_tra_lai;
                int v_i_current = 0;
                double v_d_ngay = 0;
                US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_v_trai_phieu.dcID_DOT_PHAT_HANH);
                m_cbo_ky_tinh_lai.Items.Clear();
                if(m_us_v_trai_phieu.dcID_DV_KY_TRA_LAI == 18)
                {
                    v_dc_so_ky_tra_lai = m_us_v_trai_phieu.dcKY_HAN / m_us_v_trai_phieu.dcKY_TRA_LAI * 12;
                    v_d_ngay = (DateTime.Now - v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH).TotalDays;
                }
                else
                {
                    v_dc_so_ky_tra_lai = m_us_v_trai_phieu.dcKY_HAN / m_us_v_trai_phieu.dcKY_TRA_LAI;
                }
                for (int i = 1; i <= v_dc_so_ky_tra_lai; i++)
                {
                    m_cbo_ky_tinh_lai.Items.Add(i);
                    DateTime v_dat = v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH;
                    v_dat = v_dat.AddMonths(i * (int)m_us_v_trai_phieu.dcKY_TRA_LAI);
                    if (v_d_ngay >= (v_dat - v_us_dm_dot_phat_hanh.datNGAY_PHAT_HANH).TotalDays)
                    {
                        v_i_current = i;
                    }
                }

                if (v_i_current != 0)
                {
                    m_cbo_ky_tinh_lai.SelectedIndex = v_i_current - 1;
                }
            }
        }

        private void us_trai_phieu_2_form(US_V_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;

            //US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(ip_us_trai_phieu.dcID_DOT_PHAT_HANH);
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH,"dd/MM/yyyy");

            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN, "dd/MM/yyyy");
            m_txt_menh_gia.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_lai_suat.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcLAI_SUAT_DEFAULT*100) + "%";
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_HAN);
            m_txt_ky_tinh_lai.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_TRA_LAI, "#,###");
        }

        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            return true;
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (m_us_v_trai_phieu.strMA_TRAI_PHIEU != "")
            {
                us_trai_phieu_2_form(m_us_v_trai_phieu);
                load_data_2_grid(m_us_v_trai_phieu);	
            }
        }

        private void filter()
        {
            if (m_txt_search.Text == "")
            {
                m_us_v_trai_phieu = null;
                load_data_2_grid(null);
            }
        }

        private void set_define_event()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_cmd_xac_nhan.Click += new EventHandler(m_cmd_xac_nhan_Click);
            m_cmd_filter.Click += new EventHandler(m_cmd_filter_Click);
            m_cmd_hoan_tac.Click += new EventHandler(m_cmd_hoan_tac_Click);
            m_cbo_trang_thai.SelectedIndexChanged += new EventHandler(m_cbo_trang_thai_SelectedIndexChanged);
        }

        #endregion

        #region Events

         private void f900_quan_ly_coupon_Load(object sender, EventArgs e)
         {
             try
             {
                 set_inital_form_load();
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

         void m_cmd_xac_nhan_Click(object sender, EventArgs e)
         {
             try
             {
                 tra_lai_v_dm_trai_chu_chot_lai();
             }
             catch (Exception v_e)
             {
                 CSystemLog_301.ExceptionHandle(v_e);
             }
         }

         void m_cmd_filter_Click(object sender, EventArgs e)
         {
             try
             {
                 filter();
             }
             catch (Exception v_e)
             {
                 CSystemLog_301.ExceptionHandle(v_e);
             }
         }

         void m_cmd_hoan_tac_Click(object sender, EventArgs e)
         {
             hoan_tac_v_dm_trai_chu_chot_lai();
         }

        #endregion

    }
}
