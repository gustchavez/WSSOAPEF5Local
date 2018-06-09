using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class FacturaPedidoCompleta
    {
        public Factura Cabecera { get; set; }
        public Pago Pago { get; set; }
        public OrdenPedido OPRelacionada { get; set; }

        public FacturaPedidoCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Cabecera = new Factura();
            this.Pago = new Pago();
            this.OPRelacionada = new OrdenPedido();
        }
    }
}
