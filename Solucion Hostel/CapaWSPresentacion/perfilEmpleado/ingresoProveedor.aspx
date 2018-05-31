<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="IngresoProveedor.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.IngresoProveedor" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="padre">
        <div class="menu">
            <div class="BotonMenu" onclick="efecto()">
                MENU</div>
            <div class="desplegable">
                <div class="subMenu">
                    <div class="imagen-logo">
                    </div>
                </div>
                <div class="subMenu">
                    <a href="stockEmpleado.html" style="color: #e2e2e2;">Stock Productos </a>
                </div>
                <div class="subMenu">
                    <a href="perfilEmpleado.html" style="color: #e2e2e2;">Modificar Perfil </a>
                </div>
                <div class="subMenu">
                    <a href="facturaEmpleado.html" style="color: #e2e2e2;">Ver Facturas Proveedores </a>
                </div>
                <div class="subMenu">
                    <a href="empresaEmpleado.html" style="color: #e2e2e2;">Ingresar Empresa </a>
                </div>
                <div class="subMenu">
                    <a href="productosEmpleado.html" style="color: #e2e2e2;">Ingresar Productos </a>
                </div>
                <div class="subMenu">
                    <a href="solicitarEmpleado.html" style="color: #e2e2e2;">Solicitar Productos </a>
                </div>
                <br>
                <div class="subMenu">
                    <a href="ingreso.html" style="color: #e2e2e2;">Cerrar Sesión</a></div>
            </div>
        </div>
    </div>
</asp:Content>

