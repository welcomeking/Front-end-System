Imports System.Net.Mail
Public Class ReserveCar
    Public carid As Integer
    Public EmpID As Integer
    Public DropOffDate As DateTime
    Public Total_Payment As Double
    Public PickUpTime As String
    Public DropOffTime As String
    Public NoOfDays As Int32
    Public ProcessBy As String
    Public PickUpDate As DateTime
    Public rentalPrice As Double
    Public DepositPrice As Double
    Public FuelReading As Double
    Public OdometerReading As Double
    ' Public CarID As Integer
    Dim checked As Boolean = False

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub ReserveCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet1.CarTable)
        CarTableTableAdapter.FillByAvailable(Group2DataSet1.CarTable, "Available")
        ComboBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        carid = Integer.Parse(TextBox6.Text)

        Try
            rentalPrice = CarTableTableAdapter1.FillByRentalPrize(carid)
            DepositPrice = CarTableTableAdapter1.FillByDepositPrice(carid)
            OdometerReading = CarTableTableAdapter1.FillByOdoReading(carid)

            PickUpTime = ComboBox7.SelectedItem & ":" & ComboBox8.SelectedItem
            DropOffTime = ComboBox9.SelectedItem & ":" & ComboBox10.SelectedItem

            PickUpDate = DateTimePicker1.Value
            DropOffDate = DateTimePicker2.Value

            NoOfDays = DropOffDate.Subtract(PickUpDate).Days + 1
            rentalPrice = rentalPrice * NoOfDays

            If NoOfDays < 1 Then
                MsgBox("Drop Off Date cannot be less than Pick Up Date", MsgBoxStyle.Exclamation, "ERROR")
            End If

            Total_Payment = ((Double.Parse(rentalPrice)) + Double.Parse(DepositPrice))

            ProcessBy = HomePage.Label6.Text
            EmpID = EmployeeTableTableAdapter1.FillByIDNum(ProcessBy) + 2



            Dim result As String = MsgBox("Number Of Days: " & vbTab & NoOfDays & vbCrLf & "Rental Price: " & vbTab & "R" & rentalPrice & vbCrLf & "Deposit Price:" & vbTab & "R" & DepositPrice & vbCrLf & "Total Payment: " & vbTab & "R" & Total_Payment, MsgBoxStyle.OkCancel, "CONFIRM BOOKING").ToString
            If result = "Ok" Then
                MsgBox("Reservation successfully completed", MsgBoxStyle.OkOnly, "RESERVATION DONE")
                ReservationTableTableAdapter1.InsertQuery(PickUpDate, PickUpTime, DropOffDate, DropOffTime, NoOfDays, rentalPrice, DepositPrice, carid, EmpID, TextBox4.Text, OdometerReading, Total_Payment, ProcessBy, ComboBox11.SelectedItem, ComboBox12.SelectedItem)
                CarTableTableAdapter1.UpdateRented("Rented", carid)
                CustomerTableTableAdapter1.UpdateCustomerBalance(DepositPrice, CInt(TextBox4.Text))
                'End If

                'Try
                '    Dim Smtp_Server As New SmtpClient
                '    Dim e_mail As New MailMessage()
                '    Smtp_Server.UseDefaultCredentials = False
                '    Smtp_Server.Credentials = New Net.NetworkCredential("AvieraSystem@gmail.com", "saurombelogistics")
                '    Smtp_Server.Port = 587
                '    Smtp_Server.EnableSsl = True
                '    Smtp_Server.Host = "smtp.gmail.com"

                '    e_mail = New MailMessage()
                '    e_mail.From = New MailAddress("AvieraSystem@gmail.com")
                '    e_mail.To.Add("TomCyprian434@gmail.com")
                '    e_mail.Subject = "Aviera Notification"
                '    e_mail.IsBodyHtml = False
                '    e_mail.Body = "Your reservation was successful...It was proccessed by" & ProcessBy & " at " & DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
                '    Smtp_Server.Send(e_mail)


                'Catch error_t As Exception
                ' MsgBox("Invalid email address")
                'End Try

                RecieptReserve.Show()

            Else

                MsgBox("Reservation Cancelled", MsgBoxStyle.OkOnly, "BOOKING CANCELLED")
                ReserveCar_Load(Me, New System.EventArgs)
            End If

            MaskedTextBox1.Clear()
            TextBox7.Clear()
            TextBox4.Clear()
            ComboBox11.ResetText()
            ComboBox12.ResetText()
            CheckBox1.Checked = False
            ComboBox7.ResetText()
            ComboBox8.ResetText()
            ComboBox9.ResetText()
            ComboBox10.ResetText()
            ComboBox1.ResetText()
            TextBox3.Clear()
            MaskedTextBox1.Focus()
            ComboBox12.Enabled = True
            CarTableTableAdapter.FillByAvailable(Group2DataSet1.CarTable, "Available")

            RecieptReserve.Show()
        Catch
            MsgBox("Please input all reqiured details accordingly", MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MaskedTextBox1.Text = "" Then
            MsgBox("Enter Customer identity number", MsgBoxStyle.OkOnly, "No Customer found")
        Else
            Try
                TextBox4.Text = CustomerTableTableAdapter1.FillByIDByIDNum(MaskedTextBox1.Text)
                TextBox7.Text = CustomerTableTableAdapter1.FillByNameByIDNum(MaskedTextBox1.Text)
            Catch
                MsgBox("ID Number must be 13 digits", MsgBoxStyle.OkOnly, "ERROR")
            End Try
        End If 
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'CarTableBindingSource.MoveNext()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'CarTableBindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox3.Text = "" Then
            MsgBox("Please enter car registration number", MsgBoxStyle.OkOnly, "No Registration")
        Else
            Try
                CarTableTableAdapter.FillByModel(Group2DataSet1.CarTable, TextBox3.Text, "Available")
            Catch
                MsgBox("Mode Not Available", MsgBoxStyle.OkOnly, "ERROR")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaskedTextBox1.Clear()
        TextBox7.Clear()
        TextBox4.Clear()
        ComboBox11.ResetText()
        ComboBox12.ResetText()
        DateTimePicker1.Refresh()
        DateTimePicker2.Refresh()
        ComboBox7.ResetText()
        ComboBox8.ResetText()
        ComboBox9.ResetText()
        ComboBox10.ResetText()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        ViewReservation.MdiParent = HomePage
        ViewReservation.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        'ReservationTableBindingSource.MoveNext()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        'ReservationTableBindingSource.MovePrevious()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CarTableTableAdapter.FillByCode(Group2DataSet1.CarTable, ComboBox1.SelectedItem, "Available")
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.ResetText()
        ComboBox9.ResetText()
        ComboBox10.ResetText()
        ComboBox8.ResetText()
        ComboBox7.ResetText()
        ComboBox11.ResetText()
        ComboBox12.ResetText()
        CheckBox1.ResetText()
        TextBox3.Clear()
        MaskedTextBox1.Clear()
        TextBox7.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        ReserveCar_Load(Me, New System.EventArgs)
    End Sub

    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ComboBox12.Text = ComboBox11.Text
    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.CarTableTableAdapter.FillBy(Me.Group2DataSet1.CarTable)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
