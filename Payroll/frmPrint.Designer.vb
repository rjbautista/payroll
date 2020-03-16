<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.payrollDataSet6 = New Payroll.payrollDataSet6()
        Me.PayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollTableAdapter = New Payroll.payrollDataSet6TableAdapters.PayrollTableAdapter()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Payroll.payrollDataSet6TableAdapters.EmployeeTableAdapter()
        CType(Me.payrollDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PayrollBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.EmployeeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Payroll.Payslip.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 14)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1597, 955)
        Me.ReportViewer1.TabIndex = 0
        '
        'payrollDataSet6
        '
        Me.payrollDataSet6.DataSetName = "payrollDataSet6"
        Me.payrollDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PayrollBindingSource
        '
        Me.PayrollBindingSource.DataMember = "Payroll"
        Me.PayrollBindingSource.DataSource = Me.payrollDataSet6
        '
        'PayrollTableAdapter
        '
        Me.PayrollTableAdapter.ClearBeforeFill = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.payrollDataSet6
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1606, 970)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrint"
        Me.Text = "frmPrint"
        CType(Me.payrollDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PayrollBindingSource As BindingSource
    Friend WithEvents payrollDataSet6 As payrollDataSet6
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents PayrollTableAdapter As payrollDataSet6TableAdapters.PayrollTableAdapter
    Friend WithEvents EmployeeTableAdapter As payrollDataSet6TableAdapters.EmployeeTableAdapter
End Class
