///************************************************
/// Generated by: HaiND
/// Date: 10/10/2012 04:20:12
/// Goal: Create User Service Class for DM_DOT_PHAT_HANH
///************************************************
/// <summary>
/// Create User Service Class for DM_DOT_PHAT_HANH
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{
    public class US_DM_DOT_PHAT_HANH : US_Object
    {
        private const string c_TableName = "DM_DOT_PHAT_HANH";
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

        public DateTime datNGAY_DAO_HAN
        {
            get
            {
                return CNull.RowNVLDate(pm_objDR, "NGAY_DAO_HAN", IPConstants.c_DefaultDate);
            }
            set
            {
                pm_objDR["NGAY_DAO_HAN"] = value;
            }
        }

        public bool IsNGAY_DAO_HANNull()
        {
            return pm_objDR.IsNull("NGAY_DAO_HAN");
        }

        public void SetNGAY_DAO_HANNull()
        {
            pm_objDR["NGAY_DAO_HAN"] = System.Convert.DBNull;
        }

        public decimal dcTONG_SL_PHAT_HANH
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_SL_PHAT_HANH", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_SL_PHAT_HANH"] = value;
            }
        }

        public bool IsTONG_SL_PHAT_HANHNull()
        {
            return pm_objDR.IsNull("TONG_SL_PHAT_HANH");
        }

        public void SetTONG_SL_PHAT_HANHNull()
        {
            pm_objDR["TONG_SL_PHAT_HANH"] = System.Convert.DBNull;
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

        public decimal dcTONG_GIA_TRI
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "TONG_GIA_TRI", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["TONG_GIA_TRI"] = value;
            }
        }

        public bool IsTONG_GIA_TRINull()
        {
            return pm_objDR.IsNull("TONG_GIA_TRI");
        }

        public void SetTONG_GIA_TRINull()
        {
            pm_objDR["TONG_GIA_TRI"] = System.Convert.DBNull;
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

        #endregion


        #region Init Functions
        public US_DM_DOT_PHAT_HANH()
        {
            pm_objDS = new DS_DM_DOT_PHAT_HANH();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_DM_DOT_PHAT_HANH(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_DM_DOT_PHAT_HANH(decimal i_dbID)
        {
            pm_objDS = new DS_DM_DOT_PHAT_HANH();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion


    }
}