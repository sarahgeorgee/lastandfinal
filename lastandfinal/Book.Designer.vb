<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
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
        Booking1 = New Booking()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Booking1
        ' 
        Booking1.Location = New Point(198, 22)
        Booking1.Margin = New Padding(3, 4, 3, 4)
        Booking1.Name = "Booking1"
        Booking1.Size = New Size(636, 707)
        Booking1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(641, 683)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Book
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1022, 724)
        Controls.Add(Button1)
        Controls.Add(Booking1)
        Name = "Book"
        Text = "Book"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Booking1 As Booking
    Friend WithEvents Button1 As Button
End Class
