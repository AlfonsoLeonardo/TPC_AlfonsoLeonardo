var map;
var geocoder;
var dir_completa;
var zonePolygon;
var i_locales = [];
var v_pasos_franq;
var v_latAct = '';
var v_lngAct = '';
	
$( document ).ready(function() {
	
	// Cargo popup
	 $.ajax({
			 url: "https://www.tepido.com.ar/api/apiGetData.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { tipo 				: 'WEBPOPUP' }, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {
			   
			   // Si no da error, sigo con el proceso
			   if(data[0] == 'OK'){
				 
					if(data[2] == 'VID'){
						
						$("#video_popup").attr("src", 'https://www.youtube.com/embed/'+data[1]+'?autoplay=1&controls=0&showinfo=0&rel=0');
						$("#img_popup").hide();
						$("#video_popup").show();
						
					}else{
						
						$("#img_popup").attr("src", data[1]);
						$("#img_popup").show();
						$("#video_popup").hide();
					
					}
					
					$('#ModalPopUp').modal();
					$(".item_form").removeClass('hidden');
				 
			   }else{
				 				 
			   }
			   
			 }
			 
		}).fail(function(){
		
	 });
	
	
	// Cargo sucursales
	 $.ajax({
			 url: "https://www.tepido.com.ar/api/apiGetData.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { tipo 				: 'LOCALES' }, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {
			   
			   // Si no da error, sigo con el proceso
			   if(data[0] == 'OK'){
				 
				 $( "#mapa_google" ).empty();
				 
				 initMap(data);
				 
				 //fcn_LoadlistaLoc();
				 
			   }else{
				 				 
			   }
			   
			 }
			 
		}).fail(function(){
		
	 });
	
	
	// Cargo productos
	 $.ajax({
			 url: "https://www.tepido.com.ar/api/apiGetData.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { tipo 	: 'PROD_LIST',
						 	 rub	  : '1,2'}, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {
			   
			   // Si no da error, sigo con el proceso
			   if(data[0] == 'OK'){
					 
					 $("#body_empanadas").empty();
					 $("#body_pizzas").empty();
				 
					 var vueltas   = 0;
					 var v_col1    = '';
					 var v_col2    = '';
					 var v_mostrar = '';
					 var v_cant_empanadas = 0;
					 var v_cant_pizzas = 0;
					 
					 do{
						 vueltas++;
						 
						 if(data['datos'][vueltas]['IDRubro'] == '1'){
							 v_cant_empanadas++;
						 }
						 
					 }while (vueltas < data['cant_reg']);
					 
					 vueltas = 0;
					 
					 do{
						 vueltas++;
						 
						 if(data['datos'][vueltas]['IDRubro'] == '2' && data['datos'][vueltas]['IDSubRubro'] == '6'){
							 v_cant_pizzas++;
						 }
						 
					 }while (vueltas < data['cant_reg']);
					 
					
					 vueltas = 0;
					 
				 	// Cargo prductos en pantalla EMPANADAS
					do{
						
						vueltas++;
						
						if(data['datos'][vueltas]['IDRubro'] == '1'){
							

							if(v_col1 == ''){
								 v_col1 = data['datos'][vueltas]['Codigo']+' - '+data['datos'][vueltas]['Descripcion'];
							}else{
								if(v_col2 == ''){
									v_col2 = data['datos'][vueltas]['Codigo']+' - '+data['datos'][vueltas]['Descripcion'];
								}
							}

							// Verifico si hay que mostrar
							if(v_col1 != '' && v_col2 != '' || vueltas == v_cant_empanadas){
								v_mostrar = 'X';
							}

							if(v_mostrar == 'X'){

								$("#body_empanadas").append(

									 '<tr>'
									+'	<td class="body-item mbr-fonts-style display-5">'+v_col1+'</td><td class="body-item mbr-fonts-style display-5">'+v_col2+'</td>'
									+'</tr>'

								);

								v_col1 = '';
								v_col2 = '';
								v_mostrar = '';

							}
							
						}
						
					}while (vueltas < data['cant_reg']);
					 
					 v_cant_pizzas_agregadas=0;
					 vueltas = 0;
					 
				 	// Cargo prductos en pantalla PIZZAS
					do{
						
						vueltas++;
						
						if(data['datos'][vueltas]['IDRubro'] == '2' && data['datos'][vueltas]['IDSubRubro'] == '6'){

							if(v_col1 == ''){
								 v_col1 = data['datos'][vueltas]['Descripcion'];
                 v_cant_pizzas_agregadas++;
							}else{
								if(v_col2 == ''){
									v_col2 = data['datos'][vueltas]['Descripcion'];
                  v_cant_pizzas_agregadas++;
								}
							}

							// Verifico si hay que mostrar
							if(v_col1 != '' && v_col2 != '' || v_cant_pizzas_agregadas == v_cant_pizzas){
								v_mostrar = 'X';
							}

							if(v_mostrar == 'X'){

								$("#body_pizzas").append(

									 '<tr>'
									+'	<td class="body-item mbr-fonts-style display-5">'+v_col1+'</td><td class="body-item mbr-fonts-style display-5">'+v_col2+'</td>'
									+'</tr>'

								);

								v_col1 = '';
								v_col2 = '';
								v_mostrar = '';

							}
							
						}
						
					}while (vueltas < data['cant_reg']);
				 
					$("#body_pizzas").append(

						 '<tr>'
						+'	<td class="body-item mbr-fonts-style display-5"><b style="text-decoration: underline;">Pizza sugerida:</b> Cuatro gustos<br><span style="font-size: 12px;">Muzzarella, Jamón y Morrón<br>Napolitana y Fugazzeta</span></td><td class="body-item mbr-fonts-style display-5"></td>'
						+'</tr>'

					);
           
			   }else{
				 				 
			   }
			   
			 }
			 
		}).fail(function(){
			//alert('Error');
	 });
	

});

	
function initMap(i_datos, areaEntrega='') {
	
  // creo el geocoder para buscar direcciones
  geocoder = new google.maps.Geocoder();
            
	map = new google.maps.Map(document.getElementById('mapa_google'), {
	  center: new google.maps.LatLng(-34.340347, -58.784962),
	  zoom: 9
	});
	
	var logo = 'https://www.migustoesdiferente.com.ar/assets/images/logo_maps.png'; 
	 
	// Defino el icono que voy a usar en el mapa
	var icon = new google.maps.MarkerImage(
	logo,
	new google.maps.Size(31, 20),
	new google.maps.Point(0, 0),
	new google.maps.Point(15, 10)
	);
	
	var index = 0;
	
	for (i=1;i<=i_datos['cant_suc'];i++){
		
		index = i;
		
		marker = new google.maps.Marker({
		'position': new google.maps.LatLng(i_datos['suc_'+i+'_lat'], i_datos['suc_'+i+'_lng']),
		'map': map,
		'icon': icon
		//'label': label
		});
		
		var infowindow = new google.maps.InfoWindow();
		
		google.maps.event.addListener(marker, 'click', (function(marker, index) {
		  return function() {
		  	
		  var v_info = '';
		  
			if(i_datos['suc_'+index+'_Direccion'] != ''){
				v_info = '<span style="font-size: 12px;" class="mbr-iconfont mbri-pin" media-simple="true"></span> '+i_datos['suc_'+index+'_Direccion'];
				
				if(i_datos['suc_'+index+'_Localidad'] != ''){
					v_info = v_info+'<br>'+i_datos['suc_'+index+'_Localidad'];
				}
				
				if(i_datos['suc_'+index+'_Provincia'] != ''){
					v_info = v_info+', '+i_datos['suc_'+index+'_Provincia'];
				}
				
			}
			
			v_info = v_info+'<br>';
			
			if(i_datos['suc_'+index+'_Tel1'] != '' && i_datos['suc_'+index+'_Tel1'] != null){
				v_info = v_info+'<br><span style="font-size: 12px;" style="font-size: 12px;" class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+i_datos['suc_'+index+'_Tel1'];
			}
			
			if(i_datos['suc_'+index+'_Tel2'] != '' && i_datos['suc_'+index+'_Tel2'] != null){
				v_info = v_info+'<br><span style="font-size: 12px;" class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+i_datos['suc_'+index+'_Tel2'];
			}
			
			if(i_datos['suc_'+index+'_Tel3'] != '' && i_datos['suc_'+index+'_Tel3'] != null){
				v_info = v_info+'<br><span style="font-size: 12px;" class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+i_datos['suc_'+index+'_Tel3'];
			}
			
			if(i_datos['suc_'+index+'_Tel4'] != '' && i_datos['suc_'+index+'_Tel4'] != null){
				v_info = v_info+'<br><span style="font-size: 12px;" class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+i_datos['suc_'+index+'_Tel4'];
			}
			
			if(i_datos['suc_'+index+'_Tel5'] != '' && i_datos['suc_'+index+'_Tel5'] != null){
				v_info = v_info+'<br><span style="font-size: 12px;" class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+i_datos['suc_'+index+'_Tel5'];
			}
		  	
		  infowindow.setContent('<div style="text-align: center;"><h4>'+i_datos['suc_'+index+'_Nombre']+'</h4><div style="font-size: 12px;">'+v_info+'</div></div>');
		  infowindow.open(map, marker);
		}
		})(marker, index));
		
		
		marker.setMap(map);
		
		var v_tels = '';
		var v_whatsapp = '';
		
		if(i_datos['suc_'+index+'_Tel1'] != '' && i_datos['suc_'+index+'_Tel1'] != null){
			v_tels = i_datos['suc_'+index+'_Tel1'];
		}
		
		if(i_datos['suc_'+index+'_Tel2'] != '' && i_datos['suc_'+index+'_Tel2'] != null){
			v_tels = v_tels + ' / ' + i_datos['suc_'+index+'_Tel2'];		
		}
		
		if(i_datos['suc_'+index+'_Tel3'] != '' && i_datos['suc_'+index+'_Tel3'] != null){
			v_tels = v_tels + ' / ' + i_datos['suc_'+index+'_Tel3'];		
		}
		
		if(i_datos['suc_'+index+'_Tel4'] != '' && i_datos['suc_'+index+'_Tel4'] != null){
			v_tels = v_tels + ' / ' + i_datos['suc_'+index+'_Tel4'];		
		}
		
		if(i_datos['suc_'+index+'_Tel5'] != '' && i_datos['suc_'+index+'_Tel5'] != null){
			v_tels = v_tels + ' / ' + i_datos['suc_'+index+'_Tel5'];		
		}
		
		wa_item = {};
		
		wa_item['cod']  = i;
		wa_item['lat']  = i_datos['suc_'+i+'_lat'];
		wa_item['lng']  = i_datos['suc_'+i+'_lng'];
		wa_item['area'] = i_datos['suc_'+i+'_Area'];
		wa_item['Nombre'] = i_datos['suc_'+i+'_Nombre'];
		wa_item['Dir']    = i_datos['suc_'+i+'_Direccion'];
		wa_item['Telefonos'] = v_tels;
		wa_item['whatsapp']  = v_whatsapp;
		wa_item['dist'] 		 = '';
		
		i_locales.push(wa_item);
	
	}
	
	if(areaEntrega != ''){
	
		var zoneCoords = JSON.parse(areaEntrega);
		
		// construyo el polígono.
		//zonePolygon = new google.maps.Polygon({
		//	paths: zoneCoords,
		//	strokeColor: '#00ca0b',
		//	strokeOpacity: 0.8,
		//	strokeWeight: 2,
		//	fillColor: '#caffcd',
		//	fillOpacity: 0.20
		//});
		//zonePolygon.setMap(map);
		
	}
	
	navigator.geolocation.getCurrentPosition(onSuccess, onError);
		
}

	
function compare(a, b){
	return a.dist - b.dist;
}

