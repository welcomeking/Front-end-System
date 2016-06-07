Public Class GenerateCustomers2

    Private Sub GenerateCarPayments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ReservationTableTableAdapter.Fill(Group2DataSet.ReservationTable)
        ' ReservationTableTableAdapter.FillBy(Group2DataSet.ReservationTable, ComboBox1.SelectedItem)
        'GCPD.SetDataSource(Group2DataSet)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'GCPD.SetParameterValue("CarID", ComboBox1.SelectedItem)
        'GCPV.ReportSource = GCPD
        ' GCPV.Refresh()
        ReservationTableTableAdapter.FillBy(Group2DataSet.ReservationTable, ComboBox1.SelectedItem)
    End Sub
End Class
