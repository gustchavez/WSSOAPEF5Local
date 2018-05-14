using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class ScrudProducto
    {
        public ScrudProducto()
        {

        }

        public Producto LlamarSPCrear(Producto nProducto)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));
            var p_OUT_CODIGO = new ObjectParameter("P_OUT_CODIGO", typeof(decimal));

            CommonBD.Conexion.SP_CREAR_PRODUCTO
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
        public Producto LlamarSPActualizar(Producto aProducto)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CommonBD.Conexion.SP_ACTUALIZAR_PRODUCTO
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

        public Producto LlamarSPEliminar(Producto eProducto)
        {
            var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
            var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

            CommonBD.Conexion.SP_ELIMINAR_PRODUCTO
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

        public ListaProductos LlamarSPRescatar()
        {
            ListaProductos LProductos = new ListaProductos();
            try
            {
                var collection = CommonBD.Conexion.PRODUCTO.OrderBy(p => p.DESCRIPCION).ToList();

                foreach (var item in collection)
                {
                    ItemProducto n = new ItemProducto();
                    n.Codigo = item.CODIGO;
                    n.Descripcion = item.DESCRIPCION;
                    n.Precio = item.PRECIO;
                    n.Stock = item.STOCK;
                    n.StockCritico = item.STOCK_CRITICO;
                    LProductos.Productos.Add(n);
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
