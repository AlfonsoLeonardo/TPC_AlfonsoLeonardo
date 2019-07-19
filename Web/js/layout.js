///*!
// * IE10 viewport hack for Surface/desktop Windows 8 bug
// * Copyright 2014-2015 Twitter, Inc.
// * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
// */
//// See the Getting Started docs for more information:
//// http://getbootstrap.com/getting-started/#support-ie10-width
//(function () {
//    'use strict';

//    if (navigator.userAgent.match(/IEMobile\/10\.0/)) {
//        var msViewportStyle = document.createElement('style')
//        msViewportStyle.appendChild(
//          document.createTextNode(
//            '@-ms-viewport{width:auto!important}'
//          )
//        )
//        document.querySelector('head').appendChild(msViewportStyle)
//    }
//})();

//// se llama cuando ya está lista la API de google maps
//function googleInitMapCallback() {
//    mapModule.googleApiReady();
//}

//var dataHelper = (function () {
//    var module = {};

//    module.parseDecimalPlaces = function (numero) {
//        /// <summary>Este método devuelve el número entero sin decimales, o el número con 2 decimales. Si numero
//        /// tiene más de 2 decimales, se redondea.</summary>
//        if (numero && numero % 1 != 0) {
//            return parseFloat(numero).toFixed(2);
//        }
//        return numero;
//    };
//    module.pad = function (num, size) {
//        /// <summary>Devuelve un número con 0s a la izquierda (hasta 10 máximo)</summary>
//        var s = "000000000" + num;
//        return s.substr(s.length - size);
//    };

//    // parseo el query string una única vez
//    var qs = (function (a) {
//        if (a == "") return {};
//        var b = {};
//        for (var i = 0; i < a.length; ++i) {
//            var p = a[i].split('=', 2);
//            if (p.length == 1)
//                b[p[0]] = "";
//            else
//                b[p[0]] = decodeURIComponent(p[1].replace(/\+/g, " "));
//        }
//        return b;
//    })(window.location.search.substr(1).split('&'));

//    module.getEmpresaData = function () {
//        /// <summary>Usando el ID de la empresa seleccionada (ver getEmpresaId), realiza una consulta a la API de Datalive
//        /// para obtener los datos correspondientes a la empresa (nombre y sucursales).
//        /// La data de la empresa es guardada en el localStorage del usuario por 24 horas. De esta forma, subsecuentes
//        /// llamadas a getEmpresaData resolverá la promesa de forma inmediata.</summary>
//        /// <returns type="Promise">Promesa que será resuelta con los datos de la empresa.</returns>
//        var id = module.getEmpresaId();

//        var deferred = jQuery.Deferred();

//        // verifico si todavía tengo los datos de la empresa en localStorage
//        var empresaData = storageHelper.tempStorage.getItem("empresaData_" + id);
        
//        empresaData =null; //que lo levante siempre de la base.
        
//        if (empresaData) {
//            // resuelvo la promesa inmediatamente con la data en cache
//            deferred.resolve(empresaData);
//        }
//        else {
//            // pido los datos
//           //  $.get("/api/get_empresa_data.json?eId=" + id)
           
//            var url=geturlempresa();
            
//            url= url+"?tipo=SUCURSALESTP&IDEmpresa=" + id;
             
//            $.get(url)
//                .done(function (data) {
//                    // guardo de forma temporal (default == 1 día) los datos de la empresa
//                    storageHelper.tempStorage.setItem("empresaData_" + id, data);
//                    deferred.resolve(data);
//                })
//                .fail(function () {
//                    console.log("error al hacer request a /api/get_empresa_data.json?eId=" + id);
//                    deferred.fail("Error al obtener los datos de la empresa");
//                });
//        }

//        return deferred.promise();
//    };

