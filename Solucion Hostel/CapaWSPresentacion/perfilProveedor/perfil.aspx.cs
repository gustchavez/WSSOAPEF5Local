using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilProveedor
{
    public partial class perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Proveedor") || Perfil.Equals("Administrador"))
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

            ContenedorPerfilUsuarioProveedores n = new ContenedorPerfilUsuarioProveedores();

            n = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            var proveedor = n.Lista.Where(p => p.PerfilUsuario.Usuario.Nombre == SesionUsuario.Usuario).SingleOrDefault();

            if(proveedor != null)
            {
                txtRutEmpresa.Text = proveedor.Proveedor.Rut;
                txtRazonSocial.Text = proveedor.PerfilUsuario.Empresa.RazonSocial;
                txtCorreoElectronico.Text = proveedor.PerfilUsuario.Empresa.Email;
                txtTelefono.Text = proveedor.PerfilUsuario.Empresa.Telefono;
                txtNombreCiudad.SelectedValue = proveedor.PerfilUsuario.Direccion.NombreCiudad;
                txtDireccion.Text = proveedor.PerfilUsuario.Direccion.Calle;
                txtNombreUsuario.Text = proveedor.PerfilUsuario.Usuario.Nombre;
                txtContraseña.Text = proveedor.PerfilUsuario.Usuario.Clave;

                Session["SesionPerfilUsuarioProveedor"] = proveedor;
            } else {
                Session["SesionPerfilUsuarioProveedor"] = null;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            PerfilUsuarioProveedor m = (PerfilUsuarioProveedor)Session["SesionPerfilUsuarioProveedor"];

            if (m != null)
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                ContenedorPerfilUsuarioProveedor n = new ContenedorPerfilUsuarioProveedor();

                n.Item.Proveedor = m.Proveedor;
                n.Item.PerfilUsuario = m.PerfilUsuario;
                n.Retorno.Token = Session["TokenUsuario"].ToString();

                n.Item.Proveedor.Rut = txtRutEmpresa.Text;
                n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
                n.Item.PerfilUsuario.Empresa.Email = txtCorreoElectronico.Text;
                n.Item.PerfilUsuario.Empresa.Telefono = txtTelefono.Text;
                n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.SelectedValue;
                n.Item.PerfilUsuario.Direccion.Calle = txtDireccion.Text;
                n.Item.PerfilUsuario.Usuario.Nombre = txtNombreUsuario.Text;
                n.Item.PerfilUsuario.Usuario.Clave = txtContraseña.Text;

                n = x.PerfilUsuarioProveedorActualizar(n);

                if (n.Retorno.Codigo == 0)
                {
                    //correcto
                }
            }
        }
    }
}