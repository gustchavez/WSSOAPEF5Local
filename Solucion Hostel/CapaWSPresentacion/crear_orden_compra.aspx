<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crear_orden_compra.aspx.cs" Inherits="CapaWSPresentacion.crear_orden_compra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="scripts/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table id="tablaEncabezado" style="width: 75%;">
            <tr>
                <th>Numero Orden</th>
                <th>Fecha Recepción</th>
                <th>Rut Cliente</th>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtNumeroOrden" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtFechaRecepcion" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtRutCliente" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <input id="htmlbtnAgregar" type="button" value="Agregar Detalle" />
        <table id="tablaDetalle" style="width: 75%;">
            <tr>
                <th>Fecha Ingreso</th>
                <th>Fecha Egreso</th>
                <th>Observsación Cama</th>
            </tr>
            <tr>
                <td><asp:TextBox ID="txtFechaIngreso" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtFechaEgreso" runat="server"></asp:TextBox></td>
                <td><asp:TextBox ID="txtObservacionCama" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="88px" style="height: 26px" OnClick="btnIngresar_Click" />
    </div>
    </form>
    <script src="scripts/funciones.js"></script>
</body>
</html>
