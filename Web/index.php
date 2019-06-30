<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="shortcut icon" href="assets/images/favicon.ico" type="image/x-icon">
  <meta name="description" content="">
  <title>Mi Gusto · Empanadas y pizzas</title>
  
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css">
	
  <link rel="stylesheet" href="assets/web/assets/mobirise-icons/mobirise-icons.css">
  <link rel="stylesheet" href="assets/tether/tether.min.css">
  <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
  <link rel="stylesheet" href="assets/bootstrap/css/bootstrap-grid.min.css">
  <link rel="stylesheet" href="assets/bootstrap/css/bootstrap-reboot.min.css">
  <link rel="stylesheet" href="assets/dropdown/css/style.css">
  <link rel="stylesheet" href="assets/animate.css/animate.min.css">
  <link rel="stylesheet" href="assets/socicon/css/styles.css">
  <link rel="stylesheet" href="assets/data-tables/data-tables.bootstrap4.min.css">
  <link rel="stylesheet" href="assets/theme/css/style.css?v3">
  <link rel="stylesheet" href="assets/mobirise/css/mbr-additional.css" type="text/css">
  
	<style>
		.modal-footer{
			display: block;
		}
			
		.btn_modal{
			border-radius: 80px;
		}
			
		.center{
			text-align: center;
		}
		
		.w100{
			width: 100%;
		}
		
		.main_local{
			padding: 5px;
			float: left;
		}
		
		.content_local{
			border: solid 1px #ff001d;
			border-radius: 3px;
			padding: 5px;
			height: 175px;
		}
		
		.nom_local{
			font-size: 20px;
			font-weight: bold;
		}
		
		.info_local{
			font-size: 13px;
		}
		
		.div_bar_left{
			background-color: #ff001d;
	    float: left;
	    height: 174px;
	    width: 15px;
	    margin: -5px;
		}
		
		.progress-bar{
			background-color: green;
		}
		
		.btnEncuesta{
			width: auto;
			border: solid 1px;
			font-weight: bold;
			display: inline-block;
		}
		
		.btnEncuesta100{
			width: 100%;
		}
		
		.btnGreen{
			background-color: green;
			color: white;
		}
		
		.btnRed{
			background-color: red;
			color: white;
		}
		
		.btnOrange{
			background-color: orange;
			color: white;
		}
		
		.ButtonMarkSurvey{
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
		
		.BtnMark{
			background-color: green;
			color: white;
		}

		#dni_comment{
			color: #dc3545;
			margin-top: -1px;
			border-bottom-left-radius: 5px;
			border-bottom-right-radius: 5px;
			font-size: 12px;
			padding: 5px;
		}
		
		#dniLoading{
			position: absolute;
			top: 15px;
			right: 25px;
		}
		
		.circlePrice{
			padding: 10px;
			float: right;
			background-color: #ababab94;
			background-color: #ff001d99;
			border-radius: 100%;
			height: 120px;
			width: 120px;
		}
		
		.circlePriceTitle{
			font-size: 12px;
			width: 100%;
			text-align: center;
		}

		.circlePricePrice{
			font-size: 40px;
			width: 100%;
			text-align: center;
			margin-top: -22px;
		}
		
		.promoNoValida{
			font-size: 10px;
			float: right;
    	width: 100%;
			margin-top: 20px;
		}
		
		.PriceAster{
			font-size: 10px; 
			position: absolute; 
			margin-top: 12px;
		}
		
		.sucItem{
			border: solid 1px #ff001d;
	    padding: 5px;
	    border-left: solid 10px #ff001d;
	    border-radius: 5px;
	    padding-left: 10px;
	    margin-bottom: 8px;
		}
		
		.sucTitle{
	    font-weight: bold;
	    font-size: 18px;
		}
		
		.sucDir{
			font-size: 17px;
		}
		
		.sucTels{
			font-size: 15px;
		}
		
		.btnVerTodSuc{
			background-color: #ff001d;
			border-color: #ff001d;
			border-radius: 5px;
		}
		
		.btnVerTodSuc:hover{
			background-color: #c60018;
			border-color: #c60018;
		}

		.btnVerTodSuc:focus{
			background-color: #c60018;
			border-color: #c60018;
		}
		
		#listaSucursales{
	    float: left;
	    background-color: white;
	    height: 20rem;
	    width: 100%;
	    padding: 5px;
	    overflow-y: scroll;
		}
		
		#distLoc{
			font-size: 15px;
			color: #555;
		}
		
		.sombraBox{
			box-shadow: 0 10px 30px -12px rgba(0, 0, 0, 0.42), 0 4px 25px 0px rgba(0, 0, 0, 0.12), 0 8px 10px -5px rgba(0, 0, 0, 0.2);
		}
		
		.sombraText{
		    text-shadow: 4px 4px 8px #000;
		}
		
		.sombraText2{
			text-shadow: 3px 3px 3px #000;
		}
		
		#ModalPedir{
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
    
    .pointer{
      cursor: pointer;
    }
    
    .bgNav{
      background-color: #ff001d99;
    }
    
    .bgNavLeft{
      border-bottom-left-radius: 5px;
      border-top-left-radius: 5px;
    }
    
    .bgNavRight{
      border-bottom-right-radius: 5px;
      border-top-right-radius: 5px;
    }
    
    .sombraText3{
      text-shadow: 1px 0 0 #000, -1px 0 0 #000, 0 1px 0 #000, 0 -1px 0 #000, 1px 1px #000, -1px -1px 0 #000, 1px -1px 0 #000, -1px 1px 0 #000;
    }
    
    .cid-qzdDlyAR9g P{
      font-weight: bold;
    }
		
		@media only screen and (max-width: 400px) {

		}
		
		@media (max-width: 600px) and (orientation: landscape){
			.circlePricePrice{
				font-size: 30px;
				margin-top: -12px;
			}
		}
    
    @media (min-width: 991px){
      
      #BtnPedidoMobile{
        display: none;
        position: absolute;
        right: 55px;
        top: 5px;
        font-family: 'Muli', sans-serif !important;
      }
      
      #BtnPedidoDesktop{
        display: block;
      }
      
    }
    
    @media (max-width: 991px){
      
      #BtnPedidoMobile{
        display: block;
        position: absolute;
        right: 55px;
        top: 5px;
        font-family: 'Muli', sans-serif !important;
      }
      
      #BtnPedidoDesktop{
        display: none;
      }
      
    }
		
		
    ::-webkit-scrollbar{ 
      width: 5px; 
    }
    ::-webkit-scrollbar-button{ 
      
    }
    ::-webkit-scrollbar-track{
      
    }
    ::-webkit-scrollbar-track-piece{
      background-color: #fff;
    }
    ::-webkit-scrollbar-thumb{
      background-color: #ff001d;
    }
    ::-webkit-scrollbar-corner       { /* 6 */ }
    ::-webkit-resizer                { /* 7 */ }
		
	</style>
  
  <!-- Facebook Pixel Code -->
  <script>
    !function(f,b,e,v,n,t,s)
    {if(f.fbq)return;n=f.fbq=function(){n.callMethod?
    n.callMethod.apply(n,arguments):n.queue.push(arguments)};
    if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
    n.queue=[];t=b.createElement(e);t.async=!0;
    t.src=v;s=b.getElementsByTagName(e)[0];
    s.parentNode.insertBefore(t,s)}(window, document,'script',
    'https://connect.facebook.net/en_US/fbevents.js');
    fbq('init', '1050090208486276');
    fbq('track', 'PageView');
  </script>
  <noscript><img height="1" width="1" style="display:none"
    src="https://www.facebook.com/tr?id=1050090208486276&ev=PageView&noscript=1"
  /></noscript>
  <!-- End Facebook Pixel Code -->
  
  <!-- Global site tag (gtag.js) - Google Analytics -->
  <script async src="https://www.googletagmanager.com/gtag/js?id=UA-115869006-1"></script>
  <script>
    window.dataLayer = window.dataLayer || [];
    function gtag(){dataLayer.push(arguments);}
    gtag('js', new Date());

    gtag('config', 'UA-115869006-1');
    
    gtag('config', 'AW-765785862');
  </script>
  
