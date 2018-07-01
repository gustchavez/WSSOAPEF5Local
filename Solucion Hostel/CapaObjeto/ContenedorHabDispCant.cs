using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ContenedorHabDispCant
    {
        public HabDispCant Item { get; set; }

        public Comunicacion Retorno { get; set; }

        public ContenedorHabDispCant()
        {
            Init();
        }

        private void Init()
        {
            this.Item = new HabDispCant();
            this.Retorno = new Comunicacion();
        }
    }
}
