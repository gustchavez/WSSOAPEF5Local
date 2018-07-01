using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class HabDispCant
    {
        public int CantHabSimple { get; set; }
        public int CantHabDoble { get; set; }
        public int CantHabTriple { get; set; }
        public int CantHabSectuple { get; set; }

        public HabDispCant()
        {
            Init();
        }

        private void Init()
        {
            this.CantHabSimple   = 0;
            this.CantHabDoble    = 0;
            this.CantHabTriple   = 0;
            this.CantHabSectuple = 0;
        }
    }
}
