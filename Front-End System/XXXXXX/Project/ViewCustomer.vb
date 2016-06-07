Public Class ViewCustomer

    Private Sub CustomerTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub

    Private Sub ViewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.Group2DataSet.CustomerTable)
        'TODO: This line of code loads data into the 'Group2DataSet1.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.Group2DataSet.CustomerTable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "Search By Customer ID" Then
                CustomerTableTableAdapter.FillByCustomerID(Group2DataSet.CustomerTable, TextBox1.Text)

            ElseIf Button1.Text = "Search By ID Number" Then
                CustomerTableTableAdapter.FillByIDnum(Group2DataSet.CustomerTable, TextBox2.Text)
            Else
                ViewCustomer_Load(Me, New System.EventArgs)
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        Catch g As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Customer ID" Then
            Label3.Visible = False
            TextBox2.Visible = False

            Label4.Visible = True
            TextBox1.Visible = True

            Button1.Text = "Search By Customer ID"
        ElseIf ComboBox1.SelectedItem = "ID Number" Then
            Label3.Visible = True
            TextBox2.Visible = True

            Label4.Visible = False
            TextBox1.Visible = False

            Button1.Text = "Search By ID Number"
        Else
            Label3.Visible = False
            TextBox2.Visible = False

            Label4.Visible = False
            TextBox1.Visible = False

            Button1.Text = ""
            ViewCustomer_Load(Me, New System.EventArgs)
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Add_new_car.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Add_Customer.Show()
        Me.Close()
    End Sub

    Private Sub CustomerTableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet)

    End Sub


End Class