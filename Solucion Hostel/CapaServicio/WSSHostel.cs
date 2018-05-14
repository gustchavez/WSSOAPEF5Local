using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaNegocio;
using CapaObjeto;

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
        public PerfilCliente CrearCliente(PerfilCliente value)
        {
            CrearPerfilCliente x = new CrearPerfilCliente();
            x.DatoCliente.RutEmpresa = value.RutEmpresa;
            x.DatoCliente.RazonSocial = value.RazonSocial;
            x.DatoCliente.Giro = value.Giro;
            x.DatoCliente.EmailEmpresa = value.EmailEmpresa;
            x.DatoCliente.TelefonoEmpresa = value.TelefonoEmpresa;
            x.DatoCliente.Logo = value.Logo;
            x.DatoCliente.RutPersona = value.RutPersona;
            x.DatoCliente.Nombre = value.Nombre;
            x.DatoCliente.Apellido = value.Apellido;
            x.DatoCliente.Nacimiento = value.Nacimiento;
            x.DatoCliente.EmailPersona = value.EmailPersona;
            x.DatoCliente.TelofonoPersona = value.TelofonoPersona;
            x.DatoCliente.Calle = value.Calle;
            x.DatoCliente.Numero = value.Numero;
            x.DatoCliente.Comuna = value.Comuna;
            x.DatoCliente.CodPostal = value.CodPostal;
            x.DatoCliente.NombreCiudad = value.NombreCiudad;
            x.DatoCliente.CodPais = value.CodPais;
            x.DatoCliente.Clave = value.Clave;

            x.LlamarSP();

            return x.DatoCliente;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Producto ProductoCrear(Producto entrada)
        {
            ScrudProducto x = new ScrudProducto();

            x.LlamarSPCrear(entrada);

            return entrada;
        }

        public Producto ProductoActualizar(Producto entrada)
        {
            ScrudProducto x = new ScrudProducto();

            x.LlamarSPActualizar(entrada);

            return entrada;
        }

        public Producto ProductoEliminar(Producto entrada)
        {
            ScrudProducto x = new ScrudProducto();

            x.LlamarSPEliminar(entrada);

            return entrada;
        }

        public ListaProductos ProductoRescatar()
        {

            ScrudProducto x = new ScrudProducto();

            return x.LlamarSPRescatar();
        }

        public ListaServicioComida ServicioComidaRescatar()
        {

            ScrudServicioComida x = new ScrudServicioComida();

            return x.LlamarSPRescatar();
        }

        public Plato PlatoCrear(Plato entrada)
        {
            ScrudPlato x = new ScrudPlato();

            x.LlamarSPCrear(entrada);

            return entrada;
        }

        public Plato PlatoActualizar(Plato entrada)
        {
            ScrudPlato x = new ScrudPlato();

            x.LlamarSPActualizar(entrada);

            return entrada;
        }

        public Plato PlatoEliminar(Plato entrada)
        {
            ScrudPlato x = new ScrudPlato();

            x.LlamarSPEliminar(entrada);

            return entrada;
        }

        public ListaPlatos PlatoRescatar()
        {

            ScrudPlato x = new ScrudPlato();

            return x.LlamarSPRescatar();
        }

    }
}
