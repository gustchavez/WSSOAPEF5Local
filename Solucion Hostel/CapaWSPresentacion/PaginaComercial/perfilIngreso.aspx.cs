using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.PaginaComercial
{
    public partial class perfilIngreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["TokenUsuario"] = null;
            Session["NombreUsuario"] = null;
            Session["PerfilUsuario"] = null;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Sesion nLogin = new Sesion();

            nLogin.Usuario = txtNombreUsuario.Text;
            nLogin.Clave = txtClaveUsuario.Text;

            nLogin = x.ValidarLogin(txtNombreUsuario.Text, txtClaveUsuario.Text);

            if (nLogin.Retorno.Codigo == 0)
            {
                Session["TokenUsuario"] = nLogin.Retorno.Token;
                Session["NombreUsuario"] = nLogin.Usuario;
                Session["PerfilUsuario"] = nLogin.Perfil;

                switch (nLogin.Perfil)
                {
                    case "Empleado":
                        Response.Redirect("/perfilEmpleado/stock.aspx");
                        break;
                    case "Cliente":
                        Response.Redirect("/perfilCliente/solicitarServicio.aspx");
                        break;
                    case "Proveedor":
                        Response.Redirect("/perfilProveedor/Pedidos.aspx");
                        break;
                    case "Administrador":
                        Response.Redirect("Index.aspx");
                        break;
                    default:
                        Session["TokenUsuario"] = null;
                        Session["NombreUsuario"] = null;
                        Session["PerfilUsuario"] = null;
                        break;
                }
            } else {
                Session["TokenUsuario"] = null;
                Session["NombreUsuario"] = null;
                Session["PerfilUsuario"] = null;
            }

        }
    }
}