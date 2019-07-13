
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


subtotal_template = $.templates("#subtotal_template");
var htmlOutput = subtotal_template.render({subTotal, total});
$("#subtotal").html(htmlOutput);

function agregarProducto(id, nombre, precio) {
    const nuevo = {
        id: id,
        nombre: nombre,
        precio: precio,
        cantidad: 1,
        itotal: precio
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

            $('#TablaModalRevisar').append('<tr><td class="text-center">' +ped.cantidad + '</td><td class="text-left">' +  ped.nombre + '</td><td class="text-center">$' +ped.itotal + '</td></tr>');
       
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