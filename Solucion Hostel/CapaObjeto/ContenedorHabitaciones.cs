using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorHabitaciones
    {
        public List<Habitacion> Lista { get; set; }

        public RetornoBBDD Retorno { get; set; }

        public ContenedorHabitaciones()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Habitacion>();
            this.Retorno = new RetornoBBDD();
        }
    }
}
