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
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            if (Session["TokenUsuario"] != null &&
                (x.ValidarToken(Session["TokenUsuario"].ToString(), "Empleado") ||
                x.ValidarToken(Session["TokenUsuario"].ToString(), "Administrador")))
            {
                CrearFormularioDetalle();

            }
            else
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("ingreso_cliente.aspx");
            }
        }

        private void CrearFormularioDetalle()
        {
            int CantidadProductos = 3;
            Session["CantidadProductos"] = CantidadProductos;

            EscribirHeadDetalle();

            //Se instacion el WS para recuperar los datos de Productos y Platos
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            //Se vuelca en una lista las Productos
            ContenedorProductos Productos = new ContenedorProductos();
            Productos = x.ProductoRescatar();

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

        private void EscribirBodyDetalle(int CantidadHuespedes, ContenedorProductos Productos)
        {
            //Escribir Registro de la parte Detalle
            for (int i = 0; i < CantidadHuespedes; i++)
            {
                Literal item0Antes = new Literal();
                item0Antes.Text = "<tr><td>";
                form1.Controls.Add(item0Antes);

                TextBox item1 = new TextBox();
                item1.ID = "txtProductoFecRecepcion" + i;
                item1.TextMode = TextBoxMode.Date;
                form1.Controls.Add(item1);
                //
                Literal item3Antes = new Literal();
                item3Antes.Text = "</td><td>";
                form1.Controls.Add(item3Antes);

                DropDownList item3 = new DropDownList();
                item3.ID = "ddlProductoCodProd" + i;
                item3.DataSource = Productos.Lista;
                item3.DataValueField = "Codigo";
                item3.DataTextField = "Descripcion";
                item3.DataBind();
                form1.Controls.Add(item3);
                //
                Literal item6Despues = new Literal();
                item6Despues.Text = "</td></tr>";
                form1.Controls.Add(item6Despues);
            }

            Literal BodyDespues = new Literal();
            BodyDespues.Text = "</table>";
            form1.Controls.Add(BodyDespues);
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
                
                TextBox item1 = (TextBox)form1.FindControl("txtProductoFecRecepcion" + i);
                nOPD.RegistroRecepcionPedido.Recepcion = DateTime.Parse(item1.Text);
                
                DropDownList item3 = (DropDownList)form1.FindControl("ddlProductoCodProd" + i);
                nOPD.RegistroRecepcionPedido.CodigoProducto = decimal.Parse(item3.SelectedValue);

                nOPC.ListaDetalle.Add(nOPD);
            }

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorOrdenPedidoCompleta xOPC = new ContenedorOrdenPedidoCompleta();
            xOPC.Item.Cabecera = nOPC.Cabecera;
            xOPC.Item.ListaDetalle = nOPC.ListaDetalle;

            xOPC = x.OrdenPedidoCompletaCrear(xOPC);
            
            txtCodigoRetorno.Text = xOPC.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = xOPC.Retorno.Glosa;

        }
    }
}