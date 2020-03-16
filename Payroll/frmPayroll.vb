Imports System.Data.OleDb

Public Class frmPayroll
    Private Sub FrmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet4.TimesheetHeader' table. You can move, or remove it, as needed.
        Me.TimesheetHeaderTableAdapter.Fill(Me.PayrollDataSet4.TimesheetHeader)

        PopulateCutoff()
        RefreshGrid()

    End Sub

    Private Sub PopulateCutoff()
        Dim timesheet = New Timesheet
        Dim ds = timesheet.GetActiveCutoff()

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
        End If

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

    Sub RefreshGrid()
        Dim employee = New PayrollProcess
        Dim ds = employee.GetPayrollDetails(GetCutoffID())
        payrollGrid.DataSource = ds.Tables(0)
    End Sub

    Private Sub CmbCutoff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCutoff.SelectedIndexChanged
        RefreshGrid()
    End Sub

    Private Sub CmdProcess_Click(sender As Object, e As EventArgs) Handles cmdProcess.Click

        cmdProcess.Enabled = False
        cmdProcess.Text = "Processing payroll please wait."
        Dim cutOffID = GetCutoffID()

        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT th.*, emp.* FROM TimesheetHeader th LEFT JOIN Employee emp ON th.employeeID = emp.ID WHERE th.cutoffID = @cutOffID"
        Dim command = New OleDb.OleDbCommand(sql, connection)
        connection.Open()
        command.Parameters.Add("@cutOffID", OleDbType.Numeric).Value = cutOffID
        dr = command.ExecuteReader

        If dr.HasRows Then
            While dr.Read()

                Dim ccn As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
                Dim cdr As OleDb.OleDbDataReader
                Dim csql As String = "SELECT start_date, end_date FROM Cutoff WHERE ID = @cutOffID"
                Dim ccm = New OleDb.OleDbCommand(csql, connection)
                ccn.Open()
                ccm.Parameters.Add("@cutOffID", OleDbType.Numeric).Value = cutOffID
                cdr = ccm.ExecuteReader
                Dim cutoffStart = ""
                Dim cutoffEnd = ""
                With cdr.Read
                    cutoffStart = cdr("start_date")
                    cutoffEnd = cdr("start_date")
                End With

                Dim Rate = dr.Item("rate")
                Dim DOW = dr.Item("total_dow")

                ' deductions
                Dim SSS = dr.Item("sss") / 4
                Dim PagIbig = dr.Item("pagibig") / 4
                Dim Philhealth = dr.Item("philhealth") / 4

                Dim LateHours = dr.Item("total_late") / 60 ' convert to hours
                Dim UndertimeHours = dr.Item("total_ut") / 60 ' convert to hours
                Dim OvertimeHours = dr.Item("total_ot") / 60 ' convert to hours

                ' Compute whole salary
                Dim Gross = DOW * Rate

                Dim HourlyRate = Rate / 8 ' rate divided 8 hours
                Dim LateRate = HourlyRate * LateHours
                Dim UndertimeRate = HourlyRate * UndertimeHours

                ' Compute total deductions.
                Dim Deductions = SSS + PagIbig + Philhealth + LateRate + UndertimeRate

                ' Compute overtime 
                Dim OvertimeRate = OvertimeHours * HourlyRate

                Dim NetPay = (Gross + OvertimeRate) - Deductions

                ' Create payroll header
                Dim cn As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
                Dim cm = New OleDb.OleDbCommand("INSERT INTO Payroll (employeeID, cutoffID, cutoff_start, cutoff_end, overtime, late, undertime, sss, philhealth, pagibig, total_deductions, grosspay, netpay, dow) VALUES (@employeeID, @cutoffID, @cutoff_start, @cutoff_end, @overtime, @late, @undertime, @sss, @philhealth, @pagibig, @total_deductions, @grosspay, @netpay, @dow)", connection)

                cn.Open()
                cm.Parameters.Add("@employeeID", OleDbType.Numeric).Value = dr.Item("employeeID")
                cm.Parameters.Add("@cutoffID", OleDbType.Numeric).Value = cutOffID
                cm.Parameters.Add("@cutoff_start", OleDbType.Date).Value = cutoffStart
                cm.Parameters.Add("@cutoff_end", OleDbType.Date).Value = cutoffEnd
                cm.Parameters.Add("@overtime", OleDbType.Currency).Value = OvertimeRate
                cm.Parameters.Add("@late", OleDbType.Currency).Value = LateRate
                cm.Parameters.Add("@undertime", OleDbType.Currency).Value = UndertimeRate
                cm.Parameters.Add("@sss", OleDbType.Currency).Value = SSS
                cm.Parameters.Add("@philhealth", OleDbType.Currency).Value = Philhealth
                cm.Parameters.Add("@pagibig", OleDbType.Currency).Value = PagIbig
                cm.Parameters.Add("@total_deductions", OleDbType.Currency).Value = Deductions
                cm.Parameters.Add("@grosspay", OleDbType.Currency).Value = Gross
                cm.Parameters.Add("@netpay", OleDbType.Currency).Value = NetPay
                cm.Parameters.Add("@dow", OleDbType.Currency).Value = DOW

                cm.ExecuteNonQuery()
                cn.Close()
                ccn.Close()


            End While
        End If

        connection.Close()


        ' Freeze the payroll period
        connection = New OleDb.OleDbConnection(PY.ConnectionString)
        command = New OleDb.OleDbCommand("UPDATE Cutoff SET posted = true WHERE ID = @cutOffID", connection)

        connection.Open()
        command.Parameters.Add("@cutOffID", OleDbType.VarChar).Value = cutOffID


        command.ExecuteNonQuery()
        connection.Close()

        cmdProcess.Text = "Process Payroll"
        cmdProcess.Enabled = True
        MsgBox("Payroll process completed.")
        PopulateCutoff()
        RefreshGrid()
    End Sub
End Class