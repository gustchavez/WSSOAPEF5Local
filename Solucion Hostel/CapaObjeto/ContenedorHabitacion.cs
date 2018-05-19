using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorHabitacion
    {
        public Habitacion Item { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorHabitacion()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Habitacion();
            this.Retorno = new Comunicacion();
        }


    }
}
