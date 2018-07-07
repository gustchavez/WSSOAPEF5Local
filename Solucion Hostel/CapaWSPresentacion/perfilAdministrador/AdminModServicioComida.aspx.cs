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
        
        protected void ddlTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ServicioComida> m = (List<ServicioComida>)Session["ServiciosComida"];
            txtPrecio.Text = m.Where(p => p.Tipo == ddlTipoServicio.SelectedValue).SingleOrDefault().Precio.ToString(); 
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
    }
}
