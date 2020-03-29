<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.menuTimesheet = New System.Windows.Forms.MenuStrip()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEmp201 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHolidays = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimesheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutoffScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessPayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneratePayslipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menuTimesheet.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuTimesheet
        '
        Me.menuTimesheet.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.menuTimesheet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageToolStripMenuItem, Me.TimesheetToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.menuAbout})
        Me.menuTimesheet.Location = New System.Drawing.Point(0, 0)
        Me.menuTimesheet.Name = "menuTimesheet"
        Me.menuTimesheet.Size = New System.Drawing.Size(2574, 33)
        Me.menuTimesheet.TabIndex = 0
        Me.menuTimesheet.Text = "MenuStrip1"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEmp201, Me.menuHolidays})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'menuEmp201
        '
        Me.menuEmp201.Name = "menuEmp201"
        Me.menuEmp201.Size = New System.Drawing.Size(227, 34)
        Me.menuEmp201.Text = "Employee 201"
        '
        'menuHolidays
        '
        Me.menuHolidays.Name = "menuHolidays"
        Me.menuHolidays.Size = New System.Drawing.Size(227, 34)
        Me.menuHolidays.Text = "Holidays"
        '
        'TimesheetToolStripMenuItem
        '
        Me.TimesheetToolStripMenuItem.Name = "TimesheetToolStripMenuItem"
        Me.TimesheetToolStripMenuItem.Size = New System.Drawing.Size(108, 29)
        Me.TimesheetToolStripMenuItem.Text = "Timesheet"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutoffScheduleToolStripMenuItem, Me.ProcessPayrollToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'CutoffScheduleToolStripMenuItem
        '
        Me.CutoffScheduleToolStripMenuItem.Name = "CutoffScheduleToolStripMenuItem"
        Me.CutoffScheduleToolStripMenuItem.Size = New System.Drawing.Size(240, 34)
        Me.CutoffScheduleToolStripMenuItem.Text = "Cutoff Schedule"
        '
        'ProcessPayrollToolStripMenuItem
        '
        Me.ProcessPayrollToolStripMenuItem.Name = "ProcessPayrollToolStripMenuItem"
        Me.ProcessPayrollToolStripMenuItem.Size = New System.Drawing.Size(240, 34)
        Me.ProcessPayrollToolStripMenuItem.Text = "Process Payroll"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneratePayslipToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'GeneratePayslipToolStripMenuItem
        '
        Me.GeneratePayslipToolStripMenuItem.Name = "GeneratePayslipToolStripMenuItem"
        Me.GeneratePayslipToolStripMenuItem.Size = New System.Drawing.Size(168, 34)
        Me.GeneratePayslipToolStripMenuItem.Text = "Payslip"
        '
        'menuAbout
        '
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(78, 29)
        Me.menuAbout.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = Global.Payroll.My.Resources.Resources.login_bg
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2562, 1177)
        Me.Panel1.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(2574, 1224)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.menuTimesheet)
        Me.MainMenuStrip = Me.menuTimesheet
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll System | Account Login"
        Me.menuTimesheet.ResumeLayout(False)
        Me.menuTimesheet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuTimesheet As MenuStrip
    Friend WithEvents menuAbout As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuEmp201 As ToolStripMenuItem
    Friend WithEvents menuHolidays As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneratePayslipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimesheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CutoffScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcessPayrollToolStripMenuItem As ToolStripMenuItem
End Class
