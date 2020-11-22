Module Module2
    Sub Main()
        Dim s1 As New Student
        s1.sId = 100
        s1.sName = "Rohan"
        s1.dob = Date.Now

        Dim s2 As Student = New Student()
        s2.sId = 101
        s2.sName = "Charan"
        s2.dob = Date.Parse("12.2.2010")

        Dim s3 As Student = New Student()
        s3.Register(102, "Tim", Date.Parse("12.3.2011"))

        'Add objects into array
        Dim student_list(30) As Student
        student_list(0) = s1
        student_list(1) = s2
        student_list(2) = s3
        student_list(3) = New Student()
        student_list(3).dob = Date.Parse("12.3.2010")
        student_list(3).sId = 104
        student_list(3).sName = "Jack"
        For Each s In student_list
            If Not (s Is Nothing) Then

                s.show()

            End If

        Next

    End Sub
End Module
