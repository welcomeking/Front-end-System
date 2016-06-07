Public Class Add_new_car
    Dim buttonNew As Boolean = False
    Dim car As Integer
    Private Sub Add_new_car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        'Me.CarTableTableAdapter.Fill(Me.Group2DataSet1.CarTable)
        'CarTableTableAdapter.Fill(Group2DataSet1.CarTable)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        buttonNew = True

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ' TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True



        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        'TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If buttonNew = True Then
                '(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text)
                MsgBox("Car added successfully", MsgBoxStyle.OkOnly, "CAR ADDED")
                Add_new_car_Load(Me, New System.EventArgs)
            Else
                CarTableBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Group2DataSet1)
                MsgBox("Car updated successfully", MsgBoxStyle.OkOnly, "CAR UPDATED")
                ' ViewMlu_Load(Me, New System.EventArgs)
            End If
        Catch ex As Exception
            MsgBox("Something went wrong")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        'TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'CarTableBindingSource.RemoveCurrent()
        CarTableDataGridView.Rows.RemoveAt(CarTableDataGridView.CurrentRow.Index)
        MsgBox("Car deleted successfully", MsgBoxStyle.OkOnly, "DELETE CAR")
        'Add_new_car_Load(Me, New System.EventArgs)
    End Sub

    Private Sub Reg_TextChanged(sender As Object, e As EventArgs)
        CarTableBindingSource.RemoveFilter()
        'BSCar.Filter = " [Registration No] like '%" & Reg.Text & "%'"
    End Sub

    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ViewCar.MdiParent = HomePage
        Me.Hide()
        ViewCar.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Try
        '    If (CarTableTableAdapter.FillByjj(Group2DataSet1.CarTable, TextBox1.Text)) > 0 Then
        '        MsgBox("Car already exists in the database", MsgBoxStyle.OkOnly, "RETRIEVE INFO")
        '    Else
        '        MsgBox("Car does not exist", MsgBoxStyle.OkOnly, "CAPTURE DATA")
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text = "NUR 895"
        TextBox2.Text = "BMW"
        TextBox3.Text = "BMW 320i"
        TextBox4.Text = "Red"
        TextBox5.Text = "120.00"
        ' TextBox6.Text = "50.0"
        TextBox7.Text = "Available"
        TextBox8.Text = "299"
        TextBox9.Text = "2999"
        TextBox10.Text = "Car"
        TextBox11.Text = "A"
        TextBox12.Text = "Masiya"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DamagedCars.MdiParent = HomePage
        Me.Hide()
        DamagedCars.Show()
    End Sub
End Class