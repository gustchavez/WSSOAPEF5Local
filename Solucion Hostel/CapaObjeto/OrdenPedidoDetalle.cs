using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class OrdenPedidoDetalle
    {
        public RegistroRecepcionPedido RegistroRecepcionPedido { get; set; }

        public OrdenPedidoDetalle()
        {
            Init();
        }

        private void Init()
        {
            this.RegistroRecepcionPedido = new RegistroRecepcionPedido();
        }
    }
}
