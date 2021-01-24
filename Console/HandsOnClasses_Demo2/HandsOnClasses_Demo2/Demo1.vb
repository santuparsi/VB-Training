Public Class Demo1
    Public res As Double
    Public Sub Add(i As Integer, j As Integer)
        res = i + j
        'Console.WriteLine(res)
    End Sub
    Public Sub Add(i As Integer, j As Integer, k As Integer)
        res = i + j + k
    End Sub
    Public Sub Add(a As Double, b As Integer)
        res = a + b
    End Sub
    Public Sub Add(a As Integer, b As Double)
        res = a + b
    End Sub
End Class
Module Module3
    Sub main()
        Dim obj As New Demo1
        obj.Add(2, 3)
        obj.Add(2, 3, 4)
        obj.Add(3.4, 2)
        obj.Add(4, 2.3)
    End Sub
End Module
