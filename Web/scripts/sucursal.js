///// /*<reference path="layout.js" />*/

//var GLOB_costoDelivery = 0;


//var rangoHorarioModule = (function () {

//    var module = {};

//    module.calculateTimespan = function (rangoHorario, minutesThreshold) {
//        /// <summary>Se encarga de determinar si la hora actual se encuentra dentro del rango horario indicado.</summary>
//        /// <param name="minutesThreshold">La cantidad de minutos que se considera suficientemente cerca para devolver "FaltanPocosMinutos" o "QuedanPocosMinutos"</param>  
//        /// <returns>DentroDeHorario|FueraDeHorario|FaltanPocosMinutos|QuedanPocosMinutos</returns>

//        minutesThreshold = minutesThreshold * 60000;
//        var now = new Date();
//        var date = now.getFullYear() + "/" + (now.getMonth() + 1) + "/" + now.getDate() + " ";

//        var desde = new Date(date + rangoHorario.desde);
//        var hasta = new Date(date + rangoHorario.hasta);
//        if (hasta < desde) {
//            // si hasta es menor que desde, es porque pusieron un horario después de las 00:00. Hago que vaya hasta el siguiente día
//            hasta.setDate(hasta.getDate() + 1);
//        }

//        var result = module.results.DentroDeHorario;
//        if (desde - now >= 0) {
//            result = module.results.FueraDeHorario;
//            if (desde - now <= minutesThreshold && desde - now > 0) {
//                result = module.results.FaltanPocosMinutos;
//            }
//        }
//        else if (hasta - now <= 0) {
//            result = module.results.FueraDeHorario;
//        }
//        else if (hasta - now <= 600000 && hasta - now > 30000) {
//            result = module.results.QuedanPocosMinutos;
//        }
//        return result;
//    };

//    module.results = {};
//    module.results.FueraDeHorario = 0; // la hora actual está fuera del rango horario
//    module.results.DentroDeHorario = 1; // la hora actual está dentro del rango horario
//    module.results.FaltanPocosMinutos = 2; // cuando la hora actual se aproxima al final del rango horario
//    module.results.QuedanPocosMinutos = 3; // cuando la hora actual está próxima al comienzo del rango horario

//    return module;
//})();

//var productosModule = (function () {

//    // referencias a los templates
//    var grupo_productos_template;

//    // referencia a los datos de la sucursal
//    var DatosLocal;

//    function procesarDatosLocal() {
//        /// <summary>Se encarga de procesar los datos que vienen en el JSON para que sea más accesible por el resto de los métodos.</summary>

//        // productosById lo creo para poder acceder al producto por su ID, en lugar de iterar el array hasta
//        // encontrar el producto
//        DatosLocal.productosById = {};
//        for (var i = 0; i < DatosLocal.productos_base.length; i++) {
//            var prod = DatosLocal.productos_base[i];
//            DatosLocal.productosById[prod.id] = prod;
//        }
//        // lo mismo para los otros arrays...
//        DatosLocal.promosById = {};
//        for (var i = 0; i < DatosLocal.promos_base.length; i++) {
//            var promo = DatosLocal.promos_base[i];
//            DatosLocal.promosById[promo.id] = promo;

//            promo.grupoProductoById = {};
//            for (var j = 0; j < promo.grupos_productos.length; j++) {
//                promo.grupoProductoById[promo.grupos_productos[j].id] = promo.grupos_productos[j];
//            }
//        }
//        DatosLocal.gruposProductosById = {};
//        for (var i = 0; i < DatosLocal.grupos_productos.length; i++) {
//            var grupoProd = DatosLocal.grupos_productos[i];
//            DatosLocal.gruposProductosById[grupoProd.id] = grupoProd;
//        }

//        DatosLocal.gruposPromosById = {};
//        for (var i = 0; i < DatosLocal.grupos_promos.length; i++) {
//            var grupoPromo = DatosLocal.grupos_promos[i];
//            DatosLocal.gruposPromosById[grupoPromo.id] = grupoPromo;
//        }

//        DatosLocal.modificadoresProductosById = {};
//        for (var i = 0; i < DatosLocal.modificadores_productos.length; i++) {
//            var modProd = DatosLocal.modificadores_productos[i];
//            DatosLocal.modificadoresProductosById[modProd.id] = modProd;
//        }

//        DatosLocal.opcionesBaseById = {};
//        for (var i = 0; i < DatosLocal.opciones_base.length; i++) {
//            var opc = DatosLocal.opciones_base[i];
//            DatosLocal.opcionesBaseById[opc.id] = opc;
//        }
//    }

//    function procesarCondicionesGruposProductos(renderObj, grupo) {
//        /// <summary>En este método proceso las condiciones de "rango_horario" y "rango_dias" que pueden tener los grupos_promos y grupos_productos.</summary>

//        var disable = false;
//        if (grupo.rango_horario) {

//            var resultRangoHorario = rangoHorarioModule.calculateTimespan(grupo.rango_horario, 10);

//            if (resultRangoHorario == rangoHorarioModule.results.FueraDeHorario) {
//                renderObj.disabled = "disabled";
//                renderObj.warning = "Sólo disponible entre " + grupo.rango_horario.desde + " y " + grupo.rango_horario.hasta + " horas";
//            }
//            else if (resultRangoHorario == rangoHorarioModule.results.FaltanPocosMinutos) {
//                renderObj.warning = "Sólo faltan unos minutos para que pueda ordenar estos productos";
//            }
//            else if (resultRangoHorario == rangoHorarioModule.results.QuedanPocosMinutos) {
//                renderObj.warning = "Dentro de unos minutos estos productos no podrá ordenarlos";
//            }
//        }
//        if (grupo.rango_dias) {
//            var dia = new Date().getDay();
//            var disable = true;
//            for (var i = 0; i < grupo.rango_dias.length; i++) {
//                if (grupo.rango_dias[i] == dia) {
//                    disable = false;
//                    break;
//                }
//            }
//            if (disable) {
//                renderObj.disabled = "disabled";
//                renderObj.warning = "No puede pedir estos productos hoy";
//            }
//        }
//    }

//    function procesarCondiciones(renderObj, grupo) {
//        /// <summary>Se encarga de procesar los horarios en los que trabaja la sucursal y los rangos del producto para determinar si el producto debería estar disponible.</summary>

//        if (sucursalModule.sucursalAbierta()) {
//            // si llego a este punto, es porque la sucursal está disponible para hacer pedidos hoy y ahora. Proceso los horarios y días del grupo en particular
//           // procesarCondicionesGruposProductos(renderObj, grupo);
//        } else {
//            renderObj.disabled = "disabled";
//        }
//    }

//    function initGruposProductos() {
//        /// <summary>Se encarga de incializar los datos en grupos_productos. grupos_productos es un array que contiene las agrupaciones
//        /// más simples de productos. Cada objeto contiene los siguientes datos:
//        /// {   "id": 1, // el identificador del grupo_producto.
//        ///     "nombre": "Empanadas al horno", // Opcional. El nombre a mostrar para la agrupación de productos.
//        ///     "modificador_precio": 0.8, // Opcional. El modificador precio. Si es un número, simplemente lo suma al precio del producto. Si es un objeto, ver función getPrecioConModificador. La función podría usarse para hacer casos especiales en los precios. Por ejemplo, que ciertos días tenga un descuento especial, o que ciertos productos tengan otros precios, etc.
//        ///     "productos": [ 1, 2, 3, 4, 5 ], // los IDs de productos. Estos productos están en el array de productos_base.
//        ///     "imagen": "/content/promo-img-1.jpg" // Opcional. La URL de la imagen para usar de header de la agrupación.
//        /// }
//        /// </summary>
//        /// <remarks>Si modificador_precio indica una función, param1 va a ser el precio del producto, param2 va a ser el producto, y param3 va a ser la instancia actual de grupo_producto.</remarks>
//        if (DatosLocal.grupos_productos) {
//            // itero cada grupo de productos
//            for (var i = 0; i < DatosLocal.grupos_productos.length; i++) {
//                var grupo = DatosLocal.grupos_productos[i];

//                var objTemplate = {
//                    nombre: grupo.nombre,
//                    imagen: grupo.imagen,
//                    productos: [],
//                    disabled: "",
//                    warning: ""
//                };

//                // itero los productos de este grupo y obtengo el producto procesado que puede ser usado por el template de jsrender
//                for (var j = 0; j < grupo.productos.length; j++) {
//                    var prodProcesado = getProductoProcesado(grupo.productos[j], null, null, grupo.id, function (prod) {
//                        if (grupo.modificador_precio) {
//                            return getPrecioConModificador(prod, grupo.modificador_precio, grupo);
//                        }
//                        return { calculado: dataHelper.parseDecimalPlaces(prod.precio) };
//                    });
//                    objTemplate.productos.push(prodProcesado);
//                }

//                procesarCondiciones(objTemplate, grupo);
//                var htmlOutput = grupo_productos_template.render(objTemplate);
//                $("#productosContainer").append(htmlOutput);
//            }
//        }
//    }

