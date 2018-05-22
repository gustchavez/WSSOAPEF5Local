using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class np_plato_crud : System.Web.UI.Page
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
                        WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                        ContenedorServiciosComida m = new ContenedorServiciosComida();

                        m = x.ServicioComidaRescatar(Session["TokenUsuario"].ToString());

                        ddlServicioTipo.DataSource = m.Lista;
                        ddlServicioTipo.DataValueField = "Tipo";
                        ddlServicioTipo.DataTextField = "Tipo";
                        ddlServicioTipo.DataBind();

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
            //
            ContenedorPlatos n = new ContenedorPlatos();

            n = x.PlatoRescatar(Session["TokenUsuario"].ToString());

            gwListaPlatos.DataSource = null;
            gwListaPlatos.DataSource = n.Lista;
            gwListaPlatos.DataBind();

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPlato nPlato = new ContenedorPlato();

            nPlato.Item.Nombre = txtNombre.Text;
            nPlato.Item.Descripcion = txtDescripcion.Text;
            nPlato.Item.Disponible = ddlDisponible.SelectedValue;
            nPlato.Item.TipoServicio = ddlServicioTipo.SelectedValue;
            nPlato.Retorno.Token = Session["TokenUsuario"].ToString();

            nPlato = x.PlatoCrear(nPlato);

            txtCodigo.Text = nPlato.Item.Codigo.ToString();
            txtCodigoRetorno.Text = nPlato.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = nPlato.Retorno.Glosa;

            CargarGridView();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPlato aPlato = new ContenedorPlato();

            aPlato.Item.Codigo = decimal.Parse(txtCodigo.Text);
            aPlato.Item.Nombre = txtNombre.Text;
            aPlato.Item.Descripcion = txtDescripcion.Text;
            aPlato.Item.Disponible = ddlDisponible.SelectedValue;
            aPlato.Item.TipoServicio = ddlServicioTipo.SelectedValue;
            aPlato.Retorno.Token = Session["TokenUsuario"].ToString();

            aPlato = x.PlatoActualizar(aPlato);

            txtCodigoRetorno.Text = aPlato.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = aPlato.Retorno.Glosa;

            CargarGridView();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPlato ePlato = new ContenedorPlato();

            ePlato.Item.Codigo = decimal.Parse(txtCodigo.Text);
            ePlato.Retorno.Token = Session["TokenUsuario"].ToString();

            ePlato = x.PlatoEliminar(ePlato);

            txtCodigoRetorno.Text = ePlato.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = ePlato.Retorno.Glosa;

            CargarGridView();

        }
    }
}