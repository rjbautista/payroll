<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmdProcess = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCutoff = New System.Windows.Forms.ComboBox()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.payrollDataSet6 = New Payroll.payrollDataSet6()
        Me.DataTable1TableAdapter = New Payroll.payrollDataSet6TableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Payroll.Payslip.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 147)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1062, 1155)
        Me.ReportViewer1.TabIndex = 0
        '
        'cmdProcess
        '
        Me.cmdProcess.Enabled = False
        Me.cmdProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdProcess.Location = New System.Drawing.Point(797, 57)
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.Size = New System.Drawing.Size(183, 50)
        Me.cmdProcess.TabIndex = 11
        Me.cmdProcess.Text = "View Payslip"
        Me.cmdProcess.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(15, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Payroll Period"
        '
        'cmbCutoff
        '
        Me.cmbCutoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCutoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cmbCutoff.FormattingEnabled = True
        Me.cmbCutoff.Location = New System.Drawing.Point(342, 60)
        Me.cmbCutoff.Name = "cmbCutoff"
        Me.cmbCutoff.Size = New System.Drawing.Size(449, 45)
        Me.cmbCutoff.TabIndex = 9
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.payrollDataSet6
        '
        'payrollDataSet6
        '
        Me.payrollDataSet6.DataSetName = "payrollDataSet6"
        Me.payrollDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 1314)
        Me.Controls.Add(Me.cmdProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCutoff)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrint"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents payrollDataSet6 As payrollDataSet6
    Friend WithEvents DataTable1TableAdapter As payrollDataSet6TableAdapters.DataTable1TableAdapter
    Friend WithEvents cmdProcess As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCutoff As ComboBox
End Class
