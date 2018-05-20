<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="empresaEmpleado.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.empresaEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <link rel="stylesheet" type="text/css" href="/scripts/empresaEmpleado.css"/>
    <title></title>
</head>
<body>
    <div class="padre">

    <!--Inicio COLUMNA1-->
    	<div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> Datos Usuario </h3> </div>
			<div class="datosEmpresa" style=""> <b>Nombre</b>  <br> <label>Francisca Jímenez</label> </div>
			<div class="datosEmpresa">  <b>Rut</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Cargo</b>  <br> <label>Empleado</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>Fran.Jimenez@donaclarita.cl</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>+56 9 57846054</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA 1-->
         <!--Inicio COLUMNA 2-->

	<div class="columna2">
    <form id="form1" runat="server"  >
		<div class="ModificarDatos">
				
			<h2>Agregar Proveedor</h2><br>	
	
			<div class="Casilla2-1">
			<h4>Rut Empresa</h4>	
			<asp:TextBox ID="txtRutEmpresa" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Razón Social</h4>	              
			<asp:TextBox ID="txtRazonSocial" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Giro</h4>	
                <asp:DropDownList ID="txtGiro" runat="server" CssClass="droplist">
                    <asp:ListItem value="1"> Selecciona un Giro</asp:ListItem>
                    <asp:ListItem value="2"> CULTIVOS EN GENERAL; CULTIVO DE PRODUCTOS DE MERCADO; HORTICULTURA</asp:ListItem>
                    <asp:ListItem value="3"> CRÍA DE ANIMALES</asp:ListItem>
                    <asp:ListItem value="4"> CULTIVO PROD. AGRÍCOLAS EN COMBINACIÓN CON CRÍA DE ANIMALES</asp:ListItem>
                    <asp:ListItem value="5"> ACTIVIDADES DE SERVICIOS AGRÍCOLAS Y GANADEROS</asp:ListItem>
                    <asp:ListItem value="6"> CAZA ORDINARIA Y MEDIANTE TRAMPAS, REPOBLACIÓN, ACT. SERVICIO CONEXAS</asp:ListItem>
                    <asp:ListItem value="7"> SILVICULTURA, EXTRACCIÓN DE MADERA Y ACTIVIDADES DE SERVICIOS CONEXAS</asp:ListItem>
                    <asp:ListItem value="8"> EXPLT. DE CRIADEROS DE PECES Y PROD. DEL MAR; SERVICIOS RELACIONADOS</asp:ListItem>
                    <asp:ListItem value="9"> PESCA EXTRACTIVA: Y SERVICIOS RELACIONADOS</asp:ListItem>
                    <asp:ListItem value="10"> EXTRACCIÓN, AGLOMERACIÓN DE CARBÓN DE PIEDRA, LIGNITO Y TURBA</asp:ListItem>
                    <asp:ListItem value="11"> EXTRACCIÓN DE PETRÓLEO CRUDO Y GAS NATURAL; ACTIVIDADES RELACIONADAS</asp:ListItem>
                    <asp:ListItem value="12"> EXTRACCIÓN DE MINERALES METALÍFEROS</asp:ListItem>
                    <asp:ListItem value="13"> EXPLOTACIÓN DE MINAS Y CANTERAS</asp:ListItem>
                    <asp:ListItem value="14"> PRODUCCIÓN, PROCESAMIENTO Y CONSERVACIÓN DE ALIMENTOS</asp:ListItem>
                    <asp:ListItem value="15"> ELABORACIÓN DE PRODUCTOS LÁCTEOS</asp:ListItem>
                    <asp:ListItem value="16"> ELAB. DE PROD. DE MOLINERÍA, ALMIDONES Y PROD. DERIVADOS DEL ALMIDÓN</asp:ListItem>
                    <asp:ListItem value="17"> ELABORACIÓN DE OTROS PRODUCTOS ALIMENTICIOS</asp:ListItem>
                    <asp:ListItem value="18"> ELABORACIÓN DE BEBIDAS</asp:ListItem>
                    <asp:ListItem value="19"> ELABORACIÓN DE PRODUCTOS DEL TABACO</asp:ListItem>
                    <asp:ListItem value="20"> HILANDERÍA, TEJEDURA Y ACABADO DE PRODUCTOS TEXTILES</asp:ListItem>
                    <asp:ListItem value="21"> FABRICACIÓN DE OTROS PRODUCTOS TEXTILES</asp:ListItem>
                    <asp:ListItem value="22"> FABRICACIÓN DE TEJIDOS Y ARTÍCULOS DE PUNTO Y GANCHILLO</asp:ListItem>
                    <asp:ListItem value="23"> FABRICACIÓN DE PRENDAS DE VESTIR; EXCEPTO PRENDAS DE PIEL</asp:ListItem>
                    <asp:ListItem value="24"> PROCESAMIENTO Y FABRICACIÓN DE ARTÍCULOS DE PIEL Y CUERO</asp:ListItem>
                    <asp:ListItem value="25"> FABRICACIÓN DE CALZADO</asp:ListItem>
                    <asp:ListItem value="26"> ASERRADO Y ACEPILLADURA DE MADERAS</asp:ListItem>
                    <asp:ListItem value="27"> FAB. DE PRODUCTOS DE MADERA Y CORCHO,  PAJA Y DE MATERIALES TRENZABLES</asp:ListItem>
                    <asp:ListItem value="28"> FABRICACIÓN DE PAPEL Y PRODUCTOS DEL PAPEL</asp:ListItem>
                    <asp:ListItem value="29"> ACTIVIDADES DE EDICIÓN</asp:ListItem>
                    <asp:ListItem value="30"> ACTIVIDADES DE IMPRESIÓN Y DE SERVICIOS CONEXOS</asp:ListItem>
                    <asp:ListItem value="31"> FABRICACIÓN DE PRODUCTOS DE HORNOS COQUE Y DE REFINACIÓN DE PETRÓLEO</asp:ListItem>
                    <asp:ListItem value="32"> ELABORACIÓN DE COMBUSTIBLE NUCLEAR</asp:ListItem>
                    <asp:ListItem value="33"> FABRICACIÓN DE SUSTANCIAS QUÍMICAS BÁSICAS</asp:ListItem>
                    <asp:ListItem value="34"> FABRICACIÓN DE OTROS PRODUCTOS QUÍMICOS</asp:ListItem>
                    <asp:ListItem value="35"> FABRICACIÓN DE FIBRAS MANUFACTURADAS</asp:ListItem>
                    <asp:ListItem value="36"> FABRICACIÓN DE PRODUCTOS DE CAUCHO</asp:ListItem>
                    <asp:ListItem value="37"> FABRICACIÓN DE PRODUCTOS DE PLÁSTICO</asp:ListItem>
                    <asp:ListItem value="38"> FABRICACIÓN DE VIDRIOS Y PRODUCTOS DE VIDRIO</asp:ListItem>
                    <asp:ListItem value="39"> FABRICACIÓN DE PRODUCTOS MINERALES NO METÁLICOS N.C.P.</asp:ListItem>
                    <asp:ListItem value="40"> INDUSTRIAS BÁSICAS DE HIERRO Y ACERO</asp:ListItem>
                    <asp:ListItem value="41"> FAB. DE PRODUCTOS PRIMARIOS DE METALES PRECIOSOS Y METALES NO FERROSOS </asp:ListItem>
                    <asp:ListItem value="42"> FUNDICIÓN DE METALES </asp:ListItem>
                    <asp:ListItem value="43"> FAB. DE PROD. METÁLICOS PARA USO ESTRUCTURAL </asp:ListItem>
                    <asp:ListItem value="44"> FAB. DE OTROS PROD. ELABORADOS DE METAL; ACT. DE TRABAJO DE METALES </asp:ListItem>
                    <asp:ListItem value="45"> FABRICACIÓN DE MAQUINARIA DE USO GENERAL </asp:ListItem>
                    <asp:ListItem value="46"> FABRICACIÓN DE MAQUINARIA DE USO ESPECIAL </asp:ListItem>
                    <asp:ListItem value="47"> FABRICACIÓN DE APARATOS DE USO DOMÉSTICO N.C.P. </asp:ListItem>
                    <asp:ListItem value="48"> FABRICACIÓN DE MAQUINARIA DE OFICINA, CONTABILIDAD E INFORMÁTICA </asp:ListItem>
                    <asp:ListItem value="49"> FAB. Y REPARACIÓN DE MOTORES, GENERADORES Y TRANSFORMADORES ELÉCTRICOS </asp:ListItem>
                    <asp:ListItem value="50"> FABRICACIÓN DE APARATOS DE DISTRIBUCIÓN Y CONTROL; SUS REPARACIONES </asp:ListItem>
                    <asp:ListItem value="51"> FABRICACIÓN DE HILOS Y CABLES AISLADOS </asp:ListItem>
                    <asp:ListItem value="52"> FABRICACIÓN DE ACUMULADORES DE PILAS Y BATERÍAS PRIMARIAS </asp:ListItem>
                    <asp:ListItem value="53"> FABRICACIÓN Y REPARACIÓN DE LÁMPARAS Y EQUIPO DE ILUMINACIÓN </asp:ListItem>
                    <asp:ListItem value="54"> FABRICACIÓN Y REPARACIÓN DE OTROS TIPOS DE EQUIPO ELÉCTRICO N.C.P. </asp:ListItem>
                    <asp:ListItem value="55"> FABRICACIÓN DE COMPONENTES ELECTRÓNICOS; SUS REPARACIONES </asp:ListItem>
                    <asp:ListItem value="56"> FAB. Y REPARACIÓN DE TRANSMISORES DE RADIO, TELEVISIÓN, TELEFONÍA </asp:ListItem>
                    <asp:ListItem value="57"> FAB. DE RECEPTORES DE RADIO, TELEVISIÓN, APARATOS DE AUDIO/VÍDEO </asp:ListItem>
                    <asp:ListItem value="58"> FAB. DE APARATOS E INSTRUMENTOS MÉDICOS Y PARA REALIZAR MEDICIONES </asp:ListItem>
                    <asp:ListItem value="59"> FAB. Y REPARACIÓN DE INSTRUMENTOS DE ÓPTICA Y EQUIPO FOTOGRÁFICO </asp:ListItem>
                    <asp:ListItem value="60"> FABRICACIÓN DE RELOJES </asp:ListItem>
                    <asp:ListItem value="61"> FABRICACIÓN DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem value="62"> CONSTRUCCIÓN Y REPARACIÓN DE BUQUES Y OTRAS EMBARCACIONES </asp:ListItem>
                    <asp:ListItem value="63"> FAB. DE LOCOMOTORAS Y MATERIAL RODANTE PARA FERROCARRILES Y TRANVÍAS </asp:ListItem>
                    <asp:ListItem value="64"> FABRICACIÓN DE AERONAVES Y NAVES ESPACIALES; SUS REPARACIONES </asp:ListItem>
                    <asp:ListItem value="65"> FABRICACIÓN DE OTROS TIPOS DE EQUIPO DE TRANSPORTE N.C.P. </asp:ListItem>
                    <asp:ListItem value="66"> FABRICACIÓN DE MUEBLES </asp:ListItem>
                    <asp:ListItem value="67"> INDUSTRIAS MANUFACTURERAS N.C.P. </asp:ListItem>
                    <asp:ListItem value="68"> RECICLAMIENTO DE DESPERDICIOS Y DESECHOS </asp:ListItem>
                    <asp:ListItem value="69"> GENERACIÓN, CAPTACIÓN Y DISTRIBUCIÓN DE ENERGÍA ELÉCTRICA </asp:ListItem>
                    <asp:ListItem value="70"> FABRICACIÓN DE GAS; DISTRIBUCIÓN DE COMBUSTIBLES GASEOSOS POR TUBERÍAS </asp:ListItem>
                    <asp:ListItem value="71"> SUMINISTRO DE VAPOR Y AGUA CALIENTE </asp:ListItem>
                    <asp:ListItem value="72"> CAPTACIÓN, DEPURACIÓN Y DISTRIBUCIÓN DE AGUA </asp:ListItem>
                    <asp:ListItem value="73"> CONSTRUCCIÓN </asp:ListItem>
                    <asp:ListItem value="74"> VENTA DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem value="75"> MANTENIMIENTO Y REPARACIÓN DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem value="76"> VENTA DE PARTES, PIEZAS Y ACCESORIOS DE VEHÍCULOS AUTOMOTORES </asp:ListItem>
                    <asp:ListItem value="77"> VENTA, MANTENIMIENTO Y REPARACIÓN DE MOTOCICLETAS Y SUS PARTES </asp:ListItem>
                    <asp:ListItem value="78"> VENTA AL POR MENOR DE COMBUSTIBLE PARA AUTOMOTORES </asp:ListItem>
                    <asp:ListItem value="79"> VENTA AL POR MAYOR A CAMBIO DE UNA RETRIBUCIÓN O POR CONTRATA </asp:ListItem>
                    <asp:ListItem value="80"> VENTA AL POR MAYOR DE MATERIAS PRIMAS AGROPECUARIAS </asp:ListItem>
                    <asp:ListItem value="81"> VENTA AL POR MAYOR DE ENSERES DOMÉSTICOS </asp:ListItem>
                    <asp:ListItem value="82"> VENTA AL POR MAYOR DE PRODUCTOS INTERMEDIOS, DESECHOS NO AGROPECUARIOS </asp:ListItem>
                    <asp:ListItem value="83"> VENTA AL POR MAYOR DE MAQUINARIA, EQUIPO Y MATERIALES CONEXOS </asp:ListItem>
                    <asp:ListItem value="84"> VENTA AL POR MAYOR DE OTROS PRODUCTOS </asp:ListItem>
                    <asp:ListItem value="85"> COMERCIO AL POR MENOR NO ESPECIALIZADO EN ALMACENES </asp:ListItem>
                    <asp:ListItem value="86"> VENTA POR MENOR DE ALIMENTOS, BEBIDAS, TABACOS EN ALMC. ESPECIALIZADOS </asp:ListItem>
                    <asp:ListItem value="87"> COMERCIO AL POR MENOR DE OTROS PROD. NUEVOS EN ALMC. ESPECIALIZADOS </asp:ListItem>
                    <asp:ListItem value="88"> VENTA AL POR MENOR EN ALMACENES DE ARTÍCULOS USADOS </asp:ListItem>
                    <asp:ListItem value="89"> COMERCIO AL POR MENOR NO REALIZADO EN ALMACENES </asp:ListItem>
                    <asp:ListItem value="90"> REPARACIÓN DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS </asp:ListItem>
                    <asp:ListItem value="91"> HOTELES; CAMPAMENTOS Y OTROS TIPOS DE HOSPEDAJE TEMPORAL </asp:ListItem>
                    <asp:ListItem value="92"> RESTAURANTES, BARES Y CANTINAS </asp:ListItem>
                    <asp:ListItem value="93"> TRANSPORTE POR FERROCARRILES </asp:ListItem>
                    <asp:ListItem value="94"> OTROS TIPOS DE TRANSPORTE POR VÍA TERRESTRE </asp:ListItem>
                    <asp:ListItem value="95"> TRANSPORTE POR TUBERÍAS </asp:ListItem>
                    <asp:ListItem value="96"> TRANSPORTE MARÍTIMO Y DE CABOTAJE </asp:ListItem>
                    <asp:ListItem value="97"> TRANSPORTE POR VÍAS DE NAVEGACIÓN INTERIORES </asp:ListItem>
                    <asp:ListItem value="98"> TRANSPORTE POR VÍA AÉREA </asp:ListItem>
                    <asp:ListItem value="99"> ACT. DE TRANSPORTE COMPLEMENTARIAS Y AUXILIARES; AGENCIAS DE VIAJE </asp:ListItem>
                    <asp:ListItem value="100"> ACTIVIDADES POSTALES Y DE CORREO </asp:ListItem>
                    <asp:ListItem value="101"> TELECOMUNICACIONES </asp:ListItem>
                    <asp:ListItem value="102"> INTERMEDIACIÓN MONETARIA </asp:ListItem>
                    <asp:ListItem value="103"> OTROS TIPOS DE INTERMEDIACIÓN FINANCIERA </asp:ListItem>
                    <asp:ListItem value="104"> FINANCIACIÓN PLANES DE SEG. Y DE PENSIONES, EXCEPTO AFILIACIÓN OBLIG. </asp:ListItem>
                    <asp:ListItem value="105"> ACT. AUX. DE LA INTERMEDIACIÓN FINANCIERA, EXCEPTO PLANES DE SEGUROS </asp:ListItem>
                    <asp:ListItem value="106"> ACT. AUXILIARES DE FINANCIACIÓN DE PLANES DE SEGUROS Y DE PENSIONES </asp:ListItem>
                    <asp:ListItem value="107"> ACTIVIDADES INMOBILIARIAS REALIZADAS CON BIENES PROPIOS O ARRENDADOS </asp:ListItem>
                    <asp:ListItem value="108"> ACT. INMOBILIARIAS REALIZADAS A CAMBIO DE RETRIBUCIÓN O POR CONTRATA </asp:ListItem>
                    <asp:ListItem value="109"> ALQUILER EQUIPO DE TRANSPORTE </asp:ListItem>
                    <asp:ListItem value="110"> ALQUILER DE OTROS TIPOS DE MAQUINARIA Y EQUIPO </asp:ListItem>
                    <asp:ListItem value="111"> ALQUILER DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS N.C.P. </asp:ListItem>
                    <asp:ListItem value="112"> SERVICIOS INFORMÁTICOS </asp:ListItem>
                    <asp:ListItem value="113"> MANTENIMIENTO Y REPARACIÓN DE MAQUINARIA DE OFICINA </asp:ListItem>
                    <asp:ListItem value="114"> ACTIVIDADES DE INVESTIGACIONES Y DESARROLLO EXPERIMENTAL </asp:ListItem>
                    <asp:ListItem value="115"> ACTIVIDADES JURÍDICAS Y DE ASESORAMIENTO EMPRESARIAL EN GENERAL </asp:ListItem>
                    <asp:ListItem value="116"> ACTIVIDADES DE ARQUITECTURA E INGENIERÍA Y OTRAS ACTIVIDADES TÉCNICAS </asp:ListItem>
                    <asp:ListItem value="117"> PUBLICIDAD </asp:ListItem>
                    <asp:ListItem value="118"> ACT. EMPRESARIALES Y DE PROFESIONALES PRESTADAS A EMPRESAS N.C.P. </asp:ListItem>
                    <asp:ListItem value="119"> GOBIERNO CENTRAL Y ADMINISTRACIÓN PÚBLICA </asp:ListItem>
                    <asp:ListItem value="120"> ACTIVIDADES DE PLANES DE SEGURIDAD SOCIAL DE AFILIACIÓN OBLIGATORIA </asp:ListItem>
                    <asp:ListItem value="121"> ENSEÑANZA PREESCOLAR, PRIMARIA, SECUNDARIA Y SUPERIOR ; PROFESORES </asp:ListItem>
                    <asp:ListItem value="122"> ACTIVIDADES RELACIONADAS CON LA SALUD HUMANA </asp:ListItem>
                    <asp:ListItem value="123"> ACTIVIDADES VETERINARIAS </asp:ListItem>
                    <asp:ListItem value="124"> ACTIVIDADES DE SERVICIOS SOCIALES </asp:ListItem>
                    <asp:ListItem value="125"> ELIMINACIÓN DE DESPERDICIOS Y AGUAS RESIDUALES, SANEAMIENTO </asp:ListItem>
                    <asp:ListItem value="126"> ACT. DE ORGANIZACIONES EMPRESARIALES, PROFESIONALES Y DE EMPLEADORES </asp:ListItem>
                    <asp:ListItem value="127"> ACTIVIDADES DE SINDICATOS Y DE OTRAS ORGANIZACIONES </asp:ListItem>
                    <asp:ListItem value="128"> ACT. DE CINEMATOGRAFÍA, RADIO Y TV Y OTRAS ACT. DE ENTRETENIMIENTO </asp:ListItem>
                    <asp:ListItem value="129"> ACTIVIDADES DE AGENCIAS DE NOTICIAS Y SERVICIOS PERIODÍSTICOS </asp:ListItem>
                    <asp:ListItem value="130"> ACTIVIDADES DE BIBLIOTECAS, ARCHIVOS Y MUSEOS Y OTRAS ACT. CULTURALES </asp:ListItem>
                    <asp:ListItem value="131"> ACTIVIDADES DEPORTIVAS Y OTRAS ACTIVIDADES DE ESPARCIMIENTO </asp:ListItem>
                    <asp:ListItem value="132"> OTRAS ACTIVIDADES DE SERVICIOS </asp:ListItem>
                    <asp:ListItem value="133"> CONSEJO DE ADMINISTRACIÓN DE EDIFICIOS Y CONDOMINIOS </asp:ListItem>
                    <asp:ListItem value="134"> ORGANIZACIONES Y ÓRGANOS EXTRATERRITORIALES </asp:ListItem>
                </asp:DropDownList>
			</div>
			<div class="Casilla2-1">
			<h4>Dirección</h4>
			<asp:TextBox ID="txtCalle" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
            <div class="Casilla2-1">
			<h4>Número</h4>
			<asp:TextBox ID="txtNumero" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
				<h4>Ciudad</h4>		
                <asp:DropDownList ID="txtNombreCiudad" runat="server">
                     <asp:ListItem value="1">Seleccione una ciudad</asp:ListItem>
                     <asp:ListItem value="2">Metropolitana de Santiago</asp:ListItem>
                     <asp:ListItem value="3">Biobío</asp:ListItem>
                     <asp:ListItem value="4">Valparaíso</asp:ListItem>
                     <asp:ListItem value="5">Coquimbo</asp:ListItem>
                     <asp:ListItem value="6">Antofagasta</asp:ListItem>
                     <asp:ListItem value="7">Araucanía</asp:ListItem>
                     <asp:ListItem value="8">O'Higgins</asp:ListItem>
                     <asp:ListItem value="9">Tarapacá</asp:ListItem>
                     <asp:ListItem value="10">Maule</asp:ListItem>
                     <asp:ListItem value="11">Arica y Parinacota</asp:ListItem>
                     <asp:ListItem value="12">Los Lagos</asp:ListItem>
                     <asp:ListItem value="13">Biobío</asp:ListItem>
                     <asp:ListItem value="14">Biobío</asp:ListItem>
                     <asp:ListItem value="15">Antofagasta</asp:ListItem>
                     <asp:ListItem value="16">Atacama</asp:ListItem>
                     <asp:ListItem value="17">Los Lagos</asp:ListItem>
                     <asp:ListItem value="18">Valparaíso</asp:ListItem>
                     <asp:ListItem value="19">Los Ríos</asp:ListItem>
                     <asp:ListItem value="20">Magallanes</asp:ListItem>
                     <asp:ListItem value="21">Valparaíso</asp:ListItem>
                     <asp:ListItem value="22">Maule</asp:ListItem>
                     <asp:ListItem value="23">Coquimbo</asp:ListItem>
                     <asp:ListItem value="24">Maule</asp:ListItem>
                     <asp:ListItem value="25">Valparaíso</asp:ListItem>
                     <asp:ListItem value="26">Metropolitana de Santiago</asp:ListItem>
                     <asp:ListItem value="27">Valparaíso</asp:ListItem>
                </asp:DropDownList>
			</div>
			<div class="Casilla2-1">
				<h4>Comuna</h4>					
				  <asp:DropDownList ID="txtComuna" runat="server">
                 <asp:ListItem value="1">Seleccione una comuna</asp:ListItem>
                 <asp:ListItem value="2">Cerrillos</asp:ListItem>
                 <asp:ListItem value="3">Cerro Navia</asp:ListItem>
                 <asp:ListItem value="4">Conchalí</asp:ListItem>
                 <asp:ListItem value="5">El Bosque</asp:ListItem>
                 <asp:ListItem value="6">Estación Central</asp:ListItem>
                 <asp:ListItem value="7">Huechuraba</asp:ListItem>
                 <asp:ListItem value="8">Independencia</asp:ListItem>
                 <asp:ListItem value="9">La Cisterna</asp:ListItem>
                 <asp:ListItem value="10">La Florida</asp:ListItem>
                 <asp:ListItem value="11">La Granja</asp:ListItem>
                 <asp:ListItem value="12">La Pintana</asp:ListItem>
                 <asp:ListItem value="13">La Reina</asp:ListItem>
                 <asp:ListItem value="14">Las Condes</asp:ListItem>
                 <asp:ListItem value="15">Lo Barnechea</asp:ListItem>
                 <asp:ListItem value="16">Lo Espejo</asp:ListItem>
                 <asp:ListItem value="17">Lo Prado</asp:ListItem>
                 <asp:ListItem value="18">Macul</asp:ListItem>
                 <asp:ListItem value="19">Maipú</asp:ListItem>
                 <asp:ListItem value="20">Ñuñoa</asp:ListItem>
                 <asp:ListItem value="21">Padre Hurtado</asp:ListItem>
                 <asp:ListItem value="22">Pedro Aguirre Cerda</asp:ListItem>
                 <asp:ListItem value="23">Peñalolén</asp:ListItem>
                 <asp:ListItem value="24">Providencia</asp:ListItem>
                 <asp:ListItem value="25">Pudahuel</asp:ListItem>
                 <asp:ListItem value="26">Puente Alto</asp:ListItem>
                 <asp:ListItem value="27">Quilicura</asp:ListItem>
                 <asp:ListItem value="28">Quinta Normal</asp:ListItem>
                 <asp:ListItem value="29">Recoleta</asp:ListItem>
                 <asp:ListItem value="30">Renca</asp:ListItem>
                 <asp:ListItem value="31">San Bernardo</asp:ListItem>
                 <asp:ListItem value="32">San Joaquín</asp:ListItem>
                 <asp:ListItem value="33">San Miguel</asp:ListItem>
                 <asp:ListItem value="34">San Ramón</asp:ListItem>
                 <asp:ListItem value="35">Santiago</asp:ListItem>
                 <asp:ListItem value="36">Vitacura</asp:ListItem>
                 <asp:ListItem value="37">--Otra--</asp:ListItem>
                </asp:DropDownList>
			</div>
			<div class="Casilla2-1">
			<h4>Correo Electrónico</h4>	
			<asp:TextBox ID="txtCorreoElectronico" runat="server" TextMode="Email" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Teléfono</h4>	
			<asp:TextBox ID="txtTelefonoEmpresa" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
			</div>
        
	</div>


	<div class="ModificarDatos2">
		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre Usuario</h4>	
		<asp:TextBox ID="txtNombreEmpleado" runat="server"  CssClass="CasillaPersona"></asp:TextBox>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Nueva Contraseña</h4>	
		<asp:TextBox ID="txtConstrasena" runat="server"  CssClass="CasillaPersona" ></asp:TextBox>
        </div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Confirmar Contraseña</h4>	
		<asp:TextBox ID="txtConstrasena2" runat="server"  CssClass="CasillaPersona"  ></asp:TextBox>
		</div>
		<div class="Casilla2-2">	
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar Proveedor"  OnClick="btnAceptar_Click" CssClass="SubmitTotal" />
        </div>
	  </div>	
      </form>

    </div>
               <!--Fin COLUMNA 2-->

 </div>

</body>
</html>
