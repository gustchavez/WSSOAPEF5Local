using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class AnularFactura : System.Web.UI.Page
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

            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorPerfilUsuarioProveedores m = new ContenedorPerfilUsuarioProveedores();
                m = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

                var prov = (from l in m.Lista
                            select new
                            {
                                Rut         = l.Proveedor.Rut,
                                RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                            }
                            ).ToList();

                if (prov != null)
                {
                    ddlEmpresas.DataSource     = prov;
                    ddlEmpresas.DataValueField = "Rut";
                    ddlEmpresas.DataTextField  = "RazonSocial";
                    ddlEmpresas.DataBind();
                    ddlEmpresas.Enabled        = true;
                    ////
                    RescatarFacturasXEmpresa(x);
                    ////
                } else {
                    LimpiarControles();
                }
            }
            else {
                ContenedorPerfilUsuarioClientes m = new ContenedorPerfilUsuarioClientes();
                m = x.PerfilUsuarioClienteRescatar(Session["TokenUsuario"].ToString());

                var clie = (from l in m.Lista
                            select new
                            {
                                Rut = l.Cliente.Rut,
                                RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                            }
                            ).ToList();

                if (clie != null)
                {
                    ddlEmpresas.DataSource = clie;
                    ddlEmpresas.DataValueField = "Rut";
                    ddlEmpresas.DataTextField = "RazonSocial";
                    ddlEmpresas.DataBind();
                    ddlEmpresas.Enabled = true;
                    ////
                    RescatarFacturasXEmpresa(x);
                    ////
                } else {
                    LimpiarControles();
                }
            }
        }

        private void LimpiarControles()
        {
            ddlEmpresas.Items.Clear();
            ddlEmpresas.Items.Add(new ListItem("No Existe", ""));
            ddlEmpresas.DataBind();
            ddlEmpresas.SelectedIndex = 0;
            //////////////
            ddlEmpresas.Enabled = false;

            LimpiarControlesOrdenes();
        }

        private void LimpiarControlesOrdenes()
        {
            ddlFacturas.Items.Clear();
            ddlFacturas.Items.Add(new ListItem("No Existe", ""));
            ddlFacturas.DataBind();
            ddlFacturas.SelectedIndex = 0;
            //////////////
            ddlFacturas.Enabled = false;
            Session["OrdenesCompra"] = null;
            //////////////
            gwFacturaDetalle.DataSource = null;
            gwFacturaDetalle.DataBind();
            /////////////
            txtOrden.Text       = string.Empty;
            txtObservacion.Text = string.Empty;
        }

        private void RescatarFacturasXEmpresa(WSSoap.WSSHostelClient x)
        {
            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorFacturasPedidoCompleta m = new ContenedorFacturasPedidoCompleta();
                m = x.FacturaPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

                //filtrar las ordenes rescatadas
                var FPs = m.Lista.Where(p => p.OPRelacionada.RutProveedor == ddlEmpresas.SelectedValue
                                          && p.Cabecera.Estado            == "activo").ToList();

                //formatear lista para dejar en dropdwonlist, solo se deja numero orden
                var fpc = (from l in FPs
                           select new
                           {
                               Numero = l.Cabecera.Numero
                           }
                            ).ToList();
                //
                if (fpc.Count > 0)
                {
                    ddlFacturas.DataSource = fpc;
                    ddlFacturas.DataValueField = "Numero";
                    ddlFacturas.DataTextField = "Numero";
                    ddlFacturas.DataBind();
                    ddlFacturas.Enabled = true;
                    //
                    var FPSeleccionada = FPs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlFacturas.SelectedValue)).ToList();

                    LlenarGridFacturaPedido(FPSeleccionada);

                    Session["FacturasPedido"] = FPs;
                }
                else {
                    LimpiarControlesOrdenes();
                }
            } else {
                ContenedorFacturasCompraCompleta m = new ContenedorFacturasCompraCompleta();
                m = x.FacturaCompraCompletaRescatar(Session["TokenUsuario"].ToString());

                //filtrar las ordenes rescatadas
                var FCs = m.Lista.Where(p => p.OCRelacionada.RutCliente == ddlEmpresas.SelectedValue
                                          && p.Cabecera.Estado == "activo").ToList();

                //formatear lista para dejar en dropdwonlist, solo se deja numero orden
                var fcc = (from l in FCs
                           select new
                           {
                               Numero = l.Cabecera.Numero
                           }
                            ).ToList();

                if (fcc.Count > 0)
                {
                    ddlFacturas.DataSource = fcc;
                    ddlFacturas.DataValueField = "Numero";
                    ddlFacturas.DataTextField = "Numero";
                    ddlFacturas.DataBind();
                    ddlFacturas.Enabled = true;
                    //
                    var FCSeleccionada = FCs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlFacturas.SelectedValue)).ToList();

                    LlenarGridFacturaCompra(FCSeleccionada);

                    Session["FacturasCompra"] = FCs;
                }
                else {
                    LimpiarControlesOrdenes();
                }
            }
        }

        private void LlenarGridFacturaPedido(List<FacturaPedidoCompleta> lista)
        {
            var detalle = (from l in lista
                                select new
                                {
                                    NroOrden = l.OPRelacionada.Numero,
                                    FecOrden = l.OPRelacionada.FechaEmision,
                                    MedPago  = l.Pago.MedioPago,
                                    Moneda   = l.Pago.CodigoISO,
                                    Monto    = l.Pago.Monto
                                }
                        ).ToList();
            ////////
            gwFacturaDetalle.DataSource = detalle;
            gwFacturaDetalle.DataBind();
            ////////
            txtOrden.Text = detalle.SingleOrDefault().NroOrden.ToString();
            ////////
        }

        private void LlenarGridFacturaCompra(List<FacturaCompraCompleta> lista)
        {
            var detalle = (from l in lista
                                select new
                                {
                                    NroOrden = l.OCRelacionada.Numero,
                                    FecOrden = l.OCRelacionada.FechaRecepcion,
                                    MedPago  = l.Pago.MedioPago,
                                    Moneda   = l.Pago.CodigoISO,
                                    Monto    = l.Pago.Monto
                                }
                        ).ToList();
            ////////
            gwFacturaDetalle.DataSource = detalle;
            gwFacturaDetalle.DataBind();
            ////////
            txtOrden.Text = detalle.SingleOrDefault().NroOrden.ToString();
            ////////
        }

        protected void ddlTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            RescatarDatos();
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            RescatarFacturasXEmpresa(x);
        }

        protected void ddlFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                var FPs = (List<FacturaPedidoCompleta>)Session["FacturasPedido"];
                var FPSeleccionada = FPs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlFacturas.SelectedValue)).ToList();
                LlenarGridFacturaPedido(FPSeleccionada);
            }
            else {
                var FCs = (List<FacturaCompraCompleta>)Session["FacturasCompra"];
                var FCSeleccionada = FCs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlFacturas.SelectedValue)).ToList();
                LlenarGridFacturaCompra(FCSeleccionada);
            }
        }

        protected void btnAnularFactura_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorFacturaPedidoCompleta xFPC = new ContenedorFacturaPedidoCompleta();
                xFPC.Item.Cabecera.Numero = decimal.Parse(ddlFacturas.SelectedValue);
                //
                xFPC.Item.OPRelacionada.Numero = decimal.Parse(txtOrden.Text);
                //
                xFPC.Item.Cabecera.Observaciones = txtObservacion.Text;
                //
                xFPC.Retorno.Token = Session["TokenUsuario"].ToString();

                xFPC = x.FacturaPedidoCompletaActualizar(xFPC);

                if (xFPC.Retorno.Codigo == 0)
                {
                    RescatarDatos();
                }
            }
            else {
                ContenedorFacturaCompraCompleta xFCC = new ContenedorFacturaCompraCompleta();
                xFCC.Item.Cabecera.Numero = decimal.Parse(ddlFacturas.SelectedValue);
                //
                xFCC.Item.OCRelacionada.Numero = decimal.Parse(txtOrden.Text);
                //
                xFCC.Item.Cabecera.Observaciones = txtObservacion.Text;
                //
                xFCC.Retorno.Token = Session["TokenUsuario"].ToString();

                xFCC = x.FacturaCompraCompletaActualizar(xFCC);

                if (xFCC.Retorno.Codigo == 0)
                {
                    RescatarDatos();
                }
            }
        }
    }
}
