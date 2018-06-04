<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.stock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/stockEmpleado.css">

    <form id="form1" runat="server">

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
		
	            <asp:GridView ID="gwListaProductos" runat="server" CssClass="listaFactura">
                </asp:GridView>
		
	</div>

    </form>

</asp:Content>
