Module Module5
    Sub main()
        Dim obj As New Stack
        'add items
        obj.Push(23)
        obj.Push(45)
        obj.Push(56)
        obj.Push(89)
        obj.Push(34)
        Console.WriteLine("selected value: " & obj.Peek())
        For Each k In obj
            Console.WriteLine(k)
        Next
        Console.WriteLine("removed value: " & obj.Pop)
        For Each k In obj
            Console.WriteLine(k)
        Next
        obj.Clear() 'to clear stack collection
    End Sub
End Module
