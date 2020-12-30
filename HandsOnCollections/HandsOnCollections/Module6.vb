Module Module6
    Sub main()
        Dim obj As New Queue
        'add items in a queue
        obj.Enqueue("rohan")
        obj.Enqueue("suren")
        obj.Enqueue("ram")
        obj.Enqueue("john")
        Console.WriteLine("items count: " & obj.Count)
        Console.WriteLine("first item: " & obj.Peek)
        For Each k In obj
            Console.WriteLine(k)
        Next
        Console.WriteLine("removed item: " & obj.Dequeue)
        For Each k In obj
            Console.WriteLine(k)
        Next

    End Sub
End Module
