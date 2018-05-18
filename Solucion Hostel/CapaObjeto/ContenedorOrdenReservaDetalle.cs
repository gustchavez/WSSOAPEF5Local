using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenReservaDetalle
    {
        public OrdenReservaDetalle Item { get; set; }
        public RetornoBBDD Retorno { get; set; }

        public ContenedorOrdenReservaDetalle()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenReservaDetalle();
            this.Retorno = new RetornoBBDD();
        }
    }
}
