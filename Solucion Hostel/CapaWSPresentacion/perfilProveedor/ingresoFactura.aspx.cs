using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilProveedor
{
    public partial class ingresoFactura : System.Web.UI.Page
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
            Sesion datSes = (Sesion)Session["SesionUsuario"];

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            
            //Solo ordenes compra del proveedor
            ContenedorOrdenesPedidoCompleta m = new ContenedorOrdenesPedidoCompleta();
            m = x.OrdenPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

            var opc = (from l in m.Lista
                       where l.Cabecera.RutProveedor == datSes.RutEmpresa
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
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            
            ContenedorFacturaPedidoCompleta xFPC = new ContenedorFacturaPedidoCompleta();
            xFPC.Item.Cabecera.Numero = 0;
            xFPC.Item.Cabecera.NumeroOrdenPedido = decimal.Parse(ddlOrdenes.SelectedValue);
            xFPC.Item.Cabecera.ValorBruto = int.Parse(txtValorBruto.Text);
            xFPC.Item.Cabecera.ValorIva = int.Parse(txtValorIVA.Text);
            xFPC.Item.Cabecera.ValorNeto = int.Parse(txtValorNeto.Text);
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
        }        
    }
}