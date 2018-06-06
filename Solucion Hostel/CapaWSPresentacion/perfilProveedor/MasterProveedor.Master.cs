using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilProveedor
{
    public partial class MasterProveedor : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            if (SesionUsuario != null)
            {
                try
                {
                    if (SesionUsuario.Perfil == "Proveedor")
                    {
                        lblNombreUsuario.Text = SesionUsuario.Nombre + " " + SesionUsuario.Apellido;
                        lblPerfilUsuario.Text = SesionUsuario.Perfil;
                        lblUsuario.Text = SesionUsuario.Usuario;
                        //lblbtnLoginStatus.Text = "Cerrar Sesion"; 
                    }
                    else {
                        lblNombreUsuario.Text = string.Empty;
                        lblPerfilUsuario.Text = string.Empty;
                        lblUsuario.Text = SesionUsuario.Usuario;
                        Session["TokenUsuario"] = null;
                        Session["NombreUsuario"] = null;
                        Session["PerfilUsuario"] = null;
                    }
                }
                catch (Exception)
                {
                    lblNombreUsuario.Text = string.Empty;
                    lblPerfilUsuario.Text = string.Empty;
                    lblUsuario.Text = SesionUsuario.Usuario;
                    Session["TokenUsuario"] = null;
                    Session["NombreUsuario"] = null;
                    Session["PerfilUsuario"] = null;
                }
            }
            else
            {
                lblNombreUsuario.Text = string.Empty;
                lblPerfilUsuario.Text = string.Empty;
                lblUsuario.Text = SesionUsuario.Usuario;
                Session["TokenUsuario"] = null;
                Session["NombreUsuario"] = null;
                Session["PerfilUsuario"] = null;
            }
        }
    }
}