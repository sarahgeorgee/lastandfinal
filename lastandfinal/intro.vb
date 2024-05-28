Imports Microsoft.VisualBasic.Logging
Imports Microsoft.Win32

Public Class intro
    Private Sub btnRegister_Click_1(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        register.Show()

    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Hide()
        login.Show
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Adminlogin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class