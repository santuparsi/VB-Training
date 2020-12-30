Imports System.Collections

Module Module2
    Sub main()
        Dim obj As New Hashtable()
        'add key-value pairs
        obj.Add(1345, "Rohan")
        obj.Add(3456, "Karan")
        obj.Add(7898, "Sachin")
        obj.Add(4345, "David")
        'access value from hashtable
        Dim name As String
        name = obj(3456)
        'access all values of keys
        For Each i In obj.Keys
            Console.WriteLine("key:{0} value:{1}", i, obj(i))
        Next
    End Sub
End Module
