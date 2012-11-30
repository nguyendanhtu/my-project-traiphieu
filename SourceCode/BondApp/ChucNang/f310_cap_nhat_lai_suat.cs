using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BondUS;
using BondDS;
using BondDS.CDBNames;
using IP.Core.IPData.DBNames;
using C1.Win.C1FlexGrid;
using System.Data.SqlClient;

using IP.Core.IPSystemAdmin;

namespace BondApp.ChucNang
{
    public partial class f310_cap_nhat_lai_suat : Form
    {
        public f310_cap_nhat_lai_suat()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Intrface
        public void display_sua_gd_cap_nhat_ls()
        {
            m_e_form_mode = eFormMode.CAP_NHAT_LAI_SUAT;
            this.ShowDialog();
        }
        public void display_sua_gd_cap_nhat_ls(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_cap_nhat_lai_suat)
        {
            m_e_form_mode = eFormMode.CAP_NHAT_LAI_SUAT;
            m_us_gd_cap_nhat_ls = ip_us_cap_nhat_lai_suat;
            us_gd_cap_nhat_ls_2_from();
            this.ShowDialog();
        }
        public void display_xem_gd_cap_nhat_ls(US_GD_LICH_THANH_TOAN_LAI_GOC ip_us_cap_nhat_lai_suat)
        {
            m_e_form_mode = eFormMode.XEM_GIAO_DICH;
            m_us_gd_cap_nhat_ls = ip_us_cap_nhat_lai_suat;
            us_gd_cap_nhat_ls_2_from();
            this.ShowDialog();
        }        
        #endregion

        #region Data Structures
        public enum eFormMode
        {            
            CAP_NHAT_LAI_SUAT,           
            XEM_GIAO_DICH,
            DUYET_LAI_SUAT
        }

        private enum e_col_Number
        {            
            STT = 1
                ,
            ID = 2,

            NGAY = 3
                ,            
            LAI_SUAT = 4
                ,
            NGAY_BAT_DAU_AD_LS = 5
                ,            
            DA_THUC_HIEN_YN = 6
                ,
            DA_DUYET_YN = 7
                , 
            GHI_CHU = 8
        }
        #endregion