//    module.getEmpresaId = function () {
//        /// <summary>Devuelve el ID de la empresa con la que entró el usuario originalmente.</summary>
//        /// <returns type="Int">empresaId</returns>
//        // siempre verifico primero el query string, a ver si cambió la empresa del usuario...
//      //  var empresaId = qs["eId"];
//     var empresaId = $("#idempresahd").val();
//        if (empresaId) {
//            // guardo el ID de la empresa seleccionada, para mantenerlo de referencia en el resto de las páginas...
//            storageHelper.setItem("empresaId", empresaId);
//        }
//        else {
//            // el usuario está navegando el sitio... obtengo el ID de la empresa.
//            empresaId = storageHelper.getItem("empresaId");
//        }
//        if (!empresaId) {
//            // TODO qué hago en este caso?
//            //throw "No hay empresa seleccionada";
//            empresaId=1;
//        }
//        return empresaId;
//    };

//    var getSucursalDataDeferred;
//    module.getSucursalData = function (idSucursal) {
//        /// <summary>Usando el ID de la empresa seleccionada (ver getEmpresaId), junto al ID de la sucursal,
//        /// realiza una consulta a la API de Datalive para obtener los datos correspondientes a la sucursal.
//        /// La data de la empresa es guardada en el localStorage del usuario por 15 minutos. De esta forma, subsecuentes
//        /// llamadas a getSucursalData resolverá la promesa de forma inmediata.</summary>
//        /// <returns type="Promise">Promesa que será resuelta con los datos de la sucursal.</returns>
//        var id = module.getEmpresaId();

//        var deferred = jQuery.Deferred();

//        var storeKey = "sucursalData_" + id + "_" + idSucursal;
//        // verifico si todavía tengo los datos de la empresa en localStorage
//        var sucursalData = storageHelper.tempStorage.getItem(storeKey);
//        if (sucursalData && 1==0) {
//            // resuelvo la promesa inmediatamente con la data en cache
//            deferred.resolve(sucursalData);
//        }
//        else {
//            if (getSucursalDataDeferred) {
//                deferred = getSucursalDataDeferred;
//            }
//            else {
//                getSucursalDataDeferred = deferred;
//                // pido los datos
//               // $.get("api/get_sucursal_data.json", { idEmpresa: id, idSucursal: idSucursal })
//               //   $.get("../api/api.php/get_sucursal_data", { idEmpresa: id, idSucursal: idSucursal })
               
               
//                var url=geturlempresa();
              
//                if($("#versionTPhd").val() == null ||  $("#versionTPhd").val()=="" ||  $("#versionTPhd").val()=="1.00")
//                {
//                  url= url+"?tipo=DatosLocalTP&IDEmpresa=" + id + "&IDSucursal="+idSucursal;
//                }else
//                {
//                  url= url+"?tipo=DatosLocalTP2&IDEmpresa=" + id + "&IDSucursal="+idSucursal;
//                }
              
                
//                 $.get(url)
            
//                    .done(function (data) {
//                        // guardo durante 15 minutos los datos de la sucursal
//                        storageHelper.tempStorage.setItem(storeKey, data, 5);
//                        deferred.resolve(data);
//                        getSucursalDataDeferred = null;
//                    })
//                    .fail(function () {
//                        console.log("error al hacer request a /api/get_sucursal_data.json?idEmpresa=" + id + "&idSucursal=" + idSucursal);
//                        deferred.fail("Error al obtener los datos de la sucursal");
//                        getSucursalDataDeferred = null;
//                    });
//            }
//        }

//        return deferred.promise();
//    };

//    return module;
//})();

//var storageHelper = (function () {
//    /// <summary>
//    /// Este módulo es para facilitar el manejo del localStorage. Como localStorage sólo permite guardar strings, storageHelper
//    /// se encarga automáticamente de hacerle stringify a los objetos para poder guardarlos. Al obtenerlos, los parsea de nuevo
//    /// a un objeto. Además, agrega shortcuts de los objetos. Por lo tanto, se puede utilizar storageHelper.miPropiedad, y en
//    /// la consola de debug aparecerá el objeto completo con sus propiedades, etc.
//    /// </summary>
//    /// <remarks>Como localStorage maneja strings, hay que volver a setear los objetos que fueron modificados</remarks>

