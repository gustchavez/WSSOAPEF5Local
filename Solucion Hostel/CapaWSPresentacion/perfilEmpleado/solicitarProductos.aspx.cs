﻿using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class solicitarProductos : System.Web.UI.Page
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

            //Recuperar datos de provisiones
            ContenedorProvisiones m = new ContenedorProvisiones();
            m = x.ProvisionRescatar(Session["TokenUsuario"].ToString());

            //Recuperar datos de proveedores
            ContenedorPerfilUsuarioProveedores n = new ContenedorPerfilUsuarioProveedores();
            n = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

            var proveedores = (from prvi in m.Lista
                               join prov in n.Lista on prvi.RutProveedor equals prov.Proveedor.Rut
                               orderby prov.PerfilUsuario.Empresa.RazonSocial
                               select new
                               {
                                   Rut = prov.Proveedor.Rut,
                                   RazonSocial = prov.PerfilUsuario.Empresa.RazonSocial
                               }
                              ).Distinct().ToList();

            txtProveedor.DataSource = null;
            txtProveedor.DataSource = proveedores;
            txtProveedor.DataValueField = "Rut";
            txtProveedor.DataTextField = "RazonSocial";
            txtProveedor.DataBind();
            
            //guardar los valores
            Session["TemporalProvision"] = m.Lista;
            Session["TemporalProveedor"] = n.Lista;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            OrdenPedidoCompleta ListaTemporal;

            try
            {
                ListaTemporal = (OrdenPedidoCompleta)Session["ListaTemporal"];
                if (ListaTemporal == null)
                {
                    ListaTemporal = new OrdenPedidoCompleta();
                }
            }
            catch (Exception)
            {
                ListaTemporal = new OrdenPedidoCompleta();
            }

            OrdenPedidoDetalle opd = new OrdenPedidoDetalle();

            try
            {
                List<Provision> Lprvi = (List<Provision>)Session["TemporalProvision"];
                List<Producto>  Lprod = (List<Producto>)Session["TemporalProducto"];

                var producto = (from prvi in Lprvi
                                join prod in Lprod on prvi.CodigoProducto equals prod.Codigo
                                where prvi.RutProveedor   == txtProveedor.SelectedValue
                                   && prvi.CodigoProducto == int.Parse(txtProducto.SelectedValue)
                                select new
                                {
                                    CodProd     = prod.Codigo,
                                    Descripcion = prod.Descripcion,
                                    PreUni      = prvi.Precio,
                                    Cantidad    = int.Parse(txtCantidad.Text),
                                    PrecioCant  = prvi.Precio * int.Parse(txtCantidad.Text)
                                }
                                ).SingleOrDefault();

                opd.RegistroRecepcionPedido.Producto.Codigo = producto.CodProd;
                opd.RegistroRecepcionPedido.Producto.Descripcion = producto.Descripcion;
                opd.RegistroRecepcionPedido.PrecioUnitario = producto.PreUni;
                opd.RegistroRecepcionPedido.Cantidad = producto.Cantidad;
                opd.RegistroRecepcionPedido.PrecioCantidad = producto.PrecioCant;

                ListaTemporal.ListaDetalle.Add(opd);

                var formatogw = (from fmgw in ListaTemporal.ListaDetalle
                                 select new
                                 {
                                     CodProd = fmgw.RegistroRecepcionPedido.Producto.Codigo,
                                     Descripcion = fmgw.RegistroRecepcionPedido.Producto.Descripcion,
                                     PrecioUnitario = fmgw.RegistroRecepcionPedido.PrecioUnitario,
                                     Cantidad = fmgw.RegistroRecepcionPedido.Cantidad,
                                     PrecioCantidad = fmgw.RegistroRecepcionPedido.PrecioCantidad
                                 }
                                    ).ToList();

                gwListaCompra.DataSource = null;
                gwListaCompra.DataSource = formatogw;
                gwListaCompra.DataBind();

                Session["ListaTemporal"] = ListaTemporal;
            }
            catch (Exception ex)
            {

            }                      
        }

        protected void btnSelectProveedor_Click(object sender, EventArgs e)
        {
            if (txtProveedor.Enabled == true)
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                //Recuperar datos de provisiones
                ContenedorProvisiones m = new ContenedorProvisiones();
                m = x.ProvisionRescatar(Session["TokenUsuario"].ToString());

                //Recuperar datos de productos
                ContenedorProductos o = new ContenedorProductos();
                o = x.ProductoRescatar(Session["TokenUsuario"].ToString());

                var productos = (from prvi in m.Lista
                                 join prod in o.Lista on prvi.CodigoProducto equals prod.Codigo
                                 where prvi.RutProveedor == txtProveedor.SelectedValue
                                 orderby prod.Descripcion
                                 select new
                                 {
                                     Codigo = prod.Codigo,
                                     Descripcion = prod.Descripcion
                                 }
                                ).ToList();

                txtProducto.DataSource = null;
                txtProducto.DataSource = productos;
                txtProducto.DataValueField = "Codigo";
                txtProducto.DataTextField = "Descripcion";
                txtProducto.DataBind();

                Session["TemporalProducto"] = o.Lista;

                OrdenPedidoCompleta ListaTemporal = new OrdenPedidoCompleta();

                ListaTemporal.Cabecera.Estado = "activo";
                ListaTemporal.Cabecera.FechaEmision = DateTime.Now;
                ListaTemporal.Cabecera.Monto = 0;
                ListaTemporal.Cabecera.Numero = 0;
                ListaTemporal.Cabecera.RutProveedor = txtProveedor.SelectedValue;
                ListaTemporal.Cabecera.Ubicacion = "Logo";

                Session["ListaTemporal"] = ListaTemporal;

                txtProveedor.Enabled = false;
                btnSelectProveedor.Text = "Modificar Proveedor";
                txtProducto.Enabled = true;
                txtCantidad.Enabled = true;
                btnAgregar.Enabled = true;
                btnRealizar.Enabled = true;

            } else {
                InicializarProveedor();
            }            
        }
        protected void btnRealizar_Click(object sender, EventArgs e)
        {
            OrdenPedidoCompleta ListaTemporal;

            try
            {
                ListaTemporal = (OrdenPedidoCompleta)Session["ListaTemporal"];
                if (ListaTemporal != null)
                {
                    ListaTemporal.Cabecera.Monto = ListaTemporal.ListaDetalle.Sum(p => p.RegistroRecepcionPedido.PrecioCantidad);//realizar calculo de las habitaciones seleccionadas

                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                    ContenedorOrdenPedidoCompleta xOPC = new ContenedorOrdenPedidoCompleta();
                    xOPC.Item.Cabecera = ListaTemporal.Cabecera;
                    xOPC.Item.ListaDetalle = ListaTemporal.ListaDetalle;
                    xOPC.Retorno.Token = Session["TokenUsuario"].ToString();

                    xOPC = x.OrdenPedidoCompletaCrear(xOPC);
                    
                    InicializarProveedor();

                    //txtCodigoRetorno.Text = xOPC.Retorno.Codigo.ToString();
                    //txtGlosaRetorno.Text = xOPC.Retorno.Glosa;
                }
                Session["ListaTemporal"] = null;
            }
            catch (Exception)
            {
                Session["ListaTemporal"] = null;
            }
        }

        private void InicializarProveedor()
        {
            Session["ListaTemporal"] = null;
            gwListaCompra.DataSource = null;
            gwListaCompra.DataBind();

            txtProveedor.Enabled = true;
            btnSelectProveedor.Text = "Elegir Proveedor";
            txtProducto.Enabled = false;
            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            btnRealizar.Enabled = false;
        }
    }
}