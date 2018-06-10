<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminFacturaProveedorP.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminFacturaProveedorP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/AdminFacturaProveedorP.css">

    <form id="form1" runat="server">
        
	<div class="columna2">
		
		<h2>Facturas Proveedor</h2><br>

		<div class="Casilla2-1Principal">
			<h4>Selecciona una Empresa</h4>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="droplistPrincipal">
                <asp:ListItem Value="1">Selecciona un Perfil</asp:ListItem>
                <asp:ListItem Value="2">Administrador</asp:ListItem>
                <asp:ListItem Value="3">Empleado</asp:ListItem>
                <asp:ListItem Value="4">Cliente</asp:ListItem>
                <asp:ListItem Value="5">Proveedor</asp:ListItem>
            </asp:DropDownList> 
		</div>		
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
				<td> <a href="#"> <img src="/scripts/logPdf.png"><asp:Button ID="generarPDF" runat="server" OnClick="generarPDF_Click" Text="Generar PDF" />
                    </a></td>
			</tr>
		</table>
	</div>	
	<!--Fin COLUMNA2-->

    </form>

</asp:Content>
