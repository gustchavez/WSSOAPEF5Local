using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPlato
    {
        public Plato Item { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorPlato()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Plato();
            this.Retorno = new Comunicacion();
        }

    }
}
