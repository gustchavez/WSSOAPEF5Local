using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Pago
    {

        public string TipoFactura { get; set; }
        public decimal NumeroFactura { get; set; }
        public string MedioPago { get; set; }
        public string Divisa { get; set; }
        public string CodigoISO { get; set; }
        public string Monto { get; set; }
        public Nullable<decimal> TasaCambioCLP { get; set; }

        public Pago()
        {
            Init();
        }

        private void Init()
        {
            this.TipoFactura = string.Empty;
            this.NumeroFactura = decimal.MinValue;
            this.MedioPago = string.Empty;
            this.Divisa = string.Empty;
            this.CodigoISO = string.Empty;
            this.Monto = string.Empty;
            this.TasaCambioCLP = decimal.MinValue;
        }

    }
}
