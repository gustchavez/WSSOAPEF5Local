using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;

namespace CapaNegocio
{
    public class ConsultasJava
    {
        
        public ConsultasJava()
        {
           
        }

        public List<Producto> StockProductos(string token)
        {

            CRUDProducto crudProd = new CRUDProducto();
            List<Producto> lista = new List<Producto>();
            if (ValidarPerfil(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.PRODUCTO.OrderBy(p => p.DESCRIPCION).ToList();

                    foreach (var item in collection)
                    {
                        Producto n = new Producto();
                        n.Codigo = item.CODIGO;
                        n.Descripcion = item.DESCRIPCION;
                        n.Stock = item.STOCK;
                        n.StockCritico = item.STOCK_CRITICO;
                        lista.Add(n);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                lista = null;
            }

            return lista;
        }

        //String text = "select SERVICIO_COMIDA.TIPO, count(SERVICIO_COMIDA.TIPO)  FROM COMIDA" +
        //    " inner join PLATO on COMIDA.CODIGO_PLATO = PLATO.CODIGO" +
        //    " inner join SERVICIO_COMIDA on PLATO.SERVICIO_TIPO = SERVICIO_COMIDA.TIPO" +
        //    " GROUP by SERVICIO_COMIDA.TIPO" +
        //    " order by count(SERVICIO_COMIDA.TIPO)desc";

        public List<ComodinJava> Productos_mas_solicitados(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from c in conex.COMIDA
                                 join p in conex.PLATO on c.CODIGO_PLATO equals p.CODIGO
                                 join s in conex.SERVICIO_COMIDA on p.SERVICIO_TIPO equals s.TIPO
                                 group s by s.TIPO into g
                                 orderby g.Select(x => x.TIPO).Count()
                                 select new { tipox = g.Select(x => x.TIPO), cantidad = g.Select(x => x.TIPO).Count() }).ToList();

                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.tipox.FirstOrDefault();
                        obj.numero1 = item.cantidad;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        //String text = "select EMPRESA.RUBRO,EMPRESA.RUT from empresa " +
        //    "inner join cliente on EMPRESA.RUT=CLIENTE.RUT";
        public List<ComodinJava> Segun_rubro_empresa(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from e in conex.EMPRESA
                                 join c in conex.CLIENTE on e.RUT equals c.RUT
                                 group e by e.RUBRO into g
                                 select new { rubro = g.Select(q => q.RUBRO), cantidad = g.Select(q => q.RUBRO).Count() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.rubro.FirstOrDefault();
                        obj.numero1 = item.cantidad;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public List<ComodinJava> Metodo_pago_mas_usado(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from p in conex.PAGO
                                 group p by p.MEDIO_PAGO into g
                                 select new { medio = g.Select(q => q.MEDIO_PAGO), cantidad = g.Select(q => q.MEDIO_PAGO).Count() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.medio.FirstOrDefault();
                        obj.numero1 = item.cantidad;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        //ciudad que utiliza mas los servicios (llamar solo el primer arreglo)
        //String text = "select count(NOMBRE_CIUDAD),NOMBRE_CIUDAD from direccion " +
        //    "inner join Empresa on EMPRESA.RUT = direccion.RUT_EMPRESA " +
        //    "inner join   cliente on EMPRESA.RUT = CLIENTE.RUT " +
        //    "group by NOMBRE_CIUDAD order by count(NOMBRE_CIUDAD)desc";
        public List<ComodinJava> Ciudad_mas_solicita_servicios(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from d in conex.DIRECCION
                                 join e in conex.EMPRESA on d.RUT_EMPRESA equals e.RUT
                                 group d by d.NOMBRE_CIUDAD into g
                                 select new { nombre = g.Select(q => q.NOMBRE_CIUDAD), cantidad = g.Select(q => q.NOMBRE_CIUDAD).Count() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.nombre.FirstOrDefault();
                        obj.numero1 = item.cantidad;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        //**********---->Panel habitaciones
        //String text = "select count(CAPACIDAD) as cantidad_habitaciones, CAPACIDAD, ESTADO " +
        //    "from HABITACION " +
        //    "group by CAPACIDAD, ESTADO order by ESTADO";

        public List<ComodinJava> Estado_habitaciones(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from h in conex.HABITACION
                                 group h by h.ESTADO into g
                                 select new { estado = g.Select(q => q.ESTADO), capacidad = g.Select(q => q.CAPACIDAD), cantidad = g.Select(q => q.ESTADO).Count() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.estado.FirstOrDefault();
                        obj.numero1 = item.capacidad.FirstOrDefault();
                        obj.numero2 = item.cantidad;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }


        //String text = "select HABITACION.CAPACIDAD , count(HABITACION.CAPACIDAD) from ALOJAMIENTO " +
        //    "inner join cama on  ALOJAMIENTO.CODIGO_CAMA = cama.CODIGO " +
        //    "inner join HABITACION on habitacion.codigo = cama.CODIGO_HABITACION " +
        //    "group by HABITACION.CAPACIDAD order by count(HABITACION.CAPACIDAD)desc";

        public List<ComodinJava> Habitaciones_mas_solicitadas(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from h in conex.HABITACION
                                 group h by h.ESTADO into g
                                 select new { estado = g.Select(q => q.DESCRIPCION), cantidad = g.Select(q => q.ESTADO).Count() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.estado.FirstOrDefault();
                        obj.numero1 = item.cantidad;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        //String q = "select count(fecha),fecha, sum(valorBruto) \n" +
        //        " from Factura where ordenDeCompra is not null \n" +
        //        " group by fecha order by count(fecha) desc";

        public List<ComodinJava> Fecha_mayor_auge(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from f in conex.FACTURA
                                 where f.NUMERO_OC != null
                                 group f by f.FECHA into g
                                 select new { fecha = g.Select(q => q.FECHA), cantidad = g.Select(q => q.FECHA).Count(), total = g.Select(q => q.VALOR_BRUTO).Sum() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.fecha.FirstOrDefault().ToString();
                        obj.numero1 = item.cantidad;
                        obj.numero2 = item.total;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public string Solicitudes_NO_terminadas()
        {
            String text = "create or replace procedure solic_noTerminadas(cantidad out INTEGER) " +
                "is " +
                "facturas INTEGER:= 0; " +
                "ordenes INTEGER:= 0; " +
                "begin " +
                "select count(ORDEN_DE_COMPRA.NUMERO)into ordenes from ORDEN_DE_COMPRA; " +
                "select count(FACTURA.NUMERO_OC)into facturas from FACTURA " +
                "inner join ORDEN_DE_COMPRA on ORDEN_DE_COMPRA.NUMERO = FACTURA.NUMERO_OC; " +
                "cantidad:= ordenes - facturas; " +
                "end; " +
                "-- " +
                "declare " +
                "aux INTEGER;" +
                "begin " +
                "solic_noTerminadas(aux); " +
                "dbms_output.put_line(aux); " +
                "end; ";
            return text;
        }

        //**********---->Panel Finanzas

        //String q = " select round(sum(valorBruto)/count(valorBruto)),extract(month from fecha),extract(year from fecha)"
        // + " from Factura where ordenDeCompra is not null "
        // + " group by extract(year from fecha), extract(month from fecha) "
        // + " order by extract(year from fecha), extract(month from fecha) desc";
        public List<ComodinJava> Promedio_venta_mensual(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from f in conex.FACTURA
                                 where f.NUMERO_OC != null
                                 group f by new { f.FECHA.Year, f.FECHA.Month } into g
                                 orderby g.Select(q => q.FECHA.Year) descending, g.Select(q => q.FECHA.Month) descending
                                 select new
                                 {
                                     promedio = (g.Select(q => q.VALOR_BRUTO).Sum() / g.Select(q => q.VALOR_BRUTO).Count()),
                                     mes = g.Select(q => q.FECHA.Month),
                                     anno = g.Select(q => q.FECHA.Year)
                                 }
                                 ).ToList();
                    // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                    // Estas se usan solamente como contenedores de la data proveniente de la "query"
                    foreach (var item in query)
                    {
                        ComodinJava obj = new ComodinJava();
                        obj.numero1 = item.promedio;
                        obj.numero2 = item.mes.FirstOrDefault();
                        obj.numero3 = item.anno.FirstOrDefault();
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public string Promedio_perdida_mensual()
        {
            String text = "create or replace procedure promedio_perdida(total out INTEGER) " +
                "is " +
                "valor_fact INTEGER:= 0;" +
                "valor_OC INTEGER:= 0;" +
                "begin " +
                "select sum(VALOR_BRUTO) " +
                "into valor_fact " +
                "from FACTURA where TIPO = 'de Compra' group by TIPO;" +
                "select sum(MONTO)" +
                "into valor_OC " +
                "from ORDEN_DE_COMPRA group by MONTO; " +
                "total:= valor_OC - valor_fact;" +
                "end;" +
                "--" +
                "declare" +
                "aux INTEGER;" +
                "begin" +
                "promedio_perdida(aux);" +
                "dbms_output.put_line(aux);" +
                "end;";
            return text;
        }

        public string Porcentage_cierre_efectivo()
        {
            String text = "create or replace procedure porcentage_cierre(total out INTEGER) " +
                "is" +
                 "valor_fact INTEGER:= 0;" +
             "valor_OC INTEGER:= 0;" +
             "begin" +
                " select count(VALOR_BRUTO)" +
                " into valor_fact" +
                " from FACTURA where TIPO = 'de Compra' group by TIPO;" +
             "select count(MONTO)" +
                " into valor_OC" +
                " from ORDEN_DE_COMPRA group by MONTO;" +
         "total:= round((valor_fact * 100) / valor_OC);" +
             "end;" +
            " --" +
              "   declare" +
             "    aux INTEGER;" +
           "  begin" +
             "    porcentage_cierre(aux);" +
           "  dbms_output.put_line(aux);" +
           "  end; ";
            return text;
        }

        private bool ValidarPerfil(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Administrador");
            Perfiles.Add("Empleado");
            if (x.ValidarPerfil(token, Perfiles))
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
