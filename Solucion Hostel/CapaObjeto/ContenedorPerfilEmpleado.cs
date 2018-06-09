using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilEmpleado
    {
        public PerfilEmpleado Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilEmpleado()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new PerfilEmpleado();
            this.Retorno = new Comunicacion();
        }
    }
}