function getKilometros(lat1,lon1,lat2,lon2){
  var rad = function(x) {return x*Math.PI/180;}
  var R = 6378.137; //Radio de la tierra en km
  var dLat = rad( lat2 - lat1 );
  var dLong = rad( lon2 - lon1 );
  var a = Math.sin(dLat/2) * Math.sin(dLat/2) + Math.cos(rad(lat1)) * Math.cos(rad(lat2)) * Math.sin(dLong/2) * Math.sin(dLong/2);
  var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1-a));
  var d = R * c;
  return d.toFixed(1); //Retorna 1 decimale
}
	
var onSuccess = function(position) {
	
	//alert('Latitude: '          + position.coords.latitude          + '\n' +
	//      'Longitude: '         + position.coords.longitude         + '\n');
	//      'Altitude: '          + position.coords.altitude          + '\n' +
	//      'Accuracy: '          + position.coords.accuracy          + '\n' +
	//      'Altitude Accuracy: ' + position.coords.altitudeAccuracy  + '\n' +
	//      'Heading: '           + position.coords.heading           + '\n' +
	//      'Speed: '             + position.coords.speed             + '\n' +
	//      'Timestamp: '         + position.timestamp                + '\n');
	
	map.setCenter({
		lat : position.coords.latitude,
		lng : position.coords.longitude
	});
	
	map.setZoom(12);
	
	marker = new google.maps.Marker({
		map: map,
		draggable: true,
		animation: google.maps.Animation.DROP,
		position: {lat: position.coords.latitude, lng: position.coords.longitude}
	});
	
	marker.setAnimation(google.maps.Animation.BOUNCE);
	
	v_latAct = position.coords.latitude;
	v_lngAct = position.coords.longitude;
	
	
	for (z=0;z<i_locales.length;z++){
		
		if(i_locales[z]['lat'] != null && i_locales[z]['lng'] != null){
		
			var distancia = getKilometros(position.coords.latitude, position.coords.longitude, i_locales[z]['lat'], i_locales[z]['lng']);
			
			var idLocl = z + 1;
			
			i_locales[z]['dist'] = distancia;
		
		}else{
			
			i_locales[z]['dist'] = 99999;
			
		}
		
	}
	
	
	// Muestro el local mas cercano
	if(v_latAct != '' && v_lngAct != ''){
		i_locales.sort(compare);
	}

	for (i=0;i<i_locales.length;i++){
		
		if(i_locales[i]['Telefonos'] != ''){
			var v_iconPhone = '<i class="fas fa-phone" style="font-weight: bold; font-size: 15px; margin-left: 10px; color: #ff001d;"></i>';
		}else{
			var v_iconPhone = '';
		}
		
		$("#sucMasCercana").html(
		
	       '<div class="sucItem">'
	    +      '<div class="sucTitle">Tu sucursal más cercana es '+i_locales[i]['Nombre']+'</div>'
	    +      '<div class="sucDir"><i class="fas fa-map-marker-alt" style="font-weight: bold; font-size: 15px; margin-left: 10px; color: #ff001d;"></i> '+i_locales[i]['Dir']+'<span id="distLoc"></span></div>'
	    +      '<div class="sucTels">'+v_iconPhone+' '+i_locales[i]['Telefonos']+'</div>'
	    +  '</div>'
	      
	  );
	  
    v_myLAT = position.coords.latitude;
    v_myLON = position.coords.longitude;
	
    var request = {
      origin      : new google.maps.LatLng(position.coords.latitude, position.coords.longitude),
      destination : new google.maps.LatLng(i_locales[i]['lat'], i_locales[i]['lng']),
      travelMode  : google.maps.DirectionsTravelMode.DRIVING
    };
    
    var directionsService = new google.maps.DirectionsService();
  
		directionsService.route(request, function(response, status) {
			
		  if ( status == google.maps.DirectionsStatus.OK ) {
		  	
			v_distancia = response.routes[0].legs[0].distance.text+' - '+response.routes[0].legs[0].duration.text;
				
			$('#distLoc').html(' <i class="fas fa-route" style="font-weight: bold; font-size: 15px; margin-left: 5px; color: #ff001d;"></i> En auto '+v_distancia);
			
		  }
		  
		});
  
  	break;
  	
	}
	
	//fcn_LoadlistaLoc();
	
};

