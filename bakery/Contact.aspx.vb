Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Threading
Imports System.ComponentModel
Imports System.Web.Configuration
Imports System.Web
Imports System.IO
Public Class Contact
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Async Sub btnSendFeedback_Click(sender As Object, e As EventArgs)
        If Page.IsValid Then
            If tbToChefMessage.Text.Trim().Length > 0 Then

                Dim client As New SmtpClient

                client.Port = Constants.SmtpClientPort
                client.Host = Constants.SmtpClientHost
                client.Credentials = New NetworkCredential With {.UserName = Constants.SmtpClientUsername, .Password = Constants.SmtpClientPassword}
                client.EnableSsl = Constants.SmtpClientEnableSSL
                ' Specify the e-mail sender.
                Dim mailFrom As New MailAddress(Constants.MailAddressFromAddress, Constants.MailAddressDisplayName, System.Text.Encoding.UTF8)
                ' Set destinations for the email message.
                Dim mailTo As New MailAddress(Constants.MailAddressFromAddress)
                ' Specify the message content.
                Dim message As New MailMessage(mailFrom, mailTo)
                'message.Body = "This is a test email message sent by 2Wrights'Delights last time."
                message.Body = "<h2>2Wrights'Delights feedback from Contacts page:</h2><hr />"
                ' Include some non-ASCII characters in body and subject.
                'Dim someArrows As New String(New Char() {ChrW(&H2190), ChrW(&H2191), ChrW(&H2192), ChrW(&H2193), ChrW(32768), ChrW(8594)})
                'message.Body += Environment.NewLine & someArrows
                message.Body += "<h3>Feedback details:</h3>"
                message.Body += "<strong>" + "Full name: </strong>" + Server.HtmlEncode(tbToChefFullName.Text.Trim())
                message.Body += "<br />" + "<strong>" + "Email address of the person who left this feedback: </strong>" + Server.HtmlEncode(tbToChefCustomerEmail.Text.Trim())
                message.Body += "<br /><strong>" + "Subject: </strong>" + Server.HtmlEncode(tbToChefSubject.Text.Trim())
                message.Body += "<br /><strong>" + "Message: </strong>" + Server.HtmlEncode(tbToChefMessage.Text.Trim())




                'message.Body += "<p>*GMT time is 5 hours ahead of Central Daylight Time and 6 hours ahead of Central Standard Time</p>"

                message.BodyEncoding = System.Text.Encoding.UTF8
                message.Subject = "A new feedback from Contacts page of 2Wrights'Delights web site has been submitted on " + DateTime.UtcNow.ToShortDateString + " at " + DateTime.UtcNow.ToShortTimeString + " GMT"
                message.SubjectEncoding = System.Text.Encoding.UTF8
                message.IsBodyHtml = True

                ' Set the method that is called back when the send operation ends.
                '  AddHandler client.SendCompleted, AddressOf SendCompletedCallback
                ' The userState can be any object that allows your callback 
                ' method to identify this send operation.
                ' For this example, the userToken is a string constant.
                '  Dim userState As String = "test message1"
                'client.SendAsync(message, userState)
                Try
                    '  client.Send(mailFrom.Address, mailTo.Address, message.Subject, message.Body)
                    client.Send(message)

                    Dim uniencoding As UnicodeEncoding = New UnicodeEncoding()
                    Dim filename As String = Server.MapPath("~\\App_Data\\Feedback\\" + "feedback" + Server.UrlEncode(DateTime.UtcNow) + ".txt")

                    Dim result As Byte() = uniencoding.GetBytes(DateTime.UtcNow + Environment.NewLine + message.Body)

                    Using SourceStream As FileStream = File.Open(filename, FileMode.OpenOrCreate)
                        SourceStream.Seek(0, SeekOrigin.End)
                        Await SourceStream.WriteAsync(result, 0, result.Length)
                    End Using

                    ' Clean up.
                    message.Dispose()
                    Response.Redirect("~/FeedbackSubmitted.aspx", False)
                Catch ex As Exception
                    Response.Redirect("~/ErrorFeedback.html")
                End Try
            End If

        End If
    End Sub
End Class