Public Class frmTimesheet
    Dim editing As Boolean = False
    Dim CutoffID As String = ""
    Private Sub FrmTimesheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet3.Cutoff' table. You can move, or remove it, as needed.
        Me.CutoffTableAdapter.Fill(Me.PayrollDataSet3.Cutoff)
        'TODO: This line of code loads data into the 'PayrollDataSet2.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PayrollDataSet2.Employee)
        RefreshForm()
    End Sub
    Private Sub RefreshForm()
        lblEmployeeName.Text = ""
        Dim dates() = cmbCutoff.SelectedItem.ToString().Split(" - ")
        Dim startP As DateTime = CDate(dates(0))
        Dim endP As DateTime = CDate(dates(2))
        Dim CurrD As DateTime = startP

        Dim holiday As New Holiday

        Dim j = 0
        While (CurrD <= endP)
            Dim HolidayRecord = holiday.GetByDate(CurrD.ToShortDateString())
            Dim isHoliday = False
            Dim DateColor = Color.Blue
            If HolidayRecord.HasRows Then
                With HolidayRecord.Read
                    Dim HolidayType = HolidayRecord.Item("type")
                    If HolidayType = "Regular Holiday" Then
                        DateColor = Color.Red
                    End If
                    HolidayRecord.Close()
                End With

                isHoliday = True
            End If

            If j = 0 Then
                lblFriDate.Text = CurrD.ToShortDateString
                lblFriDate.ForeColor = Color.Black
                If isHoliday Then
                    lblFriDate.ForeColor = DateColor
                End If
            ElseIf j = 1 Then
                lblSatDate.Text = CurrD.ToShortDateString
                lblSatDate.ForeColor = Color.Black
                If isHoliday Then
                    lblSatDate.ForeColor = DateColor
                End If
            ElseIf j = 2 Then
                lblSunDate.Text = CurrD.ToShortDateString
                lblSunDate.ForeColor = Color.Black
                If isHoliday Then
                    lblSunDate.ForeColor = DateColor
                End If
            ElseIf j = 3 Then
                lblMonDate.Text = CurrD.ToShortDateString
                lblMonDate.ForeColor = Color.Black
                If isHoliday Then
                    lblMonDate.ForeColor = DateColor
                End If
            ElseIf j = 4 Then
                lblTueDate.Text = CurrD.ToShortDateString
                lblTueDate.ForeColor = Color.Black
                If isHoliday Then
                    lblTueDate.ForeColor = DateColor
                End If
            ElseIf j = 5 Then
                lblWedDate.Text = CurrD.ToShortDateString
                lblWedDate.ForeColor = Color.Black
                If isHoliday Then
                    lblWedDate.ForeColor = DateColor
                End If
            ElseIf j = 6 Then
                lblThuDate.Text = CurrD.ToShortDateString
                lblThuDate.ForeColor = Color.Black
                If isHoliday Then
                    lblThuDate.ForeColor = DateColor
                End If
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



        ChkFri_CheckedChanged(chkFri, New EventArgs)
        chkSat_CheckedChanged(chkSat, New EventArgs)
        chkSun_CheckStateChanged(chkSun, New EventArgs)
        chkMon_CheckedChanged(chkMon, New EventArgs)
        chkTue_CheckStateChanged(chkTue, New EventArgs)
        chkWed_CheckStateChanged(chkWed, New EventArgs)
        chkThu_CheckStateChanged(chkThu, New EventArgs)

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

            If UnsubmittedGrid.Rows.Count > 0 Then
                cmdCreateTimesheet.Visible = True
            End If
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
        CalculateUT()
        CalculateLate()
        GetTotalDaysOfWork()
        CalculateHoliday()
    End Sub

    Private Sub calculateOT()
        Dim OT = CDec(lbFriOM.Text) + CDec(lbSatOM.Text) + CDec(lbSunOM.Text) + CDec(lbMonOM.Text) + CDec(lbTueOM.Text) + CDec(lbWedOM.Text) + CDec(lbThuOM.Text)
        lblTotalOvertime.Text = OT
    End Sub

    Private Sub CalculateUT()
        Dim UT = CDec(lbFriUM.Text) + CDec(lbSatUM.Text) + CDec(lbSunUM.Text) + CDec(lbMonUM.Text) + CDec(lbTueUM.Text) + CDec(lbWedUM.Text) + CDec(lbThuUM.Text)
        lblTotalUndertime.Text = UT
    End Sub

    Private Sub CalculateLate()
        Dim Late = CDec(lbFriLM.Text) + CDec(lbSatLM.Text) + CDec(lbSunLM.Text) + CDec(lbMonLM.Text) + CDec(lbTueLM.Text) + CDec(lbWedLM.Text) + CDec(lbThuLM.Text)
        lblTotalLate.Text = Late
    End Sub

    Private Sub CalculateHoliday()
        Dim SpecialHoliday = CDec(lblFriSH.Text) + CDec(lblSatSH.Text) + CDec(lblSunSH.Text) + CDec(lblMonSH.Text) + CDec(lblTueSH.Text) + CDec(lblWedSH.Text) + CDec(lblThuSH.Text)
        lblSpecialHoliday.Text = SpecialHoliday

        Dim RegularHoliday = CDec(lblFriRH.Text) + CDec(lblSatRH.Text) + CDec(lblSunRH.Text) + CDec(lblMonRH.Text) + CDec(lblTueRH.Text) + CDec(lblWedRH.Text) + CDec(lblThuRH.Text)
        lblRegularHoliday.Text = RegularHoliday

    End Sub

    Private Sub GetTotalDaysOfWork()
        Dim Count = 0
        lblTotalDays.Text = 0

        If chkFri.Checked Then
            Count += 1
        End If

        If chkSat.Checked Then
            Count += 1
        End If

        If chkSun.Checked Then
            Count += 1
        End If

        If chkMon.Checked Then
            Count += 1
        End If

        If chkTue.Checked Then
            Count += 1
        End If

        If chkWed.Checked Then
            Count += 1
        End If

        If chkThu.Checked Then
            Count += 1
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
        If UnsubmittedGrid.Rows.Count <= 0 Then
            cmdCreateTimesheet.Visible = False
        End If
    End Sub

    Private Sub CalculateDateLine(ByRef chkDay As CheckBox, ByRef lblDate As Label, ByRef cmbStart As DateTimePicker, ByRef cmbEnd As DateTimePicker, ByRef lblOH As Label, ByRef lblOM As Label, ByRef lblUH As Label, ByRef lblUM As Label, ByRef lblLH As Label, ByRef lblLM As Label, ByRef lblRH As Label, ByRef lblSH As Label)
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

        Dim totalHoliday = empOutTime.Subtract(empStartTime)
        lblRH.Text = 0
        lblSH.Text = 0
        If lblDate.ForeColor = Color.Red Then
            lblRH.Text = totalHoliday.TotalHours - 1
            lblRH.Visible = True
        ElseIf lblDate.ForeColor = Color.Blue Then
            lblSH.Text = totalHoliday.TotalHours - 1
            lblSH.Visible = True
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
        CalculateDateLine(chkFri, lblFriDate, cmbFriIn, cmbFriOut, lbFriOH, lbFriOM, lbFriUH, lbFriUM, lbFriLH, lbFriLM, lblFriRH, lblFriSH)
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
        CalculateDateLine(chkMon, lblMonDate, cmbMonIn, cmbMonOut, lbMonOH, lbMonOM, lbMonUH, lbMonUM, lbMonLH, lbMonLM, lblMonRH, lblMonSH)
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
        CalculateDateLine(chkSat, lblSatDate, cmbSatIn, cmbSatOut, lbSatOH, lbSatOM, lbSatUH, lbSatUM, lbSatLH, lbSatLM, lblSatRH, lblSatSH)
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
        CalculateDateLine(chkSun, lblSunDate, cmbSunIn, cmbSunOut, lbSunOH, lbSunOM, lbSunUH, lbSunUM, lbSunLH, lbSunLM, lblSunRH, lblSunSH)
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
        CalculateDateLine(chkThu, lblThuDate, cmbThuIn, cmbThuOut, lbThuOH, lbThuOM, lbThuUH, lbThuUM, lbThuLH, lbThuLM, lblThuRH, lblThuSH)
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
        CalculateDateLine(chkTue, lblTueDate, cmbTueIn, cmbTueOut, lbTueOH, lbTueOM, lbTueUH, lbTueUM, lbTueLH, lbTueLM, lblTueRH, lblTueSH)
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
        CalculateDateLine(chkWed, lblWedDate, cmbWedIn, cmbWedOut, lbWedOH, lbWedOM, lbWedUH, lbWedUM, lbWedLH, lbWedLM, lblWedRH, lblWedSH)
        CalculateSummary()

    End Sub

    Private Sub CmbFriIn_TextChanged(sender As Object, e As EventArgs) Handles cmbFriIn.TextChanged
        CalculateDateLine(chkFri, lblFriDate, cmbFriIn, cmbFriOut, lbFriOH, lbFriOM, lbFriUH, lbFriUM, lbFriLH, lbFriLM, lblFriRH, lblFriSH)
    End Sub

    Private Sub CmbFriOut_TextChanged(sender As Object, e As EventArgs) Handles cmbFriOut.TextChanged
        CalculateDateLine(chkFri, lblFriDate, cmbFriIn, cmbFriOut, lbFriOH, lbFriOM, lbFriUH, lbFriUM, lbFriLH, lbFriLM, lblFriRH, lblFriSH)
    End Sub

    Private Sub CmbSatIn_TextChanged(sender As Object, e As EventArgs) Handles cmbSatIn.TextChanged
        CalculateDateLine(chkSat, lblSatDate, cmbSatIn, cmbSatOut, lbSatOH, lbSatOM, lbSatUH, lbSatUM, lbSatLH, lbSatLM, lblSatRH, lblSatSH)
    End Sub

    Private Sub CmbSatOut_TextChanged(sender As Object, e As EventArgs) Handles cmbSatOut.TextChanged
        CalculateDateLine(chkSat, lblSatDate, cmbSatIn, cmbSatOut, lbSatOH, lbSatOM, lbSatUH, lbSatUM, lbSatLH, lbSatLM, lblSatRH, lblSatSH)
    End Sub

    Private Sub CmbSunIn_TextChanged(sender As Object, e As EventArgs) Handles cmbSunIn.TextChanged
        CalculateDateLine(chkSun, lblSatDate, cmbSunIn, cmbSunOut, lbSunOH, lbSunOM, lbSunUH, lbSunUM, lbSunLH, lbSunLM, lblSunRH, lblSunSH)
    End Sub

    Private Sub CmbSunOut_TextChanged(sender As Object, e As EventArgs) Handles cmbSunOut.TextChanged
        CalculateDateLine(chkSun, lblSunDate, cmbSunIn, cmbSunOut, lbSunOH, lbSunOM, lbSunUH, lbSunUM, lbSunLH, lbSunLM, lblSunRH, lblSunSH)
    End Sub

    Private Sub CmbMonIn_TextChanged(sender As Object, e As EventArgs) Handles cmbMonIn.TextChanged
        CalculateDateLine(chkMon, lblMonDate, cmbMonIn, cmbMonOut, lbMonOH, lbMonOM, lbMonUH, lbMonUM, lbMonLH, lbMonLM, lblMonRH, lblMonSH)
    End Sub

    Private Sub CmbMonOut_TextChanged(sender As Object, e As EventArgs) Handles cmbMonOut.TextChanged
        CalculateDateLine(chkMon, lblMonDate, cmbMonIn, cmbMonOut, lbMonOH, lbMonOM, lbMonUH, lbMonUM, lbMonLH, lbMonLM, lblMonRH, lblMonSH)
    End Sub

    Private Sub CmbTueIn_TextChanged(sender As Object, e As EventArgs) Handles cmbTueIn.TextChanged
        CalculateDateLine(chkTue, lblTueDate, cmbTueIn, cmbTueOut, lbTueOH, lbTueOM, lbTueUH, lbTueUM, lbTueLH, lbTueLM, lblTueRH, lblTueSH)
    End Sub

    Private Sub CmbTueOut_TextChanged(sender As Object, e As EventArgs) Handles cmbTueOut.TextChanged
        CalculateDateLine(chkTue, lblTueDate, cmbTueIn, cmbTueOut, lbTueOH, lbTueOM, lbTueUH, lbTueUM, lbTueLH, lbTueLM, lblTueRH, lblTueSH)
    End Sub

    Private Sub CmbWedIn_TextChanged(sender As Object, e As EventArgs) Handles cmbWedIn.TextChanged
        CalculateDateLine(chkWed, lblWedDate, cmbWedIn, cmbWedOut, lbWedOH, lbWedOM, lbWedUH, lbWedUM, lbWedLH, lbWedLM, lblWedRH, lblWedSH)
    End Sub

    Private Sub CmbWedOut_TextChanged(sender As Object, e As EventArgs) Handles cmbWedOut.TextChanged
        CalculateDateLine(chkWed, lblWedDate, cmbWedIn, cmbWedOut, lbWedOH, lbWedOM, lbWedUH, lbWedUM, lbWedLH, lbWedLM, lblWedRH, lblWedSH)
    End Sub

    Private Sub CmbThuIn_TextChanged(sender As Object, e As EventArgs) Handles cmbThuIn.TextChanged
        CalculateDateLine(chkThu, lblThuDate, cmbThuIn, cmbThuOut, lbThuOH, lbThuOM, lbThuUH, lbThuUM, lbThuLH, lbThuLM, lblThuRH, lblThuSH)
    End Sub

    Private Sub CmbThuOut_TextChanged(sender As Object, e As EventArgs) Handles cmbThuOut.TextChanged
        CalculateDateLine(chkThu, lblThuDate, cmbThuIn, cmbThuOut, lbThuOH, lbThuOM, lbThuUH, lbThuUM, lbThuLH, lbThuLM, lblThuRH, lblThuSH)
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
        RefreshForm()
    End Sub
End Class