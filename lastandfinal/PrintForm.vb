
Imports System.Drawing.Printing

Public Class PrintForm
    Private ReadOnly travelMode As String
    Private ReadOnly age As Integer
    Private printDoc As New PrintDocument()

    Public Sub New(ByVal name As String, ByVal email As String, ByVal age As String, ByVal dob As Date, ByVal fromLocation As String, ByVal toLocation As String, ByVal travelDate As Date, ByVal travelMode As String)
        InitializeComponent()

        lblName.Text = "Name: " & name
        lblEmail.Text = "Email: " & email
        lblAge.Text = "Age: " & age
        lblDOB.Text = "Date of Birth: " & dob.ToShortDateString()
        lblFrom.Text = "From: " & fromLocation
        lblTo.Text = "To: " & toLocation
        lblDate.Text = "Travel Date: " & travelDate.ToShortDateString()
        lblTravelMode.Text = "Travel Mode: " & travelMode

        Me.travelMode = travelMode
        Me.age = If(Integer.TryParse(age, Nothing), Convert.ToInt32(age), 0)

        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub PrintTicketButton_Click(sender As Object, e As EventArgs) Handles pntTicket.Click
        Dim printDlg As New PrintDialog()
        printDlg.Document = printDoc

        If printDlg.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    Private Function CalculatePrice() As Decimal
        Dim basePrice As Decimal = 0

        Select Case travelMode
            Case "Bus"
                basePrice = 100
            Case "Train"
                basePrice = 150
            Case "Airplane"
                basePrice = 500
        End Select

        Select Case travelMode
            Case "Bus"
            Case "Train"
                If age < 5 Then
                    basePrice /= 2
                End If
            Case "Airplane"
        End Select

        Return basePrice
    End Function

    Private Sub PrintForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tickettype_Click(sender As Object, e As EventArgs) Handles Tickettype.Click


    End Sub

    Private Sub lblprice_Click(sender As Object, e As EventArgs) Handles lblprice.Click

    End Sub
End Class