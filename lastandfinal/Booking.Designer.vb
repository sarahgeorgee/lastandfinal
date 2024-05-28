<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Booking
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
        lblTitle = New Label()
        lblName = New Label()
        txtName = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblAge = New Label()
        txtAge = New TextBox()
        lblDOB = New Label()
        dtpDOB = New DateTimePicker()
        lblFrom = New Label()
        cmbFrom = New ComboBox()
        lblTo = New Label()
        cmbTo = New ComboBox()
        lblDate = New Label()
        dtpDate = New DateTimePicker()
        lblTravelMode = New Label()
        cmbTravelMode = New ComboBox()
        btnBook = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.Blue
        lblTitle.Location = New Point(171, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(342, 46)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Book Your Trip Here"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblName.Location = New Point(57, 133)
        lblName.Name = "lblName"
        lblName.Size = New Size(68, 28)
        lblName.TabIndex = 1
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(229, 133)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(285, 34)
        txtName.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmail.Location = New Point(57, 200)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(63, 28)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(229, 200)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(285, 34)
        txtEmail.TabIndex = 4
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblAge.Location = New Point(57, 267)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(51, 28)
        lblAge.TabIndex = 5
        lblAge.Text = "Age:"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtAge.Location = New Point(229, 267)
        txtAge.Margin = New Padding(3, 4, 3, 4)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(57, 34)
        txtAge.TabIndex = 6
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDOB.Location = New Point(57, 333)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(126, 28)
        lblDOB.TabIndex = 7
        lblDOB.Text = "Date of Birth:"
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpDOB.Location = New Point(229, 333)
        dtpDOB.Margin = New Padding(3, 4, 3, 4)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(285, 34)
        dtpDOB.TabIndex = 8
        ' 
        ' lblFrom
        ' 
        lblFrom.AutoSize = True
        lblFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblFrom.Location = New Point(57, 400)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(62, 28)
        lblFrom.TabIndex = 9
        lblFrom.Text = "From:"
        ' 
        ' cmbFrom
        ' 
        cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFrom.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbFrom.FormattingEnabled = True
        cmbFrom.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Andaman and Nicobar Islands", "Chandigarh", "Dadra and Nagar Haveli and Daman and Diu", "Lakshadweep", "Delhi", "Puducherry"})
        cmbFrom.Location = New Point(229, 400)
        cmbFrom.Margin = New Padding(3, 4, 3, 4)
        cmbFrom.Name = "cmbFrom"
        cmbFrom.Size = New Size(285, 36)
        cmbFrom.TabIndex = 10
        ' 
        ' lblTo
        ' 
        lblTo.AutoSize = True
        lblTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTo.Location = New Point(57, 467)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(36, 28)
        lblTo.TabIndex = 11
        lblTo.Text = "To:"
        ' 
        ' cmbTo
        ' 
        cmbTo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbTo.FormattingEnabled = True
        cmbTo.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Andaman and Nicobar Islands", "Chandigarh", "Dadra and Nagar Haveli and Daman and Diu", "Lakshadweep", "Delhi", "Puducherry"})
        cmbTo.Location = New Point(229, 467)
        cmbTo.Margin = New Padding(3, 4, 3, 4)
        cmbTo.Name = "cmbTo"
        cmbTo.Size = New Size(285, 36)
        cmbTo.TabIndex = 12
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDate.Location = New Point(57, 533)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(57, 28)
        lblDate.TabIndex = 13
        lblDate.Text = "Date:"
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dtpDate.Location = New Point(229, 533)
        dtpDate.Margin = New Padding(3, 4, 3, 4)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(285, 34)
        dtpDate.TabIndex = 14
        ' 
        ' lblTravelMode
        ' 
        lblTravelMode.AutoSize = True
        lblTravelMode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblTravelMode.Location = New Point(57, 600)
        lblTravelMode.Name = "lblTravelMode"
        lblTravelMode.Size = New Size(123, 28)
        lblTravelMode.TabIndex = 15
        lblTravelMode.Text = "Travel Mode:"
        ' 
        ' cmbTravelMode
        ' 
        cmbTravelMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTravelMode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbTravelMode.FormattingEnabled = True
        cmbTravelMode.Items.AddRange(New Object() {"Bus", "Train", "Airplane"})
        cmbTravelMode.Location = New Point(229, 600)
        cmbTravelMode.Margin = New Padding(3, 4, 3, 4)
        cmbTravelMode.Name = "cmbTravelMode"
        cmbTravelMode.Size = New Size(171, 36)
        cmbTravelMode.TabIndex = 16
        ' 
        ' btnBook
        ' 
        btnBook.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnBook.FlatStyle = FlatStyle.Flat
        btnBook.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBook.ForeColor = Color.White
        btnBook.Location = New Point(229, 667)
        btnBook.Margin = New Padding(3, 4, 3, 4)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(114, 53)
        btnBook.TabIndex = 17
        btnBook.Text = "Book Now"
        btnBook.UseVisualStyleBackColor = False
        ' 
        ' Booking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnBook)
        Controls.Add(cmbTravelMode)
        Controls.Add(lblTravelMode)
        Controls.Add(dtpDate)
        Controls.Add(lblDate)
        Controls.Add(cmbTo)
        Controls.Add(lblTo)
        Controls.Add(cmbFrom)
        Controls.Add(lblFrom)
        Controls.Add(dtpDOB)
        Controls.Add(lblDOB)
        Controls.Add(txtAge)
        Controls.Add(lblAge)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(lblTitle)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Booking"
        Size = New Size(899, 835)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblDOB As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents cmbFrom As ComboBox
    Friend WithEvents lblTo As Label
    Friend WithEvents cmbTo As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblTravelMode As Label
    Friend WithEvents cmbTravelMode As ComboBox
    Friend WithEvents btnBook As Button
End Class