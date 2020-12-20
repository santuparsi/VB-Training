Public Class Calculator
    Dim a, b, c As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        a = Integer.Parse(t1.Text)
        b = Integer.Parse(t2.Text)
        c = a + b
        msgLbl.Text = "Addition: " + c.ToString()

    End Sub
End Class