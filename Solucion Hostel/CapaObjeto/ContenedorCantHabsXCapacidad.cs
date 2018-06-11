using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorCantHabsXCapacidad
    {
        public List<CantHabXCapacidad> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorCantHabsXCapacidad()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<CantHabXCapacidad>();
            this.Retorno = new Comunicacion();
        }
    }
}
