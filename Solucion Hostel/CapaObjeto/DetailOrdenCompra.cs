using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class DetailOrdenCompra
    {
        public decimal NumeroReserva { get; set; }
        public string RutPersona { get; set; }
        public DateTime FecIngAlojamiento { get; set; }
        public DateTime FecEgrAlojamiento { get; set; }
        public string ObsAlojamiento { get; set; }
        public decimal CodigoCama { get; set; }
        public DateTime FecRecepcionComida { get; set; }
        public string ObsComida { get; set; }
        public decimal CodPlatoComida { get; set; }
        
        public Respuesta Retorno { get; set; }

        public DetailOrdenCompra()
        {
            Init();
        }

        private void Init()
        {
            this.NumeroReserva = decimal.MinValue;
            this.RutPersona = string.Empty;
            this.FecIngAlojamiento = DateTime.MinValue;
            this.FecEgrAlojamiento = DateTime.MinValue;
            this.ObsAlojamiento = string.Empty;
            this.CodigoCama = decimal.MinValue;
            this.FecRecepcionComida = DateTime.MinValue;
            this.ObsComida = string.Empty;
            this.CodPlatoComida = decimal.MinValue;
            this.Retorno = new Respuesta();
        }
    }
}
