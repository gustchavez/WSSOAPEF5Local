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
            txtFechaEgreso.Text = DateTime.Now.ToString("yyyy-mm-dd");
            txtFechaIngreso.Text = DateTime.Now.ToString("yyyy-mm-dd");
            MostrarCasillas.Enabled = false;
            BtnSiguiente.Enabled = false;
        }

        protected void Siguiente_Click1(object sender, EventArgs e)
        {

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            OrdenCompraCompleta nOCC = new OrdenCompraCompleta();

            //nOCC.Cabecera.RutCliente = txtRutPersona.Text;
            nOCC.Cabecera.Monto = 1000;//realizar calculo de las habitaciones seleccionadas.
            nOCC.Cabecera.Observaciones = "Reserva habitación";
            nOCC.Cabecera.Ubicacion = "Nose";
            nOCC.Cabecera.Estado = "activa";

            int CantidadHuespedes = int.Parse(Session["CantidadHuespedes"].ToString());

            for (int i = 0; i < CantidadHuespedes; i++)
            {
                OrdenCompraDetalle nOCD = new OrdenCompraDetalle();
                //nOCD.Alojamiento.RutPersona = item0.Text;
                //nOCD.Alojamiento.FechaIngreso = DateTime.Parse(item1.Text);
                //nOCD.Alojamiento.FechaEgreso = DateTime.Parse(item2.Text);
                nOCD.Alojamiento.CodigoCama = 1;
                nOCD.Alojamiento.Observaciones = "bla bla";
                nOCD.Comida.CodigoPlato = 1;
                nOCD.Comida.Observaciones = "bla bla";
                nOCD.Comida.FechaRecepcion = DateTime.Now;
                nOCC.ListaDetalle.Add(nOCD);
            }

        }


        //GUSTAVO ----->
        /*
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
            nOCD.Alojamiento.RutPersona = item0.Text; 
            nOCD.Alojamiento.FechaIngreso = DateTime.Parse(item1.Text );
            nOCD.Alojamiento.FechaEgreso = DateTime.Parse(item2.Text); 
            nOCD.Alojamiento.CodigoCama = 1; 
            nOCD.Alojamiento.Observaciones = "bla bla"; 
            nOCD.Comida.CodigoPlato = 1; 
            nOCD.Comida.Observaciones = "bla bla"; 
            nOCD.Comida.FechaRecepcion = DateTime.Now 
            nOCC.ListaDetalle.Add(nOCD);
        } */




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