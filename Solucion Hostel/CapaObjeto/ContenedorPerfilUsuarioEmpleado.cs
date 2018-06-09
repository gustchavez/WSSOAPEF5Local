using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioEmpleado
    {
        public PerfilUsuarioEmpleado Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioEmpleado()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new PerfilUsuarioEmpleado();
            this.Retorno = new Comunicacion();
        }
    }
}
