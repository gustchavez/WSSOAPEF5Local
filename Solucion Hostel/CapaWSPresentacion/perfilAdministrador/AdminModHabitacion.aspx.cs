using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminModHabitacion : System.Web.UI.Page
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
                txtPrecio.Text = m.Lista.Where(p => p.Capacidad == int.Parse(ddlTipoHabitacion.SelectedValue)).SingleOrDefault().Precio.ToString();
                ////
            }
            else {
                LimpiarControles();
            }
            Session["Habitaciones"] = m.Lista;
        }

        private void LimpiarControles()
        {
            ddlTipoHabitacion.Items.Clear();
            ddlTipoHabitacion.Items.Add(new ListItem("No Existe", ""));
            ddlTipoHabitacion.DataBind();
            ddlTipoHabitacion.SelectedIndex = 0;
            //////////////
            ddlTipoHabitacion.Enabled = false;

            txtPrecio.Text = string.Empty;
        }

        protected void ddlTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Habitacion> m = (List<Habitacion>)Session["Habitaciones"];
            txtPrecio.Text = m.Where(p => p.Capacidad == int.Parse(ddlTipoHabitacion.SelectedValue)).SingleOrDefault().Precio.ToString();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorHabitacion xH = new ContenedorHabitacion();
            xH.Item.Capacidad = int.Parse(ddlTipoHabitacion.SelectedValue);
            xH.Item.Precio = int.Parse(txtPrecio.Text);
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
