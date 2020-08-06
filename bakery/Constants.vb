Imports System.Web.Configuration
Module Constants

    Public ReadOnly Property BubbleGumCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("BubbleGumCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("BubbleGumCookiesPrice"))
            Else
                Return 0
            End If
        End Get
        'Set(ByVal value As Integer)
        '    _count = value
        'End Set
    End Property

    Public ReadOnly Property ChocolateChipCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("ChocolateChipCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("ChocolateChipCookiesPrice"))
            Else
                Return 0
            End If
        End Get

    End Property

    Public ReadOnly Property DoubleChocolateCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("DoubleChocolateCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("DoubleChocolateCookiesPrice"))
            Else
                Return 0
            End If
        End Get

    End Property

    Public ReadOnly Property TripleChocolateCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("TripleChocolateCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("TripleChocolateCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property


    Public ReadOnly Property LemonDropCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("LemonDropCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("LemonDropCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property OatmealChocolateChunkCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("OatmealChocolateChunkCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("OatmealChocolateChunkCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property OatmealCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("OatmealCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("OatmealCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property PeanutButterChocolateChipCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("PeanutButterChocolateChipCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("PeanutButterChocolateChipCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property PeanutButterMapleCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("PeanutButterMapleCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("PeanutButterMapleCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property


    Public ReadOnly Property VanillaBeanSugarCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("VanillaBeanSugarCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("VanillaBeanSugarCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property WhiteChocolateMacadamiaCranberryCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("WhiteChocolateMacadamiaCranberryCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("WhiteChocolateMacadamiaCranberryCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property WhiteChocolateRaspberryCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("WhiteChocolateRaspberryCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("WhiteChocolateRaspberryCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property TexasSheetCakePrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("TexasSheetCakePrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("TexasSheetCakePrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property ChocolateFudgeBrowniesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("ChocolateFudgeBrowniesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("ChocolateFudgeBrowniesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property ChocolateCaramelPecanBrowniesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("ChocolateCaramelPecanBrowniesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("ChocolateCaramelPecanBrowniesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property MillionDollarFudgePrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("MillionDollarFudgePrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("MillionDollarFudgePrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property AddPecansForCookiesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("AddPecansForCookiesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("AddPecansForCookiesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property AddPecansForChocolateFudgeBrowniesPrice() As Double
        Get
            If WebConfigurationManager.AppSettings.Get("AddPecansForChocolateFudgeBrowniesPrice") IsNot Nothing Then
                Return Convert.ToDouble(WebConfigurationManager.AppSettings.Get("AddPecansForChocolateFudgeBrowniesPrice"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property SmtpClientHost() As String
        Get
            If WebConfigurationManager.AppSettings.Get("SmtpClientHost") IsNot Nothing Then
                Return Convert.ToString(WebConfigurationManager.AppSettings.Get("SmtpClientHost"))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property SmtpClientPort() As Integer
        Get
            If WebConfigurationManager.AppSettings.Get("SmtpClientPort") IsNot Nothing Then
                Return Convert.ToInt32(WebConfigurationManager.AppSettings.Get("SmtpClientPort"))
            Else
                Return 0
            End If
        End Get
    End Property

    Public ReadOnly Property SmtpClientUsername() As String
        Get
            If WebConfigurationManager.AppSettings.Get("SmtpClientUsername") IsNot Nothing Then
                Return Convert.ToString(WebConfigurationManager.AppSettings.Get("SmtpClientUsername"))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property SmtpClientPassword() As String
        Get
            If WebConfigurationManager.AppSettings.Get("SmtpClientPassword") IsNot Nothing Then
                Return Convert.ToString(WebConfigurationManager.AppSettings.Get("SmtpClientPassword"))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property SmtpClientEnableSSL() As Boolean
        Get
            If WebConfigurationManager.AppSettings.Get("SmtpClientEnableSSL") IsNot Nothing Then
                Return Convert.ToBoolean(WebConfigurationManager.AppSettings.Get("SmtpClientEnableSSL"))
            Else
                Return True
            End If
        End Get
    End Property

    Public ReadOnly Property MailAddressFromAddress() As String
        Get
            If WebConfigurationManager.AppSettings.Get("MailAddressFromAddress") IsNot Nothing Then
                Return Convert.ToString(WebConfigurationManager.AppSettings.Get("MailAddressFromAddress"))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public ReadOnly Property MailAddressDisplayName() As String
        Get
            If WebConfigurationManager.AppSettings.Get("MailAddressDisplayName") IsNot Nothing Then
                Return Convert.ToString(WebConfigurationManager.AppSettings.Get("MailAddressDisplayName"))
            Else
                Return Nothing
            End If
        End Get
    End Property
End Module
