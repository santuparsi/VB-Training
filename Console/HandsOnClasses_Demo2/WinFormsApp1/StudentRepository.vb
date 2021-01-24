Imports System.Collections
Public Class StudentRepository
    Public Shared list As New ArrayList
    Public Sub AddStudent(ob As Student)
        list.Add(ob)
    End Sub
    Public Function GetStudent(id As Integer) As Student
        For Each s As Student In list
            If s.Sid = id Then
                Return s
            End If
        Next
        Return Nothing
    End Function
End Class
