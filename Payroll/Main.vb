Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuAbout_Click(sender As Object, e As EventArgs) Handles menuAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub MenuEmp201_Click(sender As Object, e As EventArgs) Handles menuEmp201.Click
        Employee201.TopMost = True
        Employee201.TopLevel = False
        Panel1.Controls.Add(Employee201)
        Employee201.Show()

    End Sub

    Private Sub MenuHolidays_Click(sender As Object, e As EventArgs) Handles menuHolidays.Click
        Panel1.Controls.Clear()
    End Sub

    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class
