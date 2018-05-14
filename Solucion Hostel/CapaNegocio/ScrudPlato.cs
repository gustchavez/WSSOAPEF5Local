using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class ScrudPlato
    {
        public ScrudPlato()
        {

        }

        public Plato LlamarSPCrear(Plato nPlato)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
            var p_OUT_CODIGO = new ObjectParameter("P_OUT_CODIGO", typeof(decimal));

            CommonBD.Conexion.SP_CREAR_PLATO
                ( nPlato.Item.Nombre
                , nPlato.Item.Descripcion
                , nPlato.Item.Disponible
                , nPlato.Item.TipoServicio
                , p_OUT_CODRET
                , p_OUT_GLSRET
                , p_OUT_CODIGO
                );

            try
            {
                nPlato.Item.Codigo = decimal.Parse(p_OUT_CODIGO.Value.ToString());
                nPlato.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                nPlato.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                nPlato.Item.Codigo = 0;
                nPlato.Retorno.Codigo = 1011;
                nPlato.Retorno.Glosa = "Err codret ORACLE";
            }

            return nPlato;

        }
        public Plato LlamarSPActualizar(Plato aPlato)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CommonBD.Conexion.SP_ACTUALIZAR_PLATO
                ( aPlato.Item.Codigo
                , aPlato.Item.Nombre
                , aPlato.Item.Descripcion
                , aPlato.Item.Disponible
                , aPlato.Item.TipoServicio
                , p_OUT_CODRET
                , p_OUT_GLSRET
                );

            try
            {
                aPlato.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                aPlato.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                aPlato.Retorno.Codigo = 1011;
                aPlato.Retorno.Glosa = "Err codret ORACLE";
            }

            return aPlato;
        }

        public Plato LlamarSPEliminar(Plato ePlato)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CommonBD.Conexion.SP_ELIMINAR_PLATO
                (ePlato.Item.Codigo
                , p_OUT_CODRET
                , p_OUT_GLSRET
                );

            try
            {
                ePlato.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                ePlato.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                ePlato.Retorno.Codigo = 1011;
                ePlato.Retorno.Glosa = "Err codret ORACLE";
            }

            return ePlato;
        }

        public ListaPlatos LlamarSPRescatar()
        {
            ListaPlatos LPlatos = new ListaPlatos();
            try
            {
                var collection = CommonBD.Conexion.PLATO.OrderBy(p => p.NOMBRE).ToList();

                foreach (var item in collection)
                {
                    ItemPlato n = new ItemPlato();
                    n.Codigo = item.CODIGO;
                    n.Nombre = item.NOMBRE;
                    n.Descripcion = item.DESCRIPCION;
                    n.Disponible = item.DISPONIBLE;
                    n.TipoServicio = item.SERVICIO_TIPO;
                    LPlatos.Platos.Add(n);
                }
                LPlatos.Retorno.Codigo = 0;
                LPlatos.Retorno.Glosa = "OK";
            }
            catch (Exception)
            {
                LPlatos.Retorno.Codigo = 1011;
                LPlatos.Retorno.Glosa = "Err codret ORACLE";
            }

            return LPlatos;
        }


    }
}
