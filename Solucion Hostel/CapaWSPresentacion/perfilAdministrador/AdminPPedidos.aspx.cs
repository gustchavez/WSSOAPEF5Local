﻿using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminPPedidos : System.Web.UI.Page
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

            //Filtrar solo por el proveedor
            var listaPedidoProveedor = n.Lista.ToList();

            if (listaPedidoProveedor.Count > 0)
            {
                var pedidos = (from prov in listaPedidoProveedor
                               orderby prov.Cabecera.RutProveedor, prov.Cabecera.Numero
                               select new
                               {
                                   RutEmpresa     = prov.Cabecera.RutProveedor,
                                   NroOrden       = prov.Cabecera.Numero,
                                   FechaSolicitud = prov.Cabecera.FechaEmision,
                                   Monto          = prov.Cabecera.Monto,
                                   Estado         = prov.Cabecera.Estado
                               }

                            ).ToList();

                gwSolicitudes.DataSource = null;
                gwSolicitudes.DataSource = pedidos;
                gwSolicitudes.DataBind();
            } else  {
                gwSolicitudes.DataSource = null;
                gwSolicitudes.DataBind();
            }

            gwOrdenDetalle.DataSource = null;
            gwOrdenDetalle.DataBind();
            
            Session["OrdenesPedido"] = listaPedidoProveedor;
        }

        protected void gwSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<OrdenPedidoCompleta> lista = (List<OrdenPedidoCompleta>)Session["OrdenesPedido"];

            GridViewRow row = gwSolicitudes.SelectedRow;

            var orden = (from l in lista
                           where l.Cabecera.Numero == int.Parse(row.Cells[2].Text)
                         select new
                         {
                             DetalleOP = l.ListaDetalle.ToList()
                         }
                         ).FirstOrDefault();
            ////////
            if (orden.DetalleOP != null)
            {
                var detalleOrden = (from l in orden.DetalleOP
                                    select new
                                    {
                                        CodProd = l.RegistroRecepcionPedido.Producto.Codigo,
                                        NomProd = l.RegistroRecepcionPedido.Producto.Descripcion,
                                        CantProd = l.RegistroRecepcionPedido.Cantidad,
                                        PreUniPr = l.RegistroRecepcionPedido.PrecioUnitario,
                                        PreCant = l.RegistroRecepcionPedido.PrecioUnitario * l.RegistroRecepcionPedido.Cantidad,
                                        FecReci = l.RegistroRecepcionPedido.Recepcion
                                    }
                            ).ToList();

                gwOrdenDetalle.DataSource = null;
                gwOrdenDetalle.DataSource = detalleOrden;
                gwOrdenDetalle.DataBind();
            } else {
                gwOrdenDetalle.DataSource = null;
                gwOrdenDetalle.DataBind();
            }
        }
    }
}