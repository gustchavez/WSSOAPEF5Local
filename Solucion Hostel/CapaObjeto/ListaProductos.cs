using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ListaProductos
    {
        public List<ItemProducto> Productos { get; set; }

        public Respuesta Retorno { get; set; }

        public ListaProductos()
        {
            Init();
        }

        private void Init()
        {
            this.Productos = new List<ItemProducto>();
            this.Retorno = new Respuesta();
        }

    }
}
