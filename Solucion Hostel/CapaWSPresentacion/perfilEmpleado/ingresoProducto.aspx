<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="ingresoProducto.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.ingresoProducto" %>
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
			</div>
			<%--<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<asp:TextBox ID="txtCodProdAgregar" runat="server" CssClass="CasillaPersona" Enabled="False"></asp:TextBox>
			</div>--%>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<asp:TextBox ID="txtDetProdAgregar" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<asp:TextBox ID="txtPrecioProdAgregar" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
        	<div class="Casilla2-1">
			<h4>Stock</h4>
			<asp:TextBox ID="txtStock" runat="server" CssClass="CasillaPersona" min="0" Max="100"></asp:TextBox>
			</div>
        	<div class="Casilla2-1">
			<h4>Stock Critico</h4>
			<asp:TextBox ID="txtStockCritico" runat="server" CssClass="CasillaPersona" min="10"></asp:TextBox>
			</div>
			<div class="Casilla2-1">	
		    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Producto" CssClass="SubmitTotal" OnClick="btnAgregar_click" />
			</div>		
	</div>

	<div class="ModificarDatos2">
			<h2>Modificar producto de proveedor</h2><br>	
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>		
                <asp:DropDownList ID="txtProveedorModificar" runat="server" CssClass="droplist" AutoPostBack="True" OnSelectedIndexChanged="txtProveedorModificar_SelectedIndexChanged">
                    <asp:ListItem Value="1">Seleccione una comuna</asp:ListItem>
                    <asp:ListItem Value="2">Empresa 1</asp:ListItem>
                    <asp:ListItem Value="3">Empresa 2</asp:ListItem>
                    <asp:ListItem Value="4">Empresa 3</asp:ListItem>
                    <asp:ListItem Value="5">Empresa 4</asp:ListItem>
                </asp:DropDownList>
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
                <asp:DropDownList ID="txtProductoModificar" runat="server" CssClass="droplist">
                    <asp:ListItem Value="1">Seleccione una comuna</asp:ListItem>
                    <asp:ListItem Value="2">Cod 1</asp:ListItem>
                    <asp:ListItem Value="3">Cod 2</asp:ListItem>
                    <asp:ListItem Value="4">Cod 3</asp:ListItem>
                    <asp:ListItem Value="5">Cod 4</asp:ListItem>
                </asp:DropDownList>
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<asp:TextBox ID="txtPrecioModificar" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
             <div class="Casilla2-1">
			<h4>Stock</h4>
			<asp:TextBox ID="txtStockModificar" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
            <div class="Casilla2-1">
			<h4>Stock Critico</h4>
			<asp:TextBox ID="txtStockCriticoModificar" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">	
			<asp:Button ID="btnModificar" runat="server" Text="Modificar Producto" CssClass="SubmitTotal" OnClick="btnModificar_click" Enabled="False" />
			</div>
			
	</div>


		
</div>

    </form>

</asp:Content>
