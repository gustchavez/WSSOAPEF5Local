using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaWSPresentacion.WSSoap;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class crearFactura : System.Web.UI.Page
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
                    RescatarOrdenesXEmpresa(x);
                    ////
                } else {
                    LimpiarControles();
                }
            } else {
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
                    ddlEmpresas.DataSource     = clie;
                    ddlEmpresas.DataValueField = "Rut";
                    ddlEmpresas.DataTextField  = "RazonSocial";
                    ddlEmpresas.DataBind();
                    ddlEmpresas.Enabled        = true;
                    ////
                    RescatarOrdenesXEmpresa(x);
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
            ddlOrdenes.Items.Clear();
            ddlOrdenes.Items.Add(new ListItem("No Existe", ""));
            ddlOrdenes.DataBind();
            ddlOrdenes.SelectedIndex  = 0;
            //////////////
            ddlOrdenes.Enabled        = false;
            Session["OrdenesCompra"]  = null;
            //////////////
            ddlCodigoISO.Enabled      = false;
            //////////////
            gwOrdenDetalle.DataSource = null;
            gwOrdenDetalle.DataBind();
            /////////////
            txtValorBruto.Text        = string.Empty;
            txtValorIVA.Text          = string.Empty;
            txtValorNeto.Text         = string.Empty;
            txtMonto.Text             = string.Empty;
            txtObservacion.Text       = string.Empty;
        }

        private void RescatarOrdenesXEmpresa(WSSHostelClient x)
        {
            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorOrdenesPedidoCompleta m = new ContenedorOrdenesPedidoCompleta();
                m = x.OrdenPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

                //filtrar las ordenes rescatadas
                var OPs = m.Lista.Where(p => p.Cabecera.RutProveedor == ddlEmpresas.SelectedValue
                                          && p.Cabecera.Estado       == "activo" ).ToList();

                //formatear lista para dejar en dropdwonlist, solo se deja numero orden
                var opc = (from l in OPs
                           select new
                           {
                               Numero = l.Cabecera.Numero
                           }
                            ).ToList();

                if (opc.Count > 0)
                {
                    ddlOrdenes.DataSource = opc;
                    ddlOrdenes.DataValueField = "Numero";
                    ddlOrdenes.DataTextField = "Numero";
                    ddlOrdenes.DataBind();
                    ddlOrdenes.Enabled = true;
                    //
                    ddlCodigoISO.Enabled = true;
                    //
                    var OPSeleccionada = OPs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlOrdenes.SelectedValue)).ToList();

                    LlenarGridOrdenPedido(OPSeleccionada);

                    Session["OrdenesPedido"] = OPs;
                } else {
                    LimpiarControlesOrdenes();
                }
            } else {
                ContenedorOrdenesCompraCompleta m = new ContenedorOrdenesCompraCompleta();
                m = x.OrdenCompraCompletaRescatar(Session["TokenUsuario"].ToString());
                
                //filtrar las ordenes rescatadas
                var OCs = m.Lista.Where(p => p.Cabecera.RutCliente == ddlEmpresas.SelectedValue
                                          && p.Cabecera.Estado     == "activo").ToList();

                //formatear lista para dejar en dropdwonlist, solo se deja numero orden
                var occ = (from l in OCs
                           select new
                           {
                               Numero = l.Cabecera.Numero
                           }
                            ).ToList();
                
                if (occ.Count > 0)
                {
                    ddlOrdenes.DataSource = occ;
                    ddlOrdenes.DataValueField = "Numero";
                    ddlOrdenes.DataTextField = "Numero";
                    ddlOrdenes.DataBind();
                    ddlOrdenes.Enabled = true;
                    //
                    ddlCodigoISO.Enabled = true;
                    //
                    var OCSeleccionada = OCs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlOrdenes.SelectedValue)).ToList();
                    
                    LlenarGridOrdenCompra(OCSeleccionada);

                    Session["OrdenesCompra"] = OCs;
                } else {
                    LimpiarControlesOrdenes();
                }
            }
        }

        private void LlenarGridOrdenPedido(List<OrdenPedidoCompleta> lista)
        {
            var orden = (from l in lista
                         select new
                         {
                             DetalleOP    = l.ListaDetalle.ToList()
                         }
                        ).FirstOrDefault();
            ////////
            var detalleOrden = (from l in orden.DetalleOP
                                select new
                                {
                                    CodProd  = l.RegistroRecepcionPedido.Producto.Codigo,
                                    NomProd  = l.RegistroRecepcionPedido.Producto.Descripcion,
                                    CantProd = l.RegistroRecepcionPedido.Cantidad,
                                    PreUniPr = l.RegistroRecepcionPedido.PrecioUnitario,
                                    PreCant  = l.RegistroRecepcionPedido.PrecioUnitario * l.RegistroRecepcionPedido.Cantidad,
                                    FecReci  = l.RegistroRecepcionPedido.Recepcion
                                }
                        ).ToList();
            ////////
            gwOrdenDetalle.DataSource = detalleOrden;
            gwOrdenDetalle.DataBind();
            /////////////
            int Bruto = (int)lista.FirstOrDefault().Cabecera.Monto;
            int IVA   = (int)Math.Round((Bruto * 0.19), 0);
            int Neto  = Bruto - IVA;
            /////////////
            LlenarTotales(Bruto, IVA, Neto);
            /////////////
        }

        private void LlenarGridOrdenCompra(List<OrdenCompraCompleta> lista)
        {
            var orden = (from l in lista
                         select new
                         { 
                             DetalleOC = l.ListaDetalle.ToList()
                         }
                        ).FirstOrDefault();
            ////////
            var detalleOrden = (from l in orden.DetalleOC
                                select new
                                {
                                    RutPersona     = l.Alojamiento.RutPersona,
                                    FecIng         = l.Alojamiento.FechaIngreso,
                                    FecEgr         = l.Alojamiento.FechaEgreso,
                                    CantDias       = l.Alojamiento.RegistroDias,
                                    CapacHab       = l.Alojamiento.Habitacion.Capacidad,
                                    PrecioHab      = l.Alojamiento.Habitacion.Precio,
                                    TipoComida     = l.Comida.ServicioComida.Tipo,
                                    PrecioCom      = l.Comida.ServicioComida.Precio,
                                    PrecioSubTotal = l.Alojamiento.RegistroDias * (l.Alojamiento.Habitacion.Precio + l.Comida.ServicioComida.Precio)
                                }
                        ).ToList();
            ////////
            gwOrdenDetalle.DataSource = detalleOrden;
            gwOrdenDetalle.DataBind();

            int Bruto = (int)lista.FirstOrDefault().Cabecera.Monto;
            int IVA = (int)Math.Round((Bruto * 0.19), 0);
            int Neto = Bruto - IVA;

            LlenarTotales(Bruto, IVA, Neto);
        }

        private void LlenarTotales(int Bruto, int IVA, int Neto)
        {
            txtValorBruto.Text = Bruto.ToString();
            txtValorIVA.Text = IVA.ToString();
            txtValorNeto.Text = Neto.ToString();
            /////////////
            LlenarMontoCambio();
        }

        private void LlenarMontoCambio()
        {
            int TasaCambio = int.Parse(ddlCodigoISO.SelectedValue);
            /////////////
            decimal MontoCambio = int.Parse(txtValorBruto.Text) / TasaCambio;
            /////////////
            txtMonto.Text = MontoCambio.ToString();
        }

        protected void ddlTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            RescatarDatos();
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            RescatarOrdenesXEmpresa(x);
        }

        protected void ddlOrdenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                var OPs = (List<OrdenPedidoCompleta>)Session["OrdenesPedido"];
                var OPSeleccionada = OPs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlOrdenes.SelectedValue)).ToList();
                LlenarGridOrdenPedido(OPSeleccionada);
            } else {
                var OCs = (List<OrdenCompraCompleta>)Session["OrdenesCompra"];
                var OCSeleccionada = OCs.Where(p => p.Cabecera.Numero == decimal.Parse(ddlOrdenes.SelectedValue)).ToList();
                LlenarGridOrdenCompra(OCSeleccionada);
            }
        }

        protected void ddlCodigoISO_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarMontoCambio();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorFacturaPedidoCompleta xFPC = new ContenedorFacturaPedidoCompleta();
                xFPC.Item.Cabecera.Numero = 0;
                //
                xFPC.Item.Cabecera.NumeroOrdenPedido = decimal.Parse(ddlOrdenes.SelectedValue);
                //
                xFPC.Item.Cabecera.ValorBruto        = int.Parse(txtValorBruto.Text);
                xFPC.Item.Cabecera.ValorIva          = int.Parse(txtValorIVA.Text);
                xFPC.Item.Cabecera.ValorNeto         = int.Parse(txtValorNeto.Text);
                xFPC.Item.Cabecera.Observaciones     = txtObservacion.Text;
                //
                xFPC.Item.Cabecera.Ubicacion         = "logo";
                //
                xFPC.Item.Pago.MedioPago             = ddlMedioPago.SelectedValue.ToString();
                xFPC.Item.Pago.Divisa                = ddlCodigoISO.SelectedItem.Text; //txtDivisa.Text;
                xFPC.Item.Pago.CodigoISO             = ddlCodigoISO.SelectedItem.Text; //txtCodigoISO.Text;
                //
                xFPC.Item.Pago.Monto                 = txtMonto.Text + " " + xFPC.Item.Pago.CodigoISO; // txtMonto.Text;
                xFPC.Item.Pago.TasaCambioCLP         = int.Parse(ddlCodigoISO.SelectedValue);
                
                xFPC.Item.OPRelacionada.Monto        = xFPC.Item.Cabecera.ValorBruto; //decimal.Parse(txtMonto.Text);

                xFPC.Retorno.Token = Session["TokenUsuario"].ToString();

                xFPC = x.FacturaPedidoCompletaCrear(xFPC);

                if (xFPC.Item.Cabecera.Numero > 0)
                {
                    RescatarDatos();
                }
            } else {
                ContenedorFacturaCompraCompleta xFCC = new ContenedorFacturaCompraCompleta();
                xFCC.Item.Cabecera.Numero = 0;
                //
                xFCC.Item.Cabecera.NumeroOrdenCompra = decimal.Parse(ddlOrdenes.SelectedValue);
                //
                xFCC.Item.Cabecera.ValorBruto        = int.Parse(txtValorBruto.Text);
                xFCC.Item.Cabecera.ValorIva          = int.Parse(txtValorIVA.Text);
                xFCC.Item.Cabecera.ValorNeto         = int.Parse(txtValorNeto.Text);
                xFCC.Item.Cabecera.Observaciones     = txtObservacion.Text;
                //
                xFCC.Item.Cabecera.Ubicacion         = "logo";
                //
                xFCC.Item.Pago.MedioPago             = ddlMedioPago.SelectedValue.ToString();
                xFCC.Item.Pago.Divisa                = ddlCodigoISO.SelectedItem.Text; //txtDivisa.Text;
                xFCC.Item.Pago.CodigoISO             = ddlCodigoISO.SelectedItem.Text; //txtCodigoISO.Text;
                //
                xFCC.Item.Pago.Monto                 = txtMonto.Text + " " + xFCC.Item.Pago.CodigoISO; // txtMonto.Text;
                xFCC.Item.Pago.TasaCambioCLP         = int.Parse(ddlCodigoISO.SelectedValue);
                
                xFCC.Item.OCRelacionada.Monto        = xFCC.Item.Cabecera.ValorBruto; //decimal.Parse(txtMonto.Text);

                xFCC.Retorno.Token = Session["TokenUsuario"].ToString();

                xFCC = x.FacturaCompraCompletaCrear(xFCC);

                if (xFCC.Item.Cabecera.Numero > 0)
                {
                    RescatarDatos();
                }
            }            
        }
    }
}
