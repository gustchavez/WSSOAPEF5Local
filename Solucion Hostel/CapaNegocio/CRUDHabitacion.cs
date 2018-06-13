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
            if (ValidarFecExp(nHabitacion.Retorno.Token))
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
            } else {
                nHabitacion.Retorno.Codigo = 100;
                nHabitacion.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nHabitacion;

        }
        public ContenedorHabitacion LlamarSPActualizar(ContenedorHabitacion aHabitacion)
        {
            if (ValidarFecExp(aHabitacion.Retorno.Token))
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
            } else {
                aHabitacion.Retorno.Codigo = 100;
                aHabitacion.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return aHabitacion;
        }
        public ContenedorHabitacion LlamarSPEliminar(ContenedorHabitacion eHabitacion)
        {
            if (ValidarFecExp(eHabitacion.Retorno.Token))
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
            } else {
                eHabitacion.Retorno.Codigo = 100;
                eHabitacion.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return eHabitacion;
        }

        public ContenedorHabitaciones LlamarSPRescatar(string token)
        {
            ContenedorHabitaciones LHabitacions = new ContenedorHabitaciones();

            if (ValidarFecExp(token))
            {
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
            } else {
                LHabitacions.Retorno.Codigo = 100;
                LHabitacions.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LHabitacions;
        }

        public ContenedorCantHabsXCapacidad LlamarSPHabitaHabXCapacidad(string token)
        {
            ContenedorCantHabsXCapacidad LHabitacionesXCapacidad = new ContenedorCantHabsXCapacidad();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from hab in conex.HABITACION
                                      where hab.ESTADO == "habilitada"
                                      group hab by hab.CAPACIDAD into g                                      
                                      select new
                                      {
                                          Capacidad = g.Key,
                                          Cantidad  = g.Count()
                                      }
                            ).ToList();

                    foreach (var item in collection)
                    {
                        CantHabXCapacidad n = new CantHabXCapacidad();
                        n.Capacidad = item.Capacidad;
                        n.Estado    = "habilitada";
                        n.Cantidad  = item.Capacidad;

                        LHabitacionesXCapacidad.Lista.Add(n);
                    }
                    LHabitacionesXCapacidad.Retorno.Codigo = 0;
                    LHabitacionesXCapacidad.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LHabitacionesXCapacidad.Retorno.Codigo = 1011;
                    LHabitacionesXCapacidad.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LHabitacionesXCapacidad.Retorno.Codigo = 100;
                LHabitacionesXCapacidad.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LHabitacionesXCapacidad;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Administrador");
            if (x.ValidarPerfil(token, Perfiles))
            {
                retorno = true;
            }
            return retorno;
        }

        private bool ValidarFecExp(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            if (x.ValidarFechaExpiracion(token))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
