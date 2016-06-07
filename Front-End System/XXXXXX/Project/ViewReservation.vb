Public Class ViewReservation

    Private Sub ReservationTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub ViewReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet.ReservationTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.ReservationTable' table. You can move, or remove it, as needed.
        Me.ReservationTableTableAdapter.Fill(Me.Group2DataSet.ReservationTable)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Reg No" Then
            'Label4.Visible = False
            'TextBox3.Visible = False

            Label4.Visible = True
            TextBox3.Visible = True

            Button1.Text = "Search By Registration No"
        Else
         
            Label4.Visible = False
            TextBox3.Visible = False

            Button1.Text = ""
            ViewReservation_Load(Me, New System.EventArgs)
            TextBox3.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Search By Registration No" Then
            ReservationTableTableAdapter.FillBySearchReg(Group2DataSet.ReservationTable, TextBox3.Text)
        Else
            ViewReservation_Load(Me, New System.EventArgs)
            TextBox3.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ReserveCar.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ReservationTableTableAdapter.DeleteReservation(TextBox1.Text)
            MsgBox("Booking Cancelled", MsgBoxStyle.OkOnly, "BOOKING CANCELLED")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ReservationTableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim count As Integer = ReservationTableTableAdapter.ScalarQueryCount()
        ReservationTableTableAdapter.FillByLastReservation(Group2DataSet.ReservationTable, count)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ViewReservation_Load(Me, New System.EventArgs)
        TextBox1.Clear()
    End Sub
End Class