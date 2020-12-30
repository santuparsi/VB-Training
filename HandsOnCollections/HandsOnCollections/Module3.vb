Imports System.Collections

Module Module3
    Sub main()
        Dim logins As New Hashtable() From {
        {"rohan", "rohan@123"},
        {"suren", "suren@123"},
        {"karan", "karan@123"},
        {"john", "john@123"}
        }
        Console.WriteLine("enter username")
        Dim uname As String = Console.ReadLine
        Console.WriteLine("enter password")
        Dim pwd As String = Console.ReadLine
        Dim flag As Boolean = False
        For Each k In logins.Keys
            If k.Equals(uname) And logins(k).Equals(pwd) Then
                Console.WriteLine("valid user")
                flag = True
                Exit For
            End If
        Next

        If Not flag Then
            Console.WriteLine("invalid user")
        End If

    End Sub
End Module
