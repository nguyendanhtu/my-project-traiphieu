///************************************************
/// Generated by: BINH
/// Date: 10/10/2012 04:36:07
/// Goal: Create User Service Class for GD_CHOT_LAI
///************************************************
/// <summary>
/// Create User Service Class for GD_CHOT_LAI
/// </summary>

namespace BondUS
{
using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;


public class US_GD_CHOT_LAI : US_Object
{
	private const string c_TableName = "GD_CHOT_LAI";
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

	public DateTime datNGAY_CHOT_LAI
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CHOT_LAI", IPConstants.c_DefaultDate);
		}
		set   
		{
            DateTime v_dt = value;
			pm_objDR["NGAY_CHOT_LAI"] = v_dt.Date;
		}
	}

	public bool IsNGAY_CHOT_LAINull()
	{
		return pm_objDR.IsNull("NGAY_CHOT_LAI");
	}

	public void SetNGAY_CHOT_LAINull()
	{
		pm_objDR["NGAY_CHOT_LAI"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_THANH_TOAN
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_THANH_TOAN", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_THANH_TOAN"] = value;
		}
	}

	public bool IsNGAY_THANH_TOANNull()
	{
		return pm_objDR.IsNull("NGAY_THANH_TOAN");
	}

	public void SetNGAY_THANH_TOANNull()
	{
		pm_objDR["NGAY_THANH_TOAN"] = System.Convert.DBNull;
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

	public decimal dcTRANG_THAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TRANG_THAI"] = value;
		}
	}

	public bool IsTRANG_THAINull()	{
		return pm_objDR.IsNull("TRANG_THAI");
	}

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
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

	public DateTime datNGAY_DAU_KY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_DAU_KY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_DAU_KY"] = value;
		}
	}

	public bool IsNGAY_DAU_KYNull()
	{
		return pm_objDR.IsNull("NGAY_DAU_KY");
	}

	public void SetNGAY_DAU_KYNull()
	{
		pm_objDR["NGAY_DAU_KY"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_CUOI_KY
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_CUOI_KY", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_CUOI_KY"] = value;
		}
	}

	public bool IsNGAY_CUOI_KYNull()
	{
		return pm_objDR.IsNull("NGAY_CUOI_KY");
	}

	public void SetNGAY_CUOI_KYNull()
	{
		pm_objDR["NGAY_CUOI_KY"] = System.Convert.DBNull;
	}

	public string strMUC_DICH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MUC_DICH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MUC_DICH"] = value;
		}
	}

	public bool IsMUC_DICHNull() 
	{
		return pm_objDR.IsNull("MUC_DICH");
	}

	public void SetMUC_DICHNull() {
		pm_objDR["MUC_DICH"] = System.Convert.DBNull;
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

	public decimal dcKY_TINH_LAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "KY_TINH_LAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["KY_TINH_LAI"] = value;
		}
	}

	public bool IsKY_TINH_LAINull()	{
		return pm_objDR.IsNull("KY_TINH_LAI");
	}

	public void SetKY_TINH_LAINull() {
		pm_objDR["KY_TINH_LAI"] = System.Convert.DBNull;
	}

    public DateTime datNGAY_THANH_TOAN_THUC_TE
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_THANH_TOAN_THUC_TE", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_THANH_TOAN_THUC_TE"] = value;
		}
	}

	public bool IsNGAY_THANH_TOAN_THUC_TENull()
	{
		return pm_objDR.IsNull("NGAY_THANH_TOAN_THUC_TE");
	}

	public void SetNGAY_THANH_TOAN_THUC_TENull()
	{
		pm_objDR["NGAY_THANH_TOAN_THUC_TE"] = System.Convert.DBNull;
	}

#endregion


#region Init Functions
	public US_GD_CHOT_LAI() 
	{
		pm_objDS = new DS_GD_CHOT_LAI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_CHOT_LAI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_CHOT_LAI(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_CHOT_LAI();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void load_data_by_search(DS_GD_CHOT_LAI op_ds_gd_chot_lai
                                  , string ip_str_keyword)
    {
        CStoredProc v_cstore = new CStoredProc("pr_GD_CHOT_LAI_Fill_By_Search");
        v_cstore.addNVarcharInputParam("@KEYWORD", ip_str_keyword);
        v_cstore.fillDataSetByCommand(this, op_ds_gd_chot_lai);
    }
    public void GenDSTraLai()
    {
        CStoredProc v_pr_obj = new CStoredProc("pr_GD_CHOT_LAI_Sinh_Gd_Chot_Lai_detail");
        v_pr_obj.addDecimalInputParam("@ID_GD_CHOT_LAI", this.dcID);
        v_pr_obj.ExecuteCommand(this);
    }
    public void fillDSChotLaiDetail(DS_GD_CHOT_LAI_DETAIL op_ds)
    {
        CStoredProc v_pr_obj = new CStoredProc("pr_GD_CHOT_LAI_DETAIL_SelectByIdChotLai");
        v_pr_obj.addDecimalInputParam("@ID_CHOT_LAI", this.dcID);
        v_pr_obj.fillDataSetByCommand(this, op_ds);
    }

    public void FillDSChotLaiByIDTraiPhieuAndNgayChotLai(DS_GD_CHOT_LAI ip_ds
        , decimal ip_id_trai_phieu
        , DateTime ip_ngay_chot_lai)
    {
        CStoredProc v_pr_obj = new CStoredProc("[pr_GD_CHOT_LAI_Select_ChotLaiByIDTraiPhieuAndNgayChotLai]");
        v_pr_obj.addDecimalInputParam("@ID_TRAI_PHIEU", ip_id_trai_phieu);
        v_pr_obj.addDatetimeInputParam("@NGAY_CHOT_LAI", ip_ngay_chot_lai);        
        v_pr_obj.fillDataSetByCommand(this, ip_ds);
    }
    public void FillDSChotLaiByIDTraiPhieuAndNgayThanhToan(DS_GD_CHOT_LAI ip_ds
       , decimal ip_id_trai_phieu
       , DateTime ip_ngay_chot_lai)
    {
        CStoredProc v_pr_obj = new CStoredProc("pr_GD_CHOT_LAI_DETAIL_Select_ChotLaiByIDTraiPhieuAndNgayThanhToan");
        v_pr_obj.addDecimalInputParam("@ID_TRAI_PHIEU", ip_id_trai_phieu);
        v_pr_obj.addDatetimeInputParam("@NGAY_THANH_TOAN", ip_ngay_chot_lai);
        v_pr_obj.fillDataSetByCommand(this, ip_ds);
    }

    public bool check_uk_chot_lai()
    {
        DS_GD_CHOT_LAI v_ds = new DS_GD_CHOT_LAI();
        CStoredProc v_pr_obj = new CStoredProc("pr_GD_CHOT_LAI_Select_ChotLaiByIDTraiPhieuAndNgayChotLai");
        v_pr_obj.addDecimalInputParam("@ID_TRAI_PHIEU", this.dcID_TRAI_PHIEU);
        v_pr_obj.addDatetimeInputParam("@NGAY_CHOT_LAI", this.datNGAY_CHOT_LAI);
        v_pr_obj.fillDataSetByCommand(this, v_ds);
        if (v_ds.GD_CHOT_LAI != null && v_ds.GD_CHOT_LAI.Count > 0)
            return true;
        else
            return false;
    }
}
}
