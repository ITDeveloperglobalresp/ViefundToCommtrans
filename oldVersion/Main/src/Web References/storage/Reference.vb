﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace storage
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="Service1Soap", [Namespace]:="http://tempuri.org/")> _
    Partial Public Class Service1
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private MoveFileOperationCompleted As System.Threading.SendOrPostCallback

        Private MoveandDeleteFileOperationCompleted As System.Threading.SendOrPostCallback

        Private GetFaxestoProcessOperationCompleted As System.Threading.SendOrPostCallback

        Private GetFaxestoProcess_CSOperationCompleted As System.Threading.SendOrPostCallback

        Private SetUserOperationCompleted As System.Threading.SendOrPostCallback

        Private SetUserFolderOperationCompleted As System.Threading.SendOrPostCallback

        Private SendEmailOperationCompleted As System.Threading.SendOrPostCallback

        Private useDefaultCredentialsSetExplicitly As Boolean

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = Global.ViefundCommProcess.My.MySettings.Default.ViefundCommProcess_storage_Service1
            If (Me.IsLocalFileSystemWebService(Me.Url) = True) Then
                Me.UseDefaultCredentials = True
                Me.useDefaultCredentialsSetExplicitly = False
            Else
                Me.useDefaultCredentialsSetExplicitly = True
            End If
        End Sub

        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set(value As String)
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) _
                            AndAlso (Me.IsLocalFileSystemWebService(Value) = False)) Then
                    MyBase.UseDefaultCredentials = False
                End If
                MyBase.Url = Value
            End Set
        End Property

        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set(value As Boolean)
                MyBase.UseDefaultCredentials = Value
                Me.useDefaultCredentialsSetExplicitly = True
            End Set
        End Property

        '''<remarks/>
        Public Event MoveFileCompleted As MoveFileCompletedEventHandler

        '''<remarks/>
        Public Event MoveandDeleteFileCompleted As MoveandDeleteFileCompletedEventHandler

        '''<remarks/>
        Public Event GetFaxestoProcessCompleted As GetFaxestoProcessCompletedEventHandler

        '''<remarks/>
        Public Event GetFaxestoProcess_CSCompleted As GetFaxestoProcess_CSCompletedEventHandler

        '''<remarks/>
        Public Event SetUserCompleted As SetUserCompletedEventHandler

        '''<remarks/>
        Public Event SetUserFolderCompleted As SetUserFolderCompletedEventHandler

        '''<remarks/>
        Public Event SendEmailCompleted As SendEmailCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MoveFile", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function MoveFile(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String) As String
            Dim results() As Object = Me.Invoke("MoveFile", New Object() {SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginMoveFile(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("MoveFile", New Object() {SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndMoveFile(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub MoveFileAsync(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String)
            Me.MoveFileAsync(SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub MoveFileAsync(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String, ByVal userState As Object)
            If (Me.MoveFileOperationCompleted Is Nothing) Then
                Me.MoveFileOperationCompleted = AddressOf Me.OnMoveFileOperationCompleted
            End If
            Me.InvokeAsync("MoveFile", New Object() {SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID}, Me.MoveFileOperationCompleted, userState)
        End Sub

        Private Sub OnMoveFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.MoveFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent MoveFileCompleted(Me, New MoveFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MoveandDeleteFile", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function MoveandDeleteFile(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String) As String
            Dim results() As Object = Me.Invoke("MoveandDeleteFile", New Object() {SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginMoveandDeleteFile(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("MoveandDeleteFile", New Object() {SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndMoveandDeleteFile(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub MoveandDeleteFileAsync(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String)
            Me.MoveandDeleteFileAsync(SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub MoveandDeleteFileAsync(ByVal SoucePath As String, ByVal SourceFileName As String, ByVal TargetPath As String, ByVal TargetFileName As String, ByVal UserName As String, ByVal TranID As String, ByVal userState As Object)
            If (Me.MoveandDeleteFileOperationCompleted Is Nothing) Then
                Me.MoveandDeleteFileOperationCompleted = AddressOf Me.OnMoveandDeleteFileOperationCompleted
            End If
            Me.InvokeAsync("MoveandDeleteFile", New Object() {SoucePath, SourceFileName, TargetPath, TargetFileName, UserName, TranID}, Me.MoveandDeleteFileOperationCompleted, userState)
        End Sub

        Private Sub OnMoveandDeleteFileOperationCompleted(ByVal arg As Object)
            If (Not (Me.MoveandDeleteFileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent MoveandDeleteFileCompleted(Me, New MoveandDeleteFileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFaxestoProcess", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetFaxestoProcess(ByVal stringtoCombine As String, ByVal BaseFaxNumber As String) As String
            Dim results() As Object = Me.Invoke("GetFaxestoProcess", New Object() {stringtoCombine, BaseFaxNumber})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginGetFaxestoProcess(ByVal stringtoCombine As String, ByVal BaseFaxNumber As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetFaxestoProcess", New Object() {stringtoCombine, BaseFaxNumber}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndGetFaxestoProcess(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub GetFaxestoProcessAsync(ByVal stringtoCombine As String, ByVal BaseFaxNumber As String)
            Me.GetFaxestoProcessAsync(stringtoCombine, BaseFaxNumber, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetFaxestoProcessAsync(ByVal stringtoCombine As String, ByVal BaseFaxNumber As String, ByVal userState As Object)
            If (Me.GetFaxestoProcessOperationCompleted Is Nothing) Then
                Me.GetFaxestoProcessOperationCompleted = AddressOf Me.OnGetFaxestoProcessOperationCompleted
            End If
            Me.InvokeAsync("GetFaxestoProcess", New Object() {stringtoCombine, BaseFaxNumber}, Me.GetFaxestoProcessOperationCompleted, userState)
        End Sub

        Private Sub OnGetFaxestoProcessOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetFaxestoProcessCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetFaxestoProcessCompleted(Me, New GetFaxestoProcessCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetFaxestoProcess_CS", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function GetFaxestoProcess_CS(ByVal stringtoCombine As String) As String
            Dim results() As Object = Me.Invoke("GetFaxestoProcess_CS", New Object() {stringtoCombine})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginGetFaxestoProcess_CS(ByVal stringtoCombine As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetFaxestoProcess_CS", New Object() {stringtoCombine}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndGetFaxestoProcess_CS(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub GetFaxestoProcess_CSAsync(ByVal stringtoCombine As String)
            Me.GetFaxestoProcess_CSAsync(stringtoCombine, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetFaxestoProcess_CSAsync(ByVal stringtoCombine As String, ByVal userState As Object)
            If (Me.GetFaxestoProcess_CSOperationCompleted Is Nothing) Then
                Me.GetFaxestoProcess_CSOperationCompleted = AddressOf Me.OnGetFaxestoProcess_CSOperationCompleted
            End If
            Me.InvokeAsync("GetFaxestoProcess_CS", New Object() {stringtoCombine}, Me.GetFaxestoProcess_CSOperationCompleted, userState)
        End Sub

        Private Sub OnGetFaxestoProcess_CSOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetFaxestoProcess_CSCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetFaxestoProcess_CSCompleted(Me, New GetFaxestoProcess_CSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetUser", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function SetUser(ByVal TargetPath As String, ByVal UserName As String, ByVal tranid As String) As String
            Dim results() As Object = Me.Invoke("SetUser", New Object() {TargetPath, UserName, tranid})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginSetUser(ByVal TargetPath As String, ByVal UserName As String, ByVal tranid As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SetUser", New Object() {TargetPath, UserName, tranid}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndSetUser(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub SetUserAsync(ByVal TargetPath As String, ByVal UserName As String, ByVal tranid As String)
            Me.SetUserAsync(TargetPath, UserName, tranid, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SetUserAsync(ByVal TargetPath As String, ByVal UserName As String, ByVal tranid As String, ByVal userState As Object)
            If (Me.SetUserOperationCompleted Is Nothing) Then
                Me.SetUserOperationCompleted = AddressOf Me.OnSetUserOperationCompleted
            End If
            Me.InvokeAsync("SetUser", New Object() {TargetPath, UserName, tranid}, Me.SetUserOperationCompleted, userState)
        End Sub

        Private Sub OnSetUserOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetUserCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetUserCompleted(Me, New SetUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SetUserFolder", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function SetUserFolder(ByVal tranid As String) As String
            Dim results() As Object = Me.Invoke("SetUserFolder", New Object() {tranid})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Function BeginSetUserFolder(ByVal tranid As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SetUserFolder", New Object() {tranid}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndSetUserFolder(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub SetUserFolderAsync(ByVal tranid As String)
            Me.SetUserFolderAsync(tranid, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SetUserFolderAsync(ByVal tranid As String, ByVal userState As Object)
            If (Me.SetUserFolderOperationCompleted Is Nothing) Then
                Me.SetUserFolderOperationCompleted = AddressOf Me.OnSetUserFolderOperationCompleted
            End If
            Me.InvokeAsync("SetUserFolder", New Object() {tranid}, Me.SetUserFolderOperationCompleted, userState)
        End Sub

        Private Sub OnSetUserFolderOperationCompleted(ByVal arg As Object)
            If (Not (Me.SetUserFolderCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SetUserFolderCompleted(Me, New SetUserFolderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendEmail", RequestNamespace:="http://tempuri.org/", ResponseNamespace:="http://tempuri.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function SendEmail(ByVal Subject As String, ByVal ToStr As String, ByVal fromStr As String, ByVal DisplayName As String, ByVal AttchedFile1 As String, ByVal AttchedFile2 As String, ByVal AttchedFile3 As String, ByVal mailBody As String, ByVal tranid As String) As Object
            Dim results() As Object = Me.Invoke("SendEmail", New Object() {Subject, ToStr, fromStr, DisplayName, AttchedFile1, AttchedFile2, AttchedFile3, mailBody, tranid})
            Return CType(results(0), Object)
        End Function

        '''<remarks/>
        Public Function BeginSendEmail(ByVal Subject As String, ByVal ToStr As String, ByVal fromStr As String, ByVal DisplayName As String, ByVal AttchedFile1 As String, ByVal AttchedFile2 As String, ByVal AttchedFile3 As String, ByVal mailBody As String, ByVal tranid As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SendEmail", New Object() {Subject, ToStr, fromStr, DisplayName, AttchedFile1, AttchedFile2, AttchedFile3, mailBody, tranid}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndSendEmail(ByVal asyncResult As System.IAsyncResult) As Object
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), Object)
        End Function

        '''<remarks/>
        Public Overloads Sub SendEmailAsync(ByVal Subject As String, ByVal ToStr As String, ByVal fromStr As String, ByVal DisplayName As String, ByVal AttchedFile1 As String, ByVal AttchedFile2 As String, ByVal AttchedFile3 As String, ByVal mailBody As String, ByVal tranid As String)
            Me.SendEmailAsync(Subject, ToStr, fromStr, DisplayName, AttchedFile1, AttchedFile2, AttchedFile3, mailBody, tranid, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub SendEmailAsync(ByVal Subject As String, ByVal ToStr As String, ByVal fromStr As String, ByVal DisplayName As String, ByVal AttchedFile1 As String, ByVal AttchedFile2 As String, ByVal AttchedFile3 As String, ByVal mailBody As String, ByVal tranid As String, ByVal userState As Object)
            If (Me.SendEmailOperationCompleted Is Nothing) Then
                Me.SendEmailOperationCompleted = AddressOf Me.OnSendEmailOperationCompleted
            End If
            Me.InvokeAsync("SendEmail", New Object() {Subject, ToStr, fromStr, DisplayName, AttchedFile1, AttchedFile2, AttchedFile3, mailBody, tranid}, Me.SendEmailOperationCompleted, userState)
        End Sub

        Private Sub OnSendEmailOperationCompleted(ByVal arg As Object)
            If (Not (Me.SendEmailCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SendEmailCompleted(Me, New SendEmailCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub

        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing) _
                        OrElse (url Is String.Empty)) Then
                Return False
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024) _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return True
            End If
            Return False
        End Function
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub MoveFileCompletedEventHandler(ByVal sender As Object, ByVal e As MoveFileCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class MoveFileCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub MoveandDeleteFileCompletedEventHandler(ByVal sender As Object, ByVal e As MoveandDeleteFileCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class MoveandDeleteFileCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub GetFaxestoProcessCompletedEventHandler(ByVal sender As Object, ByVal e As GetFaxestoProcessCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class GetFaxestoProcessCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub GetFaxestoProcess_CSCompletedEventHandler(ByVal sender As Object, ByVal e As GetFaxestoProcess_CSCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class GetFaxestoProcess_CSCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub SetUserCompletedEventHandler(ByVal sender As Object, ByVal e As SetUserCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class SetUserCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub SetUserFolderCompletedEventHandler(ByVal sender As Object, ByVal e As SetUserFolderCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class SetUserFolderCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")> _
    Public Delegate Sub SendEmailCompletedEventHandler(ByVal sender As Object, ByVal e As SendEmailCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class SendEmailCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Object)
            End Get
        End Property
    End Class
End Namespace
