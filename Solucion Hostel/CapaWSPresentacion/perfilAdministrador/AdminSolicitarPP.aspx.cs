using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminSolicitarPP : System.Web.UI.Page
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

            var elementos = (from prvi in m.Lista
                             join prov in n.Lista on prvi.RutProveedor equals prov.Proveedor.Rut
                             orderby prov.PerfilUsuario.Empresa.RazonSocial
                             select new
                             {
                                 Rut = prov.Proveedor.Rut,
                                 RazonSocial = prov.PerfilUsuario.Empresa.RazonSocial
                             }
                            ).Distinct().ToList();

            if (elementos.Count > 0)
            {
                txtProveedor.DataSource = null;
                txtProveedor.DataSource = elementos;
                txtProveedor.DataValueField = "Rut";
                txtProveedor.DataTextField = "RazonSocial";
                txtProveedor.DataBind();

                CargarDDLProducto();

            }
            else {
                InicializarDDLProveedor();
                InicializarDDLProducto();
            }

            InicializarLista();

            //guardar los valores
            Session["TemporalProvision"] = m.Lista;
            Session["TemporalProveedor"] = n.Lista;

        }

        private void InicializarDDLProducto()
        {
            txtProducto.Items.Clear();
            txtProducto.Items.Add(new ListItem("No Existe", ""));
            txtProducto.DataBind();
            txtProducto.SelectedIndex = 0;

            txtProducto.Enabled = false;
            btnAgregar.Enabled = false;
            btnRealizar.Enabled = false;
        }

        private void InicializarDDLProveedor()
        {
            txtProveedor.Items.Clear();
            txtProveedor.Items.Add(new ListItem("No Existe", ""));
            txtProveedor.DataBind();
            txtProveedor.SelectedIndex = 0;

            txtProveedor.Enabled = false;
        }

        private void CargarDDLProducto()
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

            if (productos.Count > 0)
            {
                txtProducto.DataSource = null;
                txtProducto.DataSource = productos;
                txtProducto.DataValueField = "Codigo";
                txtProducto.DataTextField = "Descripcion";
                txtProducto.DataBind();

                Session["TemporalProducto"] = o.Lista;

                txtProducto.Enabled = true;
                txtCantidad.Enabled = true;
                btnAgregar.Enabled = true;

            }
            else {
                InicializarDDLProducto();
            }
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

            //Verificar Existe el Producto en la Lista Temporal
            if (VerificarExisteProdEnListaTemp(ListaTemporal.ListaDetalle) == false)
            {
                OrdenPedidoDetalle opd = new OrdenPedidoDetalle();

                List<Provision> Lprvi = (List<Provision>)Session["TemporalProvision"];
                List<Producto> Lprod = (List<Producto>)Session["TemporalProducto"];

                var producto = (from prvi in Lprvi
                                join prod in Lprod on prvi.CodigoProducto equals prod.Codigo
                                where prvi.RutProveedor == txtProveedor.SelectedValue
                                   && prvi.CodigoProducto == int.Parse(txtProducto.SelectedValue)
                                select new
                                {
                                    CodProd = prod.Codigo,
                                    Descripcion = prod.Descripcion,
                                    PreUni = prvi.Precio,
                                    Cantidad = int.Parse(txtCantidad.Text),
                                    PrecioCant = prvi.Precio * int.Parse(txtCantidad.Text)
                                }
                                ).SingleOrDefault();

                opd.RegistroRecepcionPedido.Producto.Codigo = producto.CodProd;
                opd.RegistroRecepcionPedido.Producto.Descripcion = producto.Descripcion;
                opd.RegistroRecepcionPedido.PrecioUnitario = producto.PreUni;
                opd.RegistroRecepcionPedido.Cantidad = producto.Cantidad;
                opd.RegistroRecepcionPedido.PrecioCantidad = producto.PrecioCant;

                ListaTemporal.ListaDetalle.Add(opd);
                DesplegarGridView(ListaTemporal);

                //verificar si la cantidad existente se puede habilitar el realizar
                btnRealizar.Enabled = true;

                Session["ListaTemporal"] = ListaTemporal;
            }

        }

        private bool VerificarExisteProdEnListaTemp(List<OrdenPedidoDetalle> listaDetalle)
        {
            bool existe = false;

            foreach (var item in listaDetalle)
            {
                if (item.RegistroRecepcionPedido.Producto.Codigo == int.Parse(txtProducto.SelectedValue))
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {
            OrdenPedidoCompleta ListaTemporal;

            try
            {
                ListaTemporal = (OrdenPedidoCompleta)Session["ListaTemporal"];
                if (ListaTemporal != null && ListaTemporal.ListaDetalle.Count > 0)
                {
                    ListaTemporal.Cabecera.Estado = "activo";
                    ListaTemporal.Cabecera.FechaEmision = DateTime.Now;
                    ListaTemporal.Cabecera.Monto = 0;
                    ListaTemporal.Cabecera.Numero = 0;
                    ListaTemporal.Cabecera.RutProveedor = txtProveedor.SelectedValue;
                    ListaTemporal.Cabecera.Ubicacion = "Logo";
                    //
                    ListaTemporal.Cabecera.Monto = ListaTemporal.ListaDetalle.Sum(p => p.RegistroRecepcionPedido.PrecioCantidad);//realizar calculo de las productos seleccionados

                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                    ContenedorOrdenPedidoCompleta xOPC = new ContenedorOrdenPedidoCompleta();
                    xOPC.Item.Cabecera = ListaTemporal.Cabecera;
                    xOPC.Item.ListaDetalle = ListaTemporal.ListaDetalle;
                    xOPC.Retorno.Token = Session["TokenUsuario"].ToString();

                    xOPC = x.OrdenPedidoCompletaCrear(xOPC);

                    if (xOPC.Retorno.Codigo == 0)
                    {
                        RescatarDatos();
                        //ok mostrar mensaje
                    }
                    else {
                        //error mostrar mensaje
                    }
                    Session["ListaTemporal"] = null;
                }
                Session["ListaTemporal"] = null;
            }
            catch (Exception ex)
            {
                Session["ListaTemporal"] = null;
            }
        }

        private void InicializarLista()
        {
            Session["ListaTemporal"] = null;
            gwListaCompra.DataSource = null;
            gwListaCompra.DataBind();
        }

        protected void txtProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            InicializarLista();
            CargarDDLProducto();
        }


        private void DesplegarGridView(OrdenPedidoCompleta ListaTemporal)
        {
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

        protected void gwListaCompra_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            OrdenPedidoCompleta ListaTemporal;

            try
            {
                ListaTemporal = (OrdenPedidoCompleta)Session["ListaTemporal"];
                if (ListaTemporal != null)
                {
                    OrdenPedidoDetalle eliminar = new OrdenPedidoDetalle();
                    //Buscar a eliminar
                    foreach (var item in ListaTemporal.ListaDetalle)
                    {
                        if (item.RegistroRecepcionPedido.Producto.Codigo == int.Parse(gwListaCompra.Rows[e.RowIndex].Cells[1].Text))
                        {
                            eliminar = item;
                            break;
                        }
                    }
                    //eliminar
                    if (eliminar != null)
                    {
                        ListaTemporal.ListaDetalle.Remove(eliminar);
                        DesplegarGridView(ListaTemporal);
                    }
                    //verificar si la cantidad existente se puede habilitar el realizar
                    if (ListaTemporal.ListaDetalle.Count > 0)
                    {
                        btnRealizar.Enabled = true;
                    }
                    else {
                        btnRealizar.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                //
            }
        }
    }
}