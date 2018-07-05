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
                PerfilUsuarioProveedor a = n.Item;
                txtRutEmpresa.Text = a.Proveedor.Rut;
                txtRazonSocial.Text = a.PerfilUsuario.Empresa.RazonSocial;
                ddlGiro.SelectedValue = a.PerfilUsuario.Empresa.Rubro;
                txtMailEmpresa.Text = a.PerfilUsuario.Empresa.Email;
                txtTelEmpresa.Text = a.PerfilUsuario.Empresa.Telefono;
                //a.PerfilUsuario.Direccion.CodPais = 56;
                //a.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                ddlNombreCiudad.SelectedValue = a.PerfilUsuario.Direccion.NombreCiudad;
                ddlComuna.SelectedValue = a.PerfilUsuario.Direccion.Comuna;
                txtDirEmp.Text = a.PerfilUsuario.Direccion.Calle;
                //a.PerfilUsuario.Direccion.Numero = 0;
                //a.PerfilUsuario.Empresa.Logo = "Logo";
                txtRutPersona.Text = a.PerfilUsuario.Persona.Rut;
                txtNombrePersona.Text = a.PerfilUsuario.Persona.Nombre;
                txtApellidoPersona.Text = a.PerfilUsuario.Persona.Apellido;
                txtFecNacPersona.Text = a.PerfilUsuario.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text = a.PerfilUsuario.Persona.Email;
                txtTelPersona.Text = a.PerfilUsuario.Persona.Telefono;
                txtUsuario.Text = a.PerfilUsuario.Usuario.Nombre;
                txtClave.Text = a.PerfilUsuario.Usuario.Clave;
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
                PerfilUsuarioCliente a = n.Item;
                txtRutEmpresa.Text = a.Cliente.Rut;
                txtRazonSocial.Text = a.PerfilUsuario.Empresa.RazonSocial;
                ddlGiro.SelectedValue = a.PerfilUsuario.Empresa.Rubro;
                txtMailEmpresa.Text = a.PerfilUsuario.Empresa.Email;
                txtTelEmpresa.Text = a.PerfilUsuario.Empresa.Telefono;
                //a.PerfilUsuario.Direccion.CodPais = 56;
                //a.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                ddlNombreCiudad.SelectedValue = a.PerfilUsuario.Direccion.NombreCiudad;
                ddlComuna.SelectedValue = a.PerfilUsuario.Direccion.Comuna;
                txtDirEmp.Text = a.PerfilUsuario.Direccion.Calle;
                //a.PerfilUsuario.Direccion.Numero = 0;
                //a.PerfilUsuario.Empresa.Logo = "Logo";
                txtRutPersona.Text = a.PerfilUsuario.Persona.Rut;
                txtNombrePersona.Text = a.PerfilUsuario.Persona.Nombre;
                txtApellidoPersona.Text = a.PerfilUsuario.Persona.Apellido;
                txtFecNacPersona.Text = a.PerfilUsuario.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text = a.PerfilUsuario.Persona.Email;
                txtTelPersona.Text = a.PerfilUsuario.Persona.Telefono;
                txtUsuario.Text = a.PerfilUsuario.Usuario.Nombre;
                txtClave.Text = a.PerfilUsuario.Usuario.Clave;
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
                PerfilUsuarioEmpleado a = n.Item;
                txtRutPersona.Text = a.Persona.Rut;
                txtNombrePersona.Text = a.Persona.Nombre;
                txtApellidoPersona.Text = a.Persona.Apellido;
                txtFecNacPersona.Text = a.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text = a.Persona.Email;
                txtTelPersona.Text = a.Persona.Telefono;
                txtClave.Text = a.Usuario.Clave;
                txtUsuario.Text = a.Usuario.Nombre;
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
                txtRutPersona.Text = a.Persona.Rut;
                txtNombrePersona.Text = a.Persona.Nombre;
                txtApellidoPersona.Text = a.Persona.Apellido;
                txtFecNacPersona.Text = a.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtMailPersona.Text = a.Persona.Email;
                txtTelPersona.Text = a.Persona.Telefono;
                txtClave.Text = a.Usuario.Clave;
                txtUsuario.Text = a.Usuario.Nombre;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            int perfil = ddlTipoPerfil.SelectedIndex;
            //TextBox7.Text = txtGiro.SelectedItem.Text;
            switch (perfil)
            {
                case 1:
                    //Admin
                    ContenedorPerfilUsuarioAdministrador a = new ContenedorPerfilUsuarioAdministrador();
                    a.Item.Persona.Rut = txtRutPersona.Text;
                    a.Item.Persona.Nombre = txtNombrePersona.Text;
                    a.Item.Persona.Apellido = txtApellidoPersona.Text;
                    a.Item.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    a.Item.Persona.Email = txtMailPersona.Text;
                    a.Item.Persona.Telefono = txtTelPersona.Text;
                    a.Item.Usuario.Clave = txtClave.Text;
                    a.Retorno.Token = Session["TokenUsuario"].ToString();
                    a = x.PerfilUsuarioAdministradorActualizar(a);
                    break;
                case 2:
                    //Empleado
                    ContenedorPerfilUsuarioEmpleado em = new ContenedorPerfilUsuarioEmpleado();
                    em.Item.Persona.Rut = txtRutPersona.Text;
                    em.Item.Persona.Nombre = txtNombrePersona.Text;
                    em.Item.Persona.Apellido = txtApellidoPersona.Text;
                    em.Item.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    em.Item.Persona.Email = txtMailPersona.Text;
                    em.Item.Persona.Telefono = txtTelPersona.Text;
                    em.Item.Usuario.Clave = txtClave.Text;
                    em.Retorno.Token = Session["TokenUsuario"].ToString();
                    em = x.PerfilUsuarioEmpleadoActualizar(em);
                    break;
                case 3:
                    //Cliente      
                    ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();

                    n.Item.Cliente.Rut = txtRutEmpresa.Text;
                    n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
                    n.Item.PerfilUsuario.Empresa.Rubro = ddlGiro.SelectedItem.Text;
                    n.Item.PerfilUsuario.Empresa.Email = txtMailEmpresa.Text;
                    n.Item.PerfilUsuario.Empresa.Telefono = txtTelEmpresa.Text;
                    n.Item.PerfilUsuario.Direccion.CodPais = 56;
                    n.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                    n.Item.PerfilUsuario.Direccion.NombreCiudad = ddlNombreCiudad.SelectedItem.Text;
                    n.Item.PerfilUsuario.Direccion.Comuna = ddlComuna.SelectedItem.Text;
                    n.Item.PerfilUsuario.Direccion.Calle = "";
                    n.Item.PerfilUsuario.Direccion.Numero = 0;
                    n.Item.PerfilUsuario.Empresa.Logo = "Logo";
                    n.Item.PerfilUsuario.Persona.Rut = txtRutPersona.Text;
                    n.Item.PerfilUsuario.Persona.Nombre = txtNombrePersona.Text;
                    n.Item.PerfilUsuario.Persona.Apellido = txtApellidoPersona.Text;
                    n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    n.Item.PerfilUsuario.Persona.Email = txtMailPersona.Text;
                    n.Item.PerfilUsuario.Persona.Telefono = txtTelPersona.Text;
                    n.Item.PerfilUsuario.Usuario.Clave = txtClave.Text;
                    n.Retorno.Token = Session["TokenUsuario"].ToString();
                    n = x.PerfilUsuarioClienteActualizar(n);
                    break;
                case 4:
                    //Proveedor

                    ContenedorPerfilUsuarioProveedor p = new ContenedorPerfilUsuarioProveedor();

                    p.Item.Proveedor.Rut = txtRutEmpresa.Text;
                    p.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
                    p.Item.PerfilUsuario.Empresa.Rubro = ddlGiro.SelectedItem.Text;
                    p.Item.PerfilUsuario.Empresa.Email = txtMailEmpresa.Text;
                    p.Item.PerfilUsuario.Empresa.Telefono = txtTelEmpresa.Text;
                    p.Item.PerfilUsuario.Direccion.CodPais = 56;
                    p.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                    p.Item.PerfilUsuario.Direccion.NombreCiudad = ddlNombreCiudad.SelectedItem.Text;
                    p.Item.PerfilUsuario.Direccion.Comuna = ddlComuna.SelectedItem.Text;
                    p.Item.PerfilUsuario.Direccion.Calle = "";
                    p.Item.PerfilUsuario.Direccion.Numero = 0;
                    p.Item.PerfilUsuario.Empresa.Logo = "Logo";
                    p.Item.PerfilUsuario.Persona.Rut = txtRutPersona.Text;
                    p.Item.PerfilUsuario.Persona.Nombre = txtNombrePersona.Text;
                    p.Item.PerfilUsuario.Persona.Apellido = txtApellidoPersona.Text;
                    p.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    p.Item.PerfilUsuario.Persona.Email = txtMailPersona.Text;
                    p.Item.PerfilUsuario.Persona.Telefono = txtTelPersona.Text;
                    p.Item.PerfilUsuario.Usuario.Clave = txtClave.Text;
                    p.Retorno.Token = Session["TokenUsuario"].ToString();
                    p = x.PerfilUsuarioProveedorActualizar(p);
                    break;
                default:
                    break;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioAdministrador a = new ContenedorPerfilUsuarioAdministrador();

            //a.Item.Persona.Rut = TextBox1.Text;
            //a.Item.Persona.Nombre = TextBox2.Text;
            //a.Item.Persona.Apellido = TextBox3.Text;
            //a.Item.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
            //a.Item.Persona.Email = TextBox5.Text;
            //a.Item.Persona.Telefono = TextBox6.Text;
            //a.Item.Usuario.Clave = TextBox14.Text;
            a.Item.Usuario.Nombre = txtUsuario.Text;
            a.Retorno.Token = Session["TokenUsuario"].ToString();

            x.PerfilUsuarioAdministradorEliminar(a);
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
                        ////
                    }
                    else {
                        LimpiarControles();
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
                        ////
                    }
                    else {
                        LimpiarControles();
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
                        LimpiarControles();
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
                        LimpiarControles();
                    }
                    break;
                default:
                    LimpiarControles();
                    break;
            }
        }

        private void LimpiarControles()
        {
            ddlRutPerfil.Items.Clear();
            ddlRutPerfil.Items.Add(new ListItem("No Existe", ""));
            ddlRutPerfil.DataBind();
            ddlRutPerfil.SelectedIndex = 0;
            //////////////
            ddlRutPerfil.Enabled = false;
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
                    LimpiarControles();
                    break;
            }
        }
    }
}