//    function initPromosProductos() {
//        /// <summary>Se encarga de incializar los datos en grupos_promos. grupos_promos permite más opciones a la hora de ofrecer producto.
//        /// Se puede indicar un rango horario y/o rango de días de la promo. En el dialogo aparecen los productos directamente, y se 
//        /// pueden restringir la cantidad de productos a pedir, etc.
//        /// </summary>
//        /// <remarks>Si modificador_precio indica una función, param1 va a ser el precio del producto, param2 va a ser el producto, y param3 va a ser la instancia actual de grupo_producto.</remarks>
//        if (DatosLocal.grupos_promos) {
//            // itero cada grupo de promos
//            for (var i = 0; i < DatosLocal.grupos_promos.length; i++) {
//                var grupo = DatosLocal.grupos_promos[i];

//                var objTemplate = {
//                    nombre: grupo.nombre,
//                    imagen: grupo.imagen,
//                    productos: []
//                };

//                // itero las promos de este grupo y obtengo el 'producto' procesado que puede ser usado por el template de jsrender
//                // nota: lo llamo 'producto' para que el template no tenga que complicarse con los nombres
//                for (var j = 0; j < grupo.promos.length; j++) {
//                    var prodProcesado = getProductoProcesado(null, grupo.promos[j], grupo.id, null, function (prod) {
//                        if (grupo.modificador_precio) {
//                            return getPrecioConModificador(prod, grupo.modificador_precio, grupo);
//                        }
//                        return { calculado: dataHelper.parseDecimalPlaces(prod.precio) };
//                    });
//                    objTemplate.productos.push(prodProcesado);
//                }

//                procesarCondiciones(objTemplate, grupo);
//                var htmlOutput = grupo_productos_template.render(objTemplate);
//                $("#productosContainer").append(htmlOutput);
//            }
//        }
//    }

//    function getPrecioConModificador(producto, modificadorPrecio, obj) {
//        /// <summary>Si modificador precio es un objeto, debe tener el formato { param1: "nombreParam1", param2: "nombreParam2", param3: "nombreParam3", func: "[cuerpo de una función que recibe nombreParam1, nombreParam2 y nombreParam3]"}.
//        /// param1, param2 y param3 son seteados con producto.precio, producto y obj respectivamente al ser invocado el cuerpo de la función.</summary>
//        /// <param name="precio">El precio base del producto.</param>
//        /// <param name="modificadorPrecio">El modificador del precio base. Si es un número, se suma al precio base. Si es una función, ver summary para la explicación.</param>
//        /// <param name="obj">El objeto que es pasado como param2 a la función de modificadorPrecio.</param>
//        var res = producto.precio;
//        if (typeof (modificadorPrecio) == "object") {
//            var f = new Function(modificadorPrecio.param1, modificadorPrecio.param2, modificadorPrecio.param3, modificadorPrecio.func);
//            res = f(res, producto, obj);
//        }
//        else if (Number(modificadorPrecio)) {
//            res = res + Number(modificadorPrecio);
//        }
//        var retVal = dataHelper.parseDecimalPlaces(res);
//        return {
//            original: dataHelper.parseDecimalPlaces(producto.precio),
//            calculado: retVal
//        };
//    }

//    function getProductoProcesado(idProducto, idPromo, idGrupoPromo, idGrupoProducto, getPrecioProducto) {
//        /// <summary>Se encarga de devolver un producto para que pueda ser interpretado por el template de jsrender.</summary>
//        /// <param name="getPrecioProducto">Función callback para obtener el precio a mostra de este producto.</param>
//        var prod = idProducto ? DatosLocal.productosById[idProducto]
//            : DatosLocal.promosById[idPromo];
//        return {
//            id: idProducto,
//            precio: getPrecioProducto(prod),
//            nombre: prod.nombre,
//            descripcion: prod.descripcion,
//            id_promo: idPromo,
//            id_promocion: prod.idpromocion,
//            id_grupo_promo: idGrupoPromo,
//            id_grupo_prod: idGrupoProducto
//        };
//    }

//    function initClickListeners() {
//        /// <summary>Crea los event listeners para cuando el usuario hace click sobre algún producto,
//        /// y se encarga de comunicarse con pedidoModule para indicarle que se seleccionó un producto.</summary>

//        var timeoutHandle;

//        function clearProductosAdded() {
//            /// <summary>Esto resetea todos los iconos de los productos de nuevo al "+".</summary>
//            $("#productosContainer .producto").removeClass("added").find(".far").removeClass("fa-check-square").addClass("fa-plus-square");
//            timeoutHandle = null;
//        }

//        $("#productosContainer").on("click", ".producto", function () {
//            if (this.dataset.disabled) {
//                return;
//            }

//            var idProducto = this.dataset.idProducto;
//            var idPromo = this.dataset.idPromo;
//            var idGrupoPromo = this.dataset.idGrupoPromo;
//            var idGrupoProducto = this.dataset.idGrupoProducto;

//            if (idGrupoProducto) {
//                // si pertenece a un grupoProducto, obtengo el grupo producto y el producto
//                var grupoProd = DatosLocal.gruposProductosById[idGrupoProducto];
//                var prod = DatosLocal.productosById[idProducto];
//                // si el producto tiene modificadores, tengo que mostrar la ventana...
//                if (prod.modificadores_producto && prod.modificadores_producto.length) {
//                    dialogModule.initDialog(prod, idGrupoProducto, null, DatosLocal);
//                }
//                else {
//                    // verifico que haya stock, y agrego el producto directamente...
//                    var precio = { calculado: dataHelper.parseDecimalPlaces(prod.precio) };
//                    if (grupoProd.modificador_precio) {
//                        precio = getPrecioConModificador(prod, grupoProd.modificador_precio, grupoProd);
//                    }

//                    // cambio el ícono del "+" por un tick para indicar que se agregó a la lista.
//                    $(this).addClass("added").find(".far").removeClass("fa-plus-square").addClass("fa-check-square");
//                    if (timeoutHandle) {
//                        clearTimeout(timeoutHandle);
//                    }
//                    timeoutHandle = setTimeout(clearProductosAdded, 1000);

//                    pedidoModule.addPedido({
//                        idProducto: idProducto,
//                        idGrupoPromo: idGrupoPromo,
//                        idGrupoProducto: idGrupoProducto,
//                        precio_unitario: precio.calculado,
//                        precio_total: precio.calculado,
//                        cantidad: 1,
//                        nombre: prod.nombre
//                    });
//                }
//            }
//            else if (idGrupoPromo) {
//                // si pertenece a un grupoPromo, obtengo el grupo promo y la promo
//                var promo = DatosLocal.promosById[idPromo];
//                // las promos SIEMPRE muestran una ventana. Si queres hacer una promo que se agregue directamente
//                // sin pasar por la ventana, hace la promo como si fuera un producto y listo...
//                dialogModule.initDialog(promo, null, idGrupoPromo, DatosLocal);
//            }
//        });
//    }

//    function getPromoById(id) {
//        return DatosLocal.promosById[id];
//    }

//    function getProdById(id) {
//        return DatosLocal.productosById[id];
//    }

//    return {
//        initProductos: function (id) {
//            grupo_productos_template = $.templates("#grupoProductosTemplate");

//            // obtengo la data de la sucursal
//            dataHelper.getSucursalData(id)
//                .done(function (data) {
//                    DatosLocal = data;

//                    procesarDatosLocal();

//                    $("#productosContainer").empty();

//                    initPromosProductos();
//                    initGruposProductos();

//                    initClickListeners();
//                });
//        },
//        getPrecioConModificador: getPrecioConModificador,
//        getPromoById: getPromoById,
//        getProdById: getProdById
//    }
//})();

//var dialogModule = (function () {

//    var option_dialog_template, option_dialog_promo_grupos_template, option_dialog_promo_template;

//    var refDatosLocal;

//    var currentDialog;
//    var currentProducto, idGrupoProducto, idGrupoPromocion;
//    var cantidadTotal;
//    var baseGuid = 1000;

//    // referencias al DOM
//    var modalBody, modalTitle, subtitle, dialogTotal, dialog, dialogCantidad;

//    function validarPedido() {
//        var sections = $("#pedidoDialog section");
//        var isOK = true;
//        for (var i = 0; i < sections.length; i++) {
//            if (sections[i].dataset.isOk == "false") {
//                sections[i].classList.add("review");
//                $(sections[i]).find(".option-quantity").text("Debe completar la selección");
//                isOK = false;
//            }
//        }

//        if (!isOK) {
//            setTimeout(function () {
//                sections.removeClass("review");
//            }, 300);
//        }

//        return isOK;
//    }

//    function addPedido() {
//        /// <summary>Cuando se hace click en "Agregar" se llama a este método. El mismo se encarga de agregar el producto con todas las opciones seleccionadas
//        /// al módulo de pedidos.</summary>

//        if (!validarPedido()) {
//            return;
//        }

//        var precioUnitario = recalcularPrecio();
//        var pedido = {
//            idProducto: currentProducto.id,
//            idGrupoPromo: idGrupoPromocion,
//            idGrupoProducto: idGrupoProducto,
//            precio_unitario: dataHelper.parseDecimalPlaces(precioUnitario),
//            precio_total: dataHelper.parseDecimalPlaces(precioUnitario * cantidadTotal),
//            cantidad: cantidadTotal,
//            nombre: currentProducto.nombre
//        };

//        pedido.extras = [];
//        addPedidoProductoModificadores(pedido);
//        addPedidoPromoExtras(pedido);

//        if (!pedido.extras.length) {
//            delete pedido.extras;
//        }

