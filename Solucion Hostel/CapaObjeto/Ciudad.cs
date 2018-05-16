using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Ciudad
    {
        public string Nombre { get; set; }
        public int CodArea { get; set; }
        public int CodPais { get; set; }

        public Ciudad()
        {
            Init();
        }

        private void Init()
        {
            this.Nombre = string.Empty;
            this.CodArea = int.MinValue;
            this.CodPais = int.MinValue;
        }
    }
}

