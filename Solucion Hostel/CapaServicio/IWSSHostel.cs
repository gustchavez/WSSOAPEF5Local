using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaObjeto;

namespace CapaServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSSHostel
    {
        [OperationContract]
        Sesion ValidarLogin(string usuario, string clave); //NegLogin entrada);

        //[OperationContract]
        //string GenerarToken(string usuario, string clave);

        //[OperationContract]
        //bool ValidarToken(string token, List<string> perfiles);

        //[OperationContract]
        //string TokenRecuperarPerfil(string token);

        //Inicio Usuario
        [OperationContract]
        ContenedorUsuarios UsuarioRescatar(string token);
        
        //Fin Usuario

        //Inicio PerfilUsuarioCliente
        [OperationContract]
        ContenedorPerfilUsuarioCliente PerfilUsuarioClienteCrear(ContenedorPerfilUsuarioCliente entrada);

        [OperationContract]
        ContenedorPerfilUsuarioCliente PerfilUsuarioClienteActualizar(ContenedorPerfilUsuarioCliente entrada);

        [OperationContract]
        ContenedorPerfilUsuarioClientes PerfilUsuarioClienteRescatar(string token);

        [OperationContract]
        PerfilUsuarioCliente PerfilUsuarioClienteBuscarPorRut(String rut, String token);
        //Fin PerfilUsuarioCliente

        //Inicio PerfilUsuarioProveedor
        [OperationContract]
        ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorCrear(ContenedorPerfilUsuarioProveedor entrada);

        [OperationContract]
        ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorActualizar(ContenedorPerfilUsuarioProveedor entrada);

        [OperationContract]
        ContenedorPerfilUsuarioProveedores PerfilUsuarioProveedorRescatar(string token);

        [OperationContract]
        PerfilUsuarioProveedor PerfilUsuarioProveedorBuscarPorRut(String rut, String token);
        //Fin PerfilUsuarioProveedor

        //Inicio PerfilUsuarioEmpleado
        [OperationContract]
        ContenedorPerfilUsuarioEmpleado PerfilUsuarioEmpleadoCrear(ContenedorPerfilUsuarioEmpleado entrada);

        [OperationContract]
        ContenedorPerfilUsuarioEmpleado PerfilUsuarioEmpleadoActualizar(ContenedorPerfilUsuarioEmpleado entrada);

        [OperationContract]
        ContenedorPerfilUsuarioEmpleados PerfilUsuarioEmpleadoRescatar(String token);

        //Inicio PerfilUsuarioAdministrador
        [OperationContract]
        ContenedorPerfilUsuarioAdministrador PerfilUsuarioAdministradorCrear(ContenedorPerfilUsuarioAdministrador entrada);

        [OperationContract]
        ContenedorPerfilUsuarioAdministrador PerfilUsuarioAdministradorActualizar(ContenedorPerfilUsuarioAdministrador entrada);

        [OperationContract]
        bool PerfilUsuarioAdministradorEliminar(ContenedorPerfilUsuarioAdministrador nPUA);

        [OperationContract]
        PerfilUsuarioAdministrador PerfilUsuarioAdministradorBuscarPorRut(String rut, String token);

        //[OperationContract]
        //ContenedorPerfilUsuarioAdministradores PerfilUsuarioAdministradorRescatar(string token);
        //Fin PerfilUsuarioAdministrador

        //Inicio Producto
        [OperationContract]
        ContenedorProducto ProductoCrear(ContenedorProducto entrada);

        [OperationContract]
        ContenedorProducto ProductoActualizar(ContenedorProducto entrada);

        [OperationContract]
        ContenedorProducto ProductoEliminar(ContenedorProducto entrada);

        [OperationContract]
        ContenedorProductos ProductoRescatar(string token);
        //Fin Producto

        [OperationContract]
        ContenedorServiciosComida ServicioComidaRescatar(string token);
        
        //Inicio Plato
        [OperationContract]
        ContenedorPlato PlatoCrear(ContenedorPlato entrada);

        [OperationContract]
        ContenedorPlato PlatoActualizar(ContenedorPlato entrada);

        [OperationContract]
        ContenedorPlato PlatoEliminar(ContenedorPlato entrada);

        [OperationContract]
        ContenedorPlatos PlatoRescatar(string token);
        //Fin Plato

        //Inicio Habitacion
        [OperationContract]
        ContenedorHabitacion HabitacionCrear(ContenedorHabitacion entrada);

        [OperationContract]
        ContenedorHabitacion HabitacionActualizar(ContenedorHabitacion entrada);

        [OperationContract]
        ContenedorHabitacion HabitacionEliminar(ContenedorHabitacion entrada);

        [OperationContract]
        ContenedorHabitaciones HabitacionRescatar(string token);

        [OperationContract]
        ContenedorHabDispCant HabitacionHabXCapacidad(string token, DateTime fecIng, DateTime fecEgr);
        //Fin Habitacion

        [OperationContract]
        ContenedorCiudades CiudadRescatar(string token);

        //Inicio Cama
        [OperationContract]
        ContenedorCama CamaCrear(ContenedorCama entrada);

        [OperationContract]
        ContenedorCama CamaActualizar(ContenedorCama entrada);

        [OperationContract]
        ContenedorCama CamaEliminar(ContenedorCama entrada);

        [OperationContract]
        ContenedorCamas CamaRescatar(string token);
        //Fin Cama

        //Ini OrdenCompraCompleta
        [OperationContract]
        ContenedorOrdenCompraCompleta OrdenCompraCompletaCrear(ContenedorOrdenCompraCompleta entrada);

        [OperationContract]
        ContenedorOrdenesCompraCompleta OrdenCompraCompletaRescatar(string token);

        [OperationContract]
        ContenedorAlojamiento AlojConfirHueActualizar(ContenedorAlojamiento entrada);
        //Fin OrdenCompraCompleta

        //Ini OrdenPedidoCompleta
        [OperationContract]
        ContenedorOrdenPedidoCompleta OrdenPedidoCompletaCrear(ContenedorOrdenPedidoCompleta entrada);

        [OperationContract]
        ContenedorOrdenesPedidoCompleta OrdenPedidoCompletaRescatar(string token);

        [OperationContract]
        ContenedorRegistroRecepcionPedido ProdConfirRecepActualizar(ContenedorRegistroRecepcionPedido entrada);
        //Fin OrdenPedidoCompleta

        //Ini FacturaCompraCompleta
        [OperationContract]
        ContenedorFacturaCompraCompleta FacturaCompraCompletaCrear(ContenedorFacturaCompraCompleta entrada);

        [OperationContract]
        ContenedorFacturasCompraCompleta FacturaCompraCompletaRescatar(string token);
        //Fin FacturaCompraCompleta

        //Ini FacturaPedidoCompleta
        [OperationContract]
        ContenedorFacturaPedidoCompleta FacturaPedidoCompletaCrear(ContenedorFacturaPedidoCompleta entrada);

        [OperationContract]
        ContenedorFacturasPedidoCompleta FacturaPedidoCompletaRescatar(string token);
        //Fin FacturaPedidoCompleta


        //Consultas para Apicacion Java

        [OperationContract]
        List<Producto> StockProductos(string token);

        [OperationContract]
        List<ComodinJava> Productos_mas_solicitados(string token);

        [OperationContract]
        List<ComodinJava> Segun_rubro_empresa(string token);

        [OperationContract]
        List<ComodinJava> Metodo_pago_mas_usado(string token);

        [OperationContract]
        List<ComodinJava> Ciudad_mas_solicita_servicios(string token);

        [OperationContract]
        List<ComodinJava> Estado_habitaciones(string token);

        [OperationContract]
        List<ComodinJava> Habitaciones_mas_solicitadas(string token);

        [OperationContract]
        List<ComodinJava> Fecha_mayor_auge(string token);

        [OperationContract]
        List<ComodinJava> SolicitudesNoTerminadas(string token);

        [OperationContract]
        List<ComodinJava> Promedio_venta_mensual(string token);

        [OperationContract]
        List<ComodinJava> PromedioPerdidaMensual(String token);

        [OperationContract]
        List<ComodinJava> PorcentageCierreEfectivo(String token);

        [OperationContract]
        ContenedorProveedores ProveedorRescatar(string token);

        [OperationContract]
        ContenedorClientes ClienteRescatar(string token);

        [OperationContract]
        List<String[]> listaProveedores(String token);

        [OperationContract]
        List<String[]> listaClientes(String token);

        //Inicio Provision
        [OperationContract]
        ContenedorProvision ProvisionCrear(ContenedorProvision entrada);

        [OperationContract]
        ContenedorProvision ProvisionActualizar(ContenedorProvision entrada);

        [OperationContract]
        ContenedorProvision ProvisionEliminar(ContenedorProvision entrada);

        [OperationContract]
        ContenedorProvisiones ProvisionRescatar(string token);
        //Fin Provision
        //Inicio Admin
    }
}
