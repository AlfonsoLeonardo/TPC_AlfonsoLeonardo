<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Web.Home" %>

<!DOCTYPE html>

<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if !IE]><!--> <html lang="en"> <!--<![endif]-->
    <head>
        <meta charset="utf-8">
        <title>Pizzeria</title>
          <!-- Font -->
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:400,600" rel="stylesheet">
        <link rel="stylesheet" href="fonts/beyond_the_mountains-webfont.css" type="text/css"/>

        <!-- Stylesheets -->
        <link href="plugin-frameworks/bootstrap.min.css" rel="stylesheet">
        <link href="plugin-frameworks/swiper.css" rel="stylesheet">
        <link href="fonts/ionicons.css" rel="stylesheet">
        <link href="common/styles.css" rel="stylesheet">
        <!-- Mobile Specific Meta -->
        <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
        <!-- Stylesheets -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css" />
        <link rel="stylesheet" href="Content/flaticon.css" />

        <!-- Animate -->
        <link rel="stylesheet" href="Content/animate.css">
        <!-- Bootsnav -->
        <link rel="stylesheet" href="Content/bootsnav.css">
        <!-- Color style -->
        <link rel="stylesheet" href="Content/color.css">

        <!-- Custom stylesheet -->
        <link rel="stylesheet" href="Content/custom.css" />
        <!--[if lt IE 9]>
                <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
        <![endif]-->
    </head>
    <body data-spy="scroll" data-target="#navbar-menu" data-offset="100">

        <!-- Preloader --> 
        <div id="loading">
            <div id="loading-left" style="background-color: #FF0000; color: #FFFFFF;">
                <div id="loading-center-absolute">
                    <div class="object" id="object_one"></div>
                    <div class="object" id="object_two"></div>
                    <div class="object" id="object_three"></div>
                    <div class="object" id="object_four"></div>
                    <div class="object" id="object_five"></div>
                    <div class="object" id="object_six"></div>
                    <div class="object" id="object_seven"></div>
                    <div class="object" id="object_eight"></div>
                    <div class="object" id="object_big"></div>
                </div>
            </div>
        </div>
        <!--End Preloader -->
        <!-- Navbar -->
         <nav class="navbar navbar-default bootsnav no-background navbar-fixed black" style="background-color: #4440;">
    <a class="navbar-brand" href="#"><img src="images/logo.png" class="logo" alt=""></a>
