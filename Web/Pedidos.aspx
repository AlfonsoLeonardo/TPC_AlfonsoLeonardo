<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="Web.Pedidos" %>
<!DOCTYPE html>
<html lang="es-ar">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Los 3 tags de arriba tienen que ser los primeros; NO MOVERLOS -->
    <title>Mi Pizza | Pedidos online</title>

    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <link rel="stylesheet" href="css/bootstrap-theme.css">
    <link rel="stylesheet" href="css/Site.css">
    
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700,300|Material+Icons" rel="stylesheet" type="text/css">
    
    <link rel="stylesheet" href="css/totop.css">
  </head>  
<style>
    @media only screen and (min-width: 769px) {

        .top_bar_navbar {
            border: solid 0px;
            background-repeat: no-repeat;
            background-size: cover;
            height: 150px;
            background-image: url('images/fondoPortadaNegro.jpg');
        }
    }

    @media only screen and (max-width: 768px) {

        .top_bar_navbar {
            border: solid 0px;
            background-repeat: no-repeat;
            background-image: url('images/fondoPortadaNegro.jpg');
        }
    }

    .back-to-top {
        cursor: pointer;
        position: fixed;
        bottom: 0;
        right: 20px;
        display: none;
    }
</style>



<body>
     
    <nav id="nav_header" class="navbar navbar-inverse top_bar_navbar only_desktop sombraBox">
        <div class="gradient_1" style="height: 150px;" id="grad_1"></div>
        <div class="container-fluid" style="z-index: 20; position: relative;">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Ver/Ocultar navegación</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            
            <div id="navbar" class="collapse navbar-collapse" style="margin-left: 10%; margin-top: 35px;">
                
                <div class="navbar-brand">
                    <div id="container_image_pedido" class="sombraBox">
                        <img id="div_image_pedido" src="images/logo.png" width="120px">
                    </div>
                    <div class="div_titulo_pedido class_titulo_pedido white sombraText2">Cargando</div>
                    <div class="div_dir_cliente"><span class="dir_entrega white">Cargando dirección</span> <a class="white-link" href="#" onclick="goBack();">(Cambiar Dirección)</a></div>
                    <div class="div_distancia">Distancia</br><span class="distancia">-</span></div>
                    <div class="div_pedido_minimo">Pedido mínimo</br><span class="pedido-minimo">-</span></div>
                    <div class="div_tiempo_entrega">Tiempo Entrega</br><span class="tiempo_entrega">-</span></div>
                </div>
                
            </div><!--/.nav-collapse -->
            

            <div class="head_right_btn" id="div_desconectado">
              <button type="button" class="btn button_new" id="btn_ini_sesion">Iniciar sesion</button>
              <button type="button" class="btn button_new registrarse" id="btn_register">Registrate</button>
            </div>
            
            <ul class="nav navbar-nav navbar-right navbar_not_collapse" id="div_conectado">
                    <li class="dropdown">
                <a href="#" class="dropdown-toggle" data-toggle="dropdown" style="color: white;">
                
                <center><div class="div_img_user"></div></center>
                
                <span id="user_name"></span>
                
                </a>
                <ul class="dropdown-menu">
                  <li><a href="/user/pedidos_" id="btn_mi_cuenta"><span class="glyphicon glyphicon-copy" aria-hidden="true"></span> Pedidos realizados</a></li>
                  <li><a href="/user/direcciones" id="btn_mi_cuenta"><span class="glyphicon glyphicon-home" aria-hidden="true"></span> Mis direcciones</a></li>
                  <!--<li><a href="/user/favoritos" id="btn_mi_cuenta"><span class="glyphicon glyphicon-heart" aria-hidden="true"></span> Tiendas favoritas</a></li>-->
                  <li><a href="/user/perfil" id="btn_mi_cuenta"><span class="glyphicon glyphicon-user" aria-hidden="true"></span> Perfil</a></li>                  <li class="divider"></li>
                  <li><a href="#" class="btn_logout"><span class="glyphicon glyphicon-log-out" aria-hidden="true"></span> Cerrar sesión</a></li>
                </ul>
              </li>
            </ul>
            
        </div>
    </nav>
    
    
    <nav class="navbar navbar-inverse only_mobile" role="navigation" style="top: -3px; min-height: 155px;">
        
        <div>
          <div class="navbar-brand">
              <div id="container_image_pedido" style="margin-top: 35px;">
                  <img id="div_image_pedido" src="images/logo.png" width="120px">
              </div>
              <div class="div_titulo_pedido class_titulo_pedido letras_sombra">Cargando</div>
              <div class="div_dir_cliente"><span class="dir_entrega letras_sombra">Cargando dirección</span> <a class="letras_sombra" href="#" onclick="goBack();">(Cambiar Dirección)</a></div>
              <div class="div_distancia letras_sombra">Distancia</br><span class="distancia">-</span></div>
              <div class="div_pedido_minimo letras_sombra">Pedido mínimo</br><span class="pedido-minimo">-</span></div>
          </div>
          
          <div class="navbar-header top_bar_navbar">
            <button type="button" class="div_img_user user_img_button_mobile" style="margin-top: 110px;" data-toggle="collapse" data-target=".navbar-ex1-collapse"></button>
          
          </div>
         
          <div class="collapse navbar-collapse navbar-ex1-collapse" style="background-color: rgba(255, 255, 255, 0.4)">
            <ul class="nav navbar-nav">
              <li class="btn_menu_mobile div_desconectado_mobile text-center" id="btn_ini_sesion_mobile"><a style="color: white;" href="#">Iniciar sesión</a></li>
              <li class="btn_menu_mobile div_desconectado_mobile registrarse text-center"><a style="color: white;" href="#">Registrate</a></li>
              
              <li class="btn_menu_mobile div_conectado_mobile" style="display: none;"><a style="color: white;" href="/user/pedidos_" id="btn_mi_cuenta"><span class="glyphicon glyphicon-copy" aria-hidden="true"></span> Pedidos realizados</a></li>
              <li class="btn_menu_mobile div_conectado_mobile" style="display: none;"><a style="color: white;" href="/user/direcciones" id="btn_mi_cuenta"><span class="glyphicon glyphicon-home" aria-hidden="true"></span> Mis direcciones</a></li>
        <!--  <li><a href="/user/favoritos" id="btn_mi_cuenta"><span class="glyphicon glyphicon-heart" aria-hidden="true"></span> Tiendas favoritas</a></li>-->          
              <li class="btn_menu_mobile div_conectado_mobile" style="display: none;"><a style="color: white;" href="/user/perfil" id="btn_mi_cuenta"><span class="glyphicon glyphicon-user" aria-hidden="true"></span> Perfil</a></li>
              <li class="btn_menu_mobile div_conectado_mobile" style="display: none;"><a style="color: white;" href="#" class="btn_logout"><span class="glyphicon glyphicon-log-out" aria-hidden="true"></span> Cerrar sesión</a></li>
        
            </ul>
          </div>
      </div>
      
    </nav>
    
    
    <div class="container-fluid">
        <div id="main_div_seleccion" class="row" style="background-image: url();">
            <div class="main-content col-xs-12 col-md-8 col-lg-7 col-lg-offset-1">
               
            
                <div id="sucursalCerrada" class="alert alert-danger" style="display: none;">La sucursal se encuentra cerrada.</div>
                <div>
                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs" role="tablist">
                        <li role="presentation" class="active"><a href="#menu" aria-controls="menu" role="tab" data-toggle="tab">Menú</a></li>
                        <li role="presentation"><a href="#sucursal" aria-controls="sucursal" role="tab" data-toggle="tab">Sucursal</a></li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content">
                        <div role="tabpanel" class="tab-pane fade in active" id="menu">
                            <div id="productosContainer" class="inner-tab-content">
        <section>
            <div class="menu-header">
                <div class="col-xs-12">
                    <h3>Empanadas</h3>
                    
                    <img src="images/mgHeadEmpanadas.jpg">
                    
                </div>
                
            </div>
             <% cargar(5, 9999); %>
            <div class="productos">
                
             
                 <% foreach (var comidas in comidas)
                     { %>
                <div class="col-xs-12 col-sm-6 col-lg-4">
                    <div class="producto sombraBox" id="<%= comidas.Id %>"data-disabled="" data-id-producto="<%= comidas.Id %>" data-id-promo="" data-id-grupo-promo=" <%= comidas.TC.Id %>" data-id-grupo-producto="1" data-precio-mostrado="<%= comidas.Precio %>" onclick="agregarProducto(<%= comidas.Id %>, '<%= comidas.Nombre %>', <%= comidas.Precio %>, '<%= comidas.TC.Nombre %>')">
                        <div class="precio-producto">
                            <span> <%= comidas.Precio %></span>
                            
                        </div>
                        <h4 class="nombre-producto">
                           <%= comidas.Nombre %>
                        </h4>
                        <div class="agregar-producto"><b class="far fa-plus-square" id="cm<%= comidas.Id %>"title="Agregar a mi pedido"></b></div>
                        
                        <p class="descripcion-producto"><%= comidas.TC.Nombre %></p>
                        
                    </div>
                </div>
               <% } %>
                
            </div>
        </section>
    
        <section>
            <div class="menu-header">
                <div class="col-xs-12">
                    <h3>Pizzas</h3>
                    
                   <img src="images/Pizzas.jpg">
                    
                </div>
                
            </div>
            <div class="productos">
                 <% cargar(2, 3); %>
                 <% foreach (var comidas in comidas)
                     { %>
                <div class="col-xs-12 col-sm-6 col-lg-4">
                    <div class="producto sombraBox" data-disabled="" onclick="agregarProducto(<%= comidas.Id %>, '<%= comidas.Nombre %>', <%= comidas.Precio %>, '<%= comidas.TC.Nombre %>')" data-id-producto="<%= comidas.Id %>" data-id-promo="" data-id-grupo-promo=" <%= comidas.TC.Id %>" data-id-grupo-producto="1" data-precio-mostrado="50">
                        <div class="precio-producto">
                            <span> <%= comidas.Precio %></span>
                                                   </div>
                        <h4 class="nombre-producto">
                           <%= comidas.Nombre %>
                        </h4>
                        <div class="agregar-producto">
                            
                            <b class="far fa-plus-square" title="Agregar a mi pedido"></b></div>
                        
                        <p class="descripcion-producto"><%= comidas.TC.Nombre %></p>
                        
                    </div>
                </div>
               <% } %>
            </div>
        </section>
                            </div>
                        </div> <!-- /#menu -->
                        <div role="tabpanel" class="tab-pane fade" id="sucursal">
                            <div class="inner-tab-content">
                         
                                <section class="grey-box">
                                    <h3><img id="datalive-logo" src="images/logo.png" width="60px" /> Horarios</h3>
                                    <div id="schedule">

                                    </div> <!-- /#schedule -->
                                </section>
                                <section class="grey-box">
                                    <h3>Ubicación y zona de entrega</h3>
                                    <h5 id="address"></h5>
                                    <div id="map_placeholder">
                                    </div>
                                </section>
                            </div>
                        </div> <!-- /#sucursal -->
                    </div>
                </div>
            </div><!-- /.main-content -->
            <div class="pedido-content col-xs-12 col-md-4 col-lg-3">
                <div id="pedidoHeader">
                    <button class="btn btn-default button_new"><span class="glyphicon glyphicon-chevron-left"></span> Volver al men&uacute;</button>
                </div>
                <div class="grey-box sombraBox">
                    <span id="vaciarPedido" class="glyphicon glyphicon-trash" title="Vaciar pedido"></span>
                    <h4 id="pedidoTop"><b>Mi pedido</b></h4>
                    <div id="pedidoVacio">
                        <span class="glyphicon glyphicon-shopping-cart"></span><br />
                        Todavía no has pedido nada.
                    </div>
                    <div id="pedido">
                        <!-- items pedidos -->
                    </div>
                    <div id="subtotal">
                        <!-- subtotal -->
                    </div>
                    <div>
                        <div class="alert alert-danger" id="alertPedidoError" style="display: none;"></div>
                        <div class="alert alert-danger" id="alertPedidoMinimo" style="display: none;">El mínimo por pedido es <span class="pedido-minimo"></span></div>
                        <button id="revisarPedido" class="btn_new btn-primary width_100">Finalizar Pedido</button>
                        <!--<button id="realizarPedido" class="btn btn-primary button_new">Realizar Pedido</button>-->
                    </div>
                </div>
            </div><!-- /.pedido-content -->
            <div id="mostrarPedido" class="grey-box">
                <button class="btn_new btn-primary button_new width_100">Ver pedido <span class="ver-pedido-total">($0)</span></button>
            </div>
        </div>
         <input type="hidden" id="versionTPhd" value="1.00">
    
    </div><!-- /.container -->
    <footer class="site-footer">
        <!-- Company Footer -->
        <div class="footer-company center">
            <div class="container">
                <img height="40" src="images/logo.png"><a target="_blank"</a> 
            </div>
        </div>
    </footer>

    <div id="pedidoDialog" class="modal fade" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content modal_new">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title  center text-grey"></h4>
                    <p class="subtitle"></p>
                </div>
                <div class="modal-body">
                </div>
                <div class="modal-footer">
                    <div class="add-remove">
                        <span>Cantidad:</span>
                        <span><span class="cantidad">1</span>x</span>
                        <span class="add-remove-controls"><span class="glyphicon glyphicon-plus"></span><span class="glyphicon glyphicon-minus"></span></span>
                    </div>
                    <button id="dialogAddButton" type="button" class="btn_new btn-primary button_new"><b>Agregar</b> (<span class="dialog-total"></span>)</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
    <!-- este template es para el dialogo de promociones que indican grupos de productos -->
    <script id="option_dialog_promo_grupos_template" type="text/x-jsrender">
        <section class="products-container" data-promo-id="{{:id}}" data-promo-grupo-producto-id="{{:promoGrupoProdId}}" data-is-ok="{{:isOk}}">
            <h5>{{:titulo}} <small class="option-quantity">{{if cantidad > 0}}Elegí {{:cantidad}}{{/if}}</small></h5>
            <ul>
               {{for grupos ~inputName=nombre ~cantidad=cantidad ~parentId=id ~promoGrupoId=promoGrupoProdId}}

                <li>
                    <h6>{{:titulo}}</h6>
                    <ul class="group">
                        {{for productos ~grupoId=id ~grupoIndex=#index}}
                        <li>
                            {{if ~cantidad == 1}}
                            <label for="{{:~inputName}}_{{:~grupoIndex}}_{{:#getIndex()}}">
                                <input id="{{:~inputName}}_{{:~grupoIndex}}_{{:#getIndex()}}" data-producto-id="{{:id}}" data-grupo-producto-id="{{:~grupoId}}" data-promo-grupo-producto-id="{{:~promoGrupoId}}" data-promo-id="{{:~parentId}}" type="radio" name="{{:~inputName}}" />
                                {{:nombre}}{{if precio}}<small> ($ {{:precio}})</small>{{/if}}
                            </label>
                            {{else}}
                            <select class="listbox_new" data-producto-id="{{:id}}" data-grupo-producto-id="{{:~grupoId}}" data-promo-grupo-producto-id="{{:~promoGrupoId}}" data-promo-id="{{:~parentId}}">
                                {{for cantidadLoop}}
                                <option value="{{:#index}}">{{:#index}}</option>
                                {{/for}}
                            </select>
                            <span>{{:nombre}}{{if precio}}<small> ($ {{:precio}})</small>{{/if}}</span>
                            {{/if}}
                        </li>
                        {{/for}}
                    </ul>
                </li>
                {{/for}}
            </ul>
        </section>
    </script>

    <!-- este template es para el dialogo de promociones que indican productos -->
    <script id="option_dialog_promo_template" type="text/x-jsrender">
        <section class="products-container" data-promo-id="{{:id}}" data-promo-grupo-producto-id="{{:promoGrupoProdId}}" data-is-ok="{{:isOk}}">
            <h5>{{:titulo}} <small class="option-quantity">{{if cantidad > 0}}Elegí {{:cantidad}}{{/if}}</small></h5>
            <ul class="{{if !hasOptions}}group{{/if}}">
                
                {{for productos ~inputName=nombre ~cantidad=cantidad ~parentId=id ~promoGrupoId=promoGrupoProdId }}
                <li>
                  
                        {{if ~cantidad == 1}}
                            <label for="{{:~inputName}}{{:#getIndex()}}">
                                <input id="{{:~inputName}}{{:#getIndex()}}" data-producto-id="{{:id}}" data-promo-id="{{:~parentId}}" data-promo-grupo-producto-id="{{:~promoGrupoId}}" type="radio" name="{{:~inputName}}" />
                                {{:nombre}}{{if precio > 0}}<small>$ {{:precio}}</small>{{/if}}
                            </label>
                            
                               {{for options ~productoId=id}}
                               {{if id == 1}}
                                    <ul class="group">
                                        {{for opciones ~modificadorId=id}}
                                        <li>
                                            <label for="{{:~inputName}}{{:~productoId}}">
                                                <input id="{{:~inputName}}{{:~productoId}}" data-opcion-id="{{:id}}" data-modificador-id="{{:~modificadorId}}" data-producto-id="{{:~productoId}}" data-promo-id="{{:~parentId}}" data-promo-grupo-producto-id="{{:~promoGrupoId}}" type="{{if ~cantidad == 1}}radio{{else}}radio{{/if}}" checked   name="{{:~inputName}}{{:~productoId}}" />
                                                {{:nombre}}{{if precio > 0}}<small>$ {{:precio}}</small>{{/if}}
                                            </label>
                                        </li>
                                        {{/for}}
                                    </ul>
                                 {{/if}}
                                {{/for}}
                         {{else}}
                            <select class="listbox_new" data-producto-id="{{:id}}" data-promo-id="{{:~parentId}}" data-promo-grupo-producto-id="{{:~promoGrupoId}}">
                                {{for cantidadLoop}}
                                <option value="{{:#index}}">{{:#index}}</option>
                                {{/for}}
                            </select>
                            <span>{{:nombre}}{{if precio > 0}}<small>$ {{:precio}}</small>{{/if}}</span>
                            
                             {{for options ~productoId=id}}
                               {{if id == 1}}
                                   <ul class="group">
                                      {{for opciones ~modificadorId=id}}
                                      <li>
                                          <label for="{{:~inputName}}{{:~productoId}}">
                                              <input id="{{:~inputName}}{{:~productoId}}" data-opcion-id="{{:id}}" data-modificador-id="{{:~modificadorId}}" data-producto-id="{{:~productoId}}" data-promo-id="{{:~parentId}}" data-promo-grupo-producto-id="{{:~promoGrupoId}}" type="{{if ~cantidad == 1}}radio{{else}}radio{{/if}}" checked  name="{{:~inputName}}{{:~productoId}}" />
                                              {{:nombre}}{{if precio > 0}}<small>$ {{:precio}}</small>{{/if}}
                                          </label>
                                      </li>
                                      {{/for}}
                                  </ul>
                                {{/if}}  
                            {{/for}}
                        {{/if}}
                   
                </li>
                {{/for}}
            </ul>
        </section>
    </script>

    <!-- este template es para el dialogo de productos con modificadores -->
    <script id="option_dialog_template" type="text/x-jsrender">
        <section class="option-container{{if cantidad == opciones.length}} optional-container{{/if}}" data-modificador-id="{{:id}}" data-is-ok="{{:isOk}}">
            <h5>{{:titulo}} <small class="option-quantity">{{if cantidad < opciones.length}}Elegí {{:cantidad}}{{else}}<span class="dim">(opcional)</span>{{/if}}</small></h5>
            <ul>
                {{for opciones ~inputName=nombre ~cantidad=cantidad ~parentId=id}}
                <li>
                    <label for="{{:~inputName}}{{:#index}}">
                        <input id="{{:~inputName}}{{:#index}}" data-opcion-id="{{:id}}" data-modificador-id="{{:~parentId}}" type="{{if ~cantidad == 1}}radio{{else}}checkbox{{/if}}" name="{{:~inputName}}" />
                        {{:nombre}}{{if precio > 0}}<small>$ {{:precio}}</small>{{/if}}
                    </label>
                </li>
                {{/for}}
            </ul>
        </section>
    </script>

    <script id="schedule_template" type="text/x-jsrender">
        <ul class="schedule">
            
            {{for horarios}}
            <li class="{{if active}}active{{/if}}">
                <div class="date">{{:nombre}}</div>
                <div class="times">
                    {{for horario}}
                    <div class="time"><span>{{:desde}}</span> - <span>{{:hasta}}</span></div>
                    {{else}}
                    <div class="time">Cerrado</div>
                    {{/for}}
                </div>
            </li>
            {{/for}}
        </ul>
    </script>

   <script id="subtotal_template" type="text/x-jsrender">
        <div class="item">
            <div class="sub-total item-right">${{:subTotal}}</div>
            Sub-Total
        </div>
        <div class="item">
            {{if costoDelivery}}
            <div class="item-right">${{:delivery}}</div>
            {{/if}}
            {{:direccionDelivery}}
            <br>
            {{:pisoDto}}
        </div>
        <div class="item">
            <span class="glyphicon glyphicon-time" aria-hidden="true"></span> Entrega
            <div id="selectedTime">
                <span>Lo antes posible</span> <a style="color: white;" id="cambiarLink" href="#">(Cambiar)</a>
            </div>
            <div id="deliveryTimeDiv" style="display: none;">
                <select class="form-control" id="deliveryTime">
                </select>
            </div>
        </div>
        <div class="item">
            <div class="item-right precio">${{:total}}</div>
            <b>Total</b>
        </div>
        <textarea class="form-control" id="comentarios" name="comentarios" placeholder="Comentarios (opcional)..."></textarea>
    </script>

        <!-- este template es para productos y promos -->
    <script id="grupoProductosTemplate" type="text/x-jsrender">
        <section>
            <div class="menu-header">
                <div class="col-xs-12">
                    <h3>{{:nombre}}</h3>
                    {{if imagen}}
                    <img src="{{:imagen}}" />
                    {{/if}}
                </div>
                {{if warning}}
                <div class="col-xs-12">
                    <div class="alert alert-warning" role="alert">{{:warning}}</div>
                </div>
                {{/if}}
            </div>
            <div class="productos">
                {{for productos ~disabled=disabled}}
                <div class="col-xs-12 col-sm-6 col-lg-4">
                    <div class="F {{:~disabled}}" data-disabled="{{:~disabled}}" data-id-producto="{{:id}}" data-id-promo="{{:id_promo}}" data-id-grupo-promo="{{:id_grupo_promo}}" data-id-grupo-producto="{{:id_grupo_prod}}" data-precio-mostrado="{{:precio.calculado}}">
                        <div class="precio-producto">
                            <span>${{:precio.calculado}}</span>
                            {{if precio.calculado < precio.original}}
                            <br />
                            <span class="precio-original">${{:precio.original}}</span>&nbsp;
                            {{/if}}
                        </div>
                        <h4 class="nombre-producto">
                            {{:nombre}}
                        </h4>
                        <div class="agregar-producto"><b class="far fa-plus-square" title="Agregar a mi pedido"></b></div>
                        {{if descripcion}}
                        <p class="descripcion-producto">{{:descripcion}}</p>
                        {{/if}}
                    </div>
                </div>
                {{/for}}
            </div>
        </section>
    </script>
     
    <script  src="https://code.jquery.com/jquery-3.4.1.min.js"  integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="  crossorigin="anonymous"></script>
    
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jsrender/0.9.80/jsrender.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <script src="js/bootstrap-notify.js"></script>
<%--       <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>--%>
 <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.4.1/jspdf.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/2.3.5/jspdf.plugin.autotable.min.js"></script>
    <script src="js/jquery.totop.js"></script>
  
      <script src="js/jquery.dataTables.js" type="text/javascript"></script>
    <script src="js/dataTables.bootstrap.js"></script>
     <script src="JavaScript.js" type="text/javascript"></script>
    <a id="back-to-top" href="#" class="btn btn-warning btn-lg back-to-top" 
      role="button" title="Subir" data-toggle="tooltip" data-placement="top">
      <span class="glyphicon glyphicon-menu-up" aria-hidden="true"></span>
    </a>

</body>

<div id="totopscroller">
</div>

</html>

<script>

    $(function () {
        $('#totopscroller').totopscroller({
            showToBottom: true,
            showToPrev: true,
            link: false,
            linkTarget: '_self',
            toTopHtml: '<a href="#"></a>',
            toBottomHtml: '<a href="#"></a>',
            toPrevHtml: '<a href="#"></a>',
            linkHtml: '<a href="#"></a>',
            toTopClass: 'totopscroller-top',
            toBottomClass: 'totopscroller-bottom',
            toPrevClass: 'totopscroller-prev',
            linkClass: 'totopscroller-lnk',
        });
    })

    $(window).on("scroll", function () {
        if ($(this).scrollTop() > 100) {
            $("#nav_header").addClass("header_fijo");
            $("#nav_header").removeClass("top_bar_navbar");
            $("#div_image_pedido").addClass("header_imagen");
            $(".div_titulo_pedido").addClass("header_titulo");
            $(".div_dir_cliente").addClass("header_hide");
            $(".dir_entrega").addClass("header_hide");
            $(".div_distancia").addClass("header_hide");
            $(".div_pedido_minimo").addClass("header_hide");
            $(".div_tiempo_entrega").addClass("header_hide");
            $("#main_div_seleccion").addClass("main_margin");
            $("#div_conectado").addClass("navbar_collapse");
            $("#div_conectado").removeClass("navbar_not_collapse");
            $("#div_desconectado").addClass("navbar_collapse_desconectado");
            $("#user_name").hide();
            $("#grad_1").hide();
        }
        else {
            $("#nav_header").addClass("top_bar_navbar");
            $("#nav_header").removeClass("header_fijo");
            $("#div_image_pedido").removeClass("header_imagen");
            $(".div_titulo_pedido").removeClass("header_titulo");
            $(".div_dir_cliente").removeClass("header_hide");
            $(".dir_entrega").removeClass("header_hide");
            $(".div_distancia").removeClass("header_hide");
            $(".div_pedido_minimo").removeClass("header_hide");
            $(".div_tiempo_entrega").removeClass("header_hide");
            $("#main_div_seleccion").removeClass("main_margin");
            $("#div_conectado").removeClass("navbar_collapse");
            $("#div_conectado").addClass("navbar_not_collapse");
            $("#div_desconectado").removeClass("navbar_collapse_desconectado");
            $("#user_name").show();
            $("#grad_1").show();
        }
    });

</script>

<!-- INI Modal Revisar Pedido -->
  <div class="modal fade" id="ModalRevisar" role="dialog" style="font-family: Arimo, serif;">
    <div class="modal-dialog">
      <div class="modal-content modal_new">
<!--        <div class="modal-header">
          <h4 class="modal-title center text-grey">Revisar pedido</h4>
        </div>-->
        <div id="ModalRevisarBody" class="modal-body">

			<div class="row" style="margin-top: -15px; height: 120px;">
				<div class="col-12">
				    <div class="top_bar_navbar center" style="font-size: 28px; color: white; height: 120px;">
				        <div style="z-index: 18; position: relative; padding-top: 7%;">Último paso! Revisá y confirmá tu pedido.</div>
				        <div class="gradient_2" style="height: 120px;"></div>
				    </div>
				</div>
			</div>
			
        	<div style="margin: 10px;">
        	    <div><span class="glyphicon glyphicon-home" aria-hidden="true"></span> Dirección de entrega <b id="dir_entrega_conf"></b></div>
                <div><span class="glyphicon glyphicon-time" aria-hidden="true"></span> Hora de entrega <b id="dir_hora_conf">Lo antes posible</b></div>
            </div>
					
	        <div class="row" style="margin-top: 10px;">
	            <div class="col-12">
	                <div class="card">
	                    <div class="card-header" data-background-color="purple">
	                        <h4 class="title text-center">Detalle del pedido</h4>
	                        <p class="category"></p>
	                    </div>
	                    <div class="card-content table-responsive">
	                        <table class="table">
	                            <thead class="text-default">
	                                <tr>
                                        <th class="text-center">Cantidad</th>
                                        <th class="text-left">Producto</th>
                                        <th class="text-center">Tipo comida</th>
                                        <th class="text-center">Precio</th>
                                    </tr>
	                            </thead>
	                            <tbody id="TablaModalRevisar">
	                            </tbody>
	                        </table>
	                    </div>
	                </div>
	            </div>
	        </div>
	        
	        <div class="well center">
	            <div id="resumenCostoDelivery"></div>
	            <h3 style="margin: -10px;">Costo total $<span id="ModalRevisarTotal"></span></h3>
        	</div>

        	<div class="well center" style="padding: 10px;">
        	    <div><label>Indique con cuanto paga</label> <input type="number" min="0" step="any" style="width: 100px; display: inline-block;" class="form-control" id="ModalRevisarPagaCon" placeholder="$0.00"></div>
                <p id="PagaConMsj" class="center" style="color: red;"></p>
            </div>
            
            <div class="well center" style="padding: 10px;">
        	    <div><label>Indique las Entre Calles</label> <input type="text"  style="width: 50%; display: inline-block;" class="form-control" id="ModalRevisarEntreCalle" placeholder="Solar y Juncal"></div>
                <p id="EntreCalleMsj" class="center" style="color: red;"></p>
            </div>
            
	        <div class="center" id="comentarios_div">
	            Comentarios: <b id="comentarios_conf"></b>
	        </div>
	        
        	<div class="well center" style="padding: 10px;">
        	    <div><label>Número de teléfono</label> <input value="" type="number" min="0" style="width: 50%; display: inline-block;" class="form-control" id="ModalRevisarTel" placeholder="(Sin espacios ni guiones)"></div>
                <p id="NumTelMsj" class="center" style="color: red;"></p>
            </div>
          
            <div class="row text-center">
                <div class="col-xs-12 col-md-6 col-lg-6">
                    <button type="button" class="btn_new btn-primary" id="confirmarPedido">Confirmar pedido</button>
                </div>
	            <div class="col-xs-12 col-md-6 col-lg-6">
	                <button type="button" class="btn_new btn-default" data-dismiss="modal" id="cancelarPedido">Cancelar</button>
	            </div>
	        </div>
          
        </div>
        
        <div id="ModalRevisarMsj" class="modal-body"></div>
        
      </div>
    </div>
  </div>
<!-- FIN Modal Revisar Pedido -->


<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.7.0/animate.css">




<!-- INI Modal VER PEDIDOS -->
  <div class="modal fade" id="ModalPedidos" role="dialog">
    <div class="modal-dialog modal-lg">
      <div class="modal-content modal_new">
        <div class="modal-header">
          <h4 class="modal-title center text-grey">PEDIDOS</h4>
        </div>
        <div class="modal-body">
            
          <form class="form-horizontal" role="form" action="#">

            
          </form>
            
          <div id="TextModalPedidos"></div>
        </div>
        <div class="modal-footer center">
          <button type="button" class="btn btn-primary button_new width_100" data-dismiss="modal">Salir</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal VER PEDIDOS -->


<!-- INI Modal VER PERFIL -->
  <div class="modal fade" id="ModalPerfil" role="dialog">
    <div class="modal-dialog">
      <div class="modal-content modal_new">
        <div class="modal-header">
          <h4 class="modal-title center text-grey">Perfil  </h4>
        </div>
        <div class="modal-body">
            
          <form class="form-horizontal" role="form" action="#">

            
          </form>
            
          <div id="TextModalPerfil"></div>
        </div>
        <div class="modal-footer center">
          <button type="button" class="btn btn-primary button_new width_100" data-dismiss="modal">Salir</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal VER PERFIL -->

<!-- INI Modal CONFIRM -->
  <div class="modal fade" id="ModalConfirm" role="dialog">
    <div class="modal-dialog modal-sm">
      <div class="modal-content modal_new">
        <div class="modal-header">
          <h4 class="modal-title center text-grey">Confirmación</h4>
        </div>
        <div class="modal-body">
          <div id="TextModalConfirm" class="text-center"></div>
        </div>
        <div class="modal-footer center">
          <button type="button" class="btn btn-danger button_new" onclick="fcn_cerrar_sesion();">Confirmar</button>
          <button type="button" class="btn button_new" data-dismiss="modal">Cancelar</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal VER PERFIL -->

<!-- INI Modal CONFIRM -->
  <div class="modal fade" id="ModalAlerta" role="dialog">
    <div class="modal-dialog modal-sm">
      <div class="modal-content modal_new">
        <div class="modal-header">
          <h4 class="modal-title center text-grey">Mensaje</h4>
        </div>
        <div class="modal-body">
          <div id="TextModalAlerta" class="text-center"></div>
        </div>
        <div class="modal-footer center">
          <button type="button" class="btn btn-primary button_new" onclick="fcn_modal_close('ModalAlerta');">Aceptar</button>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal VER PERFIL -->

<!-- INI Modal Recovery Pass -->
  <div class="modal fade" id="ModalRecovery" role="dialog">
    <div class="modal-dialog modal-sm">
      <form class="form-horizontal" role="form" action="#">
      <div class="modal-content modal_new">
        <div class="modal-header">
          <h4 class="modal-title center text-grey">Olvidaste tu contraseña?</h4>
        </div>
        <div class="modal-body">

            <div class="form-group">
              <div class="col-sm-12">
                <div class="center text-grey">Ingresá tu e-mail y te enviaremos un link para recuperarla</div>
              </div>
            </div>
            
            <div class="form-group">
              <div class="col-sm-12">
                <input id="reco_mail" type="text" class="form-control textbox_new width_100" placeholder="E-mail"> </div>
            </div>
   
						<div style="width: 260px" class="g-recaptcha2" data-sitekey="6LfQaiYUAAAAANDblY5M_t3cV9DNeriWIaFAdM5i"></div>
            
          <div class="center" id="TextModalRecovery"></div>
        </div>
        <div class="modal-footer center">
          <button type="button" id="btn_recovery" class="btn btn-success button_new width_100">Enviar</button>
          <p><div style="margin-top: 10px; font-size: 12px;" class="center"><span class="text-grey">Ya la recordaste?</span> <a data-dismiss="modal" href="#" id="btn_ini_sesion3" onclick="fcn_add_modalclass_body();">Ingresa!</a></div></p>
        </div>
      </div>
      </form>
    </div>
  </div>
<!-- FIN Modal Recovery Pass -->
