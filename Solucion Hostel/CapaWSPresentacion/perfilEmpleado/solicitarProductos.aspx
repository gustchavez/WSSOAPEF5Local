<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="solicitarProductos.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.solicitarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" type="text/css" href="/scripts/solicitarEmpleado.css">

<form id="form1" runat="server">

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
	<!--Fin COLUMNA1-->

<div class="columna2">
	
	
	<div class="ModificarDatos2" style="left: 0px; top: 30px">
		
		<h2>Solicitar productos</h2>
		<h4>Seleccione cod. producto y cantidad o nombre de producto y cantidad </h4>
		<div class="Casilla2-2" >
		<h4 style="color: red;">Proveedor</h4>
        <asp:DropDownList ID="txtProveedor" runat="server" CssClass="selectO">
            </asp:DropDownList>
		</div>        
		<div class="Casilla2-2">	
	    <asp:Button ID="btnSelectProveedor" runat="server" Text="Elegir Proveedor" CssClass="SubmitTotal" OnClick="btnSelectProveedor_Click"/>
		</div>

		<div class="Casilla2-2">
		<h4 style="color: red;">Nombre producto</h4>	
		<asp:DropDownList ID="txtProducto" runat="server" CssClass="selectO" Enabled="False">
            </asp:DropDownList>
		</div>
		<div class="Casilla2-2">
		<h4 style="color: red;">Cantidad</h4>	
	    <asp:TextBox ID="txtCantidad" runat="server" CssClass="CasillaPersona2" Enabled="False"></asp:TextBox>
		</div>
		<div class="Casilla2-2">	
	    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="SubmitTotal" OnClick="btnAgregar_Click" Enabled="False" />
		</div>
	</div>
	
	<div class="contenedorTabla">
		

        <asp:GridView ID="gwListaCompra" runat="server" CssClass="tabla" style="left: 0px; top: 50px">
        </asp:GridView>

		<div class="Casilla2-1">	
		 <asp:Button ID="btnRealizar" runat="server" Text="Realizar" CssClass="SubmitTotal" OnClick="btnRealizar_Click" />
		</div>
	    
	</div>		
</div>

</form>
</asp:Content>
