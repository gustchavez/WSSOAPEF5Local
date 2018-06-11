<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="ingresoFactura.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.ingresoFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/ingresoFacturaProveedor.css">

<div class="columna2">
	
	<div class="ModificarDatos2">
		
		<h2>Ingreso de productos</h2>
		<div class="Casilla2-2" >
		<h4 style="color: red;">Cod.Producto</h4>	
		 <asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Detalle</h4>	
		 <asp:TextBox ID="TextBox2" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Precio</h4>	
		 <asp:TextBox ID="TextBox3" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Cantidad</h4>	
		 <asp:TextBox ID="TextBox4" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">	
	 <asp:Button ID="Button1" runat="server" Text="Agregar Producto" CssClass="SubmitTotal" /> 
		</div>
	</div>
	
	<div class="contenedorTabla">
		<table class="tabla">
			<tr>
				<th>Cod. Producto</th>
				<th>Detalle</th>
				<th>Precio</th>
				<th>Cantidad</th>
				<th>Total</th>
				<th>IVA</th>
				<th>Total IVA</th>
				<th>Eliminar</th>
			</tr>
			<tr>
				<td>A2740</td>
				<td>Limpia vidrios 1lt</td>
				<td>1000</td>
				<td>10</td>
				<td>10000</td>
				<td>1900</td>
				<td>11900</td>
				<td> <a href="#">Eliminar</a></td>
			</tr>
			<tr>
				<td>A2745</td>
				<td>Lustra muebles</td>
				<td>1000</td>
				<td>10</td>
				<td>10000</td>
				<td>1900</td>
				<td>11900</td>
				<td> <a href="#">Eliminar</a></td>
			</tr>
			<tr>
				<td style="background: ; height: 30px;"></td>
				<td style="background: ;"></td>
				<td style="background: white;">2000</td>
				<td style="background: white;">20</td>
				<td style="background: white;">20000</td>
				<td style="background: white;">3800</td>
				<td style="background: white;">23800</td>
				<td style="background: white;">Totales</td>
			</tr>

		</table>
		<div class="Casilla2-1">	
		<asp:Button ID="Button2" runat="server" Text="Enviar Factura" CssClass="SubmitTotal" />
		</div>
	</div>	
</div>

</asp:Content>
