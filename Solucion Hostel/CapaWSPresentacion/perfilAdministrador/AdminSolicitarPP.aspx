<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminSolicitarPP.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminSolicitarPP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/AdminSolicitarPP.css">

    <form id="form1" runat="server">
        
	<div class="columna2">	
	
	<div class="ModificarDatos2">
		
		<h2>Solicitar productos a proveedor</h2>
		<h4>Seleccione cod. producto y cantidad o nombre de producto y cantidad </h4>
		<div class="Casilla2-2" >
		<h4 style="color: orange;">Cod.Producto</h4>	
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="selectO">
                <asp:ListItem Value="1">Selecciona un Cod</asp:ListItem>
                <asp:ListItem Value="2">H4040</asp:ListItem>
                <asp:ListItem Value="3">A2740</asp:ListItem>
                <asp:ListItem Value="4">A2740</asp:ListItem>
                <asp:ListItem Value="5">A2740</asp:ListItem>
        </asp:DropDownList> 
		</div>
		<div class="Casilla2-2">
		<h4 style="color: orange;">Nombre producto</h4>	
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="selectO">
                <asp:ListItem Value="1">Selecciona un Cod</asp:ListItem>
                <asp:ListItem Value="2">producto</asp:ListItem>
                <asp:ListItem Value="3">producto</asp:ListItem>
                <asp:ListItem Value="4">producto</asp:ListItem>
                <asp:ListItem Value="5">producto</asp:ListItem>
        </asp:DropDownList> 
		</div>
		<div class="Casilla2-2">
		<h4 style="color: orange;">Cantidad</h4>	
		<asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">	
	     <asp:Button ID="Button2" runat="server" Text="AGREGAR PRODUCTO" CssClass="SubmitTotal" />
		</div>
	</div>
	
	<div class="contenedorTabla">
		<table class="tabla">
			<tr>
				<th>Cod. Producto</th>
				<th>Detalle</th>
				<th>Precio</th>
				<th>Cantidad</th>
				<th>empresa</th>
				<th>Eliminar</th>
			</tr>
			<tr>
				<td>A2740</td>
				<td>Limpia vidrios 1lt</td>
				<td>1000</td>
				<td>10</td>
				<td>Limpieza ltda</td>
				<td> <a href="#">Eliminar</a></td>
			</tr>

		</table>
		<div class="Casilla2-1">	
	    <asp:Button ID="Button1" runat="server" Text="Hacer solicitud a proveedores" CssClass="SubmitTotal2" />
		</div>
	</div>		
</div>

    </form>
</asp:Content>
