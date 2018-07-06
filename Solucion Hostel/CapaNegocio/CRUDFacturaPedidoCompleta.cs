using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUDFacturaPedidoCompleta
    {
        public CRUDFacturaPedidoCompleta()
        {

        }

        public ContenedorFacturaPedidoCompleta LlamarSPCrear(ContenedorFacturaPedidoCompleta nFPC)
        {
            if (ValidarPerfilCUD(nFPC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
                var p_OUT_NUMERO = new ObjectParameter("p_OUT_NUMERO", typeof(decimal));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_FACTURA_PEDIDO
                    ( nFPC.Item.Cabecera.NumeroOrdenPedido
                    , nFPC.Item.Cabecera.ValorBruto
                    , nFPC.Item.Cabecera.ValorIva
                    , nFPC.Item.Cabecera.ValorNeto
                    , nFPC.Item.Cabecera.Observaciones
                    , nFPC.Item.Cabecera.Ubicacion
                    , nFPC.Item.Pago.MedioPago
                    , nFPC.Item.Pago.Divisa
                    , nFPC.Item.Pago.CodigoISO
                    , nFPC.Item.Pago.Monto
                    , nFPC.Item.Pago.TasaCambioCLP
                    , nFPC.Item.OPRelacionada.Monto
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_NUMERO
                    );

                try
                {
                    nFPC.Item.Cabecera.Numero = decimal.Parse(p_OUT_NUMERO.Value.ToString());
                    nFPC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nFPC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nFPC.Retorno.Codigo = 1011;
                    nFPC.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                nFPC.Retorno.Codigo = 100;
                nFPC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nFPC;
        }

        public ContenedorFacturaPedidoCompleta LlamarSPActualizar(ContenedorFacturaPedidoCompleta aFPC)
        {
            if (ValidarFecExp(aFPC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_ANULAR_FACTURA_PEDIDO
                    ( aFPC.Item.Cabecera.Numero
                    , aFPC.Item.Cabecera.Observaciones
                    , aFPC.Item.OPRelacionada.Numero
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    );

                try
                {
                    aFPC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    aFPC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    aFPC.Retorno.Codigo = 1011;
                    aFPC.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                aFPC.Retorno.Codigo = 100;
                aFPC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }
            return aFPC;
        }

        public ContenedorFacturasPedidoCompleta LlamarSPRescatar(string token)
        {
            ContenedorFacturasPedidoCompleta LFacturasPedido = new ContenedorFacturasPedidoCompleta();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from fac in conex.FACTURA
                                      join pag in conex.PAGO on fac.NUMERO equals pag.NUMERO_FACTURA
                                      join ord_pedi in conex.ORDEN_DE_PEDIDO on fac.NUMERO_OP equals ord_pedi.NUMERO
                                      orderby ord_pedi.RUT_PROVEEDOR, fac.NUMERO
                                      select new
                                      {
                                          RutProveedor = ord_pedi.RUT_PROVEEDOR,
                                          NroFactura   = fac.NUMERO,
                                          FecFactura   = fac.FECHA,
                                          ValorBruto   = fac.VALOR_BRUTO,
                                          ValorIva     = fac.VALOR_IVA,
                                          ValorNeto    = fac.VALOR_NETO,
                                          EstadoFac    = fac.ESTADO,
                                          FormaPago    = pag.MEDIO_PAGO,
                                          NroOrdPedi   = ord_pedi.NUMERO
                                      }
                            ).ToList();

                    //Se crea la FacturaCompleta

                    foreach (var item in collection)
                    {
                        FacturaPedidoCompleta n = new FacturaPedidoCompleta();
                        //Se carga valores de la cabecera
                        n.OPRelacionada.RutProveedor = item.RutProveedor;
                        n.Cabecera.Numero            = item.NroFactura;
                        n.Cabecera.Fecha             = item.FecFactura;
                        n.Cabecera.ValorBruto        = item.ValorBruto;
                        n.Cabecera.ValorIva          = item.ValorIva;
                        n.Cabecera.ValorNeto         = item.ValorNeto;
                        n.Cabecera.Estado            = item.EstadoFac;
                        n.Pago.MedioPago             = item.FormaPago;
                        n.OPRelacionada.Numero       = item.NroOrdPedi;

                        //Se agrega la orden completa a la orden
                        LFacturasPedido.Lista.Add(n);
                    }

                    LFacturasPedido.Retorno.Codigo = 0;
                    LFacturasPedido.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LFacturasPedido.Retorno.Codigo = 1011;
                    LFacturasPedido.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LFacturasPedido.Retorno.Codigo = 100;
                LFacturasPedido.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LFacturasPedido;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Empleado");
            Perfiles.Add("Proveedor");
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
