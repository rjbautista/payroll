Public Class frmTimesheet
    Dim editing As Boolean = False
    Dim CutoffID As String = ""
    Private Sub FrmTimesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet3.Cutoff' table. You can move, or remove it, as needed.
        Me.CutoffTableAdapter.Fill(Me.PayrollDataSet3.Cutoff)
        'TODO: This line of code loads data into the 'PayrollDataSet2.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PayrollDataSet2.Employee)
        lblEmployeeName.Text = ""

        Dim dates() = cmbCutoff.SelectedItem.ToString().Split(" - ")
        Dim startP As DateTime = CDate(dates(0))
        Dim endP As DateTime = CDate(dates(2))
        Dim CurrD As DateTime = startP

        Dim j = 0
        While (CurrD <= endP)
            If j = 0 Then
                lblFriDate.Text = CurrD.Date
            ElseIf j = 1 Then
                lblSatDate.Text = CurrD.ToShortDateString
            ElseIf j = 2 Then
                lblSunDate.Text = CurrD.ToShortDateString
            ElseIf j = 3 Then
                lblMonDate.Text = CurrD.ToShortDateString
            ElseIf j = 4 Then
                lblTueDate.Text = CurrD.ToShortDateString
            ElseIf j = 5 Then
                lblWedDate.Text = CurrD.ToShortDateString
            ElseIf j = 6 Then
                lblThuDate.Text = CurrD.ToShortDateString
            End If

            j += 1
            CurrD = CurrD.AddDays(1)
        End While


        ' RESET in and out
        Dim startTime = New DateTime(Now.Year, Now.Month, Now.Day, 8, 0, 0)
        Dim outTime = New DateTime(Now.Year, Now.Month, Now.Day, 17, 0, 0)
        cmbFriIn.Value = startTime
        cmbSatIn.Value = startTime
        cmbSunIn.Value = startTime
        cmbMonIn.Value = startTime
        cmbTueIn.Value = startTime
        cmbWedIn.Value = startTime
        cmbThuIn.Value = startTime

        cmbFriOut.Value = outTime
        cmbSatOut.Value = outTime
        cmbSunOut.Value = outTime
        cmbMonOut.Value = outTime
        cmbTueOut.Value = outTime
        cmbWedOut.Value = outTime
        cmbThuOut.Value = outTime


        CutoffID = GetCutoffID()
        RefreshTables()
        TabControl1.TabPages(1).Hide()
    End Sub

    Private Sub RefreshTables()

        If CutoffID <> "" Then
            Dim timesheet = New Timesheet
            Dim uds = timesheet.GetUnsubmittedEmployee(CutoffID)
            Dim sds = timesheet.GetSubmittedEmployee(CutoffID)

            SubmittedGrid.DataSource = sds.Tables(0)
            UnsubmittedGrid.DataSource = uds.Tables(0)
        End If
    End Sub

    Private Sub CmdCreateTimesheet_Click(sender As Object, e As EventArgs) Handles cmdCreateTimesheet.Click
        SubmittedGrid.Enabled = False
        UnsubmittedGrid.Enabled = False
        cmdCreateTimesheet.Visible = False
        cmdEdit.Visible = False
        cmdSave.Visible = True
        lblEmployeeName.Text = UnsubmittedGrid.SelectedRows(0).Cells(1).Value & " - " & UnsubmittedGrid.SelectedRows(0).Cells(2).Value & ", " & UnsubmittedGrid.SelectedRows(0).Cells(3).Value & " " & UnsubmittedGrid.SelectedRows(0).Cells(4).Value
        CalculateSummary()
        grpTimesheet.Visible = True
        editing = False
        lblEmployeeID.Text = UnsubmittedGrid.SelectedRows(0).Cells(0).Value
    End Sub
    Private Sub CalculateSummary()
        calculateOT()
        calculateUT()
        calculateLate()
        GetTotalDaysOfWork()
    End Sub

    Private Sub calculateOT()
        Dim OT = CDec(lbFriOM.Text) + CDec(lbSatOM.Text) + CDec(lbSunOM.Text) + CDec(lbMonOM.Text) + CDec(lbTueOM.Text) + CDec(lbWedOM.Text) + CDec(lbThuOM.Text)
        lblTotalOvertime.Text = OT
    End Sub

    Private Sub calculateUT()
        Dim UT = CDec(lbFriUM.Text) + CDec(lbSatUM.Text) + CDec(lbSunUM.Text) + CDec(lbMonUM.Text) + CDec(lbTueUM.Text) + CDec(lbWedUM.Text) + CDec(lbThuUM.Text)
        lblTotalUndertime.Text = UT
    End Sub

    Private Sub calculateLate()
        Dim Late = CDec(lbFriLM.Text) + CDec(lbSatLM.Text) + CDec(lbSunLM.Text) + CDec(lbMonLM.Text) + CDec(lbTueLM.Text) + CDec(lbWedLM.Text) + CDec(lbThuLM.Text)
        lblTotalLate.Text = Late
    End Sub

    Private Sub GetTotalDaysOfWork()
        Dim Count = 0
        lblTotalDays.Text = 0

        If chkFri.Checked Then
            Count = Count + 1
        End If

        If chkSat.Checked Then
            Count = Count + 1
        End If

        If chkSun.Checked Then
            Count = Count + 1
        End If

        If chkMon.Checked Then
            Count = Count + 1
        End If

        If chkTue.Checked Then
            Count = Count + 1
        End If

        If chkWed.Checked Then
            Count = Count + 1
        End If

        If chkThu.Checked Then
            Count = Count + 1
        End If

        lblTotalDays.Text = Count
    End Sub
    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        SubmittedGrid.Enabled = False
        UnsubmittedGrid.Enabled = False
        cmdCreateTimesheet.Visible = False
        cmdEdit.Visible = False
        cmdSave.Visible = True
        lblEmployeeName.Text = SubmittedGrid.SelectedRows(0).Cells(1).Value & " - " & SubmittedGrid.SelectedRows(0).Cells(2).Value & ", " & SubmittedGrid.SelectedRows(0).Cells(3).Value & " " & SubmittedGrid.SelectedRows(0).Cells(4).Value
        grpTimesheet.Visible = True
        editing = True
        lblEmployeeID.Text = SubmittedGrid.SelectedRows(0).Cells(0).Value
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        SubmittedGrid.Enabled = True
        UnsubmittedGrid.Enabled = True
        cmdCreateTimesheet.Visible = True
        cmdEdit.Visible = True
        cmdSave.Visible = False
        grpTimesheet.Visible = False
        editing = False

        Dim timesheet = New Timesheet
        If editing = False Then
            timesheet.CreateHeader()
        Else
            timesheet.UpdateHeader(UnsubmittedGrid.SelectedRows(0).Cells(0).Value())
        End If

        ' Traverse all the days
        If chkFri.Checked Then
            timesheet.CreateDetail(cmbFriIn.Value.ToShortTimeString, cmbFriOut.Value.ToShortTimeString, lbFriOM.Text, lbFriUM.Text, lbFriLM.Text, lblFriDate.Text)
        End If

        If chkSat.Checked Then
            timesheet.CreateDetail(cmbSatIn.Value.ToShortTimeString, cmbSatOut.Value.ToShortTimeString, lbSatOM.Text, lbSatUM.Text, lbSatLM.Text, lblSatDate.Text)
        End If

        If chkSun.Checked Then
            timesheet.CreateDetail(cmbSunIn.Value.ToShortTimeString, cmbSunOut.Value.ToShortTimeString, lbSunOM.Text, lbSunUM.Text, lbSunLM.Text, lblSunDate.Text)
        End If

        If chkMon.Checked Then
            timesheet.CreateDetail(cmbMonIn.Value.ToShortTimeString, cmbMonOut.Value.ToShortTimeString, lbMonOM.Text, lbMonUM.Text, lbMonLM.Text, lblMonDate.Text)
        End If

        If chkTue.Checked Then
            timesheet.CreateDetail(cmbTueIn.Value.ToShortTimeString, cmbTueOut.Value.ToShortTimeString, lbTueOM.Text, lbTueUM.Text, lbTueLM.Text, lblTueDate.Text)
        End If

        If chkWed.Checked Then
            timesheet.CreateDetail(cmbWedIn.Value.ToShortTimeString, cmbWedOut.Value.ToShortTimeString, lbWedOM.Text, lbWedUM.Text, lbWedLM.Text, lblWedDate.Text)
        End If

        If chkThu.Checked Then
            timesheet.CreateDetail(cmbThuIn.Value.ToShortTimeString, cmbThuOut.Value.ToShortTimeString, lbThuOM.Text, lbThuUM.Text, lbThuLM.Text, lblThuDate.Text)
        End If

        MsgBox("Timesheet has been created", vbInformation)
        RefreshTables()
    End Sub

    Private Sub CalculateDateLine(ByRef chkDay As CheckBox, ByRef cmbStart As DateTimePicker, ByRef cmbEnd As DateTimePicker, ByRef lblOH As Label, ByRef lblOM As Label, ByRef lblUH As Label, ByRef lblUM As Label, ByRef lblLH As Label, ByRef lblLM As Label)
        ' RULE = 8am - 5pm
        Dim startTime = New DateTime(Now.Year, Now.Month, Now.Day, 8, 0, 0)
        Dim outTime = New DateTime(Now.Year, Now.Month, Now.Day, 17, 0, 0)

        ' Reset all the day line.
        If chkDay.Checked = False Then
            cmbStart.Value = startTime
            cmbEnd.Value = outTime
            lblOH.Text = 0
            lblOM.Text = 0
            lblUH.Text = 0
            lblUM.Text = 0
            lblLH.Text = 0
            lblLM.Text = 0
            Exit Sub
        End If

        Dim empStartTime = cmbStart.Value
        Dim empOutTime = cmbEnd.Value

        ' calculate late
        If empStartTime > startTime Then
            Dim late = empStartTime.Subtract(startTime)
            lblLM.Visible = True
            lblLH.Visible = True

            lblLM.Text = late.TotalMinutes
            lblLH.Text = late.TotalHours
        Else
            lblLM.Visible = False
            lblLH.Visible = False
            lblLM.Text = 0
            lblLH.Text = 0
        End If

        ' calculate undertime
        If empOutTime < outTime Then
            Dim undertime = outTime.Subtract(empOutTime)
            lblUM.Visible = True
            lblUH.Visible = True
            lblUM.Text = undertime.TotalMinutes
            lblUH.Text = undertime.TotalHours
        Else
            lblUM.Visible = False
            lblUH.Visible = False
            lblUM.Text = 0
            lblUH.Text = 0
        End If

        ' calculate ot
        If empOutTime > outTime Then
            Dim ot = empOutTime.Subtract(outTime)
            lblOM.Visible = True
            lblOH.Visible = True
            lblOM.Text = ot.TotalMinutes
            lblOH.Text = ot.TotalHours
        Else
            lblOM.Visible = False
            lblOH.Visible = False
            lblOM.Text = 0
            lblOH.Text = 0
        End If


        CalculateSummary()
    End Sub
    Private Sub ChkFri_CheckedChanged(sender As Object, e As EventArgs) Handles chkFri.CheckedChanged
        If chkFri.Checked Then
            cmbFriIn.Enabled = True
            cmbFriOut.Enabled = True
        Else
            cmbFriIn.Enabled = False
            cmbFriOut.Enabled = False
        End If
        'CalculateDateLine(chkFri, cmbFriIn, cmbFriOut, lbFriOH, lbFriOM, lbFriUH, lbFriUM, lbFriLH, lbFriLM)
        CalculateSummary()
    End Sub

    Private Sub chkMon_CheckedChanged(sender As Object, e As EventArgs) Handles chkMon.CheckedChanged
        If chkMon.Checked Then
            cmbMonIn.Enabled = True
            cmbMonOut.Enabled = True
        Else
            cmbMonIn.Enabled = False
            cmbMonOut.Enabled = False
        End If
        CalculateDateLine(chkMon, cmbMonIn, cmbMonOut, lbMonOH, lbMonOM, lbMonUH, lbMonUM, lbMonLH, lbMonLM)
        CalculateSummary()

    End Sub

    Private Sub chkSat_CheckedChanged(sender As Object, e As EventArgs) Handles chkSat.CheckedChanged
        If chkSat.Checked Then
            cmbSatIn.Enabled = True
            cmbSatOut.Enabled = True
        Else
            cmbSatIn.Enabled = False
            cmbSatOut.Enabled = False
        End If
        CalculateDateLine(chkSat, cmbSatIn, cmbSatOut, lbSatOH, lbSatOM, lbSatUH, lbSatUM, lbSatLH, lbSatLM)
        CalculateSummary()

    End Sub

    Private Sub chkSun_CheckStateChanged(sender As Object, e As EventArgs) Handles chkSun.CheckStateChanged
        If chkSun.Checked Then
            cmbSunIn.Enabled = True
            cmbSunOut.Enabled = True
        Else
            cmbSunIn.Enabled = False
            cmbSunOut.Enabled = False
        End If
        CalculateDateLine(chkSun, cmbSunIn, cmbSunOut, lbSunOH, lbSunOM, lbSunUH, lbSunUM, lbSunLH, lbSunLM)
        CalculateSummary()

    End Sub

    Private Sub chkThu_CheckStateChanged(sender As Object, e As EventArgs) Handles chkThu.CheckStateChanged
        If chkThu.Checked Then
            cmbThuIn.Enabled = True
            cmbThuOut.Enabled = True
        Else
            cmbThuIn.Enabled = False
            cmbThuOut.Enabled = False
        End If
        CalculateDateLine(chkThu, cmbThuIn, cmbThuOut, lbThuOH, lbThuOM, lbThuUH, lbThuUM, lbThuLH, lbThuLM)
        CalculateSummary()

    End Sub

    Private Sub chkTue_CheckStateChanged(sender As Object, e As EventArgs) Handles chkTue.CheckStateChanged
        If chkTue.Checked Then
            cmbTueIn.Enabled = True
            cmbTueOut.Enabled = True
        Else
            cmbTueIn.Enabled = False
            cmbTueOut.Enabled = False
        End If
        CalculateDateLine(chkTue, cmbTueIn, cmbTueOut, lbTueOH, lbTueOM, lbTueUH, lbTueUM, lbTueLH, lbTueLM)
        CalculateSummary()

    End Sub

    Private Sub chkWed_CheckStateChanged(sender As Object, e As EventArgs) Handles chkWed.CheckStateChanged
        If chkWed.Checked Then
            cmbWedIn.Enabled = True
            cmbWedOut.Enabled = True
        Else
            cmbWedIn.Enabled = False
            cmbWedOut.Enabled = False
        End If
        CalculateDateLine(chkWed, cmbWedIn, cmbWedOut, lbWedOH, lbWedOM, lbWedUH, lbWedUM, lbWedLH, lbWedLM)
        CalculateSummary()

    End Sub

    Private Sub CmbFriIn_TextChanged(sender As Object, e As EventArgs) Handles cmbFriIn.TextChanged
        CalculateDateLine(chkFri, cmbFriIn, cmbFriOut, lbFriOH, lbFriOM, lbFriUH, lbFriUM, lbFriLH, lbFriLM)
    End Sub

    Private Sub CmbFriOut_TextChanged(sender As Object, e As EventArgs) Handles cmbFriOut.TextChanged
        CalculateDateLine(chkFri, cmbFriIn, cmbFriOut, lbFriOH, lbFriOM, lbFriUH, lbFriUM, lbFriLH, lbFriLM)
    End Sub

    Private Sub CmbSatIn_TextChanged(sender As Object, e As EventArgs) Handles cmbSatIn.TextChanged
        CalculateDateLine(chkSat, cmbSatIn, cmbSatOut, lbSatOH, lbSatOM, lbSatUH, lbSatUM, lbSatLH, lbSatLM)
    End Sub

    Private Sub CmbSatOut_TextChanged(sender As Object, e As EventArgs) Handles cmbSatOut.TextChanged
        CalculateDateLine(chkSat, cmbSatIn, cmbSatOut, lbSatOH, lbSatOM, lbSatUH, lbSatUM, lbSatLH, lbSatLM)
    End Sub

    Private Sub CmbSunIn_TextChanged(sender As Object, e As EventArgs) Handles cmbSunIn.TextChanged
        CalculateDateLine(chkSun, cmbSunIn, cmbSunOut, lbSunOH, lbSunOM, lbSunUH, lbSunUM, lbSunLH, lbSunLM)
    End Sub

    Private Sub CmbSunOut_TextChanged(sender As Object, e As EventArgs) Handles cmbSunOut.TextChanged
        CalculateDateLine(chkSun, cmbSunIn, cmbSunOut, lbSunOH, lbSunOM, lbSunUH, lbSunUM, lbSunLH, lbSunLM)
    End Sub

    Private Sub CmbMonIn_TextChanged(sender As Object, e As EventArgs) Handles cmbMonIn.TextChanged
        CalculateDateLine(chkMon, cmbMonIn, cmbMonOut, lbMonOH, lbMonOM, lbMonUH, lbMonUM, lbMonLH, lbMonLM)
    End Sub

    Private Sub CmbMonOut_TextChanged(sender As Object, e As EventArgs) Handles cmbMonOut.TextChanged
        CalculateDateLine(chkMon, cmbMonIn, cmbMonOut, lbMonOH, lbMonOM, lbMonUH, lbMonUM, lbMonLH, lbMonLM)
    End Sub

    Private Sub CmbTueIn_TextChanged(sender As Object, e As EventArgs) Handles cmbTueIn.TextChanged
        CalculateDateLine(chkTue, cmbTueIn, cmbTueOut, lbTueOH, lbTueOM, lbTueUH, lbTueUM, lbTueLH, lbTueLM)
    End Sub

    Private Sub CmbTueOut_TextChanged(sender As Object, e As EventArgs) Handles cmbTueOut.TextChanged
        CalculateDateLine(chkTue, cmbTueIn, cmbTueOut, lbTueOH, lbTueOM, lbTueUH, lbTueUM, lbTueLH, lbTueLM)
    End Sub

    Private Sub CmbWedIn_TextChanged(sender As Object, e As EventArgs) Handles cmbWedIn.TextChanged
        CalculateDateLine(chkWed, cmbWedIn, cmbWedOut, lbWedOH, lbWedOM, lbWedUH, lbWedUM, lbWedLH, lbWedLM)
    End Sub

    Private Sub CmbWedOut_TextChanged(sender As Object, e As EventArgs) Handles cmbWedOut.TextChanged
        CalculateDateLine(chkWed, cmbWedIn, cmbWedOut, lbWedOH, lbWedOM, lbWedUH, lbWedUM, lbWedLH, lbWedLM)
    End Sub

    Private Sub CmbThuIn_TextChanged(sender As Object, e As EventArgs) Handles cmbThuIn.TextChanged
        CalculateDateLine(chkThu, cmbThuIn, cmbThuOut, lbThuOH, lbThuOM, lbThuUH, lbThuUM, lbThuLH, lbThuLM)
    End Sub

    Private Sub CmbThuOut_TextChanged(sender As Object, e As EventArgs) Handles cmbThuOut.TextChanged
        CalculateDateLine(chkThu, cmbThuIn, cmbThuOut, lbThuOH, lbThuOM, lbThuUH, lbThuUM, lbThuLH, lbThuLM)
    End Sub

    Private Function GetCutoffID() As String
        Dim timesheet = New Timesheet
        Dim cid = ""
        Dim cds = timesheet.GetCutoffID(cmbCutoff.SelectedItem)
        If cds.Tables(0).Rows.Count <> 0 Then
            cid = cds.Tables(0).Rows(0)("ID")
        End If
        lblCutoffID.Text = cid
        Return cid
    End Function
    Private Sub CmbCutoff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCutoff.SelectedIndexChanged
        CutoffID = GetCutoffID()
        RefreshTables()
    End Sub
End Class