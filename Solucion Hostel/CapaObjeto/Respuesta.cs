using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Respuesta
    {
        public decimal Codigo { get; set; }
        public string Glosa { get; set; }

        public Respuesta()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = decimal.MinValue;
            this.Glosa = string.Empty;
        }
    }
}
