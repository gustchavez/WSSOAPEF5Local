using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorFacturaCompraCompleta
    {
        public FacturaCompraCompleta Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorFacturaCompraCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new FacturaCompraCompleta();
            this.Retorno = new Comunicacion();
        }
    }
}
