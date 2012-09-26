﻿using System;
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

        public void display_tra_lai_trai_phieu(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_us_trai_phieu = ip_us_trai_phieu;
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
        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu;
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.InsertDataState;
        ITransferDataRow m_obj_trans;
        DS_V_DM_TRAI_CHU_CHOT_LAI m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
        US_V_DM_TRAI_CHU_CHOT_LAI m_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
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
            /*switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    us_object_2_form(m_us_trai_chu);
                    break;
            }*/
            if (m_us_trai_phieu != null)
                us_trai_phieu_2_form(m_us_trai_phieu);
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid(m_us_trai_phieu);	
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

        private void load_data_2_grid(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_ds = new DS_V_DM_TRAI_CHU_CHOT_LAI();
            if (ip_us_trai_phieu == null)
            {

                m_us.FillDataset(m_ds);
            }
            else
            {
                m_us.FillDatasetByIDTraiPhieu(m_ds, ip_us_trai_phieu.dcID);
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
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

        private void insert_v_dm_trai_chu_chot_lai()
        {
            //	f950_quan_ly_tra_coupon_DE v_fDE = new  f950_quan_ly_tra_coupon_DE();								
            //	v_fDE.display();
            load_data_2_grid(m_us_trai_phieu);
        }

        private void update_v_dm_trai_chu_chot_lai()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            m_us.strDA_NHAN_TIEN_YN = "Y";
            m_us.Update();
            BaseMessages.MsgBox_Infor("Đã xác nhận trả lãi!");
            load_data_2_grid(m_us_trai_phieu);
        }

        private void delete_v_dm_trai_chu_chot_lai()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_TRAI_CHU_CHOT_LAI v_us = new US_V_DM_TRAI_CHU_CHOT_LAI();
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

        private void view_v_dm_trai_chu_chot_lai()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f950_quan_ly_tra_coupon_DE v_fDE = new f950_quan_ly_tra_coupon_DE();			
            //	v_fDE.display(m_us);
        }

        private void load_data_2_cbo()
        {
            /*m_ds_cm_dm_tu_dien = m_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.TRANG_THAI_GD);
            m_cbo_trang_thai.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;

            m_ds_cm_dm_tu_dien = m_us_cm_dm_tu_dien.getLoaiTuDienDS(CM_DM_DS_LOAI_TU_DIEN.LOAI_TRAI_CHU);
            m_cbo_loai_trai_chu.DataSource = m_ds_cm_dm_tu_dien.Tables[0];
            m_cbo_loai_trai_chu.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
            m_cbo_loai_trai_chu.ValueMember = CM_DM_TU_DIEN.ID;*/
        }

        private void us_objects_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {

        }

        private void form_2_us_object(US_DM_TRAI_CHU ip_us_trai_chu)
        {

        }

        private void us_trai_phieu_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH);
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN);
            m_txt_menh_gia.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcMENH_GIA);
            m_txt_lai_suat.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcLAI_SUAT_DEFAULT*100) + "%";
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_HAN);
        }

        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO, true))
            {
                return false;
            }
            return true;
        }

        private void save_data()
        {
            /*if (check_data_is_ok() == false)
            {
                return;
            }
            form_2_us_object(m_us_trai_chu);
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_trai_chu.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_trai_chu.Update();
                    break;
            }

            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            this.Close();*/
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

         private void select_trai_chu()
        {

        }

         private void set_define_event()
         {
             m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
             m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
             m_cmd_xac_nhan.Click += new EventHandler(m_cmd_xac_nhan_Click);
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
                 update_v_dm_trai_chu_chot_lai();
             }
             catch (Exception v_e)
             {
                 CSystemLog_301.ExceptionHandle(v_e);
             }
         }

        #endregion

    }
}
