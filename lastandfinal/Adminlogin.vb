
Imports System.Data.SqlClient

Public Class Adminlogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chack\source\repos\lastandfinal\lastandfinal\Database1.mdf;Integrated Security=True"
        con.Open()

        If (txtUsername.Text = "" Or txtPassword.Text = "") Then
            MessageBox.Show("Please enter both username/email and password")
            Return
        End If

        cmd = New SqlCommand("SELECT * FROM Admins WHERE (txtName = @Username) AND txtPassword = @Password", con)
        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

        dr = cmd.ExecuteReader()
        MsgBox("login succsus")
        Admindashboard.Show()

        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        intro.Show()
    End Sub
End Class