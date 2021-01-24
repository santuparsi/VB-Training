Imports System.IO

Module Module1
    Sub Read(path As String)
        Try
            Using sr As New StreamReader(path)
                Dim content As String
                content = sr.ReadToEnd
                Console.WriteLine(content)

            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    Sub Write(path As String)
        Using sw As New StreamWriter(path, True)
            Dim content As String
            content = ".Net Core 5.0 was realeased by the Month of Nov 2020"
            sw.WriteLine(content)
        End Using
    End Sub
    Sub Main()
        Console.WriteLine("Enter the Path")
        Dim path As String = Console.ReadLine
        '  Read(path)
        Write(path)
        Read(path)
    End Sub

End Module
