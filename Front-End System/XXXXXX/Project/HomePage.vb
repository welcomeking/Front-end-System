Public Class HomePage
    Dim i As Integer = 0
    Dim X As Date
    Dim username As String
    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close() 'in case there are any living children
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False

        ReturnCar.Close()
        ViewCar.Close()
        Add_Customer.Close()
        Extend.Close()
        ViewReservation.Close()
        CarReportViewig.Close()
        GeneratingReports.Close()


        ReserveCar.MdiParent = Me
        ReserveCar.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False


        ViewCar.Close()
        Add_Customer.Close()
        ReserveCar.Close()
        Extend.Close()
        CarReportViewig.Close()
        GeneratingReports.Close()


        ReturnCar.MdiParent = Me
        ReturnCar.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False


        ViewCar.Close()
        ReturnCar.Close()
        ReserveCar.Close()
        Extend.Close()
        CarReportViewig.Close()
        GeneratingReports.Close()

        Add_Customer.MdiParent = Me
        Add_Customer.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False

        Add_new_car.Close()
        ViewCar.Close()
        CarReportViewig.Close()
        Extend.Close()
        GeneratingReports.Close()

        AddEmployee.MdiParent = Me
        AddEmployee.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False

        AddEmployee.Close()
        ViewCar.Close()
        CarReportViewig.Close()
        Extend.Close()
        GeneratingReports.Close()

        Add_new_car.MdiParent = Me
        Add_new_car.Show()
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False

        AddEmployee.Close()
        Add_new_car.Close()
        Extend.Close()
        CarReportViewig.Close()
        GeneratingReports.Close()

        ViewCar.MdiParent = Me
        ViewCar.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        Label8.Visible = False
        Label9.Visible = False

        AddEmployee.Close()
        Add_new_car.Close()
        Extend.Close()
        ViewCar.Close()

        'CarReportViewig.MdiParent = Me
        GeneratingReports.Show()
        'FinancialReportviews.MdiParent = Me
        'FinancialReportviews.Show()
        'EmployeeReports.MdiParent = Me
        'EmployeeReports.Show()
        'CustomerReportview.MdiParent = Me
        'CustomerReportview.Show()

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Me.Close()
    End Sub

    Private Sub EmployeeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Text = Now()
        Me.EmployeeTableTableAdapter.Fill(Me.Group2DataSet1.EmployeeTable)
        CarTableTableAdapter.FillByRented(Group2DataSet1.CarTable, "Rented")

        'For i As Integer = 0 To ReservationTableDataGridView.Rows.Count - 1

        'MsgBox(X)

        '(Group2DataSet1.ReservationTable, X)

        'End If
        'Next
        'Dim TodaysDate As Date = Date.Today.Date

        'X = ReservationTableDataGridView.Rows(i).Cells(3).Value
        'If (TodaysDate = X) Then
        '    CarTableTableAdapter.FillByMaib(X, TextBox5.Text)
        '    i += 1
        'End If

        'If ReservationTableDataGridView.Item(3, ReservationTableBindingSource.Find("Drop Off Date", TodaysDate)).Value = TodaysDate Then
        '(Group2DataSet1.CarTable, "Rented")
        'End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' EmployeeTableTableAdapter.FillByUserPass(Group2DataSet1.EmployeeTable, TextBox1.Text, TextBox2.Text)
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "No input found")
        Else
            Try
                username = TextBox1.Text
                If (Group2DataSet1.EmployeeTable.Rows.Count) Then
                    Label6.Text = TextBox1.Text
                    If EmployeeTableDataGridView.Item(8, EmployeeTableBindingSource.Find("Username", TextBox1.Text)).Value = "Admin" Then
                        MsgBox("Welcome " & TextBox1.Text & " You will be directed to the system")


                        CarTableDataGridView.Visible = True

                        Button2.Enabled = True
                        Button3.Enabled = True
                        Button4.Enabled = True
                        Button6.Enabled = True
                        Button7.Enabled = True
                        Button10.Visible = True
                        Button1.Visible = False
                        Button12.Enabled = True

                        PictureBox2.Visible = True
                        PictureBox3.Visible = False

                        LinkLabel1.Enabled = True
                        LinkLabel2.Enabled = True
                        LinkLabel3.Enabled = True
                        LinkLabel4.Enabled = True
                        LinkLabel5.Enabled = True

                        Button11.Enabled = True


                        TextBox1.Text = "Username"
                        TextBox2.Text = "Password"

                        TextBox1.ReadOnly = True
                        TextBox2.ReadOnly = True

                    Else
                        MsgBox("Welcome " & TextBox1.Text & " You will be directed to the system")
                        CarTableDataGridView.Visible = True
                        Button2.Enabled = True
                        Button5.Enabled = True
                        Button6.Enabled = True
                        Button8.Enabled = True
                        Button9.Enabled = True
                        Button12.Enabled = True

                        LinkLabel1.Enabled = True
                        LinkLabel4.Enabled = True
                        LinkLabel5.Enabled = True

                        Button10.Visible = True
                        Button1.Visible = False

                        PictureBox2.Visible = True
                        PictureBox3.Visible = False

                        Button11.Enabled = True


                        TextBox1.Text = "Username"
                        TextBox2.Text = "Password"

                        TextBox1.ReadOnly = True
                        TextBox2.ReadOnly = True


                    End If
                Else
                    MsgBox("Invalid username or password")
                End If
            Catch
                MsgBox("Username or Password is incorect", MsgBoxStyle.Exclamation, "Error detected")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()

            End Try
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        CarTableDataGridView.Visible = False

        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button12.Enabled = False

        LinkLabel1.Enabled = False
        LinkLabel2.Enabled = False
        LinkLabel3.Enabled = False
        LinkLabel4.Enabled = False
        LinkLabel5.Enabled = False

        Button1.Visible = True
        Button10.Visible = False
        TextBox1.Clear()
        TextBox2.Clear()
        Label6.Text = "Username"
        PictureBox2.Visible = False
        PictureBox3.Visible = True

        Button11.Enabled = False

        TextBox1.Text = "Username"
        TextBox2.Text = "Password"

        TextBox1.ReadOnly = False
        TextBox2.ReadOnly = False

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button10.Visible = True
        GroupBox1.Visible = True
        Label7.Visible = True
        Button11.Visible = True
        ProgressBar1.Visible = True
        Label3.Visible = True
        GroupBox2.Visible = True
        ReserveCar.Close()
        ReturnCar.Close()
        ViewCar.Close()
        Add_Customer.Close()
        AddEmployee.Close()
        Add_new_car.Close()
        ViewCar.Close()
        Extend.Close()
        DamagedCars.Close()
        'report.close()
        GeneratingReports.Close()

        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        Button10.Visible = True
        GroupBox1.Visible = True
        Label7.Visible = True
        Button11.Visible = True
        ProgressBar1.Visible = True
        Label3.Visible = True
        GroupBox2.Visible = True
        Label8.Visible = True
        Label9.Visible = True

        ReserveCar.Close()
        ReturnCar.Close()
        ViewCar.Close()
        Add_Customer.Close()
        AddEmployee.Close()
        Add_new_car.Close()
        ViewCar.Close()
        Extend.Close()
        ViewReservation.Close()
        DamagedCars.Close()
        'report.close()
        GeneratingReports.Close()

        HomePage_Load(Me, New System.EventArgs)
        Me.Refresh()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False

        ReturnCar.Close()
        ViewCar.Close()
        Add_Customer.Close()
        Extend.Close()
        DamagedCars.Close()
        GeneratingReports.Close()

        ReserveCar.MdiParent = Me
        ReserveCar.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False

        ViewCar.Close()
        Add_Customer.Close()
        ReserveCar.Close()
        Extend.Close()
        GeneratingReports.Close()

        ReturnCar.MdiParent = Me
        ReturnCar.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False
        AddEmployee.Close()
        Add_new_car.Close()
        Extend.Close()
        GeneratingReports.Close()
        'report.close()
        ViewCar.MdiParent = Me
        ViewCar.Show()
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        About.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Contacts.Show()
    End Sub

    'Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
    '    ToolTip1.tooliptext "Your not logged in"
    'End Sub

    'Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
    '    ToolTip1.Tag = "Your are logged in"
    'End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Button10.Visible = False
        GroupBox1.Visible = False
        Label7.Visible = False
        Button11.Visible = False
        ProgressBar1.Visible = False
        Label3.Visible = False
        GroupBox2.Visible = False

        ReturnCar.Close()
        ViewCar.Close()
        Add_Customer.Close()
        ReserveCar.Close()
        AddEmployee.Close()
        'report.close()
        Add_new_car.Close()
        GeneratingReports.Close()

        Extend.MdiParent = Me
        Extend.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        'Help.ShowHelp(Me, HP.HelpNamespace)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, HP.HelpNamespace)
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Help.ShowHelp(Me, HP.HelpNamespace)
    End Sub
End Class