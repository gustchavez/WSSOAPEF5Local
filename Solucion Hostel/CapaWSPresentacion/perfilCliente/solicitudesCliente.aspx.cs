﻿using CapaObjeto;
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
            var listaPedidoCliente = n.Lista.Where(p => p.Cabecera.RutCliente == datSes.RutEmpresa
                                                       && (p.Cabecera.Estado == "activo"
                                                        || p.Cabecera.Estado == "facturada")
                                                    )
                                              .OrderBy(p => p.Cabecera.Numero).ToList();

            if (listaPedidoCliente != null)
            {

                var ordenes = (from cli in listaPedidoCliente
                               select new
                            {
                                NroOrden = cli.Cabecera.Numero,
                                FechaSolicitud = cli.Cabecera.FechaRecepcion,
                                Monto = cli.Cabecera.Monto,
                                Estado = cli.Cabecera.Estado
                            }
                            ).ToList();

                gwOrdenesCompra.DataSource = null;
                gwOrdenesCompra.DataSource = ordenes;
                gwOrdenesCompra.DataBind();

            } else {
                gwOrdenesCompra.DataSource = null;
                gwOrdenesCompra.DataBind();
            }

            gwOrdenDetalle.DataSource = null;
            gwOrdenDetalle.DataBind();

            Session["OrdenesCompra"] = listaPedidoCliente;
        }

        protected void gwOrdenesCompra_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<OrdenCompraCompleta> lista = (List<OrdenCompraCompleta>)Session["OrdenesCompra"];

            GridViewRow row = gwOrdenesCompra.SelectedRow;
            
            //row.CssClass = "listaFacturaSeleccion2";

            var orden = (from l in lista
                         where l.Cabecera.Numero == int.Parse(row.Cells[1].Text)
                         select new
                         {
                             DetalleOC = l.ListaDetalle.ToList()
                         }
                         ).FirstOrDefault();
            ////////
            if (orden.DetalleOC != null)
            {
                var detalleOrden = (from l in orden.DetalleOC
                                    select new
                                    {
                                        RutPersona = l.Persona.Rut,
                                        FecIng = l.Alojamiento.FechaIngreso,
                                        FecEgr = l.Alojamiento.FechaEgreso,
                                        CantDias = l.Alojamiento.RegistroDias,
                                        CapacHab = l.Alojamiento.Habitacion.Capacidad,
                                        PrecioHab = (l.Alojamiento.Habitacion.Precio / l.Alojamiento.Habitacion.Capacidad),
                                        TipoComida = l.Comida.ServicioComida.Tipo,
                                        PrecioCom = l.Comida.ServicioComida.Precio,
                                        PrecioSubTotal = l.Alojamiento.RegistroDias * ((l.Alojamiento.Habitacion.Precio /l.Alojamiento.Habitacion.Capacidad)+ l.Comida.ServicioComida.Precio)
                                    }
                            ).ToList();

                gwOrdenDetalle.DataSource = null;
                gwOrdenDetalle.DataSource = detalleOrden;
                gwOrdenDetalle.DataBind();
            }
            else {
                gwOrdenDetalle.DataSource = null;
                gwOrdenDetalle.DataBind();
            }
        }
    }
}