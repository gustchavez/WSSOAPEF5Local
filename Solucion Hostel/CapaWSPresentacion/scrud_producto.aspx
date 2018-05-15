<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scrud_producto.aspx.cs" Inherits="CapaWSPresentacion.scrud_producto" %>

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
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <div class="Casilla2-1">
                    <td><h4>Codigo</h4></td>
                    <td><asp:TextBox ID="txtCodigo" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox></td>
                </div>
            </tr>
            <tr>
                <div class="Casilla2-1">
                    <td>Descripción</td>
                    <td><asp:TextBox ID="txtDescripcion" runat="server" CssClass="CasillaPersona"></asp:TextBox></td>
                </div>
            </tr>
            <tr>
                <td style="width:25%;">Precio</td>
                <td style="width:75%;"><asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Stock</td>
                <td style="width:75%;"><asp:TextBox ID="txtStock" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Stock Critico</td>
                <td style="width:75%;"><asp:TextBox ID="txtStockCritico" runat="server" TextMode="Number" CssClass="CasillaPersona"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Codigo Retorno</td>
                <td style="width:75%;"><asp:TextBox ID="txtCodigoRetorno" runat="server" Enabled="False" CssClass="CasillaPersona"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Glosa Retorno</td>
                <td style="width:75%;"><asp:TextBox ID="txtGlosaRetorno" runat="server" Enabled="False" Width="387px" CssClass="CasillaPersona"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">&nbsp;</td>
                <td style="width:75%;"><asp:Button ID="btnCrear" runat="server" Text="Crear" Width="88px" OnClick="btnCrear_Click" />
                    <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
                    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                </td>
            </tr>
        </table>    
    
        <br />
    
        Lista de Productos
        <asp:GridView ID="gwListaProductos" runat="server"></asp:GridView>
        <br />
    </div>
    </form>
</body>
</html>
