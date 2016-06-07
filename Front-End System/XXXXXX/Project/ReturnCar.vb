Public Class ReturnCar
    Public OdometerAmount As Double
    Public fuelAmount As Double
    Public mileageCovered As Double
    Public finalTank As Double
    Public TotalKM As Double
    Public InitialOdometer As Double
    Public FinalOdometer As String
    Public InitialFuel As Double
    Public FinalfuelAmount As String
    Public NoOfDays As Int32
    Public TotalExtra As Double = 0
    Public extradaysAMT As Double
    Dim DueDate As DateTime
    Dim ReturnDate As DateTime
    Dim km_perday As Double
    Dim price_km As Double

    Public RentalPrice As Double

    Public EOdometerAmount As Double
    Public EfuelAmount As Double
    Public EextradaysAMT As Double
    Public ENoOfDays As Integer
    Public ERegNo As String
    Public ECustName As String
    Public EextraCost As Double


    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub ReturnCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet1.CarTable)

        'TODO: This line of code loads data into the 'Group2DataSet1.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter1.Fill(Me.Group2DataSet1.CustomerTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter1.Fill(Me.Group2DataSet1.ReservationTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet1.CarTable)
        'TODO: This line of code loads data into the 'Group2DataSet.CarTable' table. You can move, or remove it, as needed.
        'Me.CarTableTableAdapter.Fill(Group2DataSet1.CarTable)

        CarTableTableAdapter.FillByRented(Group2DataSet1.CarTable, "Rented")

        'Catch ex As Exception

        'End Try
        'TextBox7.Text = CustomerTableTableAdapter.FillByName(Group2DataSet1.CustomerTable, TextBox11.Text)

        'TextBox8.Text = ReservationTableTableAdapter.FillByDropOffDate(Group2DataSet1.ReservationTable, TextBox11.Text)
        'TextBox19.Text = ReservationTableTableAdapter.FillByPickUpDate(Group2DataSet1.ReservationTable, TextBox11.Text)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub CarTableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
       

        Dim carid As Integer = Integer.Parse(TextBox1.Text)      
        ECustName = TextBox7.Text

        If CheckBox1.Checked = True And ComboBox1.SelectedItem = "Minor" Then

            RentalPrice = CarTableTableAdapter.FillByRentalPrize(carid)
            Dim ReturnTime As String = ComboBox9.SelectedItem & ":" & ComboBox10.SelectedItem

            InitialOdometer = CarTableTableAdapter.FillByOdoReading(carid)
            FinalOdometer = Double.Parse(TextBox4.Text)

            FinalfuelAmount = Double.Parse(TextBox10.Text)
            km_perday = Double.Parse(TextBox6.Text)
            price_km = Double.Parse(TextBox12.Text)

            NoOfDays = ReservationTableTableAdapter1.FillByNoOfDays(carid)


            DueDate = DateTime.Parse(TextBox8.Text)
            ReturnDate = DateTimePicker2.Value
            ENoOfDays = ReturnDate.Subtract(DueDate).Days
            If ENoOfDays < 0 Then
                MsgBox("Return date cannot be less than due date", MsgBoxStyle.Exclamation, "Error")
            Else
                mileageCovered = FinalOdometer - InitialOdometer
                TotalKM = km_perday * NoOfDays

                If mileageCovered > TotalKM Then

                    OdometerAmount = (price_km) * ((mileageCovered - TotalKM))
                Else
                    OdometerAmount = 0.0
                End If



                If (ENoOfDays > 0) Then
                    extradaysAMT = RentalPrice * ENoOfDays
                Else
                    extradaysAMT = 0.0
                End If

                TotalExtra = OdometerAmount + FinalfuelAmount + extradaysAMT + Double.Parse(TextBox2.Text)
                ReservationTableTableAdapter1.UpdateReservationMinor(Double.Parse(TextBox9.Text), Double.Parse(TextBox4.Text), DateTimePicker2.Value, ReturnTime, TotalExtra, OdometerAmount, TextBox10.Text, carid, TextBox2.Text)
            End If


            If (TotalExtra > 0) Then
                CustomerTableTableAdapter1.ReduceCustomerBalance(TotalExtra, TextBox11.Text)
                CarTableTableAdapter.UpdateAvailableFromRented("Available", carid)
                CarTableTableAdapter.UpdateOdometerRead(CInt(TextBox4.Text), carid)
                MsgBox("Thank you for returning the Car.ENJOY THE REST OF YOUR DAY!", MsgBoxStyle.OkOnly, "CAR " & carid & "RETURNED")
                TextBox3.Clear()
                TextBox9.Clear()
                TextBox10.Clear()
                ComboBox9.ResetText()
                ComboBox10.ResetText()
                TextBox4.Clear()

                ReturnCar_Load(Me, New System.EventArgs)
                ReturnReciepts.Show()
                Me.Hide()
            Else
                CarTableTableAdapter.UpdateAvailableFromRented("Available", carid)
                MsgBox("Thank you for returning the Car.ENJOY THE REST OF YOUR DAY!", MsgBoxStyle.OkOnly, "CAR " & carid & " RETURNED")
                TextBox3.Clear()
                ReturnCar_Load(Me, New System.EventArgs)
            End If

            TextBox9.Clear()
            TextBox10.Clear()
            TextBox3.Clear()
            TextBox11.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox19.Clear()
            TextBox4.Clear()
            ComboBox10.ResetText()
            ComboBox9.ResetText()
            'End of Minor

        ElseIf CheckBox1.Checked = True And ComboBox1.SelectedItem = "On Maintenance" Then
            CarTableTableAdapter.UpdateDamageCar(TextBox5.Text, DateTimePicker1.Value, TextBox1.Text)
            CarTableTableAdapter.UpdateDamageStatus("Damaged", TextBox1.Text)
            MsgBox("Thank You The Car Is Now On Damaged Cars", MsgBoxStyle.OkOnly, "Successfull")
            'End of Maintenance
        Else
            RentalPrice = CarTableTableAdapter.FillByRentalPrize(carid)
            Dim ReturnTime As String = ComboBox9.SelectedItem & ":" & ComboBox10.SelectedItem

            InitialOdometer = CarTableTableAdapter.FillByOdoReading(carid)
            Try
                FinalOdometer = Double.Parse(TextBox4.Text)
            Catch ex As Exception
                MsgBox("Please enter final odometer reading")
                TextBox4.Focus()
            End Try


            FinalfuelAmount = Double.Parse(TextBox10.Text)
            km_perday = Double.Parse(TextBox6.Text)
            price_km = Double.Parse(TextBox12.Text)

            NoOfDays = ReservationTableTableAdapter1.FillByNoOfDays(carid)


            DueDate = DateTime.Parse(TextBox8.Text)
            ReturnDate = DateTimePicker2.Value
            ENoOfDays = ReturnDate.Subtract(DueDate).Days
            If ENoOfDays < 0 Then
                MsgBox("Return date cannot be less than due date", MsgBoxStyle.Exclamation, "Error")
            Else
                mileageCovered = FinalOdometer - InitialOdometer
                TotalKM = km_perday * NoOfDays

                If mileageCovered > TotalKM Then

                    OdometerAmount = (price_km) * ((mileageCovered - TotalKM))
                Else
                    OdometerAmount = 0.0
                End If



                If (ENoOfDays > 0) Then
                    extradaysAMT = RentalPrice * ENoOfDays
                Else
                    extradaysAMT = 0.0
                End If

                TotalExtra = OdometerAmount + FinalfuelAmount + extradaysAMT
                ReservationTableTableAdapter1.UpdateReservation(Double.Parse(TextBox9.Text), Double.Parse(TextBox4.Text), DateTimePicker2.Value, ReturnTime, TotalExtra, OdometerAmount, TextBox10.Text, carid)
            End If


            If (TotalExtra > 0) Then
                CustomerTableTableAdapter1.ReduceCustomerBalance(TotalExtra, TextBox11.Text)
                CarTableTableAdapter.UpdateAvailableFromRented("Available", carid)
                CarTableTableAdapter.UpdateOdometerRead(CInt(TextBox4.Text), carid)
                MsgBox("Thank you for returning the Car.ENJOY THE REST OF YOUR DAY!", MsgBoxStyle.OkOnly, "CAR " & carid & "RETURNED")
                TextBox3.Clear()
                TextBox9.Clear()
                TextBox10.Clear()
                ComboBox9.ResetText()
                ComboBox10.ResetText()
                TextBox4.Clear()

                ReturnCar_Load(Me, New System.EventArgs)
                ReturnReciepts.Show()
                Me.Hide()
            Else
                CarTableTableAdapter.UpdateAvailableFromRented("Available", carid)
                MsgBox("Thank you for returning the Car.ENJOY THE REST OF YOUR DAY!", MsgBoxStyle.OkOnly, "CAR " & carid & " RETURNED")
                TextBox3.Clear()
                ReturnCar_Load(Me, New System.EventArgs)
            End If

            TextBox9.Clear()
            TextBox10.Clear()
            TextBox3.Clear()
            TextBox11.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox19.Clear()
            ComboBox10.ResetText()
            ComboBox9.ResetText()
            TextBox4.Clear()

            TextBox2.Visible = True
            Label4.Visible = True
            Label8.Visible = True
            TextBox4.Visible = True
            TextBox9.Visible = True
            TextBox6.Visible = True
            TextBox12.Visible = True
            TextBox10.Visible = True
            Label21.Visible = True
            Label3.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label23.Visible = True
            Label5.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True

            Label6.Visible = False
            TextBox5.Visible = False
            DateTimePicker1.Visible = False
            Label9.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CarTableTableAdapter.FillByRegistrationNo(Group2DataSet1.CarTable, TextBox3.Text, "Rented")
        Catch
            MsgBox("Your search has no match", MsgBoxStyle.OkOnly, "ERROR")
        End Try

        Try        
            TextBox11.Text = ReservationTableTableAdapter1.FillByCustomerID(CInt(TextBox1.Text))
            TextBox7.Text = CustomerTableTableAdapter1.FillByName(TextBox11.Text)
            'MsgBox(ReservationTableTableAdapter1.ScalarQuery(CInt(TextBox1.Text)))
            TextBox8.Text = ReservationTableTableAdapter1.FillByDropOffDate(CInt(TextBox1.Text))
            TextBox19.Text = ReservationTableTableAdapter1.FillByDropOffTime(CInt(TextBox1.Text))
        Catch
            MsgBox("Registration number is invalid", MsgBoxStyle.Exclamation, "Error detected")
        End Try
       
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Visible = True
        Label4.Visible = True
        Label8.Visible = True
        TextBox4.Visible = True
        TextBox9.Visible = True
        TextBox6.Visible = True
        TextBox12.Visible = True
        TextBox10.Visible = True
        Label21.Visible = True
        Label3.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label23.Visible = True
        Label5.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True

        Label6.Visible = False
        TextBox5.Visible = False
        DateTimePicker1.Visible = False
        Label9.Visible = False
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox3.Clear()
        TextBox11.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox19.Clear()
        ComboBox10.ResetText()
        ComboBox9.ResetText()
        TextBox4.Clear()
        ReturnCar_Load(Me, New System.EventArgs)
    End Sub

    Private Sub CarTableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'TextBox7.Text = CustomerTableTableAdapter.FillByName(TextBox11.Text)

        'TextBox8.Text = ReservationTableTableAdapter.FillByDropOffDate(TextBox11.Text)
        'TextBox19.Text = ReservationTableTableAdapter.FillByPickUpDate(TextBox11.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim clicked As Boolean = True
        Try
            Dim kilometerPerDay As Double = Double.Parse(InputBox("Update kilometer's per day "))
            TextBox6.Text = kilometerPerDay
            TextBox6.Enabled = False
        Catch
            MsgBox("Only numeric value is required from kilometer's per day ", MsgBoxStyle.Exclamation, "Incorrect Input")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim PriceperKilo As Double = Double.Parse(InputBox("Update price per kilometer :"))
            TextBox12.Text = PriceperKilo
            TextBox6.Enabled = False
        Catch
            MsgBox("Only numeric value is required from price per kilo ", MsgBoxStyle.Exclamation, "Incorrect Input")
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Minor" Then
            TextBox2.Enabled = True
            TextBox2.Visible = True
            Label4.Visible = True
            Label8.Visible = True
            TextBox4.Visible = True
            TextBox9.Visible = True
            TextBox6.Visible = True
            TextBox12.Visible = True
            TextBox10.Visible = True
            Label21.Visible = True
            Label3.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            Label23.Visible = True
            Label5.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True

            Label6.Visible = False
            TextBox5.Visible = False
            DateTimePicker1.Visible = False
            Label9.Visible = False
        ElseIf ComboBox1.SelectedItem = "On Maintenance" Then
            TextBox2.Visible = False
            Label4.Visible = False
            Label8.Visible = False
            TextBox4.Visible = False
            TextBox9.Visible = False
            TextBox6.Visible = False
            TextBox12.Visible = False
            TextBox10.Visible = False
            Label21.Visible = False
            Label3.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label23.Visible = False
            Label5.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False

            Label6.Visible = True
            TextBox5.Visible = True
            DateTimePicker1.Visible = True
            Label9.Visible = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ComboBox1.Enabled = True
    End Sub

    Private Sub CarTableBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim PriceperKilo As Double = Double.Parse(InputBox("Input odometer amount :"))
            TextBox4.Text = PriceperKilo
            TextBox4.Enabled = False
        Catch
            MsgBox("Odometer reading should be numeric", MsgBoxStyle.Exclamation, "Incorrect Input")
        End Try
    End Sub
End Class