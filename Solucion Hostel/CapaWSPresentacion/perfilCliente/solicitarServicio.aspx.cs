using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace CapaWSPresentacion.perfilCliente
{
    public partial class solicitarServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Cliente") || Perfil.Equals("Administrador"))
                {
                    if (!IsPostBack)
                    {
                       
                        bloqueados();
                        //RescatarDatos();
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

        private void bloqueados()
        {
            txtFechaEgreso.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
            txtFechaIngreso.Text = DateTime.Now.ToString("yyyy-MM-dd");

            MostrarCasillas.Enabled = false;
            BtnSiguiente.Enabled = false;
        }

        protected void Siguiente_Click1(object sender, EventArgs e)
        {

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            OrdenCompraCompleta nOCC = new OrdenCompraCompleta();
            //Armar Encabezado de Orden de Reserva
            nOCC.Cabecera.RutCliente = SesionUsuario.RutEmpresa;
            nOCC.Cabecera.Monto = int.Parse(txtPersonasHabitacion.Text);//realizar calculo de las habitaciones seleccionadas.
            nOCC.Cabecera.Observaciones = "Reserva habitación";
            nOCC.Cabecera.Ubicacion = "logo";
            nOCC.Cabecera.Estado = "activa";

            //int CantidadHuespedes = int.Parse(Session[txtPersonasHabitacion.Text].ToString());
            try
            {                
                int CantIndividual = int.Parse(individual.Text);
                AgregarHuesped(nOCC, CantIndividual, "Individual", 1);
            }
            catch (Exception)
            {
                //No existe se continua siguiente validacion
            }

            try
            {
                int CantIndividual = int.Parse(doble.Text);
                AgregarHuesped(nOCC, CantIndividual, "Doble", 2);
            }
            catch (Exception)
            {
                //No existe se continua siguiente validacion
            }

            try
            {
                int CantIndividual = int.Parse(triple.Text);
                AgregarHuesped(nOCC, CantIndividual, "Tiple", 3);
            }
            catch (Exception)
            {
                //No existe se continua siguiente validacion
            }

            ContenedorOrdenCompraCompleta xOCC = new ContenedorOrdenCompraCompleta();
            xOCC.Item.Cabecera = nOCC.Cabecera;
            xOCC.Item.ListaDetalle = nOCC.ListaDetalle;
            xOCC.Retorno.Token = Session["TokenUsuario"].ToString();

            xOCC = x.OrdenCompraCompletaCrear(xOCC);

        }

        private void AgregarHuesped(OrdenCompraCompleta nOCC, int CantHuesp, string TipoHab, int CapHab)
        {
            for (int i = 1; i < CantHuesp+1; i++)
            {
                OrdenCompraDetalle nOCD = new OrdenCompraDetalle();
                
                TextBox item0 = (TextBox)form1.FindControl("txtRut" + TipoHab + i);
                nOCD.Alojamiento.RutPersona = item0.Text;

                //TextBox item1 = (TextBox)form1.FindControl("txtFecha" + TipoHab + i);
                nOCD.Alojamiento.FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);

                //TextBox item2 = (TextBox)form1.FindControl("txtFecha" + TipoHab + i);
                nOCD.Alojamiento.FechaEgreso = DateTime.Parse(txtFechaEgreso.Text);

                nOCD.Alojamiento.Habitacion.Capacidad = CapHab;

                TextBox item3 = (TextBox)form1.FindControl("txtOtro" + TipoHab + i);
                nOCD.Alojamiento.Observaciones = item3.Text;

                /* //se debe incluir los dropdownlist de tipo de comida
                DropDownList item4 = (DropDownList)FindControl(txtComidaIndividualObservaciones1.Text + i);
                nOCD.Comida.CodigoPlato = decimal.Parse(item4.SelectedValue);
                */

                nOCD.Comida.ServicioComida.Tipo = "general";

                //TextBox item5 = (TextBox)form1.FindControl("txtComidaObservaciones" + TipoHab + i);
                //nOCD.Comida.Observaciones = item5.Text;

                nOCD.Comida.Observaciones = "Observaciones Comida";

                nOCD.Comida.FechaRecepcion = DateTime.Now;

                nOCC.ListaDetalle.Add(nOCD);
            }
        }

        protected void txtFechaIngreso_TextChanged1(object sender, EventArgs e)
        {
            TotaldeDias();
        }

        protected void txtFechaEgreso_TextChanged(object sender, EventArgs e)
        {
            TotaldeDias();
        }

        protected void individual_TextChanged(object sender, EventArgs e)
        {
            personasConHabitacion();
            desbloquearBoton();
        }
            
        protected void doble_TextChanged(object sender, EventArgs e)
        {
            personasConHabitacion();
            desbloquearBoton();
        }

        protected void triple_TextChanged(object sender, EventArgs e)
        {
            personasConHabitacion();
            desbloquearBoton();
        }

        protected void sectuple_TextChanged(object sender, EventArgs e)
        {
            personasConHabitacion();
            desbloquearBoton();
        }

        private void personasConHabitacion()
        {
            int uno = int.Parse(individual.Text);
            int dos = int.Parse(doble.Text);
            int tres = int.Parse(triple.Text);
            int cuatro = int.Parse(sectuple.Text);

            int total = uno + (dos * 2) + (tres * 3) + (cuatro * 4);

            txtPersonasHabitacion.Text = total.ToString();
        }

        private void desbloquearBoton()
        {
            int valor1 = int.Parse(txtNpersonas.Text);
            int valor2 = int.Parse(txtPersonasHabitacion.Text);

            if (valor2 >= valor1)
            {
                MostrarCasillas.Enabled = true;
                BtnSiguiente.Enabled = true;

            }
            else
            {
                MostrarCasillas.Enabled = false;
                BtnSiguiente.Enabled = true;
            }
        }

        private void TotaldeDias()
        {
            DateTime fechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
            DateTime fechaEgreso = DateTime.Parse(txtFechaEgreso.Text);

            TimeSpan total = fechaEgreso - fechaIngreso;

            int dias = total.Days + 1;

            txtRegistroDias.Text = dias.ToString();
        }

    }
}