using System;
using System.Collections.Generic;
using System.Text;
using BondDS;

namespace BondDS.CDBNames
{
    public class LOAI_TD
    {
        public const decimal PHAN_QUYEN = 1;        
        public const decimal LOAI_TRAI_PHIEU = 2;
        public const decimal LOAI_TRAI_CHU = 3;
        public const decimal DON_VI_KY_HAN = 4;
        public const decimal LOAI_NHAC_NHAC_VIEC = 5;
        public const decimal TRANG_THAI_GD = 6;
        public const decimal NGAN_HANG_DL_QUAN_LY_TK = 7;
        public const decimal TRANG_THAI_DANH_MUC = 8;
        public const decimal LOAI_NGAY_LAM_VIEC = 9;
        public const decimal LOG_LOAI_HANH_DONG = 10;
        public const decimal TT_TRUOC_NGAY_LV_GAN_NHAT = 11;
        public const decimal NGAN_HANG_THAM_CHIEU_LAI_SUAT = 12;
    }
    public class GD_THONG_BAO_LAI_SUAT_IN_TIMES
    {
        public const string ID = "ID";
        public const string NGAY_DAU = "NGAY_DAU";
        public const string NGAY_KET_THUC = "NGAY_KET_THUC";
        public const string SO_NGAY_AP_DUNG = "SO_NGAY_AP_DUNG";
        public const string LAI_SUAT = "LAI_SUAT";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class LOG_DOI_TUONG_TAC_DONG
    {
        public const string DANG_NHAP_XUAT = "";
        public const string DM_TU_DIEN = "Danh mục từ điển";
        public const string DM_DOT_PHAT_HANH = "Danh mục đợt phát hành";
        public const string DM_NGAY_LAM_VIEC = "Danh mục ngày làm việc";
        public const string DM_THAM_SO_NHAC_VIEC = "Danh mục tham số nhắc việc";
        public const string DM_TO_CHUC_PHAT_HANH = "Danh mục tổ chức phát hành";
        public const string DM_TRAI_CHU = "Danh mục trái chủ";
        public const string DM_TRAI_PHIEU = "Danh mục trái phiếu";
        public const string GD_CHOT_LAI = "Giao dịch chốt lãi";
        public const string GD_CHOT_LAI_DETAIL = "Chi tiết giao dịch chốt lãi";
        public const string GD_CHUYEN_NHUONG = "Giao dịch chuyển nhượng";
        public const string GD_LICH_THANH_TOAN_LAI_GOC = "Giao dịch lịch thanh toán lãi gốc";
        public const string GD_NHAC_VIEC = "Giao dịch nhắc việc";
        public const string GD_PHONG_TOA = "Giao dịch phong tỏa";
        public const string GD_GIAI_TOA = "Giao dịch giải tỏa";
        public const string GD_SO_DU_TRAI_PHIEU = "Giao dịch số dư trái phiếu";
        public const string HT_NGUOI_SU_DUNG = "Người sử dụng";
        public const string HT_THAM_SO_HE_THONG = "Tham số hệ thống";
    }
    public class ID_THAM_SO_HE_THONG
    {
        public const decimal CHOT_LAI_TRUOC = 16;
    }
    public class ID_DON_VI_KY_HAN
    {
        public const decimal THANG = 18;
        public const decimal NAM = 19;
    }
    public class ID_LOAI_TRAI_PHIEU
    {
        public const decimal LS_THA_NOI= 24;
        public const decimal LS_CO_DINH= 25;
        public const decimal LS_BANG_0= 26;
    }
    public class GIOI_HAN_PHI_CHUYEN_NHUONG
    {
        public const decimal PHI_CN_MAX = 14;
        public const decimal PHI_CN_MIN = 15;        
    }
    public class GIOI_HAN_PHI_PGT
    {
        public const decimal ID_PHI_PGT_MAX = 12;
        public const decimal ID_PHI_PGT_MIN = 13;
    }
    public class TRANG_THAI_DANH_MUC
    {
        public const decimal DA_LAP = 60;
        public const decimal DA_DUYET = 61;
        public const decimal DA_DONG = 68;
    }
    public class List_trang_thai
    {
        public const decimal Da_Nhap = 21;
        public const decimal Da_Duyet = 22;
        public const decimal Da_Thuc_Hien = 23;
    }

    public class ID_LOAI_NHAC_VIEC
    {
        public const decimal THANH_TOAN_LAI = 27;
        public const decimal THANH_TOAN_GOC = 28;
        public const decimal CAP_NHAT_LAI_SUAT = 29;
        public const decimal GIAO_DICH_DA_THUC_HIEN = 30;
        public const decimal CHOT_DANH_SACH_LAI = 33;
    }
    public class ID_LOAI_TRAI_CHU
    {
        public const decimal CA_NHAN_TRONG_NUOC = 32;
        public const decimal TO_CHUC_TRONG_NUOC = 31;
        public const decimal CA_NHAN_NUOC_NGOAI = 40;
        public const decimal TO_CHUC_NUOC_NGOAI = 39;
    }
    public class LOG_TRUY_CAP
    {
        public const decimal DANG_NHAP = 69;
        public const decimal DANG_XUAT = 70;
        public const decimal THEM = 71;
        public const decimal SUA = 72;
        public const decimal XOA = 73;
        public const decimal DUYET = 74;
        public const decimal IMPORT = 80;
    }
    public class ID_TRANG_THAI_PGT
    {
        public const decimal DA_NHAP = 21;
        public const decimal DA_DUYET = 22;
        public const decimal DA_THUC_HIEN=23;
    }
    public class CM_DM_DS_LOAI_TU_DIEN
    {
        public const string TRANG_THAI_GD = "TRANG_THAI_GD";
        public const string LOAI_TRAI_CHU = "LOAI_TRAI_CHU";
        public const string TRANG_THAI_DANH_MUC = "TRANG_THAI_DANH_MUC";
        public const string LOAI_NHAC_NHAC_VIEC = "LOAI_NHAC_NHAC_VIEC";
        public const string TT_TRUOC_NGAY_LV_GAN_NHAT = "TT_TRUOC_NGAY_LV_GAN_NHAT";
        public const string LOG_LOAI_HANH_DONG = "LOG_LOAI_HANH_DONG";
    }
    public class GD_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string ID_LOAI_NHAC_VIEC = "ID_LOAI_NHAC_VIEC";
        public const string NGAY = "NGAY";
        public const string NOI_DUNG_NHAC = "NOI_DUNG_NHAC";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class V_GD_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string ID_LOAI_NHAC_VIEC = "ID_LOAI_NHAC_VIEC";
        public const string LOAI_NHAC_VIEC = "LOAI_NHAC_VIEC";
        public const string NGAY = "NGAY";
        public const string NOI_DUNG_NHAC = "NOI_DUNG_NHAC";
        public const string GHI_CHU = "GHI_CHU";
        public const string SO_NGAY_NHAC_TRUOC = "SO_NGAY_NHAC_TRUOC";
    }

