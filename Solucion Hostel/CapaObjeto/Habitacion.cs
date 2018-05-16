using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Habitacion
    {
        public int Codigo { get; set; }
        public string Estado { get; set; }
        public int Capacidad { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public Habitacion()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = int.MinValue;
            this.Estado = string.Empty;
            this.Capacidad = int.MinValue;
            this.Descripcion = string.Empty;
            this.Precio = int.MinValue;
        }
    }
}

