using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaNegocio;
using CapaObjeto;
using System.Security.Cryptography;
using System.IO;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class WSSHostel : IWSSHostel
    {
        public Sesion ValidarLogin(string usuario, string clave) //NegLogin entrada)
        {
            ValidarLoginUsuario x = new ValidarLoginUsuario();

            x.DatosLogin.Usuario = usuario; // entrada.Usuario;
            x.DatosLogin.Clave = clave; // entrada.Clave;

            x.LlamarSP();

            return x.DatosLogin;
        }

        //public bool ValidarToken(string token, List<string> perfiles)
        //{
        //    TokenUsuario x = new TokenUsuario();
        //    return x.ValidarPerfil(token, perfiles);
        //}

        //public string TokenRecuperarPerfil(string token)
        //{
        //    TokenUsuario x = new TokenUsuario();
        //    return x.LeerPerfil(token);
        //}

        public ContenedorPerfilUsuarioCliente PerfilUsuarioClienteCrear(ContenedorPerfilUsuarioCliente entrada)
        {
            CRUDPerfilUsuarioCliente x = new CRUDPerfilUsuarioCliente();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorCrear(ContenedorPerfilUsuarioProveedor entrada)
        {
            CRUDPerfilUsuarioProveedor x = new CRUDPerfilUsuarioProveedor();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        //CRUD Producto - INI
        public ContenedorProducto ProductoCrear(ContenedorProducto entrada)
        {
            CRUDProducto x = new CRUDProducto();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorProducto ProductoActualizar(ContenedorProducto entrada)
        {
            CRUDProducto x = new CRUDProducto();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }

        public ContenedorProducto ProductoEliminar(ContenedorProducto entrada)
        {
            CRUDProducto x = new CRUDProducto();
            x.LlamarSPEliminar(entrada);
            return entrada;
        }

        public ContenedorProductos ProductoRescatar(string token)
        {
            CRUDProducto x = new CRUDProducto();
            return x.LlamarSPRescatar(token);
        }
        //CRUD Producto - FIN

        public ContenedorServiciosComida ServicioComidaRescatar(string token)
        {
            CRUDServicioComida x = new CRUDServicioComida();
            return x.LlamarSPRescatar(token);
        }
        
        public ContenedorPlato PlatoCrear(ContenedorPlato entrada)
        {
            CRUDPlato x = new CRUDPlato();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorPlato PlatoActualizar(ContenedorPlato entrada)
        {
            CRUDPlato x = new CRUDPlato();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }

        public ContenedorPlato PlatoEliminar(ContenedorPlato entrada)
        {
            CRUDPlato x = new CRUDPlato();
            x.LlamarSPEliminar(entrada);
            return entrada;
        }

        public ContenedorPlatos PlatoRescatar(string token)
        {
            CRUDPlato x = new CRUDPlato();
            return x.LlamarSPRescatar(token);
        }

        //Inicio Habitacion
        public ContenedorHabitacion HabitacionCrear(ContenedorHabitacion entrada)
        {
            CRUDHabitacion x = new CRUDHabitacion();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorHabitacion HabitacionActualizar(ContenedorHabitacion entrada)
        {
            CRUDHabitacion x = new CRUDHabitacion();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }

        public ContenedorHabitacion HabitacionEliminar(ContenedorHabitacion entrada)
        {
            CRUDHabitacion x = new CRUDHabitacion();
            x.LlamarSPEliminar(entrada);
            return entrada;
        }

        public ContenedorHabitaciones HabitacionRescatar(string token)
        {
            CRUDHabitacion x = new CRUDHabitacion();
            return x.LlamarSPRescatar(token);
        }
        //Fin Habitacion

        public ContenedorCiudades CiudadRescatar(string token)
        {

            CRUDCiudad x = new CRUDCiudad();

            return x.LlamarSPRescatar(token);
        }
        
        //Inicio Cama
        public ContenedorCama CamaCrear(ContenedorCama entrada)
        {
            CRUDCama x = new CRUDCama();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorCama CamaActualizar(ContenedorCama entrada)
        {
            CRUDCama x = new CRUDCama();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }

        public ContenedorCama CamaEliminar(ContenedorCama entrada)
        {
            CRUDCama x = new CRUDCama();
            x.LlamarSPEliminar(entrada);
            return entrada;
        }

        public ContenedorCamas CamaRescatar(string token)
        {
            CRUDCama x = new CRUDCama();
            return x.LlamarSPRescatar(token);
        }
        //Fin Cama

        public ContenedorOrdenCompraCompleta OrdenCompraCompletaCrear(ContenedorOrdenCompraCompleta entrada)
        {
            CRUDOrdenCompraCompleta x = new CRUDOrdenCompraCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorOrdenPedidoCompleta OrdenPedidoCompletaCrear(ContenedorOrdenPedidoCompleta entrada)
        {
            CRUDOrdenPedidoCompleta x = new CRUDOrdenPedidoCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        //Consultas para Apicacion Java

        public ContenedorProductos StockProductos(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.StockProductos(token);
        }

        public List<object> Productos_mas_solicitados(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Productos_mas_solicitados(token);
        }

        public List<object> Segun_rubro_empresa(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Segun_rubro_empresa(token);
        }

        public List<object> Metodo_pago_mas_usado(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Metodo_pago_mas_usado(token);
        }

        public List<object> Ciudad_mas_solicita_servicios(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Ciudad_mas_solicita_servicios(token);
        }

        public List<object> Estado_habitaciones(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Estado_habitaciones(token);
        }

        public List<object> Habitaciones_mas_solicitadas(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Habitaciones_mas_solicitadas(token);
        }

        public List<object> Fecha_mayor_auge(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Fecha_mayor_auge(token);
        }

        public string Solicitudes_NO_terminadas()
        {
            throw new NotImplementedException();
        }

        public List<object> Promedio_venta_mensual(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Promedio_venta_mensual(token);
        }

        public string Promedio_perdida_mensual()
        {
            throw new NotImplementedException();
        }

        public string Porcentage_cierre_efectivo()
        {
            throw new NotImplementedException();
        }

        public ContenedorProveedores ProveedorRescatar(string token)
        {
            CRUDProveedor x = new CRUDProveedor();
            return x.LlamarSPRescatar(token);
        }

        //CRUD Provision - INI
        public ContenedorProvision ProvisionCrear(ContenedorProvision entrada)
        {
            CRUDProvision x = new CRUDProvision();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorProvision ProvisionActualizar(ContenedorProvision entrada)
        {
            CRUDProvision x = new CRUDProvision();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }

        public ContenedorProvision ProvisionEliminar(ContenedorProvision entrada)
        {
            CRUDProvision x = new CRUDProvision();
            x.LlamarSPEliminar(entrada);
            return entrada;
        }

        public ContenedorProvisiones ProvisionRescatar(string token)
        {
            CRUDProvision x = new CRUDProvision();
            return x.LlamarSPRescatar(token);
        }
        //CRUD Provision - FIN
    }
}
