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
            try
            {
                string Perfil = Session["PerfilUsuario"].ToString();

                if (Perfil.Equals("Administrador"))
                {
                    RescatarDatos();
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
        
        private void RescatarDatos()
        {

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            //Recuperar datos de proveedores
            ContenedorPerfilUsuarioProveedores n = new ContenedorPerfilUsuarioProveedores();
            n = x.PerfilUsuarioProveedorRescatar(Session["TokenUsuario"].ToString());
            var proveedores = (from prov in n.Lista
                               select new
                               {
                                   Rut = prov.Proveedor.Rut,
                                   RazonSocial = prov.PerfilUsuario.Empresa.RazonSocial
                               }
                            ).ToList();

            DropDownList1.DataSource = null;
            DropDownList1.DataSource = proveedores;
            DropDownList1.DataValueField = "Rut";
            DropDownList1.DataTextField = "RazonSocial";
            DropDownList1.DataBind();
            

        }
        protected void generarListaFacturas(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            ContenedorFacturasPedidoCompleta n = new ContenedorFacturasPedidoCompleta();

            n = x.FacturaPedidoCompletaRescatar(Session["TokenUsuario"].ToString());

            String empresa = DropDownList1.SelectedValue;

            var facturas = (from l in n.Lista
                            where l.OPRelacionada.RutProveedor == empresa
                            select new
                            {
                                Rut = l.OPRelacionada.RutProveedor,
                                NroFactura = l.Cabecera.Numero,
                                FecFactura = l.Cabecera.Fecha,
                                ValorBruto = l.Cabecera.ValorBruto,
                                ValorIva = l.Cabecera.ValorIva,
                                ValorNeto = l.Cabecera.ValorNeto,
                                MedioPago = l.Pago.MedioPago,
                                NroOrdReserva = l.OPRelacionada.Numero
                            }
                            ).ToList();

            GridView1.DataSource = null;
            GridView1.DataSource = facturas;
            GridView1.DataBind();
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
            String strPdfPath = @"C:\Hostal_Web\perfilProveedor\Facturas\prueba.pdf";

            //Aqui va el titulo de la factura <-------------------------------------------
            string strHeader = " FACTURA ELECTRONICA ";

            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            // Insertar Imagen
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:/Users/portafolio/Documents/WSSOAPEF5Local/WSSOAPEF5Local/Solucion Hostel/CapaWSPresentacion/images/svg pegado 191_poster_.png");
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_RIGHT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            // Insertamos la imagen en el documento
            document.Add(imagen);

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.RED);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_LEFT;
            prgHeading.Add(new Chunk("\n RUT:xxxxxxxx", fntHead));
            prgHeading.Add(new Chunk("\n "+strHeader.ToUpper(), fntHead));
            prgHeading.Add(new Chunk("\n N° xxxxxxxxx", fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 12, 1, iTextSharp.text.BaseColor.BLACK);
            prgAuthor.Alignment = Element.ALIGN_RIGHT; // alineacion del texto (derecha) <-------------------------------------------
            //prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
            //prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            //document.Add(prgAuthor);

            //Add a line seperation
            Paragraph pr = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(pr);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Datos
            Paragraph datos = new Paragraph();
            BaseFont btndatos = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntdatos = new Font(btnAuthor, 16, 1);
            datos.Alignment = Element.ALIGN_LEFT; // alineacion del texto (izquierda) <-------------------------------------------
            //prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
            datos.Add(new Chunk("\nFecha : " + DateTime.Now.ToShortDateString(), fntAuthor));
            datos.Add(new Chunk("\nSeñores(as) : Cochys Loves" , fntAuthor));
            datos.Add(new Chunk("\nDireccion : xxxxxxxxxx", fntAuthor));
            datos.Add(new Chunk("\nRut : xxxxxxxx", fntAuthor));
            document.Add(datos);


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
            cell.BackgroundColor = iTextSharp.text.BaseColor.BLACK;
            cell.AddElement(new Chunk("Cantidad", fntColumnHeader));
            cell2.BackgroundColor = iTextSharp.text.BaseColor.BLACK;
            cell2.AddElement(new Chunk("Detalle", fntColumnHeader));
            cell3.BackgroundColor = iTextSharp.text.BaseColor.BLACK;
            cell3.AddElement(new Chunk("Total", fntColumnHeader));
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            RescatarDatos();
        }
    }
}