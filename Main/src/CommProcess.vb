Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Scripting
Imports System.Data.SqlClient
Public Class CommProcess
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        Try

      
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())


        End Try
        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgCommRun As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgCommRunSum As System.Windows.Forms.DataGrid
    Friend WithEvents dgDetails As System.Windows.Forms.DataGrid
    Friend WithEvents TC1 As System.Windows.Forms.TabControl
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProcessDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgCodesMF As System.Windows.Forms.DataGrid
    Friend WithEvents BalApprove As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShowDetails As System.Windows.Forms.CheckBox
    Friend WithEvents IncMan As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DealerCode As System.Windows.Forms.ComboBox
    Friend WithEvents VeiwReports As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Process As System.Windows.Forms.Button
    Friend WithEvents getDetails As System.Windows.Forms.CheckBox
    Private WithEvents cr1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SearchDealerCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents CachedRepReport1 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport2 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport3 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport4 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport5 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport6 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport7 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport8 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport9 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport10 As ViefundCommProcess.CachedRepReport
    Friend WithEvents CachedRepReport11 As ViefundCommProcess.CachedRepReport
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TC1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgCodesMF = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.dgCommRun = New System.Windows.Forms.DataGrid()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.BalApprove = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgCommRunSum = New System.Windows.Forms.DataGrid()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgDetails = New System.Windows.Forms.DataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProcessDate = New System.Windows.Forms.DateTimePicker()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VeiwReports = New System.Windows.Forms.Button()
        Me.ShowDetails = New System.Windows.Forms.CheckBox()
        Me.IncMan = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DealerCode = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchDealerCode = New System.Windows.Forms.ComboBox()
        Me.bStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Process = New System.Windows.Forms.Button()
        Me.getDetails = New System.Windows.Forms.CheckBox()
        Me.cr1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.CachedRepReport1 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport2 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport3 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport4 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport5 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport6 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport7 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport8 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport9 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport10 = New ViefundCommProcess.CachedRepReport()
        Me.CachedRepReport11 = New ViefundCommProcess.CachedRepReport()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TC1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgCodesMF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCommRun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgCommRunSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC1
        '
        Me.TC1.Controls.Add(Me.TabPage1)
        Me.TC1.Controls.Add(Me.TabPage2)
        Me.TC1.Controls.Add(Me.TabPage3)
        Me.TC1.Location = New System.Drawing.Point(216, 16)
        Me.TC1.Name = "TC1"
        Me.TC1.SelectedIndex = 0
        Me.TC1.Size = New System.Drawing.Size(712, 592)
        Me.TC1.TabIndex = 5
        Me.TC1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dgCodesMF)
        Me.TabPage1.Controls.Add(Me.BalApprove)
        Me.TabPage1.Controls.Add(Me.dgCommRun)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(704, 566)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Totals"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(240, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Double Click on the each line to Provide Commtrans RepNo."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Execptions"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Amout Totals"
        '
        'dgCodesMF
        '
        Me.dgCodesMF.DataMember = ""
        Me.dgCodesMF.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCodesMF.Location = New System.Drawing.Point(144, 360)
        Me.dgCodesMF.Name = "dgCodesMF"
        Me.dgCodesMF.Size = New System.Drawing.Size(536, 192)
        Me.dgCodesMF.TabIndex = 9
        Me.dgCodesMF.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgCodesMF
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CommRun"
        '
        'dgCommRun
        '
        Me.dgCommRun.DataMember = ""
        Me.dgCommRun.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCommRun.Location = New System.Drawing.Point(144, 24)
        Me.dgCommRun.Name = "dgCommRun"
        Me.dgCommRun.Size = New System.Drawing.Size(536, 304)
        Me.dgCommRun.TabIndex = 4
        Me.dgCommRun.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Type"
        Me.DataGridTextBoxColumn1.MappingName = "Type"
        Me.DataGridTextBoxColumn1.NullText = "0"
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Amount"
        Me.DataGridTextBoxColumn2.MappingName = "Amount"
        Me.DataGridTextBoxColumn2.NullText = "0"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Description"
        Me.DataGridTextBoxColumn3.MappingName = "Descr"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 300
        '
        'BalApprove
        '
        Me.BalApprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalApprove.Location = New System.Drawing.Point(8, 72)
        Me.BalApprove.Name = "BalApprove"
        Me.BalApprove.Size = New System.Drawing.Size(128, 23)
        Me.BalApprove.TabIndex = 7
        Me.BalApprove.Text = "Balanced"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgCommRunSum)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(704, 566)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Summary"
        '
        'dgCommRunSum
        '
        Me.dgCommRunSum.DataMember = ""
        Me.dgCommRunSum.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCommRunSum.Location = New System.Drawing.Point(8, 8)
        Me.dgCommRunSum.Name = "dgCommRunSum"
        Me.dgCommRunSum.Size = New System.Drawing.Size(560, 184)
        Me.dgCommRunSum.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgDetails)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(704, 566)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Details"
        '
        'dgDetails
        '
        Me.dgDetails.DataMember = ""
        Me.dgDetails.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetails.Location = New System.Drawing.Point(8, 8)
        Me.dgDetails.Name = "dgDetails"
        Me.dgDetails.Size = New System.Drawing.Size(560, 176)
        Me.dgDetails.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Process Date"
        '
        'ProcessDate
        '
        Me.ProcessDate.Location = New System.Drawing.Point(24, 56)
        Me.ProcessDate.Name = "ProcessDate"
        Me.ProcessDate.Size = New System.Drawing.Size(128, 20)
        Me.ProcessDate.TabIndex = 12
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3})
        Me.MenuItem1.Text = "Process"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Commission"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        Me.MenuItem2.Text = "View "
        Me.MenuItem2.Visible = False
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Reports"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VeiwReports)
        Me.Panel1.Controls.Add(Me.ShowDetails)
        Me.Panel1.Controls.Add(Me.IncMan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DealerCode)
        Me.Panel1.Location = New System.Drawing.Point(16, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 160)
        Me.Panel1.TabIndex = 20
        '
        'VeiwReports
        '
        Me.VeiwReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VeiwReports.Location = New System.Drawing.Point(8, 128)
        Me.VeiwReports.Name = "VeiwReports"
        Me.VeiwReports.Size = New System.Drawing.Size(128, 23)
        Me.VeiwReports.TabIndex = 24
        Me.VeiwReports.Text = "ViewReport"
        '
        'ShowDetails
        '
        Me.ShowDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowDetails.Location = New System.Drawing.Point(8, 96)
        Me.ShowDetails.Name = "ShowDetails"
        Me.ShowDetails.Size = New System.Drawing.Size(104, 24)
        Me.ShowDetails.TabIndex = 23
        Me.ShowDetails.Text = "Show Details"
        '
        'IncMan
        '
        Me.IncMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncMan.Location = New System.Drawing.Point(8, 72)
        Me.IncMan.Name = "IncMan"
        Me.IncMan.Size = New System.Drawing.Size(128, 24)
        Me.IncMan.TabIndex = 22
        Me.IncMan.Text = "Include Manager"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Dealer Code"
        '
        'DealerCode
        '
        Me.DealerCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DealerCode.Location = New System.Drawing.Point(8, 40)
        Me.DealerCode.Name = "DealerCode"
        Me.DealerCode.Size = New System.Drawing.Size(176, 21)
        Me.DealerCode.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.SearchDealerCode)
        Me.Panel2.Controls.Add(Me.bStatus)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Process)
        Me.Panel2.Controls.Add(Me.getDetails)
        Me.Panel2.Location = New System.Drawing.Point(16, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 160)
        Me.Panel2.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Dealer Code"
        '
        'SearchDealerCode
        '
        Me.SearchDealerCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchDealerCode.Items.AddRange(New Object() {"7686", "7625", "3365"})
        Me.SearchDealerCode.Location = New System.Drawing.Point(8, 66)
        Me.SearchDealerCode.Name = "SearchDealerCode"
        Me.SearchDealerCode.Size = New System.Drawing.Size(176, 21)
        Me.SearchDealerCode.TabIndex = 25
        '
        'bStatus
        '
        Me.bStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bStatus.Enabled = False
        Me.bStatus.Location = New System.Drawing.Point(8, 18)
        Me.bStatus.Name = "bStatus"
        Me.bStatus.Size = New System.Drawing.Size(176, 21)
        Me.bStatus.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Batch Status"
        '
        'Process
        '
        Me.Process.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Process.Location = New System.Drawing.Point(8, 128)
        Me.Process.Name = "Process"
        Me.Process.Size = New System.Drawing.Size(128, 23)
        Me.Process.TabIndex = 15
        Me.Process.Text = "Process"
        '
        'getDetails
        '
        Me.getDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getDetails.Location = New System.Drawing.Point(8, 96)
        Me.getDetails.Name = "getDetails"
        Me.getDetails.Size = New System.Drawing.Size(104, 24)
        Me.getDetails.TabIndex = 16
        Me.getDetails.Text = "Get Details"
        '
        'cr1
        '
        Me.cr1.ActiveViewIndex = -1
        Me.cr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cr1.Cursor = System.Windows.Forms.Cursors.Default
        Me.cr1.Location = New System.Drawing.Point(640, 192)
        Me.cr1.Name = "cr1"
        Me.cr1.SelectionFormula = ""
        Me.cr1.Size = New System.Drawing.Size(808, 568)
        Me.cr1.TabIndex = 22
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(27, 567)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(173, 23)
        Me.btnTest.TabIndex = 26
        Me.btnTest.Text = "Generate Prev Report"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "You are connected to test DB"
        '
        'CommProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1032, 607)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.cr1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProcessDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TC1)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.MainMenu1
        Me.Name = "CommProcess"
        Me.Text = "VieFund Comm Process v.2023-july-26"
        Me.TC1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgCodesMF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCommRun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgCommRunSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim BaseLocation As String = "\\storage.globalresp.com\ToBePublished\MF\"

    ' Dim BaseLocation As String = "\\prodstorage\ToBePublished\MF\"
    Dim BatchStatus As Integer

    Private Sub CommRun(ByVal Opt As Integer)
        ''TC1.Visible = False
        
        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Conn.ConnectionString = getConnStr
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "[SP_VieFUND_Commission_Process]"

        sqlCmd.CommandTimeout = 10000

        Dim myParm As SqlParameter = sqlCmd.Parameters.Add("@ProcDate", SqlDbType.SmallDateTime)
        myParm.Size = 50
        myParm.Value = Format(ProcessDate.Value, "yyyy-MM-dd")

        Dim myParm1 As SqlParameter = sqlCmd.Parameters.Add("@opt", SqlDbType.TinyInt)
        myParm1.Value = 0 ''

        Dim myParm2 As SqlParameter = sqlCmd.Parameters.Add("@DealerCode", SqlDbType.VarChar, 5)
        myParm2.Value = Trim(SearchDealerCode.Text)
        Try
            da = New SqlDataAdapter(sqlCmd)
            If BatchStatus = 0 And Opt = 0 Then

                da.Fill(ds, "CommRun")
                dgCommRun.DataSource = ds.Tables("CommRun").DefaultView


                myParm1.Value = 3
                da.Fill(ds, "CodesMF")
                dgCodesMF.DataSource = ds.Tables("CodesMF").DefaultView
                If ds.Tables("CodesMF").Rows.Count > 0 Then
                    MsgBox("Please check the missing information in the execption grid.")
                    BalApprove.Enabled = False
                Else
                    BalApprove.Enabled = True
                End If

                If ds.Tables("CommRun").Rows.Count <= 0 Then
                    MsgBox("No Data for the selected date.")
                    BalApprove.Enabled = False
                Else
                    BalApprove.Enabled = True
                End If

                If getDetails.Checked Then


                    myParm1.Value = 1
                    da.Fill(ds, "CommRunSum")

                    myParm1.Value = 2
                    da.Fill(ds, "CommRunDet")

                    dgCommRunSum.DataSource = ds.Tables("CommRunSum").DefaultView
                    dgDetails.DataSource = ds.Tables("CommRunDet").DefaultView



                End If



            End If

                If BatchStatus = 1 And Opt = 1 Then
                    myParm1.Value = 4
                    da.Fill(ds, "CommRun")
                    dgCommRun.DataSource = ds.Tables("CommRun").DefaultView

                    myParm1.Value = 3
                    da.Fill(ds, "CodesMF")
                    dgCodesMF.DataSource = ds.Tables("CodesMF").DefaultView
                End If

                If BatchStatus = 2 And Opt = 2 Then
                    myParm1.Value = 5
                    da.Fill(ds, "CommRun")
                    dgCommRun.DataSource = ds.Tables("CommRun").DefaultView
                End If

                If BatchStatus = 0 And Opt = 6 Then
                    myParm1.Value = 6
                    sqlCmd.ExecuteNonQuery()
                    BalApprove.Text = "Approve"
                End If

                If BatchStatus = 1 And Opt = 7 Then

                    ''If ds.Tables("CodesMF").Rows.Count > 0 Then
                    ''    MsgBox("Please check the missing information in the execption grid. Insert any Rep and Manager code not matching and try again.")
                    ''    Exit Sub
                    ''End If
                    myParm1.Value = 7
                    sqlCmd.ExecuteNonQuery()
                    BalApprove.Visible = False

                End If

                If BatchStatus = 1 And Opt = 8 Then
                    myParm1.Value = 8
                    sqlCmd.ExecuteNonQuery()
                    BalApprove.Text = "Balance"
                    BatchStatus = 0
                    bStatus.SelectedIndex = 0
                End If


                If BatchStatus = 2 And Opt = 9 Then
                    myParm1.Value = 9
                    sqlCmd.ExecuteNonQuery()

                End If


                If BatchStatus = 2 And Opt = 11 Then
                    myParm1.Value = 11
                    sqlCmd.ExecuteNonQuery()

                End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If BatchStatus < 2 Then
            getDetails.Visible = True
        End If
    End Sub
    Private Sub CommRun(ByVal Opt As Integer, ByVal code As String, ByVal repno As String)
        ''TC1.Visible = False

        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand

        Dim ds As New DataSet
        Conn.ConnectionString = getConnStr
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "[SP_VieFUND_Commission_Process]"
        sqlCmd.CommandTimeout = 10000
        Dim myParm As SqlParameter = sqlCmd.Parameters.Add("@ProcDate", SqlDbType.SmallDateTime)
        myParm.Size = 50
        myParm.Value = Format(ProcessDate.Value, "yyyy-MM-dd")
        Dim myParm1 As SqlParameter = sqlCmd.Parameters.Add("@opt", SqlDbType.TinyInt)


        Dim myParm2 As SqlParameter = sqlCmd.Parameters.Add("@Code", SqlDbType.NVarChar)
        myParm2.Size = 5
        myParm2.Value = code
        Dim myParm3 As SqlParameter = sqlCmd.Parameters.Add("@RepNo", SqlDbType.NVarChar)
        myParm3.Size = 4
        myParm3.Value = repno

        Try

            If Opt = 10 Then
                myParm1.Value = 10
                sqlCmd.ExecuteNonQuery()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If BatchStatus < 2 Then
            getDetails.Visible = True
        End If
    End Sub
    Private Sub CommProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserRights()
        'GenrateReports()
        'GenerateParkingFeeReport()

        If canView = 0 Then
            MsgBox("No rights to view the application")
            Me.Close()
        End If
        Panel1.Visible = False
        TC1.Visible = True
        cr1.Visible = False
        With DealerCode
            .Items.Add("All")
            .Items.Add("7686")
            .Items.Add("3365")
            .Items.Add("7820")

        End With

        DealerCode.SelectedIndex = 0
        With bStatus

            .Items.Add("New")
            .Items.Add("Balanced")
            .Items.Add("Approved")

        End With

        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand

        Conn.ConnectionString = getConnStr
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandText = "Select WFtoCommTransBatchStatus from Parms"
        BatchStatus = sqlCmd.ExecuteScalar
        bStatus.SelectedIndex = BatchStatus

        sqlCmd.CommandText = "Select  LastWFtoCommTransBatchDate from Parms"
        ProcessDate.Value = sqlCmd.ExecuteScalar

        If BatchStatus >= 2 Then
            getDetails.Visible = False
        End If
        If BatchStatus > 0 Then
            ProcessDate.Enabled = False
        End If

        BalApprove.Visible = False
        If BatchStatus = 0 Then
            BalApprove.Text = "Balance"
        ElseIf BatchStatus = 1 Then
            BalApprove.Text = "Approve"
        Else
            BalApprove.Visible = False
        End If

    End Sub
    Private Sub Process_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Process.Click
        'GenrateReports()
        'GenerateParkingFeeReport()
        If BatchStatus = 2 And CanPost = 0 Then
            MsgBox("No rights to Post the commission to commtrans.")
            Exit Sub
        End If

        If SearchDealerCode.Text.Length = 0 Then
            MsgBox("Please select dealer first")
            Exit Sub
        End If

        If BatchStatus < 2 Then
            BalApprove.Visible = True
            CommRun(BatchStatus)
        End If

        If BatchStatus = 2 Then

            If MsgBox("Do you want to post the commisison batch?", MsgBoxStyle.YesNo, "Post Commission") = MsgBoxResult.No Then
                Exit Sub
            End If

            CommRun(9) '' if PDF files in folder do not need to check this step

            GenrateReports() '' there are two parts ( rep and manager). run queries inside sub  in proddb02 SQL to check pdf files are matching

            GenerateParkingFeeReport()  ''there are two parts ( rep and manager). run queries inside sub  in proddb02 SQL to check pdf files are matching

            CommRun(11) '' last step to send email and set flag for next run 
            BalApprove.Text = "New"
            BatchStatus = 0
            bStatus.SelectedIndex = 0
            ProcessDate.Enabled = True

        End If

        MsgBox("The Process is done")
    End Sub
    Private Sub BalApprove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalApprove.Click
        If BatchStatus = 0 And canBalance = 0 Then
            MsgBox("No rights to change batch status to Balanced.")
            Exit Sub
        End If

        If BatchStatus = 1 And canApprove = 0 Then
            MsgBox("No rights to change batch status to Approved.")
            Exit Sub
        End If
        Try
            If BatchStatus = 0 Then '' Batch from new to Balanced
                If MsgBox("Are you the Numbers are matching with Viefund?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CommRun(6)
                    ProcessDate.Enabled = False
                Else
                    Exit Sub
                End If

            End If
            If BatchStatus = 1 Then '' Batch from  Balanced to Approved

                If MsgBox("Please double check before approving that numbers are matching with Viefund.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CommRun(7)

                    If BatchStatus = 1 Then '' batch status is moved to approve
                        BalApprove.Visible = False
                        ProcessDate.Enabled = False
                    End If


                Else
                    CommRun(8)
                    Exit Sub
                End If

            End If

            If BatchStatus = 2 Then '' Batch from  Balanced to Approved
                If MsgBox("Do you want to Post commission to Commtrans?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    CommRun(9)

                    ProcessDate.Enabled = True
                    BatchStatus = -1


                End If

            End If

            BatchStatus = BatchStatus + 1
            bStatus.SelectedIndex = BatchStatus
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub dgCodesMF_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCodesMF.DoubleClick

        Dim cRow As Integer = dgCodesMF.CurrentRowIndex
        Dim code As String
        Dim Type As String
        Dim CommTranRepNo As String
        If cRow >= 0 Then
            code = dgCodesMF.Item(cRow, 0)
            Type = dgCodesMF.Item(cRow, 1)
            CommTranRepNo = dgCodesMF.Item(cRow, 2)

            If Type = "Exp-Rep" Or Type = "Exp-Man" Then
                MsgBox("Please Contact IT to insert the expense commtype type.")
                Exit Sub
            End If


            If CommTranRepNo > 0 Then
                MsgBox("CommTrans Repno is already assigned for this code.")
                Exit Sub
            End If

            CommTranRepNo = InputBox("Please enter Commtrans RepNo", "CommTrans RepNo", 0)

            If Not IsNumeric(CommTranRepNo) Then
                MsgBox("Commtrans RepNo must be nuermic.Please try again")
                Exit Sub
            End If

            If CommTranRepNo <= 0 Then
                MsgBox("Commtrans RepNo must be greater then zero.Please try again")
                Exit Sub
            End If

            If CommTranRepNo > 9999 Then
                MsgBox("Commtrans RepNo must be less then or equal to 9999.Please try again")
                Exit Sub
            End If

            CommRun(10, code, CommTranRepNo)
        End If
    End Sub
    Private Sub GenrateReports()

        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Conn.ConnectionString = getConnstr
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.Text

        useWebServiceSetUser(tmpPath & userName & "\")
        
        ' '' 2010-10-14 to send email to PIS reps
        sqlCmd.CommandText = "select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address = case when dealer_code in ( '7625','3346') then email else '' end ,RepNo =tmpcommrunmf.rep_code  from  tmpcommrunmf , proddb01.[global db].dbo.SalesInfo s where tmpcommrunmf.rep_code=s.repno and  isnumeric(tmpcommrunmf.rep_code) = 1 and  ( rep_code not in ( select code  COLLATE SQL_Latin1_General_CP437_CI_AS  from   proddb01.[global db].dbo.codesMF where isPIStransferHist = 1 )  or rep_code in ( '8150') and Dealer_Code in ('7686' ,'3365') )  " _
        & " union select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address =   case when dealer_code in ( '7625','3346') then email else '' end,RepNo =tmpcommrunmf.rep_code  from tmpcommrunmf , proddb01.[global db].dbo.SalesInfo s where   tmpcommrunmf.rep_code=s.repno and  Dealer_Code in ( '7686', '3365','7820' )  and isnumeric(tmpcommrunmf.rep_code) = 1 and   rep_code  in ( select code  from   proddb01.[global db].dbo.codesMF where isPIStransferHist = 1   ) and rep_code not in (select code from  Representatives where Dealer_Code  in ( '7625') or  Dealer_Code  in ( '3466')  ) " _
        & " union  select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address  = case when tmpcommrunmf.dealer_code in ( '7625','3466') then email else '' end,RepNo =codesmf.repno from tmpcommrunmf, proddb01.[global db].dbo.codesMF, proddb01.[global db].dbo.SalesInfo s  where tmpcommrunmf.rep_code = codesmf.code and codesmf.repno=s.repno and   rep_code in ( select code  from   proddb01.[global db].dbo.codesMF where isPIStransferHist = 1 ) and  codesMF.Dealer_Code not in ( '7686','7820' )   and codesmf.repno > 0  " _
        & " union select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address  = case when tmpcommrunmf.dealer_code in ( '7625','3466') then email else '' end,RepNo =codesmf.repno from tmpcommrunmf, proddb01.[global db].dbo.codesMF, proddb01.[global db].dbo.SalesInfo s where tmpcommrunmf.rep_code = codesmf.code and codesmf.repno=s.repno and   isnumeric(tmpcommrunmf.rep_code) = 0 and rep_code  not in ( select code  from   proddb01.[global db].dbo.codesMF where isPIStransferHist = 1 ) and tmpcommrunmf.Dealer_Code not in ( '7820' )  and codesmf.repno > 0      " _
        & " order by tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code"

        ' sqlCmd.CommandText = "select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address  = case when tmpcommrunmf.dealer_code in ( '7625','3466') then email else '' end,RepNo =codesmf.repno from tmpcommrunmf, ibm.proddb01.[global db].dbo.codesMF, ibm.proddb01.[global db].dbo.SalesInfo s where tmpcommrunmf.rep_code = codesmf.code and codesmf.repno=s.repno and   isnumeric(tmpcommrunmf.rep_code) = 0 and rep_code  not in ( select code  from   ibm.proddb01.[global db].dbo.codesMF where isPIStransferHist = 1 ) and tmpcommrunmf.Dealer_Code not in ('7820' )  and codesmf.repno > 0"
        '' dc on 2010-10-14   sqlCmd.CommandText = "select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address = 'kimberlyh@globalfinancial.ca',RepNo =tmpcommrunmf.rep_code from tmpcommrunmf where isnumeric(tmpcommrunmf.rep_code) = 1 union select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address = 'kimberlyh@globalfinancial.ca',RepNo =codesmf.repno from tmpcommrunmf, ibm.proddb01.[global db].dbo.codesMF where tmpcommrunmf.rep_code = codesmf.code and isnumeric(tmpcommrunmf.rep_code) = 0  and repno > 0 order by tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code"
        sqlCmd.CommandTimeout = 120
        ''''  sqlCmd.CommandText = "select distinct  tmpcommrunmf.rep_code,tmpcommrunmf.dealer_code,email_address = 'kimberlyh@globalfinancial.ca',RepNo =codesmf.repno from tmpcommrunmf, ibm.proddb01.[global db].dbo.codesMF where tmpcommrunmf.rep_code = codesmf.code and isnumeric(tmpcommrunmf.rep_code) = 0  and repno > 0  and  rep_code<='T4759' order by tmpcommrunmf.rep_code desc,tmpcommrunmf.dealer_code"
        dr = sqlCmd.ExecuteReader


        While dr.Read()
            'If dr.Item("rep_code") > "T5058" Then
            PdfReportRep(dr.Item("Dealer_code"), Trim(dr.Item("rep_code")), Microsoft.VisualBasic.Right("00000" & Trim(dr.Item("RepNo")), 5), "") ' dr("email_address")

            'End If

            ' Exit Sub

        End While

        dr.Close()

        '' dc on 2010-10-14 for PIS mang emails   sqlCmd.CommandText = "select distinct  tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code,email_address =  'kimberlyh@globalfinancial.ca',Repno = case when codesmf.repno = 0 then codesmf.Agencyno  else str(codesmf.repno) end from tmpcommrunmfMang,ibm.proddb01.[global db].dbo.codesmf  where codesmf.code = tmpcommrunmfmang.manager_code  Union select distinct  tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code,email_address =  '',Repno = tmpcommrunmfmang.manager_code from tmpcommrunmfMang where isnumeric(manager_code) = 1  order by tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code"

        '' 2010-10-14 added for PIS adv emails
        sqlCmd.CommandText = "select distinct  tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code,email_address =  '',Repno = case when codesmf.repno = 0 then codesmf.Agencyno  else str(codesmf.repno) end from tmpcommrunmfMang,proddb01.[global db].dbo.codesmf  where codesmf.code = tmpcommrunmfmang.manager_code " _
                                & " Union select distinct  tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code,email_address =  email ,Repno = case when codesmf.repno = 0 then codesmf.Agencyno  else str(codesmf.repno) end from tmpcommrunmfMang,proddb01.[global db].dbo.codesmf  ,proddb01.[global db].dbo.SalesInfo s  where tmpcommrunmfmang.dealer_code in ('7625','3466') and codesmf.code = tmpcommrunmfmang.manager_code  and codesmf.repno=s.repno" _
                                & " union select distinct  tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code,email_address =  '',Repno = tmpcommrunmfmang.manager_code from tmpcommrunmfMang where isnumeric(manager_code) = 1  " _
                                & "union select distinct  tmpcommrunmfmang.manager_code,tmpcommrunmfmang.dealer_code,email_address =  email ,Repno = tmpcommrunmfmang.manager_code from tmpcommrunmfMang  , proddb01.[global db].dbo.SalesInfo s where  tmpcommrunmfmang.dealer_code in ('7625','3466') and isnumeric(manager_code) = 1  and tmpcommrunmfMang.manager_code=s.repno"

        dr = sqlCmd.ExecuteReader

        While dr.Read()
            PdfReportMang(dr.Item("Dealer_code"), Trim(dr.Item("manager_code")), Microsoft.VisualBasic.Right("00000" & Trim(dr("repno")), 5), "")   ' dr("email_address")

        End While

        dr.Close()

    End Sub

    Private Sub GenrateReports_PrevData()
        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Conn.ConnectionString = getConnStr
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "[SP_VieFUND_Commission_Process]"
        sqlCmd.CommandTimeout = 10000
        Dim myParm As SqlParameter = sqlCmd.Parameters.Add("@ProcDate", SqlDbType.SmallDateTime)
        myParm.Size = 50
        myParm.Value = Format(ProcessDate.Value, "yyyy-MM-dd")
        Dim myParm1 As SqlParameter = sqlCmd.Parameters.Add("@opt", SqlDbType.TinyInt)
        myParm1.Value = 12
        da = New SqlDataAdapter(sqlCmd)
        da.Fill(ds)

        Conn.Close()


    End Sub
    Private Sub GenerateParkingFeeReport()

        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Conn.ConnectionString = getConnStr
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.Text

        sqlCmd.CommandText = "select commClosingDate from proddb01.[global db].dbo.parms"
        Dim startdate As Date = sqlCmd.ExecuteScalar()
        ' '' ''startdate = "5/1/2011"
        If (Month(startdate)) >= 4 And (Month(startdate)) <= 6 Then
            startdate = Convert.ToString(Year(startdate)) + "-04-01"
        ElseIf (Month(startdate)) >= 7 And (Month(startdate)) <= 9 Then
            startdate = Convert.ToString(Year(startdate)) + "-07-01" '"7/1/" + Convert.ToString(Year(startdate))
        ElseIf (Month(startdate)) >= 10 And (Month(startdate)) <= 12 Then
            startdate = Convert.ToString(Year(startdate)) + "-10-01" ' "10/1/" + Convert.ToString(Year(startdate))
        ElseIf (Month(startdate)) >= 1 And (Month(startdate)) <= 3 Then
            startdate = Convert.ToString(Year(startdate)) + "-01-01" '"1/1/" + Convert.ToString(Year(startdate))
        Else
            startdate = Date.Now
        End If

        useWebServiceSetUser(tmpPath & userName & "\")

        sqlCmd.CommandText = "select distinct repno ,reportype=0 from proddb01.[global db].dbo.tempRepFees where corporate =1 or managerRepno= 0 " _
                            & "union " _
                            & "select distinct managerRepno ,reportype=1 from proddb01.[global db].dbo.tempRepFees where managerRepno > 0"
        dr = sqlCmd.ExecuteReader

        While dr.Read()
            If dr.Item("reportype") = 0 Then
                PdfReportParkingFees(dr.Item("repno"), startdate, 0)
            Else
                PdfReportParkingFees(0, startdate, dr.Item("repno"))
            End If
        End While

        dr.Close()

    End Sub
  

    Private Sub PdfReportParkingFees(ByVal RepNO As String, ByVal startDate As Date, ByVal MangerRepNo As String)
        Dim fromDate As Date
        Dim Filename As String
        Dim cr As New ParkFees
        fromDate = CDate(ProcessDate.Text)


        Dim crTableLogonInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo
        Dim crTable As Table

        crTableLogonInfo = New TableLogOnInfo
        crConnectionInfo = New ConnectionInfo

        crConnectionInfo.DatabaseName = StrDataBaseNameIBM

        crConnectionInfo.ServerName = StrServerNameIBM  'ibm'

        crConnectionInfo.UserID = "inf"
        crConnectionInfo.Password = "gemc"
        crTableLogonInfo.ConnectionInfo = crConnectionInfo

        For Each crTable In cr.Database.Tables
            crTable.ApplyLogOnInfo(crTableLogonInfo)
        Next

        cr.SetParameterValue("RepNo", RepNO)
        cr.SetParameterValue("ManagerNo", MangerRepNo)
        cr.SetParameterValue("startDate", startDate)

        If RepNO > 0 Then
            Filename = BaseLocation & "AF_" & Trim(RepNO).PadLeft(5, "0") & Format(ProcessDate.Value, "yyyy-MM-dd")
        Else
            Filename = BaseLocation & "AG_" & Trim(MangerRepNo).PadLeft(5, "0") & Format(ProcessDate.Value, "yyyy-MM-dd")

        End If

        Filename = nextFileName(Filename)
        Filename = Replace(Filename, BaseLocation, "")

        cr.ExportToDisk(ExportFormatType.PortableDocFormat, tmpPath & userName & "\" & Filename)

        useWebService(tmpPath & userName & "\", Filename, BaseLocation, Filename)

        cr.Close()
        cr.Dispose()

    End Sub


    Private Sub PdfReportRep(ByVal Dealer_code As String, ByVal rep_code As String, ByVal RepNO As String, ByVal Email As String)
        Dim fromDate, toDate As Date
        Dim Filename As String
        Dim cr As New RepReport
        fromDate = CDate(ProcessDate.Text)
        toDate = CDate(ProcessDate.Text)


        Dim crTableLogonInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo
        Dim crTable As Table

        crTableLogonInfo = New TableLogOnInfo
        crConnectionInfo = New ConnectionInfo

        crConnectionInfo.DatabaseName = StrDataBaseName



        crConnectionInfo.ServerName = StrServerName

        crConnectionInfo.UserID = "inf"
        crConnectionInfo.Password = "gemc"
        crTableLogonInfo.ConnectionInfo = crConnectionInfo

        For Each crTable In cr.Database.Tables
            crTable.ApplyLogOnInfo(crTableLogonInfo)
        Next


        'cr.RecordSelectionFormula = " {MFCommReport;1.Dealer_Code} = '" & Dealer_code & "'" & " {MFCommReport;1.Rep_Code} = '" & rep_code & "'"

        cr.SetParameterValue("Show Header", False)
        cr.SetParameterValue("Include Manager", False)
        cr.SetParameterValue("Show Detail", True)
        cr.SetParameterValue("bShowDetails2", True)
        cr.SetParameterValue("PrintDate", toDate)
        cr.SetParameterValue("cDateToParam", toDate)
        cr.SetParameterValue("cDealerParam", Dealer_code)
        cr.SetParameterValue("cOverRideStatusParam", 2)
        cr.SetParameterValue("cDateFromParam", fromDate)
        cr.SetParameterValue("cAccountTypeParam", 0)
        cr.SetParameterValue("cDateTypeParam", 1)
        cr.SetParameterValue("cStatusParam", 1)
        cr.SetParameterValue("cShowParams", True)
        cr.SetParameterValue("iLanguage", 0)
        cr.SetParameterValue("Rep_Code", rep_code)




        If IsNumeric(rep_code) Then
            Filename = BaseLocation & "P" & Trim(RepNO) & Format(ProcessDate.Value, "yyyy-MM-dd")
        Else
            Filename = BaseLocation & "J" & Trim(RepNO) & Format(ProcessDate.Value, "yyyy-MM-dd")

        End If

        Filename = nextFileName(Filename)

        Filename = Replace(Filename, BaseLocation, "")

        cr.ExportToDisk(ExportFormatType.PortableDocFormat, tmpPath & userName & "\" & Filename)

        useWebService(tmpPath & userName & "\", Filename, BaseLocation, Filename)

        cr.Close()
        cr.Dispose()
        If Email.Trim().Length > 0 Then '' 201010-14 to send email to PIS Advisor Only
            SendEmail(Email, Filename, "Advisor", rep_code)
        End If

    End Sub
    Private Sub PdfReportMang(ByVal Dealer_code As String, ByVal manager_code As String, ByVal RepNO As String, ByVal email As String)
        Dim fromDate, toDate As Date
        Dim Filename As String
        Dim cr As New MangReport
        fromDate = CDate(ProcessDate.Text)
        toDate = CDate(ProcessDate.Text)


        Dim crTableLogonInfo As TableLogOnInfo
        Dim crConnectionInfo As ConnectionInfo
        Dim crTable As Table

        crTableLogonInfo = New TableLogOnInfo
        crConnectionInfo = New ConnectionInfo

        crConnectionInfo.DatabaseName = StrDataBaseName

        crConnectionInfo.ServerName = StrServerName

        crConnectionInfo.UserID = "inf"
        crConnectionInfo.Password = "gemc"
        crTableLogonInfo.ConnectionInfo = crConnectionInfo

        For Each crTable In cr.Database.Tables
            crTable.ApplyLogOnInfo(crTableLogonInfo)
        Next


        'cr.RecordSelectionFormula = " {MFCommReport;1.Dealer_Code} = '" & Dealer_code & "'" & " {MFCommReport;1.Rep_Code} = '" & rep_code & "'"

        cr.SetParameterValue("Show Header", False)
        cr.SetParameterValue("Include Manager", True)
        cr.SetParameterValue("Show Detail", False)
        cr.SetParameterValue("bShowDetails2", True)
        cr.SetParameterValue("PrintDate", toDate)
        cr.SetParameterValue("cDateToParam", toDate)
        cr.SetParameterValue("cDealerParam", Dealer_code)
        cr.SetParameterValue("cOverRideStatusParam", 2)
        cr.SetParameterValue("cDateFromParam", fromDate)
        cr.SetParameterValue("cAccountTypeParam", 0)
        cr.SetParameterValue("cDateTypeParam", 2)
        cr.SetParameterValue("cStatusParam", 2)
        cr.SetParameterValue("cShowParams", True)
        cr.SetParameterValue("iLanguage", 0)
        cr.SetParameterValue("manager_code", manager_code)




        If IsNumeric(RepNO) Then
            Filename = BaseLocation & "M" & Trim(RepNO) & Format(ProcessDate.Value, "yyyy-MM-dd")
        Else
            Filename = BaseLocation & "A" & Trim(RepNO) & Format(ProcessDate.Value, "yyyy-MM-dd")

        End If

        Filename = nextFileName(Filename)

        Filename = Replace(Filename, BaseLocation, "")

        cr.ExportToDisk(ExportFormatType.PortableDocFormat, tmpPath & userName & "\" & Filename)

        useWebService(tmpPath & userName & "\", Filename, BaseLocation, Filename)

        cr.Close()
        cr.Dispose()
        If email.Trim().Length > 0 Then '' 201010-14 to send email to PIS Manager Only
            SendEmail(email, Filename, "Manager", manager_code)
        End If
    End Sub
    Private Function nextFileName(ByVal Filename As String) As String
        Dim fso As New FileSystemObject
        Dim filechar As String = ""
        Dim i As Integer
        i = 0
        While fso.FileExists(Filename & filechar & ".pdf")
            If i = 0 Then
                filechar = "a"
            Else
                filechar = Chr(97 + i)
            End If
            i += 1
        End While
        nextFileName = Filename & filechar & ".pdf"
    End Function
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        TC1.Visible = True
        cr1.Visible = False
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Panel1.Top = Panel2.Top
        Panel1.Left = Panel2.Left
        Panel1.Visible = True
        Panel2.Visible = False
        cr1.Width = TC1.Width
        cr1.Height = TC1.Height
        cr1.Top = TC1.Top
        cr1.Left = TC1.Left
        cr1.Visible = True
        TC1.Visible = False
    End Sub
    Private Sub UserRights()
        If StrServerName = "Proddb02" Then

            Label8.Visible = False

            ' Code block to be executed if the condition is true
            ' Add your desired actions here
        End If
        '' MsgBox("set user")
        Dim Conn As New SqlConnection
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Conn.ConnectionString = getConnStrGMII_IMG
        Conn.Open()
        sqlCmd.Connection = Conn
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.CommandText = "select * from UserRightsCommRun where UserID in (select UserID from Users where NTLogin = '" & userName & "')"
        dr = sqlCmd.ExecuteReader
        Try
            dr.Read()
            isAdmin = dr.Item("isAdmin")
            canView = dr.Item("canView")
            canBalance = dr.Item("canBalance")
            canApprove = dr.Item("canApprove")
            CanPost = dr.Item("CanPost")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


    Private Sub SendEmail(ByVal Email As String, ByVal FileName As String, ByVal Descr As String, ByVal Number As String)
        Dim conn As New SqlConnection
        Dim strSql As String
        conn.ConnectionString = getConnStrGMII_IMG
        Dim sqlcmd As New SqlCommand
        conn.Open()
        sqlcmd.Connection = conn
        strSql = "exec msdb.dbo.sp_send_dbmail " _
                & "@profile_name = 'PIS_Profile' , @recipients = '" & Trim(Email) & "' ," _
                & "@body = '" & "This is automated message. Do not reply to this message. No one is reading mails from this mailbox. If you have any problems Regarding this email Please contact Account Department (Alex at 416 741 7377 Ext. 3509) Thanks. Here is Statement for " & Descr & " " & Number & "'," _
                & "@subject = 'Statement for  " & Descr & " " & Number & "'," _
                & "@file_attachments = '" & BaseLocation & FileName & "'," _
                & "@copy_recipients = 'Statements@globalresp.com'"

        sqlcmd.CommandText = strSql
        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
    End Sub


    Private Sub btnTest_Click(sender As System.Object, e As System.EventArgs) Handles btnTest.Click

        Try

    
            ' BaseLocation = "\\storage.globalresp.com\olstatements.gemc\" + ProcessDate.Value.Year.ToString() + "\" + ProcessDate.Value.Month.ToString().PadLeft(2, "0") + "\"
            GenrateReports_PrevData()
            GenrateReports()
            MessageBox.Show("Done!")


        Catch ex As Exception
            MessageBox.Show(ex.ToString())

        Finally
            BaseLocation = "\\storage.globalresp.com\ToBePublished\MF\"
        End Try


    End Sub
End Class
