' In Welcome.Designer.vb

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class intro
    Inherits System.Windows.Forms.Form

    'Designer code here

    ' Add your controls and their properties here
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(intro))
        mainPanel = New Panel()
        btnLogin = New Button()
        btnRegister = New Button()
        lblText = New Label()
        Button1 = New Button()
        Button2 = New Button()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.Transparent
        mainPanel.Controls.Add(btnLogin)
        mainPanel.Controls.Add(btnRegister)
        mainPanel.Controls.Add(lblText)
        mainPanel.Location = New Point(4, 129)
        mainPanel.Margin = New Padding(3, 4, 3, 4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(879, 352)
        mainPanel.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(175, 267)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(101, 40)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(393, 267)
        btnRegister.Margin = New Padding(3, 4, 3, 4)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(101, 40)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblText
        ' 
        lblText.AutoSize = True
        lblText.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblText.ForeColor = SystemColors.ActiveCaptionText
        lblText.Location = New Point(7, 99)
        lblText.Name = "lblText"
        lblText.Size = New Size(872, 47)
        lblText.TabIndex = 2
        lblText.Text = "welcome to Holiday tours and TRAVELS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(736, 28)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 45)
        Button1.TabIndex = 2
        Button1.Text = "Admin Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(593, 508)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 40)
        Button2.TabIndex = 3
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' intro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(892, 600)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(mainPanel)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "intro"
        Text = "Welcome"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    ' Event handler for login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        ' Add your login logic here
        MessageBox.Show("Login button clicked")
    End Sub

    ' Event handler for registration button click
    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        ' Add your registration logic here
        MessageBox.Show("Register button clicked")
    End Sub
    Friend WithEvents mainPanel As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
