<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="solicitarEmpleado.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.solicitarEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="/scripts/solicitarEmpleado.css"/>
    <title></title>
</head>
<body>
    <div class="padre">
	
	<div class="menu">

		<div class="BotonMenu" onclick="efecto()">MENU</div>		
		<div class="desplegable">		
			<div class="subMenu"> <div class="imagen-logo"></div> </div>
			<div class="subMenu"> <a href="stockEmpleado.html" style="color: #e2e2e2;"> Stock Productos </a></div>
			<div class="subMenu"> <a href="perfilEmpleado.html" style="color: #e2e2e2;"> Modificar Perfil </a></div>
			<div class="subMenu"> <a href="facturaEmpleado.html" style="color: #e2e2e2;"> Ver Facturas Proveedores </a></div> 
			<div class="subMenu"> <a href="empresaEmpleado.html" style="color: #e2e2e2;"> Ingresar Empresa </a></div>
			<div class="subMenu"> <a href="productosEmpleado.html" style="color: #e2e2e2;"> Ingresar Productos </a></div>
			<div class="subMenu"> <a href="solicitarEmpleado.html" style="color: #e2e2e2;"> Solicitar Productos </a></div><br>
			<div class="subMenu"> <a href="ingreso.html" style="color: #e2e2e2;"> Cerrar Sesión</a></div>
		</div>

	</div>
	<!--Fin Menu-->

	<div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> Datos Usuario </h3> </div>
			<div class="datosEmpresa" style=""> <b>Nombre</b>  <br> <label>Francisca Jímenez</label> </div>
			<div class="datosEmpresa">  <b>Rut</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Cargo</b>  <br> <label>Empleado</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>Fran.Jimenez@donaclarita.cl</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>+56 9 57846054</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->

<div class="columna2">
	
	
	<div class="ModificarDatos2">
		
		<h2>Solicitar productos</h2>
		<h4>Seleccione cod. producto y cantidad o nombre de producto y cantidad </h4>
		<div class="Casilla2-2" >
		<h4 style="color: red;">Cod.Producto</h4>	
		<select class="selectO">
			<option>H4040</option>
			<option>A2740</option>
			<option>A2740</option>
			<option>A2740</option>
		</select>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre producto</h4>	
		<select class="selectO">
			<option>Lavaloza</option>
			<option>Limpia Vidrio</option>
			<option>Arroz</option>
			<option>Azucar</option>
		</select></div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Cantidad</h4>	
		<input type="number" name="" class="CasillaPersona2" placeholder=" ">
		</div>
		<div class="Casilla2-2">	
		<input type="submit" name="" class="SubmitTotal" placeholder="Ingrese Teléfono" value="Agregar Produto">
		</div>
	</div>
	
	<div class="contenedorTabla">
		<table class="tabla">
			<tr>
				<th>Cod. Producto</th>
				<th>Detalle</th>
				<th>Precio</th>
				<th>Cantidad</th>
				<th>empresa</th>
				<th>Eliminar</th>
			</tr>
			<tr>
				<td>A2740</td>
				<td>Limpia vidrios 1lt</td>
				<td>1000</td>
				<td>10</td>
				<td>Limpieza ltda</td>
				<td> <a href="#">Eliminar</a></td>
			</tr>

		</table>
		<div class="Casilla2-1">	
		<input type="submit" name="" class="SubmitTotal2" placeholder="Ingrese Teléfono" value="Hacer solicitud a proveedores">
		</div>
	</div>	

	

	
		
</div>
	<!--Fin COLUMNA2-->


</div>
</body>
</html>
