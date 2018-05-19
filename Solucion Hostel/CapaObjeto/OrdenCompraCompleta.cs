using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class OrdenCompraCompleta
    {
        public OrdenCompra Cabecera { get; set; }
        public List<OrdenCompraDetalle> ListaDetalle { get; set; }

        public OrdenCompraCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Cabecera = new OrdenCompra();
            this.ListaDetalle = new List<OrdenCompraDetalle>();
        }
    }
}
