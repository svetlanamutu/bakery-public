<%@ Page Title="Place Order" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="PlaceOrder.aspx.vb" Inherits="bakery.PlaceOrder" Async="true" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container"><br />
        <div class="row">
            <div class="col-md-12">
                <h2 class="text-center headersFont">Order details</h2>
            </div>
        </div>
        
        <div class="row">
            <div class="col-md-8"></div>
            <div class="col-md-2 pb-2">
               <asp:Button ID="btnChangeOrder" runat="server" CssClass="btn btn-dark" Text="Change my order" OnClick="btnChangeOrder_Click" CausesValidation="false" />
        <br />
            </div>
            <div class="col-md-2"></div>
        </div>


        <div class="row">
            <div class="col-md-2"></div>
                <div class="col-md-8">
                <div class="card ">
                    <div class="card-body">
                        <h5 class="card-title">Contact details:</h5>
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblCustomerFirstName" runat="server" Text="First name:(*)"></asp:Label>
                                <asp:TextBox ID="tbCustomerFirstName" runat="server" Width="100%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alert-danger" ErrorMessage="First name is a required field." ControlToValidate="tbCustomerFirstName"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblMiddleName" runat="server" Text="Middle name:"></asp:Label>
                                <asp:TextBox ID="tbMiddleName" runat="server" Width="100%"></asp:TextBox>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblCustomerLastName" runat="server" Text="Last name:(*)"></asp:Label>
                                <asp:TextBox ID="tbCustomerLastName" runat="server" Width="100%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="alert-danger" ErrorMessage="Last name is a required field." ControlToValidate="tbCustomerLastName"></asp:RequiredFieldValidator>
                            </div>
                               <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblPhonePrimary" runat="server" Text="Primary phone:"></asp:Label>
                                <asp:TextBox ID="tbPrimaryPhone" runat="server" Width="100%"></asp:TextBox>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblPhoneSecondary" runat="server" Text="Secondary Phone:"></asp:Label>
                                <asp:TextBox ID="tbSecondaryPhone" runat="server" Width="100%"></asp:TextBox>
                            </div>
                        </div>

                       
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblCustomerEmail" runat="server" Text="Email:(*)"></asp:Label>
                                <asp:TextBox ID="tbEmail" runat="server" Width="100%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="alert-danger" ErrorMessage="Email is a required field." ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
                                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="alert-danger" ErrorMessage="You typed a wrongly-formatted email adress." ControlToValidate="tbEmail" ValidationExpression="^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"></asp:RegularExpressionValidator>--%>
                                <br /><asp:CustomValidator ID="CustomValidator1" runat="server" CssClass="alert-danger" ErrorMessage="You typed a wrongly-formatted email adress." ControlToValidate="tbEmail" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>

                            </div>
                        </div>
                    </div>
                </div>
            
                </div>
            <div class="col-md-2"></div>
        </div>


        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Shipping address:</h5>
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblShippingFullName" runat="server" Text="Full name:(*)"></asp:Label>
                                <asp:TextBox ID="tbShippingFullName" runat="server" Width="100%"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="alert-danger" ErrorMessage="Full name in the shipping section is a required field." ControlToValidate="tbShippingFullName"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblShippingStreetAddress1" runat="server" Text="Street address:(*)"></asp:Label>
                                <asp:TextBox ID="tbShippingStreetAddress1" runat="server" Width="100%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" CssClass="alert-danger" ErrorMessage="Street address is a required field." ControlToValidate="tbShippingStreetAddress1"></asp:RequiredFieldValidator>
                                <br />
                                <asp:Label ID="lblShippingStreetAddress2" runat="server" Text="Street address:(*)" CssClass="invisible"></asp:Label>
                                <asp:TextBox ID="tbSShippingtreetAddress2" runat="server" placeholder="Apartment, suite, floor, etc." CssClass="mt-2 mb-2" Width="100%"></asp:TextBox>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblShippingCity" runat="server" Text="City:(*)"></asp:Label>
                                <asp:TextBox ID="tbShippingCity" runat="server" Width="100%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" CssClass="alert-danger" ErrorMessage="City is a required field." ControlToValidate="tbShippingCity"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblShippingState" runat="server" Text="State:(*)"></asp:Label>
                                <asp:TextBox ID="tbShippingState" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" CssClass="alert-danger" ErrorMessage="State is a required field." ControlToValidate="tbShippingState"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblShippingZipCode" runat="server" Text="Zip code:(*)"></asp:Label>
                                <asp:TextBox ID="tbShippingZipCode" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" CssClass="alert-danger" ErrorMessage="Zip code is a required field." ControlToValidate="tbShippingZipCode"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblShippingPhoneNumber" runat="server" Text="Phone number:"></asp:Label>
                                <asp:TextBox ID="tbShippingPhoneNumber" runat="server"></asp:TextBox>
                                
                            </div>

                              <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblDateAndTimeOfDelivery" runat="server" Text="Date of delivery and specific time, if needed:"></asp:Label>
                                <asp:TextBox ID="tbDateAndTimeOfDelivery" runat="server"></asp:TextBox>
                                
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2"></div>
        </div>

        
        
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Message to the Chef (optional):</h5>
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                             
                                <asp:TextBox ID="tbMessageToTheChefFromOrder" runat="server" Width="100%" TextMode="MultiLine" Height="100%"></asp:TextBox>
                            </div>
                       
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2"></div>
        </div>

               <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Order totals:</h5>
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:ListView ID="lvOrderedCookies" runat="server" ItemPlaceholderID="itemPlaceholder" SelectMethod="lvOrderedCookies_GetData">
                                    <LayoutTemplate>
                                        <div class="row text-center listBorder">

                                            <div class="col-md-1">#</div>
                                            <div class="col-md-2">Count (dozens or sheets)</div>
                                            <div class="col-md-5">Type of product</div>
                                            <div class="col-md-2">Pecans Requested?</div>
                                            <div class="col-md-2">Price, $</div>
                                        </div>
                                           
                                          <div runat="server" id="itemPlaceholder"></div>
                                        
                                           
                                    </LayoutTemplate>
                                    <ItemTemplate>
                                         <div class="row text-center listBorder">
                                             <div class="col-md-1"> <asp:Label ID="lblItem" runat="server" Text='<%#: Eval("OrderInTheList")%>'></asp:Label></div>
                                        <div class="col-md-2"> <asp:Label ID="lblCount" runat="server" Text='<%#: Eval("Count")%>'></asp:Label></div>
                                        <div class="col-md-5"> <asp:Label ID="lblTypeOfProduct" runat="server" Text='<%#: Eval("TypeOfProduct")%>'></asp:Label></div>
                                        <div class="col-md-2"> <asp:Label ID="lblPecansRequested" runat="server" Text='<%#: Eval("PecansRequested")%>'></asp:Label></div>
                                        <div class="col-md-2"> <asp:Label ID="lblPrice" runat="server" Text='<%#: Eval("Price")%>'></asp:Label></div>
                                             </div>
                                    </ItemTemplate>
                                </asp:ListView>
                                <hr />
                                          <div class="row text-right">
                                              <div class="col-md-12">
                                                    
                                                  <asp:Label ID="lblTotalCost" runat="server"></asp:Label>
                                                
                                                  <br />
                                                  <p class="text-center">Delivery price is added to the price of the order and will vary based upon location.</p>
                                              </div>
                            </div>
                       
                        </div>
                    </div>
                </div>
            </div>
                </div>
            <div class="col-md-2"></div>
        </div>
        
                <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                                  You will be contacted by us by phone or email to verify your order and arrange shipping and payment details. Thank you so much for ordering from us!                              
                               
                            </div>
                       
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-2"></div>
        </div>

<br />
       <div class="row text-center">
          <div class="col-md-12"> 
          <asp:Button ID="btnSubmitOrder" class="btn btn-dark" runat="server" Text="Submit your order to the Chef!" OnClick="btnSubmitOrder_Click" CausesValidation="true"/></div>
          </div>
    </div>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptContent" runat="server">
</asp:Content>
