Imports System
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Threading
Imports System.ComponentModel
Imports System.Web.Configuration
Imports System.Web
Imports System.IO

Public Class PlaceOrder
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        If Session("TotalPrice") IsNot Nothing Then
            lblTotalCost.Visible = True
            lblTotalCost.Text = "Total price: $" + Session("TotalPrice").ToString()
        Else
            lblTotalCost.Visible = False
        End If

    End Sub

    Protected Sub btnChangeOrder_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/Order.aspx")
    End Sub

    'Private mailSent As Boolean = False

    'Private Sub SendCompletedCallback(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
    '    ' Get the unique identifier for this asynchronous operation.
    '    Dim token As String = CStr(e.UserState)

    '    If e.Cancelled Then
    '        Console.WriteLine("[{0}] Send canceled.", token)
    '    End If
    '    If e.Error IsNot Nothing Then
    '        'Console.WriteLine("[{0}] {1}", token, e.Error.ToString())
    '        Response.Redirect("~/ErrorEmailOrder.html")
    '    Else
    '        'Console.WriteLine("Message sent.")
    '        Response.Redirect("~/OrderSubmitted.aspx")
    '    End If
    '    mailSent = True
    'End Sub
    Protected Async Sub btnSubmitOrder_Click(sender As Object, e As EventArgs)
        If Page.IsValid Then
            Dim client As New SmtpClient

            client.Port = Constants.SmtpClientPort
            client.Host = Constants.SmtpClientHost
            client.Credentials = New NetworkCredential With {.UserName = Constants.SmtpClientUsername, .Password = Constants.SmtpClientPassword}
            client.EnableSsl = Constants.SmtpClientEnableSSL
            ' Specify the e-mail sender.
            Dim mailFrom As New MailAddress(Constants.MailAddressFromAddress, Constants.MailAddressDisplayName, System.Text.Encoding.UTF8)
            ' Set destinations for the email message.
            'Dim mailTo As New MailAddress(Server.HtmlEncode(tbEmail.Text.Trim()))

            Dim mailTo As New MailAddress(Constants.MailAddressFromAddress)
            ' Specify the message content.
            Dim message As New MailMessage(mailFrom, mailTo)
            'message.Body = "This is a test email message sent by 2Wrights'Delights last time."
            message.Body = "<h2>2Wrights'Delights order details:</h2><hr />"
            ' Include some non-ASCII characters in body and subject.
            'Dim someArrows As New String(New Char() {ChrW(&H2190), ChrW(&H2191), ChrW(&H2192), ChrW(&H2193), ChrW(32768), ChrW(8594)})
            'message.Body += Environment.NewLine & someArrows
            message.Body += "<h3>Contact details:</h3>"
            message.Body += "<strong>" + "First name: </strong>" + Server.HtmlEncode(tbCustomerFirstName.Text.Trim())
            message.Body += "<br />" + "<strong>" + "Middle name: </strong>" + Server.HtmlEncode(tbMiddleName.Text.Trim())
            message.Body += "<br /><strong>" + "Last name: </strong>" + Server.HtmlEncode(tbCustomerLastName.Text.Trim())
            message.Body += "<br /><strong>" + "Primary phone: </strong>" + Server.HtmlEncode(tbPrimaryPhone.Text.Trim())
            message.Body += "<br /><strong>" + "Secondary phone: </strong>" + Server.HtmlEncode(tbSecondaryPhone.Text.Trim())
            message.Body += "<br /><strong>" + "Email: </strong>" + Server.HtmlEncode(tbEmail.Text.Trim())


            message.Body += "<hr /><h3>Shipping address:</h3>"
            message.Body += "<strong>" + "Full name: </strong>" + Server.HtmlEncode(tbShippingFullName.Text.Trim())
            message.Body += "<br /><strong>" + "Shipping address 1: </strong>" + Server.HtmlEncode(tbShippingStreetAddress1.Text.Trim())
            message.Body += "<br /><strong>" + "Shipping address 2: </strong>" + Server.HtmlEncode(tbSShippingtreetAddress2.Text.Trim())
            message.Body += "<br /><strong>" + "City: </strong>" + Server.HtmlEncode(tbShippingCity.Text.Trim())
            message.Body += "<br /><strong>" + "State: </strong>" + Server.HtmlEncode(tbShippingState.Text.Trim())
            message.Body += "<br /><strong>" + "Zip code: </strong>" + Server.HtmlEncode(tbShippingZipCode.Text.Trim())
            message.Body += "<br /><strong>" + "Phone number: </strong>" + Server.HtmlEncode(tbShippingPhoneNumber.Text.Trim())
            message.Body += "<br /><strong>" + "Date of delivery and specific time, if needed: </strong>" + Server.HtmlEncode(tbDateAndTimeOfDelivery.Text.Trim())

            message.Body += "<hr /><h3>Message to Chef (optional):</h3>"
            message.Body += Server.HtmlEncode(tbMessageToTheChefFromOrder.Text.Trim())

            message.Body += "<hr /><h3>Ordered products:</h3>"

            Dim productList As List(Of ProductListForPlacingTheOrder) = Session("ProductList")

            For Each item In productList
                message.Body += "<strong>Type of product: </strong>" + item.TypeOfProduct + "; <strong>Pecans requested: </strong>" + item.PecansRequested + "; <strong>Count: </strong>" + item.Count.ToString() + "; <strong>Price: </strong>$" + item.Price.ToString() + "<br />"

            Next

            If productList.Count > 0 Then
                message.Body += "<h3>Total price for this order: $" + Session("TotalPrice").ToString() + "</h3><hr />"
            End If

            'message.Body += "<p>*GMT time is 5 hours ahead of Central Daylight Time and 6 hours ahead of Central Standard Time</p>"

            message.BodyEncoding = System.Text.Encoding.UTF8
            message.Subject = "A new order from 2Wrights'Delights web site has been submitted on " + DateTime.UtcNow.ToShortDateString + " at " + DateTime.UtcNow.ToShortTimeString + " GMT"
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

                'Dim logFile As New FileInfo(Server.MapPath("~\\App_Data\\" + "order" + DateTime.UtcNow + ".txt"))

                'If logFile.Exists = False Then
                '    Dim fs As FileStream
                '    fs = logFile.Create()
                '    fs.Write(message.Body)
                'End If


                Dim uniencoding As UnicodeEncoding = New UnicodeEncoding()
                Dim filename As String = Server.MapPath("~\\App_Data\\Orders\\" + "order" + Server.UrlEncode(DateTime.UtcNow) + ".txt")

                Dim result As Byte() = uniencoding.GetBytes(DateTime.UtcNow + Environment.NewLine + message.Body)

                Using SourceStream As FileStream = File.Open(filename, FileMode.OpenOrCreate)
                    SourceStream.Seek(0, SeekOrigin.End)
                    Await SourceStream.WriteAsync(result, 0, result.Length)
                End Using

                ' Clean up.
                message.Dispose()
                Response.Redirect("~/OrderSubmitted.aspx", False)
            Catch ex As Exception
                Response.Redirect("~/ErrorEmailOrder.html")
            End Try

        End If

    End Sub



    ' The return type can be changed to IEnumerable, however to support
    ' paging and sorting, the following parameters must be added:
    '     ByVal maximumRows as Integer
    '     ByVal startRowIndex as Integer
    '     ByRef totalRowCount as Integer
    '     ByVal sortByExpression as String
    Public Function lvOrderedCookies_GetData() As IEnumerable
        Dim productList As New List(Of ProductListForPlacingTheOrder)
        '  Dim productList As New List(Of ProductListForPlacingTheOrder)
        Dim index As Integer = 1

        Dim bubbleGumCookies As New ProductListForPlacingTheOrder
        Dim chocolateChipCookies As New ProductListForPlacingTheOrder
        Dim doubleChocolateCookies As New ProductListForPlacingTheOrder
        Dim tripleChocolateCookies As New ProductListForPlacingTheOrder
        Dim lemonDropCookies As New ProductListForPlacingTheOrder
        Dim oatmealChocolateChunkCookies As New ProductListForPlacingTheOrder
        Dim oatmealCookies As New ProductListForPlacingTheOrder
        Dim peanutButterChocolateChipCookies As New ProductListForPlacingTheOrder
        Dim peanutButterMapleCookies As New ProductListForPlacingTheOrder
        Dim vanillaBeanSugarCookies As New ProductListForPlacingTheOrder
        Dim whiteChocolateMacadamiaCranberryCookies As New ProductListForPlacingTheOrder
        Dim whiteChocolateRaspberryCookies As New ProductListForPlacingTheOrder
        Dim texasSheetCake As New ProductListForPlacingTheOrder
        Dim chocolateFudgeBrownie As New ProductListForPlacingTheOrder
        Dim chocolateCaramelPecanBrownies As New ProductListForPlacingTheOrder
        Dim millionDollarFudge As New ProductListForPlacingTheOrder

        If Session("bubbleGumCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("bubbleGumCookiesCount")) > 0 Then
            bubbleGumCookies.TypeOfProduct = "Bubble Gum cookies"
            bubbleGumCookies.Count = Convert.ToInt32(Session("bubbleGumCookiesCount"))
            bubbleGumCookies.Price = Convert.ToDouble(Session("BubbleGumCookiesPriceTotal"))
            bubbleGumCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("bubbleGumCookiesAddPecansChecked")) = True Then
                bubbleGumCookies.PecansRequested = "Yes"
            Else
                bubbleGumCookies.PecansRequested = "No"
            End If

            productList.Add(bubbleGumCookies)

        End If


        If Session("chocolateChipCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("chocolateChipCookiesCount")) > 0 Then
            chocolateChipCookies.TypeOfProduct = "Chocolate Chip cookies"
            chocolateChipCookies.Count = Convert.ToInt32(Session("chocolateChipCookiesCount"))
            chocolateChipCookies.Price = Convert.ToDouble(Session("ChocolateChipCookiesPriceTotal"))
            chocolateChipCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("chocolateChipCookiesAddPecansChecked")) = True Then
                chocolateChipCookies.PecansRequested = "Yes"
            Else
                chocolateChipCookies.PecansRequested = "No"
            End If

            productList.Add(chocolateChipCookies)

        End If


        If Session("doubleChocolateCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("doubleChocolateCookiesCount")) > 0 Then
            doubleChocolateCookies.TypeOfProduct = "Double Chocolate cookies"
            doubleChocolateCookies.Count = Convert.ToInt32(Session("doubleChocolateCookiesCount"))
            doubleChocolateCookies.Price = Convert.ToDouble(Session("DoubleChocolateCookiesPriceTotal"))
            doubleChocolateCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("doubleChocolateCookiesAddPecansChecked")) = True Then
                doubleChocolateCookies.PecansRequested = "Yes"
            Else
                doubleChocolateCookies.PecansRequested = "No"
            End If

            productList.Add(doubleChocolateCookies)

        End If


        If Session("tripleChocolateCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("tripleChocolateCookiesCount")) > 0 Then
            tripleChocolateCookies.TypeOfProduct = "Triple Chocolate cookies"
            tripleChocolateCookies.Count = Convert.ToInt32(Session("tripleChocolateCookiesCount"))
            tripleChocolateCookies.Price = Convert.ToDouble(Session("TripleChocolateCookiesPriceTotal"))
            tripleChocolateCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("tripleChocolateCookiesAddPecansChecked")) = True Then
                tripleChocolateCookies.PecansRequested = "Yes"
            Else
                tripleChocolateCookies.PecansRequested = "No"
            End If

            productList.Add(tripleChocolateCookies)

        End If

        If Session("lemonDropCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("lemonDropCookiesCount")) > 0 Then
            lemonDropCookies.TypeOfProduct = "Lemon Drop cookies"
            lemonDropCookies.Count = Convert.ToInt32(Session("lemonDropCookiesCount"))
            lemonDropCookies.Price = Convert.ToDouble(Session("LemonDropCookiesPriceTotal"))
            lemonDropCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("lemonDropCookiesAddPecansChecked")) = True Then
                lemonDropCookies.PecansRequested = "Yes"
            Else
                lemonDropCookies.PecansRequested = "No"
            End If

            productList.Add(lemonDropCookies)

        End If

        If Session("oatmealChocolateChunkCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("oatmealChocolateChunkCookiesCount")) > 0 Then
            oatmealChocolateChunkCookies.TypeOfProduct = "Oatmeal Chocolate Chunk cookies"
            oatmealChocolateChunkCookies.Count = Convert.ToInt32(Session("oatmealChocolateChunkCookiesCount"))
            oatmealChocolateChunkCookies.Price = Convert.ToDouble(Session("OatmealChocolateChunkCookiesPriceTotal"))
            oatmealChocolateChunkCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("oatmealChocolateChunkCookiesAddPecansChecked")) = True Then
                oatmealChocolateChunkCookies.PecansRequested = "Yes"
            Else
                oatmealChocolateChunkCookies.PecansRequested = "No"
            End If

            productList.Add(oatmealChocolateChunkCookies)

        End If

        If Session("oatmealCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("oatmealCookiesCount")) > 0 Then
            oatmealCookies.TypeOfProduct = "Oatmeal cookies"
            oatmealCookies.Count = Convert.ToInt32(Session("oatmealCookiesCount"))
            oatmealCookies.Price = Convert.ToDouble(Session("OatmealCookiesPriceTotal"))
            oatmealCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("oatmealCookiesAddPecansChecked")) = True Then
                oatmealCookies.PecansRequested = "Yes"
            Else
                oatmealCookies.PecansRequested = "No"
            End If

            productList.Add(oatmealCookies)

        End If

        If Session("peanutButterChocolateChipCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("peanutButterChocolateChipCookiesCount")) > 0 Then
            peanutButterChocolateChipCookies.TypeOfProduct = "Peanut Butter Chocolate Chip cookies"
            peanutButterChocolateChipCookies.Count = Convert.ToInt32(Session("peanutButterChocolateChipCookiesCount"))
            peanutButterChocolateChipCookies.Price = Convert.ToDouble(Session("PeanutButterChocolateChipCookiesPriceTotal"))
            peanutButterChocolateChipCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("peanutButterChocolateChipCookiesAddPecansChecked")) = True Then
                peanutButterChocolateChipCookies.PecansRequested = "Yes"
            Else
                peanutButterChocolateChipCookies.PecansRequested = "No"
            End If

            productList.Add(peanutButterChocolateChipCookies)

        End If

        If Session("peanutButterMapleCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("peanutButterMapleCookiesCount")) > 0 Then
            peanutButterMapleCookies.TypeOfProduct = "Peanut Butter Maple cookies"
            peanutButterMapleCookies.Count = Convert.ToInt32(Session("peanutButterMapleCookiesCount"))
            peanutButterMapleCookies.Price = Convert.ToDouble(Session("PeanutButterMapleCookiesPriceTotal"))
            peanutButterMapleCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("peanutButterMapleCookiesAddPecansChecked")) = True Then
                peanutButterMapleCookies.PecansRequested = "Yes"
            Else
                peanutButterMapleCookies.PecansRequested = "No"
            End If

            productList.Add(peanutButterMapleCookies)

        End If

        If Session("vanillaBeanSugarCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("vanillaBeanSugarCookiesCount")) > 0 Then
            vanillaBeanSugarCookies.TypeOfProduct = "Vanilla Bean Sugar cookies"
            vanillaBeanSugarCookies.Count = Convert.ToInt32(Session("vanillaBeanSugarCookiesCount"))
            vanillaBeanSugarCookies.Price = Convert.ToDouble(Session("VanillaBeanSugarCookiesPriceTotal"))
            vanillaBeanSugarCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("vanillaBeanSugarCookiesAddPecansChecked")) = True Then
                vanillaBeanSugarCookies.PecansRequested = "Yes"
            Else
                vanillaBeanSugarCookies.PecansRequested = "No"
            End If

            productList.Add(vanillaBeanSugarCookies)

        End If

        If Session("whiteChocolateMacadamiaCranberryCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("whiteChocolateMacadamiaCranberryCookiesCount")) > 0 Then
            whiteChocolateMacadamiaCranberryCookies.TypeOfProduct = "White Chocolate Macadamia Cranberry cookies"
            whiteChocolateMacadamiaCranberryCookies.Count = Convert.ToInt32(Session("whiteChocolateMacadamiaCranberryCookiesCount"))
            whiteChocolateMacadamiaCranberryCookies.Price = Convert.ToDouble(Session("WhiteChocolateMacadamiaCranberryCookiesPriceTotal"))
            whiteChocolateMacadamiaCranberryCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked")) = True Then
                whiteChocolateMacadamiaCranberryCookies.PecansRequested = "Yes"
            Else
                whiteChocolateMacadamiaCranberryCookies.PecansRequested = "No"
            End If

            productList.Add(whiteChocolateMacadamiaCranberryCookies)

        End If

        If Session("whiteChocolateRaspberryCookiesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("whiteChocolateRaspberryCookiesCount")) > 0 Then
            whiteChocolateRaspberryCookies.TypeOfProduct = "White Chocolate Raspberry cookies"
            whiteChocolateRaspberryCookies.Count = Convert.ToInt32(Session("whiteChocolateRaspberryCookiesCount"))
            whiteChocolateRaspberryCookies.Price = Convert.ToDouble(Session("WhiteChocolateRaspberryCookiesPriceTotal"))
            whiteChocolateRaspberryCookies.OrderInTheList = index
            index = index + 1
            If Convert.ToBoolean(Session("whiteChocolateRaspberryCookiesAddPecansChecked")) = True Then
                whiteChocolateRaspberryCookies.PecansRequested = "Yes"
            Else
                whiteChocolateRaspberryCookies.PecansRequested = "No"
            End If

            productList.Add(whiteChocolateRaspberryCookies)

        End If

        If Session("texasSheetCakeCount") IsNot Nothing AndAlso Convert.ToInt32(Session("texasSheetCakeCount")) > 0 Then
            texasSheetCake.TypeOfProduct = "Texas Sheet cake"
            texasSheetCake.Count = Convert.ToInt32(Session("texasSheetCakeCount"))
            texasSheetCake.Price = Convert.ToDouble(Session("TexasSheetCakePriceTotal"))
            texasSheetCake.OrderInTheList = index
            index = index + 1

            texasSheetCake.PecansRequested = "N/A"

            productList.Add(texasSheetCake)

        End If



        If Session("chocolateFudgeBrownieCount") IsNot Nothing AndAlso Convert.ToInt32(Session("chocolateFudgeBrownieCount")) > 0 Then
            chocolateFudgeBrownie.TypeOfProduct = "Chocolate Fudge brownie"
            chocolateFudgeBrownie.Count = Convert.ToInt32(Session("chocolateFudgeBrownieCount"))
            chocolateFudgeBrownie.Price = Convert.ToDouble(Session("ChocolateFudgeBrowniePriceTotal"))
            chocolateFudgeBrownie.OrderInTheList = index
            index = index + 1

            If Convert.ToBoolean(Session("chocolateFudgeBrownieAddPecansChecked")) = True Then
                chocolateFudgeBrownie.PecansRequested = "Yes"
            Else
                chocolateFudgeBrownie.PecansRequested = "No"
            End If

            productList.Add(chocolateFudgeBrownie)

        End If

        If Session("chocolateCaramelPecanBrowniesCount") IsNot Nothing AndAlso Convert.ToInt32(Session("chocolateCaramelPecanBrowniesCount")) > 0 Then
            chocolateCaramelPecanBrownies.TypeOfProduct = "Chocolate Caramel Pecan brownie"
            chocolateCaramelPecanBrownies.Count = Convert.ToInt32(Session("chocolateCaramelPecanBrowniesCount"))
            chocolateCaramelPecanBrownies.Price = Convert.ToDouble(Session("ChocolateCaramelPecanBrowniesPriceTotal"))
            chocolateCaramelPecanBrownies.OrderInTheList = index
            index = index + 1

            chocolateCaramelPecanBrownies.PecansRequested = "N/A"

            productList.Add(chocolateCaramelPecanBrownies)

        End If

        If Session("millionDollarFudgeCount") IsNot Nothing AndAlso Convert.ToInt32(Session("millionDollarFudgeCount")) > 0 Then
            millionDollarFudge.TypeOfProduct = "Million Dollar fudge"
            millionDollarFudge.Count = Convert.ToInt32(Session("millionDollarFudgeCount"))
            millionDollarFudge.Price = Convert.ToDouble(Session("MillionDollarFudgePriceTotal"))
            millionDollarFudge.OrderInTheList = index
            index = index + 1

            millionDollarFudge.PecansRequested = "N/A"

            productList.Add(millionDollarFudge)

        End If

        Session("ProductList") = productList

        Return productList
    End Function

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs)
        args.IsValid = False

        Try
            Dim m As New MailAddress(tbEmail.Text.Trim())
            args.IsValid = True
        Catch ex As FormatException
            args.IsValid = False

        End Try

    End Sub
End Class