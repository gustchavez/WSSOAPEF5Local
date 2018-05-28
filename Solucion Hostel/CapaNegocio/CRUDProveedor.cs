using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;
using System.Data.Objects;

namespace CapaNegocio
{
    public class CRUDProveedor
    {
        public CRUDProveedor()
        {

        }

        public ContenedorProveedores LlamarSPRescatar(string token)
        {            
            ContenedorProveedores LProveedores = new ContenedorProveedores();
            if (ValidarPerfilCUD(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.PROVEEDOR.OrderBy(p => p.RUT).ToList();

                    foreach (var item in collection)
                    {
                        Proveedor n = new Proveedor();
                        n.Rut = item.RUT;
                        LProveedores.Lista.Add(n);
                    }
                    LProveedores.Retorno.Codigo = 0;
                    LProveedores.Retorno.Glosa = "OK";

                }
                catch (Exception)
                {
                    LProveedores.Retorno.Codigo = 1011;
                    LProveedores.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LProveedores.Retorno.Codigo = 100;
                LProveedores.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LProveedores;
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
