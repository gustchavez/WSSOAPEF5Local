using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorAlojamiento
    {


        public Alojamiento Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorAlojamiento()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Alojamiento();
            this.Retorno = new Comunicacion();
        }
    }
}
