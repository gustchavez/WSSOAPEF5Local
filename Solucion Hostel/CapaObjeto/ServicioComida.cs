using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ServicioComida
    {
        public string Tipo { get; set; }
        public int Precio { get; set; }

        public ServicioComida()
        {
            Init();
        }

        private void Init()
        {
            this.Tipo = string.Empty;
            this.Precio = int.MinValue;
        }
    }
}
