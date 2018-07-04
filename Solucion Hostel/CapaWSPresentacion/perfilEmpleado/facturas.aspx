<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="facturas.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <link rel="stylesheet" type="text/css" href="/scripts/facturaEmpleado.css">

 <form id="form1" runat="server">

	<div class="columna2">
		
	    <h2>Facturas Pedidos</h2><br>
        <asp:GridView ID="gwFacturasPedido" runat="server" CssClass="listaFactura"
            EmptyDataText="No se encontraron Facturas..."
            ></asp:GridView>
		
        <h2>Facturas Compras</h2><br>
        <asp:GridView ID="gwFacturasCompra" runat="server" CssClass="listaFactura"
            EmptyDataText="No se encontraron Facturas..."
            ></asp:GridView>
		
	</div>

</form>



</asp:Content>
