Public Class FinalFinancialReportview

    Private Sub ReservationTableBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ReservationTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub FinalFinancialReportview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet.CarTable' table. You can move, or remove it, as needed.
        'Me.CarTableTableAdapter.Fill(Me.Group2DataSet.CarTable)
        'TODO: This line of code loads data into the 'Group2DataSet.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet.ReservationTable)
        FFCRD.SetDataSource(Group2DataSet)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FFCRD.SetParameterValue("Registration Number", TextBox1.Text)
        FFCRV.ReportSource = FFCRD
        FFCRV.Refresh()
    End Sub
End Class