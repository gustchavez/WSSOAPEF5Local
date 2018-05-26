using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorOrdenesCompraCompleta
    {
        public List<OrdenCompraCompleta> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorOrdenesCompraCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<OrdenCompraCompleta>();
            this.Retorno = new Comunicacion();
        }
    }
}
