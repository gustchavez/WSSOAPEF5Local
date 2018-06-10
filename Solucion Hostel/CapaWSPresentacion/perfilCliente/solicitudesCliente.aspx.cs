using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilCliente
{
    public partial class solicitudesCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Cliente") || Perfil.Equals("Administrador"))
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
            ContenedorOrdenesCompraCompleta n = new ContenedorOrdenesCompraCompleta();

            n = x.OrdenCompraCompletaRescatar(Session["TokenUsuario"].ToString());

            Sesion datSes = (Sesion)Session["SesionUsuario"];

            var ordenes = (from l in n.Lista
                           where l.Cabecera.RutCliente == datSes.RutEmpresa
                           select new
                            { 
                                RutCliente  = l.Cabecera.RutCliente ,
                                NumeroOC    = l.Cabecera.Numero   ,
                                FecRecepOC  = l.Cabecera.FechaRecepcion ,
                                MontoOC     = l.Cabecera.Monto    ,
                                EstadoOC    = l.Cabecera.Estado   
                            }
                            ).ToList();

            gwOrdenesCompra.DataSource = null;
            gwOrdenesCompra.DataSource = ordenes;
            gwOrdenesCompra.DataBind();
        }
    }
}