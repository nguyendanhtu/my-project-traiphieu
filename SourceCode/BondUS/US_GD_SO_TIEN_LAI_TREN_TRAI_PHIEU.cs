///************************************************
/// Generated by: NinhVH
/// Date: 30/11/2012 01:58:36
/// Goal: Create User Service Class for GD_SO_TIEN_LAI_TREN_TRAI_PHIEU
///************************************************
/// <summary>
/// Create User Service Class for GD_SO_TIEN_LAI_TREN_TRAI_PHIEU
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{



    public class US_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU : US_Object
    {
        private const string c_TableName = "GD_SO_TIEN_LAI_TREN_TRAI_PHIEU";
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

        public decimal dcID_TRAI_PHIEU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "ID_TRAI_PHIEU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["ID_TRAI_PHIEU"] = value;
            }
        }

        public bool IsID_TRAI_PHIEUNull()
        {
            return pm_objDR.IsNull("ID_TRAI_PHIEU");
        }

        public void SetID_TRAI_PHIEUNull()
        {
            pm_objDR["ID_TRAI_PHIEU"] = System.Convert.DBNull;
        }

        public decimal dcSO_TIEN_LAI_TREN_TRAI_PHIEU
        {
            get
            {
                return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN_LAI_TREN_TRAI_PHIEU", IPConstants.c_DefaultDecimal);
            }
            set
            {
                pm_objDR["SO_TIEN_LAI_TREN_TRAI_PHIEU"] = value;
            }
        }

        public bool IsSO_TIEN_LAI_TREN_TRAI_PHIEUNull()
        {
            return pm_objDR.IsNull("SO_TIEN_LAI_TREN_TRAI_PHIEU");
        }

        public void SetSO_TIEN_LAI_TREN_TRAI_PHIEUNull()
        {
            pm_objDR["SO_TIEN_LAI_TREN_TRAI_PHIEU"] = System.Convert.DBNull;
        }

        #endregion


        #region Init Functions
        public US_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU()
        {
            pm_objDS = new DS_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU();
            pm_strTableName = c_TableName;
            pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
        }

        public US_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU(DataRow i_objDR)
            : this()
        {
            this.DataRow2Me(i_objDR);
        }

        public US_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU(decimal i_dbID)
        {
            pm_objDS = new DS_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU();
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
        public void fill_dataset_by_trai_phieu_in_times(DS_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU ip_ds
                                                        , DateTime ip_dat_tu_ngay
                                                        , DateTime ip_dat_den_ngay
                                                        , decimal ip_id_trai_phieu)
        {
            CStoredProc v_cstore = new CStoredProc("[pr_GD_SO_TIEN_LAI_TREN_TRAI_PHIEU_select_lai_in_times]");
            v_cstore.addDecimalInputParam("@id_trai_phieu", ip_id_trai_phieu);
            v_cstore.addDatetimeInputParam("@ngay_dau_ky", ip_dat_tu_ngay.Date);
            v_cstore.addDatetimeInputParam("@ngay_cuoi_ky", ip_dat_den_ngay.Date);
            v_cstore.fillDataSetByCommand(this, ip_ds);
        }
        #endregion
    }
}