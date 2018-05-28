using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion
{
    public partial class np_proveedor_producto_crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado"))
                {
                    if (!IsPostBack)
                    {
                        CargarGridView();
                    }
                } else {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("np_ingreso.aspx");
                    }
                }
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("np_ingreso.aspx");
            }
        }

        private void CargarGridView()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProvisiones n = new ContenedorProvisiones();

            n = x.ProvisionRescatar(Session["TokenUsuario"].ToString());

            gwListaProvProds.DataSource = null;
            gwListaProvProds.DataSource = n.Lista;
            gwListaProvProds.DataBind();

            //Se vuelca en una lista las Productos
            ContenedorProductos Productos = new ContenedorProductos();
            Productos = x.ProductoRescatar(Session["TokenUsuario"].ToString());
            ddlProducto.DataSource = Productos.Lista;
            ddlProducto.DataValueField = "Codigo";
            ddlProducto.DataTextField = "Descripcion";
            ddlProducto.DataBind();

            //Se vuelca en una lista las Proveedores
            ContenedorProveedores Proveedores = new ContenedorProveedores();
            Proveedores = x.ProveedorRescatar(Session["TokenUsuario"].ToString());
            ddlProveedor.DataSource = Proveedores.Lista;
            ddlProveedor.DataValueField = "Rut";
            ddlProveedor.DataTextField  = "Rut";
            ddlProveedor.DataBind();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProvision nProvision = new ContenedorProvision();

            nProvision.Item.RutProveedor   = ddlProveedor.SelectedValue;
            nProvision.Item.CodigoProducto = int.Parse(ddlProducto.SelectedValue);
            nProvision.Item.Precio         = decimal.Parse(txtPrecio.Text);
            nProvision.Retorno.Token = Session["TokenUsuario"].ToString();

            nProvision = x.ProvisionCrear(nProvision);

            txtCodigoRetorno.Text = nProvision.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = nProvision.Retorno.Glosa;

            CargarGridView();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProvision aProvision = new ContenedorProvision();

            aProvision.Item.RutProveedor   = ddlProveedor.SelectedValue;
            aProvision.Item.CodigoProducto = int.Parse(ddlProducto.SelectedValue);
            aProvision.Item.Precio         = decimal.Parse(txtPrecio.Text);
            aProvision.Retorno.Token = Session["TokenUsuario"].ToString();

            aProvision = x.ProvisionActualizar(aProvision);

            txtCodigoRetorno.Text = aProvision.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = aProvision.Retorno.Glosa;

            CargarGridView();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorProvision eProvision = new ContenedorProvision();

            eProvision.Item.RutProveedor   = ddlProveedor.SelectedValue;
            eProvision.Item.CodigoProducto = int.Parse(ddlProducto.SelectedValue);

            eProvision = x.ProvisionEliminar(eProvision);

            txtCodigoRetorno.Text = eProvision.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = eProvision.Retorno.Glosa;

            CargarGridView();
        }

    }
}