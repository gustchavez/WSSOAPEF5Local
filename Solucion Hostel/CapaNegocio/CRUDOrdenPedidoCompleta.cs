using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDOrdenPedidoCompleta
    {

        public CRUDOrdenPedidoCompleta()
        {

        }

        public ContenedorOrdenPedidoCompleta LlamarSPCrear(ContenedorOrdenPedidoCompleta nOPC)
        {
            if (ValidarPerfilCUD(nOPC.Retorno.Token))
            {
                var p_OUT_NUMERO = new ObjectParameter("P_OUT_NUMERO", typeof(decimal));
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_ENC_PEDIDO
                    (nOPC.Item.Cabecera.RutProveedor
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_NUMERO
                    );
                try
                {
                    nOPC.Item.Cabecera.Numero = decimal.Parse(p_OUT_NUMERO.Value.ToString());
                    nOPC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nOPC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();

                    if (nOPC.Retorno.Codigo == 0 && nOPC.Item.Cabecera.Numero > 0)
                    {
                        bool ErrorAltaDetalle = false;

                        foreach (var item in nOPC.Item.ListaDetalle)
                        {
                            conex.SP_CREAR_DET_PEDIDO
                            ( nOPC.Item.Cabecera.Numero
                            , item.RegistroRecepcionPedido.Recepcion
                            , item.RegistroRecepcionPedido.CodigoProducto
                            , p_OUT_CODRET
                            , p_OUT_GLSRET
                            );
                            //
                            try
                            {
                                nOPC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                                nOPC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                            }
                            catch (Exception)
                            {
                                nOPC.Retorno.Codigo = 1021;
                                nOPC.Retorno.Glosa = "Error alta detalle";
                                ErrorAltaDetalle = true;
                                break;
                            }
                        }
                        //Logica validacion Detalle
                        if (ErrorAltaDetalle != true)
                        {
                            conex.SP_ACTUALIZAR_ENC_RESERVA
                            ( nOPC.Item.Cabecera.Numero
                            , nOPC.Item.Cabecera.Monto
                            , nOPC.Item.Cabecera.Observaciones
                            , nOPC.Item.Cabecera.Ubicacion
                            , nOPC.Item.Cabecera.Estado
                            , p_OUT_CODRET
                            , p_OUT_GLSRET
                            );
                            try
                            {
                                nOPC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                                nOPC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                            }
                            catch (Exception)
                            {
                                nOPC.Retorno.Codigo = 1031;
                                nOPC.Retorno.Glosa = "Error actualizacion Encabezado";
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    nOPC.Retorno.Codigo = 1011;
                    nOPC.Retorno.Glosa = "Error creacion Encabezado";
                }
            } else {
                nOPC.Retorno.Codigo = 100;
                nOPC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nOPC;
        }

        public ContenedorOrdenesPedidoCompleta LlamarSPRescatar(string token)
        {
            ContenedorOrdenesPedidoCompleta LOrdenesPedido = new ContenedorOrdenesPedidoCompleta();

            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from cab in conex.ORDEN_DE_PEDIDO
                                      join det_prod in conex.RRP on cab.NUMERO equals det_prod.NUMERO_OP
                                      orderby cab.RUT_PROVEEDOR, cab.NUMERO
                                      select new
                                      {
                                          RutProveedor = cab.RUT_PROVEEDOR,
                                          NumeroOP     = cab.NUMERO,
                                          FecRecepOP   = cab.EMISION,
                                          MontoOP      = cab.MONTO,
                                          EstadoOP     = cab.ESTADO,
                                          CodProd      = det_prod.CODIGO_PRODUCTO,
                                          CantProd     = det_prod.CANTIDAD,
                                          FecRecProd   = det_prod.RECEPCION,
                                          EstadoProd   = det_prod.CONFIRMADO
                                      }
                            ).ToList();

                    decimal NumeroOrdenAnterior = decimal.MinValue;
                    foreach (var item in collection)
                    {
                        //Verificar Corte de control por Numero de Orden
                        if (NumeroOrdenAnterior != item.NumeroOP)
                        {
                            //Se crea la OrdenCompleta
                            OrdenPedidoCompleta n = new OrdenPedidoCompleta();
                            //Se carga valores de la cabecera
                            n.Cabecera.RutProveedor = item.RutProveedor;
                            n.Cabecera.Numero = item.NumeroOP;
                            n.Cabecera.FechaEmision = item.FecRecepOP;
                            n.Cabecera.Monto = item.MontoOP;
                            n.Cabecera.Estado = item.EstadoOP;

                            //Se crea el detalle Orden
                            OrdenPedidoDetalle m = new OrdenPedidoDetalle();
                            m.RegistroRecepcionPedido.NumeroOrdenPedido = item.NumeroOP;
                            m.RegistroRecepcionPedido.CodigoProducto = item.CodProd;
                            m.RegistroRecepcionPedido.Indice = item.CantProd;
                            m.RegistroRecepcionPedido.Recepcion = item.FecRecProd;
                            m.RegistroRecepcionPedido.Confirmado = item.EstadoProd;
                            
                            //Se agrega el detalle a la cabecera
                            n.ListaDetalle.Add(m);

                            //Se agrega la orden completa a la orden
                            LOrdenesPedido.Lista.Add(n);

                            //Se realiza logica para armar corte de control
                            NumeroOrdenAnterior = item.NumeroOP;
                        }
                        else {
                            //Se crea el detalle Orden
                            OrdenPedidoDetalle m = new OrdenPedidoDetalle();
                            m.RegistroRecepcionPedido.NumeroOrdenPedido = item.NumeroOP;
                            m.RegistroRecepcionPedido.CodigoProducto = item.CodProd;
                            m.RegistroRecepcionPedido.Indice = item.CantProd;
                            m.RegistroRecepcionPedido.Recepcion = item.FecRecProd;
                            m.RegistroRecepcionPedido.Confirmado = item.EstadoProd;

                            //Se agrega el detalle a la ultima orden de compra
                            LOrdenesPedido.Lista.Last().ListaDetalle.Add(m);
                        }
                    }
                    LOrdenesPedido.Retorno.Codigo = 0;
                    LOrdenesPedido.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LOrdenesPedido.Retorno.Codigo = 1011;
                    LOrdenesPedido.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LOrdenesPedido.Retorno.Codigo = 100;
                LOrdenesPedido.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LOrdenesPedido;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Empleado");
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
