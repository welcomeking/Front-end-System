Public Class AddEmployee
    Dim btnClicked As Boolean = False
    Dim MyId As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If btnClicked = True Then
                'EmployeeTableTableAdapter.InsertEmployee(TextBox2.Text, TextBox3.Text, MaskedTextBox1.Text, TextBox7.Text, TextBox4.Text, TextBox1.Text, ComboBox1.SelectedItem, TextBox5.Text, TextBox6.Text)
                MsgBox("New Employee added Successfully", MsgBoxStyle.OkOnly, "NEW EMPLOYEE ADDED")
                btnClicked = False

                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox7.Enabled = False
                TextBox4.Enabled = False
                TextBox1.Enabled = False
                ComboBox1.Enabled = False
                TextBox5.Enabled = False
                TextBox6.Enabled = False

                AddEmployee_Load(Me, New System.EventArgs)
            Else
                EmployeeTableBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Group2DataSet1)
                MsgBox("Employee updated Successfully", MsgBoxStyle.OkOnly, "EMPLOYEE UPDATION")

                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox7.Enabled = False
                TextBox4.Enabled = False
                TextBox1.Enabled = False
                ComboBox1.Enabled = False
                TextBox5.Enabled = False
                TextBox6.Enabled = False

                AddEmployee_Load(Me, New System.EventArgs)
            End If
        Catch
            MsgBox("Make sure all your textbox are filled accordingly ", MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Private Sub EmployeeTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeeTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.EmployeeTable' table. You can move, or remove it, as needed.
        Me.EmployeeTableTableAdapter.Fill(Me.Group2DataSet1.EmployeeTable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        btnClicked = True

        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox7.Enabled = True
        TextBox4.Enabled = True
        TextBox1.Enabled = True
        ComboBox1.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True

        TextBox2.Clear()
        TextBox3.Clear()
        TextBox7.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        ComboBox1.ResetText()
        TextBox5.Clear()
        TextBox6.Clear()
        MaskedTextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox7.Enabled = True
        TextBox4.Enabled = True
        TextBox1.Enabled = True
        ComboBox1.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True      
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        ViewEmployee.MdiParent = HomePage
        ViewEmployee.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MaskedTextBox1.Text = "9512035210082"
        TextBox1.Text = "0729212672"
        TextBox2.Text = "Tom"
        TextBox4.Text = "Soni@gmail.com"
        TextBox3.Text = "Soni"
        TextBox7.Text = "Wob"
        ComboBox1.SelectedItem = "Manager"
        TextBox5.Text = "Tom"
        TextBox6.Text = "Soni"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Try
        '    If (EmployeeTableTableAdapter.FillByIDDD(Group2DataSet1.EmployeeTable, MaskedTextBox1.Text)) > 0 Then
        '        MsgBox("Employee exists in the database", MsgBoxStyle.OkOnly, "RETRIEVE INFO")
        '    Else
        '        MsgBox("Employee does not exist", MsgBoxStyle.OkOnly, "CAPTURE DATA")
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Public Function parseIdNo(ByVal idNo As String) As Boolean
        If MyId.Length = 13 Then

            Dim a As Integer = 0
            For i As Integer = 0 To 5
                a += CInt(MyId.Substring(i * 2, 1))
            Next

            Dim b As Integer = 0
            For i As Integer = 0 To 5
                b = b * 10 + CInt(MyId.Substring(2 * i + 1, 1))
            Next
            b *= 2
            Dim c As Integer = 0
            Do
                c += b Mod 10
                b = Int(b / 10)
            Loop Until b <= 0
            c += a
            Dim d As Integer = 0
            d = 10 - (c Mod 10)
            If (d = 10) Then d = 0
            If d = CInt(MyId.Substring(12, 1)) Then
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("ID Number must have 13 digits")
            MaskedTextBox1.Clear()
            MaskedTextBox1.Focus()
        End If
        Return 0
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MyId = MaskedTextBox1.Text

        If (parseIdNo(MyId)) Then
            MsgBox("ID Number is valid", MsgBoxStyle.OkOnly, "ERROR")
            'MyYear = Integer.Parse(MyId.Substring(0, 2))
            'MyYear = "19" & MyYear

            'MyMonth = Integer.Parse(MyId.Substring(2, 2))
            ''MsgBox(MyMonth)

            'MyDate = Integer.Parse(MyId.Substring(4, 2))

            'MaskedTextBox3.Text = "19" & MyId.Substring(0, 2) & "/" & MyId.Substring(2, 2) & "/" & MyId.Substring(4, 2)

        Else
            MsgBox("ID Number is not valid", MsgBoxStyle.OkOnly, "ERROR")
            MaskedTextBox1.Clear()
            MaskedTextBox1.Focus()
        End If
    End Sub
End Class