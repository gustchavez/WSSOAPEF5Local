<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminESolicitarPP.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminSolicitarPP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/AdminSolicitarPP.css">

    <form id="form1" runat="server">
        
	<div class="columna2">	
	
	    <div class="ModificarDatos2">
		    <h2>Solicitar productos a proveedor</h2>
		    <h4>Seleccione cod. producto y cantidad o nombre de producto y cantidad </h4>
		    <div class="Casilla2-2" >
		        <h4 style="color: orange;">Proveedor</h4>
                <asp:DropDownList ID="txtProveedor" runat="server" CssClass="selectO" AutoPostBack="True" OnSelectedIndexChanged="txtProveedor_SelectedIndexChanged">
                    <asp:ListItem>Seleccione una opción</asp:ListItem>
                    </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Seleccione proveedor" ControlToValidate="txtProveedor"></asp:RequiredFieldValidator>
		    </div>        
		    <div class="Casilla2-2">
		        <h4 style="color: orange;">Nombre producto</h4>	
		        <asp:DropDownList ID="txtProducto" runat="server" CssClass="selectO" Enabled="False">
                    <asp:ListItem>Seleccione una opción</asp:ListItem>
                    </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Seleccione Producto" ControlToValidate="txtProducto"></asp:RequiredFieldValidator>
		    </div>
		    <div class="Casilla2-2">
		        <h4 style="color: orange;">Cantidad</h4>	
	            <asp:TextBox ID="txtCantidad" runat="server" CssClass="CasillaPersona2" Enabled="False" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCantidad" ErrorMessage="* Ingrese Cantidad"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="* Ingrese Cantidad" ControlToValidate="txtCantidad" MinimumValue="0" MaximumValue="9999999999"></asp:RangeValidator>
		    </div>
		    <div class="Casilla2-2">	
	            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="SubmitTotal" OnClick="btnAgregar_Click" Enabled="False" />
		    </div>
	    </div>
	
	    <div class="contenedorTabla">
            <asp:GridView ID="gwListaCompra" runat="server" CssClass="tabla" style="left: 0px; top: 50px"
                EmptyDataText="Agregue Productos..." OnRowDeleting="gwListaCompra_RowDeleting">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>

		    <div class="Casilla2-1">	
		        <asp:Button ID="btnRealizar" runat="server" Text="Realizar Solicitud" CssClass="SubmitTotal2" OnClick="btnRealizar_Click" />
		    </div>
	    </div>		
    </div>

    </form>
</asp:Content>
