using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class facturas : System.Web.UI.Page
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
            catch (Exception ex)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }
        }
        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Sesion datSes = (Sesion)Session["SesionUsuario"];

            ContenedorFacturasPedidoCompleta m = new ContenedorFacturasPedidoCompleta();
            m = x.FacturaPedidoCompletaRescatar(datSes.Retorno.Token);
            var facPed = (  from  l in m.Lista
                            //where l.OPRelacionada.RutProveedor == datSes.RutEmpresa
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
            gwFacturasPedido.DataSource = facPed;
            gwFacturasPedido.DataBind();

            ContenedorFacturasCompraCompleta n = new ContenedorFacturasCompraCompleta();
            n = x.FacturaCompraCompletaRescatar(datSes.Retorno.Token);

            //
            var facComp = (  from l in n.Lista
                            //where l.OCRelacionada.RutCliente == datSes.RutEmpresa
                            select new
                            {
                                Rut = l.OCRelacionada.RutCliente,
                                NroFactura = l.Cabecera.Numero,
                                FecFactura = l.Cabecera.Fecha,
                                ValorBruto = l.Cabecera.ValorBruto,
                                ValorIva = l.Cabecera.ValorIva,
                                ValorNeto = l.Cabecera.ValorNeto,
                                MedioPago = l.Pago.MedioPago,
                                NroOrdReserva = l.OCRelacionada.Numero
                            }
                            ).ToList();

            gwFacturasCompra.DataSource = null;
            gwFacturasCompra.DataSource = facComp;
            gwFacturasCompra.DataBind();
        }
    }
}