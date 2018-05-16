using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Empresa
    {
        public string Rut { get; set; }
        public string RazonSocial { get; set; }
        public string Rubro { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Logo { get; set; }

        public Empresa()
        {
            Init();
        }

        private void Init()
        {
            this.Rut = string.Empty;
            this.RazonSocial = string.Empty;
            this.Rubro = string.Empty;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
            this.Logo = string.Empty;
        }
    }
}
