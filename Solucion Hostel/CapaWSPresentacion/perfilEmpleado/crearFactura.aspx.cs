using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }
        }

        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorClientes n = new ContenedorClientes();

            n = x.ClienteRescatar(Session["TokenUsuario"].ToString());

            ddlEmpresas.DataSource = null;
            ddlEmpresas.DataSource = n.Lista;
            ddlEmpresas.DataValueField = "Rut";
            ddlEmpresas.DataTextField = "Rut";
            ddlEmpresas.DataBind();
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorFacturaPedidoCompleta xFPC = new ContenedorFacturaPedidoCompleta();
                xFPC.Item.Cabecera.Numero = 0;
                xFPC.Item.Cabecera.NumeroOrdenPedido = decimal.Parse(ddlOrdenes.SelectedValue);
                xFPC.Item.Cabecera.ValorBruto = int.Parse(txtValorBruto.Text);
                xFPC.Item.Cabecera.ValorIva   = int.Parse(txtValorIVA.Text);
                xFPC.Item.Cabecera.ValorNeto  = int.Parse(txtValorNeto.Text);
                xFPC.Item.Cabecera.Observaciones = txtObservacion.Text;
                xFPC.Item.Cabecera.Ubicacion = "logo";
                xFPC.Item.Pago.MedioPago = ddlMedioPago.SelectedValue.ToString();
                xFPC.Item.Pago.Divisa = txtDivisa.Text;
                xFPC.Item.Pago.CodigoISO = txtCodigoISO.Text;
                xFPC.Item.Pago.Monto = txtMonto.Text;
                xFPC.Item.Pago.TasaCambioCLP = decimal.Parse(txtTasaCambio.Text);
                xFPC.Item.OPRelacionada.Monto = decimal.Parse(txtMonto.Text);
                
                xFPC.Retorno.Token = Session["TokenUsuario"].ToString();

                xFPC = x.FacturaPedidoCompletaCrear(xFPC);

                if (xFPC.Item.Cabecera.Numero > 0)
                {
                    RescatarDatos();
                }
            } else {
                ContenedorFacturaCompraCompleta xFCC = new ContenedorFacturaCompraCompleta();
                xFCC.Item.Cabecera.Numero = 0;
                xFCC.Item.Cabecera.NumeroOrdenCompra = decimal.Parse(ddlOrdenes.SelectedValue);
                xFCC.Item.Cabecera.ValorBruto = int.Parse(txtValorBruto.Text);
                xFCC.Item.Cabecera.ValorIva = int.Parse(txtValorIVA.Text);
                xFCC.Item.Cabecera.ValorNeto = int.Parse(txtValorNeto.Text);
                xFCC.Item.Cabecera.Observaciones = txtObservacion.Text;
                xFCC.Item.Cabecera.Ubicacion = "logo";
                xFCC.Item.Pago.MedioPago = ddlMedioPago.SelectedValue.ToString();
                xFCC.Item.Pago.Divisa = txtDivisa.Text;
                xFCC.Item.Pago.CodigoISO = txtCodigoISO.Text;
                xFCC.Item.Pago.Monto = txtMonto.Text;
                xFCC.Item.Pago.TasaCambioCLP = decimal.Parse(txtTasaCambio.Text);
                xFCC.Item.OCRelacionada.Monto = decimal.Parse(txtMonto.Text);

                xFCC.Retorno.Token = Session["TokenUsuario"].ToString();

                xFCC = x.FacturaCompraCompletaCrear(xFCC);

                if (xFCC.Item.Cabecera.Numero > 0)
                {
                    RescatarDatos();
                }

            }
            
        }

        protected void ddlTipoEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlEmpresas.DataSource = null;

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorPerfilUsuarioProveedores m = new ContenedorPerfilUsuarioProveedores();
                m = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

                var prov = (from l in m.Lista
                           //where l.OCRelacionada.RutCliente == datSes.RutEmpresa
                            select new
                            {
                                Rut = l.Proveedor.Rut,
                                RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                            }
                            ).ToList();

                ddlEmpresas.DataSource = prov;
                ddlEmpresas.DataValueField = "Rut";
                ddlEmpresas.DataTextField = "RazonSocial";
                ddlEmpresas.DataBind();
            } else {
                ContenedorPerfilUsuarioClientes m = new ContenedorPerfilUsuarioClientes();
                m = x.PerfilUsuarioClienteRescatar(Session["TokenUsuario"].ToString());

                var clie = (from l in m.Lista
                                //where l.OCRelacionada.RutCliente == datSes.RutEmpresa
                            select new
                            {
                                Rut = l.Cliente.Rut,
                                RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                            }
                            ).ToList();

                ddlEmpresas.DataSource = clie;
                ddlEmpresas.DataValueField = "Rut";
                ddlEmpresas.DataTextField = "RazonSocial";
                ddlEmpresas.DataBind();
            }
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlOrdenes.DataSource = null;

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            if (ddlTipoEmpresa.SelectedValue == "Proveedor")
            {
                ContenedorOrdenesPedidoCompleta m = new ContenedorOrdenesPedidoCompleta();
                m = x.OrdenPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

                var opc = (from l in m.Lista
                            where l.Cabecera.RutProveedor == ddlEmpresas.SelectedValue
                               && l.Cabecera.Estado == "activo"
                            select new
                            {
                                Numero = l.Cabecera.Numero
                            }
                            ).ToList();

                ddlOrdenes.DataSource = opc;
                ddlOrdenes.DataValueField = "Numero";
                ddlOrdenes.DataTextField = "Numero";
                ddlOrdenes.DataBind();
            } else {
                ContenedorOrdenesCompraCompleta m = new ContenedorOrdenesCompraCompleta();
                m = x.OrdenCompraCompletaRescatar(Session["TokenUsuario"].ToString());

                var occ = (from l in m.Lista
                           where l.Cabecera.RutCliente == ddlEmpresas.SelectedValue
                              && l.Cabecera.Estado == "activo"
                           select new
                           {
                               Numero = l.Cabecera.Numero
                           }
                            ).ToList();

                ddlOrdenes.DataSource = occ;
                ddlOrdenes.DataValueField = "Numero";
                ddlOrdenes.DataTextField = "Numero";
                ddlOrdenes.DataBind();
            }

        }
    }
}