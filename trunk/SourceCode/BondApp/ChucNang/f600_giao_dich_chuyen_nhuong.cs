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
using BondUS;
using BondDS;
using BondDS.CDBNames;

using C1.Win.C1FlexGrid;
using System.Data.SqlClient;

namespace BondApp
{
    public partial class f600_giao_dich_chuyen_nhuong : Form
    {
        public f600_giao_dich_chuyen_nhuong()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Intrface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structures

        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
            this.KeyPreview = true;
        }

        private void select_trai_phieu()
        {
            f300_dm_trai_phieu v_frm300 = new f300_dm_trai_phieu();
            m_us_trai_phieu = v_frm300.select_trai_phieu();
            us_trai_phieu_2_form(m_us_trai_phieu);
        }

        private void us_trai_phieu_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_ten_trai_phieu.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_menh_gia.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcMENH_GIA, "#,###");
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_DIEU_CHINH_LS, "#,###");
            m_txt_ngay_phat_hanh.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_PHAT_HANH);
            m_txt_ngay_dao_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.datNGAY_DAO_HAN);
            m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN(ip_us_trai_phieu.dcID_DV_KY_HAN);
            m_txt_ky_han.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcKY_HAN) + " " + CIPConvert.ToStr(m_us_cm_dm_tu_dien.strTEN);
            m_txt_lai_suat.Text = CIPConvert.ToStr(ip_us_trai_phieu.dcLAI_SUAT_DEFAULT, "p");
        }

        private void select_trai_chu()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            m_us_trai_chu = v_frm500.select_trai_chu();
            us_trai_chu_2_form(m_us_trai_chu);
        }

        private void us_trai_chu_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            if (ip_us_trai_chu.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds_so_du_trai_phieu = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
            v_us_so_du_trai_phieu.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu.dcID, v_ds_so_du_trai_phieu);
                       
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_txt_ngay_cap.Text = ip_us_trai_chu.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            m_txt_so_luong_trai_phieu.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.TONG_SO_DU].ToString();
            m_txt_so_luong_kha_dung.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.SO_DU_KHA_DUNG].ToString();
            m_txt_so_dt.Text = ip_us_trai_chu.strMOBILE;
            m_txt_so_fax.Text = ip_us_trai_chu.strFAX;
            m_txt_dia_chi.Text = ip_us_trai_chu.strDIA_CHI;            
            //us_trai_phieu_2_form(m_us_trai_phieu);
        }
        private void select_trai_chu_mua()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            m_us_trai_chu = v_frm500.select_trai_chu();
            us_trai_mua_chu_2_form(m_us_trai_chu);
        }

        private void us_trai_mua_chu_2_form(US_DM_TRAI_CHU ip_us_trai_chu_mua)
        {
            if (ip_us_trai_chu_mua.IsIDNull()) return;
            DS_GD_SO_DU_TRAI_PHIEU v_ds_so_du_trai_phieu = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us_so_du_trai_phieu = new US_GD_SO_DU_TRAI_PHIEU();
            v_us_so_du_trai_phieu.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu_mua.dcID, v_ds_so_du_trai_phieu);

            m_txt_ben_mua_ten.Text = ip_us_trai_chu_mua.strTEN_TRAI_CHU;
            m_txt_ben_mua_cmnd.Text = ip_us_trai_chu_mua.strCMT_GIAY_DKKD;
            m_txt_ben_mua_noi_cap_cmnd.Text = ip_us_trai_chu_mua.strNOI_CAP_CMT;
            m_txt_ben_mua_ngay_cap_cmnd.Text = ip_us_trai_chu_mua.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            m_txt_ben_mua_so_luong_trai_phieu.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.TONG_SO_DU].ToString();
            m_txt_ben_mua_so_kha_dung.Text = v_ds_so_du_trai_phieu.GD_SO_DU_TRAI_PHIEU.Rows[0][GD_SO_DU_TRAI_PHIEU.SO_DU_KHA_DUNG].ToString();
            m_txt_ben_mua_sdt.Text = ip_us_trai_chu_mua.strMOBILE;
            m_txt_ben_mua_so_fax.Text = ip_us_trai_chu_mua.strFAX;
            m_txt_ben_mua_dia_chi.Text = ip_us_trai_chu_mua.strDIA_CHI;
            //us_trai_phieu_2_form(m_us_trai_phieu);
        }
        #endregion

        #region Events
        private void set_define_events()
        {
            m_cmd_chon_trai_phieu.Click += new EventHandler(m_cmd_chon_trai_phieu_Click);
            m_txt_phan_tram_thue.LostFocus += new EventHandler(m_txt_phan_tram_thue_LostFocus);
            m_txt_ty_le_phi_gd.LostFocus += new EventHandler(m_txt_ty_le_phi_gd_LostFocus);
            m_cmd_chon_ben_mua.Click += new EventHandler(m_cmd_chon_ben_mua_Click);
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
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

        void m_txt_phan_tram_thue_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (!m_txt_phan_tram_thue.Text.Equals("") && !m_txt_so_luong_chuyen_nhuong.Text.Equals(""))
                {
                    double v_phan_tram_thue = double.Parse(m_txt_ty_le_phi_gd.Text)/100;
                    double v_so_luong_CN = double.Parse(m_txt_so_luong_chuyen_nhuong.Text);
                    m_txt_thue.Text = CIPConvert.ToStr(v_so_luong_CN * v_phan_tram_thue * double.Parse(CIPConvert.ToStr(m_us_trai_phieu.dcMENH_GIA)), "#,###");
                }
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_txt_ty_le_phi_gd_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (!m_txt_ty_le_phi_gd.Text.Equals("") && !m_txt_so_luong_chuyen_nhuong.Text.Equals(""))
                {
                    double v_ty_le_phi = double.Parse(m_txt_ty_le_phi_gd.Text)/100;
                    double v_so_luong_CN = double.Parse(m_txt_so_luong_chuyen_nhuong.Text);
                    m_txt_phi_gd.Text = CIPConvert.ToStr(v_so_luong_CN * v_ty_le_phi * double.Parse(CIPConvert.ToStr(m_us_trai_phieu.dcMENH_GIA)), "#,###");
                }
            }            
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_ben_mua_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_chu_mua();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_chon_trai_chu_Click(object sender, EventArgs e)
        {
            try
            {
                select_trai_chu();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion                        
    }
}
