Module Module2
    Sub Div(a As Byte, b As Byte)
        Try
            Dim res As Byte
            res = a \ b
            Console.WriteLine("Divison of {0}/{1} is {2} ", a, b, res)
        Catch ex As Exception
            ErrorLog.WriteLog(ex)
        End Try
    End Sub
    Sub Add(a As Byte, b As Byte)
        Try
            Dim res As Byte
            res = a + b
            Console.WriteLine("Additon of {0} and {1} is {2} ", a, b, res)
        Catch ex As Exception
            ErrorLog.WriteLog(ex)
        End Try
    End Sub
    Sub main()
        Try
            Dim a, b As Byte
            Console.WriteLine("Enter a,b values")
            a = Console.ReadLine
            b = Console.ReadLine
            Div(a, b)
            Add(a, b)
        Catch ex As Exception
            ErrorLog.WriteLog(ex)
        End Try

    End Sub
End Module
