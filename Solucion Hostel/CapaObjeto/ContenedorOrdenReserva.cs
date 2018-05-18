using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenReserva
    {
        public OrdenReserva Item { get; set; }
        public RetornoBBDD Retorno { get; set; }

        public ContenedorOrdenReserva()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenReserva();
            this.Retorno = new RetornoBBDD();
        }
    }
}
