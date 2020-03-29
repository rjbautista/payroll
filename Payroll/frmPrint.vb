Imports Microsoft.Reporting.WinForms
Public Class frmPrint
    Private Sub FrmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCutoff()
    End Sub
    Private Sub PopulateCutoff()
        Dim timesheet = New Timesheet
        Dim ds = timesheet.GetPostedCutoff()

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("There are no cutoff date, you will need to create a payroll period first before you can enter the timesheet.", vbInformation)
            frmCutoff.ShowDialog()
        Else
            cmbCutoff.Items.Clear()
            For Each Row As DataRow In ds.Tables(0).Rows
                Dim sdate As Date = Row("start_date")
                Dim edate As Date = Row("end_date")
                cmbCutoff.Items.Add(sdate.ToShortDateString() & " - " & edate.ToShortDateString())
            Next
            cmbCutoff.SelectedIndex = 0
            cmdProcess.Enabled = True
        End If

    End Sub

    Private Sub CmdProcess_Click(sender As Object, e As EventArgs) Handles cmdProcess.Click

        Dim cutoffID As New ReportParameter("cutoffID", GetCutoffID())
        Me.ReportViewer1.LocalReport.SetParameters(cutoffID)
        Me.DataTable1TableAdapter.Fill(Me.payrollDataSet6.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Function GetCutoffID() As String
        Dim timesheet = New Timesheet
        Dim cid = ""
        Dim cds = timesheet.GetCutoffID(cmbCutoff.SelectedItem)
        If cds.Tables(0).Rows.Count <> 0 Then
            cid = cds.Tables(0).Rows(0)("ID")
        End If
        Return cid
    End Function
End Class