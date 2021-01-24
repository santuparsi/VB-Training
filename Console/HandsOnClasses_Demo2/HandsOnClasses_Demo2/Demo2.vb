Public Class Demo2
    Public Function Greet(name As String) As String
        Dim res As String
        res = "Hello " + name
        Return res
    End Function
    Public Function Add(i As Integer, j As Integer) As Integer
        Dim res As Integer
        res = i + j
        Return res
    End Function
End Class
Module Module5
    Sub main()
        Dim obj As New Demo2
        Dim r As String = obj.Greet("Sachin")
        Dim k As Integer = obj.Add(2, 3)
    End Sub
End Module