</head>

<body>
<section class="menu cid-qzdD9AioF0" once="menu" id="menu1-0" data-rv-view="1498">

    

    <nav class="navbar navbar-expand beta-menu navbar-dropdown align-items-center navbar-fixed-top navbar-toggleable-sm bg-color transparent">
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
                         <!--<img src="assets/images/logo-324x207.png" alt="Mobirise" title="" media-simple="true" style="height: 7rem;">-->
                         <img src="assets/images/logo.png" alt="Mi Gusto Empanadas de Verdad" title="" media-simple="true" style="height: 8rem;" class="animated bounceIn">
                         <div class="navbar-slogan" style="font-size: 12px; color: white; text-align: center;">Empanadas de Verdad</div>
                         <div class="navbar-slogan" style="font-size: 20px; color: white; text-align: center;">Desde 1999</div>
                    </a>
                </span>
                
            </div>
        </div>
        <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <ul class="navbar-nav nav-dropdown nav-right" data-app-modern-menu="true">
            	
              <li class="nav-item" style="display: block;">
              	<button id="BtnPedidoDesktop" href="#" onclick="fcn_goToTP();" target="_blank" style="padding-bottom: 4px; margin-top: 2px; height: 50px;" type="button" class="btn btn-primary btn-form display-4 btn_modal btnVerTodSuc animated infinite pulse sombraBox">HACÉ TU PEDIDO</button>
              </li>
            	
            	<li class="nav-item bgNav bgNavLeft">
                    <a class="nav-link link text-white display-5" href="#top">
                        
                        Inicio</a>
                </li>
                       
                       <li class="nav-item bgNav"><a class="nav-link link text-white display-5" href="index.html#table1-b">
                        
                        Productos</a></li><li class="nav-item bgNav"><a class="nav-link link text-white display-5" href="index.html#form4-6">
                        Sucursales</a></li>
                        <li  class="nav-item bgNav"><a class="nav-link link text-white display-5" href="index.html#header3-7">
                        Franquicias</a></li>
                        <li class="nav-item bgNav"><a class="nav-link link text-white display-5" href="index.html#info3-g">
                        Nosotros</a></li>
                        <li class="nav-item bgNav bgNavRight">
                        	<a class="nav-link link text-white display-5" href="index.html#form1-c">
                        		Contacto
                        	</a>
                        </li>
                        
                        
                        </ul>
            
        </div>
    </nav>
</section>

<section class="carousel slide cid-qzdDlyAR9g" data-interval="false" id="slider1-1" data-rv-view="1500">

    <div class="full-screen">
		<div class="mbr-slider slide carousel" data-pause="true" data-keyboard="true" data-ride="carousel" data-interval="8000">
			<div class="carousel-inner" role="listbox">
				
