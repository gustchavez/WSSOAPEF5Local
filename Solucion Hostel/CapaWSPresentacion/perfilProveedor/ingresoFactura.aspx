<%@ Page Title="" Language="C#" MasterPageFile="~/perfilProveedor/MasterProveedor.Master" AutoEventWireup="true" CodeBehind="ingresoFactura.aspx.cs" Inherits="CapaWSPresentacion.perfilProveedor.ingresoFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/crearFactura.css">

      <form id="form1" runat="server">


	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Crear Factura</h2><br>	
	
            <div class="Casilla2-1">
			<h4>Ordenes</h4>	
                <asp:DropDownList ID="ddlOrdenes" CssClass="droplist" runat="server">
                    <asp:ListItem Value="de Compra">Compra</asp:ListItem>
                    <asp:ListItem Value="de Venta">Pedido</asp:ListItem>
                </asp:DropDownList>
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
			<asp:TextBox ID="txtValorIVA" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
				<h4>Valor Neto</h4>		
                <asp:TextBox ID="txtValorNeto" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
			<div class="Casilla2-1">
				<h4>Observación</h4>					
				<asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" CssClass="CasillaPersona"></asp:TextBox>					
			</div>
            <div class="Casilla2-1">
				<h4>Codigo ISO</h4>		
                <asp:TextBox ID="txtCodigoISO" runat="server" CssClass="CasillaPersona"></asp:TextBox>			
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
				<h4>Monto</h4>		
                <asp:TextBox ID="txtMonto" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">
				<h4>Tasa Cambio</h4>		
                <asp:TextBox ID="txtTasaCambio" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">
				<h4>Divisa</h4>		
                <asp:TextBox ID="txtDivisa" runat="server" CssClass="CasillaPersona"></asp:TextBox>			
			</div>
            <div class="Casilla2-1">	
		    <asp:Button ID="btnAgregarFactura" runat="server" Text="Agregar"  CssClass="SubmitTotal" OnClick="btnAgregar_Click"/> 
		</div>
	</div>


	
		
</div>

    </form>

</asp:Content>
