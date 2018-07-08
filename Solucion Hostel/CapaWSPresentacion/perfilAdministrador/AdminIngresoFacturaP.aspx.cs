using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminIngresoFacturaP : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        private bool validarText()
        {
            bool varia = true;
            if (TextBox3.Text == null || TextBox3.Text =="" || int.Parse(TextBox3.Text)<0)
            {
                TextBox3.Text = "0";
                RequiredFieldValidator3.Visible = true;
                varia = false;
            }
            else
            {
                RequiredFieldValidator3.Visible = false;
            }
            if (TextBox4.Text == null || TextBox4.Text == "" || int.Parse(TextBox4.Text) < 0)
            {
                TextBox4.Text = "0";
                RequiredFieldValidator4.Visible = true;
                varia = false;
            }
            else
            {
                RequiredFieldValidator4.Visible = false;
            }
            return varia;
        }
    }
}