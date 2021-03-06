﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDOrdenCompraCompleta
    {

        public CRUDOrdenCompraCompleta()
        {
            
        }

        public ContenedorOrdenCompraCompleta LlamarSPCrear(ContenedorOrdenCompraCompleta nOCC)
        {
            if (ValidarPerfilCUD(nOCC.Retorno.Token))
            {
                var p_OUT_NUMERO = new ObjectParameter("P_OUT_NUMERO", typeof(decimal));
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
                var p_OUT_HAB_CODIGO = new ObjectParameter("P_OUT_HAB_CODIGO", typeof(decimal));
                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_ENC_RESERVA
                    (nOCC.Item.Cabecera.RutCliente
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_NUMERO
                    ) ;
                try
                {
                    nOCC.Item.Cabecera.Numero = decimal.Parse(p_OUT_NUMERO.Value.ToString());

                    nOCC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nOCC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();

                    if (nOCC.Retorno.Codigo == 0 && nOCC.Item.Cabecera.Numero > 0)
                    {
                        bool ErrorAltaDetalle = false;
                        decimal CodigoHabitacionTemporal = 0;
                        foreach (var item in nOCC.Item.ListaDetalle)
                        {
                            conex.SP_CREAR_DET_RESERVA
                            ( nOCC.Item.Cabecera.Numero
                            , item.Alojamiento.FechaIngreso
                            , item.Alojamiento.FechaEgreso
                            , item.Alojamiento.RegistroDias
                            , item.Alojamiento.Observaciones
                            , item.Persona.Rut //Puede ponerse cualquier de los 2 ruts Comida o Alojamiento
                            , item.Persona.Nombre
                            , item.Persona.Apellido
                            //, item.Alojamiento.CodigoCama
                            , item.Alojamiento.Habitacion.Capacidad
                            , CodigoHabitacionTemporal
                            , item.Comida.FechaRecepcion
                            , item.Comida.Observaciones
                            , item.Comida.ServicioComida.Tipo
                            //, item.Comida.CodigoPlato
                            , p_OUT_CODRET
                            , p_OUT_GLSRET
                            , p_OUT_HAB_CODIGO
                            );
                            //
                            try
                            {
                                nOCC.Retorno.Codigo      = decimal.Parse(p_OUT_CODRET.Value.ToString());
                                nOCC.Retorno.Glosa       = p_OUT_GLSRET.Value.ToString();
                                CodigoHabitacionTemporal = decimal.Parse(p_OUT_HAB_CODIGO.Value.ToString());
                            }
                            catch (Exception)
                            {
                                nOCC.Retorno.Codigo = 1021;
                                nOCC.Retorno.Glosa = "Error alta detalle";
                                ErrorAltaDetalle = true;
                                break;
                            }
                        }
                        //Logica validacion Detalle
                        if (ErrorAltaDetalle != true)
                        {
                            conex.SP_ACTUALIZAR_ENC_RESERVA
                            ( nOCC.Item.Cabecera.Numero
                            , nOCC.Item.Cabecera.Monto
                            , nOCC.Item.Cabecera.Observaciones
                            , nOCC.Item.Cabecera.Ubicacion
                            , nOCC.Item.Cabecera.Estado
                            , p_OUT_CODRET
                            , p_OUT_GLSRET
                            );
                            try
                            {
                                nOCC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                                nOCC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                            }
                            catch (Exception)
                            {
                                nOCC.Retorno.Codigo = 1031;
                                nOCC.Retorno.Glosa = "Error actualizacion Encabezado";
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    nOCC.Retorno.Codigo = 1011;
                    nOCC.Retorno.Glosa = "Error creacion Encabezado";
                }
            } else {
                nOCC.Retorno.Codigo = 100;
                nOCC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nOCC;
        }

        public ContenedorOrdenCompraCompleta LlamarSPActualizar(ContenedorOrdenCompraCompleta aOCC)
        {
            if (ValidarFecExp(aOCC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ANULAR_ORDEN_COMPRA
                    ( aOCC.Item.Cabecera.Numero
                    , aOCC.Item.Cabecera.Observaciones
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aOCC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aOCC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aOCC.Retorno.Codigo = 1011;
                    aOCC.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                aOCC.Retorno.Codigo = 100;
                aOCC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }
            return aOCC;
        }

        public ContenedorOrdenesCompraCompleta LlamarSPRescatar(string token)
        {
            ContenedorOrdenesCompraCompleta LOrdenesCompra = new ContenedorOrdenesCompraCompleta();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from cab in conex.ORDEN_DE_COMPRA
                                      join det_aloj in conex.ALOJAMIENTO     on cab.NUMERO             equals det_aloj.NUMERO_OC
                                      join det_comi in conex.COMIDA          on cab.NUMERO             equals det_comi.NUMERO_OC
                                      join tip_serv in conex.SERVICIO_COMIDA on det_comi.TIPO_SERVICIO equals tip_serv.TIPO
                                      where det_comi.RUT_PERSONA == det_aloj.RUT_PERSONA
                                      orderby cab.NUMERO
                                      select new
                                      {
                                          RutCliente    = cab.RUT_CLIENTE,
                                          NumeroOC      = cab.NUMERO,
                                          FecRecepOC    = cab.RECEPCION,
                                          MontoOC       = cab.MONTO,
                                          EstadoOC      = cab.ESTADO,
                                          //
                                          FecIngAloj    = det_aloj.INGRESO,
                                          FecEgrAloj    = det_aloj.EGRESO,
                                          CanDiasAloj   = det_aloj.REGISTRO_DIAS,
                                          EstadoAloj    = det_aloj.CONFIRMADO,
                                          RutPersona    = det_aloj.RUT_PERSONA,
                                          NomPersona    = det_aloj.PERSONA.NOMBRE,
                                          ApePersona    = det_aloj.PERSONA.APELLIDO,
                                          NroHab        = det_aloj.CAMA.HABITACION.CODIGO,
                                          CapaHab       = det_aloj.CAMA.HABITACION.CAPACIDAD,
                                          PrecioHab     = det_aloj.CAMA.HABITACION.PRECIO,
                                          //
                                          FecRecepCom   = det_comi.RECEPCION,
                                          EstadoCom     = det_comi.CONFIRMADA,
                                          //CodPlatoCom = det_comi.CODIGO_PLATO,
                                          TipoServ      = det_comi.TIPO_SERVICIO,
                                          PrecioCom     = tip_serv.PRECIO
                                      }
                            ).ToList();

                    decimal NumeroOrdenAnterior = decimal.MinValue;
                    foreach (var item in collection)
                    {
                        //Verificar Corte de control por Numero de Orden
                        if (NumeroOrdenAnterior != item.NumeroOC)
                        {
                            //Se crea la OrdenCompleta
                            OrdenCompraCompleta n = new OrdenCompraCompleta();
                            //Se carga valores de la cabecera
                            n.Cabecera.RutCliente              = item.RutCliente;
                            n.Cabecera.Numero                  = item.NumeroOC;
                            n.Cabecera.FechaRecepcion          = item.FecRecepOC;
                            n.Cabecera.Monto                   = item.MontoOC;
                            n.Cabecera.Estado                  = item.EstadoOC;
                            //
                            //Se crea el detalle Orden
                            OrdenCompraDetalle m = new OrdenCompraDetalle();
                            m.Alojamiento.NumerOrdenCompra     = item.NumeroOC;
                            m.Persona.Rut                      = item.RutPersona;
                            m.Persona.Nombre                   = item.NomPersona;
                            m.Persona.Apellido                 = item.ApePersona;
                            m.Alojamiento.FechaIngreso         = item.FecIngAloj;
                            m.Alojamiento.FechaEgreso          = (item.FecEgrAloj  == null) ? DateTime.MinValue : (DateTime)item.FecEgrAloj;
                            m.Alojamiento.RegistroDias         = (item.CanDiasAloj == null) ? 0 : (int)item.CanDiasAloj;
                            m.Alojamiento.Habitacion.Codigo    = item.NroHab;
                            m.Alojamiento.Confirmado           = item.EstadoAloj;
                            m.Alojamiento.Habitacion.Capacidad = item.CapaHab;
                            m.Alojamiento.Habitacion.Precio    = item.PrecioHab;
                            
                            //m.Alojamiento.
                            //
                            m.Comida.NumerOrdenCompra          = item.NumeroOC;
                            m.Comida.FechaRecepcion            = item.FecRecepCom;
                            m.Comida.Confirmada                = item.EstadoCom;
                            //m.Comida.CodigoPlato             = item.CodPlatoCom;
                            m.Comida.ServicioComida.Tipo       = item.TipoServ;
                            m.Comida.ServicioComida.Precio     = (item.PrecioCom == null) ? 0 : (int)item.PrecioCom; //(int)item.PrecioCom;
                            //Se agrega el detalle a la cabecera

                            n.ListaDetalle.Add(m);
                            //Se agrega la orden completa a la orden
                            LOrdenesCompra.Lista.Add(n);

                            //Se realiza logica para armar corte de control
                            NumeroOrdenAnterior = item.NumeroOC;
                        } else {
                            //Se crea el detalle Orden
                            OrdenCompraDetalle m = new OrdenCompraDetalle();
                            m.Alojamiento.NumerOrdenCompra     = item.NumeroOC;
                            m.Persona.Rut                      = item.RutPersona;
                            m.Persona.Nombre                   = item.NomPersona;
                            m.Persona.Apellido                 = item.ApePersona;
                            m.Alojamiento.FechaIngreso         = item.FecIngAloj;
                            m.Alojamiento.FechaEgreso          = (item.FecEgrAloj == null) ? DateTime.MinValue : (DateTime)item.FecEgrAloj;
                            m.Alojamiento.RegistroDias         = (item.CanDiasAloj == null) ? 0 : (int)item.CanDiasAloj;
                            m.Alojamiento.Habitacion.Codigo    = item.NroHab;
                            m.Alojamiento.Confirmado           = item.EstadoAloj;
                            m.Alojamiento.Habitacion.Capacidad = item.CapaHab;
                            m.Alojamiento.Habitacion.Precio    = item.PrecioHab;
                            //
                            m.Comida.NumerOrdenCompra          = item.NumeroOC;
                            m.Comida.FechaRecepcion            = item.FecRecepCom;
                            m.Comida.Confirmada                = item.EstadoCom;
                            //m.Comida.CodigoPlato             = item.CodPlatoCom;
                            m.Comida.ServicioComida.Tipo       = item.TipoServ;
                            m.Comida.ServicioComida.Precio     = (item.PrecioCom == null) ? 0 : (int)item.PrecioCom; //(int)item.PrecioCom;
                            //Se agrega el detalle a la ultima orden de compra
                            LOrdenesCompra.Lista.Last().ListaDetalle.Add(m);
                        }
                    }
                    LOrdenesCompra.Retorno.Codigo = 0;
                    LOrdenesCompra.Retorno.Glosa = "OK";

                }
                catch (Exception ex)
                {
                    LOrdenesCompra.Retorno.Codigo = 1011;
                    LOrdenesCompra.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LOrdenesCompra.Retorno.Codigo = 100;
                LOrdenesCompra.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LOrdenesCompra;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Empleado");
            Perfiles.Add("Cliente");
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

        public ContenedorAlojamiento LlamarSPActIngHuesped(ContenedorAlojamiento Huesped)
        {
            if (ValidarPerfilCUD(Huesped.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ACT_INGRESO_HUESPED
                    ( Huesped.Item.NumerOrdenCompra
                    , Huesped.Item.RutPersona
                    , Huesped.Item.Confirmado
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );
                try
                {
                    Huesped.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    Huesped.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    Huesped.Retorno.Codigo = 1011;
                    Huesped.Retorno.Glosa = "Error actualizacion Ingreso Huesped";
                }
            }
            else {
                Huesped.Retorno.Codigo = 100;
                Huesped.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return Huesped;
        }
    }
}
