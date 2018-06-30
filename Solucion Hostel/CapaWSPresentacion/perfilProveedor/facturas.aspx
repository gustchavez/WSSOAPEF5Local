<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="facturas.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/facturaProveedor.css">
 
	<!--Fin Menu-->

	<div class="columna2">
		<div class="ModificarDatos">
				<h2>Mis Facturas</h2><br>
        <asp:GridView ID="gwFacturasPedido" runat="server" CssClass="listaFactura"
            EmptyDataText="No se encontraron Facturas..."
            ></asp:GridView>
		</div>
	</div>
    </form>
</asp:Content>
