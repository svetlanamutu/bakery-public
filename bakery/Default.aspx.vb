Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        lblBubbleGumCookies.Text = "Price per dozen: $" + Constants.BubbleGumCookiesPrice.ToString()
        lblChocolateChipCookies.Text = "Price per dozen: $" + Constants.ChocolateChipCookiesPrice.ToString()
        lblDoubleChocolateCookies.Text = "Price per dozen: $" + Constants.DoubleChocolateCookiesPrice.ToString()
        lblTripleChocolateCookies.Text = "Price per dozen: $" + Constants.TripleChocolateCookiesPrice.ToString()
        lblLemonDropCookies.Text = "Price per dozen: $" + Constants.LemonDropCookiesPrice.ToString()
        lblOatmealChocolateChunkCookies.Text = "Price per dozen: $" + Constants.OatmealChocolateChunkCookiesPrice.ToString()
        lblOatmealCookies.Text = "Price per dozen: $" + Constants.OatmealCookiesPrice.ToString()
        lblPeanutButterChocolateChipCookies.Text = "Price per dozen: $" + Constants.PeanutButterChocolateChipCookiesPrice.ToString()
        lblPeanutButterMapleCookies.Text = "Price per dozen: $" + Constants.PeanutButterMapleCookiesPrice.ToString()
        lblVanillaBeanSugarCookies.Text = "Price per dozen: $" + Constants.VanillaBeanSugarCookiesPrice.ToString()
        lblWhiteChocolateMacadamiaCranberryCookies.Text = "Price per dozen: $" + Constants.WhiteChocolateMacadamiaCranberryCookiesPrice.ToString()
        lblWhiteChocolateRaspberryCookies.Text = "Price per dozen: $" + Constants.WhiteChocolateRaspberryCookiesPrice.ToString()
        lblTexasSheetCake.Text = "Price per sheet of indicated size: $" + Constants.TexasSheetCakePrice.ToString()
        lblChocolateFudgeBrownies.Text = "Price per sheet of indicated size: $" + Constants.ChocolateFudgeBrowniesPrice.ToString()
        lblChocolateCaramelPecanBrownies.Text = "Price per sheet of indicated size: $" + Constants.ChocolateCaramelPecanBrowniesPrice.ToString()
        lblMillionDollarFudge.Text = "Price per sheet of indicated size: $" + Constants.MillionDollarFudgePrice.ToString()

    End Sub
End Class