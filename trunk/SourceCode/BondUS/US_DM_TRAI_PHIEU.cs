///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:35:58
/// Goal: Create User Service Class for DM_TRAI_PHIEU
///************************************************
/// <summary>
/// Create User Service Class for DM_TRAI_PHIEU
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{

public class US_DM_TRAI_PHIEU : US_Object
{
	private const string c_TableName = "DM_TRAI_PHIEU";
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

	public bool IsID_TO_CHUC_PHAT_HANHNull()	{
		return pm_objDR.IsNull("ID_TO_CHUC_PHAT_HANH");
	}

	public void SetID_TO_CHUC_PHAT_HANHNull() {
		pm_objDR["ID_TO_CHUC_PHAT_HANH"] = System.Convert.DBNull;
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

	public decimal dcID_LOAI_TRAI_PHIEU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TRAI_PHIEU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_TRAI_PHIEU"] = value;
		}
	}

	public bool IsID_LOAI_TRAI_PHIEUNull()	{
		return pm_objDR.IsNull("ID_LOAI_TRAI_PHIEU");
	}

	public void SetID_LOAI_TRAI_PHIEUNull() {
		pm_objDR["ID_LOAI_TRAI_PHIEU"] = System.Convert.DBNull;
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

	public decimal dcKY_HAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "KY_HAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["KY_HAN"] = value;
		}
	}

	public bool IsKY_HANNull()	{
		return pm_objDR.IsNull("KY_HAN");
	}

	public void SetKY_HANNull() {
		pm_objDR["KY_HAN"] = System.Convert.DBNull;
	}

	public decimal dcID_DV_KY_HAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DV_KY_HAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DV_KY_HAN"] = value;
		}
	}

	public bool IsID_DV_KY_HANNull()	{
		return pm_objDR.IsNull("ID_DV_KY_HAN");
	}

	public void SetID_DV_KY_HANNull() {
		pm_objDR["ID_DV_KY_HAN"] = System.Convert.DBNull;
	}

	public decimal dcLAI_SUAT_DEFAULT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "LAI_SUAT_DEFAULT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["LAI_SUAT_DEFAULT"] = value;
		}
	}

	public bool IsLAI_SUAT_DEFAULTNull()	{
		return pm_objDR.IsNull("LAI_SUAT_DEFAULT");
	}

	public void SetLAI_SUAT_DEFAULTNull() {
		pm_objDR["LAI_SUAT_DEFAULT"] = System.Convert.DBNull;
	}

	public decimal dcKY_DIEU_CHINH_LS 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "KY_DIEU_CHINH_LS", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["KY_DIEU_CHINH_LS"] = value;
		}
	}

	public bool IsKY_DIEU_CHINH_LSNull()	{
		return pm_objDR.IsNull("KY_DIEU_CHINH_LS");
	}

	public void SetKY_DIEU_CHINH_LSNull() {
		pm_objDR["KY_DIEU_CHINH_LS"] = System.Convert.DBNull;
	}

	public decimal dcID_DV_DIEU_CHINH_LS 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DV_DIEU_CHINH_LS", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DV_DIEU_CHINH_LS"] = value;
		}
	}

	public bool IsID_DV_DIEU_CHINH_LSNull()	{
		return pm_objDR.IsNull("ID_DV_DIEU_CHINH_LS");
	}

	public void SetID_DV_DIEU_CHINH_LSNull() {
		pm_objDR["ID_DV_DIEU_CHINH_LS"] = System.Convert.DBNull;
	}

	public string strTHA_NOI_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "THA_NOI_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["THA_NOI_YN"] = value;
		}
	}

	public bool IsTHA_NOI_YNNull() 
	{
		return pm_objDR.IsNull("THA_NOI_YN");
	}

	public void SetTHA_NOI_YNNull() {
		pm_objDR["THA_NOI_YN"] = System.Convert.DBNull;
	}

	public decimal dcKY_TRA_LAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "KY_TRA_LAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["KY_TRA_LAI"] = value;
		}
	}

	public bool IsKY_TRA_LAINull()	{
		return pm_objDR.IsNull("KY_TRA_LAI");
	}

	public void SetKY_TRA_LAINull() {
		pm_objDR["KY_TRA_LAI"] = System.Convert.DBNull;
	}

	public decimal dcID_DV_KY_TRA_LAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DV_KY_TRA_LAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DV_KY_TRA_LAI"] = value;
		}
	}

	public bool IsID_DV_KY_TRA_LAINull()	{
		return pm_objDR.IsNull("ID_DV_KY_TRA_LAI");
	}

	public void SetID_DV_KY_TRA_LAINull() {
		pm_objDR["ID_DV_KY_TRA_LAI"] = System.Convert.DBNull;
	}

	public string strTRA_LAI_SAU_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRA_LAI_SAU_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRA_LAI_SAU_YN"] = value;
		}
	}

	public bool IsTRA_LAI_SAU_YNNull() 
	{
		return pm_objDR.IsNull("TRA_LAI_SAU_YN");
	}

	public void SetTRA_LAI_SAU_YNNull() {
		pm_objDR["TRA_LAI_SAU_YN"] = System.Convert.DBNull;
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

	public bool IsTONG_SL_PHAT_HANHNull()	{
		return pm_objDR.IsNull("TONG_SL_PHAT_HANH");
	}

	public void SetTONG_SL_PHAT_HANHNull() {
		pm_objDR["TONG_SL_PHAT_HANH"] = System.Convert.DBNull;
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

	public bool IsTONG_GIA_TRINull()	{
		return pm_objDR.IsNull("TONG_GIA_TRI");
	}

	public void SetTONG_GIA_TRINull() {
		pm_objDR["TONG_GIA_TRI"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_TRAI_PHIEU() 
	{
		pm_objDS = new DS_DM_TRAI_PHIEU();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_TRAI_PHIEU(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_TRAI_PHIEU(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_TRAI_PHIEU();
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
