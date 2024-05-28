Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Booking
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ' Save user data to the database
        If ValidateAndSaveBooking() Then
            ' Show the details in a new form for printing
            Dim printForm As New PrintForm(txtName.Text, txtEmail.Text, txtAge.Text, dtpDOB.Value, cmbFrom.SelectedItem.ToString(), cmbTo.SelectedItem.ToString(), dtpDate.Value, cmbTravelMode.SelectedItem.ToString())
            printForm.ShowDialog()
        End If
    End Sub

    Private Function ValidateAndSaveBooking() As Boolean
        If String.IsNullOrEmpty(txtName.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) OrElse String.IsNullOrEmpty(txtAge.Text) OrElse cmbFrom.SelectedItem Is Nothing OrElse cmbTo.SelectedItem Is Nothing OrElse cmbTravelMode.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all required fields.")
            Return False
        End If

        If Not Regex.IsMatch(txtName.Text, "^[a-zA-Z\s]+$") Then
            MessageBox.Show("Please enter a valid name containing only alphabetic characters.")
            Return False
        End If

        If Not IsNumeric(txtAge.Text) Then
            MessageBox.Show("Please enter a valid numeric value for age.")
            Return False
        End If

        If Not IsValidEmail(txtEmail.Text) Then
            MessageBox.Show("Please enter a valid email address.")
            Return False
        End If

        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chack\source\repos\lastandfinal\lastandfinal\Database1.mdf;Integrated Security=True"

        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO Ticket (Name, Email, Age, DOB, [From], [To], [Date], TravelMode) VALUES (@Name, @Email, @Age, @DOB, @From, @To, @Date, @TravelMode)"
                    cmd.Parameters.AddWithValue("@Name", txtName.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text)
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value)
                    cmd.Parameters.AddWithValue("@From", cmbFrom.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@To", cmbTo.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value)
                    cmd.Parameters.AddWithValue("@TravelMode", cmbTravelMode.SelectedItem.ToString())

                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Booking saved successfully.")
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while saving booking: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
