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
	<div class="columna1">
			
			<h2>Solicitud de Ingreso</h2>

			<div class="contenido">				
				Fecha Ingreso <br>
				  <asp:TextBox ID="TextBox172" runat="server" TextMode="Date" CssClass="CasillaFecha"></asp:TextBox>  </div>
			<div class="contenido">				
				Fecha Salida <br>
				 <asp:TextBox ID="TextBox173" runat="server" TextMode="Date" CssClass="CasillaFecha"></asp:TextBox> 
			</div>

			<div class="contenido">				
				Total de días  <asp:TextBox ID="TextBox174" runat="server" CssClass="Casilladias"></asp:TextBox>
			</div>

			<div class="contenido">				
				Nº Personas <asp:TextBox ID="TextBox175" runat="server" CssClass="Casilladias"></asp:TextBox>
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
                        <td><asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaEnvio" BorderColor="#AB4E68" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="individual" TextMode="Number" runat="server" Max="4" min="0" CssClass="BotonIndividual" value="0"></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 2 personas</td>
                        <td><asp:TextBox ID="TextBox2" runat="server"  CssClass="CasillaEnvio" BorderColor="#55828b" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="doble" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton2personas" value="0" ></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 3 personas</td>
                        <td><asp:TextBox ID="TextBox3" runat="server"  CssClass="CasillaEnvio" BorderColor="#e94f37" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="triple" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton3personas" value="0"></asp:TextBox></td>
					</tr>
					<tr>
						<td>Habitación 4 personas</td>
                        <td><asp:TextBox ID="TextBox4" runat="server"  CssClass="CasillaEnvio" BorderColor="#3f88c5" BorderStyle="Solid" Enabled="false"></asp:TextBox></td>
                        <td><asp:TextBox ID="sectuple" runat="server" TextMode="Number" Max="4" min="0" CssClass="Boton6personas" value="0"></asp:TextBox></td>
					</tr>	
				</table>
			</div>

			<br>
			<hr>
			<br>

			<div class="contenido">				
				<b> Personas con habitación: </b> <asp:TextBox ID="TextBox176" runat="server" CssClass="CasillaPersonas"></asp:TextBox>
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
					 <asp:TextBox ID="TextBox5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox6" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox7" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox8" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
		<div class="IngresoPersonas1" id="IngresoPersonas2">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox9" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox10" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox11" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox12" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        <div class="IngresoPersonas1" id="IngresoPersonas3">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox13" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox14" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox15" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox16" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList3" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        <div class="IngresoPersonas1" id="IngresoPersonas4">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox17" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox18" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox19" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox20" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList4" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        <!--Fin COLUMNA1-->
	

		<div class="IngresoPersonas2" id="IngresoPersonas5">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox21" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox22" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox23" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox24" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList5" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox25" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox26" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox27" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox28" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList6" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas6">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox29" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox30" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox31" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox32" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList7" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox33" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox34" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox35" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox36" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList8" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas7">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox37" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox38" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox39" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox40" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList9" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox41" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox42" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox43" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox44" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList10" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        <div class="IngresoPersonas2" id="IngresoPersonas8">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox45" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox46" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox47" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox48" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList11" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox49" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox50" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox51" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox52" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList12" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
               <!--Fin COLUMNA1-->
         <div class="IngresoPersonas3" id="IngresoPersonas9">
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox53" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox54" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox55" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox56" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList13" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox57" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox58" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox59" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox60" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList14" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
                            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox85" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox86" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox87" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox88" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList21" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
         <div class="IngresoPersonas3" id="IngresoPersonas10">
                         	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox89" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox90" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox91" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox92" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList22" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox61" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox62" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox63" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox64" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList15" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox65" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox66" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox67" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox68" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList16" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
         <div class="IngresoPersonas3" id="IngresoPersonas11">
                         	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox93" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox94" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox95" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox96" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList23" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox69" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox70" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox71" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox72" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList17" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox73" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox74" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox75" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox76" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList18" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
         <div class="IngresoPersonas3" id="IngresoPersonas12">
                         	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox97" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox98" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox99" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox100" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList24" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox77" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox78" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox79" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox80" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList19" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox81" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox82" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox83" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox84" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList20" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
		   <!--Fin COLUMNA1-->
		   <div class="IngresoPersonas4" id="IngresoPersonas13">
               <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox113" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox114" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox115" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox116" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList28" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
                <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox101" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox102" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox103" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox104" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList25" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox105" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox106" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox107" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox108" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList26" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox109" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox110" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox111" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox112" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList27" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        	   <div class="IngresoPersonas4" id="IngresoPersonas14">
               <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox117" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox118" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox119" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox120" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList29" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
                <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox121" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox122" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox123" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox124" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList30" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox125" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox126" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox127" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox128" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList31" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox129" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox130" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox131" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox132" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList32" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        	   <div class="IngresoPersonas4" id="IngresoPersonas15">
               <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox133" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox134" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox135" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox136" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList33" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
                <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox137" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox138" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox139" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox140" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList34" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox141" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox142" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox143" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox144" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList35" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox145" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox146" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox147" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox148" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList36" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        	   <div class="IngresoPersonas4" id="IngresoPersonas16">
               <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox149" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox150" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox151" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox152" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList37" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
                <div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox153" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox154" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox155" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox156" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList38" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
				<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox157" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox158" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox159" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox160" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList39" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
            	<div class="Casilla2-1">					
					 <asp:TextBox ID="TextBox161" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox162" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox163" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="Casilla2-1">
					<asp:TextBox ID="TextBox164" runat="server" CssClass="CasillaPersona"></asp:TextBox>
				</div>
				<div class="OpcionComida">
                    <asp:DropDownList ID="DropDownList40" runat="server" CssClass="comidas">
                         <asp:ListItem Value="1">Selecciona un Plato</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                         <asp:ListItem Value="1">Plato 1</asp:ListItem>
                    </asp:DropDownList>                  				
				</div>
		</div>
        </div>
	<!--Fin COLUMNA2-->
        <div class="columna3">            
			<div class="casillaTotal">
			
                <asp:Button ID="Siguiente" runat="server" Text="Siguiente"  CssClass="SubmitTotal" OnClick="Siguiente_Click1"/>

            </div>
		</div>



</form>
</asp:Content>
