using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorUsuarios
    {
        public List<Usuario> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorUsuarios()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Usuario>();
            this.Retorno = new Comunicacion();
        }

    }
}
