<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfilIngreso.aspx.cs" Inherits="CapaWSPresentacion.PaginaComercial.perfilIngreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <link rel="stylesheet" type="text/css" href="/scripts/ingreso.css"/>

</head>
<body>
    <form id="formularioRegistro" runat="server" name="formularioRegistro">
  
    
        <!-- Crear Usuario -->


<div class="ContenedorPaginaIngreso">
	

	<div class="Contenedor-Registro">
		
			<h3 class="Contenido">REGISTRO</h3>

			<div class="Contenido">
				Rut Empresa <br/>
				 <asp:TextBox ID="rutEmpresa" runat="server"  CssClass="casilla"   ></asp:TextBox><br/>	
			</div>
			<div class="Contenido">
				Razón Social <br/>
				 <asp:TextBox ID="razonSocial" runat="server"  CssClass="casilla" ></asp:TextBox><br/>	
			</div>
			<div class="Contenido" >
				Giro <br/>
                <asp:DropDownList ID="giro" runat="server" CssClass="casilla">
                    <asp:ListItem Value="1">Selecciona un Giro</asp:ListItem>
                    <asp:ListItem Value="2">CULTIVOS EN GENERAL; CULTIVO DE PRODUCTOS DE MERCADO; HORTICULTURA</asp:ListItem>
                    <asp:ListItem Value="3">CRÍA DE ANIMALES</asp:ListItem>
                    <asp:ListItem Value="4">CULTIVO PROD. AGRÍCOLAS EN COMBINACIÓN CON CRÍA DE ANIMALES</asp:ListItem>
                    <asp:ListItem Value="5">ACTIVIDADES DE SERVICIOS AGRÍCOLAS Y GANADEROS</asp:ListItem>
                    <asp:ListItem Value="6">CAZA ORDINARIA Y MEDIANTE TRAMPAS, REPOBLACIÓN, ACT. SERVICIO CONEXAS</asp:ListItem>
                    <asp:ListItem Value="7">SILVICULTURA, EXTRACCIÓN DE MADERA Y ACTIVIDADES DE SERVICIOS CONEXAS</asp:ListItem>
                    <asp:ListItem Value="8">EXPLT. DE CRIADEROS DE PECES Y PROD. DEL MAR; SERVICIOS RELACIONADOS</asp:ListItem>
                    <asp:ListItem Value="9">PESCA EXTRACTIVA: Y SERVICIOS RELACIONADOS</asp:ListItem>
                    <asp:ListItem Value="10">EXTRACCIÓN, AGLOMERACIÓN DE CARBÓN DE PIEDRA, LIGNITO Y TURBA</asp:ListItem>
                    <asp:ListItem Value="11">EXTRACCIÓN DE PETRÓLEO CRUDO Y GAS NATURAL; ACTIVIDADES RELACIONADAS</asp:ListItem>
                    <asp:ListItem Value="12">EXTRACCIÓN DE MINERALES METALÍFEROS</asp:ListItem>
                    <asp:ListItem Value="13">EXPLOTACIÓN DE MINAS Y CANTERAS</asp:ListItem>
                    <asp:ListItem Value="14">PRODUCCIÓN, PROCESAMIENTO Y CONSERVACIÓN DE ALIMENTOS</asp:ListItem>
                    <asp:ListItem Value="15">ELABORACIÓN DE PRODUCTOS LÁCTEOS</asp:ListItem>
                    <asp:ListItem Value="16">ELAB. DE PROD. DE MOLINERÍA, ALMIDONES Y PROD. DERIVADOS DEL ALMIDÓN</asp:ListItem>
                    <asp:ListItem Value="17">ELABORACIÓN DE OTROS PRODUCTOS ALIMENTICIOS</asp:ListItem>
                    <asp:ListItem Value="18">ELABORACIÓN DE BEBIDAS</asp:ListItem>
                    <asp:ListItem Value="19">ELABORACIÓN DE PRODUCTOS DEL TABACO</asp:ListItem>
                    <asp:ListItem Value="20">HILANDERÍA, TEJEDURA Y ACABADO DE PRODUCTOS TEXTILES</asp:ListItem>
                    <asp:ListItem Value="21">FABRICACIÓN DE OTROS PRODUCTOS TEXTILES</asp:ListItem>
                    <asp:ListItem Value="22">FABRICACIÓN DE TEJIDOS Y ARTÍCULOS DE PUNTO Y GANCHILLO</asp:ListItem>
                    <asp:ListItem Value="23">FABRICACIÓN DE PRENDAS DE VESTIR; EXCEPTO PRENDAS DE PIEL</asp:ListItem>
                    <asp:ListItem Value="24">PROCESAMIENTO Y FABRICACIÓN DE ARTÍCULOS DE PIEL Y CUERO</asp:ListItem>
                    <asp:ListItem Value="25">FABRICACIÓN DE CALZADO</asp:ListItem>
                    <asp:ListItem Value="26">ASERRADO Y ACEPILLADURA DE MADERAS</asp:ListItem>
                    <asp:ListItem Value="27">FAB. DE PRODUCTOS DE MADERA Y CORCHO,  PAJA Y DE MATERIALES TRENZABLES</asp:ListItem>
                    <asp:ListItem Value="28">FABRICACIÓN DE PAPEL Y PRODUCTOS DEL PAPEL</asp:ListItem>
                    <asp:ListItem Value="29">ACTIVIDADES DE EDICIÓN</asp:ListItem>
                    <asp:ListItem Value="30">ACTIVIDADES DE IMPRESIÓN Y DE SERVICIOS CONEXOS</asp:ListItem>
                    <asp:ListItem Value="31">FABRICACIÓN DE PRODUCTOS DE HORNOS COQUE Y DE REFINACIÓN DE PETRÓLEO</asp:ListItem>
                    <asp:ListItem Value="32">ELABORACIÓN DE COMBUSTIBLE NUCLEAR</asp:ListItem>
                    <asp:ListItem Value="33">FABRICACIÓN DE SUSTANCIAS QUÍMICAS BÁSICAS</asp:ListItem>
                    <asp:ListItem Value="34">FABRICACIÓN DE OTROS PRODUCTOS QUÍMICOS</asp:ListItem>
                    <asp:ListItem Value="35">FABRICACIÓN DE FIBRAS MANUFACTURADAS</asp:ListItem>
                    <asp:ListItem Value="36">FABRICACIÓN DE PRODUCTOS DE CAUCHO</asp:ListItem>
                    <asp:ListItem Value="37">FABRICACIÓN DE PRODUCTOS DE PLÁSTICO</asp:ListItem>
                    <asp:ListItem Value="38">FABRICACIÓN DE VIDRIOS Y PRODUCTOS DE VIDRIO</asp:ListItem>
                    <asp:ListItem Value="39">FABRICACIÓN DE PRODUCTOS MINERALES NO METÁLICOS N.C.P.</asp:ListItem>
                    <asp:ListItem Value="40">INDUSTRIAS BÁSICAS DE HIERRO Y ACERO</asp:ListItem>
                    <asp:ListItem Value="41">FAB. DE PRODUCTOS PRIMARIOS DE METALES PRECIOSOS Y METALES NO FERROSOS </asp:ListItem>
                    <asp:ListItem Value="42">FUNDICIÓN DE METALES </asp:ListItem>
                    <asp:ListItem Value="43">FAB. DE PROD. METÁLICOS PARA USO ESTRUCTURAL </asp:ListItem>
                    <asp:ListItem Value="44">FAB. DE OTROS PROD. ELABORADOS DE METAL; ACT. DE TRABAJO DE METALES </asp:ListItem>
                    <asp:ListItem Value="45">FABRICACIÓN DE MAQUINARIA DE USO GENERAL </asp:ListItem>
                    <asp:ListItem Value="46">FABRICACIÓN DE MAQUINARIA DE USO ESPECIAL </asp:ListItem>
                    <asp:ListItem Value="47">FABRICACIÓN DE APARATOS DE USO DOMÉSTICO N.C.P. </asp:ListItem>
                    <asp:ListItem Value="48">FABRICACIÓN DE MAQUINARIA DE OFICINA, CONTABILIDAD E INFORMÁTICA </asp:ListItem>
                    <asp:ListItem Value="49">FAB. Y REPARACIÓN DE MOTORES, GENERADORES Y TRANSFORMADORES ELÉCTRICOS </asp:ListItem>
                    <asp:ListItem Value="50">FABRICACIÓN DE APARATOS DE DISTRIBUCIÓN Y CONTROL; SUS REPARACIONES </asp:ListItem>
                    <asp:ListItem Value="51">FABRICACIÓN DE HILOS Y CABLES AISLADOS </asp:ListItem>
                    <asp:ListItem Value="52">FABRICACIÓN DE ACUMULADORES DE PILAS Y BATERÍAS PRIMARIAS </asp:ListItem>
                    <asp:ListItem Value="53">FABRICACIÓN Y REPARACIÓN DE LÁMPARAS Y EQUIPO DE ILUMINACIÓN </asp:ListItem>
                    <asp:ListItem Value="54">FABRICACIÓN Y REPARACIÓN DE OTROS TIPOS DE EQUIPO ELÉCTRICO N.C.P. </asp:ListItem>
                    <asp:ListItem Value="55">FABRICACIÓN DE COMPONENTES ELECTRÓNICOS; SUS REPARACIONES </asp:ListItem>
                    <asp:ListItem Value="56">FAB. Y REPARACIÓN DE TRANSMISORES DE RADIO, TELEVISIÓN, TELEFONÍA </asp:ListItem>
                    <asp:ListItem Value="57">FAB. DE RECEPTORES DE RADIO, TELEVISIÓN, APARATOS DE AUDIO/VÍDEO </asp:ListItem>
                    <asp:ListItem Value="58">FAB. DE APARATOS E INSTRUMENTOS MÉDICOS Y PARA REALIZAR MEDICIONES </asp:ListItem>
                    <asp:ListItem Value="59">FAB. Y REPARACIÓN DE INSTRUMENTOS DE ÓPTICA Y EQUIPO FOTOGRÁFICO </asp:ListItem>
                    <asp:ListItem Value="60">FABRICACIÓN DE RELOJES </asp:ListItem>
                    <asp:ListItem Value="61">FABRICACIÓN DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem Value="62">CONSTRUCCIÓN Y REPARACIÓN DE BUQUES Y OTRAS EMBARCACIONES </asp:ListItem>
                    <asp:ListItem Value="63">FAB. DE LOCOMOTORAS Y MATERIAL RODANTE PARA FERROCARRILES Y TRANVÍAS </asp:ListItem>
                    <asp:ListItem Value="64">FABRICACIÓN DE AERONAVES Y NAVES ESPACIALES; SUS REPARACIONES </asp:ListItem>
                    <asp:ListItem Value="65">FABRICACIÓN DE OTROS TIPOS DE EQUIPO DE TRANSPORTE N.C.P. </asp:ListItem>
                    <asp:ListItem Value="66">FABRICACIÓN DE MUEBLES </asp:ListItem>
                    <asp:ListItem Value="67">INDUSTRIAS MANUFACTURERAS N.C.P. </asp:ListItem>
                    <asp:ListItem Value="68">RECICLAMIENTO DE DESPERDICIOS Y DESECHOS </asp:ListItem>
                    <asp:ListItem Value="69">GENERACIÓN, CAPTACIÓN Y DISTRIBUCIÓN DE ENERGÍA ELÉCTRICA </asp:ListItem>
                    <asp:ListItem Value="70">FABRICACIÓN DE GAS; DISTRIBUCIÓN DE COMBUSTIBLES GASEOSOS POR TUBERÍAS </asp:ListItem>
                    <asp:ListItem Value="71">SUMINISTRO DE VAPOR Y AGUA CALIENTE </asp:ListItem>
                    <asp:ListItem Value="72">CAPTACIÓN, DEPURACIÓN Y DISTRIBUCIÓN DE AGUA </asp:ListItem>
                    <asp:ListItem Value="73">CONSTRUCCIÓN </asp:ListItem>
                    <asp:ListItem Value="74">VENTA DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem Value="75">MANTENIMIENTO Y REPARACIÓN DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem Value="76">VENTA DE PARTES, PIEZAS Y ACCESORIOS DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem Value="77">VENTA, MANTENIMIENTO Y REPARACIÓN DE MOTOCICLETAS Y SUS PARTES </asp:ListItem>
                    <asp:ListItem Value="78">VENTA AL POR MENOR DE COMBUSTIBLE PARA AUTOMOTORES </asp:ListItem>
                    <asp:ListItem Value="79">VENTA AL POR MAYOR A CAMBIO DE UNA RETRIBUCIÓN O POR CONTRATA </asp:ListItem>
                    <asp:ListItem Value="80">VENTA AL POR MAYOR DE MATERIAS PRIMAS AGROPECUARIAS </asp:ListItem>
                    <asp:ListItem Value="81">VENTA AL POR MAYOR DE ENSERES DOMÉSTICOS </asp:ListItem>
                    <asp:ListItem Value="82">VENTA AL POR MAYOR DE PRODUCTOS INTERMEDIOS, DESECHOS NO AGROPECUARIOS </asp:ListItem>
                    <asp:ListItem Value="83">VENTA AL POR MAYOR DE MAQUINARIA, EQUIPO Y MATERIALES CONEXOS </asp:ListItem>
                    <asp:ListItem Value="84">VENTA AL POR MAYOR DE OTROS PRODUCTOS </asp:ListItem>
                    <asp:ListItem Value="85">COMERCIO AL POR MENOR NO ESPECIALIZADO EN ALMACENES </asp:ListItem>
                    <asp:ListItem Value="86">VENTA POR MENOR DE ALIMENTOS, BEBIDAS, TABACOS EN ALMC. ESPECIALIZADOS </asp:ListItem>
                    <asp:ListItem Value="87">COMERCIO AL POR MENOR DE OTROS PROD. NUEVOS EN ALMC. ESPECIALIZADOS </asp:ListItem>
                    <asp:ListItem Value="88">VENTA AL POR MENOR EN ALMACENES DE ARTÍCULOS USADOS </asp:ListItem>
                    <asp:ListItem Value="89">COMERCIO AL POR MENOR NO REALIZADO EN ALMACENES </asp:ListItem>
                    <asp:ListItem Value="90">REPARACIÓN DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS </asp:ListItem>
                    <asp:ListItem Value="91">HOTELES; CAMPAMENTOS Y OTROS TIPOS DE HOSPEDAJE TEMPORAL </asp:ListItem>
                    <asp:ListItem Value="92">RESTAURANTES, BARES Y CANTINAS </asp:ListItem>
                    <asp:ListItem Value="93">TRANSPORTE POR FERROCARRILES </asp:ListItem>
                    <asp:ListItem Value="94">OTROS TIPOS DE TRANSPORTE POR VÍA TERRESTRE </asp:ListItem>
                    <asp:ListItem Value="95">TRANSPORTE POR TUBERÍAS </asp:ListItem>
                    <asp:ListItem Value="96">TRANSPORTE MARÍTIMO Y DE CABOTAJE </asp:ListItem>
                    <asp:ListItem Value="97">TRANSPORTE POR VÍAS DE NAVEGACIÓN INTERIORES </asp:ListItem>
                    <asp:ListItem Value="98">TRANSPORTE POR VÍA AÉREA </asp:ListItem>
                    <asp:ListItem Value="99">ACT. DE TRANSPORTE COMPLEMENTARIAS Y AUXILIARES; AGENCIAS DE VIAJE </asp:ListItem>
                    <asp:ListItem Value="100">ACTIVIDADES POSTALES Y DE CORREO </asp:ListItem>
                    <asp:ListItem Value="101">TELECOMUNICACIONES </asp:ListItem>
                    <asp:ListItem Value="102">INTERMEDIACIÓN MONETARIA </asp:ListItem>
                    <asp:ListItem Value="103">OTROS TIPOS DE INTERMEDIACIÓN FINANCIERA </asp:ListItem>
                    <asp:ListItem Value="104">FINANCIACIÓN PLANES DE SEG. Y DE PENSIONES, EXCEPTO AFILIACIÓN OBLIG. </asp:ListItem>
                    <asp:ListItem Value="105">ACT. AUX. DE LA INTERMEDIACIÓN FINANCIERA, EXCEPTO PLANES DE SEGUROS </asp:ListItem>
                    <asp:ListItem Value="106">ACT. AUXILIARES DE FINANCIACIÓN DE PLANES DE SEGUROS Y DE PENSIONES </asp:ListItem>
                    <asp:ListItem Value="107">ACTIVIDADES INMOBILIARIAS REALIZADAS CON BIENES PROPIOS O ARRENDADOS </asp:ListItem>
                    <asp:ListItem Value="108">ACT. INMOBILIARIAS REALIZADAS A CAMBIO DE RETRIBUCIÓN O POR CONTRATA </asp:ListItem>
                    <asp:ListItem Value="109">ALQUILER EQUIPO DE TRANSPORTE </asp:ListItem>
                    <asp:ListItem Value="110">ALQUILER DE OTROS TIPOS DE MAQUINARIA Y EQUIPO </asp:ListItem>
                    <asp:ListItem Value="111">ALQUILER DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS N.C.P. </asp:ListItem>
                    <asp:ListItem Value="112">SERVICIOS INFORMÁTICOS </asp:ListItem>
                    <asp:ListItem Value="113">MANTENIMIENTO Y REPARACIÓN DE MAQUINARIA DE OFICINA </asp:ListItem>
                    <asp:ListItem Value="114">ACTIVIDADES DE INVESTIGACIONES Y DESARROLLO EXPERIMENTAL </asp:ListItem>
                    <asp:ListItem Value="115">ACTIVIDADES JURÍDICAS Y DE ASESORAMIENTO EMPRESARIAL EN GENERAL </asp:ListItem>
                    <asp:ListItem Value="116">ACTIVIDADES DE ARQUITECTURA E INGENIERÍA Y OTRAS ACTIVIDADES TÉCNICAS </asp:ListItem>
                    <asp:ListItem Value="117">PUBLICIDAD </asp:ListItem>
                    <asp:ListItem Value="118">ACT. EMPRESARIALES Y DE PROFESIONALES PRESTADAS A EMPRESAS N.C.P. </asp:ListItem>
                    <asp:ListItem Value="119">GOBIERNO CENTRAL Y ADMINISTRACIÓN PÚBLICA </asp:ListItem>
                    <asp:ListItem Value="120">ACTIVIDADES DE PLANES DE SEGURIDAD SOCIAL DE AFILIACIÓN OBLIGATORIA </asp:ListItem>
                    <asp:ListItem Value="121">ENSEÑANZA PREESCOLAR, PRIMARIA, SECUNDARIA Y SUPERIOR ; PROFESORES </asp:ListItem>
                    <asp:ListItem Value="122">ACTIVIDADES RELACIONADAS CON LA SALUD HUMANA </asp:ListItem>
                    <asp:ListItem Value="123">ACTIVIDADES VETERINARIAS </asp:ListItem>
                    <asp:ListItem Value="124">ACTIVIDADES DE SERVICIOS SOCIALES </asp:ListItem>
                    <asp:ListItem Value="125">ELIMINACIÓN DE DESPERDICIOS Y AGUAS RESIDUALES, SANEAMIENTO </asp:ListItem>
                    <asp:ListItem Value="126">ACT. DE ORGANIZACIONES EMPRESARIALES, PROFESIONALES Y DE EMPLEADORES </asp:ListItem>
                    <asp:ListItem Value="127">ACTIVIDADES DE SINDICATOS Y DE OTRAS ORGANIZACIONES </asp:ListItem>
                    <asp:ListItem Value="128">ACT. DE CINEMATOGRAFÍA, RADIO Y TV Y OTRAS ACT. DE ENTRETENIMIENTO </asp:ListItem>
                    <asp:ListItem Value="129">ACTIVIDADES DE AGENCIAS DE NOTICIAS Y SERVICIOS PERIODÍSTICOS </asp:ListItem>
                    <asp:ListItem Value="130">ACTIVIDADES DE BIBLIOTECAS, ARCHIVOS Y MUSEOS Y OTRAS ACT. CULTURALES </asp:ListItem>
                    <asp:ListItem Value="131">ACTIVIDADES DEPORTIVAS Y OTRAS ACTIVIDADES DE ESPARCIMIENTO </asp:ListItem>
                    <asp:ListItem Value="132">OTRAS ACTIVIDADES DE SERVICIOS </asp:ListItem>
                    <asp:ListItem Value="133">CONSEJO DE ADMINISTRACIÓN DE EDIFICIOS Y CONDOMINIOS </asp:ListItem>
                    <asp:ListItem Value="134">ORGANIZACIONES Y ÓRGANOS EXTRATERRITORIALES </asp:ListItem>

                </asp:DropDownList>

				
			</div>

			<div class="Contenido">
				Nombre Usuario<br/>
				 <asp:TextBox ID="nombreUsuario" runat="server"  CssClass="casilla" ></asp:TextBox><br/>		
			</div>

			<div class="Contenido">
				Correo Electrónico <br/>
				 <asp:TextBox ID="correoElectronico" runat="server"  CssClass="casilla" ></asp:TextBox><br/>			
			</div>
				
			<div class="Contenido">
				Contraseña <br/>
				<asp:TextBox ID="contrasena" runat="server" TextMode="Password" CssClass="casilla" ></asp:TextBox><br/>		
			</div>

			<div class="Contenido">
                <asp:Button ID="submit" runat="server" Text="Registrar" CssClass="casillaEnvio" OnClick="submit_Click"/>	
			</div>

			<div class="Contenido">
				<ul class="error" id="error"></ul>	
			</div>
	</div>
    
   

	<div class="Contenedor-Registro">
		<div class="linea"></div>
	</div>

        <!-- Ingreso usuario contraseña -->

	<div class="Contenedor-Ingreso">	
			<h3 class="Contenido">INGRESO</h3>
			<div class="Contenido">
				Correo Electrónico <br/>
			    <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="casilla"></asp:TextBox> <br/>		
			</div>
			<div class="Contenido">
				Contraseña <br/>
			    <asp:TextBox ID="txtClaveUsuario" runat="server"  TextMode="Password" CssClass="casilla"></asp:TextBox><br/>
			</div>



			<div class="Contenido">
				<asp:Button ID="btnAceptar" runat="server" Text="Ingresar"  OnClick="btnAceptar_Click" CssClass="casillaEnvio" /><br/>		
			</div>
			<div class="Contenido">
				<ul class="error2" id="error2"></ul>	
			</div>
	</div>

     </form>



</div>
  

<script src="/scripts/condiciones.js"></script>	
   
</body>
</html>