//        dialog.modal("hide");
//        pedidoModule.addPedido(pedido);
//    }

//    function addPedidoPromoExtras(pedido) {
//        /// <summary>Se encarga de agregar los "extras" al pedido de las promos seleccionadas.</summary>
//        var containers = $("#pedidoDialog .products-container");
//        for (var i = 0; i < containers.length; i++) {
//            var promo = refDatosLocal.promosById[containers[i].dataset.promoId];
//            var grupoPromo = promo.grupoProductoById[containers[i].dataset.promoGrupoProductoId];

//            // idGrupoProductoPromo es el ID del array "grupos_productos" dentro de la promo
//            var extra = { idGrupoProductoPromo: grupoPromo.id, nombre: grupoPromo.nombre_grupo, items: [] };

//            var opciones = $(containers[i]).find("input:checked");
//            for (var j = 0; j < opciones.length; j++) {
//                var prod = refDatosLocal.productosById[opciones[j].dataset.productoId];
//                var opcion = null;
//                if (opciones[j].dataset.opcionId) {
//                    opcion = refDatosLocal.opcionesBaseById[opciones[j].dataset.opcionId];
//                }

//                var precio = 0;
//                if (grupoPromo.usar_modificadores) {
//                    var grupoProd = refDatosLocal.gruposProductosById[opciones[j].dataset.grupoProductoId];
//                    var newPrecio = productosModule.getPrecioConModificador(prod, grupoProd ? grupoProd.modificador_precio : prod.modificador_precio, promo);
//                    precio = (newPrecio.calculado - prod.precio);
//                }
//                var item = {
//                    // el ID del producto (viene de "productos_base")
//                    idProducto: prod.id,
//                    // el ID del grupo del producto (viene de "grupos_productos")
//                    idGrupoProducto: opciones[j].dataset.grupoProductoId,
//                    nombre: opcion ? opcion.nombre : prod.nombre,
//                    precio: precio > 0 ? dataHelper.parseDecimalPlaces(precio) : ''
//                };
//                if (opcion) {
//                    item.idOpcion = opcion.id;
//                    item.idModificadorProducto = Number.parseInt(opciones[j].dataset.modificadorId);
//                }
//                extra.items.push(item);
//                // quito 1 del stock del producto
//                prod.stock = parseInt(prod.stock) - 1;
//            }

//            var pedidos = $(containers[i]).find("select");
//            for (var j = 0; j < pedidos.length; j++) {

//                if (pedidos[j].value > 0) {
//                    var prod = refDatosLocal.productosById[pedidos[j].dataset.productoId];

//                    var precio = 0;
//                    if (grupoPromo.usar_modificadores) {
//                        var grupoProd = refDatosLocal.gruposProductosById[pedidos[j].dataset.grupoProductoId];
//                        var newPrecio = productosModule.getPrecioConModificador(prod, grupoProd ? grupoProd.modificador_precio : prod.modificador_precio, promo);
//                        precio = (newPrecio.calculado - prod.precio) * pedidos[j].value;
//                    }

//                    extra.items.push({
//                        // el ID del producto (viene de "productos_base")
//                        idProducto: prod.id,
//                        // el ID del grupo del producto (viene de "grupos_productos")
//                        idGrupoProducto: pedidos[j].dataset.grupoProductoId,
//                        nombre: prod.nombre,
//                        precio: precio > 0 ? dataHelper.parseDecimalPlaces(precio) : '',
//                        cantidad: pedidos[j].value
//                    });
//                    // quito del stock del producto
//                    prod.stock = parseInt(prod.stock) - pedidos[j].value;
//                }
//            }

//            if (extra.items.length) {
//                pedido.extras.push(extra);
//            }
//        }
//    }

//    function addPedidoProductoModificadores(pedido) {
//        /// <summary>Se encarga de agregar los "extras" al pedido de los modificadores seleccionados.</summary>
//        var containers = $("#pedidoDialog .option-container");
//        for (var i = 0; i < containers.length; i++) {
//            var currentGroup = refDatosLocal.modificadoresProductosById[containers[i].dataset.modificadorId];

//            var extra = { idModificadorProducto: currentGroup.id, nombre: currentGroup.nombre, items: [] };

//            var opciones = $(containers[i]).find("input:checked");
//            for (var j = 0; j < opciones.length; j++) {
//                var currentOpcion = refDatosLocal.opcionesBaseById[opciones[j].dataset.opcionId];

//                var precio = 0;
//                if (currentGroup.usar_modificadores) {
//                    precio = productosModule.getPrecioConModificador(currentProducto, currentOpcion.modificador_precio, currentGroup).calculado - currentProducto.precio;
//                }

//                extra.items.push({
//                    idOpcion: currentOpcion.id,
//                    nombre: currentOpcion.nombre,
//                    precio: precio > 0 ? dataHelper.parseDecimalPlaces(precio) : ''
//                });
//            }

//            pedido.extras.push(extra);
//        }
//    }

//    function recalcularPrecio() {
//        /// <summary>Itera todas las opciones para calcular nuevamente el precio.</summary>

//        var currentTotal = currentProducto.precio;

//        if (idGrupoPromocion) {
//            var grupoPromocion = refDatosLocal.gruposPromosById[idGrupoPromocion];
//            if (grupoPromocion.modificador_precio) {
//                currentTotal = Number.parseFloat(productosModule.getPrecioConModificador(currentProducto, grupoPromocion.modificador_precio, grupoPromocion).calculado);
//            }
//        }

//        var inputs = $("#pedidoDialog input, #pedidoDialog select");
//        for (var i = 0; i < inputs.length; i++) {
//            var current = inputs[i];

//            if (current.dataset.promoId) {
//                if (current.value > 0) {
//                    var promo = refDatosLocal.promosById[current.dataset.promoId];
//                    var grupoPromo = promo.grupoProductoById[current.dataset.promoGrupoProductoId];

//                    if (grupoPromo.usar_modificadores) {
//                        var prod = refDatosLocal.productosById[current.dataset.productoId];
//                        var grupoProd = refDatosLocal.gruposProductosById[current.dataset.grupoProductoId];
//                        var newPrecio = productosModule.getPrecioConModificador(prod, grupoProd ? grupoProd.modificador_precio : prod.modificador_precio, promo);
//                        currentTotal += (newPrecio.calculado - prod.precio) * current.value;
//                    }
//                }
//            }
//            else if (current.dataset.modificadorId) {
//                var modProd = refDatosLocal.modificadoresProductosById[current.dataset.modificadorId];
//                if (modProd.usar_modificadores) {
//                    var opc = refDatosLocal.opcionesBaseById[current.dataset.opcionId];

//                    if (currentProducto.idrubro == 2) {
//                        var newPrecio = procesarmodificador(opc.modificador_precio, opc, currentProducto, true)
//                        if (current.checked) {
//                            currentTotal = dataHelper.parseDecimalPlaces(newPrecio.calculado);
//                        }

//                    } else {
//                        var newPrecio = productosModule.getPrecioConModificador(currentProducto, opc.modificador_precio, modProd);

//                        if (current.checked) {
//                            currentTotal += newPrecio.calculado - currentProducto.precio;
//                        }
//                    }


//                }
//            }
//        }

//        return currentTotal;
//    }

//    function inputClick() {
//        /// <summary>Cuando se hace click en alguna de las opciones, tengo que calcular las modificaciones al precio e indicar que la opción fue seleccionada.</summary>

//        if (this.dataset.promoId) {
//            promoClicked(this);
//        }
//        else if (this.dataset.modificadorId) {
//            modificadorProductoClicked(this);
//        }
//    }

//    function promoClicked(element) {
//        /// <summary>La opcion seleccionada pertenece a una promo.</summary>

//        var promo = refDatosLocal.promosById[element.dataset.promoId];
//        var grupo = promo.grupoProductoById[element.dataset.promoGrupoProductoId];
//        var prod = refDatosLocal.productosById[element.dataset.productoId];

//        var prodsContainer = $(element).parents(".products-container");
//        var optionQuantity = prodsContainer.find(".option-quantity");
//        var left = 0;

//        if (grupo && grupo.cantidad > 1) {
//            // actualizo el "Elegí 2" a "Elegí 1" o lo quito, etc.
//            var selects = prodsContainer.find("select");
//            var amount = 0;
//            for (var i = 0; i < selects.length; i++) {
//                amount += Number(selects[i].value);
//            }

//            left = grupo.cantidad - amount;
//        }
//        else {
//            left = prodsContainer.find("input:checked").length == 1 ? 0 : 1;
//        }

//        optionQuantity.text(left == 0 ? "Selección completada" : left == grupo.cantidad ? "Elegí " + grupo.cantidad : left < 0 ? "No puedes seleccionar más de " + grupo.cantidad : "Faltan " + left);
//        left == 0 ? optionQuantity.addClass("completada") : optionQuantity.removeClass("completada");
//        prodsContainer[0].dataset.isOk = left == 0;

//        // seteo el nuevo precio
//        var currentTotal = recalcularPrecio();
//        dialogTotal.text(currentTotal > 0 ? ('$' + dataHelper.parseDecimalPlaces(currentTotal * cantidadTotal)) : '');
//    }

//    function modificadorProductoClicked(element) {
//        /// <summary>La opcion seleccionada pertenece a un producto con modificadores.</summary>

