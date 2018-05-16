using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Persona
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Persona()
        {
            Init();
        }

        private void Init()
        {
            this.Rut = string.Empty;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.FechaNacimiento = DateTime.MinValue;
            this.Email = string.Empty;
            this.Telefono = string.Empty;
        }
    }
}
