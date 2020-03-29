Imports System.Data.OleDb

Public Class Timesheet
    Public Function GetActiveCutoff() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim Sql As String = "SELECT * FROM Cutoff WHERE posted = FALSE"
        connection.Open()
        da.SelectCommand = New OleDb.OleDbCommand(Sql, connection)
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function GetPostedCutoff() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim Sql As String = "SELECT * FROM Cutoff WHERE posted = TRUE"
        connection.Open()
        da.SelectCommand = New OleDb.OleDbCommand(Sql, connection)
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function GetUnsubmittedEmployee(ByRef CutoffID As String) As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        command = New OleDb.OleDbCommand("SELECT * FROM EMPLOYEE WHERE ID NOT IN (SELECT EmployeeID FROM TimesheetHeader WHERE cutoffID = @keyword) ", connection)
        command.Parameters.Add("@keyword", OleDbType.Numeric).Value = CutoffID
        connection.Open()
        da.SelectCommand = command
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function GetSubmittedEmployee(ByRef CutoffID As String) As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        command = New OleDb.OleDbCommand("SELECT * FROM EMPLOYEE WHERE ID IN (SELECT EmployeeID FROM TimesheetHeader WHERE cutoffID = @keyword) ", connection)
        command.Parameters.Add("@keyword", OleDbType.Numeric).Value = CutoffID
        connection.Open()
        da.SelectCommand = command
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function GetCutoffID(ByRef CutoffDates As String) As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        Dim dates() = CutoffDates.ToString().Split(" - ")
        command = New OleDb.OleDbCommand("SELECT * FROM Cutoff WHERE start_date = @sdate AND end_date = @edate", connection)
        command.Parameters.Add("@sdate", OleDbType.Date).Value = CDate(dates(0))
        command.Parameters.Add("@edate", OleDbType.Date).Value = CDate(dates(2))
        connection.Open()
        da.SelectCommand = command
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Sub CreateHeader()
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand
        ' CREATE Timesheet header
        command = New OleDb.OleDbCommand("INSERT INTO TimesheetHeader (cutoffID, employeeID, total_ot, total_ut, total_late, total_dow,total_regular_holiday,total_special_holiday) VALUES (@cutoffID, @employeeID, @totalOt, @totalUt, @totalLate, @totalDow,@totalRegular,@totalSpecial)", connection)

        connection.Open()
        command.Parameters.Add("@cutoffID", OleDbType.Numeric).Value = frmTimesheet.lblCutoffID.Text
        command.Parameters.Add("@employeeID", OleDbType.Numeric).Value = frmTimesheet.lblEmployeeID.Text
        command.Parameters.Add("@totalOt", OleDbType.Numeric).Value = frmTimesheet.lblTotalOvertime.Text
        command.Parameters.Add("@totalUt", OleDbType.Numeric).Value = frmTimesheet.lblTotalUndertime.Text
        command.Parameters.Add("@totalLate", OleDbType.Numeric).Value = frmTimesheet.lblTotalLate.Text
        command.Parameters.Add("@totalDow", OleDbType.Numeric).Value = frmTimesheet.lblTotalDays.Text
        command.Parameters.Add("@totalRegular", OleDbType.Numeric).Value = frmTimesheet.lblRegularHoliday.Text
        command.Parameters.Add("@totalSpecial", OleDbType.Numeric).Value = frmTimesheet.lblSpecialHoliday.Text

        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub CreateDetail(ByVal empIn, ByVal empOut, ByVal empOt, ByVal empUt, ByVal empLate, ByVal empDow)
        Dim holiday As New Holiday
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("INSERT INTO TimesheetDEtail (timesheetHeaderID, employeeID, timein, timeout, date_of_work, undertime, overtime, late) VALUES (@timesheetHeaderID, @employeeID, @timein, @timeout, @date_of_work, @undertime, @overtime, @late)", connection)

        connection.Open()
        command.Parameters.Add("@timesheetHeaderID", OleDbType.VarChar).Value = frmTimesheet.lblCutoffID.Text
        command.Parameters.Add("@employeeID", OleDbType.VarChar).Value = frmTimesheet.lblEmployeeID.Text
        command.Parameters.Add("@timein", OleDbType.VarChar).Value = empIn
        command.Parameters.Add("@timeout", OleDbType.VarChar).Value = empOut
        command.Parameters.Add("@date_of_work", OleDbType.VarChar).Value = empDow
        command.Parameters.Add("@undertime", OleDbType.VarChar).Value = empUt
        command.Parameters.Add("@overtime", OleDbType.VarChar).Value = empOt
        command.Parameters.Add("@late", OleDbType.VarChar).Value = empLate

        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub DeleteDetail(ByVal HolidayID As String)
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("DELETE FROM TimesheetDEtail WHERE cutoffID = @cutoffIDAND employeeID = @employeeID", connection)

        connection.Open()
        command.Parameters.Add("@cutoffID", OleDbType.Numeric).Value = frmTimesheet.lblCutoffID.Text
        command.Parameters.Add("@employeeID", OleDbType.Numeric).Value = frmTimesheet.lblEmployeeID.Text

        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub UpdateHeader(ByVal HolidayID As String)
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("UPDATE TimesheetHeader SET total_ot = @totalOt, total_ut = @totalUt, total_late = @totalLate, total_dow = @totalDow WHERE cutoffID = @cutoffIDAND employeeID = @employeeID", connection)

        connection.Open()
        command.Parameters.Add("@cutoffID", OleDbType.Numeric).Value = frmTimesheet.lblCutoffID.Text
        command.Parameters.Add("@employeeID", OleDbType.Numeric).Value = frmTimesheet.lblEmployeeID.Text
        command.Parameters.Add("@totalOt", OleDbType.Numeric).Value = frmTimesheet.lblTotalOvertime.Text
        command.Parameters.Add("@totalUt", OleDbType.Numeric).Value = frmTimesheet.lblTotalUndertime.Text
        command.Parameters.Add("@totalLate", OleDbType.Numeric).Value = frmTimesheet.lblTotalLate.Text
        command.Parameters.Add("@totalDow", OleDbType.Numeric).Value = frmTimesheet.lblTotalDays.Text

        command.ExecuteNonQuery()
        MsgBox("Timesheet has been Updated", vbInformation)
        connection.Close()

    End Sub
End Class
