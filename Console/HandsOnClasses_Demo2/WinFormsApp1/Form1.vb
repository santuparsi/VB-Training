Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtAge.TextChanged

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim s As New Student
        Dim repo As New StudentRepository
        s.Sid = txtID.Text
        s.Sname = txtName.Text
        s.Age = txtAge.Text
        repo.AddStudent(s)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim repo As New StudentRepository
        Dim s As New Student
        Dim id As Integer = CInt(txtID.Text)
        s = repo.GetStudent(id)
        If s IsNot Nothing Then
            MessageBox.Show("Hello " & s.Sname)
        Else
            MessageBox.Show("Invalid Id")
        End If


    End Sub
End Class
