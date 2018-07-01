<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="ingresoFactura.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.ingresoFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/crearFactura.css">

      <form id="form1" runat="server">


	<div class="columna2">
		<div class="ModificarDatosd">
				
			<h2>Crear Factura</h2><br>	
	
            <div class="Casilla2-1">
			<h4>Ordenes</h4>	
                <asp:DropDownList ID="ddlOrdenes" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrdenes_SelectedIndexChanged">
                    <asp:ListItem Value="Seleccione una opcion">Seleccione una opción</asp:ListItem>
                    <asp:ListItem Value="de Compra">Compra</asp:ListItem>
                    <asp:ListItem Value="de Venta">Pedido</asp:ListItem>
                </asp:DropDownList>
			</div>
			<div class="Casilla2-1">
			<h4>Valor Bruto</h4>	
                <asp:TextBox ID="txtValorBruto" runat="server" TextMode="number" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Valor IVA</h4>
			<asp:TextBox ID="txtValorIVA" runat="server" TextMode="number" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
				<h4>Valor Neto</h4>		
                <asp:TextBox ID="txtValorNeto" runat="server" TextMode="number" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>			
			</div>
			<div class="Casilla2-1">
			<h4>Fecha</h4>	
			<asp:TextBox ID="txtFecha" runat="server" TextMode="Date" CssClass="CasillaPersona"></asp:TextBox>
			</div>
            <div class="Casilla2-1">
				<h4>Medio de Pago</h4>		
                <asp:DropDownList ID="ddlMedioPago" CssClass="droplist" runat="server">
                    <asp:ListItem Value="Debito">Débito</asp:ListItem>
                    <asp:ListItem Value="Credito">Crédito</asp:ListItem>
                    <asp:ListItem Value="Transferencia electronica">Transferencia Electrónica</asp:ListItem>
                </asp:DropDownList>
			</div>
            <div class="Casilla2-1">
				<h4>Codigo Moneda</h4>		
                <asp:DropDownList ID="ddlCodigoISO" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCodigoISO_SelectedIndexChanged">
                    <asp:ListItem Value="1">CLP</asp:ListItem>
                    <asp:ListItem Value="650">USD</asp:ListItem>
                    <asp:ListItem Value="190">BRL</asp:ListItem>
                    <asp:ListItem Value="750">EUR</asp:ListItem>
                </asp:DropDownList>	
			</div>
            <div class="Casilla2-1">
				<h4>Monto</h4>		
                <asp:TextBox ID="txtMonto" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
			<div class="Casilla2-1">
				<h4>Observación</h4>					
				<asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" CssClass="CasillaPersona"></asp:TextBox>					
			</div>
            <div class="Casilla2-1">	
		        <asp:Button ID="btnAgregarFactura" runat="server" Text="Crear Factura"  CssClass="SubmitTotalfactura" OnClick="btnAgregar_Click" OnClientClick="return valida();"/> 
		    </div>
	</div>
    <div class="ModificarDatos2">
        <div class="columna2-1"> 
		    <h2>Detalle Orden</h2><br>
            <asp:GridView ID="gwOrdenDetalle" runat="server" CssClass="listaFactura"
                EmptyDataText="No se encontraron Solicitudes..."
                ></asp:GridView>
	    </div>
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
                <div class="error" id="error9"> Ingrese un número de telefono </div>
                <div class="error" id="error10"> Ingrese una contraseña </div>
            </div>		
</div>
    </form>




     <!----VALIDACIONES ------->

<script type="text/javascript">
     function valida() 
     {      
         var razonSocial = document.getElementById('<%= ddlOrdenes.ClientID %>').value;
         var rubro = document.getElementById('<%= txtValorBruto.ClientID %>').value;
         var direccion = document.getElementById('<%= txtValorIVA.ClientID %>').value;
         var ciudad = document.getElementById('<%= txtValorNeto.ClientID %>').value;
         var comuna = document.getElementById('<%= txtFecha.ClientID %>').value;
         var correo = document.getElementById('<%= ddlMedioPago.ClientID %>').value;
         var telefono = document.getElementById('<%= ddlCodigoISO.ClientID %>').value;
         var monto = document.getElementById('<%= txtMonto.ClientID %>').value;
         var observacion = document.getElementById('<%= txtObservacion.ClientID %>').value;

         if (razonSocial == "" || razonSocial == null || razonSocial == "Seleccione una opcion") {
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

         if (monto == "" || monto == null || monto == "Selecciona un Giro") {
             $('#error9').fadeIn(500);
         } else {
             $('#error9').fadeOut(500);
         }

         if (observacion == "" || observacion == null || observacion == "Selecciona un Giro") {
             $('#error10').fadeIn(500);
         } else {
             $('#error10').fadeOut(500);
         }
         return false;
     }
 </script>

</asp:Content>
