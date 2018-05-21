<%@ Page Title="" Language="C#" MasterPageFile="~/SitioPrincipal.Master" AutoEventWireup="true" CodeBehind="np_cliente_crear.aspx.cs" Inherits="CapaWSPresentacion.np_cliente_crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <table style="width:75%;">
        <tr>
            <td style="width:25%;">Rut Empresa </td>
            <td style="width:75%;">
                <asp:TextBox ID="txtRutEmpresa" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Razón Social</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtRazonSocial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Giro</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtGiro" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Correo Electrónico</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Teléfono Empresa</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtTelefonoEmpresa" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Codigo Postal</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtCodigoPostal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Nombre Ciudad</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtNombreCiudad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Comuna</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtComuna" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Calle</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtCalle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Numero</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtNumero" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Logo</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtLogo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Rut Empleado</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtRutEmpleado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Nombre Empleado</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtNombreEmpleado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Apellido Empleado</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtxApellidoEmpleado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Fecha Nacimiento</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Correo Empleado</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtCorreoEmpleado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Teléfono Empleado</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtTelefonoEmpleado" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Contraseña </td>
            <td style="width:75%;">
                <asp:TextBox ID="txtConstrasena" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Codigo Retorno</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtCodigoRetorno" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">Glosa Retorno</td>
            <td style="width:75%;">
                <asp:TextBox ID="txtGlosaRetorno" runat="server" Enabled="False" Width="387px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width:25%;">&nbsp;</td>
            <td style="width:75%;">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" Width="88px" OnClick="btnAceptar_Click" style="height: 26px" />
            </td>
        </tr>
    </table>
</asp:Content>

