using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioProveedor
    {
        public PerfilUsuarioProveedor Item { get; set; }
        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioProveedor()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new PerfilUsuarioProveedor();
            this.Retorno = new Comunicacion();
        }



    }
}
