using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioCliente
    {
        public PerfilUsuarioCliente Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioCliente()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new PerfilUsuarioCliente();
            this.Retorno = new Comunicacion();
        }

    }
}
