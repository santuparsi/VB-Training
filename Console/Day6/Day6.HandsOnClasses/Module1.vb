Module Module1

    Sub Main()
        ' Dim i As Integer
        'create object to student
        Dim s1 As New Student
        s1.sId = 100
        s1.sName = "Rohan"
        s1.dob = Date.Now
        's1.show()
        Dim s2 As Student = New Student()
        s2.sId = 101
        s2.sName = "Charan"
        s2.dob = Date.Parse("12.2.2010")
        ' s2.show()
        Dim s3 As Student = New Student()
        s3.Register(102, "Tim", Date.Parse("12.3.2011"))
        's3.show()
        'reading data from input
        Dim s4 As Student = New Student()
        Console.WriteLine("Enter Id")
        s4.sId = Integer.Parse(Console.ReadLine())
        Console.WriteLine("Enter Name")
        s4.sName = Console.ReadLine()
        Console.WriteLine("Enter DOB")
        s4.dob = Date.Parse(Console.ReadLine())
        's4.show()


    End Sub

End Module
