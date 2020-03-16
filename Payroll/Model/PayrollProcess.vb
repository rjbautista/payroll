Imports System.Data.OleDb

Public Class PayrollProcess
    Public Function GetPayrollDetails(ByRef CutoffID As String) As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        command = New OleDb.OleDbCommand("SELECT th.*, emp.emp_num, emp.lname, emp.mname, emp.fname FROM TimesheetHeader th LEFT JOIN Employee emp ON th.employeeID = emp.ID WHERE th.cutoffID = @keyword ", connection)
        command.Parameters.Add("@keyword", OleDbType.Numeric).Value = CutoffID
        connection.Open()
        da.SelectCommand = command
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function
End Class
