using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorCama
    {
        public Cama Item { get; set; }

        public RetornoBBDD Retorno { get; set; }

        public ContenedorCama()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Cama();
            this.Retorno = new RetornoBBDD();
        }


    }
}
