using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilProveedor
{
    public partial class AgregarProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado") || Perfil.Equals("Administrador"))
                {
                    //
                }
                else
                {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("np_ingreso.aspx");
                }
            }
            catch (Exception)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("np_ingreso.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioProveedor n = new ContenedorPerfilUsuarioProveedor();

            n.Item.Proveedor.Rut = txtRutEmpresa.Text;
            n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
            n.Item.PerfilUsuario.Empresa.Rubro = "Giro";
            n.Item.PerfilUsuario.Empresa.Email = txtCorreoElectronico.Text;
            n.Item.PerfilUsuario.Empresa.Telefono = txtTelefonoEmpresa.Text;
            n.Item.PerfilUsuario.Empresa.Rut = txtRutEmpresa.Text;
           n.Item.PerfilUsuario.Direccion.CodPais = 56;
            n.Item.PerfilUsuario.Direccion.CodPostal = "12";
            n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.Text;
            n.Item.PerfilUsuario.Direccion.Comuna = txtComuna.Text;
            n.Item.PerfilUsuario.Direccion.Calle = txtCalle.Text;
            n.Item.PerfilUsuario.Direccion.Numero = int.Parse("123");
            n.Item.PerfilUsuario.Empresa.Logo = "123";
            n.Item.PerfilUsuario.Persona.Rut = "123";
            n.Item.PerfilUsuario.Persona.Nombre = "123";
            n.Item.PerfilUsuario.Persona.Apellido = "123";
            n.Item.PerfilUsuario.Persona.FechaNacimiento =  DateTime.Now;
            n.Item.PerfilUsuario.Persona.Email = TextBox4.Text;
            n.Item.PerfilUsuario.Persona.Telefono = "123";
            n.Item.PerfilUsuario.Usuario.Clave = txtConstrasena.Text;
            n.Retorno.Token = Session["TokenUsuario"].ToString();

            n = x.PerfilUsuarioProveedorCrear(n);

            txtCodigoRetorno.Text = n.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = n.Retorno.Glosa;
        }
    }
}