<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
    Inherits System.Windows.Forms.Form

    Friend WithEvents pnlOptions As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnAboutUs As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents Button1 As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Welcome))
        pnlOptions = New Panel()
        bking = New Button()
        Button1 = New Button()
        btnFeedback = New Button()
        btnProfile = New Button()
        btnAboutUs = New Button()
        lblWelcome = New Label()
        pnlProfile = New Panel()
        lbltime = New Label()
        lblsystem = New Label()
        lbldate = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblUserName = New Label()
        pnlOptions.SuspendLayout()
        pnlProfile.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlOptions
        ' 
        pnlOptions.BackColor = Color.SteelBlue
        pnlOptions.Controls.Add(bking)
        pnlOptions.Controls.Add(Button1)
        pnlOptions.Controls.Add(btnFeedback)
        pnlOptions.Controls.Add(btnProfile)
        pnlOptions.Controls.Add(btnAboutUs)
        pnlOptions.Controls.Add(lblWelcome)
        pnlOptions.Dock = DockStyle.Left
        pnlOptions.Location = New Point(0, 0)
        pnlOptions.Margin = New Padding(3, 4, 3, 4)
        pnlOptions.Name = "pnlOptions"
        pnlOptions.Size = New Size(175, 776)
        pnlOptions.TabIndex = 0
        ' 
        ' bking
        ' 
        bking.BackColor = Color.MediumVioletRed
        bking.FlatAppearance.BorderSize = 0
        bking.FlatStyle = FlatStyle.Popup
        bking.ForeColor = Color.White
        bking.Location = New Point(12, 497)
        bking.Margin = New Padding(3, 4, 3, 4)
        bking.Name = "bking"
        bking.Size = New Size(141, 72)
        bking.TabIndex = 8
        bking.Text = "booking"
        bking.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumVioletRed
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(14, 691)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 72)
        Button1.TabIndex = 7
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnFeedback
        ' 
        btnFeedback.BackColor = Color.MediumVioletRed
        btnFeedback.FlatAppearance.BorderSize = 0
        btnFeedback.FlatStyle = FlatStyle.Popup
        btnFeedback.ForeColor = Color.White
        btnFeedback.Location = New Point(14, 381)
        btnFeedback.Margin = New Padding(3, 4, 3, 4)
        btnFeedback.Name = "btnFeedback"
        btnFeedback.Size = New Size(141, 72)
        btnFeedback.TabIndex = 6
        btnFeedback.Text = "Feedback"
        btnFeedback.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.MediumVioletRed
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Popup
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(12, 139)
        btnProfile.Margin = New Padding(3, 4, 3, 4)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(141, 69)
        btnProfile.TabIndex = 3
        btnProfile.Text = "View Profile"
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnAboutUs
        ' 
        btnAboutUs.BackColor = Color.MediumVioletRed
        btnAboutUs.FlatAppearance.BorderSize = 0
        btnAboutUs.FlatStyle = FlatStyle.Popup
        btnAboutUs.ForeColor = Color.White
        btnAboutUs.Location = New Point(12, 256)
        btnAboutUs.Margin = New Padding(3, 4, 3, 4)
        btnAboutUs.Name = "btnAboutUs"
        btnAboutUs.Size = New Size(141, 72)
        btnAboutUs.TabIndex = 5
        btnAboutUs.Text = "About Us"
        btnAboutUs.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(3, 46)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(86, 20)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome"
        ' 
        ' pnlProfile
        ' 
        pnlProfile.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        pnlProfile.Controls.Add(lbltime)
        pnlProfile.Controls.Add(lblsystem)
        pnlProfile.Controls.Add(lbldate)
        pnlProfile.Controls.Add(Label2)
        pnlProfile.Controls.Add(Label1)
        pnlProfile.Controls.Add(PictureBox1)
        pnlProfile.Controls.Add(lblUserName)
        pnlProfile.Location = New Point(182, 13)
        pnlProfile.Margin = New Padding(3, 4, 3, 4)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(899, 835)
        pnlProfile.TabIndex = 9
        ' 
        ' lbltime
        ' 
        lbltime.AutoSize = True
        lbltime.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbltime.Location = New Point(42, 422)
        lbltime.Name = "lbltime"
        lbltime.Size = New Size(102, 37)
        lbltime.TabIndex = 11
        lbltime.Text = "Label7"
        ' 
        ' lblsystem
        ' 
        lblsystem.AutoSize = True
        lblsystem.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblsystem.Location = New Point(42, 367)
        lblsystem.Name = "lblsystem"
        lblsystem.Size = New Size(102, 37)
        lblsystem.TabIndex = 10
        lblsystem.Text = "Label7"
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lbldate.Location = New Point(633, 86)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(70, 32)
        lbldate.TabIndex = 4
        lbldate.Text = "Label"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(11, 290)
        Label2.Name = "Label2"
        Label2.Size = New Size(297, 41)
        Label2.TabIndex = 5
        Label2.Text = "YOUR TRAVEL INFO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("HP Simplified Hans", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(0, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 42)
        Label1.TabIndex = 3
        Label1.Text = "Greetings!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(42, 81)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(134, 147)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblUserName.Location = New Point(215, 81)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(93, 37)
        lblUserName.TabIndex = 0
        lblUserName.Text = "Label1"
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1086, 776)
        Controls.Add(pnlOptions)
        Controls.Add(pnlProfile)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(3, 4, 3, 4)
        Name = "Welcome"
        Text = "Dashboard"
        pnlOptions.ResumeLayout(False)
        pnlOptions.PerformLayout()
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

        ' Add more hardware and software details as needed...

    End Sub
    Friend WithEvents About1 As About
    Friend WithEvents Feedback1 As Feedback
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents lblUserName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents lblsystem As Label
    Friend WithEvents bking As Button
End Class