function onError(error) {
	//alert('code: '    + error.code    + '\n' +
	//      'message: ' + error.message + '\n');
}


function fcn_LoadlistaLoc(){
	
	$("#listaSucursales").empty();
	
	if(v_latAct != '' && v_lngAct != ''){
		i_locales.sort(compare);
	}
	
	$("#cantLoc1").html(i_locales.length);
	$("#cantLoc2").html(i_locales.length);
	
	var v_distext = '';
	var v_cantLoc = 0;
	var v_claseActivo = '';
	var v_itemOculto = ' oculto';
	
	for (i=0;i<i_locales.length;i++){
		
		v_cantLoc++;
		
		if(i_locales[i]['dist'] != ''){
			v_distext = ' - '+i_locales[i]['dist']+' Km';
			
			if(v_cantLoc == 1){

				if(i_locales[i]['area'] != ''){
					
					var zoneCoords = JSON.parse(i_locales[i]['area']);
					
					// construyo el polígono.
					//zonePolygon = new google.maps.Polygon({
					//	paths: zoneCoords,
					//	strokeColor: '#00ca0b',
					//	strokeOpacity: 0.8,
					//	strokeWeight: 2,
					//	fillColor: '#caffcd',
					//	fillOpacity: 0.20
					//});
					//zonePolygon.setMap(map);
				
				}
				
				map.setZoom(13);
				
				v_claseActivo = ' sombraBox';
				v_itemOculto = '';
				
			}else{
				
				v_claseActivo = '';
				v_itemOculto = ' oculto'
				
			}
			
		}else{
			v_distext = '';
			v_claseActivo = '';
			v_itemOculto = ' oculto';
		}
		
		if(i_locales[i]['Telefonos'] != ''){
			var v_iconPhone = '<i class="fas fa-phone" style="font-weight: bold; font-size: 15px; margin-left: 10px; color: #ff001d;"></i>';
		}else{
			var v_iconPhone = '';
		}
		
		$("#listaSucursales").append(
		
         '<div class="sucItem'+v_claseActivo+'" id="itemLista'+i_locales[i]['cod']+'" onclick="fcn_goToLoc('+i_locales[i]['cod']+');">'
      +      '<div class="sucTitle">'+i_locales[i]['Nombre'].toUpperCase()+v_distext+'</div>'
      +      '<div class="sucDir"><i class="fas fa-map-marker-alt" style="font-weight: bold; font-size: 15px; margin-left: 10px; color: #ff001d;"></i> '+i_locales[i]['Dir']+'</div>'
      +      '<div class="sucTels">'+v_iconPhone+' '+i_locales[i]['Telefonos']+'</div>'
      +  '</div>'
        
    );
		
	}
	
}


