///************************************************
/// Generated by: NinhVH
/// Date: 10/10/2012 11:16:37
/// Goal: Create User Service Class for V_DM_DOT_PHAT_HANH
///************************************************
/// <summary>
/// Create User Service Class for V_DM_DOT_PHAT_HANH
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BondDS;


namespace BondUS
{

    public class US_V_DM_DOT_PHAT_HANH : US_Object
    {
        private const string c_TableName = "V_DM_DOT_PHAT_HANH";
        #region "Public Properties"
        public decimal dcID
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID"] = value;
            }
        }

        public bool IsIDNull()
        {
            return pm_objDR.IsNull("ID");
        }

        public void SetIDNull()
        {
            pm_objDR["ID"] = System.Convert.DBNull;
        }

        public decimal dcID_TO_CHUC_PHAT_HANH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TO_CHUC_PHAT_HANH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TO_CHUC_PHAT_HANH"] = value;
            }
        }

        public bool IsID_TO_CHUC_PHAT_HANHNull()
        {
            return pm_objDR.IsNull("ID_TO_CHUC_PHAT_HANH");
        }

        public void SetID_TO_CHUC_PHAT_HANHNull()
        {
            pm_objDR["ID_TO_CHUC_PHAT_HANH"] = System.Convert.DBNull;
        }

        public string strTEN_TO_CHUC_PHAT_HANH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_TO_CHUC_PHAT_HANH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_TO_CHUC_PHAT_HANH"] = value;
            }
        }

        public bool IsTEN_TO_CHUC_PHAT_HANHNull()
        {
            return pm_objDR.IsNull("TEN_TO_CHUC_PHAT_HANH");
        }

        public void SetTEN_TO_CHUC_PHAT_HANHNull()
        {
            pm_objDR["TEN_TO_CHUC_PHAT_HANH"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_PHAT_HANH
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_PHAT_HANH", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_PHAT_HANH"] = value;
            }
        }

        public bool IsNGAY_PHAT_HANHNull()
        {
            return pm_objDR.IsNull("NGAY_PHAT_HANH");
        }

        public void SetNGAY_PHAT_HANHNull()
        {
            pm_objDR["NGAY_PHAT_HANH"] = System.Convert.DBNull;
        }

        public string strGHI_CHU
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["GHI_CHU"] = value;
            }
        }

        public bool IsGHI_CHUNull()
        {
            return pm_objDR.IsNull("GHI_CHU");
        }

        public void SetGHI_CHUNull()
        {
            pm_objDR["GHI_CHU"] = System.Convert.DBNull;
        }

        public decimal dcMENH_GIA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "MENH_GIA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["MENH_GIA"] = value;
            }
        }

        public bool IsMENH_GIANull()
        {
            return pm_objDR.IsNull("MENH_GIA");
        }

        public void SetMENH_GIANull()
        {
            pm_objDR["MENH_GIA"] = System.Convert.DBNull;
        }

        public decimal dcKY_TRA_LAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "KY_TRA_LAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["KY_TRA_LAI"] = value;
            }
        }

        public bool IsKY_TRA_LAINull()
        {
            return pm_objDR.IsNull("KY_TRA_LAI");
        }

        public void SetKY_TRA_LAINull()
        {
            pm_objDR["KY_TRA_LAI"] = System.Convert.DBNull;
        }

        public decimal dcID_DV_KY_TRA_LAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_DV_KY_TRA_LAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_DV_KY_TRA_LAI"] = value;
            }
        }

        public bool IsID_DV_KY_TRA_LAINull()
        {
            return pm_objDR.IsNull("ID_DV_KY_TRA_LAI");
        }

        public void SetID_DV_KY_TRA_LAINull()
        {
            pm_objDR["ID_DV_KY_TRA_LAI"] = System.Convert.DBNull;
        }

        public decimal dcTONG_SO_LUONG_TRAI_PHIEU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_LUONG_TRAI_PHIEU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_SO_LUONG_TRAI_PHIEU"] = value;
            }
        }

        public bool IsTONG_SO_LUONG_TRAI_PHIEUNull()
        {
            return pm_objDR.IsNull("TONG_SO_LUONG_TRAI_PHIEU");
        }

        public void SetTONG_SO_LUONG_TRAI_PHIEUNull()
        {
            pm_objDR["TONG_SO_LUONG_TRAI_PHIEU"] = System.Convert.DBNull;
        }

        public decimal dcTONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH"] = value;
            }
        }

        public bool IsTONG_GIA_TRI_TRAI_PHIEU_PHAT_HANHNull()
        {
            return pm_objDR.IsNull("TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH");
        }

        public void SetTONG_GIA_TRI_TRAI_PHIEU_PHAT_HANHNull()
        {
            pm_objDR["TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH"] = System.Convert.DBNull;
        }

        public decimal dcID_NGAN_HANG_DAI_LY_QUAN_LY_TK
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGAN_HANG_DAI_LY_QUAN_LY_TK", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGAN_HANG_DAI_LY_QUAN_LY_TK"] = value;
            }
        }

        public bool IsID_NGAN_HANG_DAI_LY_QUAN_LY_TKNull()
        {
            return pm_objDR.IsNull("ID_NGAN_HANG_DAI_LY_QUAN_LY_TK");
        }

        public void SetID_NGAN_HANG_DAI_LY_QUAN_LY_TKNull()
        {
            pm_objDR["ID_NGAN_HANG_DAI_LY_QUAN_LY_TK"] = System.Convert.DBNull;
        }

        public string strNGAN_HANG_DAI_LY_QUAN_LY_TK
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGAN_HANG_DAI_LY_QUAN_LY_TK", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGAN_HANG_DAI_LY_QUAN_LY_TK"] = value;
            }
        }

        public bool IsNGAN_HANG_DAI_LY_QUAN_LY_TKNull()
        {
            return pm_objDR.IsNull("NGAN_HANG_DAI_LY_QUAN_LY_TK");
        }

        public void SetNGAN_HANG_DAI_LY_QUAN_LY_TKNull()
        {
            pm_objDR["NGAN_HANG_DAI_LY_QUAN_LY_TK"] = System.Convert.DBNull;
        }

        public decimal dcTY_LE_PHI_CHUYEN_NHUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TY_LE_PHI_CHUYEN_NHUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TY_LE_PHI_CHUYEN_NHUONG"] = value;
            }
        }

        public bool IsTY_LE_PHI_CHUYEN_NHUONGNull()
        {
            return pm_objDR.IsNull("TY_LE_PHI_CHUYEN_NHUONG");
        }

        public void SetTY_LE_PHI_CHUYEN_NHUONGNull()
        {
            pm_objDR["TY_LE_PHI_CHUYEN_NHUONG"] = System.Convert.DBNull;
        }

        public decimal dcTY_LE_PHI_PHONG_GIAI_TOA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TY_LE_PHI_PHONG_GIAI_TOA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TY_LE_PHI_PHONG_GIAI_TOA"] = value;
            }
        }

        public bool IsTY_LE_PHI_PHONG_GIAI_TOANull()
        {
            return pm_objDR.IsNull("TY_LE_PHI_PHONG_GIAI_TOA");
        }

        public void SetTY_LE_PHI_PHONG_GIAI_TOANull()
        {
            pm_objDR["TY_LE_PHI_PHONG_GIAI_TOA"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_LAP
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_LAP"] = value;
            }
        }

        public bool IsID_NGUOI_LAPNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_LAP");
        }

        public void SetID_NGUOI_LAPNull()
        {
            pm_objDR["ID_NGUOI_LAP"] = System.Convert.DBNull;
        }

        public string strNGUOI_LAP
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_LAP", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_LAP"] = value;
            }
        }

        public bool IsNGUOI_LAPNull()
        {
            return pm_objDR.IsNull("NGUOI_LAP");
        }

        public void SetNGUOI_LAPNull()
        {
            pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
        }

        public decimal dcID_NGUOI_DUYET
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_DUYET", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NGUOI_DUYET"] = value;
            }
        }

        public bool IsID_NGUOI_DUYETNull()
        {
            return pm_objDR.IsNull("ID_NGUOI_DUYET");
        }

        public void SetID_NGUOI_DUYETNull()
        {
            pm_objDR["ID_NGUOI_DUYET"] = System.Convert.DBNull;
        }

        public string strNGUOI_DUYET
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGUOI_DUYET", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGUOI_DUYET"] = value;
            }
        }

        public bool IsNGUOI_DUYETNull()
        {
            return pm_objDR.IsNull("NGUOI_DUYET");
        }

        public void SetNGUOI_DUYETNull()
        {
            pm_objDR["NGUOI_DUYET"] = System.Convert.DBNull;
        }

        public string strNGAY_LAM_VIEC_HAI_SAU_YN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NGAY_LAM_VIEC_HAI_SAU_YN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NGAY_LAM_VIEC_HAI_SAU_YN"] = value;
            }
        }

        public bool IsNGAY_LAM_VIEC_HAI_SAU_YNNull()
        {
            return pm_objDR.IsNull("NGAY_LAM_VIEC_HAI_SAU_YN");
        }

        public void SetNGAY_LAM_VIEC_HAI_SAU_YNNull()
        {
            pm_objDR["NGAY_LAM_VIEC_HAI_SAU_YN"] = System.Convert.DBNull;
        }

        public decimal dcID_TRANG_THAI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI"] = value;
            }
        }

        public bool IsID_TRANG_THAINull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI");
        }

        public void SetID_TRANG_THAINull()
        {
            pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
        }

        public string strTRANG_THAI
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TRANG_THAI"] = value;
            }
        }

        public bool IsTRANG_THAINull()
        {
            return pm_objDR.IsNull("TRANG_THAI");
        }

        public void SetTRANG_THAINull()
        {
            pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
        }

        #endregion


        #region Init Functions
        public US_V_DM_DOT_PHAT_HANH()
        {
            pm_objDS = new DS_V_DM_DOT_PHAT_HANH();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_V_DM_DOT_PHAT_HANH(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_V_DM_DOT_PHAT_HANH(decimal i_dbID)
        {
            pm_objDS = new DS_V_DM_DOT_PHAT_HANH();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        #region Additional Functions
        public void load_data_by_search(DS_V_DM_DOT_PHAT_HANH op_ds_v_dm_dot_phat_hanh
                                       , string ip_str_keyword)
        {
            CStoredProc v_cstore = new CStoredProc("pr_DM_DOT_PHAT_HANH_Fill_By_Search");
            v_cstore.addNVarcharInputParam("@KEYWORD", ip_str_keyword);
            v_cstore.fillDataSetByCommand(this, op_ds_v_dm_dot_phat_hanh);
        }
        #endregion
    }
}