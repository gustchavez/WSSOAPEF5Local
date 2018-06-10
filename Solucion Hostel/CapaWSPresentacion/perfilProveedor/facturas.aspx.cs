using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilProveedor
{
    public partial class facturas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Proveedor") || Perfil.Equals("Administrador"))
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

            ContenedorFacturasPedidoCompleta n = new ContenedorFacturasPedidoCompleta();

            n = x.FacturaPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

            Sesion datSes = (Sesion)Session["SesionUsuario"];

            var facturas = (from l in n.Lista
                            where l.OPRelacionada.RutProveedor == datSes.RutEmpresa
                            select new
                            {
                                Rut = l.OPRelacionada.RutProveedor,
                                NroFactura = l.Cabecera.Numero,
                                FecFactura = l.Cabecera.Fecha,
                                ValorBruto = l.Cabecera.ValorBruto,
                                ValorIva = l.Cabecera.ValorIva,
                                ValorNeto = l.Cabecera.ValorNeto,
                                MedioPago = l.Pago.MedioPago,
                                NroOrdReserva = l.OPRelacionada.Numero
                            }
                            ).ToList();

            gwFacturasPedido.DataSource = null;
            gwFacturasPedido.DataSource = facturas;
            gwFacturasPedido.DataBind();
        }
    }
}