//    var module = {};

//    module.storageAvailable = function () {
//        /// <summary>Determina si localStorage está disponible para ser utilizado.</summary>
//        /// <returns type="Bool">true o false</returns>
//        try {
//            var storage = window["localStorage"],
//                x = '__storage_test__';
//            storage.setItem(x, x);
//            storage.removeItem(x);
//            return true;
//        }
//        catch (e) {
//            return false;
//        }
//    }

//    // TODO: Hay que decidir qué hacer si localStorage no está disponible...

//    // el temp storage agrega funcionalidad para hacer que los items expiren después de X minutos
//    module.tempStorage = {};
//    module.tempStorage.prefix = "tempStorage_";
//    module.tempStorage.defaultExpiration = 1440; // 1440 minutos => 1 día
//    module.tempStorage.setItem = function (key, item, minutes) {
//        /// <summary>Guarda un item en localStorage con tiempo de expiración. El tiempo de expiración está definido en
//        /// tempStorage.defaultExpiration (minutos), o puede ser especificado en el 3er argumento.</summary>
//        /// <param name="key" type="String">La clave del item a guardar.</param>
//        /// <param name="item" type="Object">El item a guardar.</param>
//        /// <param name="minutes" type="Int">Opcional. La cantidad de minutos en que expira el item. El default es 1 día.</param>
//        if (!minutes) {
//            minutes = module.tempStorage.defaultExpiration;
//        }
//        if (!isRestrictedKey(key)) {
//            var obj = { expiration: new Date().getTime() + minutes * 60000, obj: item };
//            localStorage.setItem(module.tempStorage.prefix + key, JSON.stringify(obj));
//            // guardo el shortcut. Sin embargo, al acceder por el shortcut no se ejecutará la validación de expiración
//            // igual en la próxima recarga de la página, si el item ya expiró, se eliminará de localStorage
//            module[key] = item;
//        }
//    };
//    module.tempStorage.getItem = function (key) {
//        /// <summary>Devuelve el item guardado previamente.</summary>
//        /// <param name="key" type="String">La clave del item a guardar.</param>
//        /// <returns type="Object">El item, o null si no existe o ya expiró.</returns>
//        if (!isRestrictedKey(key)) {
//            storageKey = module.tempStorage.prefix + key;
//            var item = module.getItem(storageKey);
//            if (!item || item.expiration < new Date().getTime()) {
//                // el item no existe o ya expiró, lo borro y devuelvo null
//                delete module[key];
//                localStorage.removeItem(storageKey);
//                return null;
//            }
//            return item.obj;
//        }
//        return null;
//    };

//    // estos items son guardados para siempre en el navegador...
//    module.getItem = function (key) {
//        /// <summary>Devuelve el item guardado previamente.</summary>
//        /// <param name="key" type="String">La clave del item a guardar.</param>
//        /// <returns type="Object">El item, o null si no existe.</returns>
//        if (!isRestrictedKey(key)) {
//            return JSON.parse(localStorage.getItem(key));
//        }
//    };
//    module.setItem = function (key, item) {
//        /// <summary>Guarda un objeto en localStorage.</summary>
//        /// <param name="key" type="String">La clave del item a guardar.</param>
//        if (!isRestrictedKey(key)) {
//            localStorage.setItem(key, JSON.stringify(item));
//            module[key] = item;
//        }
//    };
//    module.removeItem = function (key) {
//        /// <summary>Elimina el item de localStorage.</summary>
//        /// <param name="key" type="String">La clave del item a eliminar.</param>
//        if (!isRestrictedKey(key)) {
//            delete module[key];
//            localStorage.removeItem(key);
//        }
//    };

