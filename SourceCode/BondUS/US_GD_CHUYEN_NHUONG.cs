///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:36:26
/// Goal: Create User Service Class for GD_CHUYEN_NHUONG
///************************************************
/// <summary>
/// Create User Service Class for GD_CHUYEN_NHUONG
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{
    public class US_GD_CHUYEN_NHUONG : US_Object
    {
        private const string c_TableName = "GD_CHUYEN_NHUONG";
        #region Public Properties
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

        public string strMA_GIAO_DICH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "MA_GIAO_DICH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["MA_GIAO_DICH"] = value;
            }
        }

        public bool IsMA_GIAO_DICHNull()
        {
            return pm_objDR.IsNull("MA_GIAO_DICH");
        }

        public void SetMA_GIAO_DICHNull()
        {
            pm_objDR["MA_GIAO_DICH"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_XAC_NHAN
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_XAC_NHAN", IPConstants.c_DefaultDate);
            }
            set
            {
                DateTime v_dt = value;
                pm_objDR["NGAY_XAC_NHAN"] = v_dt.Date;
            }
        }

        public bool IsNGAY_XAC_NHANNull()
        {
            return pm_objDR.IsNull("NGAY_XAC_NHAN");
        }

        public void SetNGAY_XAC_NHANNull()
        {
            pm_objDR["NGAY_XAC_NHAN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_KY_CHUYEN_NHUONG
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_KY_CHUYEN_NHUONG", IPConstants.c_DefaultDate);
            }
            set
            {
                DateTime v_dt = value;
                pm_objDR["NGAY_KY_CHUYEN_NHUONG"] = v_dt.Date;
            }
        }

        public bool IsNGAY_KY_CHUYEN_NHUONGNull()
        {
            return pm_objDR.IsNull("NGAY_KY_CHUYEN_NHUONG");
        }

        public void SetNGAY_KY_CHUYEN_NHUONGNull()
        {
            pm_objDR["NGAY_KY_CHUYEN_NHUONG"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_VAO_SO
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_VAO_SO", IPConstants.c_DefaultDate);
            }
            set
            {
                DateTime v_dt = value;
                pm_objDR["NGAY_VAO_SO"] = v_dt.Date;
            }
        }

        public bool IsNGAY_VAO_SONull()
        {
            return pm_objDR.IsNull("NGAY_VAO_SO");
        }

        public void SetNGAY_VAO_SONull()
        {
            pm_objDR["NGAY_VAO_SO"] = System.Convert.DBNull;
        }

        public decimal dcID_TRAI_CHU_MUA
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRAI_CHU_MUA", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRAI_CHU_MUA"] = value;
            }
        }

        public bool IsID_TRAI_CHU_MUANull()
        {
            return pm_objDR.IsNull("ID_TRAI_CHU_MUA");
        }

        public void SetID_TRAI_CHU_MUANull()
        {
            pm_objDR["ID_TRAI_CHU_MUA"] = System.Convert.DBNull;
        }

        public decimal dcID_TRAI_CHU_BAN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRAI_CHU_BAN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRAI_CHU_BAN"] = value;
            }
        }

        public bool IsID_TRAI_CHU_BANNull()
        {
            return pm_objDR.IsNull("ID_TRAI_CHU_BAN");
        }

        public void SetID_TRAI_CHU_BANNull()
        {
            pm_objDR["ID_TRAI_CHU_BAN"] = System.Convert.DBNull;
        }

        public string strTEN_NGUOI_UY_QUYEN_MUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_UY_QUYEN_MUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NGUOI_UY_QUYEN_MUA"] = value;
            }
        }

        public bool IsTEN_NGUOI_UY_QUYEN_MUANull()
        {
            return pm_objDR.IsNull("TEN_NGUOI_UY_QUYEN_MUA");
        }

        public void SetTEN_NGUOI_UY_QUYEN_MUANull()
        {
            pm_objDR["TEN_NGUOI_UY_QUYEN_MUA"] = System.Convert.DBNull;
        }

        public string strTEN_NGUOI_UY_QUYEN_BAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_UY_QUYEN_BAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["TEN_NGUOI_UY_QUYEN_BAN"] = value;
            }
        }

        public bool IsTEN_NGUOI_UY_QUYEN_BANNull()
        {
            return pm_objDR.IsNull("TEN_NGUOI_UY_QUYEN_BAN");
        }

        public void SetTEN_NGUOI_UY_QUYEN_BANNull()
        {
            pm_objDR["TEN_NGUOI_UY_QUYEN_BAN"] = System.Convert.DBNull;
        }

        public string strSO_CMT_NGUOI_MUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_CMT_NGUOI_MUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_CMT_NGUOI_MUA"] = value;
            }
        }

        public bool IsSO_CMT_NGUOI_MUANull()
        {
            return pm_objDR.IsNull("SO_CMT_NGUOI_MUA");
        }

        public void SetSO_CMT_NGUOI_MUANull()
        {
            pm_objDR["SO_CMT_NGUOI_MUA"] = System.Convert.DBNull;
        }

        public string strSO_CMT_NGUOI_BAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "SO_CMT_NGUOI_BAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["SO_CMT_NGUOI_BAN"] = value;
            }
        }

        public bool IsSO_CMT_NGUOI_BANNull()
        {
            return pm_objDR.IsNull("SO_CMT_NGUOI_BAN");
        }

        public void SetSO_CMT_NGUOI_BANNull()
        {
            pm_objDR["SO_CMT_NGUOI_BAN"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_CMT_NGUOI_MUA
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_CMT_NGUOI_MUA", IPConstants.c_DefaultDate);
            }
            set
            {
                DateTime v_dt = value;
                pm_objDR["NGAY_CAP_CMT_NGUOI_MUA"] = v_dt.Date;
            }
        }

        public bool IsNGAY_CAP_CMT_NGUOI_MUANull()
        {
            return pm_objDR.IsNull("NGAY_CAP_CMT_NGUOI_MUA");
        }

        public void SetNGAY_CAP_CMT_NGUOI_MUANull()
        {
            pm_objDR["NGAY_CAP_CMT_NGUOI_MUA"] = System.Convert.DBNull;
        }

        public DateTime datNGAY_CAP_CMT_NGUOI_BAN
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_CMT_NGUOI_BAN", IPConstants.c_DefaultDate);
            }
            set
            {
                DateTime v_dt = value;
                pm_objDR["NGAY_CAP_CMT_NGUOI_BAN"] = v_dt.Date;
            }
        }

        public bool IsNGAY_CAP_CMT_NGUOI_BANNull()
        {
            return pm_objDR.IsNull("NGAY_CAP_CMT_NGUOI_BAN");
        }

        public void SetNGAY_CAP_CMT_NGUOI_BANNull()
        {
            pm_objDR["NGAY_CAP_CMT_NGUOI_BAN"] = System.Convert.DBNull;
        }

        public string strNOI_CAP_CMT_NGUOI_MUA
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_CAP_CMT_NGUOI_MUA", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_CAP_CMT_NGUOI_MUA"] = value;
            }
        }

        public bool IsNOI_CAP_CMT_NGUOI_MUANull()
        {
            return pm_objDR.IsNull("NOI_CAP_CMT_NGUOI_MUA");
        }

        public void SetNOI_CAP_CMT_NGUOI_MUANull()
        {
            pm_objDR["NOI_CAP_CMT_NGUOI_MUA"] = System.Convert.DBNull;
        }

        public string strNOI_CAP_CMT_NGUOI_BAN
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_CAP_CMT_NGUOI_BAN", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_CAP_CMT_NGUOI_BAN"] = value;
            }
        }

        public bool IsNOI_CAP_CMT_NGUOI_BANNull()
        {
            return pm_objDR.IsNull("NOI_CAP_CMT_NGUOI_BAN");
        }

        public void SetNOI_CAP_CMT_NGUOI_BANNull()
        {
            pm_objDR["NOI_CAP_CMT_NGUOI_BAN"] = System.Convert.DBNull;
        }

        public decimal dcSO_LUONG_CHUYEN_NHUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_CHUYEN_NHUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_LUONG_CHUYEN_NHUONG"] = value;
            }
        }

        public bool IsSO_LUONG_CHUYEN_NHUONGNull()
        {
            return pm_objDR.IsNull("SO_LUONG_CHUYEN_NHUONG");
        }

        public void SetSO_LUONG_CHUYEN_NHUONGNull()
        {
            pm_objDR["SO_LUONG_CHUYEN_NHUONG"] = System.Convert.DBNull;
        }

        public decimal dcGIA_TRI_CHUYEN_NHUONG_THUC_TE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_CHUYEN_NHUONG_THUC_TE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_TRI_CHUYEN_NHUONG_THUC_TE"] = value;
            }
        }

        public bool IsGIA_TRI_CHUYEN_NHUONG_THUC_TENull()
        {
            return pm_objDR.IsNull("GIA_TRI_CHUYEN_NHUONG_THUC_TE");
        }

        public void SetGIA_TRI_CHUYEN_NHUONG_THUC_TENull()
        {
            pm_objDR["GIA_TRI_CHUYEN_NHUONG_THUC_TE"] = System.Convert.DBNull;
        }

        public decimal dcTY_LE_PHI_GD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TY_LE_PHI_GD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TY_LE_PHI_GD"] = value;
            }
        }

        public bool IsTY_LE_PHI_GDNull()
        {
            return pm_objDR.IsNull("TY_LE_PHI_GD");
        }

        public void SetTY_LE_PHI_GDNull()
        {
            pm_objDR["TY_LE_PHI_GD"] = System.Convert.DBNull;
        }

        public decimal dcPHI_GD
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "PHI_GD", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["PHI_GD"] = value;
            }
        }

        public bool IsPHI_GDNull()
        {
            return pm_objDR.IsNull("PHI_GD");
        }

        public void SetPHI_GDNull()
        {
            pm_objDR["PHI_GD"] = System.Convert.DBNull;
        }

        public string strNOI_DUNG_GIAO_DICH
        {
            get
            {
                return CNull.RowNVLString(pm_objDR, "NOI_DUNG_GIAO_DICH", IPConstants.c_DefaultString);
            }
            set
            {
                pm_objDR["NOI_DUNG_GIAO_DICH"] = value;
            }
        }

        public bool IsNOI_DUNG_GIAO_DICHNull()
        {
            return pm_objDR.IsNull("NOI_DUNG_GIAO_DICH");
        }

        public void SetNOI_DUNG_GIAO_DICHNull()
        {
            pm_objDR["NOI_DUNG_GIAO_DICH"] = System.Convert.DBNull;
        }

        public decimal dcPHAN_TRAM_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "PHAN_TRAM_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["PHAN_TRAM_THUE"] = value;
            }
        }

        public bool IsPHAN_TRAM_THUENull()
        {
            return pm_objDR.IsNull("PHAN_TRAM_THUE");
        }

        public void SetPHAN_TRAM_THUENull()
        {
            pm_objDR["PHAN_TRAM_THUE"] = System.Convert.DBNull;
        }

        public decimal dcGIA_TRI_THUE
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "GIA_TRI_THUE", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["GIA_TRI_THUE"] = value;
            }
        }

        public bool IsGIA_TRI_THUENull()
        {
            return pm_objDR.IsNull("GIA_TRI_THUE");
        }

        public void SetGIA_TRI_THUENull()
        {
            pm_objDR["GIA_TRI_THUE"] = System.Convert.DBNull;
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

        public decimal dcID_TRANG_THAI_CHUYEN_NHUONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI_CHUYEN_NHUONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRANG_THAI_CHUYEN_NHUONG"] = value;
            }
        }

        public bool IsID_TRANG_THAI_CHUYEN_NHUONGNull()
        {
            return pm_objDR.IsNull("ID_TRANG_THAI_CHUYEN_NHUONG");
        }

        public void SetID_TRANG_THAI_CHUYEN_NHUONGNull()
        {
            pm_objDR["ID_TRANG_THAI_CHUYEN_NHUONG"] = System.Convert.DBNull;
        }

        #endregion


        #region Init Functions
        public US_GD_CHUYEN_NHUONG()
        {
            pm_objDS = new DS_GD_CHUYEN_NHUONG();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_CHUYEN_NHUONG(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_CHUYEN_NHUONG(decimal i_dbID)
        {
            pm_objDS = new DS_GD_CHUYEN_NHUONG();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }


        public void duyet_chuyen_nhuong()
        {
            CStoredProc v_pr_obj = new CStoredProc("pr_GD_CHUYEN_NHUONG_duyet_giao_dich");
            v_pr_obj.addDecimalInputParam("@ID", this.dcID);            
            v_pr_obj.addDatetimeInputParam("@NGAY_XAC_NHAN", this.datNGAY_XAC_NHAN);
            v_pr_obj.addDecimalInputParam("@ID_TRAI_CHU_MUA", this.dcID_TRAI_CHU_MUA);
            v_pr_obj.addDecimalInputParam("@ID_TRAI_CHU_BAN", this.dcID_TRAI_CHU_BAN);
            v_pr_obj.addDecimalInputParam("@SO_LUONG_CHUYEN_NHUONG", this.dcSO_LUONG_CHUYEN_NHUONG);
            v_pr_obj.addDecimalInputParam("@ID_TRANG_THAI_CHUYEN_NHUONG", this.dcID_TRANG_THAI_CHUYEN_NHUONG);
            v_pr_obj.addDecimalInputParam("@ID_NGUOI_DUYET", this.dcID_NGUOI_DUYET);
            v_pr_obj.ExecuteCommand(this);
        }
        public string get_ma_dich_chuyen_nhuong()
        {
            string v_str_ma_gd = "CN";
            string v_str_ma_gd_cu;
            DS_GD_CHUYEN_NHUONG v_ds = new DS_GD_CHUYEN_NHUONG();
            CStoredProc v_cstore = new CStoredProc("pr_GD_CHUYEN_NHUONG_get_ma_gd");
            v_cstore.fillDataSetByCommand(this, v_ds);
            if(v_ds.GD_CHUYEN_NHUONG == null || v_ds.GD_CHUYEN_NHUONG.Count == 0)
                return "CN0001";
            this.DataRow2Me(getRowClone(v_ds.Tables[pm_strTableName].Rows[0]));
            v_str_ma_gd_cu = this.strMA_GIAO_DICH;                     
            decimal v_so_ma_gd = CIPConvert.ToDecimal(v_str_ma_gd_cu.Substring(2)) + 1;
            v_str_ma_gd = v_str_ma_gd + v_so_ma_gd.ToString("0000");
                return v_str_ma_gd;
        }
        #endregion

        
    }
}
