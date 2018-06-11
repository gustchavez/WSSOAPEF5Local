<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.Pedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">

	    <div class="columna2">
		
				<h2>Solicitudes de Doña Clarita</h2><br>
		
	            <br />
                <asp:GridView ID="gwSolicitudes" runat="server" CssClass="listaFactura">
                </asp:GridView>
		
	</div>
	<!--Fin COLUMNA2-->



        </form>



</asp:Content>
