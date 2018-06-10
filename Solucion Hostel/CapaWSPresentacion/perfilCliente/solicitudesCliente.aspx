<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="solicitudesCliente.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.solicitudesCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/solicitudesCliente.css">
    
<form id="form1" runat="server">
    
	<div class="columna2"> 
		<h2>Historico Solicitudes</h2><br>
        <asp:GridView ID="gwOrdenesCompra" runat="server" CssClass="listaFactura"
            EmptyDataText="No se encontraron Solicitudes..."
            ></asp:GridView>
	</div>
</form>


</asp:Content>
