Module Module2
    Sub Main()
        Dim i As Integer
        Console.WriteLine("Enter i value")
        i = Console.ReadLine() 'reads value from console 
        If i >= 0 Then
            Console.WriteLine("{0} is +Ve ", i)
        Else
            Console.WriteLine("{0} is -Ve ", i)
        End If
    End Sub
End Module
