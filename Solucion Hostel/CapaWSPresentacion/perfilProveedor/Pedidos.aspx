<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="css/solicitudesCliente.css">

    <form id="form1" runat="server">

	    <div class="columna2">
		   <div class="ModificarDatos">
				<h2>Solicitudes de Doña Clarita</h2><br>
		
	            <br />
                <asp:GridView ID="gwSolicitudes" runat="server" CssClass="listaFactura"
                     EmptyDataText="No se encontraron solicitudes...">
               
                </asp:GridView>
		    </div>
	</div>
	<!--Fin COLUMNA2-->



        </form>



</asp:Content>