    public class V_GD_TRA_GOC
    {
        public const string ID = "ID";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string DIA_CHI = "DIA_CHI";
        public const string MOBILE = "MOBILE";
        public const string FAX = "FAX";
        public const string CMT_GIAY_DKKD = "CMT_GIAY_DKKD";
        public const string NGAY_CAP_CMT = "NGAY_CAP_CMT";
        public const string NOI_CAP_CMT = "NOI_CAP_CMT";
        public const string ID_LOAI_TRAI_CHU = "ID_LOAI_TRAI_CHU";
        public const string ID_NGUOI_DUYET_TC = "ID_NGUOI_DUYET_TC";
        public const string ID_NGUOI_LAP_TC = "ID_NGUOI_LAP_TC";
        public const string ID_TRAI_PHIEU_SO_HUU = "ID_TRAI_PHIEU_SO_HUU";
        public const string MA_TRAI_PHIEU = "MA_TRAI_PHIEU";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string MENH_GIA = "MENH_GIA";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string GHI_CHU1 = "GHI_CHU1";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string GHI_CHU3 = "GHI_CHU3";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TONG_SO_DU = "TONG_SO_DU";
        public const string SO_DU_KHA_DUNG = "SO_DU_KHA_DUNG";
    }

    public class V_GD_CHUYEN_NHUONG
    {
        public const string ID = "ID";
        public const string MA_GIAO_DICH = "MA_GIAO_DICH";
        public const string NGAY_XAC_NHAN = "NGAY_XAC_NHAN";
        public const string NGAY_KY_CHUYEN_NHUONG = "NGAY_KY_CHUYEN_NHUONG";
        public const string NGAY_VAO_SO = "NGAY_VAO_SO";
        public const string ID_TRAI_CHU_MUA = "ID_TRAI_CHU_MUA";
        public const string tcm_MA_TRAI_CHU = "tcm_MA_TRAI_CHU";
        public const string tcm_TEN_TRAI_CHU = "tcm_TEN_TRAI_CHU";
        public const string tcm_DIA_CHI_TRAI_CHU = "tcm_DIA_CHI_TRAI_CHU";
        public const string tcm_MOBILE_TRAI_CHU = "tcm_MOBILE_TRAI_CHU";
        public const string tcm_FAX = "tcm_FAX";
        public const string tcm_CMT_GIAY_DKKD = "tcm_CMT_GIAY_DKKD";
        public const string tcm_NGAY_CAP_CMT = "tcm_NGAY_CAP_CMT";
        public const string tcm_NOI_CAP_CMT = "tcm_NOI_CAP_CMT";
        public const string tcm_ID_LOAI_TRAI_CHU = "tcm_ID_LOAI_TRAI_CHU";
        public const string tcm_TEN_LOAI_TRAI_CHU = "tcm_TEN_LOAI_TRAI_CHU";
        public const string tcm_SO_TAI_KHOAN = "tcm_SO_TAI_KHOAN";
        public const string tcm_MO_TAI_NGAN_HANG = "tcm_MO_TAI_NGAN_HANG";
        public const string tcm_GHI_CHU1 = "tcm_GHI_CHU1";
        public const string tcm_GHI_CHU2 = "tcm_GHI_CHU2";
        public const string tcm_GHI_CHU3 = "tcm_GHI_CHU3";
        public const string ID_TRAI_PHIEU_SO_HUU = "ID_TRAI_PHIEU_SO_HUU";
        public const string MA_TRAI_PHIEU = "MA_TRAI_PHIEU";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string ID_LOAI_TRAI_PHIEU = "ID_LOAI_TRAI_PHIEU";
        public const string MENH_GIA_TRAI_PHIEU = "MENH_GIA_TRAI_PHIEU";
        public const string GIA_TRI_CN_THEO_MENH_GIA = "GIA_TRI_CN_THEO_MENH_GIA";
        public const string GIA_TRI_CHUYEN_NHUONG_THUC_TE = "GIA_TRI_CHUYEN_NHUONG_THUC_TE";
        public const string KY_HAN_TRAI_PHIEU = "KY_HAN_TRAI_PHIEU";
        public const string ID_DV_KY_HAN = "ID_DV_KY_HAN";
        public const string CO_SO_TINH_LAI = "CO_SO_TINH_LAI";
        public const string LAI_SUAT_DEFAULT = "LAI_SUAT_DEFAULT";
        public const string KY_DIEU_CHINH_LS = "KY_DIEU_CHINH_LS";
        public const string ID_DV_DIEU_CHINH_LS = "ID_DV_DIEU_CHINH_LS";
        public const string THA_NOI_YN = "THA_NOI_YN";
        public const string KY_TRA_LAI = "KY_TRA_LAI";
        public const string ID_DV_KY_TRA_LAI = "ID_DV_KY_TRA_LAI";
        public const string TRA_LAI_SAU_YN = "TRA_LAI_SAU_YN";
        public const string NGAY_DAO_HAN = "NGAY_DAO_HAN";
        public const string TONG_SL_PHAT_HANH = "TONG_SL_PHAT_HANH";
        public const string TONG_GIA_TRI = "TONG_GIA_TRI";
        public const string tcm_ID_NGUOI_LAP = "tcm_ID_NGUOI_LAP";
        public const string tcm_ID_NGUOI_DUYET = "tcm_ID_NGUOI_DUYET";
        public const string tcm_ID_TRANG_THAI = "tcm_ID_TRANG_THAI";
        public const string ID_TRAI_CHU_BAN = "ID_TRAI_CHU_BAN";
        public const string tcb_MA_TRAI_CHU = "tcb_MA_TRAI_CHU";
        public const string tcb_TEN_TRAI_CHU = "tcb_TEN_TRAI_CHU";
        public const string tcb_DIA_CHI_TRAI_CHU = "tcb_DIA_CHI_TRAI_CHU";
        public const string tcb_MOBILE_TRAI_CHU = "tcb_MOBILE_TRAI_CHU";
        public const string tcb_FAX = "tcb_FAX";
        public const string tcb_CMT_GIAY_DKKD = "tcb_CMT_GIAY_DKKD";
        public const string tcb_NGAY_CAP_CMT = "tcb_NGAY_CAP_CMT";
        public const string tcb_NOI_CAP_CMT = "tcb_NOI_CAP_CMT";
        public const string tcb_ID_LOAI_TRAI_CHU = "tcb_ID_LOAI_TRAI_CHU";
        public const string tcb_TEN_LOAI_TRAI_CHU = "tcb_TEN_LOAI_TRAI_CHU";
        public const string tcb_SO_TAI_KHOAN = "tcb_SO_TAI_KHOAN";
        public const string tcb_MO_TAI_NGAN_HANG = "tcb_MO_TAI_NGAN_HANG";
        public const string tcb_GHI_CHU1 = "tcb_GHI_CHU1";
        public const string tcb_GHI_CHU2 = "tcb_GHI_CHU2";
        public const string tcb_GHI_CHU3 = "tcb_GHI_CHU3";
        public const string tcb_ID_NGUOI_LAP = "tcb_ID_NGUOI_LAP";
        public const string tcb_ID_NGUOI_DUYET = "tcb_ID_NGUOI_DUYET";
        public const string tcb_ID_TRANG_THAI = "tcb_ID_TRANG_THAI";
        public const string TEN_NGUOI_UY_QUYEN_MUA = "TEN_NGUOI_UY_QUYEN_MUA";
        public const string SO_CMT_NGUOI_MUA = "SO_CMT_NGUOI_MUA";
        public const string NGAY_CAP_CMT_NGUOI_MUA = "NGAY_CAP_CMT_NGUOI_MUA";
        public const string NOI_CAP_CMT_NGUOI_MUA = "NOI_CAP_CMT_NGUOI_MUA";
        public const string TEN_NGUOI_UY_QUYEN_BAN = "TEN_NGUOI_UY_QUYEN_BAN";
        public const string SO_CMT_NGUOI_BAN = "SO_CMT_NGUOI_BAN";
        public const string NGAY_CAP_CMT_NGUOI_BAN = "NGAY_CAP_CMT_NGUOI_BAN";
        public const string NOI_CAP_CMT_NGUOI_BAN = "NOI_CAP_CMT_NGUOI_BAN";
        public const string SO_LUONG_CHUYEN_NHUONG = "SO_LUONG_CHUYEN_NHUONG";
        public const string TY_LE_PHI_GD = "TY_LE_PHI_GD";
        public const string PHI_GD = "PHI_GD";
        public const string NOI_DUNG_GIAO_DICH = "NOI_DUNG_GIAO_DICH";
        public const string PHAN_TRAM_THUE = "PHAN_TRAM_THUE";
        public const string GIA_TRI_THUE = "GIA_TRI_THUE";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI_CHUYEN_NHUONG = "ID_TRANG_THAI_CHUYEN_NHUONG";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
    }

