Public Class FinalCarReportview

    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub FinalCarReportview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet.CarTable)
        FCD.SetDataSource(Group2DataSet)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FCD.SetParameterValue("Registration Number", TextBox1.Text)
        FCV.ReportSource = FCD
        FCV.Refresh()
    End Sub

    Private Sub FCV_Load(sender As System.Object, e As System.EventArgs) Handles FCV.Load

    End Sub
End Class