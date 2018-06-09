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
