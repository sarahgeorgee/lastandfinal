<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintForm
    Inherits System.Windows.Forms.Form

    ' Labels to display booking details
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTravelMode As Label

    ' Button to print the ticket
    Friend WithEvents pntTicket As Button

    ' Label to display price
    Friend WithEvents lblprice As Label

    ' Form initialization
    Private Sub InitializeComponent()
        lblName = New Label()
        lblEmail = New Label()
        lblAge = New Label()
        lblDOB = New Label()
        lblFrom = New Label()
        lblTo = New Label()
        lblDate = New Label()
        lblTravelMode = New Label()
        pntTicket = New Button()
        lblprice = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Tickettype = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblName.Location = New Point(9, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(80, 32)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblEmail.Location = New Point(8, 63)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(75, 32)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblAge.Location = New Point(8, 137)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(56, 32)
        lblAge.TabIndex = 2
        lblAge.Text = "Age"
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblDOB.Location = New Point(9, 219)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(65, 32)
        lblDOB.TabIndex = 3
        lblDOB.Text = "DOB"
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblFrom.Location = New Point(8, 15)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(88, 41)
        lblFrom.TabIndex = 4
        lblFrom.Text = "From"
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTo.Location = New Point(8, 73)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(52, 41)
        lblTo.TabIndex = 5
        lblTo.Text = "To"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblDate.Location = New Point(270, 94)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(94, 32)
        lblDate.TabIndex = 6
        lblDate.Text = "lblDate"
        ' 
        ' lblTravelMode
        ' 
        lblTravelMode.AutoSize = True
        lblTravelMode.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblTravelMode.Location = New Point(246, 22)
        lblTravelMode.Name = "lblTravelMode"
        lblTravelMode.Size = New Size(168, 32)
        lblTravelMode.TabIndex = 7
        lblTravelMode.Text = "lblTravelMode"
        ' 
        ' pntTicket
        ' 
        pntTicket.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        pntTicket.Location = New Point(479, 700)
        pntTicket.Margin = New Padding(3, 4, 3, 4)
        pntTicket.Name = "pntTicket"
        pntTicket.Size = New Size(111, 57)
        pntTicket.TabIndex = 8
        pntTicket.Text = "Print Ticket"
        pntTicket.UseVisualStyleBackColor = True
        ' 
        ' lblprice
        ' 
        lblprice.AutoSize = True
        lblprice.BackColor = Color.Transparent
        lblprice.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblprice.Location = New Point(22, 715)
        lblprice.Name = "lblprice"
        lblprice.Size = New Size(118, 41)
        lblprice.TabIndex = 9
        lblprice.Text = "lblprice"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(lblAge)
        Panel1.Controls.Add(lblTravelMode)
        Panel1.Controls.Add(lblDOB)
        Panel1.Controls.Add(lblDate)
        Panel1.Location = New Point(14, 64)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(576, 293)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel2.Controls.Add(lblFrom)
        Panel2.Controls.Add(lblTo)
        Panel2.Location = New Point(14, 379)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(576, 123)
        Panel2.TabIndex = 11
        ' 
        ' Tickettype
        ' 
        Tickettype.AutoSize = True
        Tickettype.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Tickettype.Location = New Point(241, 12)
        Tickettype.Name = "Tickettype"
        Tickettype.Size = New Size(98, 41)
        Tickettype.TabIndex = 12
        Tickettype.Text = "Ticket"
        ' 
        ' PrintForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(623, 820)
        Controls.Add(Tickettype)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblprice)
        Controls.Add(pntTicket)
        Margin = New Padding(3, 4, 3, 4)
        Name = "PrintForm"
        Text = "Ticket"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tickettype As Label
End Class