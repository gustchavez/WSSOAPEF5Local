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
            ////
            ContenedorPerfilUsuarioClientes m = new ContenedorPerfilUsuarioClientes();
            m = x.PerfilUsuarioClienteRescatar(Session["TokenUsuario"].ToString());

            var clie = (from l in m.Lista
                            //where l.OCRelacionada.RutCliente == datSes.RutEmpresa
                        select new
                        {
                            Rut = l.Cliente.Rut,
                            RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                        }
                        ).ToList();

            if (clie != null) { 
                ddlEmpresas.DataSource = clie;
                ddlEmpresas.DataValueField = "Rut";
                ddlEmpresas.DataTextField = "RazonSocial";
                ddlEmpresas.Enabled = true;
                ddlEmpresas.DataBind();
                ////
                RescatarOrdenesXEmpresa(x);
                ////
            } else {
                ddlEmpresas.DataSource = null;
                ddlEmpresas.Items.Add(new ListItem("No Existe", ""));
                ddlEmpresas.Enabled = false;
                ddlEmpresas.DataBind();
                ////
                ddlOrdenesCompra.DataSource = null;
                ddlOrdenesCompra.Items.Add(new ListItem("No Existe", ""));
                ddlOrdenesCompra.Enabled = false;
                ddlOrdenesCompra.DataBind();
            }
            LlenarGrid();
        }

        private void RescatarOrdenesXEmpresa(WSSoap.WSSHostelClient x)
        {
            ContenedorOrdenesCompraCompleta n = new ContenedorOrdenesCompraCompleta();

            n = x.OrdenCompraCompletaRescatar(Session["TokenUsuario"].ToString());
            List<OrdenCompraCompleta> OrdenesCompra = n.Lista.Where(p => p.Cabecera.Estado == "activo").ToList();

            var occ = (from l in OrdenesCompra
                       where l.Cabecera.RutCliente == ddlEmpresas.SelectedValue
                          //&& l.Cabecera.Estado == "activo"
                       select new
                       {
                           Numero = l.Cabecera.Numero
                       }
                       ).ToList();            

            Session["ListaOrdenesCompraCompleta"] = OrdenesCompra;

            if(occ != null)
            {
                ddlOrdenesCompra.DataSource = occ;
                ddlOrdenesCompra.DataValueField = "Numero";
                ddlOrdenesCompra.DataTextField = "Numero";
                ddlOrdenesCompra.Enabled = true;
                ddlOrdenesCompra.DataBind();
            } else {
                ddlOrdenesCompra.DataSource = null;
                ddlOrdenesCompra.Items.Add(new ListItem("No Existe", ""));
                ddlOrdenesCompra.Enabled = false;
                ddlOrdenesCompra.DataBind();
            }
            
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow item in gwListaRecepcion.Rows)
            {
                if (item.Cells[0].Text != item.Cells[3].Text)
                {
                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                    ContenedorAlojamiento m = new ContenedorAlojamiento();

                    m.Item.NumerOrdenCompra = decimal.Parse(item.Cells[1].Text);
                    m.Item.RutPersona = item.Cells[2].Text;
                    m.Item.Confirmado = item.Cells[0].Text == "1" ? "Si" : "No";

                    //m.Retorno.Token = Session["TokenUsuario"].ToString();

                    //m = x.AlojConfirHueActualizar(m);
                }
            }
        //    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

        //    ContenedorAlojamiento m = new ContenedorAlojamiento();

        //    m.Item.NumerOrdenCompra = decimal.Parse(ddlOrdenesCompra.SelectedValue);
        //    m.Item.RutPersona = ddlRutsHuesped.SelectedValue;
        //    m.Item.Confirmado = ddlEstado.SelectedValue;

        //    m.Retorno.Token = Session["TokenUsuario"].ToString();

        //    m = x.AlojConfirHueActualizar(m);

        //    RescatarDatos();
        }

        protected void ddlOrdenesCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void LlenarGrid()
        {            
            if (ddlOrdenesCompra.SelectedValue != null && ddlOrdenesCompra.SelectedValue != string.Empty)
            {
                var collection = (List<OrdenCompraCompleta>)Session["ListaOrdenesCompraCompleta"];
                /////////////////
                var ocd = (from l in collection
                           where l.Cabecera.Numero == decimal.Parse(ddlOrdenesCompra.SelectedValue)
                           select new
                           {
                               ListaDetalle = l.ListaDetalle.ToList()
                           }
                           ).SingleOrDefault();
                /////////////////
                var huespedes = (from m in ocd.ListaDetalle
                           select new
                           {
                               NroOrden = m.Alojamiento.NumerOrdenCompra,
                               Rut = m.Alojamiento.RutPersona,
                               //Estado = m.Alojamiento.Confirmado,
                               EstadoBool = m.Alojamiento.Confirmado == "Si" ? true : false
                           }
                           ).ToList();
                /////////////////
                gwListaRecepcion.DataSource = null;
                gwListaRecepcion.DataSource = huespedes;
                gwListaRecepcion.DataBind();
                /////////////////
            }
            else
            {
                gwListaRecepcion.DataSource = null;
                gwListaRecepcion.DataBind();
            }
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            RescatarOrdenesXEmpresa(x);

            LlenarGrid();
        }
    }
}