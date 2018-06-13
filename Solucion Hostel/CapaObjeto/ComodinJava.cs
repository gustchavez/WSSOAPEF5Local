using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ComodinJava
    {
        public string Nombre { get; set; }
        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int numero3 { get; set; }
        public int numero4 { get; set; }
        public int numero5 { get; set; }

        public ComodinJava()
        {
            Init();
        }

        private void Init()
        {
            this.Nombre = string.Empty;
            this.numero1 = int.MinValue;
            this.numero2 = int.MinValue;
            this.numero3 = int.MinValue;
            this.numero4 = int.MinValue;
            this.numero5 = int.MinValue;
        }
    }
}
