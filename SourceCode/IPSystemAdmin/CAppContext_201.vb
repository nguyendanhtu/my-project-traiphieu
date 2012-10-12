Option Explicit On 
Option Strict On

Imports IP.Core.IPCommon
Imports IP.Core.IPUserService
'Imports eSchool.eSchoolData
'Imports eSchool.eSchoolUserService

#Region "Nhiệm vụ của Class"
'************************************************************************
'* Phục vụ lấy dữ liệu đặc trưng cho ứng dụng
'*
'************************************************************************
#End Region

Public Class CAppContext_201

#Region "Variables"
    Private Shared m_us_user As US_HT_NGUOI_SU_DUNG
    Private Shared m_strRunMode As String
#End Region

#Region "Public interface"
    Public Shared Function IsHavingQuyen(ByVal i_str_ma_quyen As String) As Boolean
        Return US_HT_NGUOI_SU_DUNG.IsHavingMA_QUYEN( _
           CAppContext_201.getCurrentUserID() _
           , i_str_ma_quyen)

    End Function

    Public Shared Sub InitializeContext(ByVal i_LoginInfo As CLoginInformation_302)
        '*****************************************************************
        '* Init context 
        '* 1. các giá trị thường dùng trong hệ thống
        '* 2. load phân quyền hệ thống về 
        '* 3. Các biến môi trường khác
        '****************************************************************
        '* 1. các giá trị thường dùng trong hệ thống
        '        Debug.Assert(m_strCurrentUserName <> "")
        Try

            m_us_user = i_LoginInfo.m_us_user
            '* 2. load phân quyền hệ thống về 
            '* 3. Các biến môi trường khác
            Dim v_configReader As New System.Configuration.AppSettingsReader
            m_strRunMode = v_configReader.GetValue("RUN_MODE", IPConstants.C_StringType).ToString()
            v_configReader = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function getCurentDate() As DateTime
        '*****************************************************************
        '*  Gọi để lấy ngày hiện tại
        '***********************************************************************
        Return System.DateTime.Now.Date
    End Function

    Public Shared Function getCurrentUser() As String
        Return m_us_user.strTEN
    End Function

    Public Shared Function getCurrentUserID() As Decimal
        Return m_us_user.dcID
    End Function

    Public Shared Function getRunMode() As String
        Return m_strRunMode
    End Function

    Public Shared Function getAppPath() As String
        Return AppDomain.CurrentDomain.SetupInformation.ApplicationBase
    End Function

    Public Shared Function get_DefaultReportRootPath() As String
        Dim v_strRootPath As String
        v_strRootPath = Application.StartupPath
        'v_strRootPath += "\..\.."
        v_strRootPath += "\Reports"
        Return v_strRootPath
    End Function

    Public Shared Function checkLicense() As Boolean

    End Function
#End Region

End Class
Public Class PHAN_QUYEN
    Public Const GIOI_THIEU As String = "Q00"
    Public Const BACK_UP_AND_RESTORE As String = "Q01"
    Public Const QUAN_LY_NGUOI_DUNG As String = "Q02"
    Public Const QUAN_LY_LICH_LAM_VIEC As String = "Q03"
    Public Const QUAN_LY_TU_DIEN As String = "Q04"
    Public Const QUAN_LY_LOAI_TU_DIEN As String = "Q05"

    Public Const DM_TO_CHUC_PHAT_HANH As String = "Q06"
    Public Const DM_TRAI_PHIEU As String = "Q07"
    Public Const DM_TRAI_CHU As String = "Q08"
    Public Const DM_DOT_CHOT_LAI As String = "Q09"
    Public Const DM_DOT_PHAT_HANH As String = "Q10"

    Public Const DANH_SACH_CHUYEN_NHUONG As String = "Q11"
    Public Const GIAO_DICH_CHUYEN_NHUONG As String = "Q12"

    Public Const LAP_PHONG_TOA As String = "Q13"
    Public Const DUYET_PHONG_TOA As String = "Q14"
    Public Const DANH_SACH_PHONG_TOA As String = "Q15"

    Public Const LAP_GIAI_TOA As String = "Q16"
    Public Const DUYET_GIAI_TOA As String = "Q17"
    Public Const DANH_SACH_GIAI_TOA As String = "Q20"

    Public Const QUAN_LY_THAM_SO_HE_THONG As String = "Q18"
    Public Const QUAN_LY_THAM_SO_NHAC_VIEC As String = "Q19"

    Public Const IMPORT_TRAI_CHU As String = "Q21"
    Public Const LAP_LICH_THANH_TOAN_LAI_GOC As String = "Q22"
    Public Const CAP_NHAT_LS_THA_NOI As String = "Q23"
    Public Const LAP_DS_CHOT_LAI As String = "Q24"
    Public Const TRA_LAI As String = "Q25"
    Public Const TRA_GOC As String = "Q26"

    Public Const THONG_BAO_LAI_SUAT As String = "Q27"
    Public Const THONG_BAO_NGAY_CHOT_TIEN_LAI As String = "Q28"
    Public Const THONG_BAO_THANH_TOAN_LAI_TRAI_PHIEU As String = "Q29"
    Public Const DE_XUAT_KY_TRA_LAI_TIEP_THEO As String = "Q30"
    Public Const DANH_SACH_TRA_LAI As String = "Q31"
    Public Const YEU_CAU_TCPH_TRA_LAI_SUAT As String = "Q32"
    Public Const BAO_CAO_LS_TRAI_PHIEU As String = "Q33"
    Public Const BAO_CAO_IN_SO_SO_HUU As String = "Q34"
    Public Const BAO_CAO_CHUYEN_NHUONG As String = "Q35"
End Class
