<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminModServicioComida.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminModServicioComida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="/scripts/comidaHabitacion.css">
    <form id="form1" runat="server">
	    <div class="columna2">
		    <div class="ModificarDatos">			
			    <h2>Modificar Precio Servicio Comida</h2><br>	
                <div class="Casilla2-1">
			        <h4>Tipo Servicio</h4>	
                    <asp:DropDownList ID="ddlTipoServicio" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoServicio_SelectedIndexChanged" ></asp:DropDownList>
			    </div>
			    <div class="Casilla2-1">
				    <h4>Precio</h4>					
				    <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" CssClass="CasillaPersona" ></asp:TextBox>					
			    </div>
                <div class="Casilla2-2">	
		            <asp:Button ID="btnModificar" runat="server" Text="Modificar Comida"  CssClass="SubmitTotalfactura" OnClick="btnModificar_Click"/> 
		        </div>
             <div class="ModificarDatos2">
                  <h2>Modificar Precio Habitacion</h2><br>	
                <div class="Casilla2-1">
			        <h4>Capacidad Habitación</h4>	
                    <asp:DropDownList ID="ddlTipoHabitacion" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoHabitacion_SelectedIndexChanged" ></asp:DropDownList>
			    </div>
			    <div class="Casilla2-1">
				    <h4>Precio</h4>					
				    <asp:TextBox ID="txtPrecio2" runat="server" TextMode="Number" CssClass="CasillaPersona" ></asp:TextBox>					
			    </div>
                <div class="Casilla2-2">	
		            <asp:Button ID="btnModificar2" runat="server" Text="Modificar Habitación"  CssClass="SubmitTotalfactura" OnClick="btnModificar2_Click" /> 
		        </div>
              </div>
	        </div>
        </div>
    </form>
</asp:Content>

