using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorCiudades
    {
        public List<Ciudad> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorCiudades()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Ciudad>();
            this.Retorno = new Comunicacion();
        }
    }
}
