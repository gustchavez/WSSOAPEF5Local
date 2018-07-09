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
                            RazonSocial = l.PerfilUsuario.Empresa.RazonSocial,
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
                //////////////
                ddlEmpresas.DataSource = clie;
                ddlEmpresas.DataBind();
                ddlEmpresas.Items.Add(new ListItem("No Existe", ""));
                ddlEmpresas.SelectedIndex = 0;
                //////////////
                ddlEmpresas.Enabled = false;

                //////////////
                ddlOrdenesCompra.DataSource = clie;
                ddlOrdenesCompra.DataBind();
                ddlOrdenesCompra.Items.Add(new ListItem("No Existe", ""));
                ddlOrdenesCompra.SelectedIndex = 0;
                //////////////
                ddlOrdenesCompra.Enabled = false;
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

            if(occ.Count > 0)
            {
                ddlOrdenesCompra.DataSource = occ;
                ddlOrdenesCompra.DataValueField = "Numero";
                ddlOrdenesCompra.DataTextField = "Numero";
                ddlOrdenesCompra.Enabled = true;
                ddlOrdenesCompra.DataBind();
            } else {
                //////////////
                ddlOrdenesCompra.DataSource = occ;
                ddlOrdenesCompra.DataBind();
                ddlOrdenesCompra.Items.Add(new ListItem("No Existe", ""));
                ddlOrdenesCompra.SelectedIndex = 0;
                //////////////
                ddlOrdenesCompra.Enabled = false;         
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow item in gwListaRecepcion.Rows)
            {
                CheckBox EstadoReserva = (item.Cells[0].Controls[1] as CheckBox);
                //Si se agregan columnas se debe validar posicion
                bool EstadoReservaBBDD = item.Cells[7].Text == "Si" ? true : false; 
                if (EstadoReserva.Checked != EstadoReservaBBDD)
                {
                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                    ContenedorAlojamiento m = new ContenedorAlojamiento();

                    m.Item.NumerOrdenCompra = decimal.Parse(item.Cells[1].Text);
                    m.Item.RutPersona = item.Cells[2].Text;
                    m.Item.Confirmado = EstadoReserva.Checked == true ? "Si" : "No";

                    m.Retorno.Token = Session["TokenUsuario"].ToString();

                    m = x.AlojConfirHueActualizar(m);
                }
            }
            RescatarDatos();
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
                               NroOrden           = m.Alojamiento.NumerOrdenCompra,
                               Rut                = m.Persona.Rut,
                               NombreCompleto     = m.Persona.Apellido + ' ' + m.Persona.Nombre,
                               NroHabitacion      = m.Alojamiento.Habitacion.Codigo,
                               TipoHabitacion     = m.Alojamiento.Habitacion.Capacidad,
                               TipoServicioComida = m.Comida.ServicioComida.Tipo,
                               Estado             = m.Alojamiento.Confirmado,
                               EstadoBool         = m.Alojamiento.Confirmado == "Si" ? true : false
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