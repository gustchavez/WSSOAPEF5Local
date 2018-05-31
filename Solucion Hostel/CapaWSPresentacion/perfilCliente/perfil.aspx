<%@ Page Title="" Language="C#" MasterPageFile="~/perfilCliente/MasteCliente.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="CapaWSPresentacion.perfilCliente.perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <link rel="stylesheet" type="text/css" href="/scripts/perfilCliente.css">

    <form id="form1" runat="server">

    <div class="columna1">
		<div class="perfilCliente">		
			<div class="datosEmpresa" > <div class="imagen-logo-empresa"></div> </div>
			<div class="datosEmpresa">  <h3> DATOS ACTUALES </h3> </div>
			<div class="datosEmpresa" style=""> <b>Razón Social</b>  <br> <label>Nombre Empresa</label> </div>
			<div class="datosEmpresa">  <b>Rut Empresa</b>  <br>  <label>11111111-1</label> </div>
			<div class="datosEmpresa">  <b>Giro</b>  <br> <label>Entretención</label> </div>
			<div class="datosEmpresa">  <b>Correo Electrónico </b> <br> <label>contacto@empresa.cl</label> </div>
			<div class="datosEmpresa">  <b>Dirección</b>  <br> <label>Almirante Pastene 185</label> </div>
			<div class="datosEmpresa">  <b>Teléfono</b>  <br> <label>22222222</label> </div>
		</div>
	</div>
	<!--Fin COLUMNA1-->

	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Modificar datos de empresa</h2><br>	

			<div class="Casilla2-1">
			<h4>Rut Empresa</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Rut" disabled>
			</div>
			<div class="Casilla2-1">
			<h4>Razón Social</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Nombre">
			</div>
			<div class="Casilla2-1">
			<h4>Giro</h4>	
			<select class="droplist" required>
				<option value="" >Selecciona un Giro</option>
				<option>CULTIVOS EN GENERAL; CULTIVO DE PRODUCTOS DE MERCADO; HORTICULTURA</option>
				<option>CRÍA DE ANIMALES</option>
				<option>CULTIVO PROD. AGRÍCOLAS EN COMBINACIÓN CON CRÍA DE ANIMALES</option>
				<option>ACTIVIDADES DE SERVICIOS AGRÍCOLAS Y GANADEROS</option>
				<option>CAZA ORDINARIA Y MEDIANTE TRAMPAS, REPOBLACIÓN, ACT. SERVICIO CONEXAS</option>
				<option>SILVICULTURA, EXTRACCIÓN DE MADERA Y ACTIVIDADES DE SERVICIOS CONEXAS</option>
				<option>EXPLT. DE CRIADEROS DE PECES Y PROD. DEL MAR; SERVICIOS RELACIONADOS</option>
				<option>PESCA EXTRACTIVA: Y SERVICIOS RELACIONADOS</option>
				<option>EXTRACCIÓN, AGLOMERACIÓN DE CARBÓN DE PIEDRA, LIGNITO Y TURBA</option>
				<option>EXTRACCIÓN DE PETRÓLEO CRUDO Y GAS NATURAL; ACTIVIDADES RELACIONADAS</option>
				<option>EXTRACCIÓN DE MINERALES METALÍFEROS</option>
				<option>EXPLOTACIÓN DE MINAS Y CANTERAS</option>
				<option>PRODUCCIÓN, PROCESAMIENTO Y CONSERVACIÓN DE ALIMENTOS</option>
				<option>ELABORACIÓN DE PRODUCTOS LÁCTEOS</option>
				<option>ELAB. DE PROD. DE MOLINERÍA, ALMIDONES Y PROD. DERIVADOS DEL ALMIDÓN</option>
				<option>ELABORACIÓN DE OTROS PRODUCTOS ALIMENTICIOS</option>
				<option>ELABORACIÓN DE BEBIDAS</option>
				<option>ELABORACIÓN DE PRODUCTOS DEL TABACO</option>
				<option>HILANDERÍA, TEJEDURA Y ACABADO DE PRODUCTOS TEXTILES</option>
				<option>FABRICACIÓN DE OTROS PRODUCTOS TEXTILES</option>
				<option>FABRICACIÓN DE TEJIDOS Y ARTÍCULOS DE PUNTO Y GANCHILLO</option>
				<option>FABRICACIÓN DE PRENDAS DE VESTIR; EXCEPTO PRENDAS DE PIEL</option>
				<option>PROCESAMIENTO Y FABRICACIÓN DE ARTÍCULOS DE PIEL Y CUERO</option>
				<option>FABRICACIÓN DE CALZADO</option>
				<option>ASERRADO Y ACEPILLADURA DE MADERAS</option>
				<option>FAB. DE PRODUCTOS DE MADERA Y CORCHO,  PAJA Y DE MATERIALES TRENZABLES</option>
				<option>FABRICACIÓN DE PAPEL Y PRODUCTOS DEL PAPEL</option>
				<option>ACTIVIDADES DE EDICIÓN</option>
				<option>ACTIVIDADES DE IMPRESIÓN Y DE SERVICIOS CONEXOS</option>
				<option>FABRICACIÓN DE PRODUCTOS DE HORNOS COQUE Y DE REFINACIÓN DE PETRÓLEO</option>
				<option>ELABORACIÓN DE COMBUSTIBLE NUCLEAR</option>
				<option>FABRICACIÓN DE SUSTANCIAS QUÍMICAS BÁSICAS</option>
				<option>FABRICACIÓN DE OTROS PRODUCTOS QUÍMICOS</option>
				<option>FABRICACIÓN DE FIBRAS MANUFACTURADAS</option>
				<option>FABRICACIÓN DE PRODUCTOS DE CAUCHO</option>
				<option>FABRICACIÓN DE PRODUCTOS DE PLÁSTICO</option>
				<option>FABRICACIÓN DE VIDRIOS Y PRODUCTOS DE VIDRIO</option>
				<option>FABRICACIÓN DE PRODUCTOS MINERALES NO METÁLICOS N.C.P.</option>
				<option>INDUSTRIAS BÁSICAS DE HIERRO Y ACERO</option>
				<option>FAB. DE PRODUCTOS PRIMARIOS DE METALES PRECIOSOS Y METALES NO FERROSOS </option>
				<option>FUNDICIÓN DE METALES </option>
				<option>FAB. DE PROD. METÁLICOS PARA USO ESTRUCTURAL </option>
				<option>FAB. DE OTROS PROD. ELABORADOS DE METAL; ACT. DE TRABAJO DE METALES </option>
				<option>FABRICACIÓN DE MAQUINARIA DE USO GENERAL </option>
				<option>FABRICACIÓN DE MAQUINARIA DE USO ESPECIAL </option>
				<option>FABRICACIÓN DE APARATOS DE USO DOMÉSTICO N.C.P. </option>
				<option>FABRICACIÓN DE MAQUINARIA DE OFICINA, CONTABILIDAD E INFORMÁTICA </option>
				<option>FAB. Y REPARACIÓN DE MOTORES, GENERADORES Y TRANSFORMADORES ELÉCTRICOS </option>
				<option>FABRICACIÓN DE APARATOS DE DISTRIBUCIÓN Y CONTROL; SUS REPARACIONES </option>
				<option>FABRICACIÓN DE HILOS Y CABLES AISLADOS </option>
				<option>FABRICACIÓN DE ACUMULADORES DE PILAS Y BATERÍAS PRIMARIAS </option>
				<option>FABRICACIÓN Y REPARACIÓN DE LÁMPARAS Y EQUIPO DE ILUMINACIÓN </option>
				<option>FABRICACIÓN Y REPARACIÓN DE OTROS TIPOS DE EQUIPO ELÉCTRICO N.C.P. </option>
				<option>FABRICACIÓN DE COMPONENTES ELECTRÓNICOS; SUS REPARACIONES </option>
				<option>FAB. Y REPARACIÓN DE TRANSMISORES DE RADIO, TELEVISIÓN, TELEFONÍA </option>
				<option>FAB. DE RECEPTORES DE RADIO, TELEVISIÓN, APARATOS DE AUDIO/VÍDEO </option>
				<option>FAB. DE APARATOS E INSTRUMENTOS MÉDICOS Y PARA REALIZAR MEDICIONES </option>
				<option>FAB. Y REPARACIÓN DE INSTRUMENTOS DE ÓPTICA Y EQUIPO FOTOGRÁFICO </option>
				<option>FABRICACIÓN DE RELOJES </option>
				<option>FABRICACIÓN DE VEHÍCULOS AUTOMOTORES </option>
				<option>CONSTRUCCIÓN Y REPARACIÓN DE BUQUES Y OTRAS EMBARCACIONES </option>
				<option>FAB. DE LOCOMOTORAS Y MATERIAL RODANTE PARA FERROCARRILES Y TRANVÍAS </option>
				<option>FABRICACIÓN DE AERONAVES Y NAVES ESPACIALES; SUS REPARACIONES </option>
				<option>FABRICACIÓN DE OTROS TIPOS DE EQUIPO DE TRANSPORTE N.C.P. </option>
				<option>FABRICACIÓN DE MUEBLES </option>
				<option>INDUSTRIAS MANUFACTURERAS N.C.P. </option>
				<option>RECICLAMIENTO DE DESPERDICIOS Y DESECHOS </option>
				<option>GENERACIÓN, CAPTACIÓN Y DISTRIBUCIÓN DE ENERGÍA ELÉCTRICA </option>
				<option>FABRICACIÓN DE GAS; DISTRIBUCIÓN DE COMBUSTIBLES GASEOSOS POR TUBERÍAS </option>
				<option>SUMINISTRO DE VAPOR Y AGUA CALIENTE </option>
				<option>CAPTACIÓN, DEPURACIÓN Y DISTRIBUCIÓN DE AGUA </option>
				<option>CONSTRUCCIÓN </option>
				<option>VENTA DE VEHÍCULOS AUTOMOTORES </option>
				<option>MANTENIMIENTO Y REPARACIÓN DE VEHÍCULOS AUTOMOTORES </option>
				<option>VENTA DE PARTES, PIEZAS Y ACCESORIOS DE VEHÍCULOS AUTOMOTORES </option>
				<option>VENTA, MANTENIMIENTO Y REPARACIÓN DE MOTOCICLETAS Y SUS PARTES </option>
				<option>VENTA AL POR MENOR DE COMBUSTIBLE PARA AUTOMOTORES </option>
				<option>VENTA AL POR MAYOR A CAMBIO DE UNA RETRIBUCIÓN O POR CONTRATA </option>
				<option>VENTA AL POR MAYOR DE MATERIAS PRIMAS AGROPECUARIAS </option>
				<option>VENTA AL POR MAYOR DE ENSERES DOMÉSTICOS </option>
				<option>VENTA AL POR MAYOR DE PRODUCTOS INTERMEDIOS, DESECHOS NO AGROPECUARIOS </option>
				<option>VENTA AL POR MAYOR DE MAQUINARIA, EQUIPO Y MATERIALES CONEXOS </option>
				<option>VENTA AL POR MAYOR DE OTROS PRODUCTOS </option>
				<option>COMERCIO AL POR MENOR NO ESPECIALIZADO EN ALMACENES </option>
				<option>VENTA POR MENOR DE ALIMENTOS, BEBIDAS, TABACOS EN ALMC. ESPECIALIZADOS </option>
				<option>COMERCIO AL POR MENOR DE OTROS PROD. NUEVOS EN ALMC. ESPECIALIZADOS </option>
				<option>VENTA AL POR MENOR EN ALMACENES DE ARTÍCULOS USADOS </option>
				<option>COMERCIO AL POR MENOR NO REALIZADO EN ALMACENES </option>
				<option>REPARACIÓN DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS </option>
				<option>HOTELES; CAMPAMENTOS Y OTROS TIPOS DE HOSPEDAJE TEMPORAL </option>
				<option>RESTAURANTES, BARES Y CANTINAS </option>
				<option>TRANSPORTE POR FERROCARRILES </option>
				<option>OTROS TIPOS DE TRANSPORTE POR VÍA TERRESTRE </option>
				<option>TRANSPORTE POR TUBERÍAS </option>
				<option>TRANSPORTE MARÍTIMO Y DE CABOTAJE </option>
				<option>TRANSPORTE POR VÍAS DE NAVEGACIÓN INTERIORES </option>
				<option>TRANSPORTE POR VÍA AÉREA </option>
				<option>ACT. DE TRANSPORTE COMPLEMENTARIAS Y AUXILIARES; AGENCIAS DE VIAJE </option>
				<option>ACTIVIDADES POSTALES Y DE CORREO </option>
				<option>TELECOMUNICACIONES </option>
				<option>INTERMEDIACIÓN MONETARIA </option>
				<option>OTROS TIPOS DE INTERMEDIACIÓN FINANCIERA </option>
				<option>FINANCIACIÓN PLANES DE SEG. Y DE PENSIONES, EXCEPTO AFILIACIÓN OBLIG. </option>
				<option>ACT. AUX. DE LA INTERMEDIACIÓN FINANCIERA, EXCEPTO PLANES DE SEGUROS </option>
				<option>ACT. AUXILIARES DE FINANCIACIÓN DE PLANES DE SEGUROS Y DE PENSIONES </option>
				<option>ACTIVIDADES INMOBILIARIAS REALIZADAS CON BIENES PROPIOS O ARRENDADOS </option>
				<option>ACT. INMOBILIARIAS REALIZADAS A CAMBIO DE RETRIBUCIÓN O POR CONTRATA </option>
				<option>ALQUILER EQUIPO DE TRANSPORTE </option>
				<option>ALQUILER DE OTROS TIPOS DE MAQUINARIA Y EQUIPO </option>
				<option>ALQUILER DE EFECTOS PERSONALES Y ENSERES DOMÉSTICOS N.C.P. </option>
				<option>SERVICIOS INFORMÁTICOS </option>
				<option>MANTENIMIENTO Y REPARACIÓN DE MAQUINARIA DE OFICINA </option>
				<option>ACTIVIDADES DE INVESTIGACIONES Y DESARROLLO EXPERIMENTAL </option>
				<option>ACTIVIDADES JURÍDICAS Y DE ASESORAMIENTO EMPRESARIAL EN GENERAL </option>
				<option>ACTIVIDADES DE ARQUITECTURA E INGENIERÍA Y OTRAS ACTIVIDADES TÉCNICAS </option>
				<option>PUBLICIDAD </option>
				<option>ACT. EMPRESARIALES Y DE PROFESIONALES PRESTADAS A EMPRESAS N.C.P. </option>
				<option>GOBIERNO CENTRAL Y ADMINISTRACIÓN PÚBLICA </option>
				<option>ACTIVIDADES DE PLANES DE SEGURIDAD SOCIAL DE AFILIACIÓN OBLIGATORIA </option>
				<option>ENSEÑANZA PREESCOLAR, PRIMARIA, SECUNDARIA Y SUPERIOR ; PROFESORES </option>
				<option>ACTIVIDADES RELACIONADAS CON LA SALUD HUMANA </option>
				<option>ACTIVIDADES VETERINARIAS </option>
				<option>ACTIVIDADES DE SERVICIOS SOCIALES </option>
				<option>ELIMINACIÓN DE DESPERDICIOS Y AGUAS RESIDUALES, SANEAMIENTO </option>
				<option>ACT. DE ORGANIZACIONES EMPRESARIALES, PROFESIONALES Y DE EMPLEADORES </option>
				<option>ACTIVIDADES DE SINDICATOS Y DE OTRAS ORGANIZACIONES </option>
				<option>ACT. DE CINEMATOGRAFÍA, RADIO Y TV Y OTRAS ACT. DE ENTRETENIMIENTO </option>
				<option>ACTIVIDADES DE AGENCIAS DE NOTICIAS Y SERVICIOS PERIODÍSTICOS </option>
				<option>ACTIVIDADES DE BIBLIOTECAS, ARCHIVOS Y MUSEOS Y OTRAS ACT. CULTURALES </option>
				<option>ACTIVIDADES DEPORTIVAS Y OTRAS ACTIVIDADES DE ESPARCIMIENTO </option>
				<option>OTRAS ACTIVIDADES DE SERVICIOS </option>
				<option>CONSEJO DE ADMINISTRACIÓN DE EDIFICIOS Y CONDOMINIOS </option>
				<option>ORGANIZACIONES Y ÓRGANOS EXTRATERRITORIALES </option>
			</select>				
			</div>
			<div class="Casilla2-1">
			<h4>Dirección</h4>
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Dirección">
			</div>
			<div class="Casilla2-1">
				<h4>Ciudad</h4>					
				<select class="droplist">
					<option value="">Seleccione una ciudad</option>
					<option>Metropolitana de Santiago</option>
					<option>Biobío</option>
					<option>Valparaíso</option>
					<option>Coquimbo</option>
					<option>Antofagasta</option>
					<option>Araucanía</option>
					<option>O'Higgins</option>
					<option>Tarapacá</option>
					<option>Maule</option>
					<option>Arica y Parinacota</option>
					<option>Los Lagos</option>
					<option>Biobío</option>
					<option>Biobío</option>
					<option>Antofagasta</option>
					<option>Atacama</option>
					<option>Los Lagos</option>
					<option>Valparaíso</option>
					<option>Los Ríos</option>
					<option>Magallanes</option>
					<option>Valparaíso</option>
					<option>Maule</option>
					<option>Coquimbo</option>
					<option>Maule</option>
					<option>Valparaíso</option>
					<option>Metropolitana de Santiago</option>
					<option>Valparaíso</option>
				</select>
			</div>
			<div class="Casilla2-1">
				<h4>Comuna</h4>					
				<select class="droplist">
					<option value="">Seleccione una comuna</option>
					<option>Cerrillos</option>
					<option>Cerro Navia</option>
					<option>Conchalí</option>
					<option>El Bosque</option>
					<option>Estación Central</option>
					<option>Huechuraba</option>
					<option>Independencia</option>
					<option>La Cisterna</option>
					<option>La Florida</option>
					<option>La Granja</option>
					<option>La Pintana</option>
					<option>La Reina</option>
					<option>Las Condes</option>
					<option>Lo Barnechea</option>
					<option>Lo Espejo</option>
					<option>Lo Prado</option>
					<option>Macul</option>
					<option>Maipú</option>
					<option>Ñuñoa</option>
					<option>Padre Hurtado</option>
					<option>Pedro Aguirre Cerda</option>
					<option>Peñalolén</option>
					<option>Providencia</option>
					<option>Pudahuel</option>
					<option>Puente Alto</option>
					<option>Quilicura</option>
					<option>Quinta Normal</option>
					<option>Recoleta</option>
					<option>Renca</option>
					<option>San Bernardo</option>
					<option>San Joaquín</option>
					<option>San Miguel</option>
					<option>San Ramón</option>
					<option>Santiago</option>
					<option>Vitacura</option>
					<option>--Otra--</option>
				</select>
			</div>
			<div class="Casilla2-1">
			<h4>Correo Electrónico</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Correo Electrónico">
			</div>
			<div class="Casilla2-1">
			<h4>Teléfono</h4>	
			<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Teléfono">
			</div>
	</div>


	<div class="ModificarDatos2">
		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre Usuario</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Correo Electrónico" >
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Nueva Contraseña</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Teléfono">
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Confirmar Contraseña</h4>	
		<input type="text" name="" class="CasillaPersona" placeholder="Ingrese Teléfono">
		</div>
		<div class="Casilla2-2">	
		<input type="submit" name="" class="SubmitTotal" value="Modificar">
		</div>
	</div>
		
</div>

</form>

</asp:Content>
