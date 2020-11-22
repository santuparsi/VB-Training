Public Class Student
    'variables
    'functions
    'procedures
    'constructors
    'properties
    Public sId As Integer
    Public sName As String
    Public dob As Date
    Public Sub Register(id As Integer, name As String, d As Date)
        sId = id
        sName = name
        dob = d
    End Sub
    'procedure
    Public Sub show()
        'display student details
        Console.WriteLine("ID:{0} Name:{1} DOB:{2}", sId, sName, dob)
    End Sub
End Class