//    // los nombres de funciones anteriores no pueden ser utilizados como keys...
//    var restrictedNames = [];
//    for (var prop in module) { restrictedNames.push(prop); }
//    var isRestrictedKey = function (name) {
//        /// <summary>Hay ciertas claves que no puede ser utilizadas para guardar en localStorage.
//        /// Son todos los métodos del storageHelper (setItem, removeItem, etc).</summary>
//        /// <param name="name" type="String">La clave a usar para guardar un item.</param>
//        /// <returns type="Bool">true si no se puede utilizar el nombre como clave para guardar en local storage.
//        /// false si está permitido.</returns>
//        for (var i = 0; i < restrictedNames.length; i++) {
//            if (restrictedNames[i] == name) {
//                return true;
//            }
//        }
//        return false;
//    };

//    if (module.storageAvailable()) {
//        // vuelvo a recrear todos los shortcuts, con lo que ya estaba guardado en localStorage.
//        for (var prop in localStorage) {
//            if (isRestrictedKey(prop)) {
//                break;
//            }
//            if (prop.indexOf(module.tempStorage.prefix) < 0) {
//                module[prop] = module.getItem(prop);
//            }
//            else {
//                var itemKey = prop.substr(module.tempStorage.prefix.length);
//                var item = module.tempStorage.getItem(itemKey);
//                if (item) {
//                    // si el item todavía no expiró, lo agrego como shortcut
//                    module[itemKey] = item;
//                }
//            }
//        }
//    }

//    module.removeAll = function () {
//        /// <summary>Elimina toda la data guardada en localStorage.</summary>
//        for (var prop in localStorage) {
//            localStorage.removeItem(prop);
//        }
//    };

//    return module;
//})();

//var userHelper = (function () {
//    var module = {};

//    if (!storageHelper.usuario) {
//        // inicializo la propiedad "usuario" si es que no existía
//        storageHelper.setItem("usuario", {});
//    }

//    module.getUserAddress = function () {
//        /// <summary>Maneja el storageHelper para obtener la dirección del usuario.</summary>
//        /// <returns type="String">usuario.address</returns>
//        var usuario = storageHelper.usuario;
//        return usuario.address;
//    };

//    module.setUserAddress = function (address) {
//        /// <summary>Guarda la dirección ingresada por el usuario.</summary>
//        /// <param name="address" type="String">La dirección tal cual la ingresó el usuario.</param>
//        var usuario = storageHelper.usuario;
//        usuario.address = address;
//        storageHelper.setItem("usuario", usuario);
//    };

//    module.setGoogleAddress = function (address) {
//        /// <summary>Guarda la dirección formateada por el geocoder de google.</summary>
//        /// <param name="address" type="Object">La dirección de google. Objecto con { formatted_address, location }</param>
//        var usuario = storageHelper.usuario;
//        usuario.googleAddress = address;
//        storageHelper.setItem("usuario", usuario);
//    };

//    module.getGoogleAddress = function () {
//        /// <summary>Maneja el storageHelper para obtener la dirección del usuario estandarizada por google.</summary>
//        /// <returns type="object { formatted_address, location }">usuario.googleAddress</returns>
//        var usuario = storageHelper.usuario;
//        return usuario.googleAddress;
//    };

//    module.setIdSucursal = function (idSucursal) {
//        /// <summary>Guarda el ID de la sucursal seleccionada en base a la dirección ingresada por el usuario.</summary>
//        /// <param name="idSucursal" type="String">El ID de la sucursal.</param>
//        var usuario = storageHelper.usuario;
//        usuario.idSucursal = idSucursal;
//        storageHelper.setItem("usuario", usuario);
//    };

//    module.getIdSucursal = function () {
//        /// <summary>Devuelve el ID de la sucursal seleccionada previamente.</summary>
//        /// <returns type="Int"></returns>
//        var usuario = storageHelper.usuario;
//        return usuario.idSucursal;
//    };
    
