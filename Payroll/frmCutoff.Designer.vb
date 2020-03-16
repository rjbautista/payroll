<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCutoff
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
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.lstCutoff = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCreate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpAdd = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.calendar.Location = New System.Drawing.Point(16, 68)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 0
        '
        'lstCutoff
        '
        Me.lstCutoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstCutoff.FormattingEnabled = True
        Me.lstCutoff.ItemHeight = 25
        Me.lstCutoff.Location = New System.Drawing.Point(12, 64)
        Me.lstCutoff.Name = "lstCutoff"
        Me.lstCutoff.Size = New System.Drawing.Size(438, 504)
        Me.lstCutoff.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "List of active Payroll Cutoff"
        '
        'cmdCreate
        '
        Me.cmdCreate.Location = New System.Drawing.Point(12, 574)
        Me.cmdCreate.Name = "cmdCreate"
        Me.cmdCreate.Size = New System.Drawing.Size(216, 58)
        Me.cmdCreate.TabIndex = 3
        Me.cmdCreate.Text = "Create new"
        Me.cmdCreate.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(234, 574)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(216, 58)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select cutoff period"
        '
        'grpAdd
        '
        Me.grpAdd.Controls.Add(Me.Label3)
        Me.grpAdd.Controls.Add(Me.cmdCancel)
        Me.grpAdd.Controls.Add(Me.cmdSubmit)
        Me.grpAdd.Controls.Add(Me.calendar)
        Me.grpAdd.Controls.Add(Me.Label2)
        Me.grpAdd.Location = New System.Drawing.Point(483, 64)
        Me.grpAdd.Name = "grpAdd"
        Me.grpAdd.Size = New System.Drawing.Size(380, 504)
        Me.grpAdd.TabIndex = 6
        Me.grpAdd.TabStop = False
        Me.grpAdd.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(168, 426)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(160, 58)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(16, 426)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(146, 58)
        Me.cmdSubmit.TabIndex = 6
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(407, 60)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Press ""SHIFT"" key to select the start " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and end date."
        '
        'frmCutoff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Payroll.My.Resources.Resources.login_bg
        Me.ClientSize = New System.Drawing.Size(906, 686)
        Me.Controls.Add(Me.grpAdd)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCutoff)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCutoff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payroll Period Cutoff"
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents lstCutoff As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCreate As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents grpAdd As GroupBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents Label3 As Label
End Class
