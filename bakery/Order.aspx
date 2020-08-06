<%@ Page Title="Order" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Order.aspx.vb" Inherits="bakery.Order" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2 class="text-center headersFont"><%: Title %></h2>
    <br />
    <%--    <div class="row">
        <div class="col-md-12">
            <h3 class="text-center">Cookies</h3>
        </div>
    </div>--%>

    <div class="row">
        <div class="col-md-12">
            <div class="row">
                <div class="col-md-12">
                    <h3 class="text-center headersFont">Cookies</h3>
                </div>
            </div>
            <div class="row">
             
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Bubble Gum</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/bubble gum.jpg" alt="Bubble Gum cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel18" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblBubbleGumAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbBubbleGumAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbBubbleGumAddPecans_CheckedChanged" onclick="BubbleGumAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>

                                <asp:UpdatePanel ID="UpdatePanel31" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountBubbleGum">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountBubbleGum" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                            </asp:UpdatePanel>
                          
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderBubbleGum" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderBubbleGum_Click" OnClientClick="OrderBubbleGumCookies()" /><br />
                                    <asp:Label ID="lblAddedIntoOrderBubbleGumCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderBubbleGum" />
                                    <asp:AsyncPostBackTrigger ControlID="cbBubbleGumAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                         
                <div class="col-md-3 text-center">
                    <div class="card mb-3">

                        <h5 class="card-header text-center">Chocolate Chip</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Chocolate_Chip_3_c.jpg" alt="Chocolate Chip cookies">
                        <div class="card-body">
                            <%--<h5 class="card-title">Ingredients or something else</h5>
                    <p class="card-text">Description of this type  of cookies</p>
                            --%>
                            <asp:UpdatePanel ID="UpdatePanel19" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblChocolateChipAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbChocolateChipAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbChocolateChipAddPecans_CheckedChanged" onclick="ChocolateChipAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel32" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountChocolateChip">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountChocolateChip" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderChocolateChip" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderChocolateChip_Click" OnClientClick="OrderChocolateChipCookies()" /><br />
                                    <asp:Label ID="lblAddedToOrderChocolateChipCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderChocolateChip" />
                                    <asp:AsyncPostBackTrigger ControlID="cbChocolateChipAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>


                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">

                        <h5 class="card-header text-center">Double Chocolate</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Double_Chocolate_3_c.JPG" alt="Double Chocolate cookies">
                        <div class="card-body">
                            <%--              <h5 class="card-title">Ingredients or something else</h5>
                    <p class="card-text">Description of this type  of cookies</p>
                            --%>
                            <asp:UpdatePanel ID="UpdatePanel20" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblDoubleChocolateAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbDoubleChocolateAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbDoubleChocolateAddPecans_CheckedChanged" onclick="DoubleChocolateAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel33" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountDoubleChocolate">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountDoubleChocolate" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                                </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderDoubleChocolate" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderDoubleChocolate_Click" OnClientClick="OrderDoubleChocolateCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderDoubleChocolateCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderDoubleChocolate" />
                                    <asp:AsyncPostBackTrigger ControlID="cbDoubleChocolateAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>


                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Triple Chocolate</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4231_c.jpg" alt="Triple Chocolate cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel21" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblTripleChocolateAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbTripleChocolateAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbTripleChocolateAddPecans_CheckedChanged" onclick="TripleChocolateAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                             <asp:UpdatePanel ID="UpdatePanel34" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountTripleChocolate">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountTripleChocolate" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderTripleChocolate" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderTripleChocolate_Click" OnClientClick="OrderTripleChocolateCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderTripleChocolateCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderTripleChocolate" />
                                    <asp:AsyncPostBackTrigger ControlID="cbTripleChocolateAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
            </div>
            <div class="row">

                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Lemon Drop</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Lemon_Drop_5_c.jpg" alt="Lemon Drop cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel22" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblLemonDropAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbLemonDropAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbLemonDropAddPecans_CheckedChanged" onclick="LemonDropAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                              <asp:UpdatePanel ID="UpdatePanel35" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountLemonDrop">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountLemonDrop" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderLemonDrop" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderLemonDrop_Click" OnClientClick="OrderLemonDropCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderLemonDropCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderLemonDrop" />
                                    <asp:AsyncPostBackTrigger ControlID="cbLemonDropAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Oatmeal Chocolate Chunk</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Hubby_s_Favorite_6_c.jpg" alt="Oatmeal Chocolate Chunk cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel23" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblOatmealChocolateChunkAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbOatmealChocolateChunkAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbOatmealChocolateChunkAddPecans_CheckedChanged" onclick="OatmealChocolateChunkAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel36" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountOatmealChocolateChunk">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountOatmealChocolateChunk" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderOatmealChocolateChunk" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderOatmealChocolateChunk_Click" OnClientClick="OrderOatmealChocolateChunkCookies()" /><br />
                                    <asp:Label ID="lblAddedToOrderOatmealChocolateChunkCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderOatmealChocolateChunk" />
                                    <asp:AsyncPostBackTrigger ControlID="cbOatmealChocolateChunkAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Oatmeal</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_04651_c.jpg" alt="Oatmeal cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel24" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblOatmealAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbOatmealAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbOatmealAddPecans_CheckedChanged" onclick="OatmealAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                              <asp:UpdatePanel ID="UpdatePanel37" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountOatmeal">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountOatmeal" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderOatmeal" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderOatmeal_Click" OnClientClick="OrderOatmealCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderOatmealCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderOatmeal" />
                                    <asp:AsyncPostBackTrigger ControlID="cbOatmealAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Peanut Butter Chocolate Chip</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4242_c.jpg" alt="Peanut Butter Chocolate Chip cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel25" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblPeanutButterChocolateChipAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbPeanutButterChocolateChipAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbPeanutButterChocolateChipAddPecans_CheckedChanged" onclick="PeanutButterChocolateChipAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                           <asp:UpdatePanel ID="UpdatePanel38" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountPeanutButterChocolateChip">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountPeanutButterChocolateChip" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel9" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderPeanutButterChocolateChip" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderPeanutButterChocolateChip_Click" OnClientClick="OrderPeanutButterChocolateChipCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderPeanutButterChocolateChipCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderPeanutButterChocolateChip" />
                                    <asp:AsyncPostBackTrigger ControlID="cbPeanutButterChocolateChipAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Peanut Butter Maple</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Peanut_Butter_Maple_2_c.jpg" alt="Peanut Butter Maple cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel26" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblPeanutButterMapleAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbPeanutButterMapleAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbPeanutButterMapleAddPecans_CheckedChanged" onclick="PeanutButterMapleAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                              <asp:UpdatePanel ID="UpdatePanel39" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountPeanutButterMaple">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountPeanutButterMaple" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel10" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderPeanutButterMaple" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderPeanutButterMaple_Click" OnClientClick="OrderPeanutButterMapleCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderPeanutButterMapleCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderPeanutButterMaple" />
                                    <asp:AsyncPostBackTrigger ControlID="cbPeanutButterMapleAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Vanilla Bean Sugar</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Vanilla_Bean_Sugar_3_c.jpg" alt="Vanilla Bean Sugar cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel27" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblVanillaBeanSugarAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbVanillaBeanSugarAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbVanillaBeanSugarAddPecans_CheckedChanged" onclick="VanillaBeanSugarAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel40" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountVanillaBeanSugar">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountVanillaBeanSugar" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel11" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderVanillaBeanSugar" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderVanillaBeanSugar_Click" OnClientClick="OrderVanillaBeanSugarCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderVanillaBeanSugarCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderVanillaBeanSugar" />
                                    <asp:AsyncPostBackTrigger ControlID="cbVanillaBeanSugarAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">White Chocolate Macadamia Cranberry</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/White_Chocolate_Macadamia_Cranberry_3_c.jpg" alt="White Chocolate Macadamia Cranberry cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel28" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblWhiteChocolateMacadamiaCranberryAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbWhiteChocolateMacadamiaCranberryAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbWhiteChocolateMacadamiaCranberryAddPecans_CheckedChanged" onclick="WhiteChocolateMacadamiaCranberryAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel41" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountWhiteChocolateMacadamiaCranberry">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountWhiteChocolateMacadamiaCranberry" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel12" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderWhiteChocolateMacadamiaCranberry" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderWhiteChocolateMacadamiaCranberry_Click" OnClientClick="OrderWhiteChocolateMacadamiaCranberryCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderWhiteChocolateMacadamiaCranberry" />
                                    <asp:AsyncPostBackTrigger ControlID="cbWhiteChocolateMacadamiaCranberryAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>

                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">White Chocolate Raspberry</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4250_c.jpg" alt="White Chocolate Raspberry cookies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel29" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblWhiteChocolateRaspberryAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbWhiteChocolateRaspberryAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbWhiteChocolateRaspberryAddPecans_CheckedChanged" onclick="WhiteChocolateRaspberryAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                             <asp:UpdatePanel ID="UpdatePanel42" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountWhiteChocolateRaspberry">Select how many dozens you would like:</label>
                                <asp:TextBox ID="tbCountWhiteChocolateRaspberry" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel13" runat="server">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderWhiteChocolateRaspberry" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderWhiteChocolateRaspberry_Click" OnClientClick="OrderWhiteChocolateRaspberryCookies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderWhiteChocolateRaspberryCookies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderWhiteChocolateRaspberry" />
                                    <asp:AsyncPostBackTrigger ControlID="cbWhiteChocolateRaspberryAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
            </div>

            <hr />
            <div class="row">
                <div class="col-md-12">
                    <h3 class="text-center headersFont">Cakes</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Texas Sheet Cake</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4257_c.jpg" alt="Texas Sheet Cake">
                        <div class="card-body">
                            <p>Comes in a pan sized 17'' x 13''</p>
                             <asp:UpdatePanel ID="UpdatePanel43" runat="server" >
                                <ContentTemplate>
                            <p>
                                <label for="tbCountTexasSheetCake">Select how many cakes you would like:</label>
                                <asp:TextBox ID="tbCountTexasSheetCake" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                             </ContentTemplate>
                                 </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel14" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderTexasSheetCake" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderTexasSheetCake_Click" OnClientClick="OrderTexasSheetCake()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderTexasSheetCake" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderTexasSheetCake" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-3"></div>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-12">
                    <h3 class="text-center headersFont">Brownies (each sized 12'' x 8'')</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-4 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Chocolate Fudge Brownies</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Chocolate_Brownies_2_c.jpg" alt="Chocolate Fudge brownies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel30" runat="server">
                                <ContentTemplate>
                                    <span>
                                        <asp:Label ID="lblChocolateFudgeBrownieAddPecans" runat="server" CssClass="text-center" Text="Add pecans"></asp:Label>
                                        <asp:CheckBox ID="cbChocolateFudgeBrownieAddPecans" runat="server" AutoPostBack="true" ClientIDMode="Static" OnCheckedChanged="cbChocolateFudgeBrownieAddPecans_CheckedChanged" onclick="ChocolateFudgeBrownieAddPecans()" />
                                    </span>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel44" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountChocolateFudgeBrownie">Select how many sheets you would like:</label>
                                <asp:TextBox ID="tbCountChocolateFudgeBrownie" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                            </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel15" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderChocolateFudgeBrownie" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderChocolateFudgeBrownie_Click" OnClientClick="OrderChocolateFudgeBrownie()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderChocolateFudgeBrownie" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderChocolateFudgeBrownie" />
                                    <asp:AsyncPostBackTrigger ControlID="cbChocolateFudgeBrownieAddPecans" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-4 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Chocolate Caramel Pecan Brownies</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Chocolate_Caramel_Pecan_Brownies_2_c.jpg" alt="Chocolate Caramel Pecan brownies">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel45" runat="server">
                                <ContentTemplate>
                            <p>
                                <label for="tbCountChocolateCaramelPecanBrownies">Select how many sheets you would like:</label>
                                <asp:TextBox ID="tbCountChocolateCaramelPecanBrownies" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                                </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel16" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderChocolateCaramelPecanBrownies" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderChocolateCaramelPecanBrownies_Click" OnClientClick="OrderChocolateCaramelPecanBrownies()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderChocolateCaramelPecanBrownies" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderChocolateCaramelPecanBrownies" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-12">
                    <h3 class="text-center headersFont">Fudge (each sized 14'' x 12'' x 1'' - about 5 lbs)</h3>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Million Dollar Fudge</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4291_c.jpg" alt="Million Dollar fudge">
                        <div class="card-body">
                            <asp:UpdatePanel ID="UpdatePanel46" runat="server" >
                                <ContentTemplate>
                            <p>
                                <label for="tbCountMillionDollarFudge">Select how many sheets you would like:</label>
                                <asp:TextBox ID="tbCountMillionDollarFudge" ClientIDMode="Static" runat="server" class="spinnerWidth" name="value" placeholder="0"></asp:TextBox>
                            </p>
                            </ContentTemplate>
                                 </asp:UpdatePanel>
                            <asp:UpdatePanel ID="UpdatePanel17" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="btnOrderMillionDollarFudge" runat="server" CssClass="btn btn-dark" Text="Add to order" OnClick="btnOrderMillionDollarFudge_Click" OnClientClick="OrderMillionDollarFudge()" />
                                    <br />
                                    <asp:Label ID="lblAddedToOrderMillionDollarFudge" runat="server" CssClass="text-center" Text="Added! Scroll down for order details." Visible="false" ClientIDMode="Static"></asp:Label>
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="btnOrderMillionDollarFudge" />
                                </Triggers>
                            </asp:UpdatePanel>

                        </div>
                    </div>
                </div>

                <div class="col-md-3"></div>
            </div>

        </div>
        <%-- <div class="col-md-3 text-center">
            <div class="row">
                <div class="col-md-12">
                    <h3>Order details</h3>
                    <div class="card mb-3">
                        <div class="card-body">
                            Cookie 1
                            <br />
                            Cookie 2
                        </div>
                    </div>
                </div>
            </div>

        </div>--%>
    </div>





    <hr />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-8 text-center ">
                    <h4 class="headersFont">Order totals:</h4>
                    <div class="text-center">

                        <asp:PlaceHolder ID="phNothingOrdered" runat="server" Visible="true">
                            <p>You have not added anything to your order yet</p>
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phBubbleGumCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalBubbleGumCookies" runat="server" Text="Bubble Gum cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalBubbleGumCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForBubbleGumCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteBubbleGumCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteBubbleGumCookiesFromOrder_Click"  />
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>
                        <asp:PlaceHolder ID="phChocolateChipCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalChocolateChipCookies" runat="server" Text="Chocolate Chip cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalChocolateChipCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForChocolateChipCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteChocolateChipCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteChocolateChipCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phDoubleChocolateCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalDoubleChocolateCookies" runat="server" Text="Double Chocolate cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalDoubleChocolateCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForDoubleChocolateCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteDoubleChocolateCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteDoubleChocolateCookiesFromOrder_Click" />
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>
                        <asp:PlaceHolder ID="phTripleChocolateCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalTripleChocolateCookies" runat="server" Text="Triple Chocolate cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalTripleChocolateCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForTripleChocolateCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteTripleChocolateCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" onClick="btnDeleteTripleChocolateCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phLemonDropCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalLemonDropCookies" runat="server" Text="Lemon Drop cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalLemonDropCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForLemonDropCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteLemonDropCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteLemonDropCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phOatmealChocolateChunkCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalOatmealChocloateChunkCookies" runat="server" Text="Oatmeal Chocolate Chunk cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalOatmealChocolateChunkCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForOatmealChocolateChunkCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteOatmealChocolateChunkCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteOatmealChocolateChunkCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phOatmealCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalOatmealCookies" runat="server" Text="Oatmeal cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalOatmealCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForOatmealCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteOatmealCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" onClick="btnDeleteOatmealCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phPeanutButterChocolateChipCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalPeanutButterChocolateChipCookies" runat="server" Text="Peanut Butter Chocolate Chip cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalPeanutButterChocolateChipCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForPeanutButterChocolateChipCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeletePeanutButterChocolateChipCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeletePeanutButterChocolateChipCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>


                        <asp:PlaceHolder ID="phPeanutButterMapleCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalPeanutButterMapleCookies" runat="server" Text="Peanut Butter Maple cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalPeanutButterMapleCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForPeanutButterMapleCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeletePeanutButterMapleCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeletePeanutButterMapleCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>


                        <asp:PlaceHolder ID="phVanillaBeanSugarCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalVanillaBeanSugarCookies" runat="server" Text="Vanilla Bean Sugar cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalVanillaBeanSugarCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForVanillaBeanSugarCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteVanillaBeanSugarCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" onClick="btnDeleteVanillaBeanSugarCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phWhiteChocolateMacadamiaCranberryCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalWhiteChocolateMacadamiaCranberryCookies" runat="server" Text="White Chocolate Macadamia Cranberry cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalWhiteChocolateMacadamiaCranberryCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForWhiteChocolateMacadamiaCranberryCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteWhiteChocolateMacadamiaCranberryCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteWhiteChocolateMacadamiaCranberryCookiesFromOrder_Click" />
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>


                        <asp:PlaceHolder ID="phWhiteChocolateRaspberryCookies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalWhiteChocolateRaspberryCookies" runat="server" Text="White Chocolate Raspberry cookies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalWhiteChocolateRaspberryCookies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForWhiteChocolateRaspberryCookies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteWhiteChocolateRaspberryCookiesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" onClick="btnDeleteWhiteChocolateRaspberryCookiesFromOrder_Click"/>
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>



                        <asp:PlaceHolder ID="phTexasSheetCake" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalTexasSheetCake" runat="server" Text="Texas Sheet cake: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalTexasSheetCake" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForTexasSheetCake" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteTexasSheetCakeFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteTexasSheetCakeFromOrder_Click" />
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phChocolateFudgeBrownie" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalChocolateFudgeBrownie" runat="server" Text="Chocolate Fudge brownies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalChocolateFudgeBrownie" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForChocolateFudgeBrownie" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteChocolateFudgeBrownieFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteChocolateFudgeBrownieFromOrder_Click" />
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>

                        <asp:PlaceHolder ID="phChocolateCaramelPecanBrownies" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalChocolateCaramelPecanBrownies" runat="server" Text=" Chocolate Caramel Pecan brownies: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalChocolateCaramelPecanBrownies" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForChocolateCaramelPecanBrownies" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteChocolateCaramelPecanBrowniesFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteChocolateCaramelPecanBrowniesFromOrder_Click" />
                                </div>
                            </div>
                            <hr />
                        </asp:PlaceHolder>


                        <asp:PlaceHolder ID="phMillionDollarFudge" runat="server" Visible="false">
                            <div class="row text-left">
                                <div class="col-md-6">
                                    <span>
                                        <asp:Literal ID="lForOrderTotalMillionDollarFudge" runat="server" Text="Million Dollar fudge: "></asp:Literal>
                                        <asp:Label ID="lblOrderTotalMillionDollarFudge" runat="server" Text=""></asp:Label>

                                    </span>
                                    <br />
                                </div>
                                <div class="col-md-4 text-left">
                                    <asp:Label ID="lblPriceForMillionDollarFudge" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="col-md-2">
                                    <asp:Button ID="btnDeleteMillionDollarFudgeFromOrder" runat="server" CssClass="btn btn-dark" Text="Delete" OnClick="btnDeleteMillionDollarFudgeFromOrder_Click" />
                                </div>

                            </div>
                            <hr />
                        </asp:PlaceHolder>
                        <asp:PlaceHolder ID="phTotalPrice" runat="server" Visible="false">
                            <br />
                            <span>
                                <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label></span>
                            <br />
                            <br />
                            <asp:Button ID="btnPlaceOrder" runat="server" class="btn btn-dark" Text="Proceed to placing of my order" OnClick="btnPlaceOrder_Click" />
                        </asp:PlaceHolder>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptContent" runat="server">
    <script>

