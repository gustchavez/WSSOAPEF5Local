using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class PerfilUsuarioEmpleado
    {
        public Persona Persona { get; set; }
        public Usuario Usuario { get; set; }

        public PerfilUsuarioEmpleado()
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
