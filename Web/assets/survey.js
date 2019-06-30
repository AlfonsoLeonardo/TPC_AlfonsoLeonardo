var v_survItemTot = 13;
var v_survItemAct;
var P3_1;
var P3_2;
var P3_3;
var i_respuestas = [];
var v_dni_validado;

	
function showSurvey(){
	$("#ModalEncuesta").modal();
	$("#ProgDivEncuesta").hide();
	$(".surveyDiv").hide();
	$("#P0").show();
	v_survItemAct = 0;
	i_respuestas  = [];
	P3_1 = '';
	P3_2 = '';
	P3_3 = '';
	
	$("#surveyFinish").prop('disabled', false);
	$("#surveyFinish").html('FINALIZAR ENCUESTA');
	
	$("#dni_comment").html('Es necesario ingresar el DNI para validarlo en el local junto con el código de cupón.');
	v_dni_validado = '';
	
} // showSurvey
	
function fcn_survey(tipo='', v_respuesta=''){
	
	$("#surveyMsj").html('');
	
	if(tipo == 'START'){
		$(".surveyDiv").hide();
		$("#P1").show();
		$("#ProgDivEncuesta").show();
		$("#barraEstadoEncuesta").width('7%');
		$("#barraEstadoEncuesta").html('7%');
		
		v_survItemAct = 1;
		
		$("#sucFrecuente").empty();
		var i;
		for (i=0;i<i_locales.length;i++){
			$("#sucFrecuente").append('<option value="'+i_locales[i]['Nombre']+'">'+i_locales[i]['Nombre']+'</option>');
		}
		
	}else if(tipo == 'NEXT'){
		
		if(v_survItemAct == 1){
			v_respuesta = $("#sucFrecuente").val();
		}else if(v_survItemAct == 3){
			// Cargo checkbox
			v_respuesta = P3_1+';'+P3_2+';'+P3_3;
			
		}else if(v_survItemAct == 10){
			v_respuesta = $("#P10_1").val();
		}else if(v_survItemAct == 11){
			v_respuesta = $("#P11_1").val();
		}else if(v_survItemAct == 12){
			v_respuesta = $("#P12_1").val();
		}
		
		if(v_respuesta != ''){
			// Guardo seleccion
			wa_item = {};

			wa_item['P']  		= v_survItemAct;
			wa_item['opcion'] = v_respuesta;
			i_respuestas.push(wa_item);
		}
		
		v_survItemAct = v_survItemAct + 1;
		
		if (v_survItemAct == 2){
			$("#SurveyNomSuc").html($("#sucFrecuente").val());
		}
		
		$(".surveyDiv").hide();
		$("#P"+v_survItemAct).show();
		
		var v_valorProgreso;
		
		v_valorProgreso = v_survItemAct * 7;
		
		$("#barraEstadoEncuesta").width(v_valorProgreso+'%');
		$("#barraEstadoEncuesta").html(v_valorProgreso+'%');
	
	
	}else if(tipo == 'NEXTP10'){
		
		$("#surveyMsjP10").html('');
		$("#P10_1").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		if($("#P10_1").val() == '' && 1==2){
			 $("#P10_1").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			 $("#surveyMsjP10").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
		}else{
			 fcn_survey('NEXT');
		}
		
	}else if(tipo == 'NEXTP11'){
		
		$("#surveyMsjP11").html('');
		$("#P11_1").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		
		if($("#P11_1").val() == '' && 1==2){
			 $("#P11_1").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			 $("#surveyMsjP11").html('<div style="color: red; text-align: center;">Complete los campos obligatorios.</div>');
		}else{
			 fcn_survey('NEXT');
		}
		
	}else if(tipo == 'NEXTP12'){
		
		fcn_survey('NEXT');
		
	}else if(tipo == 'FINISH'){

		var v_salir;
		$("#surveyMsj").html('');
		
		$("#surveyNombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyApellido").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyDNI").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyFechaNacDia").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyFechaNacMes").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyFechaNacAno").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyDireccion").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyTelefono").css({'border-color' : '#ccc', 'background-color' : '#fff'});
		$("#surveyMail").css({'border-color' : '#ccc', 'background-color' : '#fff'});

		// Valido campos
		if($("#surveyNombre").val() == ''){
			$("#surveyNombre").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyApellido").val() == ''){
			$("#surveyApellido").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyDNI").val() == ''){
			$("#dni_comment").html('Es necesario ingresar el DNI para validarlo en el local junto con el código de cupón.');
			$("#surveyDNI").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}else{
			if(v_dni_validado == ''){
				$("#surveyDNI").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
				$("#surveyMsj").html('<div style="color: red; text-align: center; margin-bottom: 15px;">Ingrese un DNI válido.</div>');
				v_salir = 'X';
				return;
			}
		}
		
		if($("#surveyFechaNacDia").val() == ''){
			$("#surveyFechaNacDia").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyFechaNacMes").val() == ''){
			$("#surveyFechaNacMes").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyFechaNacAno").val() == ''){
			$("#surveyFechaNacAno").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyDireccion").val() == '' && 1==2){
			$("#surveyDireccion").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyTelefono").val() == '' && 1==2){
			$("#surveyTelefono").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}
		
		if($("#surveyMail").val() == ''){
			$("#surveyMail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
			v_salir = 'X';
		}else{


			var caract = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
			if (caract.test($("#surveyMail").val()) == false){

				$("#surveyMail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
				$("#surveyMsj").html('<div style="color: red; text-align: center;">Por favor, ingrese un E-mail válido.</div>');
				return;

			}
		}
		
		if(v_salir == 'X'){
			$("#surveyMsj").html('<div style="color: red; text-align: center; margin-bottom: 15px;">Complete los campos obligatorios.</div>');
			return;
		}
		
		$("#surveyFinish").prop('disabled', true);
		$("#surveyFinish").html('<div style="color: green; text-align: center;"><img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"> Procesando..</div>');
		
		var v_diaa = $("#surveyFechaNacDia").val();
		var v_mess = $("#surveyFechaNacMes").val();
		var v_anoo = $("#surveyFechaNacAno").val();
		
		if(v_diaa.length == 1){
			 v_diaa = '0'+v_diaa;
		}
		
		if(v_mess.length == 1){
			 v_mess = '0'+v_mess;
		}
		
		if(v_anoo.length == 3){
			 v_anoo = '0'+v_anoo;
		}
		
		if(v_anoo.length == 2){
			 v_anoo = '00'+v_anoo;
		}
		
		if(v_anoo.length == 1){
			 v_anoo = '000'+v_anoo;
		}
		
		var v_fechaNac = v_anoo+v_mess+v_diaa;
		
		// Guard
		$.ajax({
			 url: "https://dataliveserver.com/migusto/sistema/prd/APP/app_config_read_ajax.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { 	tipo     		 : 'SURVEYSAVE',	
                sid          : '1',
                ori          : 'WEB',
								nombre	  	 :	$("#surveyNombre").val(),
								apellido  	 :	$("#surveyApellido").val(),
								dni			  	 :	$("#surveyDNI").val(),
								fechaNac  	 :	v_fechaNac,
								direccion  	 :	$("#surveyDireccion").val(),
								telefono  	 :	$("#surveyTelefono").val(),
								mail		  	 :	$("#surveyMail").val(),
								newsletter   :	document.getElementById("surveyNewsletter").checked,
								i_respuestas : i_respuestas

			 }, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {

				 // Si no da error, sigo con el proceso
				 if(data[0] == 'OK'){
					 
						v_survItemAct = v_survItemAct + 1; 
					 	
					 	$("#CupCode").html(data['CupCode']);
					 
					  $("#CupFrom").html(data['fechaDesde']);
					  $("#CupTo").html(data['fechaHasta']);
					 
					  $("#CupCliName").html($("#surveyNombre").val());

						$(".surveyDiv").hide();
						$("#P"+v_survItemAct).show();

						$("#barraEstadoEncuesta").width('100%');
						$("#barraEstadoEncuesta").html('100%');
					 
					  // Envio codigo por E-mail
						$.ajax({
							 url: "contacto.php",  // Url a llamar
							 type: "POST",             					 // Metodo de llamada
							 data: { tipo    			: 'SURVEYSENDCODE',
											 email   			: $("#surveyMail").val(),
											 CupCode 			: data['CupCode'],
											 fechaDesde 	: data['fechaDesde'],
											 fechaHasta 	: data['fechaHasta'],
											 nombre 			: $("#surveyNombre").val()


							 }, // Datos a enviar
							 dataType: "json", 									 // Tipo de datos a devolver (JSON)
							 success: function (data) {}

						}).fail(function(){

						});
					 
				 }else{

						$("#surveyMsj").html('<div style="color: red; text-align: center;">'+data[1]+'</div>');

						$("#surveyFinish").html('INTENTAR NUEVAMENTE');
						$("#surveyFinish").prop('disabled', false);

				 }

			 }

		}).fail(function(){

			$("#surveyMsj").html('<div style="color: red; text-align: center;">Ocurrió un error al intentar procesar los datos.</div>');

			$("#surveyFinish").html('INTENTAR NUEVAMENTE');
			$("#surveyFinish").prop('disabled', false);

		});
				
	}else if(tipo == 'EXIT'){
		$("#ModalEncuesta").modal('toggle');
	}
	
} // fcn_survey
	
	
function fcn_btn_mark(p='', id=''){
	
	var v_nomCampo  = p+'_'+id;
	var v_tipoMarca;
	
	if(p == 'P3'){
		 
		if(id == '1'){
			if(P3_1 == 'X'){
				 P3_1 = '';
				 v_tipoMarca = 0;
			}else{
				 P3_1 = 'X';
				 v_tipoMarca = 1;
			}
		}
		
		if(id == '2'){
			if(P3_2 == 'X'){
				 P3_2 = '';
				 v_tipoMarca = 0;
			}else{
				 P3_2 = 'X';
				 v_tipoMarca = 1;
			}
		}
		
		if(id == '3'){
			if(P3_3 == 'X'){
				 P3_3 = '';
				 v_tipoMarca = 0;
			}else{
				 P3_3 = 'X';
				 v_tipoMarca = 1;
			}
		}
		
	}
	
	if(v_tipoMarca == 1){
		$("#"+v_nomCampo).addClass('BtnMark');
	}else{
		$("#"+v_nomCampo).removeClass('BtnMark');
	}
	
} // fcn_btn_mark


