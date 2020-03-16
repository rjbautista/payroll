Imports OleDbType = System.Data.OleDb.OleDbType
Public Class frmCutoff
    Private Sub FrmCutoff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.ShowToday = False
    End Sub

    Private Sub CmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        cmdDelete.Enabled = False
        cmdCreate.Enabled = False
        grpAdd.Show()
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        cmdDelete.Enabled = True
        cmdCreate.Enabled = True
        grpAdd.Hide()
    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click


        Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
        Dim command As OleDb.OleDbCommand

        Dim ts As New TimeSpan

        ts = calendar.SelectionEnd.Subtract(calendar.SelectionStart)

        If ts.Days < 6 Then
            MsgBox("A payroll period cutoff requires 7 days, please select the dates accordingly.")
            Exit Sub
        End If

        command = New OleDb.OleDbCommand("INSERT INTO Cutoff (start_date, end_date, posted) VALUES (@sdate, @edate, @posted)", connection)

        connection.Open()
        command.Parameters.Add("@sdate", OleDbType.Date).Value = calendar.SelectionStart
        command.Parameters.Add("@edate", OleDbType.Date).Value = calendar.SelectionEnd
        command.Parameters.Add("@posted", OleDbType.VarChar).Value = "0"

        command.ExecuteNonQuery()
        MsgBox("New Cutoff has been created", vbInformation)
        connection.Close()

        lstCutoff.Items.Add(calendar.SelectionStart.ToShortDateString() & " - " & calendar.SelectionEnd.ToShortDateString())

        cmdDelete.Enabled = True
        cmdCreate.Enabled = True
        grpAdd.Hide()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure you want to delete the selected cutoff?", vbYesNo) = vbYes Then
            Dim connection As OleDb.OleDbConnection = New OleDb.OleDbConnection(PY.ConnectionString)
            Dim command As OleDb.OleDbCommand

            Dim dates() = lstCutoff.SelectedItem.ToString().Split(" - ")

            command = New OleDb.OleDbCommand("DELETE FROM Cutoff WHERE start_date = @sdate AND end_date = @edate", connection)

            connection.Open()
            command.Parameters.Add("@sdate", OleDbType.Date).Value = CDate(dates(0))
            command.Parameters.Add("@edate", OleDbType.Date).Value = CDate(dates(2))

            command.ExecuteNonQuery()
            MsgBox("Cutoff has been deleted", vbInformation)
            lstCutoff.Items.Remove(lstCutoff.SelectedItem)

            connection.Close()
        End If

    End Sub
End Class