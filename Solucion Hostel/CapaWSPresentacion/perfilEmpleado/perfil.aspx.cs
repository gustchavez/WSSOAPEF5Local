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
            Sesion SesionUsuario = (Sesion)Session["SesionUsuario"];

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorPerfilUsuarioEmpleados n = new ContenedorPerfilUsuarioEmpleados();

            n = x.PerfilUsuarioEmpleadoRescatar(Session["TokenUsuario"].ToString());
            

            var empleado = n.Lista.Where(p => p.Usuario.Nombre == SesionUsuario.Usuario).SingleOrDefault();

            if (empleado != null)
            {
                txtRut.Text = empleado.Persona.Rut;
                txtNombre.Text = empleado.Persona.Nombre;
                txtApellido.Text = empleado.Persona.Apellido;
                txtCorreoElectronico.Text = empleado.Persona.Email;
                txtFechaNacimiento.Text = empleado.Persona.FechaNacimiento.ToString("yyyy-MM-dd");
                txtTelefono.Text = empleado.Persona.Telefono;
                txtUsuario.Text = empleado.Usuario.Nombre;
                txtContraseña.Text = empleado.Usuario.Clave;

                Session["SesionPerfilUsuarioEmpleado"] = empleado;
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
                
                n.Retorno.Token = Session["TokenUsuario"].ToString();
                                
                n.Item.Persona.Rut = txtRut.Text;
                n.Item.Persona.Nombre = txtNombre.Text;
                n.Item.Persona.Apellido = txtApellido.Text;
                n.Item.Persona.Email = txtCorreoElectronico.Text;
                n.Item.Persona.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                n.Item.Persona.Telefono = txtTelefono.Text;
                n.Item.Usuario.Clave = txtContraseña.Text;

                n = x.PerfilUsuarioEmpleadoActualizar(n);

                if (n.Retorno.Codigo == 0)
                {
                    //correcto
                }
            }

        }
    }
}