using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioAdministrador
    {
        public PerfilUsuarioAdministrador Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioAdministrador()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new PerfilUsuarioAdministrador();
            this.Retorno = new Comunicacion();
        }
    }
    
}
