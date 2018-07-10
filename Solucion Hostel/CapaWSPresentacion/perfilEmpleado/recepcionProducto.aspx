<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="recepcionProducto.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.recepcionProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <link rel="stylesheet" type="text/css" href="/scripts/recepcion.css">

<form id="form1" runat="server">

    

<div class="columna2">
	
	
	<div class="ModificarDatos2" style="left: 0px; top: 30px">
		
		<h2>Confirmación recepción de productos</h2>
        <div class="Casilla2-2" >
		    <h4 style="color: red;">Empresas</h4>
            <asp:DropDownList ID="ddlEmpresas" CssClass="selectO" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged">
                <asp:ListItem Value="">Seleccione una opción</asp:ListItem>
            </asp:dropdownlist>
            <br><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Seleccione Empresa" ControlToValidate="ddlEmpresas" ValidationGroup="validarGrupo"></asp:RequiredFieldValidator>

		</div>   
		<div class="Casilla2-2" >
		    <h4 style="color: red;">Nº de Orden</h4>
            <asp:DropDownList ID="ddlOrdenes" CssClass="selectO" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrdenesCompra_SelectedIndexChanged">
                <asp:ListItem Value="">Seleccione una opción</asp:ListItem>
            </asp:dropdownlist>
            <br><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Seleccione Nº de Orden" ControlToValidate="ddlOrdenes" ValidationGroup="validarGrupo"></asp:RequiredFieldValidator>
		</div>     
        
	    <div class="contenedorTabla">
		    <div class="Casilla2-2">	
	            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Ingresos producto" CssClass="SubmitTotal" OnClick="btnConfirmar_Click" />
		    </div>

            <asp:GridView ID="gwListaRecepcion" runat="server" CssClass="tabla" style="left: 0px; top: 50px"
                EmptyDataText="Seleccione Orden..."
                AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="Ingreso">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkEliminar" runat="server" Checked='<%# Eval("EstadoBool") %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="NroOrden" HeaderText="Numero Orden"
                    Visible="True" />
                    <asp:BoundField DataField="CodProducto" HeaderText="Cod. Producto"  
                    Visible="True" />
                    <asp:BoundField DataField="Nombre" HeaderText="Descripción"  
                    Visible="True" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad"  
                    Visible="True" />
                    <asp:BoundField DataField="Estado" HeaderText="¿Ingresado?"
                    Visible="True" />
                </Columns>
            </asp:GridView>
        	    
	    </div>	

	</div>
</div>
</form>



</asp:Content>
