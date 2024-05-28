<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adminlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        loginPanel = New Panel()
        lblHeader = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Button1 = New Button()
        loginPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.FromArgb(CByte(30), CByte(50), CByte(80))
        loginPanel.BorderStyle = BorderStyle.FixedSingle
        loginPanel.Controls.Add(lblHeader)
        loginPanel.Controls.Add(lblUsername)
        loginPanel.Controls.Add(txtUsername)
        loginPanel.Controls.Add(lblPassword)
        loginPanel.Controls.Add(txtPassword)
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Location = New Point(175, 100)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(350, 250)
        loginPanel.TabIndex = 0
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Arial", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(100, 10)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(194, 35)
        lblHeader.TabIndex = 7
        lblHeader.Text = "Admin Login"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(44, 70)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(105, 23)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(50), CByte(70), CByte(100))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(155, 72)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(177, 26)
        txtUsername.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(44, 120)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(104, 23)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(50), CByte(70), CByte(100))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(155, 122)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(177, 26)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(131, 177)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(88, 40)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(29, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Adminlogin
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 18.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(30), CByte(50))
        ClientSize = New Size(700, 450)
        Controls.Add(Button1)
        Controls.Add(loginPanel)
        Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Adminlogin"
        Text = "Admin Login"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents loginPanel As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button1 As Button

End Class