Imports System.Collections

Public Class Demo1
    Shared Sub main()
        Dim ar1 As New ArrayList() From {"Rohan", "Charan", "Suren"}
        Dim ar As New ArrayList
        'adding values
        ar.Add(10)
        ar.Add(23)
        ar.Add(34)
        ar.Add(45)
        ar.Add(56)
        ar.Insert(2, 78) 'inserted 78 as 3rd element
        'access value
        Dim i As Integer = ar(1)
        Console.WriteLine(i)
        ar.Sort()
        ar.Reverse()
        For Each j In ar
            Console.WriteLine(j)
        Next


    End Sub
End Class
