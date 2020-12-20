Public Class Login
    Private Sub t2_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub ValidateUser(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname, pwd As String
        uname = txtUname.Text
        pwd = txtPwd.Text
        If uname = Nothing Then
            MessageBox.Show("Pls Enter Username")
        ElseIf pwd = Nothing Then
            MessageBox.Show("Pls Enter Password")
        ElseIf uname = "Admin" And pwd = "12345" Then

            MessageBox.Show("Valid User")
        Else
            MessageBox.Show("Invalid user")
        End If
    End Sub

    Private Sub SignUp(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj As New Register 'Register is a Form to navigate
        Me.Hide() 'Hide the current form(Login)
        obj.ShowDialog() 'open Register form
        Me.Dispose() 'Dispose hided form

    End Sub
End Class