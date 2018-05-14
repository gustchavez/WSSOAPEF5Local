using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ListaServicioComida
    {
        public List<ItemServicioComida> ServiciosComida { get; set; }

        public Respuesta Retorno { get; set; }

        public ListaServicioComida()
        {
            Init();
        }

        private void Init()
        {
            this.ServiciosComida = new List<ItemServicioComida>();
            this.Retorno = new Respuesta();
        }
    }
}
