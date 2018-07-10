<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminEingresoProducto.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminEingresoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 <link rel="stylesheet" type="text/css" href="/scripts/productosEmpleado.css">


<form id="form1" runat="server">

<div class="columna2">
	<div class="ModificarDatos">
				
			<h2>Agregar productos a proveedor</h2><br>	
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>				
			<asp:DropDownList ID="txtProveedorAgregar" runat="server" CssClass="droplist">
                <asp:ListItem>Seleccione una opción</asp:ListItem>
            </asp:DropDownList>		
                <br><asp:TextBox ID="TextBox4" Text="* Selecciona Nombre Empresa" runat="server" CssClass="CasillaPersona" Visible="false" ValidationGroup="vgAgregar"></asp:TextBox>
			</div>
			<%--<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<asp:TextBox ID="txtCodProdAgregar" runat="server" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
			</div>--%>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<asp:TextBox ID="txtDetProdAgregar" runat="server" CssClass="CasillaPersona"></asp:TextBox>
                <br><asp:TextBox ID="TextBox3" Text="* Ingrese Detalle Producto" runat="server" CssClass="CasillaPersona" Visible="false" ValidationGroup="vgAgregar"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<asp:TextBox ID="txtPrecioProdAgregar" TextMode="Number" runat="server" CssClass="CasillaPersona" Text="0"></asp:TextBox>
                <br>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="* Ingrese Precio Producto" ControlToValidate="txtPrecioProdAgregar" ValidationGroup="ValidarProducto" MinimumValue="1" MaximumValue="999999999"></asp:RangeValidator>
			</div>
        	<div class="Casilla2-1">
			<h4>Stock</h4>
			<asp:TextBox ID="txtStock" runat="server" Text="0" TextMode="Number" CssClass="CasillaPersona" min="0" Max="100"></asp:TextBox>
                <br>
                <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="* Ingrese Stock" ControlToValidate="txtStock" ValidationGroup="ValidarProducto" MinimumValue="1" MaximumValue="9999999"></asp:RangeValidator>
			</div>
        	<div class="Casilla2-1">
			<h4>Stock Critico</h4>
			<asp:TextBox ID="txtStockCritico" TextMode="Number" Text="0" runat="server" CssClass="CasillaPersona" min="10"></asp:TextBox>
                <br><asp:TextBox ID="TextBox0" Text="* Ingrese Stock Critico" runat="server" CssClass="CasillaPersona" Visible="false" ValidationGroup="ValidarProducto"></asp:TextBox>

			</div>
			<div class="Casilla2-1">	
		    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Producto" CssClass="SubmitTotal" OnClick="btnAgregar_click" ValidationGroup="ValidarProducto" />
			</div>		
	</div>

	<div class="ModificarDatos2">
			<h2>Modificar producto de proveedor</h2><br>	
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>		
                <asp:DropDownList ID="txtProveedorModificar" runat="server" CssClass="droplist" AutoPostBack="True" OnSelectedIndexChanged="txtProveedorModificar_SelectedIndexChanged">
                    <asp:ListItem Value="">Seleccione una comuna</asp:ListItem>
                    <asp:ListItem Value="2">Empresa 1</asp:ListItem>
                    <asp:ListItem Value="3">Empresa 2</asp:ListItem>
                    <asp:ListItem Value="4">Empresa 3</asp:ListItem>
                    <asp:ListItem Value="5">Empresa 4</asp:ListItem>
                </asp:DropDownList>
                <br>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Seleccione Nombre Empresa" ControlToValidate="txtProveedorModificar" ValidationGroup="vgModificar"></asp:RequiredFieldValidator>
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
                <asp:DropDownList ID="txtProductoModificar" runat="server" CssClass="droplist" AutoPostBack="True" OnSelectedIndexChanged="txtProductoModificar_SelectedIndexChanged">
                    <asp:ListItem Value="1">Seleccione una comuna</asp:ListItem>
                    <asp:ListItem Value="2">Cod 1</asp:ListItem>
                    <asp:ListItem Value="3">Cod 2</asp:ListItem>
                    <asp:ListItem Value="4">Cod 3</asp:ListItem>
                    <asp:ListItem Value="5">Cod 4</asp:ListItem>
                </asp:DropDownList>
                <br>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Seleccione Nombre Empresa" ControlToValidate="txtProductoModificar" ValidationGroup="vgModificar"></asp:RequiredFieldValidator>
            </div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<asp:TextBox ID="txtPrecioModificar" TextMode="Number" runat="server" CssClass="CasillaPersona" min ="0"></asp:TextBox>
                <br>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="* Ingrese Precio Producto" ControlToValidate="txtPrecioModificar" ValidationGroup="vgModificar" MinimumValue="1" MaximumValue="9999999"></asp:RangeValidator>
			</div>
             <div class="Casilla2-1">
			<h4>Stock</h4>
			<asp:TextBox ID="txtStockModificar" TextMode="Number" runat="server" CssClass="CasillaPersona" min ="0"></asp:TextBox>
                 <br>
                 <asp:RangeValidator ID="RangeValidator4" runat="server" ErrorMessage="* Ingrese Stock" ControlToValidate="txtStockModificar" ValidationGroup="vgModificar" MinimumValue="1" MaximumValue="9999999"></asp:RangeValidator>
			</div>
            <div class="Casilla2-1">
			<h4>Stock Critico</h4>
			<asp:TextBox ID="txtStockCriticoModificar" TextMode="Number" runat="server" CssClass="CasillaPersona" min ="0"></asp:TextBox>
                <br>
                <asp:RangeValidator ID="RangeValidator5" runat="server" ErrorMessage="* Ingrese Stock Critico" ControlToValidate="txtStockCriticoModificar" ValidationGroup="vgModificar"></asp:RangeValidator>
			</div>
			<div class="Casilla2-1">	
			<asp:Button ID="btnModificar" runat="server" Text="Modificar Producto" CssClass="SubmitTotal" OnClick="btnModificar_click" Enabled="False" ValidationGroup="vgModificar" />
			</div>
			
	</div>


		
</div>

    </form>

</asp:Content>
