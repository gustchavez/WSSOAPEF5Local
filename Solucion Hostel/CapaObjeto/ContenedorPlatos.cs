using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPlatos
    {
        public List<Plato> Lista { get; set; }

        public RetornoBBDD Retorno { get; set; }

        public ContenedorPlatos()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Plato>();
            this.Retorno = new RetornoBBDD();
        }
    }
}
