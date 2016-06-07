Public Class GenerateCars

    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet.CarTable)
        GCARD.SetDataSource(Group2DataSet)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GCARD.SetParameterValue("CarID", TextBox1.Text)
        GCARV.ReportSource = GCARD
        GCARV.Refresh()
    End Sub
End Class