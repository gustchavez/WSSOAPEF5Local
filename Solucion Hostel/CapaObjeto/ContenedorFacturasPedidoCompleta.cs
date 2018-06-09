using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorFacturasPedidoCompleta
    {
        public List<FacturaPedidoCompleta> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorFacturasPedidoCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<FacturaPedidoCompleta>();
            this.Retorno = new Comunicacion();
        }
    }
}
