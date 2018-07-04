using CapaObjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CRUDUsuario
    {
        public CRUDUsuario()
        {

        }

        public ContenedorUsuarios LlamarSPRescatar(string token)
        {
            ContenedorUsuarios LUsuarios = new ContenedorUsuarios();

            if (ValidarFecExp(token))
            {
                try
                {
                    CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                    var collection = conex.USUARIO.OrderBy(p => p.NOMBRE).ToList();

                    foreach (var item in collection)
                    {
                        Usuario n = new Usuario();
                        n.Id          = item.ID;
                        n.Nombre      = item.NOMBRE;
                        n.Clave       = item.CLAVE;
                        n.Perfil      = item.PERFIL;
                        n.Estado      = item.ESTADO;
                        n.RutPersona  = item.RUT_PERSONA;
                        LUsuarios.Lista.Add(n);
                    }

                    LUsuarios.Retorno.Codigo = 0;
                    LUsuarios.Retorno.Glosa = "OK";
                }
                catch (Exception)
                {
                    LUsuarios.Retorno.Codigo = 1011;
                    LUsuarios.Retorno.Glosa = "Err codret ORACLE";
                }
            }
            else {
                LUsuarios.Retorno.Codigo = 100;
                LUsuarios.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return LUsuarios;
        }

        public bool ExisteNomUsuActivo(string nomusu)
        {
            bool existe = false;
            
            try
            {
                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                int cantidad = conex.USUARIO.Where(p => p.NOMBRE == nomusu 
                                                        && p.ESTADO == "activo").Count();
                if (cantidad > 0)
                {
                    existe = true;
                }                    
            }
            catch (Exception)
            {
                existe = false;
            }

            return existe;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Administrador");
            Perfiles.Add("Empleado");
            Perfiles.Add("Proveedor");
            Perfiles.Add("Cliente");
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

