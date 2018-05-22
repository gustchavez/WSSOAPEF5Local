﻿using System;
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

        [OperationContract]
        ContenedorPerfilUsuarioCliente PerfilUsuarioClienteCrear(ContenedorPerfilUsuarioCliente entrada);

        [OperationContract]
        ContenedorPerfilUsuarioProveedor PerfilUsuarioProveedorCrear(ContenedorPerfilUsuarioProveedor entrada);
        
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

        [OperationContract]
        ContenedorOrdenCompraCompleta OrdenCompraCompletaCrear(ContenedorOrdenCompraCompleta entrada);

        [OperationContract]
        ContenedorOrdenPedidoCompleta OrdenPedidoCompletaCrear(ContenedorOrdenPedidoCompleta entrada);
    }
}
