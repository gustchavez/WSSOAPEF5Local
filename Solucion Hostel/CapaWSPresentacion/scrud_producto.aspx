<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scrud_producto.aspx.cs" Inherits="CapaWSPresentacion.scrud_producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:75%;">
            <tr>
                <td style="width:25%;">Codigo</td>
                <td style="width:75%;"><asp:TextBox ID="txtCodigo" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Descripción</td>
                <td style="width:75%;"><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Precio</td>
                <td style="width:75%;"><asp:TextBox ID="txtPrecio" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Stock</td>
                <td style="width:75%;"><asp:TextBox ID="txtStock" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Stock Critico</td>
                <td style="width:75%;"><asp:TextBox ID="txtStockCritico" runat="server" TextMode="Number"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Codigo Retorno</td>
                <td style="width:75%;"><asp:TextBox ID="txtCodigoRetorno" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Glosa Retorno</td>
                <td style="width:75%;"><asp:TextBox ID="txtGlosaRetorno" runat="server" Enabled="False" Width="387px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">&nbsp;</td>
                <td style="width:75%;"><asp:Button ID="btnCrear" runat="server" Text="Crear" Width="88px" OnClick="btnAceptar_Click" />
                    <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
                    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                </td>
            </tr>
        </table>    
    
        Lista de Productos
        <asp:GridView ID="gwListaProductos" runat="server"></asp:GridView>
        <asp:ObjectDataSource ID="dsListaProductos" runat="server"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
