using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorProveedores
    {
        public List<Proveedor> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorProveedores()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<Proveedor>();
            this.Retorno = new Comunicacion();
        }
    }
}
