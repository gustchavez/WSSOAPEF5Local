using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class Sesion
    {
        public string Usuario  { get; set; }
        public string Clave    { get; set; }
        public string Perfil   { get; set; }
        public string Nombre   { get; set; }
        public string Apellido { get; set; }

        public Comunicacion Retorno { get; set; }

        public Sesion()
        {
            Init();
        }

        private void Init()
        {
            this.Usuario = string.Empty;
            this.Clave = string.Empty;
            this.Perfil = string.Empty;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Retorno = new Comunicacion();
        }
    }
}
