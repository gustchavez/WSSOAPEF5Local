using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Producto
    {
        public ItemProducto Item { get; set; }

        public Respuesta Retorno { get; set; }

        public Producto()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new ItemProducto();
            this.Retorno = new Respuesta();
        }
    }
}
