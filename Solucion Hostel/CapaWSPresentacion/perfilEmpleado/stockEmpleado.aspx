`´<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stockEmpleado.aspx.cs" Inherits="CapaWSPresentacion.stockEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="scripts/stockEmpleado.css"/>
	<script src="scripts/efectos.js"></script>
	<script src="scripts/jquery.min.js"></script>
</head>

<body>

    <form id="form1" runat="server">

  <div class="padre">

    <!-- Inicio Columna 1 --> 

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

    <!-- Fin Columna 1 --> 
    <!-- Inicio Columna 2 --> 

      <div class="columna2">
		
				<h2>Solicitudes de Doña Clarita</h2>
				<h4>Color rojo es stock critico, favor solicitar cuanto antes ese producto.</h4>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Cod. Producto </th>
						<th>Detalle  </th>
						<th>Empresa </th>
						<th>Precio unitario </th>
						<th>Cantidad</th>						
					</tr>
					<tr>
						<td>A0127</td>
						<td>Limpia Vidrios</td>
						<td>Limpieza ltda.</td>
						<td>1000</td>
						<td style="background: #5fb49c; color: white;">20</td>			
					</tr>
					<tr>
						<td>H4040</td>
						<td>Arroz Capel 1kg</td>
						<td>Jumbo</td>
						<td>720</td>
						<td style="background: #b24c63; color:white;">10</td>			
					</tr>
		</table>
	</div>
   

    <!-- Fin Columna 2 --> 

   </div> 
    </form>
</body>
</html>
