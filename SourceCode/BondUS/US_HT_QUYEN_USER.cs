///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:37:04
/// Goal: Create User Service Class for HT_QUYEN_USER
///************************************************
/// <summary>
/// Create User Service Class for HT_QUYEN_USER
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{

    public class US_HT_QUYEN_USER : US_Object
    {
        private const string c_TableName = "HT_QUYEN_USER";
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

        public decimal dcID_USER
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_USER", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_USER"] = value;
            }
        }

        public bool IsID_USERNull()
        {
            return pm_objDR.IsNull("ID_USER");
        }

        public void SetID_USERNull()
        {
            pm_objDR["ID_USER"] = System.Convert.DBNull;
        }

        public decimal dcID_QUYEN
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_QUYEN", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_QUYEN"] = value;
            }
        }

        public bool IsID_QUYENNull()
        {
            return pm_objDR.IsNull("ID_QUYEN");
        }

        public void SetID_QUYENNull()
        {
            pm_objDR["ID_QUYEN"] = System.Convert.DBNull;
        }

        #endregion
        #region "Init Functions"
        public US_HT_QUYEN_USER()
        {
            pm_objDS = new DS_HT_QUYEN_USER();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_HT_QUYEN_USER(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_HT_QUYEN_USER(decimal i_dbID)
        {
            pm_objDS = new DS_HT_QUYEN_USER();
            pm_strTableName = c_TableName;
            IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
            v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            SqlCommand v_cmdSQL;
            v_cmdSQL = v_objMkCmd.getSelectCmd();
            this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
            pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
        }
        #endregion
        #region Addtional
        public void FillDatasetByUserID(decimal i_dc_user_id
            , DS_HT_QUYEN_USER i_ds)
        {

            IMakeSelectCmd v_obj_mak_cmd = new CMakeAndSelectCmd(i_ds, i_ds.HT_QUYEN_USER.TableName);
            v_obj_mak_cmd.AddCondition("ID_USER", i_dc_user_id, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
            this.FillDatasetByCommand(i_ds, v_obj_mak_cmd.getSelectCmd());
        }
        public void DeleteAllQuyenOfUser(decimal i_dc_user_id)
        {
            CStoredProc v_obj = new CStoredProc("pr_HT_QUYEN_USER_Delele_All_Quyen_Of_user");
            v_obj.addDecimalInputParam("@ip_dc_user_id", i_dc_user_id);
            v_obj.ExecuteCommand(this);
        }
        #endregion
    }
}
