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
                    ( nFPC.Item.Cabecera.NumeroOrdenCompra
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