</nav>

       <nav class="navbar navbar-default bootsnav no-background navbar-fixed black" style="background-color: #4440;">

          
                              <div class="navbar-header" style="    float: right">
                  

                        <a class="navbar-brand"href="HOME" style="font-family: 'Arial Black'; color: #FFFFFF">Inicio</a>
                        
                        <a class="navbar-brand"href="Pedidos"style="font-family: 'Arial Black'; color: #FFFFFF">Catalogo</a>

                        <a class="navbar-brand"href="#"style="font-family: 'Arial Black'; color: #FFFFFF">Contacto</a>
                              
                   

              	<Button id="BtnPedidoDesktop" href="#" onclick="fcn_goToTP();" type="button" class="btn btn-primary btn-form display-4 btn_modal btnVerTodSuc animated infinite pulse sombraBox" style="border-color: #f43438;background-color: #FF0000;margin-top: 12px;padding-top: 2px;padding-bottom: 2px;padding-left: 2px;padding-right: 2px;margin-left: 1‒;margin-right: 8px;" border-color:="" #ff0000";="">HACÉ TU PEDIDO</Button>     
                


                                  
                </div>
        </nav>

        <!-- Header -->
        <header id="hello">
            <!-- Container -->
            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <div class="banner">
                            <h3>-Pizzeria-</h3>
                            <h1>Mi Pizza</h1>

                            <div class="inner_banner">
                                <div class="banner_content">
                                    <p>s.</p><!-- contenedor de pantalla  -->
                                    <p>*.</p><!-- Container end -->							
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div><!-- Container end -->
            <p class="caption">*y</p>
        </header><!-- Header end -->

        <!-- Block Content -->
        <section id="block">
            <div class="container">

                <!-- Second section -->
                <div class="row">
                    <div class="col-md-6">
                        <div class="classic">
                            <a href="" class="classic_btn">classic</a>

                            <div class="overlay">
                                <h3>House-ground hamburger</h3>
                                <p>(served in a grilled rosemary focaccia).</p>

                                <p class="overlay_content">Instead of traditional cucumber pickles, legendary chef-owner Judy Rodgers accents her burgers with thin-cut zucchini strips pickled in apple cider vinegar, mustard seeds and turmeric.</p>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6">
                        <!-- Carousel -->
                        <div id="small_carousel" class="carousel slide" data-ride="carousel">
                            <!-- Indicators -->
                            <ol class="carousel-indicators">
                                <li data-target="#small_carousel" data-slide-to="0" class="active"></li>
                                <li data-target="#small_carousel" data-slide-to="1"></li>
                                <li data-target="#small_carousel" data-slide-to="2"></li>
                            </ol>

                            <div class="carousel-caption">
                                <h3>The Original Burger</h3>
                                <hr />

                                <ul class="list-unstyled nutrition">
                                    <li><a href=""><span class="flaticon flaticon-protein"></span><p>Protein - 33g</p></a></li>
                                    <li><a href=""><span class="flaticon flaticon-carbohydrate"></span><p>Carbohydrates - 46gm</p></a></li>
                                    <li><a href=""><span class="flaticon flaticon-calories"></span><p>Calories - 750 kcal</p></a></li>
                                </ul>
                                <div class="info_btn_shadow">
                                    <a href="" class="info_btn">info & nutrition</a>
                                </div>
                            </div>

                            <!-- carousel inner -->
                            <div class="carousel-inner" role="listbox">
                                <div class="item active">
                                    <img src="images/small_slider_bg.jpg" alt="" />
                                </div>
                                <div class="item">
                                    <img src="images/small_slider_bg.jpg" alt="" />
                                </div>
                                <div class="item">
                                    <img src="images/small_slider_bg.jpg" alt="" />
                                </div>
                            </div><!-- carousel inner end -->
                        </div><!-- Carousel end-->
                    </div>
                </div><!-- second section end -->

                <!-- Third section -->
                <!-- Carousel -->
                <div id="carousel" class="carousel slide" data-ride="carousel">
                    <!-- Indicators -->
                    <ol class="carousel-indicators">
                        <li data-target="#carousel" data-slide-to="0" class="active"></li>
                        <li data-target="#carousel" data-slide-to="1"></li>
                        <li data-target="#carousel" data-slide-to="2"></li>
                    </ol>

                    <!-- carousel inner -->
                    <div class="carousel-inner" role="listbox">
                        <div class="item active">
                            <img src="images/large_slider_img.jpg" alt="Burger">

                            <div class="carousel-caption">
                                <h2>Cheddar JUnky</h2>
                                <h3>Stuffed Burgers</h3>

                                <p>Chef Wesley Genovart makes this over-the-top, Shake Shack–inspired burger with two thin stacked patties, thick-cut bacon, kimchi and a spicy homemade sauce.</p>

                                <div class="info_btn_shadow">
                                    <a href="" class="info_btn">info & nutrition</a>
                                </div>
                            </div>
                        </div>
                        <div class="item">
                            <img src="images/large_slider_img.jpg" alt="Burger">

                            <div class="carousel-caption">
                                <h2>Cheddar JUnky</h2>
                                <h3>Stuffed Burgers</h3>

                                <p>Chef Wesley Genovart makes this over-the-top, Shake Shack–inspired burger with two thin stacked patties, thick-cut bacon, kimchi and a spicy homemade sauce.</p>

                                <div class="info_btn_shadow">
                                    <a href="" class="info_btn">info & nutrition</a>
                                </div>
                            </div>
                        </div>
                        <div class="item">
                            <img src="images/large_slider_img.jpg" alt="Burger">

                            <div class="carousel-caption">
                                <h2>Cheddar JUnky</h2>
                                <h3>Stuffed Burgers</h3>

                                <p>Chef Wesley Genovart makes this over-the-top, Shake Shack–inspired burger with two thin stacked patties, thick-cut bacon, kimchi and a spicy homemade sauce.</p>

                                <div class="info_btn_shadow">
                                    <a href="" class="info_btn">info & nutrition</a>
                                </div>
                            </div>
                        </div>
                    </div><!-- carousel inner end -->
                </div><!-- Carousel end-->

                <!-- Forth section -->
                <div class="row forth_sec">
                    <div class="col-sm-4">
                        <div class="menu">
                            <div class="inner_content">
                                <span class="flaticon flaticon-burger"></span>
                                <h2>menu</h2>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="drinks">
                            <div class="inner_content">
                                <span class="flaticon flaticon-drink"></span>
                                <h2>drinks</h2>
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="sides">
                            <div class="inner_content">
                                <span class="flaticon flaticon-food"></span>
                                <h2>sides</h2>
                            </div>
                        </div>
                    </div>
                </div><!-- forth section end -->
            </div>
        </section><!-- Block Content end-->

        <!-- Lock -->
        <section id="lock">
            <h2>SERVING MORE THAN JUST BURGERS SINCE 1998</h2>
            <p>Check out our opening hours and location address below.</p>
        </section>

        <!-- Map -->

        <!-- Footer -->
        <footer>
            <!-- Container -->
            <div class="container">
                <div class="row">

                    <div class="col-lg-3 col-sm-4 col-xs-12 col-lg-offset-1 pull-right">
                        <div class="subscribe">
                            <h4>Subscribe now</h4>
                            <p>Subscribe to the newsletter and
                                get some crispy stuff every week.</p>

                            <form role="form">
                                <div class="form-group">
                                    <div class="input-group">
                                        <input type="email" class="form-control" id="em" placeholder="Enter your e-mail here">
                                        <span class="input-group-btn">
                                            <button type="submit" class="btn send_btn">
                                                <i class="glyphicon glyphicon-send"></i>
                                            </button>
                                        </span>
                                    </div>
                                </div>
                            </form>

                        </div>
                    </div>

                    <div class="col-lg-3 col-sm-4 col-xs-12 col-lg-offset-1 pull-right">
                        <div class="contact_us">
                            <h4>Contact Us</h4>
                            <a href="">info@junkyburget.com</a>

                            <address>
                                Jalan Awan Hijau, Taman OUG<br />
                                58200 Kuala Lumpur <br />
                                Malaysia <br />
                            </address>
                        </div>
                    </div>

                    <div class="col-lg-4 col-sm-4 col-xs-12 pull-right">
                        <div class="basic_info">
                            <a href=""><img class="footer_logo" src="images/footer_logo.png" alt="Burger" /></a>

                            <ul class="list-inline social">
                                <li><a href="" class="fa fa-facebook"></a></li>
                                <li><a href="" class="fa fa-twitter"></a></li>
                                <li><a href="" class="fa fa-instagram"></a></li>
                            </ul>

                            <div class="footer-copyright">
                                <p class="wow fadeInRight" data-wow-duration="1s">
                                    Made with 
                                    <i class="fa fa-heart"></i>
                                    by 
                                    <a target="_blank" href="http://bootstrapthemes.co">Bootstrap Themes</a> <br /> 
                                    2016. All Rights Reserved
                                </p>
                            </div>					
                        </div>
                    </div>

                </div>
            </div><!-- Container end -->
        </footer><!-- Footer end -->


        <!-- scroll up-->
        <div class="scrollup">
            <a href="#"><i class="fa fa-chevron-up"></i></a>
        </div><!-- End off scroll up->

        <!-- JavaScript -->
        <script src="http://code.jquery.com/jquery-1.12.1.min.js"></script>		
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
        <!-- Bootsnav js -->
        <script src="scripts/bootsnav.js"></script>
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
	
	Response.Redirect("Pedidos.aspx");
	
	return;
	

	
}


function fcnActGO(){
	window.open('https://app.migusto.com.ar', '_self');
}

</script>
         
        <!--main js-->
        <script type="text/javascript" src="Scripts/main.js"></script>
    </body>	
</html>	
