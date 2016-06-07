Public Class ViewEmployee

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        AddEmployee.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        AddEmployee.Show()
    End Sub

    Private Sub EmployeeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub ViewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.EmployeeTable' table. You can move, or remove it, as needed.
        Me.EmployeeTableTableAdapter.Fill(Me.Group2DataSet1.EmployeeTable)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Employee ID" Then
            Label4.Visible = False
            TextBox3.Visible = False

            Label3.Visible = True
            TextBox2.Visible = True

            Button1.Text = "Search By Employee ID"
        ElseIf ComboBox1.SelectedItem = "ID Number" Then
            Label4.Visible = True
            TextBox3.Visible = True

            Label3.Visible = False
            TextBox2.Visible = False

            Button1.Text = "Search By ID Number"
        Else
            Label4.Visible = False
            TextBox3.Visible = False

            Label3.Visible = False
            TextBox2.Visible = False

            Button1.Text = ""
            ViewEmployee_Load(Me, New System.EventArgs)
            TextBox2.Clear()
            TextBox3.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "Search By Employee ID" Then
                EmployeeTableTableAdapter.FillByEmployeeID(Group2DataSet1.EmployeeTable, TextBox2.Text)

            ElseIf Button1.Text = "Search By ID Number" Then
                EmployeeTableTableAdapter.FillByEmployeeIDnum(Group2DataSet1.EmployeeTable, TextBox3.Text)

            Else
                ViewEmployee_Load(Me, New System.EventArgs)
                TextBox2.Clear()
                TextBox3.Clear()
            End If
        Catch g As Exception
        End Try
    End Sub
End Class