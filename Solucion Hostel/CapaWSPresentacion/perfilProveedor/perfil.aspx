<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/perfilCliente.css">


    <form id="form2" runat="server">
        
	    <div class="columna2">
		    <div class="ModificarDatos">
				
			    <h2>Modificar datos de empresa</h2><br>	

			    <div class="Casilla2-1">
			    <h4>Rut Empresa</h4>	
                    <asp:TextBox ID="txtRutEmpresa" runat="server" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
                </div>

			    <div class="Casilla2-1">
			    <h4>Razón Social</h4>	
                    <asp:TextBox ID="txtRazonSocial" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			    </div>
			    <div class="Casilla2-1">
			    <h4>Giro</h4>	
			        <asp:DropDownList ID="ddlRubro" CssClass="droplist" runat="server">
				        <asp:ListItem value="Selecciona un Giro" >Selecciona un Giro</asp:ListItem>
				        <asp:ListItem value="1">CULTIVOS EN GENERAL; CULTIVO DE PRODUCTOS DE MERCADO; HORTICULTURA</asp:ListItem>
				        <asp:ListItem value="2">CRÍA DE ANIMALES</asp:ListItem>
				        <asp:ListItem value="3">CULTIVO PROD. AGRÍCOLAS EN COMBINACIÓN CON CRÍA DE ANIMALES</asp:ListItem>
				        <asp:ListItem value="4">ACTIVIDADES DE SERVICIOS AGRÍCOLAS Y GANADEROS</asp:ListItem>
				        <asp:ListItem value="5">CAZA ORDINARIA Y MEDIANTE TRAMPAS, REPOBLACIÓN, ACT. SERVICIO CONEXAS</asp:ListItem>
				        <asp:ListItem value="6">SILVICULTURA, EXTRACCIÓN DE MADERA Y ACTIVIDADES DE SERVICIOS CONEXAS</asp:ListItem>
				        <asp:ListItem value="7">EXPLT. DE CRIADEROS DE PECES Y PROD. DEL MAR; SERVICIOS RELACIONADOS</asp:ListItem>
				        <asp:ListItem value="8">PESCA EXTRACTIVA: Y SERVICIOS RELACIONADOS</asp:ListItem>
				        <asp:ListItem value="9">EXTRACCIÓN, AGLOMERACIÓN DE CARBÓN DE PIEDRA, LIGNITO Y TURBA</asp:ListItem>
				        <asp:ListItem value="10">EXTRACCIÓN DE PETRÓLEO CRUDO Y GAS NATURAL; ACTIVIDADES RELACIONADAS</asp:ListItem>
				        <asp:ListItem value="11">EXTRACCIÓN DE MINERALES METALÍFEROS</asp:ListItem>
				        <asp:ListItem value="12">EXPLOTACIÓN DE MINAS Y CANTERAS</asp:ListItem>
				        <asp:ListItem value="13">PRODUCCIÓN, PROCESAMIENTO Y CONSERVACIÓN DE ALIMENTOS</asp:ListItem>
				        <asp:ListItem value="14">ELABORACIÓN DE PRODUCTOS LÁCTEOS</asp:ListItem>
				        <asp:ListItem value="15">ELAB. DE PROD. DE MOLINERÍA, ALMIDONES Y PROD. DERIVADOS DEL ALMIDÓN</asp:ListItem>
				        <asp:ListItem value="16">ELABORACIÓN DE OTROS PRODUCTOS ALIMENTICIOS</asp:ListItem>
				        <asp:ListItem value="17">ELABORACIÓN DE BEBIDAS</asp:ListItem>
				        <asp:ListItem value="18">ELABORACIÓN DE PRODUCTOS DEL TABACO</asp:ListItem>
				        <asp:ListItem value="19">HILANDERÍA, TEJEDURA Y ACABADO DE PRODUCTOS TEXTILES</asp:ListItem>
				        <asp:ListItem value="20">FABRICACIÓN DE OTROS PRODUCTOS TEXTILES</asp:ListItem>
				        <asp:ListItem value="21">FABRICACIÓN DE TEJIDOS Y ARTÍCULOS DE PUNTO Y GANCHILLO</asp:ListItem>
				        <asp:ListItem value="22">FABRICACIÓN DE PRENDAS DE VESTIR; EXCEPTO PRENDAS DE PIEL</asp:ListItem>
				        <asp:ListItem value="23">PROCESAMIENTO Y FABRICACIÓN DE ARTÍCULOS DE PIEL Y CUERO</asp:ListItem>
				        <asp:ListItem value="24">FABRICACIÓN DE CALZADO</asp:ListItem>
				        <asp:ListItem value="25">ASERRADO Y ACEPILLADURA DE MADERAS</asp:ListItem>
				        <asp:ListItem value="26">FAB. DE PRODUCTOS DE MADERA Y CORCHO,  PAJA Y DE MATERIALES TRENZABLES</asp:ListItem>
				        <asp:ListItem value="27">FABRICACIÓN DE PAPEL Y PRODUCTOS DEL PAPEL</asp:ListItem>
				        <asp:ListItem value="28">ACTIVIDADES DE EDICIÓN</asp:ListItem>
				        <asp:ListItem value="29">ACTIVIDADES DE IMPRESIÓN Y DE SERVICIOS CONEXOS</asp:ListItem>
				        <asp:ListItem value="30">FABRICACIÓN DE PRODUCTOS DE HORNOS COQUE Y DE REFINACIÓN DE PETRÓLEO</asp:ListItem>
				        <asp:ListItem value="31">ELABORACIÓN DE COMBUSTIBLE NUCLEAR</asp:ListItem>
				        <asp:ListItem value="32">FABRICACIÓN DE SUSTANCIAS QUÍMICAS BÁSICAS</asp:ListItem>
				        <asp:ListItem value="33">FABRICACIÓN DE OTROS PRODUCTOS QUÍMICOS</asp:ListItem>
				        <asp:ListItem value="34">FABRICACIÓN DE FIBRAS MANUFACTURADAS</asp:ListItem>
				        <asp:ListItem value="35">FABRICACIÓN DE PRODUCTOS DE CAUCHO</asp:ListItem>
				        <asp:ListItem value="36">FABRICACIÓN DE PRODUCTOS DE PLÁSTICO</asp:ListItem>
				        <asp:ListItem value="37">FABRICACIÓN DE VIDRIOS Y PRODUCTOS DE VIDRIO</asp:ListItem>
				        <asp:ListItem value="38">FABRICACIÓN DE PRODUCTOS MINERALES NO METÁLICOS N.C.P.</asp:ListItem>
				        <asp:ListItem value="39">INDUSTRIAS BÁSICAS DE HIERRO Y ACERO</asp:ListItem>
				        <asp:ListItem value="40">FAB. DE PRODUCTOS PRIMARIOS DE METALES PRECIOSOS Y METALES NO FERROSOS </asp:ListItem>
				        <asp:ListItem value="41">FUNDICIÓN DE METALES </asp:ListItem>
				        <asp:ListItem value="42">FAB. DE PROD. METÁLICOS PARA USO ESTRUCTURAL </asp:ListItem>
				        <asp:ListItem value="43">FAB. DE OTROS PROD. ELABORADOS DE METAL; ACT. DE TRABAJO DE METALES </asp:ListItem>
				        <asp:ListItem value="44">FABRICACIÓN DE MAQUINARIA DE USO GENERAL </asp:ListItem>
				        <asp:ListItem value="45">FABRICACIÓN DE MAQUINARIA DE USO ESPECIAL </asp:ListItem>
				        <asp:ListItem value="46">FABRICACIÓN DE APARATOS DE USO DOMÉSTICO N.C.P. </asp:ListItem>
				        <asp:ListItem value="47">FABRICACIÓN DE MAQUINARIA DE OFICINA, CONTABILIDAD E INFORMÁTICA </asp:ListItem>
				        <asp:ListItem value="48">FAB. Y REPARACIÓN DE MOTORES, GENERADORES Y TRANSFORMADORES ELÉCTRICOS </asp:ListItem>
				        <asp:ListItem value="49">FABRICACIÓN DE APARATOS DE DISTRIBUCIÓN Y CONTROL; SUS REPARACIONES </asp:ListItem>
				        <asp:ListItem value="50">FABRICACIÓN DE HILOS Y CABLES AISLADOS </asp:ListItem>
				        <asp:ListItem value="51">FABRICACIÓN DE ACUMULADORES DE PILAS Y BATERÍAS PRIMARIAS </asp:ListItem>
				        <asp:ListItem value="52">FABRICACIÓN Y REPARACIÓN DE LÁMPARAS Y EQUIPO DE ILUMINACIÓN </asp:ListItem>
				        <asp:ListItem value="53">FABRICACIÓN Y REPARACIÓN DE OTROS TIPOS DE EQUIPO ELÉCTRICO N.C.P. </asp:ListItem>
				        <asp:ListItem value="54">FABRICACIÓN DE COMPONENTES ELECTRÓNICOS; SUS REPARACIONES </asp:ListItem>
				        <asp:ListItem value="55">FAB. Y REPARACIÓN DE TRANSMISORES DE RADIO, TELEVISIÓN, TELEFONÍA </asp:ListItem>
				        <asp:ListItem value="56">FAB. DE RECEPTORES DE RADIO, TELEVISIÓN, APARATOS DE AUDIO/VÍDEO </asp:ListItem>
				        <asp:ListItem value="57">FAB. DE APARATOS E INSTRUMENTOS MÉDICOS Y PARA REALIZAR MEDICIONES </asp:ListItem>
				        <asp:ListItem value="58">FAB. Y REPARACIÓN DE INSTRUMENTOS DE ÓPTICA Y EQUIPO FOTOGRÁFICO </asp:ListItem>
				        <asp:ListItem value="59">FABRICACIÓN DE RELOJES </asp:ListItem>
				        <asp:ListItem value="60">FABRICACIÓN DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
				        <asp:ListItem value="61">CONSTRUCCIÓN Y REPARACIÓN DE BUQUES Y OTRAS EMBARCACIONES </asp:ListItem>
				        <asp:ListItem value="62">FAB. DE LOCOMOTORAS Y MATERIAL RODANTE PARA FERROCARRILES Y TRANVÍAS </asp:ListItem>
				        <asp:ListItem value="63">FABRICACIÓN DE AERONAVES Y NAVES ESPACIALES; SUS REPARACIONES </asp:ListItem>
				        <asp:ListItem value="64">FABRICACIÓN DE OTROS TIPOS DE EQUIPO DE TRANSPORTE N.C.P. </asp:ListItem>
				        <asp:ListItem value="65">FABRICACIÓN DE MUEBLES </asp:ListItem>
				        <asp:ListItem value="66">INDUSTRIAS MANUFACTURERAS N.C.P. </asp:ListItem>
				        <asp:ListItem value="67">RECICLAMIENTO DE DESPERDICIOS Y DESECHOS </asp:ListItem>
				        <asp:ListItem value="68">GENERACIÓN, CAPTACIÓN Y DISTRIBUCIÓN DE ENERGÍA ELÉCTRICA </asp:ListItem>
				        <asp:ListItem value="69">FABRICACIÓN DE GAS; DISTRIBUCIÓN DE COMBUSTIBLES GASEOSOS POR TUBERÍAS </asp:ListItem>
				        <asp:ListItem value="70">SUMINISTRO DE VAPOR Y AGUA CALIENTE </asp:ListItem>
				        <asp:ListItem value="71">CAPTACIÓN, DEPURACIÓN Y DISTRIBUCIÓN DE AGUA </asp:ListItem>
				        <asp:ListItem value="72">CONSTRUCCIÓN </asp:ListItem>
				        <asp:ListItem value="73">VENTA DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
				        <asp:ListItem value="74">MANTENIMIENTO Y REPARACIÓN DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
				        <asp:ListItem value="75">VENTA DE PARTES, PIEZAS Y ACCESORIOS DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
				        <asp:ListItem value="76">VENTA, MANTENIMIENTO Y REPARACIÓN DE MOTOCICLETAS Y SUS PARTES </asp:ListItem>
				        <asp:ListItem value="77">VENTA AL POR MENOR DE COMBUSTIBLE PARA AUTOMOTORES </asp:ListItem>
				        <asp:ListItem value="78">VENTA AL POR MAYOR A CAMBIO DE UNA RETRIBUCIÓN O POR CONTRATA </asp:ListItem>
				        <asp:ListItem value="79">VENTA AL POR MAYOR DE MATERIAS PRIMAS AGROPECUARIAS </asp:ListItem>
				        <asp:ListItem value="80">VENTA AL POR MAYOR DE ENSERES DOMÉSTICOS </asp:ListItem>
				        <asp:ListItem value="81">VENTA AL POR MAYOR DE PRODUCTOS INTERMEDIOS, DESECHOS NO AGROPECUARIOS </asp:ListItem>
				        <asp:ListItem value="82">VENTA AL POR MAYOR DE MAQUINARIA, EQUIPO Y MATERIALES CONEXOS </asp:ListItem>
				        <asp:ListItem value="83">VENTA AL POR MAYOR DE OTROS PRODUCTOS </asp:ListItem>
				        <asp:ListItem value="84">COMERCIO AL POR MENOR NO ESPECIALIZADO EN ALMACENES </asp:ListItem>
				        <asp:ListItem value="85">VENTA POR MENOR DE ALIMENTOS, BEBIDAS, TABACOS EN ALMC. ESPECIALIZADOS </asp:ListItem>
				        <asp:ListItem value="86">COMERCIO AL POR MENOR DE OTROS PROD. NUEVOS EN ALMC. ESPECIALIZADOS </asp:ListItem>
				        <asp:ListItem value="87">VENTA AL POR MENOR EN ALMACENES DE ARTÍCULOS USADOS </asp:ListItem>
				        <asp:ListItem value="88">COMERCIO AL POR MENOR NO REALIZADO EN ALMACENES </asp:ListItem>
				        <asp:ListItem value="89">REPARACIÓN DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS </asp:ListItem>
				        <asp:ListItem value="90">HOTELES; CAMPAMENTOS Y OTROS TIPOS DE HOSPEDAJE TEMPORAL </asp:ListItem>
				        <asp:ListItem value="91">RESTAURANTES, BARES Y CANTINAS </asp:ListItem>
				        <asp:ListItem value="92">TRANSPORTE POR FERROCARRILES </asp:ListItem>
				        <asp:ListItem value="93">OTROS TIPOS DE TRANSPORTE POR VÍA TERRESTRE </asp:ListItem>
				        <asp:ListItem value="94">TRANSPORTE POR TUBERÍAS </asp:ListItem>
				        <asp:ListItem value="95">TRANSPORTE MARÍTIMO Y DE CABOTAJE </asp:ListItem>
				        <asp:ListItem value="96">TRANSPORTE POR VÍAS DE NAVEGACIÓN INTERIORES </asp:ListItem>
				        <asp:ListItem value="97">TRANSPORTE POR VÍA AÉREA </asp:ListItem>
				        <asp:ListItem value="98">ACT. DE TRANSPORTE COMPLEMENTARIAS Y AUXILIARES; AGENCIAS DE VIAJE </asp:ListItem>
				        <asp:ListItem value="99">ACTIVIDADES POSTALES Y DE CORREO </asp:ListItem>
				        <asp:ListItem value="100">TELECOMUNICACIONES </asp:ListItem>
				        <asp:ListItem value="101">INTERMEDIACIÓN MONETARIA </asp:ListItem>
				        <asp:ListItem value="102">OTROS TIPOS DE INTERMEDIACIÓN FINANCIERA </asp:ListItem>
				        <asp:ListItem value="103">FINANCIACIÓN PLANES DE SEG. Y DE PENSIONES, EXCEPTO AFILIACIÓN OBLIG. </asp:ListItem>
				        <asp:ListItem value="104">ACT. AUX. DE LA INTERMEDIACIÓN FINANCIERA, EXCEPTO PLANES DE SEGUROS </asp:ListItem>
				        <asp:ListItem value="105">ACT. AUXILIARES DE FINANCIACIÓN DE PLANES DE SEGUROS Y DE PENSIONES </asp:ListItem>
				        <asp:ListItem value="106">ACTIVIDADES INMOBILIARIAS REALIZADAS CON BIENES PROPIOS O ARRENDADOS </asp:ListItem>
				        <asp:ListItem value="107">ACT. INMOBILIARIAS REALIZADAS A CAMBIO DE RETRIBUCIÓN O POR CONTRATA </asp:ListItem>
				        <asp:ListItem value="108">ALQUILER EQUIPO DE TRANSPORTE </asp:ListItem>
				        <asp:ListItem value="109">ALQUILER DE OTROS TIPOS DE MAQUINARIA Y EQUIPO </asp:ListItem>
				        <asp:ListItem value="110">ALQUILER DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS N.C.P. </asp:ListItem>
				        <asp:ListItem value="111">SERVICIOS INFORMÁTICOS </asp:ListItem>
				        <asp:ListItem value="112">MANTENIMIENTO Y REPARACIÓN DE MAQUINARIA DE OFICINA </asp:ListItem>
				        <asp:ListItem value="113">ACTIVIDADES DE INVESTIGACIONES Y DESARROLLO EXPERIMENTAL </asp:ListItem>
				        <asp:ListItem value="114">ACTIVIDADES JURÍDICAS Y DE ASESORAMIENTO EMPRESARIAL EN GENERAL </asp:ListItem>
				        <asp:ListItem value="115">ACTIVIDADES DE ARQUITECTURA E INGENIERÍA Y OTRAS ACTIVIDADES TÉCNICAS </asp:ListItem>
				        <asp:ListItem value="116">PUBLICIDAD </asp:ListItem>
				        <asp:ListItem value="117">ACT. EMPRESARIALES Y DE PROFESIONALES PRESTADAS A EMPRESAS N.C.P. </asp:ListItem>
				        <asp:ListItem value="118">GOBIERNO CENTRAL Y ADMINISTRACIÓN PÚBLICA </asp:ListItem>
				        <asp:ListItem value="119">ACTIVIDADES DE PLANES DE SEGURIDAD SOCIAL DE AFILIACIÓN OBLIGATORIA </asp:ListItem>
				        <asp:ListItem value="120">ENSEÑANZA PREESCOLAR, PRIMARIA, SECUNDARIA Y SUPERIOR ; PROFESORES </asp:ListItem>
				        <asp:ListItem value="121">ACTIVIDADES RELACIONADAS CON LA SALUD HUMANA </asp:ListItem>
				        <asp:ListItem value="122">ACTIVIDADES VETERINARIAS </asp:ListItem>
				        <asp:ListItem value="123">ACTIVIDADES DE SERVICIOS SOCIALES </asp:ListItem>
				        <asp:ListItem value="124">ELIMINACIÓN DE DESPERDICIOS Y AGUAS RESIDUALES, SANEAMIENTO </asp:ListItem>
				        <asp:ListItem value="125">ACT. DE ORGANIZACIONES EMPRESARIALES, PROFESIONALES Y DE EMPLEADORES </asp:ListItem>
				        <asp:ListItem value="126">ACTIVIDADES DE SINDICATOS Y DE OTRAS ORGANIZACIONES </asp:ListItem>
				        <asp:ListItem value="127">ACT. DE CINEMATOGRAFÍA, RADIO Y TV Y OTRAS ACT. DE ENTRETENIMIENTO </asp:ListItem>
				        <asp:ListItem value="128">ACTIVIDADES DE AGENCIAS DE NOTICIAS Y SERVICIOS PERIODÍSTICOS </asp:ListItem>
				        <asp:ListItem value="129">ACTIVIDADES DE BIBLIOTECAS, ARCHIVOS Y MUSEOS Y OTRAS ACT. CULTURALES </asp:ListItem>
				        <asp:ListItem value="130">ACTIVIDADES DEPORTIVAS Y OTRAS ACTIVIDADES DE ESPARCIMIENTO </asp:ListItem>
				        <asp:ListItem value="131">OTRAS ACTIVIDADES DE SERVICIOS </asp:ListItem>
				        <asp:ListItem value="132">CONSEJO DE ADMINISTRACIÓN DE EDIFICIOS Y CONDOMINIOS </asp:ListItem>
				        <asp:ListItem value="133">ORGANIZACIONES Y ÓRGANOS EXTRATERRITORIALES </asp:ListItem>  
			        </asp:DropDownList>			
			    </div>
			    <div class="Casilla2-1">
			    <h4>Dirección</h4>
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			    </div>
			    <div class="Casilla2-1">
			    <h4>Ciudad</h4>	
                    <asp:DropDownList ID="txtNombreCiudad" runat="server" CssClass="droplist">
                    </asp:DropDownList>
			    </div>
			    <div class="Casilla2-1">
				    <h4>Comuna</h4>					
                    <asp:DropDownList ID="ddlComunas" CssClass="droplist" runat="server">
					    <asp:ListItem value="">Seleccione una comuna</asp:ListItem>
					    <asp:ListItem value="1">Cerrillos</asp:ListItem>
					    <asp:ListItem value="2">Cerro Navia</asp:ListItem>
					    <asp:ListItem value="3">Conchalí</asp:ListItem>
					    <asp:ListItem value="4">El Bosque</asp:ListItem>
					    <asp:ListItem value="5">Estación Central</asp:ListItem>
					    <asp:ListItem value="6">Huechuraba</asp:ListItem>
					    <asp:ListItem value="7">Independencia</asp:ListItem>
					    <asp:ListItem value="8">La Cisterna</asp:ListItem>
					    <asp:ListItem value="9">La Florida</asp:ListItem>
					    <asp:ListItem value="10">La Granja</asp:ListItem>
					    <asp:ListItem value="11">La Pintana</asp:ListItem>
					    <asp:ListItem value="12">La Reina</asp:ListItem>
					    <asp:ListItem value="13">Las Condes</asp:ListItem>
					    <asp:ListItem value="14">Lo Barnechea</asp:ListItem>
					    <asp:ListItem value="15">Lo Espejo</asp:ListItem>
					    <asp:ListItem value="16">Lo Prado</asp:ListItem>
					    <asp:ListItem value="17">Macul</asp:ListItem>
					    <asp:ListItem value="18">Maipú</asp:ListItem>
					    <asp:ListItem value="19">Ñuñoa</asp:ListItem>
					    <asp:ListItem value="20">Padre Hurtado</asp:ListItem>
					    <asp:ListItem value="21">Pedro Aguirre Cerda</asp:ListItem>
					    <asp:ListItem value="22">Peñalolén</asp:ListItem>
					    <asp:ListItem value="23">Providencia</asp:ListItem>
					    <asp:ListItem value="24">Pudahuel</asp:ListItem>
					    <asp:ListItem value="25">Puente Alto</asp:ListItem>
					    <asp:ListItem value="26">Quilicura</asp:ListItem>
					    <asp:ListItem value="27">Quinta Normal</asp:ListItem>
					    <asp:ListItem value="28">Recoleta</asp:ListItem>
					    <asp:ListItem value="29">Renca</asp:ListItem>
					    <asp:ListItem value="30">San Bernardo</asp:ListItem>
					    <asp:ListItem value="31">San Joaquín</asp:ListItem>
					    <asp:ListItem value="32">San Miguel</asp:ListItem>
					    <asp:ListItem value="33">San Ramón</asp:ListItem>
					    <asp:ListItem value="34">Santiago</asp:ListItem>
					    <asp:ListItem value="35">Vitacura</asp:ListItem>
					    <asp:ListItem value="36">--Otra--</asp:ListItem>
                   </asp:DropDownList>
			    </div>
			    <div class="Casilla2-1">
			    <h4>Correo Electrónico</h4>
                    <asp:TextBox ID="txtCorreoElectronico" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			    </div>
			    <div class="Casilla2-1">
			    <h4>Teléfono</h4>	
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			    </div>
	    </div>


	    <div class="ModificarDatos2">
		    <div class="Casilla2-2">
		    <h4 style="color: white;">Nombre Usuario</h4>	
                <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
		    </div>
		    <div class="Casilla2-2">
		    <h4 style="color: white;">Nueva Contraseña</h4>	
                <asp:TextBox ID="txtContraseña" runat="server" CssClass="CasillaPersona"></asp:TextBox>
		    </div>
		    <div class="Casilla2-2">
                <asp:Button ID="Button1" runat="server" Text="Modificar Datos"  CssClass="SubmitTotal" OnClick="btnModificar_Click" OnClientClick="return valida();"/> 	
		    </div>
            <div class="Casilla2-2">
                <div class="error" id="error1"> Ingrese una razón social </div>
                <div class="error" id="error2"> Seleccione un Giro </div>
                <div class="error" id="error3"> Ingrese una dirección </div>
                <div class="error" id="error4"> Seleccione una ciudad </div>
                <div class="error" id="error5"> Seleccione una comuna </div>
                <div class="error" id="error6"> Ingrese un correo electrónico </div>
                <div class="error" id="error7"> Ingrese un número de telefono </div>
                <div class="error" id="error8"> Ingrese una contraseña </div>
            </div>
           
	    </div>
		
    </div>

    </form>


    <script src="/CondicionesJavascript/proveedorPerfil.js"></script>

    <!----VALIDACIONES 

