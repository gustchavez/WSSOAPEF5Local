using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorFacturasCompraCompleta
    {
        public List<FacturaCompraCompleta> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorFacturasCompraCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<FacturaCompraCompleta>();
            this.Retorno = new Comunicacion();
        }
    }
}
