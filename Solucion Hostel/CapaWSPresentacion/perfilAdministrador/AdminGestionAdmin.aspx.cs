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
            PerfilUsuarioProveedor a = new PerfilUsuarioProveedor();
            a = x.PerfilUsuarioProveedorBuscarPorRut(rutUsuario, token);
            txtRutEmpresa.Text = a.Proveedor.Rut;
            txtRazonSocial.Text = a.PerfilUsuario.Empresa.RazonSocial;
            ddlGiro.SelectedItem.Text = a.PerfilUsuario.Empresa.Rubro;
            txtMailEmpresa.Text = a.PerfilUsuario.Empresa.Email;
            txtTelEmpresa.Text = a.PerfilUsuario.Empresa.Telefono;
            //a.PerfilUsuario.Direccion.CodPais = 56;
            //a.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
            ddlNombreCiudad.SelectedItem.Text = a.PerfilUsuario.Direccion.NombreCiudad;
            ddlComuna.SelectedItem.Text = a.PerfilUsuario.Direccion.Comuna;
            //a.PerfilUsuario.Direccion.Calle = "";
            //a.PerfilUsuario.Direccion.Numero = 0;
            //a.PerfilUsuario.Empresa.Logo = "Logo";
            txtRutPersona.Text = a.PerfilUsuario.Persona.Rut;
            txtNombrePersona.Text = a.PerfilUsuario.Persona.Nombre;
            txtApellidoPersona.Text = a.PerfilUsuario.Persona.Apellido;
            txtFecNacPersona.Text = a.PerfilUsuario.Persona.FechaNacimiento.ToString();
            txtMailPersona.Text = a.PerfilUsuario.Persona.Email;
            txtTelPersona.Text = a.PerfilUsuario.Persona.Telefono;
            txtClave.Text = a.PerfilUsuario.Usuario.Clave;
        }
        private void RescatarDatosCliente()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioCliente a = new PerfilUsuarioCliente();
            a = x.PerfilUsuarioClienteBuscarPorRut(rutUsuario, token);
            txtRutEmpresa.Text = a.Cliente.Rut;
            txtRazonSocial.Text = a.PerfilUsuario.Empresa.RazonSocial;
            ddlGiro.SelectedItem.Text = a.PerfilUsuario.Empresa.Rubro;
            txtMailEmpresa.Text = a.PerfilUsuario.Empresa.Email;
            txtTelEmpresa.Text = a.PerfilUsuario.Empresa.Telefono;
            //a.PerfilUsuario.Direccion.CodPais = 56;
            //a.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
            ddlNombreCiudad.SelectedItem.Text = a.PerfilUsuario.Direccion.NombreCiudad;
            ddlComuna.SelectedItem.Text = a.PerfilUsuario.Direccion.Comuna;
            //a.PerfilUsuario.Direccion.Calle = "";
            //a.PerfilUsuario.Direccion.Numero = 0;
            //a.PerfilUsuario.Empresa.Logo = "Logo";
            txtRutPersona.Text = a.PerfilUsuario.Persona.Rut;
            txtNombrePersona.Text = a.PerfilUsuario.Persona.Nombre;
            txtApellidoPersona.Text = a.PerfilUsuario.Persona.Apellido;
            txtFecNacPersona.Text = a.PerfilUsuario.Persona.FechaNacimiento.ToString();
            txtMailPersona.Text = a.PerfilUsuario.Persona.Email;
            txtTelPersona.Text = a.PerfilUsuario.Persona.Telefono;
            txtClave.Text = a.PerfilUsuario.Usuario.Clave;
        }
        private void RescatarDatosEmpleado()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioEmpleado a = new PerfilUsuarioEmpleado();
            //a = x.PerfilUsuarioEmpleadoBuscarPorRut(rutUsuario, token);
            //TextBox1.Text = a.Persona.Rut;
            //TextBox2.Text = a.Persona.Nombre;
            //TextBox3.Text = a.Persona.Apellido;
            ////TextBox4.Text = a.Persona.FechaNacimiento.ToString();
            //TextBox5.Text = a.Persona.Email;
            //TextBox6.Text = a.Persona.Telefono;
            //TextBox14.Text = a.Usuario.Clave;
            //TextBox13.Text = a.Usuario.Nombre;
        }
        private void RescatarDatosAdministrador()
        {
            String rutUsuario = ddlRutPerfil.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioAdministrador a = new PerfilUsuarioAdministrador();
            a = x.PerfilUsuarioAdministradorBuscarPorRut(rutUsuario,token);
            txtRutPersona.Text = a.Persona.Rut;
            txtNombrePersona.Text = a.Persona.Nombre;
            txtApellidoPersona.Text = a.Persona.Apellido;
            //TextBox4.Text = a.Persona.FechaNacimiento.ToString();
            txtMailPersona.Text = a.Persona.Email;
            txtTelPersona.Text = a.Persona.Telefono;
            txtClave.Text = a.Usuario.Clave;
            txtUsuario.Text = a.Usuario.Nombre;
        }

        protected void Button1_Click(object sender, EventArgs e)
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
    }
}