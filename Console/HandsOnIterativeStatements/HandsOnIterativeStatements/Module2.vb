Module Module2
    Sub Main()
        Dim a As Integer = 10
        'Do
        '    Console.WriteLine("value of a: {0} ", a)
        '    a = a + 1
        'Loop While a < 20
        Do
            Console.WriteLine("value of a: {0} ", a)
            a = a + 1
        Loop Until a = 15
    End Sub
End Module