function fcn_goToLoc(cod=''){
	
	if(cod != ''){
		
		$(".itemListaRightBar").hide();
		$(".itemLista").removeClass('sombraBox');
		
		map.setZoom(8);
		
		for (i=0;i<i_locales.length;i++){
			
			if(i_locales[i]['cod'] == cod){
				
				map.setCenter({
					lat : parseFloat(i_locales[i]['lat']),
					lng : parseFloat(i_locales[i]['lng'])
				});
				
				map.setZoom(13);
				
				if(i_locales[i]['area'] != ''){
					
					var zoneCoords = JSON.parse(i_locales[i]['area']);
					
					//zonePolygon.setMap(null);
					
					// construyo el polígono.
					//zonePolygon = new google.maps.Polygon({
					//	paths: zoneCoords,
					//	strokeColor: '#00ca0b',
					//	strokeOpacity: 0.8,
					//	strokeWeight: 2,
					//	fillColor: '#caffcd',
					//	fillOpacity: 0.20
					//});
					//zonePolygon.setMap(map);
				
				}
				
				$("#barRightLoc"+cod).show();
				$("#itemLista"+cod).addClass('sombraBox');
				
				break;
			}
				
		}
		
	}
	
}



// Function open contact
function fcn_open_contact(tipo){
	
	if(tipo == 'P'){
		
		$("#prov_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#prov_rsocial").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#prov_telefono").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#prov_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#prov_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#ModalProveedoresMsj").empty();
		$("#btn1_prov").html('Enviar');
		$("#btn2_prov").html('Cancelar');
		$("#btn1_prov").show();
		$("#btn2_prov").show();
		
		$("#prov_nombre").val('');
		$("#prov_rsocial").val('');
		$("#prov_telefono").val('');
		$("#prov_mail").val('');
		$("#prov_mensaje").val('');
		
		$("#ModalProveedores").modal({backdrop: 'static', keyboard: false});
		$(".item_form").removeClass('hidden');
		
	}else if(tipo == 'F'){
		
		$("#fran_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_apellido").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_fenac").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_sexo").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_ecivil").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tipodoc").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_numdoc").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		$("#fran_paisres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_provres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_locres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_domicilio").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tel").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_telalter").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_email").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_emailalter").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		$("#fran_paispref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_provpref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_localidadpref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_garant").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_capital").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tiempodisp").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		$("#ModalFranMsj").empty();
		$("#btn1_fran").html('Enviar');
		$("#btn2_fran").html('Cancelar');
		$("#btn1_fran").show();
		$("#btn2_fran").show();
		
		$("#fran_nombre").val('');
		$("#fran_apellido").val('');
		$("#fran_fenac").val('');
		$("#fran_sexo").val('');
		$("#fran_ecivil").val('');
		$("#fran_tipodoc").val('');
		$("#fran_numdoc").val('');
		
		$("#fran_paisres").val('');
		$("#fran_provres").val('');
		$("#fran_locres").val('');
		$("#fran_domicilio").val('');
		$("#fran_tel").val('');
		$("#fran_telalter").val('');
		$("#fran_email").val('');
		$("#fran_emailalter").val('');
		
		$("#fran_paispref").val('');
		$("#fran_provpref").val('');
		$("#fran_localidadpref").val('');
		$("#fran_garant").val('');
		$("#fran_capital").val('');
		$("#fran_tiempodisp").val('');
		$("#fran_mensaje").val('');
		
		$("#PasoStatus").html('Datos personales');
		$("#barraEstadoFranq").html('Paso 1 de 3');
		$('#barraEstadoFranq').width('33%');
		$('#DivPaso1').show();
		$('#DivPaso2').hide();
		$('#DivPaso3').hide();
		
		$('#PasoStatus').show();
		$('#ProgDiv').show();
		
		$('#btn1_fran').html('Continuar');
		$('#btn2_fran').html('Salir');
		v_pasos_franq = 1;
		
		
		$("#ModalFran").modal({backdrop: 'static', keyboard: false});
		$(".item_form").removeClass('hidden');
		
	}else if(tipo == 'CV'){

		$("#cv_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#cv_apellido").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#cv_telefono").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#cv_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#cv_puesto").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#cv_sector").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#cv_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#ModalCVMsj").empty();
		$("#btn1_cv").html('Enviar');
		$("#btn2_cv").html('Cancelar');
		$("#btn1_cv").show();
		$("#btn2_cv").show();
		
		$("#cv_nombre").val('');
		$("#cv_apellido").val('');
		$("#cv_telefono").val('');
		$("#cv_mail").val('');
		$("#cv_puesto").val('');
		$("#cv_sector").val('');
		$("#cv_sector").empty('');
		$("#cv_sector").hide('');
		$("#cv_mensaje").val('');
		$("#cv_upload").val('');
		
		$("#ModalCV").modal({backdrop: 'static', keyboard: false});
		$(".item_form").removeClass('hidden');
		
	}
	
} // fcn_open_contact
	


