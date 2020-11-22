Module Module1

    Sub Main()
        'array declaration
        Dim n(5) As Integer
        'assing array values
        n(0) = 10
        n(1) = 20
        n(2) = 30
        n(3) = 40
        n(4) = 50
        n(5) = 60
        'access value from an array
        Console.WriteLine("value at index 2:{0} ", n(2))
        Dim i As Integer
        'For i = 0 To 5
        '    Console.WriteLine("value at {0} index is {1}", i, n(i))
        'Next
        For i = 0 To n.Length - 1
            Console.WriteLine("value at {0} index is {1}", i, n(i))
        Next
    End Sub

End Module
