<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <link rel="stylesheet" type="text/css" href="/scripts/perfilCliente.css">
    
     <form id="form1" runat="server">

    <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> Datos Usuario </h3> </div>
			<div class="datosEmpresa" style=""> <b>Nombre</b>  <br> <label>Francisca Jímenez</label> </div>
			<div class="datosEmpresa">  <b>Rut</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Cargo</b>  <br> <label>Empleado</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>Fran.Jimenez@donaclarita.cl</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>+56 9 57846054</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->


	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Modificar datos de empleado</h2><br>	
			<div class="Casilla2-1">
			<h4>Rut </h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="111111111-1" disabled>
			</div>
			<div class="Casilla2-1">
			<h4>Nombre</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Francisca Jímenez" disabled>
			</div>
			<div class="Casilla2-1">
			<h4>Cargo</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Empleado" disabled>
			</div>
			<div class="Casilla2-1">
			<h4>Correo Electrónico</h4>
			<input type="text" name="" class="CasillaPersona" placeholder="fran.jimenez@donaclarita.cl" disabled>
			</div>
			<div class="Casilla2-1">
			<h4>Fecha Nacimiento</h4>					
			<input type="text" name="" class="CasillaPersona" placeholder="13/03/1990" disabled>
			</div>
			<div class="Casilla2-1">
			<h4 style="color: red;">Dirección (modificable)</h4>					
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Dirección">
			</div>			
			<div class="Casilla2-1">
			<h4 style="color: red;">Teléfono (modificable)</h4>					
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Teléfono">
			</div>
	</div>


	<div class="ModificarDatos2">
		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre Usuario</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre" >
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Nueva Contraseña</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Contraseña">
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Confirmar Contraseña</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Contraseña">
		</div>
		<div class="Casilla2-2">	
		<input type="submit" name="" class="SubmitTotal" placeholder="Ingrese Teléfono" value="Modificar">
		</div>
	</div>
		
</div>
</form>

</asp:Content>
