Imports lastandfinal.login

Public Class Welcome
    Private userInfo As UserInfo

    Public Sub New(ByVal userInfo As UserInfo)
        InitializeComponent()
        Me.userInfo = userInfo
        DisplayUserInfo()
        DisplayCurrentDateAndTime()
    End Sub

    Private Sub DisplayUserInfo()
        lblWelcome.Text = "Welcome, " & userInfo.UserName
        lblUserName.Text = userInfo.UserName
        lblsystem.Text = "traveller: " & userInfo.UserName
    End Sub

    Private Sub DisplayCurrentDateAndTime()
        Dim currentDate As DateTime = DateTime.Now
        lbldate.Text = "Date: " & currentDate.ToShortDateString()
        lbltime.Text = "Time: " & currentDate.ToString("HH:mm:ss")
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        pnlProfile.Show()
        pnlProfile.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub bking_Click(sender As Object, e As EventArgs) Handles bking.Click
        Me.Hide()
        Book.Show()
    End Sub

    Private Sub pnlProfile_Paint(sender As Object, e As PaintEventArgs) Handles pnlProfile.Paint
        ' Add any custom painting code here, if needed
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        Me.Hide()
        Feedbackk.Show()
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        Me.Hide()
        About.Show()
    End Sub
End Class