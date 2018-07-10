<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminPPedidos.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminPPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/solicitudesCliente.css">

    <form id="form1" runat="server">
	    <div class="columna2">
            <br />
            <h2 style="text-align:center;">Solicitudes de Doña Clarita</h2>
		   
				
               
            <div class="ModificarDatos">
                <h2>Ordenes</h2><br>
             
                    <asp:GridView ID="gwSolicitudes" runat="server" CssClass="listaFactura97"
                        AutoGenerateColumns="False"
                        OnSelectedIndexChanged="gwSolicitudes_SelectedIndexChanged"
                        EmptyDataText="No se encontraron solicitudes...">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="RutEmpresa" HeaderText="Rut Proveedor" SortExpression="RutEmpresa" />
                            <asp:BoundField DataField="NroOrden" HeaderText="Nro. Orden" SortExpression="NroOrden" />
                            <asp:BoundField DataField="FechaSolicitud" HeaderText="Fec. Solicitud" SortExpression="FechaSolicitud"/>
                            <asp:BoundField DataField="Monto" HeaderText="Monto" SortExpression="Monto"/>
                            <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado"/>
                        </Columns>
                        <SelectedRowStyle CssClass="listaFacturaSeleccion" Font-Bold="True"></SelectedRowStyle>
                    </asp:GridView>
			
		    </div>
            <div class="ModificarDatos32">
                <div class="columna2-1"> 
		            <h2>Detalle Orden</h2><br>
                    <asp:GridView ID="gwOrdenDetalle" runat="server" CssClass="listaFactura97"
                         EmptyDataText="Seleccione Orden...">
                    </asp:GridView>
	            </div>
		    </div>
	    </div>
	<!--Fin COLUMNA2-->
    </form>
</asp:Content>
