
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

//var  rr;
function enviarDataAjax() {

    $.ajax({
        type: "POST",
        url: "Pedidos.aspx/prueba",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        Error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (info) {
            console.log(info);
        }
    });
}
enviarDataAjax();

