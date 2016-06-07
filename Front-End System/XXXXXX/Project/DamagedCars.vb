Public Class DamagedCars

    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub DamagedCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Group2DataSet.CarTable' table. You can move, or remove it, as needed.
        'Me.CarTableTableAdapter2.Fill(Me.Group2DataSet.CarTable)
        CarTableTableAdapter2.FillByDamaged(Group2DataSet1.CarTable, "Damaged")
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CarTableTableAdapter2.FillByRegistrationNo(Group2DataSet1.CarTable, TextBox3.Text, "Damaged")
            TextBox2.Text = ReservationTableTableAdapter1.FillByDamageAmount(TextBox4.Text)
        Catch
            MsgBox("Your search has no match", MsgBoxStyle.Exclamation, "Error detected")
        End Try

        TextBox6.Text = CustomerTableTableAdapter1.FillByCustNameDamage(TextBox4.Text)
        TextBox7.Text = CustomerTableTableAdapter1.FillByCustSurDamage(TextBox4.Text)
        TextBox8.Text = CustomerTableTableAdapter1.FillByCustCellDamage(TextBox4.Text)
        TextBox9.Text = CustomerTableTableAdapter1.FillByCustBalanceDamage(TextBox4.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            CarTableTableAdapter2.UpdateAvailableFromRented("Available", (TextBox4.Text))
            CarTableTableAdapter2.UpdateQueryDescription("", TextBox4.Text)
            TextBox2.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            MsgBox("The car has been repaired")
            DamagedCars_Load(Me, New System.EventArgs)
        Catch
            MsgBox("No Damaged Cars Available To Repair")
        End Try
    End Sub

    Private Sub CarTableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Enabled = True
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ReservationTableTableAdapter1.UpdateDamageAmount(Double.Parse(TextBox2.Text), TextBox4.Text)
            CustomerTableTableAdapter1.UpdateCustBalance(Double.Parse(TextBox2.Text), TextBox8.Text)

        Catch
            MsgBox("Please enter damage amount", MsgBoxStyle.Exclamation)
        End Try
        MsgBox("Your updates was done")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class