﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feed
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
        Button1 = New Button()
        Feedbacks1 = New Feedbacks()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(512, 640)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Feedbacks1
        ' 
        Feedbacks1.BackColor = SystemColors.InactiveCaption
        Feedbacks1.Location = New Point(0, 1)
        Feedbacks1.Margin = New Padding(3, 4, 3, 4)
        Feedbacks1.Name = "Feedbacks1"
        Feedbacks1.Size = New Size(954, 678)
        Feedbacks1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(418, 479)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 59)
        Button2.TabIndex = 3
        Button2.Text = "back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Feed
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(951, 681)
        Controls.Add(Button2)
        Controls.Add(Feedbacks1)
        Controls.Add(Button1)
        Name = "Feed"
        Text = "Feed"
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Feedbacks1 As Feedbacks
    Friend WithEvents Button2 As Button
End Class
