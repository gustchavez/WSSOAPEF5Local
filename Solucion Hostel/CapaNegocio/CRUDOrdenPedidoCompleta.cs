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
