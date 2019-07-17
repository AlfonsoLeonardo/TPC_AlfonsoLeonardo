
/*
 Id de Producto
 Nombre de producto
 Precio del producto
 Cantidad que selecciono
 */
var pedido = [];
var pedidoMinimo = 100;
var sucursalEstaAbierta = true;
var subTotal = 0;
var delivery = 30;
var total = 0;
var subtotal_template;   
var grupo_productos_template;

//grupo_productos_template = $.templates("#grupoProductosTemplate");
subtotal_template = $.templates("#subtotal_template");
var htmlOutput = subtotal_template.render({subTotal, total});
$("#subtotal").html(htmlOutput);

function procesarCondiciones(renderObj, grupo) {
    /// <summary>Se encarga de procesar los horarios en los que trabaja la sucursal y los rangos del producto para determinar si el producto debería estar disponible.</summary>

    if (sucursalAbierta()) {
        // si llego a este punto, es porque la sucursal está disponible para hacer pedidos hoy y ahora. Proceso los horarios y días del grupo en particular
        //procesarCondicionesGruposProductos(renderObj, grupo);
    } else {
        renderObj.disabled = "disabled";
    }
}
function initGruposProductos() {
    /// <summary>Se encarga de incializar los datos en grupos_productos. grupos_productos es un array que contiene las agrupaciones
    /// más simples de productos. Cada objeto contiene los siguientes datos:
    /// {   "id": 1, // el identificador del grupo_producto.
    ///     "nombre": "Empanadas al horno", // Opcional. El nombre a mostrar para la agrupación de productos.
    ///     "modificador_precio": 0.8, // Opcional. El modificador precio. Si es un número, simplemente lo suma al precio del producto. Si es un objeto, ver función getPrecioConModificador. La función podría usarse para hacer casos especiales en los precios. Por ejemplo, que ciertos días tenga un descuento especial, o que ciertos productos tengan otros precios, etc.
    ///     "productos": [ 1, 2, 3, 4, 5 ], // los IDs de productos. Estos productos están en el array de productos_base.
    ///     "imagen": "/content/promo-img-1.jpg" // Opcional. La URL de la imagen para usar de header de la agrupación.
    /// }
    /// </summary>
    /// <remarks>Si modificador_precio indica una función, param1 va a ser el precio del producto, param2 va a ser el producto, y param3 va a ser la instancia actual de grupo_producto.</remarks>
    if (datosSucursal.grupos_productos) {
        // itero cada grupo de productos
        for (var i = 0; i < datosSucursal.grupos_productos.length; i++) {
            var grupo = datosSucursal.grupos_productos[i];

            var objTemplate = {
                nombre: grupo.nombre,
                imagen: grupo.imagen,
                productos: [],
                disabled: "",
                warning: ""
            };

            // itero los productos de este grupo y obtengo el producto procesado que puede ser usado por el template de jsrender
            for (var j = 0; j < grupo.productos.length; j++) {
                var prodProcesado = getProductoProcesado(grupo.productos[j]);
                objTemplate.productos.push(prodProcesado);
            }

            procesarCondiciones(objTemplate, grupo);
            var htmlOutput = grupo_productos_template.render(objTemplate);
            $("#productosContainer").append(htmlOutput);
        }
    }
}
function getProductoProcesado(idProducto) {
    /// <summary>Se encarga de devolver un producto para que pueda ser interpretado por el template de jsrender.</summary>
    /// <param name="getPrecioProducto">Función callback para obtener el precio a mostra de este producto.</param>
    var prod = idProducto ? datosSucursal.productosById[idProducto]
        : datosSucursal.promosById[idPromo];
    return {
        id: idProducto,
        precio: getPrecioProducto(prod),
        nombre: prod.nombre,
        descripcion: prod.descripcion,
        id_promo: idPromo,
        id_promocion: prod.idpromocion,
        id_grupo_promo: idGrupoPromo,
        id_grupo_prod: idGrupoProducto
    };
}

