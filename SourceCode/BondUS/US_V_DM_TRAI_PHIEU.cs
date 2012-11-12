///************************************************
/// Generated by: HaiND
/// Date: 10/10/2012 08:44:32
/// Goal: Create User Service Class for V_DM_TRAI_PHIEU
///************************************************
/// <summary>
/// Create User Service Class for V_DM_TRAI_PHIEU
/// </summary>

using BondDS.CDBNames;
using BondDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using System;

public class US_V_DM_TRAI_PHIEU : US_Object
{
    private const string c_TableName = "V_DM_TRAI_PHIEU";
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

    public decimal dcID_DOT_PHAT_HANH
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_DOT_PHAT_HANH", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_DOT_PHAT_HANH"] = value;
        }
    }

    public bool IsID_DOT_PHAT_HANHNull()
    {
        return pm_objDR.IsNull("ID_DOT_PHAT_HANH");
    }

    public void SetID_DOT_PHAT_HANHNull()
    {
        pm_objDR["ID_DOT_PHAT_HANH"] = System.Convert.DBNull;
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

    public bool IsID_TO_CHUC_PHAT_HANHNull()
    {
        return pm_objDR.IsNull("ID_TO_CHUC_PHAT_HANH");
    }

    public void SetID_TO_CHUC_PHAT_HANHNull()
    {
        pm_objDR["ID_TO_CHUC_PHAT_HANH"] = System.Convert.DBNull;
    }

    public string strTEN_TO_CHUC_PHAT_HANH
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_TO_CHUC_PHAT_HANH", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_TO_CHUC_PHAT_HANH"] = value;
        }
    }

    public bool IsTEN_TO_CHUC_PHAT_HANHNull()
    {
        return pm_objDR.IsNull("TEN_TO_CHUC_PHAT_HANH");
    }

    public void SetTEN_TO_CHUC_PHAT_HANHNull()
    {
        pm_objDR["TEN_TO_CHUC_PHAT_HANH"] = System.Convert.DBNull;
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

    public void SetMA_TRAI_PHIEUNull()
    {
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

    public void SetTEN_TRAI_PHIEUNull()
    {
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

    public bool IsID_LOAI_TRAI_PHIEUNull()
    {
        return pm_objDR.IsNull("ID_LOAI_TRAI_PHIEU");
    }

    public void SetID_LOAI_TRAI_PHIEUNull()
    {
        pm_objDR["ID_LOAI_TRAI_PHIEU"] = System.Convert.DBNull;
    }

    public string strLOAI_TRAI_PHIEU
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "LOAI_TRAI_PHIEU", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["LOAI_TRAI_PHIEU"] = value;
        }
    }

    public bool IsLOAI_TRAI_PHIEUNull()
    {
        return pm_objDR.IsNull("LOAI_TRAI_PHIEU");
    }

    public void SetLOAI_TRAI_PHIEUNull()
    {
        pm_objDR["LOAI_TRAI_PHIEU"] = System.Convert.DBNull;
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

    public bool IsMENH_GIANull()
    {
        return pm_objDR.IsNull("MENH_GIA");
    }

    public void SetMENH_GIANull()
    {
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

    public bool IsKY_HANNull()
    {
        return pm_objDR.IsNull("KY_HAN");
    }

    public void SetKY_HANNull()
    {
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

    public bool IsID_DV_KY_HANNull()
    {
        return pm_objDR.IsNull("ID_DV_KY_HAN");
    }

    public void SetID_DV_KY_HANNull()
    {
        pm_objDR["ID_DV_KY_HAN"] = System.Convert.DBNull;
    }

    public string strDON_VI_KY_HAN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "DON_VI_KY_HAN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["DON_VI_KY_HAN"] = value;
        }
    }

    public bool IsDON_VI_KY_HANNull()
    {
        return pm_objDR.IsNull("DON_VI_KY_HAN");
    }

    public void SetDON_VI_KY_HANNull()
    {
        pm_objDR["DON_VI_KY_HAN"] = System.Convert.DBNull;
    }

    public string strCO_SO_TINH_LAI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "CO_SO_TINH_LAI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["CO_SO_TINH_LAI"] = value;
        }
    }

    public bool IsCO_SO_TINH_LAINull()
    {
        return pm_objDR.IsNull("CO_SO_TINH_LAI");
    }

    public void SetCO_SO_TINH_LAINull()
    {
        pm_objDR["CO_SO_TINH_LAI"] = System.Convert.DBNull;
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

    public bool IsLAI_SUAT_DEFAULTNull()
    {
        return pm_objDR.IsNull("LAI_SUAT_DEFAULT");
    }

    public void SetLAI_SUAT_DEFAULTNull()
    {
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

    public bool IsKY_DIEU_CHINH_LSNull()
    {
        return pm_objDR.IsNull("KY_DIEU_CHINH_LS");
    }

    public void SetKY_DIEU_CHINH_LSNull()
    {
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

    public bool IsID_DV_DIEU_CHINH_LSNull()
    {
        return pm_objDR.IsNull("ID_DV_DIEU_CHINH_LS");
    }

    public void SetID_DV_DIEU_CHINH_LSNull()
    {
        pm_objDR["ID_DV_DIEU_CHINH_LS"] = System.Convert.DBNull;
    }

    public string strDON_VI_DIEU_CHINH_LS
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "DON_VI_DIEU_CHINH_LS", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["DON_VI_DIEU_CHINH_LS"] = value;
        }
    }

    public bool IsDON_VI_DIEU_CHINH_LSNull()
    {
        return pm_objDR.IsNull("DON_VI_DIEU_CHINH_LS");
    }

    public void SetDON_VI_DIEU_CHINH_LSNull()
    {
        pm_objDR["DON_VI_DIEU_CHINH_LS"] = System.Convert.DBNull;
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

    public void SetTHA_NOI_YNNull()
    {
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

    public bool IsKY_TRA_LAINull()
    {
        return pm_objDR.IsNull("KY_TRA_LAI");
    }

    public void SetKY_TRA_LAINull()
    {
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

    public bool IsID_DV_KY_TRA_LAINull()
    {
        return pm_objDR.IsNull("ID_DV_KY_TRA_LAI");
    }

    public void SetID_DV_KY_TRA_LAINull()
    {
        pm_objDR["ID_DV_KY_TRA_LAI"] = System.Convert.DBNull;
    }

    public string strDON_VI_KY_TRA_LAI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "DON_VI_KY_TRA_LAI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["DON_VI_KY_TRA_LAI"] = value;
        }
    }

    public bool IsDON_VI_KY_TRA_LAINull()
    {
        return pm_objDR.IsNull("DON_VI_KY_TRA_LAI");
    }

    public void SetDON_VI_KY_TRA_LAINull()
    {
        pm_objDR["DON_VI_KY_TRA_LAI"] = System.Convert.DBNull;
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

    public void SetTRA_LAI_SAU_YNNull()
    {
        pm_objDR["TRA_LAI_SAU_YN"] = System.Convert.DBNull;
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

    public bool IsTONG_SL_PHAT_HANHNull()
    {
        return pm_objDR.IsNull("TONG_SL_PHAT_HANH");
    }

    public void SetTONG_SL_PHAT_HANHNull()
    {
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

    public bool IsTONG_GIA_TRINull()
    {
        return pm_objDR.IsNull("TONG_GIA_TRI");
    }

    public void SetTONG_GIA_TRINull()
    {
        pm_objDR["TONG_GIA_TRI"] = System.Convert.DBNull;
    }

    public decimal dcBIEN_DO_LAI
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "BIEN_DO_LAI", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["BIEN_DO_LAI"] = value;
        }
    }

    public bool IsBIEN_DO_LAINull()
    {
        return pm_objDR.IsNull("BIEN_DO_LAI");
    }

    public void SetBIEN_DO_LAINull()
    {
        pm_objDR["BIEN_DO_LAI"] = System.Convert.DBNull;
    }

    public decimal dcSO_NGAY_TCPH_CHUYEN_TIEN_TRUOC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC"] = value;
        }
    }

    public bool IsSO_NGAY_TCPH_CHUYEN_TIEN_TRUOCNull()
    {
        return pm_objDR.IsNull("SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC");
    }

    public void SetSO_NGAY_TCPH_CHUYEN_TIEN_TRUOCNull()
    {
        pm_objDR["SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC"] = System.Convert.DBNull;
    }

    public string strNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN"] = value;
        }
    }

    public bool IsNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YNNull()
    {
        return pm_objDR.IsNull("NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN");
    }

    public void SetNGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YNNull()
    {
        pm_objDR["NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN"] = System.Convert.DBNull;
    }

    public string strNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN"] = value;
        }
    }

    public bool IsNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YNNull()
    {
        return pm_objDR.IsNull("NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN");
    }

    public void SetNGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YNNull()
    {
        pm_objDR["NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN"] = System.Convert.DBNull;
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

    public bool IsID_NGUOI_LAPNull()
    {
        return pm_objDR.IsNull("ID_NGUOI_LAP");
    }

    public void SetID_NGUOI_LAPNull()
    {
        pm_objDR["ID_NGUOI_LAP"] = System.Convert.DBNull;
    }

    public string strNGUOI_LAP
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUOI_LAP", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUOI_LAP"] = value;
        }
    }

    public bool IsNGUOI_LAPNull()
    {
        return pm_objDR.IsNull("NGUOI_LAP");
    }

    public void SetNGUOI_LAPNull()
    {
        pm_objDR["NGUOI_LAP"] = System.Convert.DBNull;
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

    public bool IsID_NGUOI_DUYETNull()
    {
        return pm_objDR.IsNull("ID_NGUOI_DUYET");
    }

    public void SetID_NGUOI_DUYETNull()
    {
        pm_objDR["ID_NGUOI_DUYET"] = System.Convert.DBNull;
    }

    public string strNGUOI_DUYET
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGUOI_DUYET", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGUOI_DUYET"] = value;
        }
    }

    public bool IsNGUOI_DUYETNull()
    {
        return pm_objDR.IsNull("NGUOI_DUYET");
    }

    public void SetNGUOI_DUYETNull()
    {
        pm_objDR["NGUOI_DUYET"] = System.Convert.DBNull;
    }

    public string strGHI_CHU_PHUONG_THUC_XD_LAI_SUAT
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "GHI_CHU_PHUONG_THUC_XD_LAI_SUAT", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["GHI_CHU_PHUONG_THUC_XD_LAI_SUAT"] = value;
        }
    }

    public bool IsGHI_CHU_PHUONG_THUC_XD_LAI_SUATNull()
    {
        return pm_objDR.IsNull("GHI_CHU_PHUONG_THUC_XD_LAI_SUAT");
    }

    public void SetGHI_CHU_PHUONG_THUC_XD_LAI_SUATNull()
    {
        pm_objDR["GHI_CHU_PHUONG_THUC_XD_LAI_SUAT"] = System.Convert.DBNull;
    }

    public string strCN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN"] = value;
        }
    }

    public bool IsCN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YNNull()
    {
        return pm_objDR.IsNull("CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN");
    }

    public void SetCN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YNNull()
    {
        pm_objDR["CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN"] = System.Convert.DBNull;
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

    public bool IsID_TRANG_THAINull()
    {
        return pm_objDR.IsNull("ID_TRANG_THAI");
    }

    public void SetID_TRANG_THAINull()
    {
        pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
    }

    public string strTRANG_THAI
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TRANG_THAI"] = value;
        }
    }

    public bool IsTRANG_THAINull()
    {
        return pm_objDR.IsNull("TRANG_THAI");
    }

    public void SetTRANG_THAINull()
    {
        pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
    }

    public string strSO_HOP_DONG_DL_DK_LUU_KY
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "SO_HOP_DONG_DL_DK_LUU_KY", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["SO_HOP_DONG_DL_DK_LUU_KY"] = value;
        }
    }

    public bool IsSO_HOP_DONG_DL_DK_LUU_KYNull()
    {
        return pm_objDR.IsNull("SO_HOP_DONG_DL_DK_LUU_KY");
    }

    public void SetSO_HOP_DONG_DL_DK_LUU_KYNull()
    {
        pm_objDR["SO_HOP_DONG_DL_DK_LUU_KY"] = System.Convert.DBNull;
    }

    public DateTime datNGAY_KY_HD
    {
        get
        {
            return CNull.RowNVLDate(pm_objDR, "NGAY_KY_HD", IPConstants.c_DefaultDate);
        }
        set
        {
            pm_objDR["NGAY_KY_HD"] = value;
        }
    }

    public bool IsNGAY_KY_HDNull()
    {
        return pm_objDR.IsNull("NGAY_KY_HD");
    }

    public void SetNGAY_KY_HDNull()
    {
        pm_objDR["NGAY_KY_HD"] = System.Convert.DBNull;
    }

    public decimal dcSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN"] = value;
        }
    }

    public bool IsSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOANNull()
    {
        return pm_objDR.IsNull("SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN");
    }

    public void SetSO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOANNull()
    {
        pm_objDR["SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN"] = System.Convert.DBNull;
    }

    public string strTHANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN"] = value;
        }
    }

    public bool IsTHANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YNNull()
    {
        return pm_objDR.IsNull("THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN");
    }

    public void SetTHANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YNNull()
    {
        pm_objDR["THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN"] = System.Convert.DBNull;
    }

    public decimal dcID_NGAN_HANG_THAM_CHIEU_LAI_SUAT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NGAN_HANG_THAM_CHIEU_LAI_SUAT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NGAN_HANG_THAM_CHIEU_LAI_SUAT"] = value;
        }
    }

    public bool IsID_NGAN_HANG_THAM_CHIEU_LAI_SUATNull()
    {
        return pm_objDR.IsNull("ID_NGAN_HANG_THAM_CHIEU_LAI_SUAT");
    }

    public void SetID_NGAN_HANG_THAM_CHIEU_LAI_SUATNull()
    {
        pm_objDR["ID_NGAN_HANG_THAM_CHIEU_LAI_SUAT"] = System.Convert.DBNull;
    }

    public string strNGAN_HANG_THAM_CHIEU_LS
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "NGAN_HANG_THAM_CHIEU_LS", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["NGAN_HANG_THAM_CHIEU_LS"] = value;
        }
    }

    public bool IsNGAN_HANG_THAM_CHIEU_LSNull()
    {
        return pm_objDR.IsNull("NGAN_HANG_THAM_CHIEU_LS");
    }

    public void SetNGAN_HANG_THAM_CHIEU_LSNull()
    {
        pm_objDR["NGAN_HANG_THAM_CHIEU_LS"] = System.Convert.DBNull;
    }
    #endregion


    #region Init Functions
    public US_V_DM_TRAI_PHIEU()
    {
        pm_objDS = new DS_V_DM_TRAI_PHIEU();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_DM_TRAI_PHIEU(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_DM_TRAI_PHIEU(decimal i_dbID)
    {
        pm_objDS = new DS_V_DM_TRAI_PHIEU();
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
    public void load_data_by_search(DS_V_DM_TRAI_PHIEU op_ds_dm_trai_phieu
                                   , string ip_str_keyword)
    {
        CStoredProc v_cstore = new CStoredProc("pr_DM_TRAI_PHIEU_Fill_By_Search");
        v_cstore.addNVarcharInputParam("@KEYWORD", ip_str_keyword);
        v_cstore.fillDataSetByCommand(this, op_ds_dm_trai_phieu);
    }
    public void FillDatasetByIDDotPhatHanh(DS_V_DM_TRAI_PHIEU ip_ds_dm_trai_phieu, decimal ip_id_dot_ph)
    {
        CMakeAndSelectCmd v_obj_mak_cmd = new CMakeAndSelectCmd(ip_ds_dm_trai_phieu, c_TableName);
        v_obj_mak_cmd.AddCondition(V_DM_TRAI_PHIEU.ID_DOT_PHAT_HANH
            , ip_id_dot_ph
            , eKieuDuLieu.KieuNumber
            , eKieuSoSanh.Bang);
        SqlCommand v_obj_cmd = v_obj_mak_cmd.getSelectCmd();

        this.FillDatasetByCommand(ip_ds_dm_trai_phieu, v_obj_cmd);

    }
    #endregion
}
