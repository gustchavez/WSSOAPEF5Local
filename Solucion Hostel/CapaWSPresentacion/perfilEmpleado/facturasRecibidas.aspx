<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="facturasRecibidas.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.facturasRecibidas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder13" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/facturaEmpleado.css"/>

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
						<td> <a href="#"> <img src="/images/logPdf.png"></a></td>
					</tr>
		</table>
		
	</div>
	<!--Fin COLUMNA2-->


</div>

</asp:Content>
