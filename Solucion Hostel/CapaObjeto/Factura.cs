using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Factura
    {
        public string Tipo { get; set; }
        public decimal Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int ValorBruto { get; set; }
        public int ValorIva { get; set; }
        public int ValorNeto { get; set; }
        public string Observaciones { get; set; }
        public string Ubicacion { get; set; }
        public decimal NumeroOrdenCompra { get; set; }
        public decimal NumeroOrdenPedido { get; set; }
        public string Estado { get; set; }

        public Factura()
        {
            Init();
        }

        private void Init()
        {
            this.Tipo = string.Empty;
            this.Numero = decimal.MinValue;
            this.Fecha = DateTime.MinValue;
            this.ValorBruto = int.MinValue;
            this.ValorIva = int.MinValue;
            this.ValorNeto = int.MinValue;
            this.Observaciones = string.Empty;
            this.Ubicacion = string.Empty;
            this.NumeroOrdenCompra = decimal.MinValue;
            this.NumeroOrdenPedido = decimal.MinValue;
            this.Estado = string.Empty;
        }
    }
}
