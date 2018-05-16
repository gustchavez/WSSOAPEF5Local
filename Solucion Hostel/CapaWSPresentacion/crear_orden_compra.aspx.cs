using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion
{
    public partial class crear_orden_compra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrearFormularioDetalle();
        }

        private void CrearFormularioDetalle()
        {
            int CantidadHuespedes = 3;
            Session["CantidadHuespedes"] = CantidadHuespedes;

            EscribirHeadDetalle();

            //Se instacion el WS para recuperar los datos de Camas y Platos
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            //Se vuelca en una lista las camas
            ContenedorCamas Camas = new ContenedorCamas();
            Camas = x.CamaRescatar();
            //Se vuelca en una lista las Plato
            ContenedorPlatos Platos = new ContenedorPlatos();
            Platos = x.PlatoRescatar();

            EscribirBodyDetalle(CantidadHuespedes, Camas, Platos);
        }

        private void EscribirHeadDetalle()
        {
            //Lista para escribir Head de detall
            List<string> lHeadDetalle = new List<string>();
            lHeadDetalle.Add("Fecha Ingreso");
            lHeadDetalle.Add("Fecha Egreso");
            lHeadDetalle.Add("Codigo Cama");
            lHeadDetalle.Add("Observaciones Cama");
            lHeadDetalle.Add("Codigo Plato");
            lHeadDetalle.Add("Observaciones Plato");

            Literal HeadAntes = new Literal();
            HeadAntes.Text = "<table id = 'tablaDetalle' style = 'width: 75%;'><tr>";
            form1.Controls.Add(HeadAntes);

            //Escribir Head de la parte Detalle
            foreach (var item in lHeadDetalle)
            {
                Literal HeadDuranteA = new Literal();
                HeadDuranteA.Text = "<th>";
                form1.Controls.Add(HeadDuranteA);

                Literal HeadDetalle = new Literal();
                HeadDetalle.Text = item;
                form1.Controls.Add(HeadDetalle);

                Literal HeadDuranteD = new Literal();
                HeadDuranteD.Text = "</th>";
                form1.Controls.Add(HeadDuranteD);
            }

            Literal HeadDespues = new Literal();
            HeadDespues.Text = "</tr>";
            form1.Controls.Add(HeadDespues);
        }

        private void EscribirBodyDetalle(int CantidadHuespedes, ContenedorCamas Camas, ContenedorPlatos Platos)
        {
            //Escribir Registro de la parte Detalle
            for (int i = 0; i < CantidadHuespedes; i++)
            {
                Literal item0Antes = new Literal();
                item0Antes.Text = "<tr><td>";
                form1.Controls.Add(item0Antes);

                TextBox item0 = new TextBox();
                item0.ID = "txtAlojaIngreso" + i;
                item0.TextMode = TextBoxMode.Date;
                form1.Controls.Add(item0);
                //
                Literal item1Antes = new Literal();
                item1Antes.Text = "</td><td>";
                form1.Controls.Add(item1Antes);

                TextBox item1 = new TextBox();
                item1.ID = "txtAlojaEgreso" + i;
                item1.TextMode = TextBoxMode.Date;
                form1.Controls.Add(item1);
                //
                Literal item2Antes = new Literal();
                item2Antes.Text = "</td><td>";
                form1.Controls.Add(item2Antes);

                DropDownList item2 = new DropDownList();
                item2.ID = "ddlAlojaCodCama" + i;
                item2.DataSource = Camas.Lista;
                item2.DataValueField = "Codigo";
                item2.DataTextField = "Descripcion";
                item2.DataBind();
                form1.Controls.Add(item2);
                //
                Literal item3Antes = new Literal();
                item3Antes.Text = "</td><td>";
                form1.Controls.Add(item3Antes);

                TextBox item3 = new TextBox();
                item3.ID = "txtAlojaObservaciones" + i;
                form1.Controls.Add(item3);
                //
                Literal item4Antes = new Literal();
                item4Antes.Text = "</td><td>";
                form1.Controls.Add(item4Antes);

                DropDownList item4 = new DropDownList();
                item4.ID = "ddlComidaCodPlato" + i;
                item4.DataSource = Platos.Lista;
                item4.DataValueField = "Codigo";
                item4.DataTextField = "Descripcion";
                item4.DataBind();
                form1.Controls.Add(item4);
                //
                Literal item5Antes = new Literal();
                item5Antes.Text = "</td><td>";
                form1.Controls.Add(item5Antes);

                TextBox item5 = new TextBox();
                item5.ID = "txtComidaObservaciones" + i;
                form1.Controls.Add(item5);
                //
                Literal item5Despues = new Literal();
                item5Despues.Text = "</td></tr>";
                form1.Controls.Add(item5Despues);
            }

            Literal BodyDespues = new Literal();
            BodyDespues.Text = "</table>";
            form1.Controls.Add(BodyDespues);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            OrdenCompraCompleta nOCC = new OrdenCompraCompleta();
            //Armar Encabezado de Orden de Reserva
            nOCC.Cabecera.RutCliente = txtRutCliente.Text;
            nOCC.Cabecera.Monto = 1000;//realizar calculo de las habitaciones seleccionadas.
            nOCC.Cabecera.Observaciones = "Reserva habitación";
            nOCC.Cabecera.Ubicacion = "Nose";
            nOCC.Cabecera.Estado = "activa";

            //
            int CantidadHuespedes = int.Parse(Session["CantidadHuespedes"].ToString());

            for (int i = 0; i < CantidadHuespedes; i++)
            {
                OrdenCompraDetalle nOCD = new OrdenCompraDetalle();
                TextBox item0 = (TextBox)form1.FindControl("txtAlojaIngreso" + i);
                nOCD.Alojamiento.FechaIngreso = DateTime.Parse(item0.Text);

                TextBox item1 = (TextBox)form1.FindControl("txtAlojaEgreso" + i);
                nOCD.Alojamiento.FechaEgreso = DateTime.Parse(item1.Text);

                DropDownList item2 = (DropDownList)form1.FindControl("ddlAlojaCodCama" + i);
                nOCD.Alojamiento.CodigoCama = decimal.Parse(item2.SelectedValue);

                TextBox item3 = (TextBox)form1.FindControl("txtAlojaObservaciones" + i);
                nOCD.Alojamiento.Observaciones = item3.Text;

                DropDownList item4 = (DropDownList)form1.FindControl("ddlComidaCodPlato" + i);
                nOCD.Comida.CodigoPlato = decimal.Parse(item4.SelectedValue);

                TextBox item5 = (TextBox)form1.FindControl("txtComidaObservaciones" + i);
                nOCD.Comida.Observaciones = item5.Text;

                nOCD.Comida.FechaRecepcion = DateTime.Now;

                nOCC.ListaDetalle.Add(nOCD);
            }

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorOrdenCompraCompleta xOCC = new ContenedorOrdenCompraCompleta();
            xOCC.Item.Cabecera = nOCC.Cabecera;
            xOCC.Item.ListaDetalle = nOCC.ListaDetalle;

            xOCC = x.OrdenCompraCompletaCrear(xOCC);
            
            txtCodigoRetorno.Text = xOCC.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = xOCC.Retorno.Glosa;

        }
    }
}