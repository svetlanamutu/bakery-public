<%@ Page Title="Menu" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="bakery._Default" MaintainScrollPositionOnPostback="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <br /> 
    <h2 class="text-center headersFont">Menu</h2>
        <h3 class="text-center">Welcome!</h3>
    <p class="text-indentation">
   Thank you for stopping by and seeing what 2Wrights'Delights has to offer to you and yours. Please stop by often for we have a regular menu as well as monthly and seasonal specials. 
        </p>
    <p class="text-indentation">2Wrights'Delights has been so fortunate to discover a secret ingredient. This wonderful secret ingredient just takes our homemade delights to a whole new level. It truly does make our delights so delicious and it will compel you to savor every bite.</p>
    <p class="text-indentation">2Wrights'Delights can bake for small or medium groups. So please give us a try. We would love to bake for you.</p>
    <%--<p>2 Wrights' Delights - the pace where you will savor every bite.</p>--%>

        <h4 class="text-center">Here are our offerings:</h4>
        

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
                            <asp:Label ID="lblBubbleGumCookies" runat="server" Text=""></asp:Label>
  <%--                          <!-- Button trigger modal -->
<button type="button" class="btn btn-dark" data-toggle="modal" data-target="#exampleModalCenter">
  See more pictures
</button>

<!-- Modal -->
<div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLongTitle">Bubble Gum Cookies</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div id="carouselExampleIndicators1" class="carousel slide" data-ride="carousel" data-interval="false">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators1" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators1" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators1" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" runat="server" src="~/Images/IMG_4231_c.jpg" alt="First slide">
        <div class="carousel-caption d-none d-md-block">
    <h5>Best cookies ever</h5>
    <p>So I think</p>
  </div>
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" runat="server" src="~/Images/IMG_4242_c.jpg" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" runat="server" src="~/Images/IMG_4250_c.JPG" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators1" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators1" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        
      </div>
    </div>
  </div>
</div>--%>

                                        </div>
                    </div>
                </div>
                         
                <div class="col-md-3 text-center">
                    <div class="card mb-3">

                        <h5 class="card-header text-center">Chocolate Chip</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Chocolate_Chip_3_c.jpg" alt="Chocolate Chip cookies">
                        <div class="card-body">
                        <asp:Label ID="lblChocolateChipCookies" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">

                        <h5 class="card-header text-center">Double Chocolate</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Double_Chocolate_3_c.JPG" alt="Double Chocolate cookies">
                        <div class="card-body">
                          <asp:Label ID="lblDoubleChocolateCookies" runat="server" Text=""></asp:Label>


                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Triple Chocolate</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4231_c.jpg" alt="Triple Chocolate cookies">
                        <div class="card-body">
              <asp:Label ID="lblTripleChocolateCookies" runat="server" Text=""></asp:Label>

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
                              <asp:Label ID="lblLemonDropCookies" runat="server" Text=""></asp:Label>
                      </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Oatmeal Chocolate Chunk</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Hubby_s_Favorite_6_c.jpg" alt="Oatmeal Chocolate Chunk cookies">
                        <div class="card-body">
                              <asp:Label ID="lblOatmealChocolateChunkCookies" runat="server" Text=""></asp:Label>
                                         </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Oatmeal</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_04651_c.jpg" alt="Oatmeal cookies">
                        <div class="card-body">
                          <asp:Label ID="lblOatmealCookies" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Peanut Butter Chocolate Chip</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4242_c.jpg" alt="Peanut Butter Chocolate Chip cookies">
                        <div class="card-body">
                        <asp:Label ID="lblPeanutButterChocolateChipCookies" runat="server" Text=""></asp:Label>

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
                       <asp:Label ID="lblPeanutButterMapleCookies" runat="server" Text=""></asp:Label>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Vanilla Bean Sugar</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Vanilla_Bean_Sugar_3_c.jpg" alt="Vanilla Bean Sugar cookies">
                        <div class="card-body">
                    <asp:Label ID="lblVanillaBeanSugarCookies" runat="server" Text=""></asp:Label>

                        </div>
                    </div>
                </div>
                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">White Chocolate Macadamia Cranberry</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/White_Chocolate_Macadamia_Cranberry_3_c.jpg" alt="White Chocolate Macadamia Cranberry cookies">
                        <div class="card-body">
                       <asp:Label ID="lblWhiteChocolateMacadamiaCranberryCookies" runat="server" Text=""></asp:Label>

                        </div>
                    </div>
                </div>

                <div class="col-md-3 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">White Chocolate Raspberry</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4250_c.jpg" alt="White Chocolate Raspberry cookies">
                        <div class="card-body">
                  <asp:Label ID="lblWhiteChocolateRaspberryCookies" runat="server" Text=""></asp:Label>

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
                           <asp:Label ID="lblTexasSheetCake" runat="server" Text=""></asp:Label>

                        </div>
                    </div>
                </div>
                <div class="col-md-3"></div>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-12">
                    <h3 class="text-center headersFont">Brownies (each sized 13'' x 9'')</h3>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2"></div>
                <div class="col-md-4 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Chocolate Fudge Brownies</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Chocolate_Brownies_2_c.jpg" alt="Chocolate Fudge brownies">
                        <div class="card-body">
                      <asp:Label ID="lblChocolateFudgeBrownies" runat="server" Text=""></asp:Label>

                        </div>
                    </div>
                </div>
                <div class="col-md-4 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Chocolate Caramel Pecan Brownies</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/Chocolate_Caramel_Pecan_Brownies_2_c.jpg" alt="Chocolate Caramel Pecan brownies">
                        <div class="card-body">
                     
                             <asp:Label ID="lblChocolateCaramelPecanBrownies" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-md-2"></div>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-12">
                    <h3 class="text-center headersFont">Fudge (each sized 14'' x 12'' - about 5 lbs)</h3>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3"></div>
                <div class="col-md-6 text-center">
                    <div class="card mb-3">
                        <h5 class="card-header text-center">Million Dollar Fudge</h5>
                        <img class="card-img-top img-thumbnail rounded" runat="server" src="~/Images/IMG_4291_c.jpg" alt="Million Dollar fudge">
                        <div class="card-body">
                     
                              <asp:Label ID="lblMillionDollarFudge" runat="server" Text=""></asp:Label>
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


        </div>
</asp:Content>
