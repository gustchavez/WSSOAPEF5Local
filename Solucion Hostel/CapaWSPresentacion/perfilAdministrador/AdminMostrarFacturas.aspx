<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminMostrarFacturas.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminMostrarFacturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/AdminMostrarFacturas.css">


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
		
				<h2>Solicitudes de Empleado a Proveedor</h2><br>
				<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha  </th>
						<th>Empresa </th>
						<th>Factura  </th>
					</tr>
					<tr>
						<td>13/03/2018</td>
						<td>Proveedor</td>
						<td> <a href="#"> <img src="images/logPdf.png"></a></td>
					</tr>
		</table>
		
	</div>
	<!--Fin COLUMNA2-->
    </form>

</asp:Content>
