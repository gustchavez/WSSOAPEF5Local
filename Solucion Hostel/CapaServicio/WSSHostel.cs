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

        //CRUD PerfilUsuarioCliente - INI
        public ContenedorPerfilUsuarioCliente PerfilUsuarioClienteCrear(ContenedorPerfilUsuarioCliente entrada)
        {
            CRUDPerfilUsuarioCliente x = new CRUDPerfilUsuarioCliente();
            x.LlamarSPCrear(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioCliente PerfilUsuarioClienteActualizar(ContenedorPerfilUsuarioCliente entrada)
        {
            CRUDPerfilUsuarioCliente x = new CRUDPerfilUsuarioCliente();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioClientes PerfilUsuarioClienteRescatar(string token)
        {
            CRUDPerfilUsuarioCliente x = new CRUDPerfilUsuarioCliente();
            return x.LlamarSPRescatar(token);
        }

        public PerfilUsuarioCliente PerfilUsuarioClienteBuscarPorRut(String rut, String token)
        {
            CRUDPerfilUsuarioCliente x = new CRUDPerfilUsuarioCliente();
            return x.buscarClientePorRut(rut,token);
        }

        //CRUD PerfilUsuarioCliente - FIN

        //CRUD PerfilUsuarioProveedor - INI
        public ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorCrear(ContenedorPerfilUsuarioProveedor entrada)
        {
            CRUDPerfilUsuarioProveedor x = new CRUDPerfilUsuarioProveedor();
            x.LlamarSPCrear(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorActualizar(ContenedorPerfilUsuarioProveedor entrada)
        {
            CRUDPerfilUsuarioProveedor x = new CRUDPerfilUsuarioProveedor();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioProveedores PerfilUsuarioProveedorRescatar(string token)
        {
            CRUDPerfilUsuarioProveedor x = new CRUDPerfilUsuarioProveedor();
            return x.LlamarSPRescatar(token);
        }
        public PerfilUsuarioProveedor PerfilUsuarioProveedorBuscarPorRut(String rut, String token)
        {
            CRUDPerfilUsuarioProveedor x = new CRUDPerfilUsuarioProveedor();
            return x.buscarProveedorPorRut(rut,token);
        }
        //CRUD PerfilUsuarioProveedor - FIN

        //CRUD PerfilUsuarioEmpleado - INI
        public ContenedorPerfilUsuarioEmpleado PerfilUsuarioEmpleadoCrear(ContenedorPerfilUsuarioEmpleado entrada)
        {
            CRUDPerfilUsuarioEmpleado x = new CRUDPerfilUsuarioEmpleado();
            x.LlamarSPCrear(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioEmpleado PerfilUsuarioEmpleadoActualizar(ContenedorPerfilUsuarioEmpleado entrada)
        {
            CRUDPerfilUsuarioEmpleado x = new CRUDPerfilUsuarioEmpleado();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioEmpleados PerfilUsuarioEmpleadoRescatar(String token)
        {
            CRUDPerfilUsuarioEmpleado x = new CRUDPerfilUsuarioEmpleado();
            return x.LlamarSPRescatar(token);
        }
        //public ContenedorPerfilUsuarioEmpleados PerfilUsuarioEmpleadoRescatar(string token)
        //{
        //    CRUDPerfilUsuarioEmpleado x = new CRUDPerfilUsuarioEmpleado();
        //    return x.LlamarSPRescatar(token);
        //}
        //CRUD PerfilUsuarioEmpleado - FIN

        //CRUD PerfilUsuarioAdministrador - INI
        public ContenedorPerfilUsuarioAdministrador PerfilUsuarioAdministradorCrear(ContenedorPerfilUsuarioAdministrador entrada)
        {
            CRUDPerfilUsuarioAdministrador x = new CRUDPerfilUsuarioAdministrador();
            x.LlamarSPCrearAdmin(entrada);
            return entrada;
        }
        public ContenedorPerfilUsuarioAdministrador PerfilUsuarioAdministradorActualizar(ContenedorPerfilUsuarioAdministrador entrada)
        {
            CRUDPerfilUsuarioAdministrador x = new CRUDPerfilUsuarioAdministrador();
            x.LlamarSPActualizar(entrada);
            return entrada;
        }
        public bool PerfilUsuarioAdministradorEliminar(ContenedorPerfilUsuarioAdministrador nPUA)
        {
            CRUDPerfilUsuarioAdministrador x = new CRUDPerfilUsuarioAdministrador();
            return x.eliminarUsuario(nPUA);
        }
        public PerfilUsuarioAdministrador PerfilUsuarioAdministradorBuscarPorRut(String rut, String token)
        {
            CRUDPerfilUsuarioAdministrador x = new CRUDPerfilUsuarioAdministrador();
            return x.buscarAdministradorPorRut(rut, token);
        }
        //public ContenedorPerfilUsuarioAdministradores PerfilUsuarioAdministradorRescatar(string token)
        //{
        //    CRUDPerfilUsuarioAdministrador x = new CRUDPerfilUsuarioAdministrador();
        //    return x.LlamarSPRescatar(token);
        //}
        //CRUD PerfilUsuarioAdministrador - FIN

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

        public ContenedorHabDispCant HabitacionHabXCapacidad(string token, DateTime fecIng, DateTime fecEgr)
        {
            CRUDHabitacion x = new CRUDHabitacion();
            return x.LlamarSPHabitaHabXCapacidad(token, fecIng, fecEgr);
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

        //Ini OrdenCompraCompleta
        public ContenedorOrdenCompraCompleta OrdenCompraCompletaCrear(ContenedorOrdenCompraCompleta entrada)
        {
            CRUDOrdenCompraCompleta x = new CRUDOrdenCompraCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }
        public ContenedorOrdenesCompraCompleta OrdenCompraCompletaRescatar(string token)
        {
            CRUDOrdenCompraCompleta x = new CRUDOrdenCompraCompleta();
            return x.LlamarSPRescatar(token);
        }
        public ContenedorAlojamiento AlojConfirHueActualizar(ContenedorAlojamiento entrada)
        {
            CRUDOrdenCompraCompleta x = new CRUDOrdenCompraCompleta();
            return x.LlamarSPActIngHuesped(entrada);
        }
        //Fin OrdenCompraCompleta

        //Ini OrdenPedidoCompleta
        public ContenedorOrdenPedidoCompleta OrdenPedidoCompletaCrear(ContenedorOrdenPedidoCompleta entrada)
        {
            CRUDOrdenPedidoCompleta x = new CRUDOrdenPedidoCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorOrdenesPedidoCompleta OrdenPedidoCompletaRescatar(string token)
        {
            CRUDOrdenPedidoCompleta x = new CRUDOrdenPedidoCompleta();
            return x.LlamarSPRescatar(token);
        }

        public ContenedorRegistroRecepcionPedido ProdConfirRecepActualizar(ContenedorRegistroRecepcionPedido entrada)
        {
            CRUDOrdenPedidoCompleta x = new CRUDOrdenPedidoCompleta();
            return x.LlamarSPActRecepProd(entrada);
        }
        
        //Fin OrdenPedidoCompleta


        //Ini FacturaCompraCompleta
        public ContenedorFacturaCompraCompleta FacturaCompraCompletaCrear(ContenedorFacturaCompraCompleta entrada)
        {
            CRUDFacturaCompraCompleta x = new CRUDFacturaCompraCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }
        public ContenedorFacturasCompraCompleta FacturaCompraCompletaRescatar(string token)
        {
            CRUDFacturaCompraCompleta x = new CRUDFacturaCompraCompleta();
            return x.LlamarSPRescatar(token);
        }
        //Fin FacturaCompraCompleta

        //Ini FacturaPedidoCompleta
        public ContenedorFacturaPedidoCompleta FacturaPedidoCompletaCrear(ContenedorFacturaPedidoCompleta entrada)
        {
            CRUDFacturaPedidoCompleta x = new CRUDFacturaPedidoCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorFacturasPedidoCompleta FacturaPedidoCompletaRescatar(string token)
        {
            CRUDFacturaPedidoCompleta x = new CRUDFacturaPedidoCompleta();
            return x.LlamarSPRescatar(token);
        }
        //Fin FacturaPedidoCompleta


        //Consultas para Apicacion Java

        public List<Producto> StockProductos(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.StockProductos(token);
        }

        public List<ComodinJava> Productos_mas_solicitados(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Productos_mas_solicitados(token);
        }

        public List<ComodinJava> Segun_rubro_empresa(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Segun_rubro_empresa(token);
        }

        public List<ComodinJava> Metodo_pago_mas_usado(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Metodo_pago_mas_usado(token);
        }

        public List<ComodinJava> Ciudad_mas_solicita_servicios(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Ciudad_mas_solicita_servicios(token);
        }

        public List<ComodinJava> Estado_habitaciones(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Estado_habitaciones(token);
        }

        public List<ComodinJava> Habitaciones_mas_solicitadas(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Habitaciones_mas_solicitadas(token);
        }

        public List<ComodinJava> Fecha_mayor_auge(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Fecha_mayor_auge(token);
        }

        public List<ComodinJava> SolicitudesNoTerminadas(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Solicitudes_NO_terminadas(token);
        }

        public List<ComodinJava> Promedio_venta_mensual(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Promedio_venta_mensual(token);
        }

        public List<ComodinJava> PromedioPerdidaMensual(String token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Promedio_perdida_mensual(token);
        }

        public List<ComodinJava> PorcentageCierreEfectivo(String token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.Porcentage_cierre_efectivo(token);
        }

        public ContenedorProveedores ProveedorRescatar(string token)
        {
            CRUDProveedor x = new CRUDProveedor();
            return x.LlamarSPRescatar(token);
        }

        public ContenedorClientes ClienteRescatar(string token)
        {
            CRUDCliente x = new CRUDCliente();
            return x.LlamarSPRescatar(token);
        }
        public List<String[]> listaClientes(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.clientes(token);
        }
        public List<String[]> listaProveedores(string token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.proveedores(token); 
        }

        public List<String[]> ListaUsuario(String token)
        {
            ConsultasJava cj = new ConsultasJava();
            return cj.ListaUsuarios(token);
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
