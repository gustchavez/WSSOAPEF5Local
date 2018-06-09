using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilAdmin
    {
        public PerfilAdmin Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilAdmin()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new PerfilAdmin();
            this.Retorno = new Comunicacion();
        }
    }
    
}
