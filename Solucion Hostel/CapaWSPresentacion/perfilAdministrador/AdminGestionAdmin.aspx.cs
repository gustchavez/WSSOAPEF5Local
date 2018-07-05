using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminGestionAdmin : System.Web.UI.Page
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
                        //RescatarDatos();
                    }
                }
                else {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("perfilIngreso.aspx");
                }
            }
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("perfilIngreso.aspx");
            }
        }
        private void RescatarDatosProveedor()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            ContenedorPerfilUsuarioProveedor n = new ContenedorPerfilUsuarioProveedor();
            n = x.PerfilUsuarioProveedorRescatarXRut(rutUsuario, token);

            if(n.Retorno.Codigo == 0)
            {
                PerfilUsuarioProveedor a      = n.Item;
                txtRutEmpresa.Text            = a.Proveedor.Rut;
                txtRazonSocial.Text           = a.PerfilUsuario.Empresa.RazonSocial;
                ddlGiro.SelectedValue         = a.PerfilUsuario.Empresa.Rubro;
                txtMailEmpresa.Text           = a.PerfilUsuario.Empresa.Email;
                txtTelEmpresa.Text            = a.PerfilUsuario.Empresa.Telefono;
                ddlNombreCiudad.SelectedValue = a.PerfilUsuario.Direccion.NombreCiudad;
                ddlComuna.SelectedValue       = a.PerfilUsuario.Direccion.Comuna;
                txtDirEmp.Text                = a.PerfilUsuario.Direccion.Calle;
                txtRutPersona.Text            = a.PerfilUsuario.Persona.Rut;
                txtNombrePersona.Text         = a.PerfilUsuario.Persona.Nombre;
                txtApellidoPersona.Text       = a.PerfilUsuario.Persona.Apellido;
                txtFecNacPersona.Text         = a.PerfilUsuario.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text           = a.PerfilUsuario.Persona.Email;
                txtTelPersona.Text            = a.PerfilUsuario.Persona.Telefono;
                txtUsuario.Text               = a.PerfilUsuario.Usuario.Nombre;
                txtClave.Text                 = a.PerfilUsuario.Usuario.Clave;
                ddlEstado.SelectedValue       = a.PerfilUsuario.Usuario.Estado;
            }
        }

        private void RescatarDatosCliente()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();
            n = x.PerfilUsuarioClienteRescatarXRut(rutUsuario, token);

            if (n.Retorno.Codigo == 0)
            {
                PerfilUsuarioCliente a        = n.Item;
                txtRutEmpresa.Text            = a.Cliente.Rut;
                txtRazonSocial.Text           = a.PerfilUsuario.Empresa.RazonSocial;
                ddlGiro.SelectedValue         = a.PerfilUsuario.Empresa.Rubro;
                txtMailEmpresa.Text           = a.PerfilUsuario.Empresa.Email;
                txtTelEmpresa.Text            = a.PerfilUsuario.Empresa.Telefono;
                ddlNombreCiudad.SelectedValue = a.PerfilUsuario.Direccion.NombreCiudad;
                ddlComuna.SelectedValue       = a.PerfilUsuario.Direccion.Comuna;
                txtDirEmp.Text                = a.PerfilUsuario.Direccion.Calle;
                txtRutPersona.Text            = a.PerfilUsuario.Persona.Rut;
                txtNombrePersona.Text         = a.PerfilUsuario.Persona.Nombre;
                txtApellidoPersona.Text       = a.PerfilUsuario.Persona.Apellido;
                txtFecNacPersona.Text         = a.PerfilUsuario.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text           = a.PerfilUsuario.Persona.Email;
                txtTelPersona.Text            = a.PerfilUsuario.Persona.Telefono;
                txtUsuario.Text               = a.PerfilUsuario.Usuario.Nombre;
                txtClave.Text                 = a.PerfilUsuario.Usuario.Clave;
                ddlEstado.SelectedValue       = a.PerfilUsuario.Usuario.Estado;
            }
        }
        private void RescatarDatosEmpleado()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            ContenedorPerfilUsuarioEmpleado n = new ContenedorPerfilUsuarioEmpleado();
            n = x.PerfilUsuarioEmpleadoRescatarXRut(rutUsuario, token);

            if (n.Retorno.Codigo == 0)
            {
                PerfilUsuarioEmpleado a      = n.Item;
                txtRutPersona.Text           = a.Persona.Rut;
                txtNombrePersona.Text        = a.Persona.Nombre;
                txtApellidoPersona.Text      = a.Persona.Apellido;
                txtFecNacPersona.Text        = a.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text          = a.Persona.Email;
                txtTelPersona.Text           = a.Persona.Telefono;
                txtClave.Text                = a.Usuario.Clave;
                txtUsuario.Text              = a.Usuario.Nombre;
                ddlEstado.SelectedValue      = a.Usuario.Estado;
            }
        }
        private void RescatarDatosAdministrador()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            ContenedorPerfilUsuarioAdministrador n = new ContenedorPerfilUsuarioAdministrador();
            n = x.PerfilUsuarioAdministradorRescatarXRut(rutUsuario, token);

            if (n.Retorno.Codigo == 0)
            {
                PerfilUsuarioAdministrador a = n.Item;
                txtRutPersona.Text           = a.Persona.Rut;
                txtNombrePersona.Text        = a.Persona.Nombre;
                txtApellidoPersona.Text      = a.Persona.Apellido;
                txtFecNacPersona.Text        = a.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text          = a.Persona.Email;
                txtTelPersona.Text           = a.Persona.Telefono;
                txtClave.Text                = a.Usuario.Clave;
                txtUsuario.Text              = a.Usuario.Nombre;
                ddlEstado.SelectedValue      = a.Usuario.Estado;
            }
        }

        protected void ddlTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            int perfil = ddlTipoPerfil.SelectedIndex;

            switch (perfil)
            {
                case 1:
                    //Admin
                    ContenedorPerfilUsuarioAdministradores m = new ContenedorPerfilUsuarioAdministradores();
                    m = x.PerfilUsuarioAdministradorRescatar(Session["TokenUsuario"].ToString());

                    var adm = (from l in m.Lista
                                select new
                                {
                                    Rut = l.Persona.Rut,
                                    NombreCompleto = l.Persona.Apellido + l.Persona.Nombre
                                }
                                ).ToList();

                    if (adm != null)
                    {
                        ddlRutPerfil.DataSource = adm;
                        ddlRutPerfil.DataValueField = "Rut";
                        ddlRutPerfil.DataTextField = "NombreCompleto";
                        ddlRutPerfil.DataBind();
                        ddlRutPerfil.Enabled = true;
                        ////
                        RescatarDatosAdministrador();
                        LimpiarControlesEmpresa();
                        ////
                    }
                    else {
                        InicializarPersona();
                    }
                    break;
                case 2:
                    //Empleado
                    ContenedorPerfilUsuarioEmpleados n = new ContenedorPerfilUsuarioEmpleados();
                    n = x.PerfilUsuarioEmpleadoRescatar(Session["TokenUsuario"].ToString());

                    var emp = (from l in n.Lista
                                select new
                                {
                                    Rut = l.Persona.Rut,
                                    NombreCompleto = l.Persona.Apellido + l.Persona.Nombre
                                }
                                ).ToList();

                    if (emp != null)
                    {
                        ddlRutPerfil.DataSource = emp;
                        ddlRutPerfil.DataValueField = "Rut";
                        ddlRutPerfil.DataTextField = "NombreCompleto";
                        ddlRutPerfil.DataBind();
                        ddlRutPerfil.Enabled = true;
                        ////
                        RescatarDatosEmpleado();
                        LimpiarControlesEmpresa();
                        ////
                    }
                    else {
                        InicializarPersona();
                    }
                    break;
                case 3:
                    //Cliente      
                    ContenedorPerfilUsuarioClientes o = new ContenedorPerfilUsuarioClientes();
                    o = x.PerfilUsuarioClienteRescatar(Session["TokenUsuario"].ToString());

                    var clie = (from l in o.Lista
                                select new
                                {
                                    Rut = l.Cliente.Rut,
                                    RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                                }
                                ).ToList();

                    if (clie != null)
                    {
                        ddlRutPerfil.DataSource = clie;
                        ddlRutPerfil.DataValueField = "Rut";
                        ddlRutPerfil.DataTextField = "RazonSocial";
                        ddlRutPerfil.DataBind();
                        ddlRutPerfil.Enabled = true;
                        ////
                        RescatarDatosCliente();
                        ////
                    }
                    else {
                        InicializarEmpresa();
                    }
                    break;
                case 4:
                    //Proveedor
                    ContenedorPerfilUsuarioProveedores p = new ContenedorPerfilUsuarioProveedores();
                    p = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

                    var prov = (from l in p.Lista
                                select new
                                {
                                    Rut = l.Proveedor.Rut,
                                    RazonSocial = l.PerfilUsuario.Empresa.RazonSocial
                                }
                                ).ToList();

                    if (prov != null)
                    {
                        ddlRutPerfil.DataSource = prov;
                        ddlRutPerfil.DataValueField = "Rut";
                        ddlRutPerfil.DataTextField = "RazonSocial";
                        ddlRutPerfil.DataBind();
                        ddlRutPerfil.Enabled = true;
                        ////
                        RescatarDatosProveedor();
                        ////
                    }
                    else {
                        InicializarEmpresa();
                    }
                    break;
                default:
                    ReiniciarDDL();
                    break;
            }
        }

        private void InicializarPersona()
        {
            ReiniciarDDL();
            LimpiarControlesPersona();
            LimpiarControlesUsuario();
        }

        private void InicializarEmpresa()
        {
            ReiniciarDDL();
            LimpiarControlesPersona();
            LimpiarControlesEmpresa();
            LimpiarControlesUsuario();
        }
        private void ReiniciarDDL()
        {
            ddlRutPerfil.Items.Clear();
            ddlRutPerfil.Items.Add(new ListItem("No Existe", ""));
            ddlRutPerfil.DataBind();
            ddlRutPerfil.SelectedIndex = 0;
            //////////////
            ddlRutPerfil.Enabled = false;            
        }

        private void LimpiarControlesPersona()
        {
            txtRutPersona.Text = string.Empty;
            txtApellidoPersona.Text = string.Empty;
            txtNombrePersona.Text = string.Empty;
            txtFecNacPersona.Text = string.Empty;
            txtMailPersona.Text = string.Empty;
        }
        private void LimpiarControlesEmpresa()
        { 
            ddlComuna.SelectedIndex = 0;
            ddlGiro.SelectedIndex = 0;
            ddlNombreCiudad.SelectedIndex = 0;
            //
            txtRutEmpresa.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtTelEmpresa.Text = string.Empty;
            txtDirEmp.Text = string.Empty;
            txtMailEmpresa.Text = string.Empty;
        }
        private void LimpiarControlesUsuario()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        protected void ddlRutPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            int perfil = ddlTipoPerfil.SelectedIndex;

            switch (perfil)
            {
                case 1:
                    RescatarDatosAdministrador();
                    break;
                case 2:
                    RescatarDatosEmpleado();
                    break;
                case 3:
                    RescatarDatosCliente();
                    break;
                case 4:
                    RescatarDatosProveedor();
                    break;
                default:
                    ReiniciarDDL();
                    break;
            }
        }
        protected void btnModificar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            int perfil = ddlTipoPerfil.SelectedIndex;

            switch (perfil)
            {
                case 1:
                    //Admin
                    ContenedorPerfilUsuarioAdministrador m = new ContenedorPerfilUsuarioAdministrador();
                    m = x.PerfilUsuarioAdministradorRescatarXRut(txtRutPersona.Text, Session["TokenUsuario"].ToString());
                    //
                    ContenedorPerfilUsuarioAdministrador ad       = new ContenedorPerfilUsuarioAdministrador();
                    ad.Item                                       = m.Item;
                    ad.Item.Persona.Nombre                        = txtNombrePersona.Text;
                    ad.Item.Persona.Apellido                      = txtApellidoPersona.Text;
                    ad.Item.Persona.FechaNacimiento               = DateTime.Parse(txtFecNacPersona.Text);
                    ad.Item.Persona.Email                         = txtMailPersona.Text;
                    ad.Item.Persona.Telefono                      = txtTelPersona.Text;
                    ad.Item.Usuario.Clave                         = txtClave.Text;
                    ad.Item.Usuario.Estado                        = ddlEstado.SelectedValue;
                    ad.Retorno.Token                              = Session["TokenUsuario"].ToString();
                    ad                                            = x.PerfilUsuarioAdministradorActualizar(ad);
                    //
                    break;
                case 2:
                    //Empleado
                    ContenedorPerfilUsuarioEmpleado n = new ContenedorPerfilUsuarioEmpleado();
                    n = x.PerfilUsuarioEmpleadoRescatarXRut(txtRutPersona.Text, Session["TokenUsuario"].ToString());
                    //
                    ContenedorPerfilUsuarioEmpleado em            = new ContenedorPerfilUsuarioEmpleado();
                    em.Item                                       = n.Item;
                    em.Item.Persona.Nombre                        = txtNombrePersona.Text;
                    em.Item.Persona.Apellido                      = txtApellidoPersona.Text;
                    em.Item.Persona.FechaNacimiento               = DateTime.Parse(txtFecNacPersona.Text);
                    em.Item.Persona.Email                         = txtMailPersona.Text;
                    em.Item.Persona.Telefono                      = txtTelPersona.Text;
                    em.Item.Usuario.Clave                         = txtClave.Text;
                    em.Item.Usuario.Estado                        = ddlEstado.SelectedValue;
                    em.Retorno.Token                              = Session["TokenUsuario"].ToString();
                    em                                            = x.PerfilUsuarioEmpleadoActualizar(em);
                    //
                    break;
                case 3:
                    //Cliente
                    ContenedorPerfilUsuarioCliente o = new ContenedorPerfilUsuarioCliente();
                    o = x.PerfilUsuarioClienteRescatarXRut(txtRutEmpresa.Text, Session["TokenUsuario"].ToString());
                    //
                    ContenedorPerfilUsuarioCliente cl             = new ContenedorPerfilUsuarioCliente();
                    cl.Item                                       = o.Item;
                    cl.Item.PerfilUsuario.Empresa.RazonSocial     = txtRazonSocial.Text;
                    cl.Item.PerfilUsuario.Empresa.Rubro           = ddlGiro.SelectedValue;
                    cl.Item.PerfilUsuario.Empresa.Email           = txtMailEmpresa.Text;
                    cl.Item.PerfilUsuario.Empresa.Telefono        = txtTelEmpresa.Text;
                    cl.Item.PerfilUsuario.Direccion.NombreCiudad  = ddlNombreCiudad.SelectedValue;
                    cl.Item.PerfilUsuario.Direccion.Comuna        = ddlComuna.SelectedValue;
                    cl.Item.PerfilUsuario.Direccion.Calle         = txtDirEmp.Text;
                    cl.Item.PerfilUsuario.Persona.Nombre          = txtNombrePersona.Text;
                    cl.Item.PerfilUsuario.Persona.Apellido        = txtApellidoPersona.Text;
                    cl.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    cl.Item.PerfilUsuario.Persona.Email           = txtMailPersona.Text;
                    cl.Item.PerfilUsuario.Persona.Telefono        = txtTelPersona.Text;
                    cl.Item.PerfilUsuario.Usuario.Nombre          = txtUsuario.Text;
                    cl.Item.PerfilUsuario.Usuario.Clave           = txtClave.Text;
                    cl.Item.PerfilUsuario.Usuario.Estado          = ddlEstado.SelectedValue;
                    cl.Retorno.Token                              = Session["TokenUsuario"].ToString();
                    cl                                            = x.PerfilUsuarioClienteActualizar(cl);
                    //
                    break;
                case 4:
                    //Proveedor
                    ContenedorPerfilUsuarioProveedor p = new ContenedorPerfilUsuarioProveedor();
                    p = x.PerfilUsuarioProveedorRescatarXRut(txtRutEmpresa.Text, Session["TokenUsuario"].ToString());
                    //     
                    ContenedorPerfilUsuarioProveedor pr           = new ContenedorPerfilUsuarioProveedor();
                    pr.Item.PerfilUsuario.Empresa.RazonSocial     = txtRazonSocial.Text;
                    pr.Item.PerfilUsuario.Empresa.Rubro           = ddlGiro.SelectedValue;
                    pr.Item.PerfilUsuario.Empresa.Email           = txtMailEmpresa.Text;
                    pr.Item.PerfilUsuario.Empresa.Telefono        = txtTelEmpresa.Text;
                    pr.Item.PerfilUsuario.Direccion.NombreCiudad  = ddlNombreCiudad.SelectedValue;
                    pr.Item.PerfilUsuario.Direccion.Comuna        = ddlComuna.SelectedValue;
                    pr.Item.PerfilUsuario.Direccion.Calle         = txtDirEmp.Text;
                    pr.Item.PerfilUsuario.Persona.Nombre          = txtNombrePersona.Text;
                    pr.Item.PerfilUsuario.Persona.Apellido        = txtApellidoPersona.Text;
                    pr.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    pr.Item.PerfilUsuario.Persona.Email           = txtMailPersona.Text;
                    pr.Item.PerfilUsuario.Persona.Telefono        = txtTelPersona.Text;
                    pr.Item.PerfilUsuario.Usuario.Nombre          = txtUsuario.Text;
                    pr.Item.PerfilUsuario.Usuario.Clave           = txtClave.Text;
                    pr.Item.PerfilUsuario.Usuario.Estado          = ddlEstado.SelectedValue;
                    pr.Retorno.Token                              = Session["TokenUsuario"].ToString();
                    pr                                            = x.PerfilUsuarioProveedorActualizar(p);
                    //
                    break;
                default:
                    break;
            }
        }
        
    }
}