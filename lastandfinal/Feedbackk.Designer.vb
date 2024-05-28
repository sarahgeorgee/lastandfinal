<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedbackk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Feedback1 = New Feedback()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Feedback1
        ' 
        Feedback1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Feedback1.Location = New Point(-1, -1)
        Feedback1.Margin = New Padding(3, 4, 3, 4)
        Feedback1.Name = "Feedback1"
        Feedback1.Size = New Size(1164, 731)
        Feedback1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(571, 638)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Feedbackk
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1163, 733)
        Controls.Add(Button1)
        Controls.Add(Feedback1)
        Name = "Feedbackk"
        Text = "Feedbackk"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Feedback1 As Feedback
    Friend WithEvents Button1 As Button
End Class
