using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class np_orden_compra_crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();
                if (Perfil.Equals("Empleado") || Perfil.Equals("Administrador"))
                {
                    CrearFormularioDetalle();
                }
                else
                {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
                }
            }
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }
        }

        private void CrearFormularioDetalle()
        {
            foreach (var item in Master.Controls)
            {
                item.ToString();
            }
            int CantidadProductos = 3;
            Session["CantidadProductos"] = CantidadProductos;

            EscribirHeadDetalle();

            //Se instacion el WS para recuperar los datos de Productos y Platos
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            //Se vuelca en una lista las Productos
            ContenedorProductos Productos = new ContenedorProductos();
            Productos = x.ProductoRescatar(Session["TokenUsuario"].ToString());

            EscribirBodyDetalle(CantidadProductos, Productos);
        }

        private void EscribirHeadDetalle()
        {
            //Lista para escribir Head de detall
            List<string> lHeadDetalle = new List<string>();
            lHeadDetalle.Add("Rut Persona");
            lHeadDetalle.Add("Fecha Recepcion");
            lHeadDetalle.Add("Codigo Producto");

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

        private void EscribirBodyDetalle(int CantidadHuespedes, ContenedorProductos Productos)
        {
            //Escribir Registro de la parte Detalle
            for (int i = 0; i < CantidadHuespedes; i++)
            {
                Literal item0Antes = new Literal();
                item0Antes.Text = "<tr><td>";
                PlaceHolder1.Controls.Add(item0Antes);

                TextBox item1 = new TextBox();
                item1.ID = "txtProductoFecRecepcion" + i;
                item1.TextMode = TextBoxMode.Date;
                PlaceHolder1.Controls.Add(item1);
                //
                Literal item3Antes = new Literal();
                item3Antes.Text = "</td><td>";
                PlaceHolder1.Controls.Add(item3Antes);

                DropDownList item3 = new DropDownList();
                item3.ID = "ddlProductoCodProd" + i;
                item3.DataSource = Productos.Lista;
                item3.DataValueField = "Codigo";
                item3.DataTextField = "Descripcion";
                item3.DataBind();
                PlaceHolder1.Controls.Add(item3);
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
            OrdenPedidoCompleta nOPC = new OrdenPedidoCompleta();
            //Armar Encabezado de Orden de Reserva
            nOPC.Cabecera.RutProveedor = txtRutProveedor.Text;
            nOPC.Cabecera.Monto = 1000;//realizar calculo de las habitaciones seleccionadas.
            nOPC.Cabecera.Observaciones = "Reserva producto";
            nOPC.Cabecera.Ubicacion = "Nose";
            nOPC.Cabecera.Estado = "activa";

            //
            int CantidadProductos = int.Parse(Session["CantidadProductos"].ToString());

            for (int i = 0; i < CantidadProductos; i++)
            {
                OrdenPedidoDetalle nOPD = new OrdenPedidoDetalle();

                TextBox item1 = (TextBox)PlaceHolder1.FindControl("txtProductoFecRecepcion" + i);
                nOPD.RegistroRecepcionPedido.Recepcion = DateTime.Parse(item1.Text);

                DropDownList item3 = (DropDownList)PlaceHolder1.FindControl("ddlProductoCodProd" + i);
                nOPD.RegistroRecepcionPedido.CodigoProducto = decimal.Parse(item3.SelectedValue);

                nOPC.ListaDetalle.Add(nOPD);
            }

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorOrdenPedidoCompleta xOPC = new ContenedorOrdenPedidoCompleta();
            xOPC.Item.Cabecera = nOPC.Cabecera;
            xOPC.Item.ListaDetalle = nOPC.ListaDetalle;
            xOPC.Retorno.Token = Session["TokenUsuario"].ToString();

            xOPC = x.OrdenPedidoCompletaCrear(xOPC);

            txtCodigoRetorno.Text = xOPC.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = xOPC.Retorno.Glosa;

        }
    }
}