<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Feedback
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Feedname = New TextBox()
        Feeddesc = New RichTextBox()
        Feedsumbit = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 41)
        Label1.TabIndex = 0
        Label1.Text = "FeedBack"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(26, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 37)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(26, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(172, 37)
        Label3.TabIndex = 2
        Label3.Text = "Description:"
        ' 
        ' Feedname
        ' 
        Feedname.Location = New Point(47, 148)
        Feedname.Margin = New Padding(3, 4, 3, 4)
        Feedname.Name = "Feedname"
        Feedname.Size = New Size(182, 27)
        Feedname.TabIndex = 3
        ' 
        ' Feeddesc
        ' 
        Feeddesc.Location = New Point(47, 247)
        Feeddesc.Margin = New Padding(3, 4, 3, 4)
        Feeddesc.Name = "Feeddesc"
        Feeddesc.Size = New Size(825, 344)
        Feeddesc.TabIndex = 4
        Feeddesc.Text = ""
        ' 
        ' Feedsumbit
        ' 
        Feedsumbit.Location = New Point(710, 637)
        Feedsumbit.Margin = New Padding(3, 4, 3, 4)
        Feedsumbit.Name = "Feedsumbit"
        Feedsumbit.Size = New Size(86, 31)
        Feedsumbit.TabIndex = 5
        Feedsumbit.Text = "Sumbit"
        Feedsumbit.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 4)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(903, 61)
        Panel1.TabIndex = 6
        ' 
        ' Feedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Controls.Add(Panel1)
        Controls.Add(Feedsumbit)
        Controls.Add(Feeddesc)
        Controls.Add(Feedname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Feedback"
        Size = New Size(914, 848)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Feedname As TextBox
    Friend WithEvents Feeddesc As RichTextBox
    Friend WithEvents Feedsumbit As Button
    Friend WithEvents Panel1 As Panel

End Class