<%--        setTimeout(function(){
         document.getElementById("<%=lblAddedIntoOrderBubbleGumCookies.ClientID%>").style.display = "none";
        }, 5000);--%>

        var parameter = Sys.WebForms.PageRequestManager.getInstance();

        parameter.add_endRequest(function() {
        //jquery code after postback

             $("#tbCountBubbleGum").spinner({

                spin: function (event, ui) {
                    //          var link = document.getElementById('lblAddedIntoOrderBubbleGumCookies');
                    //if (typeof (link) !== "object") {
                    //    link.style.display = 'none';
                    //}

                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });

             $("#tbCountChocolateChip").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });

            
            $("#tbCountDoubleChocolate").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountTripleChocolate").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountLemonDrop").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountOatmealChocolateChunk").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountOatmeal").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountPeanutButterChocolateChip").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountPeanutButterMaple").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountVanillaBeanSugar").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountWhiteChocolateMacadamiaCranberry").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountWhiteChocolateRaspberry").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountTexasSheetCake").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountChocolateFudgeBrownie").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountChocolateCaramelPecanBrownies").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountMillionDollarFudge").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });

             


//end of after postback function
    });

        $(function () {

           



            $("#tbCountChocolateChip").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
           
            $("#tbCountBubbleGum").spinner({

                spin: function (event, ui) {
                    //          var link = document.getElementById('lblAddedIntoOrderBubbleGumCookies');
                    //if (typeof (link) !== "object") {
                    //    link.style.display = 'none';
                    //}

                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            



            $("#tbCountDoubleChocolate").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountTripleChocolate").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountLemonDrop").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountOatmealChocolateChunk").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountOatmeal").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountPeanutButterChocolateChip").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountPeanutButterMaple").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountVanillaBeanSugar").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountWhiteChocolateMacadamiaCranberry").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountWhiteChocolateRaspberry").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountTexasSheetCake").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountChocolateFudgeBrownie").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountChocolateCaramelPecanBrownies").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
            $("#tbCountMillionDollarFudge").spinner({
                spin: function (event, ui) {
                    if (ui.value < 0) {
                        $(this).spinner("value", 0);
                        return false;
                    }
                }
            });
        });



        function OrderBubbleGumCookies() {

            window.setTimeout(function () {
                $("#lblAddedIntoOrderBubbleGumCookies").hide();
            }, 4000);
        };

        function BubbleGumAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedIntoOrderBubbleGumCookies").hide();
            }, 4000);
        };

        function OrderChocolateChipCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderChocolateChipCookies").hide();
            }, 4000);
        };

        function ChocolateChipAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderChocolateChipCookies").hide();
            }, 4000);
        };


        function OrderDoubleChocolateCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderDoubleChocolateCookies").hide();
            }, 4000);
        };

        function DoubleChocolateAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderDoubleChocolateCookies").hide();
            }, 4000);
        };

        function OrderTripleChocolateCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderTripleChocolateCookies").hide();
            }, 4000);
        };

        function TripleChocolateAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderTripleChocolateCookies").hide();
            }, 4000);
        };

        function OrderLemonDropCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderLemonDropCookies").hide();
            }, 4000);
        };

        function LemonDropAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderLemonDropCookies").hide();
            }, 4000);
        };

        function OrderOatmealChocolateChunkCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderOatmealChocolateChunkCookies").hide();
            }, 4000);
        };

        function OatmealChocolateChunkAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderOatmealChocolateChunkCookies").hide();
            }, 4000);
        };

        function OrderOatmealCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderOatmealCookies").hide();
            }, 4000);
        };

        function OatmealAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderOatmealCookies").hide();
            }, 4000);
        };


        function OrderPeanutButterChocolateChipCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderPeanutButterChocolateChipCookies").hide();
            }, 4000);
        };

        function PeanutButterChocolateChipAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderPeanutButterChocolateChipCookies").hide();
            }, 4000);
        };

        function OrderPeanutButterMapleCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderPeanutButterMapleCookies").hide();
            }, 4000);
        };

        function PeanutButterMapleAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderPeanutButterMapleCookies").hide();
            }, 4000);
        };

        function OrderVanillaBeanSugarCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderVanillaBeanSugarCookies").hide();
            }, 4000);
        };

        function VanillaBeanSugarAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderVanillaBeanSugarCookies").hide();
            }, 4000);
        };

        function OrderWhiteChocolateMacadamiaCranberryCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies").hide();
            }, 4000);
        };

        function WhiteChocolateMacadamiaCranberryAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderWhiteChocolateMacadamiaCranberryCookies").hide();
            }, 4000);
        };

        function OrderWhiteChocolateRaspberryCookies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderWhiteChocolateRaspberryCookies").hide();
            }, 4000);
        };

        function WhiteChocolateRaspberryAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderWhiteChocolateRaspberryCookies").hide();
            }, 4000);
        };

        function OrderTexasSheetCake() {

            window.setTimeout(function () {
                $("#lblAddedToOrderTexasSheetCake").hide();
            }, 4000);
        };
        function OrderChocolateFudgeBrownie() {

            window.setTimeout(function () {
                $("#lblAddedToOrderChocolateFudgeBrownie").hide();
            }, 4000);
        };

        function ChocolateFudgeBrownieAddPecans() {
            window.setTimeout(function () {
                $("#lblAddedToOrderChocolateFudgeBrownie").hide();
            }, 4000);
        };

        function OrderChocolateCaramelPecanBrownies() {

            window.setTimeout(function () {
                $("#lblAddedToOrderChocolateCaramelPecanBrownies").hide();
            }, 4000);
        };

        function OrderMillionDollarFudge() {

            window.setTimeout(function () {
                $("#lblAddedToOrderMillionDollarFudge").hide();
            }, 4000);
        };


    </script>

</asp:Content>
