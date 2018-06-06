using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Provision
    {
        public string RutProveedor { get; set; }
        public int CodigoProducto { get; set; }
        public decimal Precio { get; set; }

        public Provision()
        {
            Init();
        }

        private void Init()
        {
            this.RutProveedor = string.Empty;
            this.CodigoProducto = int.MinValue;
            this.Precio = decimal.MinValue;

        }
    }
}
