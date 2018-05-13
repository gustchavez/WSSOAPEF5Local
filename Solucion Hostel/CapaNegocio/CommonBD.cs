using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;

namespace CapaNegocio
{
    public class CommonBD
    {
        private static EntitiesBBDDHostel _conexion;

        public static EntitiesBBDDHostel Conexion
        {
            get
            {
                if (_conexion == null)
                {
                    _conexion = new EntitiesBBDDHostel();
                }
                return _conexion;
            }
        }
    }
}
