Public Class User
    Public Function Authenticate(ByVal username As String, ByVal password As String) As Boolean
        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As New OleDb.OleDbCommand
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter
        Dim count As Integer

        connection.Open()
        command.Connection = connection

        da.SelectCommand = New OleDb.OleDbCommand("SELECT * FROM Users WHERE username='" & StripSQ(username) & "' AND password='" & StripSQ(password) & "'", connection)
        da.Fill(ds, ("Users"))
        count = ds.Tables("Users").Rows.Count
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
