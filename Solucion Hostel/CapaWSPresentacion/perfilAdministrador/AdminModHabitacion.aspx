<%@ Page Title="" Language="C#" MasterPageFile="~/perfilAdministrador/MasterAdministrador.Master" AutoEventWireup="true" CodeBehind="AdminModHabitacion.aspx.cs" Inherits="CapaWSPresentacion.perfilAdministrador.AdminModHabitacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="/scripts/comidaHabitacion.css">
    <form id="form1" runat="server">
	    <div class="columna2">
		    <div class="ModificarDatos">			
			    <h2>Modificar Precio Habitacion</h2><br>	
                <div class="Casilla2-1">
			        <h4>Capacidad Habitacion</h4>	
                    <asp:DropDownList ID="ddlTipoHabitacion" CssClass="droplist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTipoHabitacion_SelectedIndexChanged" ></asp:DropDownList>
			    </div>
			    <div class="Casilla2-1">
				    <h4>Precio</h4>					
				    <asp:TextBox ID="txtPrecio" runat="server" TextMode="Number" CssClass="CasillaPersona" min="0" ></asp:TextBox>		
                    <br><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Ingrese Precio" ControlToValidate="txtPrecio"></asp:RequiredFieldValidator>
			    </div>
                <div class="Casilla2-2">	
		            <asp:Button ID="btnModificar" runat="server" Text="Modificar"  CssClass="SubmitTotal" OnClick="btnModificar_Click"/> 
		        </div>
	        </div>
        </div>
    </form>
</asp:Content>
