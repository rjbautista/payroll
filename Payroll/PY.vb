Public Module PY
    Public isLoggedIn As Boolean = False
    Public emptyFieldBG = Color.MistyRose
    Public defaultFieldBG = Color.White
    Public ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\payroll.mdb"
    ' 
    Public Function RequiredTextField(ByRef textBox As TextBox, ByVal caption As String) As Boolean
        Dim valid As Boolean = True

        If textBox.Text.Trim() = "" Then
            textBox.BackColor = emptyFieldBG
            valid = False
        Else
            textBox.BackColor = defaultFieldBG
        End If

        Return valid

    End Function

    Public Sub MoneyFormat(ByRef textBox As TextBox)
        Dim strtoint As Double = 0

        If textBox.Text.Trim() = "" Then
            Exit Sub
        End If

        'Check for valid number
        If Double.TryParse(textBox.Text, strtoint) Then
            'Less than 1 add leading 0
            If strtoint = 0 Then
                textBox.Text = "0.00"
            ElseIf strtoint < 1 Then
                textBox.Text = "0" + textBox.Text
                'A whole number? add trailing 0's and a decimal
            ElseIf strtoint = Math.Truncate(strtoint) Then
                textBox.Text += ".00"
                'Only 1 decimal place? add trailing 0
            ElseIf strtoint * 10 = Math.Truncate(strtoint * 10) Then
                textBox.Text += "0"
            End If
        Else
            MessageBox.Show("Invalid Input")
            textBox.Focus()
        End If
    End Sub

    ' Strip down all single quotes
    Public Function StripSQ(text As String) As String
        Return text.Replace("'", "")
    End Function

End Module
