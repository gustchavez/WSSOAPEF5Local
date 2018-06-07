using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class perfil : System.Web.UI.Page
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
            catch (Exception ex)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }

        }

        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorCiudades m = new ContenedorCiudades();

            m = x.CiudadRescatar(Session["TokenUsuario"].ToString());

            txtNombreCiudad.DataSource = null;
            txtNombreCiudad.DataSource = m.Lista.Where(p => p.CodPais == 56);
            txtNombreCiudad.DataValueField = "Nombre";
            txtNombreCiudad.DataTextField = "Nombre";
            txtNombreCiudad.DataBind();

            ContenedorPerfilUsuarioClientes n = new ContenedorPerfilUsuarioClientes();

            n = x.PerfilUsuarioClienteRescatar(Session["TokenUsuario"].ToString());

            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            var proveedor = n.Lista.Where(p => p.PerfilUsuario.Usuario.Nombre == SesionUsuario.Usuario).SingleOrDefault();

            txtRutEmpresa.Text = proveedor.Cliente.Rut;
            txtRazonSocial.Text = proveedor.PerfilUsuario.Empresa.RazonSocial;
            txtCorreoElectronico.Text = proveedor.PerfilUsuario.Empresa.Email;
            txtTelefono.Text = proveedor.PerfilUsuario.Empresa.Telefono;
            txtNombreCiudad.SelectedValue = proveedor.PerfilUsuario.Direccion.NombreCiudad;
            txtDireccion.Text = proveedor.PerfilUsuario.Direccion.Calle;
            txtNombreUsuario.Text = proveedor.PerfilUsuario.Usuario.Nombre;
            txtContraseña.Text = proveedor.PerfilUsuario.Usuario.Clave;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}