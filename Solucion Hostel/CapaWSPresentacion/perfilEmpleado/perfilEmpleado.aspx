﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfilEmpleado.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.perfilEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="/scripts/perfilEmpleado.css"/>
	<script src="scripts/efectos.js"></script>
	<script src="scripts/jquery.min.js"></script>
</head>
<body>
   <div class="padre">

       <!-- Inicio columna 1-->
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
       <!-- Fin columna 1-->
       <!-- Inicio columna 2-->
        <form id="form1" runat="server">
        <div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Modificar datos de empleado</h2><br>	
			<div class="Casilla2-1">
			<h4>Rut </h4>	
			<asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaPersona" Enabled="False" ></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Nombre</h4>	
			<asp:TextBox ID="TextBox2" runat="server" CssClass="CasillaPersona" Enabled="False" ></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Cargo</h4>	
			<asp:TextBox ID="TextBox3" runat="server" CssClass="CasillaPersona" Enabled="False" ></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Correo Electrónico</h4>
			<asp:TextBox ID="TextBox4" runat="server" CssClass="CasillaPersona" Enabled="False" ></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Fecha Nacimiento</h4>					
			<asp:TextBox ID="TextBox5" runat="server" CssClass="CasillaPersona" Enabled="False" ></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4 style="color: red;">Dirección (modificable)</h4>					
			<asp:TextBox ID="TextBox6" runat="server" CssClass="CasillaPersona"  ></asp:TextBox>
			</div>			
			<div class="Casilla2-1">
			<h4 style="color: red;">Teléfono (modificable)</h4>					
			<asp:TextBox ID="TextBox7" runat="server" CssClass="CasillaPersona"  ></asp:TextBox>
			</div>
    	</div>


        <div class="ModificarDatos2">
		        <div class="Casilla2-2">
		        <h4 style="color: red;">Nombre Usuario</h4>	
		        <asp:TextBox ID="TextBox8" runat="server" CssClass="CasillaPersona" ></asp:TextBox>
		        </div>
		        <div class="Casilla2-2">
		        <h4 style="color: red;">Nueva Contraseña</h4>	
		        <asp:TextBox ID="TextBox9" runat="server" CssClass="CasillaPersona" ></asp:TextBox>
		        </div>
		        <div class="Casilla2-2">
		        <h4 style="color: red;">Confirmar Contraseña</h4>	
		        <asp:TextBox ID="TextBox10" runat="server" CssClass="CasillaPersona" ></asp:TextBox>
		        </div>
		        <div class="Casilla2-2">	
		        <asp:Button ID="Button1" runat="server" Text="Modificar" CssClass="SubmitTotal"/>
		        </div>
	        </div>
		
        </div>
       </form>
       <!-- Fin columna 1-->

   </div>
</body>
</html>

