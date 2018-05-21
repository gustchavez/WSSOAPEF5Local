using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class SitioPrincipal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenUsuario"] != null)
            {
                try
                {
                    string perfil = Session["PerfilUsuario"].ToString();

                    switch (perfil)
                    {
                        case "Empleado":
                            lblNombreUsuario.Text = Session["NombreUsuario"].ToString();
                            lblbtnLoginStatus.Text = "Cerrar Sesion";
                            smdcMenu.SiteMapProvider = "XmlSiteMapWebEmpleado";
                            break;
                        case "Cliente":
                            lblNombreUsuario.Text = Session["NombreUsuario"].ToString();
                            lblbtnLoginStatus.Text = "Cerrar Sesion";
                            smdcMenu.SiteMapProvider = "XmlSiteMapWebCliente";
                            break;
                        case "Proveedor":
                            lblNombreUsuario.Text = Session["NombreUsuario"].ToString();
                            lblbtnLoginStatus.Text = "Cerrar Sesion";
                            smdcMenu.SiteMapProvider = "XmlSiteMapWebProveedor";
                            break;
                        case "Administrador":
                            lblNombreUsuario.Text = Session["NombreUsuario"].ToString();
                            lblbtnLoginStatus.Text = "Cerrar Sesion";
                            smdcMenu.SiteMapProvider = "XmlSiteMapWebAdministrador";
                            break;
                        default:
                            lblNombreUsuario.Text = string.Empty;
                            lblbtnLoginStatus.Text = "Iniciar Sesion";
                            smdcMenu.SiteMapProvider = "XmlSiteMapWebDefault";
                            Session["TokenUsuario"] = null;
                            Session["NombreUsuario"] = null;
                            Session["PerfilUsuario"] = null;
                            break;
                    }
                } catch (Exception) {
                    lblNombreUsuario.Text = string.Empty;
                    lblbtnLoginStatus.Text = "Iniciar Sesion";
                    smdcMenu.SiteMapProvider = "XmlSiteMapWebDefault";
                    Session["TokenUsuario"] = null;
                    Session["NombreUsuario"] = null;
                    Session["PerfilUsuario"] = null;
                }
            } else {
                lblNombreUsuario.Text = string.Empty;
                lblbtnLoginStatus.Text = "Iniciar Sesion";
                smdcMenu.SiteMapProvider = "XmlSiteMapWebDefault";
                Session["NombreUsuario"] = null;
                Session["PerfilUsuario"] = null;
            }
        }        

        protected void lblbtnLoginStatus_Click(object sender, EventArgs e)
        {
            if (lblbtnLoginStatus.Text == "Iniciar Sesion")
            {
                Session["NombreUsuario"] = null;
                Session["TokenUsuario"] = null;
                Session["PerfilUsuario"] = null;
                Response.Redirect("np_ingreso.aspx");
            }  else {
                Session["NombreUsuario"] = null;
                Session["TokenUsuario"] = null;
                Session["PerfilUsuario"] = null;
                lblbtnLoginStatus.Text = "Iniciar Sesion";
                Response.Redirect("Index.aspx");
            }
        }
    }
}