using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace CapaWSPresentacion.perfilAdministrador
{
    public partial class AdminFacturaProveedorP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RescatarDatos();
        }
        /*
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
            //Informacion solo de prueba <-------------------------------------------
            List<Persona> dtblTable = new List<Persona>();
            Persona p = new Persona();
            p.Nombre = "mauro";
            p.Telefono = "1231231123";
            p.Apellido = "guaton";
            Persona p2 = new Persona();
            p2.Nombre = "mauro2";
            p2.Telefono = "1231231123--2";
            p2.Apellido = "guaton2";
            dtblTable.Add(p);
            dtblTable.Add(p2);

            //indicar Ruta en dode se generaran las facturas <-------------------------------------------
            //cambiar "prueba" por numero de factura o algo asi <-------------------------------------------
            String strPdfPath = @"C:\Users\Cochy\Desktop\prueba.pdf";

            //Aqui va el titulo de la factura <-------------------------------------------
            string strHeader = " Hostale ";

            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2);
            prgAuthor.Alignment = Element.ALIGN_RIGHT; // alineacion del texto (derecha) <-------------------------------------------
            prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph pr = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(pr);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write la table
            //Indicar las columnas que se utilizaran <-------------------------------------------
            PdfPTable table = new PdfPTable(3);
            //Table header
            //Nombrar columnas <-------------------------------------------
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, iTextSharp.text.BaseColor.WHITE);
            //crear columna <-------------------------------------------
            PdfPCell cell = new PdfPCell();
            PdfPCell cell2 = new PdfPCell();
            PdfPCell cell3 = new PdfPCell();
            cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
            cell.AddElement(new Chunk("nombre", fntColumnHeader));
            cell2.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
            cell2.AddElement(new Chunk("apellido", fntColumnHeader));
            cell3.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
            cell3.AddElement(new Chunk("nombre", fntColumnHeader));
            table.AddCell(cell);
            table.AddCell(cell2);
            table.AddCell(cell3);
            //table Data
            //Aqui hay que recorrer la tabla para añadirla al pdf <-------------------------------------------
            foreach (Persona pe in dtblTable)
            {
                table.AddCell(pe.Nombre);
                table.AddCell(pe.Apellido);
                table.AddCell(pe.Telefono);
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }
        */
    }
}