Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = TxtName.Text 'return textbox value
        If n = Nothing Then
            MessageBox.Show("Pls Enter Name")
            TxtName.Focus()
        Else
            Dim msg As String = "Hello " & n
            MessageBox.Show(msg) 'show the message in the messagebox
        End If



    End Sub
End Class
