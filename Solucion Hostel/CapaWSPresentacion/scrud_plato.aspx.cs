using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion
{
    public partial class scrud_plato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
                //
                ContenedorServiciosComida m = new ContenedorServiciosComida();

                m = x.ServicioComidaRescatar();

                ddlServicioTipo.DataSource = m.Lista;
                ddlServicioTipo.DataValueField = "Tipo";
                ddlServicioTipo.DataTextField = "Tipo";
                ddlServicioTipo.DataBind();

                CargarGridView();
            }            
        }
        private void CargarGridView()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            //
            ContenedorPlatos n = new ContenedorPlatos();

            n = x.PlatoRescatar();

            gwListaPlatos.DataSource = null;
            gwListaPlatos.DataSource = n.Lista;
            gwListaPlatos.DataBind();
            
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPlato nPlato = new ContenedorPlato();

            nPlato.Item.Nombre       = txtNombre.Text;
            nPlato.Item.Descripcion  = txtDescripcion.Text;
            nPlato.Item.Disponible   = ddlDisponible.SelectedValue;
            nPlato.Item.TipoServicio = ddlServicioTipo.SelectedValue;

            nPlato = x.PlatoCrear(nPlato);

            txtCodigo.Text        = nPlato.Item.Codigo.ToString();
            txtCodigoRetorno.Text = nPlato.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = nPlato.Retorno.Glosa;

            CargarGridView();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPlato aPlato = new ContenedorPlato();

            aPlato.Item.Codigo       = decimal.Parse(txtCodigo.Text);
            aPlato.Item.Nombre       = txtNombre.Text;
            aPlato.Item.Descripcion  = txtDescripcion.Text;
            aPlato.Item.Disponible   = ddlDisponible.SelectedValue;
            aPlato.Item.TipoServicio = ddlServicioTipo.SelectedValue;

            aPlato = x.PlatoActualizar(aPlato);

            txtCodigoRetorno.Text = aPlato.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = aPlato.Retorno.Glosa;

            CargarGridView();

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPlato ePlato = new ContenedorPlato();

            ePlato.Item.Codigo = decimal.Parse(txtCodigo.Text);

            ePlato = x.PlatoEliminar(ePlato);

            txtCodigoRetorno.Text = ePlato.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text  = ePlato.Retorno.Glosa;

            CargarGridView();

        }
    }
}