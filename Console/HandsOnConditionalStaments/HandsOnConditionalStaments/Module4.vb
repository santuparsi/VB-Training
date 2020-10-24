Module Module4
    Sub Main()
        Dim a As Integer = 10
        Select Case a
            Case 10, 40
                Console.WriteLine("a is " & a)
            Case 50
                Console.WriteLine("a is " & a)
            Case 100
                Console.WriteLine("a is " & a)
            Case Else
                Console.WriteLine("Invalid Input")
        End Select
    End Sub
End Module
