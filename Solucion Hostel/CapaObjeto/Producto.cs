using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Producto
    {
        public decimal Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public decimal StockCritico { get; set; }

        public Producto()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = decimal.MinValue;
            this.Descripcion = string.Empty;
            this.Precio = decimal.MinValue;
            this.Stock = decimal.MinValue;
            this.StockCritico = decimal.MinValue;
        }
    }
}
