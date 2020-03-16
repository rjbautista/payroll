Public Class frmLogin

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblLoginErr.Text = ""

        ' Guard clause.
        If RequiredTextField(txtUsername, "Username") = False Or RequiredTextField(txtPassword, "Password") = False Then
            lblLoginErr.Text = "Username and Password is required."
            Exit Sub
        End If

        Dim user = New User
        If user.Authenticate(txtUsername.Text, txtPassword.Text) Then
            isLoggedIn = True
            frmMain.Show()
            Me.Hide()
        Else
            lblLoginErr.Text = "Invalid username or password, please try again."
            txtUsername.Select()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginErr.Text = ""
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class