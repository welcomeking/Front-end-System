Public Class GenerateEmployee

    Private Sub GenerateEmployees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        EmployeeTableTableAdapter.Fill(Group2DataSet.EmployeeTable)
        GED.SetDataSource(Group2DataSet)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GED.SetParameterValue("EmployeeID", ComboBox1.SelectedItem)
        GEV.ReportSource = GED
        GEV.Refresh()


    End Sub
End Class