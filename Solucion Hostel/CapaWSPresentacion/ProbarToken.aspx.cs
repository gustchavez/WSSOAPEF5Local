using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion
{
    public partial class ProbarToken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtArmarToken_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            //string variable = x.GenerarToken(txtUsuario.Text, txtClave.Text);

            //txtToken.Text = variable;
            //Session["Token"] = variable;
        }

        protected void txtValidarToken_Click(object sender, EventArgs e)
        {
            //WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            
            //chkValido.Checked = x.ValidarToken(Session["Token"].ToString());
        }
    }
}