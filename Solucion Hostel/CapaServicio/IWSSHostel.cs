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

        [OperationContract]
        ContenedorPerfilUsuarioCliente PerfilUsuarioClienteCrear(ContenedorPerfilUsuarioCliente entrada);

        [OperationContract]
        ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorCrear(ContenedorPerfilUsuarioProveedor entrada);

        [OperationContract]
        ContenedorProducto ProductoCrear(ContenedorProducto entrada);

        [OperationContract]
        ContenedorProducto ProductoActualizar(ContenedorProducto entrada);

        [OperationContract]
        ContenedorProducto ProductoEliminar(ContenedorProducto entrada);

        [OperationContract]
        ContenedorProductos ProductoRescatar();

        [OperationContract]
        ContenedorServiciosComida ServicioComidaRescatar();

        [OperationContract]
        ContenedorPlato PlatoCrear(ContenedorPlato entrada);

        [OperationContract]
        ContenedorPlato PlatoActualizar(ContenedorPlato entrada);

        [OperationContract]
        ContenedorPlato PlatoEliminar(ContenedorPlato entrada);

        [OperationContract]
        ContenedorPlatos PlatoRescatar();

        [OperationContract]
        ContenedorHabitacion HabitacionCrear(ContenedorHabitacion entrada);

        [OperationContract]
        ContenedorHabitacion HabitacionActualizar(ContenedorHabitacion entrada);

        [OperationContract]
        ContenedorHabitacion HabitacionEliminar(ContenedorHabitacion entrada);

        [OperationContract]
        ContenedorHabitaciones HabitacionRescatar();

        [OperationContract]
        ContenedorCiudades CiudadRescatar();


    }
}