<script type="text/javascript">
     function valida() 
     {      
         var razonSocial = document.getElementById('<%= txtRazonSocial.ClientID %>').value;
         var rubro = document.getElementById('<%= ddlRubro.ClientID %>').value;
         var direccion = document.getElementById('<%= txtDireccion.ClientID %>').value;
         var ciudad = document.getElementById('<%= txtNombreCiudad.ClientID %>').value;
         var comuna = document.getElementById('<%= ddlComunas.ClientID %>').value;
         var correo = document.getElementById('<%= txtCorreoElectronico.ClientID %>').value;
         var telefono = document.getElementById('<%= txtTelefono.ClientID %>').value;
         var contrasena = document.getElementById('<%= txtContraseña.ClientID %>').value;

         if (razonSocial == "" || razonSocial == null) {
             $('#error1').fadeIn(500);         
         } else {
             $('#error1').fadeOut(500); 
         }

         if (rubro == "" || rubro == null || rubro == "Selecciona un Giro") {
             $('#error2').fadeIn(500);
         } else {
             $('#error2').fadeOut(500);
         }

         if (direccion == "" || direccion == null || direccion == "Selecciona un Giro") {
             $('#error3').fadeIn(500);
         } else {
             $('#error3').fadeOut(500);
         }

         if (ciudad == "" || ciudad == null || ciudad == "Selecciona un Giro") {
             $('#error4').fadeIn(500);
         } else {
             $('#error4').fadeOut(500);
         }

         if (comuna == "" || comuna == null || comuna == "Selecciona un Giro") {
             $('#error5').fadeIn(500);
         } else {
             $('#error5').fadeOut(500);
         }

         if (correo == "" || correo == null || correo == "Selecciona un Giro") {
             $('#error6').fadeIn(500);
         } else {
             $('#error6').fadeOut(500);
         }

         if (telefono == "" || telefono == null || telefono == "Selecciona un Giro") {
             $('#error7').fadeIn(500);
         } else {
             $('#error7').fadeOut(500);
         }

         if (contrasena == "" || contrasena == null || contrasena == "Selecciona un Giro") {
             $('#error8').fadeIn(500);
         } else {
             $('#error8').fadeOut(500);
         }
         return false;
     }
 </script>
    ------->
</asp:Content>
