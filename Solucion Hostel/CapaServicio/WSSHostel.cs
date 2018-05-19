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

        //public string GenerarToken(string usuario, string clave)
        //{
        //    TokenUsuario x = new TokenUsuario();
        //    return x.Codificar(usuario, clave);
        //    //string key = "{0}-{1}-{2}";
        //    //key = string.Format(key, usuario, clave, DateTime.Now.Ticks);

        //    //byte[] Clave = Encoding.ASCII.GetBytes("12ClaveNoFacil!!");
        //    //byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        //    //byte[] inputBytes = Encoding.ASCII.GetBytes(key);
        //    //byte[] encripted;

        //    //RijndaelManaged cripto = new RijndaelManaged();
        //    //using (MemoryStream ms = new MemoryStream(inputBytes.Length))
        //    //{
        //    //    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
        //    //    {
        //    //        objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
        //    //        objCryptoStream.FlushFinalBlock();
        //    //        objCryptoStream.Close();
        //    //    }
        //    //    encripted = ms.ToArray();
        //    //}
        //    //return Convert.ToBase64String(encripted);
        //}

        public bool ValidarToken(string token, string perfil)
        {
            TokenUsuario x = new TokenUsuario();
            return x.ValidarToken(token, perfil);
            //bool result = false;

            //byte[] Clave = Encoding.ASCII.GetBytes("12ClaveNoFacil!!");
            //byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

            //byte[] inputBytes = Convert.FromBase64String(token);
            //byte[] resultBytes = new byte[inputBytes.Length];
            //string textoLimpio = String.Empty;
            //RijndaelManaged cripto = new RijndaelManaged();
            //using (MemoryStream ms = new MemoryStream(inputBytes))
            //{
            //    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
            //    {
            //        using (StreamReader sr = new StreamReader(objCryptoStream, true))
            //        {
            //            textoLimpio = sr.ReadToEnd();
            //        }
            //    }
            //}
            //string[] values = textoLimpio.Split('-');

            //if (values != null && values.Length == 3)
            //{
            //    string user = values[0];
            //    string pass = values[1];
            //    long ticks;
            //    if (long.TryParse(values[2], out ticks))
            //    {
            //        if ( Math.Abs((new DateTime(ticks) - DateTime.Now).Hours) < 1)
            //        {
            //            result = true;
            //        }
            //    }
            //}

            //return result;
        }

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

        public ContenedorProductos ProductoRescatar()
        {
            CRUDProducto x = new CRUDProducto();
            return x.LlamarSPRescatar();
        }

        public ContenedorServiciosComida ServicioComidaRescatar()
        {
            CRUDServicioComida x = new CRUDServicioComida();
            return x.LlamarSPRescatar();
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

        public ContenedorPlatos PlatoRescatar()
        {
            CRUDPlato x = new CRUDPlato();
            return x.LlamarSPRescatar();
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

        public ContenedorHabitaciones HabitacionRescatar()
        {
            CRUDHabitacion x = new CRUDHabitacion();
            return x.LlamarSPRescatar();
        }
        //Fin Habitacion

        public ContenedorCiudades CiudadRescatar()
        {

            CRUDCiudad x = new CRUDCiudad();

            return x.LlamarSPRescatar();
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

        public ContenedorCamas CamaRescatar()
        {
            CRUDCama x = new CRUDCama();
            return x.LlamarSPRescatar();
        }
        //Fin Cama

        public ContenedorOrdenReservaCompleta OrdenReservaCompletaCrear(ContenedorOrdenReservaCompleta entrada)
        {
            CRUDOrdenReservaCompleta x = new CRUDOrdenReservaCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }

        public ContenedorOrdenPedidoCompleta OrdenPedidoCompletaCrear(ContenedorOrdenPedidoCompleta entrada)
        {
            CRUDOrdenPedidoCompleta x = new CRUDOrdenPedidoCompleta();
            x.LlamarSPCrear(entrada);
            return entrada;
        }
    }
}
