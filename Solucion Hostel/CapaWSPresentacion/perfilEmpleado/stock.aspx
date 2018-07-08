<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="stock.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.stock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/stockEmpleado.css">

    <form id="form1" runat="server">

	<div class="columna2">
		<h2>Solicitudes de Doña Clarita</h2>
		<h4>Color rojo es stock critico, favor solicitar cuanto antes ese producto.</h4>
			
	    <asp:GridView ID="gwListaProductos" runat="server" CssClass="listaFactura">
        </asp:GridView>
		
	</div>

    </form>

</asp:Content>
