using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Comida
    {
        public DateTime FechaRecepcion { get; set; }
        public string Observaciones { get; set; }
        public string Confirmada { get; set; }
        public decimal CodigoPlato { get; set; }
        public string RutPersona { get; set; }
        public decimal NumerOrdenCompra { get; set; }

        public Comida()
        {
            Init();
        }

        private void Init()
        {
            this.FechaRecepcion = DateTime.MinValue;
            this.Observaciones = string.Empty;
            this.Confirmada = string.Empty;
            this.CodigoPlato = decimal.MinValue;
            this.RutPersona = string.Empty;
            this.NumerOrdenCompra = decimal.MinValue;
        }
    }
}
