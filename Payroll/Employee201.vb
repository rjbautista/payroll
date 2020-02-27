Public Class Employee201
    Dim Create As Boolean = False
    Dim Employee = New Employee

    Private Sub Employee201_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PayrollDataSet.Employee)
        'TODO: This line of code loads data into the 'PayrollDataSet.Employee' table. You can move, or remove it, as needed

        'TODO: This line of code loads data into the 'EmployeelDataSet.Employee' table. You can move, or remove it, as needed.

    End Sub

    Private Sub EnableInfo(ByVal State As Boolean)
        If State = True Then
            State = False
        Else
            State = True
        End If

        txtEmpNum.ReadOnly = State
        txtLastName.ReadOnly = State
        txtFirstName.ReadOnly = State
        txtMiddleName.ReadOnly = State
        cmbBday.Enabled = IIf(State = False, True, False)

    End Sub

    Private Sub EnablePayroll(ByVal State As Boolean)
        If State = True Then
            State = False
        Else
            State = True
        End If

        txtRate.ReadOnly = State
        txtSSS.ReadOnly = State
        txtPagIbig.ReadOnly = State
        txtPhilhealth.ReadOnly = State
    End Sub
    Private Sub clearFields()
        txtEmpNum.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtRate.Text = ""
        txtSSS.Text = ""
        txtPhilhealth.Text = ""
        txtPagIbig.Text = ""
    End Sub
    Private Sub EditingMode(ByVal State As Boolean)
        If State = True Then
            cmdSave.Show()
            cmdCancel.Show()

            cmdAdd.Hide()
            cmdEdit.Hide()
            cmdDelete.Hide()
            cmdSearch.Enabled = False

        Else
            cmdSave.Hide()
            cmdCancel.Hide()

            cmdAdd.Show()
            cmdEdit.Show()
            cmdDelete.Show()
            cmdSearch.Enabled = true

        End If
    End Sub

    Sub PopulateFields()
        clearFields()

        Dim EmpID As String = EmployeeGrid.SelectedRows(0).Cells(0).Value
        Dim employee = New Employee
        Dim dr As OleDb.OleDbDataReader = employee.GetByID(EmpID)

        With dr.Read
            txtEmpNum.Text = dr.Item("emp_num")
            txtLastName.Text = dr.Item("lname")
            txtFirstName.Text = dr.Item("fname")
            txtMiddleName.Text = dr.Item("mname")
            cmbBday.Value = IIf(IsDBNull(dr.Item("bday")), Today, dr.Item("bday"))
            txtRate.Text = IIf(IsDBNull(dr.Item("rate")), 0, dr.Item("rate"))
            txtSSS.Text = IIf(IsDBNull(dr.Item("sss")), 0, dr.Item("sss"))
            txtPhilhealth.Text = IIf(IsDBNull(dr.Item("philhealth")), 0, dr.Item("philhealth"))
            txtPagIbig.Text = IIf(IsDBNull(dr.Item("pagibig")), 0, dr.Item("pagibig"))
            dr.Close()
        End With

    End Sub

    Sub RefreshEmployeeGrid()
        Dim employee = New Employee
        Dim ds = Employee.GetAll()
        EmployeeGrid.DataSource = ds.Tables(0)
    End Sub
    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        clearFields()
        EnablePayroll(True)
        EnableInfo(True)

        EditingMode(True)
        Create = True
    End Sub

    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        PopulateFields()
        EnablePayroll(True)
        EnableInfo(True)
        EditingMode(True)
        EmployeeGrid.Enabled = False
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        clearFields()
        EnablePayroll(False)
        EnableInfo(False)
        EditingMode(False)
        EmployeeGrid.Enabled = True
    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim employee = New Employee
        Dim selectedIndex As String = EmployeeGrid.SelectedRows(0).Index

        If Create = True Then
            employee.Create()
        Else
            employee.Update(EmployeeGrid.SelectedRows(0).Cells(0).Value)
        End If
        RefreshEmployeeGrid()
        EmployeeGrid.Rows(selectedIndex).Selected = True

        clearFields()
        EnablePayroll(False)
        EnableInfo(False)
        EditingMode(False)
        EmployeeGrid.Enabled = True
    End Sub

    Private Sub CmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim keyword As String = txtSearch.Text.Trim
        If (keyword = "") Then
            RefreshEmployeeGrid()
        Else
            Dim employee = New Employee
            Dim ds = employee.Search(keyword)
            txtSearch.Text = keyword
            EmployeeGrid.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub TxtRate_Leave(sender As Object, e As EventArgs) Handles txtRate.Leave
        MoneyFormat(txtRate)
    End Sub

    Private Sub TxtSSS_Leave(sender As Object, e As EventArgs) Handles txtSSS.Leave
        MoneyFormat(txtSSS)
    End Sub

    Private Sub TxtPagIbig_Leave(sender As Object, e As EventArgs) Handles txtPagIbig.Leave
        MoneyFormat(txtPagIbig)
    End Sub

    Private Sub TxtPhilhealth_Leave(sender As Object, e As EventArgs) Handles txtPhilhealth.Leave
        MoneyFormat(txtPhilhealth)
    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        If MsgBox("Are you sure you want to delete the selected employee?", vbYesNo) = vbYes Then
            Dim employee = New Employee
            employee.Delete(EmployeeGrid.SelectedRows(0).Cells(0).Value)
            RefreshEmployeeGrid()
            EmployeeGrid.Rows(0).Selected = True
        End If
    End Sub
End Class