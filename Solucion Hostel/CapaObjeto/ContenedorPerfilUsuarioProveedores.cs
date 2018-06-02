using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioProveedores
    {
        public List<PerfilUsuarioProveedor> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioProveedores()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<PerfilUsuarioProveedor>();
            this.Retorno = new Comunicacion();
        }

    }
}
