using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class FacturaCompraCompleta
    {
        public Factura Cabecera { get; set; }
        public Pago Pago { get; set; }
        public OrdenCompra OCRelacionada { get; set; }

        public FacturaCompraCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Cabecera      = new Factura();
            this.Pago          = new Pago();
            this.OCRelacionada = new OrdenCompra();
        }
    }
}
