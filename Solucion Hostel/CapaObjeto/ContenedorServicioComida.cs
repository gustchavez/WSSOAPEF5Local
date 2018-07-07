using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorServicioComida
    {
        public ServicioComida Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorServicioComida()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new ServicioComida();
            this.Retorno = new Comunicacion();
        }
    }
}
