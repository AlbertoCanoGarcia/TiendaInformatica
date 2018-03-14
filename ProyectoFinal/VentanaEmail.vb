Imports System.Net.Mail

Public Class VentanaEmail
    Dim ruta As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EnvioMail()
    End Sub
    Public Sub EnvioMail()

        Dim Mail As New MailMessage
            Dim SMTP As New SmtpClient("smtp.gmail.com")

            Mail.Subject = "Canomatic S.A"
            Mail.From = New MailAddress("beto10cano@gmail.com")
            SMTP.Credentials = New Net.NetworkCredential("beto10cano@gmail.com", "guasiguasi") '<-- Password Here

        Mail.To.Add(TextBox1.Text) 'I used ByVal here for address
        Dim archivoAdjunto As New System.Net.Mail.Attachment(ruta)
        Mail.Attachments.Add(archivoAdjunto)
            Mail.Body = textoMensaje.Text

            SMTP.EnableSsl = True
            SMTP.Port = "587"

            SMTP.Send(Mail)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ruta = OpenFileDialog1.FileName.ToString

        End If
    End Sub
End Class