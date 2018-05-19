<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="facturaEmpleado.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.facturaEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" type="text/css" href="/scripts/facturaEmpleado.css"/>
    <title></title>
</head>
<body>
<div class="padre">
   <!-- Inicio Columna 1 --> 

   <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> Datos Usuario </h3> </div>
			<div class="datosEmpresa" style=""> <b>Nombre</b>  <br/> <label>Francisca Jímenez</label> </div>
			<div class="datosEmpresa">  <b>Rut</b>  <br/>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Cargo</b>  <br/> <label>Empleado</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br/> <label>Fran.Jimenez@donaclarita.cl</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br/> <label>+56 9 57846054</label> </div>
		</div>
	</div>

    <!-- Fin Columna 1 --> 
    <!-- Inicio Columna 2 --> 
    <div class="columna2">
		
				<h2>Mis Facturas</h2><br/>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha  </th>
						<th>Empresa </th>
						<th>Factura  </th>
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>Proveedor</td>
						<td> <a href="#"> <img src="images/logPdf.png"/></a></td>
					</tr>
		</table>
		
	</div>


    
     <!-- Fin Columna 2 --> 
</div>
</body>
</html>
