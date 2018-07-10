using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            Session["PerfilUsuario"] = null;
            Session["SesionUsuario"] = null;
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
                        Session["PerfilUsuario"] = null;
                        Session["SesionUsuario"] = null;
                        break;
                }
            } else {
                Session["TokenUsuario"] = null;
                Session["PerfilUsuario"] = null;
                Session["SesionUsuario"] = null;
                Response.Write(@"<script lenguage='text/javascript'>alert('Error al ingresar usuario y/o contraseña');</script>");
            }

        }
        private bool validarText()
        {
            bool varia = true;
            Regex regex = new Regex("[0-9]{7,8}-[0-9kK]{1}");
            if (rutEmpresa.Text == null || rutEmpresa.Text == "" || !(regex.IsMatch(rutEmpresa.Text)) || rutEmpresa.Text.Length > 10 || rutEmpresa.Text.Length < 9)
            {
                rutEmpresa.Text = "";
                varia = false;
            }
            if (razonSocial.Text==null || razonSocial.Text=="")
            {
                varia = false;
            }
            if (giro.Text == null || giro.Text == "")
            {
                varia = false;
            }
            if (nombreUsuario.Text == null || nombreUsuario.Text == "")
            {
                varia = false;
            }
            if (correoElectronico.Text == null || correoElectronico.Text == "")
            {
                varia = false;
            }
            if (contrasena.Text == null || contrasena.Text == "")
            {
                varia = false;
            }
            return varia;
        }
        
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(validarText())
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();

                n.Item.Cliente.Rut = rutEmpresa.Text;
                n.Item.PerfilUsuario.Empresa.RazonSocial = razonSocial.Text;
                n.Item.PerfilUsuario.Empresa.Rubro = giro.Text;
                n.Item.PerfilUsuario.Empresa.Email = correoElectronico.Text;
                n.Item.PerfilUsuario.Empresa.Telefono = "Ingrese tel";
                n.Item.PerfilUsuario.Direccion.CodPais = 56;
                n.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                n.Item.PerfilUsuario.Direccion.NombreCiudad = "Santiago";
                n.Item.PerfilUsuario.Direccion.Comuna = "Ingrese comuna";
                n.Item.PerfilUsuario.Direccion.Calle = "Ingrese Calle";
                n.Item.PerfilUsuario.Direccion.Numero = 123;
                n.Item.PerfilUsuario.Empresa.Logo = "LogoDefecto.png";
                n.Item.PerfilUsuario.Persona.Rut = rutEmpresa.Text + "Z"; // "Rut empleado";
                n.Item.PerfilUsuario.Persona.Nombre = "Nombre";
                n.Item.PerfilUsuario.Persona.Apellido = "Apellido";
                n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Now;
                n.Item.PerfilUsuario.Persona.Email = "Ingrese mail";
                n.Item.PerfilUsuario.Persona.Telefono = "Ingrese tel";
                n.Item.PerfilUsuario.Usuario.Nombre = nombreUsuario.Text;
                n.Item.PerfilUsuario.Usuario.Clave = contrasena.Text;
                n.Retorno.Token = null; //Session["TokenUsuario"].ToString();

                n = x.PerfilUsuarioClienteCrear(n);

                if (n.Retorno.Codigo == 0)
                {
                    //termino ok
                    rutEmpresa.Text = string.Empty;
                    razonSocial.Text = string.Empty;
                    giro.SelectedIndex = 0;
                    correoElectronico.Text = string.Empty;

                    txtNombreUsuario.Text = nombreUsuario.Text;
                    nombreUsuario.Text = string.Empty;

                    txtClaveUsuario.Text = contrasena.Text;
                    contrasena.Text = string.Empty;
                }
                else
                {
                    //Error
                }
            }
            else
            {

                Response.Write(@"<script lenguage='text/javascript'>alert('Debe completar todos los campos');</script>");
            }
            
        }
    }
}