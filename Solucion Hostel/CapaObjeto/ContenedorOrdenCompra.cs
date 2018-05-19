using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenCompra
    {
        public OrdenCompra Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorOrdenCompra()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenCompra();
            this.Retorno = new Comunicacion();
        }
    }
}
