using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class MasterAdministrador : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            try
            {
                if (SesionUsuario.Perfil == "Administrador")
                {
                    lblNombreUsuario.Text = SesionUsuario.Nombre + " " + SesionUsuario.Apellido;
                    lblPerfilUsuario.Text = SesionUsuario.Perfil;
                    lblUsuario.Text = SesionUsuario.Usuario;
                }
                else {
                    lblNombreUsuario.Text = string.Empty;
                    lblPerfilUsuario.Text = string.Empty;
                    lblUsuario.Text = SesionUsuario.Usuario;
                    Session["TokenUsuario"] = null;
                    Session["PerfilUsuario"] = null;
                    Session["SesionUsuario"] = null;
                }
            }
            catch (Exception)
            {
                lblNombreUsuario.Text = string.Empty;
                lblPerfilUsuario.Text = string.Empty;
                lblUsuario.Text = SesionUsuario.Usuario;
                Session["TokenUsuario"] = null;
                Session["PerfilUsuario"] = null;
                Session["SesionUsuario"] = null;
            }

        }
    }
}