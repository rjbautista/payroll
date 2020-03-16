<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimesheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpTimesheet = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.lbThuUM = New System.Windows.Forms.Label()
        Me.lbThuUH = New System.Windows.Forms.Label()
        Me.lbThuLM = New System.Windows.Forms.Label()
        Me.lbThuLH = New System.Windows.Forms.Label()
        Me.lbThuOM = New System.Windows.Forms.Label()
        Me.lbThuOH = New System.Windows.Forms.Label()
        Me.lbWedUM = New System.Windows.Forms.Label()
        Me.lbWedLM = New System.Windows.Forms.Label()
        Me.lbWedUH = New System.Windows.Forms.Label()
        Me.lbWedLH = New System.Windows.Forms.Label()
        Me.lbTueUM = New System.Windows.Forms.Label()
        Me.lbWedOM = New System.Windows.Forms.Label()
        Me.lbWedOH = New System.Windows.Forms.Label()
        Me.lbTueUH = New System.Windows.Forms.Label()
        Me.lbTueLM = New System.Windows.Forms.Label()
        Me.lbTueLH = New System.Windows.Forms.Label()
        Me.lbTueOM = New System.Windows.Forms.Label()
        Me.lbTueOH = New System.Windows.Forms.Label()
        Me.lbMonUM = New System.Windows.Forms.Label()
        Me.lbMonUH = New System.Windows.Forms.Label()
        Me.lbMonLM = New System.Windows.Forms.Label()
        Me.lbMonLH = New System.Windows.Forms.Label()
        Me.lbMonOM = New System.Windows.Forms.Label()
        Me.lbMonOH = New System.Windows.Forms.Label()
        Me.lbSunUM = New System.Windows.Forms.Label()
        Me.lbSunUH = New System.Windows.Forms.Label()
        Me.lbSunLM = New System.Windows.Forms.Label()
        Me.lbSunLH = New System.Windows.Forms.Label()
        Me.lbSunOM = New System.Windows.Forms.Label()
        Me.lbSunOH = New System.Windows.Forms.Label()
        Me.lbSatUM = New System.Windows.Forms.Label()
        Me.lbSatUH = New System.Windows.Forms.Label()
        Me.lbSatLM = New System.Windows.Forms.Label()
        Me.lbSatLH = New System.Windows.Forms.Label()
        Me.lbSatOM = New System.Windows.Forms.Label()
        Me.lbSatOH = New System.Windows.Forms.Label()
        Me.lbFriUM = New System.Windows.Forms.Label()
        Me.lbFriUH = New System.Windows.Forms.Label()
        Me.lbFriLM = New System.Windows.Forms.Label()
        Me.lbFriLH = New System.Windows.Forms.Label()
        Me.lbFriOM = New System.Windows.Forms.Label()
        Me.lbFriOH = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblFriDate = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblSatDate = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblSunDate = New System.Windows.Forms.Label()
        Me.lblMonDate = New System.Windows.Forms.Label()
        Me.lblTueDate = New System.Windows.Forms.Label()
        Me.lblWedDate = New System.Windows.Forms.Label()
        Me.lblThuDate = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkFri = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbFriIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbThuOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbThuIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbSunIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbSunOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbWedOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbWedIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbTueOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbMonOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbSatOut = New System.Windows.Forms.DateTimePicker()
        Me.cmbTueIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbMonIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbSatIn = New System.Windows.Forms.DateTimePicker()
        Me.cmbFriOut = New System.Windows.Forms.DateTimePicker()
        Me.chkThu = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkWed = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTue = New System.Windows.Forms.CheckBox()
        Me.chkMon = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkSun = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkSat = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalLate = New System.Windows.Forms.Label()
        Me.lblTotalUndertime = New System.Windows.Forms.Label()
        Me.lblTotalOvertime = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdCreateTimesheet = New System.Windows.Forms.Button()
        Me.UnsubmittedGrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollDataSet2 = New Payroll.payrollDataSet2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.SubmittedGrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpnumDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCutoff = New System.Windows.Forms.ComboBox()
        Me.EmployeeTableAdapter = New Payroll.payrollDataSet2TableAdapters.EmployeeTableAdapter()
        Me.PayrollDataSet3 = New Payroll.payrollDataSet3()
        Me.CutoffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CutoffTableAdapter = New Payroll.payrollDataSet3TableAdapters.CutoffTableAdapter()
        Me.lblCutoffID = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.grpTimesheet.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UnsubmittedGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SubmittedGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CutoffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTimesheet
        '
        Me.grpTimesheet.Controls.Add(Me.lblEmployeeName)
        Me.grpTimesheet.Controls.Add(Me.cmdSave)
        Me.grpTimesheet.Controls.Add(Me.TableLayoutPanel1)
        Me.grpTimesheet.Controls.Add(Me.GroupBox2)
        Me.grpTimesheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.grpTimesheet.Location = New System.Drawing.Point(937, 41)
        Me.grpTimesheet.Name = "grpTimesheet"
        Me.grpTimesheet.Size = New System.Drawing.Size(1076, 922)
        Me.grpTimesheet.TabIndex = 1
        Me.grpTimesheet.TabStop = False
        Me.grpTimesheet.Text = "Employee Timesheet"
        Me.grpTimesheet.Visible = False
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.Location = New System.Drawing.Point(15, 46)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(128, 29)
        Me.lblEmployeeName.TabIndex = 44
        Me.lblEmployeeName.Text = "empname"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmdSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdSave.Location = New System.Drawing.Point(16, 830)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(606, 65)
        Me.cmdSave.TabIndex = 43
        Me.cmdSave.Text = "Submit and save timesheet"
        Me.cmdSave.UseVisualStyleBackColor = False
        Me.cmdSave.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.415823!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.64522!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.84016!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.37427!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.775828!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.335283!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.288499!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.042885!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.712042!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.387434!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label68, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label69, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbThuUM, 10, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbThuUH, 9, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbThuLM, 8, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbThuLH, 7, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbThuOM, 6, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbThuOH, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbWedUM, 10, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbWedLM, 8, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbWedUH, 9, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbWedLH, 7, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTueUM, 10, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbWedOM, 6, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbWedOH, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTueUH, 9, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTueLM, 8, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTueLH, 7, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTueOM, 6, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbTueOH, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMonUM, 10, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMonUH, 9, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMonLM, 8, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMonLH, 7, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMonOM, 6, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbMonOH, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSunUM, 10, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSunUH, 9, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSunLM, 8, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSunLH, 7, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSunOM, 6, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSunOH, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSatUM, 10, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSatUH, 9, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSatLM, 8, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSatLH, 7, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSatOM, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSatOH, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFriUM, 10, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFriUH, 9, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFriLM, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFriLH, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFriOM, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbFriOH, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblFriDate, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label24, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSatDate, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSunDate, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMonDate, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTueDate, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblWedDate, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblThuDate, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkFri, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFriIn, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbThuOut, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbThuIn, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSunIn, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSunOut, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbWedOut, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbWedIn, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTueOut, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMonOut, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSatOut, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbTueIn, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMonIn, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSatIn, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFriOut, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkThu, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.chkWed, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.chkTue, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.chkMon, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkSun, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.chkSat, 0, 2)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(17, 94)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.32143!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.67857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1027, 438)
        Me.TableLayoutPanel1.TabIndex = 42
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(332, 1)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(80, 25)
        Me.Label68.TabIndex = 45
        Me.Label68.Text = "Time IN"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(522, 1)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(93, 25)
        Me.Label69.TabIndex = 46
        Me.Label69.Text = "Time Out"
        '
        'lbThuUM
        '
        Me.lbThuUM.AutoSize = True
        Me.lbThuUM.Location = New System.Drawing.Point(959, 375)
        Me.lbThuUM.Name = "lbThuUM"
        Me.lbThuUM.Size = New System.Drawing.Size(23, 25)
        Me.lbThuUM.TabIndex = 51
        Me.lbThuUM.Text = "0"
        Me.lbThuUM.Visible = False
        '
        'lbThuUH
        '
        Me.lbThuUH.AutoSize = True
        Me.lbThuUH.Location = New System.Drawing.Point(910, 375)
        Me.lbThuUH.Name = "lbThuUH"
        Me.lbThuUH.Size = New System.Drawing.Size(23, 25)
        Me.lbThuUH.TabIndex = 51
        Me.lbThuUH.Text = "0"
        Me.lbThuUH.Visible = False
        '
        'lbThuLM
        '
        Me.lbThuLM.AutoSize = True
        Me.lbThuLM.Location = New System.Drawing.Point(848, 375)
        Me.lbThuLM.Name = "lbThuLM"
        Me.lbThuLM.Size = New System.Drawing.Size(23, 25)
        Me.lbThuLM.TabIndex = 52
        Me.lbThuLM.Text = "0"
        Me.lbThuLM.Visible = False
        '
        'lbThuLH
        '
        Me.lbThuLH.AutoSize = True
        Me.lbThuLH.Location = New System.Drawing.Point(804, 375)
        Me.lbThuLH.Name = "lbThuLH"
        Me.lbThuLH.Size = New System.Drawing.Size(23, 25)
        Me.lbThuLH.TabIndex = 51
        Me.lbThuLH.Text = "0"
        Me.lbThuLH.Visible = False
        '
        'lbThuOM
        '
        Me.lbThuOM.AutoSize = True
        Me.lbThuOM.Location = New System.Drawing.Point(739, 375)
        Me.lbThuOM.Name = "lbThuOM"
        Me.lbThuOM.Size = New System.Drawing.Size(23, 25)
        Me.lbThuOM.TabIndex = 52
        Me.lbThuOM.Text = "0"
        Me.lbThuOM.Visible = False
        '
        'lbThuOH
        '
        Me.lbThuOH.AutoSize = True
        Me.lbThuOH.Location = New System.Drawing.Point(690, 375)
        Me.lbThuOH.Name = "lbThuOH"
        Me.lbThuOH.Size = New System.Drawing.Size(23, 25)
        Me.lbThuOH.TabIndex = 53
        Me.lbThuOH.Text = "0"
        Me.lbThuOH.Visible = False
        '
        'lbWedUM
        '
        Me.lbWedUM.AutoSize = True
        Me.lbWedUM.Location = New System.Drawing.Point(959, 320)
        Me.lbWedUM.Name = "lbWedUM"
        Me.lbWedUM.Size = New System.Drawing.Size(23, 25)
        Me.lbWedUM.TabIndex = 64
        Me.lbWedUM.Text = "0"
        Me.lbWedUM.Visible = False
        '
        'lbWedLM
        '
        Me.lbWedLM.AutoSize = True
        Me.lbWedLM.Location = New System.Drawing.Point(848, 320)
        Me.lbWedLM.Name = "lbWedLM"
        Me.lbWedLM.Size = New System.Drawing.Size(23, 25)
        Me.lbWedLM.TabIndex = 69
        Me.lbWedLM.Text = "0"
        Me.lbWedLM.Visible = False
        '
        'lbWedUH
        '
        Me.lbWedUH.AutoSize = True
        Me.lbWedUH.Location = New System.Drawing.Point(910, 320)
        Me.lbWedUH.Name = "lbWedUH"
        Me.lbWedUH.Size = New System.Drawing.Size(23, 25)
        Me.lbWedUH.TabIndex = 70
        Me.lbWedUH.Text = "0"
        Me.lbWedUH.Visible = False
        '
        'lbWedLH
        '
        Me.lbWedLH.AutoSize = True
        Me.lbWedLH.Location = New System.Drawing.Point(804, 320)
        Me.lbWedLH.Name = "lbWedLH"
        Me.lbWedLH.Size = New System.Drawing.Size(23, 25)
        Me.lbWedLH.TabIndex = 65
        Me.lbWedLH.Text = "0"
        Me.lbWedLH.Visible = False
        '
        'lbTueUM
        '
        Me.lbTueUM.AutoSize = True
        Me.lbTueUM.Location = New System.Drawing.Point(959, 268)
        Me.lbTueUM.Name = "lbTueUM"
        Me.lbTueUM.Size = New System.Drawing.Size(23, 25)
        Me.lbTueUM.TabIndex = 66
        Me.lbTueUM.Text = "0"
        Me.lbTueUM.Visible = False
        '
        'lbWedOM
        '
        Me.lbWedOM.AutoSize = True
        Me.lbWedOM.Location = New System.Drawing.Point(739, 320)
        Me.lbWedOM.Name = "lbWedOM"
        Me.lbWedOM.Size = New System.Drawing.Size(23, 25)
        Me.lbWedOM.TabIndex = 67
        Me.lbWedOM.Text = "0"
        Me.lbWedOM.Visible = False
        '
        'lbWedOH
        '
        Me.lbWedOH.AutoSize = True
        Me.lbWedOH.Location = New System.Drawing.Point(690, 320)
        Me.lbWedOH.Name = "lbWedOH"
        Me.lbWedOH.Size = New System.Drawing.Size(23, 25)
        Me.lbWedOH.TabIndex = 68
        Me.lbWedOH.Text = "0"
        Me.lbWedOH.Visible = False
        '
        'lbTueUH
        '
        Me.lbTueUH.AutoSize = True
        Me.lbTueUH.Location = New System.Drawing.Point(910, 268)
        Me.lbTueUH.Name = "lbTueUH"
        Me.lbTueUH.Size = New System.Drawing.Size(23, 25)
        Me.lbTueUH.TabIndex = 71
        Me.lbTueUH.Text = "0"
        Me.lbTueUH.Visible = False
        '
        'lbTueLM
        '
        Me.lbTueLM.AutoSize = True
        Me.lbTueLM.Location = New System.Drawing.Point(848, 268)
        Me.lbTueLM.Name = "lbTueLM"
        Me.lbTueLM.Size = New System.Drawing.Size(23, 25)
        Me.lbTueLM.TabIndex = 72
        Me.lbTueLM.Text = "0"
        Me.lbTueLM.Visible = False
        '
        'lbTueLH
        '
        Me.lbTueLH.AutoSize = True
        Me.lbTueLH.Location = New System.Drawing.Point(804, 268)
        Me.lbTueLH.Name = "lbTueLH"
        Me.lbTueLH.Size = New System.Drawing.Size(23, 25)
        Me.lbTueLH.TabIndex = 73
        Me.lbTueLH.Text = "0"
        Me.lbTueLH.Visible = False
        '
        'lbTueOM
        '
        Me.lbTueOM.AutoSize = True
        Me.lbTueOM.Location = New System.Drawing.Point(739, 268)
        Me.lbTueOM.Name = "lbTueOM"
        Me.lbTueOM.Size = New System.Drawing.Size(23, 25)
        Me.lbTueOM.TabIndex = 74
        Me.lbTueOM.Text = "0"
        Me.lbTueOM.Visible = False
        '
        'lbTueOH
        '
        Me.lbTueOH.AutoSize = True
        Me.lbTueOH.Location = New System.Drawing.Point(690, 268)
        Me.lbTueOH.Name = "lbTueOH"
        Me.lbTueOH.Size = New System.Drawing.Size(23, 25)
        Me.lbTueOH.TabIndex = 51
        Me.lbTueOH.Text = "0"
        Me.lbTueOH.Visible = False
        '
        'lbMonUM
        '
        Me.lbMonUM.AutoSize = True
        Me.lbMonUM.Location = New System.Drawing.Point(959, 214)
        Me.lbMonUM.Name = "lbMonUM"
        Me.lbMonUM.Size = New System.Drawing.Size(23, 25)
        Me.lbMonUM.TabIndex = 52
        Me.lbMonUM.Text = "0"
        Me.lbMonUM.Visible = False
        '
        'lbMonUH
        '
        Me.lbMonUH.AutoSize = True
        Me.lbMonUH.Location = New System.Drawing.Point(910, 214)
        Me.lbMonUH.Name = "lbMonUH"
        Me.lbMonUH.Size = New System.Drawing.Size(23, 25)
        Me.lbMonUH.TabIndex = 53
        Me.lbMonUH.Text = "0"
        Me.lbMonUH.Visible = False
        '
        'lbMonLM
        '
        Me.lbMonLM.AutoSize = True
        Me.lbMonLM.Location = New System.Drawing.Point(848, 214)
        Me.lbMonLM.Name = "lbMonLM"
        Me.lbMonLM.Size = New System.Drawing.Size(23, 25)
        Me.lbMonLM.TabIndex = 54
        Me.lbMonLM.Text = "0"
        Me.lbMonLM.Visible = False
        '
        'lbMonLH
        '
        Me.lbMonLH.AutoSize = True
        Me.lbMonLH.Location = New System.Drawing.Point(804, 214)
        Me.lbMonLH.Name = "lbMonLH"
        Me.lbMonLH.Size = New System.Drawing.Size(23, 25)
        Me.lbMonLH.TabIndex = 55
        Me.lbMonLH.Text = "0"
        Me.lbMonLH.Visible = False
        '
        'lbMonOM
        '
        Me.lbMonOM.AutoSize = True
        Me.lbMonOM.Location = New System.Drawing.Point(739, 214)
        Me.lbMonOM.Name = "lbMonOM"
        Me.lbMonOM.Size = New System.Drawing.Size(23, 25)
        Me.lbMonOM.TabIndex = 56
        Me.lbMonOM.Text = "0"
        Me.lbMonOM.Visible = False
        '
        'lbMonOH
        '
        Me.lbMonOH.AutoSize = True
        Me.lbMonOH.Location = New System.Drawing.Point(690, 214)
        Me.lbMonOH.Name = "lbMonOH"
        Me.lbMonOH.Size = New System.Drawing.Size(23, 25)
        Me.lbMonOH.TabIndex = 57
        Me.lbMonOH.Text = "0"
        Me.lbMonOH.Visible = False
        '
        'lbSunUM
        '
        Me.lbSunUM.AutoSize = True
        Me.lbSunUM.Location = New System.Drawing.Point(959, 163)
        Me.lbSunUM.Name = "lbSunUM"
        Me.lbSunUM.Size = New System.Drawing.Size(23, 25)
        Me.lbSunUM.TabIndex = 58
        Me.lbSunUM.Text = "0"
        Me.lbSunUM.Visible = False
        '
        'lbSunUH
        '
        Me.lbSunUH.AutoSize = True
        Me.lbSunUH.Location = New System.Drawing.Point(910, 163)
        Me.lbSunUH.Name = "lbSunUH"
        Me.lbSunUH.Size = New System.Drawing.Size(23, 25)
        Me.lbSunUH.TabIndex = 59
        Me.lbSunUH.Text = "0"
        Me.lbSunUH.Visible = False
        '
        'lbSunLM
        '
        Me.lbSunLM.AutoSize = True
        Me.lbSunLM.Location = New System.Drawing.Point(848, 163)
        Me.lbSunLM.Name = "lbSunLM"
        Me.lbSunLM.Size = New System.Drawing.Size(23, 25)
        Me.lbSunLM.TabIndex = 60
        Me.lbSunLM.Text = "0"
        Me.lbSunLM.Visible = False
        '
        'lbSunLH
        '
        Me.lbSunLH.AutoSize = True
        Me.lbSunLH.Location = New System.Drawing.Point(804, 163)
        Me.lbSunLH.Name = "lbSunLH"
        Me.lbSunLH.Size = New System.Drawing.Size(23, 25)
        Me.lbSunLH.TabIndex = 61
        Me.lbSunLH.Text = "0"
        Me.lbSunLH.Visible = False
        '
        'lbSunOM
        '
        Me.lbSunOM.AutoSize = True
        Me.lbSunOM.Location = New System.Drawing.Point(739, 163)
        Me.lbSunOM.Name = "lbSunOM"
        Me.lbSunOM.Size = New System.Drawing.Size(23, 25)
        Me.lbSunOM.TabIndex = 62
        Me.lbSunOM.Text = "0"
        Me.lbSunOM.Visible = False
        '
        'lbSunOH
        '
        Me.lbSunOH.AutoSize = True
        Me.lbSunOH.Location = New System.Drawing.Point(690, 163)
        Me.lbSunOH.Name = "lbSunOH"
        Me.lbSunOH.Size = New System.Drawing.Size(23, 25)
        Me.lbSunOH.TabIndex = 63
        Me.lbSunOH.Text = "0"
        Me.lbSunOH.Visible = False
        '
        'lbSatUM
        '
        Me.lbSatUM.AutoSize = True
        Me.lbSatUM.Location = New System.Drawing.Point(959, 113)
        Me.lbSatUM.Name = "lbSatUM"
        Me.lbSatUM.Size = New System.Drawing.Size(23, 25)
        Me.lbSatUM.TabIndex = 50
        Me.lbSatUM.Text = "0"
        Me.lbSatUM.Visible = False
        '
        'lbSatUH
        '
        Me.lbSatUH.AutoSize = True
        Me.lbSatUH.Location = New System.Drawing.Point(910, 113)
        Me.lbSatUH.Name = "lbSatUH"
        Me.lbSatUH.Size = New System.Drawing.Size(23, 25)
        Me.lbSatUH.TabIndex = 51
        Me.lbSatUH.Text = "0"
        Me.lbSatUH.Visible = False
        '
        'lbSatLM
        '
        Me.lbSatLM.AutoSize = True
        Me.lbSatLM.Location = New System.Drawing.Point(848, 113)
        Me.lbSatLM.Name = "lbSatLM"
        Me.lbSatLM.Size = New System.Drawing.Size(23, 25)
        Me.lbSatLM.TabIndex = 52
        Me.lbSatLM.Text = "0"
        Me.lbSatLM.Visible = False
        '
        'lbSatLH
        '
        Me.lbSatLH.AutoSize = True
        Me.lbSatLH.Location = New System.Drawing.Point(804, 113)
        Me.lbSatLH.Name = "lbSatLH"
        Me.lbSatLH.Size = New System.Drawing.Size(23, 25)
        Me.lbSatLH.TabIndex = 53
        Me.lbSatLH.Text = "0"
        Me.lbSatLH.Visible = False
        '
        'lbSatOM
        '
        Me.lbSatOM.AutoSize = True
        Me.lbSatOM.Location = New System.Drawing.Point(739, 113)
        Me.lbSatOM.Name = "lbSatOM"
        Me.lbSatOM.Size = New System.Drawing.Size(23, 25)
        Me.lbSatOM.TabIndex = 54
        Me.lbSatOM.Text = "0"
        Me.lbSatOM.Visible = False
        '
        'lbSatOH
        '
        Me.lbSatOH.AutoSize = True
        Me.lbSatOH.Location = New System.Drawing.Point(690, 113)
        Me.lbSatOH.Name = "lbSatOH"
        Me.lbSatOH.Size = New System.Drawing.Size(23, 25)
        Me.lbSatOH.TabIndex = 55
        Me.lbSatOH.Text = "0"
        Me.lbSatOH.Visible = False
        '
        'lbFriUM
        '
        Me.lbFriUM.AutoSize = True
        Me.lbFriUM.Location = New System.Drawing.Point(959, 54)
        Me.lbFriUM.Name = "lbFriUM"
        Me.lbFriUM.Size = New System.Drawing.Size(23, 25)
        Me.lbFriUM.TabIndex = 56
        Me.lbFriUM.Text = "0"
        Me.lbFriUM.Visible = False
        '
        'lbFriUH
        '
        Me.lbFriUH.AutoSize = True
        Me.lbFriUH.Location = New System.Drawing.Point(910, 54)
        Me.lbFriUH.Name = "lbFriUH"
        Me.lbFriUH.Size = New System.Drawing.Size(23, 25)
        Me.lbFriUH.TabIndex = 57
        Me.lbFriUH.Text = "0"
        Me.lbFriUH.Visible = False
        '
        'lbFriLM
        '
        Me.lbFriLM.AutoSize = True
        Me.lbFriLM.Location = New System.Drawing.Point(848, 54)
        Me.lbFriLM.Name = "lbFriLM"
        Me.lbFriLM.Size = New System.Drawing.Size(23, 25)
        Me.lbFriLM.TabIndex = 58
        Me.lbFriLM.Text = "0"
        Me.lbFriLM.Visible = False
        '
        'lbFriLH
        '
        Me.lbFriLH.AutoSize = True
        Me.lbFriLH.Location = New System.Drawing.Point(804, 54)
        Me.lbFriLH.Name = "lbFriLH"
        Me.lbFriLH.Size = New System.Drawing.Size(23, 25)
        Me.lbFriLH.TabIndex = 59
        Me.lbFriLH.Text = "0"
        Me.lbFriLH.Visible = False
        '
        'lbFriOM
        '
        Me.lbFriOM.AutoSize = True
        Me.lbFriOM.Location = New System.Drawing.Point(739, 54)
        Me.lbFriOM.Name = "lbFriOM"
        Me.lbFriOM.Size = New System.Drawing.Size(23, 25)
        Me.lbFriOM.TabIndex = 60
        Me.lbFriOM.Text = "0"
        Me.lbFriOM.Visible = False
        '
        'lbFriOH
        '
        Me.lbFriOH.AutoSize = True
        Me.lbFriOH.Location = New System.Drawing.Point(690, 54)
        Me.lbFriOH.Name = "lbFriOH"
        Me.lbFriOH.Size = New System.Drawing.Size(23, 25)
        Me.lbFriOH.TabIndex = 43
        Me.lbFriOH.Text = "0"
        Me.lbFriOH.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label25, 2)
        Me.Label25.Location = New System.Drawing.Point(910, 1)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 50)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Undertime" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hr/mins"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFriDate
        '
        Me.lblFriDate.AutoSize = True
        Me.lblFriDate.Location = New System.Drawing.Point(190, 54)
        Me.lblFriDate.Name = "lblFriDate"
        Me.lblFriDate.Size = New System.Drawing.Size(50, 25)
        Me.lblFriDate.TabIndex = 43
        Me.lblFriDate.Text = "date"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label24, 2)
        Me.Label24.Location = New System.Drawing.Point(804, 1)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 50)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Late" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hr/mins"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSatDate
        '
        Me.lblSatDate.AutoSize = True
        Me.lblSatDate.Location = New System.Drawing.Point(190, 113)
        Me.lblSatDate.Name = "lblSatDate"
        Me.lblSatDate.Size = New System.Drawing.Size(50, 25)
        Me.lblSatDate.TabIndex = 44
        Me.lblSatDate.Text = "date"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label23, 2)
        Me.Label23.Location = New System.Drawing.Point(690, 1)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 50)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Overtime" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hr/mins"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSunDate
        '
        Me.lblSunDate.AutoSize = True
        Me.lblSunDate.Location = New System.Drawing.Point(190, 163)
        Me.lblSunDate.Name = "lblSunDate"
        Me.lblSunDate.Size = New System.Drawing.Size(50, 25)
        Me.lblSunDate.TabIndex = 45
        Me.lblSunDate.Text = "date"
        '
        'lblMonDate
        '
        Me.lblMonDate.AutoSize = True
        Me.lblMonDate.Location = New System.Drawing.Point(190, 214)
        Me.lblMonDate.Name = "lblMonDate"
        Me.lblMonDate.Size = New System.Drawing.Size(50, 25)
        Me.lblMonDate.TabIndex = 46
        Me.lblMonDate.Text = "date"
        '
        'lblTueDate
        '
        Me.lblTueDate.AutoSize = True
        Me.lblTueDate.Location = New System.Drawing.Point(190, 268)
        Me.lblTueDate.Name = "lblTueDate"
        Me.lblTueDate.Size = New System.Drawing.Size(50, 25)
        Me.lblTueDate.TabIndex = 47
        Me.lblTueDate.Text = "date"
        '
        'lblWedDate
        '
        Me.lblWedDate.AutoSize = True
        Me.lblWedDate.Location = New System.Drawing.Point(190, 320)
        Me.lblWedDate.Name = "lblWedDate"
        Me.lblWedDate.Size = New System.Drawing.Size(50, 25)
        Me.lblWedDate.TabIndex = 48
        Me.lblWedDate.Text = "date"
        '
        'lblThuDate
        '
        Me.lblThuDate.AutoSize = True
        Me.lblThuDate.Location = New System.Drawing.Point(190, 375)
        Me.lblThuDate.Name = "lblThuDate"
        Me.lblThuDate.Size = New System.Drawing.Size(50, 25)
        Me.lblThuDate.TabIndex = 49
        Me.lblThuDate.Text = "date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(190, 1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 25)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(50, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 25)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Day of week"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 25)
        Me.Label13.TabIndex = 43
        '
        'chkFri
        '
        Me.chkFri.AutoSize = True
        Me.chkFri.Checked = True
        Me.chkFri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFri.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkFri.Location = New System.Drawing.Point(4, 57)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(39, 21)
        Me.chkFri.TabIndex = 5
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Friday"
        '
        'cmbFriIn
        '
        Me.cmbFriIn.CustomFormat = "hh:mm tt"
        Me.cmbFriIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbFriIn.Location = New System.Drawing.Point(332, 57)
        Me.cmbFriIn.Name = "cmbFriIn"
        Me.cmbFriIn.ShowUpDown = True
        Me.cmbFriIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbFriIn.TabIndex = 6
        Me.cmbFriIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbThuOut
        '
        Me.cmbThuOut.CustomFormat = "hh:mm tt"
        Me.cmbThuOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbThuOut.Location = New System.Drawing.Point(522, 378)
        Me.cmbThuOut.Name = "cmbThuOut"
        Me.cmbThuOut.ShowUpDown = True
        Me.cmbThuOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbThuOut.TabIndex = 25
        Me.cmbThuOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'cmbThuIn
        '
        Me.cmbThuIn.CustomFormat = "hh:mm tt"
        Me.cmbThuIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbThuIn.Location = New System.Drawing.Point(332, 378)
        Me.cmbThuIn.Name = "cmbThuIn"
        Me.cmbThuIn.ShowUpDown = True
        Me.cmbThuIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbThuIn.TabIndex = 24
        Me.cmbThuIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbSunIn
        '
        Me.cmbSunIn.CustomFormat = "hh:mm tt"
        Me.cmbSunIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbSunIn.Location = New System.Drawing.Point(332, 166)
        Me.cmbSunIn.Name = "cmbSunIn"
        Me.cmbSunIn.ShowUpDown = True
        Me.cmbSunIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbSunIn.TabIndex = 12
        Me.cmbSunIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbSunOut
        '
        Me.cmbSunOut.CustomFormat = "hh:mm tt"
        Me.cmbSunOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbSunOut.Location = New System.Drawing.Point(522, 166)
        Me.cmbSunOut.Name = "cmbSunOut"
        Me.cmbSunOut.ShowUpDown = True
        Me.cmbSunOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbSunOut.TabIndex = 13
        Me.cmbSunOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'cmbWedOut
        '
        Me.cmbWedOut.CustomFormat = "hh:mm tt"
        Me.cmbWedOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbWedOut.Location = New System.Drawing.Point(522, 323)
        Me.cmbWedOut.Name = "cmbWedOut"
        Me.cmbWedOut.ShowUpDown = True
        Me.cmbWedOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbWedOut.TabIndex = 22
        Me.cmbWedOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'cmbWedIn
        '
        Me.cmbWedIn.CustomFormat = "hh:mm tt"
        Me.cmbWedIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbWedIn.Location = New System.Drawing.Point(332, 323)
        Me.cmbWedIn.Name = "cmbWedIn"
        Me.cmbWedIn.ShowUpDown = True
        Me.cmbWedIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbWedIn.TabIndex = 21
        Me.cmbWedIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbTueOut
        '
        Me.cmbTueOut.CustomFormat = "hh:mm tt"
        Me.cmbTueOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbTueOut.Location = New System.Drawing.Point(522, 271)
        Me.cmbTueOut.Name = "cmbTueOut"
        Me.cmbTueOut.ShowUpDown = True
        Me.cmbTueOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbTueOut.TabIndex = 19
        Me.cmbTueOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'cmbMonOut
        '
        Me.cmbMonOut.CustomFormat = "hh:mm tt"
        Me.cmbMonOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbMonOut.Location = New System.Drawing.Point(522, 217)
        Me.cmbMonOut.Name = "cmbMonOut"
        Me.cmbMonOut.ShowUpDown = True
        Me.cmbMonOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbMonOut.TabIndex = 16
        Me.cmbMonOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'cmbSatOut
        '
        Me.cmbSatOut.CustomFormat = "hh:mm tt"
        Me.cmbSatOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbSatOut.Location = New System.Drawing.Point(522, 116)
        Me.cmbSatOut.Name = "cmbSatOut"
        Me.cmbSatOut.ShowUpDown = True
        Me.cmbSatOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbSatOut.TabIndex = 10
        Me.cmbSatOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'cmbTueIn
        '
        Me.cmbTueIn.CustomFormat = "hh:mm tt"
        Me.cmbTueIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbTueIn.Location = New System.Drawing.Point(332, 271)
        Me.cmbTueIn.Name = "cmbTueIn"
        Me.cmbTueIn.ShowUpDown = True
        Me.cmbTueIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbTueIn.TabIndex = 18
        Me.cmbTueIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbMonIn
        '
        Me.cmbMonIn.CustomFormat = "hh:mm tt"
        Me.cmbMonIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbMonIn.Location = New System.Drawing.Point(332, 217)
        Me.cmbMonIn.Name = "cmbMonIn"
        Me.cmbMonIn.ShowUpDown = True
        Me.cmbMonIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbMonIn.TabIndex = 15
        Me.cmbMonIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbSatIn
        '
        Me.cmbSatIn.CustomFormat = "hh:mm tt"
        Me.cmbSatIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbSatIn.Location = New System.Drawing.Point(332, 116)
        Me.cmbSatIn.Name = "cmbSatIn"
        Me.cmbSatIn.ShowUpDown = True
        Me.cmbSatIn.Size = New System.Drawing.Size(183, 30)
        Me.cmbSatIn.TabIndex = 9
        Me.cmbSatIn.Value = New Date(2020, 3, 16, 8, 0, 0, 0)
        '
        'cmbFriOut
        '
        Me.cmbFriOut.CustomFormat = "hh:mm tt"
        Me.cmbFriOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbFriOut.Location = New System.Drawing.Point(522, 57)
        Me.cmbFriOut.Name = "cmbFriOut"
        Me.cmbFriOut.ShowUpDown = True
        Me.cmbFriOut.Size = New System.Drawing.Size(161, 30)
        Me.cmbFriOut.TabIndex = 7
        Me.cmbFriOut.Value = New Date(2020, 3, 16, 17, 0, 0, 0)
        '
        'chkThu
        '
        Me.chkThu.AutoSize = True
        Me.chkThu.Checked = True
        Me.chkThu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkThu.Location = New System.Drawing.Point(4, 378)
        Me.chkThu.Name = "chkThu"
        Me.chkThu.Size = New System.Drawing.Size(22, 21)
        Me.chkThu.TabIndex = 23
        Me.chkThu.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 375)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Thursday"
        '
        'chkWed
        '
        Me.chkWed.AutoSize = True
        Me.chkWed.Checked = True
        Me.chkWed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWed.Location = New System.Drawing.Point(4, 323)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(22, 21)
        Me.chkWed.TabIndex = 20
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Wednesday"
        '
        'chkTue
        '
        Me.chkTue.AutoSize = True
        Me.chkTue.Checked = True
        Me.chkTue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTue.Location = New System.Drawing.Point(4, 271)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(22, 21)
        Me.chkTue.TabIndex = 17
        Me.chkTue.UseVisualStyleBackColor = True
        '
        'chkMon
        '
        Me.chkMon.AutoSize = True
        Me.chkMon.Checked = True
        Me.chkMon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMon.Location = New System.Drawing.Point(4, 217)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(22, 21)
        Me.chkMon.TabIndex = 14
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Monday"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tuesday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Sunday"
        '
        'chkSun
        '
        Me.chkSun.AutoSize = True
        Me.chkSun.Checked = True
        Me.chkSun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSun.Location = New System.Drawing.Point(4, 166)
        Me.chkSun.Name = "chkSun"
        Me.chkSun.Size = New System.Drawing.Size(22, 21)
        Me.chkSun.TabIndex = 11
        Me.chkSun.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Saturday"
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.Checked = True
        Me.chkSat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSat.Location = New System.Drawing.Point(4, 116)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(22, 21)
        Me.chkSat.TabIndex = 8
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.lblTotalLate)
        Me.GroupBox2.Controls.Add(Me.lblTotalUndertime)
        Me.GroupBox2.Controls.Add(Me.lblTotalOvertime)
        Me.GroupBox2.Controls.Add(Me.lblTotalDays)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 538)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 286)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Timesheet Summary"
        '
        'lblTotalLate
        '
        Me.lblTotalLate.AutoSize = True
        Me.lblTotalLate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalLate.Location = New System.Drawing.Point(280, 225)
        Me.lblTotalLate.Name = "lblTotalLate"
        Me.lblTotalLate.Size = New System.Drawing.Size(32, 32)
        Me.lblTotalLate.TabIndex = 7
        Me.lblTotalLate.Text = "0"
        '
        'lblTotalUndertime
        '
        Me.lblTotalUndertime.AutoSize = True
        Me.lblTotalUndertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalUndertime.Location = New System.Drawing.Point(280, 173)
        Me.lblTotalUndertime.Name = "lblTotalUndertime"
        Me.lblTotalUndertime.Size = New System.Drawing.Size(32, 32)
        Me.lblTotalUndertime.TabIndex = 6
        Me.lblTotalUndertime.Text = "0"
        '
        'lblTotalOvertime
        '
        Me.lblTotalOvertime.AutoSize = True
        Me.lblTotalOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalOvertime.Location = New System.Drawing.Point(280, 111)
        Me.lblTotalOvertime.Name = "lblTotalOvertime"
        Me.lblTotalOvertime.Size = New System.Drawing.Size(32, 32)
        Me.lblTotalOvertime.TabIndex = 5
        Me.lblTotalOvertime.Text = "0"
        '
        'lblTotalDays
        '
        Me.lblTotalDays.AutoSize = True
        Me.lblTotalDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDays.Location = New System.Drawing.Point(280, 60)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(32, 32)
        Me.lblTotalDays.TabIndex = 4
        Me.lblTotalDays.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(160, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 29)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Total Late:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(94, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 29)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Total Undertime:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(108, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 29)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Overtime:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total days of work:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 144)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(907, 819)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdCreateTimesheet)
        Me.TabPage1.Controls.Add(Me.UnsubmittedGrid)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(899, 786)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Timesheet"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmdCreateTimesheet
        '
        Me.cmdCreateTimesheet.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmdCreateTimesheet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdCreateTimesheet.Location = New System.Drawing.Point(15, 14)
        Me.cmdCreateTimesheet.Name = "cmdCreateTimesheet"
        Me.cmdCreateTimesheet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCreateTimesheet.Size = New System.Drawing.Size(258, 54)
        Me.cmdCreateTimesheet.TabIndex = 3
        Me.cmdCreateTimesheet.Text = "Create Timesheet"
        Me.cmdCreateTimesheet.UseVisualStyleBackColor = False
        '
        'UnsubmittedGrid
        '
        Me.UnsubmittedGrid.AllowUserToAddRows = False
        Me.UnsubmittedGrid.AllowUserToDeleteRows = False
        Me.UnsubmittedGrid.AutoGenerateColumns = False
        Me.UnsubmittedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UnsubmittedGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EmpnumDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn})
        Me.UnsubmittedGrid.DataSource = Me.EmployeeBindingSource
        Me.UnsubmittedGrid.Location = New System.Drawing.Point(3, 86)
        Me.UnsubmittedGrid.MultiSelect = False
        Me.UnsubmittedGrid.Name = "UnsubmittedGrid"
        Me.UnsubmittedGrid.ReadOnly = True
        Me.UnsubmittedGrid.RowHeadersWidth = 62
        Me.UnsubmittedGrid.RowTemplate.Height = 28
        Me.UnsubmittedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UnsubmittedGrid.Size = New System.Drawing.Size(890, 677)
        Me.UnsubmittedGrid.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'EmpnumDataGridViewTextBoxColumn
        '
        Me.EmpnumDataGridViewTextBoxColumn.DataPropertyName = "emp_num"
        Me.EmpnumDataGridViewTextBoxColumn.HeaderText = "Employee Number"
        Me.EmpnumDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmpnumDataGridViewTextBoxColumn.Name = "EmpnumDataGridViewTextBoxColumn"
        Me.EmpnumDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpnumDataGridViewTextBoxColumn.Width = 150
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Last name"
        Me.LnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LnameDataGridViewTextBoxColumn.Width = 150
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "First name"
        Me.FnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn.Width = 150
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MnameDataGridViewTextBoxColumn.Width = 150
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.PayrollDataSet2
        '
        'PayrollDataSet2
        '
        Me.PayrollDataSet2.DataSetName = "payrollDataSet2"
        Me.PayrollDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmdEdit)
        Me.TabPage2.Controls.Add(Me.SubmittedGrid)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(899, 786)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Submitted Timesheets"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.SystemColors.Highlight
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdEdit.Location = New System.Drawing.Point(16, 15)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(258, 54)
        Me.cmdEdit.TabIndex = 4
        Me.cmdEdit.Text = "Edit Timesheet"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'SubmittedGrid
        '
        Me.SubmittedGrid.AllowUserToAddRows = False
        Me.SubmittedGrid.AllowUserToDeleteRows = False
        Me.SubmittedGrid.AutoGenerateColumns = False
        Me.SubmittedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubmittedGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.EmpnumDataGridViewTextBoxColumn1, Me.LnameDataGridViewTextBoxColumn1, Me.FnameDataGridViewTextBoxColumn1, Me.MnameDataGridViewTextBoxColumn1})
        Me.SubmittedGrid.DataSource = Me.EmployeeBindingSource
        Me.SubmittedGrid.Location = New System.Drawing.Point(4, 86)
        Me.SubmittedGrid.MultiSelect = False
        Me.SubmittedGrid.Name = "SubmittedGrid"
        Me.SubmittedGrid.ReadOnly = True
        Me.SubmittedGrid.RowHeadersWidth = 62
        Me.SubmittedGrid.RowTemplate.Height = 28
        Me.SubmittedGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SubmittedGrid.Size = New System.Drawing.Size(890, 677)
        Me.SubmittedGrid.TabIndex = 11
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Width = 150
        '
        'EmpnumDataGridViewTextBoxColumn1
        '
        Me.EmpnumDataGridViewTextBoxColumn1.DataPropertyName = "emp_num"
        Me.EmpnumDataGridViewTextBoxColumn1.HeaderText = "Employee Number"
        Me.EmpnumDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.EmpnumDataGridViewTextBoxColumn1.Name = "EmpnumDataGridViewTextBoxColumn1"
        Me.EmpnumDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EmpnumDataGridViewTextBoxColumn1.Width = 150
        '
        'LnameDataGridViewTextBoxColumn1
        '
        Me.LnameDataGridViewTextBoxColumn1.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn1.HeaderText = "Last name"
        Me.LnameDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.LnameDataGridViewTextBoxColumn1.Name = "LnameDataGridViewTextBoxColumn1"
        Me.LnameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.LnameDataGridViewTextBoxColumn1.Width = 150
        '
        'FnameDataGridViewTextBoxColumn1
        '
        Me.FnameDataGridViewTextBoxColumn1.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn1.HeaderText = "First name"
        Me.FnameDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.FnameDataGridViewTextBoxColumn1.Name = "FnameDataGridViewTextBoxColumn1"
        Me.FnameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.FnameDataGridViewTextBoxColumn1.Width = 150
        '
        'MnameDataGridViewTextBoxColumn1
        '
        Me.MnameDataGridViewTextBoxColumn1.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn1.HeaderText = "Middle name"
        Me.MnameDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.MnameDataGridViewTextBoxColumn1.Name = "MnameDataGridViewTextBoxColumn1"
        Me.MnameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MnameDataGridViewTextBoxColumn1.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Timesheet for"
        '
        'cmbCutoff
        '
        Me.cmbCutoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCutoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cmbCutoff.FormattingEnabled = True
        Me.cmbCutoff.Location = New System.Drawing.Point(237, 57)
        Me.cmbCutoff.Name = "cmbCutoff"
        Me.cmbCutoff.Size = New System.Drawing.Size(449, 45)
        Me.cmbCutoff.TabIndex = 4
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'PayrollDataSet3
        '
        Me.PayrollDataSet3.DataSetName = "payrollDataSet3"
        Me.PayrollDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CutoffBindingSource
        '
        Me.CutoffBindingSource.DataMember = "Cutoff"
        Me.CutoffBindingSource.DataSource = Me.PayrollDataSet3
        '
        'CutoffTableAdapter
        '
        Me.CutoffTableAdapter.ClearBeforeFill = True
        '
        'lblCutoffID
        '
        Me.lblCutoffID.AutoSize = True
        Me.lblCutoffID.Location = New System.Drawing.Point(821, 41)
        Me.lblCutoffID.Name = "lblCutoffID"
        Me.lblCutoffID.Size = New System.Drawing.Size(62, 20)
        Me.lblCutoffID.TabIndex = 5
        Me.lblCutoffID.Text = "cutoffid"
        Me.lblCutoffID.Visible = False
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(821, 82)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(111, 20)
        Me.lblEmployeeID.TabIndex = 6
        Me.lblEmployeeID.Text = "lblEmployeeID"
        Me.lblEmployeeID.Visible = False
        '
        'frmTimesheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(3147, 1234)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.lblCutoffID)
        Me.Controls.Add(Me.cmbCutoff)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpTimesheet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimesheet"
        Me.Text = "frmTimesheet"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpTimesheet.ResumeLayout(False)
        Me.grpTimesheet.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.UnsubmittedGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.SubmittedGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CutoffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpTimesheet As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents UnsubmittedGrid As DataGridView
    Friend WithEvents cmdCreateTimesheet As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents SubmittedGrid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalLate As Label
    Friend WithEvents lblTotalUndertime As Label
    Friend WithEvents lblTotalOvertime As Label
    Friend WithEvents lblTotalDays As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chkThu As CheckBox
    Friend WithEvents chkWed As CheckBox
    Friend WithEvents chkTue As CheckBox
    Friend WithEvents chkMon As CheckBox
    Friend WithEvents chkSun As CheckBox
    Friend WithEvents chkSat As CheckBox
    Friend WithEvents cmbThuOut As DateTimePicker
    Friend WithEvents cmbThuIn As DateTimePicker
    Friend WithEvents cmbWedOut As DateTimePicker
    Friend WithEvents cmbWedIn As DateTimePicker
    Friend WithEvents cmbTueOut As DateTimePicker
    Friend WithEvents cmbTueIn As DateTimePicker
    Friend WithEvents cmbMonOut As DateTimePicker
    Friend WithEvents cmbMonIn As DateTimePicker
    Friend WithEvents cmbSunOut As DateTimePicker
    Friend WithEvents cmbSunIn As DateTimePicker
    Friend WithEvents cmbSatOut As DateTimePicker
    Friend WithEvents cmbSatIn As DateTimePicker
    Friend WithEvents cmbFriOut As DateTimePicker
    Friend WithEvents cmbFriIn As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chkFri As CheckBox
    Friend WithEvents lblFriDate As Label
    Friend WithEvents lblSatDate As Label
    Friend WithEvents lblSunDate As Label
    Friend WithEvents lblMonDate As Label
    Friend WithEvents lblTueDate As Label
    Friend WithEvents lblWedDate As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents lbThuUM As Label
    Friend WithEvents lbThuUH As Label
    Friend WithEvents lbThuLM As Label
    Friend WithEvents lbThuLH As Label
    Friend WithEvents lbThuOM As Label
    Friend WithEvents lbThuOH As Label
    Friend WithEvents lbWedUM As Label
    Friend WithEvents lbWedLM As Label
    Friend WithEvents lbWedUH As Label
    Friend WithEvents lbWedLH As Label
    Friend WithEvents lbTueUM As Label
    Friend WithEvents lbWedOM As Label
    Friend WithEvents lbWedOH As Label
    Friend WithEvents lbTueUH As Label
    Friend WithEvents lbTueLM As Label
    Friend WithEvents lbTueLH As Label
    Friend WithEvents lbTueOM As Label
    Friend WithEvents lbTueOH As Label
    Friend WithEvents lbMonUM As Label
    Friend WithEvents lbMonUH As Label
    Friend WithEvents lbMonLM As Label
    Friend WithEvents lbMonLH As Label
    Friend WithEvents lbMonOM As Label
    Friend WithEvents lbMonOH As Label
    Friend WithEvents lbSunUM As Label
    Friend WithEvents lbSunUH As Label
    Friend WithEvents lbSunLM As Label
    Friend WithEvents lbSunLH As Label
    Friend WithEvents lbSunOM As Label
    Friend WithEvents lbSunOH As Label
    Friend WithEvents lbSatUM As Label
    Friend WithEvents lbSatUH As Label
    Friend WithEvents lbSatLM As Label
    Friend WithEvents lbSatLH As Label
    Friend WithEvents lbSatOM As Label
    Friend WithEvents lbSatOH As Label
    Friend WithEvents lbFriUM As Label
    Friend WithEvents lbFriUH As Label
    Friend WithEvents lbFriLM As Label
    Friend WithEvents lbFriLH As Label
    Friend WithEvents lbFriOM As Label
    Friend WithEvents lbFriOH As Label
    Friend WithEvents lblThuDate As Label
    Friend WithEvents cmbCutoff As ComboBox
    Friend WithEvents PayrollDataSet2 As payrollDataSet2
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As payrollDataSet2TableAdapters.EmployeeTableAdapter
    Friend WithEvents PayrollDataSet3 As payrollDataSet3
    Friend WithEvents CutoffBindingSource As BindingSource
    Friend WithEvents CutoffTableAdapter As payrollDataSet3TableAdapters.CutoffTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmpnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EmpnumDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents cmdSave As Button
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblCutoffID As Label
    Friend WithEvents lblEmployeeID As Label
End Class
