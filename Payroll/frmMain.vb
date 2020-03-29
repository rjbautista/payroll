Public Class frmMain
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Width = Me.Width
    End Sub

    Private Sub MenuAbout_Click(sender As Object, e As EventArgs) Handles menuAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub MenuEmp201_Click(sender As Object, e As EventArgs) Handles menuEmp201.Click
        CloseAllWindows()
        Panel1.Controls.Clear()
        frmEmployee201.TopMost = True
        frmEmployee201.TopLevel = False
        Panel1.Controls.Add(frmEmployee201)
        frmEmployee201.Show()
    End Sub

    Private Sub MenuHolidays_Click(sender As Object, e As EventArgs) Handles menuHolidays.Click
        CloseAllWindows()
        Panel1.Controls.Clear()
        frmHoliday.TopMost = True
        frmHoliday.TopLevel = False
        Panel1.Controls.Add(frmHoliday)
        frmHoliday.Show()
    End Sub

    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub TimesheetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesheetToolStripMenuItem.Click
        CloseAllWindows()
        Dim timesheet = New Timesheet
        Dim ds = timesheet.GetActiveCutoff()

        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("There are no cutoff date, you will need to create a payroll period first before you can enter the timesheet.", vbInformation)
            frmCutoff.ShowDialog()
        Else

            frmTimesheet.cmbCutoff.Items.Clear()
            For Each Row As DataRow In ds.Tables(0).Rows
                Dim sdate As Date = Row("start_date")
                Dim edate As Date = Row("end_date")
                frmTimesheet.cmbCutoff.Items.Add(sdate.ToShortDateString() & " - " & edate.ToShortDateString())
            Next

            frmTimesheet.cmbCutoff.SelectedIndex = 0
            Panel1.Controls.Clear()
            frmTimesheet.TopMost = True
            frmTimesheet.TopLevel = False
            Panel1.Controls.Add(frmTimesheet)
            frmTimesheet.Show()
        End If

    End Sub

    Private Sub CutoffScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutoffScheduleToolStripMenuItem.Click
        CloseAllWindows()
        Dim timesheet = New Timesheet
        Dim ds = timesheet.GetActiveCutoff()

        If ds.Tables(0).Rows.Count <> 0 Then
            frmCutoff.lstCutoff.Items.Clear()
            For Each Row As DataRow In ds.Tables(0).Rows
                Dim sdate As Date = Row("start_date")
                Dim edate As Date = Row("end_date")
                frmCutoff.lstCutoff.Items.Add(sdate.ToShortDateString() & " - " & edate.ToShortDateString())
            Next
        End If
        frmCutoff.ShowDialog()

    End Sub

    Private Sub ProcessPayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessPayrollToolStripMenuItem.Click
        CloseAllWindows()
        Panel1.Controls.Clear()
        frmPayroll.TopMost = True
        frmPayroll.TopLevel = False
        Panel1.Controls.Add(frmPayroll)
        frmPayroll.Show()
    End Sub

    Private Sub GeneratePayslipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratePayslipToolStripMenuItem.Click
        CloseAllWindows()
        frmPrint.Show()
    End Sub

    Private Sub frmMain_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        Panel1.Width = Me.Width
    End Sub

    Private Sub CloseAllWindows()
        frmCutoff.Close()
        frmEmployee201.Close()
        frmHoliday.Close()
        frmPayroll.Close()
        frmPrint.Close()
    End Sub
End Class
