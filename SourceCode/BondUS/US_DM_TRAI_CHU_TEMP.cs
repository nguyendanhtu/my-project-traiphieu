///************************************************
/// Generated by: linhdh
/// Date: 01/11/2012 06:52:21
/// Goal: Create User Service Class for DM_TRAI_CHU_TEMP
///************************************************
/// <summary>
/// Create User Service Class for DM_TRAI_CHU_TEMP
/// </summary>

using System;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using WebDS;


namespace WebUS{

public class US_DM_TRAI_CHU_TEMP : US_Object
{
	private const string c_TableName = "DM_TRAI_CHU_TEMP";
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

	public bool IsID_NGUOI_LAPNull()	{
		return pm_objDR.IsNull("ID_NGUOI_LAP");
	}

	public void SetID_NGUOI_LAPNull() {
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

	public bool IsID_NGUOI_DUYETNull()	{
		return pm_objDR.IsNull("ID_NGUOI_DUYET");
	}

	public void SetID_NGUOI_DUYETNull() {
		pm_objDR["ID_NGUOI_DUYET"] = System.Convert.DBNull;
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

	public string strTEN_NGUOI_DAI_DIEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NGUOI_DAI_DIEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NGUOI_DAI_DIEN"] = value;
		}
	}

	public bool IsTEN_NGUOI_DAI_DIENNull() 
	{
		return pm_objDR.IsNull("TEN_NGUOI_DAI_DIEN");
	}

	public void SetTEN_NGUOI_DAI_DIENNull() {
		pm_objDR["TEN_NGUOI_DAI_DIEN"] = System.Convert.DBNull;
	}

	public string strCMT_NGUOI_DAI_DIEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CMT_NGUOI_DAI_DIEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CMT_NGUOI_DAI_DIEN"] = value;
		}
	}

	public bool IsCMT_NGUOI_DAI_DIENNull() 
	{
		return pm_objDR.IsNull("CMT_NGUOI_DAI_DIEN");
	}

	public void SetCMT_NGUOI_DAI_DIENNull() {
		pm_objDR["CMT_NGUOI_DAI_DIEN"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_CAP_CMT_NGUOI_DAI_DIEN
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CAP_CMT_NGUOI_DAI_DIEN", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_CAP_CMT_NGUOI_DAI_DIEN"] = value;
		}
	}

	public bool IsNGAY_CAP_CMT_NGUOI_DAI_DIENNull()
	{
		return pm_objDR.IsNull("NGAY_CAP_CMT_NGUOI_DAI_DIEN");
	}

	public void SetNGAY_CAP_CMT_NGUOI_DAI_DIENNull()
	{
		pm_objDR["NGAY_CAP_CMT_NGUOI_DAI_DIEN"] = System.Convert.DBNull;
	}

	public string strNOI_CAP_CMT_NGUOI_DAI_DIEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NOI_CAP_CMT_NGUOI_DAI_DIEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NOI_CAP_CMT_NGUOI_DAI_DIEN"] = value;
		}
	}

	public bool IsNOI_CAP_CMT_NGUOI_DAI_DIENNull() 
	{
		return pm_objDR.IsNull("NOI_CAP_CMT_NGUOI_DAI_DIEN");
	}

	public void SetNOI_CAP_CMT_NGUOI_DAI_DIENNull() {
		pm_objDR["NOI_CAP_CMT_NGUOI_DAI_DIEN"] = System.Convert.DBNull;
	}

	public string strCHUC_VU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "CHUC_VU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["CHUC_VU"] = value;
		}
	}

	public bool IsCHUC_VUNull() 
	{
		return pm_objDR.IsNull("CHUC_VU");
	}

	public void SetCHUC_VUNull() {
		pm_objDR["CHUC_VU"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG_TRAI_PHIEU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_TRAI_PHIEU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_TRAI_PHIEU"] = value;
		}
	}

	public bool IsSO_LUONG_TRAI_PHIEUNull()	{
		return pm_objDR.IsNull("SO_LUONG_TRAI_PHIEU");
	}

	public void SetSO_LUONG_TRAI_PHIEUNull() {
		pm_objDR["SO_LUONG_TRAI_PHIEU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_TRAI_CHU_TEMP() 
	{
		pm_objDS = new DS_DM_TRAI_CHU_TEMP();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_TRAI_CHU_TEMP(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_TRAI_CHU_TEMP(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_TRAI_CHU_TEMP();
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