function agregarProducto(id, nombre, precio, tipocomida) {
    const nuevo = {
        id: id,
        nombre: nombre,
        precio: precio,
        cantidad: 1,
        itotal: precio,
        tipocomida:tipocomida
    }
   
    $("#pedidoVacio").hide()
    var existeElProducto = pedido.some(ped => ped.id === nuevo.id);
   
    if (existeElProducto) {
        pedido.map(ped => {
            if (ped.id === nuevo.id) {
                
                ped.cantidad++;
                ped.itotal = ped.precio * ped.cantidad;
                
            }
        })
    } else {

        pedido.push(nuevo);
    }
    stotal();
    mostrarLista();
    cambiarSubtotal();  
    
}

function cambiarSubtotal() {
    
    total = subTotal + delivery;
    $("#subtotal .sub-total").text("$" + subTotal);
    $("#subtotal .precio").text("$" + total);
    $(".ver-pedido-total").text("($" + total + ")");
}

$("#vaciarPedido").on("click", function () {

    var prop = 0;
    while (pedido.length!=0) {
        var ped = pedido[prop];
       
        ped.cantidad = 0;
        ped.itotal = 0;
        pedido = pedido.filter(p => p.id !== ped.id);
        mostrarLista();

    }   
    stotal();
    $("#subtotal .sub-total").text("$" + subTotal);
   
    
    reloadPedidos();   
    
})

function reloadPedidos() {
    /// <summary>Recarga todo el carrito de pedidos</summary>

   
    $("#pedidoVacio").show();
   
    }

