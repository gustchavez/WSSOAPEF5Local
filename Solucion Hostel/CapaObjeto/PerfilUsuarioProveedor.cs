using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class PerfilUsuarioProveedor
    {
        public Proveedor Proveedor { get; set; }
        public PerfilUsuario PerfilUsuario { get; set; }

        public PerfilUsuarioProveedor()
        {
            Init();
        }

        private void Init()
        {
            this.Proveedor = new Proveedor();
            this.PerfilUsuario = new PerfilUsuario();
        }

    }
}