//        var modif = refDatosLocal.modificadoresProductosById[element.dataset.modificadorId];

//        var container = $(element).parents(".option-container");
//        var inputs = container.find("input");

//        // si cantidad es 0 o mayor o igual a la cantidad total de opciones, significa que puede elegir los que quiera...
//        if (!modif.cantidad || modif.cantidad < inputs.length) {
//            var optionQuantity = container.find(".option-quantity");

//            // y actualizo el "Elegí 2" a "Elegí 1" o lo quito, etc.
//            var checkedInputs = inputs.length - inputs.not(":checked").length;
//            var left = modif.cantidad - checkedInputs;
//            optionQuantity.text(left == 0 ? "Selección completada" : left == modif.cantidad ? "Elegí " + modif.cantidad : left < 0 ? "No puedes seleccionar más de " + modif.cantidad : "Faltan " + left);
//            left == 0 ? optionQuantity.addClass("completada") : optionQuantity.removeClass("completada");
//            container[0].dataset.isOk = left == 0;

//            if (modif.cantidad > 1) {
//                // si eran checkboxes y se llegó al límite de selecciones, les hago disable a las que quedan
//                // al deseleccionar una opción, todas las opciones se vuelven a habilitar...
//                inputs.not(":checked").prop("disabled", checkedInputs == modif.cantidad);
//            }
//        }

//        // seteo el nuevo precio
//        var currentTotal = recalcularPrecio();
//        dialogTotal.text(currentTotal > 0 ? ('$' + dataHelper.parseDecimalPlaces(currentTotal * cantidadTotal)) : '');
//    }

//    function initDialog(producto, idGrupoProd, idGrupoPromo, DatosLocal) {
//        /// <summary>Se encarga de inicializar el diálogo con las opciones del producto (o la promo).</summary>

//        refDatosLocal = DatosLocal;

//        modalBody.empty();
//        modalTitle.text(producto.nombre);
//        subtitle.text(producto.descripcion || "");
//        dialogCantidad.text("1");
//        cantidadTotal = 1;

//        var modalBodyHtml = '';
//        var options = [];

//        if (idGrupoProd) {
//            for (var i = 0; i < producto.modificadores_producto.length; i++) {
//                var modProd = DatosLocal.modificadoresProductosById[producto.modificadores_producto[i]];

//                // option representa el grupo de las opciones (por ejemplo: "souffle o al horno")
//                var option = getGrupoOpciones(modProd, DatosLocal, producto);
//                options.push(option);
//                modalBodyHtml += option_dialog_template.render(option);
//            }
//        }
//        else if (idGrupoPromo) {
//            // en este punto, la variable "producto" contiene en realidad la promo
//            for (var i = 0; i < producto.grupos_productos.length; i++) {
//                // no confundir este grupo producto. Este pertenece a la promo.
//                var grupoProdPromo = producto.grupos_productos[i];

//                if (grupoProdPromo.grupos_productos_posibles && grupoProdPromo.grupos_productos_posibles.length) {
//                    // grupos_productos_posibles fue definido, por lo tanto la promo indica grupos de productos en lugar de productos directamente

//                    var promo = getPromoGruposProductos(producto.id, grupoProdPromo, DatosLocal);
//                    options.push(promo);
//                    modalBodyHtml += option_dialog_promo_grupos_template.render(promo);
//                }
//                else {
//                    // esta promo es más parecida a la de productos modificadores, ya que indica directamente los productos posibles en lugar de los grupos productos

//                    var promo = getPromoProductos(producto.id, grupoProdPromo, DatosLocal);
//                    options.push(promo);
//                    modalBodyHtml += option_dialog_promo_template.render(promo);
//                }
//            }
//        }

//        currentDialog = options;
//        // tener en cuenta que "currentProducto" puede hacer referencia a una promo
//        currentProducto = producto;
//        idGrupoProducto = idGrupoProd;
//        idGrupoPromocion = idGrupoPromo;

//        var currentTotal = recalcularPrecio();
//        dialogTotal.text(currentTotal > 0 ? ('$' + dataHelper.parseDecimalPlaces(currentTotal)) : '');

//        modalBody.append(modalBodyHtml);
//        dialog.modal("show");
//    }

//    function getPromoProductos(promoId, grupoProdPromo, DatosLocal) {
//        /// <summary>Se encarga de crear el objeto para renderizar el template option_dialog_promo_template.
//        /// Este template se renderiza cuando el grupo producto de la promo indica productos directamente, en
//        /// lugar de grupos de productos.</summary>

//        var promo = {
//            titulo: grupoProdPromo.nombre_grupo, // el título a mostrar
//            nombre: 'opcion' + (grupoProdPromo.id || baseGuid++), // se usa para construir el 'name' para que los radios y los labels funcionen bien
//            id: promoId,
//            promoGrupoProdId: grupoProdPromo.id,
//            cantidad: grupoProdPromo.cantidad, // la cantidad de items que puede seleccionar (si es 1, entonces se usan radio en lugar de select)
//            cantidadLoop: [],
//            productos: [],
//            isOk: false
//        };
//        for (var j = 0; j < grupoProdPromo.productos_posibles.length; j++) {
//            var prd = DatosLocal.productosById[grupoProdPromo.productos_posibles[j]];

//            var stock = parseInt(prd.stock);
//            if (!stock) {
//                // como no hay stock, dejo este producto afuera directamente
//                continue;
//            }

//            var prdRender = {
//                id: prd.id,
//                nombre: prd.nombre,
//                precio: grupoProdPromo.usar_modificadores ? dataHelper.parseDecimalPlaces(prd.modificador_precio) : '',
//                cantidadLoop: []
//            };

//            i
//            var cantidadLoop = [];
//            for (var z = 0; z <= grupoProdPromo.cantidad && z <= stock; z++) {
//                prdRender.cantidadLoop.push(z);
//            }

//            // inserto cada opción al grupo (ejemplo: 'souffle')
//            promo.productos.push(prdRender);

//            if (prd.modificadores_producto) {
//                // este producto contiene "modificadores", por lo tanto tengo que iterar esos modificadores para generar
//                // las opciones correspondientes
//                prdRender.options = [];
//                promo.hasOptions = true;
//                for (var i = 0; i < prd.modificadores_producto.length; i++) {
//                    var modProd = DatosLocal.modificadoresProductosById[prd.modificadores_producto[i]];
//                    var option = getGrupoOpciones(modProd, DatosLocal, prd);
//                    prdRender.options.push(option);
//                }
//            }
//        }
//        return promo;
//    }

//    function getPromoGruposProductos(promoId, grupoProdPromo, DatosLocal) {
//        /// <summary>Se encarga de crear el objeto para renderizar el template option_dialog_promo_grupos_template
//        /// Un ejemplo de este tipo de promo sería una que indica "empandas" y se venden empanadas al horno y souffle. Por lo tanto,
//        /// puedo indicar un grupo de productos para las "souffle" y uno para "al horno".</summary>

//        var promo = {
//            titulo: grupoProdPromo.nombre_grupo, // el título a mostrar
//            nombre: 'opcion' + (grupoProdPromo.id || baseGuid++), // se usa para construir el 'name' para que los radios y los labels funcionen bien
//            id: promoId,
//            promoGrupoProdId: grupoProdPromo.id,
//            cantidad: grupoProdPromo.cantidad, // la cantidad de items que puede seleccionar (si es 1, se usan radio, si no se usa select)
//            cantidadLoop: [],
//            grupos: [],
//            isOk: false
//        };

//        for (var j = 0; j < grupoProdPromo.grupos_productos_posibles.length; j++) {
//            var grupoProd = DatosLocal.gruposProductosById[grupoProdPromo.grupos_productos_posibles[j]];

//            var grupo = {
//                titulo: grupoProd.nombre,
//                id: grupoProd.id,
//                productos: []
//            };
//            promo.grupos.push(grupo);

//            for (var i = 0; i < grupoProd.productos.length; i++) {
//                var prod = DatosLocal.productosById[grupoProd.productos[i]];

//                var stock = parseInt(prod.stock);
//                if (!stock) {
//                    // omito este producto pq no tiene stock
//                    continue;
//                }

//                var precio = '';
//                var cantidadLoop = [];
//                for (var z = 0; z <= grupoProdPromo.cantidad && z <= stock; z++) {
//                    // el "cantidadLoop" se usa para construir los SELECT (1, 2, 3... etc) ya que en jsrender no hay un loop "for" común y corriente
//                    cantidadLoop.push(z);
//                }

//                if (grupoProdPromo.usar_modificadores) {
//                    var mod = productosModule.getPrecioConModificador(prod, grupoProd.modificador_precio, grupoProd)
//                    precio = dataHelper.parseDecimalPlaces(mod.calculado - mod.original);
//                }
//                // inserto cada producto al grupo
//                grupo.productos.push({
//                    id: prod.id,
//                    nombre: prod.nombre,
//                    precio: precio,
//                    cantidadLoop: cantidadLoop
//                });
//            }
//        }
//        return promo;
//    }

//    function getGrupoOpciones(modProd, DatosLocal, producto) {
//        /// <summary>Se encarga de crear el objeto para renderizar el template option_dialog_template.
//        /// Estos dialogos se usan en productos que tienen modificadores con opciones. Las opciones son
//        /// una forma de customizar los productos de una forma básica.</summary>

