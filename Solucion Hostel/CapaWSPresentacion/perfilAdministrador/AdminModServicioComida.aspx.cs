using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminModServicioComida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Administrador"))
                {
                    if (!IsPostBack)
                    {
                        RescatarDatos();
                        RescatarDatos2();
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
            
            ContenedorServiciosComida m = new ContenedorServiciosComida();
            m = x.ServicioComidaRescatar(Session["TokenUsuario"].ToString());
            
            if (m.Lista != null)
            {
                ddlTipoServicio.DataSource = m.Lista;
                ddlTipoServicio.DataValueField = "Tipo";
                ddlTipoServicio.DataTextField  = "Tipo";
                ddlTipoServicio.DataBind();
                ddlTipoServicio.Enabled = true;
                ////
                txtPrecio.Text = m.Lista.Where(p => p.Tipo == ddlTipoServicio.SelectedValue).SingleOrDefault().Precio.ToString();
                ////
            } else {
                LimpiarControles();
            } 
            Session["ServiciosComida"] = m.Lista;
        }


        private void RescatarDatos2()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorHabitaciones m = new ContenedorHabitaciones();
            m = x.HabitacionResPrecioXCapacidad(Session["TokenUsuario"].ToString());

            if (m.Lista != null)
            {
                ddlTipoHabitacion.DataSource = m.Lista.OrderBy(p => p.Capacidad);
                ddlTipoHabitacion.DataValueField = "Capacidad";
                ddlTipoHabitacion.DataTextField = "Capacidad";
                ddlTipoHabitacion.DataBind();
                ddlTipoHabitacion.Enabled = true;
                ////
                txtPrecio2.Text = m.Lista.Where(p => p.Capacidad == int.Parse(ddlTipoHabitacion.SelectedValue)).SingleOrDefault().Precio.ToString();
                ////
            }
            else {
                LimpiarControles2();
            }
            Session["Habitaciones"] = m.Lista;
        }

        private void LimpiarControles()
        {
            ddlTipoServicio.Items.Clear();
            ddlTipoServicio.Items.Add(new ListItem("No Existe", ""));
            ddlTipoServicio.DataBind();
            ddlTipoServicio.SelectedIndex = 0;
            //////////////
            ddlTipoServicio.Enabled = false;

            txtPrecio.Text = string.Empty;
        }

        private void LimpiarControles2()
        {
            ddlTipoHabitacion.Items.Clear();
            ddlTipoHabitacion.Items.Add(new ListItem("No Existe", ""));
            ddlTipoHabitacion.DataBind();
            ddlTipoHabitacion.SelectedIndex = 0;
            //////////////
            ddlTipoHabitacion.Enabled = false;

            txtPrecio2.Text = string.Empty;
        }

        protected void ddlTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ServicioComida> m = (List<ServicioComida>)Session["ServiciosComida"];
            txtPrecio.Text = m.Where(p => p.Tipo == ddlTipoServicio.SelectedValue).SingleOrDefault().Precio.ToString(); 
        }

        protected void ddlTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Habitacion> m = (List<Habitacion>)Session["Habitaciones"];
            txtPrecio2.Text = m.Where(p => p.Capacidad == int.Parse(ddlTipoHabitacion.SelectedValue)).SingleOrDefault().Precio.ToString();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorServicioComida xSC = new ContenedorServicioComida();
            xSC.Item.Tipo = ddlTipoServicio.SelectedValue;
            xSC.Item.Precio = int.Parse(txtPrecio.Text);
            //
            xSC.Retorno.Token = Session["TokenUsuario"].ToString();

            xSC = x.ServicioComidaActualizar(xSC);

            if (xSC.Retorno.Codigo == 0)
            {
                RescatarDatos();
            }
        }

        protected void btnModificar2_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorHabitacion xH = new ContenedorHabitacion();
            xH.Item.Capacidad = int.Parse(ddlTipoHabitacion.SelectedValue);
            xH.Item.Precio = int.Parse(txtPrecio2.Text);
            //
            xH.Retorno.Token = Session["TokenUsuario"].ToString();

            xH = x.HabitacionActPrecioXCapacidad(xH);

            if (xH.Retorno.Codigo == 0)
            {
                RescatarDatos();
            }

        }

  
    }
}
