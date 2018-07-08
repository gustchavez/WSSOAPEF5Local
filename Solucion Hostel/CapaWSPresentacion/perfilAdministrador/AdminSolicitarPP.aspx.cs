using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminSolicitarPP : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            validarText();
        }

        private bool validarText()
        {
            bool vari = true;
            if (int.Parse(TextBox1.Text)<0 || TextBox1.Text == "" || TextBox1.Text ==null)
            {
                RequiredFieldValidator3.Visible = true;
                vari = false;
                TextBox1.Text = "0";
            }
            else
            {
                RequiredFieldValidator3.Visible = false;
            }
            return vari;
        }
    }
}