using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorProvision
    {
        public Provision Item { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorProvision()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Provision();
            this.Retorno = new Comunicacion();
        }

    }
}
