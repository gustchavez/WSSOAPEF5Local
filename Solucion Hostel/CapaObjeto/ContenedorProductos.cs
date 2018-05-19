using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorProductos
    {
        public List<Producto> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorProductos()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Producto>();
            this.Retorno = new Comunicacion();
        }

    }
}
