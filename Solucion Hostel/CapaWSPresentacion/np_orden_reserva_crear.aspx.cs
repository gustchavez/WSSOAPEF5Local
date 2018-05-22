using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class np_orden_reserva_crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();
                if (Perfil.Equals("Cliente") || Perfil.Equals("Administrador"))
                {
                    CrearFormularioDetalle();
                }
                else
                {
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

        private void CrearFormularioDetalle()
        {
            int CantidadHuespedes = 3;
            Session["CantidadHuespedes"] = CantidadHuespedes;

            EscribirHeadDetalle();

            //Se instacion el WS para recuperar los datos de Camas y Platos
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            //Se vuelca en una lista las camas
            ContenedorCamas Camas = new ContenedorCamas();
            Camas = x.CamaRescatar(Session["TokenUsuario"].ToString());
            //Se vuelca en una lista las Plato
            ContenedorPlatos Platos = new ContenedorPlatos();
            Platos = x.PlatoRescatar(Session["TokenUsuario"].ToString());

            EscribirBodyDetalle(CantidadHuespedes, Camas, Platos);
        }

        private void EscribirHeadDetalle()
        {
            //Lista para escribir Head de detall
            List<string> lHeadDetalle = new List<string>();
            lHeadDetalle.Add("Rut Persona");
            lHeadDetalle.Add("Fecha Ingreso");
            lHeadDetalle.Add("Fecha Egreso");
            lHeadDetalle.Add("Codigo Cama");
            lHeadDetalle.Add("Observaciones Cama");
            lHeadDetalle.Add("Codigo Plato");
            lHeadDetalle.Add("Observaciones Plato");

            Literal HeadAntes = new Literal();
            HeadAntes.Text = "<table id = 'tablaDetalle' style = 'width: 75%;'><tr>";
            PlaceHolder1.Controls.Add(HeadAntes);

            //Escribir Head de la parte Detalle
            foreach (var item in lHeadDetalle)
            {
                Literal HeadDuranteA = new Literal();
                HeadDuranteA.Text = "<th>";
                PlaceHolder1.Controls.Add(HeadDuranteA);

                Literal HeadDetalle = new Literal();
                HeadDetalle.Text = item;
                PlaceHolder1.Controls.Add(HeadDetalle);

                Literal HeadDuranteD = new Literal();
                HeadDuranteD.Text = "</th>";
                PlaceHolder1.Controls.Add(HeadDuranteD);
            }

            Literal HeadDespues = new Literal();
            HeadDespues.Text = "</tr>";
            PlaceHolder1.Controls.Add(HeadDespues);
        }

        private void EscribirBodyDetalle(int CantidadHuespedes, ContenedorCamas Camas, ContenedorPlatos Platos)
        {
            //Escribir Registro de la parte Detalle
            for (int i = 0; i < CantidadHuespedes; i++)
            {
                Literal item0Antes = new Literal();
                item0Antes.Text = "<tr><td>";
                PlaceHolder1.Controls.Add(item0Antes);

                TextBox item0 = new TextBox();
                item0.ID = "txtRutPersona" + i;
                PlaceHolder1.Controls.Add(item0);
                //
                Literal item1Antes = new Literal();
                item1Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item1Antes);

                TextBox item1 = new TextBox();
                item1.ID = "txtAlojaIngreso" + i;
                item1.TextMode = TextBoxMode.Date;
                PlaceHolder1.Controls.Add(item1);
                //
                Literal item2Antes = new Literal();
                item2Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item2Antes);

                TextBox item2 = new TextBox();
                item2.ID = "txtAlojaEgreso" + i;
                item2.TextMode = TextBoxMode.Date;
                PlaceHolder1.Controls.Add(item2);
                //
                Literal item3Antes = new Literal();
                item3Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item3Antes);

                DropDownList item3 = new DropDownList();
                item3.ID = "ddlAlojaCodCama" + i;
                item3.DataSource = Camas.Lista;
                item3.DataValueField = "Codigo";
                item3.DataTextField = "Descripcion";
                item3.DataBind();
                PlaceHolder1.Controls.Add(item3);
                //
                Literal item4Antes = new Literal();
                item4Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item4Antes);

                TextBox item4 = new TextBox();
                item4.ID = "txtAlojaObservaciones" + i;
                PlaceHolder1.Controls.Add(item4);
                //
                Literal item5Antes = new Literal();
                item5Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item5Antes);

                DropDownList item5 = new DropDownList();
                item5.ID = "ddlComidaCodPlato" + i;
                item5.DataSource = Platos.Lista;
                item5.DataValueField = "Codigo";
                item5.DataTextField = "Descripcion";
                item5.DataBind();
                PlaceHolder1.Controls.Add(item5);
                //
                Literal item6Antes = new Literal();
                item6Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item6Antes);

                TextBox item6 = new TextBox();
                item6.ID = "txtComidaObservaciones" + i;
                PlaceHolder1.Controls.Add(item6);
                //
                Literal item6Despues = new Literal();
                item6Despues.Text = "</td></tr>";
                PlaceHolder1.Controls.Add(item6Despues);
            }

            Literal BodyDespues = new Literal();
            BodyDespues.Text = "</table>";
            PlaceHolder1.Controls.Add(BodyDespues);
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

                TextBox item0 = (TextBox)PlaceHolder1.FindControl("txtRutPersona" + i);
                nOCD.Alojamiento.RutPersona = item0.Text;

                TextBox item1 = (TextBox)PlaceHolder1.FindControl("txtAlojaIngreso" + i);
                nOCD.Alojamiento.FechaIngreso = DateTime.Parse(item1.Text);

                TextBox item2 = (TextBox)PlaceHolder1.FindControl("txtAlojaEgreso" + i);
                nOCD.Alojamiento.FechaEgreso = DateTime.Parse(item2.Text);

                DropDownList item3 = (DropDownList)PlaceHolder1.FindControl("ddlAlojaCodCama" + i);
                nOCD.Alojamiento.CodigoCama = decimal.Parse(item3.SelectedValue);

                TextBox item4 = (TextBox)PlaceHolder1.FindControl("txtAlojaObservaciones" + i);
                nOCD.Alojamiento.Observaciones = item4.Text;

                DropDownList item5 = (DropDownList)PlaceHolder1.FindControl("ddlComidaCodPlato" + i);
                nOCD.Comida.CodigoPlato = decimal.Parse(item5.SelectedValue);

                TextBox item6 = (TextBox)PlaceHolder1.FindControl("txtComidaObservaciones" + i);
                nOCD.Comida.Observaciones = item6.Text;

                nOCD.Comida.FechaRecepcion = DateTime.Now;

                nOCC.ListaDetalle.Add(nOCD);
            }

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorOrdenCompraCompleta xOCC = new ContenedorOrdenCompraCompleta();
            xOCC.Item.Cabecera = nOCC.Cabecera;
            xOCC.Item.ListaDetalle = nOCC.ListaDetalle;
            xOCC.Retorno.Token = Session["TokenUsuario"].ToString();

            xOCC = x.OrdenCompraCompletaCrear(xOCC);

            txtCodigoRetorno.Text = xOCC.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = xOCC.Retorno.Glosa;

        }
    }
}