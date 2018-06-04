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

            List<Object> obje = new List<Object>();

            if (nLogin.Retorno.Codigo == 0)
            {
                obje.Add(nLogin.Nombre);
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
        public List<Producto> StockProductos(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<Producto> contenProduc = new List<Producto>();
            var prodList = x.StockProductos(token).ToList();
            return (List<Producto>)prodList;
        }

        [WebMethod]
        public List<ComodinJava> Productos_mas_solicitados(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Productos_mas_solicitados(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        //**********---->Panel Clientes

        [WebMethod]
        public List<ComodinJava> Segun_rubro_empresa(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Segun_rubro_empresa(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }
            return lista;
        }
        [WebMethod]
        public List<ComodinJava> Metodo_pago_mas_usado(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Metodo_pago_mas_usado(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        //ciudad que utiliza mas los servicios (llamar solo el primer arreglo)
        [WebMethod]
        public List<ComodinJava> Ciudad_mas_solicita_servicios(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Ciudad_mas_solicita_servicios(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        ////Genero no va

        [WebMethod]
        public List<ComodinJava> Promedio_Edad(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Ciudad_mas_solicita_servicios(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        //**********---->Panel habitaciones

        [WebMethod]
        public List<ComodinJava> Estado_habitaciones(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Estado_habitaciones(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        [WebMethod]
        public List<ComodinJava> Habitaciones_mas_solicitadas(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Habitaciones_mas_solicitadas(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
        [WebMethod]
        public List<ComodinJava> Fecha_mayor_auge(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Fecha_mayor_auge(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
        [WebMethod]
        public string Solicitudes_NO_terminadas(String token)
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
        public List<ComodinJava> Promedio_venta_mensual(String token)
        {
            WSSoap.WSSHostelClient x = new WSSoap.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.Promedio_venta_mensual(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
        [WebMethod]
        public string Promedio_perdida_mensual(String token)
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
        public string Porcentage_cierre_efectivo(String token)
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
