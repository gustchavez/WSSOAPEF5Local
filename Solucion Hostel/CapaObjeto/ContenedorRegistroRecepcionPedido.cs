using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorRegistroRecepcionPedido
    {
        public RegistroRecepcionPedido Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorRegistroRecepcionPedido()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new RegistroRecepcionPedido();
            this.Retorno = new Comunicacion();
        }
    }
}
