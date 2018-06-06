<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="facturas.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/facturaProveedor.css">


    <div class="menu">

		<div class="BotonMenu" onclick="efecto()">MENU</div>		
		<div class="desplegable">			
			<div class="subMenu"> <div class="imagen-logo"></div> </div>
			<div class="subMenu"> <a href="pedidosProveedor.html" style="color: #e2e2e2;"> Pedidos </a></div>
			<div class="subMenu"> <a href="perfilProveedor.html" style="color: #e2e2e2;"> Modificar Perfil </a></div>
			<div class="subMenu"> <a href="facturaProveedor.html" style="color: #e2e2e2;"> Ver Facturas </a></div> 
			<div class="subMenu"> <a href="ingresoFacturaProveedor.html" style="color: #e2e2e2;"> Ingreso Factura </a></div><br>
			<div class="subMenu"> <a href="ingreso.html" style="color: #e2e2e2;"> Cerrar Sesión</a></div>
		</div>

	</div>
	<!--Fin Menu-->

	<div class="columna2">
		
				<h2>Mis Facturas</h2><br>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha  </th>
						<th>Forma de Pago  </th>
						<th>Empresa </th>
						<th>Factura  </th>
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>Debito</td>
						<td>Proveedor</td>
						<td> <a href="#"> <img src="images/logPdf.png"></a></td>
					</tr>
		</table>
		
	</div>
</asp:Content>
