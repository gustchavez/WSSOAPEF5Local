using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class recepcionProducto : System.Web.UI.Page
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
            ////
            ContenedorPerfilUsuarioProveedores m = new ContenedorPerfilUsuarioProveedores();
            m = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

            var prov = (from l in m.Lista
                            //where l.OCRelacionada.RutCliente == datSes.RutEmpresa
                        select new
                        {
                            Rut = l.Proveedor.Rut,
                            RazonSocial = l.PerfilUsuario.Empresa.RazonSocial,
                        }
                        ).ToList();

            if (prov != null)
            {
                ddlEmpresas.DataSource = prov;
                ddlEmpresas.DataValueField = "Rut";
                ddlEmpresas.DataTextField = "RazonSocial";
                ddlEmpresas.Enabled = true;
                ddlEmpresas.DataBind();
                ////
                RescatarOrdenesXEmpresa(x);
                ////
            }
            else {
                //////////////
                ddlEmpresas.DataSource = prov;
                ddlEmpresas.DataBind();
                ddlEmpresas.Items.Add(new ListItem("No Existe", ""));
                ddlEmpresas.SelectedIndex = 0;
                //////////////
                ddlEmpresas.Enabled = false;

                //////////////
                ddlOrdenes.DataSource = prov;
                ddlOrdenes.DataBind();
                ddlOrdenes.Items.Add(new ListItem("No Existe", ""));
                ddlOrdenes.SelectedIndex = 0;
                //////////////
                ddlOrdenes.Enabled = false;
            }
            LlenarGrid();
        }

        private void RescatarOrdenesXEmpresa(WSSoap.WSSHostelClient x)
        {
            ContenedorOrdenesPedidoCompleta n = new ContenedorOrdenesPedidoCompleta();

            n = x.OrdenPedidoCompletaRescatar(Session["TokenUsuario"].ToString());
            List<OrdenPedidoCompleta> OrdenesPedido = n.Lista.Where(p => p.Cabecera.Estado == "activo").ToList();

            var opc = (from l in OrdenesPedido
                       where l.Cabecera.RutProveedor == ddlEmpresas.SelectedValue
                       //&& l.Cabecera.Estado == "activo"
                       select new
                       {
                           Numero = l.Cabecera.Numero
                       }
                       ).ToList();

            Session["ListaOrdenesPedidoCompleta"] = OrdenesPedido;

            if (opc.Count > 0)
            {
                ddlOrdenes.DataSource = opc;
                ddlOrdenes.DataValueField = "Numero";
                ddlOrdenes.DataTextField = "Numero";
                ddlOrdenes.Enabled = true;
                ddlOrdenes.DataBind();
            }
            else {
                //////////////
                ddlOrdenes.DataSource = opc;
                ddlOrdenes.DataBind();
                ddlOrdenes.Items.Add(new ListItem("No Existe", ""));
                ddlOrdenes.SelectedIndex = 0;
                //////////////
                ddlOrdenes.Enabled = false;
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow item in gwListaRecepcion.Rows)
            {
                CheckBox EstadoReserva = (item.Cells[0].Controls[1] as CheckBox);
                bool EstadoReservaBBDD = item.Cells[3].Text == "Si" ? true : false;
                if (EstadoReserva.Checked != EstadoReservaBBDD)
                {
                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                    ContenedorRegistroRecepcionPedido m = new ContenedorRegistroRecepcionPedido();

                    m.Item.NumeroOrdenPedido = decimal.Parse(item.Cells[1].Text);
                    m.Item.Producto.Codigo   = decimal.Parse(item.Cells[2].Text);
                    //m.Item.Confirmado      = item.Cells[0].Text == "1" ? "Si" : "No";
                    m.Item.Confirmado        = EstadoReserva.Checked == true ? "Si" : "No";

                    m.Retorno.Token = Session["TokenUsuario"].ToString();

                    m = x.ProdConfirRecepActualizar(m);
                }
            }
            RescatarDatos();
        }

        protected void ddlOrdenesCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            if (ddlOrdenes.SelectedValue != null && ddlOrdenes.SelectedValue != string.Empty)
            {
                var collection = (List<OrdenPedidoCompleta>)Session["ListaOrdenesPedidoCompleta"];
                /////////////////
                var ocd = (from l in collection
                           where l.Cabecera.Numero == decimal.Parse(ddlOrdenes.SelectedValue)
                           select new
                           {
                               ListaDetalle = l.ListaDetalle.ToList()
                           }
                           ).SingleOrDefault();
                /////////////////
                var productos = (from m in ocd.ListaDetalle
                                 select new
                                 {
                                     NroOrden      = m.RegistroRecepcionPedido.NumeroOrdenPedido,
                                     CodProducto   = m.RegistroRecepcionPedido.Producto.Codigo,
                                     Nombre        = m.RegistroRecepcionPedido.Producto.Descripcion,
                                     Cantidad      = m.RegistroRecepcionPedido.Cantidad,
                                     Estado        = m.RegistroRecepcionPedido.Confirmado,
                                     EstadoBool    = m.RegistroRecepcionPedido.Confirmado == "Si" ? true : false
                                 }
                           ).ToList();
                /////////////////
                gwListaRecepcion.DataSource = null;
                gwListaRecepcion.DataSource = productos;
                gwListaRecepcion.DataBind();
                /////////////////
            }
            else
            {
                gwListaRecepcion.DataSource = null;
                gwListaRecepcion.DataBind();
            }
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            RescatarOrdenesXEmpresa(x);

            LlenarGrid();
        }
    }
}