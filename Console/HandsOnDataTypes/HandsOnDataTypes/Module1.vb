Module Module1

    Sub Main()
        'Datatypes in VB.net
        Dim b As Byte
        Dim n As Integer
        Dim si As Single
        Dim d As Double
        Dim da As Date
        Dim c As Char
        Dim s As String
        Dim bl As Boolean

        ' assign values
        b = 1
        n = 3420834
        si = 0.43093249
        d = 12.3224934934
        da = Today
        c = "R"
        s = "David"
        bl = True
        Console.WriteLine(da)
        Console.WriteLine("b:" & b & " and n:" & n)
        Console.WriteLine("b:{0} and n:{1}", b, n)
        Console.WriteLine("Single Value:{0} and Double Value:{1}", si, d)
    End Sub

End Module
