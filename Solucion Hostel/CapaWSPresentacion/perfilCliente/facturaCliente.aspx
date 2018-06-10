<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="facturaCliente.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.facturaCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/facturaCliente.css">


    <form id="form1" runat="server">
        
	<div class="columna2">
		
				<h2>Mis Facturas</h2><br>
        <asp:GridView ID="gwFacturasCompra" runat="server" CssClass="listaFactura"
            EmptyDataText="No se encontraron Facturas..."
            ></asp:GridView>
	</div>

    </form>
</asp:Content>
