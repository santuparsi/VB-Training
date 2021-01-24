Public Class Calculate
    Sub Add(i As Integer, j As Integer)
        Dim res As Integer
        res = i + j
        Console.WriteLine("Addition: " & res)
    End Sub
    Sub Square(a As Double)
        Dim res As Double
        res = a * a
        Console.WriteLine("Square: " & res)
    End Sub
    Sub Mul(a As Integer, Optional b As Integer = 10)
        Dim res As Integer
        res = a * b
    End Sub


End Class
Module Module2
    Sub main()
        Dim obj As New Calculate
        obj.Add(3, 5)
        obj.Square(4)
        obj.Mul(3)
        obj.Mul(3, 5)
    End Sub
End Module