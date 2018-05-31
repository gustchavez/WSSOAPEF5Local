<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="finSolicitud.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.finSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<link rel="stylesheet" type="text/css" href="/scripts/ordenCliente.css">

<form id="form1" runat="server">

    <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> SOLICITANTE </h3> </div>
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

		<h1>Gracias por preferirnos</h1>
		<h2>Su orden ha sido efectuada exitosamente</h2>
		<p>*Al generar una orden de compra usted dispondra de 3 días para realizar el pago de este, ya sea en cheques, deposito, crédito o efectivo, si usted no realiza esto dentro de los días solicitados su reserva será anulada</p>	
		
		<div class="contenedor">
			<h3>Datos deposito: Doña Clarita</h3><br>
			<h4>Banco: Falabella</h4><br>
			<h4>Nº Cuenta: 1-111-111-11-2</h4><br>
			<h4>Tipo de cuenta: Vista</h4><br>
			<h4>Télefono: 5555-55555</h4><br>
			<h4>Correo Electrónico: deposito@donaclarita.cl</h4><br>
			<h4>Asunto: Deposito</h4>
			<br>
			<br>
			<hr>
			<br>
			<br>
			<h3>Contacto Ventas</h3>
			<br>
			<h4>+56 2 2343 5434</h4>
			<br>
			<h4>Contacto@donaclarita.cl</h4>
			
		</div>	
	</div>


</form>

</asp:Content>