function mostrarLista() {
    var html = '';
    
    pedido.map(ped => {
       
        html +=             
            '<div data-id-item-pedido="1" class="item">' +
            '<div class="item-right precio" > $' + ped.itotal + '</div >' +
            '<span class="add-remove-controls"><span class="glyphicon glyphicon-plus" onclick="agregarProducto(' + ped.id + ', \'' + ped.nombre + '\', ' + ped.precio + ')"></span>' +
            '<span class="glyphicon glyphicon-minus" onclick="quitarProducto(' + ped.id + ')"></span ></span> ' +
            '<span><span class="cantidad">' + ped.cantidad + '</span> ' + ped.nombre + '</span>' +
            '<div class="view-item-details">' +
            '<span class="glyphicon glyphicon-option-horizontal"></span>' +
            '</div>' +
            '</div >'        
    });
    
    $('#pedido').html(html);
  
}
function stotal() {
    subTotal = 0;
    for (var prop in pedido) {
        var ped = pedido[prop];
        
subTotal += parseFloat(ped.itotal);

    }
}
function quitarProducto(id) {
    var cambio = false;
   
    pedido.map(ped => {
        if (ped.id === id) {

            ped.cantidad--;
            ped.itotal = ped.itotal-ped.precio;
            
        }

        if (ped.cantidad === 0) {
            cambio = true;
        }
       
    });

    if (cambio) {
        pedido = pedido.filter(p => p.id !== id);
    }
    if (pedido.length === 0) {

        $("#pedidoVacio").show()
    }
     stotal();
    mostrarLista();
        
    $("#subtotal .sub-total").text("$" + subTotal);
}
// document ready
$(function () {

        scrollSidebar.initialize(".pedido-content");
   
});
var scrollSidebar = (function () {

    var animDur = 250;

    var oldY = 0;
    var newY = 0;
    var originalTop = 0;
    var originalOffsetTop = 0;
    var $window;
    var $element;
    var timeoutHandle;
    var $body;
    var $footer;

    var windowHeight = 0;
    var elementHeight = 0;

    var useFixedTop = function () {
        windowHeight = $window.height();
        elementHeight = $element.height();

        return elementHeight < windowHeight;
    };

    var executeFixedTop = function (failCallback) {
        $element.stop(true);
        if (newY > originalOffsetTop) {
            if (useFixedTop()) {
                // y verifico que el bottom no esté por debajo del footer tmb
                var bodyHeight = $body.outerHeight();
                var footerHeight = $footer.outerHeight();
                if ((newY + elementHeight) < bodyHeight - footerHeight) {
                    $element.animate({ top: newY - originalOffsetTop }, animDur);
                }
                else {
                    $element.animate({ top: bodyHeight - footerHeight - elementHeight - originalOffsetTop }, animDur);
                }
            }
            else {
                failCallback();
            }
        }
        else {
            $element.animate({ top: originalTop }, animDur);
        }
    };

    var onDown = function () {
        executeFixedTop(function () {
            // calculo el top para que el bottom del sidebar de justo con el bottom del window
            // (en donde está el boton de "Realizar Pedido")
            var newTop = newY + windowHeight - elementHeight - originalOffsetTop;
            // verifico que el nuevo top esté por "debajo" del top original. (no quiero que el pedido quede flotando por arriba del navbar)
            if (newTop > originalTop) {
                var topActual = parseInt($element.css("top"));
                // como estoy scrolleando hacia abajo, verifico que el nuevo top es más grande (más abajo) que el que está seteado ahora
                // (esto pasa cuando estaba escrolleando para abajo, y vuelvo un poquito para arriba y luego sigo bajando)
                if (newTop > topActual) {
                    // y verifico que el bottom no esté por debajo del footer tmb
                    var bodyHeight = $body.outerHeight();
                    var footerHeight = $footer.outerHeight();
                    if ((newTop + elementHeight) < bodyHeight - footerHeight - originalOffsetTop) {
                        $element.animate({ top: newTop }, animDur);
                    }
                    else {
                        $element.animate({ top: bodyHeight - footerHeight - elementHeight - originalOffsetTop }, animDur);
                    }
                }
            }
            else {
                $element.animate({ top: originalTop }, animDur);
            }
        });
    };
    var onUp = function () {
        executeFixedTop(function () {
            // calculo el top para que el bottom del sidebar de justo con el bottom del window
            // (en donde está el boton de "Realizar Pedido")
            var newTop = newY + 10 - originalOffsetTop;
            // verifico que el nuevo top esté por "debajo" del top original. (no quiero que el pedido quede flotando por arriba del navbar)
            if (newTop > originalTop) {
                var topActual = parseInt($element.css("top"));
                // como estoy scrolleando hacia arriba, verifico que el nuevo top es más chico (más arriba) que el que está seteado ahora
                // (esto pasa cuando estaba escrolleando para abajo, y empiezo a volver hacia arriba) 
                if (newTop < topActual) {
                    $element.animate({ top: newTop }, animDur);
                }
            }
            else {
                $element.animate({ top: originalTop }, animDur);
            }
        });
    };

    var initScroll = function (selector) {
        // guardo referencias de los elementos que su seguido
        $element = $(selector);
        originalTop = parseInt($element.css("top"));
        originalOffsetTop = $element.offset().top - 5;
        $window = $(window);
        oldY = $window.scrollTop();
        $body = $("body");
        $footer = $(".footer-company");

        $window.on("scroll", function () {
            // verifico que estoy en una pantalla con sidebar
            if ($window.width() > 981) {
                newY = $window.scrollTop();
                // se usa setTimeout para no hacer demasiadas llamadas a onDown/onUp
                clearTimeout(timeoutHandle);
                if (newY > oldY) {
                    timeoutHandle = setTimeout(onDown, 50);
                }
                else {
                    timeoutHandle = setTimeout(onUp, 50);
                }
                oldY = newY;
            }
        });

        // en el "load", ejecuto una vez onDown por si la ventana estaba ya escroleada
        onDown();
    };

    return {
        initialize: initScroll
    };
})();


