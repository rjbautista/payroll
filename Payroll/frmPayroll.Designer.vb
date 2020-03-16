<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayroll
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
        Me.cmbCutoff = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.payrollGrid = New System.Windows.Forms.DataGridView()
        Me.middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotallateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaldowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimesheetHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollDataSet4 = New Payroll.payrollDataSet4()
        Me.TimesheetHeaderTableAdapter = New Payroll.payrollDataSet4TableAdapters.TimesheetHeaderTableAdapter()
        Me.cmdProcess = New System.Windows.Forms.Button()
        CType(Me.payrollGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimesheetHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCutoff
        '
        Me.cmbCutoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCutoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.cmbCutoff.FormattingEnabled = True
        Me.cmbCutoff.Location = New System.Drawing.Point(371, 38)
        Me.cmbCutoff.Name = "cmbCutoff"
        Me.cmbCutoff.Size = New System.Drawing.Size(449, 45)
        Me.cmbCutoff.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(44, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Payroll Period"
        '
        'payrollGrid
        '
        Me.payrollGrid.AllowUserToAddRows = False
        Me.payrollGrid.AllowUserToDeleteRows = False
        Me.payrollGrid.AutoGenerateColumns = False
        Me.payrollGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.payrollGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.middlename, Me.TotalotDataGridViewTextBoxColumn, Me.TotalutDataGridViewTextBoxColumn, Me.TotallateDataGridViewTextBoxColumn, Me.TotaldowDataGridViewTextBoxColumn})
        Me.payrollGrid.DataSource = Me.TimesheetHeaderBindingSource
        Me.payrollGrid.Location = New System.Drawing.Point(12, 132)
        Me.payrollGrid.MultiSelect = False
        Me.payrollGrid.Name = "payrollGrid"
        Me.payrollGrid.ReadOnly = True
        Me.payrollGrid.RowHeadersWidth = 62
        Me.payrollGrid.RowTemplate.Height = 28
        Me.payrollGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.payrollGrid.Size = New System.Drawing.Size(1786, 704)
        Me.payrollGrid.TabIndex = 7
        '
        'middlename
        '
        Me.middlename.DataPropertyName = "mname"
        Me.middlename.HeaderText = "Middle name"
        Me.middlename.MinimumWidth = 8
        Me.middlename.Name = "middlename"
        Me.middlename.ReadOnly = True
        Me.middlename.Width = 150
        '
        'TotalotDataGridViewTextBoxColumn
        '
        Me.TotalotDataGridViewTextBoxColumn.DataPropertyName = "total_ot"
        Me.TotalotDataGridViewTextBoxColumn.HeaderText = "Total Overtime"
        Me.TotalotDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalotDataGridViewTextBoxColumn.Name = "TotalotDataGridViewTextBoxColumn"
        Me.TotalotDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalotDataGridViewTextBoxColumn.Width = 150
        '
        'TotalutDataGridViewTextBoxColumn
        '
        Me.TotalutDataGridViewTextBoxColumn.DataPropertyName = "total_ut"
        Me.TotalutDataGridViewTextBoxColumn.HeaderText = "Total Undertime"
        Me.TotalutDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalutDataGridViewTextBoxColumn.Name = "TotalutDataGridViewTextBoxColumn"
        Me.TotalutDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalutDataGridViewTextBoxColumn.Width = 150
        '
        'TotallateDataGridViewTextBoxColumn
        '
        Me.TotallateDataGridViewTextBoxColumn.DataPropertyName = "total_late"
        Me.TotallateDataGridViewTextBoxColumn.HeaderText = "Total Late"
        Me.TotallateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotallateDataGridViewTextBoxColumn.Name = "TotallateDataGridViewTextBoxColumn"
        Me.TotallateDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotallateDataGridViewTextBoxColumn.Width = 150
        '
        'TotaldowDataGridViewTextBoxColumn
        '
        Me.TotaldowDataGridViewTextBoxColumn.DataPropertyName = "total_dow"
        Me.TotaldowDataGridViewTextBoxColumn.HeaderText = "Total Days of work"
        Me.TotaldowDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotaldowDataGridViewTextBoxColumn.Name = "TotaldowDataGridViewTextBoxColumn"
        Me.TotaldowDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotaldowDataGridViewTextBoxColumn.Width = 150
        '
        'TimesheetHeaderBindingSource
        '
        Me.TimesheetHeaderBindingSource.DataMember = "TimesheetHeader"
        Me.TimesheetHeaderBindingSource.DataSource = Me.PayrollDataSet4
        '
        'PayrollDataSet4
        '
        Me.PayrollDataSet4.DataSetName = "payrollDataSet4"
        Me.PayrollDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimesheetHeaderTableAdapter
        '
        Me.TimesheetHeaderTableAdapter.ClearBeforeFill = True
        '
        'cmdProcess
        '
        Me.cmdProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmdProcess.Location = New System.Drawing.Point(826, 38)
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.Size = New System.Drawing.Size(183, 50)
        Me.cmdProcess.TabIndex = 8
        Me.cmdProcess.Text = "Process Payroll"
        Me.cmdProcess.UseVisualStyleBackColor = True
        '
        'frmPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(1810, 871)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdProcess)
        Me.Controls.Add(Me.payrollGrid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCutoff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPayroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.payrollGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimesheetHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCutoff As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents payrollGrid As DataGridView
    Friend WithEvents PayrollDataSet4 As payrollDataSet4
    Friend WithEvents TimesheetHeaderBindingSource As BindingSource
    Friend WithEvents TimesheetHeaderTableAdapter As payrollDataSet4TableAdapters.TimesheetHeaderTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CutoffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents middlename As DataGridViewTextBoxColumn
    Friend WithEvents TotalotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotallateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotaldowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdProcess As Button
End Class
