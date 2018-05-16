using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Usuario
    {
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Perfil { get; set; }
        public string Estado { get; set; }
        public string RutPersona { get; set; }

        public Usuario()
        {
            Init();
        }

        private void Init()
        {
            this.Id = decimal.MinValue;
            this.Nombre = string.Empty;
            this.Clave = string.Empty;
            this.Perfil = string.Empty;
            this.Estado = string.Empty;
            this.RutPersona = string.Empty;
        }
    }
}
