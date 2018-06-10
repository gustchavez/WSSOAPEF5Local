<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminMostrarFacturas.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminMostrarFacturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/AdminMostrarFacturas.css">


    <form id="form1" runat="server">
        
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
