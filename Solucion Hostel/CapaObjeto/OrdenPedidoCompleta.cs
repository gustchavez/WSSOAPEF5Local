using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class OrdenPedidoCompleta
    {
        public OrdenPedido Cabecera { get; set; }
        public List<OrdenPedidoDetalle> ListaDetalle { get; set; }

        public OrdenPedidoCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Cabecera = new OrdenPedido();
            this.ListaDetalle = new List<OrdenPedidoDetalle>();
        }
    }
}
