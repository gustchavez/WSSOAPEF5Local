<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="solicitarServicio.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.solicitarServicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <link rel="stylesheet" type="text/css" href="/scripts/servicioCliente.css">
        <script src="/scripts/mostrar.js"></script>
        <script src="/scripts/jquery.min.js"></script>

       <script type="text/javascript">
        function autenticarme() {
            var habitacion1 = document.getElementById('<%= individual.ClientID %>').value;
            var habitacion2 = document.getElementById('<%= doble.ClientID %>').value;
            var habitacion3 = document.getElementById('<%= triple.ClientID %>').value;
            var habitacion4 = document.getElementById('<%= sectuple.ClientID %>').value;

            if (habitacion1 == 0) {
                $('#IngresoPersonas1').fadeOut(1000);
                $('#IngresoPersonas2').fadeOut(1000);
                $('#IngresoPersonas3').fadeOut(1000);
                $('#IngresoPersonas4').fadeOut(1000);
            } else if (habitacion1 == 1) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeOut(1000);
                $('#IngresoPersonas3').fadeOut(1000);
                $('#IngresoPersonas4').fadeOut(1000);
            } else if (habitacion1 == 2) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeOut(1000);
                $('#IngresoPersonas4').fadeOut(1000);
            } else if (habitacion1 == 3) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeIn(1000);
                $('#IngresoPersonas4').fadeOut(1000);
            } else if (habitacion1 == 4) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeIn(1000);
                $('#IngresoPersonas4').fadeIn(1000);
            }

            if (habitacion2 == 0) {
                $('#IngresoPersonas5').fadeOut(1000);
                $('#IngresoPersonas6').fadeOut(1000);
                $('#IngresoPersonas7').fadeOut(1000);
                $('#IngresoPersonas8').fadeOut(1000);
            } else if (habitacion2 == 1) {
                $('#IngresoPersonas5').fadeIn(1000);
                $('#IngresoPersonas6').fadeOut(1000);
                $('#IngresoPersonas7').fadeOut(1000);
                $('#IngresoPersonas8').fadeOut(1000);
            } else if (habitacion2 == 2) {
                $('#IngresoPersonas5').fadeIn(1000);
                $('#IngresoPersonas6').fadeIn(1000);
                $('#IngresoPersonas7').fadeOut(1000);
                $('#IngresoPersonas8').fadeOut(1000);
            } else if (habitacion2 == 3) {
                $('#IngresoPersonas5').fadeIn(1000);
                $('#IngresoPersonas6').fadeIn(1000);
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeOut(1000);
            } else if (habitacion2 == 4) {
                $('#IngresoPersonas5').fadeIn(1000);
                $('#IngresoPersonas6').fadeIn(1000);
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeIn(1000);
            }

            if (habitacion3 == 0) {
                $('#IngresoPersonas9').fadeOut(1000);
                $('#IngresoPersonas10').fadeOut(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion3 == 1) {
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeOut(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion3 == 2) {
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeIn(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion3 == 3) {
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeIn(1000);
                $('#IngresoPersonas11').fadeIn(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion3 == 4) {
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeIn(1000);
                $('#IngresoPersonas11').fadeIn(1000);
                $('#IngresoPersonas12').fadeIn(1000);
            }

            if (habitacion4 == 0) {
                $('#IngresoPersonas13').fadeOut(1000);
                $('#IngresoPersonas14').fadeOut(1000);
                $('#IngresoPersonas15').fadeOut(1000);
                $('#IngresoPersonas16').fadeOut(1000);
            } else if (habitacion4 == 1) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeOut(1000);
                $('#IngresoPersonas15').fadeOut(1000);
                $('#IngresoPersonas16').fadeOut(1000);
            } else if (habitacion4 == 2) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeOut(1000);
                $('#IngresoPersonas16').fadeOut(1000);
            } else if (habitacion4 == 3) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeIn(1000);
                $('#IngresoPersonas16').fadeOut(1000);
            } else if (habitacion4 == 4) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeIn(1000);
                $('#IngresoPersonas16').fadeIn(1000);
            }
        return false;
             }
        </script>

   
    <form id="form1" runat="server">

	<!--Fin Menu-->
	<div class="columna1v1">
			
			<h2>Solicitud de Ingreso</h2>

			<div class="contenido">				
				Fecha Ingreso <br>
				  <asp:TextBox ID="txtFechaIngreso" runat="server" TextMode="Date" CssClass="CasillaFecha" AutoPostBack="True" OnTextChanged="txtFechaIngreso_TextChanged1" value="System.DateTime.Today" ></asp:TextBox>  </div>
			<div class="contenido">				
				Fecha Salida <br>
				 <asp:TextBox ID="txtFechaEgreso" runat="server" TextMode="Date" CssClass="CasillaFecha" Enabled="true"  AutoPostBack="True" OnTextChanged="txtFechaEgreso_TextChanged"></asp:TextBox> 
			</div>

			<div class="contenido">				
				Total de días  <asp:TextBox ID="txtRegistroDias" runat="server" CssClass="Casilladias" Enabled="false" value="1" ></asp:TextBox>
			</div>

			<div class="contenido">				
				Nº Personas <asp:TextBox ID="txtNpersonas" runat="server" CssClass="Casilladias" value="0"></asp:TextBox>
			</div>

			<div class="contenido">
				<table>
					<tr>
						<td></td>
						<th>Disponible</th>
						<th>Cuantas Habitaciones</th>
					</tr>
					<tr>
						<td>Habitación individual</td>
                        <td><asp:TextBox ID="txtCantHabDispSim" runat="server" CssClass="CasillaEnvio" BorderColor="#AB4E68" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="individual" TextMode="Number" runat="server" Max="4" min="0" CssClass="BotonIndividual" value="0" AutoPostBack="True" OnTextChanged="individual_TextChanged"></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 2 personas</td>
                        <td><asp:TextBox ID="txtCantHabDispDob" runat="server"  CssClass="CasillaEnvio" BorderColor="#55828b" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="doble" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton2personas" value="0" AutoPostBack="True" OnTextChanged="doble_TextChanged" ></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 3 personas</td>
                        <td><asp:TextBox ID="txtCantHabDispTri" runat="server"  CssClass="CasillaEnvio" BorderColor="#e94f37" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="triple" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton3personas" value="0" AutoPostBack="True" OnTextChanged="triple_TextChanged"></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 6 personas</td>
                        <td><asp:TextBox ID="txtCantHabDispSec" runat="server"  CssClass="CasillaEnvio" BorderColor="#3f88c5" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="sectuple" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton6personas" value="0" AutoPostBack="True" OnTextChanged="sectuple_TextChanged"></asp:TextBox></td>
					</tr>	
				</table>
			</div>

			<br>
			<hr>
			<br>

			<div class="contenido">				
				<b> Personas con habitación: </b> <asp:TextBox ID="txtPersonasHabitacion" runat="server" value="0" Enabled="false" CssClass="CasillaPersonas"></asp:TextBox>
			</div>
			<div class="casillaTotal">
               <asp:Button ID="MostrarCasillas" runat="server" Text="Ingresar Personas"  CssClass="SubmitTotal" OnClientClick="return autenticarme();" />
			</div>
	</div>

	<!--Fin COLUMNA1-->
	<div class="columna2">
		<h2>Ingreso de Personas</h2>
		<div class="IngresoPersonas1" ID="IngresoPersonas1">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutIndividual1" runat="server" CssClass="CasillaPersona" placeholder="Ingrese Rut"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual1" runat="server" CssClass="CasillaPersona" placeholder=" Ingrese Nombre"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual1" runat="server" CssClass="CasillaPersona" placeholder="Ingrese Apellido"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroIndividual1" runat="server" CssClass="CasillaPersona" value="reserva pagina"></asp:TextBox>
            </div>
            <div class="OpcionComida">                
                <asp:DropDownList ID="ddlComidaTipoServIndividual1" runat="server" CssClass="comidas">
                     <asp:ListItem >Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
		<div class="IngresoPersonas1" id="IngresoPersonas2">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutIndividual2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroIndividual2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServIndividual2" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas1" id="IngresoPersonas3">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutIndividual3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroIndividual3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServIndividual3" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas1" id="IngresoPersonas4">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutIndividual4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroIndividual4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServIndividual4" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <!--Fin COLUMNA1-->
	

		<div class="IngresoPersonas2" id="IngresoPersonas5">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble1" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble2" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas6">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble3" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble4" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas7">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble5" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble6" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas8">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble7" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroDoble8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServDoble8" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
               <!--Fin COLUMNA1-->
        <div class="IngresoPersonas3" id="IngresoPersonas9">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple1" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple2" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
                            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple3" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas10">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple4" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple5" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple6" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas11">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple7" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple8" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple9" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas12">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple10" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple11" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtroTriple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServTiple12" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <!--Fin COLUMNA1-->
		<div class="IngresoPersonas4" id="IngresoPersonas13">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple1" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple2" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple3" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple4" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas4" id="IngresoPersonas14">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple5" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple6" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple7" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple8" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
    	<div class="IngresoPersonas4" id="IngresoPersonas15">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutSectuple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple9" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple10" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple11" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple12" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas4" id="IngresoPersonas16">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutSectuple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple13" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple14" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple15" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutSectuple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreSectuple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoSectuple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtOtro16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlComidaTipoServSectuple16" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
        </div>
    </div>
	<!--Fin COLUMNA2-->
    <div class="columna3">            
        <div class="casillaTotal">			
            <asp:Button ID="BtnSiguiente" runat="server" Text="Siguiente"  CssClass="SubmitTotal" OnClick="BtnSiguiente_Click" Enabled="true"/>
        </div>
    </div>
</form>
</asp:Content>