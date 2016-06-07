Public Class GenerateCustomers

    Private Sub GenerateCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet.ReservationTable)
        ' GCD.SetDataSource(Group2DataSet)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        ' ("CustomerID", ComboBox1.SelectedItem)
        GCV.ReportSource = GCD
        GCV.Refresh()

    End Sub
End Class