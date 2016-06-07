Public Class Add_Customer

    Dim jbtbutton1 As Boolean = False
    Dim a As Date
    Dim MyId As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub CustomerTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group2DataSet1)

    End Sub

    Private Sub Add_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group2DataSet1.CustomerTable' table. You can move, or remove it, as needed.
        Me.CustomerTableTableAdapter.Fill(Me.Group2DataSet1.CustomerTable)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        jbtbutton1 = True

        TextBox19.Enabled = True       
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        MaskedTextBox1.Enabled = True
        TextBox7.Enabled = True
        ComboBox1.Enabled = True
        TextBox6.Enabled = True
        MaskedTextBox3.Enabled = True
        ComboBox2.Enabled = True
        TextBox5.Enabled = True
        ComboBox3.Enabled = True

        TextBox19.Clear()
        MaskedTextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        MaskedTextBox1.Clear()
        TextBox7.Clear()
        ComboBox1.ResetText()
        TextBox6.Clear()
        MaskedTextBox3.Clear()
        ComboBox2.ResetText()
        TextBox5.Clear()
        ComboBox3.ResetText()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox19.Enabled = True    
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        MaskedTextBox1.Enabled = True
        TextBox7.Enabled = True
        ComboBox1.Enabled = True
        TextBox6.Enabled = True
        MaskedTextBox3.Enabled = True
        ComboBox2.Enabled = True
        TextBox5.Enabled = True
        ComboBox3.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Try
        Dim value As String = MaskedTextBox3.Text
        Dim time As DateTime = DateTime.Parse(value)

        a = Date.Parse(MaskedTextBox3.Text)
        If jbtbutton1 = True Then
            'CustomerTableTableAdapter.InsertCustomer(TextBox19.Text, TextBox3.Text, TextBox6.Text, TextBox7.Text, TextBox4.Text, MaskedTextBox1.Text, ComboBox1.SelectedItem, ComboBox2.SelectedItem, TextBox5.Text, MaskedTextBox2.Text, time, ComboBox3.SelectedItem)
            MsgBox("New Customer added successfully", MsgBoxStyle.OkOnly, "CUSTOMER ADDED")
            jbtbutton1 = False

            TextBox19.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            MaskedTextBox1.Enabled = False
            TextBox7.Enabled = False
            ComboBox1.Enabled = False
            TextBox6.Enabled = False
            MaskedTextBox3.Enabled = False
            ComboBox2.Enabled = False
            TextBox5.Enabled = False
            ComboBox3.Enabled = False

            Add_Customer_Load(Me, New System.EventArgs)
        Else
            CustomerTableBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Group2DataSet1)
            MsgBox("Customer update successfully", MsgBoxStyle.OkOnly, "CUSTOMER UPDATION")

            TextBox19.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            MaskedTextBox1.Enabled = False
            TextBox7.Enabled = False
            ComboBox1.Enabled = False
            TextBox6.Enabled = False
            MaskedTextBox3.Enabled = False
            ComboBox2.Enabled = False
            TextBox5.Enabled = False
            ComboBox3.Enabled = False

            Add_Customer_Load(Me, New System.EventArgs)
        End If
        'Catch
        '    MsgBox("Make sure all your textbox are filled accordingly ", MsgBoxStyle.Exclamation, "ERROR")
        'End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        ViewCustomer.MdiParent = HomePage
        ViewCustomer.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MaskedTextBox2.Text = "9401175343087"
        MaskedTextBox1.Text = "0729212672"
        TextBox19.Text = "Tom"
        TextBox4.Text = "Soni@gmail.com"
        TextBox3.Text = "Soni"
        TextBox7.Text = "Wob"
        ComboBox1.SelectedItem = "Mr"
        TextBox6.Text = "84512-kw-789"
        MaskedTextBox3.Text = "19940117"
        ComboBox2.SelectedItem = "KwaZulu Natal"
        TextBox5.Text = "PMB"
        ComboBox3.SelectedItem = "None"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Try
        '    If ((Group2DataSet1.CustomerTable, MaskedTextBox2.Text)) > 0 Then
        '        MsgBox("Customer exists in the database", MsgBoxStyle.OkOnly, "RETRIEVE INFO")
        '    Else
        '        MsgBox("Customer does not exist", MsgBoxStyle.OkOnly, "CAPTURE DATA")
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
            MaskedTextBox2.Clear()
            MaskedTextBox2.Focus()
        End If
        Return 0
    End Function


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MyId = MaskedTextBox2.Text

        If (parseIdNo(MyId)) Then
            MsgBox("ID Number is valid", MsgBoxStyle.OkOnly, "ERROR")
            'MyYear = Integer.Parse(MyId.Substring(0, 2))
            'MyYear = "19" & MyYear

            'MyMonth = Integer.Parse(MyId.Substring(2, 2))
            ''MsgBox(MyMonth)

            'MyDate = Integer.Parse(MyId.Substring(4, 2))

            MaskedTextBox3.Text = "19" & MyId.Substring(0, 2) & "/" & MyId.Substring(2, 2) & "/" & MyId.Substring(4, 2)

        Else
            MsgBox("ID Number is not valid", MsgBoxStyle.OkOnly, "ERROR")
            MaskedTextBox2.Clear()
            MaskedTextBox2.Focus()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class