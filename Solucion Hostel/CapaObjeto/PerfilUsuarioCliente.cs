using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class PerfilUsuarioCliente
    {
        public Cliente Cliente { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }

        public PerfilUsuarioCliente()
        {
            Init();
        }

        private void Init()
        {
            this.Cliente = new Cliente();
            this.PerfilUsuario = new PerfilUsuario();
        }
    }
}
