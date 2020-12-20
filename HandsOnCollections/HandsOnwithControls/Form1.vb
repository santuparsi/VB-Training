Imports System.Collections

Public Class Form1
    Dim ar1 As New ArrayList()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ar As New ArrayList() From {
        "Keyboard",
        "Mouse",
        "Pendrive",
        "Speakers"
        }
        For Each item In ar
            cmb2.Items.Add(item) 'Add items to combobox
        Next
        cmb1.DataSource = ar

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As String
        n = t1.Text
        ar1.Add(n)
        cmb3.Items.Clear()
        'For Each item In ar1
        '    cmb3.Items.Add(item) 'Add items to combobox
        'Next
        cmb3.DataSource = ar1
    End Sub
End Class
