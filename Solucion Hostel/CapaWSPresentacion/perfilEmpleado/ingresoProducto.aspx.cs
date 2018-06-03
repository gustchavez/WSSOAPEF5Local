using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class ingresoProducto : System.Web.UI.Page
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
            //Recuperar datos de proveedores
            ContenedorPerfilUsuarioProveedores n = new ContenedorPerfilUsuarioProveedores();
            n = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());
            var proveedores = (from prov in n.Lista
                              select new
                              {
                                  Rut = prov.Proveedor.Rut,
                                  RazonSocial = prov.PerfilUsuario.Empresa.RazonSocial
                              }
                            ).ToList();

            txtProveedorAgregar.DataSource = null;
            txtProveedorAgregar.DataSource = proveedores;
            txtProveedorAgregar.DataValueField = "Rut";
            txtProveedorAgregar.DataTextField = "RazonSocial";
            txtProveedorAgregar.DataBind();

            txtProveedorModificar.DataSource = null;
            txtProveedorModificar.DataSource = proveedores;
            txtProveedorModificar.DataValueField = "Rut";
            txtProveedorModificar.DataTextField = "RazonSocial";
            txtProveedorModificar.DataBind();

            //Recuperar datos de productos
            ContenedorProductos m = new ContenedorProductos();
            m = x.ProductoRescatar(Session["TokenUsuario"].ToString());
            txtProductoModificar.DataSource = m.Lista;
            txtProductoModificar.DataValueField = "Codigo";
            txtProductoModificar.DataTextField = "Descripcion";
            txtProductoModificar.DataBind();
        }

        protected void btnAgregar_click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProducto nProducto = new ContenedorProducto();

            nProducto.Item.Descripcion = txtDetProdAgregar.Text;
            nProducto.Item.Stock = 0;
            nProducto.Item.StockCritico = 0;
            nProducto.Retorno.Token = Session["TokenUsuario"].ToString();

            nProducto = x.ProductoCrear(nProducto);

            if (nProducto.Retorno.Codigo.ToString() == "0")
            {
                ContenedorProvision nProvision = new ContenedorProvision();

                nProvision.Item.RutProveedor = txtProveedorAgregar.SelectedValue;
                nProvision.Item.CodigoProducto = (int)nProducto.Item.Codigo;
                nProvision.Item.Precio = decimal.Parse(txtPrecioProdAgregar.Text);
                nProvision.Retorno.Token = Session["TokenUsuario"].ToString();

                nProvision = x.ProvisionCrear(nProvision);
                if (nProvision.Retorno.Codigo.ToString() == "0")
                {
                    txtCodProdAgregar.Text = nProducto.Item.Codigo.ToString();
                }
                else
                {
                    txtCodProdAgregar.Text = "-2";
                    //nProvision.Retorno.Codigo.ToString();
                    //nProvision.Retorno.Glosa;
                }
            } else  {
                txtCodProdAgregar.Text = "-1";
                //nProducto.Retorno.Codigo.ToString();
                //nProducto.Retorno.Glosa;
            }
        }

        protected void btnModificar_click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            
            ContenedorProvision nProvision = new ContenedorProvision();

            nProvision.Item.RutProveedor = txtProveedorModificar.SelectedValue;
            nProvision.Item.CodigoProducto = int.Parse(txtProductoModificar.SelectedValue.ToString());
            nProvision.Item.Precio = decimal.Parse(txtPrecioModificar.Text);
            nProvision.Retorno.Token = Session["TokenUsuario"].ToString();

            nProvision = x.ProvisionActualizar(nProvision);
            if (nProvision.Retorno.Codigo.ToString() == "0")
            {
                txtPrecioModificar.Text = "0";
            }
            else
            {
                txtPrecioModificar.Text = "-1";
                //nProvision.Retorno.Codigo.ToString();
                //nProvision.Retorno.Glosa;
            }
        }
    }
}