<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="recepcion.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.recepcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <link rel="stylesheet" type="text/css" href="/scripts/recepcion.css">

<form id="form1" runat="server">

    

<div class="columna2">
	
	
	<div class="ModificarDatos2" style="left: 0px; top: 30px">
		
		<h2>Confirmación de Huéspedes</h2>
		<h4>Seleccione cod. de orden y rut de empleado para confirmar su asistencia </h4>
		<div class="Casilla2-2" >
		<h4 style="color: red;">recepcion</h4>
            <asp:dropdownlist runat="server"></asp:dropdownlist>
		</div>        
		<div class="Casilla2-2">
		<h4 style="color: red;">Rut Huésped</h4>	
		     <asp:dropdownlist runat="server"></asp:dropdownlist>
		</div>
		<div class="Casilla2-2">	
	    <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Huésped" CssClass="SubmitTotal" OnClick="btnAgregar_Click" Enabled="False" />
		</div>
	</div>
	
	<div class="contenedorTabla">
		
		
	</div>		
</div>

</form>




</asp:Content>
