<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admindashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admindashboard))
        Panel1 = New Panel()
        Button1 = New Button()
        btnFeedbacks = New Button()
        btnStudents = New Button()
        Students2 = New Students()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnFeedbacks)
        Panel1.Controls.Add(btnStudents)
        Panel1.Location = New Point(-2, -1)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(191, 603)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(16, 473)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 69)
        Button1.TabIndex = 5
        Button1.Text = "Logout"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnFeedbacks
        ' 
        btnFeedbacks.BackColor = Color.DimGray
        btnFeedbacks.FlatAppearance.BorderSize = 0
        btnFeedbacks.FlatStyle = FlatStyle.Popup
        btnFeedbacks.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnFeedbacks.ForeColor = Color.White
        btnFeedbacks.Location = New Point(16, 179)
        btnFeedbacks.Margin = New Padding(3, 4, 3, 4)
        btnFeedbacks.Name = "btnFeedbacks"
        btnFeedbacks.Size = New Size(158, 69)
        btnFeedbacks.TabIndex = 4
        btnFeedbacks.Text = "Feedbacks"
        btnFeedbacks.UseVisualStyleBackColor = False
        ' 
        ' btnStudents
        ' 
        btnStudents.BackColor = Color.DimGray
        btnStudents.FlatAppearance.BorderSize = 0
        btnStudents.FlatStyle = FlatStyle.Popup
        btnStudents.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnStudents.ForeColor = Color.White
        btnStudents.Location = New Point(16, 81)
        btnStudents.Margin = New Padding(3, 4, 3, 4)
        btnStudents.Name = "btnStudents"
        btnStudents.Size = New Size(158, 69)
        btnStudents.TabIndex = 3
        btnStudents.Text = "customer"
        btnStudents.UseVisualStyleBackColor = False
        ' 
        ' Students2
        ' 
        Students2.BackColor = SystemColors.ButtonShadow
        Students2.Location = New Point(178, -1)
        Students2.Margin = New Padding(3, 4, 3, 4)
        Students2.Name = "Students2"
        Students2.Size = New Size(712, 754)
        Students2.TabIndex = 1
        ' 
        ' Admindashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(844, 575)
        Controls.Add(Students2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Admindashboard"
        Text = "Admindashboard"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnFeedbacks As Button
    Friend WithEvents Students1 As Students
    Friend WithEvents Feedbacks1 As Feedbacks
    Friend WithEvents Button1 As Button
    Friend WithEvents Students2 As Students
End Class
