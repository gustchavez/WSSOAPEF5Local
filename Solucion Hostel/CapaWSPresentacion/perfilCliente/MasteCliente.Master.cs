using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilCliente
{
    public partial class MasteCliente : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];
            
            try
            {
                if (SesionUsuario.Perfil == "Cliente")
                {
                    lblRutEmpresa.Text = SesionUsuario.RutEmpresa;
                    lblRazonSocial.Text = SesionUsuario.RazonSocial;
                    //lblNombreUsuario.Text = SesionUsuario.Nombre + " " + SesionUsuario.Apellido;
                    lblPerfilUsuario.Text = SesionUsuario.Perfil;
                    lblUsuario.Text = SesionUsuario.Usuario;
                } else {
                    lblRutEmpresa.Text = string.Empty;
                    lblRazonSocial.Text = string.Empty;
                    //lblNombreUsuario.Text = string.Empty;
                    lblPerfilUsuario.Text = string.Empty;
                    lblUsuario.Text = SesionUsuario.Usuario;
                    Session["TokenUsuario"] = null;
                    Session["PerfilUsuario"] = null;
                    Session["SesionUsuario"] = null;
                }
            }
            catch (Exception)
            {
                lblRutEmpresa.Text = string.Empty;
                lblRazonSocial.Text = string.Empty;
                //lblNombreUsuario.Text = string.Empty;
                lblPerfilUsuario.Text = string.Empty;
                lblUsuario.Text = SesionUsuario.Usuario;
                Session["TokenUsuario"] = null;
                Session["PerfilUsuario"] = null;
                Session["SesionUsuario"] = null;
            }
        }
    }
}