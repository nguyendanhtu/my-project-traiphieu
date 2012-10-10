///************************************************
/// Generated by: SyHT
/// Date: 11/10/2012 01:50:57
/// Goal: Create User Service Class for V_GD_TRA_GOC
///************************************************
/// <summary>
/// Create User Service Class for V_GD_TRA_GOC
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_V_GD_TRA_GOC : US_Object
{
	private const string c_TableName = "V_GD_TRA_GOC";
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

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public string strTEN_TRAI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_TRAI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_TRAI_CHU"] = value;
		}
	}

	public bool IsTEN_TRAI_CHUNull() 
	{
		return pm_objDR.IsNull("TEN_TRAI_CHU");
	}

	public void SetTEN_TRAI_CHUNull() {
		pm_objDR["TEN_TRAI_CHU"] = System.Convert.DBNull;
	}

	public string strMA_TRAI_CHU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TRAI_CHU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TRAI_CHU"] = value;
		}
	}

	public bool IsMA_TRAI_CHUNull() 
	{
		return pm_objDR.IsNull("MA_TRAI_CHU");
	}

	public void SetMA_TRAI_CHUNull() {
		pm_objDR["MA_TRAI_CHU"] = System.Convert.DBNull;
	}

	public string strDIA_CHI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIA_CHI"] = value;
		}
	}

	public bool IsDIA_CHINull() 
	{
		return pm_objDR.IsNull("DIA_CHI");
	}

	public void SetDIA_CHINull() {
		pm_objDR["DIA_CHI"] = System.Convert.DBNull;
	}

	public string strMOBILE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MOBILE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MOBILE"] = value;
		}
	}

	public bool IsMOBILENull() 
	{
		return pm_objDR.IsNull("MOBILE");
	}

	public void SetMOBILENull() {
		pm_objDR["MOBILE"] = System.Convert.DBNull;
	}

	public string strFAX 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "FAX", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["FAX"] = value;
		}
	}

	public bool IsFAXNull() 
	{
		return pm_objDR.IsNull("FAX");
	}

	public void SetFAXNull() {
		pm_objDR["FAX"] = System.Convert.DBNull;
	}

	public string strCMT_GIAY_DKKD 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CMT_GIAY_DKKD", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CMT_GIAY_DKKD"] = value;
		}
	}

	public bool IsCMT_GIAY_DKKDNull() 
	{
		return pm_objDR.IsNull("CMT_GIAY_DKKD");
	}

	public void SetCMT_GIAY_DKKDNull() {
		pm_objDR["CMT_GIAY_DKKD"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_CAP_CMT
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_CMT", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_CAP_CMT"] = value;
		}
	}

	public bool IsNGAY_CAP_CMTNull()
	{
		return pm_objDR.IsNull("NGAY_CAP_CMT");
	}

	public void SetNGAY_CAP_CMTNull()
	{
		pm_objDR["NGAY_CAP_CMT"] = System.Convert.DBNull;
	}

	public string strNOI_CAP_CMT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_CAP_CMT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_CAP_CMT"] = value;
		}
	}

	public bool IsNOI_CAP_CMTNull() 
	{
		return pm_objDR.IsNull("NOI_CAP_CMT");
	}

	public void SetNOI_CAP_CMTNull() {
		pm_objDR["NOI_CAP_CMT"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_TRAI_CHU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TRAI_CHU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_TRAI_CHU"] = value;
		}
	}

	public bool IsID_LOAI_TRAI_CHUNull()	{
		return pm_objDR.IsNull("ID_LOAI_TRAI_CHU");
	}

	public void SetID_LOAI_TRAI_CHUNull() {
		pm_objDR["ID_LOAI_TRAI_CHU"] = System.Convert.DBNull;
	}

	public decimal dcID_NGUOI_DUYET_TC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_DUYET_TC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGUOI_DUYET_TC"] = value;
		}
	}

	public bool IsID_NGUOI_DUYET_TCNull()	{
		return pm_objDR.IsNull("ID_NGUOI_DUYET_TC");
	}

	public void SetID_NGUOI_DUYET_TCNull() {
		pm_objDR["ID_NGUOI_DUYET_TC"] = System.Convert.DBNull;
	}

	public decimal dcID_NGUOI_LAP_TC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP_TC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGUOI_LAP_TC"] = value;
		}
	}

	public bool IsID_NGUOI_LAP_TCNull()	{
		return pm_objDR.IsNull("ID_NGUOI_LAP_TC");
	}

	public void SetID_NGUOI_LAP_TCNull() {
		pm_objDR["ID_NGUOI_LAP_TC"] = System.Convert.DBNull;
	}

	public decimal dcID_TRAI_PHIEU_SO_HUU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRAI_PHIEU_SO_HUU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRAI_PHIEU_SO_HUU"] = value;
		}
	}

	public bool IsID_TRAI_PHIEU_SO_HUUNull()	{
		return pm_objDR.IsNull("ID_TRAI_PHIEU_SO_HUU");
	}

	public void SetID_TRAI_PHIEU_SO_HUUNull() {
		pm_objDR["ID_TRAI_PHIEU_SO_HUU"] = System.Convert.DBNull;
	}

	public string strMA_TRAI_PHIEU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_TRAI_PHIEU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_TRAI_PHIEU"] = value;
		}
	}

	public bool IsMA_TRAI_PHIEUNull() 
	{
		return pm_objDR.IsNull("MA_TRAI_PHIEU");
	}

	public void SetMA_TRAI_PHIEUNull() {
		pm_objDR["MA_TRAI_PHIEU"] = System.Convert.DBNull;
	}

	public string strTEN_TRAI_PHIEU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_TRAI_PHIEU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_TRAI_PHIEU"] = value;
		}
	}

	public bool IsTEN_TRAI_PHIEUNull() 
	{
		return pm_objDR.IsNull("TEN_TRAI_PHIEU");
	}

	public void SetTEN_TRAI_PHIEUNull() {
		pm_objDR["TEN_TRAI_PHIEU"] = System.Convert.DBNull;
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

	public bool IsMENH_GIANull()	{
		return pm_objDR.IsNull("MENH_GIA");
	}

	public void SetMENH_GIANull() {
		pm_objDR["MENH_GIA"] = System.Convert.DBNull;
	}

	public string strSO_TAI_KHOAN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "SO_TAI_KHOAN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["SO_TAI_KHOAN"] = value;
		}
	}

	public bool IsSO_TAI_KHOANNull() 
	{
		return pm_objDR.IsNull("SO_TAI_KHOAN");
	}

	public void SetSO_TAI_KHOANNull() {
		pm_objDR["SO_TAI_KHOAN"] = System.Convert.DBNull;
	}

	public string strMO_TAI_NGAN_HANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MO_TAI_NGAN_HANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MO_TAI_NGAN_HANG"] = value;
		}
	}

	public bool IsMO_TAI_NGAN_HANGNull() 
	{
		return pm_objDR.IsNull("MO_TAI_NGAN_HANG");
	}

	public void SetMO_TAI_NGAN_HANGNull() {
		pm_objDR["MO_TAI_NGAN_HANG"] = System.Convert.DBNull;
	}

	public string strGHI_CHU1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU1"] = value;
		}
	}

	public bool IsGHI_CHU1Null() 
	{
		return pm_objDR.IsNull("GHI_CHU1");
	}

	public void SetGHI_CHU1Null() {
		pm_objDR["GHI_CHU1"] = System.Convert.DBNull;
	}

	public string strGHI_CHU2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU2"] = value;
		}
	}

	public bool IsGHI_CHU2Null() 
	{
		return pm_objDR.IsNull("GHI_CHU2");
	}

	public void SetGHI_CHU2Null() {
		pm_objDR["GHI_CHU2"] = System.Convert.DBNull;
	}

	public string strGHI_CHU3 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU3", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU3"] = value;
		}
	}

	public bool IsGHI_CHU3Null() 
	{
		return pm_objDR.IsNull("GHI_CHU3");
	}

	public void SetGHI_CHU3Null() {
		pm_objDR["GHI_CHU3"] = System.Convert.DBNull;
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

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
	}

	public decimal dcTONG_SO_DU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_DU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TONG_SO_DU"] = value;
		}
	}

	public bool IsTONG_SO_DUNull()	{
		return pm_objDR.IsNull("TONG_SO_DU");
	}

	public void SetTONG_SO_DUNull() {
		pm_objDR["TONG_SO_DU"] = System.Convert.DBNull;
	}

#endregion


#region Init Functions
	public US_V_GD_TRA_GOC() 
	{
		pm_objDS = new DS_V_GD_TRA_GOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_TRA_GOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_TRA_GOC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_TRA_GOC();
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
