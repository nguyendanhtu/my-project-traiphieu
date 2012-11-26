///************************************************
/// Generated by: NinhVH
/// Date: 26/11/2012 03:27:37
/// Goal: Create User Service Class for HT_PHAN_QUYEN_CHO_NHOM
///************************************************
/// <summary>
/// Create User Service Class for HT_PHAN_QUYEN_CHO_NHOM
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{

    public class US_HT_PHAN_QUYEN_CHO_NHOM : US_Object
    {
        private const string c_TableName = "HT_PHAN_QUYEN_CHO_NHOM";
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

        public decimal dcID_NHOM_NGUOI_SU_DUNG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_NGUOI_SU_DUNG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_NHOM_NGUOI_SU_DUNG"] = value;
            }
        }

        public bool IsID_NHOM_NGUOI_SU_DUNGNull()
        {
            return pm_objDR.IsNull("ID_NHOM_NGUOI_SU_DUNG");
        }

        public void SetID_NHOM_NGUOI_SU_DUNGNull()
        {
            pm_objDR["ID_NHOM_NGUOI_SU_DUNG"] = System.Convert.DBNull;
        }

        public decimal dcID_PHAN_QUYEN_HE_THONG
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_PHAN_QUYEN_HE_THONG", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_PHAN_QUYEN_HE_THONG"] = value;
            }
        }

        public bool IsID_PHAN_QUYEN_HE_THONGNull()
        {
            return pm_objDR.IsNull("ID_PHAN_QUYEN_HE_THONG");
        }

        public void SetID_PHAN_QUYEN_HE_THONGNull()
        {
            pm_objDR["ID_PHAN_QUYEN_HE_THONG"] = System.Convert.DBNull;
        }

        #endregion


        #region Init Functions
        public US_HT_PHAN_QUYEN_CHO_NHOM()
        {
            pm_objDS = new DS_HT_PHAN_QUYEN_CHO_NHOM();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_HT_PHAN_QUYEN_CHO_NHOM(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_HT_PHAN_QUYEN_CHO_NHOM(decimal i_dbID)
        {
            pm_objDS = new DS_HT_PHAN_QUYEN_CHO_NHOM();
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
