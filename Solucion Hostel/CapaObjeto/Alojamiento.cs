using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Alojamiento
    {
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int RegistroDias { get; set; }
        public string Observaciones { get; set; }
        public string Confirmado { get; set; }
        public decimal CodigoCama { get; set; }
        public string RutPersona { get; set; }
        public decimal NumerOrdenCompra { get; set; }

        public Alojamiento()
        {
            Init();
        }

        private void Init()
        {
            this.FechaIngreso = DateTime.MinValue;
            this.FechaIngreso = DateTime.MinValue;
            this.RegistroDias = int.MinValue;
            this.Observaciones = string.Empty;
            this.Confirmado = string.Empty;
            this.RutPersona = string.Empty;
            this.CodigoCama = decimal.MinValue;
            this.NumerOrdenCompra = decimal.MinValue;
        }
    }
}
