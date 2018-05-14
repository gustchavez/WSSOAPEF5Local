﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaObjeto
{
    public class ItemServicioComida
    {
        public string Tipo { get; set; }
        public decimal Precio { get; set; }

        public ItemServicioComida()
        {
            Init();
        }

        private void Init()
        {
            this.Tipo = string.Empty;
            this.Precio = decimal.MinValue;
        }
    }
}
