using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUDCliente
    {
        public CRUDCliente()
        {

        }

        public ContenedorClientes LlamarSPRescatar(string token)
        {
            ContenedorClientes LClientes = new ContenedorClientes();
            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.CLIENTE.OrderBy(p => p.RUT).ToList();

                    foreach (var item in collection)
                    {
                        Cliente n = new Cliente();
                        n.Rut = item.RUT;
                        LClientes.Lista.Add(n);
                    }
                    LClientes.Retorno.Codigo = 0;
                    LClientes.Retorno.Glosa = "OK";

                }
                catch (Exception)
                {
                    LClientes.Retorno.Codigo = 1011;
                    LClientes.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LClientes.Retorno.Codigo = 100;
                LClientes.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LClientes;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Administrador");
            Perfiles.Add("Empleado");
            if (x.ValidarPerfil(token, Perfiles))
            {
                retorno = true;
            }
            return retorno;
        }

        private bool ValidarFecExp(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            if (x.ValidarFechaExpiracion(token))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
