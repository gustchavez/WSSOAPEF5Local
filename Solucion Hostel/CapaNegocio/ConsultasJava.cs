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

        public ContenedorProductos StockProductos(string token)
        {
            ContenedorProductos LProductos = new ContenedorProductos();
            CRUDProducto crudProd = new CRUDProducto();
            if (ValidarPerfil(token))
            {
                try
                {
                    LProductos = crudProd.LlamarSPRescatar(token);
                }
                catch (Exception)
                {
                    LProductos.Retorno.Codigo = 1011;
                    LProductos.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else
            {
                LProductos.Retorno.Codigo = 100;
                LProductos.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LProductos;
        }

        //String text = "select SERVICIO_COMIDA.TIPO, count(SERVICIO_COMIDA.TIPO)  FROM COMIDA" +
        //    " inner join PLATO on COMIDA.CODIGO_PLATO = PLATO.CODIGO" +
        //    " inner join SERVICIO_COMIDA on PLATO.SERVICIO_TIPO = SERVICIO_COMIDA.TIPO" +
        //    " GROUP by SERVICIO_COMIDA.TIPO" +
        //    " order by count(SERVICIO_COMIDA.TIPO)desc";

        public List<Object> Productos_mas_solicitados(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from c in conex.COMIDA
                                 join p in conex.PLATO on c.CODIGO_PLATO equals p.CODIGO
                                 join s in conex.SERVICIO_COMIDA on p.SERVICIO_TIPO equals s.TIPO
                                 group s by s.TIPO into g
                                 orderby g.Select(x => x.TIPO).Count()
                                 select new { tipo = g.Select(x => x.TIPO), cantidad = g.Select(x => x.TIPO).Count() }).ToList();
                    foreach (var item in query)
                    {
                        Object[] obj = new Object[2];
                        obj[0] = item.tipo;
                        obj[1] = item.cantidad;
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
        public List<Object> Segun_rubro_empresa(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
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
                        Object[] obj = new Object[2];
                        obj[0] = item.rubro;
                        obj[1] = item.cantidad;
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
       
        public List<Object> Metodo_pago_mas_usado(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
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
                        Object[] obj = new Object[2];
                        obj[0] = item.medio;
                        obj[1] = item.cantidad;
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
        public List<Object> Ciudad_mas_solicita_servicios(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
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
                        Object[] obj = new Object[2];
                        obj[0] = item.nombre;
                        obj[1] = item.cantidad;
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

        public List<Object> Estado_habitaciones(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from h in conex.HABITACION
                                 group h by h.ESTADO into g
                                 select new { estado = g.Select(q => q.ESTADO), cantidad = g.Select(q => q.ESTADO).Count() }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        Object[] obj = new Object[2];
                        obj[0] = item.estado;
                        obj[1] = item.cantidad;
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

        public List<Object> Habitaciones_mas_solicitadas(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
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
                        Object[] obj = new Object[2];
                        obj[0] = item.estado;
                        obj[1] = item.cantidad;
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

        public List<Object> Fecha_mayor_auge(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from f in conex.FACTURA
                                 where f.NUMERO_OC != null
                                 group f by f.FECHA into g
                                 select new { fecha = g.Select(q => q.FECHA), cantidad = g.Select(q => q.FECHA).Count(), total = g.Select(q => q.FECHA) }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        Object[] obj = new Object[3];
                        obj[0] = item.fecha;
                        obj[1] = item.cantidad;
                        obj[2] = item.total;
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
        public List<Object> Promedio_venta_mensual(string token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<Object> lista = new List<Object>();
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
                                     fecha = g.Select(q => q.VALOR_BRUTO).Sum() / g.Select(q => q.VALOR_BRUTO).Count()
                                                ,
                                     mes = g.Select(q => q.FECHA.Month),
                                     anno = g.Select(q => q.FECHA.Year)
                                 }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        Object[] obj = new Object[3];
                        obj[0] = item.fecha;
                        obj[1] = item.mes;
                        obj[2] = item.anno;
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
