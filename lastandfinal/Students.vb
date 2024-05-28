Imports System.Data.SqlClient

Public Class Students
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chack\source\repos\lastandfinal\lastandfinal\Database1.mdf;Integrated Security=True"

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Dim searchText As String = studentname.Text
        Dim query As String = "SELECT txtName, txtAddress, txtNumber, txtEmail FROM students WHERE txtName LIKE '%' + @SearchText + '%'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@SearchText", searchText)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            lblname.Text = reader("txtName").ToString()
                            lblAddress.Text = reader("txtAddress").ToString()
                            lblEmail.Text = reader("txtEmail").ToString()
                            lblNumber.Text = reader("txtNumber").ToString()
                        Else
                            MessageBox.Show("customer not found.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
