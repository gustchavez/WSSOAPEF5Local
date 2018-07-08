using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminCrearAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Administrador"))
                {
                    Session["PerfilUsuario"] = Perfil;
                    RescatarDatos();
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
        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorCiudades n = new ContenedorCiudades();

            n = x.CiudadRescatar(Session["TokenUsuario"].ToString());

            ddlNombreCiudad.DataSource = null;
            ddlNombreCiudad.DataSource = n.Lista.Where(p => p.CodPais == 56);
            ddlNombreCiudad.DataValueField = "Nombre";
            ddlNombreCiudad.DataTextField = "Nombre";
            ddlNombreCiudad.DataBind();
        }
        private bool validarTexto()
        {
            bool var = true;
            if (txtRutEmpresa.Text==null || txtRutEmpresa.Text == "")
            {
                TextBox1.Visible = true;
                var = false;
            }
            else
            {
                TextBox1.Visible = false;
            }
            if (txtRazonSocial.Text == null || txtRazonSocial.Text == "")
            {
                TextBox2.Visible = true;
                var = false;
            }
            else
            {
                TextBox2.Visible = false;
            }
            if (ddlGiro.Text == null || ddlGiro.Text == "1")
            {
                TextBox3.Visible = true;
                var = false;
            }
            else
            {
                TextBox3.Visible = false;
            }
            if (txtMailEmpresa.Text == null || txtMailEmpresa.Text == "")
            {
                TextBox4.Visible = true;
                var = false;
            }
            else
            {
                TextBox4.Visible = false;
            }
            if (txtTelEmpresa.Text == null || txtTelEmpresa.Text == "")
            {
                TextBox5.Visible = true;
                var = false;
            }
            else
            {
                TextBox5.Visible = false;
            }
            if (ddlNombreCiudad.Text == null || ddlNombreCiudad.Text == "")
            {
                TextBox6.Visible = true;
                var = false;
            }
            else
            {
                TextBox6.Visible = false;
            }
            if (ddlComuna.Text == null || ddlComuna.Text == "")
            {
                TextBox7.Visible = true;
                var = false;
            }
            else
            {
                TextBox7.Visible = false;
            }
            if (txtDirEmp.Text == null || txtDirEmp.Text.Length==0)
            {
                TextBox8.Visible = true;
                var = false;
            }
            else
            {
                TextBox8.Visible = false;
            }
            return var;

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            int perfil = ddlTipoPerfil.SelectedIndex;
            //
            switch (perfil)
            {
                case 1:
                    //Admin
                    ContenedorPerfilUsuarioAdministrador a = new ContenedorPerfilUsuarioAdministrador();
                    a.Item.Persona.Rut              = txtRutPersona.Text;
                    a.Item.Persona.Nombre           = txtNombrePersona.Text;
                    a.Item.Persona.Apellido         = txtApellidoPersona.Text;
                    a.Item.Persona.FechaNacimiento  = DateTime.Parse(txtFecNacPersona.Text);
                    a.Item.Persona.Email            = txtMailPersona.Text;
                    a.Item.Persona.Telefono         = txtTelPersona.Text;
                    a.Item.Usuario.Nombre           = txtUsuario.Text;
                    a.Item.Usuario.Clave            = txtClave.Text;
                    a.Retorno.Token                 = Session["TokenUsuario"].ToString();
                    a                               = x.PerfilUsuarioAdministradorCrear(a);
                    //
                    if (a.Retorno.Codigo == 0)
                    {
                        //realizado correctamente
                        LimpiarControles();
                    }
                    break;
                case 2:
                    //Empleado
                    ContenedorPerfilUsuarioEmpleado em = new ContenedorPerfilUsuarioEmpleado();
                    em.Item.Persona.Rut             = txtRutPersona.Text;
                    em.Item.Persona.Nombre          = txtNombrePersona.Text;
                    em.Item.Persona.Apellido        = txtApellidoPersona.Text;
                    em.Item.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                    em.Item.Persona.Email           = txtMailPersona.Text;
                    em.Item.Persona.Telefono        = txtTelPersona.Text;
                    em.Item.Usuario.Nombre          = txtUsuario.Text;
                    em.Item.Usuario.Clave           = txtClave.Text;
                    em.Retorno.Token                = Session["TokenUsuario"].ToString();
                    em                              = x.PerfilUsuarioEmpleadoCrear(em);
                    //
                    if (em.Retorno.Codigo == 0)
                    {
                        //realizado correctamente
                        LimpiarControles();
                    }
                    break;
                case 3:
                    //Cliente  
                    if (validarTexto())
                    {
                        ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();

                        n.Item.Cliente.Rut = txtRutEmpresa.Text;
                        n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
                        n.Item.PerfilUsuario.Empresa.Rubro = ddlGiro.SelectedItem.Value;
                        n.Item.PerfilUsuario.Empresa.Email = txtMailEmpresa.Text;
                        n.Item.PerfilUsuario.Empresa.Telefono = txtTelEmpresa.Text;
                        n.Item.PerfilUsuario.Empresa.Logo = "Logo";
                        n.Item.PerfilUsuario.Persona.Rut = txtRutPersona.Text;
                        n.Item.PerfilUsuario.Persona.Nombre = txtNombrePersona.Text;
                        n.Item.PerfilUsuario.Persona.Apellido = txtApellidoPersona.Text;
                        n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                        n.Item.PerfilUsuario.Persona.Email = txtMailPersona.Text;
                        n.Item.PerfilUsuario.Persona.Telefono = txtTelPersona.Text;
                        n.Item.PerfilUsuario.Direccion.Calle = txtDirEmp.Text;
                        n.Item.PerfilUsuario.Direccion.Numero = 0;
                        n.Item.PerfilUsuario.Direccion.Comuna = ddlComuna.SelectedItem.Value;
                        n.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                        n.Item.PerfilUsuario.Direccion.NombreCiudad = ddlNombreCiudad.SelectedItem.Value;
                        n.Item.PerfilUsuario.Direccion.CodPais = 56;
                        n.Item.PerfilUsuario.Usuario.Nombre = txtUsuario.Text;
                        n.Item.PerfilUsuario.Usuario.Clave = txtClave.Text;
                        n.Retorno.Token = Session["TokenUsuario"].ToString();
                        n = x.PerfilUsuarioClienteCrear(n);
                        //
                        if (n.Retorno.Codigo == 0)
                        {
                            //realizado correctamente
                            LimpiarControles();
                        }
                    }                        
                    break;
                case 4:
                    //Proveedor 
                    if (validarTexto())
                    {
                        ContenedorPerfilUsuarioProveedor p = new ContenedorPerfilUsuarioProveedor();

                        p.Item.Proveedor.Rut = txtRutEmpresa.Text;
                        p.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
                        p.Item.PerfilUsuario.Empresa.Rubro = ddlGiro.SelectedItem.Value;
                        p.Item.PerfilUsuario.Empresa.Email = txtMailEmpresa.Text;
                        p.Item.PerfilUsuario.Empresa.Telefono = txtTelEmpresa.Text;
                        p.Item.PerfilUsuario.Direccion.CodPais = 56;
                        p.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                        p.Item.PerfilUsuario.Direccion.NombreCiudad = ddlNombreCiudad.SelectedItem.Value;
                        p.Item.PerfilUsuario.Direccion.Comuna = ddlComuna.SelectedItem.Value;
                        p.Item.PerfilUsuario.Direccion.Calle = txtDirEmp.Text;
                        p.Item.PerfilUsuario.Direccion.Numero = 0;
                        p.Item.PerfilUsuario.Empresa.Logo = "Logo";
                        p.Item.PerfilUsuario.Persona.Rut = txtRutPersona.Text;
                        p.Item.PerfilUsuario.Persona.Nombre = txtNombrePersona.Text;
                        p.Item.PerfilUsuario.Persona.Apellido = txtApellidoPersona.Text;
                        p.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFecNacPersona.Text);
                        p.Item.PerfilUsuario.Persona.Email = txtMailPersona.Text;
                        p.Item.PerfilUsuario.Persona.Telefono = txtTelPersona.Text;
                        p.Item.PerfilUsuario.Usuario.Nombre = txtUsuario.Text;
                        p.Item.PerfilUsuario.Usuario.Clave = txtClave.Text;
                        p.Retorno.Token = Session["TokenUsuario"].ToString();
                        p = x.PerfilUsuarioProveedorCrear(p);
                        //
                        if (p.Retorno.Codigo == 0)
                        {
                            //realizado correctamente
                            LimpiarControles();
                        }
                    }
                    
                    break;
                default:
                    break;
            }
        }

        private void LimpiarControles()
        {
            txtApellidoPersona.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtDirEmp.Text = string.Empty;
            txtFecNacPersona.Text = string.Empty;
            txtMailEmpresa.Text = string.Empty;
            txtMailPersona.Text = string.Empty;
            txtNombrePersona.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtRutEmpresa.Text = string.Empty;
            txtRutPersona.Text = string.Empty;
            txtTelEmpresa.Text = string.Empty;
            txtTelPersona.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            //
            ddlComuna.SelectedIndex = 0;
            ddlGiro.SelectedIndex = 0;
            ddlNombreCiudad.SelectedIndex = 0;
            //
            ddlTipoPerfil.SelectedIndex = 0;
        }

        protected void ddlTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoPerfil.SelectedIndex == 3 || ddlTipoPerfil.SelectedIndex == 4)
            {
                HabilitarControlesEmpresa();
            } else {
                DeshabilitarControlesEmpresa();
            }
        }

        private void DeshabilitarControlesEmpresa()
        {
            txtDirEmp.Enabled       = false;
            txtMailEmpresa.Enabled  = false;
            txtRazonSocial.Enabled  = false;
            txtRutEmpresa.Enabled   = false;
            txtTelEmpresa.Enabled   = false;
            ddlComuna.Enabled       = false;
            ddlGiro.Enabled         = false;
            ddlNombreCiudad.Enabled = false;
        }

        private void HabilitarControlesEmpresa()
        {
            txtDirEmp.Enabled       = true;
            txtMailEmpresa.Enabled  = true;
            txtRazonSocial.Enabled  = true;
            txtRutEmpresa.Enabled   = true;
            txtTelEmpresa.Enabled   = true;
            ddlComuna.Enabled       = true;
            ddlGiro.Enabled         = true;
            ddlNombreCiudad.Enabled = true;
        }
    }
}