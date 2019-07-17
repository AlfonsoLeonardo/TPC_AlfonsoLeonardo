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
    <link rel="stylesheet" href="Content/bootstrap-theme.css">
    <link rel="stylesheet" href="Content/Site.css">
    
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700,300|Material+Icons" rel="stylesheet" type="text/css">
    
    <link rel="stylesheet" href="Content/scrollToTop/totop.css">
  </head>  
<style>

@media only screen and (min-width: 769px) {
    
    .top_bar_navbar{
        border: solid 0px;
        background-repeat: no-repeat;
        background-size: cover;
        height: 150px;
        background-image: url('Content/imagenes/fondoPortadaNegro.jpg');
    }


}

@media only screen and (max-width: 768px) {

    .top_bar_navbar{
        border: solid 0px;
        background-repeat: no-repeat;
        background-image: url('content/imagenes/fondoPortadaNegro.jpg');
    }

}

.back-to-top {
cursor: pointer;
position: fixed;
bottom: 0;
right: 20px;
display:none;
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
                    
                    <img src="content/imagenes/mgHeadEmpanadas.jpg">
                    
                </div>
                
            </div>
             <% cargar(5, 9999); %>
            <div class="productos">
                
             
                 <% foreach (var comidas in comidas) { %>
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
                    
                   <img src="content/images/Pizzas.jpg">
                    
                </div>
                
            </div>
            <div class="productos">
                 <% cargar(2, 3); %>
                 <% foreach (var comidas in comidas) { %>
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

    <script
  src="https://code.jquery.com/jquery-3.4.1.min.js"
  integrity="sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="
  crossorigin="anonymous"></script>
 <script src="https://cdnjs.cloudflare.com/ajax/libs/jsrender/0.9.80/jsrender.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <%--<script src="Scripts/layout.js"></script>--%>
    <script src="../../user/assets/js/bootstrap-notify.js"></script>
    <script src="../../user/assets/js/tepido.js"></script>
<%-- <script src="Scripts/sucursal.js"></script>--%>
    <script src="../../content/scrollToTop/jquery.totop.js"></script>
    <script src="JavaScript.js"></script>
    <!--Acá estoy usando mi API_KEY de desarrollo. Vos deberías usar tu propia API_KEY.
        Ver https://developers.google.com/maps/faq?hl=es#keysystem
            https://developers.google.com/maps/documentation/javascript/get-api-key?hl=es#key -->
    <%--<script        async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDE9UILj0YokjZpfRiH6a0al4CWDDeKNBc&signed_in=true&callback=googleInitMapCallback"></script>--%>

    <a id="back-to-top" href="#" class="btn btn-warning btn-lg back-to-top" 
      role="button" title="Subir" data-toggle="tooltip" data-placement="top">
      <span class="glyphicon glyphicon-menu-up" aria-hidden="true"></span>
    </a>

</body>

<div id="totopscroller">
</div>

</html>

<script>

$(function(){
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


<!-- INI Modal INICIAR SESION -->
  <div class="modal fade" id="ModalLogin" role="dialog">
    <div class="modal-dialog modal-sm">
      <div class="modal-content modal_new">
        <div class="modal-header">
          <div id="ModalLoginMsj"></div>
          <h4 class="modal-title center text-grey">INGRESÁ A TU CUENTA</h4>
        </div>
        <div class="modal-body">
            
          <form class="form-horizontal" role="form" action="#">
          
            <div class="form-group">
              <div class="col-sm-12">
                <div style="display: none;" class="btn button_new width_100 btn_fb"><span >Continuar con <b>Facebook</b></span></div>
                <div class="btn button_new width_100 btn_gplus"><span >Continuar con <b>Google</b></span></div>
              </div>
            </div>

            <div class="form-group">
              <div class="col-sm-12">
                <div class="center text-grey">O ingresa tu e-mail</div>
              </div>
            </div>
            
            <div class="form-group">
              <div class="col-sm-12">
                <input id="is_mail" type="text" class="form-control textbox_new width_100" placeholder="E-mail">
              </div>
            </div>

            <div class="form-group">
              <div class="col-sm-12">
                <input id="is_pwd" type="password" class="form-control textbox_new width_100" placeholder="Contraseña">
             		<p><div style="margin-top: 10px; font-size: 12px;" class="center"><span class="text-grey">Olvidaste tu contraseña?</span> <a data-dismiss="modal" href="#" id="btn_recovery_pass" >Recuperala!</a></div></p>
							</div>
            </div>
            
          </form>
            
          <div class="center" id="TextModalLogin"></div>
        </div>
        <div class="modal-footer center">
          <button type="button" id="btn_login" class="btn btn-success button_new width_100">Ingresar</button>
          <p><div style="margin-top: 10px; font-size: 12px;" class="center"><span class="text-grey">No tenes cuenta?</span> <a data-dismiss="modal" href="#" class="registrarse" onclick="fcn_add_modalclass_body();">Registrate!</a></div></p>
        </div>
      </div>
    </div>
  </div>
<!-- FIN Modal INICIAR SESION -->


<!-- INI Modal REGISTER -->
  <div class="modal fade" id="ModalRegister" role="dialog">
    <div class="modal-dialog modal-sm">
      <div class="modal-content modal_new">
        
        <div id="registerFields">
        
        <div class="modal-header">
          <h4 class="modal-title center text-grey">REGISTRATE GRATIS</h4>
        </div>
        <div class="modal-body">
            
          <form class="form-horizontal" role="form" action="#">
          
            <div class="form-group">
              <div class="col-sm-12">
                <div style="display: none;" class="btn button_new width_100 btn_fb"><span >Continuar con <b>Facebook</b></span></div>
                <div class="btn button_new width_100 btn_gplus"><span >Continuar con <b>Google</b></span></div>
              </div>
            </div>

            <div class="form-group">
              <div class="col-sm-12">
                <div class="center text-grey">O registrate con tu e-mail</div>
              </div>
            </div>
            
            <div class="form-group">
              <div class="col-sm-12">
                <input id="reg_nombre" type="text" class="form-control textbox_new width_100" placeholder="Nombre">
              </div>
            </div>

            <div class="form-group">
              <div class="col-sm-12">
                <input id="reg_apellido" type="text" class="form-control textbox_new width_100" placeholder="Apellido (Opcional)">
              </div>
            </div>

            <div class="form-group">
              <div class="col-sm-12">
                <input id="reg_mail" type="mail" class="form-control textbox_new width_100" placeholder="E-mail">
              </div>
            </div>

            <div class="form-group">
              <div class="col-sm-12">
                <input id="reg_pwd" type="password" class="form-control textbox_new width_100" placeholder="Contraseña">
              </div>
            </div>
						
						  <div class="form-group">
              <div class="col-sm-12">
                <input id="reg_pwd2" type="password" class="form-control textbox_new width_100" placeholder="Repetir Contraseña">
              </div>
            </div>
            
            <div style="width: 260px" class="g-recaptcha" data-sitekey="6LfQaiYUAAAAANDblY5M_t3cV9DNeriWIaFAdM5i"></div>
            
          </form>
            
          <div class="center" id="TextModalRegister"></div>
        </div>
        <div class="modal-footer center">
          <button id="btn_conf_register" type="button" class="btn btn-success button_new width_100">Confirmar datos</button>
          <p><div style="margin-top: 10px; font-size: 12px;" class="center"><span class="text-grey">Ya tenes cuenta?</span> <a data-dismiss="modal" href="#" id="btn_ini_sesion2" onclick="fcn_add_modalclass_body();">Ingresar!</a></div></p>
        </div>
      
      </div>
      
      <div class="modal-body center" id="registerOK"></div>
        
      </div>
        
    </div>
  </div>
<!-- FIN Modal REGISTER -->


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

<%--<script>

// Funcion que indica al BODY que hay un MODAL abierto
function fcn_add_modalclass_body(){
	
	setTimeout(function(){ $("body").addClass("modal-open"); }, 500);
	
} // fcn_add_modalclass_body

$("#btn_recovery").click(function(){
    
    $("#btn_recovery").html('Enviar');
    
    $("#reco_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#TextModalRecovery").html('');
    
    // Valido los campos de la pantalla
    var v_error = '';
    
    if($("#reco_mail").val() == ''){
      $("#reco_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
  
    
    if(v_error != ''){
        $("#TextModalRecovery").html('<span style="color:#e7423a;">Complete todos los campos obligatorios.</span>');
        return;
    }
	
		if (!validateEmail($("#reco_mail").val())) 
		{
     $("#TextModalRecovery").html('<span style="color:#e7423a;">Ingrese un email valido.</span>');
        return;
    }
    /*if($("#g-recaptcha2-response").val() == ''){
      $("#TextModalRecovery").html('<span style="color:#e7423a;">Por favor valide el captcha.</span>');
      return;
    }*/
    
    $("#btn_recovery").html('<center><img style="height: 20px; width: 20px;" src="https://www.tepido.com.ar/content/spin_loader.gif"></center>');
    
  	$.ajax({
  	        url: "../pass_recovery.php",  // Url a llamar
  	        type: "POST",             					 // Metodo de llamada
  	        data: { 
              reco_mail : $("#reco_mail").val(),
             			}, // Datos a enviar
  	        dataType: "json", 									 // Tipo de datos a devolver (JSON)
  	        success: function (data) {
  	          
  	          // Si no da error, sigo con el proceso
  	          if(data[0] == 'OK'){
  	             $("#btn_recovery").html('Enviar nuevamente');
  							 $("#TextModalRecovery").html('<span class="text-success">'+data[1]+'</span>');
							}else{
  	            $("#btn_recovery").html('Enviar nuevamente');
  	            $("#TextModalRecovery").html('<span style="color:#e7423a;">'+data[1]+'</span>');

  	          }
  	          
  	        }
  	              
  	}).fail(function(){
    	
    });
    
});
	
$("#btn_login").click(function(){
    
    $("#btn_login").html('Ingresar');
    
    $("#is_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
	  $("#is_pwd").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#TextModalLogin").html('');
    
    // Valido los campos de la pantalla
    var v_error = '';
    
    if($("#is_mail").val() == ''){
      $("#is_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
	
	  if($("#is_pwd").val() == ''){
      $("#is_pwd").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
  
    
    if(v_error != ''){
        $("#TextModalRecovery").html('<span style="color:#e7423a;">Complete todos los campos obligatorios.</span>');
        return;
    }
	
		if (!validateEmail($("#is_mail").val())) 
		{
     $("#TextModalLogin").html('<span style="color:#e7423a;">Ingrese un email valido.</span>');
        return;
    }
   
    $("#btn_login").html('<center><img style="height: 20px; width: 20px;" src="https://www.tepido.com.ar/content/spin_loader.gif"></center>');

  	$.ajax({
  	        url: "../login_action.php",  // Url a llamar
  	        type: "POST",             					 // Metodo de llamada
  	        data: { 
              	mail : $("#is_mail").val(),
							  pass : $("#is_pwd").val()
             			}, // Datos a enviar
  	        dataType: "json", 									 // Tipo de datos a devolver (JSON)
  	        success: function (data) {
  	          
  	          // Si no da error, sigo con el proceso
  	          if(data[0] == 'OK'){
  							
									window.location.reload(true);
                
                  localStorage.setItem('TPoauth_uid', data['oauth_uid']);
  				
							}else{
  	            
  	            $("#btn_login").html('Ingresar');
  	            $("#TextModalLogin").html('<span style="color:#e7423a;">'+data[1]+'</span>');

  	          }
  	          
  	        }
  	              
  	}).fail(function(){
    	
    });
    
});
	
	

$("#is_mail").on("keypress", function (e) {
  if (e.charCode == 13) {
    $("#btn_login").click();
  }
});

$("#is_pwd").on("keypress", function (e) {
  if (e.charCode == 13) {
    $("#btn_login").click();
  }
});

$("#reco_mail").on("keypress", function (e) {
  if (e.charCode == 13) {
    $("#btn_recovery").click();
  }
});


$("#btn_recovery_pass").click(function(){
    v_modal_open = 'ModalRecovery';
    $("#TextModalRecovery").html('');
    $("#reco_mail").val('');
    $("#btn_recovery").html('Enviar');
    $('#ModalRecovery').modal();
});
	
	
	
$("#btn_ini_sesion").click(function(){
    // Abro el modal para iniciar sesión
    //$('#ModalLogin').modal({backdrop: 'static', keyboard: false});
    $("#ModalLoginMsj").hide();
    v_modal_open = 'ModalLogin';
    $("#btn_login").html('Ingresar');
    $('#ModalLogin').modal();
});

$("#btn_ini_sesion2").click(function(){
    // Abro el modal para iniciar sesión
    //$('#ModalLogin').modal({backdrop: 'static', keyboard: false});
    
    $("#ModalLoginMsj").hide();
  
    v_modal_open = 'ModalLogin';
    $("#btn_login").html('Ingresar');
    $('#ModalLogin').modal();
});
	
$("#btn_ini_sesion3").click(function(){
    $("#ModalLoginMsj").hide();
    v_modal_open = 'ModalLogin';
    $("#btn_login").html('Ingresar');
    $('#ModalLogin').modal();
});


$("#btn_ini_sesion_mobile").click(function(){
    $("#ModalLoginMsj").hide();
    v_modal_open = 'ModalLogin';
    $("#btn_login").html('Ingresar');
    $('#ModalLogin').modal();
});
	

$("#btn_ver_pedidos").click(function(){
    // Llamo al archivo para ver pedidos
    $('#ModalPedidos').modal();
});

$("#btn_ver_perfil").click(function(){
    $('#ModalPerfil').modal();
});

$(".btn_logout").click(function(){
    $('#TextModalConfirm').html('<b>Está seguro que desea cerrar sesión?</b>');
    $('#ModalConfirm').modal();
});

$(".registrarse").click(function(){
    
    $("#reg_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#reg_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#reg_pwd").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    
    $("#reg_nombre").val('');
    $("#reg_apellido").val('');
    $("#reg_mail").val('');
    $("#reg_pwd").val('');
    $("#reg_pwd2").val('');
    
    $("#TextModalRegister").html('');
    
    v_modal_open = 'ModalRegister';
    $("#btn_conf_register").html('Confirmar datos');
    
    $("#registerFields").show();
    $("#registerOK").hide();
    
    $('#ModalRegister').modal();
});

$("#btn_conf_register").click(function(){
    
    $("#btn_conf_register").html('Confirmar datos');
    
    $("#reg_nombre").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#reg_mail").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#reg_pwd").css({'border-color' : '#ccc', 'background-color' : '#fff'});
    $("#TextModalRegister").html('');
    
    // Valido los campos de la pantalla
    var v_error = '';
    
    if($("#reg_nombre").val() == ''){
      $("#reg_nombre").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
    
    if($("#reg_mail").val() == ''){
      $("#reg_mail").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
    
    if($("#reg_pwd").val() == ''){
      $("#reg_pwd").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
	
	 if($("#reg_pwd2").val() == ''){
      $("#reg_pwd2").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      v_error = 1;
    }
    
    if(v_error != ''){
        $("#TextModalRegister").html('<span style="color:#e7423a;">Complete todos los campos obligatorios.</span>');
        return;
    }
	
	 if($("#g-recaptcha-response").val() == ''){
      $("#TextModalRegister").html('<span style="color:#e7423a;">Por favor valide el captcha.</span>');
      return;
    }
	
		if (!validateEmail($("#reg_mail").val())) 
		{
     $("#TextModalRegister").html('<span style="color:#e7423a;">Ingrese un email valido.</span>');
        return;
    }
	
	 if($("#reg_pwd").val() != $("#reg_pwd2").val()){
     $("#reg_pwd").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
		 $("#reg_pwd2").css({'border-color' : '#f4686b', 'background-color' : '#fee9e7'});
      
		 $("#TextModalRegister").html('<span style="color:#e7423a;">Las contraseñas no coinciden.</span>');
        return;
    }
	
	var espacios = false;
	var cont = 0;

	while (!espacios && (cont < $('#reg_pwd').val().length)) {
		if ($('#reg_pwd').val().charAt(cont) == " ")
			espacios = true;
		cont++;
	}

	if (espacios)
	{
		 $("#TextModalRegister").html('<span style="color:#e7423a;">La contraseña no puede contener espacios en blanco.</span>');
     return;
	}

	
	 if($('#reg_pwd').val().length < 6){
  	 $("#TextModalRegister").html('<span style="color:#e7423a;">La contraseña debe contener mas de 6 caracteres y menos de 30.</span>');
     return;
    }
	
	 if($('#reg_pwd').val().length > 30){
    	$("#TextModalRegister").html('<span style="color:#e7423a;">La contraseña debe contener mas de 6 caracteres y menos de 30.</span>');
     return;;
    }
    
    $("#btn_conf_register").html('<center><img style="height: 20px; width: 20px;" src="https://www.tepido.com.ar/content/spin_loader.gif"></center>');
    
  	$.ajax({
  	        url: "../register_action.php",  // Url a llamar
  	        type: "POST",             					 // Metodo de llamada
  	        data: { 
              reg_nombre : $("#reg_nombre").val(),
              reg_apellido : $("#reg_apellido").val(),
              reg_mail : $("#reg_mail").val(),
              reg_pwd : $("#reg_pwd").val(),
							reg_pwd2 : $("#reg_pwd2").val(),
							IDEmpresa : '3'
  	        				
  	        			}, // Datos a enviar
  	        dataType: "json", 									 // Tipo de datos a devolver (JSON)
  	        success: function (data) {
  	          
  	          // Si no da error, sigo con el proceso
  	          if(data[0] == 'OK'){
  							  
                $("#registerFields").hide();
                
                var v_textOK =   '<i class="far fa-check-circle" style="font-size:  80px; background: -webkit-linear-gradient(#8BC34A, #4CAF50);'
                                +'      -webkit-background-clip: text;'
                                +'      -webkit-text-fill-color: transparent; margin: 8px;"></i><br>'
                
                                +'<div style="font-size: 20px;">Gracias por registrarte!</div><br>'
                
                                +'<div>Por favor, verificá tu E-mail para confirmar el correo que te enviamos a '+$("#reg_mail").val()+'</div><br>'
                                
                                +'<div style="color: #555; font-size: 11px; border: solid 1px #ffeb3b; border-radius: 3px; padding: 5px;"><i class="fas fa-exclamation-triangle" style="color: #f44336;"></i> Si el correo no se encuentra en la bandeja de entrada revise la carpeta de SPAM</div><br>'
                                
                                +'<button type="button" class="btn btn-primary" data-dismiss="modal">CONTINUAR</button>';
                
                $("#registerOK").html(v_textOK);
                
                $("#registerOK").show();
                
                $("#registerOK").addClass('animated bounceIn');
  							
  	          }else{
  	             $("#btn_conf_register").html('Confirmar datos');
  	             $("#TextModalRegister").html('<span style="color:#e7423a;">'+data[1]+'</span>');
  	          }
  	          
  	        }
  	              
  	}).fail(function(){
    	
    });
    
});

// Funcion para cerrar sesion
function fcn_cerrar_sesion(){

  firebase.auth().signOut().then(function() {
    // Sign-out successful.
  }, function(error) {
    // An error happened.
  });

  if("" == 'X'){
  		
  	window.location.replace('../desloguear.php');
  					  
  }else{

    $.ajax({
            url: "../desloguear.php",  // Url a llamar
            type: "POST",             					 // Metodo de llamada
            data: { 
                    tipo : 'AJAX'
                    
            			}, // Datos a enviar
            dataType: "json", 									 // Tipo de datos a devolver (JSON)
            success: function (data) {
              
              // Si no da error, sigo con el proceso
              if(data[0] == 'OK'){
    						
                localStorage.removeItem('TPoauth_uid');
                
    						fcn_header_admin('', '');
    						$("#ModalConfirm").modal('toggle');
    						
              }else{
                
                //alert(data[1]);
  
              }
              
            }
                  
    }).fail(function(){
    	
    });
  
  }
  
} // fcn_cerrar_sesion


// Funcion para cerrar modal
function fcn_modal_close(ModalID){
  
  $("#"+ModalID).modal('toggle');
  
  if(v_modal_open != ''){
    fcn_add_modalclass_body();
  }
  
} // fcn_modal_close


// Funcion que indica al BODY que hay un MODAL abierto
function fcn_add_modalclass_body(){
	
	setTimeout(function(){ $("body").addClass("modal-open"); }, 500);
	
} // fcn_add_modalclass_body

// Funcion para obtener localidades
function fcn_get_localidades(){
  
  
  
} // fcn_get_localidades

function validateEmail(email) {
  var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
  return re.test(email);
}
	
	
$(document).ready(function() {
  
  fcn_get_localidades();
  //$("#div_conectado").hide();
  
});

$(".btn_gplus").click(function() {
  
  var provider = new firebase.auth.GoogleAuthProvider();
  provider.addScope('profile');
  provider.addScope('email');
  
  fcn_iniciar_sesion(provider, 'G');

});

$(".btn_fb").click(function() {
  
  var provider = new firebase.auth.FacebookAuthProvider();
  provider.addScope('public_profile');
  fcn_iniciar_sesion(provider, 'FB');

});


// Funcion para iniciar sesion
function fcn_iniciar_sesion(provider, cod_prov){

  firebase.auth().signInWithPopup(provider).then(function(result) {
    
    // This gives you a Facebook Access Token.
    var token = result.credential.accessToken;
    // The signed-in user info.
    var user = result.user;
    
    var user_extend = result.additionalUserInfo.profile;
    
    localStorage.setItem('TPoauth_uid', user_extend['id']);
    
    // Ingreso el usuario en la base de datos, o actualizo los datos del mismo
    fcn_send2db(user_extend, result.additionalUserInfo.providerId, cod_prov);
    
    // Modifico cabecera de la web
    fcn_header_admin(user['displayName'], user['photoURL']);
    
    if(v_modal_open != ''){
      $("#"+v_modal_open).modal('toggle');
      v_modal_open = '';
    }
    
  }, function(error) {
    // The provider's account email, can be used in case of
    // auth/account-exists-with-different-credential to fetch the providers
    // linked to the email:
    var email = error.email;
    // The provider's credential:
    var credential = error.credential;
    // In case of auth/account-exists-with-different-credential error,
    // you can fetch the providers using this:
    if (error.code === 'auth/account-exists-with-different-credential') {
      firebase.auth().fetchProvidersForEmail(email).then(function(providers) {
        // The returned 'providers' is a list of the available providers
        // linked to the email address. Please refer to the guide for a more
        // complete explanation on how to recover from this error.
        
        $("#TextModalAlerta").html('Su email ya se encuentra registrado con otro proveedor. Por favor, inicie sesión con <b>'+providers+'</b>');
        $("#ModalAlerta").modal();
        
      });
    }else{
        $("#TextModalAlerta").html('Ocurrió un error al intentar iniciar sesión.');
        $("#ModalAlerta").modal();
    }
  });
    

  
} // fcn_iniciar_sesion


// Funcion que registra los datos en la base de datos
function fcn_send2db(userData, providerId, cod_prov){
  
  if(userData != ''){
    
    if(cod_prov == 'FB'){
      var email          = userData['email'];
      var gender         = userData['gender'];
      var locale         = userData['locale'];
      var birthday       = userData['birthday'];
      var link           = userData['link'];
      var oauth_provider = providerId;
      var oauth_uid      = userData['id'];
      var first_name     = userData['first_name'];
      var last_name      = userData['last_name'];
      var photoURL       = userData['picture']['data']['url'];
    }else if(cod_prov == 'G'){
      var email          = userData['email'];
      var gender         = userData['gender'];
      var locale         = userData['locale'];
      var birthday       = userData['birthday'];
      var link           = userData['link'];
      var oauth_provider = providerId;
      var oauth_uid      = userData['id'];
      var first_name     = userData['given_name'];
      var last_name      = userData['family_name'];
      var photoURL       = userData['picture'];
    }
    
  	$.ajax({
  	        url: "../UserUpdate.php",  // Url a llamar
  	        type: "POST",             					 // Metodo de llamada
  	        data: { 
  	                accion         : 'LOGIN',
                    email          : email,
                    gender         : gender,
                    locale         : locale,
                    birthday       : birthday,
                    link           : link,
                    oauth_provider : oauth_provider,
                    oauth_uid      : oauth_uid,
                    first_name     : first_name,
                    last_name      : last_name,
                    photoURL       : photoURL,
                    
  	        			}, // Datos a enviar
  	        dataType: "json", 									 // Tipo de datos a devolver (JSON)
  	        success: function (data) {
  	          
  	          // Si no da error, sigo con el proceso
  	          if(data[0] == 'OK'){
  							
  							//alert(data[1]);
  							
  	          }else{
  	            
  	            //alert(data[1]);

  	          }
  	          
  	        }
  	              
  	}).fail(function(){
    	
    });
    
  }
  
} // fcn_send2db


// Funcion para modificar el header con boton o con el usuario
function fcn_header_admin(Name, photoURL){
  
  if (Name != '') {
    // User is signed in.
    $('.div_img_user').css("background-image", "url("+photoURL+")");  
    $('#user_name').html(Name);  
    
    $("#div_desconectado").hide();
    $("#div_conectado").show();
    
    $(".div_desconectado_mobile").css({'display' : 'none'});
    $(".div_conectado_mobile").css({'display' : 'block'});
    
  } else {
    // No user is signed in.
    $("#div_desconectado").show();
    $("#div_conectado").hide();
    
    $('.div_img_user').css("background-image", "url('https://www.tepido.com.ar/content/imagenes/icon_user1.png')");  

    $(".div_desconectado_mobile").css({'display' : 'block'});
    $(".div_conectado_mobile").css({'display' : 'none'});
  }
  
} // fcn_header_admin

	
// Funcion para enlazar el usuario con el token de mensajes
function fcn_update_message_ID(v_uid){
	
	messaging.requestPermission()
	.then(function() {
		console.log('Notification permission granted.');
		// TODO(developer): Retrieve an Instance ID token for use with FCM.
		// ...	
		
		// Obtengo el token para enviarlo al servidor
		messaging.getToken()
		.then(function(Token) {
			console.log('Token obtenido: '+Token);
			// Send Instance ID token to app server.
			UPDATETokenToServer(Token, v_uid);
		})
		.catch(function(err) {
			console.log('Unable to retrieve token ', err);
		});
		
	})
	.catch(function(err) {
		console.log('Unable to get permission to notify.', err);
	});
	
} // fcn_update_message_ID


function UPDATETokenToServer(Token, v_uid){
	
	$.ajax({
	    url: "https://www.tepido.com.ar/saveMessageID.php",  // Url a llamar
	    type: "POST",             					 // Metodo de llamada
	    data: { senderID	: Token,
	            uid   		: v_uid,
							IDEmpresa : '3'
	          }, // Datos a enviar
	    dataType: "json", 									 // Tipo de datos a devolver (JSON)
	    success: function (data) {

	      // Si no da error, sigo con el proceso
	      if(data[0] == 'OK'){

	      }else{

	      }

	    }

	 }).fail(function(){

 	});
		
} // UPDATETokenToServer
	
</script>--%>

<script src='https://www.google.com/recaptcha/api.js'></script>
<script src="https://www.gstatic.com/firebasejs/4.1.3/firebase.js"></script>
<script src="https://apis.google.com/js/platform.js" async defer></script>
<%--<script>
  
  var v_bloquearFirebase = '';
  
  if( /iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)){
    v_bloquearFirebase = 'X';
    $(".btn_gplus").hide();
  }
  
  // Initialize Firebase
  var config = {
    apiKey: "AIzaSyB6m2nki28AvY8oqAwjBEqjaauh4H2UqGg",
    authDomain: "tepido-8e018.firebaseapp.com",
    databaseURL: "https://tepido-8e018.firebaseio.com",
    projectId: "tepido-8e018",
    storageBucket: "",
    messagingSenderId: "904120649958"
  };
  firebase.initializeApp(config);
  
	const messaging = firebase.messaging();
	
      firebase.auth().onAuthStateChanged(function(user) {
      fcn_header_admin(user['displayName'], user['photoURL']);
      
			fcn_update_message_ID(user['providerData'][0]['uid']);
      
      localStorage.setItem('TPoauth_uid', user['providerData'][0]['uid']);
			
      $.ajax({
              url: "../UserUpdate.php",  // Url a llamar
              type: "POST",             					 // Metodo de llamada
              data: { 
                      email          : user['email'],
                      oauth_provider : user['providerData'][0]['providerId'],
                      oauth_uid      : user['providerData'][0]['uid'],
                      first_name     : user['displayName'],
                      photoURL       : user['photoURL'],
											IDEmpresa			 : '3'
                      
              			}, // Datos a enviar
              dataType: "json", 									 // Tipo de datos a devolver (JSON)
              success: function (data) {
                
                // Si no da error, sigo con el proceso
                if(data[0] == 'OK'){
      						
      						//alert(data[1]);
      						if(data['usrTel'] != ''){
      						  $("#ModalRevisarTel").val(data['usrTel']);
      						}
      						
                }else{
                  
                  //alert(data[1]);
    
                }
                
              }
                    
      }).fail(function(){
      	
      });
      
    });
  	
</script>--%>

<%--<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-104830613-1', 'auto');
  ga('send', 'pageview');

</script>--%>
