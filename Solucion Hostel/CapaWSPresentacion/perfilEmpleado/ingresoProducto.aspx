﻿<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="ingresoProducto.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.ingresoProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link rel="stylesheet" type="text/css" href="/scripts/productosEmpleado.css">


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
	<div class="ModificarDatos">
				
			<h2>Agregar productos a proveedor</h2><br>	
	
		
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>				
			<asp:DropDownList ID="txtProveedorAgregar" runat="server" CssClass="droplist">
            </asp:DropDownList>		
			</div>
			<div class="Casilla2-1">
			<h4>Cod. Producto</h4>	
			<asp:TextBox ID="TextBox1" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Detalle Producto</h4>	
			<asp:TextBox ID="TextBox2" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<asp:TextBox ID="TextBox3" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">	
		    <asp:Button ID="btnAgregar" runat="server" Text="Agregar Producto" CssClass="SubmitTotal" />
			</div>
			
	</div>
	<hr style="opacity: 0.1">
	<div class="ModificarDatos">
			<h2>Modificar producto de proveedor</h2><br>	
			<div class="Casilla2-1">
			<h4>Nombre Empresa</h4>		
                <asp:DropDownList ID="txtProveedorModificar" runat="server" CssClass="droplist">
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
			<h4>Detalle Producto</h4>	
			<asp:TextBox ID="TextBox4" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">
			<h4>Precio Producto</h4>
			<asp:TextBox ID="TextBox5" runat="server" CssClass="CasillaPersona"></asp:TextBox>
			</div>
			<div class="Casilla2-1">	
			<asp:Button ID="btnModificar" runat="server" Text="Modificar Producto" CssClass="SubmitTotal" />
			</div>
			
	</div>


		
</div>

    </form>

</asp:Content>
