using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class CRUDCiudad
    {
        public CRUDCiudad()
        {

        }


        public ContenedorCiudades LlamarSPRescatar()
        {
            ContenedorCiudades LCiudades = new ContenedorCiudades();

            try
            {
                var collection = CommonBD.Conexion.CIUDAD.OrderBy(p => p.NOMBRE).ToList();

                foreach (var item in collection)
                {
                    Ciudad n = new Ciudad();
                    n.Nombre = item.NOMBRE;
                    n.CodArea = item.COD_AREA;
                    n.CodPais = item.COD_PAIS;
                    LCiudades.Lista.Add(n);
                }
                LCiudades.Retorno.Codigo = 0;
                LCiudades.Retorno.Glosa = "OK";
            }
            catch (Exception)
            {
                LCiudades.Retorno.Codigo = 1011;
                LCiudades.Retorno.Glosa = "Err codret ORACLE";
            }

            return LCiudades;
        }
    }
}