//        var option = {
//            titulo: modProd.nombre, // el título a mostrar
//            nombre: 'opcion' + modProd.id, // se usa para construir el 'name' para que los radios y los labels funcionen bien
//            id: modProd.id,
//            cantidad: modProd.cantidad, // la cantidad de items que puede seleccionar (si es 1, entonces se usan radio en lugar de checkbox)
//            opciones: [],
//            isOk: modProd.cantidad == modProd.opciones.length
//        };

//        for (var j = 0; j < modProd.opciones.length; j++) {
//            var opt = DatosLocal.opcionesBaseById[modProd.opciones[j]];
//            // inserto cada opción al grupo (ejemplo: 'souffle')
//            option.opciones.push({
//                id: opt.id,
//                nombre: opt.nombre,
//                // precio: modProd.usar_modificadores ? dataHelper.parseDecimalPlaces(opt.modificador_precio) : ''
//                precio: modProd.usar_modificadores ? dataHelper.parseDecimalPlaces(procesarmodificador(opt.modificador_precio, opt, producto, false)) : ''
//            });
//        }
//        return option;
//    }

//    $(function () {
//        option_dialog_template = $.templates("#option_dialog_template");
//        option_dialog_promo_grupos_template = $.templates("#option_dialog_promo_grupos_template");
//        option_dialog_promo_template = $.templates("#option_dialog_promo_template");


//        dialog = $("#pedidoDialog");
//        modalBody = $("#pedidoDialog .modal-body");
//        modalTitle = $("#pedidoDialog .modal-title");
//        subtitle = $("#pedidoDialog .subtitle");
//        dialogTotal = $("#pedidoDialog .dialog-total");
//        dialogCantidad = $("#pedidoDialog .cantidad");

//        $("#pedidoDialog").on("click", ".optional-container", function (e) {
//            if (e.target.nodeName == "H5" || e.target.className == "dim") {
//                $(this).toggleClass("visible");
//            }
//        });

//        $("#pedidoDialog").on("click", "input", inputClick);
//        $("#pedidoDialog").on("change", "select", inputClick);

//        $("#pedidoDialog .add-remove-controls .glyphicon").on("click", function (e) {
//            var target = $(e.target);
//            if (target.hasClass("glyphicon-plus")) {
//                if (cantidadTotal < 99) {
//                    cantidadTotal++;
//                    var currentTotal = recalcularPrecio();
//                    dialogTotal.text(currentTotal > 0 ? ('$' + dataHelper.parseDecimalPlaces(currentTotal * cantidadTotal)) : '');
//                    dialogCantidad.text(cantidadTotal);
//                }
//            } else if (cantidadTotal > 1) {
//                cantidadTotal--;
//                var currentTotal = recalcularPrecio();
//                dialogTotal.text(currentTotal > 0 ? ('$' + dataHelper.parseDecimalPlaces(currentTotal * cantidadTotal)) : '');
//                dialogCantidad.text(cantidadTotal);
//            }
//        });

//        $("#dialogAddButton").on("click", addPedido);
//    });

//    return {
//        initDialog: initDialog
//    };
//})();

//var pedidoModule = (function () {

//    // modulo para funciones y variables públicas
//    var module = {};

//    // variables privadas
//    var item_pedido_template;
//    var uid = 1;
//    var pedidos = {};
//    var domElements = {};
//    var pedidosSinExtras = {};
//    var total = 0;

//    function reloadPedidos() {
//        /// <summary>Recarga todo el carrito de pedidos</summary>

//        total = 0;
//        $("#pedidoVacio").show();
//        for (var prop in pedidos) {
//            $("#pedidoVacio").hide();
//            break;
//        }
//        for (var prop in pedidos) {
//            var ped = pedidos[prop];
//            if (!ped.idGrupoProducto && !ped.idGrupoPromo && ped.idProducto) {
//                var prod = productosModule.getProdById(ped.idProducto);
//                if (prod && prod.stock) {
//                    prod.stock = parseInt(prod.stock) - parseInt(ped.cantidad);
//                }
//            }
//            total += parseFloat(ped.precio_total);
//            ped.precio_total = dataHelper.parseDecimalPlaces(ped.precio_total);
//            addPedidoToDom(ped);
//        }

//        sucursalModule.changeSubtotal(total);
//    }

//    function addPedidoToDom(pedido) {
//        var newItem = $(item_pedido_template.render(pedido));
//        domElements[pedido.id] = newItem;
//        $("#pedido").append(newItem);
//        $("#pedidoVacio").hide();
//    }

//    function storePedido() {
//        /// <summary>Este método guarda o actualiza durante 20 minutos desde ahora el pedido en localStorage, y de actualizar el subtotal y total en el DOM.</summary>

//        storageHelper.tempStorage.setItem("sucursalPedidoData_" + userHelper.getIdSucursal(), {
//            uid: uid,
//            pedidos: pedidos,
//            pedidosSinExtras: pedidosSinExtras
//        }, 20);

//        var total = 0;
//        for (var prop in pedidos) {
//            total += parseFloat(pedidos[prop].precio_total);
//        }
//        sucursalModule.changeSubtotal(total)
//    }

//    function modifyPedidoCantidad(pedido, byCant) {
//        /// <summary>Se modifica la cantidad del pedido, y se actualiza el DOM para reflejar los cambios.
//        /// Si el pedido queda con una cantidad menor a 1, se devuelve false. Si queda con al menos 1 de cantidad
//        /// devuelve true. Además, siempre actualiza el pedido guardado en el localStorage.</summary>
//        var prod = productosModule.getProdById(pedido.idProducto);
//        if (prod) {
//            var stock = parseInt(prod.stock);
//            if (stock - byCant < 0) {
//                return;
//            }
//            prod.stock = stock - byCant;
//        }

//        pedido.cantidad += byCant;
//        if (pedido.cantidad < 1) {
//            pedido.cantidad = 0;
//        }

//        pedido.precio_total = pedido.precio_unitario * pedido.cantidad;

//        domElements[pedido.id].find(".precio").text("$" + dataHelper.parseDecimalPlaces(pedido.precio_total));
//        domElements[pedido.id].find(".cantidad").text(pedido.cantidad);

//        if (pedido.cantidad < 1) {
//            domElements[pedido.id].remove();
//            delete domElements[pedido.id];
//            delete pedidosSinExtras[pedido.key]
//            delete pedidos[pedido.id];
//        }

//        storePedido();

//        return pedido.cantidad > 0;
//    }

//    module.addPedido = function (obj) {
//        /// <summary>Este método se llama cuando se hace click en los productos directamente. Determina si el producto ya había sido agregado,
//        /// y lo agrega a la lista de pedidos. Si ya había sido agregado, simplemente aumenta la "cantidad" del producto. Los pedidos que vienen
//        /// con extras/adicionales son tratados todos como nuevos pedidos, ya que pueden llegar a ser muy complejos de tratar.</summary>

//        var key = (obj.idProducto || "0") + "_" + (obj.idPromo || "0") + "_" + (obj.idGrupoPromo || "0") + "_" + (obj.idGrupoProducto || "0");
//        if (pedidosSinExtras[key]) {
//            // ya se había hecho este pedido
//            modifyPedidoCantidad(pedidos[pedidosSinExtras[key]], 1);
//        }
//        else {
//            if (!obj.idPromo && !obj.idGrupoPromo && !obj.idGrupoProducto) {
//                var prod = productosModule.getProdById(obj.idProducto);
//                if (prod) {
//                    if (parseInt(prod.stock) > 0) {
//                        prod.stock = parseInt(prod.stock) - 1;
//                    } else {
//                        // no hay stock
//                        return;
//                    }
//                }
//            }

//            // es un nuevo pedido
//            var newId = uid++;

//            obj.id = newId;
//            obj.key = key;
//            pedidos[newId] = obj;

//            if (!obj.extras) {
//                pedidosSinExtras[key] = newId;
//            }

//            addPedidoToDom(obj);

//            storePedido();
//        }
//    };

//    module.incrementPedido = function (idPedido) {
//        modifyPedidoCantidad(pedidos[idPedido], 1);
//    };

//    module.decrementPedido = function (idPedido) {
//        var pedido = pedidos[idPedido];

//        modifyPedidoCantidad(pedido, -1);

//        $("#pedidoVacio").show();
//        for (var prop in pedidos) {
//            $("#pedidoVacio").hide();
//            break;
//        }
//    };

//    module.getPedidoCompleto = function () {
//        /// <summary>Parsea el pedido para ser POSTeado a la API de Datalive</summary>

//        var result = { subtotal: 0, items: [] };

//        for (var idPedido in pedidos) {
//            var current = pedidos[idPedido];
//            var parsed = getNewItemPedido(current);
//            setDetallePedido(current, parsed);
//            result.subtotal += parsed.total;
//            result.items.push(parsed);
//        }

//        return result;
//    };

//    function setDetallePedido(itemPedido, parsed) {
//        /// <summary>Setea los detalles del item del pedido (lo que se selecciona en los diálogos)</summary>

//        if (itemPedido.extras && itemPedido.extras.length) {
//            parsed.detalles = [];
//            for (var i = 0; i < itemPedido.extras.length; i++) {
//                var extra = itemPedido.extras[i];
//                for (var j = 0; j < extra.items.length; j++) {
//                    var item = extra.items[j];

