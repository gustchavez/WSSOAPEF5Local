using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminGestionAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private void RescatarDatosProveedor()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            ContenedorPerfilUsuarioProveedor cprove = new ContenedorPerfilUsuarioProveedor();
            
            //DropDownList2.Items.Add();
        }
        private void RescatarDatosCliente()
        {
            
        }
        private void RescatarDatosEmpleado()
        {
           
        }
    }
}