//    module.setIdLocalidad = function (idlocalidad) {
//        /// <summary>Guarda el ID de la sucursal seleccionada en base a la dirección ingresada por el usuario.</summary>
//        /// <param name="idSucursal" type="String">El ID de la sucursal.</param>
//        var usuario = storageHelper.usuario;
//        usuario.idlocalidad = idlocalidad;
//        storageHelper.setItem("usuario", usuario);
//    }
    
//    module.getIdLocalidad = function () {
//        /// <summary>Devuelve el ID de la sucursal seleccionada previamente.</summary>
//        /// <returns type="Int"></returns>
//        var usuario = storageHelper.usuario;
//        return usuario.idlocalidad;
//    };

//    return module;
//})();

//var mapModule = (function () {
//    // variables
//    var map;
//    var zones = [];
//    var markers = [];
//    var userMarker = null;
//    var userLocation = null;
//    var isReady = false;
//    var isVisible = false;
//    var mapData = null; // properties { address, zoom, center_location, zones, markers }
//    var _geocoder = null;

//    var defaultZoom = 14;
//    var defaultCenter = { lat: -34.613070, lng: -58.381097 };

//    function getGeocoder() {
//        if (!_geocoder) {
//            _geocoder = new google.maps.Geocoder();
//        }
//        return _geocoder;
//    }

//    function rad(x) {
//        return x * Math.PI / 180;
//    }

//    function calculateDistance(p1, p2) {
//        /// <summary>Devuelve la distancia en metros entre dos puntos.</summary>
//        var R = 6378137; // Earth’s mean radius in meter
//        var dLat = rad(p2.lat - p1.lat);
//        var dLong = rad(p2.lng - p1.lng);
//        var a = Math.sin(dLat / 2) * Math.sin(dLat / 2) +
//          Math.cos(rad(p1.lat)) * Math.cos(rad(p2.lat)) *
//          Math.sin(dLong / 2) * Math.sin(dLong / 2);
//        var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
//        var d = R * c;
//        return d; // returns the distance in meter
//    }

//    function createMap(zoom, center) {
//        /// <summary>Crea el google.maps.Map si todavía no fue inicializado.</summary>
//        /// <param name="zoom" type="Int">Opcional. El nivel de zoom en el mapa. Default 14.</param>
//        /// <param name="center" type="Location">Opcional. El punto donde centrar el mapa. Default { lat: -34.613070, lng: -58.381097 }.</param>
//        /// <returns type="Promise">Promesa que se resuelve cuando el mapa ya está creado.
//        /// La promesa se usa para que sea compatible con initMapOnAddress.</returns>
//        var defer = $.Deferred();
//        if (!map) {
//            // indico a google maps que use el elemento "map_placeholder" para insertar el mapa
//            map = new google.maps.Map(document.getElementById('map_placeholder'), {
//                zoom: zoom || defaultZoom,
//                center: center || defaultCenter,
//                mapTypeId: google.maps.MapTypeId.ROADMAP,
//                streetViewControl: false
//            });
//        }
//        defer.resolve();
//        return defer.promise();
//    }

//    function centerMapAndMarker(location, zoom) {
//        /// <summary>Centra el mapa en las coordenadas provistas, y crea el Marker (estilo usuario) en esas coordenadas.</summary>
//        /// <param name="location" type="Location">El punto donde centrar el mapa.</param>
//        /// <param name="zoom" type="Int">Opcional. El nivel de zoom a utilizar.</param>
//        map.setZoom(zoom || defaultZoom);
//        map.setCenter(location);

//        if (!userMarker) {
//            // es la primer búsqueda, así que creo el marker
//            userMarker = new google.maps.Marker({
//                position: location,
//                map: map,
//                icon: 'https://chart.apis.google.com/chart?chst=d_map_pin_letter&chld=%E2%80%A2|33AA33'
//            });
//        }
//        else {
//            // simplemente muevo el marker de lugar
//            userMarker.setPosition(location);
//        }
//    }