<!--				<div class="carousel-item slider-fullscreen-image active" data-bg-video-slide="false" style="background-image: url(assets/images/slider1-2000x1333.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
							<div class="mbr-overlay"></div>
							<img src="assets/images/slider1-2000x1333.jpg">
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

				<div class="carousel-item slider-fullscreen-image active" data-bg-video-slide="false" style="background-image: url(assets/images/slider/promo_familia.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="assets/images/slider/promo_compartir.jpg">
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
							
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(assets/images/slider/promo_familia_jamon.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="assets/images/slider/promo_compartir.jpg">
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
				
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(assets/images/slider/promo_compartir.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="assets/images/slider/promo_compartir.jpg">
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

				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(assets/images/slider/promo_amigos.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="assets/images/slider/promo_amigos.jpg">
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
				
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(assets/images/slider/promo_pareja.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="assets/images/slider/promo_pareja.jpg">
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
				
				
				<div class="carousel-item slider-fullscreen-image" data-bg-video-slide="false" style="background-image: url(assets/images/slider/promoSugerida.jpg);">
					<div class="container container-slide">
						<div class="image_wrapper">
              <div class="mbr-overlay"></div>
							<img src="assets/images/slider/promoSugerida.jpg">
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
                    <h4 class="card-title py-3 mbr-fonts-style display-5">LOCAL</h4>
                    <p class="mbr-text mbr-fonts-style display-7">Vení a Nuestros locales y conoce lo nuestras novedades para la toma de pedidos.</p>
                </div>
            </div>

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-touch" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5">APP</h4>
                    <p class="mbr-text mbr-fonts-style display-7">Hace tu pedido desde nuestra APP.</p>
                </div>
            </div>

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-responsive" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5">
                        LLAMANOS</h4>
                    <p class="mbr-text mbr-fonts-style display-7">
                        Hace tu pedido de la forma tradicional, Llamanos</p>
                </div>
            </div>

            <div class="card p-3 col-12 col-md-6 col-lg-3">
                <div class="card-img pb-3">
                    <span class="mbr-iconfont mbri-desktop" style="color: rgb(255, 51, 102);" media-simple="true"></span>
                </div>
                <div class="card-box">
                    <h4 class="card-title py-3 mbr-fonts-style display-5">
                        WEB</h4>
                    <p class="mbr-text mbr-fonts-style display-7">
                       Podes pedir ahora mismo!</p>
                </div>
            </div>
					
        </div>

    </div>

</section>

	
	
<section class="cid-qzdDOlGyGz" id="social-buttons1-3" data-rv-view="1515">
    
       

    <div class="container">
        <div class="media-container-row">
            <div class="col-md-8 align-center">
                <h2 hidden="hidden" class="pb-3 mbr-section-title mbr-fonts-style display-5"><strong style="font-size: 30px;">
                    LINEA DIRECTA DE ATENCION AL CLIENTE<br>011 3158-4466
                </strong></h2>
							
                <h2 class="pb-3 mbr-section-title mbr-fonts-style display-5"><strong>
                    COMPARTÍ NUESTRA PÁGINA!
                </strong></h2>
							
                <div>
                    <div class="mbr-social-likes" data-counters="false">
                        <span class="btn btn-social facebook mx-2" title="Share link on Facebook">
                            <i class="socicon socicon-facebook"></i>
                        </span>
                        <span class="btn btn-social twitter mx-2" title="Share link on Twitter">
                            <i class="socicon socicon-twitter"></i>
                        </span>
                        <span class="btn btn-social plusone mx-2" title="Share link on Google+">
                            <i class="socicon socicon-googleplus"></i>
                        </span>
                        
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
	
	


<section class="section-table cid-qzdN9H5yxm mbr-parallax-background" id="table1-b" data-rv-view="1518">

  
  <div class="mbr-overlay" style="opacity: 0.5; background-color: rgb(35, 35, 35);">
  </div>
  <div class="container container-table">
      <h2 class="mbr-section-title mbr-fonts-style align-center pb-3 display-1"><strong style="color: white;">Empanadas De Verdad</strong></h2>
      
      <div class="table-wrapper">
        <div class="container">
          
        </div>

        <div class="container scroll">
          <table class="table" cellspacing="0">
            <tbody id="body_empanadas">
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
						</tbody>
          </table>
        </div>
        <div class="container table-info-container">
          
        </div>
      </div>
    </div>
</section>

<section class="section-table cid-qDvYJkZRzr mbr-parallax-background" id="table1-h" data-rv-view="1597">

  
  <div class="mbr-overlay" style="opacity: 0.5; background-color: rgb(35, 35, 35);">
  </div>
  <div class="container container-table">
      <h2 class="mbr-section-title mbr-fonts-style align-center pb-3 display-1"><strong style="color: white;">
          Pizzas De Verdad</strong></h2>
      
      <div class="table-wrapper">
        <div class="container">
          
        </div>

        <div class="container scroll">
          <table class="table" cellspacing="0">

            <tbody id="body_pizzas">
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
							<tr><td></td></tr>
						</tbody>
          
					</table>
        </div>
        <div class="container table-info-container">
          
        </div>
      </div>
    </div>
</section>

<section class="mbr-section form4 cid-qzdEkUMwH4" id="form4-6" data-rv-view="1634">

    

    
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div style="display: none;" class="google-map" id="mapa_google"></div>
            </div>
            <div class="col-md-6">
                
                <h2 class="pb-3 align-left mbr-fonts-style display-2">
                    Sucursales <br>
                </h2>
                
                <div id="listaSucursales">
                	
                	<div id="sucMasCercana"></div>
	                
	                <div class="center">
	                	<button href="#form4-6" onclick="fcn_LoadlistaLoc();" type="button" class="btn btn-primary btn-form display-4 btn_modal btnVerTodSuc">Ver todas las sucursales</button>
	                </div>
                
                </div>
                
            </div>
        </div>
    </div>
</section>

<section  class="header3 cid-qzdEwOFIXb mbr-fullscreen mbr-parallax-background" id="header3-7" data-rv-view="1637">

    

    <div class="mbr-overlay" style="opacity: 0.7; background-color: rgb(0, 0, 0);">
    </div>

    <div class="container">
        <div class="media-container-row">
            <div class="mbr-figure" style="width: 55%;">
                <img src="assets/images/logo.png" alt="Mi Gusto Empanadas de Verdad" title="" media-simple="true">
            </div>

            <div class="media-content">
                <h1 class="mbr-section-title mbr-white pb-3 mbr-fonts-style display-1">
                    Franquicias</h1>
                
                <div class="mbr-section-text mbr-white pb-3 ">
                    <p class="mbr-text mbr-fonts-style display-5">
                    	
                  Siendo una empresa joven y con gran crecimiento en los últimos años, nos enorgullece ofrecerte la posibilidad de pertenecer a nuestra firma.
											
									<br>Algunas características de nuestra franquicia: 
                  <br> 	
                  <br>- No es necesario contar con experiencia en gastronomía&nbsp;
                  <br>- Todos nuestros productos son frescos, para mantener Óptimos sus sabores y tener un mínimo de desperdicio.
									<br>- Flota refrigerada propia para la distribución de productos e insumos.
									<br>- Contamos con una importante fábrica con la última tecnología para la elaboración de nuestros productos.
									<br>- Capacitación constante de franquiciados y apoyo operativo.
									<br>- Herramientas de marketing directo y apoyo publicitario.</p>
                </div>
                <div class="mbr-section-btn"><a class="btn btn-md btn-primary display-4" href="#header3-7" onclick="fcn_open_contact('F');">Contactanos</a></div>
            </div>
        </div>
    </div>

</section>

<section class="mbr-section info3 cid-qDvRrn8t8m mbr-parallax-background" id="info3-g" data-rv-view="1640">

    

    <div class="mbr-overlay" style="opacity: 0.5; background-color: rgb(35, 35, 35);">
    </div>

    <div class="container">
        <div class="row justify-content-center">
            <div class="media-container-column title col-12 col-md-10">
                <h2 class="align-left mbr-bold mbr-white pb-3 mbr-fonts-style display-2">
                    NOSOTROS</h2>
                <h3 style="font-size: 25px;" class="mbr-section-subtitle align-left mbr-light mbr-white pb-3 mbr-fonts-style display-5">En Mi Gusto nos preocupamos por ofrecerte una excelente propuesta. 
<div>
</div><br><div><br></div><div>Productos elaborados con materias primas de la más alta calidad. Contamos con la más moderna tecnología para la elaboración de nuestras pizzas y empanadas. Exquisitos sabores que harán de tus almuerzos y cenas momentos únicos. 
</div><div><br></div><br><div>
</div><div>Gracias por elegirnos, 
</div><div>porque Mi Gusto es Diferente.</div></h3>
                <p class="mbr-text align-left mbr-white mbr-fonts-style display-7"></p>
                
            </div>
        </div>
    </div>
</section>

<section class="mbr-section form1 cid-qzzEfest0i" id="form1-c" data-rv-view="1643">

    

    
    <div class="container">
        <div class="row justify-content-center">
            <div class="title col-12 col-lg-8">
                <h2 class="mbr-section-title align-center pb-3 mbr-fonts-style display-2">
                    CONTACTANOS<br>
                </h2>
                
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row justify-content-center">
            <div class="media-container-column col-lg-8" data-form-type="formoid">
                    <div data-form-alert="" hidden="">Gracias por Contactarnos</div>
            
                    <form class="mbr-form" action="" >
                    		<input type="hidden" data-form-email="true" value="r/a2KiVOUz6sj2wibjG1po8vZ4Chj5rDW4K9ohPlj8ahUZ57jT2FuvpIY/nbn6qGZZINihTbe7wNEjNiSmQjAtaHHQOpXQoPmagJOYZfnafxNSR5bz2qu8Jg4B0mSP/8">
                        <div class="row row-sm-offset">
                            <div class="col-md-4 multi-horizontal" data-for="name">
                                <div class="form-group">
                                    <label class="form-control-label mbr-fonts-style display-7" for="name-form1-c"></label>
                                    <input type="text" class="form-control" name="name" data-form-field="Name" required="" placeholder="Nombre" id="name-form1-c">
                                </div>
                            </div>
                            <div class="col-md-4 multi-horizontal" data-for="email">
                                <div class="form-group">
                                    <label class="form-control-label mbr-fonts-style display-7" for="email-form1-c"></label>
                                    <input type="email" class="form-control" name="email" data-form-field="Email" required="" placeholder="Email" id="email-form1-c">
                                </div>
                            </div>
                            <div class="col-md-4 multi-horizontal" data-for="phone">
                                <div class="form-group">
                                    <label class="form-control-label mbr-fonts-style display-7" for="phone-form1-c"></label>
                                    <input type="tel" class="form-control" name="phone" data-form-field="Phone" placeholder="Telefono" id="phone-form1-c">
                                </div>
                            </div>
                        </div>
                        <div class="form-group" data-for="message">
                            <label class="form-control-label mbr-fonts-style display-7" for="message-form1-c"></label>
                            <textarea type="text" class="form-control" name="message" rows="7" data-form-field="Message" placeholder="Mensaje" id="message-form1-c"></textarea>
                        </div>
            						
            						<div style="center" id="divContactMsj"></div>
                        <span class="input-group-btn"><button href="" id="btn_send_contact" onclick="fcn_send_contact();" type="button" class="btn btn-primary btn-form display-4">Enviar</button></span>
                    </form>
            </div>
        </div>
    </div>
</section>

<section class="footer4 cid-qzdFoKKE4v" id="footer4-a" data-rv-view="1646">

    

    

    <div class="container">
        <div class="media-container-row content mbr-white">
            <div class="col-md-3 col-sm-4">
                <div class="mb-3 img-logo">
                    <a href="#top">
                        <!--<img src="assets/images/logo-foot-238x153.png" alt="Mi Gusto" title="" media-simple="true">-->
                        <img src="assets/images/logo.png" alt="Mi Gusto Empanadas de Verdad" title="" media-simple="true">
                    </a>
                    <div style="color: white; font-size: 12px;">Empanadas de Verdad</div>
                </div>
                <p class="mb-3 mbr-fonts-style foot-title display-7"></p>
            </div>
            <div class="col-md-4 col-sm-8">
                <p class="mb-4 foot-title mbr-fonts-style display-7"></p>
                <p class="mbr-text mbr-fonts-style foot-text display-7">
                    <a onclick="fcn_open_contact('P');" style="color: white;">Proveedores</a><br>
					  <a onclick="fcn_open_contact('CV');" style="color: white;">Trabajá con nosotros</a><br>
            <a style="font-size: 12px; color: white;" href="sorteos/Bases_y_condiciones_sorteo_Empanadas_a_tu_Cole_.pdf" target="_blank" style="color: white;">Bases y condiciones sorteo Empanadas a tu Cole</a>
				</p>
            </div>
            <div class="col-md-4 offset-md-1 col-sm-12">
                <p class="mb-4 foot-title mbr-fonts-style display-7">ENCONTRANOS EN LAS REDES</p>
                <div class="social-list pl-0 mb-0">
                        <div class="soc-item">
                            <a href="https://www.facebook.com/migustooficial/" target="_blank">
                                <span class="mbr-iconfont mbr-iconfont-social socicon-facebook socicon" media-simple="true"></span>
                            </a>
                        </div>
                        <div class="soc-item">
                            <a href="https://www.instagram.com/migustooficial/" target="_blank">
                                <span class="mbr-iconfont mbr-iconfont-social socicon-instagram socicon" media-simple="true"></span>
                            </a>
                        </div>
                        
                        
                        
                </div>
            </div>
        </div>
        <div class="footer-lower">
            <div class="media-container-row">
                <div class="col-sm-12">
                    <hr>
                </div>
            </div>
            <div class="media-container-row mbr-white" style="text-align: center;">
                <div class="col-sm-12 copyright">
                    <p class="mbr-text mbr-fonts-style display-7" style="font-size: 12px;">
                      Desarrollado por <br><a href="https://www.datalive.com.ar" target="_blank"><img height="30" src="assets/images/logo_datalive_byn.png"></a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</section>


  <script src="assets/web/assets/jquery/jquery.min.js"></script>
  <script src="assets/popper/popper.min.js"></script>
  <script src="assets/tether/tether.min.js"></script>
  <script src="assets/bootstrap/js/bootstrap.min.js"></script>
  <script src="assets/smooth-scroll/smooth-scroll.js"></script>
  <script src="assets/dropdown/js/script.min.js"></script>
  <script src="assets/touch-swipe/jquery.touch-swipe.min.js"></script>
  <script src="assets/viewport-checker/jquery.viewportchecker.js"></script>
  <script src="assets/jquery-mb-vimeo_player/jquery.mb.vimeo_player.js"></script>
  <script src="assets/jarallax/jarallax.min.js"></script>
  <script src="assets/bootstrap-carousel-swipe/bootstrap-carousel-swipe.js"></script>
  <script src="assets/social-likes/social-likes.js"></script>
  <script src="assets/data-tables/jquery.data-tables.min.js"></script>
  <script src="assets/data-tables/data-tables.bootstrap4.min.js"></script>
  <script src="assets/jquery-mb-ytplayer/jquery.mb.ytplayer.min.js"></script>
  <script src="assets/theme/js/script.js"></script>
  <script src="assets/mobirise-slider-video/script.js"></script>
  <script src="assets/formoid/formoid.min.js"></script>
	<script src="assets/scptsV2.js?V7"></script>
	<script src="assets/survey.js"></script>
  
  
 <div id="scrollToTop" class="scrollToTop mbr-arrow-up"><a style="text-align: center;"><i class="mbri-down mbr-iconfont"></i></a></div>
    <input name="animation" type="hidden">
  


<!-- INI Modal Proveedores -->
  <div class="modal fade" id="ModalProveedores" role="dialog">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title item_form" style="width: 100%; text-align: center;">Proveedores</h5>
        </div>
        <div class="modal-body">
          <form class="form-horizontal" role="form" id="ModalProveedoresForm">
						
          	<div class="row row-sm-offset">
          	    <div class="col-md-6 multi-horizontal" data-for="prov_nombre">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="prov_nombre"></label>
          	            <input type="text" class="form-control item_form" id="prov_nombre" data-form-field="Name" required="" placeholder="Nombre">
          	        </div>
          	    </div>
          	    <div class="col-md-6 multi-horizontal" data-for="prov_rsocial">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="prov_rsocial"></label>
          	            <input type="text" class="form-control item_form" id="prov_rsocial" data-form-field="Name" required="" placeholder="Razón Social">
          	        </div>
          	    </div>

							
          	    <div class="col-md-6 multi-horizontal" data-for="prov_telefono">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="prov_telefono"></label>
          	            <input type="number" class="form-control item_form" id="prov_telefono" data-form-field="Name" required="" placeholder="Teléfono">
          	        </div>
          	    </div>
          	    <div class="col-md-6 multi-horizontal" data-for="prov_mail">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="prov_mail"></label>
          	            <input type="email" class="form-control item_form" id="prov_mail" data-form-field="Email" required="" placeholder="E-mail">
          	        </div>
          	    </div>

							
          	    <div class="col-md-12 multi-horizontal" data-for="prov_mensaje">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="prov_mensaje"></label>
          	            <textarea type="text" class="form-control item_form" id="prov_mensaje" data-form-field="Name" required="" placeholder="Mensaje"></textarea>
          	        </div>
          	    </div>
          	</div>
						
						<div style="center" id="ModalProveedoresMsj"></div>
						
					</form>
        </div>
        <div style="width: 100%; text-align: center;">
					<button type="button" id="btn1_prov" class="btn btn-primary btn-form display-4 btn_modal item_form" onclick="fcn_send_prov();">Enviar</button>
          <button type="button" id="btn2_prov" class="btn btn-default btn-form display-4 btn_modal item_form" data-dismiss="modal">Cancelar</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal Proveedores -->




<!-- INI Modal Fran -->
  <div class="modal fade" id="ModalFran" role="dialog">
    <div class="modal-dialog modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title item_form" style="width: 100%; text-align: center;">Unite a MiGusto</h5>
        </div>
        <div class="modal-body">
          <form class="form-horizontal" role="form" id="ModalFranForm">
						
						<div id="PasoStatus"></div>
						
						<div id="ProgDiv" class="progress" style="color: green;">
							<div style="height: 25px; padding-top: 4px;" id="barraEstadoFranq" class="progress-bar progress-bar-success progress-bar-striped" role="progressbar" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width:33%"> <span class="sr-only">Paso 1/3</span> Paso 1/3 </div>
						</div>
						
						<div id='DivPaso1'>
							<div class="row row-sm-offset">
									<div class="col-md-6 multi-horizontal" data-for="fran_nombre">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_nombre"></label>
													<input type="text" class="form-control item_form" id="fran_nombre" data-form-field="Name" required="" placeholder="Nombre">
											</div>
									</div>
									<div class="col-md-6 multi-horizontal" data-for="fran_apellido">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_apellido"></label>
													<input type="text" class="form-control item_form" id="fran_apellido" data-form-field="Name" required="" placeholder="Apellido">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_fenac">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_fenac"></label>
													<input type="text" class="form-control item_form" id="fran_fenac" data-form-field="Name" required="" placeholder="Fecha nacimiento. Ej.: 19/05/1988">
											</div>
									</div>

									<div class="col-md-6 multi-horizontal" data-for="fran_sexo">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_sexo"></label>

												  <select type="text" class="form-control item_form" id="fran_sexo">
          	            		<option value="">Sexo</option>
														<option value="Masculino">Masculino</option>
														<option value="Femenino">Femenino</option>
													</select>
										
										</div>
									</div>

									<div class="col-md-6 multi-horizontal" data-for="fran_ecivil">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_ecivil"></label>

												  <select type="text" class="form-control item_form" id="fran_ecivil">
          	            		<option value="">Estado civil</option>
														<option value="Soltero/a">Soltero/a</option>
														<option value="Casado/a">Casado/a</option>
														<option value="Divorciado/a">Divorciado/a</option>
														<option value="Viudo/a">Viudo/a</option>
													</select>
										
										</div>
									</div>
									
									<div class="col-md-6 multi-horizontal"></div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_tipodoc">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_tipodoc"></label>

												  <select type="text" class="form-control item_form" id="fran_tipodoc">
          	            		<option value="">Tipo de documento</option>
														<option value="DNI">DNI</option>
														<option value="Pasaporte">Pasaporte</option>
														<option value="LE">LE</option>
														<option value="LC">LC</option>
														<option value="Cédula">Cédula</option>
														<option value="Otro">Otro</option>

													</select>
										
										</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_numdoc">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_numdoc"></label>
													<input type="text" class="form-control item_form" id="fran_numdoc" data-form-field="Name" required="" placeholder="Número de documento">
											</div>
									</div>
							
							</div>
								
          	</div>
						
						
						<div id="DivPaso2">
					
							<div class="row row-sm-offset">
								
									<div class="col-md-6 multi-horizontal" data-for="fran_paisres">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_paisres"></label>

												  <select type="text" class="form-control item_form" id="fran_paisres">
          	            		<option value="">País de residencia</option>
														<option value="Argentina">Argentina</option>
														<option value="Chile">Chile</option>
														<option value="Paraguay">Paraguay</option>
														<option value="Uruguay">Uruguay</option>
														<option value="Bolivia">Bolivia</option>
														<option value="Otro">Otro</option>

													</select>
										
										</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_provres">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_provres"></label>
													<input type="text" class="form-control item_form" id="fran_provres" data-form-field="Name" required="" placeholder="Provincia de residencia">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_locres">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_locres"></label>
													<input type="text" class="form-control item_form" id="fran_locres" data-form-field="Name" required="" placeholder="Localidad de residencia">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_domicilio">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_domicilio"></label>
													<input type="text" class="form-control item_form" id="fran_domicilio" data-form-field="Name" required="" placeholder="Domicilio">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_tel">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_tel"></label>
													<input type="number" class="form-control item_form" id="fran_tel" data-form-field="Name" required="" placeholder="Teléfono celular">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_telalter">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_telalter"></label>
													<input type="number" class="form-control item_form" id="fran_telalter" data-form-field="Name" required="" placeholder="Teléfono alternativo">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_email">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_email"></label>
													<input type="text" class="form-control item_form" id="fran_email" data-form-field="Name" required="" placeholder="E-Mail">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_emailalter">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_emailalter"></label>
													<input type="text" class="form-control item_form" id="fran_emailalter" data-form-field="Name" required="" placeholder="E-Mail alternativo">
											</div>
									</div>
							
							</div>
					
						</div>

						<div id="DivPaso3">
							
							<div class="row row-sm-offset">
								
									<div class="col-md-6 multi-horizontal" data-for="fran_paispref">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_paispref"></label>
											
												  <select type="text" class="form-control item_form" id="fran_paispref">
          	            		<option value="">País de preferencia</option>
														<option value="Argentina">Argentina</option>
													</select>
										
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_provpref">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_provpref"></label>
													<input type="text" class="form-control item_form" id="fran_provpref" data-form-field="Name" required="" placeholder="Provincia de preferencia">
											</div>
									</div>
								
									<div class="col-md-6 multi-horizontal" data-for="fran_localidadpref">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_localidadpref"></label>
													<input type="text" class="form-control item_form" id="fran_localidadpref" data-form-field="Name" required="" placeholder="Localidad de preferencia">
											</div>
									</div>
								
									<div class="col-md-12 multi-horizontal" data-for="fran_garant">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_garant"></label>

												  <select type="text" class="form-control item_form" id="fran_garant">
          	            		<option value="">¿Dispone de inmueble para garantía? Propia o de Terceros. (Libre de Gravámenes)</option>
														<option value="SI">SI</option>
														<option value="NO">NO</option>

													</select>
										
										</div>
									</div>
								
									<div class="col-md-12 multi-horizontal" data-for="fran_capital">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_capital"></label>
													<input type="number" class="form-control item_form" id="fran_capital" data-form-field="Name" required="" placeholder="Capital disponible. Ej.: 500.000">								
										</div>
									</div>
								
									<div class="col-md-12 multi-horizontal" data-for="fran_tiempodisp">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_tiempodisp"></label>

												  <select type="text" class="form-control item_form" id="fran_tiempodisp">
          	            		<option value="">¿Qué cantidad de tiempo diario le brindaría al negocio?</option>
														<option value="4 horas">4 horas</option>
														<option value="6 horas">6 horas</option>
														<option value="8 horas">8 horas</option>
														<option value="Mas de 8 horas">Mas de 8 horas</option>

													</select>
										
										</div>
									</div>
								
									<div class="col-md-12 multi-horizontal" data-for="fran_mensaje">
											<div class="form-group">
													<label class="form-control-label mbr-fonts-style display-7" for="fran_mensaje"></label>
													<textarea type="text" class="form-control item_form" id="fran_mensaje" data-form-field="Name" required="" placeholder="¿Cómo se imagina su relación con Mi Gusto a mediano y largo plazo? ¿Qué expectativas tiene?"></textarea>
											</div>
									</div>
								
							</div>
						
						</div>
						
						<div style="center" id="ModalFranMsj"></div>
						
					</form>
        </div>
        <div style="width: 100%; text-align: center;">
					<button type="button" id="btn1_fran" class="btn btn-primary btn-form display-4 btn_modal item_form" onclick="fcn_send_fran();">Enviar</button>
          <button type="button" id="btn2_fran" class="btn btn-default btn-form display-4 btn_modal item_form" onclick="fcn_back_fran();">Cancelar</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal Fran -->


<!-- INI Modal CV -->
  <div class="modal fade" id="ModalCV" role="dialog">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title item_form" style="width: 100%; text-align: center;">Trabajá con nosotros</h5>
        </div>
        <div class="modal-body">
          <form class="form-horizontal" role="form" id="ModalCVForm" enctype="multipart/form-data">
						
          	<div class="row row-sm-offset">
          	    <div class="col-md-6 multi-horizontal" data-for="cv_nombre">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_nombre"></label>
          	            <input type="text" class="form-control item_form" id="cv_nombre" data-form-field="Name" required="" placeholder="Nombre">
          	        </div>
          	    </div>
          	    <div class="col-md-6 multi-horizontal" data-for="cv_apellido">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_apellido"></label>
          	            <input type="text" class="form-control item_form" id="cv_apellido" data-form-field="Name" required="" placeholder="Apellido">
          	        </div>
          	    </div>

							
          	    <div class="col-md-6 multi-horizontal" data-for="cv_telefono">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_telefono"></label>
          	            <input type="number" class="form-control item_form" id="cv_telefono" data-form-field="Name" required="" placeholder="Teléfono">
          	        </div>
          	    </div>
          	    <div class="col-md-6 multi-horizontal" data-for="cv_mail">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_mail"></label>
          	            <input type="email" class="form-control item_form" id="cv_mail" data-form-field="Email" required="" placeholder="E-mail">
          	        </div>
          	    </div>
          	    
          	    
          	    <div class="col-md-6 multi-horizontal" data-for="cv_puesto">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_puesto"></label>
          	            <select type="text" class="form-control item_form" id="cv_puesto">
          	            	<option value=''>Puesto de interés</option>
          	            	<option value='Fabrica'>Fábrica</option>
          	            	<option value='Sucursales'>Sucursales</option>
          	            </select>
          	        </div>
          	    </div>

          	    <div class="col-md-6 multi-horizontal" data-for="cv_sector">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_sector"></label>
          	            <select type="text" class="form-control item_form" id="cv_sector">
          	            </select>
          	        </div>
          	    </div>
          	    
          	    <div class="col-md-12 multi-horizontal" data-for="cv_upload">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7 item_form" for="cv_upload">Adjunte su CV</label>
          	            <input type="file" class="form-control item_form" id="cv_upload" placeholder="Seleccione su CV" buttonText="Seleccionar">
          	        </div>
          	    </div>
							
          	    <div class="col-md-12 multi-horizontal" data-for="cv_mensaje">
          	        <div class="form-group">
          	            <label class="form-control-label mbr-fonts-style display-7" for="cv_mensaje"></label>
          	            <textarea type="text" class="form-control item_form" id="cv_mensaje" data-form-field="Name" required="" placeholder="Mensaje"></textarea>
          	        </div>
          	    </div>
          	</div>
						
						<div style="center" id="ModalCVMsj"></div>
						
					</form>
        </div>
        <div style="width: 100%; text-align: center;">
					<button type="button" id="btn1_cv" class="btn btn-primary btn-form display-4 btn_modal item_form" onclick="fcn_send_cv();">Enviar</button>
          <button type="button" id="btn2_cv" class="btn btn-default btn-form display-4 btn_modal item_form" data-dismiss="modal">Cancelar</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal CV -->


<!-- INI Modal FranList -->
  <div class="modal fade" id="ModalFranList" role="dialog">
    <div class="modal-dialog modal-lg">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title item_form" style="width: 100%; text-align: center;">Locales</h5>
        </div>
        <div class="modal-body">
						
						<div class="center w100" id="ModalFranListContent"></div>
						
        </div>
        <div style="width: 100%; text-align: center;">
          <button type="button" id="btn2_fran" class="btn btn-default btn-form display-4 btn_modal item_form" data-dismiss="modal">Salir</button>
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
          <button style="right: 8px; position: absolute;" type="button" class="close item_form" data-dismiss="modal">&times;</button>
        </div>
        <div class="modal-body">

					<img	  class="item_form" id="img_popup"   style="width: 100%;">
					<iframe class="item_form" id="video_popup" width="100%" height="300px" src="" frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
        	<br>
          <div style="text-align: center">
            <button class="btn btn-default pointer" style="margin-bottom: -10px;" type="button" data-dismiss="modal">Cerrar</button>
          </div>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal Popup -->

<!-- INI Modal GoToAPP -->
  <div class="modal fade animated bounceInDown" id="ModalGoToAPP" role="dialog">
    <div class="modal-dialog" style="margin-top: -12px;">
      <div class="modal-content" style="border-radius: 0px;">
        <div class="modal-body center">
					<br>
					<br>
					<i class="fas fa-question-circle" style="color: #ffc107; font-size: 45px;"></i>
					<br>
					<br>
					<h3>Que desea hacer?</h3><br>
					<button class="btn sombraBox" style="background-color: #fe0000; color: white;" onclick="fcnActGO();"><i class="fas fa-mobile-alt" style="margin: 10px; font-size: 50px;"></i> <span style="font-size: 18px;">Acceder a la APP</span></button>
					<button class="btn sombraBox" style="background-color: #fe0000; color: white;" data-dismiss="modal"><i class="far fa-check-circle" style="margin: 10px; font-size: 25px;"></i> Continuar en la web</button>
					
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal GoToAPP -->


<!-- INI Modal Pedir -->
  <div id="ModalPedir">
    <iframe id="ModalPedirIframe" width="100%" height="100%" frameborder="0"></iframe>
  </div>
<!-- FIN Modal Pedir -->

	
<!-- INI Modal Encuesta -->
  <div class="modal fade" id="ModalEncuesta" role="dialog">
    <div class="modal-dialog modal-lg">
      <div class="modal-content" style="border-radius: 0px;">
        <div class="modal-header" style="border: 0px;">
          <button style="right: 8px; position: absolute;" type="button" class="close item_form" data-dismiss="modal">&times;</button>
        </div>
				
        <div class="modal-body">

					<div class="item_form surveyDiv" id="P0">
						<h3 class="item_form" style="width: 100%; text-align: center;">Participá de la encuesta y obtené 8 empanadas gratis*!</h3>
						<div class="item_form animated infinite pulse" style="width: 100%; text-align: center;">
							<button onclick="fcn_survey('START');" style="margin: 50px;" class="form-control btnEncuesta btnGreen">COMENZAR ENCUESTA AHORA!</button>
						</div>
						<div style="font-size: 10px; width: 100%; text-align: center;">(*) 8 empanadas gratis comprando 1 docena de empanadas.</div>
					</div>
					
					<div class="surveyDiv" id="P1">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿En qué sucursal de Mi Gusto suele realizar sus pedidos?</h3>
						<div class="item_form" style="width: 100%; text-align: center;">

							<form class="form-horizontal" role="form">
								<div class="row row-sm-offset">
										<div class="col-12 multi-horizontal" data-for="sucFrecuente">
												<div class="form-group">
													<select style="margin-top:20px;" type="text" class="form-control item_form" id="sucFrecuente"></select>
												</div>
										</div>
								</div>
							</form>
							
							<button onclick="fcn_survey('NEXT');" class="form-control btnEncuesta btnGreen">CONTINUAR</button>
						</div>
					</div>
					
					<div class="item_form surveyDiv" id="P2">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Cuán satisfecho estás con las compras que hiciste en la sucursal <span id="SurveyNomSuc"></span>?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> INSATISFECHO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> SATISFECHO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MUY SATISFECHO</button>
											</div>
									</div>
							</div>
												
						</div>
					</div>
					
					<div class="surveyDiv" id="P3">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Que cambiaria para que su experiencia de compra sea mejor?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div id="P3_1" onclick="fcn_btn_mark('P3', '1');" class="ButtonMarkSurvey">El tiempo de espera</div>
							<div id="P3_2" onclick="fcn_btn_mark('P3', '2');" class="ButtonMarkSurvey">El servicio de entrega a domicilio</div>
							<div id="P3_3" onclick="fcn_btn_mark('P3', '3');" class="ButtonMarkSurvey">Servicio de mostrador</div>
							<br>
							<button onclick="fcn_survey('NEXT');" class="form-control btnEncuesta btnGreen">CONTINUAR</button>
						</div>
					</div>
					
					<div class="surveyDiv" id="P4">
						<h3 class="item_form" style="width: 100%; text-align: center;">Velocidad del servicio</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> INSATISFECHO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> SATISFECHO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MUY SATISFECHO</button>
											</div>
									</div>
							</div>
						</div>
					</div>
					
					<div class="surveyDiv" id="P5">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Tus pedidos son entregados tal cual los pedis?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> AVECES</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> CASI SIEMPRE</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> SIEMPRE</button>
											</div>
									</div>
							</div>
						</div>
					</div>
					
					<div class="surveyDiv" id="P6">
						<h3 class="item_form" style="width: 100%; text-align: center;">Amabilidad del personal</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MALA</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> BUENA</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MUY BUENA</button>
											</div>
									</div>
							</div>
						</div>
					</div>
					
					<div class="surveyDiv" id="P7">
						<h3 class="item_form" style="width: 100%; text-align: center;">Higiene del local</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MALA</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> BUENA</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MUY BUENA</button>
											</div>
									</div>
							</div>
						</div>
					</div>
					
					<div class="surveyDiv" id="P8">
						<h3 class="item_form" style="width: 100%; text-align: center;">Aspecto del personal</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MALO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> BUENO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MUY BUENO</button>
											</div>
									</div>
							</div>
						</div>
					</div>
					
					<div class="surveyDiv" id="P9">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Cuál es tu nivel de satisfacción con relacion al precio y calidad?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<div class="row row-sm-offset">
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '1');" class="form-control btnEncuesta btnRed btnEncuesta100"><i class="fa fa-frown-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> INSATISFECHO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '2');" class="form-control btnEncuesta btnOrange btnEncuesta100"><i class="fa fa-meh-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> SATISFECHO</button>
											</div>
									</div>
								
									<div class="col-lg-4 multi-horizontal">
											<div class="form-group">
												<button onclick="fcn_survey('NEXT', '3');" class="form-control btnEncuesta btnGreen btnEncuesta100"><i class="fa fa-smile-o" style="font-size: 50px;" aria-hidden="true"></i><br><br> MUY SATISFECHO</button>
											</div>
									</div>
							</div>
						</div>
					</div>
					
					<div class="surveyDiv" id="P10">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Que productos nuevos le gustaría que se comercialice en nuestros locales?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<input id="P10_1" type="text" class="form-control" placeholder="Indique los productos aquí">
							<div id="surveyMsjP10"></div>
							<br>
							<button onclick="fcn_survey('NEXTP10');" class="form-control btnEncuesta btnGreen">CONTINUAR</button>
						</div>
					</div>
					
					<div class="surveyDiv" id="P11">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Que gusto  de pizzas o empanadas le gustaría que agreguemos a nuestra carta?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<input id="P11_1" type="text" class="form-control" placeholder="Indique los gustos aquí">
							<div id="surveyMsjP11"></div>
							<br>
							<button onclick="fcn_survey('NEXTP11');" class="form-control btnEncuesta btnGreen">CONTINUAR</button>
						</div>
					</div>
					
					<div class="surveyDiv" id="P12">
						<h3 class="item_form" style="width: 100%; text-align: center;">¿Como podemos mejorar el servicio?</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							<input id="P12_1" type="text" class="form-control" placeholder="Indique su sugerencia aquí">
							<div id="surveyMsjP12"></div>
							<br>
							<button onclick="fcn_survey('NEXTP12');" class="form-control btnEncuesta btnGreen">CONTINUAR</button>
						</div>
					</div>
					
					<div class="surveyDiv" id="P13">
						<h3 class="item_form" style="width: 100%; text-align: center;">Por favor, ingrese sus datos personales para finalizar la encuesta</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							
							<div class="row row-sm-offset">
									<div class="col-sm-6 multi-horizontal">
											<div class="form-group">
												<input id="surveyNombre" type="text" class="form-control" placeholder="Nombre">
											</div>
									</div>
								
									<div class="col-sm-6 multi-horizontal">
											<div class="form-group">
												<input id="surveyApellido" type="text" class="form-control" placeholder="Apellido">
											</div>
									</div>
							</div>
													
							<div class="row row-sm-offset" style="margin-top: 20px;">
									<div class="col-sm-6 multi-horizontal">
											<div class="form-group">
												<input id="surveyDNI" type="number" min="0" class="form-control" placeholder="DNI">
												<div id="dni_comment">Es necesario ingresar el DNI para validarlo en el local junto con el código de cupón.</div>
												<div id="dniLoading"></div>
											</div>
									</div>
									
									<div class="col-sm-2 multi-horizontal">
											<div class="form-group">
												<div style="position: absolute; width: 500px; margin-top: -25px; text-align: left; color: #868e96;">Fecha de Nacimiento</div>
												<input id="surveyFechaNacDia" type="number" min="1" max="31" class="form-control" placeholder="Día">
											</div>
									</div>
								
									<div class="col-sm-2 multi-horizontal">
											<div class="form-group">
												<input id="surveyFechaNacMes" type="number" min="1" max="12" class="form-control" placeholder="Mes">
											</div>
									</div>
								
									<div class="col-sm-2 multi-horizontal">
											<div class="form-group">
												<input id="surveyFechaNacAno" type="number" min="1900" max="2018" class="form-control" placeholder="Año">
											</div>
									</div>
							</div>
							
							<div class="row row-sm-offset">							
									<div class="col-sm-6 multi-horizontal">
											<div class="form-group">
												<input id="surveyDireccion" type="text" class="form-control" placeholder="Dirección (Opcional)">
											</div>
									</div>
								
									<div class="col-sm-6 multi-horizontal">
											<div class="form-group">
												<input id="surveyTelefono" type="number" min="0" class="form-control" placeholder="Teléfono (Opcional)">
											</div>
									</div>
							</div>
							
							<div class="row row-sm-offset">							
									<div class="col-sm-12 multi-horizontal">
											<div class="form-group">
												<input id="surveyMail" type="text" class="form-control" placeholder="E-mail">
											</div>
									</div>
							</div>
							
							<div id="surveyMsj"></div>
							
							<div class="row row-sm-offset">							
									<div class="col-sm-12 multi-horizontal">
											<div class="form-group">
												<div class="alert alert-success">
													<input checked style="font-size: 8px;" id="surveyNewsletter" type="checkbox" class="form-control"> Por favor confirmá si deseas recibir información de actividades, promociones o nuevas encuestas de Mi Gusto.
												</div>
												
												<div class="alert alert-success" style="background-color: #6eb5ff; font-size: 12px; margin-top: -20px;">
													Todos los datos solicitados son exclusivamente para ser utilizados por la empresa y confirmar la identidad de los usuarios al momento de canjear el voucher. La empresa se compromete a no divulgar y reservar de forma confidencial los mismos.
												</div>
											</div>
									</div>
							</div>
							
							<br>
							<button onclick="fcn_survey('FINISH');" id="surveyFinish" class="form-control btnEncuesta btnGreen">FINALIZAR ENCUESTA</button>
						</div>
					</div>
					
					<div class="surveyDiv" id="P14">
						<h3 class="item_form" style="width: 100%; text-align: center;"><span id="CupCliName"></span>, gracias por completar la encuesta!</h3>
						<div class="item_form" style="width: 100%; text-align: center; padding: 20px;">
							
							<h5>GRATIS 8 EMPANADAS</h5>
							<h6>CON LA COMPRA DE 1 DOCENA</h6>
							<br>
							
							<h4><b style="border: solid 1px; border-radius: 3px; padding: 10px;">CÓDIGO DE CUPON: <span id="CupCode"></span></b></h4>
							
							<br>
							<br>
							<div style="width: 100%; text-align: center; font-size: 12px;">Válido en todos los locales de Mi Gusto Es Diferente desde el <span id="CupFrom"></span> hasta el <span id="CupTo"></span>. <b>Presentando el número de cupón y su DNI</b>, con la compra de 1 docena de empanadas obtenés 8 empandas de regalo. Válido unicamente por mostrador.</div>
							<br>
							<div style="width: 100%; text-align: center; font-size: 12px;"><b>Te enviamos el cupón vía E-mail. En caso de no haberlo recibido, chequea el buzón de spam de tu correo.</b></div>
							<br>
							<button onclick="fcn_survey('EXIT');" class="form-control btnEncuesta btnGreen">SALIR</button>
						</div>
					</div>
										
					<div id="ProgDivEncuesta" class="progress" style="color: green;">
						<div style="height: 25px; padding-top: 4px;" id="barraEstadoEncuesta" class="progress-bar progress-bar-success progress-bar-striped" role="progressbar" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width:33%"> <span class="sr-only">Paso 1/13</span> Paso 1/13 </div>
					</div>
					
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal Encuesta -->

</body>
</html>

<script>

$(document).ready(function(){
  $(this).scrollTop(0);
  
  if( /Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)){
    $("#ModalGoToAPP").modal();
  }
  
});
	
var getUrlParameter = function getUrlParameter(sParam) {
  var sPageURL = decodeURIComponent(window.location.search.substring(1)),
      sURLVariables = sPageURL.split('&'),
      sParameterName,
      i;

  for (i = 0; i < sURLVariables.length; i++) {
      sParameterName = sURLVariables[i].split('=');

      if (sParameterName[0] === sParam) {
          return sParameterName[1] === undefined ? true : sParameterName[1];
      }
  }
};
	
var v_survey = getUrlParameter('survey');

if(v_survey == true || 1==2){
	//$("#ModalEncuesta").modal();
	$("#ModalEncuesta").modal({backdrop: 'static', keyboard: false});
	$(".item_form").removeClass('hidden');
	
	showSurvey();
}
	
$("#cv_puesto").change(function(){
	
	$("#cv_sector").empty();
	$("#cv_sector").hide();
	
	if($("#cv_puesto").val() == 'Fabrica'){
		
		$("#cv_sector").append('<option value="">Área de interés</option>');
		$("#cv_sector").append('<option value="Administración">Administración</option>');
		$("#cv_sector").append('<option value="Producción">Producción</option>');
		$("#cv_sector").append('<option value="Logística">Logística</option>');
		
		$("#cv_sector").show();
		
	}else if($("#cv_puesto").val() == 'Sucursales'){
		
		$("#cv_sector").append('<option value="">Sucursal de interés</option>');
		
		for (i=0;i<i_locales.length;i++){
			
			$("#cv_sector").append('<option value="'+i_locales[i]['Nombre']+'">'+i_locales[i]['Nombre']+'</option>');
			
		}
		
		$("#cv_sector").show();
		
	}
	
});
	
$("#surveyDNI").change(function(){
	fcn_dniCheck();
});


$("#ModalPopUp").on("hidden.bs.modal", function () {
	$("#video_popup").remove();
});

function fcn_goToTP(){
	
	window.open('https://www.tepido.com.ar/migusto', '_blank');
	
	return;
	
	// Abro iframe
	$("#ModalPedir").show();
	
	$("#ModalPedirIframe").attr('src', 'https://www.tepido.com.ar/migusto');
	
	var v_scnHei = window.innerHeight;
	
	$("#ModalPedir").height(v_scnHei+'px');
	
}


function fcnActGO(){
	window.open('https://app.migusto.com.ar', '_self');
}

</script>

<script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAw2b5MBk8UUWyGv9fRtBi0VY_M4B8bmt"></script>




