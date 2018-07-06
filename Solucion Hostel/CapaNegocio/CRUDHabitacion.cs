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
            ContenedorHabitaciones LHabitaciones = new ContenedorHabitaciones();

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
                        LHabitaciones.Lista.Add(n);
                    }
                    LHabitaciones.Retorno.Codigo = 0;
                    LHabitaciones.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LHabitaciones.Retorno.Codigo = 1011;
                    LHabitaciones.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                LHabitaciones.Retorno.Codigo = 100;
                LHabitaciones.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LHabitaciones;
        }

        public ContenedorHabDispCant LlamarSPHabitaHabXCapacidad(string token, DateTime fecIng, DateTime fecEgr)
        {
            ContenedorHabDispCant LHabDispCant = new ContenedorHabDispCant();

            if (ValidarFecExp(token))
            {
                var p_OUT_CODRET      = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET      = new ObjectParameter("P_OUT_GLSRET", typeof(string));
                var p_OUT_COD_HAB_SIM = new ObjectParameter("P_OUT_COD_HAB_SIM", typeof(decimal));
                var p_OUT_COD_HAB_DOB = new ObjectParameter("P_OUT_COD_HAB_DOB", typeof(decimal));
                var p_OUT_COD_HAB_TRI = new ObjectParameter("P_OUT_COD_HAB_TRI", typeof(decimal));
                var p_OUT_COD_HAB_CUA = new ObjectParameter("P_OUT_COD_HAB_CUA", typeof(decimal));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_OBTENER_DISPONIBILIDAD
                    ( fecIng
                    , fecEgr
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_COD_HAB_SIM
                    , p_OUT_COD_HAB_DOB
                    , p_OUT_COD_HAB_TRI
                    , p_OUT_COD_HAB_CUA
                    );

                try
                { 
                    HabDispCant n = new HabDispCant();
                    n.CantHabSimple   = int.Parse(p_OUT_COD_HAB_SIM.Value.ToString());
                    n.CantHabDoble    = int.Parse(p_OUT_COD_HAB_DOB.Value.ToString());
                    n.CantHabTriple   = int.Parse(p_OUT_COD_HAB_TRI.Value.ToString());
                    n.CantHabSectuple = int.Parse(p_OUT_COD_HAB_CUA.Value.ToString());
                    LHabDispCant.Item = n;

                    LHabDispCant.Retorno.Codigo = 0;
                    LHabDispCant.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LHabDispCant.Retorno.Codigo = 1011;
                    LHabDispCant.Retorno.Glosa = "Err codret ORACLE";
                }
                //try
                //{
                //    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                //    var collection = (from hab in conex.HABITACION
                //                      where hab.ESTADO == "habilitada"
                //                      group hab by hab.CAPACIDAD into g                                      
                //                      select new
                //                      {
                //                          Capacidad = g.Key,
                //                          Cantidad  = g.Count()
                //                      }
                //            ).ToList();

                //    foreach (var item in collection)
                //    {
                //        CantHabXCapacidad n = new CantHabXCapacidad();
                //        n.Capacidad = item.Capacidad;
                //        n.Estado    = "habilitada";
                //        n.Cantidad  = item.Capacidad;

                //        LHabitacionesXCapacidad.Lista.Add(n);
                //    }

                //    LHabitacionesXCapacidad.Retorno.Codigo = 0;
                //    LHabitacionesXCapacidad.Retorno.Glosa = "OK";
                //}
                //catch (Exception)
                //{
                //    LHabitacionesXCapacidad.Retorno.Codigo = 1011;
                //    LHabitacionesXCapacidad.Retorno.Glosa = "Err codret ORACLE";
                //}
            }
            else {
                LHabDispCant.Retorno.Codigo = 100;
                LHabDispCant.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LHabDispCant;
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
