Module Module2
    Sub Main()
        Dim a() As Integer = {12, 23, 34, 45}
        Dim s() As String = {"Rohan", "Karan"}
        Dim ob() As Object = {"Tim", 12, True}
        Dim sum As Integer = 0
        For Each i In a
            ' Console.WriteLine(i * i)
            sum = sum + i
        Next
        Console.WriteLine("Sum of Array no's" & sum)


    End Sub
End Module
