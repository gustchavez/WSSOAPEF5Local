using CapaObjeto;
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
        }

        protected void txtProveedor_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {

        }
    }
}