$("#revisarPedido").on("click", function () {

    if (subTotal == 0) {
        tepido.showMessage('bottom', 'left', 'danger', 'error', 'No se eligieron productos');
        return;
    }

    if (subTotal < pedidoMinimo || !sucursalEstaAbierta) {
        tepido.showMessage('bottom', 'left', 'warning', 'error', 'El mínimo por pedido es $' + pedidoMinimo);
        return;
    }

 

    //$("#ModalRevisar").modal('toggle');
    $("#ModalRevisar").modal('toggle');
    fcn_detalle_pedido();

});
function fcn_detalle_pedido() {

    $('#TablaModalRevisar').empty();

    var v_pisoDto = 'PISOOOOO'; //localStorage.getItem('TPPDto');

    //if (v_pisoDto != '' && v_pisoDto != null) {
    //    $('#dir_entrega_conf').html(userHelper.getUserAddress() + ' ' + v_pisoDto);
    //} else {
    //    $('#dir_entrega_conf').html(userHelper.getUserAddress());
    //}

    $('#dir_hora_conf').html($('#deliveryTime').val());

    //if ($('#dir_hora_conf').html() != 'Lo antes posible') {
    //    $('#dir_hora_conf').html($('#dir_hora_conf').html() + 'hs');
    //}

    if ($('#comentarios').val() != '') {
        $('#comentarios_conf').html($('#comentarios').val());
        $('#comentarios_div').show();
    } else {
        $('#comentarios_div').hide();
    }



    //alert(pedido.pedidos[1].nombre);
   // var v_txt_promo = '';
    var v_txt_cant = '';

    for (var prop in pedido) {

        var ped = pedido[prop];

        $('#TablaModalRevisar').append('<tr><td class="text-center">' + ped.cantidad + '</td><td class="text-left">' + ped.nombre + '</td><td class="text-center">' + ped.tipocomida+ '</td><td class="text-center">$' +ped.itotal + '</td></tr>');
       
    }

    $('#ModalRevisarTotal').html(subTotal + delivery);

    $("#ModalRevisarBody").show();
    $("#ModalRevisarMsj").hide();

    $("#ModalRevisarPagaCon").css({ 'border-color': '#ccc', 'background-color': '#fff' });
    $("#ModalRevisarTel").css({ 'border-color': '#ccc', 'background-color': '#fff' });
    $("#PagaConMsj").html('');
    $("#NumTelMsj").html('');
    $("#ModalRevisarPagaCon").val('');

    $("#confirmarPedido").attr('disabled', false);

    $('#ModalRevisar').modal({ backdrop: 'static', keyboard: false });
}

    /// <summary>Crea los event listeners para cuando el usuario hace click sobre algún producto,
    /// y se encarga de comunicarse con pedidoModule para indicarle que se seleccionó un producto.</summary>

    var timeoutHandle;

    function clearProductosAdded() {
        /// <summary>Esto resetea todos los iconos de los productos de nuevo al "+".</summary>
        $("#productosContainer .producto").removeClass("added").find(".far").removeClass("fa-check-square").addClass("fa-plus-square");
        timeoutHandle = null;
    }

    $("#productosContainer").on("click", ".producto", function () {

        $(this).addClass("added").find(".far").removeClass("fa-plus-square").addClass("fa-check-square");
        if (timeoutHandle) {
            clearTimeout(timeoutHandle);
        }
        timeoutHandle = setTimeout(clearProductosAdded, 1000);
    });

