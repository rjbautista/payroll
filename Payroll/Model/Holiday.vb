Imports OleDbType = System.Data.OleDb.OleDbType
Public Class Holiday

    Public Sub Create()
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("INSERT INTO Holidays (title, description, type, effectivity_date) VALUES (@title, @description, @type, @effectivity_date)", connection)

        connection.Open()
        command.Parameters.Add("@title", OleDbType.VarChar).Value = frmHoliday.txtTitle.Text
        command.Parameters.Add("@description", OleDbType.VarChar).Value = frmHoliday.txtDescription.Text
        command.Parameters.Add("@type", OleDbType.VarChar).Value = frmHoliday.cmbType.Text
        command.Parameters.Add("@effectivity_date", OleDbType.VarChar).Value = frmHoliday.cmbDate.Value.ToShortDateString

        command.ExecuteNonQuery()
        MsgBox("New Holiday has been created", vbInformation)
        connection.Close()

    End Sub

    Public Sub Update(ByVal HolidayID As String)
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("UPDATE Holidays SET title = @title, description = @description, type = @type, effectivity_date = @effectivity_date WHERE ID = @holidayID", connection)

        connection.Open()
        command.Parameters.Add("@title", OleDbType.VarChar).Value = frmHoliday.txtTitle.Text
        command.Parameters.Add("@description", OleDbType.VarChar).Value = frmHoliday.txtDescription.Text
        command.Parameters.Add("@type", OleDbType.VarChar).Value = frmHoliday.cmbType.Text
        command.Parameters.Add("@effectivity_date", OleDbType.VarChar).Value = frmHoliday.cmbDate.Value.ToShortDateString
        command.Parameters.Add("@holidayID", OleDbType.VarChar).Value = HolidayID

        command.ExecuteNonQuery()
        MsgBox("Holiday has been Updated", vbInformation)
        connection.Close()

    End Sub

    Public Sub Delete(ByVal HolidayID As String)
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("DELETE FROM Holidays WHERE ID = @holidayID", connection)

        connection.Open()
        command.Parameters.Add("@holidayID", OleDbType.VarChar).Value = HolidayID

        command.ExecuteNonQuery()
        MsgBox("Holiday has been deleted", vbInformation)
        connection.Close()

    End Sub

    Public Function GetAll() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim Sql As String = "SELECT * FROM Holidays ORDER BY effectivity_date ASC"
        connection.Open()
        da.SelectCommand = New OleDb.OleDbCommand(Sql, connection)
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function GetByID(ByVal HolidayID As String) As OleDb.OleDbDataReader
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM Holidays WHERE ID = @holidayID"
        Dim command = New OleDb.OleDbCommand(sql, connection)
        connection.Open()
        command.Parameters.Add("@holidayID", OleDbType.VarChar).Value = HolidayID
        dr = command.ExecuteReader

        Return dr
    End Function

    Public Function GetByDate(ByVal HolidayDate As Date) As OleDb.OleDbDataReader
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM Holidays WHERE effectivity_date = @HolidayDate"
        Dim command = New OleDb.OleDbCommand(sql, connection)
        connection.Open()
        command.Parameters.Add("@HolidayDate", OleDbType.Date).Value = HolidayDate
        dr = command.ExecuteReader

        Return dr
    End Function

    Public Function GetByDate(ByVal StartDate As Date, ByVal EndDate As Date) As OleDb.OleDbDataReader
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM Holidays WHERE effectivity_date >= @StartDate AND effectivity_date <= @EndDate"
        Dim command = New OleDb.OleDbCommand(sql, connection)
        connection.Open()
        command.Parameters.Add("@StartDate", OleDbType.Date).Value = StartDate
        command.Parameters.Add("@EndDate", OleDbType.Date).Value = EndDate
        dr = command.ExecuteReader

        Return dr

    End Function
End Class
