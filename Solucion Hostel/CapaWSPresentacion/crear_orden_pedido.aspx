﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crear_orden_pedido.aspx.cs" Inherits="CapaWSPresentacion.crear_orden_pedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="scripts/jquery-3.3.1.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            width: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="tablaEncabezado" style="width: 75%;">
            <tr>
                <th>Numero Orden</th>
                <th>Monto</th>
                <th>Rut Proveedor</th>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtNumeroOrden" runat="server"></asp:TextBox></td>
                <td class="auto-style1"><asp:TextBox ID="txtMonto" runat="server" TextMode="Number"></asp:TextBox></td>
                <td><asp:TextBox ID="txtRutProveedor" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <table >
            <tr>
                <td style="width:25%;">Codigo Retorno</td>
                <td style="width:75%;"><asp:TextBox ID="txtCodigoRetorno" runat="server" Enabled="False"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width:25%;">Glosa Retorno</td>
                <td style="width:75%;"><asp:TextBox ID="txtGlosaRetorno" runat="server" Enabled="False" Width="387px"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="88px" style="height: 26px" OnClick="btnIngresar_Click" />
        <br />
        <br />
        <br />
    </div>
    </form>
    <script src="scripts/funciones.js"></script>
</body>
</html>
