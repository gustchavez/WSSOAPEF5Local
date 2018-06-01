using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class ingresoProducto : System.Web.UI.Page
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
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }

        }

        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorCiudades n = new ContenedorCiudades();

            n = x.CiudadRescatar(Session["TokenUsuario"].ToString());

            txtProveedorAgregar.DataSource = null;
            txtProveedorAgregar.DataSource = n.Lista.Where(p => p.CodPais == 56);
            txtProveedorAgregar.DataValueField = "Nombre";
            txtProveedorAgregar.DataTextField = "Nombre";
            txtProveedorAgregar.DataBind();
        }
    }
}