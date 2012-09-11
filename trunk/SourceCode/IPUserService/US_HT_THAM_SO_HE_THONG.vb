'************************************************
'* Generated by: CS
'* Date: 09/03/2004 03:28:28
'* Goal: Create User Service Class for HT_THAM_SO_HE_THONG
'************************************************

option Explicit On
option Strict On


Imports IP.Core.IPCommon
Imports IP.Core.IPUserService
Imports System.Data.SqlClient
Imports IP.Core.IPData

Public Class US_HT_THAM_SO_HE_THONG
	Inherits US_Object

	Private Const c_TableName as String = "HT_THAM_SO_HE_THONG"
#Region "Public Properties"
	Public Property dcID() As Decimal
		Get
			Return CNull.RowNVLDecimal(pm_objdr, "ID")
		End Get
		Set(ByVal Value As Decimal)
			pm_objDR.Item("ID") = Value
		End Set
	End Property

	Public Function IsIDNull() As Boolean
		Return pm_objDR.IsNull("ID")
	End Function

	Public Sub SetIDNull()
		pm_objDR("ID") = System.Convert.DBNull
	End Sub

	Public Property strLOAI_THAM_SO() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "LOAI_THAM_SO")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("LOAI_THAM_SO") = Value
		End Set
	End Property

	Public Function IsLOAI_THAM_SONull() As Boolean
		Return pm_objDR.IsNull("LOAI_THAM_SO")
	End Function

	Public Sub SetLOAI_THAM_SONull()
		pm_objDR("LOAI_THAM_SO") = System.Convert.DBNull
	End Sub

	Public Property strMA_THAM_SO() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "MA_THAM_SO")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("MA_THAM_SO") = Value
		End Set
	End Property

	Public Function IsMA_THAM_SONull() As Boolean
		Return pm_objDR.IsNull("MA_THAM_SO")
	End Function

	Public Sub SetMA_THAM_SONull()
		pm_objDR("MA_THAM_SO") = System.Convert.DBNull
	End Sub

	Public Property strPHAN_HE() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "PHAN_HE")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("PHAN_HE") = Value
		End Set
	End Property

	Public Function IsPHAN_HENull() As Boolean
		Return pm_objDR.IsNull("PHAN_HE")
	End Function

	Public Sub SetPHAN_HENull()
		pm_objDR("PHAN_HE") = System.Convert.DBNull
	End Sub

	Public Property strGHI_CHU() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "GHI_CHU")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("GHI_CHU") = Value
		End Set
	End Property

	Public Function IsGHI_CHUNull() As Boolean
		Return pm_objDR.IsNull("GHI_CHU")
	End Function

	Public Sub SetGHI_CHUNull()
		pm_objDR("GHI_CHU") = System.Convert.DBNull
	End Sub

	Public Property strKIEU_DU_LIEU() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "KIEU_DU_LIEU")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("KIEU_DU_LIEU") = Value
		End Set
	End Property

	Public Function IsKIEU_DU_LIEUNull() As Boolean
		Return pm_objDR.IsNull("KIEU_DU_LIEU")
	End Function

	Public Sub SetKIEU_DU_LIEUNull()
		pm_objDR("KIEU_DU_LIEU") = System.Convert.DBNull
	End Sub

	Public Property strGIA_TRI() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "GIA_TRI")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("GIA_TRI") = Value
		End Set
	End Property

	Public Function IsGIA_TRINull() As Boolean
		Return pm_objDR.IsNull("GIA_TRI")
	End Function

	Public Sub SetGIA_TRINull()
		pm_objDR("GIA_TRI") = System.Convert.DBNull
	End Sub

	Public Property strCO_THE_NULL_YN() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "CO_THE_NULL_YN")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("CO_THE_NULL_YN") = Value
		End Set
	End Property

	Public Function IsCO_THE_NULL_YNNull() As Boolean
		Return pm_objDR.IsNull("CO_THE_NULL_YN")
	End Function

	Public Sub SetCO_THE_NULL_YNNull()
		pm_objDR("CO_THE_NULL_YN") = System.Convert.DBNull
	End Sub

#End Region
#Region "Init Functions"
	Public Sub New()
		pm_objDS = New DS_HT_THAM_SO_HE_THONG()
		pm_strTableName = c_TableName
		pm_objDR = pm_objDS.Tables(pm_strTableName).NewRow()
	End Sub

	Public Sub New(ByVal i_objDR As DataRow)
		Me.New()
		Me.DataRow2Me(i_objDR)
	End Sub

	Public Sub New(ByVal i_dbID As Decimal)
		pm_objDS = New DS_HT_THAM_SO_HE_THONG()
		pm_strTableName = c_TableName
		Me.FillDataset(pm_objDS, "Where ID = " & Str(i_dbID))
		pm_objDR = getRowClone(pm_objds.Tables(pm_strTableName).Rows(0))
	End Sub
#End Region
End Class
