<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="bakery.Contact" Async="true" MaintainScrollPositionOnPostback="true"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <br />
    <h2 class="text-center headersFont"><%: Title %></h2>
    
<%--    <address>
        Some street<br />
        Dallas, TX <br />
        <abbr title="Phone">P:</abbr>
        111.222.3333
    </address>--%>

    <%--<address>
        <strong>Please fill out the form and the Chef will contact you</strong><a href="mailto:2WrightsDelights@someemail.com">2WrightsDelights@someemail.com</a><br />
    </address>--%>
       

        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                       <div class="card">
                    <div class="card-body">
                        <h5 class="card-title text-left">Please fill out the form, and we will contact you promptly:</h5>
                        
                        <div class="row">
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblToChefFullName" runat="server" Text="Full name:"></asp:Label>
                                <asp:TextBox ID="tbToChefFullName" runat="server" Width="100%"></asp:TextBox>
                                
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblToChefCustomerEmail" runat="server" Text="Your email address:"></asp:Label>
                                <asp:TextBox ID="tbToChefCustomerEmail" runat="server" Width="100%"></asp:TextBox>      
                               
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblToChefSubject" runat="server" Text="Subject:"></asp:Label>
                                <asp:TextBox ID="tbToChefSubject" runat="server" Width="100%"></asp:TextBox>
                            </div>
                            <div class="col-md-12 pt-2 pb-2">
                                <asp:Label ID="lblToChefMessage" runat="server" Text="Message:"></asp:Label>
                                <asp:TextBox ID="tbToChefMessage" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="alert-danger" ErrorMessage="Message is a required field." ControlToValidate="tbToChefMessage"></asp:RequiredFieldValidator>
                            </div>
                         </div>
                        <div class="row">
                            <div class="col-md-12">
                                 <div class="text-center"><asp:Button ID="btnSendFeedback" runat="server" CssClass="btn btn-dark" Text="Submit my feedback" OnClick="btnSendFeedback_Click"/></div>
                            </div>
                        </div>
                       
                        
                    </div>
                </div>
            </div>
            <div class="col-md-2"></div>
        </div>

        </div>
</asp:Content>
