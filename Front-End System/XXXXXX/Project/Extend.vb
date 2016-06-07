Public Class Extend
    Dim DueDate As DateTime
    Dim ReturnDate As DateTime
    Dim NoOfDays As Int32
    Dim DropOffTime As String
    Dim ExtraCost As Double
    Dim ExtendedTime As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Extend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet1.ReservationTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.Group2DataSet1.CustomerTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet1.CarTable)
        CarTableTableAdapter.FillByRented(Group2DataSet1.CarTable, "Rented")
        'CarTableTableAdapter.FillByAvailable(Group2DataSet1.CarTable, "Rented")
        'TextBox7.Text = CustomerTableTableAdapter.FillByName(TextBox16.Text)
        'TextBox8.Text = ReservationTableTableAdapter.FillByDropOffDate(TextBox16.Text)
        'TextBox17.Text = ReservationTableTableAdapter.FillByPickUpDate(TextBox16.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DueDate = DateTime.Parse(TextBox8.Text)
        ReturnDate = DateTimePicker2.Value
        NoOfDays = ReturnDate.Subtract(DueDate).Days
        ExtendedTime = ComboBox9.SelectedItem & ":" & ComboBox10.SelectedItem

        'Dim RentalPrice As Double = CarTableTableAdapter.FillByRent(TextBox1.Text)
        'Dim DepositPrice As Double = CarTableTableAdapter.FillByDepositPrice(TextBox1.Text)

        'ExtraCost = (NoOfDays * RentalPrice)
        'DepositPrice = DepositPrice - ExtraCost
        'ReservationTableTableAdapter.UpdateDeposit(DepositPrice, TextBox1.Text)

        'ReservationTableTableAdapter.UpdateExtend(NoOfDays, ExtraCost, ReturnDate, ExtendedTime, TextBox1.Text)
        MsgBox("You have successfully extended the rental period for " & TextBox7.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ''CarTableTableAdapter.FillByRegistrationNo(Group2DataSet1.CarTable, TextBox9.Text, "Rented")
        'Try
        '    'CarTableTableAdapter.FillByRegistrationNo(Group2DataSet1.CarTable, TextBox9.Text, "Rented")
        'Catch
        '    MsgBox("Your search has no match")
        'End Try
        'Try
        '    TextBox16.Text = ReservationTableTableAdapter.FillByCustomerID(CInt(TextBox1.Text))
        '    TextBox7.Text = CustomerTableTableAdapter.FillByName(TextBox16.Text)
        '    TextBox8.Text = ReservationTableTableAdapter.FillByDropOffDate(CInt(TextBox16.Text))
        '    TextBox17.Text = ReservationTableTableAdapter.FillByPickUpDate(CInt(TextBox16.Text))
        'Catch
        '    MsgBox("Registration number is invalid", MsgBoxStyle.Exclamation, "Error detected")
        'End Try
    End Sub
End Class