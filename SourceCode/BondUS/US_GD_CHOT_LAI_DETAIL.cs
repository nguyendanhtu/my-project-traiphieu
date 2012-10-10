///************************************************
/// Generated by: BINH
/// Date: 10/10/2012 04:39:59
/// Goal: Create User Service Class for GD_CHOT_LAI_DETAIL
///************************************************
/// <summary>
/// Create User Service Class for GD_CHOT_LAI_DETAIL
/// </summary>

namespace BondUS
{
using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_GD_CHOT_LAI_DETAIL : US_Object
{
	private const string c_TableName = "GD_CHOT_LAI_DETAIL";
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

	public decimal dcID_CHOT_LAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_CHOT_LAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_CHOT_LAI"] = value;
		}
	}

	public bool IsID_CHOT_LAINull()	{
		return pm_objDR.IsNull("ID_CHOT_LAI");
	}

	public void SetID_CHOT_LAINull() {
		pm_objDR["ID_CHOT_LAI"] = System.Convert.DBNull;
	}

	public decimal dcID_TRAI_CHU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRAI_CHU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRAI_CHU"] = value;
		}
	}

	public bool IsID_TRAI_CHUNull()	{
		return pm_objDR.IsNull("ID_TRAI_CHU");
	}

	public void SetID_TRAI_CHUNull() {
		pm_objDR["ID_TRAI_CHU"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG_TINH_LAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_TINH_LAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_TINH_LAI"] = value;
		}
	}

	public bool IsSO_LUONG_TINH_LAINull()	{
		return pm_objDR.IsNull("SO_LUONG_TINH_LAI");
	}

	public void SetSO_LUONG_TINH_LAINull() {
		pm_objDR["SO_LUONG_TINH_LAI"] = System.Convert.DBNull;
	}

	public decimal dcSO_TIEN_LAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_TIEN_LAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_TIEN_LAI"] = value;
		}
	}

	public bool IsSO_TIEN_LAINull()	{
		return pm_objDR.IsNull("SO_TIEN_LAI");
	}

	public void SetSO_TIEN_LAINull() {
		pm_objDR["SO_TIEN_LAI"] = System.Convert.DBNull;
	}

	public string strDA_NHAN_TIEN_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DA_NHAN_TIEN_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DA_NHAN_TIEN_YN"] = value;
		}
	}

	public bool IsDA_NHAN_TIEN_YNNull() 
	{
		return pm_objDR.IsNull("DA_NHAN_TIEN_YN");
	}

	public void SetDA_NHAN_TIEN_YNNull() {
		pm_objDR["DA_NHAN_TIEN_YN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_NHAN_TIEN
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_NHAN_TIEN", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_NHAN_TIEN"] = value;
		}
	}

	public bool IsNGAY_NHAN_TIENNull()
	{
		return pm_objDR.IsNull("NGAY_NHAN_TIEN");
	}

	public void SetNGAY_NHAN_TIENNull()
	{
		pm_objDR["NGAY_NHAN_TIEN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_CHOT_LAI_DETAIL() 
	{
		pm_objDS = new DS_GD_CHOT_LAI_DETAIL();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_CHOT_LAI_DETAIL(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_CHOT_LAI_DETAIL(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_CHOT_LAI_DETAIL();
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
