using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorFacturaPedidoCompleta
    {
        public FacturaPedidoCompleta Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorFacturaPedidoCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new FacturaPedidoCompleta();
            this.Retorno = new Comunicacion();
        }
    }
}
