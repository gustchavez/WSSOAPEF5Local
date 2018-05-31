<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="IngresoProducto.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.IngresoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link rel="stylesheet" type="text/css" href="/scripts/productosEmpleado.css">
    
    <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> Datos Usuario </h3> </div>
			<div class="datosEmpresa">  <b>Nombre</b>  <br> <label>Francisca Jímenez</label> </div>
			<div class="datosEmpresa">  <b>Rut</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Cargo</b>  <br> <label>Empleado</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>Fran.Jimenez@donaclarita.cl</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>+56 9 57846054</label> </div>
		</div>
	</div>
    <!--Fin COLUMNA1-->

    <div class="columna2">
	<div class="ModificarDatos">
				
			<h2>Agregar productos a proveedor</h2><br>	
	
		
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>				
			<select class="droplist" required>
				<option value="" >Selecciona una Empresa</option>
				<option>Empresa 1</option>
				<option>Empresa 2</option>
				<option>Empresa 3</option>
				<option>Empresa 4</option>
			</select>			
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Dirección">
			</div>
			<div class="Casilla2-1">	
			<input type="submit" name="" class="SubmitTotal" value="Agregar Producto">
			</div>
			
	</div>
	<hr style="opacity: 0.1">
	<div class="ModificarDatos">
			<h2>Modificar producto de proveedor</h2><br>	
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>				
			<select class="droplist" required>
				<option value="" >Selecciona una Empresa</option>
				<option>Empresa 1</option>
				<option>Empresa 2</option>
				<option>Empresa 3</option>
				<option>Empresa 4</option>
			</select>			
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<select class="droplist" required>
				<option value="" >Selecciona un codigo</option>
				<option>Cod 1</option>
				<option>Cod 2</option>
				<option>Cod 3</option>
				<option>Cod 4</option>
			</select>	
			</div>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Dirección">
			</div>
			<div class="Casilla2-1">	
			<input type="submit" name="" class="SubmitTotal" placeholder=" " value="Modificar Producto">
			</div>
			
	</div>


		
</div>


</asp:Content>
