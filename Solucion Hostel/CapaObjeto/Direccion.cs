using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Comuna { get; set; }
        public string CodPostal { get; set; }
        public string NombreCiudad { get; set; }
        public int CodPais { get; set; }
        public string RutPersona { get; set; }
        public string RutEmpresa { get; set; }

        public Direccion()
        {
            Init();
        }

        private void Init()
        {
            this.Calle = string.Empty;
            this.Numero = int.MinValue;
            this.Comuna = string.Empty;
            this.CodPostal = string.Empty;
            this.NombreCiudad = string.Empty;
            this.CodPais = int.MinValue;
            this.RutPersona = string.Empty;
            this.RutEmpresa = string.Empty;
        }
    }
}
