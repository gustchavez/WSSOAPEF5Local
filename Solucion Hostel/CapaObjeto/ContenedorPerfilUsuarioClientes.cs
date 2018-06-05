using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioClientes
    {
        public List<PerfilUsuarioCliente> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioClientes()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<PerfilUsuarioCliente>();
            this.Retorno = new Comunicacion();
        }

    }

}

