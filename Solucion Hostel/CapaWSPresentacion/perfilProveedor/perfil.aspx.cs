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
            //
            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];
            //
            ContenedorPerfilUsuarioProveedor n = new ContenedorPerfilUsuarioProveedor();
            n = x.PerfilUsuarioProveedorRescatarXRut(SesionUsuario.RutEmpresa, Session["TokenUsuario"].ToString());
            //
            if(n.Item != null)
            {
                txtRutEmpresa.Text            = n.Item.Proveedor.Rut;
                txtRazonSocial.Text           = n.Item.PerfilUsuario.Empresa.RazonSocial;
                txtCorreoElectronico.Text     = n.Item.PerfilUsuario.Empresa.Email;
                txtTelefono.Text              = n.Item.PerfilUsuario.Empresa.Telefono;
                txtNombreCiudad.SelectedValue = n.Item.PerfilUsuario.Direccion.NombreCiudad;
                txtDireccion.Text             = n.Item.PerfilUsuario.Direccion.Calle;
                txtNombreUsuario.Text         = n.Item.PerfilUsuario.Usuario.Nombre;
                txtContraseña.Text            = n.Item.PerfilUsuario.Usuario.Clave;

                try
                {
                    ddlRubro.SelectedValue    = n.Item.PerfilUsuario.Empresa.Rubro;
                    ddlComunas.SelectedValue  = n.Item.PerfilUsuario.Direccion.Comuna;
                }
                catch (Exception)
                {
                    ddlRubro.SelectedValue    = "";
                    ddlComunas.SelectedValue  = "";
                }

                Session["SesionPerfilUsuarioProveedor"] = n.Item;
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
                n.Item = m;
                //
                n.Retorno.Token                             = Session["TokenUsuario"].ToString();                
                n.Item.PerfilUsuario.Empresa.RazonSocial    = txtRazonSocial.Text;
                n.Item.PerfilUsuario.Empresa.Rubro          = ddlRubro.SelectedValue;
                n.Item.PerfilUsuario.Empresa.Email          = txtCorreoElectronico.Text;
                n.Item.PerfilUsuario.Empresa.Telefono       = txtTelefono.Text;
                n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.SelectedValue;
                n.Item.PerfilUsuario.Direccion.Comuna       = ddlComunas.SelectedValue;
                n.Item.PerfilUsuario.Direccion.Calle        = txtDireccion.Text;
                n.Item.PerfilUsuario.Usuario.Clave          = txtContraseña.Text;
                //
                n = x.PerfilUsuarioProveedorActualizar(n);

                if (n.Retorno.Codigo == 0)
                {
                    //correcto
                    Response.Write(@"<script langauge='text/javascript'>alert('Modificación Exitosa');</script>");

                }
            }
        }
    }
}