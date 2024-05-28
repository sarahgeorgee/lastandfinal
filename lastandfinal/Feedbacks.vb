Imports System.Data.SqlClient

Public Class Feedbacks
    Dim currentIndex As Integer = 0 ' To keep track of the current feedback index
    Dim feedbackData As New List(Of FeedbackEntry)() ' List to store feedback data

    Private Sub Feedbacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load feedback data from the database
        LoadFeedbackData()
        ' Display the first feedback entry
        DisplayFeedback(currentIndex)
    End Sub

    Private Sub LoadFeedbackData()
        ' Query to fetch feedback data from the database
        Dim query As String = "SELECT Feedname, Feeddesc FROM Feedback"

        ' Database connection string
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chack\source\repos\lastandfinal\lastandfinal\Database1.mdf;Integrated Security=True"

        ' Open connection and execute the query
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' Read feedback data and add it to the list
                While reader.Read()
                    Dim feedName As String = reader("Feedname").ToString()
                    Dim feedDesc As String = reader("Feeddesc").ToString()
                    feedbackData.Add(New FeedbackEntry(feedName, feedDesc))
                End While
            End Using
        End Using
    End Sub

    Private Sub DisplayFeedback(index As Integer)
        ' Check if index is within bounds
        If index >= 0 AndAlso index < feedbackData.Count Then
            ' Update labels with feedback data at the specified index
            lblFeedName.Text = feedbackData(index).FeedName
            lblFeedDesc.Text = feedbackData(index).FeedDesc
        Else
            ' If index is out of bounds, display a message or handle it as needed
            MessageBox.Show("No more feedback available.")
        End If
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        ' Increment the current index to move to the next feedback
        currentIndex += 1
        ' Display the feedback at the new index
        DisplayFeedback(currentIndex)
    End Sub
End Class

Public Class FeedbackEntry
    Public Property FeedName As String
    Public Property FeedDesc As String

    Public Sub New(ByVal feedName As String, ByVal feedDesc As String)
        Me.FeedName = feedName
        Me.FeedDesc = feedDesc
    End Sub
End Class