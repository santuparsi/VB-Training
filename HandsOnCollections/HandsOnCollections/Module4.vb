Module Module4
    Sub main()
        Dim obj As New SortedList
        obj.Add(1345, "Rohan")
        obj.Add(3456, "Karan")
        obj.Add(7898, "Sachin")
        obj.Add(4345, "David")
        For Each i In obj.Keys
            Console.WriteLine("key:{0} value:{1}", i, obj(i))
        Next
    End Sub
End Module
