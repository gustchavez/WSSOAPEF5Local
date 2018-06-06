<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

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
		
	            <br />
                <asp:GridView ID="gwSolicitudes" runat="server" CssClass="listaFactura">
                </asp:GridView>
		
	</div>
	<!--Fin COLUMNA2-->



        </form>



</asp:Content>
