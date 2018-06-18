<%@ Page Title="" Language="C#" MasterPageFile="~/perfilEmpleado/MasterEmpleado.Master" AutoEventWireup="true" CodeBehind="recepcion.aspx.cs" Inherits="CapaWSPresentacion.perfilEmpleado.recepcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <link rel="stylesheet" type="text/css" href="/scripts/recepcion.css">

<form id="form1" runat="server">

    

<div class="columna2">
	
	
	<div class="ModificarDatos2" style="left: 0px; top: 30px">
		
		<h2>Confirmación de Huéspedes</h2>
		<h4>Seleccione cod. de orden y rut de empleado para confirmar su asistencia </h4>
        <div class="Casilla2-2" >
		    <h4 style="color: red;">Empresas</h4>
            <asp:DropDownList ID="ddlEmpresas" CssClass="selectO" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpresas_SelectedIndexChanged"></asp:dropdownlist>
		</div>   
		<div class="Casilla2-2" >
		    <h4 style="color: red;">Orden Compra</h4>
            <asp:DropDownList ID="ddlOrdenesCompra" CssClass="selectO" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlOrdenesCompra_SelectedIndexChanged"></asp:dropdownlist>
		</div>     
        
	    <div class="contenedorTabla">
		    <div class="Casilla2-2">	
	            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Ingresos" CssClass="SubmitTotal" OnClick="btnConfirmar_Click" />
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
                    <asp:BoundField DataField="Rut" HeaderText="Rut"  
                    Visible="True" />
                    <asp:BoundField DataField="Estado" HeaderText="EstadoBool"
                    Visible="False" />
                </Columns>
            </asp:GridView>
        	    
	    </div>	

	</div>
</div>
</form>

</asp:Content>
