<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Web.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <style>
        .gm-err-container {
            height: 100%;
            width: 100%;
            display: table;
            background-color: #e0e0e0;
            position: relative;
            left: 0;
            top: 0
        }

        .gm-err-content {
            border-radius: 1px;
            padding-top: 0;
            padding-left: 10%;
            padding-right: 10%;
            position: static;
            vertical-align: middle;
            display: table-cell
        }

            .gm-err-content a {
                color: #4285f4
            }

        .gm-err-icon {
            text-align: center
        }

        .gm-err-title {
            margin: 5px;
            margin-bottom: 20px;
            color: #616161;
            font-family: Roboto,Arial,sans-serif;
            text-align: center;
            font-size: 24px
        }

        .gm-err-message {
            margin: 5px;
            color: #757575;
            font-family: Roboto,Arial,sans-serif;
            text-align: center;
            font-size: 12px
        }

        .gm-err-autocomplete {
            padding-left: 20px;
            background-repeat: no-repeat;
            background-size: 15px 15px
        }
    </style>
    <style>
        .gm-style-pbc {
            transition: opacity ease-in-out;
            background-color: rgba(0,0,0,0.45);
            text-align: center
        }

        .gm-style-pbt {
            font-size: 22px;
            color: white;
            font-family: Roboto,Arial,sans-serif;
            position: relative;
            margin: 0;
            top: 50%;
            -webkit-transform: translateY(-50%);
            -ms-transform: translateY(-50%);
            transform: translateY(-50%)
        }
    </style>
    <style>
        .gm-style img {
            max-width: none;
        }

        .gm-style {
            font: 400 11px Roboto, Arial, sans-serif;
            text-decoration: none;
        }
    </style>
    <meta charset="UTF-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
    <meta name="description"/>
    <title>	Mi Pizza</title>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css"/>
    <link rel="stylesheet" href="css/mobirise-icons.css"/>
    <link rel="stylesheet" href="css/tether.min.css"/>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="css/bootstrap-grid.min.css"/>
    <link rel="stylesheet" href="css/bootstrap-reboot.min.css"/>
    <link rel="stylesheet" href="css/style.css"/>
    <link rel="stylesheet" href="css/animate.min.css"/>
    <link rel="stylesheet" href="css/styles.css"/>
    <link rel="stylesheet" href="css/data-tables.bootstrap4.min.css"/>
    <link rel="stylesheet" href="css/style.css?v3"/>
    <link rel="stylesheet" href="css/mbr-additional.css" type="text/css"/>

    <style>
        .modal-footer {
            display: block;
        }

        .btn_modal {
            border-radius: 80px;
        }

        .center {
            text-align: center;
        }

        .w100 {
            width: 100%;
        }

        .main_local {
            padding: 5px;
            float: left;
        }

        .content_local {
            border: solid 1px #ff001d;
            border-radius: 3px;
            padding: 5px;
            height: 175px;
        }

        .nom_local {
            font-size: 20px;
            font-weight: bold;
        }

        .info_local {
            font-size: 13px;
        }

        .div_bar_left {
            background-color: #ff001d;
            float: left;
            height: 174px;
            width: 15px;
            margin: -5px;
        }

        .progress-bar {
            background-color: green;
        }

        .btnEncuesta {
            width: auto;
            border: solid 1px;
            font-weight: bold;
            display: inline-block;
        }

        .btnEncuesta100 {
            width: 100%;
        }

        .btnGreen {
            background-color: green;
            color: white;
        }

        .btnRed {
            background-color: red;
            color: white;
        }

        .btnOrange {
            background-color: orange;
            color: white;
        }

        .ButtonMarkSurvey {
            font-family: 'Muli', sans-serif;
            font-size: 1rem;
            line-height: 1.43;
            min-height: 3.5em;
            padding: 1.07em .5em;
            width: auto;
            border: solid 1px;
            font-weight: bold;
            display: inline-block;
            margin-top: 30px;
            margin-bottom: 30px;
            border-radius: .25rem;
        }

        .BtnMark {
            background-color: green;
            color: white;
        }

        #dni_comment {
            color: #dc3545;
            margin-top: -1px;
            border-bottom-left-radius: 5px;
            border-bottom-right-radius: 5px;
            font-size: 12px;
            padding: 5px;
        }

        #dniLoading {
            position: absolute;
            top: 15px;
            right: 25px;
        }

        .circlePrice {
            padding: 10px;
            float: right;
            background-color: #ababab94;
            background-color: #ff001d99;
            border-radius: 100%;
            height: 120px;
            width: 120px;
        }

        .circlePriceTitle {
            font-size: 12px;
            width: 100%;
            text-align: center;
        }

        .circlePricePrice {
            font-size: 40px;
            width: 100%;
            text-align: center;
            margin-top: -22px;
        }

        .promoNoValida {
            font-size: 10px;
            float: right;
            width: 100%;
            margin-top: 20px;
        }

        .PriceAster {
            font-size: 10px;
            position: absolute;
            margin-top: 12px;
        }

        .sucItem {
            border: solid 1px #ff001d;
            padding: 5px;
            border-left: solid 10px #ff001d;
            border-radius: 5px;
            padding-left: 10px;
            margin-bottom: 8px;
        }

        .sucTitle {
            font-weight: bold;
            font-size: 18px;
        }

        .sucDir {
            font-size: 17px;
        }

        .sucTels {
            font-size: 15px;
        }

        .btnVerTodSuc {
            background-color: #ff001d;
            border-color: #ff001d;
            border-radius: 5px;
        }

            .btnVerTodSuc:hover {
                background-color: #c60018;
                border-color: #c60018;
            }

            .btnVerTodSuc:focus {
                background-color: #c60018;
                border-color: #c60018;
            }



        #distLoc {
            font-size: 15px;
            color: #555;
        }

        .sombraBox {
            box-shadow: 0 10px 30px -12px rgba(0, 0, 0, 0.42), 0 4px 25px 0px rgba(0, 0, 0, 0.12), 0 8px 10px -5px rgba(0, 0, 0, 0.2);
        }

        .sombraText {
            text-shadow: 4px 4px 8px #000;
        }

        .sombraText2 {
            text-shadow: 3px 3px 3px #000;
        }

        #ModalPedir {
            z-index: 999999999;
            position: absolute;
            left: 5px;
            right: 5px;
            top: 5px;
            display: none;
            border-radius: 5px;
            overflow-x: hidden;
            overflow-y: hidden;
        }

        .pointer {
            cursor: pointer;
        }

        .bgNav {
            background-color: #ff001d99;
        }

        .bgNavLeft {
            border-bottom-left-radius: 5px;
            border-top-left-radius: 5px;
        }

        .bgNavRight {
            border-bottom-right-radius: 5px;
            border-top-right-radius: 5px;
        }

        .sombraText3 {
            text-shadow: 1px 0 0 #000, -1px 0 0 #000, 0 1px 0 #000, 0 -1px 0 #000, 1px 1px #000, -1px -1px 0 #000, 1px -1px 0 #000, -1px 1px 0 #000;
        }

        .cid-qzdDlyAR9g P {
            font-weight: bold;
        }

        @media only screen and (max-width: 400px) {
        }

        @media (max-width: 600px) and (orientation: landscape) {
            .circlePricePrice {
                font-size: 30px;
                margin-top: -12px;
            }
        }

        @media (min-width: 991px) {

            #BtnPedidoMobile {
                display: none;
                position: absolute;
                right: 55px;
                top: 5px;
                font-family: 'Muli', sans-serif !important;
            }

            #BtnPedidoDesktop {
                display: block;
            }
        }

        @media (max-width: 991px) {

            #BtnPedidoMobile {
                display: block;
                position: absolute;
                right: 55px;
                top: 5px;
                font-family: 'Muli', sans-serif !important;
            }

            #BtnPedidoDesktop {
                display: none;
            }
        }


        ::-webkit-scrollbar {
            width: 5px;
        }

        ::-webkit-scrollbar-button {
        }

        ::-webkit-scrollbar-track {
        }

        ::-webkit-scrollbar-track-piece {
            background-color: #fff;
        }

        ::-webkit-scrollbar-thumb {
            background-color: #ff001d;
        }

        ::-webkit-scrollbar-corner { /* 6 */
        }

        ::-webkit-resizer { /* 7 */
        }
    </style>


    <style type="text/css" id="#jarallax-clip-0">
        #jarallax-container-0 {
            clip: rect(0 1361px 850px 0);
            clip: rect(0, 1361px, 850px, 0);
        }
    </style>
    <style type="text/css" id="#jarallax-clip-1">
        #jarallax-container-1 {
            clip: rect(0 1361px 1042px 0);
            clip: rect(0, 1361px, 1042px, 0);
        }
    </style>
    <style type="text/css" id="#jarallax-clip-2">
        #jarallax-container-2 {
            clip: rect(0 1361px 592.78125px 0);
            clip: rect(0, 1361px, 592.78125px, 0);
        }
    </style>
    <style type="text/css" id="#jarallax-clip-3">
        #jarallax-container-3 {
            clip: rect(0 1361px 612px 0);
            clip: rect(0, 1361px, 612px, 0);
        }
    </style>

