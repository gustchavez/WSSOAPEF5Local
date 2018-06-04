﻿<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <link rel="stylesheet" type="text/css" href="/scripts/perfilCliente.css">
    
     <form id="form1" runat="server">

	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Modificar datos de empleado</h2><br>	
			<div class="Casilla2-1">
			<h4>Rut </h4>	
			<asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaPersona"></asp:TextBox>  
			</div>
			<div class="Casilla2-1">
			<h4>Nombre</h4>	
			<asp:TextBox ID="TextBox2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Cargo</h4>	
			<asp:TextBox ID="TextBox3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Correo Electrónico</h4>
			<asp:TextBox ID="TextBox4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Fecha Nacimiento</h4>					
			<asp:TextBox ID="TextBox5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4 style="color: red;">Dirección (modificable)</h4>					
			<asp:TextBox ID="TextBox6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>			
			<div class="Casilla2-1">
			<h4 style="color: red;">Teléfono (modificable)</h4>					
			<asp:TextBox ID="TextBox7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
	</div>


	<div class="ModificarDatos2">
		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre Usuario</h4>	
		<asp:TextBox ID="TextBox8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Nueva Contraseña</h4>	
		<asp:TextBox ID="TextBox9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Confirmar Contraseña</h4>	
		<asp:TextBox ID="TextBox10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
		</div>
		<div class="Casilla2-2">	
		<asp:Button ID="Button1" runat="server" Text="Modificar Datos" CssClass="SubmitTotal" OnClick="Button1_Click" />
		</div>
	</div>
		
</div>
</form>

</asp:Content>