using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class HeadOrdenCompra
    {
        public decimal Numero { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public string RutCliente { get; set; }
        public decimal Monto { get; set; }
        public string Observaciones { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }

        public Respuesta Retorno { get; set; }

        public HeadOrdenCompra()
        {
            Init();
        }

        private void Init()
        {
            this.Numero = decimal.MinValue;
            this.FechaRecepcion = DateTime.MinValue;
            this.RutCliente = string.Empty;
            this.Monto = decimal.MinValue;
            this.Observaciones = string.Empty;
            this.Ubicacion = string.Empty;
            this.Estado = string.Empty;
            this.Retorno = new Respuesta();
        }
    }
}