// Funcion para envio de contacto proveedores
function fcn_send_prov(){
	
	var v_salir = '';
	
	$("#prov_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#prov_rsocial").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#prov_telefono").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#prov_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#prov_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#ModalProveedoresMsj").empty();
	
	// Valido campos
	var v_nom = $("#prov_nombre").val();
	var v_rso = $("#prov_rsocial").val();
	var v_tel = $("#prov_telefono").val();
	var v_mai = $("#prov_mail").val();
	var v_msj = $("#prov_mensaje").val();
	
	if(v_nom == ''){
		$("#prov_nombre").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_rso == ''){
		$("#prov_rsocial").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_tel == ''){
		$("#prov_telefono").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_mai == ''){
		$("#prov_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}else{
		

	  var caract = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
	  if (caract.test(v_mai) == false){
			
			$("#prov_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			$("#ModalProveedoresMsj").html('<div style="color: red; text-align: center;">Por favor, ingrese un E-mail válido.</div>');
			return;
		
	  }
	}
	
	if(v_msj == ''){
		$("#prov_mensaje").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_salir == 'X'){
		$("#ModalProveedoresMsj").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
		return;
	}
	
	$("#ModalProveedoresMsj").html('<div style="color: green; text-align: center;"><img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"> Enviando..</div>');
	
	$("#btn1_prov").hide();
	$("#btn2_prov").hide();
	
	$.ajax({
		 url: "contacto.php",  // Url a llamar
		 type: "POST",             					 // Metodo de llamada
		 data: { tipo    : 'PROV',
						 nombre  : v_nom,
						 rsocial : v_rso,
						 tel     : v_tel,
						 mail    : v_mai,
						 mensaje : v_msj
		 	
		 	
		 }, // Datos a enviar
		 dataType: "json", 									 // Tipo de datos a devolver (JSON)
		 success: function (data) {
		   
		   // Si no da error, sigo con el proceso
		   if(data[0] == 'OK'){
			 
					$("#ModalProveedoresMsj").html('<div style="color: green; text-align: center;">'+data[1]+'</div>');

					$("#btn2_prov").html('Salir');
					$("#btn2_prov").show();
			 
		   }else{
			 	
					$("#ModalProveedoresMsj").html('<div style="color: red; text-align: center;">'+data[1]+'</div>');

					$("#btn1_prov").html('Intentar nuevamente');
					$("#btn1_prov").show();
					
		   }
		   
		 }
		 
	}).fail(function(){

		$("#ModalProveedoresMsj").html('<div style="color: red; text-align: center;">Ocurrió un error al intentar enviar el mensaje.</div>');

		$("#btn1_prov").html('Intentar nuevamente');
		$("#btn1_prov").show();
					
	});
	
	
} // fcn_send_prov


// Funcion para volver
function fcn_back_fran(){
	
	if(v_pasos_franq == 1 || v_pasos_franq == 'FIN'){
		$("#ModalFran").modal('toggle');
	}else if(v_pasos_franq == 2){

		$("#PasoStatus").html('Datos personales');
		$("#barraEstadoFranq").html('Paso 1 de 3');
		$('#barraEstadoFranq').width('33%');
		$('#DivPaso1').show();
		$('#DivPaso2').hide();
		$('#DivPaso3').hide();
		
		$('#ModalFranMsj').html('');
		
		$('#btn1_fran').html('Continuar');
		$('#btn2_fran').html('Salir');
		v_pasos_franq = 1;
		
	}else if(v_pasos_franq == 3){

		$("#PasoStatus").html('Datos personales');
		$("#barraEstadoFranq").html('Paso 2 de 3');
		$('#barraEstadoFranq').width('66%');
		$('#DivPaso1').hide();
		$('#DivPaso2').show();
		$('#DivPaso3').hide();
		
		$('#ModalFranMsj').html('');
		
		$('#btn1_fran').html('Continuar');
		$('#btn2_fran').html('Volver');
		v_pasos_franq = 2;
		
	}
	
} // fcn_back_fran


// Funcion para envio de contacto franquicias
function fcn_send_fran(){
	
	var v_salir;
	$("#ModalFranMsj").html('');
	
	if(v_pasos_franq == 1){
		 
		$("#fran_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_apellido").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_fenac").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_sexo").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_ecivil").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tipodoc").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_numdoc").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#ModalFranMsj").empty();

		// Valido campos
		if($("#fran_nombre").val() == ''){
			$("#fran_nombre").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}

		if($("#fran_apellido").val() == ''){
			$("#fran_apellido").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_fenac").val() == ''){
			$("#fran_fenac").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_sexo").val() == ''){
			$("#fran_sexo").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_ecivil").val() == ''){
			$("#fran_ecivil").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_tipodoc").val() == ''){
			$("#fran_tipodoc").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_numdoc").val() == ''){
			$("#fran_numdoc").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if(v_salir == 'X'){
			$("#ModalFranMsj").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
			return;
		}
		
		$("#fran_paisres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_provres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_locres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_domicilio").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tel").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_telalter").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_email").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_emailalter").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		$("#PasoStatus").html('Datos personales');
		$("#barraEstadoFranq").html('Paso 2 de 3');
		$('#barraEstadoFranq').width('66%');
		$('#DivPaso1').hide();
		$('#DivPaso2').show();
		$('#DivPaso3').hide();
		
		$('#btn1_fran').html('Continuar');
		$('#btn2_fran').html('Volver');
		v_pasos_franq = 2;
		
	}else if(v_pasos_franq == 2){

		$("#fran_paisres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_provres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_locres").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_domicilio").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tel").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_telalter").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_email").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_emailalter").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		// Valido campos
		if($("#fran_paisres").val() == ''){
			$("#fran_paisres").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}

		if($("#fran_provres").val() == ''){
			$("#fran_provres").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_locres").val() == ''){
			$("#fran_locres").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_domicilio").val() == ''){
			$("#fran_domicilio").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_tel").val() == ''){
			$("#fran_tel").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_telalter").val() == ''){
			//$("#fran_telalter").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			//v_salir = 'X';
		}
		
		
		if($("#fran_email").val() == ''){
			$("#fran_email").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}else{


			var caract = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
			if (caract.test($("#fran_email").val()) == false){

				$("#fran_email").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
				$("#ModalFranMsj").html('<div style="color: red; text-align: center;">Por favor, ingrese un E-mail válido.</div>');
				return;

			}
		}
		
		if($("#fran_emailalter").val() == ''){
			//$("#fran_emailalter").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			//v_salir = 'X';
		}else{


			var caract = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
			if (caract.test($("#fran_emailalter").val()) == false){

				$("#fran_emailalter").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
				$("#ModalFranMsj").html('<div style="color: red; text-align: center;">Por favor, ingrese un E-mail válido.</div>');
				return;

			}
		}
		
		if(v_salir == 'X'){
			$("#ModalFranMsj").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
			return;
		}
		
		$("#fran_paispref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_provpref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_localidadpref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_garant").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_capital").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tiempodisp").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		$("#PasoStatus").html('Zona de preferencia para el local');
		$("#barraEstadoFranq").html('Paso 3 de 3');
		$('#barraEstadoFranq').width('100%');
		$('#DivPaso1').hide();
		$('#DivPaso2').hide();
		$('#DivPaso3').show();
		
		$('#btn1_fran').html('Finalizar');
		$('#btn2_fran').html('Volver');
		v_pasos_franq = 3;
		
	}else if(v_pasos_franq == 3){
	
		$("#fran_paispref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_provpref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_localidadpref").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_garant").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_capital").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_tiempodisp").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#fran_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		if($("#fran_paispref").val() == ''){
			$("#fran_paispref").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_provpref").val() == ''){
			$("#fran_provpref").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_localidadpref").val() == ''){
			$("#fran_localidadpref").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_garant").val() == ''){
			$("#fran_garant").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_capital").val() == ''){
			$("#fran_capital").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_tiempodisp").val() == ''){
			$("#fran_tiempodisp").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#fran_mensaje").val() == ''){
			$("#fran_mensaje").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}

		if(v_salir == 'X'){
			$("#ModalFranMsj").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
			return;
		}

		$("#ModalFranMsj").html('<div style="color: green; text-align: center;"><img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"> Enviando..</div>');

		$("#btn1_fran").hide();
		$("#btn2_fran").hide();
		
		$("#DivPaso3").hide();
		$("#PasoStatus").hide();
		$("#ProgDiv").hide();
		
		v_pasos_franq = 'FIN';
		
		$.ajax({
			 url: "contacto.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { 	tipo     		: 'FRAN',							
								nombre	  	:	$("#fran_nombre").val(),
								apellido  	:	$("#fran_apellido").val(),
								fenac				:	$("#fran_fenac").val(),
								sexo				:	$("#fran_sexo").val(),
								ecivil			:	$("#fran_ecivil").val(),
								tipodoc			:	$("#fran_tipodoc").val(),
								numdoc			:	$("#fran_numdoc").val(),

								paisres			:	$("#fran_paisres").val(),
								provres			:	$("#fran_provres").val(),
								locres			:	$("#fran_locres").val(),
								domicilio		:	$("#fran_domicilio").val(),
								tel					:	$("#fran_tel").val(),
								telalter		:	$("#fran_telalter").val(),
								email				:	$("#fran_email").val(),
								emailalter	:	$("#fran_emailalter").val(),

								fran_paispref	:	$("#fran_paispref").val(),
								provpref			:	$("#fran_provpref").val(),
							  locpref				:	$("#fran_localidadpref").val(),
								garant				:	$("#fran_garant").val(),
								capital				:	$("#fran_capital").val(),
								tiempodisp		:	$("#fran_tiempodisp").val(),
								mensaje				:	$("#fran_mensaje").val()

			 }, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {

				 // Si no da error, sigo con el proceso
				 if(data[0] == 'OK'){

						$("#ModalFranMsj").html('<div style="color: green; text-align: center;">'+data[1]+'</div>');

						$("#btn2_fran").html('Salir');
						$("#btn2_fran").show();

				 }else{

						$("#ModalFranMsj").html('<div style="color: red; text-align: center;">'+data[1]+'</div>');

						$("#btn1_fran").html('Intentar nuevamente');
						$("#btn1_fran").show();

				 }

			 }

		}).fail(function(){

			$("#ModalFranMsj").html('<div style="color: red; text-align: center;">Ocurrió un error al intentar enviar el mensaje.</div>');

			$("#btn1_fran").html('Intentar nuevamente');
			$("#btn1_fran").show();

		});
	
	}
	
} // fcn_send_fran



