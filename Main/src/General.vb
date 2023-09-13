Imports System.Security.Principal
Imports System.Data.SqlClient

Module General

    Dim wp As New WindowsPrincipal(WindowsIdentity.GetCurrent())
    Public userName As String = Replace(wp.Identity.Name, "GEMC\", "")
    Public tmpPath As String = "\\prodstorage\temp\"
    Public StrServerName As String = ""
    Public StrServerNameIBM As String = ""
    Public StrDataBaseName As String = ""
    Public StrDataBaseNameIBM As String = ""
    Public StrDataBaseNameGMII_IMG As String = ""
    Public getConnStringMain As String = "" 'this connection string is used to call tables viefundapplication into GlobalDB to make connection change on one click.'
    Public getConnStrGMII_IMG As String = ""
    Public getConnStribm As String = ""
    Public getConnstr As String = ""
    Public isAdmin As Integer = 0
    Public canView As Integer = 0
    Public canBalance As Integer = 0
    Public canApprove As Integer = 0
    Public CanPost As Integer = 0

    Public Sub Main()
        Dim Start_Frm As New CommProcess
        '' MsgBox(userName)
        getConnStringMain = "user id=inf;data source=Proddb01;persist security info=False;initial catalog=Global DB;password=gemc"
        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Conn.ConnectionString = getConnStringMain
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.CommandText = "SELECT TOP (1)*  FROM [Global DB].[dbo].[ViefundAppConnection] where active=1"
        dr = sqlCmd.ExecuteReader
        Try
            dr.Read()
            StrServerName = dr.Item("VieFund_ServerName") '"10.0.10.4" ''"PRODDB02"
            StrServerNameIBM = dr.Item("IBM_ServerName")   '"10.0.10.92" ''"PRODDB01"'
            StrDataBaseName = dr.Item("VieFund_DBName") ' "VieFUND"'
            StrDataBaseNameIBM = dr.Item("IBM_DBName") ' "VieFUND"'
            StrDataBaseNameGMII_IMG = "GMII_IMG"
            dr.Close()
            
        
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



       
        getConnstr = "user id=inf;data source=" & StrServerName & ";persist security info=False;initial catalog=" & StrDataBaseName & ";password=gemc"
        getConnStrGMII_IMG = "user id=inf;data source=" & StrServerNameIBM & ";persist security info=False;initial catalog=" & StrDataBaseNameGMII_IMG & ";password=gemc"
        getConnStribm = "user id=inf;data source=" & StrServerNameIBM & ";persist security info=False;initial catalog=" & StrDataBaseName & ";password=gemc"
       '' MsgBox("Connset")
        Start_Frm.ShowDialog()
    End Sub

    Public Function useWebServiceSetUser(ByVal TargetPath As String) As String
        Dim myService As New storage.Service1
        TargetPath = TargetPath.Replace("\", "/")
        useWebServiceSetUser = myService.SetUser(TargetPath, userName, "gemc")
        If useWebServiceSetUser <> "0" Then
            MsgBox(useWebServiceSetUser)
        End If
    End Function

    Public Function useWebService(ByVal SourceParth As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String) As String
        Dim myService As New storage.Service1
        SourceParth = SourceParth.Replace("\", "/")
        TargetPath = TargetPath.Replace("\", "/")
        useWebService = myService.MoveFile(SourceParth, SourceFileName, TargetPath, TargetFileName, userName, "gemc")
        If useWebService <> "0" Then
            MsgBox(useWebService)
        End If
    End Function

End Module
