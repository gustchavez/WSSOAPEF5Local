using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioAdministradores
    {
        public List<PerfilUsuarioAdministrador> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioAdministradores()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<PerfilUsuarioAdministrador>();
            this.Retorno = new Comunicacion();
        }
    }
}
