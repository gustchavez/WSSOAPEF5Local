using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorCamas
    {
        public List<Cama> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorCamas()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Cama>();
            this.Retorno = new Comunicacion();
        }

    }
}
