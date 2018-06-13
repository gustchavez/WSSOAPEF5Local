using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorPerfilUsuarioEmpleados
    {
        public List<PerfilUsuarioEmpleado> Lista { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorPerfilUsuarioEmpleados()
        {
            Init();
        }

        private void Init()
        {
            this.Lista = new List<PerfilUsuarioEmpleado>();
            this.Retorno = new Comunicacion();
        }

    }
}
