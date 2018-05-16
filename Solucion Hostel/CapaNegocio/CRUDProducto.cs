using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDProducto
    {
        public CRUDProducto()
        {

        }

        public ContenedorProducto LlamarSPCrear(ContenedorProducto nProducto)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
            var p_OUT_CODIGO = new ObjectParameter("P_OUT_CODIGO", typeof(decimal));

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

            conex.SP_CREAR_PRODUCTO
                (nProducto.Item.Descripcion
                , nProducto.Item.Precio
                , nProducto.Item.Stock
                , nProducto.Item.StockCritico
                , p_OUT_CODRET
                , p_OUT_GLSRET
                , p_OUT_CODIGO
                );

            try
            {
                nProducto.Item.Codigo = decimal.Parse(p_OUT_CODIGO.Value.ToString());
                nProducto.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                nProducto.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                nProducto.Item.Codigo = 0;
                nProducto.Retorno.Codigo = 1011;
                nProducto.Retorno.Glosa = "Err codret ORACLE";
            }

            return nProducto;

        }
        public ContenedorProducto LlamarSPActualizar(ContenedorProducto aProducto)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

            conex.SP_ACTUALIZAR_PRODUCTO
                ( aProducto.Item.Codigo
                , aProducto.Item.Descripcion
                , aProducto.Item.Precio
                , aProducto.Item.Stock
                , aProducto.Item.StockCritico
                , p_OUT_CODRET
                , p_OUT_GLSRET
                );

            try
            {
                aProducto.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                aProducto.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                aProducto.Retorno.Codigo = 1011;
                aProducto.Retorno.Glosa = "Err codret ORACLE";
            }

            return aProducto;
        }

        public ContenedorProducto LlamarSPEliminar(ContenedorProducto eProducto)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

            conex.SP_ELIMINAR_PRODUCTO
                ( eProducto.Item.Codigo
                , p_OUT_CODRET
                , p_OUT_GLSRET
                );

            try
            {
                eProducto.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                eProducto.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
            }
            catch (Exception)
            {
                eProducto.Retorno.Codigo = 1011;
                eProducto.Retorno.Glosa = "Err codret ORACLE";
            }

            return eProducto;
        }

        public ContenedorProductos LlamarSPRescatar()
        {
            ContenedorProductos LProductos = new ContenedorProductos();
            try
            {
                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                var collection = conex.PRODUCTO.OrderBy(p => p.DESCRIPCION).ToList();

                foreach (var item in collection)
                {
                    Producto n = new Producto();
                    n.Codigo = item.CODIGO;
                    n.Descripcion = item.DESCRIPCION;
                    n.Precio = item.PRECIO;
                    n.Stock = item.STOCK;
                    n.StockCritico = item.STOCK_CRITICO;
                    LProductos.Lista.Add(n);
                }
                LProductos.Retorno.Codigo = 0;
                LProductos.Retorno.Glosa = "OK";
            }
            catch (Exception)
            {
                LProductos.Retorno.Codigo = 1011;
                LProductos.Retorno.Glosa = "Err codret ORACLE";
            }

            return LProductos;
        }
    }
}
