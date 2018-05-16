using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenCompraCompleta
    {
        public OrdenCompraCompleta Item { get; set; }
        public RetornoBBDD Retorno { get; set; }

        public ContenedorOrdenCompraCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenCompraCompleta();
            this.Retorno = new RetornoBBDD();
        }
    }
}