// Funcion para envio de contacto CV
function fcn_send_cv(){
	
	var v_salir = '';
	
	$("#cv_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#cv_apellido").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#cv_telefono").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#cv_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#cv_puesto").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#cv_sector").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#cv_mensaje").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#ModalFranMsj").empty();
	
	// Valido campos
	var v_nom = $("#cv_nombre").val();
	var v_ape = $("#cv_apellido").val();
	var v_tel = $("#cv_telefono").val();
	var v_mai = $("#cv_mail").val();
	var v_pue = $("#cv_puesto").val();
	var v_sec = $("#cv_sector").val();
	var v_msj = $("#cv_mensaje").val();
	
	if(v_nom == ''){
		$("#cv_nombre").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_ape == ''){
		$("#cv_apellido").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_tel == ''){
		$("#cv_telefono").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_mai == ''){
		$("#cv_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}else{
		

	  var caract = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
	  if (caract.test(v_mai) == false){
			
			$("#cv_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			$("#ModalCVMsj").html('<div style="color: red; text-align: center;">Por favor, ingrese un E-mail válido.</div>');
			return;
		
	  }
	}
	
	if(v_pue == ''){
		$("#cv_puesto").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_sec == ''){
		$("#cv_sector").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_msj == ''){
		$("#cv_mensaje").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_salir == 'X'){
		$("#ModalCVMsj").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
		return;
	}
	
	$("#ModalCVMsj").html('<div style="color: green; text-align: center;"><img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"> Enviando..</div>');
	
	$("#btn1_cv").hide();
	$("#btn2_cv").hide();
	
  var file_data = $('#cv_upload').prop('files')[0];   
  var form_data = new FormData();                  
  form_data.append('file', file_data);
  form_data.append('tipo', 'CV');
  form_data.append('nombre', v_nom);
  form_data.append('apellido', v_ape);
  form_data.append('tel', v_tel);
  form_data.append('mail', v_mai);
  form_data.append('puesto', v_pue);
  form_data.append('sector', v_sec);
  form_data.append('mensaje', v_msj);
	
	$.ajax({
		 url: "contacto.php",  // Url a llamar
		 type: "POST",             					 // Metodo de llamada
		  //data: { tipo      : 'CV',
			//			 nombre    : v_nom,
			//			 apellido  : v_ape,
			//			 tel       : v_tel,
			//			 mail      : v_mai,
			//			 puesto    : v_pue,
			//			 sector    : v_sec,
			//			 mensaje   : v_msj,
			//			 file_data : file_data
		 //}, // Datos a enviar
		 
		 data: form_data,
		 contentType: false,
		 cache: false,      
		 processData: false,
		 
		 dataType: "json", 									 // Tipo de datos a devolver (JSON)
		 success: function (data) {
		   
		   // Si no da error, sigo con el proceso
		   if(data[0] == 'OK'){
			 
					$("#ModalCVMsj").html('<div style="color: green; text-align: center;">'+data[1]+'</div>');

					$("#btn2_cv").html('Salir');
					$("#btn2_cv").show();
			 
		   }else{
			 	
					$("#ModalCVMsj").html('<div style="color: red; text-align: center;">'+data[1]+'</div>');

					$("#btn1_cv").html('Intentar nuevamente');
					$("#btn1_cv").show();
					
		   }
		   
		 }
		 
	}).fail(function(){

		$("#ModalCVMsj").html('<div style="color: red; text-align: center;">Ocurrió un error al intentar enviar el mensaje.</div>');

		$("#btn1_cv").html('Intentar nuevamente');
		$("#btn1_cv").show();
					
	});
	
	
} // fcn_send_cv



// Funcion para mandar formulario de contacto
function fcn_send_contact(){
	
	var v_salir = '';
	
	$("#name-form1-c").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#phone-form1-c").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#email-form1-c").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#message-form1-c").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	$("#divContactMsj").empty();
	
	// Valido campos
	var v_nom = $("#name-form1-c").val();
	var v_tel = $("#phone-form1-c").val();
	var v_mai = $("#email-form1-c").val();
	var v_msj = $("#message-form1-c").val();
	
	if(v_nom == ''){
		$("#name-form1-c").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_tel == ''){
		$("#phone-form1-c").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_mai == ''){
		$("#email-form1-c").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}else{
		

	  var caract = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
	  if (caract.test(v_mai) == false){
			
			$("#email-form1-c").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			$("#divContactMsj").html('<div style="color: red; text-align: center;">Por favor, ingrese un E-mail válido.</div>');
			return;
		
	  }
	}
	
	if(v_msj == ''){
		$("#message-form1-c").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		v_salir = 'X';
	}
	
	if(v_salir == 'X'){
		$("#divContactMsj").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
		return;
	}
	
	$("#divContactMsj").html('<div style="color: green; text-align: center;"><img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"> Enviando..</div>');
	
	$("#btn_send_contact").hide();
	
	$.ajax({
		 url: "contacto.php",  // Url a llamar
		 type: "POST",             					 // Metodo de llamada
		 data: { tipo    : 'CONTACT',
						 nombre  : v_nom,
						 tel     : v_tel,
						 mail    : v_mai,
						 mensaje : v_msj
		 	
		 	
		 }, // Datos a enviar
		 dataType: "json", 									 // Tipo de datos a devolver (JSON)
		 success: function (data) {
		   
		   // Si no da error, sigo con el proceso
		   if(data[0] == 'OK'){
			 
					$("#divContactMsj").html('<div style="color: green; text-align: center;">'+data[1]+'</div>');

					$("#name-form1-c").val('');
					$("#phone-form1-c").val('');
					$("#email-form1-c").val('');
					$("#message-form1-c").val('');

					$("#btn_send_contact").html('Enviar');
					$("#btn_send_contact").show();
			 
		   }else{
			 	
					$("#divContactMsj").html('<div style="color: red; text-align: center;">'+data[1]+'</div>');

					$("#btn_send_contact").html('Intentar nuevamente');
					$("#btn_send_contact").show();
					
		   }
		   
		 }
		 
	}).fail(function(){

		$("#divContactMsj").html('<div style="color: red; text-align: center;">Ocurrió un error al intentar enviar el mensaje.</div>');

		$("#btn_send_contact").html('Intentar nuevamente');
		$("#btn_send_contact").show();
					
	});
	
} // fcn_send_contact


// Funcion lista de franquicias
function fcn_list_fran(){
	
	$("#ModalFranListContent").html('<img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"><br>Cargando');
	
	$("#ModalFranList").modal();
	$(".item_form").removeClass('hidden');
	
	// Cargo sucursales
	 $.ajax({
			 url: "https://www.tepido.com.ar/api/apiGetData.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { tipo 				: 'LOCALES_LIST_AJX' }, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {
			   
			   // Si no da error, sigo con el proceso
			   if(data[0] == 'OK'){
			   	
			   	$("#ModalFranListContent").empty();
				 
					 var vueltas = 0;
					 var v_info  = '';
					 
					 do{
						 
						 vueltas++;
						 
						 if(data['datos'][vueltas]['Direccion'] != ''){
							v_info = '<span class="mbr-iconfont mbri-pin" media-simple="true"></span> '+data['datos'][vueltas]['Direccion'];
							
							if(data['datos'][vueltas]['Localidad'] != ''){
								v_info = v_info+'<br>'+data['datos'][vueltas]['Localidad'];
							}
							
							if(data['datos'][vueltas]['Provincia'] != ''){
								v_info = v_info+', '+data['datos'][vueltas]['Provincia'];
							}
							
						 }
						 
						 if(data['datos'][vueltas]['Tel1'] != '' && data['datos'][vueltas]['Tel1'] != null){
							v_info = v_info+'<br><span class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+data['datos'][vueltas]['Tel1'];
						 }
						 
						 if(data['datos'][vueltas]['Tel2'] != '' && data['datos'][vueltas]['Tel2'] != null){
							v_info = v_info+'<br><span class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+data['datos'][vueltas]['Tel2'];
						 }
						 
						 if(data['datos'][vueltas]['Tel3'] != '' && data['datos'][vueltas]['Tel3'] != null){
							v_info = v_info+'<br><span class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+data['datos'][vueltas]['Tel3'];
						 }
						 
						 if(data['datos'][vueltas]['Tel4'] != '' && data['datos'][vueltas]['Tel4'] != null){
							v_info = v_info+'<br><span class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+data['datos'][vueltas]['Tel4'];
						 }
						 
						 if(data['datos'][vueltas]['Tel5'] != '' && data['datos'][vueltas]['Tel5'] != null){
							v_info = v_info+'<br><span class="mbr-iconfont mbri-mobile" media-simple="true"></span> '+data['datos'][vueltas]['Tel5'];
						 }
						 
						 $("#ModalFranListContent").append('<div class="col-ms-12 col-md-6 col-lg-4 multi-horizontal main_local"><div class="content_local"><div class="div_bar_left"></div><div class="nom_local">'+data['datos'][vueltas]['Nombre']+'</div><div class="info_local">'+v_info+'</div></div></div>');
						 
					 }while (vueltas < data['cant_reg']);
				 
			   }else{
				 				 
			   }
			   
			 }
			 
		}).fail(function(){
		
	 });
	
} // fcn_list_fran


// Funcion para buscar local
function fcn_search_dir(){
	
	$("#name-form4-6").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	
	if($("#name-form4-6").val() == ''){
		$("#name-form4-6").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		$("#SearchDirMsj").html('<div style="color: red; text-align: center;">Ingrese su dirección</div>');
	}else{
		
		$("#SearchDirMsj").html('<div style="color: green; text-align: center;"><img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"> Buscando local..</div>');
		
		var resultado;
		
		for (i=0;i<i_locales.length;i++){
			
			if(i_locales[i]['area'] != ''){
				
				doSetTimeout(i_locales[i]['area'], i_locales[i]['Nombre']);
				
			}
			
		}
		
	}
	
} // fcn_search_dir


function doSetTimeout(Area, Nom){
	
	setTimeout(function(){
	
		validarDireccion($("#name-form4-6").val(), Area);
	
	}, 100);
				
}

// Funcion para buscar direccion en base a direccion
function validarDireccion(addr, area){
    
    dir_completa = addr;
    //zonePolygon  = JSON.parse(area);
    
		// construyo el polígono.
		zonePolygon = new google.maps.Polygon({
		    paths: JSON.parse(area),
		    strokeColor: '#00ca0b',
		    strokeOpacity: 0.8,
		    strokeWeight: 3,
		    fillColor: '#caffcd',
		    fillOpacity: 0.35
		});
    
    // hago la consulta al geocoder
    geocoder.geocode({ 'address': dir_completa }, function (geocoderResults, status) {
        // gecode hace un request async a Google, y se llama a la función callback cuando termina...
        switch (status) {
            // referencia de los status del geocoder https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingStatusCodes
            case google.maps.GeocoderStatus.OK:
                // verifico si el location está dentro del polígono
                var isInside = google.maps.geometry.poly.containsLocation(geocoderResults[0].geometry.location, zonePolygon);

                // muestro el SI o el NO
                if(isInside){
                	alert('Local encontrado');
                  return 'in';
                }else{
                	$("#SearchDirMsj").html('Local no encontrado');
                  return 'out';
                }
                break;
            		default:
                //$("#SearchDirMsj").html('<div style="color: red; text-align: center;">La dirección ingresada es incorrecta</div>');;
                break;
        }
    });
}