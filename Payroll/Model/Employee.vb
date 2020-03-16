Imports OleDbType = System.Data.OleDb.OleDbType
Public Class Employee


    Public Sub Create()
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("INSERT INTO Employee (emp_num, lname, fname, mname, bday, rate, sss, philhealth, pagibig) VALUES (@empnum, @lname, @fname, @mname, @bday, @rate, @sss, @philhealth, @pagibig)", connection)

        connection.Open()
        command.Parameters.Add("@empnum", OleDbType.VarChar).Value = frmEmployee201.txtEmpNum.Text
        command.Parameters.Add("@lname", OleDbType.VarChar).Value = frmEmployee201.txtLastName.Text
        command.Parameters.Add("@fname", OleDbType.VarChar).Value = frmEmployee201.txtFirstName.Text
        command.Parameters.Add("@mname", OleDbType.VarChar).Value = frmEmployee201.txtMiddleName.Text
        command.Parameters.Add("@bday", OleDbType.VarChar).Value = frmEmployee201.cmbBday.Value.ToShortDateString()
        command.Parameters.Add("@rate", OleDbType.VarChar).Value = frmEmployee201.txtRate.Text
        command.Parameters.Add("@sss", OleDbType.VarChar).Value = frmEmployee201.txtSSS.Text
        command.Parameters.Add("@philhealth", OleDbType.VarChar).Value = frmEmployee201.txtPhilhealth.Text
        command.Parameters.Add("@pagibig", OleDbType.VarChar).Value = frmEmployee201.txtPagIbig.Text

        command.ExecuteNonQuery()
        MsgBox("New Employee has been created", vbInformation)
        connection.Close()

    End Sub

    Public Sub Update(ByVal EmpID As String)
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("UPDATE Employee SET emp_num = @empnum, lname = @lname, fname = @fname, mname = @mname, bday = @bday, rate = @rate, sss = @sss, philhealth = @philhealth, pagibig = @pagibig WHERE ID = @empID", connection)

        connection.Open()
        command.Parameters.Add("@empnum", OleDbType.VarChar).Value = frmEmployee201.txtEmpNum.Text
        command.Parameters.Add("@lname", OleDbType.VarChar).Value = frmEmployee201.txtLastName.Text
        command.Parameters.Add("@fname", OleDbType.VarChar).Value = frmEmployee201.txtFirstName.Text
        command.Parameters.Add("@mname", OleDbType.VarChar).Value = frmEmployee201.txtMiddleName.Text
        command.Parameters.Add("@bday", OleDbType.VarChar).Value = frmEmployee201.cmbBday.Value.ToShortDateString()
        command.Parameters.Add("@rate", OleDbType.VarChar).Value = frmEmployee201.txtRate.Text
        command.Parameters.Add("@sss", OleDbType.VarChar).Value = frmEmployee201.txtSSS.Text
        command.Parameters.Add("@philhealth", OleDbType.VarChar).Value = frmEmployee201.txtPhilhealth.Text
        command.Parameters.Add("@pagibig", OleDbType.VarChar).Value = frmEmployee201.txtPagIbig.Text
        command.Parameters.Add("@empID", OleDbType.VarChar).Value = EmpID

        command.ExecuteNonQuery()
        MsgBox("Employee has been Updated", vbInformation)
        connection.Close()

    End Sub

    Public Sub Delete(ByVal EmpID As String)
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        command = New OleDb.OleDbCommand("DELETE FROM Employee WHERE ID = @empID", connection)

        connection.Open()
        command.Parameters.Add("@empID", OleDbType.VarChar).Value = EmpID

        command.ExecuteNonQuery()
        MsgBox("Employee has been deleted", vbInformation)
        connection.Close()

    End Sub

    Public Function GetAll() As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim Sql As String = "SELECT * FROM Employee"
        connection.Open()
        da.SelectCommand = New OleDb.OleDbCommand(Sql, connection)
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function Search(ByVal Keyword As String) As DataSet
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet

        command = New OleDb.OleDbCommand("SELECT * FROM Employee WHERE lname = @keyword OR fname = @keyword OR emp_num = @keyword ", connection)
        command.Parameters.Add("@keyword", OleDbType.VarChar).Value = Keyword
        connection.Open()
        da.SelectCommand = command
        da.Fill(ds)
        connection.Close()
        Return ds
    End Function

    Public Function GetByID(ByVal EmpID As String) As OleDb.OleDbDataReader
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM Employee WHERE ID = @empID"
        Dim command = New OleDb.OleDbCommand(sql, connection)
        connection.Open()
        command.Parameters.Add("@empID", OleDbType.VarChar).Value = EmpID
        dr = command.ExecuteReader

        Return dr
    End Function
End Class
