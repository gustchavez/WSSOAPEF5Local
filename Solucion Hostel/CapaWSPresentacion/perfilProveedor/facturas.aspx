<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="facturas.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/facturaProveedor.css">
 
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
