Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim name As String
        name = ComboBox1.Text
        'MessageBox.Show(name)
        'clear items in listbox
        ListBox1.Items.Clear()
        Select Case name
            Case "Apple"
                ListBox1.Items.Add("IPhone-11s")
                ListBox1.Items.Add("IPhone-12s")
                ListBox1.Items.Add("IPhone-12s Pro")
            Case "Samsung"
                ListBox1.Items.Add("Samsung-J8")
                ListBox1.Items.Add("Samsung-J9")
                ListBox1.Items.Add("Samsung-J10")
            Case "Oppo"
                ListBox1.Items.Add("Oppo-11s")
                ListBox1.Items.Add("Oppo-12s")
                ListBox1.Items.Add("Oppo-12s Pro")
            Case "Vivo"
                ListBox1.Items.Add("Vivo-J8")
                ListBox1.Items.Add("Vivo-J9")
                ListBox1.Items.Add("Vivo-J10")
        End Select
    End Sub
End Class
