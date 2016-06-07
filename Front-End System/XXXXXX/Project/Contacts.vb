Public Class Contacts

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Focus()
    End Sub
End Class