using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorUsuario
    {
        public Usuario Item { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorUsuario()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new Usuario();
            this.Retorno = new Comunicacion();
        }
    }
}
