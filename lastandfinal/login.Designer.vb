<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(login))
        loginPanel = New Panel()
        Label1 = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lnkRegister = New LinkLabel()
        Button1 = New Button()
        Button2 = New Button()
        loginPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' loginPanel
        ' 
        loginPanel.BackColor = Color.Transparent
        loginPanel.BorderStyle = BorderStyle.FixedSingle
        loginPanel.Controls.Add(Label1)
        loginPanel.Controls.Add(lblUsername)
        loginPanel.Controls.Add(txtUsername)
        loginPanel.Controls.Add(lblPassword)
        loginPanel.Controls.Add(txtPassword)
        loginPanel.Controls.Add(btnLogin)
        loginPanel.Controls.Add(lnkRegister)
        loginPanel.Location = New Point(200, 101)
        loginPanel.Margin = New Padding(3, 4, 3, 4)
        loginPanel.Name = "loginPanel"
        loginPanel.Size = New Size(400, 365)
        loginPanel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(60, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 41)
        Label1.TabIndex = 7
        Label1.Text = "CUSTOMER LOGIN"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(23, 73)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(105, 23)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(139, 73)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(202, 27)
        txtUsername.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(23, 133)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(104, 23)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(139, 135)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(202, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(150, 205)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(101, 53)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lnkRegister
        ' 
        lnkRegister.AutoSize = True
        lnkRegister.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lnkRegister.LinkColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        lnkRegister.Location = New Point(85, 271)
        lnkRegister.Name = "lnkRegister"
        lnkRegister.Size = New Size(283, 19)
        lnkRegister.TabIndex = 6
        lnkRegister.TabStop = True
        lnkRegister.Text = "Don't have an account? Register here"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(42, 37)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 1
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(657, 37)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 31)
        Button2.TabIndex = 2
        Button2.Text = "Admin Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 600)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(loginPanel)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "login"
        Text = "Login"
        loginPanel.ResumeLayout(False)
        loginPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents loginPanel As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnkRegister As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button


End Class
