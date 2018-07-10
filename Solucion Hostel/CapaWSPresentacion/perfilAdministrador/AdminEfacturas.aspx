<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminEfacturas.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminEfacturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <link rel="stylesheet" type="text/css" href="/scripts/facturaEmpleado.css">

 <form id="form1" runat="server">

	<div class="columna2">
		<h2>Facturas Pedidos Proveedor</h2><br>
        <div class="casillaListado">    
        <asp:GridView ID="gwFacturasPedido" runat="server" CssClass="listaFactura77"
            EmptyDataText="No se encontraron Facturas..."
            ></asp:GridView>
		</div>
         <h2>Facturas Compras Clientes</h2><br>
        <div class="casillaListado">
        <asp:GridView ID="gwFacturasCompra" runat="server" CssClass="listaFactura77"
            EmptyDataText="No se encontraron Facturas..."
            ></asp:GridView>
		</div>
	</div>

</form>



</asp:Content>
