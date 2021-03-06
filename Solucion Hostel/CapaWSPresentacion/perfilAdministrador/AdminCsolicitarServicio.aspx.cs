﻿using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminCsolicitarServicio : System.Web.UI.Page
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
            LlenarDDLEmpresa();
            LlenarDDLTipoComida();
            Bloqueados();
            txtFechaIngreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtFechaEgreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        private void LlenarDDLEmpresa()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioClientes m = new ContenedorPerfilUsuarioClientes();
            m = x.PerfilUsuarioClienteRescatar(Session["TokenUsuario"].ToString());

            var clie = (from l in m.Lista
                        select new
                        {
                            Rut = l.Cliente.Rut,
                            RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                        }
                        ).ToList();

            if (clie != null)
            {
                ddlEmpresas.DataSource = clie;
                ddlEmpresas.DataValueField = "Rut";
                ddlEmpresas.DataTextField = "RazonSocial";
                ddlEmpresas.DataBind();
                ddlEmpresas.Enabled = true;
                ////
            } else {
                ddlEmpresas.Items.Clear();
                ddlEmpresas.Items.Add(new ListItem("No Existe", ""));
                ddlEmpresas.DataBind();
                ddlEmpresas.SelectedIndex = 0;
                //////////////
                ddlEmpresas.Enabled = false;

            }
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
                ////////////////
                TextBox item0 = (TextBox)form1.FindControl("txtRut" + TipoHab + i);
                item0.Text = string.Empty;

                TextBox item1 = (TextBox)form1.FindControl("txtNombre" + TipoHab + i);
                item1.Text = string.Empty;

                TextBox item2 = (TextBox)form1.FindControl("txtApellido" + TipoHab + i);
                item2.Text = string.Empty;
                
                TextBox item5 = (TextBox)form1.FindControl("txtAlojaObs" + TipoHab + i);
                item5.Text = string.Empty;
                ////////////////
            }
        }

        private void Bloqueados()
        {
            txtFechaEgreso.Text = DateTime.Now.ToString("dd-MM-yyyy"); 
            txtFechaIngreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
            //
            MostrarCasillas.Enabled = false;
            BtnSiguiente.Enabled = false;
        }

        protected void BtnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
                Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

                OrdenCompraCompleta nOCC = new OrdenCompraCompleta();
                //Armar Encabezado de Orden de Reserva
                nOCC.Cabecera.RutCliente = ddlEmpresas.SelectedValue;
                nOCC.Cabecera.Monto = 0;//realizar calculo de las habitaciones seleccionadas.
                nOCC.Cabecera.Observaciones = "Reserva habitación";
                nOCC.Cabecera.Ubicacion = "logo";
                nOCC.Cabecera.Estado = "activa";

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
                    AgregarHuesped(nOCC, CantHuspedes, "Triple", 3);
                }
                catch (Exception)
                {
                    //No existe se continua siguiente validacion
                }

                try
                {
                    int CantHuspedes = int.Parse(cuadruple.Text) * 4;
                    AgregarHuesped(nOCC, CantHuspedes, "Cuadruple", 4);
                }
                catch (Exception)
                {
                    //No existe se continua siguiente validacion
                }

                ContenedorOrdenCompraCompleta xOCC = new ContenedorOrdenCompraCompleta();
                xOCC.Item.Cabecera = nOCC.Cabecera;
                xOCC.Item.ListaDetalle = nOCC.ListaDetalle;

                if (xOCC.Item.ListaDetalle.Count > 0)
                {
                    xOCC.Retorno.Token = Session["TokenUsuario"].ToString();
                    xOCC = x.OrdenCompraCompletaCrear(xOCC);

                    if (xOCC.Retorno.Codigo == 0)
                    {
                        //OK
                        RescatarDatos();
                        Response.Write(@"<script language='text/javascript'>alert('Reserva relizada Correctamente');</script>");
                    } else {
                        //Error
                        Response.Write(@"<script language='text/javascript'>alert('Fallo la realizacion de la Reserva');</script>");
                    }
                } else {
                    Response.Write(@"<script language='text/javascript'>alert('Ingrese Datos de Huespedes');</script>");
                }
            }
            catch (Exception)
            {
                Response.Write(@"<script language='text/javascript'>alert('Fallo la realizacion de la Reserva');</script>");
            }

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
                    nOCD.Persona.Nombre = item1.Text;

                    TextBox item2 = (TextBox)form1.FindControl("txtApellido" + TipoHab + i);
                    nOCD.Persona.Apellido = item2.Text;

                    //TextBox item3 = (TextBox)form1.FindControl("txtFecha" + TipoHab + i);
                    nOCD.Alojamiento.FechaIngreso = DateTime.Parse(txtFechaIngreso.Text);

                    //TextBox item4 = (TextBox)form1.FindControl("txtFecha" + TipoHab + i);
                    nOCD.Alojamiento.FechaEgreso = DateTime.Parse(txtFechaEgreso.Text);

                    nOCD.Alojamiento.RegistroDias = int.Parse(txtRegistroDias.Text);

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
            //TotaldeDias();
        }

        protected void txtFechaEgreso_TextChanged(object sender, EventArgs e)
        {
            //TotaldeDias();
        }

        protected void individual_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(individual.Text)<0)
            {
                individual.Text = "0";
            }
            else
            {
                personasConHabitacion();
                desbloquearBoton();
            }
            
        }
            
        protected void doble_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(doble.Text) < 0)
            {
                doble.Text = "0";
            }
            else
            {
                personasConHabitacion();
                desbloquearBoton();
            }
        }

        protected void triple_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(triple.Text) < 0)
            {
                triple.Text = "0";
            }
            else
            {
                personasConHabitacion();
                desbloquearBoton();
            }
        }

        protected void cuadruple_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(cuadruple.Text) < 0)
            {
                cuadruple.Text = "0";
            }
            else
            {
                personasConHabitacion();
                desbloquearBoton();
            }
            
        }

        private void personasConHabitacion()
        {
            int uno    = int.Parse(individual.Text);
            int dos    = int.Parse(doble.Text);
            int tres   = int.Parse(triple.Text);
            int cuatro = int.Parse(cuadruple.Text);

            int total  = uno + dos + tres + cuatro;

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

                    int dias = total.Days;

                    txtRegistroDias.Text = dias.ToString();

                    WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
                    Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

                    ContenedorHabDispCant n = new ContenedorHabDispCant();
                    n = x.HabitacionHabXCapacidad(Session["TokenUsuario"].ToString(), fechaIngreso, fechaEgreso);
             
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

        protected void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {
            //Range2.MinimumValue = DateTime.Parse(txtFechaIngreso.Text).AddDays(1).ToShortDateString();
            try
            {
                DateTime fechaIngreso = DateTime.Parse(txtFechaIngreso.Text);
                if (fechaIngreso < DateTime.Now || fechaIngreso != null)
                {
                    Response.Write(@"<script lenguage='text/javascript'>alert('La fecha de ingreso debe der mayor o igual a la fecha actual');</script>");
                }
            }
            catch(Exception ex)
            {
                txtFechaIngreso.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
            
            
        }

        protected void txtFechaEgreso_TextChanged1(object sender, EventArgs e)
        {
            //Range2.MinimumValue = DateTime.Parse(txtFechaIngreso.Text).AddDays(1).ToShortDateString();
            try
            {
                
                DateTime fechaEgreso = DateTime.Parse(txtFechaEgreso.Text);
                if (fechaEgreso < DateTime.Parse(txtFechaIngreso.Text) || fechaEgreso == null)
                {
                    Response.Write(@"<script lenguage='text/javascript'>alert('La fecha de egreso debe der mayor a la fecha de ingreso');</script>");
                    txtRegistroDias.Text = "";
                }
                else
                {
                    if (txtFechaEgreso.Text != null && txtFechaIngreso.Text != null)
                    {
                        TimeSpan difDias = DateTime.Parse(txtFechaEgreso.Text) - DateTime.Parse(txtFechaIngreso.Text);
                        if (difDias.Days>=0)
                        {
                            //Response.Write(difDias.Days.ToString());
                            txtRegistroDias.Text = difDias.Days.ToString();
                            TotaldeDias();
                        }
                        else
                        {
                            txtRegistroDias.Text = "0";
                        }
                        
                        
                    }                    
                }
            }
            catch (Exception)
            {
                txtRegistroDias.Text = "0";
            }
        }

        protected void txtNpersonas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFechaEgreso.Text != null && txtFechaIngreso.Text != null)
                {
                    int num = int.Parse(txtNpersonas.Text);
                    if (num < 0 || num == null)
                    {
                        Response.Write(@"<script lenguage='text/javascript'>alert('La cantidad de personas debe ser mayor a 0');</script>");
                        txtNpersonas.Text = "0";
                    }
                }
                else
                {
                    Response.Write(@"<script lenguage='text/javascript'>alert('Debe ingresar las fechas primero');</script>");
                }

            }
            catch (Exception)
            {
                txtNpersonas.Text = "0";
            }
        }
    }
}