</head>
<body>
<section class="menu cid-qzdD9AioF0" once="menu" id="menu1-0" data-rv-view="1498">
    
    <nav class="navbar navbar-expand beta-menu navbar-dropdown align-items-center navbar-fixed-top navbar-toggleable-sm transparent bg-color">
        <button class="navbar-toggler navbar-toggler-right" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <div class="hamburger">
                <span></span>
                <span></span>
                <span></span>
                <span></span>
            </div>
        </button>
      
        <button id="BtnPedidoMobile" href="#" onclick="fcn_goToTP();" target="_blank" style="padding-bottom: 4px; margin-top: 2px; height: 50px;" type="button" class="btn btn-primary btn-form display-4 btn_modal btnVerTodSuc animated infinite pulse sombraBox">HACÉ TU PEDIDO</button>
      
        <div class="menu-logo">
            <div class="navbar-brand">
                <span class="navbar-logo">
                    <a href="#top">
                         <!--<img src="images/logo-324x207.png" alt="Mobirise" title="" media-simple="true" style="height: 7rem;">-->
                         <img src="images/logo.png" alt="" title="" media-simple="true" style="height: 8rem;" class="animated bounceIn">
                         <div class="navbar-slogan" style="font-size: 12px; color: white; text-align: center;"></div>
                         <div class="navbar-slogan" style="font-size: 20px; color: white; text-align: center;"></div>
                    </a>
                </span>
                
            </div>
        </div>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav nav-dropdown nav-right" data-app-modern-menu="true">
            	
              <li class="nav-item" style="display: block;">
              	<button id="BtnPedidoDesktop" href="#" onclick="fcn_goToTP();" target="_blank" style="padding-bottom: 4px; margin-top: 2px; height: 50px;" type="button" class="btn btn-primary btn-form display-4 btn_modal btnVerTodSuc animated infinite pulse sombraBox">HACÉ TU PEDIDO</button>
              </li>
            	
            	       <li class="nav-item bgNav bgNavLeft"><a class="nav-link link text-white display-5" href="#top">Inicio</a></li>
                       <li class="nav-item bgNav"><a class="nav-link link text-white display-5" href="index.html#table1-b">Productos</a></li>

               </ul>
            
        </div>
    </nav>
