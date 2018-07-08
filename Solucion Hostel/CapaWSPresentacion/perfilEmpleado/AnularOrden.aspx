<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="AnularOrden.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.AnularOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="/scripts/crearFactura.css">
    <form id="form1" runat="server">
	    <div class="columna2">
		    <div class="ModificarDatos">			
			    <h2>Anular Orden</h2><br>	
                <div class="Casilla2-1">
				    <h4>Tipo Empresa</h4>		
                    <asp:DropDownList ID="ddlTipoEmpresa" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoEmpresa_SelectedIndexChanged">
                        <asp:ListItem>Cliente</asp:ListItem>
                        <asp:ListItem>Proveedor</asp:ListItem>
                    </asp:DropDownList>
                    <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Tipo Empresa" ControlToValidate="ddlTipoEmpresa" ID="RequiredFieldValidator2" runat="server" ></asp:RequiredFieldValidator>
			    </div>
		        <div class="Casilla2-1">
			        <h4>Empresas</h4>	
                    <asp:DropDownList ID="ddlEmpresas" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged" ></asp:DropDownList>
			    <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Empresa" ControlToValidate="ddlEmpresas" ID="RequiredFieldValidator1" runat="server" ></asp:RequiredFieldValidator>
                </div>
                <div class="Casilla2-1">
			        <h4>Ordenes</h4>	
                    <asp:DropDownList ID="ddlOrdenes" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrdenes_SelectedIndexChanged">
                        <asp:ListItem Value="Seleccione una opción">Seleccione una opción</asp:ListItem>
                        <asp:ListItem Value="de Compra">Compra</asp:ListItem>
                        <asp:ListItem Value="de Venta">Pedido</asp:ListItem>
                    </asp:DropDownList>
                    <br><asp:RequiredFieldValidator ErrorMessage="* Seleccione Orden" ControlToValidate="ddlOrdenes" ID="RequiredFieldValidator3" runat="server" ></asp:RequiredFieldValidator>
			    </div>
			    <div class="Casilla2-1">
				    <h4>Observación</h4>					
				    <asp:TextBox ID="txtObservacion" runat="server" TextMode="MultiLine" CssClass="CasillaPersona"></asp:TextBox>					
                    <br><asp:RequiredFieldValidator ErrorMessage="* Ingrese Observación" ControlToValidate="txtObservacion" ID="RequiredFieldValidator4" runat="server" ></asp:RequiredFieldValidator>
			    </div>
                <div class="Casilla2-2">	
		            <asp:Button ID="btnAnularOrden" runat="server" Text="Anular"  CssClass="SubmitTotal" OnClick="btnAnularOrden_Click"/> 
		        </div>
	        </div>
            <div class="ModificarDatos2">
                <div class="columna2-1"> 
		            <h2>Detalle Orden</h2><br>
                    <asp:GridView ID="gwOrdenDetalle" runat="server" CssClass="listaFactura"
                        EmptyDataText="No se encontraron Ordenes..."
                        ></asp:GridView>
	            </div>
            </div>
        </div>
    </form>
</asp:Content>