    public class V_DM_DOT_PHAT_HANH
    {
        public const string ID = "ID";
        public const string ID_TO_CHUC_PHAT_HANH = "ID_TO_CHUC_PHAT_HANH";
        public const string TEN_TO_CHUC_PHAT_HANH = "TEN_TO_CHUC_PHAT_HANH";
        public const string NGAY_PHAT_HANH = "NGAY_PHAT_HANH";
        public const string GHI_CHU = "GHI_CHU";
        public const string MENH_GIA = "MENH_GIA";
        public const string KY_TRA_LAI = "KY_TRA_LAI";
        public const string ID_DV_KY_TRA_LAI = "ID_DV_KY_TRA_LAI";
        public const string TONG_SO_LUONG_TRAI_PHIEU = "TONG_SO_LUONG_TRAI_PHIEU";
        public const string TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH = "TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH";
        public const string ID_NGAN_HANG_DAI_LY_QUAN_LY_TK = "ID_NGAN_HANG_DAI_LY_QUAN_LY_TK";
        public const string NGAN_HANG_DAI_LY_QUAN_LY_TK = "NGAN_HANG_DAI_LY_QUAN_LY_TK";
        public const string TY_LE_PHI_CHUYEN_NHUONG = "TY_LE_PHI_CHUYEN_NHUONG";
        public const string TY_LE_PHI_PHONG_GIAI_TOA = "TY_LE_PHI_PHONG_GIAI_TOA";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string NGUOI_DUYET = "NGUOI_DUYET";
        public const string NGAY_LAM_VIEC_HAI_SAU_YN = "NGAY_LAM_VIEC_HAI_SAU_YN";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string PHI_CHUYEN_NHUONG_MAX = "PHI_CHUYEN_NHUONG_MAX";
        public const string PHI_CHUYEN_NHUONG_MIN = "PHI_CHUYEN_NHUONG_MIN";
        public const string PHI_PHONG_GIAI_TOA_MAX = "PHI_PHONG_GIAI_TOA_MAX";
        public const string PHI_PHONG_GIAI_TOA_MIN = "PHI_PHONG_GIAI_TOA_MIN";
    }


