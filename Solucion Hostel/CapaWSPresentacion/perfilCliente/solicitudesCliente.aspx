<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="solicitudesCliente.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.solicitudesCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/solicitudesCliente.css">
    
<form id="form1" runat="server">
    
    <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> DATOS ACTUALES </h3> </div>
			<div class="datosEmpresa" style=""> <b>Razón Social</b>  <br> <label>Nombre Empresa</label> </div>
			<div class="datosEmpresa">  <b>Rut Empresa</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Giro</b>  <br> <label>Entretención</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>contacto@empresa.cl</label> </div>
			<div class="datosEmpresa">  <b>Dirección</b>  <br> <label>Almirante Pastene 185</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>22222222</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->

	<div class="columna2">
		
				<h2>Historico Solicitudes</h2><br>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha Solicitud  </th>
						<th>Total de días  </th>
						<th>Nº Personas </th>
						<th>Fecha Ingreso  </th>
						<th>Fecha Salida</th>
						<th>Solicitud  </th>
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>7</td>
						<td>15</td>
						<td>15/03/2018</td>
						<td>22/03/2018</td>
						<td><a href="#">Ver Solicitud</a></td>			
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>7</td>
						<td>15</td>
						<td>15/03/2018</td>
						<td>22/03/2018</td>
						<td><a href="#">Ver Solicitud</a></td>			
					</tr>
		</table>
		
	</div>
</form>


</asp:Content>
