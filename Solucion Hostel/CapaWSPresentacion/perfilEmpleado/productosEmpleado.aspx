<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="productosEmpleado.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.productosEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="/scripts/productosEmpleado.css"/>
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
	<div class="ModificarDatos">
				
			<h2>Agregar productos a proveedor</h2><br>	
	
		
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>				
			<select class="droplist" required>
				<option value="" >Selecciona una Empresa</option>
				<option>Empresa 1</option>
				<option>Empresa 2</option>
				<option>Empresa 3</option>
				<option>Empresa 4</optio>
			</select>			
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Dirección">
			</div>
			<div class="Casilla2-1">	
			<input type="submit" name="" class="SubmitTotal" placeholder=" " value="Agregar Producto">
			</div>
			
	</div>
	<hr style="opacity: 0.1">
	<div class="ModificarDatos">
			<h2>Modificar producto de proveedor</h2><br>	
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>				
			<select class="droplist" required>
				<option value="" >Selecciona una Empresa</option>
				<option>Empresa 1</option>
				<option>Empresa 2</option>
				<option>Empresa 3</option>
				<option>Empresa 4</optio>
			</select>			
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<select class="droplist" required>
				<option value="" >Selecciona un codigo</option>
				<option>Cod 1</option>
				<option>Cod 2</option>
				<option>Cod 3</option>
				<option>Cod 4</optio>
			</select>	
			</div>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Dirección">
			</div>
			<div class="Casilla2-1">	
			<input type="submit" name="" class="SubmitTotal" placeholder=" " value="Modificar Producto">
			</div>
			
	</div>


		
</div>
	<!--Fin COLUMNA2-->


</div>
</body>
</html>