    public class V_DM_TRAI_CHU_CHOT_LAI
    {
        public const string ID = "ID";
        public const string ID_CHOT_LAI = "ID_CHOT_LAI";
        public const string ID_TRAI_CHU = "ID_TRAI_CHU";
        public const string SO_LUONG_TINH_LAI = "SO_LUONG_TINH_LAI";
        public const string SO_TIEN_LAI = "SO_TIEN_LAI";
        public const string DA_NHAN_TIEN_YN = "DA_NHAN_TIEN_YN";
        public const string NGAY_NHAN_TIEN = "NGAY_NHAN_TIEN";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string DIA_CHI = "DIA_CHI";
        public const string MOBILE = "MOBILE";
        public const string FAX = "FAX";
        public const string CMT_GIAY_DKKD = "CMT_GIAY_DKKD";
        public const string NGAY_CAP_CMT = "NGAY_CAP_CMT";
        public const string NOI_CAP_CMT = "NOI_CAP_CMT";
        public const string ID_LOAI_TRAI_CHU = "ID_LOAI_TRAI_CHU";
        public const string ID_NGUOI_DUYET_TC = "ID_NGUOI_DUYET_TC";
        public const string ID_NGUOI_LAP_TC = "ID_NGUOI_LAP_TC";
        public const string ID_TRAI_PHIEU_SO_HUU = "ID_TRAI_PHIEU_SO_HUU";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string GHI_CHU1 = "GHI_CHU1";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string GHI_CHU3 = "GHI_CHU3";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string NGAY_CHOT_LAI = "NGAY_CHOT_LAI";
        public const string NGAY_THANH_TOAN = "NGAY_THANH_TOAN";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string KY_TINH_LAI = "KY_TINH_LAI";
        public const string TRANG_THAI_CHOT_LAI = "TRANG_THAI_CHOT_LAI";
        public const string MUC_DICH = "MUC_DICH";
        public const string GHI_CHU_CHOT_LAI = "GHI_CHU_CHOT_LAI";
        public const string ID_NGUOI_LAP_CHOT_LAI = "ID_NGUOI_LAP_CHOT_LAI";
        public const string ID_NGUOI_DUYET_CHOT_LAI = "ID_NGUOI_DUYET_CHOT_LAI";
        public const string TONG_SO_DU = "TONG_SO_DU";
        public const string SO_DU_KHA_DUNG = "SO_DU_KHA_DUNG";
    }
    public class DM_TRAI_CHU_IMP
    {
        public const string ID = "ID";
        public const string STT = "STT";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string LOAI_HINH_CO_CONG = "LOAI_HINH_CO_CONG";
        public const string DKHD_CMND = "DKHD_CMND";
        public const string NGAY_CAP = "NGAY_CAP";
        public const string NOI_CAP = "NOI_CAP";
        public const string QUOC_TICH = "QUOC_TICH";
        public const string DIA_CHI = "DIA_CHI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string EMAIL = "EMAIL";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string NOI_MO_TAI_KHOAN = "NOI_MO_TAI_KHOAN";
        public const string SO_LUONG_TRAI_PHIEU_SO_HUU = "SO_LUONG_TRAI_PHIEU_SO_HUU";
        public const string TEN_NGUOI_DAI_DIEN = "TEN_NGUOI_DAI_DIEN";
        public const string SO_CMND_NGUOI_DAI_DIEN = "SO_CMND_NGUOI_DAI_DIEN";
        public const string NGAY_CAP_CMND_NGUOI_DAI_DIEN = "NGAY_CAP_CMND_NGUOI_DAI_DIEN";
        public const string NOI_CAP_CMND_NGUOI_DAI_DIEN = "NOI_CAP_CMND_NGUOI_DAI_DIEN";
        public const string CHUC_VU_NGUOI_DAI_DIEN = "CHUC_VU_NGUOI_DAI_DIEN";
        public const string NGAY_BAT_DAU_SO_HUU_TP = "NGAY_BAT_DAU_SO_HUU_TP";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string DIEN_GIAI = "DIEN_GIAI";
    }
    public class DM_TRAI_CHU_TEMP
    {
        public const string ID = "ID";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string DIA_CHI = "DIA_CHI";
        public const string MOBILE = "MOBILE";
        public const string FAX = "FAX";
        public const string CMT_GIAY_DKKD = "CMT_GIAY_DKKD";
        public const string NGAY_CAP_CMT = "NGAY_CAP_CMT";
        public const string NOI_CAP_CMT = "NOI_CAP_CMT";
        public const string ID_LOAI_TRAI_CHU = "ID_LOAI_TRAI_CHU";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string GHI_CHU1 = "GHI_CHU1";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string GHI_CHU3 = "GHI_CHU3";
        public const string ID_TRAI_PHIEU_SO_HUU = "ID_TRAI_PHIEU_SO_HUU";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TEN_NGUOI_DAI_DIEN = "TEN_NGUOI_DAI_DIEN";
        public const string CMT_NGUOI_DAI_DIEN = "CMT_NGUOI_DAI_DIEN";
        public const string NGAY_CAP_CMT_NGUOI_DAI_DIEN = "NGAY_CAP_CMT_NGUOI_DAI_DIEN";
        public const string NOI_CAP_CMT_NGUOI_DAI_DIEN = "NOI_CAP_CMT_NGUOI_DAI_DIEN";
        public const string CHUC_VU = "CHUC_VU";
        public const string SO_LUONG_TRAI_PHIEU = "SO_LUONG_TRAI_PHIEU";
    }

    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }
    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class DM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string SHORT_NAME = "SHORT_NAME";
        public const string FULL_NAME = "FULL_NAME";
        public const string ADDRESS = "ADDRESS";
        public const string MOBLIE = "MOBLIE";
        public const string EMAIL = "EMAIL";
        public const string TAX_CODE = "TAX_CODE";
    }
    public class DM_NGAY_LAM_VIEC
    {
        public const string ID = "ID";
        public const string NGAY = "NGAY";
        public const string NGAY_LAM_VIEC_YN = "NGAY_LAM_VIEC_YN";
        public const string NGAY_LAM_VIEC_HAI_BAY_YN = "NGAY_LAM_VIEC_HAI_BAY_YN";
    }
    public class DM_THAM_SO_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string ID_LOAI_NHAC_VIEC = "ID_LOAI_NHAC_VIEC";
        public const string SO_NGAY_NHAC_TRUOC = "SO_NGAY_NHAC_TRUOC";
    }
    public class V_DM_THAM_SO_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string ID_LOAI_NHAC_VIEC = "ID_LOAI_NHAC_VIEC";
        public const string LOAI_NHAC_VIEC = "LOAI_NHAC_VIEC";
        public const string SO_NGAY_NHAC_TRUOC = "SO_NGAY_NHAC_TRUOC";
        public const string NGAY_LAM_VIEC_YN = "NGAY_LAM_VIEC_YN";
        public const string NOI_DUNG_NHAC = "NOI_DUNG_NHAC";
        public const string GHI_CHU = "GHI_CHU";
        public const string SO_NGAY_LAM_TRUOC_NGAY_CHINH = "SO_NGAY_LAM_TRUOC_NGAY_CHINH";
    }

    public class DM_TO_CHUC_PHAT_HANH
    {
        public const string ID = "ID";
        public const string MA_TO_CHUC_PHAT_HANH = "MA_TO_CHUC_PHAT_HANH";
        public const string TEN_TO_CHUC_PHAT_HANH = "TEN_TO_CHUC_PHAT_HANH";
        public const string DIA_CHI_TRU_SO_CHINH = "DIA_CHI_TRU_SO_CHINH";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string FAX = "FAX";
        public const string CHUNG_NHAN_DKDN = "CHUNG_NHAN_DKDN";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
    }
    public class V_DM_TO_CHUC_PHAT_HANH
    {
        public const string ID = "ID";
        public const string MA_TO_CHUC_PHAT_HANH = "MA_TO_CHUC_PHAT_HANH";
        public const string TEN_TO_CHUC_PHAT_HANH = "TEN_TO_CHUC_PHAT_HANH";
        public const string DIA_CHI_TRU_SO_CHINH = "DIA_CHI_TRU_SO_CHINH";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string FAX = "FAX";
        public const string CHUNG_NHAN_DKDN = "CHUNG_NHAN_DKDN";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string NGUOI_DUYET = "NGUOI_DUYET";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TRANG_THAI = "TRANG_THAI";
    }
    public class DM_TRAI_CHU
    {
        public const string ID = "ID";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string DIA_CHI = "DIA_CHI";
        public const string MOBILE = "MOBILE";
        public const string FAX = "FAX";
        public const string CMT_GIAY_DKKD = "CMT_GIAY_DKKD";
        public const string NGAY_CAP_CMT = "NGAY_CAP_CMT";
        public const string NOI_CAP_CMT = "NOI_CAP_CMT";
        public const string ID_LOAI_TRAI_CHU = "ID_LOAI_TRAI_CHU";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string GHI_CHU1 = "GHI_CHU1";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string GHI_CHU3 = "GHI_CHU3";
        public const string ID_TRAI_PHIEU_SO_HUU = "ID_TRAI_PHIEU_SO_HUU";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TEN_NGUOI_DAI_DIEN = "TEN_NGUOI_DAI_DIEN";
        public const string CMT_NGUOI_DAI_DIEN = "CMT_NGUOI_DAI_DIEN";
        public const string NGAY_CAP_CMT_NGUOI_DAI_DIEN = "NGAY_CAP_CMT_NGUOI_DAI_DIEN";
        public const string NOI_CAP_CMT_NGUOI_DAI_DIEN = "NOI_CAP_CMT_NGUOI_DAI_DIEN";
        public const string CHUC_VU = "CHUC_VU";
        public const string SO_LUONG_TP_SO_HUU_BAN_DAU = "SO_LUONG_TP_SO_HUU_BAN_DAU";
        public const string NGAY_DUYET = "NGAY_DUYET";
    }

    public class V_DM_TRAI_CHU
    {
        public const string ID = "ID";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string DIA_CHI = "DIA_CHI";
        public const string MOBILE = "MOBILE";
        public const string FAX = "FAX";
        public const string CMT_GIAY_DKKD = "CMT_GIAY_DKKD";
        public const string NGAY_CAP_CMT = "NGAY_CAP_CMT";
        public const string NOI_CAP_CMT = "NOI_CAP_CMT";
        public const string ID_LOAI_TRAI_CHU = "ID_LOAI_TRAI_CHU";
        public const string ID_TRAI_PHIEU_SO_HUU = "ID_TRAI_PHIEU_SO_HUU";
        public const string TEN_NGUOI_DAI_DIEN = "TEN_NGUOI_DAI_DIEN";
        public const string CMT_NGUOI_DAI_DIEN = "CMT_NGUOI_DAI_DIEN";
        public const string NGAY_CAP_CMT_NGUOI_DAI_DIEN = "NGAY_CAP_CMT_NGUOI_DAI_DIEN";
        public const string NOI_CAP_CMT_NGUOI_DAI_DIEN = "NOI_CAP_CMT_NGUOI_DAI_DIEN";
        public const string CHUC_VU = "CHUC_VU";
        public const string MA_TRAI_PHIEU = "MA_TRAI_PHIEU";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string MENH_GIA = "MENH_GIA";
        public const string TONG_SO_DU = "TONG_SO_DU";
        public const string SO_DU_KHA_DUNG = "SO_DU_KHA_DUNG";
        public const string SO_TAI_KHOAN = "SO_TAI_KHOAN";
        public const string MO_TAI_NGAN_HANG = "MO_TAI_NGAN_HANG";
        public const string GHI_CHU1 = "GHI_CHU1";
        public const string GHI_CHU2 = "GHI_CHU2";
        public const string GHI_CHU3 = "GHI_CHU3";
        public const string ID_NGUOI_DUYET_TC = "ID_NGUOI_DUYET_TC";
        public const string ID_NGUOI_LAP_TC = "ID_NGUOI_LAP_TC";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string SO_LUONG_TP_SO_HUU_BAN_DAU = "SO_LUONG_TP_SO_HUU_BAN_DAU";
        public const string NGAY_DUYET = "NGAY_DUYET";
        public const string NGAY_SO_HUU_TRAI_PHIEU = "NGAY_SO_HUU_TRAI_PHIEU";
    }

    public class DM_DOT_PHAT_HANH
    {
        public const string ID = "ID";
        public const string ID_TO_CHUC_PHAT_HANH = "ID_TO_CHUC_PHAT_HANH";
        public const string NGAY_PHAT_HANH = "NGAY_PHAT_HANH";
        public const string GHI_CHU = "GHI_CHU";
        public const string MENH_GIA = "MENH_GIA";
        public const string KY_TRA_LAI = "KY_TRA_LAI";
        public const string ID_DV_KY_TRA_LAI = "ID_DV_KY_TRA_LAI";
        public const string TONG_SO_LUONG_TRAI_PHIEU = "TONG_SO_LUONG_TRAI_PHIEU";
        public const string TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH = "TONG_GIA_TRI_TRAI_PHIEU_PHAT_HANH";
        public const string ID_NGAN_HANG_DAI_LY_QUAN_LY_TK = "ID_NGAN_HANG_DAI_LY_QUAN_LY_TK";
        public const string TY_LE_PHI_CHUYEN_NHUONG = "TY_LE_PHI_CHUYEN_NHUONG";
        public const string TY_LE_PHI_PHONG_GIAI_TOA = "TY_LE_PHI_PHONG_GIAI_TOA";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string NGAY_LAM_VIEC_HAI_SAU_YN = "NGAY_LAM_VIEC_HAI_SAU_YN";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string PHI_CHUYEN_NHUONG_MAX = "PHI_CHUYEN_NHUONG_MAX";
        public const string PHI_CHUYEN_NHUONG_MIN = "PHI_CHUYEN_NHUONG_MIN";
        public const string PHI_PHONG_GIAI_TOA_MAX = "PHI_PHONG_GIAI_TOA_MAX";
        public const string PHI_PHONG_GIAI_TOA_MIN = "PHI_PHONG_GIAI_TOA_MIN";
    }


    public class DM_TRAI_PHIEU
    {
         public const string ID =  "ID";
         public const string ID_DOT_PHAT_HANH =  "ID_DOT_PHAT_HANH";
        public const string MA_TRAI_PHIEU =  "MA_TRAI_PHIEU";
        public const string TEN_TRAI_PHIEU =  "TEN_TRAI_PHIEU";
           public const string ID_LOAI_TRAI_PHIEU =  "ID_LOAI_TRAI_PHIEU";
           public const string MENH_GIA =  "MENH_GIA";
           public const string KY_HAN =  "KY_HAN";
           public const string CO_SO_TINH_LAI =  "CO_SO_TINH_LAI";
           public const string ID_DV_KY_HAN =  "ID_DV_KY_HAN";
           public const string LAI_SUAT_DEFAULT =  "LAI_SUAT_DEFAULT";
           public const string KY_DIEU_CHINH_LS =  "KY_DIEU_CHINH_LS";
           public const string ID_DV_DIEU_CHINH_LS =  "ID_DV_DIEU_CHINH_LS";
           public const string THA_NOI_YN =  "THA_NOI_YN";
           public const string KY_TRA_LAI =  "KY_TRA_LAI";
           public const string ID_DV_KY_TRA_LAI =  "ID_DV_KY_TRA_LAI";
           public const string TRA_LAI_SAU_YN =  "TRA_LAI_SAU_YN";
           public const string NGAY_DAO_HAN =  "NGAY_DAO_HAN";
           public const string TONG_SL_PHAT_HANH =  "TONG_SL_PHAT_HANH";
           public const string TONG_GIA_TRI =  "TONG_GIA_TRI";
           public const string BIEN_DO_LAI =  "BIEN_DO_LAI";
           public const string SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC =  "SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC";
           public const string NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN =  "NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN";
           public const string NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN =  "NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN";
           public const string ID_NGUOI_LAP =  "ID_NGUOI_LAP";
           public const string ID_NGUOI_DUYET =  "ID_NGUOI_DUYET";
           public const string GHI_CHU_PHUONG_THUC_XD_LAI_SUAT =  "GHI_CHU_PHUONG_THUC_XD_LAI_SUAT";
           public const string CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN =  "CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN";
           public const string ID_TRANG_THAI =  "ID_TRANG_THAI";
           public const string SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN = "SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN";
           public const string THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN = "THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN";
    }


    public class V_DM_TRAI_PHIEU
    {
        public const string ID = "ID";
        public const string ID_DOT_PHAT_HANH = "ID_DOT_PHAT_HANH";
        public const string NGAY_PHAT_HANH = "NGAY_PHAT_HANH";
        public const string ID_TO_CHUC_PHAT_HANH = "ID_TO_CHUC_PHAT_HANH";
        public const string TEN_TO_CHUC_PHAT_HANH = "TEN_TO_CHUC_PHAT_HANH";
        public const string MA_TRAI_PHIEU = "MA_TRAI_PHIEU";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string ID_LOAI_TRAI_PHIEU = "ID_LOAI_TRAI_PHIEU";
        public const string LOAI_TRAI_PHIEU = "LOAI_TRAI_PHIEU";
        public const string MENH_GIA = "MENH_GIA";
        public const string KY_HAN = "KY_HAN";
        public const string ID_DV_KY_HAN = "ID_DV_KY_HAN";
        public const string DON_VI_KY_HAN = "DON_VI_KY_HAN";
        public const string CO_SO_TINH_LAI = "CO_SO_TINH_LAI";
        public const string LAI_SUAT_DEFAULT = "LAI_SUAT_DEFAULT";
        public const string KY_DIEU_CHINH_LS = "KY_DIEU_CHINH_LS";
        public const string ID_DV_DIEU_CHINH_LS = "ID_DV_DIEU_CHINH_LS";
        public const string DON_VI_DIEU_CHINH_LS = "DON_VI_DIEU_CHINH_LS";
        public const string THA_NOI_YN = "THA_NOI_YN";
        public const string KY_TRA_LAI = "KY_TRA_LAI";
        public const string ID_DV_KY_TRA_LAI = "ID_DV_KY_TRA_LAI";
        public const string DON_VI_KY_TRA_LAI = "DON_VI_KY_TRA_LAI";
        public const string TRA_LAI_SAU_YN = "TRA_LAI_SAU_YN";
        public const string NGAY_DAO_HAN = "NGAY_DAO_HAN";
        public const string TONG_SL_PHAT_HANH = "TONG_SL_PHAT_HANH";
        public const string TONG_GIA_TRI = "TONG_GIA_TRI";
        public const string BIEN_DO_LAI = "BIEN_DO_LAI";
        public const string SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC = "SO_NGAY_TCPH_CHUYEN_TIEN_TRUOC";
        public const string NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN = "NGUNG_CHUYEN_NHUONG_TU_NGAY_CHOT_YN";
        public const string NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN = "NGUNG_CHUYEN_NHUONG_DEN_NGAY_THANH_TOAN_YN";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string NGUOI_LAP = "NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string NGUOI_DUYET = "NGUOI_DUYET";
        public const string GHI_CHU_PHUONG_THUC_XD_LAI_SUAT = "GHI_CHU_PHUONG_THUC_XD_LAI_SUAT";
        public const string CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN = "CN_HUONG_THEO_NGAY_CHUYEN_NHUONG_YN";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string SO_HOP_DONG_DL_DK_LUU_KY = "SO_HOP_DONG_DL_DK_LUU_KY";
        public const string NGAY_KY_HD = "NGAY_KY_HD";
        public const string SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN = "SO_NGAY_CHOT_LAI_TRUOC_NGAY_THANH_TOAN";
        public const string THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN = "THANH_TOAN_TRUOC_NGAY_LAM_VIEC_GAN_NHAT_YN";
        public const string ID_NGAN_HANG_THAM_CHIEU_LAI_SUAT = "ID_NGAN_HANG_THAM_CHIEU_LAI_SUAT";
        public const string NGAN_HANG_THAM_CHIEU_LS = "NGAN_HANG_THAM_CHIEU_LS";
        public const string SO_TRAI_PHIEU_TRAI_CHU_DA_SO_HUU = "SO_TRAI_PHIEU_TRAI_CHU_DA_SO_HUU";
    }

    public class DOC_COLUMN_COMMENT
    {
        public const string COLUMN_NAME = "COLUMN_NAME";
        public const string TABLE_NAME = "TABLE_NAME";
        public const string COLUMN_COMMENT = "COLUMN_COMMENT";
    }
    public class DOC_TABLE_COMMENT
    {
        public const string TABLE_NAME = "TABLE_NAME";
        public const string TABLE_COMMENT = "TABLE_COMMENT";
    }
    public class GD_CHOT_LAI
    {
        public const string ID = "ID";
        public const string NGAY_CHOT_LAI = "NGAY_CHOT_LAI";
        public const string NGAY_THANH_TOAN = "NGAY_THANH_TOAN";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string NGAY_DAU_KY = "NGAY_DAU_KY";
        public const string NGAY_CUOI_KY = "NGAY_CUOI_KY";
        public const string MUC_DICH = "MUC_DICH";
        public const string GHI_CHU1 = "GHI_CHU1";
        public const string KY_TINH_LAI = "KY_TINH_LAI";
        public const string NGAY_THANH_TOAN_THUC_TE = "NGAY_THANH_TOAN_THUC_TE";
    }



    public class GD_CHOT_LAI_DETAIL
    {
        public const string ID = "ID";
        public const string ID_CHOT_LAI = "ID_CHOT_LAI";
        public const string ID_TRAI_CHU = "ID_TRAI_CHU";
        public const string SO_LUONG_TINH_LAI = "SO_LUONG_TINH_LAI";
        public const string SO_TIEN_LAI = "SO_TIEN_LAI";
        public const string DA_NHAN_TIEN_YN = "DA_NHAN_TIEN_YN";
        public const string NGAY_NHAN_TIEN = "NGAY_NHAN_TIEN";
    }
    public class GD_CHUYEN_NHUONG
    {
        public const string ID = "ID";
        public const string MA_GIAO_DICH = "MA_GIAO_DICH";
        public const string NGAY_XAC_NHAN = "NGAY_XAC_NHAN";
        public const string NGAY_KY_CHUYEN_NHUONG = "NGAY_KY_CHUYEN_NHUONG";
        public const string NGAY_VAO_SO = "NGAY_VAO_SO";
        public const string ID_TRAI_CHU_MUA = "ID_TRAI_CHU_MUA";
        public const string ID_TRAI_CHU_BAN = "ID_TRAI_CHU_BAN";
        public const string TEN_NGUOI_UY_QUYEN_MUA = "TEN_NGUOI_UY_QUYEN_MUA";
        public const string TEN_NGUOI_UY_QUYEN_BAN = "TEN_NGUOI_UY_QUYEN_BAN";
        public const string SO_CMT_NGUOI_MUA = "SO_CMT_NGUOI_MUA";
        public const string SO_CMT_NGUOI_BAN = "SO_CMT_NGUOI_BAN";
        public const string NGAY_CAP_CMT_NGUOI_MUA = "NGAY_CAP_CMT_NGUOI_MUA";
        public const string NGAY_CAP_CMT_NGUOI_BAN = "NGAY_CAP_CMT_NGUOI_BAN";
        public const string NOI_CAP_CMT_NGUOI_MUA = "NOI_CAP_CMT_NGUOI_MUA";
        public const string NOI_CAP_CMT_NGUOI_BAN = "NOI_CAP_CMT_NGUOI_BAN";
        public const string SO_LUONG_CHUYEN_NHUONG = "SO_LUONG_CHUYEN_NHUONG";
        public const string GIA_TRI_CHUYEN_NHUONG_THUC_TE = "GIA_TRI_CHUYEN_NHUONG_THUC_TE";
        public const string TY_LE_PHI_GD = "TY_LE_PHI_GD";
        public const string PHI_GD = "PHI_GD";
        public const string NOI_DUNG_GIAO_DICH = "NOI_DUNG_GIAO_DICH";
        public const string PHAN_TRAM_THUE = "PHAN_TRAM_THUE";
        public const string GIA_TRI_THUE = "GIA_TRI_THUE";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI_CHUYEN_NHUONG = "ID_TRANG_THAI_CHUYEN_NHUONG";
    }

    public class GD_LICH_THANH_TOAN_LAI_GOC
    {
        public const string ID = "ID";
        public const string ID_TRAI_PHIEU = "ID_TRAI_PHIEU";
        public const string NGAY = "NGAY";
        public const string CHOT_LAI_YN = "CHOT_LAI_YN";
        public const string CAP_NHAT_LS_YN = "CAP_NHAT_LS_YN";
        public const string THANH_TOAN_GOC_YN = "THANH_TOAN_GOC_YN";
        public const string THANH_TOAN_LAI_YN = "THANH_TOAN_LAI_YN";
        public const string DA_THUC_HIEN_YN = "DA_THUC_HIEN_YN";
        public const string LAI_SUAT = "LAI_SUAT";
        public const string GHI_CHU = "GHI_CHU";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string NGAY_BAT_DAU_AD_LS = "NGAY_BAT_DAU_AD_LS";
        public const string NGAY_DUYET = "NGAY_DUYET";
        public const string NGAY_KET_THUC_AD_LS = "NGAY_KET_THUC_AD_LS";
        public const string LAI_SUAT_THOA_THUAN_YN = "LAI_SUAT_THOA_THUAN_YN";
        public const string DA_DUYET_YN = "DA_DUYET_YN";
    }


    public class GD_PHONG_GIAI_TOA
    {
        public const string ID = "ID";
        public const string ID_TRAI_CHU = "ID_TRAI_CHU";
        public const string SO_LUONG = "SO_LUONG";
        public const string NGAY_GIAO_DICH = "NGAY_GIAO_DICH";
        public const string NGUOI_DAI_DIEN = "NGUOI_DAI_DIEN";
        public const string CHUC_DANH = "CHUC_DANH";
        public const string PHONG_TOA_YN = "PHONG_TOA_YN";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TY_LE_PHI_GD = "TY_LE_PHI_GD";
        public const string PHI_GIAO_DICH = "PHI_GIAO_DICH";
        public const string NGUOI_XAC_NHAN = "NGUOI_XAC_NHAN";
        public const string CHUC_VU = "CHUC_VU";
        public const string GIAY_UQ = "GIAY_UQ";
        public const string CUA = "CUA";
        public const string NGAY_CAP_GIAY_UQ = "NGAY_CAP_GIAY_UQ";
        public const string NDD_TRU_SO = "NDD_TRU_SO";
        public const string NDD_DIEN_THOAI = "NDD_DIEN_THOAI";
        public const string NDD_FAX = "NDD_FAX";
        public const string NGAN_HANG_CAM_CO = "NGAN_HANG_CAM_CO";
        public const string KHOAN_DAU_TU = "KHOAN_DAU_TU";
    }


    public class V_GD_PHONG_GIAI_TOA
    {
        public const string ID = "ID";
        public const string MA_GIAO_DICH = "MA_GIAO_DICH";
        public const string ID_TRAI_CHU = "ID_TRAI_CHU";
        public const string MA_TRAI_CHU = "MA_TRAI_CHU";
        public const string TEN_TRAI_CHU = "TEN_TRAI_CHU";
        public const string CMT_GIAY_DKKD = "CMT_GIAY_DKKD";
        public const string NGAY_CAP_CMT = "NGAY_CAP_CMT";
        public const string NOI_CAP_CMT = "NOI_CAP_CMT";
        public const string NGAY_GIAO_DICH = "NGAY_GIAO_DICH";
        public const string NGUOI_DAI_DIEN = "NGUOI_DAI_DIEN";
        public const string SO_LUONG = "SO_LUONG";
        public const string MENH_GIA = "MENH_GIA";
        public const string GIA_TRI_GD_THEO_MENH_GIA = "GIA_TRI_GD_THEO_MENH_GIA";
        public const string CHUC_DANH = "CHUC_DANH";
        public const string PHONG_TOA_YN = "PHONG_TOA_YN";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string NGUOI_THUC_HIEN = "NGUOI_THUC_HIEN";
        public const string ID_NGUOI_DUYET = "ID_NGUOI_DUYET";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string TY_LE_PHI_GD = "TY_LE_PHI_GD";
        public const string PHI_GIAO_DICH = "PHI_GIAO_DICH";
        public const string ID_TO_CHUC_PHAT_HANH = "ID_TO_CHUC_PHAT_HANH";
        public const string NGUOI_XAC_NHAN = "NGUOI_XAC_NHAN";
        public const string CHUC_VU = "CHUC_VU";
        public const string GIAY_UQ = "GIAY_UQ";
        public const string NGAY_CAP_GIAY_UQ = "NGAY_CAP_GIAY_UQ";
        public const string CUA = "CUA";
        public const string NDD_TRU_SO = "NDD_TRU_SO";
        public const string NDD_DIEN_THOAI = "NDD_DIEN_THOAI";
        public const string NDD_FAX = "NDD_FAX";
        public const string NGAN_HANG_CAM_CO = "NGAN_HANG_CAM_CO";
        public const string KHOAN_DAU_TU = "KHOAN_DAU_TU";
        public const string TONG_SO_DU = "TONG_SO_DU";
        public const string SO_DU_KHA_DUNG = "SO_DU_KHA_DUNG";
    }


    public class GD_SO_DU_TRAI_PHIEU
    {
        public const string ID = "ID";
        public const string ID_TRAI_CHU = "ID_TRAI_CHU";
        public const string NGAY = "NGAY";
        public const string TONG_SO_DU = "TONG_SO_DU";
        public const string SO_DU_KHA_DUNG = "SO_DU_KHA_DUNG";
    }
    public class HT_BACKUP_HISTORY
    {
        public const string ID = "ID";
        public const string NGUOI_BACKUP = "NGUOI_BACKUP";
        public const string NGAY_BACKUP = "NGAY_BACKUP";
        public const string NOI_LUU = "NOI_LUU";
        public const string TEN_FILE = "TEN_FILE";
        public const string GhI_CHU = "GhI_CHU";
    }
    public class HT_BUSINESS_PROCESS_LOCK
    {
        public const string LOCK_NAME = "LOCK_NAME";
        public const string GRANTED_SYS_DATETIME = "GRANTED_SYS_DATETIME";
    }
    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
    }
    public class HT_QUYEN_USER
    {
        public const string ID = "ID";
        public const string ID_USER = "ID_USER";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class HT_THAM_SO_HE_THONG
    {
        public const string ID = "ID";
        public const string LOAI_THAM_SO = "LOAI_THAM_SO";
        public const string MA_THAM_SO = "MA_THAM_SO";
        public const string PHAN_HE = "PHAN_HE";
        public const string GHI_CHU = "GHI_CHU";
        public const string KIEU_DU_LIEU = "KIEU_DU_LIEU";
        public const string GIA_TRI = "GIA_TRI";
        public const string CO_THE_NULL_YN = "CO_THE_NULL_YN";
    }
    public class RPT_NHAC_VIEC
    {
        public const string ID = "ID";
        public const string ID_NGUOI_XEM = "ID_NGUOI_XEM";
        public const string NGAY = "NGAY";
        public const string TEN_TRAI_PHIEU = "TEN_TRAI_PHIEU";
        public const string NOI_DUNG_NHAC = "NOI_DUNG_NHAC";
    }
    public class UT_SEQUENCES
    {
        public const string SEQ_NAME = "SEQ_NAME";
        public const string SEQ_VALUE = "SEQ_VALUE";
    }
    public class V_HT_LOG_TRUY_CAP
    {
        public const string ID = "ID";
        public const string ID_DANG_NHAP = "ID_DANG_NHAP";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string THOI_GIAN = "THOI_GIAN";
        public const string ID_LOAI_HANH_DONG = "ID_LOAI_HANH_DONG";
        public const string LOAI_HANH_DONG = "LOAI_HANH_DONG";
        public const string DOI_TUONG_THAO_TAC = "DOI_TUONG_THAO_TAC";
        public const string MO_TA = "MO_TA";
        public const string GHI_CHU = "GHI_CHU";
    }
}
