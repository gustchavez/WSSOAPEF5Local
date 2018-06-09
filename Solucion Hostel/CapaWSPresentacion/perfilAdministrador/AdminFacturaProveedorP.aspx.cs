using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminFacturaProveedorP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void RescatarDatos()
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            //Recuperar datos de provisiones
            ContenedorProvisiones m = new ContenedorProvisiones();
            m = x.ProvisionRescatar(Session["TokenUsuario"].ToString());

            //Recuperar datos de proveedores
            ContenedorPerfilUsuarioProveedores n = new ContenedorPerfilUsuarioProveedores();
            n = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());

            var proveedores = (from prvi in m.Lista
                               join prov in n.Lista on prvi.RutProveedor equals prov.Proveedor.Rut
                               orderby prov.PerfilUsuario.Empresa.RazonSocial
                               select new
                               {
                                   Rut = prov.Proveedor.Rut,
                                   RazonSocial = prov.PerfilUsuario.Empresa.RazonSocial
                               }
                              ).Distinct().ToList();

            DropDownList1.DataSource = null;
            DropDownList1.DataSource = proveedores;
            DropDownList1.DataValueField = "Rut";
            DropDownList1.DataTextField = "RazonSocial";
            DropDownList1.DataBind();

            //guardar los valores
            Session["TemporalProvision"] = m.Lista;
            Session["TemporalProveedor"] = n.Lista;
        }
        protected void generarPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Prueba.pdf", FileMode.Create));
            doc.Open();
            Paragraph texto = new Paragraph(" Texto de prueba ");
            doc.Add(texto);
            doc.Close(); 
        }
    }
}