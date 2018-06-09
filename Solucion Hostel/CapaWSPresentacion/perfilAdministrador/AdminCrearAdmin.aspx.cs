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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            int perfil = DropDownList1.SelectedIndex;
            TextBox7.Text = txtGiro.SelectedItem.Text;
            switch (perfil)
            {
                case 1:
                    //Admin
                    /*
                    ContenedorPerfilAdmin a = new ContenedorPerfilAdmin();
                    a.Item.PerfilUsuario.Persona.Rut = TextBox1.Text;
                    a.Item.PerfilUsuario.Persona.Nombre = TextBox2.Text;
                    a.Item.PerfilUsuario.Persona.Apellido = TextBox3.Text;
                    a.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
                    a.Item.PerfilUsuario.Persona.Email = TextBox5.Text;
                    a.Item.PerfilUsuario.Persona.Telefono = TextBox6.Text;
                    a.Item.PerfilUsuario.Usuario.Clave = TextBox14.Text;
                    a.Retorno.Token = null; //Session["TokenUsuario"].ToString();
                    a = x.PerfilUsuarioClienteCrear(n);
                    */
                    break;
                case 2:
                    //Empleado
                    /*
                    ContenedorPerfilEmpleado e = new ContenedorPerfilEmpleado();
                    e.Item.PerfilUsuario.Persona.Rut = TextBox1.Text;
                    e.Item.PerfilUsuario.Persona.Nombre = TextBox2.Text;
                    e.Item.PerfilUsuario.Persona.Apellido = TextBox3.Text;
                    e.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(TextBox4.Text);
                    e.Item.PerfilUsuario.Persona.Email = TextBox5.Text;
                    e.Item.PerfilUsuario.Persona.Telefono = TextBox6.Text;
                    e.Item.PerfilUsuario.Usuario.Clave = TextBox14.Text;
                    e.Retorno.Token = null; //Session["TokenUsuario"].ToString();
                    e = x.PerfilUsuarioClienteCrear(n);
                    */
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
                    n.Retorno.Token = null; //Session["TokenUsuario"].ToString();
                    n = x.PerfilUsuarioClienteCrear(n);
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
                    p.Retorno.Token = null; //Session["TokenUsuario"].ToString();                    
                    break;
                default:
                    break;
            }

        }
    }
}