//    function centerMapAndMarkerByAddress(address, zoom) {
//        /// <summary>Centra el mapa en la dirección indicada, si es que el geocoder determina un lugar.</summary>
//        /// <param name="address" type="String">La dirección a buscar.</param>
//        /// <param name="zoom" type="Int">Opcional. El nivel de zoom a utilizar.</param>
//        // obtengo el geocoder para buscar direcciones
//        geocoder = getGeocoder();
//        // hago la consulta al geocoder
//        geocoder.geocode({ 'address': address }, function (geocoderResults, status) {
//            // gecode hace un request async a Google, y se llama a la función callback cuando termina...
//            switch (status) {
//                // referencia de los status del geocoder https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingStatusCodes
//                case google.maps.GeocoderStatus.OK:
//                    centerMapAndMarker(geocoderResults[0].geometry.location, 15);
//                    break;
//                default:
//                    break;
//            }
//        });
//    }

//    function repositionMap() {
//        /// <summary>Este método se utiliza cuando se obtiene la data del mapa (zonas y sucursales), pero el mapa ya había sido inicializado
//        /// (fue más rápido Google que la API de Datalive).</summary>
//        // tomo los datos en mapData, y reposiciono el mapa...
//        if (map && mapData && typeof (mapData) == "string" && mapData.trim()) {
//            centerMapAndMarkerByAddress(mapData);
//        }
//        else if (map && mapData && typeof (mapData) == "object") {
//            if (mapData.address && mapData.address.trim()) {
//                centerMapAndMarkerByAddress(mapData.address);
//            }

//            createZones();
//            createMarkers();
//        }
//    }

//    function createZones() {
//        /// <summary>Crea los google.maps.Polygon y los google.maps.Marker de las zonas indicadas en mapData.zones.</summary>
//        if (mapData && mapData.zones) {
//            for (var i = 0; i < mapData.zones.length; i++) {
//                var zone = mapData.zones[i];
//                if (zone.coords != null)
//                {
//                    // creo el polígono. Los puntos del polígono se van dibujando en el orden que los insertas, y el
//                    // último punto lo cierra con el primer punto.
//                    var zonePolygon = new google.maps.Polygon({
//                        paths: zone.coords,
//                        strokeColor: '#3eb200',
//                        strokeOpacity: 0.8,
//                        strokeWeight: 3,
//                        fillColor: '#93ff59',
//                        fillOpacity: 0.25
//                    });
//                    zone.zonePolygon = zonePolygon;
//                    zonePolygon.setMap(map);
//                    zones.push(zone);
    
//                    if (zone.marker) {
//                        // creo el marker
//                        markers.push(new google.maps.Marker({
//                            position: zone.marker,
//                            map: map
//                        }));
//                    }
//               }
//            }
//        }
//    }

//    function createMarkers() {
//        /// <summary>Crea los google.maps.Marker de las markers indicados en mapData.markers.</summary>
//        if (mapData && mapData.markers) {
//            for (var i = 0; i < mapData.markers.length; i++) {
//                // creo el marker (los de las sucursales deberían ir junto a la zona de la sucursal... pero bueno, es opcional)
//                markers.push(new google.maps.Marker({
//                    position: mapData.markers[i],
//                    map: map
//                }));
//            }
//        }
//    }

//    function createUserMarker() {
//        /// <summary>Crea el google.maps.Marker en el location del usuario si fue indicado.</summary>
//        if (userLocation) {
//            centerMapAndMarker(userLocation, 16);
//        }
//    }

//    function initMap() {
//        /// <summary>Se encarga de crear el mapa en base a los datos seteados. Si la API de Google todavía no está lista, no hace nada.
//        /// Si los datos del mapa (mapData) todavía no fueron seteados, no hace nada. Si el mapa ya fue incializado, no hace nada.
//        /// Este método se llama cuando el div del mapa se hace visible, cuando la API de Google termina de cargar, y cuando
//        /// los datos del mapa son seteados.</summary>
//        if (mapData == null || map || !isReady) {
//            return;
//        }

