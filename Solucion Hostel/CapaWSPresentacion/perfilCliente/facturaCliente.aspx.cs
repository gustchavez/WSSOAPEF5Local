using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilCliente
{
    public partial class facturaCliente : System.Web.UI.Page
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
            ContenedorFacturasCompraCompleta n = new ContenedorFacturasCompraCompleta();

            n = x.FacturaCompraCompletaRescatar(Session["TokenUsuario"].ToString());

            Sesion datSes = (Sesion)Session["SesionUsuario"];

            var facturas = (from l in n.Lista
                            where l.OCRelacionada.RutCliente == datSes.RutEmpresa
                            select new
                            {
                                Rut        = l.OCRelacionada.RutCliente,
                                NroFactura = l.Cabecera.Numero,
                                FecFactura = l.Cabecera.Fecha,
                                ValorBruto = l.Cabecera.ValorBruto,
                                ValorIva   = l.Cabecera.ValorIva,
                                ValorNeto  = l.Cabecera.ValorNeto,
                                MedioPago  = l.Pago.MedioPago,
                                NroOrdReserva = l.OCRelacionada.Numero
                            }
                            ).ToList();

            gwFacturasCompra.DataSource = null;
            gwFacturasCompra.DataSource = facturas;
            gwFacturasCompra.DataBind();
        }
    }
}