using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilCliente
{
    public partial class perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Cliente") || Perfil.Equals("Administrador"))
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

            var cliente = n.Lista.Where(p => p.PerfilUsuario.Usuario.Nombre == SesionUsuario.Usuario).SingleOrDefault();

            if (cliente != null)
            {
                txtRutEmpresa.Text            = cliente.Cliente.Rut;
                txtRazonSocial.Text           = cliente.PerfilUsuario.Empresa.RazonSocial;
                txtCorreoElectronico.Text     = cliente.PerfilUsuario.Empresa.Email;
                txtTelefono.Text              = cliente.PerfilUsuario.Empresa.Telefono;
                txtNombreCiudad.SelectedValue = cliente.PerfilUsuario.Direccion.NombreCiudad;
                txtDireccion.Text             = cliente.PerfilUsuario.Direccion.Calle;
                txtNombreUsuario.Text         = cliente.PerfilUsuario.Usuario.Nombre;
                txtContraseña.Text            = cliente.PerfilUsuario.Usuario.Clave;

                Session["SesionPerfilUsuarioCliente"]      = cliente;
            } else {

                Session["SesionPerfilUsuarioCliente"] = null;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            PerfilUsuarioCliente m = (PerfilUsuarioCliente)Session["SesionPerfilUsuarioCliente"];

            if (m != null)
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();

                n.Item.Cliente = m.Cliente;
                n.Item.PerfilUsuario = m.PerfilUsuario;
                n.Retorno.Token = Session["TokenUsuario"].ToString();

                n.Item.Cliente.Rut = txtRutEmpresa.Text;
                n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
                n.Item.PerfilUsuario.Empresa.Email = txtCorreoElectronico.Text;
                n.Item.PerfilUsuario.Empresa.Telefono = txtTelefono.Text;
                n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.SelectedValue;
                n.Item.PerfilUsuario.Direccion.Calle = txtDireccion.Text;
                n.Item.PerfilUsuario.Usuario.Nombre = txtNombreUsuario.Text;
                n.Item.PerfilUsuario.Usuario.Clave = txtContraseña.Text;

                n = x.PerfilUsuarioClienteActualizar(n);

                if (n.Retorno.Codigo == 0)
                {
                    //correcto
                }
            }
        }
    }
}