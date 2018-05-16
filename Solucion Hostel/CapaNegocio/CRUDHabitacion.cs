using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDHabitacion
    {
        public CRUDHabitacion()
        {

        }

        public ContenedorHabitacion LlamarSPCrear(ContenedorHabitacion nHabitacion)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
            var p_OUT_CODIGO = new ObjectParameter("P_OUT_CODIGO", typeof(decimal));

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

            conex.SP_CREAR_HABITACION
                ( nHabitacion.Item.Estado
                , nHabitacion.Item.Capacidad
                , nHabitacion.Item.Descripcion
                , nHabitacion.Item.Precio
                , p_OUT_CODRET
                , p_OUT_GLSRET
                , p_OUT_CODIGO
                );

            try
            {
                nHabitacion.Item.Codigo = int.Parse(p_OUT_CODIGO.Value.ToString());
                nHabitacion.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                nHabitacion.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                nHabitacion.Item.Codigo = 0;
                nHabitacion.Retorno.Codigo = 1011;
                nHabitacion.Retorno.Glosa = "Err codret ORACLE";
            }

            return nHabitacion;

        }
        public ContenedorHabitacion LlamarSPActualizar(ContenedorHabitacion aHabitacion)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

            conex.SP_ACTUALIZAR_HABITACION
                (aHabitacion.Item.Codigo
                , aHabitacion.Item.Estado
                , aHabitacion.Item.Capacidad
                , aHabitacion.Item.Descripcion
                , aHabitacion.Item.Precio
                , p_OUT_CODRET
                , p_OUT_GLSRET
                );

            try
            {
                aHabitacion.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                aHabitacion.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                aHabitacion.Retorno.Codigo = 1011;
                aHabitacion.Retorno.Glosa = "Err codret ORACLE";
            }

            return aHabitacion;
        }

        public ContenedorHabitacion LlamarSPEliminar(ContenedorHabitacion eHabitacion)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

            conex.SP_ELIMINAR_HABITACION
                (eHabitacion.Item.Codigo
                , p_OUT_CODRET
                , p_OUT_GLSRET
                );

            try
            {
                eHabitacion.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                eHabitacion.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                eHabitacion.Retorno.Codigo = 1011;
                eHabitacion.Retorno.Glosa = "Err codret ORACLE";
            }

            return eHabitacion;
        }

        public ContenedorHabitaciones LlamarSPRescatar()
        {
            ContenedorHabitaciones LHabitacions = new ContenedorHabitaciones();
            try
            {
                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                var collection = conex.HABITACION.OrderBy(p => p.DESCRIPCION).ToList();

                foreach (var item in collection)
                {
                    Habitacion n = new Habitacion();
                    n.Codigo = item.CODIGO;
                    n.Estado = item.ESTADO;
                    n.Capacidad = item.CAPACIDAD;
                    n.Descripcion = item.DESCRIPCION;
                    n.Precio = item.PRECIO;
                    LHabitacions.Lista.Add(n);
                }
                LHabitacions.Retorno.Codigo = 0;
                LHabitacions.Retorno.Glosa = "OK";
            }
            catch (Exception)
            {
                LHabitacions.Retorno.Codigo = 1011;
                LHabitacions.Retorno.Glosa = "Err codret ORACLE";
            }

            return LHabitacions;
        }


    }
}
