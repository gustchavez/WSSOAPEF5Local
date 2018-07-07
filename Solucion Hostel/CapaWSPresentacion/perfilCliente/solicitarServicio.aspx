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
            var habitacion4 = document.getElementById('<%= cuadruple.ClientID %>').value;

            if (habitacion1 == 0) {
                $('#IngresoPersonas1').fadeOut(1000);
                $('#IngresoPersonas2').fadeOut(1000);
                $('#IngresoPersonas3').fadeOut(1000);
                $('#IngresoPersonas4').fadeOut(1000);
                $('#IngresoPersonas5').fadeOut(1000);
                $('#IngresoPersonas6').fadeOut(1000);
            } else if (habitacion1 == 1) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeOut(1000);
                $('#IngresoPersonas3').fadeOut(1000);
                $('#IngresoPersonas4').fadeOut(1000);
                $('#IngresoPersonas5').fadeOut(1000);
                $('#IngresoPersonas6').fadeOut(1000);
            } else if (habitacion1 == 2) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeOut(1000);
                $('#IngresoPersonas4').fadeOut(1000);
                $('#IngresoPersonas5').fadeOut(1000);
                $('#IngresoPersonas6').fadeOut(1000);
            } else if (habitacion1 == 3) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeIn(1000);
                $('#IngresoPersonas4').fadeOut(1000);
                $('#IngresoPersonas5').fadeOut(1000);
                $('#IngresoPersonas6').fadeOut(1000);
            } else if (habitacion1 == 4) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeIn(1000);
                $('#IngresoPersonas4').fadeIn(1000);
                $('#IngresoPersonas5').fadeOut(1000);
                $('#IngresoPersonas6').fadeOut(1000);
            } else if (habitacion1 == 5) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeIn(1000);
                $('#IngresoPersonas4').fadeIn(1000);
                $('#IngresoPersonas5').fadeIn(1000);
                $('#IngresoPersonas6').fadeOut(1000);
            } else if (habitacion1 == 6) {
                $('#IngresoPersonas1').fadeIn(1000);
                $('#IngresoPersonas2').fadeIn(1000);
                $('#IngresoPersonas3').fadeIn(1000);
                $('#IngresoPersonas4').fadeIn(1000);
                $('#IngresoPersonas5').fadeIn(1000);
                $('#IngresoPersonas6').fadeIn(1000);
            }


            if (habitacion2 == 0) {
                $('#IngresoPersonas7').fadeOut(1000);
                $('#IngresoPersonas8').fadeOut(1000);
                $('#IngresoPersonas9').fadeOut(1000);
                $('#IngresoPersonas10').fadeOut(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion2 == 1) {
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeOut(1000);
                $('#IngresoPersonas9').fadeOut(1000);
                $('#IngresoPersonas10').fadeOut(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion2 == 2) {
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeIn(1000);
                $('#IngresoPersonas9').fadeOut(1000);
                $('#IngresoPersonas10').fadeOut(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion2 == 3) {
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeIn(1000);
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeOut(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion2 == 4) {
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeIn(1000);
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeIn(1000);
                $('#IngresoPersonas11').fadeOut(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion2 == 5) {
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeIn(1000);
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeIn(1000);
                $('#IngresoPersonas11').fadeIn(1000);
                $('#IngresoPersonas12').fadeOut(1000);
            } else if (habitacion2 == 6) {
                $('#IngresoPersonas7').fadeIn(1000);
                $('#IngresoPersonas8').fadeIn(1000);
                $('#IngresoPersonas9').fadeIn(1000);
                $('#IngresoPersonas10').fadeIn(1000);
                $('#IngresoPersonas11').fadeIn(1000);
                $('#IngresoPersonas12').fadeIn(1000);
            }

            if (habitacion3 == 0) {
                $('#IngresoPersonas13').fadeOut(1000);
                $('#IngresoPersonas14').fadeOut(1000);
                $('#IngresoPersonas15').fadeOut(1000);
                $('#IngresoPersonas16').fadeOut(1000);
                $('#IngresoPersonas17').fadeOut(1000);
            } else if (habitacion3 == 1) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeOut(1000);
                $('#IngresoPersonas15').fadeOut(1000);
                $('#IngresoPersonas16').fadeOut(1000);
                $('#IngresoPersonas17').fadeOut(1000);
            } else if (habitacion3 == 2) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeOut(1000);
                $('#IngresoPersonas16').fadeOut(1000);
                $('#IngresoPersonas17').fadeOut(1000);
            } else if (habitacion3 == 3) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeIn(1000);
                $('#IngresoPersonas16').fadeOut(1000);
                $('#IngresoPersonas17').fadeOut(1000);
            } else if (habitacion3 == 4) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeIn(1000);
                $('#IngresoPersonas16').fadeIn(1000);
                $('#IngresoPersonas17').fadeOut(1000);
            } else if (habitacion3 == 5) {
                $('#IngresoPersonas13').fadeIn(1000);
                $('#IngresoPersonas14').fadeIn(1000);
                $('#IngresoPersonas15').fadeIn(1000);
                $('#IngresoPersonas16').fadeIn(1000);
                $('#IngresoPersonas17').fadeIn(1000);
            }

            if (habitacion4 == 0) {
                $('#IngresoPersonas18').fadeOut(1000);
                $('#IngresoPersonas19').fadeOut(1000);
                $('#IngresoPersonas20').fadeOut(1000);
                $('#IngresoPersonas21').fadeOut(1000);
            } else if (habitacion4 == 1) {
                $('#IngresoPersonas18').fadeIn(1000);
                $('#IngresoPersonas19').fadeOut(1000);
                $('#IngresoPersonas20').fadeOut(1000);
                $('#IngresoPersonas21').fadeOut(1000);
            } else if (habitacion4 == 2) {
                $('#IngresoPersonas18').fadeIn(1000);
                $('#IngresoPersonas19').fadeIn(1000);
                $('#IngresoPersonas20').fadeOut(1000);
                $('#IngresoPersonas21').fadeOut(1000);
            } else if (habitacion4 == 3) {
                $('#IngresoPersonas18').fadeIn(1000);
                $('#IngresoPersonas19').fadeIn(1000);
                $('#IngresoPersonas20').fadeIn(1000);
                $('#IngresoPersonas21').fadeOut(1000);
            } else if (habitacion4 == 4) {
                $('#IngresoPersonas18').fadeIn(1000);
                $('#IngresoPersonas19').fadeIn(1000);
                $('#IngresoPersonas20').fadeIn(1000);
                $('#IngresoPersonas21').fadeIn(1000);
            }
        return false;
             }
        </script>

   
    <form id="form1" runat="server">

	<!--Fin Menu-->
	<div class="columna1v1">
		
        <h2>Solicitud de Ingreso</h2>
        <h5></h5>
        <div class="contenido">
            Fecha Ingreso <br>
            <asp:TextBox ID="txtFechaIngreso" runat="server" TextMode="Date" CssClass="CasillaFecha" AutoPostBack="True" OnTextChanged="txtFechaIngreso_TextChanged" ></asp:TextBox>  </div>
            <%--<asp:RangeValidator ID="Range1" Type="Date" Format = "MM/DD/YYYY" Display="Dynamic" runat="server" ErrorMessage="Fecha invalida" ControlToValidate="txtFechaIngreso" ></asp:RangeValidator>--%>
        <div class="contenido">				
            Fecha Salida <br>
            <asp:TextBox ID="txtFechaEgreso" runat="server" TextMode="Date" CssClass="CasillaFecha"  OnTextChanged="txtFechaEgreso_TextChanged1" AutoPostBack="True"></asp:TextBox> 
            <%--<asp:RangeValidator ID="Range2" Type="Date" Format = "MM/DD/YYYY" Display="Dynamic" runat="server" ErrorMessage="Fecha invalida" ControlToValidate="txtFechaEgreso" ></asp:RangeValidator>--%>
        </div>

        <div class="contenido">				
            Total de días  <asp:TextBox ID="txtRegistroDias" runat="server" min="0" CssClass="Casilladias" Enabled="false" ></asp:TextBox>
        </div>

        <div class="contenido">				
            Nº Personas <asp:TextBox ID="txtNpersonas" TextMode="Number" runat="server" CssClass="Casilladias" OnTextChanged="txtNpersonas_TextChanged" AutoPostBack="True" value=0></asp:TextBox>
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
                    <td><asp:TextBox ID="individual" TextMode="Number" runat="server" Max="6" min="0" CssClass="BotonIndividual" value="0" AutoPostBack="True" OnTextChanged="individual_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Habitación 2 personas</td>
                    <td><asp:TextBox ID="txtCantHabDispDob" runat="server"  CssClass="CasillaEnvio" BorderColor="#55828b" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                    <td><asp:TextBox ID="doble" runat="server" TextMode="Number" Max="6" min="0" CssClass="Boton2personas" value="0" AutoPostBack="True" OnTextChanged="doble_TextChanged" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Habitación 3 personas</td>
                    <td><asp:TextBox ID="txtCantHabDispTri" runat="server"  CssClass="CasillaEnvio" BorderColor="#e94f37" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                    <td><asp:TextBox ID="triple" runat="server" TextMode="Number" Max="5" min="0" CssClass="Boton3personas" value="0" AutoPostBack="True" OnTextChanged="triple_TextChanged"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Habitación 4 personas</td>
                    <td><asp:TextBox ID="txtCantHabDispCua" runat="server"  CssClass="CasillaEnvio" BorderColor="#3f88c5" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                    <td><asp:TextBox ID="cuadruple" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton6personas" value="0" AutoPostBack="True" OnTextChanged="cuadruple_TextChanged"></asp:TextBox></td>
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
            <asp:Button ID="MostrarCasillas" runat="server" Text="Ingresar Personas"  CssClass="SubmitTotal" OnClientClick="return autenticarme();" OnClick="MostrarCasillas_Click" />
        </div>

	</div>

	<!--Fin COLUMNA1-->
	<div class="columna2">
		<h2>Ingreso de Personas</h2>
		<div class="IngresoPersonas1" ID="IngresoPersonas1">
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutIndividual1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsIndividual1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComIndividual1" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsIndividual2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComIndividual2" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsIndividual3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComIndividual3" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsIndividual4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComIndividual4" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas1" id="IngresoPersonas5">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutIndividual5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsIndividual5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComIndividual5" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas1" id="IngresoPersonas6">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutIndividual6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreIndividual6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoIndividual6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsIndividual6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComIndividual6" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <!--Fin COLUMNA1-->	

		<div class="IngresoPersonas2" id="IngresoPersonas7">
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
                <asp:TextBox ID="txtAlojaObsDoble1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble1" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsDoble2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble2" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas8">
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
                <asp:TextBox ID="txtAlojaObsDoble3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble3" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsDoble4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble4" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas9">
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
                <asp:TextBox ID="txtAlojaObsDoble5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble5" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsDoble6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble6" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas10">
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
                <asp:TextBox ID="txtAlojaObsDoble7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble7" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsDoble8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble8" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
         <div class="IngresoPersonas2" id="IngresoPersonas11">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutDoble9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsDoble9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble9" runat="server" CssClass="comidas">
                   <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutDoble10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsDoble10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble10" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
         <div class="IngresoPersonas2" id="IngresoPersonas12">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutDoble11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsDoble11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble11" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutDoble12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreDoble12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoDoble12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsDoble12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComDoble12" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <!--Fin COLUMNA1-->
        <div class="IngresoPersonas3" id="IngresoPersonas13">
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
                <asp:TextBox ID="txtAlojaObsTriple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple1" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple2" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple3" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas14">
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
                <asp:TextBox ID="txtAlojaObsTriple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple4" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple5" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple6" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas15">
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
                <asp:TextBox ID="txtAlojaObsTriple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple7" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple8" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple9" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas16">
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
                <asp:TextBox ID="txtAlojaObsTriple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple10" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple11" runat="server" CssClass="comidas">
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
                <asp:TextBox ID="txtAlojaObsTriple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple12" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas3" id="IngresoPersonas17">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutTriple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsTriple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple13" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsTriple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple14" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutTriple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreTriple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoTriple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsTriple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComTriple15" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
		<!--Fin COLUMNA1-->
		<div class="IngresoPersonas4" id="IngresoPersonas18">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple1" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple2" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple3" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutCuadruple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple4" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas4" id="IngresoPersonas19">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple5" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple6" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple7" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple8" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas4" id="IngresoPersonas20">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple9" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple10" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple11" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple12" runat="server" CssClass="comidas">
                    <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
        <div class="IngresoPersonas4" id="IngresoPersonas21">
            <div class="Casilla2-1">					
                <asp:TextBox ID="txtRutCuadruple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple13" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutCuadruple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple14" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutCuadruple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple15" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
            <div class="Casilla2-1">					
                 <asp:TextBox ID="txtRutCuadruple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtNombreCuadruple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtApellidoCuadruple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:TextBox ID="txtAlojaObsCuadruple16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="OpcionComida">
                <asp:DropDownList ID="ddlTipoServComCuadruple16" runat="server" CssClass="comidas">
                     <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                </asp:DropDownList>                  				
            </div>
		</div>
    </div>
	<!--Fin COLUMNA2-->
    <div class="columna3">            
        <div class="casillaTotal">
            <asp:Button ID="BtnSiguiente" runat="server" Text="Confirmar Personas Ingresadas"  CssClass="SubmitTotal" OnClick="BtnSiguiente_Click" Enabled="true"/>
        </div>
    </div>
</form>
</asp:Content>
