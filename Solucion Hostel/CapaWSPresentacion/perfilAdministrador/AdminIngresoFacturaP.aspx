<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminIngresoFacturaP.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminIngresoFacturaP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    

        
   <link rel="stylesheet" type="text/css" href="/scripts/AdminIngresoFacturaP.css">

    
     <form id="form1" runat="server">
        <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa" style="color: white">  <h3> Bienvenido </h3> </div>
			<div class="datosEmpresa" style="color: orange"> <b>Nombre</b>  <br> <label style="color: white">Francisca Jímenez</label> </div>
			<div class="datosEmpresa" style="color: orange">  <b>Rut</b>  <br>  <label style="color: white">11111111-1</label> </div>
			<div class="datosEmpresa" style="color: orange">  <b>Cargo</b>  <br> <label style="color: white">Empleado</label> </div>
			<div class="datosEmpresa" style="color: orange">  <b>Correo Electrónico </b> <br> <label style="color: white">Fran.Jimenez@donaclarita.cl</label> </div>
			<div class="datosEmpresa" style="color: orange">  <b>Teléfono</b>  <br> <label style="color: white">+56 9 57846054</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->



	<div class="columna2">
	
	
	<div class="ModificarDatos2">
		
		<h2>Crear Factura</h2>
		<div class="Casilla2-2" >
		<h4 style="color: white;">Cod.Producto</h4>	
		<asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: white;">Detalle</h4>	
		<asp:TextBox ID="TextBox2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: white;">Precio</h4>	
		<asp:TextBox ID="TextBox3" runat="server" CssClass="CasillaPersona2"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: white;">Cantidad</h4>	
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
		<asp:Button ID="Button2" runat="server" Text="Generar Factura" CssClass="SubmitTotal2" />
		</div>
	</div>			
</div>
    </form>
</asp:Content>
