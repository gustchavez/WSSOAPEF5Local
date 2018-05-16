using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenPedidoCompleta
    {
        public OrdenPedidoCompleta Item { get; set; }
        public RetornoBBDD Retorno { get; set; }

        public ContenedorOrdenPedidoCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenPedidoCompleta();
            this.Retorno = new RetornoBBDD();
        }


    }
}
