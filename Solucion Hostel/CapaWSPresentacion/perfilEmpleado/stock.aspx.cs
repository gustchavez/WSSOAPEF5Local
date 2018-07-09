using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado") || Perfil.Equals("Administrador"))
                {
                    RescatarDatos();
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

            ContenedorProductos n = new ContenedorProductos();

            n = x.ProductoRescatar(Session["TokenUsuario"].ToString());

            var coleccion = (from l in n.Lista
                             select new
                             {
                                 Codigo = l.Codigo,
                                 Decripcion = l.Descripcion,
                                 Stock = l.Stock,
                                 StockCritico = l.StockCritico,
                                 Critico = (l.Stock - l.StockCritico)  >= 0 ? "No" : "Si"
                             }
                            ).ToList();

            gwListaProductos.DataSource = null;
            gwListaProductos.DataSource = coleccion;
            gwListaProductos.DataBind();
        }

        protected void gwListaProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string critico = e.Row.Cells[4].Text;
                
                if (critico == "Si")
                {
                    e.Row.Font.Bold = true;
                    e.Row.CssClass = "EstiloCritico";
                }

            }
        }
    }
}