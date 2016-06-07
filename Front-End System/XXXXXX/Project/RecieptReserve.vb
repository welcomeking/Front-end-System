Public Class RecieptReserve
    Dim CarID As Integer = ReserveCar.carid
    Dim EmpID As Integer = ReserveCar.EmpID
    Dim DropOffDate As DateTime = ReserveCar.DropOffDate
    Dim Total_Payment As Double = ReserveCar.Total_Payment
    Dim PickUpTime As String = ReserveCar.PickUpTime
    Dim DropOffTime As String = ReserveCar.DropOffTime
    Dim NoOfDays As Int32 = ReserveCar.NoOfDays
    Dim ProcessBy As String = ReserveCar.ProcessBy
    Dim PickUpDate As DateTime = ReserveCar.PickUpDate

    Private Sub ReservationTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub RecieptReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet1.CarTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet1.ReservationTable)

        Label6.Text = ReserveCar.TextBox7.Text
        Label7.Text = ProcessBy
        Label8.Text = Now()
        Label14.Text = PickUpDate
        Label17.Text = PickUpTime
        Label16.Text = DropOffDate
        Label18.Text = DropOffTime
        '  Label19.Text = CarTableTableAdapter.FillByReg(ReserveCar.carid)
        Label9.Text = "R" & Total_Payment
        Label7.Text = HomePage.Label6.Text

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        ' MsgBox("Reservation inserted successfully", MsgBoxStyle.OkOnly, "RESERVATION INSERTED")
        'CarTableTableAdapter.UpdateRented("Rented", CarID)
        PrintDocument1.Print()
        Me.Close()
        ReserveCar.Show()
        Button3.Visible = True

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class