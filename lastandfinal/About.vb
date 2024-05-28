Imports lastandfinal.login

Public Class About

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim welcomeForm As New Welcome()
        Welcome.Show()
        Me.Close()

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


