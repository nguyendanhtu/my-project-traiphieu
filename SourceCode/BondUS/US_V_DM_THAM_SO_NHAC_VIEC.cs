///************************************************
/// Generated by: linhdh
/// Date: 25/10/2012 05:37:19
/// Goal: Create User Service Class for V_DM_THAM_SO_NHAC_VIEC
///************************************************
/// <summary>
/// Create User Service Class for V_DM_THAM_SO_NHAC_VIEC
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BondDS;
using BondDS.CDBNames;


namespace BondUS{

public class US_V_DM_THAM_SO_NHAC_VIEC : US_Object
{
	private const string c_TableName = "V_DM_THAM_SO_NHAC_VIEC";
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

	public decimal dcID_LOAI_NHAC_VIEC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_NHAC_VIEC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_NHAC_VIEC"] = value;
		}
	}

	public bool IsID_LOAI_NHAC_VIECNull()	{
		return pm_objDR.IsNull("ID_LOAI_NHAC_VIEC");
	}

	public void SetID_LOAI_NHAC_VIECNull() {
		pm_objDR["ID_LOAI_NHAC_VIEC"] = System.Convert.DBNull;
	}

	public string strLOAI_NHAC_VIEC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "LOAI_NHAC_VIEC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["LOAI_NHAC_VIEC"] = value;
		}
	}

	public bool IsLOAI_NHAC_VIECNull() 
	{
		return pm_objDR.IsNull("LOAI_NHAC_VIEC");
	}

	public void SetLOAI_NHAC_VIECNull() {
		pm_objDR["LOAI_NHAC_VIEC"] = System.Convert.DBNull;
	}

	public decimal dcSO_NGAY_NHAC_TRUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_NGAY_NHAC_TRUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_NGAY_NHAC_TRUOC"] = value;
		}
	}

	public bool IsSO_NGAY_NHAC_TRUOCNull()	{
		return pm_objDR.IsNull("SO_NGAY_NHAC_TRUOC");
	}

	public void SetSO_NGAY_NHAC_TRUOCNull() {
		pm_objDR["SO_NGAY_NHAC_TRUOC"] = System.Convert.DBNull;
	}

	public string strNOI_DUNG_NHAC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_DUNG_NHAC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_DUNG_NHAC"] = value;
		}
	}

	public bool IsNOI_DUNG_NHACNull() 
	{
		return pm_objDR.IsNull("NOI_DUNG_NHAC");
	}

	public void SetNOI_DUNG_NHACNull() {
		pm_objDR["NOI_DUNG_NHAC"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_THAM_SO_NHAC_VIEC() 
	{
		pm_objDS = new DS_V_DM_THAM_SO_NHAC_VIEC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_THAM_SO_NHAC_VIEC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_THAM_SO_NHAC_VIEC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_THAM_SO_NHAC_VIEC();
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
