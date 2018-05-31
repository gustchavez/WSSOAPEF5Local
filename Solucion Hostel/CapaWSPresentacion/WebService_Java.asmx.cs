using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaWSPresentacion
{
    /// <summary>
    /// Descripción breve de WebService_Java
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService_Java : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        //**********------> Login

        [WebMethod]
        public List<Object> ValidarLogin(String nombre, String clave)
        {

            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();

            Sesion nLogin = new Sesion();

            nLogin.Usuario = nombre;
            nLogin.Clave = clave;

            nLogin = x.ValidarLogin(nombre, clave);

            List<Object> obje=new List<Object>();

            if (nLogin.Retorno.Codigo == 0)
            {
                obje.Add( nLogin.Nombre);
                obje.Add(nLogin.Apellido);
                obje.Add(nLogin.Perfil);
                obje.Add(nLogin.Retorno.Token);
                obje.Add(nLogin.Retorno.Codigo.ToString());              
            }
            else
            {
                obje = null;
            }            
            return obje;
        }

        //**********----> Panel Productos

        [WebMethod]
        public ContenedorProductos StockProductos(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            ContenedorProductos contenProduc = new ContenedorProductos();
            contenProduc = x.StockProductos(token);
            return contenProduc;
        }

        [WebMethod]
        public List<Object> Productos_mas_solicitados(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<Object> lista = new List<object>();
            try
            {
                var objetos = x.Productos_mas_solicitados(token);
                foreach (var item in objetos)
                {
                    lista.Add(item);
                }
            }
            catch (Exception)
            {
                lista = null;
            }
            
            
            return lista;
        }

        //**********---->Panel Clientes

        [WebMethod]
        public List<Object> Segun_rubro_empresa(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<Object> lista = new List<object>();
            try
            {
                var objetos = x.Segun_rubro_empresa(token);
                foreach (var item in objetos)
                {
                    lista.Add(item);
                }
            }
            catch (Exception)
            {
                lista = null;
            }


            return lista;
        }
        [WebMethod]
        public string Metodo_pago_mas_usado()
        {
            String text = "Pendiente tabla";
            return text;
        }

        //ciudad que utiliza mas los servicios (llamar solo el primer arreglo)
        [WebMethod]
        public string Ciudad_mas_solicita_servicios()
        {
            String text = "select count(NOMBRE_CIUDAD),NOMBRE_CIUDAD from direccion " +
                "inner join Empresa on EMPRESA.RUT = direccion.RUT_EMPRESA " +
                "inner join   cliente on EMPRESA.RUT = CLIENTE.RUT " +
                "group by NOMBRE_CIUDAD order by count(NOMBRE_CIUDAD)desc";
            return text;
        }

        ////Genero no va

        [WebMethod]
        public string Promedio_Edad()
        {
            String text = "SELECT round(AVG(EXTRACT(YEAR FROM sysdate)-EXTRACT(YEAR FROM PERSONA.NACIMIENTO))) As Prom_Edad FROM persona";
            return text;
        }

        //**********---->Panel habitaciones

        [WebMethod]
        public string Estado_habitaciones()
        {
            String text = "select count(CAPACIDAD) as cantidad_habitaciones, CAPACIDAD, ESTADO " +
                "from HABITACION " +
                "group by CAPACIDAD, ESTADO order by ESTADO";
            return text;
        }

        [WebMethod]
        public string Habitaciones_mas_solicitadas()
        {
            String text = "select HABITACION.CAPACIDAD , count(HABITACION.CAPACIDAD) from ALOJAMIENTO " +
                "inner join cama on  ALOJAMIENTO.CODIGO_CAMA = cama.CODIGO " +
                "inner join HABITACION on habitacion.codigo = cama.CODIGO_HABITACION " +
                "group by HABITACION.CAPACIDAD order by count(HABITACION.CAPACIDAD)desc";
            return text;
        }
        [WebMethod]
        public string Fecha_mayor_auge()
        {
            String text = "select count(NUMERO),FECHA, sum(VALOR_BRUTO) " +
                "from FACTURA where TIPO = 'de Compra' " +
                "group by FECHA order by count(NUMERO) desc";
            return text;
        }
        [WebMethod]
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

        [WebMethod]
        public string Promedio_venta_mensual()
        {
            String text = "select round(sum(VALOR_BRUTO)/count(VALOR_BRUTO)),FECHA " +
                "from FACTURA where TIPO = 'de Compra' group by FECHA order by FECHA desc";
            return text;
        }
        [WebMethod]
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
        [WebMethod]
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
    }
}