//                    if (item.idOpcion) {
//                        // como tiene idOpcion el "extra" es un modificadores_productos
//                        parsed.detalles.push({
//                            idProducto: item.idProducto,
//                            idModificadorProducto: item.idModificadorProducto ? item.idModificadorProducto : extra.idModificadorProducto,
//                            idOpcion: item.idOpcion
//                        });
//                    }
//                    else {
//                        // en este caso es un producto (que opcionalmente puede pertencer a un grupos_productos)
//                        // (esto es porque en las promos se puede indicar un grupos_productos o directamente productos_base)
//                        parsed.detalles.push({
//                            idProducto: item.idProducto,
//                            idGrupoProducto: item.idGrupoProducto,
//                            cantidad: item.cantidad ? Number.parseInt(item.cantidad) : 1
//                        });
//                    }
//                }
//            }
//        }
//    }

//    function getNewItemPedido(itemPedido) {
//        /// <summary>Crea un nuevo item del pedido con las propiedades base seteadas.</summary>

//        var parsed = {};
//        if (itemPedido.idGrupoProducto) {
//            parsed.idGrupoProducto = Number.parseInt(itemPedido.idGrupoProducto);
//            parsed.idProducto = Number.parseInt(itemPedido.idProducto);
//        }
//        else {
//            parsed.idGrupoPromo = Number.parseInt(itemPedido.idGrupoPromo);
//            parsed.idPromo = Number.parseInt(itemPedido.idProducto);
//            var promocion = productosModule.getPromoById(parsed.idPromo);
//            parsed.idPromocion = promocion.idpromocion;
//        }
//        parsed.total = Number.parseFloat(itemPedido.precio_total);
//        parsed.unitario = Number.parseFloat(itemPedido.precio_unitario);
//        parsed.cantidad = Number.parseInt(itemPedido.cantidad);
//        return parsed;
//    }

//    module.initPedidos = function () {
//        item_pedido_template = $.templates("#itemPedidoTemplate");

//        $("#vaciarPedido").on("click", function () {

//            // limpio todo el pedido
//            for (var prop in domElements) {
//                domElements[prop].remove();
//            }

//            uid = 1;
//            pedidos = {};
//            pedidosSinExtras = {};
//            domElements = {};

//            storePedido();
//            reloadPedidos();
//        });

//        // me fijo si hay guardado un pedido del usuario
//        var storedPedido = storageHelper.tempStorage.getItem("sucursalPedidoData_" + userHelper.getIdSucursal());
//        if (storedPedido) {
//            uid = storedPedido.uid;
//            pedidos = storedPedido.pedidos;
//            pedidosSinExtras = storedPedido.pedidosSinExtras;

//            reloadPedidos();
//        }
//    };

//    return module;
//})();

//var sucursalModule = (function () {

//    // referencias a los templates
//    var schedule_template;
//    var subtotal_template;

//    var subtotalIniciado = false;
//    var costodelivery = 0;
//    var subtotal = 0;
//    var sucursalEstaAbierta = false;
//    var pedidoMinimo = 0;

//    // document ready
//    $(function () {
//        $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
//            // el argumento es true si se mostró el tab de sucursal
//            mapModule.shouldDisplayMap(e.target && e.target.href.indexOf("#sucursal") >= 0);
//        });

//        $("#confirmarPedido").on("click", function () {

//            $("#ModalRevisarPagaCon").css({ 'border-color': '#ccc', 'background-color': '#fff' });
//            $("#ModalRevisarTel").css({ 'border-color': '#ccc', 'background-color': '#fff' });

//            var alert = document.getElementById("alertPedidoMinimo");
//            alert.style = subtotal < pedidoMinimo ? "" : "display: none;";

//            if (subtotal < pedidoMinimo || !sucursalEstaAbierta) {
//                return;
//            }

//            var v_paga_con = $("#ModalRevisarPagaCon").val();

//            if (v_paga_con == '' || v_paga_con == 0) {
//                $("#ModalRevisarPagaCon").css({ 'border-color': '#f4686b', 'background-color': '#fee9e7' });
//                $("#PagaConMsj").html('Por favor, indique con cuanto paga.');
//                return;
//            } else {
//                v_paga_con = parseFloat(v_paga_con);
//            }


//            var v_entrecalles = $("#ModalRevisarEntreCalle").val();

//            if (v_entrecalles == '') {
//                $("#ModalRevisarEntreCalle").css({ 'border-color': '#f4686b', 'background-color': '#fee9e7' });
//                $("#EntreCalleMsj").html('Por favor, indique las entrecalles.');
//                return;
//            }


//            var v_num_tel = $("#ModalRevisarTel").val();

//            if (v_num_tel == 0 || v_num_tel == '') {
//                $("#ModalRevisarTel").css({ 'border-color': '#f4686b', 'background-color': '#fee9e7' });
//                $("#NumTelMsj").html('Ingrese su número de teléfono.');
//                return;
//            }

//            var pedido = pedidoModule.getPedidoCompleto();
//            pedido.costo_delivery = Number.parseFloat(costodelivery);
//            pedido.total = pedido.costo_delivery + pedido.subtotal;
//            pedido.comentarios = document.getElementById("comentarios").value;
//            pedido.horario = $("#deliveryTime").val();

//            if (v_paga_con != '' && v_paga_con != 0 && v_paga_con < pedido.total) {
//                $("#ModalRevisarPagaCon").css({ 'border-color': '#f4686b', 'background-color': '#fee9e7' });
//                $("#PagaConMsj").html('El valor con el que paga debe ser igual o mayor al total.');
//                return;
//            }

//            $("#confirmarPedido").attr('disabled', true);

//            var vi_idsuc = userHelper.getIdSucursal();

//            var empredata = storageHelper.tempStorage.getItem("empresaData_" + storageHelper.empresaId);
//            var vi_sucursales = empredata.sucursales;
//            var vi_suc_name = '';

//            for (i = 0; i < vi_sucursales.length; i++) {
//                if (vi_sucursales[i].id == vi_idsuc) {
//                    vi_suc_name = vi_sucursales[i].nombre;
//                }
//            }

//            pedido.suc_name = vi_suc_name;

//            pedido.paga_con = v_paga_con;
//            pedido.cli_tel = v_num_tel;

//            var v_pisoDto = localStorage.getItem('TPPDto');

//            if (v_pisoDto != '' && v_pisoDto != null && v_pisoDto != undefined) {
//                v_pisoDto.replace('"', '');
//            }

//            pedido.datos_delivery = {
//                direccion_google: userHelper.getGoogleAddress(),
//                direccion_usuario: userHelper.getUserAddress(),
//                idSucursal: userHelper.getIdSucursal(),
//                idEmpresa: dataHelper.getEmpresaId(),
//                idLocalidad: userHelper.getIdLocalidad(),
//                pisoDto: v_pisoDto,
//                entrecalles: v_entrecalles
//            };


//            //pedido.suc_name: vi_suc_name;

//            handlePedidoPost(pedido);
//        });


//        $("#revisarPedido").on("click", function () {

//            if (subtotal == 0) {
//                tepido.showMessage('bottom', 'left', 'danger', 'error', 'No se eligieron productos');
//                return;
//            }

//            if (subtotal < pedidoMinimo || !sucursalEstaAbierta) {
//                tepido.showMessage('bottom', 'left', 'warning', 'error', 'El mínimo por pedido es $' + pedidoMinimo);
//                return;
//            }

//            var v_logUsr = localStorage.getItem('TPoauth_uid');

//            if (v_logUsr == undefined || v_logUsr == '' || v_logUsr == null) {

//                $("#ModalLoginMsj").html('<div class="txtheadModalLogin"><i class="fas fa-exclamation-triangle"></i><br>Debe iniciar sesión y luego finalizar su pedido</div>');

//                $("#ModalLoginMsj").show();

//                v_modal_open = 'ModalLogin';
//                $("#btn_login").html('Ingresar');
//                $('#ModalLogin').modal();

//                return;
//            }

//            //$("#ModalRevisar").modal('toggle');

//            fcn_detalle_pedido();

//        });

//    });

//    function handlePedidoPost(pedido) {
//        /// <summary>Se encarga de hacer el POST del pedido, y manejar los errores si sucede alguno.</summary>


//        // Actualizo el popup para avisar que se esta enviando
//        //$("#ModalRevisarBody").html('<center><h3>Estamos enviando tu pedido</h3></br><img style="height: 30px; width: 30px;" src="https://www.tepido.com.ar/content/spin_loader.gif"></center>');

//        $("#ModalRevisarBody").hide();

//        $("#ModalRevisarMsj").show();
//        $("#ModalRevisarMsj").html('<center><h3>Estamos enviando tu pedido</h3></br><img src="https://www.tepido.com.ar/content/loader-food.gif"></center>');

//        var urlguardar = "";

//        if ($("#versionTPhd").val() == null || $("#versionTPhd").val() == "" || $("#versionTPhd").val() == "1.00") {
//            urlguardar = '../api/guardarpedido.php';
//        }
//        else {
//            urlguardar = '../api/guardarpedido2.php';
//        }



//        $.ajax({
//            url: urlguardar,
//            method: 'POST',
//            data: JSON.stringify(pedido),
//            error: function (data) {
//                // Type: Function( jqXHR jqXHR, String textStatus, String errorThrown )
//                // TODO manejar error
//                //$("#alertPedidoError").text("Ha ocurrido un error y no se realizó el pedido").show();

