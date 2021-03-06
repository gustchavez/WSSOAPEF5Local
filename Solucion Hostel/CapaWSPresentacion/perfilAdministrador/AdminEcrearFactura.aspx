﻿<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminEcrearFactura.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminEcrearFactura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="/scripts/crearFactura.css">
      <form id="form1" runat="server">
	<div class="columna2">
		<div class="ModificarDatos">
				
			<h2>Crear Factura</h2><br>	
	
            <div class="Casilla2-1">
				<h4>Tipo Empresa</h4>		
                <asp:DropDownList ID="ddlTipoEmpresa" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoEmpresa_SelectedIndexChanged">
                    <asp:ListItem>Cliente</asp:ListItem>
                    <asp:ListItem>Proveedor</asp:ListItem>
                </asp:DropDownList>
                <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Tipo Empresa" ControlToValidate="ddlTipoEmpresa" ID="RequiredFieldValidator4" runat="server" ></asp:RequiredFieldValidator>
			</div>
		    <div class="Casilla2-1">
			<h4>Empresas</h4>	
                <asp:DropDownList ID="ddlEmpresas" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged" ></asp:DropDownList>
                <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Empresas" ControlToValidate="ddlEmpresas" ID="RequiredFieldValidator1" runat="server" ></asp:RequiredFieldValidator>
			</div>
            <div class="Casilla2-1">
			<h4>Ordenes</h4>	
                <asp:DropDownList ID="ddlOrdenes" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrdenes_SelectedIndexChanged">
                    <asp:ListItem Value="Seleccione una opción">Seleccione una opción</asp:ListItem>
                    <asp:ListItem Value="de Compra">Compra</asp:ListItem>
                    <asp:ListItem Value="de Venta">Pedido</asp:ListItem>
                </asp:DropDownList>
                <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Orden" ControlToValidate="ddlOrdenes" ID="RequiredFieldValidator2" runat="server" ></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Valor Bruto</h4>	
                <asp:TextBox ID="txtValorBruto" runat="server" TextMode="number" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
                <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Valor Bruto" ControlToValidate="txtValorBruto" ID="RequiredFieldValidator3" runat="server" ></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Valor IVA</h4>
			<asp:TextBox ID="txtValorIVA" runat="server" TextMode="number" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
                <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Valor IVA" ControlToValidate="txtValorIVA" ID="RequiredFieldValidator5" runat="server" ></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
				<h4>Valor Neto</h4>		
                <asp:TextBox ID="txtValorNeto" runat="server" TextMode="number" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>			
                <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Valor Neto" ControlToValidate="txtValorNeto" ID="RequiredFieldValidator6" runat="server" ></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Fecha</h4>	
			<asp:TextBox ID="txtFecha" runat="server" TextMode="Date" CssClass="CasillaPersona"></asp:TextBox>
                <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Fecha" ControlToValidate="txtFecha" ID="RequiredFieldValidator7" runat="server" ></asp:RequiredFieldValidator>
			</div>
            <div class="Casilla2-1">
				<h4>Medio de Pago</h4>		
                <asp:DropDownList ID="ddlMedioPago" CssClass="droplist" runat="server">
                    <asp:ListItem Value="Debito">Débito</asp:ListItem>
                    <asp:ListItem Value="Credito">Crédito</asp:ListItem>
                    <asp:ListItem Value="Transferencia electronica">Transferencia Electrónica</asp:ListItem>
                </asp:DropDownList>
                <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Medio de Pago" ControlToValidate="ddlMedioPago" ID="RequiredFieldValidator8" runat="server" ></asp:RequiredFieldValidator>
			</div>
            <div class="Casilla2-1">
				<h4>Codigo Moneda</h4>		
                <asp:DropDownList ID="ddlCodigoISO" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCodigoISO_SelectedIndexChanged">
                    <asp:ListItem Value="1">CLP</asp:ListItem>
                    <asp:ListItem Value="650">USD</asp:ListItem>
                    <asp:ListItem Value="190">BRL</asp:ListItem>
                    <asp:ListItem Value="750">EUR</asp:ListItem>
                </asp:DropDownList>	
                <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Codigo Moneda" ControlToValidate="ddlCodigoISO" ID="RequiredFieldValidator9" runat="server" ></asp:RequiredFieldValidator>
			</div>
            <div class="Casilla2-1">
				<h4>Monto</h4>		
                <asp:TextBox ID="txtMonto" runat="server" TextMode="number" CssClass="CasillaPersona"></asp:TextBox>			
                <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Monto" ControlToValidate="txtMonto" ID="RequiredFieldValidator10" runat="server" ></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
				<h4>Observación</h4>					
				<asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" CssClass="CasillaPersona"></asp:TextBox>					
                <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Observación" ControlToValidate="txtObservacion" ID="RequiredFieldValidator11" runat="server" ></asp:RequiredFieldValidator>
			</div>
            <div class="Casilla2-1">	
		        <asp:Button ID="btnAgregarFactura" runat="server" Text="Agregar"  CssClass="SubmitTotalfactura2" OnClick="btnAgregar_Click"/> 
		    </div>
	</div>
    <div class="ModificarDatos22">
       
		    <h2>Detalle Orden</h2><br>
            <asp:GridView ID="gwOrdenDetalle" runat="server" CssClass="listaFactura85"
                EmptyDataText="No se encontraron Solicitudes..."
                ></asp:GridView>
	  
    </div>
		
</div>

    </form>


</asp:Content>


