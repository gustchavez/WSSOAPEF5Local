<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminFacturaProveedorP.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminFacturaProveedorP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/AdminFacturaProveedorP.css">

    <form id="form1" runat="server">
        
	<div class="columna2">
		
		<h2>Facturas Proveedor</h2><br>

		<div class="Casilla2-1Principal">
			<h4>Selecciona una Empresa</h4>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="droplistPrincipal" OnSelectedIndexChanged="generarListaFacturas">
                <asp:ListItem Value="1">Selecciona un Perfil</asp:ListItem>
                <asp:ListItem Value="2">Administrador</asp:ListItem>
                <asp:ListItem Value="3">Empleado</asp:ListItem>
                <asp:ListItem Value="4">Cliente</asp:ListItem>
                <asp:ListItem Value="5">Proveedor</asp:ListItem>
            </asp:DropDownList> 
		</div>	
        	<div class="Casilla2-1Principal">	
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Consultar" CssClass="SubmitTotal" />
		</div>
           <table border="0" class="listaFactura">				
			<tr>
				<th>Fecha  </th>
				<th>Forma de Pago  </th>
				<th>Empresa </th>
				<th>Factura  </th>
			</tr>
			<tr>
				<td>13/03/2018</td>
				<td>Debito</td>
				<td>Proveedor</td>
				<td> <a href="#"> <img src="/scripts/logPdf.png"><asp:Button ID="generarPDF" runat="server" OnClick="generarPDF_Click" Text="Generar PDF" />
                    </a></td>
			</tr>
		</table>
	    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
	</div>	
	<!--Fin COLUMNA2-->

    </form>

</asp:Content>
