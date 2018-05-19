using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorServiciosComida
    {
        public List<ServicioComida> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorServiciosComida()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<ServicioComida>();
            this.Retorno = new Comunicacion();
        }
    }
}
