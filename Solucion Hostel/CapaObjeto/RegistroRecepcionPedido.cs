using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class RegistroRecepcionPedido
    {
        public decimal Codigo { get; set; }
        public int Indice { get; set; }
        public DateTime Recepcion { get; set; }
        public string Confirmado { get; set; }
        public decimal CodigoProducto { get; set; }
        public decimal NumeroOrdenPedido { get; set; }

        public RegistroRecepcionPedido()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = decimal.MinValue;
            this.Indice = int.MinValue;
            this.Recepcion = DateTime.MinValue;
            this.Confirmado = string.Empty;
            this.CodigoProducto = decimal.MinValue;
            this.NumeroOrdenPedido = decimal.MinValue;
        }
    }
}
