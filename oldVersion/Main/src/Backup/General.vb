Imports System.Security.Principal
Module General
    Dim wp As New WindowsPrincipal(WindowsIdentity.GetCurrent())
    Public userName As String = Replace(wp.Identity.Name, "GEMC\", "")
    Public tmpPath As String = "\\nasone\temp\"
    Public StrServerName As String = ""
    Public StrServerNameIBM As String = ""
    Public StrDataBaseName As String = ""
    Public StrDataBaseNameGMII_IMG As String = ""
    Public getConnStr As String = ""
    Public getConnStrGMII_IMG As String = ""
    Public isAdmin As Integer = 0
    Public canView As Integer = 0
    Public canBalance As Integer = 0
    Public canApprove As Integer = 0
    Public CanPost As Integer = 0

    Public Sub Main()
        Dim Start_Frm As New CommProcess
        '' MsgBox(userName)
        StrServerName = "MFSRV"
        StrServerNameIBM = "IBM"
        StrDataBaseName = "Winfundsql"
        StrDataBaseNameGMII_IMG = "GMII_IMG"
        getConnStr = "user id=inf;data source=" & StrServerName & ";persist security info=False;initial catalog=" & StrDataBaseName & ";password=gemc"
        getConnStrGMII_IMG = "user id=inf;data source=" & StrServerNameIBM & ";persist security info=False;initial catalog=" & StrDataBaseNameGMII_IMG & ";password=gemc"
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
