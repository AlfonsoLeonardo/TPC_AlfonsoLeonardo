<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main class="page-content">
    <!-- Swiper variant 3-->
    <section class="bg-gray-darker deslizador">
        <div class="swiper-variant-1">
            <div data-slide-effect="fade" data-min-height="600px" class="swiper-container swiper-slider">
                <div class="swiper-wrapper">
                    <div data-slide-bg="../Content/images/pizza/Mozzarella.jpg" class="swiper-slide">
                        <div class="swiper-slide-caption slide-caption-2 text-center">
                            <div class="shell">
                                <div class="range range-sm-center">
                                    <div class="cell-sm-11 cell-lg-9">

                                        <h2 data-caption-animate="fadeInUpSmall" data-caption-delay="400" class="text-uppercase text-white offset-top-0 bordeTexto">Muzzarella</h2>
                                        <p data-caption-animate="fadeInUpSmall" data-caption-delay="700" class="text-white offset-top-18 bordeTexto subtitulo">La que le gusta a todo el mundo</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div data-slide-bg="../Content/images/pizza/Napolitana.jpg" class="swiper-slide">
                        <div class="swiper-slide-caption slide-caption-2 text-center">
                            <div class="shell">
                                <div class="range range-sm-center">
                                    <div class="cell-sm-10 cell-lg-8">
                                        <h2 data-caption-animate="fadeInUpSmall" data-caption-delay="400" class="text-uppercase text-white offset-top-0 bordeTexto">Napolitana</h2>
                                        <p data-caption-animate="fadeInUpSmall" data-caption-delay="700" class="text-white offset-top-18 bordeTexto subtitulo">Con tomate natural</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div data-slide-bg="../Content/images/pizza/JamonYMorron.jpg" class="swiper-slide">
                        <div class="swiper-slide-caption slide-caption-2 text-center">
                            <div class="shell">
                                <div class="range range-sm-center">
                                    <div class="cell-sm-10 cell-lg-8">

                                        <h2 data-caption-animate="fadeInUpSmall" data-caption-delay="400" class="text-uppercase text-white offset-top-0 bordeTexto">Jamón y Morrón</h2>
                                        <p data-caption-animate="fadeInUpSmall" data-caption-delay="700" class="text-white offset-top-18 bordeTexto subtitulo">Hay para todos los gustos</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div data-slide-bg="../Content/images/pizza/Longaniza.jpg" class="swiper-slide">
                        <div class="swiper-slide-caption slide-caption-2 text-center">
                            <div class="shell">
                                <div class="range range-sm-center">
                                    <div class="cell-sm-10 cell-lg-8">

                                        <h2 data-caption-animate="fadeInUpSmall" data-caption-delay="400" class="text-uppercase text-white offset-top-0 bordeTexto">Longaniza</h2>
                                        <p data-caption-animate="fadeInUpSmall" data-caption-delay="700" class="text-white offset-top-18 bordeTexto subtitulo">Para los valientes</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Swiper Navigation-->
                <div class="swiper-pagination-wrap">
                    <div class="swiper-pagination"></div>
                </div>
            </div>
        </div>
    </section>


    <section>
        <div class="info-deslizador">
            <!-- BLOQUES DE LA HOME -->
            <div class="content-hogar">
                <div class="row texto-de-arriba">
                    <div class="col-lg-5 col-lg-offset-1 col-sm-12">
                        <h3>ENVÍO GRATIS A PARTIR DE $500</h3>
                    </div>
                    <div class="col-lg-5 col-lg-offset-1 col-sm-12">
                      
                    </div>
                </div>
                <div class="row">
                    <div class="col-lg-6 col-lg-offset-3 col-sm-12">
                       
                    </div>
                </div>
            </div>
        </div>
    </section>


    <section class="section-50 section-sm-top-90 section-sm-bottom-100 bg-image-6">
        <div class="shell text-center">
            <h3>Nuestro Menu</h3>
            <div class="range range-xs-center">
                <div class="cell-sm-6 cell-md-4">
                    <div class="menu-variant-1">
                        <img src="../Content/images/bloque_categorias/pizzas.jpg" alt="" width="310" height="260" class="img-responsive reveal-inline-block" />
                        <div class="caption">
                            <h5 class="title">@Html.ActionLink("Pizzas", "Index", "Product", new { category = 1 }, new { @class = "link-white" })</h5>
                        </div>
                    </div>
                </div>
                <div class="cell-sm-6 cell-md-4 offset-top-50 offset-sm-top-0">
                    <div class="menu-variant-1">
                        <img src="../Content/images/bloque_categorias/empanadas.jpg" alt="" width="310" height="260" class="img-responsive reveal-inline-block" />
                        <div class="caption">
                            <h5 class="title">@Html.ActionLink("Empanadas", "Index", "Product", new { category = 2 }, new { @class = "link-white" })</h5>
                        </div>
                    </div>
                </div>
                <div class="cell-sm-6 cell-md-4 offset-top-50 offset-md-top-0">
                    <div class="menu-variant-1">
                        <img src="../Content/images/bloque_categorias/bebidas.jpg" alt="" width="310" height="260" class="img-responsive reveal-inline-block" />
                        <div class="caption">
                            <h5 class="title"> @Html.ActionLink("Bebidas", "Index", "Product", new { category = 3 }, new { @class = "link-white" })</h5>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    
</main>

</asp:Content>
