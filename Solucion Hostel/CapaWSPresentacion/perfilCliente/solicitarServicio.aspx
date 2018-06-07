<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="solicitarServicio.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.solicitarServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/servicioCliente.css">


<form id="form1" runat="server">

    	<div class="columna1">
				
			<h2>Solicitud de Ingreso</h2>

			<div class="contenido">				
				Fecha Ingreso <br>
				<asp:TextBox ID="TextBox1" TextMode="Date" runat="server" CssClass="CasillaFecha"></asp:TextBox>
			<div class="contenido">				
				Fecha Salida <br>
				<asp:TextBox ID="TextBox2" TextMode="Date" runat="server" CssClass="CasillaFecha"></asp:TextBox>
			</div>

			<div class="contenido">				
				Total de días <asp:TextBox ID="TextBox3" CssClass="Casilladias" runat="server"></asp:TextBox>
			</div>

			<div class="contenido">				
				Nº Personas <asp:TextBox ID="TextBox4" CssClass="Casilladias" runat="server"></asp:TextBox>
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
						<td><asp:TextBox ID="TextBox5" runat="server" CssClass="CasillaEnvio" BorderColor="#55828b" BorderStyle="solid"></asp:TextBox></td>
						<td><asp:TextBox ID="TextBox6" runat="server" CssClass="Boton2personas" TextMode="Number"></asp:TextBox></td>

					</tr>
					<tr>
						<td>Habitación 3 personas</td>
                        <td><asp:TextBox ID="TextBox7" runat="server" CssClass="CasillaEnvio" BorderColor="#e94f37" BorderStyle="solid"></asp:TextBox></td>
						<td><asp:TextBox ID="TextBox8" runat="server" CssClass="Boton3personas" TextMode="Number"></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 6 personas</td>
                        <td><asp:TextBox ID="TextBox9" runat="server" CssClass="CasillaEnvio" BorderColor="#3f88c5" BorderStyle="solid"></asp:TextBox></td>
						<td><asp:TextBox ID="TextBox10" runat="server" CssClass="Boton6personas" TextMode="Number"></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación individual</td>
                        <td><asp:TextBox ID="TextBox11" runat="server" CssClass="CasillaEnvio" BorderColor="#AB4E68" BorderStyle="solid"></asp:TextBox></td>
						<td><asp:TextBox ID="TextBox12" runat="server" CssClass="BotonIndividual" TextMode="Number"></asp:TextBox></td>
					</tr>
				</table>
			</div>

			<br>
			<hr>
			<br>

			<div class="contenido">				
				<b> Personas con habitación: </b><asp:TextBox ID="TextBox13" runat="server" CssClass="CasillaPersonas"></asp:TextBox>
			</div>
			<div class="casillaTotal">
				 <asp:Button ID="Button1" runat="server" Text="Siguiente" CssClass="SubmitEnviar"/>
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
