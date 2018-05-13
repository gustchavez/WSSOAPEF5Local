using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion
{
    public partial class crear_cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            PerfilCliente nCliente = new PerfilCliente();

            nCliente.RutEmpresa        = txtRutEmpresa.Text;
            nCliente.RazonSocial       = txtRazonSocial.Text;
            nCliente.Giro              = txtGiro.Text;
            nCliente.EmailEmpresa      = txtCorreoElectronico.Text;
            nCliente.TelefonoEmpresa   = txtTelefonoEmpresa.Text;
            nCliente.CodPais           = 56;
            nCliente.CodPostal         = txtCodigoPostal.Text;
            nCliente.NombreCiudad      = txtNombreCiudad.Text;
            nCliente.Comuna            = txtComuna.Text;
            nCliente.Calle             = txtCalle.Text;
            nCliente.Numero            = decimal.Parse(txtNumero.Text);
            nCliente.Logo              = txtLogo.Text;
            nCliente.RutPersona        = txtRutEmpleado.Text;
            nCliente.Nombre            = txtNombreEmpleado.Text;
            nCliente.Apellido          = txtxApellidoEmpleado.Text;
            nCliente.Nacimiento        = DateTime.Parse(txtFechaNacimiento.Text);
            nCliente.EmailPersona      = txtCorreoEmpleado.Text;
            nCliente.TelofonoPersona   = txtTelefonoEmpleado.Text;
            nCliente.Clave             = txtConstrasena.Text;

            nCliente = x.CrearCliente(nCliente);
            
            txtCodigoRetorno.Text = nCliente.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = nCliente.Retorno.Glosa;
        }
    }
}