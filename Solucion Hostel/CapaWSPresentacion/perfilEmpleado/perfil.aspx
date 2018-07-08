<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <link rel="stylesheet" type="text/css" href="/scripts/perfilCliente.css">
    
     <form id="form1" runat="server">

	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Modificar datos de empleado</h2><br>	
			<div class="Casilla2-1">
			<h4>Rut </h4>	
			<asp:TextBox ID="txtRut" runat="server" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>  
                <br><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage=" * Ingrese Rut" ControlToValidate="txtRut"></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Nombre</h4>	
			<asp:TextBox ID="txtNombre" runat="server" CssClass="CasillaPersona"></asp:TextBox>
                <br><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage=" * Ingrese Nombre" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
			</div>
            <div class="Casilla2-1">
			<h4>Apellido</h4>	
			<asp:TextBox ID="txtApellido" runat="server" CssClass="CasillaPersona"></asp:TextBox>
                <br><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" * Ingrese Apellido" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Correo Electrónico</h4>
			<asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="CasillaPersona"></asp:TextBox>
                <br><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage=" * Ingrese Correo Electronico" ControlToValidate="txtCorreoElectronico"></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Fecha Nacimiento</h4>					
			<%--<asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="CasillaPersona" TextMode="Date" requiered=" ingresar fecha"></asp:TextBox>--%>
                <br><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage=" * Ingrese Fecha Nacimiento" ControlToValidate="txtFechaNacimiento" OnDataBinding="validaFecha" Text="Ingrese Fecha Nacimiento">Ingrese Fecha Nacimiento</asp:RequiredFieldValidator>
			</div>			
			<div class="Casilla2-1">
			<h4 style="color: red;">Teléfono</h4>					
			<asp:TextBox ID="txtTelefono" runat="server" CssClass="CasillaPersona"></asp:TextBox>
                <br><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage=" * Ingrese Telefonno" ControlToValidate="txtTelefono"></asp:RequiredFieldValidator>
			</div>
	</div>


	<div class="ModificarDatos2">
		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre Usuario</h4>	
		<asp:TextBox ID="txtUsuario" runat="server" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
            <br><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage=" * Ingrese Nombre Usuario" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Nueva Contraseña</h4>	
		<asp:TextBox ID="txtContraseña" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            <br><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage=" * Ingrese Nueva Contraseña" ControlToValidate="txtContraseña"></asp:RequiredFieldValidator>
		</div>
		<div class="Casilla2-2">	
		<asp:Button ID="btnModificar" runat="server" Text="Modificar Datos" CssClass="SubmitTotal" OnClick="btnModificar_Click" />
		</div>
	</div>
		
</div>
</form>

</asp:Content>
