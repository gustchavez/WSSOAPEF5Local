<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="facturas.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/facturaEmpleado.css">

 <form id="form1" runat="server">

	<div class="columna2">
		
				<h2>Mis Facturas</h2><br>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha  </th>
						<th>Empresa </th>
						<th>Factura  </th>
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>Proveedor</td>
						<td> <a href="#"> <img src="images/logPdf.png"></a></td>
					</tr>
		</table>
		
	</div>

</form>



</asp:Content>
