Imports System.IO

Public Class ErrorLog
    Public Shared Sub WriteLog(ex As Exception)
        Dim err As String
        err = "ERROR_MESSAGE: " & ex.Message & vbNewLine &
        "ERROR_DATE: " & Today
        Using sw As New StreamWriter("D:/errlog.txt", True)
            sw.WriteLine(err)
        End Using
    End Sub
End Class
