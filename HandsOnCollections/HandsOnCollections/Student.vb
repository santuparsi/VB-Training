Imports System.Collections

Public Class Student
    Public Sid As Integer
    Public Sname As String
    Public Age As Integer

End Class
Public Class Test_Student
    Shared Sub main()
        Dim s1 As New Student() With {.Sid = 12, .Sname = "Rohan", .Age = 12}
        Dim s2 As New Student() With {.Sid = 13, .Sname = "Karan", .Age = 12}
        Dim s3 As New Student() With {.Sid = 15, .Sname = "Jeson", .Age = 12}
        Dim s4 As New Student() With {.Sid = 19, .Sname = "Monica", .Age = 12}
        Dim s5 As New Student() With {.Sid = 11, .Sname = "Kiran", .Age = 12}
        Dim ar As New ArrayList() From {s1, s2, s3, s4, s5}
        For Each s As Student In ar
            Console.WriteLine("{0} {1} {2}", s.Sid, s.Sname, s.Age
                              )
        Next







    End Sub
End Class
