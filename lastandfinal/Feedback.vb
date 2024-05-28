Imports System.Data.SqlClient

Public Class Feedback

    Private Sub Feedsumbit_Click(sender As Object, e As EventArgs) Handles Feedsumbit.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chack\source\repos\lastandfinal\lastandfinal\Database1.mdf;Integrated Security=True"
        con.Open()

        If (Feedname.Text = "" Or Feeddesc.Text = "") Then
            MessageBox.Show("Please enter all the details")
        Else
            ' Truncate the input string if it exceeds the column length
            Dim maxLength As Integer = 500 ' Specify the maximum length for the column
            Dim truncatedFeeddesc As String = Feeddesc.Text
            If truncatedFeeddesc.Length > maxLength Then
                truncatedFeeddesc = truncatedFeeddesc.Substring(0, maxLength)
            End If

            cmd = New SqlCommand("INSERT INTO Feedback (Feedname, Feeddesc) VALUES (@Feedname, @Feeddesc)", con)
            cmd.Parameters.AddWithValue("@Feedname", Feedname.Text)
            cmd.Parameters.AddWithValue("@Feeddesc", truncatedFeeddesc) ' Use the truncated string

            cmd.ExecuteNonQuery() ' Execute the query to insert data into the database
            MessageBox.Show("Feedback sent!")
        End If

        con.Close()
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
