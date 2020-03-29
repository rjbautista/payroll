Public Class frmHoliday
    Dim Editing As Boolean = False
    Dim Holiday = New Holiday

    Private Sub FrmHoliday_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayrollDataSet1.Holidays' table. You can move, or remove it, as needed.
        Me.HolidaysTableAdapter.Fill(Me.PayrollDataSet1.Holidays)
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        imgHoliday.Visible = False
        grpHoliday.Visible = True
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        HolidayGrid.Enabled = False

    End Sub

    Private Sub CmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtTitle.Text.Trim = "" Then
            MsgBox("Title field is required.", vbInformation)
            Exit Sub
        End If

        grpHoliday.Visible = False
        imgHoliday.Visible = True
        cmdAdd.Enabled = True

        Dim holiday = New Holiday
        Dim selectedIndex As String = HolidayGrid.SelectedRows(0).Index

        If Editing = True Then
            holiday.Update(HolidayGrid.SelectedRows(0).Cells(0).Value)
        Else
            holiday.Create()
        End If

        RefreshHolidayGrid()
        HolidayGrid.Rows(selectedIndex).Selected = True
        clearFields()
        HolidayGrid.Enabled = True

        If HolidayGrid.SelectedRows(0).Cells(0).Selected Then
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        End If
        Editing = False
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        grpHoliday.Visible = False
        imgHoliday.Visible = True
        cmdAdd.Enabled = True
        Editing = False
        HolidayGrid.Enabled = True

        clearFields()

        If HolidayGrid.SelectedRows(0).Cells(0).Selected Then
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        End If
    End Sub

    Private Sub HolidayGrid_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles HolidayGrid.RowStateChanged
        If e.StateChanged = DataGridViewElementStates.Selected Then
            cmdEdit.Enabled = True
            cmdDelete.Enabled = True
        Else
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False
        End If

    End Sub

    Private Sub CmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Editing = True
        HolidayGrid.Enabled = False
        imgHoliday.Visible = False
        grpHoliday.Visible = True
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        PopulateFields()
    End Sub

    Private Sub clearFields()
        txtTitle.Text = ""
        txtDescription.Text = ""
    End Sub

    Sub RefreshHolidayGrid()
        Dim holiday = New Holiday
        Dim ds = holiday.GetAll()
        HolidayGrid.DataSource = ds.Tables(0)
    End Sub

    Sub PopulateFields()
        clearFields()

        Dim ID As String = HolidayGrid.SelectedRows(0).Cells(0).Value
        Dim holiday = New Holiday
        Dim dr As OleDb.OleDbDataReader = holiday.GetByID(ID)

        With dr.Read
            txtTitle.Text = dr.Item("title")
            txtDescription.Text = dr.Item("description")
            cmbType.SelectedItem = dr.Item("type")
            cmbDate.Value = IIf(IsDBNull(dr.Item("effectivity_date")), Today, dr.Item("effectivity_date"))
            dr.Close()
        End With

    End Sub

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Are you sure you want to delete the selected holiday?", vbYesNo) = vbYes Then
            Dim holiday = New Holiday
            holiday.Delete(HolidayGrid.SelectedRows(0).Cells(0).Value)
            RefreshHolidayGrid()
            HolidayGrid.Rows(0).Selected = True
        End If
    End Sub
End Class