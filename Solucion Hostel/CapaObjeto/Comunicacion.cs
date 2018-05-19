using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Comunicacion
    {
        public decimal Codigo { get; set; }
        public string Glosa { get; set; }
        public string Token { get; set; }

        public Comunicacion()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = decimal.MinValue;
            this.Glosa  = string.Empty;
            this.Token  = string.Empty;
        }
    }
}
