using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorProducto
    {
        public Producto Item { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorProducto()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Producto();
            this.Retorno = new Comunicacion();
        }
    }
}