//        var mapPromise;
//        if (typeof (mapData) == "string") {
//            mapPromise = initMapOnAddress(mapData);
//        }
//        else if (mapData.address) {
//            mapPromise = initMapOnAddress(mapData.address);
//        }
//        else {
//            mapPromise = createMap(mapData.zoom, mapData.center_location);
//        }

//        // espero a que el mapa ya esté creado...
//        mapPromise.done(function () {
//            createZones();
//            createMarkers();
//            createUserMarker();
//        });
//    }

//    function initMapOnAddress(address) {
//        /// <summary>Utiliza el geocoder de Google para determinar la dirección indicada, y crear el mapa centrado
//        /// en esa dirección. Si no encuentra la dirección, crea el mapa centrado en su posición por default.</summary>
//        /// <returns type="Promise">Devuelve una promesa que es resuelta cuando el mapa ya está creado.</returns>
//        if (address && address.trim()) {
//            var defer = $.Deferred();

//            // creo el geocoder para buscar direcciones
//            geocoder = getGeocoder();
//            // hago la consulta al geocoder
//            geocoder.geocode({ 'address': address }, function (geocoderResults, status) {
//                // gecode hace un request async a Google, y se llama a la función callback cuando termina...
//                switch (status) {
//                    // referencia de los status del geocoder https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingStatusCodes
//                    case google.maps.GeocoderStatus.OK:
//                        // centro el mapa en la dirección
//                        createMap(15, geocoderResults[0].geometry.location);
//                        centerMapAndMarker(geocoderResults[0].geometry.location);
//                        defer.resolve();
//                        break;
//                    default:
//                        createMap();
//                        defer.resolve();
//                        break;
//                }
//            });

//            return defer.promise();
//        }
//        else {
//            return createMap();
//        }
//    }

//    function googleApiReady() {
//        /// <summary>Esta función se llama cuando la API de Google ya terminó de cargar. Si el mapa está visible (se llamó a shouldDisplayMap(true)),
//        /// se inicializa el mapa.</summary>
//        isReady = true;
//        if (isVisible) {
//            initMap();
//        }
//    }

//    function shouldDisplayMap(should) {
//        /// <summary>Setea el flag interno que indica si el mapa está visible o no. Esto es necesario porque al crear el mapa, el mismo tiene que
//        /// estar visible para que haga su render correctamente. Además, llama a initMap para inicializar el mapa si las condiciones son las correctas.</summary>
//        /// <param name="should" type="Bool">true si el mapa está visible. false si no lo está.</param>
//        isVisible = should;
//        if (isVisible) {
//            initMap();
//        }
//    }

//    function setMapData(data) {
//        /// <summary>Setea los datos del mapa. Si el mapa ya estaba inicializado, hace un reposition del mapa en la nueva posición.</summary>
//        /// <param name="data" type="Object|String">Si es un string, indica la dirección donde centrar el mapa. Si es un objeto, las
//        /// propiedades posibles son { [address|zoom + center_location], zones, markers }. Si se indica 'address', zoom y center_location no se
//        /// utilizan. Si no se indica address, zoom y center_location son requeridos.</param>
//        if (typeof (data) == "string") {
//            if (mapData && typeof (mapData) == "object") {
//                mapData.address = data;
//            }
//            else {
//                mapData = data;
//            }
//        }
//        else {
//            mapData = data;
//        }
//        // verifico que el mapa no esté inicializado
//        if (!map) {
//            if (isVisible) {
//                initMap();
//            }
//        }
//        else {
//            // el mapa ya fue inicializado. Como se está seteando nueva data del mapa (una dirección, o coordenadas del mapa especificamente)
//            // tengo que modificar el mapa para mostrarse en el lugar correcto
//            repositionMap();
//        }
//    }

