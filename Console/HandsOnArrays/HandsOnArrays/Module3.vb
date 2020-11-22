Module Module3
    Sub Main()
        Dim n() As String = {"Rohan", "Karan", "Suren", "Jeson"}
        Console.WriteLine("Enter name")
        Dim a As String = Console.ReadLine() 'reads a value from input(command)
        'Dim f As Boolean = False
        'For Each i In n
        '    If i = a Then
        '        f = True
        '        Console.WriteLine("Valid User")
        '    End If
        'Next
        'If Not f Then
        '    Console.WriteLine("Invalid User")
        'End If
        Array.Sort(n)
        If Array.BinarySearch(n, a) > 0 Then
            Console.WriteLine("Valid User")
        Else
            Console.WriteLine("Invalid User")
        End If

    End Sub
End Module
