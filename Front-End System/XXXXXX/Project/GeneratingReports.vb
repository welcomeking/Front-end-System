Public Class GeneratingReports

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FinancialReportviews.Close()
        EmployeeReports.Close()
        CustomerReportview.Close()
        CarReportViewig.MdiParent = HomePage
        FinalCarReportview.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EmployeeReports.Close()
        CustomerReportview.Close()
        CarReportViewig.Close()
        FinancialReportviews.MdiParent = HomePage
        FinalFinancialReportview.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerReportview.Close()
        CarReportViewig.Close()
        FinancialReportviews.Close()
        EmployeeReports.MdiParent = HomePage
        GenerateEmployee.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CarReportViewig.Close()
        FinancialReportviews.Close()
        EmployeeReports.Close()
        CustomerReportview.MdiParent = HomePage
        CustomerReportview.Show()
    End Sub

    Private Sub GeneratingReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CustomerReportview.Close()
        CarReportViewig.Close()
        FinancialReportviews.Close()
        EmployeeReports.MdiParent = HomePage
        GenerateEmployee.Show()

    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click
        CustomerReportview.Close()
        CarReportViewig.Close()
        FinancialReportviews.Close()
        EmployeeReports.MdiParent = HomePage
        FinalCarPaymentReportView.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        CustomerReportview.Close()
        CarReportViewig.Close()
        FinancialReportviews.Close()
        EmployeeReports.MdiParent = HomePage
        FinalFrequencyReportView.Show()
    End Sub
End Class