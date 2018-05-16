using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class PerfilUsuario
    {
        public Empresa Empresa { get; set; }
        public Direccion Direccion { get; set; }
        public Persona Persona { get; set; }
        public Usuario Usuario { get; set; }

        public PerfilUsuario()
        {
            Init();
        }

        private void Init()
        {
            this.Empresa = new Empresa();
            this.Direccion = new Direccion();
            this.Persona = new Persona();
            this.Usuario = new Usuario();
        }
    }
}
