Public Class ReturnReciepts

    Private Sub ReturnReciepts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim FinalOdometer As String = TextBox9.Text
        'Dim InitialFuel As String = TextBox4.Text
        'Dim FinalFuel As String = TextBox10.Text
        'Dim NoOfDays As Int32 = ReserveCar.NoOfDays

        Label6.Text = "R" & ReturnCar.OdometerAmount
        Label7.Text = "R" & ReturnCar.FinalfuelAmount
        Label12.Text = ReturnCar.ECustName
        Label20.Text = "R" & ReturnCar.extradaysAMT
        Label18.Text = ReturnCar.ENoOfDays
        Label14.Text = Now()
        Label15.Text = ReturnCar.ERegNo
        Label13.Text = HomePage.Label6.Text
        Label17.Text = "R" & ReturnCar.TotalExtra
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        ReturnCar.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        PrintDocument1.Print()
        Button3.Visible = True

        Me.Close()
        ReturnCar.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        ReturnCar.Show()
    End Sub
End Class