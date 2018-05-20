using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class empresaEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            //n.Item.PerfilUsuario.Direccion.CodPostal = txtCodigoPostal.Text;
            n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.Text;
            n.Item.PerfilUsuario.Direccion.Comuna = txtComuna.Text;
            n.Item.PerfilUsuario.Direccion.Calle = txtCalle.Text;
            n.Item.PerfilUsuario.Direccion.Numero = int.Parse(txtNumero.Text);
            //n.Item.PerfilUsuario.Empresa.Logo = txtLogo.Text;
            //n.Item.PerfilUsuario.Persona.Rut = txtRutEmpleado.Text;
            n.Item.PerfilUsuario.Persona.Nombre = txtNombreEmpleado.Text;
            //n.Item.PerfilUsuario.Persona.Apellido = txtxApellidoEmpleado.Text;
            //n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            //n.Item.PerfilUsuario.Persona.Email = txtCorreoEmpleado.Text;
            //n.Item.PerfilUsuario.Persona.Telefono = txtTelefonoEmpleado.Text;
            n.Item.PerfilUsuario.Usuario.Clave = txtConstrasena.Text;

            n = x.PerfilUsuarioProveedorCrear(n);

            //txtCodigoRetorno.Text = n.Retorno.Codigo.ToString();
            //txtGlosaRetorno.Text = n.Retorno.Glosa;
        }
    }
}