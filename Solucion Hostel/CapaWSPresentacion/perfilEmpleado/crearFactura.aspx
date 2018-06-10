<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="crearFactura.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.crearFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

     <link rel="stylesheet" type="text/css" href="/scripts/crearFactura.css">

      <form id="form1" runat="server">


	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Crear Factura</h2><br>	
	
		    <div class="Casilla2-1">
			<h4>Rut Cliente</h4>	
                <asp:DropDownList ID="ddlClientes" runat="server"></asp:DropDownList>
			</div>
            <div class="Casilla2-1">
			<h4>Orden de Compra</h4>	
                <asp:DropDownList ID="ddlOrdenesCompra" runat="server"></asp:DropDownList>
			</div>
			<div class="Casilla2-1">
			<h4>Número Factura</h4>	
			<asp:TextBox ID="txtNumeroFactura" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Fecha</h4>	
			<asp:TextBox ID="txtFecha" runat="server" TextMode="Date" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Valor Bruto</h4>	
                <asp:TextBox ID="txtValorBruto" runat="server" TextMode="number" CssClass="CasillaPersona" value="0"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Valor IVA</h4>
			<asp:TextBox ID="txtIVA" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
				<h4>Valor Neto</h4>		
                <asp:TextBox ID="txtNeto" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
			<div class="Casilla2-1">
				<h4>Observación</h4>					
				<asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" CssClass="CasillaPersona"></asp:TextBox>					
			</div>
            <div class="Casilla2-1">
				<h4>Codigo ISO</h4>		
                <asp:TextBox ID="txtCodigoISO" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">
				<h4>Medio de Pago</h4>		
                <asp:DropDownList ID="ddlMedioPago" runat="server"></asp:DropDownList>
			</div>
            <div class="Casilla2-1">
				<h4>Tipo Factura</h4>		
                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
			</div>
            <div class="Casilla2-1">
				<h4>Monto</h4>		
                <asp:TextBox ID="txtMonto" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">
				<h4>Tasa Cambio</h4>		
                <asp:TextBox ID="txtTasaCambio" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">
				<h4>Divisa</h4>		
                <asp:TextBox ID="txtDivisa" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">	
		    <asp:Button ID="btnAgregarFactura" runat="server" Text="Agregar"  CssClass="SubmitTotal" OnClick="btnAgregar_Click"/> 
		</div>
	</div>


	
		
</div>

    </form>


</asp:Content>