function fcn_dniCheck(){
	
	if($("#surveyDNI").val() == ''){
		$("#dni_comment").html('Es necesario ingresar el DNI para validarlo en el local junto con el código de cupón.');
		v_dni_validado = '';
	}else{
		
		$("#dniLoading").html('<img height="25" src="http://www.datalive.com.ar/shared/spin_loader.gif"></div>');
		
		// Valido DNI
		$.ajax({
			 url: "https://dataliveserver.com/migusto/sistema/prd/APP/app_config_read_ajax.php",  // Url a llamar
			 type: "POST",             					 // Metodo de llamada
			 data: { 	tipo     		 : 'SURVEYDNICHECK',	
								sid          : '1',
								dni			  	 :	$("#surveyDNI").val()

			 }, // Datos a enviar
			 dataType: "json", 									 // Tipo de datos a devolver (JSON)
			 success: function (data) {

				 // Si no da error, sigo con el proceso
				 if(data[0] == 'EX'){

						$("#dni_comment").html('El DNI ingresado ya se encuentra registrado en esta encuesta.');
						v_dni_validado = '';
					  $("#dniLoading").html('');
					  
					  $("#surveyDNI").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});

				 }else{

						//$("#surveyMsj").html('<div style="color: red; text-align: center;">'+data[1]+'</div>');
						v_dni_validado = 'X';
						$("#dniLoading").html('');
						$("#dni_comment").html('');
					 
					  $("#surveyDNI").css({'border-color' : '#ccc', 'background-color' : '#fff'});

				 }

			 }

		}).fail(function(){

			$("#dni_comment").html('Ocurrió un error al intentar validar el DNI.');
			v_dni_validado = '';
			$("#dniLoading").html('');

		});
	
	}

}
	
