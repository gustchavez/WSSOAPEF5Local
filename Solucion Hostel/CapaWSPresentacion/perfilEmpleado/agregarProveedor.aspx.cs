using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class agregarProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado") || Perfil.Equals("Administrador"))
                {
                    if (!IsPostBack)
                    {
                        RescatarDatos();
                    }
                }
                else
                {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
                }
            }
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }
        }

        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorCiudades n = new ContenedorCiudades();

            n = x.CiudadRescatar(Session["TokenUsuario"].ToString());

            txtNombreCiudad.DataSource = null;
            txtNombreCiudad.DataSource = n.Lista.Where(p => p.CodPais == 56);
            txtNombreCiudad.DataValueField = "Nombre";
            txtNombreCiudad.DataTextField  = "Nombre";
            txtNombreCiudad.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioProveedor n = new ContenedorPerfilUsuarioProveedor();

            
            n.Item.Proveedor.Rut = txtRutEmpresa.Text;
            n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
            n.Item.PerfilUsuario.Empresa.Rubro = txtNombreCiudad.SelectedValue;
            n.Item.PerfilUsuario.Empresa.Email = txtCorreoElectronico.Text;
            n.Item.PerfilUsuario.Empresa.Telefono = txtTelefonoEmpresa.Text;
            n.Item.PerfilUsuario.Direccion.CodPais = 56;
            n.Item.PerfilUsuario.Direccion.CodPostal = "1234";
            n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.SelectedValue;
            n.Item.PerfilUsuario.Direccion.Comuna = txtComuna.Text;
            n.Item.PerfilUsuario.Direccion.Calle = txtCalle.Text;
            n.Item.PerfilUsuario.Direccion.Numero = 123;
            n.Item.PerfilUsuario.Empresa.Logo = "LogoDefecto.png";
            n.Item.PerfilUsuario.Persona.Rut = txtRutEmpresa.Text + "Z";
            n.Item.PerfilUsuario.Persona.Nombre = "Perfil";
            n.Item.PerfilUsuario.Persona.Apellido = "Proveedor";
            n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Now;
            n.Item.PerfilUsuario.Persona.Email = "ingrese mail";
            n.Item.PerfilUsuario.Persona.Telefono = "123";
            n.Item.PerfilUsuario.Usuario.Nombre = txtNombreUsuario.Text;
            n.Item.PerfilUsuario.Usuario.Clave = txtConstrasena.Text;
            n.Retorno.Token = Session["TokenUsuario"].ToString();
            //n.Item.PerfilUsuario.Empresa.Rut = txtRutEmpresa.Text;

            n = x.PerfilUsuarioProveedorCrear(n);

            if (n.Retorno.Codigo.ToString() == "0")
            {
                txtRutEmpresa.Text = string.Empty;
                txtRazonSocial.Text = string.Empty;
                //n.Item.PerfilUsuario.Empresa.Rubro = txtNombreCiudad.Text;
                txtCorreoElectronico.Text = string.Empty;
                txtTelefonoEmpresa.Text = string.Empty;
                txtCalle.Text = string.Empty;
                txtNombreUsuario.Text = string.Empty;
                txtConstrasena.Text = string.Empty;
            }
            else
            {
                //definir donde se mostrara mensaje de error
            }
        }
    }
}