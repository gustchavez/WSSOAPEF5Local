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
            RescatarRelacionProvProd();
        }
        private Boolean validarTexbox1()
        {
            Boolean valido = true;
            if (txtProveedorAgregar.Text == "Seleccione una opción")
            {
                TextBox4.Visible = true;
                valido = false;
            }
            else
            {
                TextBox4.Visible = false;
            }
            if (txtDetProdAgregar.Text == null || txtDetProdAgregar.Text == "")
            {
                TextBox3.Visible = true;
                valido = false;
            }
            else
            {
                TextBox3.Visible = false;
            }
            if (txtPrecioProdAgregar.Text == null || txtPrecioProdAgregar.Text == "" || txtPrecioProdAgregar.Text == "0"
                || int.Parse(txtPrecioProdAgregar.Text)<0)
            {
                txtPrecioProdAgregar.Text = "0";
                TextBox2.Visible = true;
                valido = false;
            }
            else
            {
                TextBox2.Visible = false;
            }
            if (txtStock.Text == null || txtStock.Text == "0" || txtStock.Text == "")
            {
                TextBox1.Visible = true;
                valido = false;
            }
            else
            {
                TextBox1.Visible = false;
            }
            if (txtStockCritico.Text == null || txtStockCritico.Text == "0" || txtStockCritico.Text == "")
            {
                TextBox0.Visible = true;
                valido = false;
            }
            else
            {
                TextBox0.Visible = false;
            }
            return valido;
        }
        private Boolean validarTexbox2()
        {
            Boolean valido = true;
            if (txtProveedorModificar.Text == "Seleccione una opción")
            {
                TextBox5.Visible = true;
                valido = false;
            }
            else
            {
                TextBox5.Visible = false;
            }
            //if (txtProductoModificar.Text == null || txtDetProdAgregar.Text == "")
            //{
            //    TextBox6.Visible = true;
            //    valido = false;
            //}
            //else
            //{
            //    TextBox6.Visible = false;
            //}
            if (txtPrecioModificar.Text == null || txtPrecioModificar.Text == "" || txtPrecioModificar.Text == "0" 
                || int.Parse(txtPrecioModificar.Text)<0)
            {
                TextBox7.Visible = true;
                txtPrecioModificar.Text = "0";
                valido = false;
            }
            else
            {
                TextBox7.Visible = false;
            }
            if (txtStockModificar.Text == null || txtStockModificar.Text == "0" || txtStockModificar.Text == ""
                || int.Parse(txtStockModificar.Text) < 0)
            {
                TextBox8.Visible = true;
                txtStockModificar.Text = "0";
                valido = false;
            }
            else
            {
                TextBox8.Visible = false;
            }
            if (txtStockCriticoModificar.Text == null || txtStockCriticoModificar.Text == "0" || txtStockCriticoModificar.Text == ""
                 || int.Parse(txtStockCriticoModificar.Text) < 0)
            {
                TextBox9.Visible = true;
                txtStockCriticoModificar.Text = "0";
                valido = false;
            }
            else
            {
                TextBox9.Visible = false;
            }
            return valido;
        }
        protected void btnAgregar_click(object sender, EventArgs e)
        {
            if (validarTexbox1())
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                ContenedorProducto nProducto = new ContenedorProducto();

                nProducto.Item.Descripcion = txtDetProdAgregar.Text;
                nProducto.Item.Stock = decimal.Parse(txtStock.Text);
                nProducto.Item.StockCritico = decimal.Parse(txtStockCritico.Text);
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
                        //txtCodProdAgregar.Text = nProducto.Item.Codigo.ToString();
                        RescatarRelacionProvProd();
                    }
                    else
                    {
                        //txtCodProdAgregar.Text = "-2";
                        //nProvision.Retorno.Codigo.ToString();
                        //nProvision.Retorno.Glosa;
                    }
                }
                else {
                    //txtCodProdAgregar.Text = "-1";
                    //nProducto.Retorno.Codigo.ToString();
                    //nProducto.Retorno.Glosa;
                }
            }
            
        }

        protected void txtProveedorModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            RescatarRelacionProvProd();
        }

        private void RescatarRelacionProvProd()
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
                             where prvi.RutProveedor == txtProveedorModificar.SelectedValue
                             orderby prod.Descripcion
                             select new
                             {
                                 Codigo = prod.Codigo,
                                 Descripcion = prod.Descripcion
                             }
                            ).ToList();

            if (productos != null)
            {
                txtProductoModificar.DataSource = null;
                txtProductoModificar.DataSource = productos;
                txtProductoModificar.DataValueField = "Codigo";
                txtProductoModificar.DataTextField = "Descripcion";
                txtProductoModificar.DataBind();

                btnModificar.Enabled = true;
            }
            else {
                btnModificar.Enabled = false;
            }
        }

        protected void btnModificar_click(object sender, EventArgs e)
        {
            if (validarTexbox2())
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                ContenedorProducto nProducto = new ContenedorProducto();

                nProducto.Item.Codigo = decimal.Parse(txtProductoModificar.SelectedValue);
                nProducto.Item.Descripcion = txtProductoModificar.SelectedItem.Text;
                nProducto.Item.Stock = decimal.Parse(txtStockModificar.Text.Trim());
                nProducto.Item.StockCritico = decimal.Parse(txtStockCriticoModificar.Text.Trim());
                nProducto.Retorno.Token = Session["TokenUsuario"].ToString();

                nProducto = x.ProductoActualizar(nProducto);

                if (nProducto.Retorno.Codigo.ToString() == "0")
                {
                    ContenedorProvision nProvision = new ContenedorProvision();

                    nProvision.Item.RutProveedor = txtProveedorModificar.SelectedValue;
                    nProvision.Item.CodigoProducto = int.Parse(txtProductoModificar.SelectedValue.ToString());
                    nProvision.Item.Precio = decimal.Parse(txtPrecioModificar.Text);

                    nProvision.Retorno.Token = Session["TokenUsuario"].ToString();

                    nProvision = x.ProvisionActualizar(nProvision);
                    if (nProvision.Retorno.Codigo.ToString() == "0")
                    {
                        txtPrecioModificar.Text = "0";
                        txtStockModificar.Text = "0";
                        txtStockCriticoModificar.Text = "0";
                    }
                    else
                    {
                        txtPrecioModificar.Text = "-1";
                        //nProvision.Retorno.Codigo.ToString();
                        //nProvision.Retorno.Glosa;
                    }
                }
                else
                {
                    txtPrecioModificar.Text = "-1";
                    //nProducto.Retorno.Codigo.ToString();
                    //nProducto.Retorno.Glosa;
                }
            }
        }
    }
}