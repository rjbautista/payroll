Public Class frmPrint
    Private Sub FrmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'payrollDataSet6.Payroll' table. You can move, or remove it, as needed.
        Me.PayrollTableAdapter.Fill(Me.payrollDataSet6.Payroll)
        'TODO: This line of code loads data into the 'payrollDataSet6.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.payrollDataSet6.Employee)


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class