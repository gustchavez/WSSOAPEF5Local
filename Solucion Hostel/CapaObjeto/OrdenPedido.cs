using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class OrdenPedido
    {
        public decimal Numero { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Monto { get; set; }
        public string Observaciones { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }
        public string RutProveedor { get; set; }

        public OrdenPedido()
        {
            Init();
        }

        private void Init()
        {
            this.Numero = decimal.MinValue;
            this.FechaEmision = DateTime.MinValue;
            this.Monto = int.MinValue;
            this.Observaciones = string.Empty;
            this.Ubicacion = string.Empty;
            this.Estado = string.Empty;
            this.RutProveedor = string.Empty;
        }
    }
}
