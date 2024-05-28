<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Students
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        studentname = New TextBox()
        Panel1 = New Panel()
        lblAddress = New Label()
        lblNumber = New Label()
        lblEmail = New Label()
        lblname = New Label()
        search = New Button()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' studentname
        ' 
        studentname.Location = New Point(66, 83)
        studentname.Margin = New Padding(3, 4, 3, 4)
        studentname.Name = "studentname"
        studentname.Size = New Size(145, 27)
        studentname.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblNumber)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblname)
        Panel1.Location = New Point(63, 120)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(247, 376)
        Panel1.TabIndex = 1
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAddress.Location = New Point(80, 249)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(74, 28)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Label4"
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumber.Location = New Point(80, 183)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(74, 28)
        lblNumber.TabIndex = 2
        lblNumber.Text = "Label3"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(80, 108)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(74, 28)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Label2"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblname.Location = New Point(80, 43)
        lblname.Name = "lblname"
        lblname.Size = New Size(74, 28)
        lblname.TabIndex = 0
        lblname.Text = "Label1"
        ' 
        ' search
        ' 
        search.Location = New Point(221, 81)
        search.Margin = New Padding(3, 4, 3, 4)
        search.Name = "search"
        search.Size = New Size(86, 31)
        search.TabIndex = 2
        search.Text = "Search"
        search.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(15, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(305, 41)
        Label5.TabIndex = 3
        Label5.Text = "SEARCH CUSTOMER"
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        Controls.Add(Label5)
        Controls.Add(search)
        Controls.Add(Panel1)
        Controls.Add(studentname)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Students"
        Size = New Size(570, 603)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents studentname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblname As Label
    Friend WithEvents search As Button
    Friend WithEvents Label5 As Label

End Class
