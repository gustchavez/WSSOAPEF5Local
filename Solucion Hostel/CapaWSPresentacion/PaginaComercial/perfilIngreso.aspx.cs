﻿using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.PaginaComercial
{
    public partial class perfilIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["TokenUsuario"] = null;
            Session["NombreUsuario"] = null;
            Session["PerfilUsuario"] = null;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Sesion nLogin = new Sesion();

            nLogin.Usuario = txtNombreUsuario.Text;
            nLogin.Clave = txtClaveUsuario.Text;

            nLogin = x.ValidarLogin(txtNombreUsuario.Text, txtClaveUsuario.Text);

            if (nLogin.Retorno.Codigo == 0)
            {
                Session["TokenUsuario"] = nLogin.Retorno.Token;
                Session["NombreUsuario"] = nLogin.Usuario;
                Session["PerfilUsuario"] = nLogin.Perfil;
                Session["SesionUsuario"] = nLogin;

                switch (nLogin.Perfil)
                {
                    case "Empleado":
                        Response.Redirect("/perfilEmpleado/stock.aspx");
                        break;
                    case "Cliente":
                        Response.Redirect("/perfilCliente/solicitarServicio.aspx");
                        break;
                    case "Proveedor":
                        Response.Redirect("/perfilProveedor/Pedidos.aspx");
                        break;
                    case "Administrador":
                        Response.Redirect("/perfilAdministrador/AdminCrearAdmin.aspx");
                        break;
                    default:
                        Session["TokenUsuario"] = null;
                        Session["NombreUsuario"] = null;
                        Session["PerfilUsuario"] = null;
                        Session["SesionUsuario"] = null;
                        break;
                }
            } else {
                Session["TokenUsuario"] = null;
                Session["NombreUsuario"] = null;
                Session["PerfilUsuario"] = null;
                Session["SesionUsuario"] = null;
            }

        }
        
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();

            n.Item.Cliente.Rut = rutEmpresa.Text;
            n.Item.PerfilUsuario.Empresa.RazonSocial = razonSocial.Text;
            n.Item.PerfilUsuario.Empresa.Rubro = giro.Text;
            n.Item.PerfilUsuario.Empresa.Email = nombreUsuario.Text;
            n.Item.PerfilUsuario.Empresa.Telefono = "Ingrese telefono";
            n.Item.PerfilUsuario.Direccion.CodPais = 56;
            n.Item.PerfilUsuario.Direccion.CodPostal = "Ingrese codigo postal";
            n.Item.PerfilUsuario.Direccion.NombreCiudad = "Ingrese ciudad";
            n.Item.PerfilUsuario.Direccion.Comuna = "Ingrese comuna";
            n.Item.PerfilUsuario.Direccion.Calle = "Ingrese Calle";
            n.Item.PerfilUsuario.Direccion.Numero = int.Parse("123");
            n.Item.PerfilUsuario.Empresa.Logo = "Logo";
            n.Item.PerfilUsuario.Persona.Rut = "Rut empleado";
            n.Item.PerfilUsuario.Persona.Nombre = "Nombre empleado";
            n.Item.PerfilUsuario.Persona.Apellido = "Apellido empleado";
            n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Now;
            n.Item.PerfilUsuario.Persona.Email = correoElectronico.Text;
            n.Item.PerfilUsuario.Persona.Telefono = "Telefono empleado";
            n.Item.PerfilUsuario.Usuario.Clave = contrasena.Text;
            n.Retorno.Token = Session["TokenUsuario"].ToString();

            n = x.PerfilUsuarioClienteCrear(n);

        }
    }
}