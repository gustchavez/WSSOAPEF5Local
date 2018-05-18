using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDOrdenReservaCompleta
    {

        public CRUDOrdenReservaCompleta()
        {
            
        }

        public ContenedorOrdenReservaCompleta LlamarSPCrear(ContenedorOrdenReservaCompleta nOCC)
        {
            var p_OUT_NUMERO = new ObjectParameter("P_OUT_NUMERO", typeof(decimal));
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

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

                    foreach (var item in nOCC.Item.ListaDetalle)
                    {
                        conex.SP_CREAR_DET_RESERVA
                        ( nOCC.Item.Cabecera.Numero
                        , item.Alojamiento.FechaIngreso
                        , item.Alojamiento.FechaEgreso
                        , item.Alojamiento.Observaciones
                        , item.Alojamiento.RutPersona //Puede ponerse cualquier de los 2 ruts Comida o Alojamiento
                        , item.Alojamiento.CodigoCama
                        , item.Comida.FechaRecepcion
                        , item.Comida.Observaciones
                        , item.Comida.CodigoPlato
                        , p_OUT_CODRET
                        , p_OUT_GLSRET
                        );
                        //
                        try
                        {
                            nOCC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                            nOCC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
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

            return nOCC;
        }
    }
}
