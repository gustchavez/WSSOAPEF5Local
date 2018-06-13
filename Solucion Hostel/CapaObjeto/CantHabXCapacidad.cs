using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class CantHabXCapacidad
    {
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }

        public CantHabXCapacidad()
        {
            Init();
        }

        private void Init()
        {
            this.Capacidad = int.MinValue;
            this.Estado = string.Empty;
            this.Cantidad = 0;
        }
    }
}
