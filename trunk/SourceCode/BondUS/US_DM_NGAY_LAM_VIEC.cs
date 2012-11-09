///************************************************
/// Generated by: uyvq
/// Date: 08/09/2012 09:35:38
/// Goal: Create User Service Class for DM_NGAY_LAM_VIEC
///************************************************
/// <summary>
/// Create User Service Class for DM_NGAY_LAM_VIEC
/// </summary>


using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;
namespace BondUS
{

public class US_DM_NGAY_LAM_VIEC : US_Object
{
	private const string c_TableName = "DM_NGAY_LAM_VIEC";
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

	public string strNGAY_LAM_VIEC_YN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGAY_LAM_VIEC_YN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGAY_LAM_VIEC_YN"] = value;
		}
	}

	public bool IsNGAY_LAM_VIEC_YNNull() 
	{
		return pm_objDR.IsNull("NGAY_LAM_VIEC_YN");
	}

	public void SetNGAY_LAM_VIEC_YNNull() {
		pm_objDR["NGAY_LAM_VIEC_YN"] = System.Convert.DBNull;
	}

    public string strNGAY_LAM_VIEC_HAI_BAY_YN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGAY_LAM_VIEC_HAI_BAY_YN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGAY_LAM_VIEC_HAI_BAY_YN"] = value;
        }
    }

    public bool IsNGAY_LAM_VIEC_HAI_BAY_YNNull()
    {
        return pm_objDR.IsNull("NGAY_LAM_VIEC_HAI_BAY_YN");
    }

    public void SetNGAY_LAM_VIEC_HAI_BAY_YNNull()
    {
        pm_objDR["NGAY_LAM_VIEC_HAI_BAY_YN"] = System.Convert.DBNull;
    }

#endregion
#region "Init Functions"
	public US_DM_NGAY_LAM_VIEC() 
	{
		pm_objDS = new DS_DM_NGAY_LAM_VIEC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_NGAY_LAM_VIEC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_NGAY_LAM_VIEC(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_NGAY_LAM_VIEC();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetGetNgayThanhtoanThucTe(DS_DM_NGAY_LAM_VIEC ip_ds_dm_ng_lam_viec, DateTime ip_ngay_thanh_toan, decimal ip_so_ngay_truoc_thanh_toan, string ip_str_ngay_lam_viec_truoc_ngay_nghi_yn)
    {
        CStoredProc v_pr_obj = new CStoredProc("pr_DM_NGAY_LAM_VIEC_get_ngay_thanh_toan_thuc_te");
        v_pr_obj.addDatetimeInputParam("@NGAY_THANH_TOAN", ip_ngay_thanh_toan);
        v_pr_obj.addDecimalInputParam("@SO_NGAY_CHOT_LAI_TRUOC_THANH_TOAN", ip_so_ngay_truoc_thanh_toan);
        v_pr_obj.addNVarcharInputParam("@NGAY_LAM_VIEC_TRUOC_NGHI_YN", ip_str_ngay_lam_viec_truoc_ngay_nghi_yn);
        v_pr_obj.fillDataSetByCommand(this, ip_ds_dm_ng_lam_viec);
    }
}
}