//    function getTypeAddress(type, geocoderResult) {
//        if (geocoderResult && geocoderResult.address_components) {
//            for (var i = 0; i < geocoderResult.address_components.length; i++) {
//                var ac = geocoderResult.address_components[i];
//                for (var j = 0; j < ac.types.length; j++) {
//                    if (ac.types[j] == type) {
//                        return ac.short_name || ac.long_name;
//                    }
//                }
//            }
//        }

//        return null;
//    }

//    function getZoneAddress(address) {
//        /// <summary>Realiza una búsqueda con el geocoder, y determina si la dirección indicada cae dentro de alguna de las zonas indicadas
//        /// en mapData. Si se encuentra dentro de una zona, resuelve la promesa con la zona como primer parámetro, y segundo parámetro con
//        /// la dirección formateada por Google. Si no se encuentra la dirección, se rechaza la promesa con { address_found: false }. Si
//        /// se encuentra la dirección, pero no está dentro de una zona, se rechaza la promesa con { address_found: true }.</summary>
//        /// <param name="address" type="String">La dirección deseada.</param>
//        /// <returns type="Promise"></returns>
//        var defer = $.Deferred();

//        var geocoder = getGeocoder();
//        // hago la consulta al geocoder
//        geocoder.geocode({ 'address': address }, function (geocoderResults, status) {
//            // gecode hace un request async a Google, y se llama a la función callback cuando termina...
//            switch (status) {
//                // referencia de los status del geocoder https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingStatusCodes
//                case google.maps.GeocoderStatus.OK:
//                    // centro el mapa en la dirección
//                    centerMapAndMarker(geocoderResults[0].geometry.location, 16);

//                    for (var i = 0; i < zones.length; i++) {
//                        var zone = zones[i];
//                        // verifico si el location está dentro del polígono
//                        var isInside = google.maps.geometry.poly.containsLocation(geocoderResults[0].geometry.location, zone.zonePolygon);
//                        // resuelvo la promesa con la zona que contiene la dirección, y la dirección formateada por google para que la sucursal tenga un formato standard de direcciones
//                        if (isInside) {
//                            // creo una "short address" para luego mostrar en la parte de subtotal para indicar a dónde es el delivery
//                            var number = getTypeAddress("street_number", geocoderResults[0]);
//                            var streetName = getTypeAddress("route", geocoderResults[0]);
//                            var locality = getTypeAddress("locality", geocoderResults[0]);
//                            if (!locality) {
//                                // si no encuentro localidad, uso la primer división política (normalmente debería ser la localidad...)
//                                locality = getTypeAddress("political", geocoderResults[0]);
//                            }
                            
//                            if(number == null || streetName == null)
//                            {
//                                 // no se encontró una dirección...
//                                defer.reject({ address_found: false });
//                                break;
//                            }
                            
//                            var shrt = streetName + " " + number + ", " + locality;
//                            defer.resolve(zone, { formatted_address: geocoderResults[0].formatted_address, short_address: shrt, location: geocoderResults[0].geometry.location });
//                            return;
//                        }
//                    }
//                    // no se encuentra dentro de una zona...
//                    defer.reject({ address_found: true });
//                    break;
//                default:
//                    // no se encontró una dirección...
//                    defer.reject({ address_found: false });
//                    break;
//            }
//        });

//        return defer.promise();
//    }

//    function setUserAddress(location) {
//        /// <summary>Setea en el mapa el marker del usuario.</summary>
//        /// <param name="address" type="Object">Las coordenadas de la dirección del usuario.</param>

//        userLocation = location;
//        if (map) {
//            // centro el mapa en la dirección
//            centerMapAndMarker(location, 16);
//        }
//        else {
//            userLocation = location;
//        }
//    }

//    return {
//        googleApiReady: googleApiReady,
//        shouldDisplayMap: shouldDisplayMap,
//        setMapData: setMapData,
//        getZoneAddress: getZoneAddress,
//        setUserAddress: setUserAddress,
//        calculateDistance: calculateDistance
//    }
//})();