Public Class Order
    Inherits System.Web.UI.Page
    Dim TotalPrice As Double = 0
    Dim BubbleGumCookiesPriceTotal As Double = 0
    Dim ChocolateChipCookiesPriceTotal As Double = 0
    Dim DoubleChocolateCookiesPriceTotal As Double = 0
    Dim TripleChocolateCookiesPriceTotal As Double = 0
    Dim LemonDropCookiesPriceTotal As Double = 0
    Dim OatmealChocolateChunkCookiesPriceTotal As Double = 0
    Dim OatmealCookiesPriceTotal As Double = 0
    Dim PeanutButterChocolateChipCookiesPriceTotal As Double = 0
    Dim PeanutButterMapleCookiesPriceTotal As Double = 0
    Dim VanillaBeanSugarCookiesPriceTotal As Double = 0
    Dim WhiteChocolateMacadamiaCranberryCookiesPriceTotal As Double = 0
    Dim WhiteChocolateRaspberryCookiesPriceTotal As Double = 0
    Dim TexasSheetCakePriceTotal As Double = 0
    Dim ChocolateFudgeBrowniePriceTotal As Double = 0
    Dim ChocolateCaramelPecanBrowniesPriceTotal As Double = 0
    Dim MillionDollarFudgePriceTotal As Double = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then
            If Not String.IsNullOrEmpty(Session("bubbleGumCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("bubbleGumCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("bubbleGumCookiesCount")) > 0 AndAlso Session("bubbleGumCookiesAddPecansChecked").Length > 1 Then
                phBubbleGumCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountBubbleGum.Text = Session("bubbleGumCookiesCount")
                cbBubbleGumAddPecans.Checked = Convert.ToBoolean(Session("bubbleGumCookiesAddPecansChecked"))
                btnOrderBubbleGum_Click(Nothing, Nothing)
                lblAddedIntoOrderBubbleGumCookies.Visible = False
            End If




            If Not String.IsNullOrEmpty(Session("chocolateChipCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("chocolateChipCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("chocolateChipCookiesCount")) > 0 AndAlso Session("chocolateChipCookiesAddPecansChecked").Length > 1 Then
                phChocolateChipCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountChocolateChip.Text = Session("chocolateChipCookiesCount")
                cbChocolateChipAddPecans.Checked = Convert.ToBoolean(Session("chocolateChipCookiesAddPecansChecked"))
                btnOrderChocolateChip_Click(Nothing, Nothing)
                lblAddedToOrderChocolateChipCookies.Visible = False
            End If


            If Not String.IsNullOrEmpty(Session("doubleChocolateCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("doubleChocolateCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("doubleChocolateCookiesCount")) > 0 AndAlso Session("doubleChocolateCookiesAddPecansChecked").Length > 1 Then
                phDoubleChocolateCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountDoubleChocolate.Text = Session("doubleChocolateCookiesCount")
                cbDoubleChocolateAddPecans.Checked = Convert.ToBoolean(Session("doubleChocolateCookiesAddPecansChecked"))
                btnOrderDoubleChocolate_Click(Nothing, Nothing)
                lblAddedToOrderDoubleChocolateCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("tripleChocolateCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("tripleChocolateCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("tripleChocolateCookiesCount")) > 0 AndAlso Session("tripleChocolateCookiesAddPecansChecked").Length > 1 Then
                phTripleChocolateCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountTripleChocolate.Text = Session("tripleChocolateCookiesCount")
                cbTripleChocolateAddPecans.Checked = Convert.ToBoolean(Session("tripleChocolateCookiesAddPecansChecked"))
                btnOrderTripleChocolate_Click(Nothing, Nothing)
                lblAddedToOrderTripleChocolateCookies.Visible = False
            End If


            If Not String.IsNullOrEmpty(Session("lemonDropCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("lemonDropCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("lemonDropCookiesCount")) > 0 AndAlso Session("lemonDropCookiesAddPecansChecked").Length > 1 Then
                phLemonDropCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountLemonDrop.Text = Session("lemonDropCookiesCount")
                cbLemonDropAddPecans.Checked = Convert.ToBoolean(Session("lemonDropCookiesAddPecansChecked"))
                btnOrderLemonDrop_Click(Nothing, Nothing)
                lblAddedToOrderLemonDropCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("oatmealChocolateChunkCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("oatmealChocolateChunkCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("oatmealChocolateChunkCookiesCount")) > 0 AndAlso Session("oatmealChocolateChunkCookiesAddPecansChecked").Length > 1 Then
                phOatmealChocolateChunkCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountOatmealChocolateChunk.Text = Session("oatmealChocolateChunkCookiesCount")
                cbOatmealChocolateChunkAddPecans.Checked = Convert.ToBoolean(Session("oatmealChocolateChunkCookiesAddPecansChecked"))
                btnOrderOatmealChocolateChunk_Click(Nothing, Nothing)
                lblAddedToOrderOatmealChocolateChunkCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("oatmealCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("oatmealCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("oatmealCookiesCount")) > 0 AndAlso Session("oatmealCookiesAddPecansChecked").Length > 1 Then
                phOatmealCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountOatmeal.Text = Session("oatmealCookiesCount")
                cbOatmealAddPecans.Checked = Convert.ToBoolean(Session("oatmealCookiesAddPecansChecked"))
                btnOrderOatmeal_Click(Nothing, Nothing)
                lblAddedToOrderOatmealCookies.Visible = False
            End If


            If Not String.IsNullOrEmpty(Session("peanutButterChocolateChipCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("peanutButterChocolateChipCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("peanutButterChocolateChipCookiesCount")) > 0 AndAlso Session("peanutButterChocolateChipCookiesAddPecansChecked").Length > 1 Then
                phPeanutButterChocolateChipCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountPeanutButterChocolateChip.Text = Session("peanutButterChocolateChipCookiesCount")
                cbPeanutButterChocolateChipAddPecans.Checked = Convert.ToBoolean(Session("peanutButterChocolateChipCookiesAddPecansChecked"))
                btnOrderPeanutButterChocolateChip_Click(Nothing, Nothing)
                lblAddedToOrderPeanutButterChocolateChipCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("peanutButterMapleCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("peanutButterMapleCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("peanutButterMapleCookiesCount")) > 0 AndAlso Session("peanutButterMapleCookiesAddPecansChecked").Length > 1 Then
                phPeanutButterMapleCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountPeanutButterMaple.Text = Session("peanutButterMapleCookiesCount")
                cbPeanutButterMapleAddPecans.Checked = Convert.ToBoolean(Session("peanutButterMapleCookiesAddPecansChecked"))
                btnOrderPeanutButterMaple_Click(Nothing, Nothing)
                lblAddedToOrderPeanutButterMapleCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("vanillaBeanSugarCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("vanillaBeanSugarCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("vanillaBeanSugarCookiesCount")) > 0 AndAlso Session("vanillaBeanSugarCookiesAddPecansChecked").Length > 1 Then
                phVanillaBeanSugarCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountVanillaBeanSugar.Text = Session("vanillaBeanSugarCookiesCount")
                cbVanillaBeanSugarAddPecans.Checked = Convert.ToBoolean(Session("vanillaBeanSugarCookiesAddPecansChecked"))
                btnOrderVanillaBeanSugar_Click(Nothing, Nothing)
                lblAddedToOrderVanillaBeanSugarCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("whiteChocolateMacadamiaCranberryCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("whiteChocolateMacadamiaCranberryCookiesCount")) > 0 AndAlso Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked").Length > 1 Then
                phWhiteChocolateMacadamiaCranberryCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountWhiteChocolateMacadamiaCranberry.Text = Session("whiteChocolateMacadamiaCranberryCookiesCount")
                cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = Convert.ToBoolean(Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked"))
                btnOrderWhiteChocolateMacadamiaCranberry_Click(Nothing, Nothing)
                lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("whiteChocolateRaspberryCookiesCount")) AndAlso Not String.IsNullOrEmpty(Session("whiteChocolateRaspberryCookiesAddPecansChecked")) AndAlso Convert.ToInt32(Session("whiteChocolateRaspberryCookiesCount")) > 0 AndAlso Session("whiteChocolateRaspberryCookiesAddPecansChecked").Length > 1 Then
                phWhiteChocolateRaspberryCookies.Visible = True
                phNothingOrdered.Visible = False
                tbCountWhiteChocolateRaspberry.Text = Session("whiteChocolateRaspberryCookiesCount")
                cbWhiteChocolateRaspberryAddPecans.Checked = Convert.ToBoolean(Session("whiteChocolateRaspberryCookiesAddPecansChecked"))
                btnOrderWhiteChocolateRaspberry_Click(Nothing, Nothing)
                lblAddedToOrderWhiteChocolateRaspberryCookies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("texasSheetCakeCount")) AndAlso Convert.ToInt32(Session("texasSheetCakeCount")) > 0 Then
                phTexasSheetCake.Visible = True
                phNothingOrdered.Visible = False
                tbCountTexasSheetCake.Text = Session("texasSheetCakeCount")

                btnOrderTexasSheetCake_Click(Nothing, Nothing)
                lblAddedToOrderTexasSheetCake.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("chocolateFudgeBrownieCount")) AndAlso Not String.IsNullOrEmpty(Session("chocolateFudgeBrownieAddPecansChecked")) AndAlso Convert.ToInt32(Session("chocolateFudgeBrownieCount")) > 0 AndAlso Session("chocolateFudgeBrownieAddPecansChecked").Length > 1 Then
                phChocolateFudgeBrownie.Visible = True
                phNothingOrdered.Visible = False
                tbCountChocolateFudgeBrownie.Text = Session("chocolateFudgeBrownieCount")
                cbChocolateFudgeBrownieAddPecans.Checked = Convert.ToBoolean(Session("chocolateFudgeBrownieAddPecansChecked"))
                btnOrderChocolateFudgeBrownie_Click(Nothing, Nothing)
                lblAddedToOrderChocolateFudgeBrownie.Visible = False
            End If


            If Not String.IsNullOrEmpty(Session("chocolateCaramelPecanBrowniesCount")) AndAlso Convert.ToInt32(Session("chocolateCaramelPecanBrowniesCount")) > 0 Then
                phChocolateCaramelPecanBrownies.Visible = True
                phNothingOrdered.Visible = False
                tbCountChocolateCaramelPecanBrownies.Text = Session("chocolateCaramelPecanBrowniesCount")

                btnOrderChocolateCaramelPecanBrownies_Click(Nothing, Nothing)
                lblAddedToOrderChocolateCaramelPecanBrownies.Visible = False
            End If

            If Not String.IsNullOrEmpty(Session("millionDollarFudgeCount")) AndAlso Convert.ToInt32(Session("millionDollarFudgeCount")) > 0 Then
                phMillionDollarFudge.Visible = True
                phNothingOrdered.Visible = False
                tbCountMillionDollarFudge.Text = Session("millionDollarFudgeCount")

                btnOrderMillionDollarFudge_Click(Nothing, Nothing)
                lblAddedToOrderMillionDollarFudge.Visible = False
            End If


        End If






        If cbBubbleGumAddPecans.Checked = True Then
            If Not String.IsNullOrEmpty(tbCountBubbleGum.Text.Trim) AndAlso ((Convert.ToInt32(tbCountBubbleGum.Text.Trim) * (Constants.BubbleGumCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                BubbleGumCookiesPriceTotal = Convert.ToInt32(tbCountBubbleGum.Text.Trim) * (Constants.BubbleGumCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("BubbleGumCookiesPriceTotal") = BubbleGumCookiesPriceTotal
            End If
        Else
            If Not String.IsNullOrEmpty(tbCountBubbleGum.Text.Trim) AndAlso ((Convert.ToInt32(tbCountBubbleGum.Text.Trim) * (Constants.BubbleGumCookiesPrice)) > 0) Then

                BubbleGumCookiesPriceTotal = Convert.ToInt32(tbCountBubbleGum.Text.Trim) * (Constants.BubbleGumCookiesPrice)
                Session("BubbleGumCookiesPriceTotal") = BubbleGumCookiesPriceTotal
            End If
        End If

        If cbChocolateChipAddPecans.Checked = True Then
            If Not String.IsNullOrEmpty(tbCountChocolateChip.Text.Trim) AndAlso ((Convert.ToInt32(tbCountChocolateChip.Text.Trim) * (Constants.ChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                ChocolateChipCookiesPriceTotal = Convert.ToInt32(tbCountChocolateChip.Text.Trim) * (Constants.ChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("ChocolateChipCookiesPriceTotal") = ChocolateChipCookiesPriceTotal
            End If
        Else
            If Not String.IsNullOrEmpty(tbCountChocolateChip.Text.Trim) AndAlso ((Convert.ToInt32(tbCountChocolateChip.Text.Trim) * (Constants.ChocolateChipCookiesPrice)) > 0) Then

                ChocolateChipCookiesPriceTotal = Convert.ToInt32(tbCountChocolateChip.Text.Trim) * (Constants.ChocolateChipCookiesPrice)
                Session("ChocolateChipCookiesPriceTotal") = ChocolateChipCookiesPriceTotal
            End If
        End If

        If cbDoubleChocolateAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountDoubleChocolate.Text.Trim) AndAlso ((Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * (Constants.DoubleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    DoubleChocolateCookiesPriceTotal = Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * (Constants.DoubleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("DoubleChocolateCookiesPriceTotal") = DoubleChocolateCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountDoubleChocolate.Text.Trim) AndAlso ((Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * (Constants.DoubleChocolateCookiesPrice)) > 0) Then

                    DoubleChocolateCookiesPriceTotal = Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * (Constants.DoubleChocolateCookiesPrice)
                Session("DoubleChocolateCookiesPriceTotal") = DoubleChocolateCookiesPriceTotal
            End If
            End If

            If cbTripleChocolateAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountTripleChocolate.Text.Trim) AndAlso ((Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * (Constants.TripleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    TripleChocolateCookiesPriceTotal = Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * (Constants.TripleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("TripleChocolateCookiesPriceTotal") = TripleChocolateCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountTripleChocolate.Text.Trim) AndAlso ((Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * (Constants.TripleChocolateCookiesPrice)) > 0) Then

                    TripleChocolateCookiesPriceTotal = Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * (Constants.TripleChocolateCookiesPrice)
                Session("TripleChocolateCookiesPriceTotal") = TripleChocolateCookiesPriceTotal
            End If
            End If


            If cbLemonDropAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountLemonDrop.Text.Trim) AndAlso ((Convert.ToInt32(tbCountLemonDrop.Text.Trim) * (Constants.LemonDropCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    LemonDropCookiesPriceTotal = Convert.ToInt32(tbCountLemonDrop.Text.Trim) * (Constants.LemonDropCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("LemonDropCookiesPriceTotal") = LemonDropCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountLemonDrop.Text.Trim) AndAlso ((Convert.ToInt32(tbCountLemonDrop.Text.Trim) * (Constants.LemonDropCookiesPrice)) > 0) Then

                    LemonDropCookiesPriceTotal = Convert.ToInt32(tbCountLemonDrop.Text.Trim) * (Constants.LemonDropCookiesPrice)
                Session("LemonDropCookiesPriceTotal") = LemonDropCookiesPriceTotal
            End If
            End If

            If cbOatmealChocolateChunkAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountOatmealChocolateChunk.Text.Trim) AndAlso ((Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * (Constants.OatmealChocolateChunkCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    OatmealChocolateChunkCookiesPriceTotal = Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * (Constants.OatmealChocolateChunkCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("OatmealChocolateChunkCookiesPriceTotal") = OatmealChocolateChunkCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountOatmealChocolateChunk.Text.Trim) AndAlso ((Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * (Constants.OatmealChocolateChunkCookiesPrice)) > 0) Then

                    OatmealChocolateChunkCookiesPriceTotal = Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * (Constants.OatmealChocolateChunkCookiesPrice)
                Session("OatmealChocolateChunkCookiesPriceTotal") = OatmealChocolateChunkCookiesPriceTotal
            End If
            End If


            If cbOatmealAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountOatmeal.Text.Trim) AndAlso ((Convert.ToInt32(tbCountOatmeal.Text.Trim) * (Constants.OatmealCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    OatmealCookiesPriceTotal = Convert.ToInt32(tbCountOatmeal.Text.Trim) * (Constants.OatmealCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("OatmealCookiesPriceTotal") = OatmealCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountOatmeal.Text.Trim) AndAlso ((Convert.ToInt32(tbCountOatmeal.Text.Trim) * (Constants.OatmealCookiesPrice)) > 0) Then

                    OatmealCookiesPriceTotal = Convert.ToInt32(tbCountOatmeal.Text.Trim) * (Constants.OatmealCookiesPrice)
                Session("OatmealCookiesPriceTotal") = OatmealCookiesPriceTotal
            End If
            End If


            If cbPeanutButterChocolateChipAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountPeanutButterChocolateChip.Text.Trim) AndAlso ((Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * (Constants.PeanutButterChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    PeanutButterChocolateChipCookiesPriceTotal = Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * (Constants.PeanutButterChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("PeanutButterChocolateChipCookiesPriceTotal") = PeanutButterChocolateChipCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountPeanutButterChocolateChip.Text.Trim) AndAlso ((Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * (Constants.PeanutButterChocolateChipCookiesPrice)) > 0) Then

                    PeanutButterChocolateChipCookiesPriceTotal = Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * (Constants.PeanutButterChocolateChipCookiesPrice)
                Session("PeanutButterChocolateChipCookiesPriceTotal") = PeanutButterChocolateChipCookiesPriceTotal
            End If
            End If

            If cbPeanutButterMapleAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountPeanutButterMaple.Text.Trim) AndAlso ((Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * (Constants.PeanutButterMapleCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    PeanutButterMapleCookiesPriceTotal = Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * (Constants.PeanutButterMapleCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("PeanutButterMapleCookiesPriceTotal") = PeanutButterMapleCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountPeanutButterMaple.Text.Trim) AndAlso ((Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * (Constants.PeanutButterMapleCookiesPrice)) > 0) Then

                    PeanutButterMapleCookiesPriceTotal = Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * (Constants.PeanutButterMapleCookiesPrice)
                Session("PeanutButterMapleCookiesPriceTotal") = PeanutButterMapleCookiesPriceTotal
            End If
            End If

            If cbVanillaBeanSugarAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountVanillaBeanSugar.Text.Trim) AndAlso ((Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * (Constants.VanillaBeanSugarCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    VanillaBeanSugarCookiesPriceTotal = Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * (Constants.VanillaBeanSugarCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("VanillaBeanSugarCookiesPriceTotal") = VanillaBeanSugarCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountVanillaBeanSugar.Text.Trim) AndAlso ((Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * (Constants.VanillaBeanSugarCookiesPrice)) > 0) Then

                    VanillaBeanSugarCookiesPriceTotal = Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * (Constants.VanillaBeanSugarCookiesPrice)
                Session("VanillaBeanSugarCookiesPriceTotal") = VanillaBeanSugarCookiesPriceTotal
            End If
            End If

            If cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) AndAlso ((Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * (Constants.WhiteChocolateMacadamiaCranberryCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    WhiteChocolateMacadamiaCranberryCookiesPriceTotal = Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * (Constants.WhiteChocolateMacadamiaCranberryCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("WhiteChocolateMacadamiaCranberryCookiesPriceTotal") = WhiteChocolateMacadamiaCranberryCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) AndAlso ((Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * (Constants.WhiteChocolateMacadamiaCranberryCookiesPrice)) > 0) Then

                    WhiteChocolateMacadamiaCranberryCookiesPriceTotal = Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * (Constants.WhiteChocolateMacadamiaCranberryCookiesPrice)
                Session("WhiteChocolateMacadamiaCranberryCookiesPriceTotal") = WhiteChocolateMacadamiaCranberryCookiesPriceTotal
            End If
            End If

            If cbWhiteChocolateRaspberryAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountWhiteChocolateRaspberry.Text.Trim) AndAlso ((Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * (Constants.WhiteChocolateRaspberryCookiesPrice + Constants.AddPecansForCookiesPrice)) > 0) Then

                    WhiteChocolateRaspberryCookiesPriceTotal = Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * (Constants.WhiteChocolateRaspberryCookiesPrice + Constants.AddPecansForCookiesPrice)
                Session("WhiteChocolateRaspberryCookiesPriceTotal") = WhiteChocolateRaspberryCookiesPriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountWhiteChocolateRaspberry.Text.Trim) AndAlso ((Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * (Constants.WhiteChocolateRaspberryCookiesPrice)) > 0) Then

                    WhiteChocolateRaspberryCookiesPriceTotal = Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * (Constants.WhiteChocolateRaspberryCookiesPrice)
                Session("WhiteChocolateRaspberryCookiesPriceTotal") = WhiteChocolateRaspberryCookiesPriceTotal
            End If
            End If


            If Not String.IsNullOrEmpty(tbCountTexasSheetCake.Text.Trim) AndAlso ((Convert.ToInt32(tbCountTexasSheetCake.Text.Trim) * (Constants.TexasSheetCakePrice)) > 0) Then

                TexasSheetCakePriceTotal = Convert.ToInt32(tbCountTexasSheetCake.Text.Trim) * (Constants.TexasSheetCakePrice)
            Session("TexasSheetCakePriceTotal") = TexasSheetCakePriceTotal
        End If


            If cbChocolateFudgeBrownieAddPecans.Checked = True Then
                If Not String.IsNullOrEmpty(tbCountChocolateFudgeBrownie.Text.Trim) AndAlso ((Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * (Constants.ChocolateFudgeBrowniesPrice + Constants.AddPecansForChocolateFudgeBrowniesPrice)) > 0) Then

                    ChocolateFudgeBrowniePriceTotal = Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * (Constants.ChocolateFudgeBrowniesPrice + Constants.AddPecansForChocolateFudgeBrowniesPrice)
                Session("ChocolateFudgeBrowniePriceTotal") = ChocolateFudgeBrowniePriceTotal
            End If
            Else
                If Not String.IsNullOrEmpty(tbCountChocolateFudgeBrownie.Text.Trim) AndAlso ((Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * (Constants.ChocolateFudgeBrowniesPrice)) > 0) Then

                    ChocolateFudgeBrowniePriceTotal = Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * (Constants.ChocolateFudgeBrowniesPrice)
                Session("ChocolateFudgeBrowniePriceTotal") = ChocolateFudgeBrowniePriceTotal
            End If
            End If

            If Not String.IsNullOrEmpty(tbCountChocolateCaramelPecanBrownies.Text.Trim) AndAlso ((Convert.ToInt32(tbCountChocolateCaramelPecanBrownies.Text.Trim) * (Constants.ChocolateCaramelPecanBrowniesPrice)) > 0) Then

                ChocolateCaramelPecanBrowniesPriceTotal = Convert.ToInt32(tbCountChocolateCaramelPecanBrownies.Text.Trim) * (Constants.ChocolateCaramelPecanBrowniesPrice)
            Session("ChocolateCaramelPecanBrowniesPriceTotal") = ChocolateCaramelPecanBrowniesPriceTotal
        End If

            If Not String.IsNullOrEmpty(tbCountMillionDollarFudge.Text.Trim) AndAlso ((Convert.ToInt32(tbCountMillionDollarFudge.Text.Trim) * (Constants.MillionDollarFudgePrice)) > 0) Then

                MillionDollarFudgePriceTotal = Convert.ToInt32(tbCountMillionDollarFudge.Text.Trim) * (Constants.MillionDollarFudgePrice)
            Session("MillionDollarFudgePriceTotal") = MillionDollarFudgePriceTotal
        End If






        TotalPrice = BubbleGumCookiesPriceTotal + ChocolateChipCookiesPriceTotal + DoubleChocolateCookiesPriceTotal + TripleChocolateCookiesPriceTotal + LemonDropCookiesPriceTotal + OatmealChocolateChunkCookiesPriceTotal + OatmealCookiesPriceTotal + PeanutButterChocolateChipCookiesPriceTotal + PeanutButterMapleCookiesPriceTotal + VanillaBeanSugarCookiesPriceTotal + WhiteChocolateMacadamiaCranberryCookiesPriceTotal + WhiteChocolateRaspberryCookiesPriceTotal + TexasSheetCakePriceTotal + ChocolateFudgeBrowniePriceTotal + ChocolateCaramelPecanBrowniesPriceTotal + MillionDollarFudgePriceTotal
        Session("TotalPrice") = TotalPrice
        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If
    End Sub



    Protected Sub btnOrderBubbleGum_Click(sender As Object, e As EventArgs)
        lblAddedIntoOrderBubbleGumCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountBubbleGum.Text.Trim) AndAlso Convert.ToInt32(tbCountBubbleGum.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedIntoOrderBubbleGumCookies.Visible = True
            phBubbleGumCookies.Visible = True
            If cbBubbleGumAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountBubbleGum.Text.Trim) = 1 Then
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozens with pecans"
                End If
                lblPriceForBubbleGumCookies.Text = "$" + (Convert.ToInt32(tbCountBubbleGum.Text.Trim) * (Constants.BubbleGumCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountBubbleGum.Text.Trim) = 1 Then
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozen"
                Else
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozens"
                End If

                lblPriceForBubbleGumCookies.Text = "$" + (Convert.ToInt32(tbCountBubbleGum.Text.Trim) * Constants.BubbleGumCookiesPrice).ToString()
            End If


        Else
            phBubbleGumCookies.Visible = False
            lblOrderTotalBubbleGumCookies.Text = Nothing
            lblPriceForBubbleGumCookies.Text = Nothing
            cbBubbleGumAddPecans.Checked = False
            lblAddedIntoOrderBubbleGumCookies.Text = "Removed!"

        End If

        'Session("lblOrderTotalBubbleGumCookies") = lblOrderTotalBubbleGumCookies.Text

        Session("bubbleGumCookiesCount") = tbCountBubbleGum.Text.Trim
        Session("bubbleGumCookiesAddPecansChecked") = cbBubbleGumAddPecans.Checked.ToString()
    End Sub


    Protected Sub btnOrderChocolateChip_Click(sender As Object, e As EventArgs)
        lblAddedToOrderChocolateChipCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountChocolateChip.Text.Trim) AndAlso Convert.ToInt32(tbCountChocolateChip.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderChocolateChipCookies.Visible = True
            phChocolateChipCookies.Visible = True

            If cbChocolateChipAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozens with pecans"
                End If
                lblPriceForChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountChocolateChip.Text.Trim) * (Constants.ChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozen"
                Else
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozens"
                End If
                lblPriceForChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountChocolateChip.Text.Trim) * Constants.ChocolateChipCookiesPrice).ToString()
            End If



        Else
            phChocolateChipCookies.Visible = False
            lblOrderTotalChocolateChipCookies.Text = Nothing
            lblPriceForChocolateChipCookies.Text = Nothing
            cbChocolateChipAddPecans.Checked = False
            lblAddedToOrderChocolateChipCookies.Text = "Removed!"

        End If

        Session("chocolateChipCookiesCount") = tbCountChocolateChip.Text.Trim
        Session("chocolateChipCookiesAddPecansChecked") = cbChocolateChipAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderDoubleChocolate_Click(sender As Object, e As EventArgs)
        lblAddedToOrderDoubleChocolateCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountDoubleChocolate.Text.Trim) AndAlso Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderDoubleChocolateCookies.Visible = True
            phDoubleChocolateCookies.Visible = True

            If cbDoubleChocolateAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozens with pecans"
                End If
                lblPriceForDoubleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * (Constants.DoubleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozen"
                Else
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozens"
                End If
                lblPriceForDoubleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * Constants.DoubleChocolateCookiesPrice).ToString()
            End If



        Else
            phDoubleChocolateCookies.Visible = False
            lblOrderTotalDoubleChocolateCookies.Text = Nothing
            lblPriceForDoubleChocolateCookies.Text = Nothing
            cbDoubleChocolateAddPecans.Checked = False
            lblAddedToOrderDoubleChocolateCookies.Text = "Removed!"

        End If

        Session("doubleChocolateCookiesCount") = tbCountDoubleChocolate.Text.Trim
        Session("doubleChocolateCookiesAddPecansChecked") = cbDoubleChocolateAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderTripleChocolate_Click(sender As Object, e As EventArgs)

        lblAddedToOrderTripleChocolateCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountTripleChocolate.Text.Trim) AndAlso Convert.ToInt32(tbCountTripleChocolate.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderTripleChocolateCookies.Visible = True
            phTripleChocolateCookies.Visible = True

            If cbTripleChocolateAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountTripleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozens with pecans"
                End If
                lblPriceForTripleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * (Constants.TripleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountTripleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozen"
                Else
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozens"
                End If
                lblPriceForTripleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * Constants.TripleChocolateCookiesPrice).ToString()
            End If



        Else
            phTripleChocolateCookies.Visible = False
            lblOrderTotalTripleChocolateCookies.Text = Nothing
            lblPriceForTripleChocolateCookies.Text = Nothing
            cbTripleChocolateAddPecans.Checked = False
            lblAddedToOrderTripleChocolateCookies.Text = "Removed!"

        End If

        Session("tripleChocolateCookiesCount") = tbCountTripleChocolate.Text.Trim
        Session("tripleChocolateCookiesAddPecansChecked") = cbTripleChocolateAddPecans.Checked.ToString()

    End Sub

    Protected Sub btnOrderLemonDrop_Click(sender As Object, e As EventArgs)
        lblAddedToOrderLemonDropCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountLemonDrop.Text.Trim) AndAlso Convert.ToInt32(tbCountLemonDrop.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderLemonDropCookies.Visible = True
            phLemonDropCookies.Visible = True

            If cbLemonDropAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountLemonDrop.Text.Trim) = 1 Then
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozens with pecans"
                End If
                lblPriceForLemonDropCookies.Text = "$" + (Convert.ToInt32(tbCountLemonDrop.Text.Trim) * (Constants.LemonDropCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountLemonDrop.Text.Trim) = 1 Then
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozen"
                Else
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozens"
                End If
                lblPriceForLemonDropCookies.Text = "$" + (Convert.ToInt32(tbCountLemonDrop.Text.Trim) * Constants.LemonDropCookiesPrice).ToString()
            End If



        Else
            phLemonDropCookies.Visible = False
            lblOrderTotalLemonDropCookies.Text = Nothing
            lblPriceForLemonDropCookies.Text = Nothing
            cbLemonDropAddPecans.Checked = False
            lblAddedToOrderLemonDropCookies.Text = "Removed!"

        End If

        Session("lemonDropCookiesCount") = tbCountLemonDrop.Text.Trim
        Session("lemonDropCookiesAddPecansChecked") = cbLemonDropAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderOatmealChocolateChunk_Click(sender As Object, e As EventArgs)
        lblAddedToOrderOatmealChocolateChunkCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountOatmealChocolateChunk.Text.Trim) AndAlso Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderOatmealChocolateChunkCookies.Visible = True
            phOatmealChocolateChunkCookies.Visible = True

            If cbOatmealChocolateChunkAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) = 1 Then
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozens with pecans"
                End If
                lblPriceForOatmealChocolateChunkCookies.Text = "$" + (Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * (Constants.OatmealChocolateChunkCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) = 1 Then
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozen"
                Else
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozens"
                End If
                lblPriceForOatmealChocolateChunkCookies.Text = "$" + (Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * Constants.OatmealChocolateChunkCookiesPrice).ToString()
            End If

        Else
            phOatmealChocolateChunkCookies.Visible = False
            lblOrderTotalOatmealChocolateChunkCookies.Text = Nothing
            lblPriceForOatmealChocolateChunkCookies.Text = Nothing
            cbOatmealChocolateChunkAddPecans.Checked = False
            lblAddedToOrderOatmealChocolateChunkCookies.Text = "Removed!"

        End If

        Session("oatmealChocolateChunkCookiesCount") = tbCountOatmealChocolateChunk.Text.Trim
        Session("oatmealChocolateChunkCookiesAddPecansChecked") = cbOatmealChocolateChunkAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderOatmeal_Click(sender As Object, e As EventArgs)
        lblAddedToOrderOatmealCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountOatmeal.Text.Trim) AndAlso Convert.ToInt32(tbCountOatmeal.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderOatmealCookies.Visible = True
            phOatmealCookies.Visible = True

            If cbOatmealAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountOatmeal.Text.Trim) = 1 Then
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozens with pecans"
                End If
                lblPriceForOatmealCookies.Text = "$" + (Convert.ToInt32(tbCountOatmeal.Text.Trim) * (Constants.OatmealCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountOatmeal.Text.Trim) = 1 Then
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozen"
                Else
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozens"
                End If
                lblPriceForOatmealCookies.Text = "$" + (Convert.ToInt32(tbCountOatmeal.Text.Trim) * Constants.OatmealCookiesPrice).ToString()
            End If

        Else
            phOatmealCookies.Visible = False
            lblOrderTotalOatmealCookies.Text = Nothing
            lblPriceForOatmealCookies.Text = Nothing
            cbOatmealAddPecans.Checked = False
            lblAddedToOrderOatmealCookies.Text = "Removed!"

        End If

        Session("oatmealCookiesCount") = tbCountOatmeal.Text.Trim
        Session("oatmealCookiesAddPecansChecked") = cbOatmealAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderPeanutButterChocolateChip_Click(sender As Object, e As EventArgs)
        lblAddedToOrderPeanutButterChocolateChipCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountPeanutButterChocolateChip.Text.Trim) AndAlso Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderPeanutButterChocolateChipCookies.Visible = True
            phPeanutButterChocolateChipCookies.Visible = True

            If cbPeanutButterChocolateChipAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozens with pecans"
                End If
                lblPriceForPeanutButterChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * (Constants.PeanutButterChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozen"
                Else
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozens"
                End If
                lblPriceForPeanutButterChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * Constants.PeanutButterChocolateChipCookiesPrice).ToString()
            End If

        Else
            phPeanutButterChocolateChipCookies.Visible = False
            lblOrderTotalPeanutButterChocolateChipCookies.Text = Nothing
            lblPriceForPeanutButterChocolateChipCookies.Text = Nothing
            cbPeanutButterChocolateChipAddPecans.Checked = False
            lblAddedToOrderPeanutButterChocolateChipCookies.Text = "Removed!"

        End If

        Session("peanutButterChocolateChipCookiesCount") = tbCountPeanutButterChocolateChip.Text.Trim
        Session("peanutButterChocolateChipCookiesAddPecansChecked") = cbPeanutButterChocolateChipAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderPeanutButterMaple_Click(sender As Object, e As EventArgs)
        lblAddedToOrderPeanutButterMapleCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountPeanutButterMaple.Text.Trim) AndAlso Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderPeanutButterMapleCookies.Visible = True
            phPeanutButterMapleCookies.Visible = True

            If cbPeanutButterMapleAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozens with pecans"
                End If
                lblPriceForPeanutButterMapleCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * (Constants.PeanutButterMapleCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozen"
                Else
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozens"
                End If
                lblPriceForPeanutButterMapleCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * Constants.PeanutButterMapleCookiesPrice).ToString()
            End If

        Else
            phPeanutButterMapleCookies.Visible = False
            lblOrderTotalPeanutButterMapleCookies.Text = Nothing
            lblPriceForPeanutButterMapleCookies.Text = Nothing
            cbPeanutButterMapleAddPecans.Checked = False
            lblAddedToOrderPeanutButterMapleCookies.Text = "Removed!"

        End If

        Session("peanutButterMapleCookiesCount") = tbCountPeanutButterMaple.Text.Trim
        Session("peanutButterMapleCookiesAddPecansChecked") = cbPeanutButterMapleAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderVanillaBeanSugar_Click(sender As Object, e As EventArgs)
        lblAddedToOrderVanillaBeanSugarCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountVanillaBeanSugar.Text.Trim) AndAlso Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderVanillaBeanSugarCookies.Visible = True
            phVanillaBeanSugarCookies.Visible = True

            If cbVanillaBeanSugarAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) = 1 Then
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozens with pecans"
                End If
                lblPriceForVanillaBeanSugarCookies.Text = "$" + (Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * (Constants.VanillaBeanSugarCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) = 1 Then
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozen"
                Else
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozens"
                End If
                lblPriceForVanillaBeanSugarCookies.Text = "$" + (Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * Constants.VanillaBeanSugarCookiesPrice).ToString()
            End If

        Else
            phVanillaBeanSugarCookies.Visible = False
            lblOrderTotalVanillaBeanSugarCookies.Text = Nothing
            lblPriceForVanillaBeanSugarCookies.Text = Nothing
            cbVanillaBeanSugarAddPecans.Checked = False
            lblAddedToOrderVanillaBeanSugarCookies.Text = "Removed!"

        End If

        Session("vanillaBeanSugarCookiesCount") = tbCountVanillaBeanSugar.Text.Trim
        Session("vanillaBeanSugarCookiesAddPecansChecked") = cbVanillaBeanSugarAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderWhiteChocolateMacadamiaCranberry_Click(sender As Object, e As EventArgs)
        lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) AndAlso Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Visible = True
            phWhiteChocolateMacadamiaCranberryCookies.Visible = True

            If cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozens with pecans"
                End If
                lblPriceForWhiteChocolateMacadamiaCranberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * (Constants.WhiteChocolateMacadamiaCranberryCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozen"
                Else
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozens"
                End If
                lblPriceForWhiteChocolateMacadamiaCranberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * Constants.WhiteChocolateMacadamiaCranberryCookiesPrice).ToString()
            End If

        Else
            phWhiteChocolateMacadamiaCranberryCookies.Visible = False
            lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = Nothing
            lblPriceForWhiteChocolateMacadamiaCranberryCookies.Text = Nothing
            cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = False
            lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Text = "Removed!"

        End If

        Session("whiteChocolateMacadamiaCranberryCookiesCount") = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim
        Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked") = cbWhiteChocolateMacadamiaCranberryAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderWhiteChocolateRaspberry_Click(sender As Object, e As EventArgs)
        lblAddedToOrderWhiteChocolateRaspberryCookies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountWhiteChocolateRaspberry.Text.Trim) AndAlso Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderWhiteChocolateRaspberryCookies.Visible = True
            phWhiteChocolateRaspberryCookies.Visible = True

            If cbWhiteChocolateRaspberryAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozens with pecans"
                End If
                lblPriceForWhiteChocolateRaspberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * (Constants.WhiteChocolateRaspberryCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozen"
                Else
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozens"
                End If
                lblPriceForWhiteChocolateRaspberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * Constants.WhiteChocolateRaspberryCookiesPrice).ToString()
            End If

        Else
            phWhiteChocolateRaspberryCookies.Visible = False
            lblOrderTotalWhiteChocolateRaspberryCookies.Text = Nothing
            lblPriceForWhiteChocolateRaspberryCookies.Text = Nothing
            cbWhiteChocolateRaspberryAddPecans.Checked = False
            lblAddedToOrderWhiteChocolateRaspberryCookies.Text = "Removed!"

        End If

        Session("whiteChocolateRaspberryCookiesCount") = tbCountWhiteChocolateRaspberry.Text.Trim
        Session("whiteChocolateRaspberryCookiesAddPecansChecked") = cbWhiteChocolateRaspberryAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderTexasSheetCake_Click(sender As Object, e As EventArgs)

        lblAddedToOrderTexasSheetCake.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountTexasSheetCake.Text.Trim) AndAlso Convert.ToInt32(tbCountTexasSheetCake.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderTexasSheetCake.Visible = True
            phTexasSheetCake.Visible = True



            If Convert.ToInt32(tbCountTexasSheetCake.Text.Trim) = 1 Then
                lblOrderTotalTexasSheetCake.Text = tbCountTexasSheetCake.Text.Trim + " sheet"
            Else
                lblOrderTotalTexasSheetCake.Text = tbCountTexasSheetCake.Text.Trim + " sheets"
            End If
            lblPriceForTexasSheetCake.Text = "$" + (Convert.ToInt32(tbCountTexasSheetCake.Text.Trim) * Constants.TexasSheetCakePrice).ToString()

        Else
            phTexasSheetCake.Visible = False
            lblOrderTotalTexasSheetCake.Text = Nothing
            lblPriceForTexasSheetCake.Text = Nothing

            lblAddedToOrderTexasSheetCake.Text = "Removed!"

        End If

        Session("texasSheetCakeCount") = tbCountTexasSheetCake.Text.Trim


    End Sub

    Protected Sub btnOrderChocolateFudgeBrownie_Click(sender As Object, e As EventArgs)
        lblAddedToOrderChocolateFudgeBrownie.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountChocolateFudgeBrownie.Text.Trim) AndAlso Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderChocolateFudgeBrownie.Visible = True
            phChocolateFudgeBrownie.Visible = True

            If cbChocolateFudgeBrownieAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) = 1 Then
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheet with pecans"
                Else
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheets with pecans"
                End If
                lblPriceForChocolateFudgeBrownie.Text = "$" + (Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * (Constants.ChocolateFudgeBrowniesPrice + Constants.AddPecansForChocolateFudgeBrowniesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) = 1 Then
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheet"
                Else
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheets"
                End If
                lblPriceForChocolateFudgeBrownie.Text = "$" + (Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * Constants.ChocolateFudgeBrowniesPrice).ToString()
            End If

        Else
            phChocolateFudgeBrownie.Visible = False
            lblOrderTotalChocolateFudgeBrownie.Text = Nothing
            lblPriceForChocolateFudgeBrownie.Text = Nothing
            cbChocolateFudgeBrownieAddPecans.Checked = False
            lblAddedToOrderChocolateFudgeBrownie.Text = "Removed!"

        End If

        Session("chocolateFudgeBrownieCount") = tbCountChocolateFudgeBrownie.Text.Trim
        Session("chocolateFudgeBrownieAddPecansChecked") = cbChocolateFudgeBrownieAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnOrderChocolateCaramelPecanBrownies_Click(sender As Object, e As EventArgs)

        lblAddedToOrderChocolateCaramelPecanBrownies.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountChocolateCaramelPecanBrownies.Text.Trim) AndAlso Convert.ToInt32(tbCountChocolateCaramelPecanBrownies.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderChocolateCaramelPecanBrownies.Visible = True
            phChocolateCaramelPecanBrownies.Visible = True


            If Convert.ToInt32(tbCountChocolateCaramelPecanBrownies.Text.Trim) = 1 Then
                lblOrderTotalChocolateCaramelPecanBrownies.Text = tbCountChocolateCaramelPecanBrownies.Text.Trim + " sheet"
            Else
                lblOrderTotalChocolateCaramelPecanBrownies.Text = tbCountChocolateCaramelPecanBrownies.Text.Trim + " sheets"
            End If

            lblPriceForChocolateCaramelPecanBrownies.Text = "$" + (Convert.ToInt32(tbCountChocolateCaramelPecanBrownies.Text.Trim) * Constants.ChocolateCaramelPecanBrowniesPrice).ToString()

        Else
            phChocolateCaramelPecanBrownies.Visible = False
            lblOrderTotalChocolateCaramelPecanBrownies.Text = Nothing
            lblPriceForChocolateCaramelPecanBrownies.Text = Nothing

            lblAddedToOrderChocolateCaramelPecanBrownies.Text = "Removed!"

        End If

        Session("chocolateCaramelPecanBrowniesCount") = tbCountChocolateCaramelPecanBrownies.Text.Trim


    End Sub

    Protected Sub btnOrderMillionDollarFudge_Click(sender As Object, e As EventArgs)

        lblAddedToOrderMillionDollarFudge.Text = "Added! Scroll down for order details."
        If Not String.IsNullOrEmpty(tbCountMillionDollarFudge.Text.Trim) AndAlso Convert.ToInt32(tbCountMillionDollarFudge.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderMillionDollarFudge.Visible = True
            phMillionDollarFudge.Visible = True


            If Convert.ToInt32(tbCountMillionDollarFudge.Text.Trim) = 1 Then
                lblOrderTotalMillionDollarFudge.Text = tbCountMillionDollarFudge.Text.Trim + " sheet"
            Else
                lblOrderTotalMillionDollarFudge.Text = tbCountMillionDollarFudge.Text.Trim + " sheets"
            End If

            lblPriceForMillionDollarFudge.Text = "$" + (Convert.ToInt32(tbCountMillionDollarFudge.Text.Trim) * Constants.MillionDollarFudgePrice).ToString()

        Else
            phMillionDollarFudge.Visible = False
            lblOrderTotalMillionDollarFudge.Text = Nothing
            lblPriceForMillionDollarFudge.Text = Nothing

            lblAddedToOrderMillionDollarFudge.Text = "Removed!"

        End If

        Session("millionDollarFudgeCount") = tbCountMillionDollarFudge.Text.Trim



    End Sub

    Protected Sub btnPlaceOrder_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/PlaceOrder.aspx")
    End Sub

    Protected Sub cbBubbleGumAddPecans_CheckedChanged(sender As Object, e As EventArgs)

        If cbBubbleGumAddPecans.Checked = True Then
            lblAddedIntoOrderBubbleGumCookies.Text = "Added pecans"
        Else
            lblAddedIntoOrderBubbleGumCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountBubbleGum.Text.Trim) AndAlso Convert.ToInt32(tbCountBubbleGum.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedIntoOrderBubbleGumCookies.Visible = True
            phBubbleGumCookies.Visible = True
            If cbBubbleGumAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountBubbleGum.Text.Trim) = 1 Then
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozens with pecans"
                End If
                lblPriceForBubbleGumCookies.Text = "$" + (Convert.ToInt32(tbCountBubbleGum.Text.Trim) * (Constants.BubbleGumCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountBubbleGum.Text.Trim) = 1 Then
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozen"
                Else
                    lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text.Trim + " dozens"
                End If

                lblPriceForBubbleGumCookies.Text = "$" + (Convert.ToInt32(tbCountBubbleGum.Text.Trim) * Constants.BubbleGumCookiesPrice).ToString()
            End If


        Else
            phBubbleGumCookies.Visible = False
            lblOrderTotalBubbleGumCookies.Text = Nothing
            lblPriceForBubbleGumCookies.Text = Nothing
            cbBubbleGumAddPecans.Checked = False
            lblAddedIntoOrderBubbleGumCookies.Text = "Removed!"

        End If

        'Session("lblOrderTotalBubbleGumCookies") = lblOrderTotalBubbleGumCookies.Text
        Session("bubbleGumCookiesCount") = tbCountBubbleGum.Text.Trim
        Session("bubbleGumCookiesAddPecansChecked") = cbBubbleGumAddPecans.Checked.ToString()

        'If Not String.IsNullOrEmpty(tbCountBubbleGum.Text.Trim) AndAlso Convert.ToInt32(tbCountBubbleGum.Text.Trim) > 0 Then
        '    phNothingOrdered.Visible = False
        '    lblAddedIntoOrderBubbleGumCookies.Visible = True
        '    phBubbleGumCookies.Visible = True
        '    phTotalPrice.Visible = True
        '    If Convert.ToInt32(tbCountBubbleGum.Text) = 1 Then
        '        lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text + " dozen"
        '    Else
        '        lblOrderTotalBubbleGumCookies.Text = tbCountBubbleGum.Text + " dozens"
        '    End If
        '    lblPriceForBubbleGumCookies.Text = "$" + (Convert.ToInt32(tbCountBubbleGum.Text.Trim) * Constants.BubbleGumCookiesPrice).ToString()
        'Else
        '    phBubbleGumCookies.Visible = False
        '    lblOrderTotalBubbleGumCookies.Text = Nothing
        '    lblPriceForBubbleGumCookies.Text = Nothing
        '    cbBubbleGumAddPecans.Checked = False
        '    lblAddedIntoOrderBubbleGumCookies.Text = "Removed!"

        'End If
    End Sub

    Protected Sub cbChocolateChipAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbChocolateChipAddPecans.Checked = True Then
            lblAddedToOrderChocolateChipCookies.Text = "Added pecans"
        Else
            lblAddedToOrderChocolateChipCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountChocolateChip.Text.Trim) AndAlso Convert.ToInt32(tbCountChocolateChip.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderChocolateChipCookies.Visible = True
            phChocolateChipCookies.Visible = True

            If cbChocolateChipAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozens with pecans"
                End If
                lblPriceForChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountChocolateChip.Text.Trim) * (Constants.ChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozen"
                Else
                    lblOrderTotalChocolateChipCookies.Text = tbCountChocolateChip.Text.Trim + " dozens"
                End If
                lblPriceForChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountChocolateChip.Text.Trim) * Constants.ChocolateChipCookiesPrice).ToString()
            End If



        Else
            phChocolateChipCookies.Visible = False
            lblOrderTotalChocolateChipCookies.Text = Nothing
            lblPriceForChocolateChipCookies.Text = Nothing
            cbChocolateChipAddPecans.Checked = False
            lblAddedToOrderChocolateChipCookies.Text = "Removed!"
        End If

        Session("chocolateChipCookiesCount") = tbCountChocolateChip.Text.Trim
        Session("chocolateChipCookiesAddPecansChecked") = cbChocolateChipAddPecans.Checked.ToString()

    End Sub

    Protected Sub cbDoubleChocolateAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbDoubleChocolateAddPecans.Checked = True Then
            lblAddedToOrderDoubleChocolateCookies.Text = "Added pecans"
        Else
            lblAddedToOrderDoubleChocolateCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountDoubleChocolate.Text.Trim) AndAlso Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderDoubleChocolateCookies.Visible = True
            phDoubleChocolateCookies.Visible = True

            If cbDoubleChocolateAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozens with pecans"
                End If
                lblPriceForDoubleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * (Constants.DoubleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozen"
                Else
                    lblOrderTotalDoubleChocolateCookies.Text = tbCountDoubleChocolate.Text.Trim + " dozens"
                End If
                lblPriceForDoubleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountDoubleChocolate.Text.Trim) * Constants.DoubleChocolateCookiesPrice).ToString()
            End If



        Else
            phDoubleChocolateCookies.Visible = False
            lblOrderTotalDoubleChocolateCookies.Text = Nothing
            lblPriceForDoubleChocolateCookies.Text = Nothing
            cbDoubleChocolateAddPecans.Checked = False
            lblAddedToOrderDoubleChocolateCookies.Text = "Removed!"
        End If

        Session("doubleChocolateCookiesCount") = tbCountDoubleChocolate.Text.Trim
        Session("doubleChocolateCookiesAddPecansChecked") = cbDoubleChocolateAddPecans.Checked.ToString()
    End Sub

    Protected Sub cbTripleChocolateAddPecans_CheckedChanged(sender As Object, e As EventArgs)

        If cbTripleChocolateAddPecans.Checked = True Then
            lblAddedToOrderTripleChocolateCookies.Text = "Added pecans"
        Else
            lblAddedToOrderTripleChocolateCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountTripleChocolate.Text.Trim) AndAlso Convert.ToInt32(tbCountTripleChocolate.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderTripleChocolateCookies.Visible = True
            phTripleChocolateCookies.Visible = True

            If cbTripleChocolateAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountTripleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozens with pecans"
                End If
                lblPriceForTripleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * (Constants.TripleChocolateCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountTripleChocolate.Text.Trim) = 1 Then
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozen"
                Else
                    lblOrderTotalTripleChocolateCookies.Text = tbCountTripleChocolate.Text.Trim + " dozens"
                End If
                lblPriceForTripleChocolateCookies.Text = "$" + (Convert.ToInt32(tbCountTripleChocolate.Text.Trim) * Constants.TripleChocolateCookiesPrice).ToString()
            End If



        Else
            phTripleChocolateCookies.Visible = False
            lblOrderTotalTripleChocolateCookies.Text = Nothing
            lblPriceForTripleChocolateCookies.Text = Nothing
            cbTripleChocolateAddPecans.Checked = False
            lblAddedToOrderTripleChocolateCookies.Text = "Removed!"
        End If

        Session("tripleChocolateCookiesCount") = tbCountTripleChocolate.Text.Trim
        Session("tripleChocolateCookiesAddPecansChecked") = cbTripleChocolateAddPecans.Checked.ToString()

    End Sub

    Protected Sub cbLemonDropAddPecans_CheckedChanged(sender As Object, e As EventArgs)

        If cbLemonDropAddPecans.Checked = True Then
            lblAddedToOrderLemonDropCookies.Text = "Added pecans"
        Else
            lblAddedToOrderLemonDropCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountLemonDrop.Text.Trim) AndAlso Convert.ToInt32(tbCountLemonDrop.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderLemonDropCookies.Visible = True
            phLemonDropCookies.Visible = True

            If cbLemonDropAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountLemonDrop.Text.Trim) = 1 Then
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozens with pecans"
                End If
                lblPriceForLemonDropCookies.Text = "$" + (Convert.ToInt32(tbCountLemonDrop.Text.Trim) * (Constants.LemonDropCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountLemonDrop.Text.Trim) = 1 Then
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozen"
                Else
                    lblOrderTotalLemonDropCookies.Text = tbCountLemonDrop.Text.Trim + " dozens"
                End If
                lblPriceForLemonDropCookies.Text = "$" + (Convert.ToInt32(tbCountLemonDrop.Text.Trim) * Constants.LemonDropCookiesPrice).ToString()
            End If



        Else
            phLemonDropCookies.Visible = False
            lblOrderTotalLemonDropCookies.Text = Nothing
            lblPriceForLemonDropCookies.Text = Nothing
            cbLemonDropAddPecans.Checked = False
            lblAddedToOrderLemonDropCookies.Text = "Removed!"
        End If

        Session("lemonDropCookiesCount") = tbCountLemonDrop.Text.Trim
        Session("lemonDropCookiesAddPecansChecked") = cbLemonDropAddPecans.Checked.ToString()

    End Sub

    Protected Sub cbOatmealChocolateChunkAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbOatmealChocolateChunkAddPecans.Checked = True Then
            lblAddedToOrderOatmealChocolateChunkCookies.Text = "Added pecans"
        Else
            lblAddedToOrderOatmealChocolateChunkCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountOatmealChocolateChunk.Text.Trim) AndAlso Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderOatmealChocolateChunkCookies.Visible = True
            phOatmealChocolateChunkCookies.Visible = True

            If cbOatmealChocolateChunkAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) = 1 Then
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozens with pecans"
                End If
                lblPriceForOatmealChocolateChunkCookies.Text = "$" + (Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * (Constants.OatmealChocolateChunkCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) = 1 Then
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozen"
                Else
                    lblOrderTotalOatmealChocolateChunkCookies.Text = tbCountOatmealChocolateChunk.Text.Trim + " dozens"
                End If
                lblPriceForOatmealChocolateChunkCookies.Text = "$" + (Convert.ToInt32(tbCountOatmealChocolateChunk.Text.Trim) * Constants.OatmealChocolateChunkCookiesPrice).ToString()
            End If



        Else
            phOatmealChocolateChunkCookies.Visible = False
            lblOrderTotalOatmealChocolateChunkCookies.Text = Nothing
            lblPriceForOatmealChocolateChunkCookies.Text = Nothing
            cbOatmealChocolateChunkAddPecans.Checked = False
            lblAddedToOrderOatmealChocolateChunkCookies.Text = "Removed!"
        End If

        Session("oatmealChocolateChunkCookiesCount") = tbCountOatmealChocolateChunk.Text.Trim
        Session("oatmealChocolateChunkCookiesAddPecansChecked") = cbOatmealChocolateChunkAddPecans.Checked.ToString()
    End Sub

    Protected Sub cbOatmealAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbOatmealAddPecans.Checked = True Then
            lblAddedToOrderOatmealCookies.Text = "Added pecans"
        Else
            lblAddedToOrderOatmealCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountOatmeal.Text.Trim) AndAlso Convert.ToInt32(tbCountOatmeal.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderOatmealCookies.Visible = True
            phOatmealCookies.Visible = True

            If cbOatmealAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountOatmeal.Text.Trim) = 1 Then
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozens with pecans"
                End If
                lblPriceForOatmealCookies.Text = "$" + (Convert.ToInt32(tbCountOatmeal.Text.Trim) * (Constants.OatmealCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountOatmeal.Text.Trim) = 1 Then
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozen"
                Else
                    lblOrderTotalOatmealCookies.Text = tbCountOatmeal.Text.Trim + " dozens"
                End If
                lblPriceForOatmealCookies.Text = "$" + (Convert.ToInt32(tbCountOatmeal.Text.Trim) * Constants.OatmealCookiesPrice).ToString()
            End If



        Else
            phOatmealCookies.Visible = False
            lblOrderTotalOatmealCookies.Text = Nothing
            lblPriceForOatmealCookies.Text = Nothing
            cbOatmealAddPecans.Checked = False
            lblAddedToOrderOatmealCookies.Text = "Removed!"
        End If

        Session("oatmealCookiesCount") = tbCountOatmeal.Text.Trim
        Session("oatmealCookiesAddPecansChecked") = cbOatmealAddPecans.Checked.ToString()
    End Sub

    Protected Sub cbPeanutButterChocolateChipAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbPeanutButterChocolateChipAddPecans.Checked = True Then
            lblAddedToOrderPeanutButterChocolateChipCookies.Text = "Added pecans"
        Else
            lblAddedToOrderPeanutButterChocolateChipCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountPeanutButterChocolateChip.Text.Trim) AndAlso Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderPeanutButterChocolateChipCookies.Visible = True
            phPeanutButterChocolateChipCookies.Visible = True

            If cbPeanutButterChocolateChipAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozens with pecans"
                End If
                lblPriceForPeanutButterChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * (Constants.PeanutButterChocolateChipCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozen"
                Else
                    lblOrderTotalPeanutButterChocolateChipCookies.Text = tbCountPeanutButterChocolateChip.Text.Trim + " dozens"
                End If
                lblPriceForPeanutButterChocolateChipCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterChocolateChip.Text.Trim) * Constants.PeanutButterChocolateChipCookiesPrice).ToString()
            End If



        Else
            phPeanutButterChocolateChipCookies.Visible = False
            lblOrderTotalPeanutButterChocolateChipCookies.Text = Nothing
            lblPriceForPeanutButterChocolateChipCookies.Text = Nothing
            cbPeanutButterChocolateChipAddPecans.Checked = False
            lblAddedToOrderPeanutButterChocolateChipCookies.Text = "Removed!"
        End If

        Session("peanutButterChocolateChipCookiesCount") = tbCountPeanutButterChocolateChip.Text.Trim
        Session("peanutButterChocolateChipCookiesAddPecansChecked") = cbPeanutButterChocolateChipAddPecans.Checked.ToString()
    End Sub

    Protected Sub cbPeanutButterMapleAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbPeanutButterMapleAddPecans.Checked = True Then
            lblAddedToOrderPeanutButterMapleCookies.Text = "Added pecans"
        Else
            lblAddedToOrderPeanutButterMapleCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountPeanutButterMaple.Text.Trim) AndAlso Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderPeanutButterMapleCookies.Visible = True
            phPeanutButterMapleCookies.Visible = True

            If cbPeanutButterMapleAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozens with pecans"
                End If
                lblPriceForPeanutButterMapleCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * (Constants.PeanutButterMapleCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) = 1 Then
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozen"
                Else
                    lblOrderTotalPeanutButterMapleCookies.Text = tbCountPeanutButterMaple.Text.Trim + " dozens"
                End If
                lblPriceForPeanutButterMapleCookies.Text = "$" + (Convert.ToInt32(tbCountPeanutButterMaple.Text.Trim) * Constants.PeanutButterMapleCookiesPrice).ToString()
            End If



        Else
            phPeanutButterMapleCookies.Visible = False
            lblOrderTotalPeanutButterMapleCookies.Text = Nothing
            lblPriceForPeanutButterMapleCookies.Text = Nothing
            cbPeanutButterMapleAddPecans.Checked = False
            lblAddedToOrderPeanutButterMapleCookies.Text = "Removed!"
        End If

        Session("peanutButterMapleCookiesCount") = tbCountPeanutButterMaple.Text.Trim
        Session("peanutButterMapleCookiesAddPecansChecked") = cbPeanutButterMapleAddPecans.Checked.ToString()
    End Sub

    Protected Sub cbVanillaBeanSugarAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbVanillaBeanSugarAddPecans.Checked = True Then
            lblAddedToOrderVanillaBeanSugarCookies.Text = "Added pecans"
        Else
            lblAddedToOrderVanillaBeanSugarCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountVanillaBeanSugar.Text.Trim) AndAlso Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderVanillaBeanSugarCookies.Visible = True
            phVanillaBeanSugarCookies.Visible = True

            If cbVanillaBeanSugarAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) = 1 Then
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozens with pecans"
                End If
                lblPriceForVanillaBeanSugarCookies.Text = "$" + (Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * (Constants.VanillaBeanSugarCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) = 1 Then
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozen"
                Else
                    lblOrderTotalVanillaBeanSugarCookies.Text = tbCountVanillaBeanSugar.Text.Trim + " dozens"
                End If
                lblPriceForVanillaBeanSugarCookies.Text = "$" + (Convert.ToInt32(tbCountVanillaBeanSugar.Text.Trim) * Constants.VanillaBeanSugarCookiesPrice).ToString()
            End If



        Else
            phVanillaBeanSugarCookies.Visible = False
            lblOrderTotalVanillaBeanSugarCookies.Text = Nothing
            lblPriceForVanillaBeanSugarCookies.Text = Nothing
            cbVanillaBeanSugarAddPecans.Checked = False
            lblAddedToOrderVanillaBeanSugarCookies.Text = "Removed!"
        End If

        Session("vanillaBeanSugarCookiesCount") = tbCountVanillaBeanSugar.Text.Trim
        Session("vanillaBeanSugarCookiesAddPecansChecked") = cbVanillaBeanSugarAddPecans.Checked.ToString()
    End Sub

    Protected Sub cbWhiteChocolateMacadamiaCranberryAddPecans_CheckedChanged(sender As Object, e As EventArgs)

        If cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = True Then
            lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Text = "Added pecans"
        Else
            lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) AndAlso Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Visible = True
            phWhiteChocolateMacadamiaCranberryCookies.Visible = True

            If cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozens with pecans"
                End If
                lblPriceForWhiteChocolateMacadamiaCranberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * (Constants.WhiteChocolateMacadamiaCranberryCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozen"
                Else
                    lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim + " dozens"
                End If
                lblPriceForWhiteChocolateMacadamiaCranberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateMacadamiaCranberry.Text.Trim) * Constants.WhiteChocolateMacadamiaCranberryCookiesPrice).ToString()
            End If



        Else
            phWhiteChocolateMacadamiaCranberryCookies.Visible = False
            lblOrderTotalWhiteChocolateMacadamiaCranberryCookies.Text = Nothing
            lblPriceForWhiteChocolateMacadamiaCranberryCookies.Text = Nothing
            cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = False
            lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies.Text = "Removed!"
        End If

        Session("whiteChocolateMacadamiaCranberryCookiesCount") = tbCountWhiteChocolateMacadamiaCranberry.Text.Trim
        Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked") = cbWhiteChocolateMacadamiaCranberryAddPecans.Checked.ToString()

    End Sub

    Protected Sub cbWhiteChocolateRaspberryAddPecans_CheckedChanged(sender As Object, e As EventArgs)

        If cbWhiteChocolateRaspberryAddPecans.Checked = True Then
            lblAddedToOrderWhiteChocolateRaspberryCookies.Text = "Added pecans"
        Else
            lblAddedToOrderWhiteChocolateRaspberryCookies.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountWhiteChocolateRaspberry.Text.Trim) AndAlso Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderWhiteChocolateRaspberryCookies.Visible = True
            phWhiteChocolateRaspberryCookies.Visible = True

            If cbWhiteChocolateRaspberryAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozen with pecans"
                Else
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozens with pecans"
                End If
                lblPriceForWhiteChocolateRaspberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * (Constants.WhiteChocolateRaspberryCookiesPrice + Constants.AddPecansForCookiesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) = 1 Then
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozen"
                Else
                    lblOrderTotalWhiteChocolateRaspberryCookies.Text = tbCountWhiteChocolateRaspberry.Text.Trim + " dozens"
                End If
                lblPriceForWhiteChocolateRaspberryCookies.Text = "$" + (Convert.ToInt32(tbCountWhiteChocolateRaspberry.Text.Trim) * Constants.WhiteChocolateRaspberryCookiesPrice).ToString()
            End If



        Else
            phWhiteChocolateRaspberryCookies.Visible = False
            lblOrderTotalWhiteChocolateRaspberryCookies.Text = Nothing
            lblPriceForWhiteChocolateRaspberryCookies.Text = Nothing
            cbWhiteChocolateRaspberryAddPecans.Checked = False
            lblAddedToOrderWhiteChocolateRaspberryCookies.Text = "Removed!"
        End If

        Session("whiteChocolateRaspberryCookiesCount") = tbCountWhiteChocolateRaspberry.Text.Trim
        Session("whiteChocolateRaspberryCookiesAddPecansChecked") = cbWhiteChocolateRaspberryAddPecans.Checked.ToString()

    End Sub

    Protected Sub cbChocolateFudgeBrownieAddPecans_CheckedChanged(sender As Object, e As EventArgs)
        If cbChocolateFudgeBrownieAddPecans.Checked = True Then
            lblAddedToOrderChocolateFudgeBrownie.Text = "Added pecans"
        Else
            lblAddedToOrderChocolateFudgeBrownie.Text = "Removed pecans"
        End If

        If Not String.IsNullOrEmpty(tbCountChocolateFudgeBrownie.Text.Trim) AndAlso Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) > 0 Then
            phNothingOrdered.Visible = False
            lblAddedToOrderChocolateFudgeBrownie.Visible = True
            phChocolateFudgeBrownie.Visible = True

            If cbChocolateFudgeBrownieAddPecans.Checked = True Then
                If Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) = 1 Then
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheet with pecans"
                Else
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheets with pecans"
                End If
                lblPriceForChocolateFudgeBrownie.Text = "$" + (Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * (Constants.ChocolateFudgeBrowniesPrice + Constants.AddPecansForChocolateFudgeBrowniesPrice)).ToString()
            Else
                If Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) = 1 Then
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheet"
                Else
                    lblOrderTotalChocolateFudgeBrownie.Text = tbCountChocolateFudgeBrownie.Text.Trim + " sheets"
                End If
                lblPriceForChocolateFudgeBrownie.Text = "$" + (Convert.ToInt32(tbCountChocolateFudgeBrownie.Text.Trim) * Constants.ChocolateFudgeBrowniesPrice).ToString()
            End If



        Else
            phChocolateFudgeBrownie.Visible = False
            lblOrderTotalChocolateFudgeBrownie.Text = Nothing
            lblPriceForChocolateFudgeBrownie.Text = Nothing
            cbChocolateFudgeBrownieAddPecans.Checked = False
            lblAddedToOrderChocolateFudgeBrownie.Text = "Removed!"
        End If

        Session("chocolateFudgeBrownieCount") = tbCountChocolateFudgeBrownie.Text.Trim
        Session("chocolateFudgeBrownieAddPecansChecked") = cbChocolateFudgeBrownieAddPecans.Checked.ToString()
    End Sub

    Protected Sub btnDeleteBubbleGumCookiesFromOrder_Click(sender As Object, e As EventArgs)
        tbCountBubbleGum.Text = Nothing
        cbBubbleGumAddPecans.Checked = False
        Session("bubbleGumCookiesCount") = Nothing
        Session("bubbleGumCookiesAddPecansChecked") = Nothing
        Session("BubbleGumCookiesPriceTotal") = Nothing
        phBubbleGumCookies.Visible = False

        TotalPrice = TotalPrice - BubbleGumCookiesPriceTotal


        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If


    End Sub

    Protected Sub btnDeleteChocolateChipCookiesFromOrder_Click(sender As Object, e As EventArgs)
        tbCountChocolateChip.Text = Nothing
        cbChocolateChipAddPecans.Checked = False
        Session("chocolateChipCookiesCount") = Nothing
        Session("chocolateChipCookiesAddPecansChecked") = Nothing
        Session("ChocolateChipCookiesPriceTotal") = Nothing
        phChocolateChipCookies.Visible = False

        TotalPrice = TotalPrice - ChocolateChipCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteDoubleChocolateCookiesFromOrder_Click(sender As Object, e As EventArgs)
        tbCountDoubleChocolate.Text = Nothing
        cbDoubleChocolateAddPecans.Checked = False

        Session("doubleChocolateCookiesCount") = Nothing
        Session("doubleChocolateCookiesAddPecansChecked") = Nothing
        Session("DoubleChocolateCookiesPriceTotal") = Nothing
        phDoubleChocolateCookies.Visible = False

        TotalPrice = TotalPrice - DoubleChocolateCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If
    End Sub

    Protected Sub btnDeleteTripleChocolateCookiesFromOrder_Click(sender As Object, e As EventArgs)
        tbCountTripleChocolate.Text = Nothing
        cbTripleChocolateAddPecans.Checked = False

        Session("tripleChocolateCookiesCount") = Nothing
        Session("tripleChocolateCookiesAddPecansChecked") = Nothing
        Session("TripleChocolateCookiesPriceTotal") = Nothing

        phTripleChocolateCookies.Visible = False

        TotalPrice = TotalPrice - TripleChocolateCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If
    End Sub

    Protected Sub btnDeleteLemonDropCookiesFromOrder_Click(sender As Object, e As EventArgs)
        tbCountLemonDrop.Text = Nothing
        cbLemonDropAddPecans.Checked = False

        Session("lemonDropCookiesCount") = Nothing
        Session("lemonDropCookiesAddPecansChecked") = Nothing
        Session("LemonDropCookiesPriceTotal") = Nothing
        phLemonDropCookies.Visible = False

        TotalPrice = TotalPrice - LemonDropCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If
    End Sub

    Protected Sub btnDeleteOatmealChocolateChunkCookiesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountOatmealChocolateChunk.Text = Nothing
        cbOatmealChocolateChunkAddPecans.Checked = False

        Session("oatmealChocolateChunkCookiesCount") = Nothing
        Session("oatmealChocolateChunkCookiesAddPecansChecked") = Nothing
        Session("OatmealChocolateChunkCookiesPriceTotal") = Nothing
        phOatmealChocolateChunkCookies.Visible = False

        TotalPrice = TotalPrice - OatmealChocolateChunkCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If
    End Sub

    Protected Sub btnDeleteOatmealCookiesFromOrder_Click(sender As Object, e As EventArgs)
        tbCountOatmeal.Text = Nothing
        cbOatmealAddPecans.Checked = False

        Session("oatmealCookiesCount") = Nothing
        Session("oatmealCookiesAddPecansChecked") = Nothing
        Session("OatmealCookiesPriceTotal") = Nothing
        phOatmealCookies.Visible = False

        TotalPrice = TotalPrice - OatmealCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeletePeanutButterChocolateChipCookiesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountPeanutButterChocolateChip.Text = Nothing
        cbPeanutButterChocolateChipAddPecans.Checked = False

        Session("peanutButterChocolateChipCookiesCount") = Nothing
        Session("peanutButterChocolateChipCookiesAddPecansChecked") = Nothing
        Session("PeanutButterChocolateChipCookiesPriceTotal") = Nothing
        phPeanutButterChocolateChipCookies.Visible = False

        TotalPrice = TotalPrice - PeanutButterChocolateChipCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeletePeanutButterMapleCookiesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountPeanutButterMaple.Text = Nothing
        cbPeanutButterMapleAddPecans.Checked = False

        Session("peanutButterMapleCookiesCount") = Nothing
        Session("peanutButterMapleCookiesAddPecansChecked") = Nothing
        Session("PeanutButterMapleCookiesPriceTotal") = Nothing

        phPeanutButterMapleCookies.Visible = False

        TotalPrice = TotalPrice - PeanutButterMapleCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteVanillaBeanSugarCookiesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountVanillaBeanSugar.Text = Nothing
        cbVanillaBeanSugarAddPecans.Checked = False

        Session("vanillaBeanSugarCookiesCount") = Nothing
        Session("vanillaBeanSugarCookiesAddPecansChecked") = Nothing
        Session("VanillaBeanSugarCookiesPriceTotal") = Nothing
        phVanillaBeanSugarCookies.Visible = False

        TotalPrice = TotalPrice - VanillaBeanSugarCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteWhiteChocolateMacadamiaCranberryCookiesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountWhiteChocolateMacadamiaCranberry.Text = Nothing
        cbWhiteChocolateMacadamiaCranberryAddPecans.Checked = False

        Session("whiteChocolateMacadamiaCranberryCookiesCount") = Nothing
        Session("whiteChocolateMacadamiaCranberryCookiesAddPecansChecked") = Nothing
        Session("WhiteChocolateMacadamiaCranberryCookiesPriceTotal") = Nothing
        phWhiteChocolateMacadamiaCranberryCookies.Visible = False

        TotalPrice = TotalPrice - WhiteChocolateMacadamiaCranberryCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteWhiteChocolateRaspberryCookiesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountWhiteChocolateRaspberry.Text = Nothing
        cbWhiteChocolateRaspberryAddPecans.Checked = False

        Session("whiteChocolateRaspberryCookiesCount") = Nothing
        Session("whiteChocolateRaspberryCookiesAddPecansChecked") = Nothing
        Session("WhiteChocolateRaspberryCookiesPriceTotal") = Nothing
        phWhiteChocolateRaspberryCookies.Visible = False

        TotalPrice = TotalPrice - WhiteChocolateRaspberryCookiesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteTexasSheetCakeFromOrder_Click(sender As Object, e As EventArgs)

        tbCountTexasSheetCake.Text = Nothing

        Session("texasSheetCakeCount") = Nothing
        Session("TexasSheetCakePriceTotal") = Nothing
        phTexasSheetCake.Visible = False

        TotalPrice = TotalPrice - TexasSheetCakePriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteChocolateFudgeBrownieFromOrder_Click(sender As Object, e As EventArgs)

        tbCountChocolateFudgeBrownie.Text = Nothing
        cbChocolateFudgeBrownieAddPecans.Checked = False

        Session("chocolateFudgeBrownieCount") = Nothing
        Session("chocolateFudgeBrownieAddPecansChecked") = Nothing
        Session("ChocolateFudgeBrowniePriceTotal") = Nothing
        phChocolateFudgeBrownie.Visible = False

        TotalPrice = TotalPrice - ChocolateFudgeBrowniePriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteChocolateCaramelPecanBrowniesFromOrder_Click(sender As Object, e As EventArgs)

        tbCountChocolateCaramelPecanBrownies.Text = Nothing

        Session("chocolateCaramelPecanBrowniesCount") = Nothing
        Session("ChocolateCaramelPecanBrowniesPriceTotal") = Nothing
        phChocolateCaramelPecanBrownies.Visible = False

        TotalPrice = TotalPrice - ChocolateCaramelPecanBrowniesPriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub

    Protected Sub btnDeleteMillionDollarFudgeFromOrder_Click(sender As Object, e As EventArgs)

        tbCountMillionDollarFudge.Text = Nothing

        Session("millionDollarFudgeCount") = Nothing
        Session("MillionDollarFudgePriceTotal") = Nothing
        phMillionDollarFudge.Visible = False

        TotalPrice = TotalPrice - MillionDollarFudgePriceTotal

        If TotalPrice > 0 Then
            phTotalPrice.Visible = True
            lblTotalPrice.Text = "Total: $" + TotalPrice.ToString()
        Else
            phTotalPrice.Visible = False
            phNothingOrdered.Visible = True
        End If

    End Sub
End Class