using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class PerfilEmpleado
    {
        public Persona Persona { get; set; }
        public Usuario Usuario { get; set; }

        public PerfilEmpleado()
        {
            Init();
        }

        private void Init()
        {
            this.Persona = new Persona();
            this.Usuario = new Usuario();
        }
    }
}
