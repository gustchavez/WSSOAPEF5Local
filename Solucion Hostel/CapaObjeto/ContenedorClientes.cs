using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorClientes
    {
        public List<Cliente> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorClientes()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Cliente>();
            this.Retorno = new Comunicacion();
        }

    }
}
