using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenReservaCompleta
    {
        public OrdenReservaCompleta Item { get; set; }
        public RetornoBBDD Retorno { get; set; }

        public ContenedorOrdenReservaCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenReservaCompleta();
            this.Retorno = new RetornoBBDD();
        }
    }
}
