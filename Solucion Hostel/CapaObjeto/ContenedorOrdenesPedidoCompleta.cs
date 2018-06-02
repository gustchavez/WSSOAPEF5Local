using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenesPedidoCompleta
    {
        public List<OrdenPedidoCompleta> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorOrdenesPedidoCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<OrdenPedidoCompleta>();
            this.Retorno = new Comunicacion();
        }
    }
}
