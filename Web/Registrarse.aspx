<%@ Page Title="Registracion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="Registrarse.aspx.cs" Inherits="Web.Registrarse" %>

<!DOCTYPE html>

<head>
    <meta name="format-detection" content="telephone=no">
    <meta name="viewport" content="width=device-width, height=device-height, initial-scale=1.0, maximum-scale=1.0, user-scalable=0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta charset="utf-8">
    <link rel="icon" href="/Content/images/favicon.ico" type="image/x-icon">
    <!-- Site Title-->
    <title>Home Page - Pizaline</title>
    <!-- Stylesheets-->
    <link rel="stylesheet" type="text/css" href="//fonts.googleapis.com/css?family=Changa+One:400,400i%7CGrand+Hotel%7CLato:300,400,400italic,700">
    <link href="Content/bootstrap.css" rel="stylesheet">
<link href="Content/style.css" rel="stylesheet">
<link href="Content/styles_custom.css" rel="stylesheet">

    
    
    
</head>
<html>
<body>
	<div class="container">
		<form method="post" action="">

			<div class="form-group">
				<input type="text" id="nombre" class="form-control" required placeholder="Nombre y Apellido">
			</div>

			<div class="form-group">
				<input type="email" class="form-control" placeholder="Email" required>
			</div>
            <div class="form-group">
				<input type="tel" id="Dirrecion" class="form-control" required placeholder="Direccion">
			</div>
			<div class="form-group">
				<input type="password" id="password" class="form-control" required placeholder="Contraseña">
			</div>
			
			<div class="form-group">
				<input type="password" id="confirmarPassword" class="form-control" required placeholder="Confirmar Contraseña">
			</div>

			<div class="form-group">
				<input type="tel" id="telefono" class="form-control" required placeholder="Telefono Celular">
			</div>

			

			<button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
			<input type="submit" class="btn btn-primary" value="Registrarse">
		</form>
	</div>
	
   <script src="Scripts/jquery-3.3.1.js"></script>

    <script src="Scripts/bootstrap.js"></script>

    <script src="Scripts/core.min.js"></script>
	<script src="Scripts/script.js"></script>
</body>
</html>
