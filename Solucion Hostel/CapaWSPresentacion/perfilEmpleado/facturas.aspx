<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="facturas.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.facturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/facturaEmpleado.css">

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
		
				<h2>Mis Facturas</h2><br>
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

</form>



</asp:Content>
