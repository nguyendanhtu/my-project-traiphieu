///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:36:31
/// Goal: Create User Service Class for GD_LICH_THANH_TOAN_LAI_GOC
///************************************************
/// <summary>
/// Create User Service Class for GD_LICH_THANH_TOAN_LAI_GOC
/// </summary>


using BondDS;
using BondDS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{

public class US_GD_LICH_THANH_TOAN_LAI_GOC : US_Object
{
	private const string c_TableName = "GD_LICH_THANH_TOAN_LAI_GOC";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
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

	public bool IsID_TRAI_PHIEUNull()	{
		return pm_objDR.IsNull("ID_TRAI_PHIEU");
	}

	public void SetID_TRAI_PHIEUNull() {
		pm_objDR["ID_TRAI_PHIEU"] = System.Convert.DBNull;
	}

	public string strCHOT_LAI_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHOT_LAI_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHOT_LAI_YN"] = value;
		}
	}

	public bool IsCHOT_LAI_YNNull() 
	{
		return pm_objDR.IsNull("CHOT_LAI_YN");
	}

	public void SetCHOT_LAI_YNNull() {
		pm_objDR["CHOT_LAI_YN"] = System.Convert.DBNull;
	}

	public string strCAP_NHAT_LS_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CAP_NHAT_LS_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CAP_NHAT_LS_YN"] = value;
		}
	}

	public bool IsCAP_NHAT_LS_YNNull() 
	{
		return pm_objDR.IsNull("CAP_NHAT_LS_YN");
	}

	public void SetCAP_NHAT_LS_YNNull() {
		pm_objDR["CAP_NHAT_LS_YN"] = System.Convert.DBNull;
	}

	public string strTHANH_TOAN_GOC_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "THANH_TOAN_GOC_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["THANH_TOAN_GOC_YN"] = value;
		}
	}

	public bool IsTHANH_TOAN_GOC_YNNull() 
	{
		return pm_objDR.IsNull("THANH_TOAN_GOC_YN");
	}

	public void SetTHANH_TOAN_GOC_YNNull() {
		pm_objDR["THANH_TOAN_GOC_YN"] = System.Convert.DBNull;
	}

	public string strTHANH_TOAN_THUC_TE_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "THANH_TOAN_THUC_TE_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["THANH_TOAN_THUC_TE_YN"] = value;
		}
	}

	public bool IsTHANH_TOAN_THUC_TE_YNNull() 
	{
		return pm_objDR.IsNull("THANH_TOAN_THUC_TE_YN");
	}

	public void SetTHANH_TOAN_THUC_TE_YNNull() {
		pm_objDR["THANH_TOAN_THUC_TE_YN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY"] = value;
		}
	}

	public bool IsNGAYNull()
	{
		return pm_objDR.IsNull("NGAY");
	}

	public void SetNGAYNull()
	{
		pm_objDR["NGAY"] = System.Convert.DBNull;
	}

	public string strDA_THUC_HIEN_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DA_THUC_HIEN_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DA_THUC_HIEN_YN"] = value;
		}
	}

	public bool IsDA_THUC_HIEN_YNNull() 
	{
		return pm_objDR.IsNull("DA_THUC_HIEN_YN");
	}

	public void SetDA_THUC_HIEN_YNNull() {
		pm_objDR["DA_THUC_HIEN_YN"] = System.Convert.DBNull;
	}

	public decimal dcLAI_SUAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "LAI_SUAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["LAI_SUAT"] = value;
		}
	}

	public bool IsLAI_SUATNull()	{
		return pm_objDR.IsNull("LAI_SUAT");
	}

	public void SetLAI_SUATNull() {
		pm_objDR["LAI_SUAT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_LICH_THANH_TOAN_LAI_GOC() 
	{
		pm_objDS = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_LICH_THANH_TOAN_LAI_GOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_LICH_THANH_TOAN_LAI_GOC(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_LICH_THANH_TOAN_LAI_GOC();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    #region Addtional Method

    public void FillDatasetByIDTraiPhieu(DS_GD_LICH_THANH_TOAN_LAI_GOC ip_gd_lich, decimal ip_id_trai_phieu)
    {
        CMakeAndSelectCmd v_obj_cmd = new CMakeAndSelectCmd(ip_gd_lich, c_TableName);
        v_obj_cmd.AddCondition(GD_LICH_THANH_TOAN_LAI_GOC.ID_TRAI_PHIEU
            , ip_id_trai_phieu
            , eKieuDuLieu.KieuNumber
            , eKieuSoSanh.Bang);

        this.FillDatasetByCommand(ip_gd_lich, v_obj_cmd.getSelectCmd());

    }
    #endregion
}
}
