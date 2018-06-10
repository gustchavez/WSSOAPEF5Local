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
            String rutUsuario = DropDownList2.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioProveedor a = new PerfilUsuarioProveedor();
            a = x.PerfilUsuarioProveedorBuscarPorRut(rutUsuario, token);
            TextBox7.Text = a.Proveedor.Rut;
            TextBox8.Text = a.PerfilUsuario.Empresa.RazonSocial;
            txtGiro.SelectedItem.Text = a.PerfilUsuario.Empresa.Rubro;
            TextBox9.Text = a.PerfilUsuario.Empresa.Email;
            TextBox10.Text = a.PerfilUsuario.Empresa.Telefono;
            //a.PerfilUsuario.Direccion.CodPais = 56;
            //a.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
            txtNombreCiudad.SelectedItem.Text = a.PerfilUsuario.Direccion.NombreCiudad;
            txtComuna.SelectedItem.Text = a.PerfilUsuario.Direccion.Comuna;
            //a.PerfilUsuario.Direccion.Calle = "";
            //a.PerfilUsuario.Direccion.Numero = 0;
            //a.PerfilUsuario.Empresa.Logo = "Logo";
            TextBox1.Text = a.PerfilUsuario.Persona.Rut;
            TextBox2.Text = a.PerfilUsuario.Persona.Nombre;
            TextBox3.Text = a.PerfilUsuario.Persona.Apellido;
            TextBox4.Text = a.PerfilUsuario.Persona.FechaNacimiento.ToString();
            TextBox5.Text = a.PerfilUsuario.Persona.Email;
            TextBox6.Text = a.PerfilUsuario.Persona.Telefono;
            TextBox14.Text = a.PerfilUsuario.Usuario.Clave;
        }
        private void RescatarDatosCliente()
        {
            String rutUsuario = DropDownList2.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioCliente a = new PerfilUsuarioCliente();
            a = x.PerfilUsuarioClienteBuscarPorRut(rutUsuario, token);
            TextBox7.Text = a.Cliente.Rut;
            TextBox8.Text = a.PerfilUsuario.Empresa.RazonSocial;
            txtGiro.SelectedItem.Text = a.PerfilUsuario.Empresa.Rubro;
            TextBox9.Text = a.PerfilUsuario.Empresa.Email;
            TextBox10.Text = a.PerfilUsuario.Empresa.Telefono;
            //a.PerfilUsuario.Direccion.CodPais = 56;
            //a.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
            txtNombreCiudad.SelectedItem.Text = a.PerfilUsuario.Direccion.NombreCiudad;
            txtComuna.SelectedItem.Text = a.PerfilUsuario.Direccion.Comuna;
            //a.PerfilUsuario.Direccion.Calle = "";
            //a.PerfilUsuario.Direccion.Numero = 0;
            //a.PerfilUsuario.Empresa.Logo = "Logo";
            TextBox1.Text = a.PerfilUsuario.Persona.Rut;
            TextBox2.Text = a.PerfilUsuario.Persona.Nombre;
            TextBox3.Text = a.PerfilUsuario.Persona.Apellido;
            TextBox4.Text = a.PerfilUsuario.Persona.FechaNacimiento.ToString();
            TextBox5.Text = a.PerfilUsuario.Persona.Email;
            TextBox6.Text = a.PerfilUsuario.Persona.Telefono;
            TextBox14.Text = a.PerfilUsuario.Usuario.Clave;
        }
        private void RescatarDatosEmpleado()
        {
            String rutUsuario = DropDownList2.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioEmpleado a = new PerfilUsuarioEmpleado();
            a = x.PerfilUsuarioEmpleadoBuscarPorRut(rutUsuario, token);
            TextBox1.Text = a.Persona.Rut;
            TextBox2.Text = a.Persona.Nombre;
            TextBox3.Text = a.Persona.Apellido;
            //TextBox4.Text = a.Persona.FechaNacimiento.ToString();
            TextBox5.Text = a.Persona.Email;
            TextBox6.Text = a.Persona.Telefono;
            TextBox14.Text = a.Usuario.Clave;
            TextBox13.Text = a.Usuario.Nombre;
        }
        private void RescatarDatosAdministrador()
        {
            String rutUsuario = DropDownList2.SelectedValue;
            String token = Session["TokenUsuario"].ToString();
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            PerfilUsuarioAdministrador a = new PerfilUsuarioAdministrador();
            a = x.PerfilUsuarioAdministradorBuscarPorRut(rutUsuario,token);
            TextBox1.Text = a.Persona.Rut;
            TextBox2.Text = a.Persona.Nombre;
            TextBox3.Text = a.Persona.Apellido;
            //TextBox4.Text = a.Persona.FechaNacimiento.ToString();
            TextBox5.Text = a.Persona.Email;
            TextBox6.Text = a.Persona.Telefono;
            TextBox14.Text = a.Usuario.Clave;
            TextBox13.Text = a.Usuario.Nombre;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            int perfil = DropDownList1.SelectedIndex;
            //TextBox7.Text = txtGiro.SelectedItem.Text;
            switch (perfil)
            {
                case 1:
                    //Admin
                    ContenedorPerfilUsuarioAdministrador a = new ContenedorPerfilUsuarioAdministrador();
                    a.Item.Persona.Rut = TextBox1.Text;
                    a.Item.Persona.Nombre = TextBox2.Text;
                    a.Item.Persona.Apellido = TextBox3.Text;
                    a.Item.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
                    a.Item.Persona.Email = TextBox5.Text;
                    a.Item.Persona.Telefono = TextBox6.Text;
                    a.Item.Usuario.Clave = TextBox14.Text;
                    a.Retorno.Token = Session["TokenUsuario"].ToString();
                    a = x.PerfilUsuarioAdministradorActualizar(a);
                    break;
                case 2:
                    //Empleado
                    ContenedorPerfilUsuarioEmpleado em = new ContenedorPerfilUsuarioEmpleado();
                    em.Item.Persona.Rut = TextBox1.Text;
                    em.Item.Persona.Nombre = TextBox2.Text;
                    em.Item.Persona.Apellido = TextBox3.Text;
                    em.Item.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
                    em.Item.Persona.Email = TextBox5.Text;
                    em.Item.Persona.Telefono = TextBox6.Text;
                    em.Item.Usuario.Clave = TextBox14.Text;
                    em.Retorno.Token = Session["TokenUsuario"].ToString();
                    em = x.PerfilUsuarioEmpleadoActualizar(em);
                    break;
                case 3:
                    //Cliente      
                    ContenedorPerfilUsuarioCliente n = new ContenedorPerfilUsuarioCliente();

                    n.Item.Cliente.Rut = TextBox7.Text;
                    n.Item.PerfilUsuario.Empresa.RazonSocial = TextBox8.Text;
                    n.Item.PerfilUsuario.Empresa.Rubro = txtGiro.SelectedItem.Text;
                    n.Item.PerfilUsuario.Empresa.Email = TextBox9.Text;
                    n.Item.PerfilUsuario.Empresa.Telefono = TextBox10.Text;
                    n.Item.PerfilUsuario.Direccion.CodPais = 56;
                    n.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                    n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.SelectedItem.Text;
                    n.Item.PerfilUsuario.Direccion.Comuna = txtComuna.SelectedItem.Text;
                    n.Item.PerfilUsuario.Direccion.Calle = "";
                    n.Item.PerfilUsuario.Direccion.Numero = 0;
                    n.Item.PerfilUsuario.Empresa.Logo = "Logo";
                    n.Item.PerfilUsuario.Persona.Rut = TextBox1.Text;
                    n.Item.PerfilUsuario.Persona.Nombre = TextBox2.Text;
                    n.Item.PerfilUsuario.Persona.Apellido = TextBox3.Text;
                    n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
                    n.Item.PerfilUsuario.Persona.Email = TextBox5.Text;
                    n.Item.PerfilUsuario.Persona.Telefono = TextBox6.Text;
                    n.Item.PerfilUsuario.Usuario.Clave = TextBox14.Text;
                    n.Retorno.Token = Session["TokenUsuario"].ToString();
                    n = x.PerfilUsuarioClienteActualizar(n);
                    break;
                case 4:
                    //Proveedor

                    ContenedorPerfilUsuarioProveedor p = new ContenedorPerfilUsuarioProveedor();

                    p.Item.Proveedor.Rut = TextBox7.Text;
                    p.Item.PerfilUsuario.Empresa.RazonSocial = TextBox8.Text;
                    p.Item.PerfilUsuario.Empresa.Rubro = txtGiro.SelectedItem.Text;
                    p.Item.PerfilUsuario.Empresa.Email = TextBox9.Text;
                    p.Item.PerfilUsuario.Empresa.Telefono = TextBox10.Text;
                    p.Item.PerfilUsuario.Direccion.CodPais = 56;
                    p.Item.PerfilUsuario.Direccion.CodPostal = "Codigo postal";
                    p.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.SelectedItem.Text;
                    p.Item.PerfilUsuario.Direccion.Comuna = txtComuna.SelectedItem.Text;
                    p.Item.PerfilUsuario.Direccion.Calle = "";
                    p.Item.PerfilUsuario.Direccion.Numero = 0;
                    p.Item.PerfilUsuario.Empresa.Logo = "Logo";
                    p.Item.PerfilUsuario.Persona.Rut = TextBox1.Text;
                    p.Item.PerfilUsuario.Persona.Nombre = TextBox2.Text;
                    p.Item.PerfilUsuario.Persona.Apellido = TextBox3.Text;
                    p.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
                    p.Item.PerfilUsuario.Persona.Email = TextBox5.Text;
                    p.Item.PerfilUsuario.Persona.Telefono = TextBox6.Text;
                    p.Item.PerfilUsuario.Usuario.Clave = TextBox14.Text;
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
            a.Item.Usuario.Nombre = TextBox13.Text;
            a.Retorno.Token = Session["TokenUsuario"].ToString();

            x.PerfilUsuarioAdministradorEliminar(a);
        }
    }
}