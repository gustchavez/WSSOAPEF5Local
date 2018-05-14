using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaObjeto;

namespace CapaWSPresentacion
{
    public partial class scrud_producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Producto nProducto = new Producto();

            nProducto.Item.Descripcion = txtDescripcion.Text;
            nProducto.Item.Precio = decimal.Parse(txtPrecio.Text);
            nProducto.Item.Stock = decimal.Parse(txtStock.Text);
            nProducto.Item.StockCritico = decimal.Parse(txtStockCritico.Text);

            x.ProductoCrear(nProducto);
            
            txtCodigoRetorno.Text = nProducto.Retorno.Codigo.ToString();
            txtGlosaRetorno.Text = nProducto.Retorno.Glosa;

        }
    }
}