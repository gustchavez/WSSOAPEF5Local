using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CrearOrdenCompra
    {
        public HeadOrdenCompra Cabecera { get; set; }
        public List<DetailOrdenCompra> Detalle { get; set; }

        public CrearOrdenCompra()
        {
            Init();
        }

        private void Init()
        {
            this.Cabecera = new HeadOrdenCompra();
            this.Detalle = new List<DetailOrdenCompra>();
        }

        public void Llamar()
        {
            var p_OUT_NUMERO = new ObjectParameter("P_OUT_NUMERO", typeof(decimal));
            var p_OUT_CODRET_E = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET_E = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CommonBD.Conexion.SP_CREAR_ENC_RESERVA
                (Cabecera.RutCliente
                , p_OUT_CODRET_E
                , p_OUT_GLSRET_E
                , p_OUT_NUMERO
                ) ;
            try
            {
                Cabecera.Numero = decimal.Parse(p_OUT_NUMERO.Value.ToString());
                Cabecera.Retorno.Codigo = decimal.Parse(p_OUT_CODRET_E.Value.ToString());
                Cabecera.Retorno.Glosa = p_OUT_GLSRET_E.Value.ToString();

                if (Cabecera.Retorno.Codigo == 0 && Cabecera.Numero > 0)
                {
                    bool ErrorAltaDetalle = false;

                    foreach (var item in this.Detalle)
                    {
                        var p_OUT_CODRET_D = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                        var p_OUT_GLSRET_D = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                        CommonBD.Conexion.SP_CREAR_DET_RESERVA
                        (Cabecera.Numero
                        , item.FecIngAlojamiento
                        , item.FecEgrAlojamiento
                        , item.ObsAlojamiento
                        , Cabecera.RutCliente
                        , item.CodigoCama
                        , item.FecRecepcionComida
                        , item.ObsComida
                        , item.CodPlatoComida
                        , p_OUT_CODRET_D
                        , p_OUT_GLSRET_D
                        );
                        //
                        try
                        {
                            item.Retorno.Codigo = decimal.Parse(p_OUT_CODRET_D.Value.ToString());
                            item.Retorno.Glosa = p_OUT_GLSRET_D.Value.ToString();
                        }
                        catch (Exception)
                        {
                            item.Retorno.Codigo = 1011;
                            item.Retorno.Glosa = "Err codret ORACLE";
                            ErrorAltaDetalle = true;
                            break;
                        }
                    }
                    //Logica validacion Detalle
                    if (ErrorAltaDetalle == true)
                    {
                        Cabecera.Retorno.Codigo = 10121;
                        Cabecera.Retorno.Glosa = "Error alta detalle";
                    }
                    else
                    {
                        CommonBD.Conexion.SP_ACTUALIZAR_ENC_RESERVA
                        (Cabecera.Numero
                        , Cabecera.Monto
                        , Cabecera.Observaciones
                        , Cabecera.Ubicacion
                        , Cabecera.Estado
                        , p_OUT_CODRET_E
                        , p_OUT_GLSRET_E
                        );
                        try
                        {
                            Cabecera.Retorno.Codigo = decimal.Parse(p_OUT_CODRET_E.Value.ToString());
                            Cabecera.Retorno.Glosa = p_OUT_GLSRET_E.Value.ToString();
                        }
                        catch (Exception)
                        {
                            Cabecera.Retorno.Codigo = 1011;
                            Cabecera.Retorno.Glosa = "Err codret ORACLE";
                        }
                    }
                }
            }
            catch (Exception)
            {
                Cabecera.Retorno.Codigo = 1011;
                Cabecera.Retorno.Glosa = "Err codret ORACLE";
            }
        }
    }
}