//                $("#ModalRevisar").modal('toggle');
//                tepido.showMessage('bottom', 'left', 'danger', 'error', 'Ocurrió un error al intentar realizar el pedido.');

//            },
//            success: function (data) {
//                // Type: Function( Anything data, String textStatus, jqXHR jqXHR )
//                // TODO habría que eliminar el pedido del localStorage, e indicarle
//                // al usuario que ya se realizó el pedido
//                if (data[0] == 'OK') {
//                    /*   // limpio todo el pedido
//                       for (var prop in domElements) {
//                           domElements[prop].remove();
//                       }
   
//                       uid = 1;
//                       pedidos = {};
//                       pedidosSinExtras = {};
//                       domElements = {};
   
//                       storePedido();
//                       reloadPedidos();*/

//                    $("#vaciarPedido").click();
//                    // Cargo el panel de usuario
//                    window.location.assign("/pedido.ok?c=" + data['nro_pedido']);
//                } else {
//                    //$("#alertPedidoError").text(data[1]).show();

//                    //$("#ModalRevisar").modal('toggle');
//                    //tepido.showMessage('bottom', 'left', 'danger', 'error', data[1]);

//                    if (data['inisession'] == 'X') {

//                        $("#ModalRevisar").modal('toggle');

//                        $("#confirmarPedido").attr('disabled', false);

//                        $("#ModalLoginMsj").html('<div class="txtheadModalLogin"><i class="fas fa-exclamation-triangle"></i><br>Debe iniciar sesión y luego finalizar su pedido</div>');

//                        $("#ModalLoginMsj").show();

//                        v_modal_open = 'ModalLogin';
//                        $("#btn_login").html('Ingresar');
//                        $('#ModalLogin').modal();
//                    } else {

//                        $("#ModalRevisarMsj").html('<div style="text-align: center;"><i class="far fa-frown" style="color: #F44336; font-size: 80px;"></i><br><br><b>' + data[1] + '</b><br><br><button class="btn_new btn-default" data-dismiss="modal">SALIR</button></div>');

//                        $("#confirmarPedido").attr('disabled', false);

//                    }


//                }

//            }
//        });
//    }

//    function createHorariosDelivery(useNow, from, to) {
//        // utilizo los métodos del navegador para mejorar performance (jQuery es medio lento en estos casos)
//        var select = document.getElementById('deliveryTime');
//        // el document fragment es para poder insertar todos los nuevos elementos en simultaneo (evitando renders de mas)
//        var myFragment = document.createDocumentFragment();

//        if (useNow) {
//            var opt = document.createElement('option');
//            opt.textContent = "Lo antes posible";
//            opt.value = opt.textContent;
//            myFragment.appendChild(opt);
//        }

//        while (from < to) {
//            var opt = document.createElement('option');
//            opt.textContent = dataHelper.pad(from.getHours(), 2) + ":" + dataHelper.pad(from.getMinutes(), 2);
//            opt.value = opt.textContent;
//            myFragment.appendChild(opt);

//            // agrego 15 minutos
//            from = new Date(from.getTime() + 1800000);
//        }

//        select.appendChild(myFragment);
//    }

//    function initHorarios(horarios) {
//        /// <summary>Además de renderizar el HTML para los horarios de la sucursal, se encarga de determinar si la sucursal está abierta ahora.</summary>
//        var dia = new Date().getDay();
//        for (var i = 0; i < horarios.length; i++) {
//            var d = horarios[i];
//            if (d.dia == dia) {
//                d.active = true;
//                // no hago el break por si está repetido algún día (no sé por qué se daría el caso... pero por las dudas...)
//                if (!sucursalEstaAbierta && d.horario) {
//                    for (var j = 0; j < d.horario.length; j++) {
//                        // determino si el momento actual se encuentra entre los horarios de la sucursal
//                        if (rangoHorarioModule.calculateTimespan(d.horario[j], 0) == rangoHorarioModule.results.DentroDeHorario) {
//                            sucursalEstaAbierta = true;
//                            var hasta = new Date();
//                            hasta.setHours(d.horario[j].hasta.substr(0, 2));
//                            hasta.setMinutes(d.horario[j].hasta.substr(3, 2));
//                            var desde = new Date();
//                            var desdeMinutes = desde.getMinutes();
//                            // agrego entre 15 y 30 minutos al horario actual, para que quede redondeado a intervalos de 15 minutos (13:00, 13:15, 13:30, etc.)
//                            desdeMinutes = desdeMinutes + (15 - (desdeMinutes % 15)) + 15;
//                            if (desdeMinutes >= 60) {
//                                desde.setHours(desde.getHours() + 1);
//                                desdeMinutes -= 60;
//                            }
//                            desde.setMinutes(desdeMinutes);
//                            if (hasta < desde) {
//                                // si hasta es menor que desde, es porque pusieron un horario después de las 00:00. Hago que vaya hasta el siguiente día
//                                hasta.setDate(hasta.getDate() + 1);
//                            }
//                            createHorariosDelivery(true, desde, hasta);
//                        }
//                        else if (rangoHorarioModule.calculateTimespan(d.horario[j], 60) == rangoHorarioModule.results.FaltanPocosMinutos) {
//                            // si estoy fuera del rango horario, calculo si al menos falta 1 hora (o menos) para entrar al horario de apertura
//                            // si es así, le permito al usuario hacer un pedido programado
//                            var hasta = new Date();
//                            hasta.setHours(d.horario[j].hasta.substr(0, 2));
//                            hasta.setMinutes(d.horario[j].hasta.substr(3, 2));
//                            var desde = new Date();
//                            desde.setHours(d.horario[j].desde.substr(0, 2));
//                            desde.setMinutes(d.horario[j].desde.substr(3, 2));
//                            if (hasta < desde) {
//                                // si hasta es menor que desde, es porque pusieron un horario después de las 00:00. Hago que vaya hasta el siguiente día
//                                hasta.setDate(hasta.getDate() + 1);
//                            }
//                            createHorariosDelivery(false, desde, hasta);
//                        }
//                    }
//                }
//            }
//        }
//        if (!sucursalEstaAbierta) {
//            $("#sucursalCerrada").show();
//        }
//        var htmlOutput = schedule_template.render({ horarios: horarios });
//        $("#schedule").html(htmlOutput);

//        $("#selectedTime span").text($("#deliveryTime").val());
//        $("#cambiarLink").on("click", function () {
//            $("#selectedTime").hide();
//            $("#deliveryTimeDiv").show();
//            return false;
//        });
//        $("#deliveryTime").on("change", function (e) {
//            $("#selectedTime span").text(e.target.value);
//            $("#deliveryTimeDiv").hide();
//            $("#selectedTime").show();
//            return false;
//        });
//    }

//    function initSubtotal(costoDelivery, direccionDelivery) {
//        costodelivery = costoDelivery;

//        var v_pisoDto = localStorage.getItem('TPPDto');

//        if (v_pisoDto == '' || v_pisoDto == null || v_pisoDto == undefined) {
//            v_pisoDto = '<div id="divPisoDto"><a href="javascript:void(0)" onclick="fcnAddPisoDto();" style="color: white;">+ Agregar piso / departamento</a></div>';
//        } else {
//            $(".dir_entrega").append(' <span class="savedPisoDto">' + v_pisoDto + '</span>');
//            v_pisoDto = '<div id="divPisoDto">Piso/Dpto: ' + v_pisoDto + ' <span class="glyphicon glyphicon-trash" title="Borrar piso/depto" onclick="fcnDelPisoDto();" style="cursor: pointer;"></span></div>';
//        }

//        var htmlOutput = subtotal_template.render({ subTotal: dataHelper.parseDecimalPlaces(subtotal), costoDelivery: dataHelper.parseDecimalPlaces(costoDelivery || 0), direccionDelivery: direccionDelivery, pisoDto: v_pisoDto, total: dataHelper.parseDecimalPlaces(costoDelivery + subtotal) });
//        $("#subtotal").html(htmlOutput);

//        if (costoDelivery != undefined && costoDelivery != null && costoDelivery != 0 && costoDelivery != '') {
//            $("#resumenCostoDelivery").html('<div style="margin-top:  -12px;margin-bottom:  12px;">Costo delivery $' + costoDelivery + '</div>');
//            GLOB_costoDelivery = costoDelivery;
//        }

//        $(".ver-pedido-total").text("($" + dataHelper.parseDecimalPlaces(costoDelivery + subtotal) + ")");
//        subtotalIniciado = true;
//    }

//    return {
//        sucursalAbierta: function () {
//            /// <summary>Devuelve false si la sucursal todavía no se encuentra abierta.</summary>
//            return sucursalEstaAbierta;
//        },
//        changeSubtotal: function (val) {
//            /// <summary>Actualiza el subtotal y el total en el DOM</summary>
//            subtotal = val;
//            if (subtotalIniciado) {
//                var total = dataHelper.parseDecimalPlaces(subtotal + costodelivery);
//                $("#subtotal .sub-total").text("$" + dataHelper.parseDecimalPlaces(subtotal));
//                $("#subtotal .precio").text("$" + total);
//                $(".ver-pedido-total").text("($" + total + ")");
//            }
//        },
//        initSucursal: function (id) {
//            schedule_template = $.templates("#schedule_template");
//            subtotal_template = $.templates("#subtotal_template");

