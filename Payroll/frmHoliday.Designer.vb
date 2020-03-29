<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoliday
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
        Me.PayrollDataSet1 = New Payroll.payrollDataSet1()
        Me.HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HolidaysTableAdapter = New Payroll.payrollDataSet1TableAdapters.HolidaysTableAdapter()
        Me.grpHoliday = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imgHoliday = New System.Windows.Forms.PictureBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.HolidayGrid = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectivitydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PayrollDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHoliday.SuspendLayout()
        CType(Me.imgHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PayrollDataSet1
        '
        Me.PayrollDataSet1.DataSetName = "payrollDataSet1"
        Me.PayrollDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HolidaysBindingSource
        '
        Me.HolidaysBindingSource.DataMember = "Holidays"
        Me.HolidaysBindingSource.DataSource = Me.PayrollDataSet1
        '
        'HolidaysTableAdapter
        '
        Me.HolidaysTableAdapter.ClearBeforeFill = True
        '
        'grpHoliday
        '
        Me.grpHoliday.Controls.Add(Me.cmdCancel)
        Me.grpHoliday.Controls.Add(Me.cmdSave)
        Me.grpHoliday.Controls.Add(Me.cmbType)
        Me.grpHoliday.Controls.Add(Me.cmbDate)
        Me.grpHoliday.Controls.Add(Me.txtTitle)
        Me.grpHoliday.Controls.Add(Me.txtDescription)
        Me.grpHoliday.Controls.Add(Me.Label6)
        Me.grpHoliday.Controls.Add(Me.Label5)
        Me.grpHoliday.Controls.Add(Me.Label4)
        Me.grpHoliday.Controls.Add(Me.Label3)
        Me.grpHoliday.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.grpHoliday.Location = New System.Drawing.Point(12, 111)
        Me.grpHoliday.Name = "grpHoliday"
        Me.grpHoliday.Size = New System.Drawing.Size(592, 832)
        Me.grpHoliday.TabIndex = 12
        Me.grpHoliday.TabStop = False
        Me.grpHoliday.Text = "Holiday Details"
        Me.grpHoliday.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(299, 675)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(276, 49)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(10, 677)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(276, 47)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Regular Holiday", "Special Holiday"})
        Me.cmbType.Location = New System.Drawing.Point(6, 591)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(569, 37)
        Me.cmbType.TabIndex = 7
        '
        'cmbDate
        '
        Me.cmbDate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbDate.Location = New System.Drawing.Point(10, 499)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(565, 36)
        Me.cmbDate.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTitle.Location = New System.Drawing.Point(10, 91)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(565, 36)
        Me.txtTitle.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDescription.Location = New System.Drawing.Point(10, 190)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(565, 257)
        Me.txtDescription.TabIndex = 4
        Me.txtDescription.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(6, 564)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Title"
        '
        'imgHoliday
        '
        Me.imgHoliday.BackgroundImage = Global.Payroll.My.Resources.Resources.holiday
        Me.imgHoliday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgHoliday.Location = New System.Drawing.Point(12, 109)
        Me.imgHoliday.Name = "imgHoliday"
        Me.imgHoliday.Size = New System.Drawing.Size(592, 667)
        Me.imgHoliday.TabIndex = 17
        Me.imgHoliday.TabStop = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdDelete.Location = New System.Drawing.Point(1174, 49)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(276, 47)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Enabled = False
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdEdit.Location = New System.Drawing.Point(892, 49)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(276, 47)
        Me.cmdEdit.TabIndex = 15
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.Location = New System.Drawing.Point(610, 49)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(276, 47)
        Me.cmdAdd.TabIndex = 14
        Me.cmdAdd.Text = "Add New"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'HolidayGrid
        '
        Me.HolidayGrid.AllowUserToAddRows = False
        Me.HolidayGrid.AllowUserToDeleteRows = False
        Me.HolidayGrid.AllowUserToResizeRows = False
        Me.HolidayGrid.AutoGenerateColumns = False
        Me.HolidayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HolidayGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.EffectivitydateDataGridViewTextBoxColumn})
        Me.HolidayGrid.DataSource = Me.HolidaysBindingSource
        Me.HolidayGrid.Location = New System.Drawing.Point(610, 111)
        Me.HolidayGrid.MultiSelect = False
        Me.HolidayGrid.Name = "HolidayGrid"
        Me.HolidayGrid.ReadOnly = True
        Me.HolidayGrid.RowHeadersWidth = 62
        Me.HolidayGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.HolidayGrid.RowTemplate.Height = 28
        Me.HolidayGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HolidayGrid.Size = New System.Drawing.Size(1477, 832)
        Me.HolidayGrid.TabIndex = 13
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
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 150
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Width = 150
        '
        'EffectivitydateDataGridViewTextBoxColumn
        '
        Me.EffectivitydateDataGridViewTextBoxColumn.DataPropertyName = "effectivity_date"
        Me.EffectivitydateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.EffectivitydateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EffectivitydateDataGridViewTextBoxColumn.Name = "EffectivitydateDataGridViewTextBoxColumn"
        Me.EffectivitydateDataGridViewTextBoxColumn.ReadOnly = True
        Me.EffectivitydateDataGridViewTextBoxColumn.Width = 150
        '
        'frmHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(2099, 993)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgHoliday)
        Me.Controls.Add(Me.grpHoliday)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.HolidayGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoliday"
        Me.Text = "frmHoliday"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PayrollDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHoliday.ResumeLayout(False)
        Me.grpHoliday.PerformLayout()
        CType(Me.imgHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PayrollDataSet1 As payrollDataSet1
    Friend WithEvents HolidaysBindingSource As BindingSource
    Friend WithEvents HolidaysTableAdapter As payrollDataSet1TableAdapters.HolidaysTableAdapter
    Friend WithEvents grpHoliday As GroupBox
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents cmbDate As DateTimePicker
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents HolidayGrid As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectivitydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents imgHoliday As PictureBox
End Class
