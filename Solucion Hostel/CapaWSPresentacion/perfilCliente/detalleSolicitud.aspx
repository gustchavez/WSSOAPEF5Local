<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="detalleSolicitud.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.detalleSolicitud" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/detalleCliente.css">


     <form id="form1" runat="server">
         
	<div class="columna2">		
		<div class="contenedor">
			<h3>Detalle de compra</h3>
			<hr>
			<br>
			<h4>Información</h4>
			<br>
			<table border="0" class="listaFactura">				
					<tr>
						<th>Fecha Ingreso:</th>
						<td><label>00/00/0000</label></td>
						<th>Total de días:</th>
						<td><label>0</label></td>
					</tr>
					<tr>
						<th>Fecha Salida:</th>
						<td><label>00/00/0000</label></td>
						<th>Nº Personas:</th>
						<td><label>0</label></td>
					</tr>
			</table>
			<br>
			<br>
			<h4>Total de Huespedes</h4>
			<br>
				<table border="0" class="listadoPersona">				
					<tr>
						<th>Rut</th>
						<th>Nombre</th>
						<th>Habitación</th>
						<th>Comedor</th>
						<th>Total</th>
					</tr>
					<tr>
						<td>Rut Persona</td>
						<td>Nombre Persona</td>
						<td>Normal</td>
						<td>Ejecutivo</td>
						<td>$00.000</td>
					</tr>
					<tr>
						<td>Rut Persona</td>
						<td>Nombre Persona</td>
						<td>Normal</td>
						<td>Ejecutivo</td>
						<td>$00.000</td>
					</tr>
					<tr>
						<td>Rut Persona</td>
						<td>Nombre Persona</td>
						<td>Normal</td>
						<td>Ejecutivo</td>
						<td>$00.000</td>
					</tr>
					<tr>
						<td>Rut Persona</td>
						<td>Nombre Persona</td>
						<td>Normal</td>
						<td>Ejecutivo</td>
						<td>$00.000</td>
					</tr>		
			</table>
			
		</div>	


		<table border="0" class="totales">				
			<tr>
				<th>A pagar: <label>$00.000</label></th>
				<th>Descuento: <label>$00.000</label></th>
				<th>Total: <label>$00.000</label></th>
			</tr>			
		</table>


			<input type="submit" name="" class="SubmitEnviar" value="Modificar compra">
			<input type="submit" name="" class="SubmitEnviar" value="Generar orden de compra">					
	</div>


    </form>

</asp:Content>
