<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="solicitarServicio.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.solicitarServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/servicioCliente.css">


<form id="form1" runat="server">

    	<div class="columna1">
				
			<h2>Solicitud de Ingreso</h2>

			<div class="contenido">				
				Fecha Ingreso <br>
				<input type="date" name="" class="CasillaFecha" > </div>
			<div class="contenido">				
				Fecha Salida <br>
				<input type="date" name="" class="CasillaFecha">
			</div>

			<div class="contenido">				
				Total de días <input type="text" name="" class="Casilladias" disabled>
			</div>

			<div class="contenido">				
				Nº Personas <input type="number" name="" class="Casilladias">
			</div>

			<div class="contenido">
				<table>
					<tr>
						<td></td>
						<th>Disponible</th>
						<th>Cuantas Habitaciones</th>

					</tr>
					<tr>
						<td>Habitación 2 personas</td>
						<td><input type="text" name="" class="CasillaEnvio" style="border-color: #55828b; border-style: solid;"  disabled></td>
						<td><input type="number" class="Boton2personas" name="" value=""></td>

					</tr>
					<tr>
						<td>Habitación 3 personas</td>
						<td><input type="text" name="" class="CasillaEnvio" style="border-color: #e94f37; border-style: solid;" disabled></td>
						<td><input type="number" class="Boton3personas" name="" value=""></td>
					</tr>
					<tr>
						<td>Habitación 6 personas</td>
						<td><input type="text" name="" class="CasillaEnvio" style="border-color: #3f88c5; border-style: solid;" disabled></td>
						<td><input type="number" class="Boton6personas" name="" value=""></td>
					</tr>
					<tr>
						<td>Habitación individual</td>
						<td><input type="text" name="" class="CasillaEnvio" style="border-color: #AB4E68; border-style: solid;" disabled></td>
						<td><input type="number" class="BotonIndividual" name="" value=""></td>
					</tr>
				</table>
			</div>

			<br>
			<hr>
			<br>

			<div class="contenido">				
				<b> Personas con habitación: </b><input type="text" name="" class="CasillaPersonas" disabled>
			</div>
			<div class="casillaTotal">
				<input type="submit" name="" class="SubmitEnviar" value="Siguiente">
			</div>
	
	</div>
	<!--Fin COLUMNA1-->
	<div class="columna2">
		<h2>Ingreso de Personas</h2><br>
		<div class="IngresoPersonas1" id="IngresoPersonas1">
				
				<div class="Casilla2-1">
					
					<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Rut">
				</div>
				<div class="Casilla2-1">
					
					<input type="text" name="" class="CasillaPersona" placeholder="Nombre">
				</div>
				<div class="Casilla2-1">
					
					<input type="text" name="" class="CasillaPersona" placeholder="Apellido Paterno">
				</div>
				<div class="Casilla2-1">
					
					<input type="text" name="" class="CasillaPersona" placeholder="Apellido Materno">
				</div>

				<div class="OpcionComida">					
					<select class="comidas">
						<option value="">Seleccione un plato</option>
						<option>Comida 1</option>
						<option>Comida 2</option>
						<option>Comida 3</option>
						<option>Comida 4</option>
					</select>
				</div>
				<div class="Casilla2-1">
					<label style="color: #AB4E68;">Habitación individual $7.500</label>
				</div>
		</div>
	</div>
	<!--Fin COLUMNA2-->
	<div class="columna3">
		

		<div class="linea2">

			<h2>Precios Finales</h2>

			<div class="casillaTotal">
				Habitación individual: <input type="text" name="" class="CasillaPrecio">
			</div>
			<div class="casillaTotal">
				Habitación 2 personas: <input type="text" name="" class="CasillaPrecio">
			</div>
			<div class="casillaTotal">
				Habitación 3 personas: <input type="text" name="" class="CasillaPrecio">
			</div>
			<div class="casillaTotal">
				Habitación 6 personas: <input type="text" name="" class="CasillaPrecio">
			</div>
			<br>
			<hr>
			<br>

			<div class="casillaTotal">
				A pagar <input type="text" name="" class="CasillaPrecio">
			</div>
			<div class="casillaTotal">
				Descuento <input type="text" name="" class="CasillaPrecio">
			</div>

			<br>

			<hr>
			<br>

			<div class="casillaTotal">
				Total <input type="text" name="" class="CasillaPrecio">
			</div>


			<div class="casillaTotal">
				<input type="submit" name="" class="SubmitTotal">
			</div>

		</div>



	</div>
</form>


</asp:Content>
