<%@ Page Title="" Language="C#" MasterPageFile="~/SitioPrincipal.Master" AutoEventWireup="true" CodeBehind="np_orden_reserva_crear.aspx.cs" Inherits="CapaWSPresentacion.np_orden_reserva_crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <div>
            <table id="tablaEncabezado" style="width: 75%;">
                <tr>
                    <th>Numero Orden</th>
                    <th>Monto</th>
                    <th>Rut Cliente</th>
                </tr>
                <tr>
                    <td><asp:TextBox ID="txtNumeroOrden" runat="server"></asp:TextBox></td>
                    <td class="auto-style1"><asp:TextBox ID="txtMonto" runat="server" TextMode="Number"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtRutCliente" runat="server"></asp:TextBox></td>
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
    </asp:PlaceHolder>
</asp:Content>

