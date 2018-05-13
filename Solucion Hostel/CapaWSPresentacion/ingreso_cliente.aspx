<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ingreso_cliente.aspx.cs" Inherits="CapaWSPresentacion.ingreso_cliente" %>

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
                <td style="width:25%;">Nombre Usuario</td>
                <td style="width:75%;"><asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Clave Usuario</td>
                <td style="width:75%;"><asp:TextBox ID="txtClaveUsuario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Perfil Usuario</td>
                <td style="width:75%;"><asp:TextBox ID="txtPerfilUsuario" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Nombre Persona</td>
                <td style="width:75%;"><asp:TextBox ID="txtNombrePersona" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Apellido Persona</td>
                <td style="width:75%;"><asp:TextBox ID="txtApellidoPersona" runat="server" Enabled="False"></asp:TextBox></td>
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
                <td style="width:75%;"><asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="88px" OnClick="btnAceptar_Click" /></td>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>
