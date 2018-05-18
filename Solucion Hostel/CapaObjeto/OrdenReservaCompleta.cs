using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class OrdenReservaCompleta
    {
        public OrdenReserva Cabecera { get; set; }
        public List<OrdenReservaDetalle> ListaDetalle { get; set; }

        public OrdenReservaCompleta()
        {
            Init();
        }

        private void Init()
        {
            this.Cabecera = new OrdenReserva();
            this.ListaDetalle = new List<OrdenReservaDetalle>();
        }
    }
}
