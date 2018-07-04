using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CapaPresentacionJAVA
{
    /// <summary>
    /// Descripción breve de WebServicesJAVA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicesJAVA : System.Web.Services.WebService
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

            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();

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

            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<Producto> contenProduc = new List<Producto>();
            var prodList = x.StockProductos(token).ToList();
            return (List<Producto>)prodList;
        }

        [WebMethod]
        public List<ComodinJava> Productos_mas_solicitados(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
        public List<ComodinJava> Solicitudes_NO_terminadas(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.SolicitudesNoTerminadas(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        //**********---->Panel Finanzas

        [WebMethod]
        public List<ComodinJava> Promedio_venta_mensual(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
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
        public List<ComodinJava> Promedio_perdida_mensual(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                var objetos = x.PromedioPerdidaMensual(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
        [WebMethod]
        public List<ComodinJava> Porcentage_cierre_efectivo(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<ComodinJava> lista = new List<ComodinJava>();
            try
            {
                List<ComodinJava> objetos = x.PorcentageCierreEfectivo(token).ToList();
                return (List<ComodinJava>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
        [WebMethod]
        public List<String[]> ListProvee(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<String[]> lista = new List<String[]>();
            try
            {
                List<String[]> objetos = x.listaProveedores(token).ToList();
                return (List<String[]>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
        [WebMethod]
        public List<String[]> ListClient(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<String[]> lista = new List<String[]>();
            try
            {
                List<String[]> objetos = x.listaClientes(token).ToList();
                return (List<String[]>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        [WebMethod]
        public List<String[]> ListUsuarios(String token)
        {
            ServiceReference.WSSHostelClient x = new ServiceReference.WSSHostelClient();
            List<String[]> lista = new List<String[]>();
            try
            {
                List<String[]> objetos = x.ListaUsuario(token).ToList();
                return (List<String[]>)objetos;
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }
    }
}
