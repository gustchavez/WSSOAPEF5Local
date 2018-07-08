using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilEmpleado
{
    public partial class perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Empleado") || Perfil.Equals("Administrador"))
                {
                    if (!IsPostBack)
                    {
                        RescatarDatos();
                    }
                }
                else
                {
                    Session["TokenUsuario"] = null;
                    Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
                }
            }
            catch (Exception ex)
            {
                Session["TokenUsuario"] = null;
                Response.Redirect("/PaginaComercial/perfilIngreso.aspx");
            }
        }

        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];
            //
            ContenedorPerfilUsuarioEmpleado n = new ContenedorPerfilUsuarioEmpleado();
            n = x.PerfilUsuarioEmpleadoRescatarXRut(SesionUsuario.RutPersona, Session["TokenUsuario"].ToString());            

            if (n.Item != null)
            {
                txtRut.Text               = n.Item.Persona.Rut;
                txtNombre.Text            = n.Item.Persona.Nombre;
                txtApellido.Text          = n.Item.Persona.Apellido;
                txtCorreoElectronico.Text = n.Item.Persona.Email;
                txtFechaNacimiento.Text   = n.Item.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtTelefono.Text          = n.Item.Persona.Telefono;
                txtUsuario.Text           = n.Item.Usuario.Nombre;
                txtContraseña.Text        = n.Item.Usuario.Clave;

                Session["SesionPerfilUsuarioEmpleado"] = n.Item;
            } else {
                Session["SesionPerfilUsuarioEmpleado"] = null;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            PerfilUsuarioEmpleado m = (PerfilUsuarioEmpleado)Session["SesionPerfilUsuarioEmpleado"];

            if (m != null)
            {
                WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

                ContenedorPerfilUsuarioEmpleado n = new ContenedorPerfilUsuarioEmpleado();
                n.Item          = m;
                //
                n.Retorno.Token                = Session["TokenUsuario"].ToString();
                n.Item.Persona.Nombre          = txtNombre.Text;
                n.Item.Persona.Apellido        = txtApellido.Text;
                n.Item.Persona.Email           = txtCorreoElectronico.Text;
                n.Item.Persona.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                n.Item.Persona.Telefono        = txtTelefono.Text;
                n.Item.Usuario.Clave           = txtContraseña.Text;
                //
                n = x.PerfilUsuarioEmpleadoActualizar(n);

                if (n.Retorno.Codigo == 0)
                {
                    //correcto
                }
            }

        }
        protected void validaFecha(object sender, EventArgs e)
        {
            if (txtFechaNacimiento.Text == null)
            {
                RequiredFieldValidator5.IsValid = true;
            }
            else
            {
                RequiredFieldValidator5.IsValid = false;
            }
        }


    }
}