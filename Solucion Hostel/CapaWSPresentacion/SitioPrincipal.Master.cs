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
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
                
                string perfil = x.TokenRecuperarPerfil(Session["TokenUsuario"].ToString());

                switch (perfil)
                {
                    case "Cliente":
                        smpMenu.SiteMapProvider = "PerfilCliente";
                        break;
                    case "Empleado":
                        smpMenu.SiteMapProvider = "PerfilEmpleado";
                        break;
                    case "Proveedor":
                        smpMenu.SiteMapProvider = "PerfilProveedor";
                        break;
                    case "Administrador":
                        smpMenu.SiteMapProvider = "PerfilAdministrador";
                        break;
                    default:
                        smpMenu.SiteMapProvider = "PerfilDefault";
                        break;
                }
                
            }
            else
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("ingreso_cliente.aspx");
            }
        }
    }
}