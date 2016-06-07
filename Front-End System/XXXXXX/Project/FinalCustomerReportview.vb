Public Class FinalCustomerReportview

    Private Sub ReservationTableBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ReservationTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub FinalCustomerReportview_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.Group2DataSet.CustomerTable)
        'TODO: This line of code loads data into the 'Group2DataSet.CarTable' table. You can move, or remove it, as needed.
        '  Me.CarTableTableAdapter.Fill(Me.Group2DataSet.CarTable)
        'TODO: This line of code loads data into the 'Group2DataSet.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet.ReservationTable)
        FRCD.SetDataSource(Group2DataSet)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FRCD.SetParameterValue("CustomerNumber", TextBox1.Text)
        FRCV.ReportSource = FRCD
        FRCV.Refresh()
    End Sub

    Private Sub FRCV_Load(sender As System.Object, e As System.EventArgs) Handles FRCV.Load

    End Sub
End Class