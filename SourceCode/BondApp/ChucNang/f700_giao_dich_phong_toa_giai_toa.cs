
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
    public partial class f700_giao_dich_phong_toa_giai_toa : Form
    {
        public f700_giao_dich_phong_toa_giai_toa()
        {
            InitializeComponent();

            format_controls();
        }

        #region Public Interface
        public void display_phong_toa()
        {
            m_e_form_mode = eFormMode.PHONG_TOA;
            this.ShowDialog();
        }
        public void display_giai_toa()
        {
            m_e_form_mode = eFormMode.GIAI_TOA;
            this.ShowDialog();
        }
        #endregion

        #region Data Structures
        private enum e_col_Number
        {
            ID = 1
                ,
            ID_TRAI_CHU = 2
                ,
            NGAY = 3
                ,
            TONG_SO_DU = 4
                ,
            SO_DU_KHA_DUNG = 5
        }
        public enum eFormMode
        {
            PHONG_TOA
                ,
            GIAI_TOA
        }
        #endregion

        #region Members
        US_DM_TRAI_CHU m_us_trai_chu = new US_DM_TRAI_CHU();
        US_DM_TRAI_PHIEU m_us_trai_phieu = new US_DM_TRAI_PHIEU();
        US_CM_DM_TU_DIEN m_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        US_CM_DM_LOAI_TD m_us_cm_dm_loai_tu_dien = new US_CM_DM_LOAI_TD();
        US_GD_PHONG_GIAI_TOA m_us_gd_phong_toa_giai_toa = new US_GD_PHONG_GIAI_TOA();
        DS_GD_PHONG_GIAI_TOA m_ds_gd_phong_toa_giai_toa = new DS_GD_PHONG_GIAI_TOA();
        eFormMode m_e_form_mode = eFormMode.PHONG_TOA;
        #endregion

        #region Private Methods

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
         
            set_define_events();
            this.KeyPreview = true;
            m_lbl_title.Font = new Font("Arial", 16);
            m_lbl_title.ForeColor = Color.DarkRed;
            m_lbl_title.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void set_inital_form_load()
        {
           
            switch (m_e_form_mode)
            {
                case eFormMode.GIAI_TOA:
                 
                    break;
                case eFormMode.PHONG_TOA:
                   
                    break;
             
                default:
                    break;
            }
        }
        private void select_trai_chu()
        {
            f500_dm_trai_chu v_frm500 = new f500_dm_trai_chu();
            m_us_trai_chu =  v_frm500.select_trai_chu_of_trai_phieu(null);
            us_trai_chu_2_form(m_us_trai_chu);
        }

        private void us_trai_chu_2_form(US_DM_TRAI_CHU ip_us_trai_chu)
        {
            if (ip_us_trai_chu.IsIDNull()) return;  
            DS_GD_SO_DU_TRAI_PHIEU v_ds = new DS_GD_SO_DU_TRAI_PHIEU();
            US_GD_SO_DU_TRAI_PHIEU v_us = new US_GD_SO_DU_TRAI_PHIEU();
            v_us.select_us_gd_so_du_trai_phieu_byTraiChuID(ip_us_trai_chu.dcID, v_ds);
            m_us_trai_phieu = new US_DM_TRAI_PHIEU(ip_us_trai_chu.dcID_TRAI_PHIEU_SO_HUU);

            m_txt_ma_trai_chu.Text = ip_us_trai_chu.dcID.ToString();
            m_txt_ten_khach_hang.Text = ip_us_trai_chu.strTEN_TRAI_CHU;
            m_txt_so_cmnd_dkkd.Text = ip_us_trai_chu.strCMT_GIAY_DKKD;
            m_txt_noi_cap.Text = ip_us_trai_chu.strNOI_CAP_CMT;
            m_txt_ngay_cap.Text = ip_us_trai_chu.datNGAY_CAP_CMT.ToString("dd/MM/yyyy");
            m_txt_so_luong_trai_phieu.Text = v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["TONG_SO_DU"].ToString();
            m_txt_so_luong_kha_dung.Text = v_ds.GD_SO_DU_TRAI_PHIEU.Rows[0]["SO_DU_KHA_DUNG"].ToString();
            
            us_trai_phieu_2_form(m_us_trai_phieu);            
        }

        private void us_trai_phieu_2_form(US_DM_TRAI_PHIEU ip_us_trai_phieu)
        {
            m_txt_ma_so_trai_phieu.Text = ip_us_trai_phieu.strMA_TRAI_PHIEU;
            m_txt_to_chuc_phat_hanh.Text = ip_us_trai_phieu.strTEN_TRAI_PHIEU;
            m_txt_tong_so_trai_phieu.Text = ip_us_trai_phieu.dcTONG_SL_PHAT_HANH.ToString();
            m_txt_tong_gia_tri.Text = ip_us_trai_phieu.dcTONG_GIA_TRI.ToString();
            m_txt_ngay_phat_hanh.Text = ip_us_trai_phieu.datNGAY_PHAT_HANH.ToString("dd/MM/yyyy");
            m_txt_ngay_dao_han.Text = ip_us_trai_phieu.datNGAY_DAO_HAN.ToString("dd/MM/yyyy");
            m_txt_lai_suat.Text = ip_us_trai_phieu.dcLAI_SUAT_DEFAULT.ToString() + "%";
            if (ip_us_trai_phieu.strTRA_LAI_SAU_YN != null)
                switch (ip_us_trai_phieu.strTRA_LAI_SAU_YN)
                {
                    case "Y":
                        m_txt_hinh_thuc_tra_lai.Text = "Trả lãi sau";
                        break;
                    case "N":
                        m_txt_hinh_thuc_tra_lai.Text = "Trả theo kỳ";
                        break;
                }            
        }

        private void from_2_us_gd_phong_toa_giai_toa()
        {
            m_us_gd_phong_toa_giai_toa.strNGUOI_DAI_DIEN = m_txt_nguoi_dai_dien.Text;
            m_us_gd_phong_toa_giai_toa.strCHUC_DANH = m_txt_chuc_danh.Text;
        }

        private void lap_giao_dich_phong_toa_giai_toa()
        {
            //MessageBox.Show("Giao dich phong toa giai toa dang duoc code hehe");
        }

        #endregion

        private void set_define_events()
        {
            m_cmd_chon_trai_chu.Click += new EventHandler(m_cmd_chon_trai_chu_Click);
            m_cmd_lap.Click += new EventHandler(m_cmd_lap_Click);
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
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
        
        void m_cmd_lap_Click(object sender, EventArgs e)
        {
            try
            {
                lap_giao_dich_phong_toa_giai_toa();
                MessageBox.Show("Cập nhập thành công!");
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

        private void f700_giao_dich_phong_toa_giai_toa_Load(object sender, EventArgs e)
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
    }
}

