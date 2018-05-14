using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class ScrudServicioComida
    {

        public ScrudServicioComida()
        {

        }


        public ListaServicioComida LlamarSPRescatar()
        {
            ListaServicioComida LServiciosComida = new ListaServicioComida();
            try
            {
                var collection = CommonBD.Conexion.SERVICIO_COMIDA.OrderBy(p => p.TIPO).ToList();

                foreach (var item in collection)
                {
                    ItemServicioComida n = new ItemServicioComida();
                    n.Tipo = item.TIPO;
                    n.Precio = (decimal)item.PRECIO;
                    LServiciosComida.ServiciosComida.Add(n);
                }
                LServiciosComida.Retorno.Codigo = 0;
                LServiciosComida.Retorno.Glosa = "OK";
            }
            catch (Exception)
            {
                LServiciosComida.Retorno.Codigo = 1011;
                LServiciosComida.Retorno.Glosa = "Err codret ORACLE";
            }

            return LServiciosComida;
        }
    }
}
