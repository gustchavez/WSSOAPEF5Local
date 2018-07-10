<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminEstock.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminEstock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/stockEmpleado.css">

    <form id="form1" runat="server">

	<div class="columna2">
		<h2>Solicitudes de Doña Clarita</h2>
		<h4>Color rojo es stock critico, favor solicitar cuanto antes ese producto.</h4>
			
	    <asp:GridView ID="gwListaProductos" runat="server" CssClass="listaFactura"
            AutoGenerateColumns="False"
            OnRowDataBound="gwListaProductos_RowDataBound"
            EmptyDataText="No se encontraron productos..." >
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Código"/>
                <asp:BoundField DataField="Decripcion" HeaderText="Descripción"/>
                <asp:BoundField DataField="Stock" HeaderText="Stock"/>
                <asp:BoundField DataField="StockCritico" HeaderText="Stock Critico"/>
                <asp:BoundField DataField="Critico" HeaderText="¿Solicitar?"/>
            </Columns>
        </asp:GridView>
		
	</div>

    </form>

</asp:Content>