//            // obtengo la data de la sucursal
//            dataHelper.getSucursalData(id)
//                .done(function (data) {
//                    // { [address | zoom + center_location], zones, markers }
//                    mapModule.setMapData({
//                        zoom: data.map.zoom,
//                        center_location: data.map.center_location,
//                        zones: [{
//                            coords: data.map.zona_entrega,
//                            marker: data.map.sucursal_coords
//                        }]
//                    });

//                    mapModule.setUserAddress(userHelper.getGoogleAddress().location);

//                    $("#address").text(data.sucursal_dir);

//                    var distancia = mapModule.calculateDistance(userHelper.getGoogleAddress().location, data.map.sucursal_coords);
//                    var unit = " m";
//                    var distText = distancia.toFixed(0);
//                    if (distancia >= 1000) {
//                        distancia = distancia / 1000;
//                        unit = " km";
//                        distText = dataHelper.parseDecimalPlaces(distancia);
//                    }
//                    $(".distancia").text(distText + unit);
//                    $(".pedido-minimo").text("$" + dataHelper.parseDecimalPlaces(data.pedido_minimo));
//                    $(".tiempo_entrega").text(data.tiempo_delivery_aprox);
//                    pedidoMinimo = data.pedido_minimo;

//                    var direccionverificada = userHelper.getGoogleAddress().short_address;
//                    if (direccionverificada.includes("null")) {
//                        //si tiene nulos uso la del usuario
//                        direccionverificada = userHelper.getUserAddress() + " " + userHelper.getGoogleAddress().short_address.substring(userHelper.getGoogleAddress().short_address.indexOf(","), userHelper.getGoogleAddress().short_address.length);
//                    }
//                    initSubtotal(data.costo_delivery, direccionverificada);
//                    initHorarios(data.horarios);
//                });
//        }
//    };
//})();

//// document ready
//$(function () {

//    $("#pedidoDialog").modal({ show: false });

//    if (storageHelper.storageAvailable()) {
//        // hay localStorage - verifico si hay una sucursal seleccionada
//        if (userHelper.getIdSucursal()) {
//            sucursalModule.initSucursal(userHelper.getIdSucursal());
//            productosModule.initProductos(userHelper.getIdSucursal());
//            pedidoModule.initPedidos();
//        }
//        else {
//            // antes tenes que elegir la sucursal!
//            window.location = "/index.php";
//        }

//        $("#mostrarPedido button").on("click", function () {
//            $("body").addClass("show-pedido");
//        });

//        $("#pedidoHeader button").on("click", function () {
//            $("body").removeClass("show-pedido");
//        });

//        $("#pedido").on("click", ".item", function (e) {
//            var target = $(e.target);
//            if (target.hasClass("glyphicon-plus") || target.hasClass("glyphicon-minus")) {
//                if (target.hasClass("glyphicon-plus")) {
//                    pedidoModule.incrementPedido(this.dataset.idItemPedido);
//                } else {
//                    pedidoModule.decrementPedido(this.dataset.idItemPedido);
//                }
//                return false;
//            }
//            $(".pedido-content .item").removeClass("show-extras");
//            $(this).addClass("show-extras");
//        });

//        scrollSidebar.initialize(".pedido-content");
//    }
//    else {
//        // TODO no hay localStorage, decidir con Diego qué hacer ¯\_(ツ)_/¯
//    }
//});

////function fcn_detalle_pedido() {

////    $('#TablaModalRevisar').empty();

////    var v_pisoDto = localStorage.getItem('TPPDto');

////    if (v_pisoDto != '' && v_pisoDto != null) {
////        $('#dir_entrega_conf').html(userHelper.getUserAddress() + ' ' + v_pisoDto);
////    } else {
////        $('#dir_entrega_conf').html(userHelper.getUserAddress());
////    }

////    $('#dir_hora_conf').html($('#deliveryTime').val());

////    if ($('#dir_hora_conf').html() != 'Lo antes posible') {
////        $('#dir_hora_conf').html($('#dir_hora_conf').html() + 'hs');
////    }

////    if ($('#comentarios').val() != '') {
////        $('#comentarios_conf').html($('#comentarios').val());
////        $('#comentarios_div').show();
////    } else {
////        $('#comentarios_div').hide();
////    }

////    var pedidoCompleto = pedidoModule.getPedidoCompleto();

////    var pedido = storageHelper.tempStorage.getItem("sucursalPedidoData_" + userHelper.getIdSucursal());
////    //var prod22 = pedidos;

////    //alert(pedido.pedidos[1].nombre);
////    var v_txt_promo = '';
////    var v_txt_cant = '';

////    for (i = 0; i < 500; i++) {
////        if (pedido.pedidos[i] != undefined) {

////            if (pedido.pedidos[i].idGrupoPromo != '') {
////                v_txt_promo = '<b>Promo </b>';
////            } else {
////                v_txt_promo = '';
////            }

////            $('#TablaModalRevisar').append('<tr><td class="text-center">' + pedido.pedidos[i].cantidad + '</td><td class="text-left">' + v_txt_promo + pedido.pedidos[i].nombre + '</td><td class="text-center">$' + pedido.pedidos[i].precio_total + '</td></tr>');

////            // Si es promo, imprimo los productos elegidos
////            if (pedido.pedidos[i].idGrupoPromo != '') {

////                if (pedido.pedidos[i].extras != null) {
////                    for (e = 0; e < pedido.pedidos[i].extras.length; e++) {

////                        $('#TablaModalRevisar').append('<tr style="color: #9e9e9e;"><td></td><td class="text-left" style="font-weight: bold; padding-top: 2px; padding-bottom: 2px;">' + pedido.pedidos[i].extras[e].nombre + '</td><td></td></tr>');

////                        for (f = 0; f < pedido.pedidos[i].extras[e].items.length; f++) {

////                            if (pedido.pedidos[i].extras[e].items[f].cantidad != undefined) {
////                                v_txt_cant = '<b>' + pedido.pedidos[i].extras[e].items[f].cantidad + 'x </b>';
////                            } else {
////                                v_txt_cant = '';
////                            }

////                            $('#TablaModalRevisar').append('<tr style="color: #9e9e9e;"><td></td><td class="text-left" style="color: #9e9e9e; padding-left: 15px; padding-top: 2px; padding-bottom: 2px;">' + v_txt_cant + pedido.pedidos[i].extras[e].items[f].nombre + '</td><td></td></tr>');


////                        }

////                    }
////                }

////            }

////        }
////    }

////    $('#ModalRevisarTotal').html(pedidoCompleto.subtotal + GLOB_costoDelivery);

////    $("#ModalRevisarBody").show();
////    $("#ModalRevisarMsj").hide();

////    $("#ModalRevisarPagaCon").css({ 'border-color': '#ccc', 'background-color': '#fff' });
////    $("#ModalRevisarTel").css({ 'border-color': '#ccc', 'background-color': '#fff' });
////    $("#PagaConMsj").html('');
////    $("#NumTelMsj").html('');
////    $("#ModalRevisarPagaCon").val('');

////    $("#confirmarPedido").attr('disabled', false);

////    $('#ModalRevisar').modal({ backdrop: 'static', keyboard: false });
////}

//function procesarmodificador(modificador_precio, opt, producto, esrecalcular) {
//    var prec = dataHelper.parseDecimalPlaces(modificador_precio);
//    var prod;
//    if (opt.id === 3) {
//        prod = productosModule.getProdById(producto.id);
//        prec = dataHelper.parseDecimalPlaces(prod.precio);
//    } else if (opt.id === 4) {
//        prod = productosModule.getProdById(producto.id);
//        prec = dataHelper.parseDecimalPlaces(prod.precio2);
//    } else if (opt.id === 5) {
//        prod = productosModule.getProdById(producto.id);
//        prec = dataHelper.parseDecimalPlaces(prod.precio3);
//    }

//    if (esrecalcular) {
//        return {
//            original: dataHelper.parseDecimalPlaces(producto.precio),
//            calculado: prec
//        };
//    }
//    else {
//        return prec;
//    }

//}

//function fcnAddPisoDto() {

//    $("#divPisoDto").html('<input onchange="fcnSavePisoDto()" style="margin: 5px; border-radius: 3px; border: none; padding: 5px; color: black;" type="text" id="pisoDtoValue" value="" placeholder="Piso / Departamento">');

//    $("#pisoDtoValue").focus();

//}

//function fcnSavePisoDto() {

//    var v_pisoDtoNew = $("#pisoDtoValue").val();

//    $("#divPisoDto").html('<div id="divPisoDto">Piso/Dpto: ' + v_pisoDtoNew + ' <span class="glyphicon glyphicon-trash" title="Borrar piso/depto" onclick="fcnDelPisoDto();" style="cursor: pointer;"></span></div>');

//    $(".dir_entrega").append(' <span class="savedPisoDto">' + v_pisoDtoNew + '</span>');

//    localStorage.setItem('TPPDto', '"' + v_pisoDtoNew + '"');

//}

//function fcnDelPisoDto() {

//    $(".savedPisoDto").empty();

//    $("#divPisoDto").html('<a href="javascript:void(0)" onclick="fcnAddPisoDto();" style="color: white;">+ Agregar piso / departamento</a>');

//    localStorage.removeItem('TPPDto');

//}