</section>

<section class="carousel slide cid-qzdDlyAR9g" data-interval="false" id="slider1-1" data-rv-view="1500">

    <div class="full-screen">
		<div class="mbr-slider slide carousel" data-pause="true" data-keyboard="true" data-ride="carousel" data-interval="8000">
			<div class="carousel-inner" role="listbox">
				
<!--				<div class="carousel-item slider-fullscreen-image active" data-bg-video-slide="false" style="background-image: url(images/slider1-2000x1333.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
							<div class="mbr-overlay"></div>
							<img src="images/slider1-2000x1333.jpg">
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1">Hace tu pedido online</h2>
									<div class="mbr-section-btn" buttons="0">
										<a class="btn  display-4 btn-danger" href="https://www.tepido.com.ar/migusto">PEDIR AHORA</a> 
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>-->

				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(images/slider/promo_familia.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="images/slider/promocompartir.jpg"/>
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1 sombraText"><em>Promo Clásica</em></h2>
									<p class="lead mbr-text mbr-fonts-style display-5 sombraText3">1 Pizza Muzzarella Grande<br>+ 6 Empanadas a elección</p>
									<div class="circlePrice"><div class="circlePriceTitle">A solo</div><br><div class="circlePricePrice">$490<span class="PriceAster">(*)</span></div></div>
									<div style="display: none;" class="promoNoValida sombraText3">(*) Precio no válido para sucursal Nordelta</div>
								</div>
							</div>
						</div>
					</div>
				</div>
							
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(images/slider/promo_familia_jamon.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="images/slider/promocompartir.jpg"/>
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1 sombraText"><em>Promo Familia</em></h2>
									<p class="lead mbr-text mbr-fonts-style display-5 sombraText3">1/2 Pizza Muzzarella Gigante<br>+ 1/2 Pizza Jamón Gigante <br>+ 8 Empanadas a elección <br>+ Sorpresa</p>
									<div class="circlePrice"><div class="circlePriceTitle">A solo</div><br><div class="circlePricePrice">$685<span class="PriceAster">(*)</span></div></div>
									<div style="display: none;" class="promoNoValida sombraText3">(*) Precio no válido para sucursal Nordelta y Palermo</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url('images/slider/promocompartir.jpg');">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="images/slider/promocompartir.jpg"/>
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1 sombraText"><em>Promo Compartir</em></h2>
									<p class="lead mbr-text mbr-fonts-style display-5 sombraText3">1/2 Pizza Napolitana Gigante<br>+ 1/2 Pizza Jamón y Morrón Gigante <br>+ 6 Empanadas a elección</p>
									<div class="circlePrice"><div class="circlePriceTitle">A solo</div><br><div class="circlePricePrice">$595<span class="PriceAster">(*)</span></div></div>
									<div style="display: none;" class="promoNoValida sombraText3">(*) Precio no válido para sucursal Nordelta</div>
								</div>
							</div>
						</div>
					</div>
				</div>

				<div class="carousel-item slider-fullscreen-image active" data-bg-video-slide="false" style="background-image: url('images/promoamigos.jpg');">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="images/promoamigos.jpg">
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1 sombraText"><em>Promo Amigos</em></h2>
									<p class="lead mbr-text mbr-fonts-style display-5 sombraText3">1 Pizza Muzzarella Gigante<br>+ 1 Pizza Jamón y Morrones Gigante<br>+ 1 Pizza Fugazzeta Gigante</p>
									<div class="circlePrice"><div class="circlePriceTitle">A solo</div><br><div class="circlePricePrice">$990<span class="PriceAster">(*)</span></div></div>
									<div style="display: none;" class="promoNoValida sombraText3">(*) Precio no válido para sucursal Nordelta</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(images/slider/promo_pareja.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="images/slider/promo_pareja.jpg">
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1 sombraText"><em>Promo Pareja</em></h2>
									<p class="lead mbr-text mbr-fonts-style display-5 sombraText3">1/2 Pizza Muzzarella Grande <br>+ 1/2 Pizza Jamón y Morrón Grande <br>+ 2 Empanadas</p>
									<div class="circlePrice"><div class="circlePriceTitle">A solo</div><br><div class="circlePricePrice">$385<span class="PriceAster">(*)</span></div></div>
									<div style="display: none;" class="promoNoValida sombraText3">(*) Precio no válido para sucursal Nordelta</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				
				
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(images/slider/promoSugerida.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="images/slider/promoSugerida.jpg">
							<div class="carousel-caption justify-content-center">
								<div class="col-10 align-right">
									<h2 class="mbr-fonts-style display-1 sombraText"><em>Promo Sugerida</em></h2>
									<p class="lead mbr-text mbr-fonts-style display-5 sombraText3">3 Empanadas a elección<br>+ 1 Gaseosa de 220ml</p>
									<div class="circlePrice"><div class="circlePriceTitle">A solo</div><br><div class="circlePricePrice">$150<span class="PriceAster">(*)</span></div></div>
									<div style="display: none;" class="promoNoValida sombraText3">(*) Precio no válido para sucursal Nordelta</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				

			</div>
			
			<a data-app-prevent-settings="" class="carousel-control carousel-control-prev" role="button" data-slide="prev" href="#slider1-1">
				<span aria-hidden="true" class="mbri-left mbr-iconfont"></span>
				<span class="sr-only">Previous</span>
			</a>
			<a data-app-prevent-settings="" class="carousel-control carousel-control-next" role="button" data-slide="next" href="#slider1-1">
				<span aria-hidden="true" class="mbri-right mbr-iconfont"></span><span class="sr-only">Next</span>
			</a>
		</div>
	</div>

</section>

<section hidden="hidden" class="features1 cid-qzdDzrEMOr" id="features1-2" data-rv-view="1512">
    
    

    
    <div class="container">
        <div class="media-container-row">

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-map-pin" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5 animated fadeInUp">LOCAL</h4>
                    <p class="mbr-text mbr-fonts-style display-7 animated fadeInUp">Vení a Nuestros locales y conoce lo nuestras novedades para la toma de pedidos.</p>
                </div>
            </div>

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-touch" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5 animated fadeInUp">APP</h4>
                    <p class="mbr-text mbr-fonts-style display-7 animated fadeInUp">Hace tu pedido desde nuestra APP.</p>
                </div>
            </div>

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-responsive" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5 animated fadeInUp">
                        LLAMANOS</h4>
                    <p class="mbr-text mbr-fonts-style display-7 animated fadeInUp">
                        Hace tu pedido de la forma tradicional, Llamanos</p>
                </div>
            </div>

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-desktop" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5 animated fadeInUp">
                        WEB</h4>
                    <p class="mbr-text mbr-fonts-style display-7 animated fadeInUp">
                       Podes pedir ahora mismo!</p>
                </div>
            </div>
					
        </div>

    </div>

</section>

<section class="section-table cid-qzdN9H5yxm mbr-parallax-background" id="table1-b" data-rv-view="1518" data-jarallax-original-styles="null" style="z-index: 0; position: relative; background-image: none; background-attachment: scroll; background-size: auto;">

  
  <div class="mbr-overlay" style="opacity: 0.5; background-color: rgb(35, 35, 35);">
  </div>
  <div class="container container-table">
      <h2 class="mbr-section-title mbr-fonts-style align-center pb-3 display-1"><strong style="color: white;">Empanadas De Verdad</strong></h2>
      
      <div class="table-wrapper">
        <div class="container">
          
        </div>

        <div class="container">
          <table class="table dataTable" cellspacing="0" id="DataTables_Table_0">
            <tbody id="body_empanadas">
        <% cargar(2, 9999); %>
                 <% foreach (var comidas in comidas) { %>
                <tr>	
                    <td class="body-item mbr-fonts-style display-5"><%=comidas.Nombre%></td>
                    <td class="body-item mbr-fonts-style display-5"><%=comidas.Nombre%></td>
                </tr>
                <% } %>
            </tbody>
          </table>
        </div>
        <div class="container table-info-container">
          
        </div>
      </div>
    </div>
<div id="jarallax-container-0" style="position: absolute; top: 0px; left: 0px; width: 100%; height: 100%; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -100;"><div style="background-position: 50% 50%; background-size: 100%; background-repeat: no-repeat; background-image: url(images/bg4-1024x640.jpg;); position: fixed; top: 0px; left: 0px; width: 1561.09px; height: 1040.4px; overflow: hidden; pointer-events: none; margin-left: -100.045px; margin-top: -333.2px; visibility: visible; transform: translate3d(0px, 365.269px, 0px);"></div></div></section>

<section class="section-table cid-qDvYJkZRzr mbr-parallax-background" id="table1-h" data-rv-view="1597" data-jarallax-original-styles="null" style="z-index: 0; position: relative; background-image: none; background-attachment: scroll; background-size: auto;">

  
  <div class="mbr-overlay" style="opacity: 0.5; background-color: rgb(35, 35, 35);">
  </div>
  <div class="container container-table">
      <h2 class="mbr-section-title mbr-fonts-style align-center pb-3 display-1"><strong style="color: white;">
          Pizzas Especiales</strong></h2>
      
      <div class="table-wrapper">
        <div class="container">
          
        </div>

        <div class="container scroll">
          <table class="table" cellspacing="0">

            <tbody id="body_pizzas">
                <% cargar(1, 6); %>
                 <% foreach (var comidas in comidas) { %>
                <tr>	
                    <td class="body-item mbr-fonts-style display-5"><%=comidas.Nombre%></td>
                    <td class="body-item mbr-fonts-style display-5"><%=comidas.Nombre%></td>
                </tr>
                <% } %>
            </tbody>
          
					</table>
        </div>
        <div class="container table-info-container">
          
        </div>
      </div>
    </div>
<div id="jarallax-container-1" style="position: absolute; top: 0px; left: 0px; width: 100%; height: 100%; overflow: hidden; pointer-events: none; visibility: hidden; z-index: -100;">
    <div style="background-position: 50% 50%; background-size: 100%; background-repeat: no-repeat; background-image: url(&quot;images/bg1-1024x640.jpg&quot;); position: fixed; top: 0px; left: 0px; width: 1964.42px; height: 1309.2px; overflow: hidden; pointer-events: none; margin-left: -301.708px; margin-top: -467.6px; visibility: visible; transform: translate3d(0px, 422.869px, 0px);"></div>

</div>

</section>

  <script src="js/jquery.min.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="js/tether.min.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/mooth-scroll/smooth-scroll.js"></script>
  <script src="js/script.min.js"></script>
  <script src="js/jquery.touch-swipe.min.js"></script>
  <script src="js/jquery.viewportchecker.js"></script>
  <script src="js/jquery.mb.vimeo_player.js"></script>
  <script src="js/jarallax.min.js"></script>
  <script src="js/bootstrap-carousel-swipe/bootstrap-carousel-swipe.js"></script>
  <script src="js/social-likes.js"></script>
  <script src="js/jquery.data-tables.min.js"></script>
  <script src="js/data-tables.bootstrap4.min.js"></script>
  <script src="js/jquery.mb.ytplayer.min.js"></script>
  <script src="js/script.js"></script>

  <script src="js/formoid.min.js"></script>

  
  
 <div id="scrollToTop" class="scrollToTop mbr-arrow-up" style="display: none;">
     <a style="text-align: center;"><i class="mbri-down mbr-iconfont"></i></a>

 </div>
    
  

<!-- INI Modal FranList -->
  <div class="modal fade" id="ModalFranList" role="dialog">
    <div class="modal-dialog modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title item_form animated fadeInUp" style="width: 100%; text-align: center;">Locales</h5>
        </div>
        <div class="modal-body">
						
						<div class="center w100" id="ModalFranListContent"></div>
						
        </div>
        <div style="width: 100%; text-align: center;">
          <button type="button" id="btn2_fran" class="btn btn-default btn-form display-4 btn_modal item_form animated fadeInUp" data-dismiss="modal">Salir</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal FranList -->

<!-- INI Modal Popup -->
  <div class="modal fade" id="ModalPopUp" role="dialog">
    <div class="modal-dialog">
      <div class="modal-content" style="border-radius: 0px;">
        <div class="modal-header" style="border: 0px;">
          <button style="right: 8px; position: absolute;" type="button" class="close item_form animated fadeInUp" data-dismiss="modal">×</button>
        </div>
        <div class="modal-body">

					<img class="item_form animated fadeInUp" id="img_popup" style="width: 100%;">
					<iframe class="item_form" id="video_popup" width="100%" height="300px" src="" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen=""></iframe>
        	<br>
          <div style="text-align: center">
            <button class="btn btn-default pointer animated fadeInUp" style="margin-bottom: -10px;" type="button" data-dismiss="modal">Cerrar</button>
          </div>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal Popup -->

<!-- INI Modal Pedir -->
  <div id="ModalPedir">
    <iframe id="ModalPedirIframe" width="100%" height="100%" frameborder="0"></iframe>
  </div>
<!-- FIN Modal Pedir -->

<script>


function fcn_goToTP(){
	
	window.open('Pedidos.aspx', '_blank');
	
	return;	
}

</script>

<div style="position: absolute; left: 0px; top: -2px; height: 1px; overflow: hidden; visibility: hidden; width: 1px;">
    <span style="position: absolute; font-size: 300px; width: auto; height: auto; margin: 0px; padding: 0px; font-family: Roboto, Arial, sans-serif;">BESbswy</span>

</div>

</body>
</html>
