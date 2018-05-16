using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Proveedor
    {
        public string Rut { get; set; }
        public Proveedor()
        {
            Init();
        }

        private void Init()
        {
            this.Rut = string.Empty;
        }
    }
}
