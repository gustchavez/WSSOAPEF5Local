using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorProvisiones
    {
        public List<Provision> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorProvisiones()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Provision>();
            this.Retorno = new Comunicacion();
        }

    }
}
