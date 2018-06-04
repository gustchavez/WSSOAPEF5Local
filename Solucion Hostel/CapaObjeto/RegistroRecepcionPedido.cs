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
        public int Cantidad { get; set; }
        public DateTime Recepcion { get; set; }
        public string Confirmado { get; set; }
        public Producto Producto { get; set; }
        public decimal NumeroOrdenPedido { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioCantidad { get; set; }


        public RegistroRecepcionPedido()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = decimal.MinValue;
            this.Cantidad = int.MinValue;
            this.Recepcion = DateTime.MinValue;
            this.Confirmado = string.Empty;
            this.Producto = new Producto();
            this.NumeroOrdenPedido = decimal.MinValue;
            this.PrecioUnitario = decimal.MinValue;
            this.PrecioCantidad = decimal.MinValue;
        }
    }
}
