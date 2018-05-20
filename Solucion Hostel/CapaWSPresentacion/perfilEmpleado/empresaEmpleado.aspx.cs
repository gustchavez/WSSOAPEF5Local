using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            n.Item.PerfilUsuario.Direccion.CodPostal = "00";
            n.Item.PerfilUsuario.Direccion.NombreCiudad = txtNombreCiudad.Text;
            n.Item.PerfilUsuario.Direccion.Comuna = txtComuna.Text;
            n.Item.PerfilUsuario.Direccion.Calle = txtCalle.Text;
            n.Item.PerfilUsuario.Direccion.Numero = int.Parse(txtNumero.Text);
            n.Item.PerfilUsuario.Empresa.Logo = "lala";
            n.Item.PerfilUsuario.Persona.Rut = "131313";
            n.Item.PerfilUsuario.Persona.Nombre = txtNombreEmpleado.Text;
            n.Item.PerfilUsuario.Persona.Apellido = "Empresa";
            n.Item.PerfilUsuario.Persona.FechaNacimiento = DateTime.Now;
            n.Item.PerfilUsuario.Persona.Email = "empresa@empresa.cl";
            n.Item.PerfilUsuario.Persona.Telefono = "5555555";
            n.Item.PerfilUsuario.Usuario.Clave = txtConstrasena.Text;

            n = x.PerfilUsuarioProveedorCrear(n);

            txtCodigoRetorno.Text = n.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = n.Retorno.Glosa;
        }
    }
}