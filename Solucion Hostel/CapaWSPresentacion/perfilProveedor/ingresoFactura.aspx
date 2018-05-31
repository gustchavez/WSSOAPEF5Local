<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="ingresoFactura.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.ingresoFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/ingresoFacturaProveedor.css">


    <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> DATOS FACTURA </h3> </div>
			<div class="datosEmpresa" style=""> <b>Razón Social</b>  <br> <label>Nombre Empresa</label> </div>
			<div class="datosEmpresa">  <b>Rut Empresa</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Giro</b>  <br> <label>Entretención</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>contacto@empresa.cl</label> </div>
			<div class="datosEmpresa">  <b>Dirección</b>  <br> <label>Almirante Pastene 185</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>22222222</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->

<div class="columna2">
	
	
	<div class="ModificarDatos2">
		
		<h2>Ingreso de productos</h2>
		<div class="Casilla2-2" >
		<h4 style="color: red;">Cod.Producto</h4>	
		<input type="text" name="" class="CasillaPersona2"  >
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Detalle</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder=" " width="40">
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Precio</h4>	
		<input type="number" name="" class="CasillaPersona2" placeholder=" ">
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Cantidad</h4>	
		<input type="number" name="" class="CasillaPersona2" placeholder=" ">
		</div>
		<div class="Casilla2-2">	
		<input type="submit" name="" class="SubmitTotal" placeholder="Ingrese Teléfono" value="Agregar Produto">
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
		<input type="submit" name="" class="SubmitTotal2" placeholder="Ingrese Teléfono" value="Generar Factura">
		</div>
	</div>	

	

	
		
</div>

</asp:Content>
