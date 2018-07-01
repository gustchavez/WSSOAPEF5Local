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
                                 group h by new { h.CAPACIDAD , h.ESTADO} into g
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
        /*
        create or replace PROCEDURE solic_noTerminadas(cantidadFact out ORDEN_DE_COMPRA.NUMERO%TYPE, 
                cantidadOrdenC out ORDEN_DE_COMPRA.NUMERO%TYPE,
                fecha out ORDEN_DE_COMPRA.RECEPCION%TYPE) 
            is
            CURSOR c1 is select Concat(EXTRACT(month from RECEPCION),concat('-',EXTRACT(year from RECEPCION))) as fechaEjerc from ORDEN_DE_COMPRA 
                    group by EXTRACT(year from RECEPCION) ,EXTRACT(month from RECEPCION)
                    order by Concat(EXTRACT(month from RECEPCION),concat('-',EXTRACT(year from RECEPCION))) desc;
                    tabla c1%rowtype;
        begin
            FOR tabla in c1 LOOP
                fecha:=tabla.fechaEjerc;
                select count(NUMERO_OC) into cantidadFact from FACTURA
                    where Concat(EXTRACT(month from FECHA),concat('-', EXTRACT(year from FECHA)))=tabla.fechaEjerc;
                select count(NUMERO)into cantidadOrdenC from ORDEN_DE_COMPRA
                    where Concat(EXTRACT(month from RECEPCION),concat('-', EXTRACT(year from RECEPCION)))=tabla.fechaEjerc;
            end loop;
        end solic_noTerminadas;
        */
        public List<ComodinJava> Solicitudes_NO_terminadas(string token)
        {

            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from f in conex.FACTURA
                                 join oc in conex.ORDEN_DE_COMPRA on f.NUMERO_OC equals oc.NUMERO
                                 where f.NUMERO_OC != null
                                 group f by f.FECHA into g
                                 orderby g.Key.Year descending, g.Key.Month descending
                                 select new {
                                     FactOC = g.Select(q => q.NUMERO_OC).Count()
                                            , mes = g.Select(q => q.FECHA.Month)
                                            , anno = g.Select(q => q.FECHA.Year)
                                            , Oc = g.Select(q => q.NUMERO).Count()
                                 }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.mes.FirstOrDefault().ToString() + "-"+item.anno.FirstOrDefault().ToString();
                        obj.numero1 = item.FactOC;
                        obj.numero2 = item.Oc;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception e)
                {
                    ComodinJava obj = new ComodinJava();
                    obj.Nombre = "Error=" + e.ToString();
                    lista.Add(obj);
                    return lista;
                }
            }
            else
            {
                ComodinJava obj = new ComodinJava();
                obj.Nombre = "Error Else";
                lista.Add(obj);
                return lista;
            }
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
                                 group f by f.FECHA into g
                                 orderby g.Key.Year descending, g.Key.Month descending
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
                catch (Exception e)
                {
                    ComodinJava obj = new ComodinJava();
                    obj.Nombre = "Error="+e.ToString();
                    lista.Add(obj);
                    return lista;
                }
            }
            else
            {
                ComodinJava obj = new ComodinJava();
                obj.Nombre = "Error Else";
                lista.Add(obj);
                return lista;
            }
        }

        public List<ComodinJava> Promedio_perdida_mensual(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from f in conex.FACTURA
                                 join oc in conex.ORDEN_DE_COMPRA on f.NUMERO_OC equals oc.NUMERO
                                 where f.NUMERO_OC != null
                                 group f by f.FECHA into g
                                 orderby g.Key.Year descending, g.Key.Month descending
                                 select new
                                 {
                                     FactOC = g.Select(q => q.VALOR_BRUTO).Sum()
                                            , mes = g.Select(q => q.FECHA.Month)
                                            , anno = g.Select(q => q.FECHA.Year)
                                            , Oc = g.Select(q => q.ORDEN_DE_COMPRA.MONTO).Sum()
                                 }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.mes.FirstOrDefault().ToString() + "-" + item.anno.FirstOrDefault().ToString();
                        obj.numero1 = item.FactOC;
                        obj.numero2 = item.Oc;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception e)
                {
                    ComodinJava obj = new ComodinJava();
                    obj.Nombre = "Error=" + e.ToString();
                    lista.Add(obj);
                    return lista;
                }
            }
            else
            {
                ComodinJava obj = new ComodinJava();
                obj.Nombre = "Error Else";
                lista.Add(obj);
                return lista;
            }
        }

        public List<ComodinJava> Porcentage_cierre_efectivo(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<ComodinJava> lista = new List<ComodinJava>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from f in conex.FACTURA
                                 join oc in conex.ORDEN_DE_COMPRA on f.NUMERO_OC equals oc.NUMERO
                                 where f.NUMERO_OC != null
                                 group f by f.FECHA into g
                                 orderby g.Key.Year descending, g.Key.Month descending
                                 select new
                                 {
                                     FactOC = g.Select(q => q.VALOR_BRUTO).Count()
                                     , mes = g.Select(q => q.FECHA.Month)
                                     , anno = g.Select(q => q.FECHA.Year)
                                     , Oc = g.Select(q => q.ORDEN_DE_COMPRA.MONTO).Count()
                                     ,totalVenta = g.Select(q => q.VALOR_BRUTO).Sum()
                                     , ventaNoRealizada = g.Select(q => q.ORDEN_DE_COMPRA.MONTO).Sum()
                                 }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        ComodinJava obj = new ComodinJava();
                        obj.Nombre = item.mes.FirstOrDefault().ToString() + "-" + item.anno.FirstOrDefault().ToString();
                        int porcentajeVenta = (item.FactOC * 100)/ item.Oc;
                        obj.numero1 = item.FactOC;
                        obj.numero2 = item.Oc;
                        obj.numero3 = porcentajeVenta;
                        obj.numero4 = item.totalVenta;
                        obj.numero5 = item.ventaNoRealizada;
                        lista.Add(obj);
                    }
                    return lista;
                }
                catch (Exception e)
                {
                    ComodinJava obj = new ComodinJava();
                    obj.Nombre = "Error=" + e.ToString();
                    lista.Add(obj);
                    return lista;
                }
            }
            else
            {
                ComodinJava obj = new ComodinJava();
                obj.Nombre = "Error Else";
                lista.Add(obj);
                return lista;
            }
        }

        public List<String[]> clientes(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<String[]> lista = new List<String[]>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from c in conex.CLIENTE
                                 join em in conex.EMPRESA on c.RUT equals em.RUT
                                 select new
                                    {
                                        rut = em.RUT,
                                        razon_soc = em.RAZON_SOCIAL,
                                        rubro = em.RUBRO,
                                        email = em.EMAIL
                                 }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        String[] cliente = new String[4];
                        cliente[0] = item.rut;
                        cliente[1] = item.razon_soc;
                        cliente[2] = item.rubro;
                        cliente[3] = item.email;
                        lista.Add(cliente);
                    }
                    return lista;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public List<String[]> proveedores(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<String[]> lista = new List<String[]>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = (from c in conex.PROVEEDOR
                                 join em in conex.EMPRESA on c.RUT equals em.RUT

                                 select new
                                 {
                                     rut = em.RUT,
                                     razon_soc = em.RAZON_SOCIAL,
                                     rubro = em.RUBRO,
                                     email = em.EMAIL
                                 }
                                 ).ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        String[] cliente = new String[4];
                        cliente[0] = item.rut;
                        cliente[1] = item.razon_soc;
                        cliente[2] = item.rubro;
                        cliente[3] = item.email;
                        lista.Add(cliente);
                    }
                    return lista;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public List<String[]> log_tabla(String token)
        {
            CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();
            List<String[]> lista = new List<String[]>();
            if (ValidarPerfil(token))
            {
                try
                {
                    var query = conex.Database.SqlQuery<String[]>("SELECT * FROM LOG_TMP").ToList();
                    foreach (var item in query)
                    {
                        // Se selecciona la clase ComodinJava ya que cuenta con una variable String "NOMBRE" y una INT "NUMERO1 y NUMERO2"
                        // Estas se usan solamente como contenedores de la data proveniente de la "query"
                        String[] cliente = new String[4];
                        cliente[0] = item[0].ToString();
                        cliente[1] = item[1].ToString();
                        cliente[2] = item[2].ToString();
                        cliente[3] = item[3].ToString();
                        lista.Add(cliente);
                    }
                    return lista;
                }
                catch (Exception e)
                {
                    
                    return null;
                }
            }
            else
            {
                
                return null;
            }
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
