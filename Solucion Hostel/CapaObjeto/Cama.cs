using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Cama
    {
        public decimal Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Disponible { get; set; }
        public int CodHabitacion { get; set; }

        public Cama()
        {
            Init();
        }

        private void Init()
        {
            this.Codigo = decimal.MinValue;
            this.Descripcion = string.Empty;
            this.Disponible = string.Empty;
            this.CodHabitacion = int.MinValue;
        }
    }
}
