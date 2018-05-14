using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ListaPlatos
    {
        public List<ItemPlato> Platos { get; set; }

        public Respuesta Retorno { get; set; }

        public ListaPlatos()
        {
            Init();
        }

        private void Init()
        {
            this.Platos = new List<ItemPlato>();
            this.Retorno = new Respuesta();
        }
    }
}
