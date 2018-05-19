using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class OrdenCompraDetalle
    {
        public Alojamiento Alojamiento { get; set; }
        public Comida Comida { get; set; }

        public OrdenCompraDetalle()
        {
            Init();
        }

        private void Init()
        {
            this.Alojamiento = new Alojamiento();
            this.Comida = new Comida();
        }
    }
}
