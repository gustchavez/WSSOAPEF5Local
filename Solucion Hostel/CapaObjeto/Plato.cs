using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Plato
    {
        public ItemPlato Item { get; set; }

        public Respuesta Retorno { get; set; }

        public Plato()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new ItemPlato();
            this.Retorno = new Respuesta();
        }

    }
}