var productosModule = (function () {

    // referencias a los templates
    var grupo_productos_template;

    // referencia a los datos de la sucursal
    var datosSucursal;

    function procesarDatosSucursal() {
        /// <summary>Se encarga de procesar los datos que vienen en el JSON para que sea más accesible por el resto de los métodos.</summary>

        // productosById lo creo para poder acceder al producto por su ID, en lugar de iterar el array hasta
        // encontrar el producto
        datosSucursal.productosById = {};
        for (var i = 0; i < datosSucursal.productos_base.length; i++) {
            var prod = datosSucursal.productos_base[i];
            datosSucursal.productosById[prod.id] = prod;
        }
        // lo mismo para los otros arrays...
        datosSucursal.promosById = {};//promos
        for (var i = 0; i < datosSucursal.promos_base.length; i++) {
            var promo = datosSucursal.promos_base[i];
            datosSucursal.promosById[promo.id] = promo;

            promo.grupoProductoById = {};//tipo
            for (var j = 0; j < promo.grupos_productos.length; j++) {
                promo.grupoProductoById[promo.grupos_productos[j].id] = promo.grupos_productos[j];
            }
        }
        datosSucursal.gruposProductosById = {};
        for (var i = 0; i < datosSucursal.grupos_productos.length; i++) {
            var grupoProd = datosSucursal.grupos_productos[i];
            datosSucursal.gruposProductosById[grupoProd.id] = grupoProd;
        }

        datosSucursal.gruposPromosById = {};
        for (var i = 0; i < datosSucursal.grupos_promos.length; i++) {
            var grupoPromo = datosSucursal.grupos_promos[i];
            datosSucursal.gruposPromosById[grupoPromo.id] = grupoPromo;
        }

        datosSucursal.modificadoresProductosById = {};
        for (var i = 0; i < datosSucursal.modificadores_productos.length; i++) {
            var modProd = datosSucursal.modificadores_productos[i];
            datosSucursal.modificadoresProductosById[modProd.id] = modProd;
        }

        datosSucursal.opcionesBaseById = {};
        for (var i = 0; i < datosSucursal.opciones_base.length; i++) {
            var opc = datosSucursal.opciones_base[i];
            datosSucursal.opcionesBaseById[opc.id] = opc;
        }
    }

    function procesarCondicionesGruposProductos(renderObj, grupo) {
        /// <summary>En este método proceso las condiciones de "rango_horario" y "rango_dias" que pueden tener los grupos_promos y grupos_productos.</summary>

        var disable = false;
        if (grupo.rango_horario) {

            var resultRangoHorario = rangoHorarioModule.calculateTimespan(grupo.rango_horario, 10);

            if (resultRangoHorario == rangoHorarioModule.results.FueraDeHorario) {
                renderObj.disabled = "disabled";
                renderObj.warning = "Sólo disponible entre " + grupo.rango_horario.desde + " y " + grupo.rango_horario.hasta + " horas";
            }
            else if (resultRangoHorario == rangoHorarioModule.results.FaltanPocosMinutos) {
                renderObj.warning = "Sólo faltan unos minutos para que pueda ordenar estos productos";
            }
            else if (resultRangoHorario == rangoHorarioModule.results.QuedanPocosMinutos) {
                renderObj.warning = "Dentro de unos minutos estos productos no podrá ordenarlos";
            }
        }
        if (grupo.rango_dias) {
            var dia = new Date().getDay();
            var disable = true;
            for (var i = 0; i < grupo.rango_dias.length; i++) {
                if (grupo.rango_dias[i] == dia) {
                    disable = false;
                    break;
                }
            }
            if (disable) {
                renderObj.disabled = "disabled";
                renderObj.warning = "No puede pedir estos productos hoy";
            }
        }
    }

    function procesarCondiciones(renderObj, grupo) {
        /// <summary>Se encarga de procesar los horarios en los que trabaja la sucursal y los rangos del producto para determinar si el producto debería estar disponible.</summary>

        if (sucursalModule.sucursalAbierta()) {
            // si llego a este punto, es porque la sucursal está disponible para hacer pedidos hoy y ahora. Proceso los horarios y días del grupo en particular
            procesarCondicionesGruposProductos(renderObj, grupo);
        } else {
            renderObj.disabled = "disabled";
        }
    }

    function initGruposProductos() {
        /// <summary>Se encarga de incializar los datos en grupos_productos. grupos_productos es un array que contiene las agrupaciones
        /// más simples de productos. Cada objeto contiene los siguientes datos:
        /// {   "id": 1, // el identificador del grupo_producto.
        ///     "nombre": "Empanadas al horno", // Opcional. El nombre a mostrar para la agrupación de productos.
        ///     "modificador_precio": 0.8, // Opcional. El modificador precio. Si es un número, simplemente lo suma al precio del producto. Si es un objeto, ver función getPrecioConModificador. La función podría usarse para hacer casos especiales en los precios. Por ejemplo, que ciertos días tenga un descuento especial, o que ciertos productos tengan otros precios, etc.
        ///     "productos": [ 1, 2, 3, 4, 5 ], // los IDs de productos. Estos productos están en el array de productos_base.
        ///     "imagen": "/content/promo-img-1.jpg" // Opcional. La URL de la imagen para usar de header de la agrupación.
        /// }
        /// </summary>
        /// <remarks>Si modificador_precio indica una función, param1 va a ser el precio del producto, param2 va a ser el producto, y param3 va a ser la instancia actual de grupo_producto.</remarks>
        if (datosSucursal.grupos_productos) {
            // itero cada grupo de productos
            for (var i = 0; i < datosSucursal.grupos_productos.length; i++) {
                var grupo = datosSucursal.grupos_productos[i];

                var objTemplate = {
                    nombre: grupo.nombre,
                    imagen: grupo.imagen,
                    productos: [],
                    disabled: "",
                    warning: ""
                };

                // itero los productos de este grupo y obtengo el producto procesado que puede ser usado por el template de jsrender
                for (var j = 0; j < grupo.productos.length; j++) {
                    var prodProcesado = getProductoProcesado(grupo.productos[j], null, null, grupo.id, function (prod) {
                        if (grupo.modificador_precio) {
                            return getPrecioConModificador(prod, grupo.modificador_precio, grupo);
                        }
                        return { calculado: dataHelper.parseDecimalPlaces(prod.precio) };
                    });
                    objTemplate.productos.push(prodProcesado);
                }

                procesarCondiciones(objTemplate, grupo);
                var htmlOutput = grupo_productos_template.render(objTemplate);
                $("#productosContainer").append(htmlOutput);
            }
        }
    }

    function initPromosProductos() {
        /// <summary>Se encarga de incializar los datos en grupos_promos. grupos_promos permite más opciones a la hora de ofrecer producto.
        /// Se puede indicar un rango horario y/o rango de días de la promo. En el dialogo aparecen los productos directamente, y se 
        /// pueden restringir la cantidad de productos a pedir, etc.
        /// </summary>
        /// <remarks>Si modificador_precio indica una función, param1 va a ser el precio del producto, param2 va a ser el producto, y param3 va a ser la instancia actual de grupo_producto.</remarks>
        if (datosSucursal.grupos_promos) {
            // itero cada grupo de promos
            for (var i = 0; i < datosSucursal.grupos_promos.length; i++) {
                var grupo = datosSucursal.grupos_promos[i];

                var objTemplate = {
                    nombre: grupo.nombre,
                    imagen: grupo.imagen,
                    productos: []
                };

                // itero las promos de este grupo y obtengo el 'producto' procesado que puede ser usado por el template de jsrender
                // nota: lo llamo 'producto' para que el template no tenga que complicarse con los nombres
                for (var j = 0; j < grupo.promos.length; j++) {
                    var prodProcesado = getProductoProcesado(null, grupo.promos[j], grupo.id, null, function (prod) {
                        if (grupo.modificador_precio) {
                            return getPrecioConModificador(prod, grupo.modificador_precio, grupo);
                        }
                        return { calculado: dataHelper.parseDecimalPlaces(prod.precio) };
                    });
                    objTemplate.productos.push(prodProcesado);
                }

                procesarCondiciones(objTemplate, grupo);
                var htmlOutput = grupo_productos_template.render(objTemplate);
                $("#productosContainer").append(htmlOutput);
            }
        }
    }

    function getPrecioConModificador(producto, modificadorPrecio, obj) {
        /// <summary>Si modificador precio es un objeto, debe tener el formato { param1: "nombreParam1", param2: "nombreParam2", param3: "nombreParam3", func: "[cuerpo de una función que recibe nombreParam1, nombreParam2 y nombreParam3]"}.
        /// param1, param2 y param3 son seteados con producto.precio, producto y obj respectivamente al ser invocado el cuerpo de la función.</summary>
        /// <param name="precio">El precio base del producto.</param>
        /// <param name="modificadorPrecio">El modificador del precio base. Si es un número, se suma al precio base. Si es una función, ver summary para la explicación.</param>
        /// <param name="obj">El objeto que es pasado como param2 a la función de modificadorPrecio.</param>
        var res = producto.precio;
        if (typeof (modificadorPrecio) == "object") {
            var f = new Function(modificadorPrecio.param1, modificadorPrecio.param2, modificadorPrecio.param3, modificadorPrecio.func);
            res = f(res, producto, obj);
        }
        else if (Number(modificadorPrecio)) {
            res = res + Number(modificadorPrecio);
        }
        var retVal = dataHelper.parseDecimalPlaces(res);
        return {
            original: dataHelper.parseDecimalPlaces(producto.precio),
            calculado: retVal
        };
    }

    function getProductoProcesado(idProducto, idPromo, idGrupoPromo, idGrupoProducto, getPrecioProducto) {
        /// <summary>Se encarga de devolver un producto para que pueda ser interpretado por el template de jsrender.</summary>
        /// <param name="getPrecioProducto">Función callback para obtener el precio a mostra de este producto.</param>
        var prod = idProducto ? datosSucursal.productosById[idProducto]
            : datosSucursal.promosById[idPromo];
        return {
            id: idProducto,
            precio: getPrecioProducto(prod),
            nombre: prod.nombre,
            descripcion: prod.descripcion,
            id_promo: idPromo,
            id_promocion: prod.idpromocion,
            id_grupo_promo: idGrupoPromo,
            id_grupo_prod: idGrupoProducto
        };
    }

    function initClickListeners() {
        /// <summary>Crea los event listeners para cuando el usuario hace click sobre algún producto,
        /// y se encarga de comunicarse con pedidoModule para indicarle que se seleccionó un producto.</summary>

        var timeoutHandle;

        function clearProductosAdded() {
            /// <summary>Esto resetea todos los iconos de los productos de nuevo al "+".</summary>
            $("#productosContainer .producto").removeClass("added").find(".far").removeClass("fa-check-square").addClass("fa-plus-square");
            timeoutHandle = null;
        }

        $("#productosContainer").on("click", ".producto", function () {
            if (this.dataset.disabled) {
                return;
            }

            var idProducto = this.dataset.idProducto;
            var idPromo = this.dataset.idPromo;
            var idGrupoPromo = this.dataset.idGrupoPromo;
            var idGrupoProducto = this.dataset.idGrupoProducto;

            if (idGrupoProducto) {
                // si pertenece a un grupoProducto, obtengo el grupo producto y el producto
                var grupoProd = datosSucursal.gruposProductosById[idGrupoProducto];
                var prod = datosSucursal.productosById[idProducto];
                // si el producto tiene modificadores, tengo que mostrar la ventana...
                if (prod.modificadores_producto && prod.modificadores_producto.length) {
                    dialogModule.initDialog(prod, idGrupoProducto, null, datosSucursal);
                }
                else {
                    // verifico que haya stock, y agrego el producto directamente...
                    var precio = { calculado: dataHelper.parseDecimalPlaces(prod.precio) };
                    if (grupoProd.modificador_precio) {
                        precio = getPrecioConModificador(prod, grupoProd.modificador_precio, grupoProd);
                    }

                    // cambio el ícono del "+" por un tick para indicar que se agregó a la lista.
                    $(this).addClass("added").find(".far").removeClass("fa-plus-square").addClass("fa-check-square");
                    if (timeoutHandle) {
                        clearTimeout(timeoutHandle);
                    }
                    timeoutHandle = setTimeout(clearProductosAdded, 1000);

                    pedidoModule.addPedido({
                        idProducto: idProducto,
                        idGrupoPromo: idGrupoPromo,
                        idGrupoProducto: idGrupoProducto,
                        precio_unitario: precio.calculado,
                        precio_total: precio.calculado,
                        cantidad: 1,
                        nombre: prod.nombre
                    });
                }
            }
            else if (idGrupoPromo) {
                // si pertenece a un grupoPromo, obtengo el grupo promo y la promo
                var promo = datosSucursal.promosById[idPromo];
                // las promos SIEMPRE muestran una ventana. Si queres hacer una promo que se agregue directamente
                // sin pasar por la ventana, hace la promo como si fuera un producto y listo...
                dialogModule.initDialog(promo, null, idGrupoPromo, datosSucursal);
            }
        });
    }

    function getPromoById(id) {
        return datosSucursal.promosById[id];
    }

    function getProdById(id) {
        return datosSucursal.productosById[id];
    }

    return {
        initProductos: function (id) {
            grupo_productos_template = $.templates("#grupoProductosTemplate");

            // obtengo la data de la sucursal
            dataHelper.getSucursalData(id)
                .done(function (data) {
                    datosSucursal = data;

                    procesarDatosSucursal();

                    $("#productosContainer").empty();

                    initPromosProductos();
                    initGruposProductos();

                    initClickListeners();
                });
        },
        getPrecioConModificador: getPrecioConModificador,
        getPromoById: getPromoById,
        getProdById: getProdById
    }
})();


function enviarDataAjax() {
    $.ajax({

        type: "POST",             					 // Metodo de llamada
        url: "Pedidos.aspx/listaTipoComidas",  // Url a llamar
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        dataType: "json"
    }).done(function (info) {
        console.log(info);
    }); 
}
enviarDataAjax();