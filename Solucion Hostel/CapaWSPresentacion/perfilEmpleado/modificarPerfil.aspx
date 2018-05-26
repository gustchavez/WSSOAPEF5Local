<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="modificarPerfil.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.modificarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder13" runat="server">
   
<div class="padre">

	<!--Fin Menu-->

	<div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> Datos Usuario </h3> </div>
			<div class="datosEmpresa">  <b>Nombre</b>  <br/> <asp:Label ID="Label1" runat="server" Text="Nombre Persona"></asp:Label> </div>
			<div class="datosEmpresa">  <b>Rut</b>  <br/> <asp:Label ID="Label2" runat="server" Text="11111111"></asp:Label>  </div>
			<div class="datosEmpresa">  <b>Cargo</b>  <br/> <asp:Label ID="Label3" runat="server" Text="Empleado"></asp:Label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br/> <asp:Label ID="Label4" runat="server" Text="correo@correo.cl"></asp:Label>  </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br/> <asp:Label ID="Label5" runat="server" Text="555555555"></asp:Label>  </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->

    <form action="/" method="post" runat="server">
	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Modificar datos de empleado</h2><br/>	
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
	    <asp:Button ID="Button1" runat="server" Text="Modificar" CssClass="SubmitTotal" />
		</div>
	</div>
		
</div>
        </form>
	<!--Fin COLUMNA2-->


</div>

</asp:Content>
