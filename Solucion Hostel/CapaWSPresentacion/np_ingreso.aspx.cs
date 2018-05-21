using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class np_ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Sesion nLogin = new Sesion();

            nLogin.Usuario = txtNombreUsuario.Text;
            nLogin.Clave = txtClaveUsuario.Text;

            nLogin = x.ValidarLogin(txtNombreUsuario.Text, txtClaveUsuario.Text);

            txtPerfilUsuario.Text = nLogin.Perfil;
            txtNombrePersona.Text = nLogin.Nombre;
            txtApellidoPersona.Text = nLogin.Apellido;
            txtCodigoRetorno.Text = nLogin.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = nLogin.Retorno.Glosa;

            if (nLogin.Retorno.Codigo == 0)
            {
                Session["TokenUsuario"] = nLogin.Retorno.Token;
                Session["NombreUsuario"] = nLogin.Usuario;
                Session["PerfilUsuario"] = nLogin.Perfil;
                Response.Redirect("Index.aspx");
            }
            else
            {
                Session["TokenUsuario"] = null;
                Session["NombreUsuario"] = null;
                Session["PerfilUsuario"] = null;
            }
        }
    }
}