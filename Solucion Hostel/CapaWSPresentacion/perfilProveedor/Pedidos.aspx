<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
		
				<h2>Solicitudes de Doña Clarita</h2><br>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha Solicitud  </th>
						<th>Cant. productos  </th>
						<th>Solicitante </th>
						<th>Fecha de entrega </th>
						<th>Solicitud</th>
						<th>Activo</th>
						
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>20</td>
						<td>Diego Tapia</td>
						<td>01/06/2018</td>
						<td><a href="#">Ver Solicitud</a></td>
						<td style="background: #c1fff2;">Activo</td>			
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>20</td>
						<td>Diego Tapia</td>
						<td>15/03/2018</td>
						<td><a href="#">Ver Solicitud</a></td>
						<td style="background: #b24c63; color:white;">Inactivo</td>			
					</tr>

		</table>
		
	</div>
	<!--Fin COLUMNA2-->



</asp:Content>
