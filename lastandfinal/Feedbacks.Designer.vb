<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Feedbacks
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        lblFeedName = New Label()
        lblFeedDesc = New Label()
        change = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 32)
        Label1.TabIndex = 0
        Label1.Text = "Feedbacks"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.OldLace
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(lblFeedDesc)
        Panel1.Location = New Point(49, 111)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(624, 320)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGray
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(lblFeedName)
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(624, 65)
        Panel2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(439, 359)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 2
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblFeedName
        ' 
        lblFeedName.AutoSize = True
        lblFeedName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblFeedName.Location = New Point(0, 0)
        lblFeedName.Name = "lblFeedName"
        lblFeedName.Size = New Size(102, 37)
        lblFeedName.TabIndex = 0
        lblFeedName.Text = "Label2"
        ' 
        ' lblFeedDesc
        ' 
        lblFeedDesc.AutoSize = True
        lblFeedDesc.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblFeedDesc.Location = New Point(10, 69)
        lblFeedDesc.Name = "lblFeedDesc"
        lblFeedDesc.Size = New Size(85, 32)
        lblFeedDesc.TabIndex = 1
        lblFeedDesc.Text = "Label2"
        ' 
        ' change
        ' 
        change.BackColor = Color.DarkCyan
        change.Location = New Point(535, 473)
        change.Margin = New Padding(3, 4, 3, 4)
        change.Name = "change"
        change.Size = New Size(104, 63)
        change.TabIndex = 2
        change.Text = "Next"
        change.UseVisualStyleBackColor = False
        ' 
        ' Feedbacks
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        Controls.Add(Panel1)
        Controls.Add(change)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Feedbacks"
        Size = New Size(727, 603)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFeedName As Label
    Friend WithEvents change As Button
    Friend WithEvents lblFeedDesc As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
End Class
