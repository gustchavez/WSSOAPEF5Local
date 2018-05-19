using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenCompraDetalle
    {
        public OrdenCompraDetalle Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorOrdenCompraDetalle()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new OrdenCompraDetalle();
            this.Retorno = new Comunicacion();
        }
    }
}
