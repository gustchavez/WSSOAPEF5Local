using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class np_proveedor_crear : System.Web.UI.Page
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioProveedor n = new ContenedorPerfilUsuarioProveedor();

            n.Item.Proveedor.Rut = txtRutEmpresa.Text;
            n.Item.PerfilUsuario.Empresa.RazonSocial = txtRazonSocial.Text;
            n.Item.PerfilUsuario.Empresa.Rubro = txtGiro.Text;
            n.Item.PerfilUsuario.Empresa.Email = txtCorreoElectronico.Text;
            n.Item.PerfilUsuario.Empresa.Telefono = txtTelefonoEmpresa.Text;
            n.Item.PerfilUsuario.Direccion.CodPais = 56;
            n.Item.PerfilUsuario.Direccion.CodPostal = txtCodigoPostal.Text;
            n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.Text;
            n.Item.PerfilUsuario.Direccion.Comuna = txtComuna.Text;
            n.Item.PerfilUsuario.Direccion.Calle = txtCalle.Text;
            n.Item.PerfilUsuario.Direccion.Numero = int.Parse(txtNumero.Text);
            n.Item.PerfilUsuario.Empresa.Logo = txtLogo.Text;
            n.Item.PerfilUsuario.Persona.Rut = txtRutEmpleado.Text;
            n.Item.PerfilUsuario.Persona.Nombre = txtNombreEmpleado.Text;
            n.Item.PerfilUsuario.Persona.Apellido = txtxApellidoEmpleado.Text;
            n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            n.Item.PerfilUsuario.Persona.Email = txtCorreoEmpleado.Text;
            n.Item.PerfilUsuario.Persona.Telefono = txtTelefonoEmpleado.Text;
            n.Item.PerfilUsuario.Usuario.Clave = txtConstrasena.Text;
            n.Retorno.Token = Session["TokenUsuario"].ToString();

            n = x.PerfilUsuarioProveedorCrear(n);

            txtCodigoRetorno.Text = n.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = n.Retorno.Glosa;
        }
    }
}