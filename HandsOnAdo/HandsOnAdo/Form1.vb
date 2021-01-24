Imports System.Data.SqlClient

Public Class Form1
    Private Sub Add(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim con As New SqlConnection("Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1")
            Dim cmd As New SqlCommand("INSERT INTO PRODUCTS VALUES(@PID,@PNAME,@PRICE,@STOCK)", con)
            'Passing values to parameters
            cmd.Parameters.AddWithValue("@PID", txtId.Text)
            cmd.Parameters.AddWithValue("@PNAME", txtName.Text)
            cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text)
            cmd.Parameters.AddWithValue("@STOCK", txtStock.Text)
            con.Open() 'Open connection to the database
            cmd.ExecuteNonQuery()
            con.Close()
            '  MessageBox.Show("Record Added")
            GetALL()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Search(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim con As New SqlConnection("Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1")
            Dim cmd As New SqlCommand("SELECT * FROM PRODUCTS WHERE PID=@PID", con)
            'Passing values to parameters
            cmd.Parameters.AddWithValue("@PID", txtId.Text)
            con.Open() 'Open connection to the database
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                txtName.Text = dr("Pname")
                txtPrice.Text = dr("Price")
                txtStock.Text = dr("Stock")
                con.Close()
            Else
                MessageBox.Show("Invalid Id")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetALL()
    End Sub
    Sub GetALL()
        Try
            Dim con As New SqlConnection("Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1")
            Dim cmd As New SqlCommand("SELECT * FROM PRODUCTS", con)
            con.Open() 'Open connection to the database
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable
            dt.Load(dr)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Update_Product(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim con As New SqlConnection("Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1")
            Dim cmd As New SqlCommand("UPDATE PRODUCTS SET PRICE=@PRICE,STOCK=@STOCK WHERE PID=@PID", con)
            'Passing values to parameters
            cmd.Parameters.AddWithValue("@PID", txtId.Text)
            cmd.Parameters.AddWithValue("@PRICE", txtPrice.Text)
            cmd.Parameters.AddWithValue("@STOCK", txtStock.Text)
            con.Open() 'Open connection to the database
            cmd.ExecuteNonQuery()
            con.Close()
            '  MessageBox.Show("Record Added")
            GetALL()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Delete_Product(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim con As New SqlConnection("Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1")
            Dim cmd As New SqlCommand("DELETE FROM PRODUCTS WHERE PID=@PID", con)
            'Passing values to parameters
            cmd.Parameters.AddWithValue("@PID", txtId.Text)
            con.Open() 'Open connection to the database
            cmd.ExecuteNonQuery()
            con.Close()
            '  MessageBox.Show("Record Added")
            GetALL()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        MessageBox.Show("Hi")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
    End Sub
End Class
