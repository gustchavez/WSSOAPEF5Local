using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ItemPlato
    {
        public decimal Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Disponible { get; set; }
        public string TipoServicio { get; set; }

        public ItemPlato()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo       = decimal.MinValue;
            this.Nombre       = string.Empty;
            this.Descripcion  = string.Empty;
            this.Disponible   = string.Empty;
            this.TipoServicio = string.Empty;
        }


    }
}
