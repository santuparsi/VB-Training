Module Module3
    Sub Main()
        Dim m1, m2, m3, m4, m5 As Double
        m1 = 67.8
        m2 = 80
        m3 = 60
        m4 = 60
        m5 = 60
        Dim tot As Double = (m1 + m2 + m3 + m4 + m5)
        Dim avg As Double = tot \ 5
        ' Console.WriteLine(avg)
        If m1 < 40 Or m2 < 40 Or m3 < 40 Or m4 < 40 Or m5 < 40 Then
            Console.WriteLine("Result:Fail ")
        ElseIf avg >= 70 Then
            Console.WriteLine("Result:Distinction Total Marks:{0}", tot)
        ElseIf avg >= 60 And avg < 70 Then
            Console.WriteLine("Result:FirstClass Total Marks:{0}", tot)
        End If
    End Sub
End Module
