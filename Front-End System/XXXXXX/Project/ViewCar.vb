Public Class ViewCar

    Private Sub CarTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub ViewCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet.CarTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.CarTable' table. You can move, or remove it, as needed.
        Me.CarTableTableAdapter.Fill(Me.Group2DataSet.CarTable)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Button2.Text = "Search By Car ID" Then
                CarTableTableAdapter.FillByCarID(Group2DataSet.CarTable, TextBox3.Text)
            ElseIf Button2.Text = "Search By Car Model" Then
                CarTableTableAdapter.FillBySearchModel(Group2DataSet.CarTable, TextBox2.Text)
            Else
                ViewCar_Load(Me, New System.EventArgs)
                TextBox3.Clear()
                TextBox2.Clear()
            End If
        Catch g As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If ComboBox1.SelectedItem = "Car ID" Then
                Label3.Visible = False
                TextBox2.Visible = False

                Label4.Visible = True
                TextBox3.Visible = True

                Button2.Text = "Search By Car ID"

            ElseIf ComboBox1.SelectedItem = "Car Name" Then
                Label3.Visible = True
                TextBox2.Visible = True

                Label4.Visible = False
                TextBox3.Visible = False

                Button2.Text = "Search By Car Name"
            Else
                Label3.Visible = False
                TextBox2.Visible = False

                Label4.Visible = False
                TextBox3.Visible = False

                Button2.Text = ""
                ViewCar_Load(Me, New System.EventArgs)
                TextBox3.Clear()
                TextBox2.Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Add_new_car.Show()
        HomePage.Show()
        Me.Close()
    End Sub

  
    Private Sub CarTableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub
End Class