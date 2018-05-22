using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaObjeto;

namespace CapaNegocio
{
    public class CRUDPerfilUsuarioCliente
    {
        
        public CRUDPerfilUsuarioCliente()
        {
        
        }
        
        public ContenedorPerfilUsuarioCliente LlamarSPCrear(ContenedorPerfilUsuarioCliente nPUC)
        {
            if (ValidarPerfilCUD(nPUC.Retorno.Token))
            {
                var p_OUT_CODRET = new ObjectParameter("P_OUT_CODRET", typeof(decimal));
                var p_OUT_GLSRET = new ObjectParameter("P_OUT_GLSRET", typeof(string));

                CapaDato.EntitiesBBDDHostel conex = new CapaDato.EntitiesBBDDHostel();

                conex.SP_CREAR_CLIENTE
                    ( nPUC.Item.Cliente.Rut
                    , nPUC.Item.PerfilUsuario.Empresa.RazonSocial
                    , nPUC.Item.PerfilUsuario.Empresa.Rubro
                    , nPUC.Item.PerfilUsuario.Empresa.Email
                    , nPUC.Item.PerfilUsuario.Empresa.Telefono
                    , nPUC.Item.PerfilUsuario.Empresa.Logo
                    , nPUC.Item.PerfilUsuario.Persona.Rut
                    , nPUC.Item.PerfilUsuario.Persona.Nombre
                    , nPUC.Item.PerfilUsuario.Persona.Apellido
                    , nPUC.Item.PerfilUsuario.Persona.FechaNacimiento
                    , nPUC.Item.PerfilUsuario.Persona.Email
                    , nPUC.Item.PerfilUsuario.Persona.Telefono
                    , nPUC.Item.PerfilUsuario.Direccion.Calle
                    , nPUC.Item.PerfilUsuario.Direccion.Numero
                    , nPUC.Item.PerfilUsuario.Direccion.Comuna
                    , nPUC.Item.PerfilUsuario.Direccion.CodPostal
                    , nPUC.Item.PerfilUsuario.Direccion.NombreCiudad
                    , nPUC.Item.PerfilUsuario.Direccion.CodPais
                    , nPUC.Item.PerfilUsuario.Usuario.Clave
                    , p_OUT_CODRET
                    , p_OUT_GLSRET
                    ) ;
            
                try
                {
                    nPUC.Retorno.Codigo = decimal.Parse(p_OUT_CODRET.Value.ToString());
                    nPUC.Retorno.Glosa = p_OUT_GLSRET.Value.ToString();
                }
                catch (Exception)
                {
                    nPUC.Retorno.Codigo = 1011;
                    nPUC.Retorno.Glosa = "Err codret ORACLE";
                }
            } else {
                nPUC.Retorno.Codigo = 100;
                nPUC.Retorno.Glosa = "Err expiro sesion o perfil invalido";
            }

            return nPUC;
        }

        private bool ValidarPerfilCUD(string token)
        {
            bool retorno = false;
            TokenUsuario x = new TokenUsuario();

            List<string> Perfiles = new List<string>();

            Perfiles.Add("Empleado");
            Perfiles.Add("Administrador");
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
