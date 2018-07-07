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
            LlenarDDLTipoComida();

            Bloqueados();
        }

        private void LlenarDDLTipoComida()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorServiciosComida n = new ContenedorServiciosComida();
            n = x.ServicioComidaRescatar(Session["TokenUsuario"].ToString());

            if (n.Retorno.Codigo == 0)
            {
                RecorrerDDLXCapacHab(n.Lista, 6, "Individual", 1);
                RecorrerDDLXCapacHab(n.Lista, 6, "Doble"     , 2);
                RecorrerDDLXCapacHab(n.Lista, 5, "Triple"    , 3);
                RecorrerDDLXCapacHab(n.Lista, 4, "Cuadruple" , 4);
            }
        }
        private void RecorrerDDLXCapacHab ( List<ServicioComida> Lista, int CantHuesp, string TipoHab, int CapHab)
        {
            for (int i = 1; i < CantHuesp + 1; i++)
            {
                DropDownList item6   = (DropDownList)form1.FindControl("ddlTipoServCom" + TipoHab + i);
                item6.DataSource     = null;
                item6.DataSource     = Lista;
                item6.DataValueField = "Tipo";
                item6.DataTextField  = "Tipo";
                item6.DataBind();
            }
        }

        private void Bloqueados()
        {
            txtFechaEgreso.Text = DateTime.Now.ToString("yyyy-MM-dd"); 
            txtFechaIngreso.Text = DateTime.Now.ToString("yyyy-MM-dd");
            //
            MostrarCasillas.Enabled = false;
            BtnSiguiente.Enabled = false;
        }

        protected void BtnSiguiente_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            OrdenCompraCompleta nOCC = new OrdenCompraCompleta();
            //Armar Encabezado de Orden de Reserva
            nOCC.Cabecera.RutCliente    = SesionUsuario.RutEmpresa;
            nOCC.Cabecera.Monto         = int.Parse(txtPersonasHabitacion.Text);//realizar calculo de las habitaciones seleccionadas.
            nOCC.Cabecera.Observaciones = "Reserva habitación";
            nOCC.Cabecera.Ubicacion     = "logo";
            nOCC.Cabecera.Estado        = "activa";

            //int CantidadHuespedes = int.Parse(Session[txtPersonasHabitacion.Text].ToString());
            try
            {                
                int CantHuspedes = int.Parse(individual.Text);
                AgregarHuesped(nOCC, CantHuspedes, "Individual", 1);
            }
            catch (Exception)
            {
                //No existe se continua siguiente validacion
            }

            try
            {
                int CantHuspedes = int.Parse(doble.Text) * 2;
                AgregarHuesped(nOCC, CantHuspedes, "Doble", 2);
            }
            catch (Exception)
            {
                //No existe se continua siguiente validacion
            }

            try
            {
                int CantHuspedes = int.Parse(triple.Text) * 3;
                AgregarHuesped(nOCC, CantHuspedes, "Tiple", 3);
            }
            catch (Exception)
            {
                //No existe se continua siguiente validacion
            }

            try
            {
                int CantHuspedes = int.Parse(triple.Text) * 4;
                AgregarHuesped(nOCC, CantHuspedes, "Cuadruple", 4);
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
                if(item0.Text.Trim().Length > 0)
                {
                    nOCD.Persona.Rut = item0.Text;

                    TextBox item1 = (TextBox)form1.FindControl("txtNombre" + TipoHab + i);
                    nOCD.Persona.Nombre = item0.Text;

                    TextBox item2 = (TextBox)form1.FindControl("txtApellido" + TipoHab + i);
                    nOCD.Persona.Apellido = item0.Text;

                    //TextBox item3 = (TextBox)form1.FindControl("txtFecha" + TipoHab + i);
                    nOCD.Alojamiento.FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);

                    //TextBox item4 = (TextBox)form1.FindControl("txtFecha" + TipoHab + i);
                    nOCD.Alojamiento.FechaEgreso = DateTime.Parse(txtFechaEgreso.Text);

                    nOCD.Alojamiento.Habitacion.Capacidad = CapHab;

                    TextBox item5 = (TextBox)form1.FindControl("txtAlojaObs" + TipoHab + i);
                    nOCD.Alojamiento.Observaciones = item5.Text;

                    //se debe incluir los dropdownlist de tipo de comida
                    DropDownList item6 = (DropDownList)form1.FindControl("ddlTipoServCom" + TipoHab + i);
                    nOCD.Comida.ServicioComida.Tipo = item6.SelectedValue;
                    //nOCD.Comida.ServicioComida.Tipo = "general";

                    //TextBox item7 = (TextBox)form1.FindControl("txtComidaObservaciones" + TipoHab + i);
                    //nOCD.Comida.Observaciones = item7.Text;

                    nOCD.Comida.Observaciones = "Sin Observaciones";

                    nOCD.Comida.FechaRecepcion = DateTime.Now;

                    nOCC.ListaDetalle.Add(nOCD);
                }
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

        protected void cuadruple_TextChanged(object sender, EventArgs e)
        {
            personasConHabitacion();
            desbloquearBoton();
        }

        private void personasConHabitacion()
        {
            int uno    = int.Parse(individual.Text);
            int dos    = int.Parse(doble.Text);
            int tres   = int.Parse(triple.Text);
            int cuatro = int.Parse(cuadruple.Text);

            int total  = uno + (dos * 2) + (tres * 3) + (cuatro * 4);

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
            try
            {
                DateTime fechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
                DateTime fechaEgreso = DateTime.Parse(txtFechaEgreso.Text);

                if(fechaIngreso != null && fechaEgreso != null && fechaIngreso < fechaEgreso)
                {
                    TimeSpan total = fechaEgreso - fechaIngreso;

                    int dias = total.Days + 1;

                    txtRegistroDias.Text = dias.ToString();

                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
                    Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

                    ContenedorHabDispCant n = new ContenedorHabDispCant();
                    n = x.HabitacionHabXCapacidad(Session["TokenUsuario"].ToString(), fechaIngreso, fechaEgreso);
                    
                    //ContenedorHabDispCant
                    //OrdenCompraCompleta nOCC = new OrdenCompraCompleta();
                    ////Armar Encabezado de Orden de Reserva
                    //nOCC.Cabecera.RutCliente = SesionUsuario.RutEmpresa;

                    txtCantHabDispSim.Text = n.Item.CantHabSimple.ToString();
                    txtCantHabDispDob.Text = n.Item.CantHabDoble.ToString();
                    txtCantHabDispTri.Text = n.Item.CantHabTriple.ToString();
                    txtCantHabDispCua.Text = n.Item.CantHabSectuple.ToString();
                } else {
                    txtCantHabDispSim.Text = "0";
                    txtCantHabDispDob.Text = "0";
                    txtCantHabDispTri.Text = "0";
                    txtCantHabDispCua.Text = "0";
                }
            }
            catch (Exception)
            {
                txtRegistroDias.Text   = "0";
                txtCantHabDispSim.Text = "0";
                txtCantHabDispDob.Text = "0";
                txtCantHabDispTri.Text = "0";
                txtCantHabDispCua.Text = "0";
            }
        }

        

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            RangeValidator1.MinimumValue = DateTime.Now.Date.ToString("dd-MM-yyyy");
            RangeValidator1.MaximumValue = DateTime.Now.Date.AddYears(90).ToString("dd-MM-yyyy");
        }
    }
}