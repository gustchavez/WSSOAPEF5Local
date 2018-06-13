using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class recepcion : System.Web.UI.Page
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

            ContenedorOrdenesCompraCompleta m = new ContenedorOrdenesCompraCompleta();

            m = x.OrdenCompraCompletaRescatar(Session["TokenUsuario"].ToString());
            
            var occ = (from l in m.Lista
                           //where l.Cabecera.RutCliente == ddlEmpresas.SelectedValue
                           //  &&
                       where l.Cabecera.Estado == "activo"
                       select new
                       {
                           Numero = l.Cabecera.Numero
                       }
                       ).ToList();

            Session["ListaOrdenesCompraCompleta"] = m.Lista.Where(p => p.Cabecera.Estado == "activo").ToList();

            ddlOrdenesCompra.DataSource = occ;
            ddlOrdenesCompra.DataValueField = "Numero";
            ddlOrdenesCompra.DataTextField = "Numero";
            ddlOrdenesCompra.DataBind();

            LlenarRuts(m.Lista.Where(p => p.Cabecera.Estado == "activo").ToList());
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorAlojamiento m = new ContenedorAlojamiento();

            m.Item.NumerOrdenCompra = decimal.Parse(ddlOrdenesCompra.SelectedValue);
            m.Item.RutPersona = ddlRutsHuesped.SelectedValue;
            m.Item.Confirmado = ddlEstado.SelectedValue;

            m.Retorno.Token = Session["TokenUsuario"].ToString();

            m = x.AlojConfirHueActualizar(m);

            RescatarDatos();
        }

        protected void ddlOrdenesCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var collection = (List<OrdenCompraCompleta>)Session["ListaOrdenesCompraCompleta"];
            LlenarRuts(collection);
        }

        private void LlenarRuts(List<OrdenCompraCompleta> collection)
        {
            if (collection != null)
            {
                var ocd = (from l in collection
                           where l.Cabecera.Numero == decimal.Parse(ddlOrdenesCompra.SelectedValue)
                           select new
                           {
                               ListaDetalle = l.ListaDetalle.ToList()
                           }
                           ).SingleOrDefault();

                var per = (from m in ocd.ListaDetalle
                           select new
                           {
                               Rut = m.Alojamiento.RutPersona,
                               Estado = m.Alojamiento.Confirmado
                           }
                           ).ToList();

                ddlRutsHuesped.DataSource = per;
                ddlRutsHuesped.DataValueField = "Rut";
                ddlRutsHuesped.DataTextField = "Rut";
                ddlRutsHuesped.DataBind();
            }
        }
    }
}