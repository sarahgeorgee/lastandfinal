Public Class Admindashboard


    Private Sub btnFeedbacks_Click(sender As Object, e As EventArgs) Handles btnFeedbacks.Click
        Me.Hide()
        Feed.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Students2.Show()
        Students2.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        intro.Show()
    End Sub

    Private Sub Admindashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class