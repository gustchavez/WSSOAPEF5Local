<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crud_plato.aspx.cs" Inherits="CapaWSPresentacion.crud_plato" %>

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
                <td style="width:25%;">Nombre</td>
                <td style="width:75%;"><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Descripcion</td>
                <td style="width:75%;"><asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Disponible</td>
                <td style="width:75%;">
                    <asp:DropDownList ID="ddlDisponible" runat="server">
                        <asp:ListItem Selected="True">Si</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width:25%;">Tipo Servicio</td>
                <td style="width:75%;">
                    <asp:DropDownList ID="ddlServicioTipo" runat="server">
                    </asp:DropDownList>
                </td>
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
                <td style="width:75%;"><asp:Button ID="btnCrear" runat="server" Text="Crear" Width="88px" OnClick="btnCrear_Click" />
                    <asp:Button ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Actualizar" />
                    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                </td>
            </tr>
        </table>    
    
        Lista de Productos
        <asp:GridView ID="gwListaPlatos" runat="server"></asp:GridView>
    
    </div>
    </form>
</body>
</html>
