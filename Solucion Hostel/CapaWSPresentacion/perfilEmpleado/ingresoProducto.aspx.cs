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

            txtProductoModificar2.DataSource = m.Lista;
            txtProductoModificar2.DataValueField = "Codigo";
            txtProductoModificar2.DataTextField = "Descripcion";
            txtProductoModificar2.DataBind();


        }

    }
}