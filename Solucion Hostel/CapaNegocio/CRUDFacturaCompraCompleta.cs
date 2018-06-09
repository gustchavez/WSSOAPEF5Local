using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUDFacturaCompraCompleta
    {
        public CRUDFacturaCompraCompleta()
        {

        }

        public ContenedorFacturaCompraCompleta LlamarSPCrear(ContenedorFacturaCompraCompleta nFCC)
        {
            if (ValidarPerfilCUD(nFCC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
                var p_OUT_NUMERO = new ObjectParameter("p_OUT_NUMERO", typeof(decimal));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_FACTURA_COMPRA
                    (nFCC.Item.Cabecera.NumeroOrdenCompra
                    , nFCC.Item.Cabecera.ValorBruto
                    , nFCC.Item.Cabecera.ValorIva
                    , nFCC.Item.Cabecera.ValorNeto
                    , nFCC.Item.Cabecera.Observaciones
                    , nFCC.Item.Cabecera.Ubicacion
                    , nFCC.Item.Pago.MedioPago
                    , nFCC.Item.Pago.Divisa
                    , nFCC.Item.Pago.CodigoISO
                    , nFCC.Item.Pago.Monto
                    , nFCC.Item.Pago.TasaCambioCLP
                    , nFCC.Item.OCRelacionada.Monto
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    , p_OUT_NUMERO
                    );

                try
                {
                    nFCC.Item.Cabecera.Numero = decimal.Parse(p_OUT_NUMERO.Value.ToString());
                    nFCC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nFCC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nFCC.Retorno.Codigo = 1011;
                    nFCC.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                nFCC.Retorno.Codigo = 100;
                nFCC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nFCC;
        }

        public ContenedorFacturasCompraCompleta LlamarSPRescatar(string token)
        {
            ContenedorFacturasCompraCompleta LFacturasCompra = new ContenedorFacturasCompraCompleta();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = (from fac in conex.FACTURA
                                      join pag in conex.PAGO on fac.NUMERO equals pag.NUMERO_FACTURA
                                      join ord_comp in conex.ORDEN_DE_COMPRA on fac.NUMERO_OC equals ord_comp.NUMERO
                                      orderby ord_comp.RUT_CLIENTE, fac.NUMERO
                                      select new
                                      {
                                          RutCliente  = ord_comp.RUT_CLIENTE,
                                          NroFactura  = fac.NUMERO,
                                          FecFactura  = fac.FECHA,
                                          ValorBruto  = fac.VALOR_BRUTO,
                                          ValorIva    = fac.VALOR_IVA,
                                          ValorNeto   = fac.VALOR_NETO,
                                          FormaPago   = pag.MEDIO_PAGO,
                                          NroOrdComp  = ord_comp.NUMERO
                                      }
                            ).ToList();

                    //Se crea la FacturaCompleta

                    foreach (var item in collection)
                    {
                        FacturaCompraCompleta n = new FacturaCompraCompleta();
                        //Se carga valores de la cabecera
                        n.OCRelacionada.RutCliente = item.RutCliente;
                        n.Cabecera.Numero          = item.NroFactura;
                        n.Cabecera.Fecha           = item.FecFactura;
                        n.Cabecera.ValorBruto      = item.ValorBruto;
                        n.Cabecera.ValorIva        = item.ValorIva;
                        n.Cabecera.ValorNeto       = item.ValorNeto;
                        n.Pago.MedioPago           = item.FormaPago;
                        n.OCRelacionada.Numero     = item.NroOrdComp;
                        
                        //Se agrega la orden completa a la orden
                        LFacturasCompra.Lista.Add(n);
                    }
                    
                    LFacturasCompra.Retorno.Codigo = 0;
                    LFacturasCompra.Retorno.Glosa = "OK";

                }
                catch (Exception)
                {
                    LFacturasCompra.Retorno.Codigo = 1011;
                    LFacturasCompra.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LFacturasCompra.Retorno.Codigo = 100;
                LFacturasCompra.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LFacturasCompra;
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
