<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud_producto.aspx.cs" Inherits="CapaWSPresentacion.scrud_producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="scripts/productosEmpleado.css"/>
	<script src="scripts/efectos.js"></script>
	<script src="scripts/jquery.min.js"></script>
</head>
<body>

<!-- Inicio Columna 1 --> 
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
<!-- Fin Columna 1 --> 
<!-- Inicio Columna 2 --> 
    
    <div class="columna2">
        <div class="ModificarDatos">

          <h2>Agregar productos a proveedor</h2>
          <form id="form1" runat="server">

            <div class="Casilla2-1">
                <h4>Codigo</h4>
                <asp:TextBox ID="txtCodigo" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <h4>Descripción</h4>
                <asp:TextBox ID="txtDescripcion" runat="server"  CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <h4>Precio</h4>
                <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <h4>Stock</h4>
                <asp:TextBox ID="txtStock" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <h4>Stock Critico</h4>
                <asp:TextBox ID="txtStockCritico" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            
            <div class="Casilla2-1">
                <h4>Codigo Retorno</h4>
                <asp:TextBox ID="txtCodigoRetorno" runat="server" Enabled="False" CssClass="CasillaPersona"></asp:TextBox>
            </div>
             <div class="Casilla2-1">
                <h4> Glosa</h4>
                <asp:TextBox ID="txtGlosaRetorno" runat="server" Enabled="False" CssClass="CasillaPersona"></asp:TextBox>
            </div>
            <div class="Casilla2-1">
                <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="SubmitTotal" OnClick="btnCrear_Click" />
            </div>
            <div class="Casilla2-1">
                <asp:Button ID="btnActualizar" runat="server" CssClass="SubmitTotal" OnClick="btnActualizar_Click" Text="Actualizar" />
            </div>
            <div class="Casilla2-1">
                <asp:Button ID="btnEliminar" runat="server" CssClass="SubmitTotal" OnClick="btnEliminar_Click" Text="Eliminar" />
            </div>
          
            <br />
            <asp:GridView ID="gwListaProductos" runat="server"></asp:GridView>
            <br />
         </form>
        </div>
    </div>


<!-- Fin Columna 2 --> 


</body>
</html>
