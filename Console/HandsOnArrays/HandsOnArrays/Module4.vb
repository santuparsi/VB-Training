Module Module4
    Sub Main()
        Dim a() As Integer = {12, 23, 14, 45}
        Array.Sort(a) 'sort array elements
        Array.Reverse(a)
        For Each i In a
            Console.WriteLine(i)
        Next
    End Sub
End Module
