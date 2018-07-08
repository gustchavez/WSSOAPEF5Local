<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="solicitudesCliente.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.solicitudesCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/solicitudesCliente.css">
    
<form id="form1" runat="server">
    
	<div class="columna2">
	    <div class="ModificarDatos">
            <div class="Casilla2-1">
		        <h2>Historico Solicitudes</h2><br>
                <asp:GridView ID="gwOrdenesCompra" runat="server" CssClass="listaFactura"
                        AutoGenerateColumns="False"
                        OnSelectedIndexChanged="gwOrdenesCompra_SelectedIndexChanged"
                        EmptyDataText="No se encontraron solicitudes...">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="NroOrden" HeaderText="Nro. Orden" SortExpression="NroOrden" />
                            <asp:BoundField DataField="FechaSolicitud" HeaderText="Fec. Solicitud" SortExpression="FechaSolicitud"/>
                            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto"/>
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"/>
                        </Columns>
                        <SelectedRowStyle Font-Bold="True" ForeColor="Red"></SelectedRowStyle>
                </asp:GridView>
	        </div>
	    </div>
        
        <div class="ModificarDatos2">
            <div class="columna2-1"> 
		        <h2>Detalle Solicitud</h2><br>
                <asp:GridView ID="gwOrdenDetalle" runat="server" CssClass="listaFactura"
                        EmptyDataText="Seleccione Solicitud...">
                </asp:GridView>
	        </div>
		</div>
	</div>
</form>


</asp:Content>