        #region Members
        US_V_DM_TRAI_PHIEU m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU(); 
        US_GD_LICH_THANH_TOAN_LAI_GOC m_us_gd_cap_nhat_ls = new US_GD_LICH_THANH_TOAN_LAI_GOC();
        DS_GD_LICH_THANH_TOAN_LAI_GOC m_ds_gd_lich_tt_lai_goc = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
        US_GD_LICH_THANH_TOAN_LAI_GOC m_us_gd_lich_tt_lai_goc = new US_GD_LICH_THANH_TOAN_LAI_GOC();
        ITransferDataRow m_obj_trans;
        eFormMode m_e_form_mode = eFormMode.CAP_NHAT_LAI_SUAT;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);            
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            set_define_events();            
        }

        private void set_inital_form_load()
        {
            switch (m_e_form_mode)
            {                
                //case eFormMode.CAP_NHAT_LAI_SUAT:                   
                //    m_cmd_cap_nhat.Enabled = true;
                //    m_cmd_duyet_gd.Enabled = true;                                       
                //    break;                
                case eFormMode.XEM_GIAO_DICH:
                    m_cmd_duyet_gd.Enabled = false;
                    m_cmd_duyet_gd.Enabled = false;
                    m_gru_thong_tin_trai_phieu.Enabled = false;
                    m_gru_thong_tin_cap_nhat.Enabled = false;
                    break;                
                default:
                    break;
            }
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.ID, e_col_Number.ID);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.NGAY, e_col_Number.NGAY);            
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.LAI_SUAT, e_col_Number.LAI_SUAT);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.NGAY_BAT_DAU_AD_LS, e_col_Number.NGAY_BAT_DAU_AD_LS);                       
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.DA_THUC_HIEN_YN, e_col_Number.DA_THUC_HIEN_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.DA_DUYET_YN, e_col_Number.DA_DUYET_YN);
            v_htb.Add(GD_LICH_THANH_TOAN_LAI_GOC.GHI_CHU, e_col_Number.GHI_CHU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_gd_lich_tt_lai_goc.GD_LICH_THANH_TOAN_LAI_GOC.NewRow());
            return v_obj_trans;
        }
        private US_GD_LICH_THANH_TOAN_LAI_GOC grid2us_object( int i_grid_row)
        {
            DataRow v_dr;            
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;            
            decimal v_id = CIPConvert.ToDecimal(v_dr[0]);
            US_GD_LICH_THANH_TOAN_LAI_GOC v_us =  new US_GD_LICH_THANH_TOAN_LAI_GOC(v_id);
            return v_us;
        }
        private void load_data_2_grid()
        {
            m_ds_gd_lich_tt_lai_goc = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
            m_us_gd_lich_tt_lai_goc.FillDatasetLichSUuLaiSuatByIDTraiPhieu(m_ds_gd_lich_tt_lai_goc, m_us_v_trai_phieu.dcID);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_gd_lich_tt_lai_goc, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT((int)e_col_Number.STT, m_fg);
            m_fg.Redraw = true;
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();           
            m_us_v_trai_phieu = v_frm300.select_trai_phieu();
            if (!m_us_v_trai_phieu.IsIDNull())
                us_trai_phieu_2_form();
        }
        private void us_trai_phieu_2_form()
        {
            if (m_us_v_trai_phieu != null)
            {
                US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
                //US_DM_DOT_PHAT_HANH v_us_dm_dot_phat_hanh = new US_DM_DOT_PHAT_HANH(m_us_v_trai_phieu.dcID_DOT_PHAT_HANH);
                m_txt_ma_trai_phieu.Text = m_us_v_trai_phieu.strMA_TRAI_PHIEU;
                m_txt_ten_trai_phieu.Text = m_us_v_trai_phieu.strTEN_TRAI_PHIEU;
                m_txt_menh_gia.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcMENH_GIA, "#,###");
                m_txt_ky_han.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_DIEU_CHINH_LS, "#,###");
                m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(m_us_v_trai_phieu.datNGAY_PHAT_HANH,"dd/MM/yyyy");
                m_txt_ngay_dao_han.Text = CIPConvert.ToStr(m_us_v_trai_phieu.datNGAY_DAO_HAN, "dd/MM/yyyy");
                try
                {
                    v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN(m_us_v_trai_phieu.dcID_DV_KY_HAN);
                }
                catch (Exception v_e)
                {
                    MessageBox.Show("Trái phiếu " + m_us_v_trai_phieu.strTEN_TRAI_PHIEU + " không có đơn vị kỳ hạn");
                    throw v_e;
                }


                m_txt_ky_han.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcKY_HAN) + " " + CIPConvert.ToStr(v_us_cm_dm_tu_dien.strTEN);
                m_txt_lai_suat.Text = CIPConvert.ToStr(m_us_v_trai_phieu.dcLAI_SUAT_DEFAULT, "p");
            }
        }

        private void form_2_us_gd_cap_nhat_ls()
        {            
            m_us_gd_cap_nhat_ls.dcID_TRAI_PHIEU = m_us_v_trai_phieu.dcID;
            m_us_gd_cap_nhat_ls.datNGAY = m_date_ngay_cap_nhat.Value;
            m_us_gd_cap_nhat_ls.datNGAY_BAT_DAU_AD_LS = m_date_ngay_ap_dung_ls.Value;
            m_us_gd_cap_nhat_ls.dcLAI_SUAT = CIPConvert.ToDecimal(m_txt_lai_suat_moi.Text)/100;
            m_us_gd_cap_nhat_ls.strCAP_NHAT_LS_YN = "Y";
            m_us_gd_cap_nhat_ls.strGHI_CHU = m_txt_ghi_chu.Text;            
            m_us_gd_cap_nhat_ls.strDA_THUC_HIEN_YN = "Y";
            m_us_gd_cap_nhat_ls.strCHOT_LAI_YN = "N";
            m_us_gd_cap_nhat_ls.strTHANH_TOAN_GOC_YN = "N";
            m_us_gd_cap_nhat_ls.strTHANH_TOAN_LAI_YN = "N";
            m_us_gd_cap_nhat_ls.SetNGAY_KET_THUC_AD_LSNull();
            m_us_gd_cap_nhat_ls.strLAI_SUAT_THOA_THUAN_YN = "N";
            if (m_e_form_mode == eFormMode.CAP_NHAT_LAI_SUAT)
            {
                m_us_gd_cap_nhat_ls.strDA_DUYET_YN = "N";
                m_us_gd_cap_nhat_ls.dcID_NGUOI_LAP = CAppContext_201.getCurrentUserID();
                m_us_gd_cap_nhat_ls.SetNGAY_DUYETNull();
                m_us_gd_cap_nhat_ls.SetID_NGUOI_DUYETNull();                
            }
            if (m_e_form_mode == eFormMode.DUYET_LAI_SUAT)
            {
                m_us_gd_cap_nhat_ls.strDA_DUYET_YN = "Y";
                m_us_gd_cap_nhat_ls.dcID_NGUOI_DUYET = CAppContext_201.getCurrentUserID();
                m_us_gd_cap_nhat_ls.datNGAY_DUYET = m_date_ngay_duyet.Value;
            }

        }

        private void us_gd_cap_nhat_ls_2_from()
        {
            if (m_us_gd_cap_nhat_ls != null)
            {
                m_us_v_trai_phieu = new US_V_DM_TRAI_PHIEU(m_us_gd_cap_nhat_ls.dcID_TRAI_PHIEU);
                us_trai_phieu_2_form();                
                m_date_ngay_ap_dung_ls.Value = m_us_gd_cap_nhat_ls.datNGAY_BAT_DAU_AD_LS;
                m_txt_lai_suat_moi.Text = CIPConvert.ToStr(m_us_gd_cap_nhat_ls.dcLAI_SUAT * 100, "#,##0.00");
                m_date_ngay_ap_dung_ls.Value = m_us_gd_cap_nhat_ls.datNGAY_BAT_DAU_AD_LS;
                m_date_ngay_cap_nhat.Value = m_us_gd_cap_nhat_ls.datNGAY;
                if (!m_us_gd_cap_nhat_ls.IsNGAY_DUYETNull())
                    m_date_ngay_duyet.Value = m_us_gd_cap_nhat_ls.datNGAY_DUYET;
                if (!m_us_gd_cap_nhat_ls.IsID_NGUOI_DUYETNull())
                {
                    US_HT_NGUOI_SU_DUNG v_nguoi_duyet = new US_HT_NGUOI_SU_DUNG(m_us_gd_cap_nhat_ls.dcID_NGUOI_DUYET);
                    m_txt_nguoi_duyet.Text = v_nguoi_duyet.strTEN;
                }
                if (!m_us_gd_cap_nhat_ls.IsID_NGUOI_LAPNull())
                {
                    US_HT_NGUOI_SU_DUNG v_nguoi_lap = new US_HT_NGUOI_SU_DUNG(m_us_gd_cap_nhat_ls.dcID_NGUOI_LAP);
                    m_txt_nguoi_lap.Text = v_nguoi_lap.strTEN;
                }
                if (m_us_gd_cap_nhat_ls.strDA_DUYET_YN.Equals("Y"))
                    m_chb_xac_nhan.Checked = true;
                else
                    m_chb_xac_nhan.Checked = false;
                m_txt_ghi_chu.Text = m_us_gd_cap_nhat_ls.strGHI_CHU;
                //load_data_2_grid();
            }
        }

        private bool check_thong_tin_cap_nhat_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_trai_phieu, DataType.StringType, allowNull.NO, false)) return false;
            if (!CValidateTextBox.IsValid(m_txt_lai_suat_moi, DataType.NumberType, allowNull.NO, false)) return false;            
            return true;
        }

        private void an_hien_button_theo_chuc_nang(eFormMode ip_e_form_mode)
        {
            m_e_form_mode = ip_e_form_mode;
            m_cmd_chon_cap_nhat.Enabled = false;
            m_cmd_chon_duyet.Enabled = false;
            switch (ip_e_form_mode)
            {
                case eFormMode.CAP_NHAT_LAI_SUAT:
                    m_cmd_cap_nhat.Enabled = true;
                    m_cmd_duyet_gd.Enabled = false;
                    break;
                case eFormMode.XEM_GIAO_DICH:
                    m_cmd_cap_nhat.Enabled = false;
                    m_cmd_duyet_gd.Enabled = false;
                    break;
                case eFormMode.DUYET_LAI_SUAT:
                    m_cmd_cap_nhat.Enabled = false;
                    m_cmd_duyet_gd.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void cap_nhat_ls()
        {
            if (!check_thong_tin_cap_nhat_is_ok())
            {
                MessageBox.Show("Chưa nhập đủ thông tin cần thiết!");
                return;
            }
            if (m_chb_xac_nhan.Checked)
            {
                MessageBox.Show("Giao dịch đã được xác nhận bạn không được phép sửa!");
                return;
            }
            form_2_us_gd_cap_nhat_ls();            
            try
            {
                m_us_gd_cap_nhat_ls.BeginTransaction();
                m_us_gd_cap_nhat_ls.Update();                
                m_us_gd_cap_nhat_ls.CommitTransaction();
            }
            catch (Exception v_e)
            {
                if (m_us_gd_cap_nhat_ls.is_having_transaction())
                {
                    m_us_gd_cap_nhat_ls.Rollback();
                }
                throw v_e;
            }

            MessageBox.Show("Cập nhập thành công!");
            resetcontrl2();
        }

        private void duyet_gd_cap_nhat_ls()
        {
            if (!check_thong_tin_cap_nhat_is_ok())
            {
                MessageBox.Show("Chưa nhập đủ thông tin cần thiết!");
                return;
            }
            if (m_chb_xac_nhan.Checked)
            {
                MessageBox.Show("Giao dịch đã được duyệt từ trước!");
                return;
            }
            else
                m_chb_xac_nhan.Checked = true;
            form_2_us_gd_cap_nhat_ls();
            try
            {
                m_us_gd_cap_nhat_ls.BeginTransaction();
                m_us_gd_cap_nhat_ls.Update();                
                m_us_gd_cap_nhat_ls.CommitTransaction();
            }
            catch (Exception v_e)
            {
                if (m_us_gd_cap_nhat_ls.is_having_transaction())
                {
                    m_us_gd_cap_nhat_ls.Rollback();
                }
                throw v_e;
            }

            MessageBox.Show("Cập nhập thành công!");
            resetcontrl2();
        }

        private void view_v_gd_cap_nhat_ls()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            m_us_gd_cap_nhat_ls = grid2us_object( m_fg.Row);
            if (m_us_gd_cap_nhat_ls.strDA_THUC_HIEN_YN.Equals("N"))
                an_hien_button_theo_chuc_nang(eFormMode.CAP_NHAT_LAI_SUAT);                            
            else{
                if (m_us_gd_cap_nhat_ls.strDA_DUYET_YN.Equals("Y"))
                    an_hien_button_theo_chuc_nang(eFormMode.XEM_GIAO_DICH);
                else
                    an_hien_button_theo_chuc_nang(eFormMode.DUYET_LAI_SUAT);
            }            
            us_gd_cap_nhat_ls_2_from();            
        }

        private void lua_chon_cap_nhan_lai_suat()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            m_us_gd_cap_nhat_ls = grid2us_object(m_fg.Row);
            if (m_us_gd_cap_nhat_ls.strDA_DUYET_YN.Equals("Y"))
                MessageBox.Show("Đợt cập nhật lãi suất này đã được duyệt, bạn không được phép sửa");
            else
            {
                us_gd_cap_nhat_ls_2_from();
                m_date_ngay_cap_nhat.Value = DateTime.Today;
                an_hien_button_theo_chuc_nang(eFormMode.CAP_NHAT_LAI_SUAT);
            }
        }

        private void lua_chon_duyet_lai_suat()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            m_us_gd_cap_nhat_ls = grid2us_object(m_fg.Row);
            if (m_us_gd_cap_nhat_ls.strDA_THUC_HIEN_YN.Equals("N"))
                MessageBox.Show("Đợt cập nhật lãi suất này chưa được thực hiện, bạn không được phép duyệt");
            else
            {
                us_gd_cap_nhat_ls_2_from();
                m_date_ngay_duyet.Value = DateTime.Today;
                an_hien_button_theo_chuc_nang(eFormMode.DUYET_LAI_SUAT);
            }
        }

        private void cell_changed()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            m_us_gd_cap_nhat_ls = grid2us_object(m_fg.Row);
            if (m_us_gd_cap_nhat_ls.strDA_THUC_HIEN_YN.Equals("Y"))
                m_cmd_duyet_gd.Enabled = false;
            else
                m_cmd_duyet_gd.Enabled = true;
        }
        private void resetcontrl()
        {
            m_gru_thong_tin_trai_phieu.Enabled = true;
            m_us_v_trai_phieu = null;
            m_us_gd_cap_nhat_ls = null;
            m_txt_ghi_chu.Text = "";
            m_txt_menh_gia.Text = "";
            m_txt_ma_trai_phieu.Text = "";
            m_txt_ten_trai_phieu.Text = "";
            m_txt_ngay_dao_han.Text = "";
            m_txt_ngay_phat_hanh.Text = "";
            m_txt_ky_han.Text = "";
            m_txt_lai_suat.Text = ""; ;
            m_txt_lai_suat_moi.Text = "";
            m_txt_ghi_chu.Text = "";
            m_chb_xac_nhan.Checked = false;
            m_cmd_duyet_gd.Enabled = false; 
        }
        private void resetcontrl2()
        {
            m_gru_thong_tin_trai_phieu.Enabled = true;
            m_cmd_cap_nhat.Enabled = false;
            m_cmd_duyet_gd.Enabled = false;
            m_cmd_chon_cap_nhat.Enabled = true;
            m_cmd_chon_duyet.Enabled = true;
            m_txt_lai_suat_moi.Text = "";
            m_txt_ghi_chu.Text = "";
            m_txt_nguoi_lap.Text = "";
            m_txt_nguoi_duyet.Text = "";
            m_chb_xac_nhan.Checked = false;
            m_date_ngay_ap_dung_ls.Value = DateTime.Today;
            load_data_2_grid();
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            this.Load += new EventHandler(f310_cap_nhat_lai_suat_Load);
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_cap_nhat.Click += new EventHandler(m_cmd_sua_gd_Click);
            m_cmd_duyet_gd.Click += new EventHandler(m_cmd_duyet_gd_Click);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
            m_cmd_reset.Click += new EventHandler(m_cmd_reset_Click);
            m_cmd_chon_cap_nhat.Click += new EventHandler(m_cmd_chon_cap_nhat_Click);
            m_cmd_chon_duyet.Click += new EventHandler(m_cmd_chon_duyet_Click);
            this.KeyDown += new KeyEventHandler(f310_cap_nhat_lai_suat_KeyDown);
        }

        void f310_cap_nhat_lai_suat_KeyDown(object sender, KeyEventArgs e)
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

        void m_cmd_chon_duyet_Click(object sender, EventArgs e)
        {
            try
            {
                lua_chon_duyet_lai_suat();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_cap_nhat_Click(object sender, EventArgs e)
        {
            try
            {
                lua_chon_cap_nhan_lai_suat();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_reset_Click(object sender, EventArgs e)
        {
            try
            {
                resetcontrl2();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                view_v_gd_cap_nhat_ls();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_duyet_gd_Click(object sender, EventArgs e)
        {
            try
            {
                duyet_gd_cap_nhat_ls();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_sua_gd_Click(object sender, EventArgs e)
        {
            try
            {                
                cap_nhat_ls();
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
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void f310_cap_nhat_lai_suat_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
                m_obj_trans = get_trans_object(m_fg);                
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

    }
}
