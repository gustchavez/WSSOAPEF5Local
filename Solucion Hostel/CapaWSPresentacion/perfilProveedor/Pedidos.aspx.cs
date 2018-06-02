using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilProveedor
{
    public partial class Pedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado") || Perfil.Equals("Proveedor") || Perfil.Equals("Administrador"))
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

            ContenedorOrdenesPedidoCompleta n = new ContenedorOrdenesPedidoCompleta();

            n = x.OrdenPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

            var pedidos = (from prov in n.Lista
                               //where prov.Cabecera.RutProveedor == Session["RutProveedor"].ToString()
                               select new
                               {
                                   FechaSolicitud = prov.Cabecera.FechaEmision,
                                   Monto = prov.Cabecera.Monto,
                                   Estado = prov.Cabecera.Estado
                               }

                            ).ToList();

            gwSolicitudes.DataSource = null;
            gwSolicitudes.DataSource = pedidos;
            gwSolicitudes.DataBind();
        }
    }
}